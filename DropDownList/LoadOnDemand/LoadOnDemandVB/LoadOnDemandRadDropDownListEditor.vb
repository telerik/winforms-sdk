Imports Telerik.WinControls.UI

''' <summary>
''' Expansion to create a Load on Demand RadDropDownListEditor in a GridViewComboBoxColumn.
''' This editor should replace the default editor by replacing it in RadGridview1_EditorRequired event.
''' </summary>
''' <remarks></remarks>
Public Class LoadOnDemandRadDropDownListEditor
    Inherits RadDropDownListEditor


    ''' <summary>
    ''' KeyCodes which fire the KeyUp and keyDown event
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property HandleKeyCodes() As List(Of Keys)
        Get
            Return _handleKeyCodes
        End Get
        Set(ByVal value As List(Of Keys))
            _handleKeyCodes = value
        End Set
    End Property
    Private _handleKeyCodes As List(Of Keys) = New List(Of Keys)


    ''' <summary>
    ''' KeyValues which fire the KeyUp and keyDown event 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property HandleKeyValues() As List(Of Integer)
        Get
            Return _handleKeyValues
        End Get
        Set(ByVal value As List(Of Integer))
            _handleKeyValues = value
        End Set
    End Property
    Private _handleKeyValues As List(Of Integer) = New List(Of Integer)


    ''' <summary>
    ''' Enter key ends edit mode
    ''' </summary>
    ''' <value></value>
    ''' <remarks>Default true</remarks>
    Public WriteOnly Property ConfirmOnEnter As Boolean
        Set(value As Boolean)
            _confirmOnEnter = value
        End Set
    End Property
    Private _confirmOnEnter As Boolean = True


    ''' <summary>
    ''' Event after a key is released
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event KeyUp(ByVal sender As Object, ByVal e As LoadOnDemandRadDropDownListEditorEventargs)

    ''' <summary>
    ''' Event when a key is hit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event KeyDown(ByVal sender As Object, ByVal e As LoadOnDemandRadDropDownListEditorEventargs)

    ''' <summary>
    ''' Bubble up the selected index changed event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As LoadOnDemandRadDropDownListEditorEventargs)

    ''' <summary>
    ''' Bubble up the selected index changing event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event SelectedIndexChanging(ByVal sender As Object, ByVal e As LoadOnDemandRadDropDownListEditorEventargs)


    ''' <summary>
    ''' Set the display memeber of the editor element
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DisplayMember() As String
        Get
            Return CType(Me.EditorElement, RadDropDownListEditorElement).DisplayMember
        End Get
        Set(ByVal value As String)
            CType(Me.EditorElement, RadDropDownListEditorElement).DisplayMember = value
        End Set
    End Property

    ''' <summary>
    ''' Set the display memeber of the editor element
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Valuemember() As String
        Get
            Return CType(Me.EditorElement, RadDropDownListEditorElement).ValueMember
        End Get
        Set(ByVal value As String)
            CType(Me.EditorElement, RadDropDownListEditorElement).ValueMember = value
        End Set
    End Property




    ''' <summary>
    ''' Initialize the handled keys (a-z / 0-9)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        'char A to Z
        For handledKeyCode As Keys = Keys.A To Keys.Z + 1
            _handleKeyCodes.Add(handledKeyCode)
        Next
        'Numbers 0 to 9
        For handledKeyValue As Integer = 48 To 58
            _handleKeyValues.Add(handledKeyValue)
        Next

        AddHandler CType(Me.EditorElement, RadDropDownListEditorElement).SelectedIndexChanged, AddressOf RaiseSelectedIndexChanged
        AddHandler CType(Me.EditorElement, RadDropDownListEditorElement).SelectedIndexChanging, AddressOf RaiseSelectedIndexChanging

    End Sub


    ''' <summary>
    ''' Overrides the default OnKeyUp van de RadDropDownListEditor
    ''' Raises KeyUp event when the entered key is in the keyCode or keyValue collection
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Overrides Sub OnKeyUp(e As System.Windows.Forms.KeyEventArgs)

        If _handleKeyCodes.Contains(e.KeyCode) OrElse _handleKeyValues.Contains(e.KeyValue) Then
            Dim ddl As RadDropDownListEditorElement = Me.EditorElement
            RaiseEvent KeyUp(Me, New LoadOnDemandRadDropDownListEditorEventargs() With {.KeyEventArgs = e, _
                                                                                        .RadDropDownListEditorElement = ddl})

            e.Handled = True
            e.SuppressKeyPress = True
        End If
        If _confirmOnEnter AndAlso e.KeyCode.Equals(Keys.Enter) Then MyBase.OnKeyUp(e)
    End Sub

    ''' <summary>
    ''' Overrides the default OnKeyDown van de RadDropDownListEditor
    ''' Raises KeyDown event. 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Overrides Sub OnKeyDown(e As System.Windows.Forms.KeyEventArgs)
        Dim ddl As RadDropDownListEditorElement = Me.EditorElement
        RaiseEvent KeyDown(Me, New LoadOnDemandRadDropDownListEditorEventargs() With {.KeyEventArgs = e, _
                                                                                      .RadDropDownListEditorElement = ddl})
        If _confirmOnEnter AndAlso e.KeyCode.Equals(Keys.Enter) Then MyBase.OnKeyDown(e)
    End Sub


    Private Sub RaiseSelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs)
        RaiseEvent SelectedIndexChanged(Me, New LoadOnDemandRadDropDownListEditorEventargs() With {.RadDropDownListEditorElement = Me.EditorElement, _
                                                                                                   .PositionChangedEventArgs = e})
    End Sub

    Private Sub RaiseSelectedIndexChanging(sender As Object, e As Data.PositionChangingCancelEventArgs)
        RaiseEvent SelectedIndexChanged(Me, New LoadOnDemandRadDropDownListEditorEventargs() With {.RadDropDownListEditorElement = Me.EditorElement, _
                                                                                                   .PositionChangingCancelEventArgs = e})
    End Sub



End Class

''' <summary>
''' Custom event argument for <see cref="LoadOnDemandRadDropDownListEditor" /><br/>
''' Contains the editor element (RadDropDownListEditorElement) and the KeyEventArgs  
''' </summary>
''' <remarks></remarks>
Public Class LoadOnDemandRadDropDownListEditorEventargs
    Inherits EventArgs

    Public RadDropDownListEditorElement As RadDropDownListEditorElement

    Public KeyEventArgs As KeyEventArgs

    Public PositionChangedEventArgs As Data.PositionChangedEventArgs

    Public PositionChangingCancelEventArgs As Data.PositionChangingCancelEventArgs

End Class
