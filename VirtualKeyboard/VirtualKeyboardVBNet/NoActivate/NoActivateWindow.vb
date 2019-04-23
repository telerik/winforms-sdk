'''**************************** Module Header ******************************\
''' * Module Name:  NoActivateWindow.cs
''' * Project:      CSSoftKeyboard
''' * Copyright (c) Microsoft Corporation.
''' * 
''' * The class represents a form that will not be activated until the user
''' * presses the left mouse button within its nonclient area(such as the title
''' * bar, menu bar, or window frame). When the left mouse button is released,
''' * this window will activate the previous foreground Window.
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

Imports System.Security.Permissions
Imports Telerik.WinControls.UI

Namespace CSSoftKeyboard.NoActivate
	Public Class NoActivateWindow
        Inherits RadForm

        Const WS_EX_NOACTIVATE As Long = &H8000000L
        Const WM_NCMOUSEMOVE As Integer = &HA0
        Const WM_NCLBUTTONDOWN As Integer = &HA1
        Private previousForegroundWindow As IntPtr = IntPtr.Zero

        Protected Overrides ReadOnly Property CreateParams As CreateParams
            <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")>
            Get
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ExStyle = cp.ExStyle Or CInt(WS_EX_NOACTIVATE)
                Return cp
            End Get
        End Property

        <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")>
        Protected Overrides Sub WndProc(ByRef m As Message)
            Select Case m.Msg
                Case WM_NCLBUTTONDOWN
                    Dim foregroundWindow = UnsafeNativeMethods.GetForegroundWindow()

                    If foregroundWindow <> Me.Handle Then
                        UnsafeNativeMethods.SetForegroundWindow(Me.Handle)

                        If foregroundWindow <> IntPtr.Zero Then
                            previousForegroundWindow = foregroundWindow
                        End If
                    End If

                Case WM_NCMOUSEMOVE

                    If UnsafeNativeMethods.IsWindow(previousForegroundWindow) Then
                        UnsafeNativeMethods.SetForegroundWindow(previousForegroundWindow)
                        previousForegroundWindow = IntPtr.Zero
                    End If

                Case Else
            End Select

            MyBase.WndProc(m)
        End Sub
    End Class

End Namespace
