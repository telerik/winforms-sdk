# 02.02-orders-winforms-api-migration: Resolve Orders source API compatibility and validate the upgraded solution

## Objective
Resolve the actual source compatibility issues against the `net10.0-windows` target established by `02.01-orders-net10-project-setup`, preserve the existing WinForms application/designer behavior, and complete the scenario-required build validation.

## Scope
- `Orders\Program.cs` (6 assessment binary-incompatibility findings)
- `Orders\Form1.cs` (176 binary-incompatibility findings)
- `Orders\Form1.Designer.cs` (582 binary-incompatibility and 34 source-incompatibility findings)
- Other application source files only if target-framework compiler/API diagnostics establish a necessary fix.
- Keep `Form1.cs` and `Form1.Designer.cs` together as one coupled partial form. Do not modify `Form1.resx` or `Properties\AssemblyInfo.cs` unless concrete compatibility evidence requires it.

## Steps
1. Confirm the prerequisite project target/package changes from `02.01-orders-net10-project-setup` are present. Use the assessment reports and target-framework diagnostics to identify actual incompatibilities; do not treat scanner counts alone as required edits.
2. Resolve applicable API errors inline. Keep the existing modern WinForms controls; the source inventory found no `StatusBar`, `DataGrid`, `ContextMenu`, `MainMenu`, legacy `MenuItem`, or `ToolBar` usage, so do not add replacements for absent controls.
3. For the `System.Drawing` findings in the designer, verify the target Windows Forms API surface and make only the changes needed for compatibility. Preserve the form's partial-class, designer, event-handler, and resource relationships.
4. Do not defer compatibility behind stubs or add `// STUB:` markers. Preserve the existing UI behavior and avoid unrelated redesign.
5. Restore and build `Orders.sln` with full Visual Studio MSBuild as required by `scenario-instructions.md`, using the stable .NET SDK pinning approach recorded in the research notes if needed; remove any temporary `global.json` after validation. No tests exist in this solution and the selected test coverage is Skip.

## Done when
All applicable target-framework compatibility issues are resolved inline, no deferred stubs remain, the form/designer/resource associations are intact, and the full solution restore/build completes with zero errors. Record that there are no existing tests to run.

## Verified Research

### Current project and assessment findings

- The working project `Orders\Orders.csproj` is already SDK-style (`Microsoft.NET.Sdk`) and now targets `net10.0-windows`, with `UseWindowsForms=true`, `OutputType=WinExe`, and `GenerateAssemblyInfo=false`. It references `Microsoft.Windows.Compatibility` `11.0.0`; there are no other package references or package replacements. These are the prerequisite changes from `02.01-orders-net10-project-setup`.
- The generated assessment predates those tasks. Its `Orders.csproj` summary still reports `net462`, `SDK-style=False`, `Project.0001`, and `Project.0002`; those project findings are stale. The assessment's 764 `Api.0001` and 34 `Api.0002` findings are still useful as candidate call sites, not proof that each source reference is incompatible. The structured query reports `Api.0003` behavioral findings: 0.
- Structured assessment file results: `Program.cs` has six `Api.0001` findings, all for `System.Windows.Forms.Application` startup calls; `Form1.cs` has 176 `Api.0001` findings; `Form1.Designer.cs` has 582 `Api.0001` and 34 `Api.0002` findings. The sampled `Api.0002` designer findings are `System.Drawing.Font` and its string/size constructors, `FontStyle`, and `ContentAlignment`. The remaining API compatibility decision must be based on target-framework compiler diagnostics.
- Telerik presence gates in the assessment both say not present. No Telerik-specific migration or verification work applies.

### Source and designer inventory

- `Program.cs` calls `Application.EnableVisualStyles`, `Application.SetCompatibleTextRenderingDefault(false)`, then `Application.Run(new Form1())`.
- `Form1.cs` uses ordinary WinForms controls and members, `System.Drawing.Color.LightGray`, LINQ, and the local `Product`/`OrderItem` models. `get_code_dependencies` confirms that `Form1` depends on `OrderItem` and `Product`; the entry point reaches the same form. `get_code_dependencies` was also run for `Form1.Designer.cs`, which is the same `Form1` partial type.
- The form uses `MenuStrip`/`ToolStripMenuItem`, `SplitContainer`, `TreeView`, `TabControl`/`TabPage`, `DataGridView`, `ComboBox`, `ListBox`, `Button`, and `Label`. The in-scope sources contain no `StatusBar`, `DataGrid`, `ContextMenu`, `MainMenu`, legacy `MenuItem`, or `ToolBar` usage; do not replace modern controls based on the assessment's legacy-control feature count.
- `Form1.Designer.cs` contains declarative control creation, property assignments, and method-group event wiring; its `Dispose(bool)` disposes `components` before calling `base.Dispose(disposing)`. Keep this file and `Form1.cs` together and avoid layout or behavior changes.
- `Orders.csproj` retains the `Form1.cs` `SubType=Form` metadata and the `DependentUpon` links from `Form1.Designer.cs` and `Form1.resx` to `Form1.cs`. `Form1.resx` contains only the schema and resource headers, with no `<data>` entries. Do not alter the resource or assembly metadata associations.
- No `// STUB:` markers were found in `Orders` C# files. `Orders.sln` has one project and no test project or test-dependent project; the selected scenario test coverage is Skip. `OrderItem.cs`, `Product.cs`, and `Properties\AssemblyInfo.cs` have no assessment API findings and remain out of scope unless target compiler diagnostics establish a necessary fix.

