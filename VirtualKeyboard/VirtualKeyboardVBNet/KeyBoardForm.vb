'''**************************** Module Header ******************************\
''' * Module Name:  KeyBoardForm.cs
''' * Project:      CSSoftKeyboard
''' * Copyright (c) Microsoft Corporation.
''' * 
''' * This is the main form that represents a soft keyboard. When the form is 
''' * being loaded, it will load the KeysMapping.xml to initialize the keyboard
''' * buttons. 
''' * 
''' * 
''' * This source is subject to the Microsoft Public License.
''' * See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
''' * All other rights reserved.
''' * 
''' * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
''' * EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
''' * WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'''\**************************************************************************

Imports System.Linq
Imports CSSoftKeyboard.Controls
Imports Telerik.WinControls

Namespace CSSoftKeyboard
	Partial Public Class KeyBoardForm
		Inherits CSSoftKeyboard.NoActivate.NoActivateWindow

'INSTANT VB NOTE: The variable keyButtonList was renamed since Visual Basic does not allow class members with the same name:
		Private keyButtonList_Renamed As IEnumerable(Of KeyButton) = Nothing
		Private ReadOnly Property KeyButtonList() As IEnumerable(Of KeyButton)
			Get
				If keyButtonList_Renamed Is Nothing Then
					keyButtonList_Renamed = Me.tableLayoutPanelKeyButtons.Controls.OfType(Of KeyButton)()
				End If
				Return keyButtonList_Renamed
			End Get
		End Property


