Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Net
Imports System.Threading
Imports System.Windows.Forms
Imports Telerik.WinControls.UI

Namespace RadGridViewExample
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			Dim table As DataTable = New DataTable()
			table.Columns.Add("Images")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Ferrari%20Enzo.png")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Jaguar%20XJ220.png")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Koenigsegg%20CCX.png")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Lamborghini%20Murcielago%20LP640.png")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/McLaren%20F1.png")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Pagani%20Zonda F.png")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Porsche%20Carrera GT.png")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/Saleen%20S7%20Twin-Turbo.png")
            table.Rows.Add("http://www.telerik.com/Images/editor/winforms/Knowledge%20Base/GridView/Grid-loading-images-asynchronously/SSC%20Ultimate Aero.png")

			AddHandler radGridView1.CreateCell, AddressOf radGridView1_CreateCell
			Me.radGridView1.AllowAddNewRow = False
			Me.radGridView1.DataSource = table
			Me.radGridView1.Columns(0).Width = 160
			Me.radGridView1.TableElement.RowHeight = 100
		End Sub

		Private Sub radGridView1_CreateCell(ByVal sender As Object, ByVal e As GridViewCreateCellEventArgs)
			If e.CellType Is GetType(GridDataCellElement) Then
				e.CellElement = New CustomCellElement(e.Column, e.Row)
			End If
		End Sub
	End Class

	Public Class CustomCellElement
		Inherits GridDataCellElement
		Public Sub New(ByVal column As GridViewColumn, ByVal row As GridRowElement)
			MyBase.New(column, row)
			Me.ImageLayout = ImageLayout.Stretch
		End Sub

		Public Overrides Sub SetContent()
			MyBase.SetContent()

			Me.Image = Nothing
			Me.Text = "Loading image..."

			Dim cache As ImageInfo = TryCast(Me.RowInfo.Tag, ImageInfo)

			If Not cache Is Nothing AndAlso cache.Url Is Me.Value.ToString() Then
				 If Not cache.Image Is Nothing Then
					Me.Image = cache.Image
					Me.Text = cache.Url
				 End If
			Else
				Me.RowInfo.Tag = New ImageInfo(Me.RowInfo.Cells(Me.ColumnInfo.Name).Value.ToString(), Nothing)
				ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf LoadImage), Me.RowInfo)
			End If
		End Sub

		Private Sub LoadImage(ByVal state As Object)
			Dim rowInfo As GridViewRowInfo = CType(state, GridViewRowInfo)
			Dim info As ImageInfo = CType(rowInfo.Tag, ImageInfo)

			Dim url As String = info.Url
			Dim request As HttpWebRequest = CType(System.Net.HttpWebRequest.Create(url), HttpWebRequest)
			Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
			Dim image As Image = Me.Image.FromStream(response.GetResponseStream())
			response.Close()

			info.Image = image
			rowInfo.InvalidateRow()

		End Sub

		Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
			Get
				Return GetType(GridDataCellElement)
			End Get
		End Property
	End Class

	Public Class ImageInfo
		Private url_Renamed As String
		Private image_Renamed As Image

		Public Sub New(ByVal url_Renamed As String, ByVal image_Renamed As Image)
			Me.url_Renamed = url_Renamed
			Me.image_Renamed = image_Renamed
		End Sub

		Public Property Url() As String
			Get
				Return Me.url_Renamed
			End Get
			Set
				Me.url_Renamed = Value
			End Set
		End Property

		Public Property Image() As Image
			Get
				Return Me.image_Renamed
			End Get
			Set
				Me.image_Renamed = Value
			End Set
		End Property
	End Class
End Namespace
