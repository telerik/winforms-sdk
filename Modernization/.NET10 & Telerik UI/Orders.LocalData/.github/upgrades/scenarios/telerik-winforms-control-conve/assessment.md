# Telerik WinForms Control Conversion Assessment

## Solution Summary
- **Solution**: `C:\Modernization Tests\.NET Upgrade & Conversion\Run 1 - Luna 6\Orders.LocalData\Orders.sln`
- **Workspace boundary**: `C:\Modernization Tests\.NET Upgrade & Conversion\Run 1 - Luna 6\Orders.LocalData`
- **WinForms Projects**: 1
- **Starting State**: Greenfield adoption — `telerik_analyze_project` found no Telerik references and `hasAllControlsPackage` is `false`.
- **Build command**: `dotnet build "C:\Modernization Tests\.NET Upgrade & Conversion\Run 1 - Luna 6\Orders.LocalData\Orders.sln"` (not run during assessment).

## Migration Playbook (`telerik_get_migration_plan`)
- **Workflow**:
  0. Ensure project is under source control; recommend committing before migration. The converter creates a `.bak` for every file it modifies when `dryRun` is off.
  1. Analyze project with `telerik_analyze_project`.
  2. Add Telerik references with `telerik_add_package_reference` when required.
  3. Convert each form/user-control pair one at a time, build, and fix errors after each pair.
  4. Run a final build and fix remaining cross-form errors.
  5. Apply the theme with `telerik_get_theme_setup`.
  6. Run a final verification build.
- **Per-class loop**:
  1. Convert `FormName.Designer.cs` first (contains control declarations)
  2. Convert `FormName.cs` immediately after (contains event handlers)
  3. Review the 'itemsToReview' array in the conversion output — these are properties/events the converter removed because they have no direct Telerik equivalent. Call the `telerik_winforms_assistant` tool to ask whether Telerik alternatives exist and how to apply them. Not all items will have alternatives. Call the assistant one item at a time — do NOT batch multiple calls in parallel.
  4. Run 'dotnet build' to check for errors (for Classic-style .NET Framework projects when the conversion is performed outside of Visual Studio, use VS MSBuild instead — see `errorHandling.classicProjectBuild`)
  5. Fix ONLY errors in the files you just converted — ignore errors in files not yet converted
  6. Repeat build-and-fix until the converted files are error-free
  8. Only then move to the next form/control class
- **Full-project workflow**:
  1. Analyze project and identify all forms/user controls.
  2. Add Telerik references to `.csproj` and run `dotnet restore`.
  3. For each form/control class: convert Designer first, then code-behind; build and fix that pair; move to the next class.
  4. After all forms are converted, run a full build and fix cross-form errors.
  5. Apply theme setup.
  6. Run a final verification build.
- **Critical rules**:
  - This plan covers ONLY the migration from standard Microsoft WinForms controls to Telerik UI. If the project already uses Telerik UI for WinForms and the user wants to move to a newer Telerik version, stop and call `telerik_upgrade_assistant` instead — it reports the breaking API changes between the two versions.
  - When calling `telerik_analyze_project`, pass the `.csproj` path visible in the workspace or solution root. Do NOT search the file system for `.csproj` files — if the path is wrong the tool will ask the user for the correct one.
  - ALWAYS use `telerik_convert_file` for ANY `.cs` or `.vb` file changes - NEVER edit WinForms code manually
  - Run `telerik_analyze_project` and `telerik_add_package_reference` only ONCE at the start of the conversion session. If they have already been called (e.g. when converting a previous form), skip them and go straight to `telerik_convert_file`.
  - NEVER run `telerik_convert_file` with `dryRun` set to True unless the user has explicitly asked for a dry run
  - When `dryRun` is True, the tool returns a list of changes WITHOUT modifying the file. You MUST then immediately apply every returned change to the source file one by one — do NOT just report the changes to the user and stop. The conversion is not complete until all changes are written to the file. NEVER tell the user to 're-run with dryRun=false' — that defeats the purpose of dry run mode.
  - Each change in the dryRun response includes the exact `lineNumber`, `originalSourceLine`, and `convertedSourceLine`. Use the line numbers to locate each change in the file and replace the `originalSourceLine` with the `convertedSourceLine`. Apply all changes first, then build and fix any compilation errors afterward.
  - NEVER create stub classes like `public class RadButton : Button { }`
  - Use `Telerik.UI.for.WinForms.AllControls` NuGet - no framework suffix
  - DO NOT call the `telerik_add_package_reference` tool if the `Telerik.UI.for.WinForms.AllControls` NuGet is installed
  - Do NOT guess package names - always use `telerik_add_package_reference` tool
  - After installing a NuGet package run `dotnet restore`
  - Do NOT attempt manual control mappings - the converter has the complete mapping database
  - NEVER rename field or variable names — only the type changes. For example, 'private ToolStripMenuItem fileToolStripMenuItem' becomes 'private RadMenuItem fileToolStripMenuItem' — the field name 'fileToolStripMenuItem' stays exactly the same. Apply changes exactly as returned by the converter without any additional renaming.
  - Convert ONE class at a time - do NOT batch all Designer files then all the corresponding `.cs` files
  - After converting a form pair (Designer.cs + .cs), BUILD and FIX errors before moving to the next form
  - When fixing post-conversion errors, ONLY fix errors in files you have already converted — IGNORE errors in unconverted files (they will be resolved when those files are converted)
  - Do NOT manually edit a `.cs` or `.vb` file to fix errors that the converter should handle — if a type or property mapping is wrong, report it rather than manually patching
  - Do NOT call `telerik_winforms_assistant` to fix build errors — resolve them by reading the error message and applying standard C# fixes. Only call `telerik_winforms_assistant` for items listed in the `itemsToReview` array returned by `telerik_convert_file`. Call the assistant one item at a time — do NOT batch multiple calls in parallel.
  - Do NOT re-convert a file that has already been converted — calling `telerik_convert_file` on the same file a second time will overwrite previous fixes. If a converted file has build errors, fix them manually in code instead of re-running the converter.
