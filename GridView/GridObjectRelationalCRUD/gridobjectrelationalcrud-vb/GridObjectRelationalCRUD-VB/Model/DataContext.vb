Imports System.IO
Imports System.Collections.Generic
Imports System.Xml.Serialization

Public Class DataContext
    Private Shared artistsField As List(Of Artist) = Nothing
    Private Shared topArtistsField As List(Of Artist) = Nothing

    Protected Sub New()
    End Sub

    Public Shared ReadOnly Property Artists() As List(Of Artist)
        Get
            If artistsField Is Nothing Then
                Dim mySerializer As New XmlSerializer(GetType(List(Of Artist)))
                Dim myFileStream As New FileStream("..\..\artists.xml", FileMode.Open)
                artistsField = DirectCast(mySerializer.Deserialize(myFileStream), List(Of Artist))
            End If

            Return artistsField
        End Get
    End Property

    Public Shared ReadOnly Property TopArtists() As List(Of Artist)
        Get
            If topArtistsField Is Nothing Then
                Dim mySerializer As New XmlSerializer(GetType(List(Of Artist)))
                Dim myFileStream As New FileStream("..\..\artists.xml", FileMode.Open)
                topArtistsField = DirectCast(mySerializer.Deserialize(myFileStream), List(Of Artist))

                While topArtistsField.Count > 50
                    topArtistsField.RemoveAt(topArtistsField.Count - 1)
                End While
            End If

            Return topArtistsField
        End Get
    End Property
End Class
