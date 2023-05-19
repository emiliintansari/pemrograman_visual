Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ukp, ukv, total, prodi, jml_matkul

        If tb_nim.Text = "" Or tb_nama.Text = "" Or cb_prodi.Text = "" Or ck_akut.Text = "" Or ck_math.Text = "" Or
            ck_pmro.Text = "" Or ck_reli.Text = "" Or ck_rob.Text = "" Or ck_statis.Text = "" Then
            MsgBox("Harap Isi Semua")
        Else dt_nim.Text = tb_nim.Text
            dt_nama.Text = tb_nama.Text
            dt_prodi.Text = cb_prodi.Text
        End If

        ukp = 0
        prodi = cb_prodi.Text
        If prodi = "SI" Then
            ukp = 1200000
        ElseIf prodi = "TI" Then
            ukp = 1100000
        ElseIf prodi = "TMJ" Then
            ukp = 900000
        ElseIf prodi = "KA" Then
            ukp = 750000
        End If
        dt_ukp.Text = ukp

        jml_matkul = 0
        If ck_akut.Checked = True Then
            jml_matkul = jml_matkul + 1
        End If
        If ck_math.Checked = True Then
            jml_matkul = jml_matkul + 1
        End If
        If ck_pmro.Checked = True Then
            jml_matkul = jml_matkul + 1
        End If
        If ck_reli.Checked = True Then
            jml_matkul = jml_matkul + 1
        End If
        If ck_rob.Checked = True Then
            jml_matkul = jml_matkul + 1
        End If
        If ck_statis.Checked = True Then
            jml_matkul = jml_matkul + 1
        End If
        ukv = jml_matkul * 100000
        dt_ukv.Text = ukv

        total = ukv + ukp
        dt_total.Text = total

        dt_nama.Visible = True
        dt_nim.Visible = True
        dt_prodi.Visible = True
        dt_total.Visible = True
        dt_ukp.Visible = True
        dt_ukv.Visible = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_nama.Visible = False
        dt_nim.Visible = False
        dt_prodi.Visible = False
        dt_total.Visible = False
        dt_ukp.Visible = False
        dt_ukv.Visible = False
    End Sub
End Class
