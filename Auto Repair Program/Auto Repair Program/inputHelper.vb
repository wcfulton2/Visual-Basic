''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Program Name: Auto Repair Program
'Description: Calculate job total and display relevent information for
'             a hypothetical auto repair shop
'Programmed by: Bill Fulton
'Class: CIS 310 Online
'Date: 02 February 2016 - Winter 2016
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On

Public Class inputHelper

    Sub New() 'constructor
    End Sub

    Public Function parse(ByVal input As String) As Double 'parse user input as a double
        Dim postParse As Double 'value after parse
        If Not Double.TryParse(input, postParse) Then 'if not parsable, return a sentinal value of -99
            Return -99
        Else 'if parsable, return the parsed value
            Return postParse
        End If
    End Function

    Public Function checkValid(value As Double) As Boolean 'check the validity of the input data
        If (value < 0) Then 'if the number is negative return False - the data is invalid
            Return False
        Else 'else return True - the data is valid
            Return True
        End If
    End Function

    Friend Sub displayError(invalidField As Control) 'Sub to handle error ouput
        Dim result As DialogResult = MessageBox.Show("There was a problem with your request. Please ensure all input is correct and try again.", 'display an error and
                                                     "An Error has occured", MessageBoxButtons.OK, MessageBoxIcon.Error)                         'wait for the user to hit OK

        If result = DialogResult.OK Then 'if OK button is pressend
            invalidField.Focus() 'focus the invalid field
            invalidField.Text = "" 'clear in the invalid field
        End If
    End Sub
End Class
