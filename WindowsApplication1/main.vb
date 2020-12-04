Public Class frmmain

    Private Sub tslbl1_Click(sender As Object, e As EventArgs) Handles tslbl1.Click
        frmsanpham.Show()

    End Sub

    Private Sub tslblkh_Click(sender As Object, e As EventArgs) Handles tslblkh.Click
        frmkhachhang.Show()
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tslbllsp_Click(sender As Object, e As EventArgs) Handles tslbllsp.Click
        frmloaisanpham.Show()
    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        frmhoadon.Show()
    End Sub

    Private Sub tslblhd_Click(sender As Object, e As EventArgs) Handles tslblhd.Click
        frmchitiethd.Show()
    End Sub
End Class
