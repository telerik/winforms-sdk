Imports System
Imports System.Collections.Generic
Imports System.Data
Imports Telerik.WinControls.UI

Namespace _1414148
	Partial Public Class RadForm1
		Inherits Telerik.WinControls.UI.RadForm

		Private master As New DataTable()
		Private child As New DataTable()
		Public Sub New()
			InitializeComponent()
			radGridView1.UseScrollbarsInHierarchy = True

			master.Columns.Add("ID", GetType(Integer))
			master.Columns.Add("F_ID", GetType(Integer))
			master.Columns.Add("test", GetType(String))

			child.Columns.Add("F_ID", GetType(Integer))
			child.Columns.Add("test", GetType(String))

			For i As Integer = 0 To 99
				master.Rows.Add(i, i Mod 2, "Row " & i)
				child.Rows.Add(i Mod 2, "Child " & i)
			Next i

			radGridView1.DataSource = master
			Dim template As New GridViewTemplate()
			template.DataSource = child
			radGridView1.MasterTemplate.Templates.Add(template)

			Dim relation As New GridViewRelation(radGridView1.MasterTemplate)
			relation.ChildTemplate = template
			relation.RelationName = "Test"
			relation.ParentColumnNames.Add("F_ID")
			relation.ChildColumnNames.Add("F_ID")
			radGridView1.Relations.Add(relation)
		End Sub


		Private Sub RadButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			Dim scrollBarValue As Integer = radGridView1.TableElement.VScrollBar.Value
			For Each rowToSave As GridViewDataRowInfo In radGridView1.Rows
				SaveExpandedStates(rowToSave)
			Next rowToSave
			radGridView1.DataSource = Nothing
			radGridView1.DataSource = master
			For Each rowToRestore As GridViewDataRowInfo In radGridView1.Rows
				RestoreExpandedStates(rowToRestore)
			Next rowToRestore

			radGridView1.TableElement.VScrollBar.Value = scrollBarValue
		End Sub

		Private Sub SaveExpandedStates(ByVal rowToSave As GridViewDataRowInfo)
			If rowToSave IsNot Nothing AndAlso rowToSave.DataBoundItem IsNot Nothing Then
				If Not nodeStates.ContainsKey(rowToSave.DataBoundItem) Then
					nodeStates.Add(rowToSave.DataBoundItem, New State(rowToSave.IsExpanded, rowToSave.IsCurrent))
				Else
					nodeStates(rowToSave.DataBoundItem) = New State(rowToSave.IsExpanded, rowToSave.IsCurrent)
				End If
			End If
			For Each childRow As GridViewDataRowInfo In rowToSave.ChildRows
				SaveExpandedStates(childRow)
			Next childRow
		End Sub

		Private Sub RestoreExpandedStates(ByVal rowToRestore As GridViewDataRowInfo)
			If rowToRestore IsNot Nothing AndAlso rowToRestore.DataBoundItem IsNot Nothing AndAlso nodeStates.ContainsKey(rowToRestore.DataBoundItem) Then
				rowToRestore.IsExpanded = nodeStates(rowToRestore.DataBoundItem).Expanded
				rowToRestore.IsCurrent = nodeStates(rowToRestore.DataBoundItem).Selected
				rowToRestore.IsSelected = nodeStates(rowToRestore.DataBoundItem).Selected
			End If

			For Each childRow As GridViewDataRowInfo In rowToRestore.ChildRows
				RestoreExpandedStates(childRow)
			Next childRow
		End Sub

		Private nodeStates As New Dictionary(Of Object, State)()

		Private Structure State
			Public Property Expanded() As Boolean

			Public Property Selected() As Boolean

			Public Sub New(ByVal expanded As Boolean, ByVal selected As Boolean)
				Me.New()
				Me.Expanded = expanded
				Me.Selected = selected
			End Sub
		End Structure
	End Class
End Namespace
