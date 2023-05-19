Public Class coba_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim x As Integer
            x = TextBox1.Text
            Do
                x = x Mod 2
                If x = 0 Then
                    MessageBox.Show("bilangan genap", "informasi")
                    Exit Do
                ElseIf x = 1 Then
                    MessageBox.Show("bilangan ganjil ", "inofrmasi")
                    Exit Do
                End If
            Loop While Not (x)
        Catch ex As Exception
            MsgBox("salah menginput data /input angka ")
        Finally
            TextBox1.Text = ""
            TextBox1.Focus()
        End Try
    End Sub
End Class