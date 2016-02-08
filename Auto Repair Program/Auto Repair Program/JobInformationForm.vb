''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Program Name: Auto Repair Program
'Description: Calculate job total and display relevent information for
'             a hypothetical auto repair shop
'Programmed by: Bill Fulton
'Class: CIS 310 Online
'Date: 02 February 2016 - Winter 2016
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On

Public Class JobInformationForm

    Dim shop As repairShop = New repairShop() 'new repairShop Object - output calculations
    Dim helper As inputHelper = New inputHelper() 'new inputHelper Object - input validation
    Dim partsCost As Double 'input cost of parts
    Dim laborHours As Double 'input labor hours

    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click 'Click event for the calculate button

        Dim goodInput As Boolean = False 'flag used for input validation

        partsCost = helper.parse(wholesalePartsTxt.Text) 'parse user input parts cost
        laborHours = helper.parse(hoursOfLaborTxt.Text) 'parse user input labor hours

        If customerNameTxt.Text = "" Then 'if the customerName text box is blank
            helper.displayError(customerNameTxt) 'display an error and focus the field
            goodInput = False 'set the goodInput flag to false
        ElseIf jobNumberTxt.Text = "" Then 'if jobNumber text box is blank
            helper.displayError(jobNumberTxt) 'display an error and focus the field
            goodInput = False 'set the goodInput flag to false
        ElseIf partsCost = -99 Or Not helper.checkValid(partsCost) Then 'if input in the partsCost text box is unparsable or negative
            helper.displayError(wholesalePartsTxt) 'display and error and focus the field
            goodInput = False 'set the goodInput flag to false
        ElseIf laborHours = -99 Or Not helper.checkValid(laborHours) Then 'if input in the laborHours text box is unparsable or negative
            helper.displayError(hoursOfLaborTxt) 'display an error and focus the field
            goodInput = False 'set the goodInput flag to false
        Else
            goodInput = True 'if all fields are valid, set the goodInput flag to True
        End If

        If goodInput Then 'if all input was good, send the laborHours and parts cost values to the repairShop class
            shop.inputLaborHours = laborHours
            shop.inputPartsCost = partsCost

            shop.calculate() 'calculate the output values - total, subtotal, tax, parts+tax, labor cost

            updateFields() 'call to the update fields sub to display the calculated values
        End If
    End Sub

    Private Sub updateFields() 'sub to update the output fields
        partsTotalTxt.Text = shop.partsCost.ToString("C") 'update partsTotal text box - parts+tax
        laborTotalTxt.Text = shop.laborCost.ToString("C") ' update laborTotal text box - labor cost
        salesTaxTxt.Text = shop.tax.ToString("C") 'update salesTax text box - sales tax
        subtotalTxt.Text = shop.subtotal.ToString("C") 'update subtotal text box - parts before tax + labor
        totalTxt.Text = shop.total.ToString("C") 'update total - subtotal + tax
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click, Me.FormClosing 'Handeler for the OK button click event and form closing event
        Me.Dispose() 'close the box
        MainForm.Show() 'show the main form
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click 'clear button click event
        For Each box As Control In Controls 'for each control in the form
            If TypeOf box Is TextBox Then 'if the type of control is text box
                box.Text = "" 'clear the box
            End If
        Next box
    End Sub
End Class