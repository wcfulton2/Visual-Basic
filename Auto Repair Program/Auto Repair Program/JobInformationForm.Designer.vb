<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobInformationForm
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
        Me.jobNumberTxt = New System.Windows.Forms.TextBox()
        Me.customerNameTxt = New System.Windows.Forms.TextBox()
        Me.wholesalePartsTxt = New System.Windows.Forms.TextBox()
        Me.hoursOfLaborTxt = New System.Windows.Forms.TextBox()
        Me.jobNumberLbl = New System.Windows.Forms.Label()
        Me.customerNameLbl = New System.Windows.Forms.Label()
        Me.wholesalePartsLbl = New System.Windows.Forms.Label()
        Me.hoursOfLaborLbl = New System.Windows.Forms.Label()
        Me.partsTotalTxt = New System.Windows.Forms.TextBox()
        Me.laborTotalTxt = New System.Windows.Forms.TextBox()
        Me.subtotalTxt = New System.Windows.Forms.TextBox()
        Me.salesTaxTxt = New System.Windows.Forms.TextBox()
        Me.totalTxt = New System.Windows.Forms.TextBox()
        Me.partsTotalLbl = New System.Windows.Forms.Label()
        Me.laborTotalLbl = New System.Windows.Forms.Label()
        Me.subtotalLbl = New System.Windows.Forms.Label()
        Me.salesTaxLbl = New System.Windows.Forms.Label()
        Me.totalLbl = New System.Windows.Forms.Label()
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'jobNumberTxt
        '
        Me.jobNumberTxt.Location = New System.Drawing.Point(92, 38)
        Me.jobNumberTxt.Name = "jobNumberTxt"
        Me.jobNumberTxt.Size = New System.Drawing.Size(100, 20)
        Me.jobNumberTxt.TabIndex = 0
        '
        'customerNameTxt
        '
        Me.customerNameTxt.Location = New System.Drawing.Point(92, 12)
        Me.customerNameTxt.Name = "customerNameTxt"
        Me.customerNameTxt.Size = New System.Drawing.Size(100, 20)
        Me.customerNameTxt.TabIndex = 1
        '
        'wholesalePartsTxt
        '
        Me.wholesalePartsTxt.Location = New System.Drawing.Point(92, 64)
        Me.wholesalePartsTxt.Name = "wholesalePartsTxt"
        Me.wholesalePartsTxt.Size = New System.Drawing.Size(100, 20)
        Me.wholesalePartsTxt.TabIndex = 2
        '
        'hoursOfLaborTxt
        '
        Me.hoursOfLaborTxt.Location = New System.Drawing.Point(92, 90)
        Me.hoursOfLaborTxt.Name = "hoursOfLaborTxt"
        Me.hoursOfLaborTxt.Size = New System.Drawing.Size(100, 20)
        Me.hoursOfLaborTxt.TabIndex = 3
        '
        'jobNumberLbl
        '
        Me.jobNumberLbl.AutoSize = True
        Me.jobNumberLbl.Location = New System.Drawing.Point(7, 41)
        Me.jobNumberLbl.Name = "jobNumberLbl"
        Me.jobNumberLbl.Size = New System.Drawing.Size(67, 13)
        Me.jobNumberLbl.TabIndex = 4
        Me.jobNumberLbl.Text = "&Job Number:"
        '
        'customerNameLbl
        '
        Me.customerNameLbl.AutoSize = True
        Me.customerNameLbl.Location = New System.Drawing.Point(7, 15)
        Me.customerNameLbl.Name = "customerNameLbl"
        Me.customerNameLbl.Size = New System.Drawing.Size(85, 13)
        Me.customerNameLbl.TabIndex = 5
        Me.customerNameLbl.Text = "C&ustomer Name:"
        '
        'wholesalePartsLbl
        '
        Me.wholesalePartsLbl.AutoSize = True
        Me.wholesalePartsLbl.Location = New System.Drawing.Point(7, 67)
        Me.wholesalePartsLbl.Name = "wholesalePartsLbl"
        Me.wholesalePartsLbl.Size = New System.Drawing.Size(73, 13)
        Me.wholesalePartsLbl.TabIndex = 6
        Me.wholesalePartsLbl.Text = "&Price of Parts:"
        '
        'hoursOfLaborLbl
        '
        Me.hoursOfLaborLbl.AutoSize = True
        Me.hoursOfLaborLbl.Location = New System.Drawing.Point(7, 93)
        Me.hoursOfLaborLbl.Name = "hoursOfLaborLbl"
        Me.hoursOfLaborLbl.Size = New System.Drawing.Size(80, 13)
        Me.hoursOfLaborLbl.TabIndex = 7
        Me.hoursOfLaborLbl.Text = "&Hours of Labor:"
        '
        'partsTotalTxt
        '
        Me.partsTotalTxt.Location = New System.Drawing.Point(92, 260)
        Me.partsTotalTxt.Name = "partsTotalTxt"
        Me.partsTotalTxt.ReadOnly = True
        Me.partsTotalTxt.Size = New System.Drawing.Size(100, 20)
        Me.partsTotalTxt.TabIndex = 8
        '
        'laborTotalTxt
        '
        Me.laborTotalTxt.Location = New System.Drawing.Point(92, 178)
        Me.laborTotalTxt.Name = "laborTotalTxt"
        Me.laborTotalTxt.ReadOnly = True
        Me.laborTotalTxt.Size = New System.Drawing.Size(100, 20)
        Me.laborTotalTxt.TabIndex = 9
        '
        'subtotalTxt
        '
        Me.subtotalTxt.Location = New System.Drawing.Point(92, 207)
        Me.subtotalTxt.Name = "subtotalTxt"
        Me.subtotalTxt.ReadOnly = True
        Me.subtotalTxt.Size = New System.Drawing.Size(100, 20)
        Me.subtotalTxt.TabIndex = 10
        '
        'salesTaxTxt
        '
        Me.salesTaxTxt.Location = New System.Drawing.Point(92, 234)
        Me.salesTaxTxt.Name = "salesTaxTxt"
        Me.salesTaxTxt.ReadOnly = True
        Me.salesTaxTxt.Size = New System.Drawing.Size(100, 20)
        Me.salesTaxTxt.TabIndex = 11
        '
        'totalTxt
        '
        Me.totalTxt.Location = New System.Drawing.Point(92, 291)
        Me.totalTxt.Name = "totalTxt"
        Me.totalTxt.ReadOnly = True
        Me.totalTxt.Size = New System.Drawing.Size(100, 20)
        Me.totalTxt.TabIndex = 12
        '
        'partsTotalLbl
        '
        Me.partsTotalLbl.AutoSize = True
        Me.partsTotalLbl.Location = New System.Drawing.Point(7, 263)
        Me.partsTotalLbl.Name = "partsTotalLbl"
        Me.partsTotalLbl.Size = New System.Drawing.Size(64, 13)
        Me.partsTotalLbl.TabIndex = 13
        Me.partsTotalLbl.Text = "Pa&rts + Tax:"
        '
        'laborTotalLbl
        '
        Me.laborTotalLbl.AutoSize = True
        Me.laborTotalLbl.Location = New System.Drawing.Point(7, 181)
        Me.laborTotalLbl.Name = "laborTotalLbl"
        Me.laborTotalLbl.Size = New System.Drawing.Size(61, 13)
        Me.laborTotalLbl.TabIndex = 14
        Me.laborTotalLbl.Text = "&Labor Cost:"
        '
        'subtotalLbl
        '
        Me.subtotalLbl.AutoSize = True
        Me.subtotalLbl.Location = New System.Drawing.Point(7, 210)
        Me.subtotalLbl.Name = "subtotalLbl"
        Me.subtotalLbl.Size = New System.Drawing.Size(49, 13)
        Me.subtotalLbl.TabIndex = 15
        Me.subtotalLbl.Text = "&Subtotal:"
        '
        'salesTaxLbl
        '
        Me.salesTaxLbl.AutoSize = True
        Me.salesTaxLbl.Location = New System.Drawing.Point(7, 237)
        Me.salesTaxLbl.Name = "salesTaxLbl"
        Me.salesTaxLbl.Size = New System.Drawing.Size(57, 13)
        Me.salesTaxLbl.TabIndex = 16
        Me.salesTaxLbl.Text = "S&ales Tax:"
        '
        'totalLbl
        '
        Me.totalLbl.AutoSize = True
        Me.totalLbl.Location = New System.Drawing.Point(7, 294)
        Me.totalLbl.Name = "totalLbl"
        Me.totalLbl.Size = New System.Drawing.Size(34, 13)
        Me.totalLbl.TabIndex = 17
        Me.totalLbl.Text = "T&otal:"
        '
        'calculateBtn
        '
        Me.calculateBtn.Location = New System.Drawing.Point(14, 353)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(75, 23)
        Me.calculateBtn.TabIndex = 18
        Me.calculateBtn.Text = "&Calculate"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(105, 353)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 19
        Me.clearBtn.Text = "Clea&r"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(196, 353)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(75, 23)
        Me.okBtn.TabIndex = 20
        Me.okBtn.Text = "O&K"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'JobInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 388)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.calculateBtn)
        Me.Controls.Add(Me.totalLbl)
        Me.Controls.Add(Me.salesTaxLbl)
        Me.Controls.Add(Me.subtotalLbl)
        Me.Controls.Add(Me.laborTotalLbl)
        Me.Controls.Add(Me.partsTotalLbl)
        Me.Controls.Add(Me.totalTxt)
        Me.Controls.Add(Me.salesTaxTxt)
        Me.Controls.Add(Me.subtotalTxt)
        Me.Controls.Add(Me.laborTotalTxt)
        Me.Controls.Add(Me.partsTotalTxt)
        Me.Controls.Add(Me.hoursOfLaborLbl)
        Me.Controls.Add(Me.wholesalePartsLbl)
        Me.Controls.Add(Me.customerNameLbl)
        Me.Controls.Add(Me.jobNumberLbl)
        Me.Controls.Add(Me.hoursOfLaborTxt)
        Me.Controls.Add(Me.wholesalePartsTxt)
        Me.Controls.Add(Me.customerNameTxt)
        Me.Controls.Add(Me.jobNumberTxt)
        Me.Name = "JobInformationForm"
        Me.Text = "JobInformationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jobNumberTxt As TextBox
    Friend WithEvents customerNameTxt As TextBox
    Friend WithEvents wholesalePartsTxt As TextBox
    Friend WithEvents hoursOfLaborTxt As TextBox
    Friend WithEvents jobNumberLbl As Label
    Friend WithEvents customerNameLbl As Label
    Friend WithEvents wholesalePartsLbl As Label
    Friend WithEvents hoursOfLaborLbl As Label
    Friend WithEvents partsTotalTxt As TextBox
    Friend WithEvents laborTotalTxt As TextBox
    Friend WithEvents subtotalTxt As TextBox
    Friend WithEvents salesTaxTxt As TextBox
    Friend WithEvents totalTxt As TextBox
    Friend WithEvents partsTotalLbl As Label
    Friend WithEvents laborTotalLbl As Label
    Friend WithEvents subtotalLbl As Label
    Friend WithEvents salesTaxLbl As Label
    Friend WithEvents totalLbl As Label
    Friend WithEvents calculateBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents okBtn As Button
End Class
