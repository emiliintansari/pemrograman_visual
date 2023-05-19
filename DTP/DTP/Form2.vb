Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selisish, denda
        selisish = DateDiff(DateInterval.Day, dtp_pinjam.Value, dtp_kembali.Value)
        If selisish > 7 Then
            denda = (selisish - 7) * 1000
            MessageBox.Show("anda terlambat " & selisish - 7 & "hari, total denda = " & denda)
        Else
            MessageBox.Show("anda tepat waktu")
        End If
    End Sub
End Class