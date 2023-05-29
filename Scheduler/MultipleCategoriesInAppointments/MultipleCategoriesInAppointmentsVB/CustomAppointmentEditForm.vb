Imports System.Drawing.Drawing2D
Imports MultipleCategoriesInAppointmentsVB.MainForm
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class CustomAppointmentEditForm
    Private categoriesLabel As RadLabel
    Private categoriesDropDown As RadCheckedDropDownList

    Public Sub New()
        InitializeComponent()
        Me.cmbBackground.Visible = False
        Me.labelBackground.Visible = False
        categoriesLabel = New RadLabel()
        categoriesLabel.ThemeName = Me.ThemeName
        categoriesLabel.Text = "Category"
        categoriesLabel.Location = labelBackground.Location
        Me.Controls.Add(categoriesLabel)
        categoriesDropDown = New RadCheckedDropDownList()
        AddHandler categoriesDropDown.TextBlockFormatting, AddressOf CategoriesDropDown_TextBlockFormatting
        AddHandler categoriesDropDown.VisualListItemFormatting, AddressOf CategoriesDropDown_VisualListItemFormatting
        categoriesDropDown.ThemeName = Me.ThemeName
        categoriesDropDown.Location = Me.cmbBackground.Location
        categoriesDropDown.Width = Me.cmbBackground.Width
        categoriesDropDown.DropDownSizingMode = SizingMode.UpDownAndRightBottom
        Me.Controls.Add(categoriesDropDown)
        Me.cmbShowTimeAs.Width -= Me.cmbShowTimeAs.Width / 2
        Me.cmbShowTimeAs.Left += Me.cmbShowTimeAs.Width
        Me.labelStatus.Left += Me.cmbShowTimeAs.Width
        categoriesDropDown.Width += Me.cmbShowTimeAs.Width
    End Sub

    Protected Overrides Sub OnFormClosed(ByVal e As FormClosedEventArgs)
        MyBase.OnFormClosed(e)
        Dim scheduler As RadScheduler = TryCast(Me.SchedulerData, RadScheduler)
        scheduler.SchedulerElement.RefreshViewElement()
    End Sub

    Protected Overrides Sub LoadSettingsFromEvent(ByVal sourceEvent As IEvent)
        MyBase.LoadSettingsFromEvent(sourceEvent)
        Dim categorizedAppointment As AppointmentWithCategories = TryCast(sourceEvent, AppointmentWithCategories)

        If categorizedAppointment.CategoryIds.Count > 0 Then

            For Each categoryItem As RadCheckedListDataItem In Me.categoriesDropDown.Items

                If categorizedAppointment.CategoryIds.Contains(CInt(categoryItem.Value)) Then
                    categoryItem.Checked = True
                End If
            Next
        End If
    End Sub

    Protected Overrides Sub ApplySettingsToEvent(ByVal targetEvent As IEvent)
        MyBase.ApplySettingsToEvent(targetEvent)
        Dim categorizedAppointment As AppointmentWithCategories = TryCast(targetEvent, AppointmentWithCategories)
        categorizedAppointment.CategoryIds.Clear()

        For Each categoryItem As RadCheckedListDataItem In Me.categoriesDropDown.CheckedItems
            categorizedAppointment.CategoryIds.Add(CInt(categoryItem.Value))
        Next
    End Sub

    Protected Overrides Function CreateNewEvent() As IEvent
        Return New AppointmentWithCategories()
    End Function

    Protected Overrides Sub LoadBackgrounds()
        MyBase.LoadBackgrounds()
        Me.categoriesDropDown.DataSource = Me.SchedulerData.GetBackgroundStorage()
        Me.categoriesDropDown.DisplayMember = "DisplayName"
        Me.categoriesDropDown.ValueMember = "Id"
    End Sub

    Private Sub CategoriesDropDown_VisualListItemFormatting(ByVal sender As Object, ByVal args As VisualItemFormattingEventArgs)
        Dim visualItem As RadCheckedListVisualItem = TryCast(args.VisualItem, RadCheckedListVisualItem)
        Dim checkBox As RadCheckBoxElement = TryCast(visualItem.CheckBox, RadCheckBoxElement)
        checkBox.CheckMarkPrimitive.Border.Visibility = ElementVisibility.Hidden
        checkBox.CheckMarkPrimitive.Fill.GradientStyle = GradientStyles.Solid
        checkBox.CheckMarkPrimitive.Fill.BackColor = GetBackgroundById(CInt((args.VisualItem.Data.Value)))
        checkBox.CheckMarkPrimitive.ForeColor = GetForeColor(checkBox.CheckMarkPrimitive.Fill.BackColor)
    End Sub

    Private Sub CategoriesDropDown_TextBlockFormatting(ByVal sender As Object, ByVal e As TextBlockFormattingEventArgs)
        Dim token As TokenizedTextBlockElement = TryCast(e.TextBlock, TokenizedTextBlockElement)

        If token IsNot Nothing Then
            token.DrawFill = True
            token.GradientStyle = GradientStyles.Solid
            token.BackColor = GetBackgroundById(CInt((CType(token.Item.Value, RadCheckedListDataItem)).Value))
            token.ForeColor = GetForeColor(token.BackColor)
        End If
    End Sub

    Public Overridable Function GetForeColor(ByVal backColor As Color) As Color
        Dim textColor As Color
        Dim brightness As Double = (0.299 * backColor.R + 0.587 * backColor.G + 0.114 * backColor.B) / 255

        If brightness > 0.5 Then
            textColor = Color.Black
        Else
            textColor = Color.White
        End If

        Return textColor
    End Function

    Private Function GetBackgroundById(ByVal categoryId As Integer) As Color
        Dim scheduler As RadScheduler = TryCast(Me.SchedulerData, RadScheduler)

        For Each bc As AppointmentBackgroundInfo In scheduler.Backgrounds

            If bc.Id = categoryId Then

                If scheduler.UseModernAppointmentStyles Then
                    Return bc.BackColor
                End If

                Return bc.BackColor2
            End If
        Next

        Return Color.Red
    End Function

    Private Function CreateImageByBackgroundInfo(ByVal backgroundInfo As IAppointmentBackgroundInfo) As Image
        Dim defaultImageSize As Size = New Size(11, 11)
        Dim image As Bitmap = New Bitmap(defaultImageSize.Width, defaultImageSize.Height)
        Dim graphics As Graphics = Graphics.FromImage(image)
        Dim rect As Rectangle = New Rectangle(Point.Empty, defaultImageSize)
        rect.Inflate(-1, -1)

        Using path As GraphicsPath = (New RoundRectShape(1)).CreatePath(rect)

            If backgroundInfo.BackColor2 <> Color.Empty Then

                Using gradientBrush As LinearGradientBrush = New LinearGradientBrush(rect, backgroundInfo.BackColor, backgroundInfo.BackColor2, backgroundInfo.GradientAngle)
                    graphics.FillPath(gradientBrush, path)
                End Using
            Else

                Using solidBrush As SolidBrush = New SolidBrush(backgroundInfo.BackColor)
                    graphics.FillPath(solidBrush, path)
                End Using
            End If

            Using pen As Pen = New Pen(backgroundInfo.BorderColor)
                graphics.DrawPath(pen, path)
            End Using
        End Using

        Return image
    End Function
End Class
