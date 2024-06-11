Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports Telerik.WinControls.UI
Imports System.Drawing

Namespace AppPortfolioVB
    Public Class PortfolioButtonElement
        Inherits RadButtonElement
        Private executeCommand_Renamed As String = String.Empty

        Private productImageLocation_Renamed As String = String.Empty
        Private productDescription_Renamed As String = String.Empty
        Private productTitle_Renamed As String = String.Empty

        Public Sub New()
            Me.ButtonFillElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        End Sub

        <DefaultValue("")> _
        Public Property NavigateToURL() As String
            Get
                Return executeCommand_Renamed
            End Get
            Set(value As String)
                executeCommand_Renamed = Value
            End Set
        End Property

        <DefaultValue("")> _
        Public Property ProductImageLocation() As String
            Get
                Return Me.productImageLocation_Renamed
            End Get
            Set(value As String)
                Me.productImageLocation_Renamed = Value
            End Set
        End Property

        Public Function GetProductImage() As Image
            If String.IsNullOrEmpty(Me.productImageLocation_Renamed) Then
                Return Nothing
            End If

            Dim executingAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim stream As Stream = executingAssembly.GetManifestResourceStream(Me.productImageLocation_Renamed)

            Return New Bitmap(stream)
        End Function

        <DefaultValue("")> _
        Public Property ProductDescription() As String
            Get
                Return Me.productDescription_Renamed
            End Get
            Set(value As String)
                Me.productDescription_Renamed = Value
            End Set
        End Property

        <DefaultValue("")> _
        Public Property ProductTitle() As String
            Get
                Return Me.productTitle_Renamed
            End Get
            Set(value As String)
                Me.productTitle_Renamed = Value
            End Set
        End Property

        Public Overridable Sub ExecuteCommand()
            Process.Start(Me.NavigateToURL, Nothing)

            'string fileName = string.Empty;
            'if (!Path.IsPathRooted(this.NavigateToURL))
            '{
            '    fileName = Path.Combine(basePath, this.NavigateToURL);
            '}
            'else
            '{
            '    fileName = this.NavigateToURL;
            '}
            'if (!File.Exists(fileName))
            '{
            '    MessageBox.Show("File not found: " + fileName);
            '    return;
            '}

            'ProcessStartInfo startInfo = new ProcessStartInfo(fileName);
            'startInfo.WorkingDirectory = Path.GetDirectoryName(fileName);
            'Process.Start(startInfo);



            'formTypeName += this.NavigateToURL.Replace("/", ".");
            'formType = Assembly.GetEntryAssembly().GetType(formTypeName);
            'Control ctrl = Activator.CreateInstance(formType) as Control;

            'Form ctrlForm = new Form();
            'if (ctrl != null)
            '{
            '    ctrlForm.Controls.Add(ctrl);
            '    ctrlForm.ShowDialog();
            '}


            'formTypeName = this.NavigateToURL.Replace("/", ".");
            'formType = Assembly.GetEntryAssembly().GetType(formTypeName);
            'Form form = Activator.CreateInstance(formType) as Form;
            'if (form != null)
            '{
            '    form.ShowDialog();
            '}

        End Sub
    End Class

End Namespace
