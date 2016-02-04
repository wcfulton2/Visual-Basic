Option Strict On
Public Class Form1
    Private Sub JobInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobInformationToolStripMenuItem.Click
        JobInformationForm.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        JobInformationForm.Dispose()
        Me.Dispose()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
        AboutBox1.TextBoxDescription.AppendText(String.Format("{0}{0}{0}Programmed by: Bill Fulton", Environment.NewLine))
    End Sub
End Class
