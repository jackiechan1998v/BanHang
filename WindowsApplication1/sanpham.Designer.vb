<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Me.dgvsp = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.cmbsearch = New System.Windows.Forms.ComboBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txtmaloai = New System.Windows.Forms.TextBox()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltensp = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtngay = New System.Windows.Forms.TextBox()
        CType(Me.dgvsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvsp
        '
        Me.dgvsp.AllowUserToAddRows = False
        Me.dgvsp.AllowUserToDeleteRows = False
        Me.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsp.Location = New System.Drawing.Point(33, 270)
        Me.dgvsp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvsp.MultiSelect = False
        Me.dgvsp.Name = "dgvsp"
        Me.dgvsp.ReadOnly = True
        Me.dgvsp.RowHeadersWidth = 51
        Me.dgvsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvsp.Size = New System.Drawing.Size(795, 272)
        Me.dgvsp.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 213)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Hiển Thị"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Location = New System.Drawing.Point(45, 160)
        Me.lblsearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(72, 17)
        Me.lblsearch.TabIndex = 2
        Me.lblsearch.Text = "Tìm kiếm: "
        '
        'cmbsearch
        '
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Items.AddRange(New Object() {"Mã Sản Phẩm", "Tên Sản Phẩm"})
        Me.cmbsearch.Location = New System.Drawing.Point(160, 150)
        Me.cmbsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(195, 24)
        Me.cmbsearch.TabIndex = 3
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(407, 150)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(420, 22)
        Me.txtsearch.TabIndex = 4
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(277, 213)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 28)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "Thêm"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(160, 30)
        Me.txtmasp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(249, 22)
        Me.txtmasp.TabIndex = 6
        '
        'txtmaloai
        '
        Me.txtmaloai.Location = New System.Drawing.Point(551, 33)
        Me.txtmaloai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmaloai.Name = "txtmaloai"
        Me.txtmaloai.Size = New System.Drawing.Size(195, 22)
        Me.txtmaloai.TabIndex = 8
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(551, 87)
        Me.txtgia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(276, 22)
        Me.txtgia.TabIndex = 9
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(160, 79)
        Me.txttensp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(249, 22)
        Me.txttensp.TabIndex = 10
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.Location = New System.Drawing.Point(45, 33)
        Me.lblmasp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(105, 17)
        Me.lblmasp.TabIndex = 11
        Me.lblmasp.Text = "Mã sản phẩm : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(469, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mã loại : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(465, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Gía tiền : "
        '
        'lbltensp
        '
        Me.lbltensp.AutoSize = True
        Me.lbltensp.Location = New System.Drawing.Point(48, 82)
        Me.lbltensp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltensp.Name = "lbltensp"
        Me.lbltensp.Size = New System.Drawing.Size(111, 17)
        Me.lbltensp.TabIndex = 15
        Me.lbltensp.Text = "Tên sản phẩm : "
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(452, 213)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 28)
        Me.btnedit.TabIndex = 16
        Me.btnedit.Text = "Sửa "
        Me.btnedit.UseMnemonic = False
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(651, 213)
        Me.btnxoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(100, 28)
        Me.btnxoa.TabIndex = 17
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ngày SX"
        '
        'txtngay
        '
        Me.txtngay.Location = New System.Drawing.Point(160, 117)
        Me.txtngay.Name = "txtngay"
        Me.txtngay.Size = New System.Drawing.Size(249, 22)
        Me.txtngay.TabIndex = 19
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 558)
        Me.Controls.Add(Me.txtngay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.lbltensp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblmasp)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtgia)
        Me.Controls.Add(Me.txtmaloai)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.cmbsearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvsp)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmsanpham"
        Me.Text = "Sản Phẩm"
        CType(Me.dgvsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvsp As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents txtmaloai As System.Windows.Forms.TextBox
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbltensp As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtngay As TextBox
End Class
