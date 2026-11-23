# 02-orders-net10-winforms: Upgrade Orders WinForms APIs to .NET 10

After the SDK-style conversion, retarget `Orders.csproj` from `net462` to `net10.0-windows` and address the compatibility work identified by the assessment. It flags 764 binary-incompatible and 34 source-incompatible APIs, including 96 legacy WinForms-control issues and 34 GDI+/`System.Drawing` issues. Use the project report and complete API-issue report as research starting points, with particular attention to removed controls such as `StatusBar`, `DataGrid`, `ContextMenu`, `MainMenu`, `MenuItem`, and `ToolBar`.

Resolve the API changes inline rather than deferring them behind stubs, preserve the WinForms designer/resources, and include the selected `Microsoft.Windows.Compatibility` package. The assessment found no existing NuGet packages or package compatibility issues.

**Done when**: `Orders.csproj` targets `net10.0-windows`, the flagged API changes are resolved without deferred stubs, `Orders.sln` restores and builds with zero errors, and any applicable existing tests pass.

## Verified Research (before source changes)

### Project state and actual scope

- Read `assessment/projects/Orders.md` and the complete 178-line `assessment/api-issues/most-frequent-api-issues.md`, and queried the structured assessment for the `Orders.csproj` summary, issue-bearing files, and API findings.
- The assessment was generated before task `01-orders-sdk-style-conversion`: it still reports `SDK-style=False` and includes `Project.0001` (project-format conversion). The working tree and task 01's recorded build evidence show that conversion is already complete. The current `Orders\Orders.csproj` uses `<Project Sdk="Microsoft.NET.Sdk">`, still targets `net462`, and retains `UseWindowsForms=true`, `OutputType=WinExe`, `GenerateAssemblyInfo=false`, `ImportWindowsDesktopTargets=true`, `PlatformTarget=AnyCPU`, and `Prefer32Bit=false`. Do not repeat the conversion; this task owns the remaining TFM and API work.
- `Orders.sln` contains exactly one project, `Orders\Orders.csproj`, with no project dependants. The dependency query reported no local imported targets or package dependencies. There is no `Directory.Build.props`, `Directory.Packages.props`, `packages.config`, or `global.json`; package versions therefore belong on the project `PackageReference`.
- The assessment's 800 findings break down as `Project.0001` and `Project.0002`, 764 `Api.0001` binary-incompatible findings, and 34 `Api.0002` source-incompatible findings. The active project/API scope is therefore one TFM finding plus 798 API findings; the old `Project.0001` is already resolved.
- Issue-bearing files reported by the structured assessment: `Program.cs` (6 `Api.0001`), `Form1.Designer.cs` (582 `Api.0001` and 34 `Api.0002`), and `Form1.cs` (176 `Api.0001`), plus the stale project-format and active TFM findings in `Orders.csproj`.

### Source, controls, designer, and resources

