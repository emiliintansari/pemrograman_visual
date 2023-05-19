Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim tahun, nama, tahun_skarang
            Dim umur As Integer

            nama = TextBox1.Text
            tahun = Year(DateTimePicker1.Value)
            tahun_skarang = Year(Now)
            umur = tahun_skarang - tahun
            MessageBox.Show("hallo" & nama &
                            vbNewLine & "umurkamu sekarang" & umur)
        Catch ex As Exception
            MsgBox(" isi yaaa")
        End Try

    End Sub
End Class