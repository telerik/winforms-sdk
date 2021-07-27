Imports System.ComponentModel
Imports System.Text
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class RadForm1
    Public Sub New()
        InitializeComponent()
        Dim segments As SegmentsCollection = New SegmentsCollection()

        For i As Integer = 0 To 5 - 1
            segments.Add(New Segment(New Start(i, i + 1, i + 2), New [End](i, i * i, i * i + i, i + 3, i + 4, i + 5)))
        Next

        Me.RadPropertyGrid1.SelectedObject = New Item(5, segments, 145229)
        AddHandler Me.RadPropertyGrid1.Edited, AddressOf RadPropertyGrid1_Edited
        AddHandler Me.RadPropertyGrid1.Editing, AddressOf RadPropertyGrid1_Editing
        AddHandler Me.RadPropertyGrid1.EditorInitialized, AddressOf RadPropertyGrid1_EditorInitialized
    End Sub

    Private Sub RadPropertyGrid1_EditorInitialized(ByVal sender As Object, ByVal e As PropertyGridItemEditorInitializedEventArgs)
        Dim editor As PropertyGridUITypeEditor = TryCast(e.Editor, PropertyGridUITypeEditor)

        If editor IsNot Nothing Then
            Dim el As PropertyGridUITypeEditorElement = TryCast(editor.EditorElement, PropertyGridUITypeEditorElement)
            el.Button.Visibility = ElementVisibility.Collapsed
        End If
    End Sub

    Private Sub RadPropertyGrid1_Editing(ByVal sender As Object, ByVal e As PropertyGridItemEditingEventArgs)
        If e.Item.Label = "Segments" Then
            e.Cancel = True
        End If
    End Sub

    Private t As Timer = Nothing

    Private Sub RadPropertyGrid1_Edited(ByVal sender As Object, ByVal e As PropertyGridItemEditedEventArgs)
        If e.Item.Label = "Count" Then
            Dim item As Item = TryCast(Me.RadPropertyGrid1.SelectedObject, Item)

            If item.Segments.Count < item.Count Then
                item.Segments.Add(New Segment(New Start(0, 0, 0), New [End](0, 0, 0, 0, 0, 0)))
            End If

            t = New Timer()
            t.Interval = 500
            AddHandler t.Tick, AddressOf T_Tick
            t.Start()
        End If
    End Sub

    Private Sub T_Tick(ByVal sender As Object, ByVal e As EventArgs)
        t.[Stop]()
        Dim item As Item = TryCast(Me.RadPropertyGrid1.SelectedObject, Item)
        Me.RadPropertyGrid1.SelectedObject = Nothing
        Me.RadPropertyGrid1.SelectedObject = item
    End Sub

    Public Class SegmentsCollection
        Inherits System.Collections.CollectionBase
        Implements ICustomTypeDescriptor

        Public Overrides Function ToString() As String
            Return "Count " & Me.Count
        End Function

        Public Sub Add(ByVal s As Segment)
            Me.List.Add(s)
        End Sub

        Public Sub Remove(ByVal s As Segment)
            Me.List.Remove(s)
        End Sub

        Default Public ReadOnly Property Item(ByVal index As Integer) As Segment
            Get
                Return CType(Me.List(index), Segment)
            End Get
        End Property

        Public Function GetClassName() As String Implements ICustomTypeDescriptor.GetClassName
            Return TypeDescriptor.GetClassName(Me, True)
        End Function

        Public Function GetAttributes() As AttributeCollection Implements ICustomTypeDescriptor.GetAttributes
            Return TypeDescriptor.GetAttributes(Me, True)
        End Function

        Public Function GetComponentName() As String Implements ICustomTypeDescriptor.GetComponentName
            Return TypeDescriptor.GetComponentName(Me, True)
        End Function

        Public Function GetConverter() As TypeConverter Implements ICustomTypeDescriptor.GetConverter
            Return TypeDescriptor.GetConverter(Me, True)
        End Function

        Public Function GetDefaultEvent() As EventDescriptor Implements ICustomTypeDescriptor.GetDefaultEvent
            Return TypeDescriptor.GetDefaultEvent(Me, True)
        End Function

        Public Function GetDefaultProperty() As PropertyDescriptor Implements ICustomTypeDescriptor.GetDefaultProperty
            Return TypeDescriptor.GetDefaultProperty(Me, True)
        End Function

        Public Function GetEditor(ByVal editorBaseType As Type) As Object Implements ICustomTypeDescriptor.GetEditor
            Return TypeDescriptor.GetEditor(Me, editorBaseType, True)
        End Function

        Public Function GetEvents(ByVal attributes As Attribute()) As EventDescriptorCollection Implements ICustomTypeDescriptor.GetEvents
            Return TypeDescriptor.GetEvents(Me, attributes, True)
        End Function

        Public Function GetEvents() As EventDescriptorCollection Implements ICustomTypeDescriptor.GetEvents
            Return TypeDescriptor.GetEvents(Me, True)
        End Function

        Public Function GetPropertyOwner(ByVal pd As PropertyDescriptor) As Object Implements ICustomTypeDescriptor.GetPropertyOwner
            Return Me
        End Function

        Public Function GetProperties(ByVal attributes As Attribute()) As PropertyDescriptorCollection Implements ICustomTypeDescriptor.GetProperties
            Return GetProperties()
        End Function

        Private pds As PropertyDescriptorCollection

        Public Function GetProperties() As PropertyDescriptorCollection Implements ICustomTypeDescriptor.GetProperties
            pds = New PropertyDescriptorCollection(Nothing)

            For i As Integer = 0 To Me.List.Count - 1
                Dim pd As SegmentsCollectionPropertyDescriptor = New SegmentsCollectionPropertyDescriptor(Me, i)
                pds.Add(pd)
            Next

            Return pds
        End Function

    End Class

    Public Class SegmentsCollectionPropertyDescriptor
        Inherits PropertyDescriptor

        Private collection As SegmentsCollection = Nothing
        Private index As Integer = -1

        Public Sub New(ByVal coll As SegmentsCollection, ByVal idx As Integer)
            MyBase.New("#" & idx.ToString(), Nothing)
            Me.collection = coll
            Me.index = idx
        End Sub

        Public Overrides ReadOnly Property Attributes As AttributeCollection
            Get
                Return New AttributeCollection(Nothing)
            End Get
        End Property

        Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
            Return True
        End Function

        Public Overrides ReadOnly Property ComponentType As Type
            Get
                Return Me.collection.[GetType]()
            End Get
        End Property

        Public Overrides ReadOnly Property DisplayName As String
            Get
                Dim s As Segment = Me.collection(index)
                Return s.Start.ToString() & " " & s.[End].ToString()
            End Get
        End Property

        Public Overrides ReadOnly Property Description As String
            Get
                Dim s As Segment = Me.collection(index)
                Dim sb As StringBuilder = New StringBuilder()
                sb.Append("Start: ")
                sb.Append(s.Start.X)
                sb.Append(",")
                sb.Append(s.Start.Y)
                sb.Append(",")
                sb.Append(s.Start.Y)
                sb.Append(" End: ")
                sb.Append(s.[End].Direction)
                sb.Append(" direction ")
                sb.Append(s.[End].ElevationAngle)
                Return sb.ToString()
            End Get
        End Property

        Public Overrides Function GetValue(ByVal component As Object) As Object
            Return Me.collection(index)
        End Function

        Public Overrides ReadOnly Property IsReadOnly As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property Name As String
            Get
                Return "#" & index.ToString()
            End Get
        End Property

        Public Overrides ReadOnly Property PropertyType As Type
            Get
                Return Me.collection(index).[GetType]()
            End Get
        End Property

        Public Overrides Sub ResetValue(ByVal component As Object)
        End Sub

        Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
            Return True
        End Function

        Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
        End Sub
    End Class

    Public Class Item
        Public Property Count As Integer
        <TypeConverter(GetType(ExpandableObjectConverter))>
        Public Property Segments As SegmentsCollection
        Public Property TotalLength As Integer

        Public Sub New(ByVal count As Integer, ByVal segments As SegmentsCollection, ByVal totalLength As Integer)
            Me.Count = count
            Me.Segments = segments
            Me.TotalLength = totalLength
        End Sub
    End Class

    <TypeConverter(GetType(ExpandableObjectConverter))>
    Public Class Segment
        Public Property Start As Start
        Public Property [End] As [End]

        Public Sub New(ByVal start As Start, ByVal [end] As [End])
            Me.Start = start
            Me.[End] = [end]
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Start.ToString() & " " & Me.[End].ToString()
        End Function
    End Class

    <TypeConverter(GetType(ExpandableObjectConverter))>
    Public Class Start
        Public Property X As Integer
        Public Property Y As Integer
        Public Property Z As Integer

        Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
            Me.X = x
            Me.Y = y
            Me.Z = z
        End Sub

        Public Overrides Function ToString() As String
            Return "Segment Start: " & Me.X & ", " & Me.Y & ", " & Me.Z
        End Function
    End Class

    <TypeConverter(GetType(ExpandableObjectConverter))>
    Public Class [End]
        Public Property Length As Integer
        Public Property Direction As Integer
        Public Property ElevationAngle As Integer
        Public Property DeltaX As Integer
        Public Property DeltaY As Integer
        Public Property DeltaZ As Integer

        Public Sub New(ByVal length As Integer, ByVal direction As Integer, ByVal elevationAngle As Integer, ByVal deltaX As Integer, ByVal deltaY As Integer, ByVal deltaZ As Integer)
            Me.Length = length
            Me.Direction = direction
            Me.ElevationAngle = elevationAngle
            Me.DeltaX = deltaX
            Me.DeltaY = deltaY
            Me.DeltaZ = deltaZ
        End Sub

        Public Overrides Function ToString() As String
            Return "Segment End: d " & Me.Direction & " a " & Me.ElevationAngle
        End Function
    End Class

    Public Class SegmentsTypeConverter
        Inherits ExpandableObjectConverter

        Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
            If sourceType = GetType(String) Then
                Return True
            End If

            Return MyBase.CanConvertFrom(context, sourceType)
        End Function

        Public Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
            If destinationType = GetType(String) Then
                Return True
            End If

            Return MyBase.CanConvertTo(context, destinationType)
        End Function

        Public Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
            If destinationType <> GetType(String) Then
                Return MyBase.ConvertTo(context, culture, value, destinationType)
            End If

            Dim segments As List(Of Segment) = TryCast(value, List(Of Segment))

            If segments Is Nothing Then
                Return String.Empty
            End If

            Return String.Format("Number of segments: {0}", segments.Count)
        End Function

        Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
            Dim stringValue As String = TryCast(value, String)

            If True Then
                Return MyBase.ConvertFrom(context, culture, value)
            End If
        End Function
    End Class
End Class
