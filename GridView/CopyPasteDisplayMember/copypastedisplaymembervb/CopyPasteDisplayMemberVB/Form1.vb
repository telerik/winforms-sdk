Imports Telerik.WinControls.UI
Imports System.Text

Public Class Form1

    Public Sub New()
        InitializeComponent()

        Dim decimalColumn As New GridViewDecimalColumn("Id")
        RadGridView1.MasterTemplate.Columns.Add(decimalColumn)

        Dim textBoxColumn As New GridViewTextBoxColumn("Name")
        RadGridView1.MasterTemplate.Columns.Add(textBoxColumn)

        Dim dateTimeColumn As New GridViewDateTimeColumn("CreatedOn")
        RadGridView1.MasterTemplate.Columns.Add(dateTimeColumn)

        Dim comboColumn As New GridViewComboBoxColumn("Country")
        comboColumn.DisplayMember = "Name"
        comboColumn.ValueMember = "ID"
        comboColumn.DataSource = New List(Of Country)() From { _
            New Country() With { _
                .ID = 1, _
                .Name = "UK" _
            }, _
            New Country() With { _
                .ID = 2, _
                .Name = "USA" _
        } _
        }
        RadGridView1.MasterTemplate.Columns.Add(comboColumn)

        RadGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        For i As Integer = 0 To 9
            RadGridView1.Rows.Add(i, "Name" & i, DateTime.Now.AddDays(i), i Mod 2 + 1)
        Next
    End Sub

    Public Class Country
        Public Property ID() As Integer
            Get
                Return m_ID
            End Get
            Set(value As Integer)
                m_ID = value
            End Set
        End Property
        Private m_ID As Integer

        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = value
            End Set
        End Property
        Private m_Name As String
    End Class

    Public Class CustomMasterGridViewTemplate
    Inherits MasterGridViewTemplate
        Public Overrides Sub Copy()
            MyBase.Copy()

            If Clipboard.ContainsData(DataFormats.Text) Then
                Dim data As String = Clipboard.GetData(DataFormats.Text).ToString()
                If data <> String.Empty Then
                    Dim sb As New StringBuilder()
                    'modify the copied data and replace it in the clipboard
                    For Each row As GridViewRowInfo In Me.Owner.SelectedRows
                        Dim i As Integer = 0
                        While i < row.Cells.Count
                            If i > 0 Then
                                sb.Append(";")
                            End If
                            'copy the DisplayMember
                            Dim cellText As String = Me.Owner.CurrentView.GetCellElement(row.Cells(i).RowInfo, row.Cells(i).ColumnInfo).Text
                            sb.Append(cellText)
                            i += 1
                        End While
                        sb.AppendLine()
                    Next

                    Clipboard.SetData(DataFormats.Text, sb.ToString())
                End If
            End If
        End Sub

        Public Overrides Sub Paste()
            If Clipboard.ContainsData(DataFormats.Text) Then
                Dim data As String = Clipboard.GetData(DataFormats.Text).ToString()
                If data <> String.Empty Then
                    Dim sb As New StringBuilder()
                    Dim rowTokens As String() = data.Split(New String() {Environment.NewLine.ToString()}, StringSplitOptions.RemoveEmptyEntries)
                    For Each rowToken As String In rowTokens
                        Dim tokens As String() = rowToken.Split(New Char() {";"c}, StringSplitOptions.RemoveEmptyEntries)

                        For i As Integer = 0 To tokens.Length - 1
                            Dim comboColumn As GridViewComboBoxColumn = TryCast(Me.Owner.Columns(i), GridViewComboBoxColumn)
                            If i < Me.Owner.Columns.Count AndAlso comboColumn IsNot Nothing Then
                                'get the ValueMember
                                sb.Append(GetValueMember(tokens(i), comboColumn.DataSource))
                            Else
                                sb.Append(tokens(i))
                            End If

                            If i < tokens.Length - 1 Then
                                sb.Append(vbTab)
                            End If
                        Next
                        sb.Append(Environment.NewLine.ToString())
                    Next

                    Clipboard.SetData(DataFormats.Text, sb.ToString())
                End If
            End If

            MyBase.Paste()
        End Sub

        Private Function GetValueMember(token As String, source As Object) As String
            Dim dataSource As IEnumerable(Of Country) = TryCast(source, IEnumerable(Of Country))
            If dataSource IsNot Nothing Then
                For Each c As Country In dataSource
                    If c.Name = token Then
                        Return c.ID.ToString()
                    End If
                Next
            End If

            Return String.Empty
        End Function
    End Class

    Public Class CustomGrid
    Inherits RadGridView
        Protected Overrides Function CreateGridViewElement() As RadGridViewElement
            Return New CustomRadGridViewElement()
        End Function

        Public Overrides Property ThemeClassName As String
            Get
                Return GetType(RadGridView).FullName
            End Get
            Set(value As String)
                MyBase.ThemeClassName = value
            End Set
        End Property
    End Class

    Public Class CustomRadGridViewElement
    Inherits RadGridViewElement
        Protected Overrides Function CreateTemplate() As MasterGridViewTemplate
            Return New CustomMasterGridViewTemplate()
        End Function

        Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
            Get
                Return GetType(RadGridViewElement)
            End Get
        End Property
    End Class

End Class
