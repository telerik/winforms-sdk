Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Service
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function GetMatchingItems(ByVal startOfText As String) As DataSet
        Dim dr As DataRow
        Dim dt As New DataTable
        Dim dv As DataView
        Dim ds As New DataSet

        'Load data
        dt.CaseSensitive = False
        dt.Columns.Add("COUNTRY")
        dt.Columns.Add("SHORTNAME")

        dr = dt.NewRow
        dr("COUNTRY") = "United States of America"
        dr("SHORTNAME") = "US"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "United Kingdom"
        dr("SHORTNAME") = "UK"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Ukraine"
        dr("SHORTNAME") = "UA"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Uruguay"
        dr("SHORTNAME") = "UY"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Malta"
        dr("SHORTNAME") = "MT"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Mali"
        dr("SHORTNAME") = "ML"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Madagasgar"
        dr("SHORTNAME") = "UA"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Morocco"
        dr("SHORTNAME") = "MA"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Monaco"
        dr("SHORTNAME") = "MC"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Mexico"
        dr("SHORTNAME") = "MX"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Maldives"
        dr("SHORTNAME") = "MV"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Malawi"
        dr("SHORTNAME") = "MW"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Malaysia"
        dr("SHORTNAME") = "MY"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Canada"
        dr("SHORTNAME") = "CA"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Cambodia"
        dr("SHORTNAME") = "KH"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Congo"
        dr("SHORTNAME") = "CG"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Chile"
        dr("SHORTNAME") = "CL"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Cameroon"
        dr("SHORTNAME") = "CM"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Cuba"
        dr("SHORTNAME") = "CU"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Spain"
        dr("SHORTNAME") = "EP"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Sri Lanka"
        dr("SHORTNAME") = "LK"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Sudan"
        dr("SHORTNAME") = "SD"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Sweden"
        dr("SHORTNAME") = "SE"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Italy"
        dr("SHORTNAME") = "IT"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Ireland"
        dr("SHORTNAME") = "IE"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "India"
        dr("SHORTNAME") = "IN"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Israel"
        dr("SHORTNAME") = "IL"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Iceland"
        dr("SHORTNAME") = "IS"
        dt.Rows.Add(dr)

        dr = dt.NewRow
        dr("COUNTRY") = "Indonesia"
        dr("SHORTNAME") = "ID"
        dt.Rows.Add(dr)

        'Filter the result set to find the matching rows
        dv = dt.DefaultView
        dv.RowFilter = "COUNTRY LIKE '" & startOfText.ToLower & "%'"

        'Convert the dataView back to a dataTable
        dt = dv.ToTable()
        dt.TableName = "ITEMS"

        'Add the dataTable to the dataSet
        ds.Tables.Add(dt)

        Return ds

    End Function

End Class
