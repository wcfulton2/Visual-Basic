<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flipper
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Flipper))
        Me.Dot = New System.Windows.Forms.Label()
        Me.DotImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Dot
        '
        Me.Dot.ImageIndex = 0
        Me.Dot.ImageList = Me.DotImageList
        Me.Dot.Location = New System.Drawing.Point(0, 0)
        Me.Dot.Name = "Dot"
        Me.Dot.Size = New System.Drawing.Size(32, 32)
        Me.Dot.TabIndex = 0
        '
        'DotImageList
        '
        Me.DotImageList.ImageStream = CType(resources.GetObject("DotImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DotImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.DotImageList.Images.SetKeyName(0, "yellowdot.ico")
        Me.DotImageList.Images.SetKeyName(1, "bluedot.ico")
        '
        'Flipper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Dot)
        Me.Name = "Flipper"
        Me.Size = New System.Drawing.Size(34, 34)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dot As System.Windows.Forms.Label
    Friend WithEvents DotImageList As System.Windows.Forms.ImageList

End Class
