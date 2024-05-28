Imports System.Drawing.Design
Imports System.Windows.Forms.Design
Imports System.ComponentModel

Public MustInherit Class PropertyEditorBase
    Inherits System.Drawing.Design.UITypeEditor
    Protected MustOverride Function GetEditControl(ByVal PropertyName As String, ByVal CurrentValue As Object) As Control
    Protected MustOverride Function GetEditedValue(ByVal EditControl As Control, ByVal PropertyName As String, ByVal OldValue As Object) As Object

    Protected _EditorService As IWindowsFormsEditorService
    Private WithEvents _EditControl As Control
    Private _EscPressed As Boolean

    ' Sets the edit style for either a popup form or dropdown control 
    Public Overrides Function GetEditStyle(ByVal context As System.ComponentModel.ITypeDescriptorContext) As UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function

    ' Display the custom editor
    Public Overrides Function EditValue(ByVal context As ITypeDescriptorContext, ByVal provider As IServiceProvider, ByVal value As Object) As Object

        Try
            If context IsNot Nothing AndAlso provider IsNot Nothing Then

                ' Use the IWindowsFormsEditorService to display a Dropdown
                _EditorService = DirectCast(provider.GetService(GetType(IWindowsFormsEditorService)), IWindowsFormsEditorService)
                If _EditorService IsNot Nothing Then

                    Dim PropertyName As String = context.PropertyDescriptor.Name

                    _EditControl = Me.GetEditControl(PropertyName, value)   'get Edit Control from the driven class

                    If _EditControl IsNot Nothing Then

                        'Set this to False before showing the control
                        _EscPressed = False

                        ' Display the Control
                        _EditorService.ShowDialog(CType(_EditControl, Form))

                        If _EscPressed Then
                            ' Return the original value since the user clicked 'Escape'
                            Return value
                        Else
                            ' Return the new value
                            Return GetEditedValue(_EditControl, PropertyName, value)
                        End If

                    End If

                End If

            End If

        Catch ex As Exception
            ' Show an error msgbox here

        End Try
        Return MyBase.EditValue(context, provider, value)

    End Function

    Public Function GetIWindowsFormsEditorService() As IWindowsFormsEditorService
        Return _EditorService
    End Function

    Public Sub CloseDropDownWindow()
        If _EditorService IsNot Nothing Then _EditorService.CloseDropDown()
    End Sub

    Private Sub _EditControl_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs) Handles _EditControl.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then _EscPressed = True
    End Sub


End Class
