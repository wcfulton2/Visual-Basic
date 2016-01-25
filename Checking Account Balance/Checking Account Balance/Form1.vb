'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Program Name: Checking Account Balance Calculator
' Description: Calculates the balance of a checking account based on a
'               series of deposits, checks, And service charges.
' Programmed By: Bill Fulton
' Class: CIS310 Online - Winter 2016
' Date Created: 18 January 2016
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On
Option Explicit On

Public Class Form1
    Dim balance As Double 'Total Account Balance Variable

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown 'OnLoad event
        transactionAmount.Focus()  'Focus the Transaction Ammount text box
    End Sub

    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click 'Calculate button click event
        Dim transaction As Double = getTransaction() 'Parse the and Validate the Transaction Ammount text box

        If Not transaction = -0.999 Then 'Check for a sentinel value caused by an un-parsable input
            Dim isValid As Boolean = checkValid(transaction) 'Further validation of the Transaction Ammount - Ensure number is greater than 0
            updateBalance(transaction, isValid) 'Call to the updateBalance function - Additional Validation and update of the New Balance text box
        End If
    End Sub

    Private Sub updateBalance(transaction As Double, isValid As Boolean) 'Update the New Balance text box
        If (isValid) Then 'If the number is valid

            Select Case getRadioPos() 'Switch statement based on Transaction Type radio button position
                Case 1
                    balance += transaction 'if deposit
                Case 2
                    balance -= transaction 'if check
                Case 3
                    balance -= transaction 'if service charge
                Case Else 'Additional validadtion for the Transaction Type radio buttons
                    MessageBox.Show("There was an error with your request. Make sure all fields are filled and try again",
                                "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

            newBalance.Text = balance.ToString("C") 'Update the New Balance text box
            transactionAmount.Text = "" 'Clear the Transaction Ammount text box
            transactionAmount.Focus() 'Refocus the Transaction Ammount text box
        End If
    End Sub

    Private Function getTransaction() As Double 'Get the value from the Transaction Ammount text box and parse it to a double
        Dim transaction As Double
        If Not Double.TryParse(transactionAmount.Text, transaction) Then
            MessageBox.Show("Please enter a numeric value in the transaction ammount text box", "Transaction Amount Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error) 'If the number cannot be parsed, display an error
            transactionAmount.Text = "" 'Clear the Transaction Ammount text box
            transactionAmount.Focus() 'Refocus the Transaction Ammount text box
            Return -0.999 'Return a sentinel value if unable to parse
        Else
            Return transaction 'If parse is sucessful, return the value
        End If
    End Function

    Private Function getRadioPos() As Integer 'Get the position of the Transaction Type radio buttons
        Dim radioPos As Integer

        If (depositRaido.Checked) Then 'Deposit
            radioPos = 1
        ElseIf (checkRadio.Checked) Then 'Check
            radioPos = 2
        ElseIf (serviceChargeRadio.Checked) Then 'Service Charge
            radioPos = 3
        End If

        Return radioPos 'Return which button is checked
    End Function

    Private Function checkValid(ByVal transaction As Double) As Boolean 'Check for a valid transaction ammount (Greater than 0)
        If (transaction <= 0) Then 'if 0 or negative display an error
            MessageBox.Show("Please enter only positive, non-zero numbers ", "Transaction Amount Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            transactionAmount.Text = "" 'Clear the invalid field
            transactionAmount.Focus() 'Refocus the invalid field

            Return False 'Return that the number is invalid
        Else 'Else retunr the number is valid
            Return True
        End If
    End Function

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click 'Click event for the print button
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview 'Display print dialog
        PrintForm1.Print()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click 'Click event for the Clear button
        For Each txtBox As Control In Controls 'Clear each text box on the form
            If (TypeOf txtBox Is TextBox) Then
                txtBox.Text = ""
            End If
        Next txtBox
        depositRaido.Checked = True 'Check the top (Deposit)  radio button
        transactionAmount.Focus() 'Focus the top (Transaction Ammount) text box
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click 'Click event for Exit button
        Close() ' Close the form
    End Sub
End Class
