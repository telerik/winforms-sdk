# Telerik WinForms Control Conversion

## Preferences
- **Flow Mode**: Automatic
- **Telerik Version to Install**: 2026.4.1111
- **Conversion Scope**: All Forms
- **Build Warnings Policy**: Fix only warnings this scenario introduces; errors and blocking TKL* diagnostics block, other warnings are reported as known issues (Telerik plugin policy)

## Build Tool Decisions
- **Orders\Orders.csproj**: `dotnet build` (SDK-style `net10.0-windows`; one-project solution, no XAML or embedded image/icon resources).
