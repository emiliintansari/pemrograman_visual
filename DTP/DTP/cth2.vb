Public Class cth2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim hasil As Integer

            hasil = DateDiff(DateInterval.Day, CDate(tpk_pembuatan.Text), CDate(tpk_exp.Text))
            MsgBox(" prodak " & tb_nama_produk.Text & " akan expried dalam " & hasil & " hari lagi ")
        Catch ex As Exception
            MsgBox(" Format input salah, silahkan gunakan angka")

        End Try

    End Sub
End Class