Option Strict On
Public Class inputHelper

    Sub New()
    End Sub

    Public Function parse(ByVal input As String) As Double
        Dim postParse As Double
        If Not Double.TryParse(input, postParse) Then
            Return -99
        Else
            Return postParse
        End If
    End Function

    Public Function checkValid(value As Double) As Boolean
        If (value < 0) Then
            Return False
        Else
            Return True
        End If
    End Function

    Friend Sub displayError(invalidField As Control)
        Dim result As DialogResult = MessageBox.Show("There was a problem with your request. Please ensure all input is correct and try again.",
                                                     "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If result = DialogResult.OK Then
            invalidField.Focus()
            invalidField.Text = ""
        End If
    End Sub
End Class
