Imports Telerik.WinControls.UI

Public Class RadForm1
    Public Sub New()
        InitializeComponent()

        RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        Dim comboColumn As New IndicatedComboBoxColumn()
        comboColumn.HeaderText = "Combo Box"
        comboColumn.DataSource = GetTable()
        comboColumn.ValueMember = "Name"
        comboColumn.DisplayMember = "Name"
        comboColumn.Width = 100
        RadGridView1.Columns.Add(comboColumn)

        Dim DateTimeColumn As New IndicatedDateTimeColumn()
        DateTimeColumn.HeaderText = "DateTime"
        RadGridView1.Columns.Add(DateTimeColumn)

        Dim browseColumn As New IndicatedBrowseColumn()
        browseColumn.HeaderText = "Browse"
        RadGridView1.Columns.Add(browseColumn)

        Dim calculatorColumn As New IndicatedCalculatorColumn()
        calculatorColumn.HeaderText = "Calcualtor"
        RadGridView1.Columns.Add(calculatorColumn)

        Dim colorColumn As New IndicatedColorColumn()
        colorColumn.HeaderText = "Color"
        RadGridView1.Columns.Add(colorColumn)

        Dim MCCBColumn As New IndicatedMultiComboBoxColumn()
        MCCBColumn.HeaderText = "MCCB"
        MCCBColumn.DataSource = GetTable()
        MCCBColumn.DisplayMember = "Name"
        MCCBColumn.ValueMember = "Name"
        RadGridView1.Columns.Add(MCCBColumn)

        Dim deciamlColumn As New IndicatedDecimalColumn()
        deciamlColumn.HeaderText = "Decimal"
        RadGridView1.Columns.Add(deciamlColumn)

        For i As Integer = 0 To 15
            RadGridView1.Rows.Add("David", New Date(2014, 8, 4), "C:\", 123456, Color.Black, "Sam", 123456)
        Next i
    End Sub

    Private Shared Function GetTable() As DataTable
        Dim table As New DataTable()
        table.Columns.Add("Dosage", GetType(Integer))
        table.Columns.Add("Drug", GetType(String))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Date", GetType(Date))

        table.Rows.Add(25, "Indocin", "David", Date.Now)
        table.Rows.Add(50, "Enebrel", "Sam", Date.Now)
        table.Rows.Add(10, "Hydralazine", "Christoff", Date.Now)
        table.Rows.Add(21, "Combivent", "Janet", Date.Now)
        table.Rows.Add(100, "Dilantin", "Melanie", Date.Now)

        Return table
    End Function
End Class
