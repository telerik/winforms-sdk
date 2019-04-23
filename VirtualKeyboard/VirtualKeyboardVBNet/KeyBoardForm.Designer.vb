Imports CSSoftKeyboard.Controls

Namespace CSSoftKeyboard
	Partial Public Class KeyBoardForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(KeyBoardForm))
			Me.keyButtonUp = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonRControl = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonProcess = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonOpenBrackets = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF10 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD0 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonRight = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonRShift = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonReturn = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonDelete = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonScrollLock = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonPause = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonPageDown = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonPageUp = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonPrintScreen = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonInsert = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonEnd = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonHome = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonBack = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonDown = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonOemPipe = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonPlus = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonLeft = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonCloseBrackets = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonMinus = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonApps = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonQuestion = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonSemicolon = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonP = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF9 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD9 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonRAlt = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonPeriod = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonL = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonO = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonSubtract = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonMultiply = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonDivide = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF8 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD8 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonComma = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonK = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonI = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonAdd = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad3 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad6 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad9 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF7 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD7 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonM = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonJ = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonU = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumLock = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonDecimal = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad2 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad5 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad8 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF6 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD6 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonN = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonH = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonY = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumReturn = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad0 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad1 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad4 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonNumberPad7 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF5 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD5 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonB = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonG = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonT = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF4 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD4 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonV = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonR = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF3 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD3 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonSpace = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonC = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonE = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF12 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF2 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD2 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonLAlt = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonX = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonS = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonW = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF11 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonF1 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonD1 = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonWin = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonZ = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonA = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonQ = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonTilde = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonLControl = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonLShift = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonCapsLock = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonTab = New CSSoftKeyboard.Controls.KeyButton()
			Me.keyButtonEscape = New CSSoftKeyboard.Controls.KeyButton()
			Me.tableLayoutPanelKeyButtons = New MyBufferedTableLayoutPanel()
			Me.fluentTheme1 = New Telerik.WinControls.Themes.FluentTheme()
			CType(Me.keyButtonUp, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonRControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonProcess, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonOpenBrackets, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF10, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD0, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonRight, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonRShift, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonReturn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonDelete, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonScrollLock, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonPause, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonPageDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonPageUp, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonPrintScreen, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonInsert, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonEnd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonHome, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonBack, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonDown, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonOemPipe, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonPlus, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonCloseBrackets, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonMinus, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonApps, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonSemicolon, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonP, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonRAlt, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonL, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonO, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonSubtract, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonMultiply, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonDivide, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonComma, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonK, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonI, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonAdd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad9, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonM, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonJ, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonU, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumLock, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonN, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonH, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonY, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumReturn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad0, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonNumberPad7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonB, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonG, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonT, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonV, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonR, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonSpace, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonC, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonE, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF12, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonLAlt, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonX, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonS, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonW, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonF1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonD1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonWin, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonZ, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonA, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonQ, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonTilde, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonLControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonLShift, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonCapsLock, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonTab, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyButtonEscape, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanelKeyButtons.SuspendLayout()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' keyButtonUp
			' 
			Me.keyButtonUp.Dock = DockStyle.Fill
			Me.keyButtonUp.IsPressed = False
			Me.keyButtonUp.KeyCode = 38
			Me.keyButtonUp.Location = New Point(606, 160)
			Me.keyButtonUp.Name = "keyButtonUp"
			Me.keyButtonUp.NormalText = Nothing
			Me.keyButtonUp.Padding = New Padding(2)
			Me.keyButtonUp.ShiftText = Nothing
			Me.keyButtonUp.Size = New Size(31, 30)
			Me.keyButtonUp.TabIndex = 2
			Me.keyButtonUp.Text = "↑"
			Me.keyButtonUp.UnNumLockKeyCode = 0
			Me.keyButtonUp.UnNumLockText = Nothing
			Me.keyButtonUp.UseMnemonic = False
			' 
			' keyButtonRControl
			' 
			Me.keyButtonRControl.Dock = DockStyle.Fill
			Me.keyButtonRControl.IsPressed = False
			Me.keyButtonRControl.KeyCode = 17
			Me.keyButtonRControl.Location = New Point(527, 196)
			Me.keyButtonRControl.Name = "keyButtonRControl"
			Me.keyButtonRControl.NormalText = Nothing
			Me.keyButtonRControl.Padding = New Padding(2)
			Me.keyButtonRControl.ShiftText = Nothing
			Me.keyButtonRControl.Size = New Size(31, 31)
			Me.keyButtonRControl.TabIndex = 0
			Me.keyButtonRControl.Text = "Ctrl"
			Me.keyButtonRControl.UnNumLockKeyCode = 0
			Me.keyButtonRControl.UnNumLockText = Nothing
			Me.keyButtonRControl.UseMnemonic = False
			' 
			' keyButtonProcess
			' 
			Me.keyButtonProcess.Dock = DockStyle.Fill
			Me.keyButtonProcess.IsPressed = False
			Me.keyButtonProcess.KeyCode = 222
			Me.keyButtonProcess.Location = New Point(416, 124)
			Me.keyButtonProcess.Name = "keyButtonProcess"
			Me.keyButtonProcess.NormalText = Nothing
			Me.keyButtonProcess.Padding = New Padding(2)
			Me.keyButtonProcess.ShiftText = Nothing
			Me.keyButtonProcess.Size = New Size(31, 30)
			Me.keyButtonProcess.TabIndex = 0
			Me.keyButtonProcess.Text = "'"
			Me.keyButtonProcess.UnNumLockKeyCode = 0
			Me.keyButtonProcess.UnNumLockText = Nothing
			Me.keyButtonProcess.UseMnemonic = False
			' 
			' keyButtonOpenBrackets
			' 
			Me.keyButtonOpenBrackets.Dock = DockStyle.Fill
			Me.keyButtonOpenBrackets.IsPressed = False
			Me.keyButtonOpenBrackets.KeyCode = 219
			Me.keyButtonOpenBrackets.Location = New Point(416, 88)
			Me.keyButtonOpenBrackets.Name = "keyButtonOpenBrackets"
			Me.keyButtonOpenBrackets.NormalText = Nothing
			Me.keyButtonOpenBrackets.Padding = New Padding(2)
			Me.keyButtonOpenBrackets.ShiftText = Nothing
			Me.keyButtonOpenBrackets.Size = New Size(31, 30)
			Me.keyButtonOpenBrackets.TabIndex = 0
			Me.keyButtonOpenBrackets.Text = "["
			Me.keyButtonOpenBrackets.UnNumLockKeyCode = 0
			Me.keyButtonOpenBrackets.UnNumLockText = Nothing
			Me.keyButtonOpenBrackets.UseMnemonic = False
			' 
			' keyButtonF10
			' 
			Me.keyButtonF10.Dock = DockStyle.Fill
			Me.keyButtonF10.IsPressed = False
			Me.keyButtonF10.KeyCode = 121
			Me.keyButtonF10.Location = New Point(453, 3)
			Me.keyButtonF10.Name = "keyButtonF10"
			Me.keyButtonF10.NormalText = Nothing
			Me.keyButtonF10.Padding = New Padding(2)
			Me.keyButtonF10.ShiftText = Nothing
			Me.keyButtonF10.Size = New Size(31, 43)
			Me.keyButtonF10.TabIndex = 0
			Me.keyButtonF10.Text = "F10"
			Me.keyButtonF10.UnNumLockKeyCode = 0
			Me.keyButtonF10.UnNumLockText = Nothing
			Me.keyButtonF10.UseMnemonic = False
			' 
			' keyButtonD0
			' 
			Me.keyButtonD0.Dock = DockStyle.Fill
			Me.keyButtonD0.IsPressed = False
			Me.keyButtonD0.KeyCode = 48
			Me.keyButtonD0.Location = New Point(379, 52)
			Me.keyButtonD0.Name = "keyButtonD0"
			Me.keyButtonD0.NormalText = Nothing
			Me.keyButtonD0.Padding = New Padding(2)
			Me.keyButtonD0.ShiftText = Nothing
			Me.keyButtonD0.Size = New Size(31, 30)
			Me.keyButtonD0.TabIndex = 0
			Me.keyButtonD0.Text = "0"
			Me.keyButtonD0.UnNumLockKeyCode = 0
			Me.keyButtonD0.UnNumLockText = Nothing
			Me.keyButtonD0.UseMnemonic = False
			' 
			' keyButtonRight
			' 
			Me.keyButtonRight.Dock = DockStyle.Fill
			Me.keyButtonRight.IsPressed = False
			Me.keyButtonRight.KeyCode = 39
			Me.keyButtonRight.Location = New Point(643, 196)
			Me.keyButtonRight.Name = "keyButtonRight"
			Me.keyButtonRight.NormalText = Nothing
			Me.keyButtonRight.Padding = New Padding(2)
			Me.keyButtonRight.ShiftText = Nothing
			Me.keyButtonRight.Size = New Size(31, 31)
			Me.keyButtonRight.TabIndex = 0
			Me.keyButtonRight.Text = "→"
			Me.keyButtonRight.UnNumLockKeyCode = 0
			Me.keyButtonRight.UnNumLockText = Nothing
			Me.keyButtonRight.UseMnemonic = False
			' 
			' keyButtonRShift
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonRShift, 2)
			Me.keyButtonRShift.Dock = DockStyle.Fill
			Me.keyButtonRShift.IsPressed = False
			Me.keyButtonRShift.KeyCode = 16
			Me.keyButtonRShift.Location = New Point(490, 160)
			Me.keyButtonRShift.Name = "keyButtonRShift"
			Me.keyButtonRShift.NormalText = Nothing
			Me.keyButtonRShift.Padding = New Padding(2)
			Me.keyButtonRShift.ShiftText = Nothing
			Me.keyButtonRShift.Size = New Size(68, 30)
			Me.keyButtonRShift.TabIndex = 0
			Me.keyButtonRShift.Text = "Shift"
			Me.keyButtonRShift.UnNumLockKeyCode = 0
			Me.keyButtonRShift.UnNumLockText = Nothing
			Me.keyButtonRShift.UseMnemonic = False
			' 
			' keyButtonReturn
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonReturn, 2)
			Me.keyButtonReturn.Dock = DockStyle.Fill
			Me.keyButtonReturn.IsPressed = False
			Me.keyButtonReturn.KeyCode = 13
			Me.keyButtonReturn.Location = New Point(490, 88)
			Me.keyButtonReturn.Name = "keyButtonReturn"
			Me.keyButtonReturn.NormalText = Nothing
			Me.keyButtonReturn.Padding = New Padding(2)
			Me.tableLayoutPanelKeyButtons.SetRowSpan(Me.keyButtonReturn, 2)
			Me.keyButtonReturn.ShiftText = Nothing
			Me.keyButtonReturn.Size = New Size(68, 66)
			Me.keyButtonReturn.TabIndex = 0
			Me.keyButtonReturn.Text = "Enter"
			Me.keyButtonReturn.UnNumLockKeyCode = 0
			Me.keyButtonReturn.UnNumLockText = Nothing
			Me.keyButtonReturn.UseMnemonic = False
			' 
			' keyButtonDelete
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonDelete, 2)
			Me.keyButtonDelete.Dock = DockStyle.Fill
			Me.keyButtonDelete.IsPressed = False
			Me.keyButtonDelete.KeyCode = 46
			Me.keyButtonDelete.Location = New Point(643, 52)
			Me.keyButtonDelete.Name = "keyButtonDelete"
			Me.keyButtonDelete.NormalText = Nothing
			Me.keyButtonDelete.Padding = New Padding(2)
			Me.keyButtonDelete.ShiftText = Nothing
			Me.keyButtonDelete.Size = New Size(68, 30)
			Me.keyButtonDelete.TabIndex = 0
			Me.keyButtonDelete.Text = "Del"
			Me.keyButtonDelete.UnNumLockKeyCode = 0
			Me.keyButtonDelete.UnNumLockText = Nothing
			Me.keyButtonDelete.UseMnemonic = False
			' 
			' keyButtonScrollLock
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonScrollLock, 2)
			Me.keyButtonScrollLock.Dock = DockStyle.Fill
			Me.keyButtonScrollLock.IsPressed = False
			Me.keyButtonScrollLock.KeyCode = 145
			Me.keyButtonScrollLock.Location = New Point(643, 3)
			Me.keyButtonScrollLock.Name = "keyButtonScrollLock"
			Me.keyButtonScrollLock.NormalText = Nothing
			Me.keyButtonScrollLock.Padding = New Padding(2)
			Me.keyButtonScrollLock.ShiftText = Nothing
			Me.keyButtonScrollLock.Size = New Size(68, 43)
			Me.keyButtonScrollLock.TabIndex = 0
			Me.keyButtonScrollLock.Text = "ScrLk"
			Me.keyButtonScrollLock.UnNumLockKeyCode = 0
			Me.keyButtonScrollLock.UnNumLockText = Nothing
			Me.keyButtonScrollLock.UseMnemonic = False
			' 
			' keyButtonPause
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonPause, 2)
			Me.keyButtonPause.Dock = DockStyle.Fill
			Me.keyButtonPause.IsPressed = False
			Me.keyButtonPause.KeyCode = 19
			Me.keyButtonPause.Location = New Point(722, 3)
			Me.keyButtonPause.Name = "keyButtonPause"
			Me.keyButtonPause.NormalText = Nothing
			Me.keyButtonPause.Padding = New Padding(2)
			Me.keyButtonPause.ShiftText = Nothing
			Me.keyButtonPause.Size = New Size(68, 43)
			Me.keyButtonPause.TabIndex = 0
			Me.keyButtonPause.Text = "Pause"
			Me.keyButtonPause.UnNumLockKeyCode = 0
			Me.keyButtonPause.UnNumLockText = Nothing
			Me.keyButtonPause.UseMnemonic = False
			' 
			' keyButtonPageDown
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonPageDown, 2)
			Me.keyButtonPageDown.Dock = DockStyle.Fill
			Me.keyButtonPageDown.IsPressed = False
			Me.keyButtonPageDown.KeyCode = 34
			Me.keyButtonPageDown.Location = New Point(643, 88)
			Me.keyButtonPageDown.Name = "keyButtonPageDown"
			Me.keyButtonPageDown.NormalText = Nothing
			Me.keyButtonPageDown.Padding = New Padding(2)
			Me.keyButtonPageDown.ShiftText = Nothing
			Me.keyButtonPageDown.Size = New Size(68, 30)
			Me.keyButtonPageDown.TabIndex = 0
			Me.keyButtonPageDown.Text = "PgDn"
			Me.keyButtonPageDown.UnNumLockKeyCode = 0
			Me.keyButtonPageDown.UnNumLockText = Nothing
			Me.keyButtonPageDown.UseMnemonic = False
			' 
			' keyButtonPageUp
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonPageUp, 2)
			Me.keyButtonPageUp.Dock = DockStyle.Fill
			Me.keyButtonPageUp.IsPressed = False
			Me.keyButtonPageUp.KeyCode = 33
			Me.keyButtonPageUp.Location = New Point(569, 88)
			Me.keyButtonPageUp.Name = "keyButtonPageUp"
			Me.keyButtonPageUp.NormalText = Nothing
			Me.keyButtonPageUp.Padding = New Padding(2)
			Me.keyButtonPageUp.ShiftText = Nothing
			Me.keyButtonPageUp.Size = New Size(68, 30)
			Me.keyButtonPageUp.TabIndex = 0
			Me.keyButtonPageUp.Text = "PgUp"
			Me.keyButtonPageUp.UnNumLockKeyCode = 0
			Me.keyButtonPageUp.UnNumLockText = Nothing
			Me.keyButtonPageUp.UseMnemonic = False
			' 
			' keyButtonPrintScreen
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonPrintScreen, 2)
			Me.keyButtonPrintScreen.Dock = DockStyle.Fill
			Me.keyButtonPrintScreen.IsPressed = False
			Me.keyButtonPrintScreen.KeyCode = 44
			Me.keyButtonPrintScreen.Location = New Point(569, 3)
			Me.keyButtonPrintScreen.Name = "keyButtonPrintScreen"
			Me.keyButtonPrintScreen.NormalText = Nothing
			Me.keyButtonPrintScreen.Padding = New Padding(2)
			Me.keyButtonPrintScreen.ShiftText = Nothing
			Me.keyButtonPrintScreen.Size = New Size(68, 43)
			Me.keyButtonPrintScreen.TabIndex = 0
			Me.keyButtonPrintScreen.Text = "PrtScn"
			Me.keyButtonPrintScreen.UnNumLockKeyCode = 0
			Me.keyButtonPrintScreen.UnNumLockText = Nothing
			Me.keyButtonPrintScreen.UseMnemonic = False
			' 
			' keyButtonInsert
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonInsert, 2)
			Me.keyButtonInsert.Dock = DockStyle.Fill
			Me.keyButtonInsert.IsPressed = False
			Me.keyButtonInsert.KeyCode = 45
			Me.keyButtonInsert.Location = New Point(569, 52)
			Me.keyButtonInsert.Name = "keyButtonInsert"
			Me.keyButtonInsert.NormalText = Nothing
			Me.keyButtonInsert.Padding = New Padding(2)
			Me.keyButtonInsert.ShiftText = Nothing
			Me.keyButtonInsert.Size = New Size(68, 30)
			Me.keyButtonInsert.TabIndex = 0
			Me.keyButtonInsert.Text = "Insert"
			Me.keyButtonInsert.UnNumLockKeyCode = 0
			Me.keyButtonInsert.UnNumLockText = Nothing
			Me.keyButtonInsert.UseMnemonic = False
			' 
			' keyButtonEnd
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonEnd, 2)
			Me.keyButtonEnd.Dock = DockStyle.Fill
			Me.keyButtonEnd.IsPressed = False
			Me.keyButtonEnd.KeyCode = 35
			Me.keyButtonEnd.Location = New Point(643, 124)
			Me.keyButtonEnd.Name = "keyButtonEnd"
			Me.keyButtonEnd.NormalText = Nothing
			Me.keyButtonEnd.Padding = New Padding(2)
			Me.keyButtonEnd.ShiftText = Nothing
			Me.keyButtonEnd.Size = New Size(68, 30)
			Me.keyButtonEnd.TabIndex = 0
			Me.keyButtonEnd.Text = "End"
			Me.keyButtonEnd.UnNumLockKeyCode = 0
			Me.keyButtonEnd.UnNumLockText = Nothing
			Me.keyButtonEnd.UseMnemonic = False
			' 
			' keyButtonHome
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonHome, 2)
			Me.keyButtonHome.Dock = DockStyle.Fill
			Me.keyButtonHome.IsPressed = False
			Me.keyButtonHome.KeyCode = 36
			Me.keyButtonHome.Location = New Point(569, 124)
			Me.keyButtonHome.Name = "keyButtonHome"
			Me.keyButtonHome.NormalText = Nothing
			Me.keyButtonHome.Padding = New Padding(2)
			Me.keyButtonHome.ShiftText = Nothing
			Me.keyButtonHome.Size = New Size(68, 30)
			Me.keyButtonHome.TabIndex = 0
			Me.keyButtonHome.Text = "Home"
			Me.keyButtonHome.UnNumLockKeyCode = 0
			Me.keyButtonHome.UnNumLockText = Nothing
			Me.keyButtonHome.UseMnemonic = False
			' 
			' keyButtonBack
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonBack, 2)
			Me.keyButtonBack.Dock = DockStyle.Fill
			Me.keyButtonBack.IsPressed = False
			Me.keyButtonBack.KeyCode = 8
			Me.keyButtonBack.Location = New Point(490, 52)
			Me.keyButtonBack.Name = "keyButtonBack"
			Me.keyButtonBack.NormalText = Nothing
			Me.keyButtonBack.Padding = New Padding(2)
			Me.keyButtonBack.ShiftText = Nothing
			Me.keyButtonBack.Size = New Size(68, 30)
			Me.keyButtonBack.TabIndex = 0
			Me.keyButtonBack.Text = "Bksp"
			Me.keyButtonBack.UnNumLockKeyCode = 0
			Me.keyButtonBack.UnNumLockText = Nothing
			Me.keyButtonBack.UseMnemonic = False
			' 
			' keyButtonDown
			' 
			Me.keyButtonDown.Dock = DockStyle.Fill
			Me.keyButtonDown.IsPressed = False
			Me.keyButtonDown.KeyCode = 40
			Me.keyButtonDown.Location = New Point(606, 196)
			Me.keyButtonDown.Name = "keyButtonDown"
			Me.keyButtonDown.NormalText = Nothing
			Me.keyButtonDown.Padding = New Padding(2)
			Me.keyButtonDown.ShiftText = Nothing
			Me.keyButtonDown.Size = New Size(31, 31)
			Me.keyButtonDown.TabIndex = 0
			Me.keyButtonDown.Text = "↓"
			Me.keyButtonDown.UnNumLockKeyCode = 0
			Me.keyButtonDown.UnNumLockText = Nothing
			Me.keyButtonDown.UseMnemonic = False
			' 
			' keyButtonOemPipe
			' 
			Me.keyButtonOemPipe.Dock = DockStyle.Fill
			Me.keyButtonOemPipe.IsPressed = False
			Me.keyButtonOemPipe.KeyCode = 220
			Me.keyButtonOemPipe.Location = New Point(453, 124)
			Me.keyButtonOemPipe.Name = "keyButtonOemPipe"
			Me.keyButtonOemPipe.NormalText = Nothing
			Me.keyButtonOemPipe.Padding = New Padding(2)
			Me.keyButtonOemPipe.ShiftText = Nothing
			Me.keyButtonOemPipe.Size = New Size(31, 30)
			Me.keyButtonOemPipe.TabIndex = 0
			Me.keyButtonOemPipe.Text = "\"
			Me.keyButtonOemPipe.UnNumLockKeyCode = 0
			Me.keyButtonOemPipe.UnNumLockText = Nothing
			Me.keyButtonOemPipe.UseMnemonic = False
			' 
			' keyButtonPlus
			' 
			Me.keyButtonPlus.Dock = DockStyle.Fill
			Me.keyButtonPlus.IsPressed = False
			Me.keyButtonPlus.KeyCode = 187
			Me.keyButtonPlus.Location = New Point(453, 52)
			Me.keyButtonPlus.Name = "keyButtonPlus"
			Me.keyButtonPlus.NormalText = Nothing
			Me.keyButtonPlus.Padding = New Padding(2)
			Me.keyButtonPlus.ShiftText = Nothing
			Me.keyButtonPlus.Size = New Size(31, 30)
			Me.keyButtonPlus.TabIndex = 0
			Me.keyButtonPlus.Text = "="
			Me.keyButtonPlus.UnNumLockKeyCode = 0
			Me.keyButtonPlus.UnNumLockText = Nothing
			Me.keyButtonPlus.UseMnemonic = False
			' 
			' keyButtonLeft
			' 
			Me.keyButtonLeft.Dock = DockStyle.Fill
			Me.keyButtonLeft.IsPressed = False
			Me.keyButtonLeft.KeyCode = 37
			Me.keyButtonLeft.Location = New Point(569, 196)
			Me.keyButtonLeft.Name = "keyButtonLeft"
			Me.keyButtonLeft.NormalText = Nothing
			Me.keyButtonLeft.Padding = New Padding(2)
			Me.keyButtonLeft.ShiftText = Nothing
			Me.keyButtonLeft.Size = New Size(31, 31)
			Me.keyButtonLeft.TabIndex = 0
			Me.keyButtonLeft.Text = "←"
			Me.keyButtonLeft.UnNumLockKeyCode = 0
			Me.keyButtonLeft.UnNumLockText = Nothing
			Me.keyButtonLeft.UseMnemonic = False
			' 
			' keyButtonCloseBrackets
			' 
			Me.keyButtonCloseBrackets.Dock = DockStyle.Fill
			Me.keyButtonCloseBrackets.IsPressed = False
			Me.keyButtonCloseBrackets.KeyCode = 221
			Me.keyButtonCloseBrackets.Location = New Point(453, 88)
			Me.keyButtonCloseBrackets.Name = "keyButtonCloseBrackets"
			Me.keyButtonCloseBrackets.NormalText = Nothing
			Me.keyButtonCloseBrackets.Padding = New Padding(2)
			Me.keyButtonCloseBrackets.ShiftText = Nothing
			Me.keyButtonCloseBrackets.Size = New Size(31, 30)
			Me.keyButtonCloseBrackets.TabIndex = 0
			Me.keyButtonCloseBrackets.Text = "]"
			Me.keyButtonCloseBrackets.UnNumLockKeyCode = 0
			Me.keyButtonCloseBrackets.UnNumLockText = Nothing
			Me.keyButtonCloseBrackets.UseMnemonic = False
			' 
			' keyButtonMinus
			' 
			Me.keyButtonMinus.Dock = DockStyle.Fill
			Me.keyButtonMinus.IsPressed = False
			Me.keyButtonMinus.KeyCode = 189
			Me.keyButtonMinus.Location = New Point(416, 52)
			Me.keyButtonMinus.Name = "keyButtonMinus"
			Me.keyButtonMinus.NormalText = Nothing
			Me.keyButtonMinus.Padding = New Padding(2)
			Me.keyButtonMinus.ShiftText = Nothing
			Me.keyButtonMinus.Size = New Size(31, 30)
			Me.keyButtonMinus.TabIndex = 0
			Me.keyButtonMinus.Text = "-"
			Me.keyButtonMinus.UnNumLockKeyCode = 0
			Me.keyButtonMinus.UnNumLockText = Nothing
			Me.keyButtonMinus.UseMnemonic = False
			' 
			' keyButtonApps
			' 
			Me.keyButtonApps.Dock = DockStyle.Fill
			Me.keyButtonApps.IsPressed = False
			Me.keyButtonApps.KeyCode = 93
			Me.keyButtonApps.Location = New Point(490, 196)
			Me.keyButtonApps.Name = "keyButtonApps"
			Me.keyButtonApps.NormalText = Nothing
			Me.keyButtonApps.Padding = New Padding(2)
			Me.keyButtonApps.ShiftText = Nothing
			Me.keyButtonApps.Size = New Size(31, 31)
			Me.keyButtonApps.TabIndex = 0
			Me.keyButtonApps.Text = "App"
			Me.keyButtonApps.UnNumLockKeyCode = 0
			Me.keyButtonApps.UnNumLockText = Nothing
			Me.keyButtonApps.UseMnemonic = False
			' 
			' keyButtonQuestion
			' 
			Me.keyButtonQuestion.Dock = DockStyle.Fill
			Me.keyButtonQuestion.IsPressed = False
			Me.keyButtonQuestion.KeyCode = 191
			Me.keyButtonQuestion.Location = New Point(453, 160)
			Me.keyButtonQuestion.Name = "keyButtonQuestion"
			Me.keyButtonQuestion.NormalText = Nothing
			Me.keyButtonQuestion.Padding = New Padding(2)
			Me.keyButtonQuestion.ShiftText = Nothing
			Me.keyButtonQuestion.Size = New Size(31, 30)
			Me.keyButtonQuestion.TabIndex = 0
			Me.keyButtonQuestion.Text = "/"
			Me.keyButtonQuestion.UnNumLockKeyCode = 0
			Me.keyButtonQuestion.UnNumLockText = Nothing
			Me.keyButtonQuestion.UseMnemonic = False
			' 
			' keyButtonSemicolon
			' 
			Me.keyButtonSemicolon.Dock = DockStyle.Fill
			Me.keyButtonSemicolon.IsPressed = False
			Me.keyButtonSemicolon.KeyCode = 186
			Me.keyButtonSemicolon.Location = New Point(379, 124)
			Me.keyButtonSemicolon.Name = "keyButtonSemicolon"
			Me.keyButtonSemicolon.NormalText = Nothing
			Me.keyButtonSemicolon.Padding = New Padding(2)
			Me.keyButtonSemicolon.ShiftText = Nothing
			Me.keyButtonSemicolon.Size = New Size(31, 30)
			Me.keyButtonSemicolon.TabIndex = 0
			Me.keyButtonSemicolon.Text = ";"
			Me.keyButtonSemicolon.UnNumLockKeyCode = 0
			Me.keyButtonSemicolon.UnNumLockText = Nothing
			Me.keyButtonSemicolon.UseMnemonic = False
			' 
			' keyButtonP
			' 
			Me.keyButtonP.Dock = DockStyle.Fill
			Me.keyButtonP.IsPressed = False
			Me.keyButtonP.KeyCode = 80
			Me.keyButtonP.Location = New Point(379, 88)
			Me.keyButtonP.Name = "keyButtonP"
			Me.keyButtonP.NormalText = Nothing
			Me.keyButtonP.Padding = New Padding(2)
			Me.keyButtonP.ShiftText = Nothing
			Me.keyButtonP.Size = New Size(31, 30)
			Me.keyButtonP.TabIndex = 0
			Me.keyButtonP.Text = "p"
			Me.keyButtonP.UnNumLockKeyCode = 0
			Me.keyButtonP.UnNumLockText = Nothing
			Me.keyButtonP.UseMnemonic = False
			' 
			' keyButtonF9
			' 
			Me.keyButtonF9.Dock = DockStyle.Fill
			Me.keyButtonF9.IsPressed = False
			Me.keyButtonF9.KeyCode = 120
			Me.keyButtonF9.Location = New Point(416, 3)
			Me.keyButtonF9.Name = "keyButtonF9"
			Me.keyButtonF9.NormalText = Nothing
			Me.keyButtonF9.Padding = New Padding(2)
			Me.keyButtonF9.ShiftText = Nothing
			Me.keyButtonF9.Size = New Size(31, 43)
			Me.keyButtonF9.TabIndex = 0
			Me.keyButtonF9.Text = "F9"
			Me.keyButtonF9.UnNumLockKeyCode = 0
			Me.keyButtonF9.UnNumLockText = Nothing
			Me.keyButtonF9.UseMnemonic = False
			' 
			' keyButtonD9
			' 
			Me.keyButtonD9.Dock = DockStyle.Fill
			Me.keyButtonD9.IsPressed = False
			Me.keyButtonD9.KeyCode = 57
			Me.keyButtonD9.Location = New Point(342, 52)
			Me.keyButtonD9.Name = "keyButtonD9"
			Me.keyButtonD9.NormalText = Nothing
			Me.keyButtonD9.Padding = New Padding(2)
			Me.keyButtonD9.ShiftText = Nothing
			Me.keyButtonD9.Size = New Size(31, 30)
			Me.keyButtonD9.TabIndex = 0
			Me.keyButtonD9.Text = "9"
			Me.keyButtonD9.UnNumLockKeyCode = 0
			Me.keyButtonD9.UnNumLockText = Nothing
			Me.keyButtonD9.UseMnemonic = False
			' 
			' keyButtonRAlt
			' 
			Me.keyButtonRAlt.Dock = DockStyle.Fill
			Me.keyButtonRAlt.IsPressed = False
			Me.keyButtonRAlt.KeyCode = 18
			Me.keyButtonRAlt.Location = New Point(453, 196)
			Me.keyButtonRAlt.Name = "keyButtonRAlt"
			Me.keyButtonRAlt.NormalText = Nothing
			Me.keyButtonRAlt.Padding = New Padding(2)
			Me.keyButtonRAlt.ShiftText = Nothing
			Me.keyButtonRAlt.Size = New Size(31, 31)
			Me.keyButtonRAlt.TabIndex = 0
			Me.keyButtonRAlt.Text = "Alt"
			Me.keyButtonRAlt.UnNumLockKeyCode = 0
			Me.keyButtonRAlt.UnNumLockText = Nothing
			Me.keyButtonRAlt.UseMnemonic = False
			' 
			' keyButtonPeriod
			' 
			Me.keyButtonPeriod.Dock = DockStyle.Fill
			Me.keyButtonPeriod.IsPressed = False
			Me.keyButtonPeriod.KeyCode = 190
			Me.keyButtonPeriod.Location = New Point(379, 160)
			Me.keyButtonPeriod.Name = "keyButtonPeriod"
			Me.keyButtonPeriod.NormalText = Nothing
			Me.keyButtonPeriod.Padding = New Padding(2)
			Me.keyButtonPeriod.ShiftText = Nothing
			Me.keyButtonPeriod.Size = New Size(31, 30)
			Me.keyButtonPeriod.TabIndex = 0
			Me.keyButtonPeriod.Text = "."
			Me.keyButtonPeriod.UnNumLockKeyCode = 0
			Me.keyButtonPeriod.UnNumLockText = Nothing
			Me.keyButtonPeriod.UseMnemonic = False
			' 
			' keyButtonL
			' 
			Me.keyButtonL.Dock = DockStyle.Fill
			Me.keyButtonL.IsPressed = False
			Me.keyButtonL.KeyCode = 76
			Me.keyButtonL.Location = New Point(342, 124)
			Me.keyButtonL.Name = "keyButtonL"
			Me.keyButtonL.NormalText = Nothing
			Me.keyButtonL.Padding = New Padding(2)
			Me.keyButtonL.ShiftText = Nothing
			Me.keyButtonL.Size = New Size(31, 30)
			Me.keyButtonL.TabIndex = 0
			Me.keyButtonL.Text = "l"
			Me.keyButtonL.UnNumLockKeyCode = 0
			Me.keyButtonL.UnNumLockText = Nothing
			Me.keyButtonL.UseMnemonic = False
			' 
			' keyButtonO
			' 
			Me.keyButtonO.Dock = DockStyle.Fill
			Me.keyButtonO.IsPressed = False
			Me.keyButtonO.KeyCode = 79
			Me.keyButtonO.Location = New Point(342, 88)
			Me.keyButtonO.Name = "keyButtonO"
			Me.keyButtonO.NormalText = Nothing
			Me.keyButtonO.Padding = New Padding(2)
			Me.keyButtonO.ShiftText = Nothing
			Me.keyButtonO.Size = New Size(31, 30)
			Me.keyButtonO.TabIndex = 0
			Me.keyButtonO.Text = "o"
			Me.keyButtonO.UnNumLockKeyCode = 0
			Me.keyButtonO.UnNumLockText = Nothing
			Me.keyButtonO.UseMnemonic = False
			' 
			' keyButtonSubtract
			' 
			Me.keyButtonSubtract.Dock = DockStyle.Fill
			Me.keyButtonSubtract.IsPressed = False
			Me.keyButtonSubtract.KeyCode = 109
			Me.keyButtonSubtract.Location = New Point(833, 52)
			Me.keyButtonSubtract.Name = "keyButtonSubtract"
			Me.keyButtonSubtract.NormalText = Nothing
			Me.keyButtonSubtract.Padding = New Padding(2)
			Me.keyButtonSubtract.ShiftText = Nothing
			Me.keyButtonSubtract.Size = New Size(36, 30)
			Me.keyButtonSubtract.TabIndex = 0
			Me.keyButtonSubtract.Text = "-"
			Me.keyButtonSubtract.UnNumLockKeyCode = 0
			Me.keyButtonSubtract.UnNumLockText = Nothing
			Me.keyButtonSubtract.UseMnemonic = False
			' 
			' keyButtonMultiply
			' 
			Me.keyButtonMultiply.Dock = DockStyle.Fill
			Me.keyButtonMultiply.IsPressed = False
			Me.keyButtonMultiply.KeyCode = 106
			Me.keyButtonMultiply.Location = New Point(796, 52)
			Me.keyButtonMultiply.Name = "keyButtonMultiply"
			Me.keyButtonMultiply.NormalText = Nothing
			Me.keyButtonMultiply.Padding = New Padding(2)
			Me.keyButtonMultiply.ShiftText = Nothing
			Me.keyButtonMultiply.Size = New Size(31, 30)
			Me.keyButtonMultiply.TabIndex = 0
			Me.keyButtonMultiply.Text = "*"
			Me.keyButtonMultiply.UnNumLockKeyCode = 0
			Me.keyButtonMultiply.UnNumLockText = Nothing
			Me.keyButtonMultiply.UseMnemonic = False
			' 
			' keyButtonDivide
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonDivide, 2)
			Me.keyButtonDivide.Dock = DockStyle.Fill
			Me.keyButtonDivide.IsPressed = False
			Me.keyButtonDivide.KeyCode = 111
			Me.keyButtonDivide.Location = New Point(722, 52)
			Me.keyButtonDivide.Name = "keyButtonDivide"
			Me.keyButtonDivide.NormalText = Nothing
			Me.keyButtonDivide.Padding = New Padding(2)
			Me.keyButtonDivide.ShiftText = Nothing
			Me.keyButtonDivide.Size = New Size(68, 30)
			Me.keyButtonDivide.TabIndex = 0
			Me.keyButtonDivide.Text = "/"
			Me.keyButtonDivide.UnNumLockKeyCode = 0
			Me.keyButtonDivide.UnNumLockText = Nothing
			Me.keyButtonDivide.UseMnemonic = False
			' 
			' keyButtonF8
			' 
			Me.keyButtonF8.Dock = DockStyle.Fill
			Me.keyButtonF8.IsPressed = False
			Me.keyButtonF8.KeyCode = 119
			Me.keyButtonF8.Location = New Point(342, 3)
			Me.keyButtonF8.Name = "keyButtonF8"
			Me.keyButtonF8.NormalText = Nothing
			Me.keyButtonF8.Padding = New Padding(2)
			Me.keyButtonF8.ShiftText = Nothing
			Me.keyButtonF8.Size = New Size(31, 43)
			Me.keyButtonF8.TabIndex = 0
			Me.keyButtonF8.Text = "F8"
			Me.keyButtonF8.UnNumLockKeyCode = 0
			Me.keyButtonF8.UnNumLockText = Nothing
			Me.keyButtonF8.UseMnemonic = False
			' 
			' keyButtonD8
			' 
			Me.keyButtonD8.Dock = DockStyle.Fill
			Me.keyButtonD8.IsPressed = False
			Me.keyButtonD8.KeyCode = 56
			Me.keyButtonD8.Location = New Point(305, 52)
			Me.keyButtonD8.Name = "keyButtonD8"
			Me.keyButtonD8.NormalText = Nothing
			Me.keyButtonD8.Padding = New Padding(2)
			Me.keyButtonD8.ShiftText = Nothing
			Me.keyButtonD8.Size = New Size(31, 30)
			Me.keyButtonD8.TabIndex = 0
			Me.keyButtonD8.Text = "8"
			Me.keyButtonD8.UnNumLockKeyCode = 0
			Me.keyButtonD8.UnNumLockText = Nothing
			Me.keyButtonD8.UseMnemonic = False
			' 
			' keyButtonComma
			' 
			Me.keyButtonComma.Dock = DockStyle.Fill
			Me.keyButtonComma.IsPressed = False
			Me.keyButtonComma.KeyCode = 188
			Me.keyButtonComma.Location = New Point(342, 160)
			Me.keyButtonComma.Name = "keyButtonComma"
			Me.keyButtonComma.NormalText = Nothing
			Me.keyButtonComma.Padding = New Padding(2)
			Me.keyButtonComma.ShiftText = Nothing
			Me.keyButtonComma.Size = New Size(31, 30)
			Me.keyButtonComma.TabIndex = 0
			Me.keyButtonComma.Text = ","
			Me.keyButtonComma.UnNumLockKeyCode = 0
			Me.keyButtonComma.UnNumLockText = Nothing
			Me.keyButtonComma.UseMnemonic = False
			' 
			' keyButtonK
			' 
			Me.keyButtonK.Dock = DockStyle.Fill
			Me.keyButtonK.IsPressed = False
			Me.keyButtonK.KeyCode = 75
			Me.keyButtonK.Location = New Point(305, 124)
			Me.keyButtonK.Name = "keyButtonK"
			Me.keyButtonK.NormalText = Nothing
			Me.keyButtonK.Padding = New Padding(2)
			Me.keyButtonK.ShiftText = Nothing
			Me.keyButtonK.Size = New Size(31, 30)
			Me.keyButtonK.TabIndex = 0
			Me.keyButtonK.Text = "k"
			Me.keyButtonK.UnNumLockKeyCode = 0
			Me.keyButtonK.UnNumLockText = Nothing
			Me.keyButtonK.UseMnemonic = False
			' 
			' keyButtonI
			' 
			Me.keyButtonI.Dock = DockStyle.Fill
			Me.keyButtonI.IsPressed = False
			Me.keyButtonI.KeyCode = 73
			Me.keyButtonI.Location = New Point(305, 88)
			Me.keyButtonI.Name = "keyButtonI"
			Me.keyButtonI.NormalText = Nothing
			Me.keyButtonI.Padding = New Padding(2)
			Me.keyButtonI.ShiftText = Nothing
			Me.keyButtonI.Size = New Size(31, 30)
			Me.keyButtonI.TabIndex = 0
			Me.keyButtonI.Text = "i"
			Me.keyButtonI.UnNumLockKeyCode = 0
			Me.keyButtonI.UnNumLockText = Nothing
			Me.keyButtonI.UseMnemonic = False
			' 
			' keyButtonAdd
			' 
			Me.keyButtonAdd.Dock = DockStyle.Fill
			Me.keyButtonAdd.IsPressed = False
			Me.keyButtonAdd.KeyCode = 107
			Me.keyButtonAdd.Location = New Point(833, 88)
			Me.keyButtonAdd.Name = "keyButtonAdd"
			Me.keyButtonAdd.NormalText = Nothing
			Me.keyButtonAdd.Padding = New Padding(2)
			Me.tableLayoutPanelKeyButtons.SetRowSpan(Me.keyButtonAdd, 2)
			Me.keyButtonAdd.ShiftText = Nothing
			Me.keyButtonAdd.Size = New Size(36, 66)
			Me.keyButtonAdd.TabIndex = 0
			Me.keyButtonAdd.Text = "+"
			Me.keyButtonAdd.UnNumLockKeyCode = 0
			Me.keyButtonAdd.UnNumLockText = Nothing
			Me.keyButtonAdd.UseMnemonic = False
			' 
			' keyButtonNumberPad3
			' 
			Me.keyButtonNumberPad3.Dock = DockStyle.Fill
			Me.keyButtonNumberPad3.IsPressed = False
			Me.keyButtonNumberPad3.KeyCode = 99
			Me.keyButtonNumberPad3.Location = New Point(796, 160)
			Me.keyButtonNumberPad3.Name = "keyButtonNumberPad3"
			Me.keyButtonNumberPad3.NormalText = Nothing
			Me.keyButtonNumberPad3.Padding = New Padding(2)
			Me.keyButtonNumberPad3.ShiftText = Nothing
			Me.keyButtonNumberPad3.Size = New Size(31, 30)
			Me.keyButtonNumberPad3.TabIndex = 0
			Me.keyButtonNumberPad3.Text = "3"
			Me.keyButtonNumberPad3.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad3.UnNumLockText = Nothing
			Me.keyButtonNumberPad3.UseMnemonic = False
			' 
			' keyButtonNumberPad6
			' 
			Me.keyButtonNumberPad6.Dock = DockStyle.Fill
			Me.keyButtonNumberPad6.IsPressed = False
			Me.keyButtonNumberPad6.KeyCode = 102
			Me.keyButtonNumberPad6.Location = New Point(796, 124)
			Me.keyButtonNumberPad6.Name = "keyButtonNumberPad6"
			Me.keyButtonNumberPad6.NormalText = Nothing
			Me.keyButtonNumberPad6.Padding = New Padding(2)
			Me.keyButtonNumberPad6.ShiftText = Nothing
			Me.keyButtonNumberPad6.Size = New Size(31, 30)
			Me.keyButtonNumberPad6.TabIndex = 0
			Me.keyButtonNumberPad6.Text = "6"
			Me.keyButtonNumberPad6.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad6.UnNumLockText = Nothing
			Me.keyButtonNumberPad6.UseMnemonic = False
			' 
			' keyButtonNumberPad9
			' 
			Me.keyButtonNumberPad9.Dock = DockStyle.Fill
			Me.keyButtonNumberPad9.IsPressed = False
			Me.keyButtonNumberPad9.KeyCode = 105
			Me.keyButtonNumberPad9.Location = New Point(796, 88)
			Me.keyButtonNumberPad9.Name = "keyButtonNumberPad9"
			Me.keyButtonNumberPad9.NormalText = Nothing
			Me.keyButtonNumberPad9.Padding = New Padding(2)
			Me.keyButtonNumberPad9.ShiftText = Nothing
			Me.keyButtonNumberPad9.Size = New Size(31, 30)
			Me.keyButtonNumberPad9.TabIndex = 0
			Me.keyButtonNumberPad9.Text = "9"
			Me.keyButtonNumberPad9.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad9.UnNumLockText = Nothing
			Me.keyButtonNumberPad9.UseMnemonic = False
			' 
			' keyButtonF7
			' 
			Me.keyButtonF7.Dock = DockStyle.Fill
			Me.keyButtonF7.IsPressed = False
			Me.keyButtonF7.KeyCode = 118
			Me.keyButtonF7.Location = New Point(305, 3)
			Me.keyButtonF7.Name = "keyButtonF7"
			Me.keyButtonF7.NormalText = Nothing
			Me.keyButtonF7.Padding = New Padding(2)
			Me.keyButtonF7.ShiftText = Nothing
			Me.keyButtonF7.Size = New Size(31, 43)
			Me.keyButtonF7.TabIndex = 0
			Me.keyButtonF7.Text = "F7"
			Me.keyButtonF7.UnNumLockKeyCode = 0
			Me.keyButtonF7.UnNumLockText = Nothing
			Me.keyButtonF7.UseMnemonic = False
			' 
			' keyButtonD7
			' 
			Me.keyButtonD7.Dock = DockStyle.Fill
			Me.keyButtonD7.IsPressed = False
			Me.keyButtonD7.KeyCode = 55
			Me.keyButtonD7.Location = New Point(268, 52)
			Me.keyButtonD7.Name = "keyButtonD7"
			Me.keyButtonD7.NormalText = Nothing
			Me.keyButtonD7.Padding = New Padding(2)
			Me.keyButtonD7.ShiftText = Nothing
			Me.keyButtonD7.Size = New Size(31, 30)
			Me.keyButtonD7.TabIndex = 0
			Me.keyButtonD7.Text = "7"
			Me.keyButtonD7.UnNumLockKeyCode = 0
			Me.keyButtonD7.UnNumLockText = Nothing
			Me.keyButtonD7.UseMnemonic = False
			' 
			' keyButtonM
			' 
			Me.keyButtonM.Dock = DockStyle.Fill
			Me.keyButtonM.IsPressed = False
			Me.keyButtonM.KeyCode = 77
			Me.keyButtonM.Location = New Point(305, 160)
			Me.keyButtonM.Name = "keyButtonM"
			Me.keyButtonM.NormalText = Nothing
			Me.keyButtonM.Padding = New Padding(2)
			Me.keyButtonM.ShiftText = Nothing
			Me.keyButtonM.Size = New Size(31, 30)
			Me.keyButtonM.TabIndex = 0
			Me.keyButtonM.Text = "m"
			Me.keyButtonM.UnNumLockKeyCode = 0
			Me.keyButtonM.UnNumLockText = Nothing
			Me.keyButtonM.UseMnemonic = False
			' 
			' keyButtonJ
			' 
			Me.keyButtonJ.Dock = DockStyle.Fill
			Me.keyButtonJ.IsPressed = False
			Me.keyButtonJ.KeyCode = 74
			Me.keyButtonJ.Location = New Point(268, 124)
			Me.keyButtonJ.Name = "keyButtonJ"
			Me.keyButtonJ.NormalText = Nothing
			Me.keyButtonJ.Padding = New Padding(2)
			Me.keyButtonJ.ShiftText = Nothing
			Me.keyButtonJ.Size = New Size(31, 30)
			Me.keyButtonJ.TabIndex = 0
			Me.keyButtonJ.Text = "j"
			Me.keyButtonJ.UnNumLockKeyCode = 0
			Me.keyButtonJ.UnNumLockText = Nothing
			Me.keyButtonJ.UseMnemonic = False
			' 
			' keyButtonU
			' 
			Me.keyButtonU.Dock = DockStyle.Fill
			Me.keyButtonU.IsPressed = False
			Me.keyButtonU.KeyCode = 85
			Me.keyButtonU.Location = New Point(268, 88)
			Me.keyButtonU.Name = "keyButtonU"
			Me.keyButtonU.NormalText = Nothing
			Me.keyButtonU.Padding = New Padding(2)
			Me.keyButtonU.ShiftText = Nothing
			Me.keyButtonU.Size = New Size(31, 30)
			Me.keyButtonU.TabIndex = 0
			Me.keyButtonU.Text = "u"
			Me.keyButtonU.UnNumLockKeyCode = 0
			Me.keyButtonU.UnNumLockText = Nothing
			Me.keyButtonU.UseMnemonic = False
			' 
			' keyButtonNumLock
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonNumLock, 2)
			Me.keyButtonNumLock.Dock = DockStyle.Fill
			Me.keyButtonNumLock.IsPressed = False
			Me.keyButtonNumLock.KeyCode = 144
			Me.keyButtonNumLock.Location = New Point(796, 3)
			Me.keyButtonNumLock.Name = "keyButtonNumLock"
			Me.keyButtonNumLock.NormalText = Nothing
			Me.keyButtonNumLock.ShiftText = Nothing
			Me.keyButtonNumLock.Size = New Size(73, 43)
			Me.keyButtonNumLock.TabIndex = 0
			Me.keyButtonNumLock.Text = "Num"
			Me.keyButtonNumLock.UnNumLockKeyCode = 0
			Me.keyButtonNumLock.UnNumLockText = Nothing
			Me.keyButtonNumLock.UseMnemonic = False
			' 
			' keyButtonDecimal
			' 
			Me.keyButtonDecimal.Dock = DockStyle.Fill
			Me.keyButtonDecimal.IsPressed = False
			Me.keyButtonDecimal.KeyCode = 110
			Me.keyButtonDecimal.Location = New Point(796, 196)
			Me.keyButtonDecimal.Name = "keyButtonDecimal"
			Me.keyButtonDecimal.NormalText = Nothing
			Me.keyButtonDecimal.Padding = New Padding(2)
			Me.keyButtonDecimal.ShiftText = Nothing
			Me.keyButtonDecimal.Size = New Size(31, 31)
			Me.keyButtonDecimal.TabIndex = 0
			Me.keyButtonDecimal.Text = "."
			Me.keyButtonDecimal.UnNumLockKeyCode = 0
			Me.keyButtonDecimal.UnNumLockText = Nothing
			Me.keyButtonDecimal.UseMnemonic = False
			' 
			' keyButtonNumberPad2
			' 
			Me.keyButtonNumberPad2.Dock = DockStyle.Fill
			Me.keyButtonNumberPad2.IsPressed = False
			Me.keyButtonNumberPad2.KeyCode = 98
			Me.keyButtonNumberPad2.Location = New Point(759, 160)
			Me.keyButtonNumberPad2.Name = "keyButtonNumberPad2"
			Me.keyButtonNumberPad2.NormalText = Nothing
			Me.keyButtonNumberPad2.Padding = New Padding(2)
			Me.keyButtonNumberPad2.ShiftText = Nothing
			Me.keyButtonNumberPad2.Size = New Size(31, 30)
			Me.keyButtonNumberPad2.TabIndex = 0
			Me.keyButtonNumberPad2.Text = "2"
			Me.keyButtonNumberPad2.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad2.UnNumLockText = Nothing
			Me.keyButtonNumberPad2.UseMnemonic = False
			' 
			' keyButtonNumberPad5
			' 
			Me.keyButtonNumberPad5.Dock = DockStyle.Fill
			Me.keyButtonNumberPad5.IsPressed = False
			Me.keyButtonNumberPad5.KeyCode = 101
			Me.keyButtonNumberPad5.Location = New Point(759, 124)
			Me.keyButtonNumberPad5.Name = "keyButtonNumberPad5"
			Me.keyButtonNumberPad5.NormalText = Nothing
			Me.keyButtonNumberPad5.Padding = New Padding(2)
			Me.keyButtonNumberPad5.ShiftText = Nothing
			Me.keyButtonNumberPad5.Size = New Size(31, 30)
			Me.keyButtonNumberPad5.TabIndex = 0
			Me.keyButtonNumberPad5.Text = "5"
			Me.keyButtonNumberPad5.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad5.UnNumLockText = Nothing
			Me.keyButtonNumberPad5.UseMnemonic = False
			' 
			' keyButtonNumberPad8
			' 
			Me.keyButtonNumberPad8.Dock = DockStyle.Fill
			Me.keyButtonNumberPad8.IsPressed = False
			Me.keyButtonNumberPad8.KeyCode = 104
			Me.keyButtonNumberPad8.Location = New Point(759, 88)
			Me.keyButtonNumberPad8.Name = "keyButtonNumberPad8"
			Me.keyButtonNumberPad8.NormalText = Nothing
			Me.keyButtonNumberPad8.Padding = New Padding(2)
			Me.keyButtonNumberPad8.ShiftText = Nothing
			Me.keyButtonNumberPad8.Size = New Size(31, 30)
			Me.keyButtonNumberPad8.TabIndex = 0
			Me.keyButtonNumberPad8.Text = "8"
			Me.keyButtonNumberPad8.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad8.UnNumLockText = Nothing
			Me.keyButtonNumberPad8.UseMnemonic = False
			' 
			' keyButtonF6
			' 
			Me.keyButtonF6.Dock = DockStyle.Fill
			Me.keyButtonF6.IsPressed = False
			Me.keyButtonF6.KeyCode = 117
			Me.keyButtonF6.Location = New Point(268, 3)
			Me.keyButtonF6.Name = "keyButtonF6"
			Me.keyButtonF6.NormalText = Nothing
			Me.keyButtonF6.Padding = New Padding(2)
			Me.keyButtonF6.ShiftText = Nothing
			Me.keyButtonF6.Size = New Size(31, 43)
			Me.keyButtonF6.TabIndex = 0
			Me.keyButtonF6.Text = "F6"
			Me.keyButtonF6.UnNumLockKeyCode = 0
			Me.keyButtonF6.UnNumLockText = Nothing
			Me.keyButtonF6.UseMnemonic = False
			' 
			' keyButtonD6
			' 
			Me.keyButtonD6.Dock = DockStyle.Fill
			Me.keyButtonD6.IsPressed = False
			Me.keyButtonD6.KeyCode = 54
			Me.keyButtonD6.Location = New Point(231, 52)
			Me.keyButtonD6.Name = "keyButtonD6"
			Me.keyButtonD6.NormalText = Nothing
			Me.keyButtonD6.Padding = New Padding(2)
			Me.keyButtonD6.ShiftText = Nothing
			Me.keyButtonD6.Size = New Size(31, 30)
			Me.keyButtonD6.TabIndex = 0
			Me.keyButtonD6.Text = "6"
			Me.keyButtonD6.UnNumLockKeyCode = 0
			Me.keyButtonD6.UnNumLockText = Nothing
			Me.keyButtonD6.UseMnemonic = False
			' 
			' keyButtonN
			' 
			Me.keyButtonN.Dock = DockStyle.Fill
			Me.keyButtonN.IsPressed = False
			Me.keyButtonN.KeyCode = 78
			Me.keyButtonN.Location = New Point(268, 160)
			Me.keyButtonN.Name = "keyButtonN"
			Me.keyButtonN.NormalText = Nothing
			Me.keyButtonN.Padding = New Padding(2)
			Me.keyButtonN.ShiftText = Nothing
			Me.keyButtonN.Size = New Size(31, 30)
			Me.keyButtonN.TabIndex = 0
			Me.keyButtonN.Text = "n"
			Me.keyButtonN.UnNumLockKeyCode = 0
			Me.keyButtonN.UnNumLockText = Nothing
			Me.keyButtonN.UseMnemonic = False
			' 
			' keyButtonH
			' 
			Me.keyButtonH.Dock = DockStyle.Fill
			Me.keyButtonH.IsPressed = False
			Me.keyButtonH.KeyCode = 72
			Me.keyButtonH.Location = New Point(231, 124)
			Me.keyButtonH.Name = "keyButtonH"
			Me.keyButtonH.NormalText = Nothing
			Me.keyButtonH.Padding = New Padding(2)
			Me.keyButtonH.ShiftText = Nothing
			Me.keyButtonH.Size = New Size(31, 30)
			Me.keyButtonH.TabIndex = 0
			Me.keyButtonH.Text = "h"
			Me.keyButtonH.UnNumLockKeyCode = 0
			Me.keyButtonH.UnNumLockText = Nothing
			Me.keyButtonH.UseMnemonic = False
			' 
			' keyButtonY
			' 
			Me.keyButtonY.Dock = DockStyle.Fill
			Me.keyButtonY.IsPressed = False
			Me.keyButtonY.KeyCode = 89
			Me.keyButtonY.Location = New Point(231, 88)
			Me.keyButtonY.Name = "keyButtonY"
			Me.keyButtonY.NormalText = Nothing
			Me.keyButtonY.Padding = New Padding(2)
			Me.keyButtonY.ShiftText = Nothing
			Me.keyButtonY.Size = New Size(31, 30)
			Me.keyButtonY.TabIndex = 0
			Me.keyButtonY.Text = "y"
			Me.keyButtonY.UnNumLockKeyCode = 0
			Me.keyButtonY.UnNumLockText = Nothing
			Me.keyButtonY.UseMnemonic = False
			' 
			' keyButtonNumReturn
			' 
			Me.keyButtonNumReturn.Dock = DockStyle.Fill
			Me.keyButtonNumReturn.IsPressed = False
			Me.keyButtonNumReturn.KeyCode = 13
			Me.keyButtonNumReturn.Location = New Point(833, 160)
			Me.keyButtonNumReturn.Name = "keyButtonNumReturn"
			Me.keyButtonNumReturn.NormalText = Nothing
			Me.keyButtonNumReturn.Padding = New Padding(2)
			Me.tableLayoutPanelKeyButtons.SetRowSpan(Me.keyButtonNumReturn, 2)
			Me.keyButtonNumReturn.ShiftText = Nothing
			Me.keyButtonNumReturn.Size = New Size(36, 67)
			Me.keyButtonNumReturn.TabIndex = 0
			Me.keyButtonNumReturn.Text = "ENT"
			Me.keyButtonNumReturn.UnNumLockKeyCode = 0
			Me.keyButtonNumReturn.UnNumLockText = Nothing
			Me.keyButtonNumReturn.UseMnemonic = False
			' 
			' keyButtonNumberPad0
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonNumberPad0, 2)
			Me.keyButtonNumberPad0.Dock = DockStyle.Fill
			Me.keyButtonNumberPad0.IsPressed = False
			Me.keyButtonNumberPad0.KeyCode = 96
			Me.keyButtonNumberPad0.Location = New Point(722, 196)
			Me.keyButtonNumberPad0.Name = "keyButtonNumberPad0"
			Me.keyButtonNumberPad0.NormalText = Nothing
			Me.keyButtonNumberPad0.Padding = New Padding(2)
			Me.keyButtonNumberPad0.ShiftText = Nothing
			Me.keyButtonNumberPad0.Size = New Size(68, 31)
			Me.keyButtonNumberPad0.TabIndex = 0
			Me.keyButtonNumberPad0.Text = "0"
			Me.keyButtonNumberPad0.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad0.UnNumLockText = Nothing
			Me.keyButtonNumberPad0.UseMnemonic = False
			' 
			' keyButtonNumberPad1
			' 
			Me.keyButtonNumberPad1.Dock = DockStyle.Fill
			Me.keyButtonNumberPad1.IsPressed = False
			Me.keyButtonNumberPad1.KeyCode = 97
			Me.keyButtonNumberPad1.Location = New Point(722, 160)
			Me.keyButtonNumberPad1.Name = "keyButtonNumberPad1"
			Me.keyButtonNumberPad1.NormalText = Nothing
			Me.keyButtonNumberPad1.Padding = New Padding(2)
			Me.keyButtonNumberPad1.ShiftText = Nothing
			Me.keyButtonNumberPad1.Size = New Size(31, 30)
			Me.keyButtonNumberPad1.TabIndex = 0
			Me.keyButtonNumberPad1.Text = "1"
			Me.keyButtonNumberPad1.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad1.UnNumLockText = Nothing
			Me.keyButtonNumberPad1.UseMnemonic = False
			' 
			' keyButtonNumberPad4
			' 
			Me.keyButtonNumberPad4.Dock = DockStyle.Fill
			Me.keyButtonNumberPad4.IsPressed = False
			Me.keyButtonNumberPad4.KeyCode = 100
			Me.keyButtonNumberPad4.Location = New Point(722, 124)
			Me.keyButtonNumberPad4.Name = "keyButtonNumberPad4"
			Me.keyButtonNumberPad4.NormalText = Nothing
			Me.keyButtonNumberPad4.Padding = New Padding(2)
			Me.keyButtonNumberPad4.ShiftText = Nothing
			Me.keyButtonNumberPad4.Size = New Size(31, 30)
			Me.keyButtonNumberPad4.TabIndex = 0
			Me.keyButtonNumberPad4.Text = "4"
			Me.keyButtonNumberPad4.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad4.UnNumLockText = Nothing
			Me.keyButtonNumberPad4.UseMnemonic = False
			' 
			' keyButtonNumberPad7
			' 
			Me.keyButtonNumberPad7.Dock = DockStyle.Fill
			Me.keyButtonNumberPad7.IsPressed = False
			Me.keyButtonNumberPad7.KeyCode = 103
			Me.keyButtonNumberPad7.Location = New Point(722, 88)
			Me.keyButtonNumberPad7.Name = "keyButtonNumberPad7"
			Me.keyButtonNumberPad7.NormalText = Nothing
			Me.keyButtonNumberPad7.Padding = New Padding(2)
			Me.keyButtonNumberPad7.ShiftText = Nothing
			Me.keyButtonNumberPad7.Size = New Size(31, 30)
			Me.keyButtonNumberPad7.TabIndex = 0
			Me.keyButtonNumberPad7.Text = "7"
			Me.keyButtonNumberPad7.UnNumLockKeyCode = 0
			Me.keyButtonNumberPad7.UnNumLockText = Nothing
			Me.keyButtonNumberPad7.UseMnemonic = False
			' 
			' keyButtonF5
			' 
			Me.keyButtonF5.Dock = DockStyle.Fill
			Me.keyButtonF5.IsPressed = False
			Me.keyButtonF5.KeyCode = 116
			Me.keyButtonF5.Location = New Point(231, 3)
			Me.keyButtonF5.Name = "keyButtonF5"
			Me.keyButtonF5.NormalText = Nothing
			Me.keyButtonF5.Padding = New Padding(2)
			Me.keyButtonF5.ShiftText = Nothing
			Me.keyButtonF5.Size = New Size(31, 43)
			Me.keyButtonF5.TabIndex = 0
			Me.keyButtonF5.Text = "F5"
			Me.keyButtonF5.UnNumLockKeyCode = 0
			Me.keyButtonF5.UnNumLockText = Nothing
			Me.keyButtonF5.UseMnemonic = False
			' 
			' keyButtonD5
			' 
			Me.keyButtonD5.Dock = DockStyle.Fill
			Me.keyButtonD5.IsPressed = False
			Me.keyButtonD5.KeyCode = 53
			Me.keyButtonD5.Location = New Point(194, 52)
			Me.keyButtonD5.Name = "keyButtonD5"
			Me.keyButtonD5.NormalText = Nothing
			Me.keyButtonD5.Padding = New Padding(2)
			Me.keyButtonD5.ShiftText = Nothing
			Me.keyButtonD5.Size = New Size(31, 30)
			Me.keyButtonD5.TabIndex = 0
			Me.keyButtonD5.Text = "5"
			Me.keyButtonD5.UnNumLockKeyCode = 0
			Me.keyButtonD5.UnNumLockText = Nothing
			Me.keyButtonD5.UseMnemonic = False
			' 
			' keyButtonB
			' 
			Me.keyButtonB.Dock = DockStyle.Fill
			Me.keyButtonB.IsPressed = False
			Me.keyButtonB.KeyCode = 66
			Me.keyButtonB.Location = New Point(231, 160)
			Me.keyButtonB.Name = "keyButtonB"
			Me.keyButtonB.NormalText = Nothing
			Me.keyButtonB.Padding = New Padding(2)
			Me.keyButtonB.ShiftText = Nothing
			Me.keyButtonB.Size = New Size(31, 30)
			Me.keyButtonB.TabIndex = 0
			Me.keyButtonB.Text = "b"
			Me.keyButtonB.UnNumLockKeyCode = 0
			Me.keyButtonB.UnNumLockText = Nothing
			Me.keyButtonB.UseMnemonic = False
			' 
			' keyButtonG
			' 
			Me.keyButtonG.Dock = DockStyle.Fill
			Me.keyButtonG.IsPressed = False
			Me.keyButtonG.KeyCode = 71
			Me.keyButtonG.Location = New Point(194, 124)
			Me.keyButtonG.Name = "keyButtonG"
			Me.keyButtonG.NormalText = Nothing
			Me.keyButtonG.Padding = New Padding(2)
			Me.keyButtonG.ShiftText = Nothing
			Me.keyButtonG.Size = New Size(31, 30)
			Me.keyButtonG.TabIndex = 0
			Me.keyButtonG.Text = "g"
			Me.keyButtonG.UnNumLockKeyCode = 0
			Me.keyButtonG.UnNumLockText = Nothing
			Me.keyButtonG.UseMnemonic = False
			' 
			' keyButtonT
			' 
			Me.keyButtonT.Dock = DockStyle.Fill
			Me.keyButtonT.IsPressed = False
			Me.keyButtonT.KeyCode = 84
			Me.keyButtonT.Location = New Point(194, 88)
			Me.keyButtonT.Name = "keyButtonT"
			Me.keyButtonT.NormalText = Nothing
			Me.keyButtonT.Padding = New Padding(2)
			Me.keyButtonT.ShiftText = Nothing
			Me.keyButtonT.Size = New Size(31, 30)
			Me.keyButtonT.TabIndex = 0
			Me.keyButtonT.Text = "t"
			Me.keyButtonT.UnNumLockKeyCode = 0
			Me.keyButtonT.UnNumLockText = Nothing
			Me.keyButtonT.UseMnemonic = False
			' 
			' keyButtonF4
			' 
			Me.keyButtonF4.Dock = DockStyle.Fill
			Me.keyButtonF4.IsPressed = False
			Me.keyButtonF4.KeyCode = 115
			Me.keyButtonF4.Location = New Point(157, 3)
			Me.keyButtonF4.Name = "keyButtonF4"
			Me.keyButtonF4.NormalText = Nothing
			Me.keyButtonF4.Padding = New Padding(2)
			Me.keyButtonF4.ShiftText = Nothing
			Me.keyButtonF4.Size = New Size(31, 43)
			Me.keyButtonF4.TabIndex = 0
			Me.keyButtonF4.Text = "F4"
			Me.keyButtonF4.UnNumLockKeyCode = 0
			Me.keyButtonF4.UnNumLockText = Nothing
			Me.keyButtonF4.UseMnemonic = False
			' 
			' keyButtonD4
			' 
			Me.keyButtonD4.Dock = DockStyle.Fill
			Me.keyButtonD4.IsPressed = False
			Me.keyButtonD4.KeyCode = 52
			Me.keyButtonD4.Location = New Point(157, 52)
			Me.keyButtonD4.Name = "keyButtonD4"
			Me.keyButtonD4.NormalText = Nothing
			Me.keyButtonD4.Padding = New Padding(2)
			Me.keyButtonD4.ShiftText = Nothing
			Me.keyButtonD4.Size = New Size(31, 30)
			Me.keyButtonD4.TabIndex = 0
			Me.keyButtonD4.Text = "4"
			Me.keyButtonD4.UnNumLockKeyCode = 0
			Me.keyButtonD4.UnNumLockText = Nothing
			Me.keyButtonD4.UseMnemonic = False
			' 
			' keyButtonV
			' 
			Me.keyButtonV.Dock = DockStyle.Fill
			Me.keyButtonV.IsPressed = False
			Me.keyButtonV.KeyCode = 86
			Me.keyButtonV.Location = New Point(194, 160)
			Me.keyButtonV.Name = "keyButtonV"
			Me.keyButtonV.NormalText = Nothing
			Me.keyButtonV.Padding = New Padding(2)
			Me.keyButtonV.ShiftText = Nothing
			Me.keyButtonV.Size = New Size(31, 30)
			Me.keyButtonV.TabIndex = 0
			Me.keyButtonV.Text = "v"
			Me.keyButtonV.UnNumLockKeyCode = 0
			Me.keyButtonV.UnNumLockText = Nothing
			Me.keyButtonV.UseMnemonic = False
			' 
			' keyButtonF
			' 
			Me.keyButtonF.Dock = DockStyle.Fill
			Me.keyButtonF.IsPressed = False
			Me.keyButtonF.KeyCode = 70
			Me.keyButtonF.Location = New Point(157, 124)
			Me.keyButtonF.Name = "keyButtonF"
			Me.keyButtonF.NormalText = Nothing
			Me.keyButtonF.Padding = New Padding(2)
			Me.keyButtonF.ShiftText = Nothing
			Me.keyButtonF.Size = New Size(31, 30)
			Me.keyButtonF.TabIndex = 0
			Me.keyButtonF.Text = "f"
			Me.keyButtonF.UnNumLockKeyCode = 0
			Me.keyButtonF.UnNumLockText = Nothing
			Me.keyButtonF.UseMnemonic = False
			' 
			' keyButtonR
			' 
			Me.keyButtonR.Dock = DockStyle.Fill
			Me.keyButtonR.IsPressed = False
			Me.keyButtonR.KeyCode = 82
			Me.keyButtonR.Location = New Point(157, 88)
			Me.keyButtonR.Name = "keyButtonR"
			Me.keyButtonR.NormalText = Nothing
			Me.keyButtonR.Padding = New Padding(2)
			Me.keyButtonR.ShiftText = Nothing
			Me.keyButtonR.Size = New Size(31, 30)
			Me.keyButtonR.TabIndex = 0
			Me.keyButtonR.Text = "r"
			Me.keyButtonR.UnNumLockKeyCode = 0
			Me.keyButtonR.UnNumLockText = Nothing
			Me.keyButtonR.UseMnemonic = False
			' 
			' keyButtonF3
			' 
			Me.keyButtonF3.Dock = DockStyle.Fill
			Me.keyButtonF3.IsPressed = False
			Me.keyButtonF3.KeyCode = 114
			Me.keyButtonF3.Location = New Point(120, 3)
			Me.keyButtonF3.Name = "keyButtonF3"
			Me.keyButtonF3.NormalText = Nothing
			Me.keyButtonF3.Padding = New Padding(2)
			Me.keyButtonF3.ShiftText = Nothing
			Me.keyButtonF3.Size = New Size(31, 43)
			Me.keyButtonF3.TabIndex = 0
			Me.keyButtonF3.Text = "F3"
			Me.keyButtonF3.UnNumLockKeyCode = 0
			Me.keyButtonF3.UnNumLockText = Nothing
			Me.keyButtonF3.UseMnemonic = False
			' 
			' keyButtonD3
			' 
			Me.keyButtonD3.Dock = DockStyle.Fill
			Me.keyButtonD3.IsPressed = False
			Me.keyButtonD3.KeyCode = 51
			Me.keyButtonD3.Location = New Point(120, 52)
			Me.keyButtonD3.Name = "keyButtonD3"
			Me.keyButtonD3.NormalText = Nothing
			Me.keyButtonD3.Padding = New Padding(2)
			Me.keyButtonD3.ShiftText = Nothing
			Me.keyButtonD3.Size = New Size(31, 30)
			Me.keyButtonD3.TabIndex = 0
			Me.keyButtonD3.Text = "3"
			Me.keyButtonD3.UnNumLockKeyCode = 0
			Me.keyButtonD3.UnNumLockText = Nothing
			Me.keyButtonD3.UseMnemonic = False
			' 
			' keyButtonSpace
			' 
			Me.tableLayoutPanelKeyButtons.SetColumnSpan(Me.keyButtonSpace, 9)
			Me.keyButtonSpace.Dock = DockStyle.Fill
			Me.keyButtonSpace.IsPressed = False
			Me.keyButtonSpace.KeyCode = 32
			Me.keyButtonSpace.Location = New Point(120, 196)
			Me.keyButtonSpace.Name = "keyButtonSpace"
			Me.keyButtonSpace.NormalText = Nothing
			Me.keyButtonSpace.Padding = New Padding(2)
			Me.keyButtonSpace.ShiftText = Nothing
			Me.keyButtonSpace.Size = New Size(327, 31)
			Me.keyButtonSpace.TabIndex = 0
			Me.keyButtonSpace.UnNumLockKeyCode = 0
			Me.keyButtonSpace.UnNumLockText = Nothing
			Me.keyButtonSpace.UseMnemonic = False
			' 
			' keyButtonC
			' 
			Me.keyButtonC.Dock = DockStyle.Fill
			Me.keyButtonC.IsPressed = False
			Me.keyButtonC.KeyCode = 67
			Me.keyButtonC.Location = New Point(157, 160)
			Me.keyButtonC.Name = "keyButtonC"
			Me.keyButtonC.NormalText = Nothing
			Me.keyButtonC.Padding = New Padding(2)
			Me.keyButtonC.ShiftText = Nothing
			Me.keyButtonC.Size = New Size(31, 30)
			Me.keyButtonC.TabIndex = 0
			Me.keyButtonC.Text = "c"
			Me.keyButtonC.UnNumLockKeyCode = 0
			Me.keyButtonC.UnNumLockText = Nothing
			Me.keyButtonC.UseMnemonic = False
			' 
			' keyButtonD
			' 
			Me.keyButtonD.Dock = DockStyle.Fill
			Me.keyButtonD.IsPressed = False
			Me.keyButtonD.KeyCode = 68
			Me.keyButtonD.Location = New Point(120, 124)
			Me.keyButtonD.Name = "keyButtonD"
			Me.keyButtonD.NormalText = Nothing
			Me.keyButtonD.Padding = New Padding(2)
			Me.keyButtonD.ShiftText = Nothing
			Me.keyButtonD.Size = New Size(31, 30)
			Me.keyButtonD.TabIndex = 0
			Me.keyButtonD.Text = "d"
			Me.keyButtonD.UnNumLockKeyCode = 0
			Me.keyButtonD.UnNumLockText = Nothing
			Me.keyButtonD.UseMnemonic = False
			' 
			' keyButtonE
			' 
			Me.keyButtonE.Dock = DockStyle.Fill
			Me.keyButtonE.IsPressed = False
			Me.keyButtonE.KeyCode = 69
			Me.keyButtonE.Location = New Point(120, 88)
			Me.keyButtonE.Name = "keyButtonE"
			Me.keyButtonE.NormalText = Nothing
			Me.keyButtonE.Padding = New Padding(2)
			Me.keyButtonE.ShiftText = Nothing
			Me.keyButtonE.Size = New Size(31, 30)
			Me.keyButtonE.TabIndex = 0
			Me.keyButtonE.Text = "e"
			Me.keyButtonE.UnNumLockKeyCode = 0
			Me.keyButtonE.UnNumLockText = Nothing
			Me.keyButtonE.UseMnemonic = False
			' 
			' keyButtonF12
			' 
			Me.keyButtonF12.Dock = DockStyle.Fill
			Me.keyButtonF12.IsPressed = False
			Me.keyButtonF12.KeyCode = 123
			Me.keyButtonF12.Location = New Point(527, 3)
			Me.keyButtonF12.Name = "keyButtonF12"
			Me.keyButtonF12.NormalText = Nothing
			Me.keyButtonF12.Padding = New Padding(2)
			Me.keyButtonF12.ShiftText = Nothing
			Me.keyButtonF12.Size = New Size(31, 43)
			Me.keyButtonF12.TabIndex = 0
			Me.keyButtonF12.Text = "F12"
			Me.keyButtonF12.UnNumLockKeyCode = 0
			Me.keyButtonF12.UnNumLockText = Nothing
			Me.keyButtonF12.UseMnemonic = False
			' 
			' keyButtonF2
			' 
			Me.keyButtonF2.Dock = DockStyle.Fill
			Me.keyButtonF2.IsPressed = False
			Me.keyButtonF2.KeyCode = 113
			Me.keyButtonF2.Location = New Point(83, 3)
			Me.keyButtonF2.Name = "keyButtonF2"
			Me.keyButtonF2.NormalText = Nothing
			Me.keyButtonF2.Padding = New Padding(2)
			Me.keyButtonF2.ShiftText = Nothing
			Me.keyButtonF2.Size = New Size(31, 43)
			Me.keyButtonF2.TabIndex = 0
			Me.keyButtonF2.Text = "F2"
			Me.keyButtonF2.UnNumLockKeyCode = 0
			Me.keyButtonF2.UnNumLockText = Nothing
			Me.keyButtonF2.UseMnemonic = False
			' 
			' keyButtonD2
			' 
			Me.keyButtonD2.Dock = DockStyle.Fill
			Me.keyButtonD2.IsPressed = False
			Me.keyButtonD2.KeyCode = 50
			Me.keyButtonD2.Location = New Point(83, 52)
			Me.keyButtonD2.Name = "keyButtonD2"
			Me.keyButtonD2.NormalText = Nothing
			Me.keyButtonD2.Padding = New Padding(2)
			Me.keyButtonD2.ShiftText = Nothing
			Me.keyButtonD2.Size = New Size(31, 30)
			Me.keyButtonD2.TabIndex = 0
			Me.keyButtonD2.Text = "2"
			Me.keyButtonD2.UnNumLockKeyCode = 0
			Me.keyButtonD2.UnNumLockText = Nothing
			Me.keyButtonD2.UseMnemonic = False
			' 
			' keyButtonLAlt
			' 
			Me.keyButtonLAlt.Dock = DockStyle.Fill
			Me.keyButtonLAlt.IsPressed = False
			Me.keyButtonLAlt.KeyCode = 18
			Me.keyButtonLAlt.Location = New Point(83, 196)
			Me.keyButtonLAlt.Name = "keyButtonLAlt"
			Me.keyButtonLAlt.NormalText = Nothing
			Me.keyButtonLAlt.Padding = New Padding(2)
			Me.keyButtonLAlt.ShiftText = Nothing
			Me.keyButtonLAlt.Size = New Size(31, 31)
			Me.keyButtonLAlt.TabIndex = 0
			Me.keyButtonLAlt.Text = "Alt"
			Me.keyButtonLAlt.UnNumLockKeyCode = 0
			Me.keyButtonLAlt.UnNumLockText = Nothing
			Me.keyButtonLAlt.UseMnemonic = False
			' 
			' keyButtonX
			' 
			Me.keyButtonX.Dock = DockStyle.Fill
			Me.keyButtonX.IsPressed = False
			Me.keyButtonX.KeyCode = 88
			Me.keyButtonX.Location = New Point(120, 160)
			Me.keyButtonX.Name = "keyButtonX"
			Me.keyButtonX.NormalText = Nothing
			Me.keyButtonX.Padding = New Padding(2)
			Me.keyButtonX.ShiftText = Nothing
			Me.keyButtonX.Size = New Size(31, 30)
			Me.keyButtonX.TabIndex = 0
			Me.keyButtonX.Text = "x"
			Me.keyButtonX.UnNumLockKeyCode = 0
			Me.keyButtonX.UnNumLockText = Nothing
			Me.keyButtonX.UseMnemonic = False
			' 
			' keyButtonS
			' 
			Me.keyButtonS.Dock = DockStyle.Fill
			Me.keyButtonS.IsPressed = False
			Me.keyButtonS.KeyCode = 83
			Me.keyButtonS.Location = New Point(83, 124)
			Me.keyButtonS.Name = "keyButtonS"
			Me.keyButtonS.NormalText = Nothing
			Me.keyButtonS.Padding = New Padding(2)
			Me.keyButtonS.ShiftText = Nothing
			Me.keyButtonS.Size = New Size(31, 30)
			Me.keyButtonS.TabIndex = 0
			Me.keyButtonS.Text = "s"
			Me.keyButtonS.UnNumLockKeyCode = 0
			Me.keyButtonS.UnNumLockText = Nothing
			Me.keyButtonS.UseMnemonic = False
			' 
			' keyButtonW
			' 
			Me.keyButtonW.Dock = DockStyle.Fill
			Me.keyButtonW.IsPressed = False
			Me.keyButtonW.KeyCode = 87
			Me.keyButtonW.Location = New Point(83, 88)
			Me.keyButtonW.Name = "keyButtonW"
			Me.keyButtonW.NormalText = Nothing
			Me.keyButtonW.Padding = New Padding(2)
			Me.keyButtonW.ShiftText = Nothing
			Me.keyButtonW.Size = New Size(31, 30)
			Me.keyButtonW.TabIndex = 0
			Me.keyButtonW.Text = "w"
			Me.keyButtonW.UnNumLockKeyCode = 0
			Me.keyButtonW.UnNumLockText = Nothing
			Me.keyButtonW.UseMnemonic = False
			' 
			' keyButtonF11
			' 
			Me.keyButtonF11.Dock = DockStyle.Fill
			Me.keyButtonF11.IsPressed = False
			Me.keyButtonF11.KeyCode = 122
			Me.keyButtonF11.Location = New Point(490, 3)
			Me.keyButtonF11.Name = "keyButtonF11"
			Me.keyButtonF11.NormalText = Nothing
			Me.keyButtonF11.Padding = New Padding(2)
			Me.keyButtonF11.ShiftText = Nothing
			Me.keyButtonF11.Size = New Size(31, 43)
			Me.keyButtonF11.TabIndex = 0
			Me.keyButtonF11.Text = "F11"
			Me.keyButtonF11.UnNumLockKeyCode = 0
			Me.keyButtonF11.UnNumLockText = Nothing
			Me.keyButtonF11.UseMnemonic = False
			' 
			' keyButtonF1
			' 
			Me.keyButtonF1.Dock = DockStyle.Fill
			Me.keyButtonF1.IsPressed = False
			Me.keyButtonF1.KeyCode = 112
			Me.keyButtonF1.Location = New Point(46, 3)
			Me.keyButtonF1.Name = "keyButtonF1"
			Me.keyButtonF1.NormalText = Nothing
			Me.keyButtonF1.Padding = New Padding(2)
			Me.keyButtonF1.ShiftText = Nothing
			Me.keyButtonF1.Size = New Size(31, 43)
			Me.keyButtonF1.TabIndex = 0
			Me.keyButtonF1.Text = "F1"
			Me.keyButtonF1.UnNumLockKeyCode = 0
			Me.keyButtonF1.UnNumLockText = Nothing
			Me.keyButtonF1.UseMnemonic = False
			' 
			' keyButtonD1
			' 
			Me.keyButtonD1.Dock = DockStyle.Fill
			Me.keyButtonD1.IsPressed = False
			Me.keyButtonD1.KeyCode = 49
			Me.keyButtonD1.Location = New Point(46, 52)
			Me.keyButtonD1.Name = "keyButtonD1"
			Me.keyButtonD1.NormalText = Nothing
			Me.keyButtonD1.Padding = New Padding(2)
			Me.keyButtonD1.ShiftText = Nothing
			Me.keyButtonD1.Size = New Size(31, 30)
			Me.keyButtonD1.TabIndex = 0
			Me.keyButtonD1.Text = "1"
			Me.keyButtonD1.UnNumLockKeyCode = 0
			Me.keyButtonD1.UnNumLockText = Nothing
			Me.keyButtonD1.UseMnemonic = False
			' 
			' keyButtonWin
			' 
			Me.keyButtonWin.Dock = DockStyle.Fill
			Me.keyButtonWin.IsPressed = False
			Me.keyButtonWin.KeyCode = 91
			Me.keyButtonWin.Location = New Point(46, 196)
			Me.keyButtonWin.Name = "keyButtonWin"
			Me.keyButtonWin.NormalText = Nothing
			Me.keyButtonWin.Padding = New Padding(2)
			Me.keyButtonWin.ShiftText = Nothing
			Me.keyButtonWin.Size = New Size(31, 31)
			Me.keyButtonWin.TabIndex = 0
			Me.keyButtonWin.Text = "Win"
			Me.keyButtonWin.UnNumLockKeyCode = 0
			Me.keyButtonWin.UnNumLockText = Nothing
			Me.keyButtonWin.UseMnemonic = False
			' 
			' keyButtonZ
			' 
			Me.keyButtonZ.Dock = DockStyle.Fill
			Me.keyButtonZ.IsPressed = False
			Me.keyButtonZ.KeyCode = 90
			Me.keyButtonZ.Location = New Point(83, 160)
			Me.keyButtonZ.Name = "keyButtonZ"
			Me.keyButtonZ.NormalText = Nothing
			Me.keyButtonZ.Padding = New Padding(2)
			Me.keyButtonZ.ShiftText = Nothing
			Me.keyButtonZ.Size = New Size(31, 30)
			Me.keyButtonZ.TabIndex = 0
			Me.keyButtonZ.Text = "z"
			Me.keyButtonZ.UnNumLockKeyCode = 0
			Me.keyButtonZ.UnNumLockText = Nothing
			Me.keyButtonZ.UseMnemonic = False
			' 
			' keyButtonA
			' 
			Me.keyButtonA.Dock = DockStyle.Fill
			Me.keyButtonA.IsPressed = False
			Me.keyButtonA.KeyCode = 65
			Me.keyButtonA.Location = New Point(46, 124)
			Me.keyButtonA.Name = "keyButtonA"
			Me.keyButtonA.NormalText = Nothing
			Me.keyButtonA.Padding = New Padding(2)
			Me.keyButtonA.ShiftText = Nothing
			Me.keyButtonA.Size = New Size(31, 30)
			Me.keyButtonA.TabIndex = 0
			Me.keyButtonA.Text = "a"
			Me.keyButtonA.UnNumLockKeyCode = 0
			Me.keyButtonA.UnNumLockText = Nothing
			Me.keyButtonA.UseMnemonic = False
			' 
			' keyButtonQ
			' 
			Me.keyButtonQ.Dock = DockStyle.Fill
			Me.keyButtonQ.IsPressed = False
			Me.keyButtonQ.KeyCode = 81
			Me.keyButtonQ.Location = New Point(46, 88)
			Me.keyButtonQ.Name = "keyButtonQ"
			Me.keyButtonQ.NormalText = Nothing
			Me.keyButtonQ.Padding = New Padding(2)
			Me.keyButtonQ.ShiftText = Nothing
			Me.keyButtonQ.Size = New Size(31, 30)
			Me.keyButtonQ.TabIndex = 0
			Me.keyButtonQ.Text = "q"
			Me.keyButtonQ.UnNumLockKeyCode = 0
			Me.keyButtonQ.UnNumLockText = Nothing
			Me.keyButtonQ.UseMnemonic = False
			' 
			' keyButtonTilde
			' 
			Me.keyButtonTilde.Dock = DockStyle.Fill
			Me.keyButtonTilde.IsPressed = False
			Me.keyButtonTilde.KeyCode = 192
			Me.keyButtonTilde.Location = New Point(3, 52)
			Me.keyButtonTilde.Name = "keyButtonTilde"
			Me.keyButtonTilde.NormalText = Nothing
			Me.keyButtonTilde.Padding = New Padding(2)
			Me.keyButtonTilde.ShiftText = Nothing
			Me.keyButtonTilde.Size = New Size(37, 30)
			Me.keyButtonTilde.TabIndex = 0
			Me.keyButtonTilde.Text = "`"
			Me.keyButtonTilde.UnNumLockKeyCode = 0
			Me.keyButtonTilde.UnNumLockText = Nothing
			Me.keyButtonTilde.UseMnemonic = False
			' 
			' keyButtonLControl
			' 
			Me.keyButtonLControl.Dock = DockStyle.Fill
			Me.keyButtonLControl.IsPressed = False
			Me.keyButtonLControl.KeyCode = 17
			Me.keyButtonLControl.Location = New Point(3, 196)
			Me.keyButtonLControl.Name = "keyButtonLControl"
			Me.keyButtonLControl.NormalText = Nothing
			Me.keyButtonLControl.Padding = New Padding(2)
			Me.keyButtonLControl.ShiftText = Nothing
			Me.keyButtonLControl.Size = New Size(37, 31)
			Me.keyButtonLControl.TabIndex = 0
			Me.keyButtonLControl.Text = "Ctrl"
			Me.keyButtonLControl.UnNumLockKeyCode = 0
			Me.keyButtonLControl.UnNumLockText = Nothing
			Me.keyButtonLControl.UseMnemonic = False
			' 
			' keyButtonLShift
			' 
			Me.keyButtonLShift.Dock = DockStyle.Fill
			Me.keyButtonLShift.IsPressed = False
			Me.keyButtonLShift.KeyCode = 16
			Me.keyButtonLShift.Location = New Point(3, 160)
			Me.keyButtonLShift.Name = "keyButtonLShift"
			Me.keyButtonLShift.NormalText = Nothing
			Me.keyButtonLShift.Padding = New Padding(2)
			Me.keyButtonLShift.ShiftText = Nothing
			Me.keyButtonLShift.Size = New Size(37, 30)
			Me.keyButtonLShift.TabIndex = 0
			Me.keyButtonLShift.Text = "Shift"
			Me.keyButtonLShift.UnNumLockKeyCode = 0
			Me.keyButtonLShift.UnNumLockText = Nothing
			Me.keyButtonLShift.UseMnemonic = False
			' 
			' keyButtonCapsLock
			' 
			Me.keyButtonCapsLock.Dock = DockStyle.Fill
			Me.keyButtonCapsLock.IsPressed = False
			Me.keyButtonCapsLock.KeyCode = 20
			Me.keyButtonCapsLock.Location = New Point(3, 124)
			Me.keyButtonCapsLock.Name = "keyButtonCapsLock"
			Me.keyButtonCapsLock.NormalText = Nothing
			Me.keyButtonCapsLock.Padding = New Padding(2)
			Me.keyButtonCapsLock.ShiftText = Nothing
			Me.keyButtonCapsLock.Size = New Size(37, 30)
			Me.keyButtonCapsLock.TabIndex = 0
			Me.keyButtonCapsLock.Text = "Caps"
			Me.keyButtonCapsLock.UnNumLockKeyCode = 0
			Me.keyButtonCapsLock.UnNumLockText = Nothing
			Me.keyButtonCapsLock.UseMnemonic = False
			' 
			' keyButtonTab
			' 
			Me.keyButtonTab.Dock = DockStyle.Fill
			Me.keyButtonTab.IsPressed = False
			Me.keyButtonTab.KeyCode = 9
			Me.keyButtonTab.Location = New Point(3, 88)
			Me.keyButtonTab.Name = "keyButtonTab"
			Me.keyButtonTab.NormalText = Nothing
			Me.keyButtonTab.Padding = New Padding(2)
			Me.keyButtonTab.ShiftText = Nothing
			Me.keyButtonTab.Size = New Size(37, 30)
			Me.keyButtonTab.TabIndex = 0
			Me.keyButtonTab.Text = "Tab"
			Me.keyButtonTab.UnNumLockKeyCode = 0
			Me.keyButtonTab.UnNumLockText = Nothing
			Me.keyButtonTab.UseMnemonic = False
			' 
			' keyButtonEscape
			' 
			Me.keyButtonEscape.Dock = DockStyle.Fill
			Me.keyButtonEscape.IsPressed = False
			Me.keyButtonEscape.KeyCode = 27
			Me.keyButtonEscape.Location = New Point(3, 3)
			Me.keyButtonEscape.Name = "keyButtonEscape"
			Me.keyButtonEscape.NormalText = Nothing
			Me.keyButtonEscape.Padding = New Padding(2)
			Me.keyButtonEscape.ShiftText = Nothing
			Me.keyButtonEscape.Size = New Size(37, 43)
			Me.keyButtonEscape.TabIndex = 0
			Me.keyButtonEscape.Text = "Esc"
			Me.keyButtonEscape.UnNumLockKeyCode = 0
			Me.keyButtonEscape.UnNumLockText = Nothing
			Me.keyButtonEscape.UseMnemonic = False
			' 
			' tableLayoutPanelKeyButtons
			' 
			Me.tableLayoutPanelKeyButtons.ColumnCount = 25
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle())
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 5F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 5F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 4.545455F))
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonEscape, 0, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonLControl, 0, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonRAlt, 12, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonApps, 13, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonRControl, 14, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonUp, 17, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonSpace, 3, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF1, 1, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonLAlt, 2, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonWin, 1, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonRight, 18, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF2, 2, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonSemicolon, 10, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF3, 3, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF4, 4, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonLeft, 16, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonL, 9, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonDown, 17, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD0, 10, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonK, 8, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonHome, 16, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonJ, 7, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonPageUp, 16, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonLShift, 0, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonH, 6, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonG, 5, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF, 4, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad3, 23, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonBack, 13, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad6, 23, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD, 3, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad0, 21, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonS, 2, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad2, 22, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonPlus, 12, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad9, 23, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonA, 1, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonTilde, 0, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad5, 22, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad1, 21, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonCapsLock, 0, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD1, 1, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonMinus, 11, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD2, 2, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad8, 22, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD3, 3, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad4, 21, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD4, 4, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD5, 5, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD6, 6, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumberPad7, 21, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD7, 7, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD8, 8, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonD9, 9, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonInsert, 16, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonTab, 0, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonQ, 1, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonW, 2, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonE, 3, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonR, 4, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonT, 5, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonY, 6, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonU, 7, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonI, 8, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonO, 9, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonP, 10, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumLock, 23, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonPause, 21, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonSubtract, 24, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonMultiply, 23, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonDivide, 21, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonAdd, 24, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonNumReturn, 24, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonPrintScreen, 16, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonDecimal, 23, 5)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonScrollLock, 18, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonDelete, 18, 1)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonPageDown, 18, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonEnd, 18, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF12, 14, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF11, 13, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF10, 12, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF9, 11, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF8, 9, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF7, 8, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF6, 7, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonF5, 6, 0)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonRShift, 13, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonQuestion, 12, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonPeriod, 10, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonComma, 9, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonM, 8, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonN, 7, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonB, 6, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonV, 5, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonC, 4, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonX, 3, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonZ, 2, 4)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonOpenBrackets, 11, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonCloseBrackets, 12, 2)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonProcess, 11, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonOemPipe, 12, 3)
			Me.tableLayoutPanelKeyButtons.Controls.Add(Me.keyButtonReturn, 13, 2)
			Me.tableLayoutPanelKeyButtons.Location = New Point(0, 0)
			Me.tableLayoutPanelKeyButtons.Name = "tableLayoutPanelKeyButtons"
			Me.tableLayoutPanelKeyButtons.RowCount = 6
			Me.tableLayoutPanelKeyButtons.RowStyles.Add(New RowStyle())
			Me.tableLayoutPanelKeyButtons.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanelKeyButtons.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanelKeyButtons.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanelKeyButtons.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanelKeyButtons.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
			Me.tableLayoutPanelKeyButtons.Size = New Size(872, 230)
			Me.tableLayoutPanelKeyButtons.TabIndex = 3
			' 
			' KeyBoardForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(872, 230)
			Me.Controls.Add(Me.tableLayoutPanelKeyButtons)
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.Margin = New Padding(3, 2, 3, 2)
			Me.MaximizeBox = False
			Me.Name = "KeyBoardForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "Soft Keyboard"
			Me.TopMost = True
