'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Program Name: Salesperson Pay Calculator
' Description: Calculate a salesperson's pay and commission based on the ammout sold
' Programmed by: Bill Fulton
' Date: 24 January 2016
' Class: CIS 310 Online - Winter 2016
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On
Option Explicit On

Public Class Form1
    Const BASE_PAY As Double = 250.0 'Base Pay constant
    Const COMMISSION_RATE As Double = 0.15 'Commission Rate constant
    Const QUOTA As Double = 1000.0 'Sales Quota constant

    Dim allSales As Double 'Total of all sales
    Dim allCommissions As Double 'Total of all commissions
    Dim allPay As Double 'Total of all pay

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click 'Click event for pay menu item
        If (nameTxt.Text = "") Then 'Display an error for an empty name text box and prevent further calculation
            MessageBox.Show("You must enter a name", "Invalid Name Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else 'if the name text box is filled
            Dim totalPay As Double = calculateTotalPay() 'Function call to calculate total pay 
            Dim commission = calculateCommission(totalPay) 'Function call to calculate commission

            If (totalPay <= 0) Then 'if the total pay is <= 0 clear the total pay text box - Do not show a 0 
                totalPayTxt.Text = ""
            Else
                totalPayTxt.Text = totalPay.ToString("N") 'If the total pay is > 0, display the number
                allPay += totalPay 'add the total pay to the allPay variable
            End If

            If (commission <= 0) Then 'If the commission is <= 0, clear the commission text box - Do not show a 0
                commissionTxt.Text = ""
            Else
                commissionTxt.Text = commission.ToString("N") 'If the commission is > 0, display the number
                allCommissions += commission 'add the commission to the allCommissions variable
            End If
        End If 'end name validation if statement
    End Sub

    Private Function calculateCommission(ByVal totalPay As Double) As Double 'Calculate the total comission
        Return totalPay - BASE_PAY
    End Function

    Private Function calculateTotalPay() As Double 'Calculate total pay
        Dim sales As Double = parse(totalSalesTxt) 'function to parse the total sales text box
        Dim isValid As Boolean = checkValid(sales) 'function to ensure the sales value is valid
        Dim totalPay As Double

        If (sales >= QUOTA And isValid) Then 'if the sales are greater than the quota
            totalPay = (sales * COMMISSION_RATE) + BASE_PAY 'calculate total pay 
        ElseIf (sales < QUOTA And isValid) Then 'else if the sales are less than the quota
            totalPay = BASE_PAY
        Else
            Return 0 'else return a sentinal value
        End If

        Return totalPay 'if a total pay was calculated, return it

    End Function

    Private Function checkValid(ByVal sales As Double) As Boolean 'Check that the total sales entered in the text box is positive
        If (sales < 0) Then 'if < 0 return invalid
            Return False
        Else 'else return valid
            Return True
        End If
    End Function

    Private Function parse(ByVal box As Control) As Double 'Parse the total sales text box as a double
        Dim salesLocal As Double

        If (box.Text <> "") Then 'if total sales text box is not blank
            If Not Double.TryParse(box.Text, salesLocal) Then 'try to parse the total sales as a double
                MessageBox.Show("You must enter a number in the Total Sales field", "Invalid Number Error", 'if unable to parse, dispay an error
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return -1 'return a sentinal value

            ElseIf (salesLocal < 0) Then 'if the parsed number is negative
                MessageBox.Show("The Total Sales field must contain a positive",
                                "Invalid Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'display an error for negative number
                Return -1 'return a sentinal value
            End If
        Else 'Additional checking for an empty total sales text box
            MessageBox.Show("You must enter a number in the Total Sales field", "Invalid Number Error", 'if empty display an error
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1 'return a sentinal value
        End If

        allSales += salesLocal 'if the number was parsed toa valid number, add the number to the allSales variable

        Return salesLocal 'return the parsed total sales value

    End Function

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click 'Click event for the font menu item
        Dim font As DialogResult = FontDialog1.ShowDialog() 'display a font selection dialog and store the result

        If font = DialogResult.OK Then 'If the dialog OK button was clicked
            totalPayTxt.Font = FontDialog1.Font 'change the total pay text box font
            commissionTxt.Font = FontDialog1.Font 'change the commission text box font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click 'Click event for the color menu item
        Dim color As DialogResult = ColorDialog1.ShowDialog() 'display a color selection dialog and store the result

        'The background color modification was a work-around in order to keep a text box read-only
        'and still allow for the font color to be changed.
        If color = DialogResult.OK Then 'if the dialog OK button was clicked
            totalPayTxt.BackColor = SystemColors.Control 'Change the background color of the total pay text box to the 'read only' background color
            totalPayTxt.ForeColor = ColorDialog1.Color 'Change the font color
            commissionTxt.BackColor = SystemColors.Control 'Change the background color of the commission text box to the 'read only' background color
            commissionTxt.ForeColor = ColorDialog1.Color 'Change the font color
        End If
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click 'Click event for the summary menu item
        If (allPay = 0) Then 'if there was no data entered yet, display an error
            MessageBox.Show("There is no data to show yet", "No Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show(String.Format("Sales: {0}{0} {2} {1}Commissions: {0} {3} {1}Total Pay: {0}{0} {4}", vbTab, Environment.NewLine, allSales.ToString("C"),
                        allCommissions.ToString("C"), allPay.ToString("C")), "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click 'Click event for the clear menu item
        For Each txtBox As Control In Controls 'for each control on the form
            If (TypeOf txtBox Is TextBox) Then 'if the control is a text box
                txtBox.Text = "" 'clear the text box
            End If
        Next txtBox
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click 'Click event for the about menu item
        MessageBox.Show("Salesperson Pay Calculator" & Environment.NewLine & "Programmed by: Bill Fulton", 'Display a message box with information about the program
                        "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click 'Click event for the exit menu item
        Close() 'close the form
    End Sub
End Class
