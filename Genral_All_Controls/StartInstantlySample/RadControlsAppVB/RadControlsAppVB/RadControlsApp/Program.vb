Imports System.Text
Imports System.Runtime.InteropServices

Friend Class Program
    Private Shared requiredString As String

    Friend NotInheritable Class NativeMethods
        <DllImport("user32.dll")> _
        Public Shared Function ShowWindowAsync(ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
        End Function

        <DllImport("user32.dll")> _
        Public Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As Boolean
        End Function

        <DllImport("user32.dll")> _
        Public Shared Function EnumWindows(ByVal lpEnumFunc As EnumWindowsProcDel, ByVal lParam As Int32) As Boolean
        End Function

        <DllImport("user32.dll")> _
        Public Shared Function GetWindowThreadProcessId(ByVal hWnd As IntPtr, ByRef lpdwProcessId As Int32) As Integer
        End Function

        <DllImport("user32.dll")> _
        Public Shared Function GetWindowText(ByVal hWnd As IntPtr, ByVal lpString As StringBuilder, ByVal nMaxCount As Int32) As Integer
        End Function

        Public Const SW_SHOWNORMAL As Integer = 1
    End Class

    Public Delegate Function EnumWindowsProcDel(ByVal hWnd As IntPtr, ByVal lParam As Int32) As Boolean

    Private Shared Function EnumWindowsProc(ByVal hWnd As IntPtr, ByVal lParam As Int32) As Boolean
        Dim processId As Integer = 0
        NativeMethods.GetWindowThreadProcessId(hWnd, processId)

        Dim caption As New StringBuilder(1024)
        NativeMethods.GetWindowText(hWnd, caption, 1024)

        ' Use IndexOf to make sure our required string is in the title.
        If processId = lParam AndAlso (caption.ToString().IndexOf(requiredString, StringComparison.OrdinalIgnoreCase) <> -1) Then
            ' Restore the window.
            NativeMethods.ShowWindowAsync(hWnd, NativeMethods.SW_SHOWNORMAL)
            NativeMethods.SetForegroundWindow(hWnd)
        End If
        Return True
    End Function

    Public Shared Function IsOnlyProcess(ByVal forceTitle As String) As Boolean
        requiredString = forceTitle
        For Each proc As Process In Process.GetProcessesByName(Application.ProductName)
            If proc.Id <> Process.GetCurrentProcess().Id Then
                NativeMethods.EnumWindows(New EnumWindowsProcDel(AddressOf EnumWindowsProc), proc.Id)
                Return False
            End If
        Next proc
        Return True
    End Function

    <STAThread()> _
    Shared Sub Main()
        If IsOnlyProcess("SingleInstanceDemo") Then
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainForm())
        End If
    End Sub
End Class

