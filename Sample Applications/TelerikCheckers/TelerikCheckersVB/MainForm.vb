Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Enumerations

Namespace TelerikCheckers
	Public Partial Class MainForm
		Inherits RadForm
		Private alphabet As List(Of String)
		Private squareDim As Integer = 60
		Private headerRectDim As Integer = 30
		Private turn As Turn = Turn.Black
		Private draggedCell As GridDataCellElement = Nothing
		Private dragDropService As RadDragDropService
		Private draggedValue As String
		Private DRAGIMAGE As Boolean
		Private CANFORMAT As Boolean
		Private DRAGRESTRICTIONS As Boolean
		Private DROPRESTRICTIONS As Boolean
		Private MOVECELLCONTENT As Boolean

		#Region "Initialization"

		Public Sub New()
			InitializeComponent()

			dragDropService = Me.radGridView1.GridViewElement.GetService(Of RadDragDropService)()

			alphabet = New List(Of String)()
			alphabet.Add("A")
			alphabet.Add("B")
			alphabet.Add("C")
			alphabet.Add("D")
			alphabet.Add("E")
			alphabet.Add("F")
			alphabet.Add("G")
			alphabet.Add("H")
			alphabet.Add("I")

			Me.radCheckBox1.ToggleState = ToggleState.On
			Me.radCheckBox2.ToggleState = ToggleState.On
			Me.radCheckBox3.ToggleState = ToggleState.On
			Me.radCheckBox4.ToggleState = ToggleState.On
			Me.radCheckBox5.ToggleState = ToggleState.On

			InitializeTheme()
			InitializeEvents()
			InitializeGrid()
		End Sub

		Private Sub InitializeTheme()
            ThemeResolutionService.LoadPackageResource("CheckersTheme.tssp")
			Dim themeName As String = "CheckersTheme"
			Me.radButton1.ThemeName = themeName
			Me.radPanel4.ThemeName = themeName
			Me.radPanel2.ThemeName = themeName
			Me.radPanel5.ThemeName = themeName
			Me.radPanel3.ThemeName = themeName

			Dim chThemeName As String = "Desert"
			Me.radCheckBox1.ThemeName = chThemeName
			Me.radCheckBox2.ThemeName = chThemeName
			Me.radCheckBox3.ThemeName = chThemeName
			Me.radCheckBox4.ThemeName = chThemeName
			Me.radCheckBox5.ThemeName = chThemeName

			Me.radGridView1.GridViewElement.BorderBoxStyle = BorderBoxStyle.SingleBorder
			Me.radGridView1.GridViewElement.BorderGradientStyle = GradientStyles.Solid

			pictureBox1.Image = CheckersBoard.BlackChecker
		End Sub

		Private Sub InitializeEvents()
            AddHandler dragDropService.PreviewDragOver, AddressOf dragDropService_PreviewDragOver
            AddHandler dragDropService.PreviewDragDrop, AddressOf dragDropService_PreviewDragDrop
            AddHandler dragDropService.PreviewDropTarget, AddressOf dragDropService_PreviewDropTarget
			AddHandler radGridView1.MouseDown, AddressOf radGridView1_MouseDown
            AddHandler dragDropService.PreviewDragHint, AddressOf dragDropService_PreviewDragHint
            AddHandler dragDropService.Stopping, AddressOf dragDropService_Stopping
			AddHandler radGridView1.ViewCellFormatting, AddressOf radGridView1_ViewCellFormatting
			AddHandler radGridView1.ContextMenuOpening, AddressOf radGridView1_ContextMenuOpening
		End Sub

		Private Sub InitializeGrid()
			Me.radGridView1.Padding = New Padding(0)
			Me.radGridView1.ReadOnly = True
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.EnableGrouping = False
			Me.radGridView1.EnableSorting = False
			Me.radGridView1.AllowColumnReorder = False
			Me.radGridView1.AllowRowResize = False
			Me.radGridView1.AllowColumnResize = False
			Me.radGridView1.GridViewElement.BorderColor = CheckersBoard.BorderOuterColor
			Me.radGridView1.TableElement.RowHeight = squareDim
			Me.radGridView1.MasterView.TableHeaderRow.Height = headerRectDim
			Me.radGridView1.TableElement.RowHeaderColumnWidth = headerRectDim

			Me.radGridView1.TableElement.CurrentRowHeaderImage = Nothing

			Me.radGridView1.AutoSize = True

			For i As Integer = 0 To 7
				Dim col As GridViewTextBoxColumn = New GridViewTextBoxColumn()
				col.HeaderText = alphabet(i)
				col.Width = squareDim
				Me.radGridView1.Columns.Add(col)
			Next i

			For i As Integer = 0 To 7
				Me.radGridView1.Rows.AddNew()
			Next i
		End Sub

		Private Sub radButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButton1.Click
			For j As Integer = 0 To 7
				For i As Integer = 0 To 7
					Me.radGridView1.Rows(i).Cells(j).Value = Nothing
				Next i
			Next j

			For j As Integer = 0 To 7
				For i As Integer = 7 To 5 Step -1
					If (i + j) Mod 2 <> 0 Then
						Me.radGridView1.Rows(i).Cells(j).Value = CheckersBoard.BLACK
					End If
				Next i

				For i As Integer = 0 To 2
					If (i + j) Mod 2 <> 0 Then
						Me.radGridView1.Rows(i).Cells(j).Value = CheckersBoard.WHITE
					End If
				Next i
			Next j

			CheckersBoard.blackTaken = 0
			CheckersBoard.whiteTaken = 0

			pictureBox1.Image = CheckersBoard.BlackChecker
			turn = Turn.Black

			CheckersBoard.shouldTakeChecker = False
		End Sub

		#End Region

		#Region "Styling"

		Private Sub SetTableHeaderCellElementStyle(ByVal cell As GridCellElement)
			cell.BackColor = Color.FromArgb(82, 38, 11)
			cell.GradientStyle = GradientStyles.Solid
			cell.BorderBoxStyle = BorderBoxStyle.SingleBorder
		End Sub

		Private Sub SetCommonStyleProperties(ByVal cell As GridCellElement)
			cell.DrawFill = True
			cell.ImageLayout = ImageLayout.Stretch
			cell.BorderColor = CheckersBoard.BorderOuterColor
			cell.BorderGradientStyle = GradientStyles.Solid
			cell.BorderBoxStyle = BorderBoxStyle.OuterInnerBorders
		End Sub

		Private Sub SetDataCellElementStyle(ByVal cell As GridCellElement)
			cell.GradientStyle = GradientStyles.Solid
			If (cell.RowIndex + cell.ColumnIndex) Mod 2 = 0 Then
				cell.BackColor = CheckersBoard.BackLightColor
				cell.BorderInnerColor = Color.FromArgb(247, 196, 104)
			Else
				cell.BackColor = CheckersBoard.BackDarkColor
				cell.BorderInnerColor = Color.FromArgb(152, 87, 34)
			End If
		End Sub

		Private Sub SetHeaderCellElementStyle(ByVal cell As GridCellElement)
			cell.GradientStyle = GradientStyles.Linear
			cell.NumberOfColors = 4
			cell.BackColor = Color.FromArgb(59, 27, 8)
			cell.BackColor2 = Color.FromArgb(65, 30, 9)
			cell.BackColor3 = Color.FromArgb(81, 38, 11)
			cell.BackColor4 = Color.FromArgb(88, 41, 12)
			cell.BorderBoxStyle = BorderBoxStyle.SingleBorder
			cell.BorderColor = Color.FromArgb(49, 23, 7)
			cell.ForeColor = Color.FromArgb(223, 177, 94)
			cell.GradientPercentage = 0.3f
			cell.GradientPercentage2 = 0.6f
		End Sub

		Private Sub SetRowHeaderCellElementStyle(ByVal cell As GridCellElement)
			cell.Text = (8 - cell.RowIndex).ToString()

			cell.GradientAngle = 0
			cell.GradientStyle = GradientStyles.Linear
			cell.NumberOfColors = 4
			cell.BackColor = Color.FromArgb(59, 27, 8)
			cell.BackColor2 = Color.FromArgb(65, 30, 9)
			cell.BackColor3 = Color.FromArgb(81, 38, 11)
			cell.BackColor4 = Color.FromArgb(88, 41, 12)
			cell.BorderBoxStyle = BorderBoxStyle.SingleBorder
			cell.BorderColor = Color.FromArgb(49, 23, 7)
			cell.ForeColor = Color.FromArgb(223, 177, 94)
			cell.GradientPercentage = 0.3f
			cell.GradientPercentage2 = 0.6f
		End Sub

		Private Sub SetImages(ByVal cell As GridCellElement)
			If Not cell.Value Is Nothing Then
				Dim cellValue As String = cell.Value.ToString()
				If cellValue = CheckersBoard.WHITE Then
					cell.Image = CheckersBoard.WhiteChecker
				ElseIf cellValue = CheckersBoard.BLACK Then
					cell.Image = CheckersBoard.BlackChecker
				ElseIf cellValue = CheckersBoard.BLACKKING Then
					cell.Image = CheckersBoard.BlackCheckerKing
				ElseIf cellValue = CheckersBoard.WHITEKING Then
					cell.Image = CheckersBoard.WhiteCheckerKing
				Else
					cell.Image = Nothing
				End If

				If TypeOf cell Is GridDataCellElement Then
					cell.Text = String.Empty
				End If
			Else
				cell.Image = Nothing
			End If
		End Sub

		Private Sub ResetCellValues(ByVal cell As GridCellElement)
			cell.ResetValue(LightVisualElement.ImageProperty, ValueResetFlags.Local)
			cell.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local)
			cell.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local)
			cell.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
			cell.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
			cell.ResetValue(LightVisualElement.ImageLayoutProperty, ValueResetFlags.Local)
			cell.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local)
			cell.ResetValue(LightVisualElement.BorderInnerColorProperty, ValueResetFlags.Local)
			cell.ResetValue(LightVisualElement.BorderGradientStyleProperty, ValueResetFlags.Local)
			cell.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local)

			If TypeOf cell Is GridRowHeaderCellElement Then
				cell.ResetValue(RadItem.TextProperty, ValueResetFlags.Local)
			End If

			If Not cell.Value Is Nothing AndAlso TypeOf cell Is GridDataCellElement Then
				cell.Text = cell.Value.ToString()
			End If
		End Sub

		Private Sub radGridView1_ContextMenuOpening(ByVal sender As Object, ByVal e As ContextMenuOpeningEventArgs)
			e.Cancel = True
		End Sub

		Private Sub radGridView1_ViewCellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs)
			If CANFORMAT Then
				SetCommonStyleProperties(e.CellElement)

				If TypeOf e.CellElement Is GridRowHeaderCellElement AndAlso Not(TypeOf e.CellElement Is GridTableHeaderCellElement) Then
					SetRowHeaderCellElementStyle(e.CellElement)
				End If

				If TypeOf e.CellElement Is GridHeaderCellElement Then
					SetHeaderCellElementStyle(e.CellElement)
				End If

				If TypeOf e.CellElement Is GridTableHeaderCellElement Then
					SetTableHeaderCellElementStyle(e.CellElement)
				End If

				If TypeOf e.CellElement Is GridDataCellElement Then
					SetDataCellElementStyle(e.CellElement)
				End If

				SetImages(e.CellElement)
			Else
				ResetCellValues(e.CellElement)
			End If
		End Sub

		#End Region

		#Region "Drag'n'Drop implementation"

		Private Sub radGridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim element As RadElement = Me.radGridView1.ElementTree.GetElementAtPoint(e.Location)
			Dim dataCell As GridDataCellElement = TryCast(element, GridDataCellElement)
			If Not dataCell Is Nothing Then
				If Not dataCell.Value Is Nothing Then
					draggedCell = Nothing

					If (Not DRAGRESTRICTIONS) Then
						dataCell.AllowDrag = True
						dragDropService.Start(dataCell)
						Return
					End If

					If CheckersBoard.CanCheckerBeDragged(turn, dataCell) Then
						dataCell.AllowDrag = True
						dragDropService.Start(dataCell)
					End If
				End If
			End If
		End Sub

		Private Sub dragDropService_PreviewDragHint(ByVal sender As Object, ByVal e As PreviewDragHintEventArgs)
			If TypeOf e.DragInstance Is GridDataCellElement Then
				Dim dataCell As GridDataCellElement = CType(e.DragInstance, GridDataCellElement)
				draggedValue = dataCell.Value.ToString()

				If MOVECELLCONTENT Then
					dataCell.Value = Nothing
				End If

				If DRAGIMAGE Then
					If draggedValue = CheckersBoard.WHITE Then
						e.DragHint = CheckersBoard.BigWhiteChecker
					ElseIf draggedValue = CheckersBoard.BLACK Then
						e.DragHint = CheckersBoard.BigBlackChecker
					ElseIf draggedValue = CheckersBoard.BLACKKING Then
						e.DragHint = CheckersBoard.BigBlackCheckerKing
					ElseIf draggedValue = CheckersBoard.WHITEKING Then
						e.DragHint = CheckersBoard.BigWhiteCheckerKing
					End If
				End If
			End If
		End Sub

		Private Sub dragDropService_PreviewDropTarget(ByVal sender As Object, ByVal e As PreviewDropTargetEventArgs)
			Dim targetCell As GridDataCellElement = TryCast(e.HitTarget, GridDataCellElement)
			draggedCell = TryCast(e.DragInstance, GridDataCellElement)
			If Not targetCell Is Nothing Then
				If TypeOf targetCell.ColumnInfo Is GridViewTextBoxColumn Then
					If (Not DROPRESTRICTIONS) Then
						targetCell.AllowDrop = True
						Return
					End If

					targetCell.AllowDrop = CheckersBoard.CanDrop(targetCell, draggedCell, draggedValue.ToString())
				End If
			End If
		End Sub

		Private Sub dragDropService_PreviewDragOver(ByVal sender As Object, ByVal e As RadDragOverEventArgs)
			Dim targetCell As GridDataCellElement = TryCast(e.HitTarget, GridDataCellElement)
			If Not targetCell Is Nothing Then
				If TypeOf targetCell.ColumnInfo Is GridViewTextBoxColumn Then
					e.CanDrop = TypeOf e.HitTarget Is GridDataCellElement
				End If
			End If
		End Sub

		Private Sub dragDropService_PreviewDragDrop(ByVal sender As Object, ByVal e As RadDropEventArgs)
			Dim targetCell As GridDataCellElement = TryCast(e.HitTarget, GridDataCellElement)
			If TypeOf targetCell.ColumnInfo Is GridViewTextBoxColumn Then
				Dim dropCell As GridDataCellElement = TryCast(e.DragInstance, GridDataCellElement)
				If Not dropCell Is Nothing Then
					If turn = Turn.Black Then
						targetCell.Value = draggedValue

						TakeWhiteChecker()
						TurnBlackCheckerIntoKing(targetCell)
					Else
						targetCell.Value = draggedValue

						TakeBlackChecker()
						TurnWhiteCheckerIntoKing(targetCell)
					End If

					Me.radLabel4.Text = CheckersBoard.whiteTaken.ToString() & " x"
					Me.radLabel5.Text = CheckersBoard.blackTaken.ToString() & " x"

					If CheckersBoard.rowIndex <> -1 AndAlso CheckersBoard.columnIndex <> -1 Then
						If (Not CheckersBoard.CanHitMoreCheckersInRow(turn, targetCell)) Then
							ChangeTurn()
						Else
							CheckersBoard.shouldTakeChecker = True
						End If
					Else
						ChangeTurn()
					End If

					CheckersBoard.IsWinner(turn)
				End If
			End If
		End Sub



		Private Sub dragDropService_Stopping(ByVal sender As Object, ByVal e As RadServiceStoppingEventArgs)
			If Not draggedCell Is Nothing Then
				If (Not e.Commit) Then
					If MOVECELLCONTENT Then
						draggedCell.Value = draggedValue
					End If
				End If

				draggedCell.AllowDrag = False
			End If
		End Sub

		#End Region

		#Region "Helper Methods"

		Private Sub TurnBlackCheckerIntoKing(ByVal targetCell As GridDataCellElement)
			If CheckersBoard.IsLastRow(targetCell) Then
				If CheckersBoard.blackTaken > 0 Then
					CheckersBoard.blackTaken -= 1
					targetCell.Value = CheckersBoard.BLACKKING
				Else
					targetCell.Value = draggedValue
				End If
			End If
		End Sub

		Private Sub TurnWhiteCheckerIntoKing(ByVal targetCell As GridDataCellElement)
			If CheckersBoard.IsLastRow(targetCell) Then
				If CheckersBoard.whiteTaken > 0 Then
					CheckersBoard.whiteTaken -= 1
					targetCell.Value = CheckersBoard.WHITEKING
				Else
					targetCell.Value = draggedValue
				End If
			End If
		End Sub

		Private Sub TakeBlackChecker()
			If CheckersBoard.rowIndex <> -1 AndAlso CheckersBoard.columnIndex <> -1 Then
				CheckersBoard.blackTaken += 1
				If Me.radGridView1.Rows(CheckersBoard.rowIndex).Cells(CheckersBoard.columnIndex).Value.ToString() = CheckersBoard.BLACKKING Then
					CheckersBoard.blackTaken += 1
				End If

				Me.radGridView1.Rows(CheckersBoard.rowIndex).Cells(CheckersBoard.columnIndex).Value = Nothing

				TurnCheckerOnTheKingRowInKing(turn)
			End If
		End Sub

		Private Sub TakeWhiteChecker()
			If CheckersBoard.rowIndex <> -1 AndAlso CheckersBoard.columnIndex <> -1 Then
				CheckersBoard.whiteTaken += 1
				If Me.radGridView1.Rows(CheckersBoard.rowIndex).Cells(CheckersBoard.columnIndex).Value.ToString() = CheckersBoard.WHITEKING Then
					CheckersBoard.whiteTaken += 1
				End If

				Me.radGridView1.Rows(CheckersBoard.rowIndex).Cells(CheckersBoard.columnIndex).Value = Nothing

				TurnCheckerOnTheKingRowInKing(turn)
			End If
		End Sub

		Private Sub TurnCheckerOnTheKingRowInKing(ByVal turn As Turn)
			If turn = Turn.Black Then
				Dim i As Integer = 0
				Do While i < Me.radGridView1.Columns.Count
					If Not Me.radGridView1.Rows(7).Cells(i).Value Is Nothing Then
						If Me.radGridView1.Rows(7).Cells(i).Value.ToString() = CheckersBoard.WHITE Then
							Me.radGridView1.Rows(7).Cells(i).Value = CheckersBoard.WHITEKING
							CheckersBoard.whiteTaken -= 1
							Exit Do
						End If
					End If
					i += 1
				Loop
			Else
				Dim i As Integer = 0
				Do While i < Me.radGridView1.Columns.Count
					If Not Me.radGridView1.Rows(0).Cells(i).Value Is Nothing Then
						If Me.radGridView1.Rows(0).Cells(i).Value.ToString() = CheckersBoard.BLACK Then
							Me.radGridView1.Rows(0).Cells(i).Value = CheckersBoard.BLACKKING
							CheckersBoard.blackTaken -= 1
							Exit Do
						End If
					End If
					i += 1
				Loop
			End If
		End Sub

		Private Sub ChangeTurn()
			If turn = Turn.Black Then
				turn = Turn.White
				pictureBox1.Image = CheckersBoard.WhiteChecker
			Else
				turn = Turn.Black
				pictureBox1.Image = CheckersBoard.BlackChecker
			End If

			CheckersBoard.shouldTakeChecker = False
		End Sub

		#End Region

		#Region "Restrictions"

		Private Sub radCheckBox1_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox1.ToggleStateChanged
			If args.ToggleState = ToggleState.On Then
				CANFORMAT = True
			Else
				CANFORMAT = False
			End If

			Me.radGridView1.TableElement.Update(GridUINotifyAction.StateChanged)
		End Sub

		Private Sub radCheckBox2_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox2.ToggleStateChanged
			If args.ToggleState = ToggleState.On Then
				DRAGIMAGE = True
			Else
				DRAGIMAGE = False
			End If
		End Sub

		Private Sub radCheckBox3_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox3.ToggleStateChanged
			If args.ToggleState = ToggleState.On Then
				MOVECELLCONTENT = True
			Else
				MOVECELLCONTENT = False
			End If
		End Sub

		Private Sub radCheckBox4_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox4.ToggleStateChanged
			If args.ToggleState = ToggleState.On Then
				DRAGRESTRICTIONS = True
			Else
				DRAGRESTRICTIONS = False
			End If
		End Sub

		Private Sub radCheckBox5_ToggleStateChanged(ByVal sender As Object, ByVal args As StateChangedEventArgs) Handles radCheckBox5.ToggleStateChanged
			If args.ToggleState = ToggleState.On Then
				DROPRESTRICTIONS = True
			Else
				DROPRESTRICTIONS = False
			End If
		End Sub

		#End Region
	End Class
End Namespace
