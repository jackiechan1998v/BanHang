Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmloaisanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=DESKTOP-JUIK989\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private DBAccess As New DataBaseAccess

    'dinh nghia ham them san pham vao database
    Private Function themsp() As Boolean
        Dim lenhsql As String = "INSERT INTO LOAISANPHAM(MaLoai, TenLoai)"
        lenhsql += String.Format("VALUES('{0}','{1}')",
                                 txtmaloai.Text, txttenloai.Text)
        Return DBAccess.ExecuteNoneQuery(lenhsql)
    End Function
    'dinh nghia ham kiem tra gia tri truoc khi insert
    Private Function rong() As Boolean
        Return (String.IsNullOrEmpty(txtmaloai.Text) OrElse String.IsNullOrEmpty(txttenloai.Text))
    End Function
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "Data Source=DESKTOP-JUIK989\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaLoai as 'Mã loại' ,TenLoai as 'Tên Loại' from LOAISANPHAM", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnhienthi.Click
        Dim sqlquery As String = String.Format("select MaLoai as 'Mã loại' ,TenLoai as 'Tên Loại' from LOAISANPHAM")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlquery)
        Me.dgvlsp.DataSource = dtable
        With Me.dgvlsp
            '.Columns(0).Width = 100
            '.Columns(1).Width = 200
            '.Columns(2).Width = 200
            '.Columns(3).Width = 100
        End With
    End Sub


    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlquery As String = String.Format("select MaLoai as 'Mã loại' ,TenLoai as 'Tên Loại' from LOAISANPHAM")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlquery)
        Me.dgvlsp.DataSource = dtable
        With Me.dgvlsp
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

    Private Sub dgvkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlsp.CellContentClick
        Dim click As Integer = dgvlsp.CurrentCell.RowIndex
        txtmaloai.Text = dgvlsp.Item(0, click).Value
        txttenloai.Text = dgvlsp.Item(1, click).Value

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update LOAISANPHAM set MaLoai=@MALOAI, TenLoai=@TENLOAI where MaLoai=@MALOAI"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmaloai.Focus()
            If txtmaloai.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmaloai.Focus()
                If txttenloai.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txttenloai.Focus()

                    addupdate.Parameters.AddWithValue("@MALOAI", txtmaloai.Text)
                    addupdate.Parameters.AddWithValue("@TENLOAI", txttenloai.Text)

                    addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                    txtmaloai.Text = Nothing
                    txttenloai.Text = Nothing

                End If
                        End If
              
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvlsp.DataSource = db
        dgvlsp.DataSource = Nothing
        'searchkh(Me.txtsearch.Text)
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim delquery As String = "delete from KHACHHANG where MaKH=@MAKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmaloai.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmaloai.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAKH", txtmaloai.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtmaloai.Text = Nothing
                    txttenloai.Text = Nothing

                    txtmaloai.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvlsp.DataSource = db
        dgvlsp.DataSource = Nothing
        'searchkh(Me.txtsearch.Text)
    End Sub
End Class