<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tpk_tanggal = New DateTimePicker()
        tb_berat = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btn_buat = New Button()
        tb_tanggal_skarang = New TextBox()
        tb_nama = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' tpk_tanggal
        ' 
        tpk_tanggal.Location = New Point(91, 69)
        tpk_tanggal.Name = "tpk_tanggal"
        tpk_tanggal.Size = New Size(200, 23)
        tpk_tanggal.TabIndex = 0
        ' 
        ' tb_berat
        ' 
        tb_berat.Location = New Point(91, 97)
        tb_berat.Name = "tb_berat"
        tb_berat.Size = New Size(200, 23)
        tb_berat.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Location = New Point(9, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 2
        Label1.Text = "Tanggal_lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Location = New Point(12, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 3
        Label2.Text = "berat mu"
        ' 
        ' btn_buat
        ' 
        btn_buat.BackColor = Color.FromArgb(CByte(22), CByte(255), CByte(0))
        btn_buat.Location = New Point(26, 137)
        btn_buat.Name = "btn_buat"
        btn_buat.Size = New Size(254, 23)
        btn_buat.TabIndex = 4
        btn_buat.Text = "GO"
        btn_buat.UseVisualStyleBackColor = False
        ' 
        ' tb_tanggal_skarang
        ' 
        tb_tanggal_skarang.Location = New Point(9, 11)
        tb_tanggal_skarang.Name = "tb_tanggal_skarang"
        tb_tanggal_skarang.Size = New Size(282, 23)
        tb_tanggal_skarang.TabIndex = 5
        ' 
        ' tb_nama
        ' 
        tb_nama.Location = New Point(91, 40)
        tb_nama.Name = "tb_nama"
        tb_nama.Size = New Size(200, 23)
        tb_nama.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Location = New Point(9, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 7
        Label3.Text = "Nama"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(304, 167)
        Controls.Add(Label3)
        Controls.Add(tb_nama)
        Controls.Add(tb_tanggal_skarang)
        Controls.Add(btn_buat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tb_berat)
        Controls.Add(tpk_tanggal)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tpk_tanggal As DateTimePicker
    Friend WithEvents tb_berat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buat As Button
    Friend WithEvents tb_tanggal_skarang As TextBox
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents Label3 As Label
End Class