'			Me.Load += New System.EventHandler(Me.KeyBoardForm_Load)
			CType(Me.keyButtonUp, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonRControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonProcess, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonOpenBrackets, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF10, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD0, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonRight, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonRShift, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonReturn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonDelete, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonScrollLock, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonPause, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonPageDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonPageUp, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonPrintScreen, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonInsert, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonEnd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonHome, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonBack, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonDown, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonOemPipe, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonPlus, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonLeft, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonCloseBrackets, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonMinus, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonApps, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonQuestion, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonSemicolon, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonP, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonRAlt, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonPeriod, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonL, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonO, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonSubtract, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonMultiply, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonDivide, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonComma, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonK, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonI, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonAdd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad9, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonM, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonJ, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonU, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumLock, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonDecimal, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonN, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonH, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonY, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumReturn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad0, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonNumberPad7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonB, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonG, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonT, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonV, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonR, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonSpace, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonC, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonE, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF12, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonLAlt, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonX, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonS, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonW, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonF1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonD1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonWin, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonZ, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonA, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonQ, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonTilde, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonLControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonLShift, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonCapsLock, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonTab, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyButtonEscape, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanelKeyButtons.ResumeLayout(False)
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private keyButtonEscape As KeyButton
		Private keyButtonTilde As KeyButton
		Private keyButtonD1 As KeyButton
		Private keyButtonD2 As KeyButton
		Private keyButtonD3 As KeyButton
		Private keyButtonD4 As KeyButton
		Private keyButtonD5 As KeyButton
		Private keyButtonD6 As KeyButton
		Private keyButtonD7 As KeyButton
		Private keyButtonD8 As KeyButton
		Private keyButtonD9 As KeyButton
		Private keyButtonD0 As KeyButton
		Private keyButtonMinus As KeyButton
		Private keyButtonPlus As KeyButton
		Private keyButtonBack As KeyButton
		Private keyButtonTab As KeyButton
		Private keyButtonQ As KeyButton
		Private keyButtonW As KeyButton
		Private keyButtonE As KeyButton
		Private keyButtonR As KeyButton
		Private keyButtonT As KeyButton
		Private keyButtonY As KeyButton
		Private keyButtonU As KeyButton
		Private keyButtonI As KeyButton
		Private keyButtonO As KeyButton
		Private keyButtonP As KeyButton
		Private keyButtonCloseBrackets As KeyButton
		Private keyButtonOemPipe As KeyButton
		Private keyButtonDelete As KeyButton
		Private keyButtonOpenBrackets As KeyButton
		Private keyButtonCapsLock As KeyButton
		Private keyButtonA As KeyButton
		Private keyButtonS As KeyButton
		Private keyButtonD As KeyButton
		Private keyButtonF As KeyButton
		Private keyButtonG As KeyButton
		Private keyButtonH As KeyButton
		Private keyButtonJ As KeyButton
		Private keyButtonK As KeyButton
		Private keyButtonL As KeyButton
		Private keyButtonSemicolon As KeyButton
		Private keyButtonReturn As KeyButton
		Private keyButtonProcess As KeyButton
		Private keyButtonLShift As KeyButton
		Private keyButtonZ As KeyButton
		Private keyButtonX As KeyButton
		Private keyButtonC As KeyButton
		Private keyButtonV As KeyButton
		Private keyButtonB As KeyButton
		Private keyButtonN As KeyButton
		Private keyButtonM As KeyButton
		Private keyButtonComma As KeyButton
		Private keyButtonPeriod As KeyButton
		Private keyButtonQuestion As KeyButton
		Private keyButtonRShift As KeyButton
		Private keyButtonLControl As KeyButton
		Private keyButtonWin As KeyButton
		Private keyButtonLAlt As KeyButton
		Private keyButtonSpace As KeyButton
		Private keyButtonRAlt As KeyButton
		Private keyButtonApps As KeyButton
		Private keyButtonLeft As KeyButton
		Private keyButtonDown As KeyButton
		Private keyButtonRight As KeyButton
		Private keyButtonRControl As KeyButton
		Private keyButtonUp As KeyButton
		Private keyButtonHome As KeyButton
		Private keyButtonPageUp As KeyButton
		Private keyButtonEnd As KeyButton
		Private keyButtonPageDown As KeyButton
		Private keyButtonInsert As KeyButton
		Private keyButtonPause As KeyButton
		Private keyButtonPrintScreen As KeyButton
		Private keyButtonScrollLock As KeyButton
		Private keyButtonNumberPad7 As KeyButton
		Private keyButtonNumberPad8 As KeyButton
		Private keyButtonNumberPad9 As KeyButton
		Private keyButtonDivide As KeyButton
		Private keyButtonNumberPad4 As KeyButton
		Private keyButtonNumberPad5 As KeyButton
		Private keyButtonNumberPad6 As KeyButton
		Private keyButtonMultiply As KeyButton
		Private keyButtonNumberPad1 As KeyButton
		Private keyButtonNumberPad2 As KeyButton
		Private keyButtonNumberPad3 As KeyButton
		Private keyButtonSubtract As KeyButton
		Private keyButtonNumberPad0 As KeyButton
		Private keyButtonDecimal As KeyButton
		Private keyButtonAdd As KeyButton
		Private keyButtonNumReturn As KeyButton
		Private keyButtonNumLock As KeyButton
		Private keyButtonF1 As KeyButton
		Private keyButtonF2 As KeyButton
		Private keyButtonF3 As KeyButton
		Private keyButtonF4 As KeyButton
		Private keyButtonF5 As KeyButton
		Private keyButtonF6 As KeyButton
		Private keyButtonF7 As KeyButton
		Private keyButtonF8 As KeyButton
		Private keyButtonF9 As KeyButton
		Private keyButtonF10 As KeyButton
		Private keyButtonF11 As KeyButton
		Private keyButtonF12 As KeyButton
		Private tableLayoutPanelKeyButtons As TableLayoutPanel
		Private fluentTheme1 As Telerik.WinControls.Themes.FluentTheme
	End Class
End Namespace