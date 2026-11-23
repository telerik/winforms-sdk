# Breakdown Context — 01-orders-sdk-style-conversion

## Research scope

- Task scope is the structural conversion of the single project `Orders\Orders.csproj`, retaining `net462`.
- The topological-order tool returned one project. Assessment and evaluated MSBuild dependency data show no project-to-project dependencies or dependants, no NuGet packages, and no package replacement work.
- The project is a classic WinForms application. Its existing form, designer, empty `.resx`, `AssemblyInfo.cs`, and `app.config` are reviewed in the task's verified research notes.
- The assessment's TFM/API findings are explicitly outside this task; later tasks own the framework retarget and API migration.

## Execution guidance and hints evaluated

- Scenario Execution stage: `skills/scenarios/dotnet-version-upgrade/execution.md`, Sections 1 (SDK-style conversion), 3 (stub discovery), and 5 (breakdown hints).
- Breakdown Hints loaded: `breakdown-hints/common.md` and `breakdown-hints/framework-migration.md`, the applicable flavors for this task.
- Common `multi-project-dependency-ordering`: not triggered; only one project and no dependency chain.
- Common `large-package-replacement-batch`: not triggered; assessment reports zero packages.
- Framework `system-web-dependency`: not triggered; project is WinForms and no `System.Web` reference or usage was found.
- Framework `windows-api-isolation`: WinForms/System.Drawing are present, but this is a project-format-only task; the TFM/API and Windows compatibility work is already separated into later tasks. No additional split is needed here.
- Framework `inprocess-background-jobs`: not triggered; no web/console scheduled or background job pattern is in scope.
- Stub discovery: no `// STUB:` markers were found in project C# sources.
- Test hint: not loaded; the solution has no test project or test-dependent project in this task's scope.

## Verdict

**Atomic.** This is one coherent conversion of one project file with validation immediately after conversion. The scenario's conversion guidance keeps one to three project conversions in one task, and no core decomposition trigger or loaded hint requires a split. TaskBreaker was not needed.

---

# Breakdown Context — 02-orders-net10-winforms

## Research scope

- The only solution project is `Orders\Orders.csproj`; there are no project dependencies or dependants. The current project is already SDK-style from task `01-orders-sdk-style-conversion`, but still targets `net462`. The assessment is pre-conversion and its `Project.0001` finding is stale; TFM and API work remain.
- Structured assessment findings: 800 total, including the resolved `Project.0001`, active `Project.0002`, 764 `Api.0001` binary-incompatible findings, and 34 `Api.0002` source-incompatible findings. Findings are located in `Orders.csproj`, `Program.cs`, `Form1.Designer.cs` (582 binary and 34 source-incompatible), and `Form1.cs` (176 binary-incompatible). The complete API report is `assessment/api-issues/most-frequent-api-issues.md`.
- The source inventory is six C# files: `Form1.cs`, `Form1.Designer.cs`, `OrderItem.cs`, `Product.cs`, `Program.cs`, and `Properties\AssemblyInfo.cs`. `Form1` depends only on `OrderItem` and `Product`. The project has no package references/CPM setup, no test project/dependent, and no `// STUB:` markers.
- Current UI uses modern controls, including `DataGridView`, `MenuStrip`, and `ToolStripMenuItem`; a case-insensitive source search found none of the named removed controls (`StatusBar`, `DataGrid`, `ContextMenu`, `MainMenu`, legacy `MenuItem`, `ToolBar`). `Form1.resx` has no `<data>` resources; retain the designer/resource association and explicit assembly metadata.
- Windows Compatibility Pack selection requires adding `Microsoft.Windows.Compatibility`; the package-version lookup for `net10.0-windows` returned `11.0.0`. No package replacement is involved.
- `Form1.Designer.cs` contains the 34 GDI+/`System.Drawing` source findings (`Font` and constructors, `FontStyle`, `ContentAlignment`); real changes should be established by target-framework compilation and fixed inline. No `Api.0003` behavioral findings exist.
- The project report and full API report, structured project summary/file/issue queries, project dependency query, and `get_code_dependencies(Form1.cs)` were consulted. `task.md` contains the complete verified inventory, package/build facts, and issue disposition.

## Execution guidance and hints evaluated

- Scenario Execution stage: `skills/scenarios/dotnet-version-upgrade/execution.md`, including Sections 0 (assessment consultation), 3 (stub discovery), and 5 (breakdown hints).
- Breakdown Hints loaded: `breakdown-hints/common.md` and `breakdown-hints/framework-migration.md`, the applicable project flavors.
- Common `multi-project-dependency-ordering`: not triggered; the solution has one project and no dependency chain.
- Common `large-package-replacement-batch`: not triggered; no existing packages require replacement.
- Framework `system-web-dependency`: not triggered; this is a WinForms application without `System.Web`.
- Framework `windows-api-isolation`: condition matches because the task combines .NET API/TFM changes with Windows-specific WinForms and `System.Drawing` usage. This match, together with the task's project-wide scope, requires escalation for decomposition assessment.
- Framework `inprocess-background-jobs`: not triggered; no web/console host or background-job pattern is in scope.
- Stub resolution: not triggered; no `// STUB:` markers were found.
- Test hint: not loaded; the solution has no test project or test-dependent project.

## Decomposition verdict

**Escalated to TaskBreaker before source edits.** This is a full-project compatibility task (retargeting plus 798 API findings across project, application, and designer files), and the loaded `windows-api-isolation` hint condition matches. TaskBreaker must decide atomicity and register any subtasks; no split has been designed here.

## Breakdown Decisions

