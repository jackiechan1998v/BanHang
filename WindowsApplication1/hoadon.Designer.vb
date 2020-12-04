<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnxhd = New System.Windows.Forms.Label()
        Me.txtmhd = New System.Windows.Forms.TextBox()
        Me.txtmkh = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnhienthi = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.dgvhd = New System.Windows.Forms.DataGridView()
        CType(Me.dgvhd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã khách hàng"
        '
        'txtnxhd
        '
        Me.txtnxhd.AutoSize = True
        Me.txtnxhd.Location = New System.Drawing.Point(79, 127)
        Me.txtnxhd.Name = "txtnxhd"
        Me.txtnxhd.Size = New System.Drawing.Size(127, 17)
        Me.txtnxhd.TabIndex = 2
        Me.txtnxhd.Text = "Ngày xuất hóa đơn"
        '
        'txtmhd
        '
        Me.txtmhd.Location = New System.Drawing.Point(230, 27)
        Me.txtmhd.Name = "txtmhd"
        Me.txtmhd.Size = New System.Drawing.Size(213, 22)
        Me.txtmhd.TabIndex = 3
        '
        'txtmkh
        '
        Me.txtmkh.Location = New System.Drawing.Point(230, 76)
        Me.txtmkh.Name = "txtmkh"
        Me.txtmkh.Size = New System.Drawing.Size(213, 22)
        Me.txtmkh.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(230, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(213, 22)
        Me.TextBox3.TabIndex = 5
        '
        'btnhienthi
        '
        Me.btnhienthi.Location = New System.Drawing.Point(54, 203)
        Me.btnhienthi.Name = "btnhienthi"
        Me.btnhienthi.Size = New System.Drawing.Size(75, 23)
        Me.btnhienthi.TabIndex = 6
        Me.btnhienthi.Text = "Hiển thị"
        Me.btnhienthi.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(230, 203)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Thêm"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(441, 203)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 8
        Me.btnedit.Text = "Sửa"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(630, 203)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 9
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'dgvhd
        '
        Me.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhd.Location = New System.Drawing.Point(54, 258)
        Me.dgvhd.Name = "dgvhd"
        Me.dgvhd.RowHeadersWidth = 51
        Me.dgvhd.RowTemplate.Height = 24
        Me.dgvhd.Size = New System.Drawing.Size(651, 170)
        Me.dgvhd.TabIndex = 10
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvhd)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnhienthi)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtmkh)
        Me.Controls.Add(Me.txtmhd)
        Me.Controls.Add(Me.txtnxhd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmhoadon"
        Me.Text = "Hóa Đơn"
        CType(Me.dgvhd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnxhd As Label
    Friend WithEvents txtmhd As TextBox
    Friend WithEvents txtmkh As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnhienthi As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents dgvhd As DataGridView
End Class
