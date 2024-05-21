## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>Q2 2011</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadGridView for WinForms</td>
	</tr>
</table>


## Description 

#### Load On Demand Combobox for RadGridView

This project demonstrates "load on demand" functionality for a combobox in the grid.  Although this is available with the controls for ASP.NET, this is not currently supported for the WinForms combobox.

The application consists of a single RadGridView control with one GridViewMultiComboBoxColumn named "Country".  The load on demand functionality is encapsulated in the LoadOnDemandCellEditor class, which inherits from RadMultiColumnComboBoxElement.  Once the cell is put into edit mode, the default cell editor is changed to the custom cell editor.  This makes use of System.Timer object, which is used to buffer the requests to the web service (included with the project).  Once the timer's interval has passed, it executes an asynchronous web service call to load the matching items.

When the application runs, a window form is loaded with a RadGridView. The grid contains a list of countries.  Double click on a row to put it into edit mode and clear out the text.  As you type, the combobox makes asynchronous web service calls to retrieve matching items.  So for example if you type in "Mo" it will return all countries that match this (ex. "Morocco", "Monaco").  As you continue typing it will further refine the matching items.
