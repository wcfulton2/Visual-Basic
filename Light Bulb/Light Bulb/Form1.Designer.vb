<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.greenRadioButton = New System.Windows.Forms.RadioButton()
        Me.redRadioButton = New System.Windows.Forms.RadioButton()
        Me.blueRadioButton = New System.Windows.Forms.RadioButton()
        Me.blackRadioButton = New System.Windows.Forms.RadioButton()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.offOnLabel = New System.Windows.Forms.Label()
        Me.printButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.lightBulbOn = New System.Windows.Forms.PictureBox()
        Me.lightBulbOff = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.lightBulbOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightBulbOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.greenRadioButton)
        Me.GroupBox1.Controls.Add(Me.redRadioButton)
        Me.GroupBox1.Controls.Add(Me.blueRadioButton)
        Me.GroupBox1.Controls.Add(Me.blackRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose a color"
        '
        'greenRadioButton
        '
        Me.greenRadioButton.AutoSize = True
        Me.greenRadioButton.Location = New System.Drawing.Point(6, 88)
        Me.greenRadioButton.Name = "greenRadioButton"
        Me.greenRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.greenRadioButton.TabIndex = 3
        Me.greenRadioButton.TabStop = True
        Me.greenRadioButton.Text = "&Green"
        Me.greenRadioButton.UseVisualStyleBackColor = True
        '
        'redRadioButton
        '
        Me.redRadioButton.AutoSize = True
        Me.redRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.redRadioButton.Name = "redRadioButton"
        Me.redRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.redRadioButton.TabIndex = 2
        Me.redRadioButton.TabStop = True
        Me.redRadioButton.Text = "&Red"
        Me.redRadioButton.UseVisualStyleBackColor = True
        '
        'blueRadioButton
        '
        Me.blueRadioButton.AutoSize = True
        Me.blueRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.blueRadioButton.Name = "blueRadioButton"
        Me.blueRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.blueRadioButton.TabIndex = 1
        Me.blueRadioButton.TabStop = True
        Me.blueRadioButton.Text = "B&lue"
        Me.blueRadioButton.UseVisualStyleBackColor = True
        '
        'blackRadioButton
        '
        Me.blackRadioButton.AutoSize = True
        Me.blackRadioButton.Location = New System.Drawing.Point(7, 19)
        Me.blackRadioButton.Name = "blackRadioButton"
        Me.blackRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.blackRadioButton.TabIndex = 0
        Me.blackRadioButton.TabStop = True
        Me.blackRadioButton.Text = "&Black"
        Me.blackRadioButton.UseVisualStyleBackColor = True
        '
        'nameText
        '
        Me.nameText.Location = New System.Drawing.Point(329, 13)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(182, 20)
        Me.nameText.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(13, 204)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(203, 20)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "Programmed by: Bill Fulton"
        '
        'offOnLabel
        '
        Me.offOnLabel.AutoSize = True
        Me.offOnLabel.Location = New System.Drawing.Point(326, 169)
        Me.offOnLabel.Name = "offOnLabel"
        Me.offOnLabel.Size = New System.Drawing.Size(0, 13)
        Me.offOnLabel.TabIndex = 5
        '
        'printButton
        '
        Me.printButton.Location = New System.Drawing.Point(329, 204)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(75, 23)
        Me.printButton.TabIndex = 3
        Me.printButton.Text = "&Print"
        Me.printButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(436, 204)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'lightBulbOn
        '
        Me.lightBulbOn.Image = Global.Light_Bulb.My.Resources.Resources.LightOn
        Me.lightBulbOn.Location = New System.Drawing.Point(362, 53)
        Me.lightBulbOn.Name = "lightBulbOn"
        Me.lightBulbOn.Size = New System.Drawing.Size(114, 98)
        Me.lightBulbOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lightBulbOn.TabIndex = 7
        Me.lightBulbOn.TabStop = False
        '
        'lightBulbOff
        '
        Me.lightBulbOff.Image = Global.Light_Bulb.My.Resources.Resources.LightOff
        Me.lightBulbOff.Location = New System.Drawing.Point(362, 53)
        Me.lightBulbOff.Name = "lightBulbOff"
        Me.lightBulbOff.Size = New System.Drawing.Size(114, 98)
        Me.lightBulbOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lightBulbOff.TabIndex = 8
        Me.lightBulbOff.TabStop = False
        Me.lightBulbOff.Visible = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 254)
        Me.Controls.Add(Me.lightBulbOff)
        Me.Controls.Add(Me.lightBulbOn)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.offOnLabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Light Bulb"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.lightBulbOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightBulbOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents greenRadioButton As RadioButton
    Friend WithEvents redRadioButton As RadioButton
    Friend WithEvents blueRadioButton As RadioButton
    Friend WithEvents blackRadioButton As RadioButton
    Friend WithEvents nameText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents offOnLabel As Label
    Friend WithEvents printButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents lightBulbOn As PictureBox
    Friend WithEvents lightBulbOff As PictureBox
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
