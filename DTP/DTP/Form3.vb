Public Class Form3
    Private Sub chek_kendarann1()
        Dim selisihk1
        selisihk1 = DateDiff(DateInterval.Day, Now, dtp_1.Value)
        If selisihk1 > 30 Then
            lb_status_k1.Text = "masih berlaku"
            lb_status_k1.ForeColor = Color.Blue
        ElseIf selisihk1 > 0 And selisihk1 <= 30 Then
            lb_status_k1.Text = "hampir habis"
            lb_status_k1.ForeColor = Color.YellowGreen
        Else
            lb_status_k1.Text = "Habis"
            lb_status_k1.ForeColor = Color.Red
            'fore untuk text nya , backround "
        End If

    End Sub
    Private Sub chek_kendaraan2()
        Dim selisihk2
        selisihk2 = DateDiff(DateInterval.Day, Now, dtp_2.Value)
        If selisihk2 > 30 Then
            lb_status_k2.Text = "masih berlaku"
            lb_status_k2.ForeColor = Color.Blue
        ElseIf selisihk2 > 0 And selisihk2 <= 30 Then
            lb_status_k2.Text = "hampir habis"
            lb_status_k2.ForeColor = Color.YellowGreen
        Else
            lb_status_k2.Text = "Habis"
            lb_status_k2.ForeColor = Color.Red
            'fore untuk text nya , backround "
        End If
    End Sub

    Private Sub chek_kendaraan3()
        Dim selisihk3
        selisihk3 = DateDiff(DateInterval.Day, Now, dtp_3.Value)
        If selisihk3 > 30 Then
            lb_status_k3.Text = "masih berlaku"
            lb_status_k3.ForeColor = Color.Blue
        ElseIf selisihk3 > 0 And selisihk3 <= 30 Then
            lb_status_k3.Text = "hampir habis"
            lb_status_k3.ForeColor = Color.YellowGreen
        Else
            lb_status_k3.Text = "Habis"
            lb_status_k3.ForeColor = Color.Red
            'fore untuk text nya , backround "
        End If
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        chek_kendaraan3()
        chek_kendaraan2()
        chek_kendarann1()
    End Sub

    Private Sub dtp_1_ValueChanged(sender As Object, e As EventArgs) Handles dtp_1.ValueChanged
        chek_kendarann1()
    End Sub

    Private Sub dtp_2_ValueChanged(sender As Object, e As EventArgs) Handles dtp_2.ValueChanged
        chek_kendaraan2()
    End Sub

    Private Sub dtp_3_ValueChanged(sender As Object, e As EventArgs) Handles dtp_3.ValueChanged
        chek_kendaraan3()
    End Sub
End Class