- **Anti-patterns**:
  - Creating wrapper classes for Telerik controls
  - Adding TFM suffix to package names (e.g., `.Net90`, `.Net48`)
  - Converting all `.Designer.cs` files first, then all `.cs` files (breaks context)
- **Skip files**: `*.resx` (resource files), `*.resources` (compiled resources), `*.settings` (application settings), and non-WinForms code (services, models, utilities).
- **Error handling**:
  - **onConversionFailure**: Read the error message carefully and apply standard C# fixes. Do NOT call `telerik_winforms_assistant` for build errors.
  - **onBuildFailure**: After converting a form pair, run `dotnet build`. Fix ONLY errors in files already converted. Ignore errors in unconverted files — they will be resolved when those files are converted. Check for missing usings, review converter notes for REMOVED properties.
  - **classicProjectBuild**: IMPORTANT: Classic-style (non-SDK) .NET Framework projects that use PackageReference may fail to resolve Telerik assemblies with `dotnet build` when the conversion is run outside of Visual Studio (e.g. inside GitHub Copilot CLI) because the .NET SDK MSBuild does not fully support PackageReference in classic `.csproj` files. If CS0246 errors like "The type or namespace name Telerik could not be found" appear after `dotnet restore` succeeds, switch to Visual Studio's MSBuild. Find it with:
    ```powershell
    & "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe" -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe | Select-Object -First 1
    ```
    Then build with `& "<MSBuild path>" <solution>.sln -restore -t:Build -p:Configuration=Debug`. Use VS MSBuild for ALL subsequent builds in that project.
  - **onDesignerError**: Check for missing Telerik control references and ensure the NuGet package is restored.
  - **whenToFixErrors**: Immediately after converting each form pair (Designer.cs + .cs). Do NOT wait until all forms are converted. Small, scoped error sets are easier to fix correctly.

## Project Analysis (`telerik_analyze_project`)

### Orders
- **Project Path**: `C:\Modernization Tests\.NET Upgrade & Conversion\Run 1 - Luna 6\Orders.LocalData\Orders\Orders.csproj`
- **Target Framework**: `net10.0-windows`
- **Project Style**: SDK
- **Output Type**: `WinExe`
- **Existing Telerik References**: none
- **Has AllControls Package**: `false`
- **WindowsForms Enabled**: `true`
- **Has packages.config**: `false`
- **Recommendations**:
  - Project uses SDK-style - use `<PackageReference>` in `.csproj`
  - No existing Telerik references found - use `telerik_add_package_reference` to add them
- **Build method**: `dotnet build` (SDK-style modern .NET; Classic .NET Framework MSBuild path does not apply).

## Conversion Units (form / user-control class pairs)

### Orders
| Class | Designer file | Code file |
|-------|---------------|-----------|
| Form1 | `Orders\Form1.Designer.cs` | `Orders\Form1.cs` |

**Total conversion units**: 1

> Per-control detail is intentionally absent — `telerik_convert_file` performs the control mapping during execution.

## Required Setup Steps
- [ ] Install `Telerik.UI.for.WinForms.AllControls`: **Yes** — package is absent; the pre-initialization recommendation for this greenfield, all-forms conversion is version `2026.4.1111`.
- [ ] Assembly → NuGet migration: **No** — no existing Telerik references to migrate.
- [ ] Application license activation: **Yes** — version `2026.4.1111` is Q1 2025 or later; the global license file exists at `C:\Users\merdjanov\AppData\Roaming\Telerik\telerik-license.txt`. Pre-initialization reports that CLI inspection succeeded, but WinForms product status is unknown. The AllControls package brings `Telerik.Licensing` transitively; do not add it explicitly.
- [ ] Theme setup: **Yes** — required as the final step after all forms are converted.

## Version Compatibility
- **Telerik Version**: `2026.4.1111`
- **Compatible with .NET target**: **Yes** — the local matrix lists .NET 10 support via the .NET 9 distribution from Telerik 2024 Q4 (2024.4.x); the proposed version exceeds that minimum.
- **Compatibility source**: [Telerik UI for WinForms distributions](https://www.telerik.com/products/winforms/documentation/installation-and-upgrades/distributions) (local `version-compatibility.md` reference).

## Risks and Notes
- **Trial conversion limit**: 1 unit vs. 20-conversion trial cap — within the stated cap.
- The solution contains only `Orders\Orders.csproj`; no test project or test target was discovered.
- No control-level APIs or breaking changes were assessed. `telerik_convert_file` performs per-file control mapping during execution and returns any `itemsToReview`.
- No Git repository is present in the workspace. The migration playbook recommends a source-control commit before conversion; arrange an equivalent backup/recovery baseline before execution.
- Active SDK is `11.0.100-rc.3.26522.148`; stable SDK `10.0.401` is also installed. No workspace `global.json` is present. .NET 10 and Windows Desktop 10 runtimes (`10.0.12`, `10.0.14`) are installed. Builds may use the active .NET 11 preview SDK unless the stable SDK is selected.
- The Telerik license file is present, and CLI inspection succeeded per pre-initialization; the WinForms product license status remains unknown.
- Scenario warning policy: fix only warnings introduced by this scenario that have a clear local fix; report other warnings as known issues. The build gate is zero errors and no blocking `TKL*` diagnostics.
- This artifact records the assessment only; no plan was generated and no product-code changes were made.
