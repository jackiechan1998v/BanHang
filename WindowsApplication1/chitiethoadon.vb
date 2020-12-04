Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmchitiethd
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=DESKTOP-JUIK989\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private DBAccess As New DataBaseAccess

    'dinh nghia ham them san pham vao database
    Private Function themsp() As Boolean
        Dim lenhsql As String = "INSERT INTO CHITIETHD(MaHD, MaSP, MaKH, TenKH, SoLuong)"
        lenhsql += String.Format("VALUES('{0}','{1}','{2}','{3}','{4}')",
                                 txtmahd.Text, txtmasp.Text, txtmakh.Text, txttenkh.Text, txtsoluong.Text)
        Return DBAccess.ExecuteNoneQuery(lenhsql)
    End Function
    'dinh nghia ham kiem tra gia tri truoc khi insert
    Private Function rong() As Boolean
        Return (String.IsNullOrEmpty(txtmakh.Text) OrElse String.IsNullOrEmpty(txttenkh.Text) OrElse
                String.IsNullOrEmpty(txtmahd.Text) OrElse String.IsNullOrEmpty(txtmasp.Text) OrElse String.IsNullOrEmpty(txtsoluong.Text))
    End Function
    Public Function Loadchitiethd() As DataSet
        Dim chuoiketnoi As String = "Data Source=DESKTOP-JUIK989\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaHD as 'Mã HD' ,MaSP as 'Mã sản phẩm', MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', SoLuong as 'Số lượng' from CHITIETHD", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnhienthi.Click
        Dim sqlquery As String = String.Format("select MaHD as 'Mã HD' ,MaSP as 'Mã sản phẩm', MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', SoLuong as 'Số lượng' from CHITIETHD")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlquery)
        Me.dgvcthd.DataSource = dtable
        With Me.dgvcthd
            '.Columns(0).Width = 100
            '.Columns(1).Width = 200
            '.Columns(2).Width = 200
            '.Columns(3).Width = 100
        End With
    End Sub
    Private Sub frmchitiethd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlquery As String = String.Format("select MaHD as 'Mã HD' ,MaSP as 'Mã sản phẩm', MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', SoLuong as 'Số lượng' from CHITIETHD")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlquery)
        Me.dgvcthd.DataSource = dtable
        With Me.dgvcthd
            '.Columns(0).Width = 100
            '.Columns(1).Width = 200
            '.Columns(2).Width = 200
            '.Columns(3).Width = 100
        End With
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If rong() Then
            MessageBox.Show("Thiếu dữ liệu", "Error", MessageBoxButtons.OK)
        Else
            If themsp() Then
                MessageBox.Show("Thêm dữ liệu thành công", "OK", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'searchkh(Me.txtsearch.Text)
            Else
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
        End If
    End Sub

    Private Sub dgvcthd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcthd.CellContentClick
        Dim click As Integer = dgvcthd.CurrentCell.RowIndex
        txtmahd.Text = dgvcthd.Item(0, click).Value
        txtmasp.Text = dgvcthd.Item(1, click).Value
        txtmakh.Text = dgvcthd.Item(2, click).Value
        txttenkh.Text = dgvcthd.Item(3, click).Value
        txtsoluong.Text = dgvcthd.Item(4, click).Value
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update CHITIETHD set MaHD=@MAHD, MaSP=@MASP, MaKH=@MAKH, TenKH=@TENKH, SoLuong=@SOLUONG where MaHD=@MAHD"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmahd.Focus()
            If txtmahd.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmahd.Focus()
                If txtmasp.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtmasp.Focus()
                    If txtmakh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtmakh.Focus()
                        If txttenkh.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txttenkh.Focus()
                            If txtsoluong.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập số lượng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txtsoluong.Focus()
                                addupdate.Parameters.AddWithValue("@MAHD", txtmahd.Text)
                                addupdate.Parameters.AddWithValue("@MASP", txtmasp.Text)
                                addupdate.Parameters.AddWithValue("@MAKH", txtmakh.Text)
                                addupdate.Parameters.AddWithValue("@TENKH", txttenkh.Text)
                                addupdate.Parameters.AddWithValue("@SOLUONG", txtsoluong.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtmahd.Text = Nothing
                                txtmasp.Text = Nothing
                                txtmakh.Text = Nothing
                                txttenkh.Text = Nothing
                                txtsoluong.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvcthd.DataSource = db
        dgvcthd.DataSource = Nothing
        'searchkh(Me.txtsearch.Text)
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim delquery As String = "delete from CHITIETHD where MaHD=@MAHD"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmakh.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAHD", txtmahd.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtmakh.Text = Nothing
                    txttenkh.Text = Nothing
                    txtmahd.Text = Nothing
                    txtmasp.Text = Nothing

                    txtsoluong.Text = Nothing
                    txtmahd.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvcthd.DataSource = db
        dgvcthd.DataSource = Nothing
        'searchkh(Me.txtsearch.Text)
    End Sub
End Class