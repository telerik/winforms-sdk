# Projects and dependencies analysis

This document provides a comprehensive overview of the projects and their dependencies in the context of upgrading to .NETCoreApp,Version=v10.0.

Detailed findings live alongside this file in `assessment/`. This page is the index: read it first, then open only the documents you need.

## Table of Contents

- [Executive Summary](#executive-summary)
  - [Highlevel Metrics](#highlevel-metrics)
  - [Projects Compatibility](#projects-compatibility)
  - [Package Compatibility](#package-compatibility)
  - [API Compatibility](#api-compatibility)
- [Top API Migration Challenges](#top-api-migration-challenges)
  - [Technologies and Features](#technologies-and-features)
  - [Most Frequent API Issues](#most-frequent-api-issues)
- [telerik-for-dotnet-version-upgrade — presence gate](#telerik-for-dotnet-version-upgrade--presence-gate)
- [telerik-wpf-for-dotnet-version-upgrade — presence gate](#telerik-wpf-for-dotnet-version-upgrade--presence-gate)
- [Detailed Reports](#detailed-reports)
  - [Projects Relationship Graph](assessment/project-graph.md)
  - [Aggregate NuGet packages details](assessment/nuget/aggregate-packages.md)
  - [Most Frequent API Issues (complete list)](assessment/api-issues/most-frequent-api-issues.md)
  - [Project Details](#project-details)

## Executive Summary

### Highlevel Metrics

| Metric | Count | Status |
| :--- | :---: | :--- |
| Total Projects | 1 | All require upgrade |
| Total NuGet Packages | 0 | All compatible |
| Total Code Files | 6 |  |
| Total Code Files with Incidents | 4 |  |
| Total Lines of Code | 642 |  |
| Total Number of Issues | 800 |  |
| Proposed Target Framework | net10.0-windows |  |
| Estimated LOC to modify | 798+ | at least 124.3% of codebase |

### Projects Compatibility

| Project | Target Framework | Difficulty | Test Coverage | Package Issues | API Issues | Binding Issues | Est. LOC Impact | Description |
| :--- | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :--- |
| [Orders.csproj](assessment/projects/Orders.md) | net462 | 🟡 Medium | 🧪 Recommended | 0 | 798 | 0 | 798+ | ClassicWinForms, Sdk Style = False |

🧪 **Test Coverage** — projects risky enough to add behavior-locking tests before upgrading, to catch regressions the upgrade may introduce. Requires the **dotnet-test** plugin.

### Package Compatibility

| Status | Count | Percentage |
| :--- | :---: | :---: |
| ✅ Compatible | 0 | 0.0% |
| ⚠️ Incompatible | 0 | 0.0% |
| 🔄 Upgrade Recommended | 0 | 0.0% |
| ***Total NuGet Packages*** | ***0*** | ***100%*** |

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 764 | High - Require code changes |
| 🟡 Source Incompatible | 34 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 488 |  |
| ***Total APIs Analyzed*** | ***1286*** |  |

## Top API Migration Challenges

### Technologies and Features

| Technology | Issues | Percentage | Migration Path |
| :--- | :---: | :---: | :--- |
| Windows Forms | 764 | 95.7% | Windows Forms APIs for building Windows desktop applications with traditional Forms-based UI that are available in .NET on Windows. Enable Windows Desktop support: Option 1 (Recommended): Target net9.0-windows; Option 2: Add <UseWindowsDesktop>true</UseWindowsDesktop>; Option 3 (Legacy): Use Microsoft.NET.Sdk.WindowsDesktop SDK. |
| Windows Forms Legacy Controls | 96 | 12.0% | Legacy Windows Forms controls that have been removed from .NET Core/5+ including StatusBar, DataGrid, ContextMenu, MainMenu, MenuItem, and ToolBar. These controls were replaced by more modern alternatives. Use ToolStrip, MenuStrip, ContextMenuStrip, and DataGridView instead. |
| GDI+ / System.Drawing | 34 | 4.3% | System.Drawing APIs for 2D graphics, imaging, and printing that are available via NuGet package System.Drawing.Common. Note: Not recommended for server scenarios due to Windows dependencies; consider cross-platform alternatives like SkiaSharp or ImageSharp for new code. |

### Most Frequent API Issues

| API | Count | Percentage | Category |
| :--- | :---: | :---: | :--- |
| T:System.Windows.Forms.AnchorStyles | 50 | 6.3% | Binary Incompatible |
| T:System.Windows.Forms.Button | 39 | 4.9% | Binary Incompatible |
| T:System.Windows.Forms.TabPage | 35 | 4.4% | Binary Incompatible |
| T:System.Windows.Forms.ToolStripMenuItem | 32 | 4.0% | Binary Incompatible |
| T:System.Windows.Forms.DataGridView | 27 | 3.4% | Binary Incompatible |
| T:System.Windows.Forms.Label | 25 | 3.1% | Binary Incompatible |
| T:System.Windows.Forms.ComboBox | 20 | 2.5% | Binary Incompatible |
| T:System.Windows.Forms.SplitContainer | 20 | 2.5% | Binary Incompatible |
| T:System.Drawing.Font | 18 | 2.3% | Source Incompatible |
| T:System.Windows.Forms.ListBox | 16 | 2.0% | Binary Incompatible |

The table above is the top 10. See [the complete list](assessment/api-issues/most-frequent-api-issues.md) for every affected API.

## telerik-for-dotnet-version-upgrade — presence gate

**Telerik UI for WinForms: not present.** The extension's Step 0 presence gate searched the in-scope project `Orders.csproj` and its `packages.config` (none exists in the project folder) for `Telerik` and `UI.for.WinForms`, case-insensitive, and found no match. Per the extension, there is nothing for it to contribute to this assessment: Steps 1–3 and its WinForms reference-detection skill were not run.

## telerik-wpf-for-dotnet-version-upgrade — presence gate

**Telerik UI for WPF: not present.** The extension's Step 0 presence gate searched the in-scope project `Orders.csproj` and its `packages.config` (none exists in the project folder) for `Telerik`, case-insensitive, and found no match. Per the extension, there is nothing for it to contribute to this assessment: Steps 1–5 and its WPF reference-detection skill were not run.

## Detailed Reports

- [Projects Relationship Graph](assessment/project-graph.md)
- [Aggregate NuGet packages details](assessment/nuget/aggregate-packages.md)
- [Most Frequent API Issues (complete list)](assessment/api-issues/most-frequent-api-issues.md)

### Project Details

- [Orders.csproj](assessment/projects/Orders.md)


