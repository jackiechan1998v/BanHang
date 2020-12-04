Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmhoadon
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=DESKTOP-JUIK989\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private DBAccess As New DataBaseAccess

    'dinh nghia ham them san pham vao database
    Private Function themsp() As Boolean
        Dim lenhsql As String = "INSERT INTO HOADON(MaHD, MaKH, NgayXuatHD)"
        lenhsql += String.Format("VALUES('{0}','{1}','{2}')",
                                 txtmhd.Text, txtmkh.Text, txtnxhd.Text)
        Return DBAccess.ExecuteNoneQuery(lenhsql)
    End Function
    'dinh nghia ham kiem tra gia tri truoc khi insert
    Private Function rong() As Boolean
        Return (String.IsNullOrEmpty(txtmhd.Text) OrElse String.IsNullOrEmpty(txtmkh.Text) OrElse
                String.IsNullOrEmpty(txtnxhd.Text))
    End Function
    Public Function Loadhoadon() As DataSet
        Dim chuoiketnoi As String = "Data Source=DESKTOP-JUIK989\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaHD as 'Mã Hóa Đơn' ,MaKH as 'Mã Khách Hàng', NgayXuatHD as 'Ngày xuất hóa đơn' from HOADON", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnhienthi.Click
        Dim sqlquery As String = String.Format("select MaHD as 'Mã Hóa Đơn' ,MaKH as 'Mã Khách Hàng', NgayXuatHD as 'Ngày xuất hóa đơn' from HOADON")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlquery)
        Me.dgvhd.DataSource = dtable
        With Me.dgvhd
            '.Columns(0).Width = 100
            '.Columns(1).Width = 200
            '.Columns(2).Width = 200
            '.Columns(3).Width = 100
        End With
    End Sub


    Private Sub frmhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlquery As String = String.Format("select MaHD as 'Mã Hóa Đơn' ,MaKH as 'Mã Khách Hàng', NgayXuatHD as 'Ngày xuất hóa đơn' from HOADON")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlquery)
        Me.dgvhd.DataSource = dtable
        With Me.dgvhd
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

    Private Sub dgvkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvhd.CellContentClick
        Dim click As Integer = dgvhd.CurrentCell.RowIndex
        txtmhd.Text = dgvhd.Item(0, click).Value
        txtmkh.Text = dgvhd.Item(1, click).Value
        txtnxhd.Text = dgvhd.Item(2, click).Value
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update HOADON set MaHD=@MAHD, MaKH=@MAKH, NgayXuatHD=@NGAYXUATHD where MaHD=@MAHD"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmhd.Focus()
            If txtmhd.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmhd.Focus()
                If txtmkh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtmkh.Focus()
                    If txtnxhd.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtnxhd.Focus()


                        addupdate.Parameters.AddWithValue("@MAHD", txtmhd.Text)
                        addupdate.Parameters.AddWithValue("@MAKH", txtmkh.Text)
                        addupdate.Parameters.AddWithValue("@NGAYXUATHD", txtnxhd.Text)

                        addupdate.ExecuteNonQuery()
                        conn.Close() 'đóng kết nối
                        MessageBox.Show("Cập nhật thành công")
                        txtmhd.Text = Nothing
                        txtmkh.Text = Nothing
                        txtnxhd.Text = Nothing
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvhd.DataSource = db
        dgvhd.DataSource = Nothing
        'searchkh(Me.txtsearch.Text)
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim delquery As String = "delete from HOADON where MaHD=@MAHD"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmhd.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmhd.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MAKH", txtmhd.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtmhd.Text = Nothing
                    txtmkh.Text = Nothing
                    txtnxhd.Text = Nothing

                    txtmhd.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvhd.DataSource = db
        dgvhd.DataSource = Nothing
        'searchkh(Me.txtsearch.Text)
    End Sub
End Class