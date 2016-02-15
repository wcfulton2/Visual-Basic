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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.leftBtn = New System.Windows.Forms.Button()
        Me.middleBtn = New System.Windows.Forms.Button()
        Me.rightBtn = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.Flipper8 = New ThinkADot.Flipper()
        Me.Flipper7 = New ThinkADot.Flipper()
        Me.Flipper6 = New ThinkADot.Flipper()
        Me.Flipper5 = New ThinkADot.Flipper()
        Me.Flipper4 = New ThinkADot.Flipper()
        Me.Flipper3 = New ThinkADot.Flipper()
        Me.Flipper2 = New ThinkADot.Flipper()
        Me.Flipper1 = New ThinkADot.Flipper()
        Me.SuspendLayout()
        '
        'leftBtn
        '
        Me.leftBtn.Location = New System.Drawing.Point(133, 34)
        Me.leftBtn.Name = "leftBtn"
        Me.leftBtn.Size = New System.Drawing.Size(75, 23)
        Me.leftBtn.TabIndex = 9
        Me.leftBtn.Text = "Left"
        Me.leftBtn.UseVisualStyleBackColor = True
        '
        'middleBtn
        '
        Me.middleBtn.Location = New System.Drawing.Point(234, 34)
        Me.middleBtn.Name = "middleBtn"
        Me.middleBtn.Size = New System.Drawing.Size(75, 23)
        Me.middleBtn.TabIndex = 10
        Me.middleBtn.Text = "Middle"
        Me.middleBtn.UseVisualStyleBackColor = True
        '
        'rightBtn
        '
        Me.rightBtn.Location = New System.Drawing.Point(338, 34)
        Me.rightBtn.Name = "rightBtn"
        Me.rightBtn.Size = New System.Drawing.Size(75, 23)
        Me.rightBtn.TabIndex = 11
        Me.rightBtn.Text = "Right"
        Me.rightBtn.UseVisualStyleBackColor = True
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(234, 343)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(75, 23)
        Me.resetBtn.TabIndex = 28
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'Flipper8
        '
        Me.Flipper8.BackColor = System.Drawing.Color.Transparent
        Me.Flipper8.Location = New System.Drawing.Point(379, 269)
        Me.Flipper8.Name = "Flipper8"
        Me.Flipper8.Size = New System.Drawing.Size(34, 34)
        Me.Flipper8.TabIndex = 19
        '
        'Flipper7
        '
        Me.Flipper7.BackColor = System.Drawing.Color.Transparent
        Me.Flipper7.Location = New System.Drawing.Point(379, 98)
        Me.Flipper7.Name = "Flipper7"
        Me.Flipper7.Size = New System.Drawing.Size(34, 34)
        Me.Flipper7.TabIndex = 18
        '
        'Flipper6
        '
        Me.Flipper6.BackColor = System.Drawing.Color.Transparent
        Me.Flipper6.Location = New System.Drawing.Point(324, 185)
        Me.Flipper6.Name = "Flipper6"
        Me.Flipper6.Size = New System.Drawing.Size(34, 34)
        Me.Flipper6.TabIndex = 17
        '
        'Flipper5
        '
        Me.Flipper5.BackColor = System.Drawing.Color.Transparent
        Me.Flipper5.Location = New System.Drawing.Point(256, 269)
        Me.Flipper5.Name = "Flipper5"
        Me.Flipper5.Size = New System.Drawing.Size(34, 34)
        Me.Flipper5.TabIndex = 16
        '
        'Flipper4
        '
        Me.Flipper4.BackColor = System.Drawing.Color.Transparent
        Me.Flipper4.Location = New System.Drawing.Point(256, 98)
        Me.Flipper4.Name = "Flipper4"
        Me.Flipper4.Size = New System.Drawing.Size(34, 34)
        Me.Flipper4.TabIndex = 15
        '
        'Flipper3
        '
        Me.Flipper3.BackColor = System.Drawing.Color.Transparent
        Me.Flipper3.Location = New System.Drawing.Point(186, 185)
        Me.Flipper3.Name = "Flipper3"
        Me.Flipper3.Size = New System.Drawing.Size(34, 34)
        Me.Flipper3.TabIndex = 14
        '
        'Flipper2
        '
        Me.Flipper2.BackColor = System.Drawing.Color.Transparent
        Me.Flipper2.Location = New System.Drawing.Point(133, 269)
        Me.Flipper2.Name = "Flipper2"
        Me.Flipper2.Size = New System.Drawing.Size(34, 34)
        Me.Flipper2.TabIndex = 13
        '
        'Flipper1
        '
        Me.Flipper1.BackColor = System.Drawing.Color.Transparent
        Me.Flipper1.Location = New System.Drawing.Point(133, 98)
        Me.Flipper1.Name = "Flipper1"
        Me.Flipper1.Size = New System.Drawing.Size(34, 34)
        Me.Flipper1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 442)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.Flipper8)
        Me.Controls.Add(Me.Flipper7)
        Me.Controls.Add(Me.Flipper6)
        Me.Controls.Add(Me.Flipper5)
        Me.Controls.Add(Me.Flipper4)
        Me.Controls.Add(Me.Flipper3)
        Me.Controls.Add(Me.Flipper2)
        Me.Controls.Add(Me.Flipper1)
        Me.Controls.Add(Me.rightBtn)
        Me.Controls.Add(Me.middleBtn)
        Me.Controls.Add(Me.leftBtn)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "ThinkADot"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leftBtn As Button
    Friend WithEvents middleBtn As Button
    Friend WithEvents rightBtn As Button
    Friend WithEvents Flipper1 As Flipper
    Friend WithEvents Flipper2 As Flipper
    Friend WithEvents Flipper3 As Flipper
    Friend WithEvents Flipper4 As Flipper
    Friend WithEvents Flipper5 As Flipper
    Friend WithEvents Flipper6 As Flipper
    Friend WithEvents Flipper7 As Flipper
    Friend WithEvents Flipper8 As Flipper
    Friend WithEvents resetBtn As Button
End Class
