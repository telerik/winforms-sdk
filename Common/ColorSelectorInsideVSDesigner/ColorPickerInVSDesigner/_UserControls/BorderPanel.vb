Imports System.ComponentModel

<Serializable(), System.Drawing.ToolboxBitmap(GetType(System.Windows.Forms.Panel)),
  System.ComponentModel.DefaultProperty("BorderColor"), DefaultEvent("Paint")>
Public Class BorderPanel
	Inherits Panel

#Region " Inherited Properties I want to Hide "

	''' <summary>
	''' I usually have a number of properties in here - mostly because i don't usually use them and i like my Properties window
	''' in the IDE to have as small of a list as possible.  Anyway i'm only including one property here to demonstrate how it's done.
	''' 
	''' These properties are NOT GONE they just don't show up in the Properties window
	''' </summary>
	''' <remarks></remarks>
	''' 

	<Browsable(False)>
	Public Overrides Property RightToLeft() As System.Windows.Forms.RightToLeft
		Get
			Return MyBase.RightToLeft
		End Get
		Set(ByVal value As System.Windows.Forms.RightToLeft)
			MyBase.RightToLeft = value
		End Set
	End Property

#End Region

#Region " Properties "

	Private _BorderColor As Color = Color.Black
	<Editor(GetType(ColorEditor), GetType(System.Drawing.Design.UITypeEditor)),
	 Description("The Border Color"), TypeConverter(GetType(SimpleColorConverter))>
	Public Property BorderColor() As Color
		Get
			Return _BorderColor
		End Get
		Set(ByVal value As Color)
			_BorderColor = value
			Me.Refresh()
		End Set
	End Property

	<Editor(GetType(ColorEditor), GetType(System.Drawing.Design.UITypeEditor)),
	 Description("The Background Color"), TypeConverter(GetType(SimpleColorConverter))>
	Public Overrides Property BackColor As System.Drawing.Color
		Get
			Return MyBase.BackColor
		End Get
		Set(value As System.Drawing.Color)
			MyBase.BackColor = value
		End Set
	End Property

	Private _ShowTop As Boolean = True
	Public Property ShowTop() As Boolean
		Get
			Return _ShowTop
		End Get
		Set(ByVal value As Boolean)
			_ShowTop = value
			Me.Refresh()
		End Set
	End Property

	Private _ShowRight As Boolean = True
	Public Property ShowRight() As Boolean
		Get
			Return _ShowRight
		End Get
		Set(ByVal value As Boolean)
			_ShowRight = value
			Me.Refresh()
		End Set
	End Property

	Private _ShowLeft As Boolean = True
	Public Property ShowLeft() As Boolean
		Get
			Return _ShowLeft
		End Get
		Set(ByVal value As Boolean)
			_ShowLeft = value
			Me.Refresh()
		End Set
	End Property

	Private _ShowBottom As Boolean = True
	Public Property ShowBottom() As Boolean
		Get
			Return _ShowBottom
		End Get
		Set(ByVal value As Boolean)
			_ShowBottom = value
			Me.Refresh()
		End Set
	End Property

	Private Sub BorderPanel_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
		' Create my pen
		Dim myPen As New Pen(New SolidBrush(_BorderColor))

		If _ShowTop Then
			e.Graphics.DrawLine(myPen, 0, 0, Me.Width - 1, 0)
		End If

		If _ShowRight Then
			e.Graphics.DrawLine(myPen, Me.Width - 1, 0, Me.Width - 1, Me.Height - 1)
		End If

		If _ShowLeft Then
			e.Graphics.DrawLine(myPen, 0, 0, 0, Me.Height - 1)
		End If

		If _ShowBottom Then
			e.Graphics.DrawLine(myPen, 0, Me.Height - 1, Me.Width - 1, Me.Height - 1)
		End If

		myPen.Dispose()
	End Sub

#End Region



End Class
