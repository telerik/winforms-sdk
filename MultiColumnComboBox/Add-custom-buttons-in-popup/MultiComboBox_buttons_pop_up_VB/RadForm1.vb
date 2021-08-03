Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI

Public Class RadForm1
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        FillData()
        Me.RadMultiColumnComboBox1.EditorControl.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub FillData()
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("FirstName")
        dt.Columns.Add("LastName")
        dt.Columns.Add("Occupation")
        dt.Columns.Add("StartingDate", GetType(DateTime))
        dt.Columns.Add("IsMarried", GetType(Boolean))
        dt.Columns.Add("Salary")
        dt.Rows.Add("Sarah", "Blake", "Supplied Manager", New DateTime(2005, 4, 12), True, 3500)
        dt.Rows.Add("Jane", "Simpson", "Security", New DateTime(2008, 12, 3), True, 2000)
        dt.Rows.Add("John", "Peterson", "Consultant", New DateTime(2005, 4, 12), False, 2600)
        dt.Rows.Add("Peter", "Bush", "Cashier", New DateTime(2005, 4, 12), True, 2300)
        dt.Rows.Add("Harry", "Forth", "Agent", New DateTime(205, 4, 12), True, 2000)
        dt.Rows.Add("Mery", "Keneth", "Consultant", New DateTime(205, 4, 12), False, 2100)
        dt.Rows.Add("Jane", "Millan", "Sales", New DateTime(205, 4, 12), False, 2600)
        Me.RadMultiColumnComboBox1.DataSource = dt
    End Sub
End Class

Public Class MyRadMultiColumnComboBox
    Inherits RadMultiColumnComboBox

    Public Overrides Property ThemeClassName As String
        Get
            Return GetType(RadMultiColumnComboBox).FullName
        End Get
        Set(value As String)
            MyBase.ThemeClassName = value
        End Set
    End Property

    Protected Overrides Function CreateMultiColumnComboBoxElement() As RadMultiColumnComboBoxElement
        Return New MyRadMultiColumnComboBoxElement()
    End Function
End Class

Public Class MyRadMultiColumnComboBoxElement
    Inherits RadMultiColumnComboBoxElement

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(RadMultiColumnComboBoxElement)
        End Get
    End Property

    Protected Overrides Function CreatePopupForm() As RadPopupControlBase
        Dim popupForm As MultiColumnComboPopupForm = New MyMultiColumnComboPopupForm(Me)
        popupForm.SizingMode = SizingMode.UpDownAndRightBottom
        Me.WirePopupFormEvents(popupForm)
        Return popupForm
    End Function
End Class

Public Class MyMultiColumnComboPopupForm
    Inherits MultiColumnComboPopupForm

    Friend closed As Boolean
    Private deleteButton As RadButtonElement
    Private addButton As RadButtonElement
    Private panel As StackLayoutPanel
    Private element As RadMultiColumnComboBoxElement

    Public Sub New(ByVal element As RadMultiColumnComboBoxElement)
        MyBase.New(element)
        Me.element = element
    End Sub

    Public Overrides Sub ClosePopup(ByVal reason As RadPopupCloseReason)
        If MyBase.EditorControl.GridViewElement.ContainsMouse Then
            Return
        End If

        MyBase.ClosePopup(reason)
    End Sub

    Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
        MyBase.CreateChildItems(parent)
        panel = New StackLayoutPanel()
        panel.StretchVertically = False
        addButton = New RadButtonElement()
        addButton.Text = "AddButton"
        addButton.MinSize = New Size(200, 20)
        addButton.StretchVertically = True
        addButton.StretchHorizontally = True
        AddHandler addButton.Click, AddressOf Me.AddButton_Click
        panel.Children.Add(addButton)
        deleteButton = New RadButtonElement()
        deleteButton.Text = "DeleteButton"
        deleteButton.MinSize = New Size(200, 20)
        deleteButton.StretchVertically = True
        deleteButton.StretchHorizontally = True
        AddHandler deleteButton.Click, AddressOf Me.DeleteButton_Click
        panel.Children.Add(deleteButton)
        MyBase.SizingGripDockLayout.Children.Insert(1, Me.panel)
        DockLayoutPanel.SetDock(Me.SizingGrip, Telerik.WinControls.Layouts.Dock.Bottom)
        DockLayoutPanel.SetDock(panel, Telerik.WinControls.Layouts.Dock.Bottom)
    End Sub

    Private Sub AddButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim entryForm As DataEntryForm = New DataEntryForm(element)
        entryForm.TopMost = True
        entryForm.Show()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        MyBase.EditorControl.Rows.Remove(MyBase.EditorControl.CurrentRow)
    End Sub
End Class

