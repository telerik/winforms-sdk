
''' <summary>
''' Example data to populate the load on demand RadDropDownList
''' </summary>
''' <remarks></remarks>
Public Class ExampleData

    ''' <summary>
    ''' The property displayed in the dropdownlist
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ExampleDisplayMember() As String
        Get
            Return _exampleDisplayMember
        End Get
        Set(ByVal value As String)
            _exampleDisplayMember = value
        End Set
    End Property
    Private _exampleDisplayMember As String

    ''' <summary>
    ''' The value of the ExampleData object
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ExampleValueMember() As Guid
        Get
            Return _exampleValueMember
        End Get
        Set(ByVal value As Guid)
            _exampleValueMember = value
        End Set
    End Property
    Private _exampleValueMember As Guid

    ''' <summary>
    ''' Any other properties of your objects are irrelevant
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property WhateverOtherProps() As String
        Get
            Return _whateverOtherProps
        End Get
        Set(ByVal value As String)
            _whateverOtherProps = value
        End Set
    End Property
    Private _whateverOtherProps As String

    ''' <summary>
    ''' Required to initialize new ExampleData objects
    ''' </summary>
    ''' <param name="display">Text to display in the dropdownlist</param>
    ''' <param name="value">Value of the created ExampleData object</param>
    ''' <param name="other">Another property, no specific purpose</param>
    ''' <remarks></remarks>
    Sub New(ByVal display As String, ByVal value As Guid, ByVal other As String)
        _exampleDisplayMember = display
        _exampleValueMember = value
        _whateverOtherProps = other
    End Sub


    ''' <summary>
    ''' Create an object list populated with ExampleData objects
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateList() As List(Of ExampleData)

        Dim chars As New List(Of String)(New String() {"abc", "def", "ghi", "jkl", "mno", "pqr", "stu", "vwx", "yz"})
        Dim numbers As New List(Of String)(New String() {"123", "456", "789", "012", "345", "678"})
        Dim result As New List(Of ExampleData)

        For Each chr As String In chars
            For Each nr As String In numbers
                result.Add(New ExampleData(chr + nr, Guid.NewGuid, chr + "-" + nr))
            Next
        Next

        Return result

    End Function


    Public Overrides Function ToString() As String
        Return Me.WhateverOtherProps
    End Function

End Class


