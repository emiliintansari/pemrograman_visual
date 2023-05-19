Public Class _2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dus, stokkeluar, box, boxx

        dus = Integer.Parse(tb_stokdus.Text)
        stokkeluar = Integer.Parse(tb_stokkeluar.Text)
        boxx = cbx_stauan.Text
        box = Integer.Parse(tb_stokbox.Text)

        If boxx = "Dus" Then
            If dus < stokkeluar Then
                MessageBox.Show("Stok tidak mencukupi")
            Else
                dus = dus - stokkeluar
                tb_stokdus.Text = dus
                MessageBox.Show("Stok berhasi diupdate")
                tb_stokkeluar.Text = ""
            End If
        ElseIf boxx = "Box" Then
            If box < stokkeluar Then
                If dus > 0 Then
                    box = box + 20
                    dus = dus - 1
                    box = box - stokkeluar
                    tb_stokdus.Text = dus
                    tb_stokbox.Text = box
                    MessageBox.Show("Stok berhasi diupdate")
                    tb_stokkeluar.Text = ""
                Else
                    MessageBox.Show("Stok tidak cukup")
                End If
            Else
                box = box - stokkeluar
                tb_stokbox.Text = box
                MessageBox.Show("Stok berhasi diupdate")
                tb_stokkeluar.Text = ""
            End If
        End If
    End Sub
End Class