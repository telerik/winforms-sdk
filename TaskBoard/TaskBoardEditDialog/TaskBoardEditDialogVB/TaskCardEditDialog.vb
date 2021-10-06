Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports Telerik.WinControls.UI.TaskBoard
Imports System.ComponentModel

Public Class TaskCardEditDialog
    Private taskCardToEdit As RadTaskCardElement
    Private taskBoard As RadTaskBoard
    Private imageSize As Size = New Size(16, 16)
    Private teams As BindingList(Of String) = New BindingList(Of String)() From {
        "WinForms",
        "WPF",
        "Reporting",
        "Blazor",
        "DocumentProcessing"
    }

    Private Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Edit Card"
    End Sub

    Public Sub New(ByVal defaultTaskCard As RadTaskCardElement, ByVal taskBoardControl As RadTaskBoard)
        Me.New()
        Me.taskCardToEdit = defaultTaskCard
        Me.taskBoard = taskBoardControl
        Me.usersCheckedDropDownList.DataSource = Me.taskBoard.Users
        Me.usersCheckedDropDownList.ValueMember = "Initials"
        Me.usersCheckedDropDownList.CheckedDropDownListElement.ItemHeight = 26
        AddHandler Me.usersCheckedDropDownList.CheckedDropDownListElement.AutoCompleteEditableAreaElement.AutoCompleteTextBox.CreateTextBlock, AddressOf AutoCompleteTextBox_CreateTextBlock
        AddHandler Me.usersCheckedDropDownList.CheckedDropDownListElement.AutoCompleteEditableAreaElement.AutoCompleteTextBox.TextBlockFormatting, AddressOf AutoCompleteTextBox_TextBlockFormatting
        AddHandler Me.usersCheckedDropDownList.VisualListItemFormatting, AddressOf usersCheckedDropDownList_VisualListItemFormatting
        Me.tagsAutoCompleteBox.AutoCompleteDataSource = teams
        LoadSettings(Me.taskCardToEdit)
    End Sub

    Private Sub LoadSettings(ByVal taskCard As RadTaskCardElement)
        Me.titleTextBox.Text = taskCard.TitleText
        Me.descriptionTextBox.Text = taskCard.DescriptionText

        For Each user As UserInfo In taskCard.Users
            Dim item As RadCheckedListDataItem = TryCast(Me.usersCheckedDropDownList.Items.FirstOrDefault(Function(x) x.Value.Equals(user.Initials)), RadCheckedListDataItem)
            item.Checked = True
        Next

        For Each tag As RadTaskCardTagElement In taskCard.TagElements
            Me.tagsAutoCompleteBox.Text += tag.Text & ";"
        Next
    End Sub

    Private Sub AutoCompleteTextBox_TextBlockFormatting(ByVal sender As Object, ByVal e As TextBlockFormattingEventArgs)
        Dim imageToken As ImageTokenizedTextBlockElement = TryCast(e.TextBlock, ImageTokenizedTextBlockElement)

        If imageToken IsNot Nothing Then
            Dim dataItem As RadCheckedListDataItem = TryCast(imageToken.Item.Value, RadCheckedListDataItem)

            If dataItem IsNot Nothing Then
                Dim user As UserInfo = TryCast(dataItem.DataBoundItem, UserInfo)

                If user IsNot Nothing Then
                    imageToken.Image.Image = ResizeImage(user.Avatar, imageSize)
                End If
            End If
        End If
    End Sub

    Private Sub AutoCompleteTextBox_CreateTextBlock(ByVal sender As Object, ByVal e As CreateTextBlockEventArgs)
        If TypeOf e.TextBlock Is TokenizedTextBlockElement Then
            e.TextBlock = New ImageTokenizedTextBlockElement()
        End If
    End Sub

    Private Sub usersCheckedDropDownList_VisualListItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
        Dim user As UserInfo = TryCast(args.VisualItem.Data.DataBoundItem, UserInfo)

        If user IsNot Nothing Then
            Dim visualItem As RadCheckedListVisualItem = TryCast(args.VisualItem, RadCheckedListVisualItem)
            visualItem.CheckBox.Text = user.FirstName & " " + user.LastName
            visualItem.CheckBox.Image = user.Avatar
            visualItem.CheckBox.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub radButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radButtonOK.Click
        Me.taskCardToEdit.TitleText = Me.titleTextBox.Text
        Me.taskCardToEdit.DescriptionText = Me.descriptionTextBox.Text
        Me.taskCardToEdit.Users.Clear()

        For Each checkedUser As RadCheckedListDataItem In Me.usersCheckedDropDownList.CheckedItems
            Me.taskCardToEdit.Users.Add(TryCast(checkedUser.DataBoundItem, UserInfo))
        Next

        Me.taskCardToEdit.TagElements.Clear()

        For Each token As RadTokenizedTextItem In Me.tagsAutoCompleteBox.Items
            Dim tag As RadTaskCardTagElement = New RadTaskCardTagElement()
            tag.Text = token.Text
            Me.taskCardToEdit.TagElements.Add(tag)
        Next
    End Sub

    Public Class ImageTokenizedTextBlockElement
        Inherits TokenizedTextBlockElement

        Private _image As ImagePrimitive

        Public ReadOnly Property Image As ImagePrimitive
            Get
                Return Me._image
            End Get
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            Me._image = New ImagePrimitive()
            Me._image.ImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me._image.StretchVertically = False
            Me._image.StretchHorizontally = False
            Me._image.MaxSize = New Size(0, 20)
            Me.Children.Insert(0, Me._image)
        End Sub

        Protected Overrides Function CreateTokenizedTextItem(ByVal text As String, ByVal value As Object) As RadTokenizedTextItem
            Dim item As RadTokenizedTextItem = MyBase.CreateTokenizedTextItem(text, value)
            Return item
        End Function

        Protected Overrides ReadOnly Property ThemeEffectiveType As Type
            Get
                Return GetType(TokenizedTextBlockElement)
            End Get
        End Property
    End Class

    Public Shared Function ResizeImage(ByVal image As Image, ByVal s As Size) As Bitmap
        Dim width As Integer = s.Width
        Dim height As Integer = s.Height
        Dim destRect = New Rectangle(0, 0, width, height)
        Dim destImage = New Bitmap(width, height)
        destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution)

        Using graphics = System.Drawing.Graphics.FromImage(destImage)
            graphics.CompositingMode = CompositingMode.SourceCopy
            graphics.CompositingQuality = CompositingQuality.HighQuality
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphics.SmoothingMode = SmoothingMode.HighQuality
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

            Using wrapMode = New ImageAttributes()
                wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY)
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode)
            End Using
        End Using

        Return destImage
    End Function
End Class
