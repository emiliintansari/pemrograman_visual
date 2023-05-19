Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim replace
    Dim angka_1 = 0
    Dim op
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_otput.Text = "0"
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "1"
            replace = False
        Else
            lbl_otput.Text = lbl_otput.Text & "1"
        End If
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "2"
            replace = False
        Else
            lbl_otput.Text = lbl_otput.Text & "2"
        End If
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "3"
            replace = False
        Else
            lbl_otput.Text = lbl_otput.Text & "3"
        End If
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "4"
            replace = False
        Else
            lbl_otput.Text = lbl_otput.Text & "4"
        End If
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "5"
        Else
            lbl_otput.Text = lbl_otput.Text & "5"
        End If
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "6"
            replace = False
        Else
            lbl_otput.Text = lbl_otput.Text & "6"
        End If
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "7"
            replace = False
        Else
            lbl_otput.Text = lbl_otput.Text & "7"
        End If
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "8"
            replace = False
        Else
            lbl_otput.Text = lbl_otput.Text & "8"
        End If
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "9"
            replace = False
        Else
            lbl_otput.Text = lbl_otput.Text & "9"
        End If
    End Sub

    Private Sub btn_nol_Click(sender As Object, e As EventArgs) Handles btn_nol.Click
        If lbl_otput.Text = "0" Or replace = True Then
            lbl_otput.Text = "0"
        Else
            lbl_otput.Text = lbl_otput.Text & "0"
        End If
    End Sub

    Private Sub btn_smdngn_Click(sender As Object, e As EventArgs) Handles btn_smdngn.Click
        If op = "+" Then
            lbl_otput.Text = Decimal.Parse(angka_1) + Decimal.Parse(lbl_otput.Text)
            replace = True
        ElseIf op = "-" Then
            lbl_otput.Text = Decimal.Parse(angka_1) - Decimal.Parse(lbl_otput.Text)
            replace = True
        ElseIf op = "*" Then
            lbl_otput.Text = Decimal.Parse(angka_1) * Decimal.Parse(lbl_otput.Text)
            replace = True
        ElseIf op = "/" Then
            lbl_otput.Text = Decimal.Parse(angka_1) / Decimal.Parse(lbl_otput.Text)
            replace = True
        End If

    End Sub
    Private Sub btn_tmbh_Click(sender As Object, e As EventArgs) Handles btn_tmbh.Click
        replace = True
        angka_1 = lbl_otput.Text
        op = "+"
    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click
        replace = True
        angka_1 = lbl_otput.Text
        op = "-"
    End Sub

    Private Sub btn_x_Click(sender As Object, e As EventArgs) Handles btn_x.Click
        replace = True
        angka_1 = lbl_otput.Text
        op = "*"
    End Sub

    Private Sub btn_bgi_Click(sender As Object, e As EventArgs) Handles btn_bgi.Click
        replace = True
        angka_1 = lbl_otput.Text
        op = "/"
    End Sub

    Private Sub btn_c_Click(sender As Object, e As EventArgs) Handles btn_c.Click
        lbl_otput.Text = "0"
        angka_1 = "0"
        op = ""
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        If lbl_otput.Text.Length > 0 Then
            lbl_otput.Text = lbl_otput.Text.Substring(0, lbl_otput.Text.Length - 1)
        End If
    End Sub

    Private Sub btn_koma_Click(sender As Object, e As EventArgs) Handles btn_koma.Click
        If lbl_otput.Text <> "0" Then
            lbl_otput.Text += ","
        Else
            lbl_otput.Text = ","
        End If
    End Sub

    Private Sub btn_plsmin_Click(sender As Object, e As EventArgs) Handles btn_plsmin.Click
        lbl_otput.Text = -1 * (lbl_otput.Text)
    End Sub


End Class
