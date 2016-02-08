''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Program Name: Auto Repair Program
'Description: Calculate job total and display relevent information for
'             a hypothetical auto repair shop
'Programmed by: Bill Fulton
'Class: CIS 310 Online
'Date: 02 February 2016 - Winter 2016
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On

Public Class MainForm
    Private Sub JobInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobInformationToolStripMenuItem.Click 'click event for the Job Information 
        JobInformationForm.Show() 'show the JobInformationForm                                                                        'menu item - Process Menu
        Me.Hide() 'hide the main form
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click 'click event for the Exit menu item - File Menu
        JobInformationForm.Dispose() 'Close JobInformationForm
        Me.Dispose() 'Close MainForm
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click 'click event for the About menu item - Help Menu
        AboutForm.Show() 'Display the AboutForm
        AboutForm.TextBoxDescription.AppendText(String.Format("{0}{0}{0}Programmed by: Bill Fulton", Environment.NewLine)) 'Add my name to the description box
    End Sub
End Class
