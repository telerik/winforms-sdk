# .NET Version Upgrade

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: .NET 10 (LTS)

## Decisions
- **Follow-up after this scenario**: Run `telerik-winforms-control-conversion` for the requested Telerik UI conversion.

## Upgrade Options

### Strategy
- Upgrade Strategy: All-at-Once

### Compatibility
- Unsupported API Handling: Fix Inline
- Windows Native APIs: Windows Compatibility Pack

### Reliability
- Test Coverage: Skip

## Strategy
**Selected**: All-at-Once
**Rationale**: The solution contains one .NET Framework project with no dependencies, so dependency-tier sequencing adds no benefit.

### Execution Constraints
- Upgrade the sole project without project-tier ordering or multi-project phases.
- Convert the legacy project format while retaining `net462` before changing the target framework; keep structural conversion and API migration distinct.
- Retarget to `net10.0-windows`, apply the selected Windows Compatibility Pack, and resolve API changes inline rather than deferring them behind stubs.
- Restore and build the whole solution after the upgrade, then run any applicable existing tests; target zero build errors.

## Build Tool Decisions
- **Orders\Orders.csproj**: `msbuild.exe` — use full Visual Studio MSBuild for restore/build because the project targets .NET Framework 4.6.2 and is a WinForms application with designer-generated resources.