### task: 02-orders-net10-winforms
- Broken into 2 subtasks based on core dependency trigger 3, with `windows-api-isolation` as supporting hint.
- Retargeting/configuring the project establishes the `net10.0-windows` API surface required to resolve the application findings; the source-compatibility subtask depends on that project state.
- Kept `Form1.cs` and `Form1.Designer.cs` together because they form one coupled partial WinForms form. Common multi-project/package-replacement hints did not fire, and no forwarded task-related skill contained a breakdown-hint section.

## Breakdown Context — 02.01-orders-net10-project-setup

### Research scope

- This subtask changes one project configuration (`Orders\Orders.csproj`) and reviews the existing `Orders\app.config`; it does not migrate application API source.
- The project is already SDK-style and targets `net462`; the assessment's `Project.0001`/non-SDK-style classification is stale after task `01-orders-sdk-style-conversion`. `Project.0002` is the active framework finding. Assessment API findings (764 binary-incompatible and 34 source-incompatible) remain assigned to the following source-compatibility task.
- There is one solution project, no project references/dependants, no existing package references, no CPM/central build files, and no `// STUB:` markers. The selected `Microsoft.Windows.Compatibility` `11.0.0` version was returned for `net10.0-windows`.
- Preserve WinForms settings, form/resource `DependentUpon`/`SubType` metadata, `GenerateAssemblyInfo=false`, explicit `Properties\AssemblyInfo.cs` attributes, and all other current project properties.
- `app.config` contains only the .NET Framework 4.6.2 `supportedRuntime` declaration; the source has no configuration API usage. Microsoft documents this selector for .NET Framework and modern .NET runtime configuration via generated `runtimeconfig.json`; the obsolete config file is therefore removed.

### Execution guidance and hints evaluated

- Scenario Execution stage: `skills/scenarios/dotnet-version-upgrade/execution.md`, Sections 0 (assessment), 3 (stub discovery), and 5 (breakdown hints).
- Loaded `breakdown-hints/common.md` and `breakdown-hints/framework-migration.md`; no web, test, or other project flavor applies.
- Common `multi-project-dependency-ordering`: not triggered; the task changes one project with no dependencies. `large-package-replacement-batch`: not triggered; there are no existing package replacements.
- Framework `windows-api-isolation`: WinForms/System.Drawing is present, but this subtask is only TFM/package setup and the API work is already in a separate following task. No further split is needed. `system-web-dependency` and `inprocess-background-jobs` are not triggered.
- Stub resolution: not triggered. Test hint: not loaded because there is no test project or test-dependent project in scope.

### Decomposition verdict

**Atomic.** Retargeting one project and adding its selected compatibility package form one prerequisite configuration change; restore is the immediate validation gate, while source compatibility is already sequenced separately. No TaskBreaker escalation.

---

# Breakdown Context — 02.02-orders-winforms-api-migration

## Research scope

- The task is limited to target-framework source compatibility in the sole project `Orders\Orders.csproj`, after the prerequisite setup task. The current project is SDK-style, targets `net10.0-windows`, uses WinForms, and references `Microsoft.Windows.Compatibility` `11.0.0`.
- Structured assessment data is stale for project format and TFM: it still reports `Project.0001` and `Project.0002` from the pre-upgrade `net462` snapshot. It reports 764 `Api.0001` findings and 34 `Api.0002` findings across `Program.cs`, `Form1.cs`, and `Form1.Designer.cs`; sampled source-incompatibility findings are `Font`, `FontStyle`, and `ContentAlignment`. The compiler must establish whether any require source changes.
- `get_code_dependencies` was run for all three task files. `Program` starts `Form1`; the form and designer are the same partial class and depend on local `OrderItem`/`Product` types. The form/designer pair is coupled and must remain together.
- The project uses modern WinForms controls; no removed legacy control names were found. Existing `Form1` form/designer/resource metadata is intact, and `Form1.resx` has no data resources. No stubs or test projects/dependants exist.
- The initial solution restore/build on SDK `10.0.401` produced 0 errors and 90 `CA1416` warnings (3 in `Program.cs`, 87 in `Form1.cs`). Project platform properties identify Windows 7.0, but `GenerateAssemblyInfo=false` means the assembly-level supported-platform annotation is not emitted. Microsoft documents a manual attribute as the supported fix; this diagnostic makes `Properties\AssemblyInfo.cs` the one conditional out-of-scope source file that may need a targeted edit. No actual WinForms or `System.Drawing` compile error was observed.

## Execution guidance and hints evaluated

- Loaded `skills/scenarios/dotnet-version-upgrade/execution.md`, Sections 0, 3, and 5, plus `breakdown-hints/common.md` and `breakdown-hints/framework-migration.md`. The forwarded build/WinForms/designer skills contain no decomposition section.
- Common multi-project dependency ordering and large package replacement do not apply. Framework System.Web and background-job hints do not apply. The `windows-api-isolation` SHOULD hint's detection condition matches because the source uses WinForms/System.Drawing, but its split recommendation applies when general and Windows-specific API changes coexist. The target-framework diagnostic found no general API incompatibilities; only CA1416 platform-contract warnings remain, with one evidence-based Windows support annotation proposed. The task therefore contains one Windows-specific compatibility concern, not two concerns to isolate. No other SHOULD hint fires.
- No stub-resolution or test-decomposition trigger applies.

## Decomposition verdict

**Atomic.** The remaining change is a single Windows platform-contract annotation in existing assembly metadata, followed by the required solution build. The candidate API findings compile, the form/designer remain coupled, and there is no independent general-API work or validation gate that warrants another task.

## Breakdown Decisions

### task: 02.02-orders-winforms-api-migration
- Kept atomic; `windows-api-isolation` was evaluated but its recommendation to separate mixed general and Windows-specific API work does not apply to this Windows-only remaining scope.
