<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tslblkh = New System.Windows.Forms.ToolStripLabel()
        Me.tslbl1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslbllsp = New System.Windows.Forms.ToolStripLabel()
        Me.tslblhd = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblkh, Me.tslbl1, Me.ToolStripSeparator1, Me.tslbllsp, Me.tslblhd, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(815, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tslblkh
        '
        Me.tslblkh.Name = "tslblkh"
        Me.tslblkh.Size = New System.Drawing.Size(86, 22)
        Me.tslblkh.Text = "Khách hàng"
        '
        'tslbl1
        '
        Me.tslbl1.Name = "tslbl1"
        Me.tslbl1.Size = New System.Drawing.Size(75, 22)
        Me.tslbl1.Text = "Sản phẩm"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tslbllsp
        '
        Me.tslbllsp.Name = "tslbllsp"
        Me.tslbllsp.Size = New System.Drawing.Size(105, 22)
        Me.tslbllsp.Text = "Loại sản phẩm"
        '
        'tslblhd
        '
        Me.tslblhd.Name = "tslblhd"
        Me.tslblhd.Size = New System.Drawing.Size(115, 22)
        Me.tslblhd.Text = "Chi tiết hóa đơn"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel2.Text = "Hoá đơn"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cloud_computing
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(815, 522)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmmain"
        Me.Text = "Main"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslbl1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblkh As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tslbllsp As ToolStripLabel
    Friend WithEvents tslblhd As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
