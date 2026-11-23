# Telerik WinForms Control Conversion Plan

## Scope
- **Projects**: `Orders\Orders.csproj`
- **Telerik Version**: `2026.4.1111` (to install)
- **Conversion units in scope**: 1 of 1
- **Units deferred**: none
- **Build method**: `dotnet build`
- **Trial cap risk**: no — the single conversion unit is within the stated 20-conversion trial cap

## Tasks

1. **01-prepare-orders-project — Install Telerik and establish licensed baseline**
   - Description: Add `Telerik.UI.for.WinForms.AllControls` version `2026.4.1111` through the Telerik package-reference tool, restore it, preserve a recovery baseline for this non-Git workspace, and run the SDK-style project's setup/baseline build. The expected application licensing mechanism is the existing license file with `Telerik.Licensing` supplied transitively by AllControls; do not add `Telerik.Licensing` explicitly. The existing file and CLI validation do not establish WinForms product activation.
   - Done when: The package is restored; the baseline build has 0 errors and no blocking `TKL*` diagnostics; license verification confirms the mechanism matches the planned package-based activation. **Conversion is gated on this evidence**: if activation remains unconfirmed or any `TKL*` diagnostic appears, stop before converting files and route the exact diagnostic to license diagnostics for resolution. Record other warnings as known issues; they do not block this task.
   - Related skill: `telerik-winforms-dependency-management`, `telerik-winforms-license-verification`

2. **02-convert-form1-controls — Convert Form1 controls**
   - Description: Convert the single in-scope class pair, `Orders\Form1.Designer.cs` and `Orders\Form1.cs`, as one unit, with the designer file first. Use the converter for mapping, preserve field names and application behavior, and handle each `itemsToReview` entry as part of this task.
   - Files: `Orders\Form1.Designer.cs`, `Orders\Form1.cs`
   - Done when: Both files are converted; each `itemsToReview` item is resolved or documented as having no alternative; and the post-pair `dotnet build` has 0 errors and no blocking `TKL*` diagnostics. Fix only errors in the converted pair. Report other warnings as known issues, not blockers.
   - Related skill: `telerik-winforms-conversion`

3. **03-finalize-orders-conversion — Apply theme and verify the solution**
   - Description: After conversion, run a full solution build and resolve cross-form errors, apply the Telerik theme, then run a final verification build after the theme/configuration change. No test project or test target was discovered.
   - Done when: The theme is configured; the final `dotnet build` has 0 errors and no blocking `TKL*` diagnostics; any other warnings are recorded as known issues; and the customer is reminded to launch the application once to check for a licensing watermark, banner, or modal.
   - Related skill: `telerik-winforms-conversion`, `telerik-winforms-migration-verification`, `telerik-winforms-license-verification`
