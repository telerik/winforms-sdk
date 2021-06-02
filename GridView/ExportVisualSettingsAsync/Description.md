## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2016.2.608</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WinForms</td>
	</tr>
</table>


## Description 

RadGridView provides async exporting capabilities out of the box. However, due to the background threads we are using and the target framework against which our assemblies are built (.NET 4.0) we are not exporting the visual settings with the existing async API. This solution shows how to export RadGridView asynchronously while preserving its visual settings.

A complete step by step tutorial is available [here](https://docs.telerik.com/devtools/winforms/knowledge-base/exporting-radgridview-asynchronously-preserving-its-visual-settings).