'INSTANT VB NOTE: The variable pressedModifierKeyCodes was renamed since Visual Basic does not allow class members with the same name:
		Private pressedModifierKeyCodes_Renamed As List(Of Integer) = Nothing

		''' <summary>
		''' The pressed modifier keys.
		''' </summary>
		Private ReadOnly Property PressedModifierKeyCodes() As List(Of Integer)
			Get
				If pressedModifierKeyCodes_Renamed Is Nothing Then
					pressedModifierKeyCodes_Renamed = New List(Of Integer)()
				End If
				Return pressedModifierKeyCodes_Renamed
			End Get
		End Property


		Public Sub New()
			InitializeComponent()

			ThemeResolutionService.ApplicationThemeName = "Fluent"
		End Sub

		#Region "Handle key board event"

		Private Sub KeyBoardForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Try
				InitializeKeyButtons()
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try

			' Register the key button click event.
			For Each btn As KeyButton In Me.KeyButtonList
				AddHandler btn.Click, AddressOf KeyButton_Click
			Next btn

			Me.Activate()
		End Sub

		''' <summary>
		''' Handle the key button click event.
		''' </summary>
		Private Sub KeyButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim btn As KeyButton = TryCast(sender, KeyButton)
			If btn Is Nothing Then
				Return
			End If

			' Synchronize the key pairs, like LShiftKey and RShiftKey.
			SyncKeyPairs(btn)

			' Process the special key such as AppsKey.
			If ProcessSpecialKey(btn) Then
				Return
			End If

			' Update the text of key buttons if the NumLock, ShiftKey or CapsLock is pressed.
			If btn.Key = Keys.NumLock OrElse btn.Key = Keys.ShiftKey OrElse btn.Key = Keys.CapsLock Then
				UpdateKeyButtonsText(keyButtonLShift.IsPressed, keyButtonNumLock.IsPressed, keyButtonCapsLock.IsPressed)
			End If

			' The CapsLock, NumLock or ScrollLock key is pressed.
			If btn.IsLockKey Then
				UserInteraction.KeyboardInput.SendToggledKey(btn.KeyCode)

			' A modifier key is pressed. 
			ElseIf btn.IsModifierKey Then
				' The modifier key is pressed twice.
				If PressedModifierKeyCodes.Contains(btn.KeyCode) Then
					UserInteraction.KeyboardInput.SendToggledKey(btn.KeyCode)

					' Clear the pressed state of all the modifier key buttons.
					ResetModifierKeyButtons()
				Else
					PressedModifierKeyCodes.Add(btn.KeyCode)
				End If

			' A normal key is pressed.
			Else
				Dim btnKeyCode As Integer = btn.KeyCode

				' If the key is a number pad key and the NumLock is not pressed, then use the 
				' UnNumLockKeyCode.
				If btn.IsNumberPadKey AndAlso (Not keyButtonNumLock.IsPressed) AndAlso btn.UnNumLockKeyCode > 0 Then
					btnKeyCode = btn.UnNumLockKeyCode
				End If

				UserInteraction.KeyboardInput.SendKey(PressedModifierKeyCodes, btnKeyCode)

				' Clear the pressed state of all the modifier key buttons.
				ResetModifierKeyButtons()
			End If
		End Sub

		''' <summary>
		''' Synchronize the key pairs, like LShiftKey and RShiftKey.
		''' </summary>
		Private Sub SyncKeyPairs(ByVal btn As KeyButton)
			If btn Is keyButtonLShift Then
				keyButtonRShift.IsPressed = keyButtonLShift.IsPressed
			End If
			If btn Is keyButtonRShift Then
				keyButtonLShift.IsPressed = keyButtonRShift.IsPressed
			End If

			If btn Is keyButtonLAlt Then
				keyButtonRAlt.IsPressed = keyButtonLAlt.IsPressed
			End If
			If btn Is keyButtonRAlt Then
				keyButtonLAlt.IsPressed = keyButtonRAlt.IsPressed
			End If

			If btn Is keyButtonLControl Then
				keyButtonRControl.IsPressed = keyButtonLControl.IsPressed
			End If
			If btn Is keyButtonRControl Then
				keyButtonLControl.IsPressed = keyButtonRControl.IsPressed
			End If
		End Sub

		''' <summary>
		''' Process the special key such as AppsKey.
		''' </summary>
		Private Function ProcessSpecialKey(ByVal btn As KeyButton) As Boolean
			Dim handled As Boolean = True
			Select Case btn.Key

				' Use Shift+F10 to simulate the Apps key. 
				Case Keys.Apps
					UserInteraction.KeyboardInput.SendKey(New Integer() { CInt(Keys.ShiftKey) }, CInt(Keys.F10))
				Case Else
					handled = False
			End Select
			Return handled
		End Function

		''' <summary>
		''' Initialize the key buttons.
		''' </summary>
		Private Sub InitializeKeyButtons()
			Dim capsLockState As Short = UserInteraction.UnsafeNativeMethods.GetKeyState(CInt(Keys.CapsLock))
			keyButtonCapsLock.IsPressed = (capsLockState And &H1) <> 0

			Dim numLockState As Short = UserInteraction.UnsafeNativeMethods.GetKeyState(CInt(Keys.NumLock))
			keyButtonNumLock.IsPressed = (numLockState And &H1) <> 0


			Dim scrLockState As Short = UserInteraction.UnsafeNativeMethods.GetKeyState(CInt(Keys.Scroll))
			keyButtonScrollLock.IsPressed = (scrLockState And &H1) <> 0

			Dim keysMappingDoc = XDocument.Load("Resources\KeysMapping.xml")
			For Each key In keysMappingDoc.Root.Elements()
				Dim keyCode As Integer = Integer.Parse(key.Element("KeyCode").Value)

				Dim btns As IEnumerable(Of KeyButton) = KeyButtonList.Where(Function(btn) btn.KeyCode = keyCode)

				For Each btn As KeyButton In btns
					btn.NormalText = key.Element("NormalText").Value

					If key.Elements("ShiftText").Count() > 0 Then
						btn.ShiftText = key.Element("ShiftText").Value
					End If

					If key.Elements("UnNumLockText").Count() > 0 Then
						btn.UnNumLockText = key.Element("UnNumLockText").Value
					End If

					If key.Elements("UnNumLockKeyCode").Count() > 0 Then
						btn.UnNumLockKeyCode = Integer.Parse(key.Element("UnNumLockKeyCode").Value)
					End If

					btn.UpdateDisplayText(False, keyButtonNumLock.IsPressed, keyButtonCapsLock.IsPressed)
				Next btn
			Next key
		End Sub

		''' <summary>
		''' Update the text of the key.
		''' </summary>
		Private Sub UpdateKeyButtonsText(ByVal isShiftKeyPressed As Boolean, ByVal isNumLockPressed As Boolean, ByVal isCapsLockPressed As Boolean)
			For Each btn In Me.KeyButtonList
				btn.UpdateDisplayText(isShiftKeyPressed, isNumLockPressed, isCapsLockPressed)
			Next btn
		End Sub

		''' <summary>
		''' Clear the pressed state of all the modifier key buttons.
		''' </summary>
		Private Sub ResetModifierKeyButtons()
			PressedModifierKeyCodes.Clear()

			keyButtonLShift.IsPressed = False
			keyButtonRShift.IsPressed = False
			keyButtonRControl.IsPressed = False
			keyButtonLControl.IsPressed = False
			keyButtonRAlt.IsPressed = False
			keyButtonLAlt.IsPressed = False
			keyButtonWin.IsPressed = False

			For Each keybtn In KeyButtonList
				keybtn.UpdateDisplayText(False, keyButtonNumLock.IsPressed, keyButtonCapsLock.IsPressed)
			Next keybtn
		End Sub

		#End Region


	End Class
End Namespace