- The project has six C# files: `Form1.cs`, `Form1.Designer.cs`, `OrderItem.cs`, `Product.cs`, `Program.cs`, and `Properties\AssemblyInfo.cs`. `get_code_dependencies` for `Form1.cs` confirms its application-layer dependencies are only `OrderItem` and `Product`.
- The application already uses modern WinForms controls (`MenuStrip`, `ToolStripMenuItem`, `SplitContainer`, `TreeView`, `TabControl`, `DataGridView`, `Button`, `ComboBox`, `Label`, and `ListBox`). A source search found no `StatusBar`, `DataGrid`, `ContextMenu`, `MainMenu`, legacy `MenuItem`, or `ToolBar` references. The assessment's 96 “Windows Forms Legacy Controls” feature findings are not evidence that these removed controls occur in this source; do not introduce replacements for controls that are absent.
- GDI+/`System.Drawing` use is confined to ordinary WinForms rendering: `Color.LightGray` in `Form1.cs`, and `Font`, `FontStyle.Bold`, `ContentAlignment.MiddleRight`, `Point`, and `Size` in the designer. The 34 `Api.0002` findings are in `Form1.Designer.cs`; sampled findings include `Font` and its string/size constructors, `FontStyle`, and `ContentAlignment`. Verify compatibility against the target WinForms reference assemblies and make any necessary changes inline rather than adding stubs.
- Preserve `Form1.cs`/`Form1.Designer.cs` partial-class and event-handler relationships. `Orders.csproj` currently declares the `Form1` subtype and `DependentUpon` metadata using SDK-style `Update` items. `Form1.resx` is an XML schema/header file with no `<data>` entries or embedded images/icons; keep its `EmbeddedResource`/`DependentUpon` association. `Properties\AssemblyInfo.cs` contains explicit assembly metadata and `GenerateAssemblyInfo=false` prevents duplicate SDK attributes.
- `Orders\app.config` still declares `.NETFramework,Version=v4.6.2` in a `supportedRuntime` element. Review its relevance to the .NET 10 executable during the migration; do not mistake it for a TFM definition.
- No `// STUB:` markers exist in the project's C# files. No tests are present in the one-project solution, and scenario instructions select `Test Coverage: Skip`.

### Packages, build, and assessment disposition

- The assessment's NuGet report lists no existing packages or package compatibility issues. The Windows Compatibility Pack selection calls for adding `Microsoft.Windows.Compatibility`; `get_supported_package_version` for `net10.0-windows` returned stable version `11.0.0`. No package replacement is involved.
- The assessment reports 0 behavioral (`Api.0003`) changes. The structured API report groups the binary-incompatible items under WinForms and source-incompatible items under GDI+/`System.Drawing`; compilation on the target framework is required to distinguish actual API changes from framework-identity findings. Resolve any real compiler errors inline, preserve the UI, and do not claim scanner counts alone prove migration.
- Use full Visual Studio MSBuild for the Windows Forms solution validation as required by `scenario-instructions.md`. Task 01 recorded the stable .NET SDK `10.0.401`, a temporary `global.json` pin for final validation, and MSBuild at `C:\Program Files\Microsoft Visual Studio\18\Insiders\MSBuild\Current\Bin\MSBuild.exe`; that MSBuild path is present in the current environment (version `18.12.2.51402`). The default SDK resolver also sees `11.0.100-rc.3.26522.148`, so use the same stable-SDK pinning approach for final validation and remove the temporary pin afterward.
- Task 01's recorded whole-solution restore/build passed on `net462`; it is baseline evidence only, not validation of the new TFM. Final validation must restore/build `Orders.sln` on `net10.0-windows`; no existing tests are available to run.

## Decomposition assessment

- Loaded scenario Execution guidance from `skills/scenarios/dotnet-version-upgrade/execution.md`, including Sections 0 (assessment consultation), 3 (stub discovery), and 5 (breakdown hints), plus `breakdown-hints/common.md` and `breakdown-hints/framework-migration.md`.
- The core decomposition rule matches because the requested scope is the entire WinForms project, including project retargeting and hundreds of API findings. The `windows-api-isolation` hint condition also matches: this task combines general .NET API work with Windows-specific WinForms/`System.Drawing` work. `multi-project-dependency-ordering`, `large-package-replacement-batch`, `system-web-dependency`, and `inprocess-background-jobs` do not match the verified scope. No stub-resolution trigger exists. The test hint is not applicable because there is no test project or test-dependent project.
- Escalate to TaskBreaker before any source edit. TaskBreaker determines whether the task is atomic and, if not, authors/registers the breakdown; this research does not prescribe subtask boundaries.

## Behavioral API review

- No `Api.0003` behavioral-change findings were reported by the assessment. There is no behavioral API notice requiring a code change or a targeted test under this finding set. The test-suite scope is empty; a UI smoke check remains unverified unless performed during execution.
