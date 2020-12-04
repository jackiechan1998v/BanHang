<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Me.dgvkh = New System.Windows.Forms.DataGridView()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnhienthi = New System.Windows.Forms.Button()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtsodt = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.cmbsearch = New System.Windows.Forms.ComboBox()
        Me.lblsearch = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        CType(Me.dgvkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvkh
        '
        Me.dgvkh.AllowUserToAddRows = False
        Me.dgvkh.AllowUserToDeleteRows = False
        Me.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkh.Location = New System.Drawing.Point(16, 301)
        Me.dgvkh.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvkh.MultiSelect = False
        Me.dgvkh.Name = "dgvkh"
        Me.dgvkh.ReadOnly = True
        Me.dgvkh.RowHeadersWidth = 51
        Me.dgvkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvkh.Size = New System.Drawing.Size(797, 253)
        Me.dgvkh.TabIndex = 1
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(680, 239)
        Me.btnxoa.Margin = New System.Windows.Forms.Padding(4)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(100, 28)
        Me.btnxoa.TabIndex = 21
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(471, 239)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 28)
        Me.btnedit.TabIndex = 20
        Me.btnedit.Text = "Sửa "
        Me.btnedit.UseMnemonic = False
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(279, 239)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 28)
        Me.btnadd.TabIndex = 19
        Me.btnadd.Text = "Thêm"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnhienthi
        '
        Me.btnhienthi.Location = New System.Drawing.Point(91, 239)
        Me.btnhienthi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhienthi.Name = "btnhienthi"
        Me.btnhienthi.Size = New System.Drawing.Size(100, 28)
        Me.btnhienthi.TabIndex = 18
        Me.btnhienthi.Text = "Hiển Thị"
        Me.btnhienthi.UseVisualStyleBackColor = True
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.Location = New System.Drawing.Point(392, 31)
        Me.lbltenkh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(67, 17)
        Me.lbltenkh.TabIndex = 32
        Me.lbltenkh.Text = "Họ Tên : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Số dt : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Địa chỉ : "
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.Location = New System.Drawing.Point(35, 31)
        Me.lblmakh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(117, 17)
        Me.lblmakh.TabIndex = 29
        Me.lblmakh.Text = "Mã khách hàng : "
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(471, 27)
        Me.txttenkh.Margin = New System.Windows.Forms.Padding(4)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(345, 22)
        Me.txttenkh.TabIndex = 28
        '
        'txtsodt
        '
        Me.txtsodt.Location = New System.Drawing.Point(164, 76)
        Me.txtsodt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsodt.Name = "txtsodt"
        Me.txtsodt.Size = New System.Drawing.Size(195, 22)
        Me.txtsodt.TabIndex = 27
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(471, 80)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(345, 22)
        Me.txtdiachi.TabIndex = 26
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(164, 27)
        Me.txtmakh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(195, 22)
        Me.txtmakh.TabIndex = 25
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(396, 179)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(420, 22)
        Me.txtsearch.TabIndex = 24
        '
        'cmbsearch
        '
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Items.AddRange(New Object() {"Mã Khách Hàng", "Tên Khách Hàng"})
        Me.cmbsearch.Location = New System.Drawing.Point(149, 177)
        Me.cmbsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(195, 24)
        Me.cmbsearch.TabIndex = 23
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Location = New System.Drawing.Point(35, 177)
        Me.lblsearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(72, 17)
        Me.lblsearch.TabIndex = 22
        Me.lblsearch.Text = "Tìm kiếm: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Email"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(164, 125)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(195, 22)
        Me.txtemail.TabIndex = 34
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 586)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltenkh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblmakh)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtsodt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.cmbsearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnhienthi)
        Me.Controls.Add(Me.dgvkh)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmkhachhang"
        Me.Text = "Khách Hàng"
        CType(Me.dgvkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvkh As System.Windows.Forms.DataGridView
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnhienthi As System.Windows.Forms.Button
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtsodt As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemail As TextBox
End Class
