# 01-orders-sdk-style-conversion: Convert Orders.csproj to SDK-style

Prepare the sole in-scope project for the framework upgrade by converting its non-SDK-style `net462` project definition while retaining the existing target framework. The assessment identifies `Orders.csproj` as a classic WinForms project with no project dependencies, no NuGet packages, and no package compatibility issues. Confirm the required .NET SDK/toolchain and `global.json` compatibility, and review legacy imports, references, form resources, and designer metadata so the structural conversion preserves the existing application.

Keep this project-format conversion separate from the TFM and API upgrade; the Framework migration guidance treats them as distinct changes with different failure modes.

**Done when**: `Orders.csproj` uses SDK-style format while still targeting `net462`, its existing forms and resources remain included, and the project restores and builds successfully on that target.

## Verified Research (before source changes)

### Project scope and dependency state

- The only project in `Orders.sln` is `Orders\Orders.csproj`. The required topological-order tool returned this single project; the assessment graph reports no project dependencies or dependants.
- The project currently targets `.NETFramework,Version=v4.6.2` (`TargetFrameworkVersion` `v4.6.2`), builds a `WinExe`, and uses the `Orders` root namespace and assembly name.
- `get_project_dependencies` found only framework assembly references: `System`, `System.Core`, `System.Data`, `System.Drawing`, `System.Windows.Forms`, and `System.Xml`. It reported no project/package references or local imported targets. The assessment's NuGet report is empty, and there is no `packages.config`.
- Preserve this as a project-format-only change. The selected destination TFM (`net10.0-windows`) and API fixes belong to later tasks.

### Legacy project structure and application assets

- The classic project imports `Microsoft.Common.props` and `Microsoft.CSharp.targets`; these are legacy imports to be handled by the SDK conversion tool.
- The project explicitly lists `Form1.cs`, `Form1.Designer.cs`, `OrderItem.cs`, `Product.cs`, `Program.cs`, and `Properties\AssemblyInfo.cs`; `Form1.Designer.cs` has `DependentUpon=Form1.cs`. It also lists `app.config` as `None`.
- `Form1.cs` calls `InitializeComponent`; the partial class and designer file contain the controls and event handlers. Preserve both source files and the designer nesting metadata.
- `Form1.resx` exists on disk but is not explicitly listed in the old project. Its content is schema/resheaders only (no `<data>` entries or embedded images/icons), and the designer does not call `ComponentResourceManager` or `ApplyResources`. Verify the converted project includes the resource file without losing any form assets.
- `Properties\AssemblyInfo.cs` contains explicit assembly attributes. Check that the conversion prevents duplicate generated assembly attributes while retaining those values. Keep `app.config` and its .NET Framework 4.6.2 startup declaration unchanged.
- Existing project properties also include automatic binding redirects, deterministic compilation, Debug/Release configuration settings, and `Prefer32Bit=false`; inspect the converter output and preserve relevant behavior.

### Assessment findings and scope disposition

- Sources consulted: `assessment/projects/Orders.md`, `assessment/project-graph.md`, `assessment/nuget/aggregate-packages.md`, and the structured assessment query for `Orders.csproj`.
- The structured project summary reports 800 findings: `Project.0001` (SDK-style conversion) is in this task; `Project.0002` (TFM change) is deferred; 764 binary-incompatible API findings and 34 source-incompatible API findings in `Program.cs`, `Form1.cs`, and `Form1.Designer.cs` are deferred to the TFM/API tasks. There are no behavioral API findings (`Api.0003`), packages, or package actions.
- The project is detected as Classic WinForms with Windows Forms, Windows Forms Legacy Controls, and GDI+/System.Drawing. Telerik WinForms and WPF are absent per the assessment presence gates. No `// STUB:` markers were found in project C# sources.
- No test project is in the sole-project solution; the scenario's test-coverage preference is `Skip`. Build/restore is the validation gate for this task.

### Toolchain, conversion, and validation plan

- No `global.json` exists at the repository root or in its parent chain. `validate_dotnet_sdk_in_globaljson` reported no configuration to validate; `validate_dotnet_sdk_installation` found a compatible SDK for the scenario target `net10.0-windows`.
- `dotnet --list-sdks` reports SDK `10.0.401` and `11.0.100-rc.3.26522.148`; with no `global.json`, `dotnet --version` resolves to the 11.0 RC. The validated Visual Studio MSBuild is `C:\Program Files\Microsoft Visual Studio\18\Insiders\MSBuild\Current\Bin\MSBuild.exe`.
- Use `convert_project_to_sdk_style` (not a hand-written project rewrite), one project at a time. After conversion, verify SDK-style format, unchanged `net462`, preserved form/designer/resource/app.config/assembly metadata, and the unchanged solution reference.
- Use the validated Visual Studio MSBuild for the project restore/build because this is a `net462` WinForms project with designer-generated resources. Run a direct project restore/build and the scenario's solution-level validation, inspect all warnings, and verify the resulting `Orders.exe` under the Debug output directory. There are no tests to run.

### Converter-output review

- The conversion tool produced `Microsoft.NET.Sdk` format with `TargetFramework=net462`, `OutputType=WinExe`, `UseWindowsForms=true`, `ImportWindowsDesktopTargets=true`, and `GenerateAssemblyInfo=false`. Evaluation confirms the six existing `.cs` files are included, `Form1.resx` is an `EmbeddedResource`, and `app.config` remains a `None` item. The solution still references `Orders\Orders.csproj`.
- The SDK default output is `bin\{Configuration}\net462\`; `RootNamespace`/`AssemblyName` still evaluate to `Orders`. SDK defaults also preserve deterministic output, automatic binding redirects, `Prefer32Bit=false`, and the old `Optimize` values.
- The SDK default `DebugType=portable` differs from the original Debug `full` and Release `pdbonly` settings. Keep the existing per-configuration symbol modes; the Release-only `RELEASE` constant has no `#if RELEASE` use in the current C# sources.
- Debug builds succeeded, but the default resolver selected .NET SDK `11.0.100-rc.3` and printed the informational `NETSDK1057` preview-SDK message. A process-level `MSBuildSDKsPath` override did not change the SDK resolver; do not count that invocation as validation under SDK 10. The stable SDK `10.0.401` is installed; temporarily pin that version with `global.json` for stable-SDK validation, then remove the temporary file so the repository remains without a version pin.
- Evaluation under the stable SDK showed `PlatformTarget=x86` in both Debug and Release, whereas the old project explicitly targeted `AnyCPU`. This would change executable architecture, so restore `PlatformTarget=AnyCPU` in the converted project before final validation.
- The conversion tool removed the old `SubType=Form` and `DependentUpon=Form1.cs` metadata. Preserve the form/designer relationship with SDK-style `Update` items (rather than duplicate `Include` items); keep the now-implicit `Form1.resx` resource associated with the form. `Form1.resx` parses to zero resource data entries, and the designer source does not load it through `ComponentResourceManager`.

## Behavioral API review

No `Api.0003` behavioral-change findings were reported for this project. The 34 `Api.0002` source-incompatible findings are API migration items for later tasks, not behavioral notices or SDK-style conversion changes.
