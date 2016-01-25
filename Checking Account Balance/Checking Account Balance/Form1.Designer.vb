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
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.serviceChargeRadio = New System.Windows.Forms.RadioButton()
        Me.checkRadio = New System.Windows.Forms.RadioButton()
        Me.depositRaido = New System.Windows.Forms.RadioButton()
        Me.transactionAmount = New System.Windows.Forms.TextBox()
        Me.newBalance = New System.Windows.Forms.TextBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.transactionAmountLabel = New System.Windows.Forms.Label()
        Me.newBalanceLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.serviceChargeRadio)
        Me.GroupBox1.Controls.Add(Me.checkRadio)
        Me.GroupBox1.Controls.Add(Me.depositRaido)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Type"
        '
        'serviceChargeRadio
        '
        Me.serviceChargeRadio.AutoSize = True
        Me.serviceChargeRadio.Location = New System.Drawing.Point(7, 107)
        Me.serviceChargeRadio.Name = "serviceChargeRadio"
        Me.serviceChargeRadio.Size = New System.Drawing.Size(98, 17)
        Me.serviceChargeRadio.TabIndex = 2
        Me.serviceChargeRadio.TabStop = True
        Me.serviceChargeRadio.Text = "&Service Charge"
        Me.serviceChargeRadio.UseVisualStyleBackColor = True
        '
        'checkRadio
        '
        Me.checkRadio.AutoSize = True
        Me.checkRadio.Location = New System.Drawing.Point(7, 74)
        Me.checkRadio.Name = "checkRadio"
        Me.checkRadio.Size = New System.Drawing.Size(56, 17)
        Me.checkRadio.TabIndex = 1
        Me.checkRadio.TabStop = True
        Me.checkRadio.Text = "C&heck"
        Me.checkRadio.UseVisualStyleBackColor = True
        '
        'depositRaido
        '
        Me.depositRaido.AutoSize = True
        Me.depositRaido.Location = New System.Drawing.Point(7, 37)
        Me.depositRaido.Name = "depositRaido"
        Me.depositRaido.Size = New System.Drawing.Size(61, 17)
        Me.depositRaido.TabIndex = 0
        Me.depositRaido.TabStop = True
        Me.depositRaido.Text = "&Deposit"
        Me.depositRaido.UseVisualStyleBackColor = True
        '
        'transactionAmount
        '
        Me.transactionAmount.AcceptsReturn = True
        Me.transactionAmount.Location = New System.Drawing.Point(139, 25)
        Me.transactionAmount.Name = "transactionAmount"
        Me.transactionAmount.Size = New System.Drawing.Size(145, 20)
        Me.transactionAmount.TabIndex = 2
        '
        'newBalance
        '
        Me.newBalance.Location = New System.Drawing.Point(139, 87)
        Me.newBalance.Name = "newBalance"
        Me.newBalance.ReadOnly = True
        Me.newBalance.Size = New System.Drawing.Size(145, 20)
        Me.newBalance.TabIndex = 7
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(20, 228)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(113, 23)
        Me.clearBtn.TabIndex = 4
        Me.clearBtn.Text = "C&lear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'printBtn
        '
        Me.printBtn.Location = New System.Drawing.Point(156, 199)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(113, 23)
        Me.printBtn.TabIndex = 5
        Me.printBtn.Text = "&Print"
        Me.printBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(156, 228)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(113, 23)
        Me.exitBtn.TabIndex = 6
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'calculateBtn
        '
        Me.calculateBtn.Location = New System.Drawing.Point(20, 199)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(113, 23)
        Me.calculateBtn.TabIndex = 3
        Me.calculateBtn.Text = "&Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'transactionAmountLabel
        '
        Me.transactionAmountLabel.AutoSize = True
        Me.transactionAmountLabel.Location = New System.Drawing.Point(139, 9)
        Me.transactionAmountLabel.Name = "transactionAmountLabel"
        Me.transactionAmountLabel.Size = New System.Drawing.Size(102, 13)
        Me.transactionAmountLabel.TabIndex = 1
        Me.transactionAmountLabel.Text = "&Transaction Amount"
        '
        'newBalanceLabel
        '
        Me.newBalanceLabel.AutoSize = True
        Me.newBalanceLabel.Location = New System.Drawing.Point(139, 68)
        Me.newBalanceLabel.Name = "newBalanceLabel"
        Me.newBalanceLabel.Size = New System.Drawing.Size(71, 13)
        Me.newBalanceLabel.TabIndex = 8
        Me.newBalanceLabel.Text = "New Balance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(17, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "by Bill Fulton"
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 260)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newBalanceLabel)
        Me.Controls.Add(Me.transactionAmountLabel)
        Me.Controls.Add(Me.calculateBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.printBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.newBalance)
        Me.Controls.Add(Me.transactionAmount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Checking Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents newBalanceLabel As Label
    Friend WithEvents transactionAmountLabel As Label
    Friend WithEvents calculateBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents printBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents newBalance As TextBox
    Friend WithEvents transactionAmount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents serviceChargeRadio As RadioButton
    Friend WithEvents checkRadio As RadioButton
    Friend WithEvents depositRaido As RadioButton
    Friend WithEvents Label1 As Label
End Class
