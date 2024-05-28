Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports RadImageBindingPanelTest.Properties
Imports Telerik.WinControls
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.Themes.Design
Imports Telerik.WinControls.UI

Namespace RadImageBindingPanelTest
    <Description("Provides a data-bindable image control.")>
    <DefaultBindingProperty("Image"), DefaultEvent("ImageChanged"), DefaultProperty("Image")>
    Public Class RadImageBindingPanel
        Inherits RadPanel
#Region "Fields"

        Private btClear As Telerik.WinControls.UI.RadButton
        Private btPaste As Telerik.WinControls.UI.RadButton
        Private btOpenImage As Telerik.WinControls.UI.RadButton

#End Region

#Region "Public Properties"

        Public Property OpenDialogTitle() As String
            Get
                Return m_OpenDialogTitle
            End Get
            Set(ByVal value As String)
                m_OpenDialogTitle = value
            End Set
        End Property
        Private m_OpenDialogTitle As String

        Public Shadows ReadOnly Property ThemeClassName() As String
            Get
                Return "Telerik.WinControls.UI.RadPanel"
            End Get
        End Property

        Public Property ButtonSize() As Size
            Get
                Return btOpenImage.Size
            End Get
            Set(ByVal value As Size)
                btOpenImage.Size = value
                btClear.Size = value
                btPaste.Size = value
                DoResize()
            End Set
        End Property

        <Bindable(True), RefreshProperties(RefreshProperties.All), Description("Gets or sets the Image of the control."), Category("Behavior")>
        Public Property Image() As Image
            Get
                Return BackgroundImage
            End Get
            Set(ByVal value As Image)
                BackgroundImage = value
                OnImageChanged()
            End Set
        End Property

        Public Property [ReadOnly]() As Boolean
            Get
                Return Not btOpenImage.Visible
            End Get
            Set(ByVal value As Boolean)
                btOpenImage.Visible = Not value
                btClear.Visible = Not value
                btPaste.Visible = Not value
                DirectCast(Me.GetChildAt(0).GetChildAt(1), BorderPrimitive).ShouldPaint = Not value
                BackColor = If(value, Color.Transparent, SystemColors.ControlLightLight)
            End Set
        End Property

#End Region

#Region "Public Events"

        Public Event ImageChanged As EventHandler

        Private Sub OnImageChanged()
            ' Update Bindings
            For Each b As Binding In DataBindings
                If b.PropertyName = "Image" Then
                    b.WriteValue()
                End If
            Next

            ' Fire Event
            RaiseEvent ImageChanged(Me, EventArgs.Empty)

            Text = If((Image Is Nothing AndAlso Not [ReadOnly]), "Click the folder icon to open an image file or click on the clipboard to paste an image from the clipboard.", InlineAssignHelper(Text, String.Empty))
        End Sub

#End Region

#Region "Constructor, Initialize"

        Protected Overrides Sub CreateChildItems(ByVal parent As RadElement)
            MyBase.CreateChildItems(parent)

            btOpenImage = New RadButton()
            btOpenImage.Dock = DockStyle.Top
            btOpenImage.Image = My.Resources.btOpenImage_Image
            AddHandler btOpenImage.Click, AddressOf btOpenImage_Click
            AddHandler btOpenImage.ToolTipTextNeeded, AddressOf btOpenImage_ToolTipTextNeeded

            btClear = New RadButton()
            btClear.Dock = DockStyle.Top
            btClear.Image = My.Resources.btClear_Image
            AddHandler btClear.Click, AddressOf btClear_Click
            AddHandler btClear.ToolTipTextNeeded, AddressOf btClear_ToolTipTextNeeded

            btPaste = New RadButton()
            btPaste.Dock = DockStyle.Top
            btPaste.Image = My.Resources.btPaste_Image
            AddHandler btPaste.Click, AddressOf btPaste_Click

            Me.Controls.Add(btClear)
            Me.Controls.Add(btOpenImage)
            Me.Controls.Add(btPaste)
        End Sub

        Public Sub New()
            MyBase.New()
            DirectCast(Me.PanelElement.Children(1), BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(173, 195, 222)
            DirectCast(Me.PanelElement.GetChildAt(2), TextPrimitive).TextWrap = True

            HideButtonBackground(btClear)
            HideButtonBackground(btOpenImage)
            HideButtonBackground(btPaste)

            OpenDialogTitle = "Open Image"
            ButtonSize = New Size(20, 20)
            [ReadOnly] = False
            Text = String.Empty
            BackgroundImageLayout = ImageLayout.Zoom
        End Sub

#End Region

#Region "Button Event Handlers"

        Private Sub btOpenImage_Click(ByVal sender As Object, ByVal e As EventArgs)
            DoOpen()
        End Sub

        Private Sub btClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            Image = Nothing
        End Sub

        Private Sub RadImageBindingPanel_Resize(ByVal sender As Object, ByVal e As EventArgs)
            DoResize()
        End Sub

        Private Sub btPaste_Click(ByVal sender As Object, ByVal e As EventArgs)
            DoPaste()
        End Sub

        Private Sub btOpenImage_ToolTipTextNeeded(ByVal sender As Object, ByVal e As ToolTipTextNeededEventArgs)
            e.ToolTipText = "Open Image"
        End Sub

        Private Sub btClear_ToolTipTextNeeded(ByVal sender As Object, ByVal e As ToolTipTextNeededEventArgs)
            e.ToolTipText = "Clear Image"
        End Sub

#End Region

#Region "Private Methods"

        Private Sub DoOpen()
            Dim ofd As New OpenFileDialog()
            ofd.CheckFileExists = True
            ofd.Filter = "Image Files (*.*)|*.*"
            ofd.Multiselect = False
            ofd.Title = OpenDialogTitle
            If ofd.ShowDialog() <> DialogResult.OK Then
                Return
            End If
            Try
                Image = Image.FromFile(ofd.FileName)
            Catch generatedExceptionName As OutOfMemoryException
                ShowError("Invalid image format.")
            Catch generatedExceptionName As FileNotFoundException
                ShowError("The file specified does not exist.")
            Catch generatedExceptionName As ArgumentException
                ShowError("Remote image loading is not supported.")
            Catch
                ShowError("An unknown error occured opening the image.")
            End Try
        End Sub

        Private Sub DoResize()
            btOpenImage.Location = New Point(Width - 3 * btOpenImage.Width, Height - btOpenImage.Height)
            btPaste.Location = New Point(Width - 2 * btOpenImage.Width, Height - btOpenImage.Height)
            btClear.Location = New Point(Width - btOpenImage.Width, Height - btOpenImage.Height)
        End Sub

        Private Sub DoPaste()
            Dim obj As IDataObject = Clipboard.GetDataObject()
            If obj Is Nothing Then
                ShowError("The clipboard is empty.")
                Return
            End If
            If Not obj.GetDataPresent(DataFormats.Bitmap) Then
                ShowError("The clipboard does not contain a valid image.")
                Return
            End If
            Image = DirectCast(obj.GetData(DataFormats.Bitmap, True), Image)
        End Sub

        Private Function ShowError(ByVal message As String) As DialogResult
            Return RadMessageBox.Show(message, "Error", MessageBoxButtons.OK, RadMessageIcon.[Error])
        End Function

        Private Sub HideButtonBackground(ByVal button As RadButton)
            button.BackColor = Color.Transparent
            button.ButtonElement.ButtonFillElement.ShouldPaint = False
            button.ButtonElement.BorderElement.ShouldPaint = False
        End Sub
        Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
            target = value
            Return value
        End Function

#End Region
    End Class
End Namespace