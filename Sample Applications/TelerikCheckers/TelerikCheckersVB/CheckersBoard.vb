Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports TelerikCheckers.Properties
Imports Telerik.WinControls

Namespace TelerikCheckers
	Public Class CheckersBoard
		Public Shared BigBlackChecker As Image = New Bitmap(Resources.checker_black, New Size(80, 80))
		Public Shared BigWhiteChecker As Image = New Bitmap(Resources.checker_white, New Size(80, 80))
		Public Shared BigBlackCheckerKing As Image = New Bitmap(Resources.checker_black_king, New Size(80, 80))
		Public Shared BigWhiteCheckerKing As Image = New Bitmap(Resources.checker_white_king, New Size(80, 80))
		Public Shared BlackChecker As Image = Resources.checker_black
		Public Shared WhiteChecker As Image = Resources.checker_white
		Public Shared BlackCheckerKing As Image = Resources.checker_black_king
		Public Shared WhiteCheckerKing As Image = Resources.checker_white_king

		Public Shared BorderOuterColor As Color = Color.FromArgb(58, 27, 8)
		Public Shared BorderInnerColor As Color = Color.FromArgb(248, 229, 196)
		Public Shared FontColor As Color = Color.FromArgb(248, 229, 196)
		Public Shared BackDarkColor As Color = Color.FromArgb(132, 62, 17)
		Public Shared BackLightColor As Color = Color.FromArgb(223, 177, 94)

		Public Shared WHITE As String = "W"
		Public Shared BLACK As String = "B"
		Public Shared WHITEKING As String = "WC"
		Public Shared BLACKKING As String = "BC"
		Public Shared whiteTaken As Integer = 0
		Public Shared blackTaken As Integer = 0
		Public Shared rowIndex As Integer = -1
		Public Shared columnIndex As Integer = -1
		Public Shared shouldTakeChecker As Boolean = False

		Public Shared Function CanCheckerBeDragged(ByVal turn As Turn, ByVal cell As GridDataCellElement) As Boolean
			Dim value As String = cell.Value.ToString()
			If (value = WHITE AndAlso turn = Turn.White) OrElse (value = BLACK AndAlso turn = Turn.Black) OrElse (value = WHITEKING AndAlso turn = Turn.White) OrElse (value = BLACKKING AndAlso turn = Turn.Black) Then
				Return True
			End If
			Return False
		End Function

		Public Shared Function CanHitMoreCheckersInRow(ByVal turn As Turn, ByVal targetCell As GridDataCellElement) As Boolean
			Dim grid As RadGridView = targetCell.GridControl

			If turn = Turn.Black Then
				' top-right direction
				If targetCell.RowIndex - 2 > -1 AndAlso targetCell.ColumnIndex + 2 < 8 Then
					Dim value As Object = grid.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex + 1).Value
					If Not value Is Nothing Then
						Dim stringValue As String = value.ToString()
						If (stringValue = CheckersBoard.WHITE OrElse stringValue = CheckersBoard.WHITEKING) AndAlso grid.Rows(targetCell.RowIndex - 2).Cells(targetCell.ColumnIndex + 2).Value Is Nothing Then
							Return True
						End If
					End If
				End If

				' top-left direction
				If targetCell.RowIndex - 2 > -1 AndAlso targetCell.ColumnIndex - 2 > -1 Then
					Dim value As Object = grid.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex - 1).Value
					If Not value Is Nothing Then
						Dim stringValue As String = value.ToString()
						If (stringValue = CheckersBoard.WHITE OrElse stringValue = CheckersBoard.WHITEKING) AndAlso grid.Rows(targetCell.RowIndex - 2).Cells(targetCell.ColumnIndex - 2).Value Is Nothing Then
							Return True
						End If
					End If
				End If

				If targetCell.Value.ToString() = CheckersBoard.BLACKKING Then
					' bottom-right direction
					If targetCell.RowIndex + 2 < 8 AndAlso targetCell.ColumnIndex + 2 < 8 Then
						Dim value As Object = grid.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex + 1).Value
						If Not value Is Nothing Then
							Dim stringValue As String = value.ToString()
							If (stringValue = CheckersBoard.WHITE OrElse stringValue = CheckersBoard.WHITEKING) AndAlso grid.Rows(targetCell.RowIndex + 2).Cells(targetCell.ColumnIndex + 2).Value Is Nothing Then
								Return True
							End If
						End If
					End If

					' bottom-left direction
					If targetCell.RowIndex + 2 < 8 AndAlso targetCell.ColumnIndex - 2 > -1 Then

						Dim value As Object = grid.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex - 1).Value
						If Not value Is Nothing Then
							Dim stringValue As String = value.ToString()
							If (stringValue = CheckersBoard.WHITE OrElse stringValue = CheckersBoard.WHITEKING) AndAlso grid.Rows(targetCell.RowIndex + 2).Cells(targetCell.ColumnIndex - 1).Value Is Nothing Then
								Return True
							End If
						End If
					End If
				End If
			Else
				' bottom-right direction
				If targetCell.RowIndex + 2 < 8 AndAlso targetCell.ColumnIndex + 2 < 8 Then

					Dim value As Object = grid.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex + 1).Value
					If Not value Is Nothing Then
						Dim stringValue As String = value.ToString()
						If (stringValue = CheckersBoard.WHITE OrElse stringValue = CheckersBoard.WHITEKING) AndAlso grid.Rows(targetCell.RowIndex + 2).Cells(targetCell.ColumnIndex + 2).Value Is Nothing Then
							Return True
						End If
					End If
				End If

				' bottom-left direction
				If targetCell.RowIndex + 2 < 8 AndAlso targetCell.ColumnIndex - 2 > -1 Then
					Dim value As Object = grid.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex - 1).Value
					If Not value Is Nothing Then
						Dim stringValue As String = value.ToString()
						If (stringValue = CheckersBoard.WHITE OrElse stringValue = CheckersBoard.WHITEKING) AndAlso grid.Rows(targetCell.RowIndex + 2).Cells(targetCell.ColumnIndex - 1).Value Is Nothing Then
							Return True
						End If
					End If
				End If

				If targetCell.Value.ToString() = CheckersBoard.WHITEKING Then
					' top-right direction
					If targetCell.RowIndex - 2 > -1 AndAlso targetCell.ColumnIndex + 2 < 8 Then
						Dim value As Object = grid.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex + 1).Value
						If Not value Is Nothing Then
							Dim stringValue As String = value.ToString()
							If (stringValue = CheckersBoard.WHITE OrElse stringValue = CheckersBoard.WHITEKING) AndAlso grid.Rows(targetCell.RowIndex - 2).Cells(targetCell.ColumnIndex + 2).Value Is Nothing Then
								Return True
							End If
						End If
					End If

					' top-left direction
					If targetCell.RowIndex - 2 > -1 AndAlso targetCell.ColumnIndex - 2 > -1 Then
						Dim value As Object = grid.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex - 1).Value
						If Not value Is Nothing Then
							Dim stringValue As String = value.ToString()
							If (stringValue = CheckersBoard.WHITE OrElse stringValue = CheckersBoard.WHITEKING) AndAlso grid.Rows(targetCell.RowIndex - 2).Cells(targetCell.ColumnIndex - 1).Value Is Nothing Then
								Return True
							End If
						End If
					End If
				End If
			End If

			Return False
		End Function

		Public Shared Function IsLastRow(ByVal targetCell As GridDataCellElement) As Boolean
			If targetCell.RowIndex = 0 OrElse targetCell.RowIndex = 7 Then
				Return True
			End If

			Return False
		End Function

		Public Shared Function IsCheckerWhite(ByVal checker As String) As Boolean
			If checker = WHITE OrElse checker = WHITEKING Then
				Return True
			End If
			Return False
		End Function

		Public Shared Function IsCheckerBlack(ByVal checker As String) As Boolean
			If checker = BLACK OrElse checker = BLACKKING Then
				Return True
			End If
			Return False
		End Function

		Public Shared Function CanDrop(ByVal targetCell As GridDataCellElement, ByVal draggedCell As GridDataCellElement, ByVal draggedValue As String) As Boolean
			rowIndex = -1
			columnIndex = -1

			' you can't drag one checker on another
			If Not targetCell.Value Is Nothing Then
				Return False
			End If

			' you can't drag a checker on a white square
			If (targetCell.RowIndex + targetCell.ColumnIndex) Mod 2 = 0 Then
				Return False
			End If

			If (Not CheckersBoard.shouldTakeChecker) Then
				' move only up
				If draggedValue = BLACK Then
					If draggedCell.RowIndex - targetCell.RowIndex = 1 AndAlso Math.Abs(draggedCell.ColumnIndex - targetCell.ColumnIndex) = 1 Then
						Return True
					End If
				End If

				' move only down
				If draggedValue = WHITE Then
					If targetCell.RowIndex - draggedCell.RowIndex = 1 AndAlso Math.Abs(draggedCell.ColumnIndex - targetCell.ColumnIndex) = 1 Then
						Return True
					End If
				End If

				' king can be moved up and down
				If draggedValue = BLACKKING Then
					If Math.Abs(draggedCell.RowIndex - targetCell.RowIndex) = 1 AndAlso Math.Abs(draggedCell.ColumnIndex - targetCell.ColumnIndex) = 1 Then
						Return True
					End If
				End If

				' king can be moved up and down
				If draggedValue = WHITEKING Then
					If Math.Abs(draggedCell.RowIndex - targetCell.RowIndex) = 1 AndAlso Math.Abs(draggedCell.ColumnIndex - targetCell.ColumnIndex) = 1 Then
						Return True
					End If
				End If
			End If

			' if black checker is dragged over a white (or white king) checker
			If draggedValue = BLACK Then
				' top
				If targetCell.RowIndex - draggedCell.RowIndex = -2 Then
					' top-right possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = 2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex - 1).Value
						If Not val Is Nothing Then
							Dim stringValue As String = val.ToString()
							If stringValue = WHITE OrElse stringValue = WHITEKING Then
								rowIndex = targetCell.RowIndex + 1
								columnIndex = targetCell.ColumnIndex - 1
								Return True
							End If
						End If
					End If

					' top-left possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = -2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex + 1).Value
						If Not val Is Nothing Then
							Dim stringValue As String = val.ToString()
							If Not stringValue Is Nothing Then
								If stringValue = WHITE OrElse stringValue = WHITEKING Then
									rowIndex = targetCell.RowIndex + 1
									columnIndex = targetCell.ColumnIndex + 1
									Return True
								End If
							End If
						End If
					End If
				End If
			End If

			' if white checker is dragged over a black (or black king) checker
			If draggedValue = WHITE Then
				' top
				If targetCell.RowIndex - draggedCell.RowIndex = 2 Then
					' bottom-right possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = 2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex - 1).Value
						If Not val Is Nothing Then
							Dim stringValue As String = val.ToString()
							If stringValue = BLACK OrElse stringValue = BLACKKING Then
								rowIndex = targetCell.RowIndex - 1
								columnIndex = targetCell.ColumnIndex - 1
								Return True
							End If
						End If
					End If

					' bottom-left possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = -2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex + 1).Value
						If Not val Is Nothing Then
							Dim stringValue As String = val.ToString()
							If stringValue = BLACK OrElse stringValue = BLACKKING Then
								rowIndex = targetCell.RowIndex - 1
								columnIndex = targetCell.ColumnIndex + 1
								Return True
							End If
						End If
					End If
				End If
			End If

			' if black king checker is dragged over a white (or white king) checker
			If draggedValue = BLACKKING Then
				' to-bottom
				If targetCell.RowIndex - draggedCell.RowIndex = 2 Then
					' bottom-right possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = 2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex - 1).Value
						If Not val Is Nothing Then
							Dim stringValue As String = val.ToString()
							If stringValue = WHITE OrElse stringValue = WHITEKING Then
								rowIndex = targetCell.RowIndex - 1
								columnIndex = targetCell.ColumnIndex - 1
								Return True
							End If
						End If
					End If

					' bottom-left possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = -2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex + 1).Value
						If Not val Is Nothing Then
							Dim objectValue As String = val.ToString()
							If objectValue = WHITE OrElse objectValue = WHITEKING Then
								rowIndex = targetCell.RowIndex - 1
								columnIndex = targetCell.ColumnIndex + 1
								Return True
							End If
						End If
					End If
				End If

				' to-top
				If targetCell.RowIndex - draggedCell.RowIndex = -2 Then
					' top-right possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = 2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex - 1).Value
						If Not val Is Nothing Then
							Dim stringValue As String = val.ToString()
							If stringValue = WHITE OrElse stringValue = WHITEKING Then
								rowIndex = targetCell.RowIndex + 1
								columnIndex = targetCell.ColumnIndex - 1
								Return True
							End If
						End If
					End If

					' top-left possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = -2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex + 1).Value
						If Not val Is Nothing Then
							Dim objectValue As String = val.ToString()
							If objectValue = WHITE OrElse objectValue = WHITEKING Then
								rowIndex = targetCell.RowIndex + 1
								columnIndex = targetCell.ColumnIndex + 1
								Return True
							End If
						End If
					End If
				End If
			End If

			' if white checker is dragged over a black (or black king) checker
			If draggedValue = WHITEKING Then
				' to-bottom
				If targetCell.RowIndex - draggedCell.RowIndex = 2 Then
					' bottom-right possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = 2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex - 1).Value
						If Not val Is Nothing Then
							Dim stringValue As String = val.ToString()
							If stringValue = BLACK OrElse stringValue = BLACKKING Then
								rowIndex = targetCell.RowIndex - 1
								columnIndex = targetCell.ColumnIndex - 1
								Return True
							End If
						End If
					End If

					' bottom-left possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = -2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex - 1).Cells(targetCell.ColumnIndex + 1).Value
						If Not val Is Nothing Then
							Dim objectValue As String = val.ToString()
							If objectValue = BLACK OrElse objectValue = BLACKKING Then
								rowIndex = targetCell.RowIndex - 1
								columnIndex = targetCell.ColumnIndex + 1
								Return True
							End If
						End If
					End If
				End If

				' to-top
				If targetCell.RowIndex - draggedCell.RowIndex = -2 Then
					' top-right possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = 2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex - 1).Value
						If Not val Is Nothing Then
							Dim stringValue As String = val.ToString()
							If stringValue = BLACK OrElse stringValue = BLACKKING Then
								rowIndex = targetCell.RowIndex + 1
								columnIndex = targetCell.ColumnIndex - 1
								Return True
							End If
						End If
					End If

					' top-left possible square
					If targetCell.ColumnIndex - draggedCell.ColumnIndex = -2 Then
						Dim val As Object = targetCell.ViewInfo.Rows(targetCell.RowIndex + 1).Cells(targetCell.ColumnIndex + 1).Value
						If Not val Is Nothing Then
							Dim objectValue As String = val.ToString()
							If objectValue = BLACK OrElse objectValue = WHITEKING Then
								rowIndex = targetCell.RowIndex + 1
								columnIndex = targetCell.ColumnIndex + 1
								Return True
							End If
						End If
					End If
				End If
			End If
			Return False
		End Function

		Public Shared Sub IsWinner(ByVal turn As Turn)
			If turn = Turn.Black Then
				If blackTaken = 12 Then
					RadMessageBox.Show("White wins!")
				End If
			Else
				If whiteTaken = 12 Then
					RadMessageBox.Show("Black wins!")
				End If
			End If
		End Sub
	End Class
End Namespace
