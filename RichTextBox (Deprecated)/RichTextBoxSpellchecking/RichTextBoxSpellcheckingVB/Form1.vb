Imports Telerik.WinControls.RichTextBox
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.RichTextBox.TextSearch
Imports Telerik.WinControls.RichTextBox.Layout

Public Class Form1
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim rtb As New SpellCheckRichTextBox()

        rtb.Parent = Me
        rtb.Dock = DockStyle.Fill

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class


Public Class SpellCheckRichTextBox
    Inherits RadRichTextBox
#Region "Fields"

    Private m_spellChecker As RadSpellChecker
    Private m_controlSpellChecker As IControlSpellChecker

#End Region

#Region "Properties"

    Public Shadows ReadOnly Property SpellChecker() As RadSpellChecker
        Get
            Return Me.m_spellChecker
        End Get
    End Property

    Public Shadows ReadOnly Property IsSpellCheckingEnabled() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Property AutoReplaceOnSpellCheck() As Boolean
        Get
            Return m_AutoReplaceOnSpellCheck
        End Get
        Set(value As Boolean)
            m_AutoReplaceOnSpellCheck = value
        End Set
    End Property
    Private m_AutoReplaceOnSpellCheck As Boolean

    Public ReadOnly Property ControlSpellChecker() As IControlSpellChecker
        Get
            Return Me.m_controlSpellChecker
        End Get
    End Property

#End Region

#Region "SpellChecking"

    Protected Overrides Sub CreateChildItems(parent As Telerik.WinControls.RadElement)
        MyBase.CreateChildItems(parent)

        Me.m_spellChecker = New RadSpellChecker()
        Me.m_controlSpellChecker = Me.m_spellChecker.GetControlSpellChecker(GetType(RadRichTextBox))
        Me.m_controlSpellChecker.CurrentControl = Me
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            Me.SpellCheckCore(Me.GetCurrentWord())
        End If

        MyBase.OnKeyDown(e)
    End Sub

    Protected Overrides Sub OnLoad(desiredSize As System.Drawing.Size)
        MyBase.OnLoad(desiredSize)
        'this is need in order to initialize the dictionaries when loaded instead of when typing
        Me.m_controlSpellChecker.SpellChecker.CheckWordIsCorrect("loadFasterWord")
    End Sub

    Private Function GetCurrentWord() As String
        Dim endPosition As New DocumentPosition(Me.Document.CaretPosition)
        Dim startPosition As New DocumentPosition(endPosition)
        Me.SelectCurrentWord(startPosition)
        Dim lastWord As String = Me.Document.Selection.GetSelectedText()
        Me.Document.Selection.Clear()

        Return lastWord
    End Function

    Private Sub SelectCurrentWord(position As DocumentPosition)
        position.MoveToCurrentWordStart()
        Me.Document.Selection.SetSelectionStart(position)
        position.MoveToCurrentWordEnd()
        Me.Document.Selection.AddSelectionEnd(position)
    End Sub

    Protected Overridable Sub SpellCheckCore(word As String)
        If String.IsNullOrEmpty(word) OrElse Me.m_controlSpellChecker.IgnoredWords.ContainsWord(word) Then
            Return
        End If

        Me.SelectCurrentWord(Me.Document.CaretPosition)

        If Me.AutoReplaceOnSpellCheck Then
            Dim suggestions As String() = DirectCast(Me.ControlSpellChecker.SpellChecker.GetSuggestions(Me.Document.Selection.GetSelectedText()), String())
            If suggestions.Length > 0 Then
                Me.Insert(suggestions(0))
            End If
        Else
            If Not m_controlSpellChecker.SpellChecker.CheckWordIsCorrect(word) Then
                Me.ChangeUnderlineDecoration(Telerik.WinControls.RichTextBox.UI.UnderlineType.Wave)
                Me.Document.Selection.Clear()

                Me.ChangeUnderlineDecoration(Telerik.WinControls.RichTextBox.UI.UnderlineType.None)
            Else
                Me.ChangeUnderlineDecoration(Telerik.WinControls.RichTextBox.UI.UnderlineType.None)
                Me.Document.Selection.Clear()
            End If
        End If
    End Sub

    Public Sub IgnoreWord(word As String)
        Me.m_controlSpellChecker.IgnoredWords.AddWord(word)
        Dim search As New DocumentTextSearch(Me.Document)
        Dim savedPosition As DocumentPosition = Me.Document.CaretPosition

        For Each text As TextRange In search.FindAll(word)
            Me.Document.Selection.AddSelectionStart(text.StartPosition)
            Me.Document.Selection.AddSelectionEnd(text.EndPosition)
            Me.ChangeUnderlineDecoration(Telerik.WinControls.RichTextBox.UI.UnderlineType.None)
        Next

        Me.Document.Selection.AddSelectionStart(savedPosition)
        Me.Document.Selection.AddSelectionEnd(savedPosition)
    End Sub

