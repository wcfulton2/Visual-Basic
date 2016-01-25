'A simple program that changes a light bulb image from off to on when clicked
'Also gives the user the ability to: enter a name to personalize a displayed message; change the color of the displayed message;
'print; exit

Public Class Form1
    Private Sub lightBulbOn_Click(sender As Object, e As EventArgs) Handles lightBulbOn.Click 'Switch from light on(default) to light off
        lightBulbOn.Visible = False
        lightBulbOff.Visible = True
        offOnLabel.Text = "Turn the light on " + nameText.Text 'modify displayed message when light is switched to off
    End Sub

    Private Sub lightBulbOff_Click(sender As Object, e As EventArgs) Handles lightBulbOff.Click 'Switch from light off to light on
        lightBulbOn.Visible = True
        lightBulbOff.Visible = False
        offOnLabel.Text = "Turn the light off " + nameText.Text 'modify displayed message when light is switched to on
    End Sub

    Private Sub blackRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles blackRadioButton.CheckedChanged 'change message color to black
        offOnLabel.ForeColor = Color.Black
    End Sub

    Private Sub blueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles blueRadioButton.CheckedChanged 'change message color to blue
        offOnLabel.ForeColor = Color.Blue
    End Sub

    Private Sub redRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles redRadioButton.CheckedChanged 'change message color to Red
        offOnLabel.ForeColor = Color.Red
    End Sub

    Private Sub greenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles greenRadioButton.CheckedChanged 'change message color to Green
        offOnLabel.ForeColor = Color.Green
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click 'Display print dialog
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click 'Exit the program
        Close()
    End Sub
End Class
