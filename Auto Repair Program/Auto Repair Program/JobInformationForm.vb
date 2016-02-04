Option Strict On
Public Class JobInformationForm

    Dim shop As repairShop = New repairShop()
    Dim helper As inputHelper = New inputHelper()
    Dim partsCost As Double
    Dim laborHours As Double

    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click

        Dim goodInput As Boolean = False

        partsCost = helper.parse(wholesalePartsTxt.Text)
        laborHours = helper.parse(hoursOfLaborTxt.Text)

        If customerNameTxt.Text = "" Then
            helper.displayError(customerNameTxt)
            goodInput = False
        ElseIf jobNumberTxt.Text = "" Then
            helper.displayError(jobNumberTxt)
            goodInput = False
        ElseIf partsCost = -99 Or Not helper.checkValid(partsCost) Then
            helper.displayError(wholesalePartsTxt)
            goodInput = False
        ElseIf laborHours = -99 Or Not helper.checkValid(laborHours) Then
            helper.displayError(hoursOfLaborTxt)
            goodInput = False
        Else
            goodInput = True
        End If

        If goodInput Then
            shop.inputLaborHours = laborHours
            shop.inputPartsCost = partsCost

            shop.calculate()

            updateFields()
        End If
    End Sub

    Private Sub updateFields()
        partsTotalTxt.Text = shop.partsCost.ToString("C")
        laborTotalTxt.Text = shop.laborCost.ToString("C")
        salesTaxTxt.Text = shop.tax.ToString("C")
        subtotalTxt.Text = shop.subtotal.ToString("C")
        totalTxt.Text = shop.total.ToString("C")
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click, Me.FormClosing
        Me.Dispose()
        Form1.Show()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        For Each box As Control In Controls
            If TypeOf box Is TextBox Then
                box.Text = ""
            End If
        Next box
    End Sub
End Class