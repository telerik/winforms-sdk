Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Primitives
Imports System.IO

Public Class RadForm1
    Sub New()

        InitializeComponent()
        Me.RadTreeView1.MultiSelect = True
        Me.RadTreeView1.TreeViewElement.ShowLines = True
        Me.RadTreeView1.TreeViewElement.AutoSizeItems = True
        Me.RadTreeView1.AllowArbitraryItemHeight = True
        AddHandler Me.RadTreeView1.CreateNodeElement, AddressOf radTreeView1_CreateNodeElement

    End Sub
    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductsTableAdapter.Fill(Me.NwindDataSet.Products)
        Me.CategoriesTableAdapter.Fill(Me.NwindDataSet.Categories)
        Me.RadTreeView1.DataSource = Me.CategoriesBindingSource
        Me.RadTreeView1.DisplayMember = "CategoryName"
        Me.RadTreeView1.ValueMember = "CategoryID"
        Me.RadTreeView1.RelationBindings.Add(New RelationBinding(Me.ProductsBindingSource, "ProductName", "CategoryID", "CategoryID", "ProductID"))
        Me.RadTreeView1.ExpandAll()
    End Sub

    Private Sub radTreeView1_CreateNodeElement(ByVal sender As Object, ByVal e As CreateTreeNodeElementEventArgs)
        If e.Node.Level = 1 Then
            e.NodeElement = New ProductTreeNodeElement()
        ElseIf e.Node.Level = 0 Then
            e.NodeElement = New CategoryTreeNodeElement()
        End If
    End Sub

    Public Class ProductTreeNodeContentElement
    Inherits TreeNodeContentElement

        Private container As StackLayoutElement
        Private infoElement As LightVisualElement
        Private unitElement As LightVisualElement
        Private linePrimitive As LinePrimitive

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            container = New StackLayoutElement()
            container.StretchVertically = True
            container.StretchHorizontally = True
            container.Orientation = Orientation.Vertical
            infoElement = New LightVisualElement()
            infoElement.StretchVertically = False
            infoElement.MaxSize = New System.Drawing.Size(0, 30)
            container.Children.Add(infoElement)
            linePrimitive = New LinePrimitive()
            container.Children.Add(linePrimitive)
            unitElement = New LightVisualElement()
            container.Children.Add(unitElement)
            Me.Children.Add(container)
        End Sub

        Public Overrides Sub Synchronize()
            Me.DrawText = False
            Dim rowView As DataRowView = TryCast(Me.NodeElement.Data.DataBoundItem, DataRowView)

            If rowView IsNot Nothing AndAlso Me.NodeElement.Data.Level = 1 Then
                infoElement.Text = rowView.Row("ProductID").ToString() & "." + rowView.Row("ProductName").ToString()

                Using ms = New MemoryStream(TryCast(rowView.Row("Picture"), Byte()))
                    infoElement.Image = Image.FromStream(ms)
                End Using

                infoElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
                infoElement.ImageLayout = System.Windows.Forms.ImageLayout.Zoom
                unitElement.Text = rowView.Row("QuantityPerUnit").ToString()
                linePrimitive.BackColor = Color.Black
                linePrimitive.Margin = New Padding(10, 0, 10, 0)
                linePrimitive.StretchVertically = False
                container.DrawBorder = True
                container.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
            End If
        End Sub
    End Class

    Public Class ProductTreeNodeElement
    Inherits TreeNodeElement

        Protected Overrides Function CreateContentElement() As TreeNodeContentElement
            Return New ProductTreeNodeContentElement()
        End Function

        Public Overrides Function IsCompatible(ByVal data As RadTreeNode, ByVal context As Object) As Boolean
            Return data.Level = 1
        End Function

        Protected Overrides ReadOnly Property ThemeEffectiveType As Type
            Get
                Return GetType(TreeNodeElement)
            End Get
        End Property
    End Class

    Public Class CategoryTreeNodeContentElement
    Inherits TreeNodeContentElement

        Private container As StackLayoutElement
        Private descriptionElement As LightVisualElement
        Private linePrimitive As LinePrimitive
        Private selectButton As RadButtonElement

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()
            container = New StackLayoutElement()
            container.Orientation = Orientation.Vertical
            container.StretchVertically = True
            descriptionElement = New LightVisualElement()
            descriptionElement.StretchVertically = False
            container.Children.Add(descriptionElement)
            linePrimitive = New LinePrimitive()
            container.Children.Add(linePrimitive)
            selectButton = New RadButtonElement()
            container.Children.Add(selectButton)
            Me.Children.Add(container)
            selectButton.Text = "Select all child nodes"
            AddHandler selectButton.Click, AddressOf selectButton_Click
        End Sub

        Private Sub selectButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            For Each node As RadTreeNode In Me.NodeElement.Data.Nodes
                node.Selected = True
            Next
        End Sub

        Public Overrides Sub Synchronize()
            MyBase.Synchronize()
            Me.DrawText = False
            Dim rowView As DataRowView = TryCast(Me.NodeElement.Data.DataBoundItem, DataRowView)

            If rowView IsNot Nothing AndAlso Me.NodeElement.Data.Level = 0 Then
                descriptionElement.Text = rowView.Row("CategoryID").ToString() & "." + rowView.Row("CategoryName").ToString()
                linePrimitive.BackColor = Color.Black
                linePrimitive.Margin = New Padding(0, 0, 0, 10)
                linePrimitive.StretchVertically = False
            End If
        End Sub
    End Class

    Public Class CategoryTreeNodeElement
    Inherits TreeNodeElement

        Protected Overrides Function CreateContentElement() As TreeNodeContentElement
            Return New CategoryTreeNodeContentElement()
        End Function

        Public Overrides Function IsCompatible(ByVal data As RadTreeNode, ByVal context As Object) As Boolean
            Return data.Level = 0
        End Function

        Protected Overrides ReadOnly Property ThemeEffectiveType As Type
            Get
                Return GetType(TreeNodeElement)
            End Get
        End Property
    End Class
End Class


