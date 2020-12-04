Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "Data Source=DESKTOP-JUIK989\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SoDT as 'SĐT', Email as 'Email' from KHACHHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "Data Source=DESKTOP-JUIK989\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SANPHAM.MaSP as 'Mã sản phẩm',SANPHAM.maloai as 'Mã Loại', SANPHAM.tensp as 'Tên sản phẩm',  gia as 'Gía Tiền', SANPHAM.NgaySX as 'Ngày SX', from SANPHAM ", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class