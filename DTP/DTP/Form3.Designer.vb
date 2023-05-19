<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dtp_1 = New DateTimePicker()
        dtp_2 = New DateTimePicker()
        dtp_3 = New DateTimePicker()
        btn_hitung = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lb_status_k3 = New Label()
        lb_status_k2 = New Label()
        lb_status_k1 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' dtp_1
        ' 
        dtp_1.Location = New Point(187, 100)
        dtp_1.Name = "dtp_1"
        dtp_1.Size = New Size(200, 23)
        dtp_1.TabIndex = 0
        ' 
        ' dtp_2
        ' 
        dtp_2.Location = New Point(187, 129)
        dtp_2.Name = "dtp_2"
        dtp_2.Size = New Size(200, 23)
        dtp_2.TabIndex = 1
        ' 
        ' dtp_3
        ' 
        dtp_3.Location = New Point(187, 154)
        dtp_3.Name = "dtp_3"
        dtp_3.Size = New Size(200, 23)
        dtp_3.TabIndex = 2
        ' 
        ' btn_hitung
        ' 
        btn_hitung.Location = New Point(229, 197)
        btn_hitung.Name = "btn_hitung"
        btn_hitung.Size = New Size(117, 23)
        btn_hitung.TabIndex = 3
        btn_hitung.Text = "HITUNG"
        btn_hitung.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 4
        Label1.Text = "jenis kendaraan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 5
        Label2.Text = "Kendaraan 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 6
        Label3.Text = "kendaraan 2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 7
        Label4.Text = "Kendaraan 3"
        ' 
        ' lb_status_k3
        ' 
        lb_status_k3.AutoSize = True
        lb_status_k3.Location = New Point(438, 162)
        lb_status_k3.Name = "lb_status_k3"
        lb_status_k3.Size = New Size(12, 15)
        lb_status_k3.TabIndex = 11
        lb_status_k3.Text = "-"
        ' 
        ' lb_status_k2
        ' 
        lb_status_k2.AutoSize = True
        lb_status_k2.Location = New Point(438, 135)
        lb_status_k2.Name = "lb_status_k2"
        lb_status_k2.Size = New Size(12, 15)
        lb_status_k2.TabIndex = 10
        lb_status_k2.Text = "-"
        ' 
        ' lb_status_k1
        ' 
        lb_status_k1.AutoSize = True
        lb_status_k1.Location = New Point(438, 102)
        lb_status_k1.Name = "lb_status_k1"
        lb_status_k1.Size = New Size(12, 15)
        lb_status_k1.TabIndex = 9
        lb_status_k1.Text = "-"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(438, 70)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 15)
        Label8.TabIndex = 8
        Label8.Text = "Status"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(574, 273)
        Controls.Add(lb_status_k3)
        Controls.Add(lb_status_k2)
        Controls.Add(lb_status_k1)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_hitung)
        Controls.Add(dtp_3)
        Controls.Add(dtp_2)
        Controls.Add(dtp_1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtp_1 As DateTimePicker
    Friend WithEvents dtp_2 As DateTimePicker
    Friend WithEvents dtp_3 As DateTimePicker
    Friend WithEvents btn_hitung As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_status_k3 As Label
    Friend WithEvents lb_status_k2 As Label
    Friend WithEvents lb_status_k1 As Label
    Friend WithEvents Label8 As Label
End Class
