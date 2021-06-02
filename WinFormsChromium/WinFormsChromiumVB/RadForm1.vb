Imports CefSharp
Imports CefSharp.WinForms
Imports Telerik.WinControls

Public Class RadForm1
    Public browser As ChromiumWebBrowser

    Sub New()

        InitializeComponent()
        InitBrowser()
    End Sub
    Public Sub InitBrowser()
        CefSharp.Cef.Initialize(New CefSettings())
        browser = New ChromiumWebBrowser("www.google.com")
        Me.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
        AddHandler browser.LoadingStateChanged, AddressOf browser_LoadingStateChanged
    End Sub

    Private Sub browser_LoadingStateChanged(ByVal sender As Object, ByVal e As LoadingStateChangedEventArgs)
        If e.IsLoading = False Then
            browser.ExecuteScriptAsync("alert('All Resources Have Loaded');")
        End If
    End Sub

End Class
