Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI


Public Class Main

    Private m_ShowCellImage As Boolean


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim somethings As New Somethings()
            Me.RadGridView.BeginUpdate()
            Me.RadGridView.DataSource = New BindingList(Of Something)(somethings.GetSomethings())
            Me.RadGridView.MasterTemplate.BestFitColumns()
            Me.RadGridView.EndUpdate()
            Me.PopulateTextImagerelationDropDown()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PopulateTextImagerelationDropDown()
        For Each relation As TextImageRelation In [Enum].GetValues(GetType(TextImageRelation))
            Me.RadDropDownTextImageRelation.Items.Add(relation.ToString())
        Next
        If Me.RadDropDownTextImageRelation.Items.Count > 0 Then
            Me.RadDropDownTextImageRelation.SelectedIndex = 0
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView.CellFormatting
        Dim cell As GridDataCellElement = TryCast(e.CellElement, GridDataCellElement)
        If cell IsNot Nothing Then
            If cell.ContainsErrors Then
                cell.DrawBorder = True
                cell.BorderBoxStyle = BorderBoxStyle.SingleBorder
                cell.BorderWidth = 2
                cell.BorderColor = Me.RadPanelBorderColor.BackColor
                If m_ShowCellImage Then
                    cell.Image = Me.ImageList.Images(0)
                    ' following line ensures cell image is placed consistantly
                    If String.IsNullOrEmpty(e.CellElement.Text) Then e.CellElement.Text = " "

                    For Each relation As TextImageRelation In [Enum].GetValues(GetType(TextImageRelation))
                        If String.Equals(Me.RadDropDownTextImageRelation.SelectedItem.Text, relation.ToString()) Then
                            cell.TextImageRelation = relation
                            Exit For
                        End If
                    Next
                    If cell.TextImageRelation = TextImageRelation.TextBeforeImage Then
                        cell.ImageAlignment = ContentAlignment.MiddleRight
                    ElseIf cell.TextImageRelation = TextImageRelation.ImageBeforeText Then
                        cell.ImageAlignment = ContentAlignment.MiddleLeft
                    End If
                Else
                    cell.Image = Nothing
                End If
            Else
                cell.ResetValue(LightVisualElement.DrawBorderProperty, ValueResetFlags.Local)
                cell.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local)
                cell.ResetValue(LightVisualElement.BorderWidthProperty, ValueResetFlags.Local)
                cell.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local)
                cell.Image = Nothing
            End If
        End If

    End Sub

    Private Sub RadButtonBorderColor_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles RadButtonBorderColor.Click

        If Me.RadColorDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.RadPanelBorderColor.BackColor = Me.RadColorDialog.SelectedColor
        End If
    End Sub

    Private Sub RadCheckBoxIncludeCellImage_ToggleStateChanged(ByVal sender As System.Object, _
        ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadCheckBoxIncludeCellImage.ToggleStateChanged

        Me.RadDropDownTextImageRelation.Enabled = (RadCheckBoxIncludeCellImage.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        m_ShowCellImage = (RadCheckBoxIncludeCellImage.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On)
        Me.RadGridView.MasterTemplate.Refresh()
        Me.RadGridView.MasterTemplate.BestFitColumns()
    End Sub

    Private Sub RadCheckBoxShowRowHeaderColumn_ToggleStateChanged(ByVal sender As System.Object, _
        ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadCheckBoxShowRowHeaderColumn.ToggleStateChanged

        Me.RadGridView.ShowRowHeaderColumn = (Me.RadCheckBoxShowRowHeaderColumn.ToggleState = Enumerations.ToggleState.On)
    End Sub

    Private Sub RadDropDownTextImageRelation_SelectedIndexChanged(ByVal sender As System.Object, _
        ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownTextImageRelation.SelectedIndexChanged

        Me.RadGridView.TableElement.Update(GridUINotifyAction.RowHeightChanged)
        Me.RadGridView.Refresh()
        Me.RadGridView.MasterTemplate.BestFitColumns()
    End Sub

    Private Sub RadPanelBorderColor_BackColorChanged(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles RadPanelBorderColor.BackColorChanged

        Me.RadGridView.MasterTemplate.Refresh()
    End Sub
End Class

Public Class Somethings

    Public Sub New()
    End Sub

    Public Function GetSomethings() As System.Collections.Generic.List(Of Something)
        Dim somethingList As New System.Collections.Generic.List(Of Something)
        somethingList.Add(New Something("", "Blank Name Description"))
        somethingList.Add(New Something("Name", "Name Description"))
        somethingList.Add(New Something("Name1", "Description1"))
        somethingList.Add(New Something("Name2", "Description2"))
        somethingList.Add(New Something("Name3", "Description3"))
        somethingList.Add(New Something("Name4", "Description4"))
        Return somethingList
    End Function
End Class

Public Class Something
    Implements IDataErrorInfo

    Private m_Name As String
    Private m_Description As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String, ByVal description As String)
        m_Name = name
        m_Description = description
    End Sub

    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(ByVal value As String)
            m_Description = value
        End Set
    End Property

    Public ReadOnly Property [Error]() As String Implements System.ComponentModel.IDataErrorInfo.Error
        Get
            If Not IsNameValid() Then
                Return "Cannot be 'Name' or Empty"
            Else
                Return ""
            End If
        End Get
    End Property

    Default Public ReadOnly Property Item(ByVal columnName As String) As String Implements System.ComponentModel.IDataErrorInfo.Item
        Get
            If columnName = "Name" AndAlso Not IsNameValid() Then
                Return "Not a valid value"
            Else
                Return ""
            End If
        End Get
    End Property

    Private Function IsNameValid() As Boolean
        If String.IsNullOrEmpty(Me.Name) Then
            Return False
        End If
        If String.Equals(Me.Name.ToUpperInvariant(), "NAME") Then
            Return False
        End If
        Return True
    End Function
End Class



