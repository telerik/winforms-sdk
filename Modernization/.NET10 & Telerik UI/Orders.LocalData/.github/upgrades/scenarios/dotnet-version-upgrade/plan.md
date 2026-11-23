# .NET Version Upgrade Plan

## Overview

**Target**: .NET 10 (`net10.0-windows`)
**Scope**: One classic WinForms project, `Orders\Orders.csproj` (`net462`, non-SDK-style; 642 LOC; no project dependencies).

### Selected Strategy
**All-At-Once** — All projects upgraded simultaneously in a single operation.
**Rationale**: The solution has one .NET Framework project and no dependencies, so dependency-tier sequencing is unnecessary.

## Upgrade Options

| Option | Selected | Why |
|--------|----------|-----|
| Upgrade Strategy | All-at-Once | One project with no dependencies leaves no project graph to manage. |
| Unsupported API Handling | Fix Inline | The assessment flags 764 binary-incompatible and 34 source-incompatible APIs; inline fixes avoid deferred API stubs. |
| Windows Native APIs | Windows Compatibility Pack | The assessment reports widespread Windows Forms and System.Drawing API usage. |
| Test Coverage | Skip | Coverage is recommended, but the confirmed selection keeps generated test baselines opt-in. |

## Tasks

### 01-orders-sdk-style-conversion: Convert Orders.csproj to SDK-style

Prepare the sole in-scope project for the framework upgrade by converting its non-SDK-style `net462` project definition while retaining the existing target framework. The assessment identifies `Orders.csproj` as a classic WinForms project with no project dependencies, no NuGet packages, and no package compatibility issues. Confirm the required .NET SDK/toolchain and `global.json` compatibility, and review legacy imports, references, form resources, and designer metadata so the structural conversion preserves the existing application.

Keep this project-format conversion separate from the TFM and API upgrade; the Framework migration guidance treats them as distinct changes with different failure modes.

**Done when**: `Orders.csproj` uses SDK-style format while still targeting `net462`, its existing forms and resources remain included, and the project restores and builds successfully on that target.

---

### 02-orders-net10-winforms: Upgrade Orders WinForms APIs to .NET 10

After the SDK-style conversion, retarget `Orders.csproj` from `net462` to `net10.0-windows` and address the compatibility work identified by the assessment. It flags 764 binary-incompatible and 34 source-incompatible APIs, including 96 legacy WinForms-control issues and 34 GDI+/`System.Drawing` issues. Use the project report and complete API-issue report as research starting points, with particular attention to removed controls such as `StatusBar`, `DataGrid`, `ContextMenu`, `MainMenu`, `MenuItem`, and `ToolBar`.

Resolve the API changes inline rather than deferring them behind stubs, preserve the WinForms designer/resources, and include the selected `Microsoft.Windows.Compatibility` package. The assessment found no existing NuGet packages or package compatibility issues.

**Done when**: `Orders.csproj` targets `net10.0-windows`, the flagged API changes are resolved without deferred stubs, `Orders.sln` restores and builds with zero errors, and any applicable existing tests pass.
