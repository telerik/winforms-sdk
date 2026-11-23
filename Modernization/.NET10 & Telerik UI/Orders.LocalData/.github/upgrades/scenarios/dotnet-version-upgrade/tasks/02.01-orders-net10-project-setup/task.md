# 02.01-orders-net10-project-setup: Retarget Orders and add the selected compatibility package

## Objective
Prepare the already SDK-style Orders project for migration against .NET 10 Windows APIs. This is the prerequisite for resolving the source API findings in the following subtask.

## Scope
- `Orders\Orders.csproj`
- `Orders\app.config` only to review the existing .NET Framework `supportedRuntime` declaration for relevance; do not treat it as the project TFM.

## Steps
1. Change the project target from `net462` to `net10.0-windows`, retaining WinForms support and the existing application/project settings.
2. Add the selected `Microsoft.Windows.Compatibility` `PackageReference` at stable version `11.0.0`. Do not add a package replacement or unrelated packages.
3. Preserve the existing `Form1` subtype and `DependentUpon` metadata, `GenerateAssemblyInfo=false`, explicit assembly metadata behavior, and other settings identified in the research notes.
4. Review the `supportedRuntime` entry in `Orders\app.config` in the context of a .NET 10 executable; retain or adjust it only as justified, and do not use it to configure the TFM.
5. Restore the solution with the scenario-required Visual Studio MSBuild and confirm the target/package configuration restores. Defer the full build until the source-compatibility subtask is complete, since the current source still targets the old API surface.

## Done when
`Orders.csproj` targets `net10.0-windows`, the selected package reference restores, relevant project metadata is preserved, and any `app.config` disposition is justified. No application API source files are changed in this setup subtask.

## Verified Research

- **Actual project state:** `Orders\Orders.csproj` is already SDK-style (`<Project Sdk="Microsoft.NET.Sdk">`) and currently targets `net462`. The assessment still labels it non-SDK-style and reports `Project.0001`; that finding is stale after task `01-orders-sdk-style-conversion`. The active project-level finding is `Project.0002`, which recommends `net10.0-windows`. The project-level assessment reports 764 binary-incompatible API findings and 34 source-incompatible findings; those source/API fixes are explicitly deferred to the following subtask. No `Api.0003` behavioral findings were reported.
- **Project configuration to preserve:** `OutputType=WinExe`, `GenerateAssemblyInfo=false`, `UseWindowsForms=true`, `ImportWindowsDesktopTargets=true`, `PlatformTarget=AnyCPU`, `Prefer32Bit=false`, and the Debug/Release `DebugType` values are set in `Orders.csproj`. The existing `Compile` metadata associates `Form1.cs` with its form subtype and `Form1.Designer.cs` with `Form1.cs`; `Form1.resx` is also associated with `Form1.cs`. `Properties\AssemblyInfo.cs` contains explicit assembly title/description/version, COM visibility, and GUID attributes, so `GenerateAssemblyInfo=false` must remain. These are all preserved; no application API source is in scope.
- **Dependencies and package management:** the project dependency query returned no local MSBuild imports or existing packages; `Orders.csproj` has no `PackageReference`. A repository scan found no `Directory.Build.props`, `Directory.Build.targets`, `Directory.Packages.props`, or `NuGet.Config`, so use a direct `PackageReference` in this project, not CPM. Scenario choice is Windows Compatibility Pack; `get_supported_package_version` returned stable `Microsoft.Windows.Compatibility` `11.0.0` for `net10.0-windows`.
- **`app.config` disposition:** the file contains only `<startup><supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.2"/>`. Microsoft documents `supportedRuntime` as the CLR/.NET Framework SKU selector, while modern .NET generates `<appname>.runtimeconfig.json` for the application from its SDK project. The modernize guidance says to remove `App.config` when it contains no remaining settings after migration. A source scan found no `ConfigurationManager`, `System.Configuration`, or app-settings usage, and no other configuration entries exist; therefore remove this obsolete Framework-only file. It is not a TFM source.
  - References: [supportedRuntime element](https://learn.microsoft.com/en-us/dotnet/framework/configure-apps/file-schema/startup/supportedruntime-element), [.NET runtime config](https://learn.microsoft.com/en-us/dotnet/core/runtime-config/), [Modernize after upgrading to .NET — App.config](https://learn.microsoft.com/en-us/dotnet/core/porting/modernize#appconfig).
- **Restore/build tool:** scenario instructions require Visual Studio MSBuild for this WinForms project. `validate_dotnet_sdk_installation(net10.0-windows)` found a compatible SDK and selected `C:\Program Files\Microsoft Visual Studio\18\Insiders\MSBuild\Current\Bin\MSBuild.exe`. Run solution restore with that MSBuild. Per this setup subtask's validation scope, defer compilation until the following source-compatibility task; do not treat restore as a build.
- **Stub/test inventory:** no `// STUB:` markers were found in project C# files. The solution contains one project and no project dependencies/dependants; no test project or test-dependent project is present in scope.

## Decomposition Assessment

- Loaded scenario Execution guidance from `skills/scenarios/dotnet-version-upgrade/execution.md` and the applicable hint files `breakdown-hints/common.md` and `breakdown-hints/framework-migration.md`.
- The Windows API isolation hint is relevant to the overall migration (WinForms/System.Drawing are present), but this task is only the focused TFM/package setup; source API fixes are already separated into the following task. Multi-project ordering, large package replacement, System.Web, background-job, and stub-resolution triggers do not apply. This is one coherent project-configuration change; verdict: **atomic**, no TaskBreaker escalation.
