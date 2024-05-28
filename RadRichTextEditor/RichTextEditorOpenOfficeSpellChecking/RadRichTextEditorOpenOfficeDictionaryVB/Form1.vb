Imports System.IO
Imports Telerik.WinForms.Documents.FormatProviders.Txt

Public Class Form1
    Private Shared ReadOnly AffFilePath As String = "..\..\ThirdPartyLibs\Dictionaries\main.aff"
    Private Shared ReadOnly DicFilePath As String = "..\..\ThirdPartyLibs\Dictionaries\main.dic"

    Private hunspellSpellChecker As HunspellSpellChecker

    Public Sub New()
        InitializeComponent()

        Me.RadRichTextEditor1.IsSpellCheckingEnabled = True
        Me.RichTextEditorRibbonBar1.AssociatedRichTextEditor = Me.RadRichTextEditor1

        Using affFile As Stream = File.OpenRead(AffFilePath)
            Using dicFile As Stream = File.OpenRead(DicFilePath)
                Me.hunspellSpellChecker = New HunspellSpellChecker(affFile, dicFile)
                Me.RadRichTextEditor1.SpellChecker = Me.hunspellSpellChecker
            End Using
        End Using


        Me.RadRichTextEditor1.Document = New TxtFormatProvider().Import("Sooooome incorrrect teeext!")
    End Sub
End Class
