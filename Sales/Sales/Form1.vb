Option Strict On
Option Explicit On
Public Class Form1
    Const BASE_PAY As Double = 250.0
    Const COMMISSION_RATE As Double = 0.15
    Const QUOTA As Double = 1000.0

    Dim allSales As Double
    Dim allCommissions As Double
    Dim allPay As Double

    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        If (nameTxt.Text = "") Then
            MessageBox.Show("You must enter a name", "Invalid Name Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim totalPay As Double = calculateTotalPay()
            Dim commission = calculateCommission(totalPay)

            If (totalPay <= 0) Then
                totalPayTxt.Text = ""
            Else
                totalPayTxt.Text = totalPay.ToString(".00") 'NEEDS FORMATTING
                allPay += totalPay
            End If


            If (commission <= 0) Then
                commissionTxt.Text = ""
            Else
                commissionTxt.Text = commission.ToString(".00") 'NEEDS FORMATTING
                allCommissions += commission
            End If
        End If
    End Sub

    Private Function calculateCommission(ByVal totalPay As Double) As Double
        Return totalPay - BASE_PAY
    End Function

    Private Function calculateTotalPay() As Double
        Dim sales As Double = parse(totalSalesTxt)
        Dim isValid As Boolean = checkValid(sales)
        Dim totalPay As Double

        If (sales >= QUOTA And isValid) Then
            totalPay = (sales * COMMISSION_RATE) + BASE_PAY
        ElseIf (sales < QUOTA And isValid) Then
            totalPay = BASE_PAY
        Else
            Return 0

        End If

        Return totalPay

    End Function

    Private Function checkValid(ByVal sales As Double) As Boolean
        If (sales < 0) Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Function parse(ByVal box As Control) As Double
        Dim salesLocal As Double

        If (box.Text <> "") Then
            If Not Double.TryParse(box.Text, salesLocal) Then
                MessageBox.Show("You must enter a number in the Total Sales field", "Invalid Number Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return -1

            ElseIf (salesLocal < 0) Then
                MessageBox.Show("The Total Sales field must contain a positive",
                                "Invalid Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return -1
            End If
        Else
            MessageBox.Show("You must enter a number in the Total Sales field", "Invalid Number Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End If
        allSales += salesLocal
        Return salesLocal
    End Function

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim font As DialogResult = FontDialog1.ShowDialog()

        If font = DialogResult.OK Then
            totalPayTxt.Font = FontDialog1.Font
            commissionTxt.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Dim color As DialogResult = ColorDialog1.ShowDialog()

        If color = DialogResult.OK Then
            totalPayTxt.BackColor = SystemColors.Control
            totalPayTxt.ForeColor = ColorDialog1.Color
            commissionTxt.BackColor = SystemColors.Control
            commissionTxt.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        If (allPay = 0) Then
            MessageBox.Show("There is no data to show yet", "No Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'MessageBox.Show(String.Format("Sales: {0}{0} {2: $.00} {1}Commissions: {0} {3: $.00} {1}Total Pay: {0}{0} {4: $.00}", vbTab, Environment.NewLine, allSales,
            '            allCommissions, allPay), "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MessageBox.Show(String.Format("Sales: {0}{0} {2} {1}Commissions: {0} {3} {1}Total Pay: {0}{0} {4}", vbTab, Environment.NewLine, allSales.ToString("C"),
                        allCommissions.ToString("C"), allPay.ToString("C")), "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'DEBUG
            'MessageBox.Show(allPay.ToString("c"), "Test", MessageBoxButtons.OK)
            'DEBUG
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        For Each txtBox As Control In Controls
            If (TypeOf txtBox Is TextBox) Then
                txtBox.Text = ""
            End If
        Next txtBox
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Salesperson Pay Calculator" & Environment.NewLine & "Programmed by: Bill Fulton",
                        "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
