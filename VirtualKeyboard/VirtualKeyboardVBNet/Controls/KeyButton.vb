'''**************************** Module Header ******************************\
''' * Module Name:  KeyButton.cs
''' * Project:      CSSoftKeyboard
''' * Copyright (c) Microsoft Corporation.
''' * 
''' * This control represents a key board button.
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

Imports Telerik.WinControls.UI

Namespace CSSoftKeyboard.Controls
	Partial Public Class KeyButton
		Inherits RadButton

		' The default styles.
		'static Color normalBackColor = Color.Black;
		'static Color mouseOverBackColor = Color.DimGray;
		'static Color pressedBackColor = Color.White;

		'static Color normalLabelForeColor = Color.White;
		'static Color pressedlLabelForeColor = Color.Black;

		''' <summary>
		''' The key code of this key.
		''' </summary>
		Public Property KeyCode() As Integer

'INSTANT VB NOTE: The variable key was renamed since Visual Basic does not allow class members with the same name:
		Private key_Renamed As Keys
		Public ReadOnly Property Key() As Keys
			Get
				If key_Renamed = Keys.None Then
					key_Renamed = CType(KeyCode, Keys)
				End If

				Return key_Renamed
			End Get
		End Property

		''' <summary>
		''' The key code of the number pad key if NumLock key is not pressed.
		''' </summary>
		Public Property UnNumLockKeyCode() As Integer

		''' <summary>
		''' The text of the number pad key if NumLock key is not pressed.
		''' </summary>
		Public Property UnNumLockText() As String

		''' <summary>
		''' The normal text of the key.
		''' </summary>
		Public Property NormalText() As String

		''' <summary>
		''' The text of the key when the Shift key is pressed.
		''' </summary>
		Public Property ShiftText() As String

		''' <summary>
		''' Specify whether it is a modifier key.
		''' </summary>
		Public ReadOnly Property IsModifierKey() As Boolean
			Get
				Return Key = Keys.ControlKey OrElse Key = Keys.ShiftKey OrElse Key = Keys.Menu OrElse Key = Keys.LWin OrElse Key = Keys.RWin
			End Get
		End Property


		''' <summary>
		''' Specify whether it is a lock key.
		''' </summary>
		Public ReadOnly Property IsLockKey() As Boolean
			Get
				Return Key = Keys.Capital OrElse Key = Keys.Scroll OrElse Key = Keys.NumLock
			End Get
		End Property

		''' <summary>
		''' Specify whether it is a letter key.
		''' </summary>
		Public ReadOnly Property IsLetterKey() As Boolean
			Get
				Return Key >= Keys.A AndAlso Key <= Keys.Z
			End Get
		End Property

		''' <summary>
		''' Specify whether it is a number pad key.
		''' </summary>
		Public ReadOnly Property IsNumberPadKey() As Boolean
			Get
				Return Key >= Keys.NumPad0 AndAlso Key <= Keys.NumPad9
			End Get
		End Property

'INSTANT VB NOTE: The variable isPressed was renamed since Visual Basic does not allow class members with the same name:
		Private isPressed_Renamed As Boolean

		''' <summary>
		''' Specify whether the key is pressed.
		''' </summary>
		Public Property IsPressed() As Boolean
			Get
				Return isPressed_Renamed
			End Get
			Set(ByVal value As Boolean)
				If isPressed_Renamed <> value Then
					isPressed_Renamed = value

					Me.OnIsPressedChange(EventArgs.Empty)
				End If
			End Set

		End Property

'INSTANT VB NOTE: The variable isMouseOver was renamed since Visual Basic does not allow class members with the same name:
		Private isMouseOver_Renamed As Boolean

		''' <summary>
		''' Specify whether the mouse is over this key.
		''' </summary>
		Private Property IsMouseOver() As Boolean
			Get
				Return isMouseOver_Renamed
			End Get
			Set(ByVal value As Boolean)
				If isMouseOver_Renamed <> value Then
					isMouseOver_Renamed = value

					Me.OnIsMouseOverChange(EventArgs.Empty)
				End If
			End Set
		End Property

		Public Sub New()
			'this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			'this.BackColor = System.Drawing.Color.Black;
			'this.ForeColor = System.Drawing.Color.White;
		End Sub

		''' <summary>
		''' Update the text of the key.
		''' </summary>
		Public Sub UpdateDisplayText(ByVal isShiftKeyPressed As Boolean, ByVal isNumLockPressed As Boolean, ByVal isCapsLockPressed As Boolean)
			If Me.IsLetterKey Then
				Me.Text = If(isShiftKeyPressed Xor isCapsLockPressed, ShiftText, NormalText)
			ElseIf Not String.IsNullOrEmpty(Me.ShiftText) Then
				Me.Text = If(isShiftKeyPressed, ShiftText, NormalText)
			ElseIf Me.IsNumberPadKey Then
				Me.Text = If(isNumLockPressed, NormalText, UnNumLockText)
			End If

		End Sub

		#Region "Update the style of the key board button."

		''' <summary>
		''' Handle the MouseDown event.
		''' Change the value of the IsPressed property, will cause the button to
		''' refresh.
		''' </summary>
		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			MyBase.OnMouseDown(e)

			IsPressed = Not IsPressed
		End Sub

		''' <summary>
		''' Handle the MouseUp event.
		''' If the key is not a modifier key or a lock key, set the IsPressed property 
		''' to false, which makes the button refresh.
		''' </summary>
		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			MyBase.OnMouseUp(e)

			If (Not IsModifierKey) AndAlso (Not IsLockKey) Then
				IsPressed = False
			End If
		End Sub

		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
			MyBase.OnMouseEnter(e)
			IsMouseOver = True
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			MyBase.OnMouseLeave(e)
			IsMouseOver = False
		End Sub


		Protected Overridable Sub OnIsMouseOverChange(ByVal e As EventArgs)
			ReDrawKeyButton()
		End Sub

		Protected Overridable Sub OnIsPressedChange(ByVal e As EventArgs)
			ReDrawKeyButton()
		End Sub

		Protected Overridable Sub ReDrawKeyButton()
			'if (IsPressed)
			'{
			'    this.BackColor = KeyButton.pressedBackColor;
			'    this.ForeColor = KeyButton.pressedlLabelForeColor;
			'}
			'else if (IsMouseOver)
			'{
			'    this.BackColor = KeyButton.mouseOverBackColor;
			'    this.ForeColor = KeyButton.normalLabelForeColor;
			'}
			'else
			'{
			'    this.BackColor = KeyButton.normalBackColor;
			'    this.ForeColor = KeyButton.normalLabelForeColor;
			'}
		End Sub

		#End Region
	End Class
End Namespace
