Imports Telerik.WinForms.Documents.Proofing
Imports NHunspell
Imports System.IO
Imports System.Globalization

Public Class HunspellSpellChecker
    Implements ISpellChecker
    Implements IDisposable
    Private spell As New Hunspell()
    Private alreadyDisposed As Boolean
    Private m_settings As SpellCheckerSettings

    Public Sub New(affFile As Stream, dicFile As Stream)
        Me.m_settings = New SpellCheckerSettings() With {
             .SpellCheckUppercaseWords = True,
             .SpellCheckWordsWithNumbers = True
        }

        Dim affBytes As Byte() = ReadAllBytes(affFile)
        Dim dicBytes As Byte() = ReadAllBytes(dicFile)

        Me.spell.Load(affBytes, dicBytes)
    End Sub

    Private Shared Function ReadAllBytes(stream As Stream) As Byte()
        Dim result As Byte() = New Byte(stream.Length - 1) {}
        stream.Seek(0, SeekOrigin.Begin)
        stream.Read(result, 0, result.Length)

        Return result
    End Function

    Public Function CheckWordIsCorrect(word As String) As Boolean Implements ISpellChecker.CheckWordIsCorrect
        If Not Me.Settings.SpellCheckUppercaseWords AndAlso Char.IsUpper(word(0)) Then
            Return True
        End If

        If Not Me.Settings.SpellCheckWordsWithNumbers AndAlso word.Any(Function(c) Char.IsDigit(c)) Then
            Return True
        End If

        Dim result As Boolean = Me.spell.Spell(word)

        Return result
    End Function

    Public Function CheckWordIsCorrect(word As String, culture As CultureInfo) As Boolean Implements ISpellChecker.CheckWordIsCorrect
        Return Me.CheckWordIsCorrect(word)
    End Function

    Public Function GetSuggestions(word As String) As ICollection(Of String) Implements ISpellChecker.GetSuggestions
        Dim result As List(Of String) = Me.spell.Suggest(word)

        Return result
    End Function

    Public Function GetSuggestions(word As String, culture As CultureInfo) As ICollection(Of String) Implements ISpellChecker.GetSuggestions
        Return Me.GetSuggestions(word)
    End Function

    Public Function CanAddWord() As Boolean Implements ISpellChecker.CanAddWord
        Return True
    End Function

    Public Function CanAddWord(culture As CultureInfo) As Boolean Implements ISpellChecker.CanAddWord
        Return True
    End Function

    Public Sub AddWord(word As String) Implements ISpellChecker.AddWord
        Me.spell.Add(word)

        Me.OnDataChanged()
    End Sub

    Public Sub AddWord(word As String, culture As CultureInfo) Implements ISpellChecker.AddWord
        Me.AddWord(word)
    End Sub

    Public Sub RemoveWord(word As String) Implements ISpellChecker.RemoveWord
        Throw New NotSupportedException()
    End Sub

    Public Sub RemoveWord(word As String, culture As CultureInfo) Implements ISpellChecker.RemoveWord
        Me.RemoveWord(word)
    End Sub

    Public Function GetDictionary() As IWordDictionary Implements ISpellChecker.GetDictionary
        Return Nothing
    End Function

    Public Function GetDictionary(culture As CultureInfo) As IWordDictionary Implements ISpellChecker.GetDictionary
        Return Nothing
    End Function

    Public Function GetCustomDictionary() As ICustomWordDictionary Implements ISpellChecker.GetCustomDictionary
        Return Nothing
    End Function

    Public Function GetCustomDictionary(culture As CultureInfo) As ICustomWordDictionary Implements ISpellChecker.GetCustomDictionary
        Return Nothing
    End Function

    Public Property SpellCheckingCulture() As CultureInfo Implements ISpellChecker.SpellCheckingCulture
        Get
            Return New CultureInfo("en-us")
        End Get
        Set(value As CultureInfo)
        End Set
    End Property

    Public Property Settings() As SpellCheckerSettings Implements ISpellChecker.Settings
        Get
            Return Me.m_settings
        End Get
        Set(value As SpellCheckerSettings)
            Me.m_settings = value
        End Set
    End Property

    Public Event DataChanged As EventHandler Implements ISpellChecker.DataChanged

    Protected Overridable Sub OnDataChanged()
        RaiseEvent DataChanged(Me, EventArgs.Empty)
    End Sub

    Protected Overrides Sub Finalize()
        Try
            Me.Dispose(False)
        Finally
            MyBase.Finalize()
        End Try
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Me.Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.alreadyDisposed Then
            If disposing Then
                If Me.spell IsNot Nothing Then
                    Me.spell.Dispose()
                    Me.spell = Nothing
                End If
            End If

            Me.alreadyDisposed = True
        End If
    End Sub
End Class