#End Region

#Region "SpellCheckContextMenu"

    Private Function BuildContextMenu(spanBox As SpanLayoutBox) As RadDropDownMenu
        Dim menu As New RadDropDownMenu()
        Dim menuItem As RadMenuItem

        If Me.Document.Selection.IsEmpty AndAlso Me.IsSpellCheckingEnabled AndAlso spanBox IsNot Nothing Then
            Me.Document.CaretPosition.MoveToInline(spanBox, 0)

            Dim spanBoxTextAlphaNumericOnly As String = [String].Concat(spanBox.Text.TakeWhile(Function(c) Char.IsLetterOrDigit(c)))

            If spanBoxTextAlphaNumericOnly.Length > 0 AndAlso Not Me.ControlSpellChecker.SpellChecker.CheckWordIsCorrect(spanBoxTextAlphaNumericOnly) Then
                Dim suggestions As String() = DirectCast(Me.ControlSpellChecker.SpellChecker.GetSuggestions(spanBox.Text), String())

                If suggestions.Length <= 0 Then
                    menuItem = New RadMenuItem("(No Spelling Suggestions)")
                    menuItem.Enabled = False
                    menu.Items.Add(menuItem)
                End If

                For Each suggestion As String In suggestions
                    menuItem = New RadMenuItem(suggestion)
                    AddHandler menuItem.Click, Sub(sender As Object, e As EventArgs)
                                                   Me.ReplaceCurrentWord(spanBox, TryCast(sender, RadMenuItem).Text)

                                               End Sub
                    menu.Items.Add(menuItem)
                Next

                menu.Items.Add(New SeparatorElement())

                menuItem = New RadMenuItem("Add to Dictionary")
                AddHandler menuItem.Click, Sub(sender As Object, e As EventArgs)
                                               Me.ControlSpellChecker.SpellChecker.AddWord(spanBoxTextAlphaNumericOnly)

                                           End Sub
                menu.Items.Add(menuItem)

                menu.Items.Add(New SeparatorElement())

            End If
        End If


        menuItem = New RadMenuItem("Undo")
        AddHandler menuItem.Click, Sub(sender As Object, e As EventArgs)
                                       Me.Undo()

                                   End Sub
        menu.Items.Add(menuItem)

        menu.Items.Add(New SeparatorElement())

        menuItem = New RadMenuItem("Cut")
        AddHandler menuItem.Click, Sub(sender As Object, e As EventArgs)
                                       Me.Cut()

                                   End Sub
        menu.Items.Add(menuItem)

        menuItem = New RadMenuItem("Copy")
        AddHandler menuItem.Click, Sub(sender As Object, e As EventArgs)
                                       Me.Copy()

                                   End Sub
        menu.Items.Add(menuItem)

        menuItem = New RadMenuItem("Paste")
        AddHandler menuItem.Click, Sub(sender As Object, e As EventArgs)
                                       Me.Paste()

                                   End Sub

        menu.Items.Add(menuItem)

        menuItem = New RadMenuItem("Delete")
        AddHandler menuItem.Click, Sub(sender As Object, e As EventArgs)
                                       Me.Delete(False)

                                   End Sub
        menu.Items.Add(menuItem)

        menu.Items.Add(New SeparatorElement())

        menuItem = New RadMenuItem("Select All")
        AddHandler menuItem.Click, Sub(sender As Object, e As EventArgs)
                                       Me.Document.Selection.SelectAll()

                                   End Sub
        menu.Items.Add(menuItem)

        Return menu
    End Function

    Private Sub ReplaceCurrentWord(spanBox As SpanLayoutBox, newWord As String)
        Me.Document.CaretPosition.MoveToInline(spanBox, 0)

        Dim endPosition As New DocumentPosition(Me.Document.CaretPosition)
        endPosition.MoveToCurrentWordEnd()

        Me.Document.Selection.Clear()
        Me.Document.Selection.AddSelectionStart(Me.Document.CaretPosition)
        Me.Document.Selection.AddSelectionEnd(endPosition)

        Me.Insert(newWord)
    End Sub

    Protected Overrides Sub OnMouseDown(e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Dim spanBox As SpanLayoutBox = TryCast(Me.Document.GetLayoutBoxByPosition(e.Location), SpanLayoutBox)
            Me.BuildContextMenu(spanBox).Show(Me, e.Location)
        End If

        MyBase.OnMouseDown(e)
    End Sub

#End Region
End Class