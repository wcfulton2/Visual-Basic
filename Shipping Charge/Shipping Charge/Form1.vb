''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Program Name: Shipping Charge Calculator
' Description: Calculate shipping charge of a package given pounds and ounces based on a fixed shipping cost
'              and reject any invalid data
' Programmed by: Bill Fulton
' Date: 13 January 2015
' Course: CIS 310 Online - Intro to Visual Basic
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On
Option Explicit On
Public Class Form1
    Const SHIPPING_COST As Double = 0.12 'constant for shipping rate
    'variables used for package weight
    Dim pounds As Integer
    Dim ounces As Integer

    'Parse and validate the pounds textbox and display any errors
    Private Sub inputPounds_TextChanged(sender As Object, e As EventArgs) Handles inputPounds.TextChanged
        If Not Integer.TryParse(inputPounds.Text, pounds) Then 'Check for numeric data
            poundsError.Text = "Enter a numeric value"
        ElseIf (pounds < 0) Then 'Check for negative numbers
            poundsError.Text = "The number must be positive"
        Else
            poundsError.Text = ""
        End If
    End Sub

    'Parse and validate the ounces textbox and display any errors
    Private Sub inputOunces_TextChanged(sender As Object, e As EventArgs) Handles inputOunces.TextChanged
        If Not Integer.TryParse(inputOunces.Text, ounces) Then 'Check for numeric data
            ouncesError.Text = "Enter a numeric value"
        ElseIf (ounces < 0) 'Check for negate numbers
            ouncesError.Text = "The number must be positive"
        Else
            ouncesError.Text = ""
        End If
    End Sub

    'Click event for caluclate button. Check for bad data and dispay any errors. Calculate shipping rate.
    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        If (pounds < 0 Or ounces < 0 Or pounds = 0 And ounces = 0 Or Not packageID.MaskCompleted) Then 'Ensure weights are in range and the package ID is valid
            MessageBox.Show("All fields must be filled and error free", "Incomplete Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim total As Double = ((pounds * 16) + ounces) * SHIPPING_COST 'Calculate shipping cost and update the Total Cost textbox with the cost as a formatted String
            totalCost.Text = total.ToString("C")
        End If
    End Sub

    'Validation for the Package ID masked text box
    Private Sub packageID_TextChanged(sender As Object, e As EventArgs) Handles packageID.TextChanged
        If (Not packageID.MaskCompleted) Then 'Ensure all 6 digits are entered
            idError.Text = "Enter the 6 Digit Package ID"
        Else
            idError.Text = ""
        End If
    End Sub

    'Click event for the Clear button. Clear the text boxes and clear any errors
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        For Each textBox As Control In Controls 'Clear all text boxes
            If (TypeOf textBox Is TextBox Or TypeOf textBox Is MaskedTextBox) Then
                textBox.Text = ""
            End If
        Next textBox

        For Each errorLabel As Control In Controls 'Clear all Red (error) lables
            If (TypeOf errorLabel Is Label And errorLabel.ForeColor = Color.Red) Then
                errorLabel.Text = ""
            End If
        Next errorLabel
    End Sub

    'Click event for the Print button
    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview 'Display the print dialog
        PrintForm1.Print()
    End Sub

    'Click event for the Exit button.
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Close() 'Close the program
    End Sub
End Class