### Validation research and plan

- Scenario instructions require full Visual Studio MSBuild for this WinForms solution. `validate_dotnet_sdk_installation(net10.0-windows)` found `C:\Program Files\Microsoft Visual Studio\18\Insiders\MSBuild\Current\Bin\MSBuild.exe`.
- Installed SDKs are `10.0.401` and `11.0.100-rc.3.26522.148`; the default `dotnet --version` resolves to the 11.0 preview. Use a temporary `global.json` pin to stable SDK `10.0.401` for the solution restore/build, then remove it. The final validation must be a solution-level restore/build, not only a project build.
- Initial target-framework diagnostic command: `MSBuild.exe Orders.sln /restore /t:Build /p:Configuration=Release /v:minimal`, using the full Visual Studio MSBuild path above and stable SDK `10.0.401`. Exit code `0`; the solution restored and compiled with 0 errors and 90 warnings, all `CA1416`. The warnings are in `Program.cs` (3) and `Form1.cs` (87); the designer and model files have no warnings. The output assembly was produced at `Orders\bin\Release\net10.0-windows\Orders.dll`.
- The `CA1416` warnings say WinForms APIs (`Application`, `BindingSource`, controls, etc.) are supported on Windows 6.1 and later but the call site is reachable on all platforms. MSBuild evaluates `TargetPlatformIdentifier=Windows`, `TargetPlatformVersion=7.0`, and `SupportedOSPlatformVersion=7.0`; however, `Orders.csproj` deliberately sets `GenerateAssemblyInfo=false`, and the generated target-framework attributes contain no assembly-level `SupportedOSPlatform` attribute. This leaves an actionable platform-contract warning, not a missing WinForms API.
- Microsoft documents that the .NET SDK normally emits the assembly-level `SupportedOSPlatform` attribute for platform-specific TFMs, and specifically says that when `GenerateAssemblyInfo=false` the SDK cannot add it; the warning is resolved by enabling generation or adding the attribute manually ([CA1416 guidance](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1416)). Preserve `GenerateAssemblyInfo=false` and the explicit assembly metadata, so the narrow evidence-based fix is a manual assembly-level `[SupportedOSPlatform("windows7.0")]` declaration in `Properties\AssemblyInfo.cs`, matching the evaluated project minimum. This describes the actual Windows-only executable and is not a warning suppression. Do not rewrite the form or designer for the scanner's `System.Drawing` findings: the initial target-framework compile found no errors or warnings there.
- Because this diagnostic establishes a necessary change in `Properties\AssemblyInfo.cs`, it is within the task's conditional allowance for additional application source files. TaskBreaker returned atomic. Adding the manual `SupportedOSPlatform("Windows7.0")` declaration cleared the analyzer warnings without changing `GenerateAssemblyInfo`, the form, or its designer. The final solution restore/build completed with 0 warnings and 0 errors; the output exists under `bin\Release\net10.0-windows`. The temporary SDK pin was removed after validation. Tests were not run because the solution has no test projects.

## Decomposition Assessment

- Loaded scenario Execution guidance from `skills/scenarios/dotnet-version-upgrade/execution.md`, including Sections 0 (assessment consultation), 3 (stub discovery), and 5 (breakdown hints), and evaluated `breakdown-hints/common.md` and `breakdown-hints/framework-migration.md`. The three forwarded task skills contain no additional `## Breakdown Hints` or `## Decomposition Rules` section.
- Common `multi-project-dependency-ordering` and `large-package-replacement-batch` do not match this one-project, zero-replacement scope. Framework `system-web-dependency` and `inprocess-background-jobs` do not match. The `windows-api-isolation` SHOULD hint was evaluated because the scoped source uses Windows Forms and `System.Drawing`; TaskBreaker determined that its split recommendation applies to mixed general/Windows API changes, while this task has only a Windows platform-contract annotation remaining. The task is **atomic**; no subtasks were created.
- No stub-resolution trigger exists, and the test hint is not applicable because the solution has no test project or test-dependent project.

## Behavioral API review

- **Underlying change / affected scope:** no `Api.0003` change is reported for `Orders.csproj`; the candidate source scope is the WinForms entry point and `Form1` partial class.
- **Documentation:** not applicable—there is no behavioral API rule instance in the generated assessment to research.
- **Local evidence and disposition:** the assessment summary reports zero behavioral findings. The only source edit is the assembly-level Windows platform contract in `Properties\AssemblyInfo.cs`, justified by CA1416 and matching the evaluated Windows 7.0 target; it does not change application startup or form behavior. Disposition: no behavioral API change applies.
- **Checks / remaining user check:** the final solution restore/build completed with 0 warnings and 0 errors. No runtime UI smoke check was performed; a user-side launch/interaction check remains unverified because no GUI runtime test was run.
