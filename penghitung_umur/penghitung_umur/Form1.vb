Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_tanggal_skarang.Text = Format(Today(), "dd MMMM yyyy")
        tb_tanggal_skarang.ReadOnly = True
    End Sub

    Private Sub btn_buat_Click(sender As Object, e As EventArgs) Handles btn_buat.Click
        Try
            Dim jmlTahun As Integer = DateDiff(DateInterval.Year, tpk_tanggal.Value, Now)
            Dim jmlBulan As Integer = DateDiff(DateInterval.Month, tpk_tanggal.Value, Now) Mod 12
            Dim jmlHari As Integer = DateDiff(DateInterval.Day, tpk_tanggal.Value, Now) Mod 30 - 10
            Dim berat As Integer = tb_berat.Text
            MessageBox.Show(" Hallo " & tb_nama.Text & "," &
                            vbNewLine & " umurmu sekarang " & jmlTahun & " Tahun, " & jmlBulan &
                            vbNewLine & " Bulan " & " berat mu " & berat)
        Catch ex As Exception
            MessageBox.Show("isi dulu dengan lengkap")
        End Try
    End Sub
End Class
