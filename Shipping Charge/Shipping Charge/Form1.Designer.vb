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
        Me.packageID = New System.Windows.Forms.MaskedTextBox()
        Me.inputPounds = New System.Windows.Forms.TextBox()
        Me.inputOunces = New System.Windows.Forms.TextBox()
        Me.totalCost = New System.Windows.Forms.TextBox()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.poundsError = New System.Windows.Forms.Label()
        Me.ouncesError = New System.Windows.Forms.Label()
        Me.idError = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'packageID
        '
        Me.packageID.Location = New System.Drawing.Point(51, 149)
        Me.packageID.Mask = "000000"
        Me.packageID.Name = "packageID"
        Me.packageID.Size = New System.Drawing.Size(145, 20)
        Me.packageID.TabIndex = 5
        '
        'inputPounds
        '
        Me.inputPounds.Location = New System.Drawing.Point(51, 25)
        Me.inputPounds.Name = "inputPounds"
        Me.inputPounds.Size = New System.Drawing.Size(145, 20)
        Me.inputPounds.TabIndex = 1
        '
        'inputOunces
        '
        Me.inputOunces.Location = New System.Drawing.Point(51, 85)
        Me.inputOunces.Name = "inputOunces"
        Me.inputOunces.Size = New System.Drawing.Size(145, 20)
        Me.inputOunces.TabIndex = 3
        '
        'totalCost
        '
        Me.totalCost.Location = New System.Drawing.Point(51, 215)
        Me.totalCost.Name = "totalCost"
        Me.totalCost.ReadOnly = True
        Me.totalCost.Size = New System.Drawing.Size(145, 20)
        Me.totalCost.TabIndex = 11
        '
        'calculateBtn
        '
        Me.calculateBtn.Location = New System.Drawing.Point(12, 267)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(94, 23)
        Me.calculateBtn.TabIndex = 6
        Me.calculateBtn.Text = "&Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(12, 296)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(94, 23)
        Me.clearBtn.TabIndex = 7
        Me.clearBtn.Text = "C&lear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'printBtn
        '
        Me.printBtn.Location = New System.Drawing.Point(130, 267)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(94, 23)
        Me.printBtn.TabIndex = 8
        Me.printBtn.Text = "&Print"
        Me.printBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(130, 296)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(94, 23)
        Me.exitBtn.TabIndex = 9
        Me.exitBtn.Text = "E&xit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Total Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Package &ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "O&unces"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(105, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "P&ounds"
        '
        'poundsError
        '
        Me.poundsError.AutoSize = True
        Me.poundsError.ForeColor = System.Drawing.Color.Red
        Me.poundsError.Location = New System.Drawing.Point(52, 48)
        Me.poundsError.Name = "poundsError"
        Me.poundsError.Size = New System.Drawing.Size(0, 13)
        Me.poundsError.TabIndex = 12
        '
        'ouncesError
        '
        Me.ouncesError.AutoSize = True
        Me.ouncesError.ForeColor = System.Drawing.Color.Red
        Me.ouncesError.Location = New System.Drawing.Point(52, 108)
        Me.ouncesError.Name = "ouncesError"
        Me.ouncesError.Size = New System.Drawing.Size(0, 13)
        Me.ouncesError.TabIndex = 13
        '
        'idError
        '
        Me.idError.AutoSize = True
        Me.idError.ForeColor = System.Drawing.Color.Red
        Me.idError.Location = New System.Drawing.Point(52, 172)
        Me.idError.Name = "idError"
        Me.idError.Size = New System.Drawing.Size(0, 13)
        Me.idError.TabIndex = 14
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "by Bill Fulton"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 359)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.idError)
        Me.Controls.Add(Me.ouncesError)
        Me.Controls.Add(Me.poundsError)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.printBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.calculateBtn)
        Me.Controls.Add(Me.totalCost)
        Me.Controls.Add(Me.inputOunces)
        Me.Controls.Add(Me.inputPounds)
        Me.Controls.Add(Me.packageID)
        Me.Name = "Form1"
        Me.Text = "Shipping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents packageID As MaskedTextBox
    Friend WithEvents inputPounds As TextBox
    Friend WithEvents inputOunces As TextBox
    Friend WithEvents totalCost As TextBox
    Friend WithEvents calculateBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents printBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents poundsError As Label
    Friend WithEvents ouncesError As Label
    Friend WithEvents idError As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Label5 As Label
End Class
