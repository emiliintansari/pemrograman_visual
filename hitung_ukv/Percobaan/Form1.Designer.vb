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
        Button1 = New Button()
        cb_prodi = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        tb_nama = New TextBox()
        tb_nim = New TextBox()
        GroupBox1 = New GroupBox()
        ck_pmro = New CheckBox()
        ck_akut = New CheckBox()
        ck_rob = New CheckBox()
        ck_statis = New CheckBox()
        ck_reli = New CheckBox()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        ck_math = New CheckBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        dt_nim = New Label()
        dt_nama = New Label()
        dt_prodi = New Label()
        dt_ukp = New Label()
        dt_ukv = New Label()
        dt_total = New Label()
        GroupBox3 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(88, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(393, 23)
        Button1.TabIndex = 0
        Button1.Text = "START"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cb_prodi
        ' 
        cb_prodi.FormattingEnabled = True
        cb_prodi.Items.AddRange(New Object() {"SI", "TI", "KA", "TMJ"})
        cb_prodi.Location = New Point(95, 137)
        cb_prodi.Name = "cb_prodi"
        cb_prodi.Size = New Size(230, 23)
        cb_prodi.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(152), CByte(223), CByte(214))
        Label1.Location = New Point(21, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 2
        Label1.Text = "Prodi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(152), CByte(223), CByte(214))
        Label2.Location = New Point(21, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 3
        Label2.Text = "Nim"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(152), CByte(223), CByte(214))
        Label3.Location = New Point(19, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 4
        Label3.Text = "Nama"
        ' 
        ' tb_nama
        ' 
        tb_nama.Location = New Point(94, 19)
        tb_nama.Name = "tb_nama"
        tb_nama.Size = New Size(235, 23)
        tb_nama.TabIndex = 5
        ' 
        ' tb_nim
        ' 
        tb_nim.Location = New Point(95, 79)
        tb_nim.Name = "tb_nim"
        tb_nim.Size = New Size(234, 23)
        tb_nim.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(35), CByte(91))
        GroupBox1.Controls.Add(tb_nim)
        GroupBox1.Controls.Add(tb_nama)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cb_prodi)
        GroupBox1.Location = New Point(4, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(351, 188)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' ck_pmro
        ' 
        ck_pmro.AutoSize = True
        ck_pmro.Location = New Point(7, 36)
        ck_pmro.Name = "ck_pmro"
        ck_pmro.Size = New Size(102, 19)
        ck_pmro.TabIndex = 8
        ck_pmro.Text = "Pemrograman"
        ck_pmro.UseVisualStyleBackColor = True
        ' 
        ' ck_akut
        ' 
        ck_akut.AutoSize = True
        ck_akut.Location = New Point(7, 61)
        ck_akut.Name = "ck_akut"
        ck_akut.Size = New Size(72, 19)
        ck_akut.TabIndex = 9
        ck_akut.Text = "Akutansi"
        ck_akut.UseVisualStyleBackColor = True
        ' 
        ' ck_rob
        ' 
        ck_rob.AutoSize = True
        ck_rob.Location = New Point(7, 86)
        ck_rob.Name = "ck_rob"
        ck_rob.Size = New Size(67, 19)
        ck_rob.TabIndex = 10
        ck_rob.Text = "Robotik"
        ck_rob.UseVisualStyleBackColor = True
        ' 
        ' ck_statis
        ' 
        ck_statis.AutoSize = True
        ck_statis.Location = New Point(7, 111)
        ck_statis.Name = "ck_statis"
        ck_statis.Size = New Size(73, 19)
        ck_statis.TabIndex = 11
        ck_statis.Text = "Statistika"
        ck_statis.UseVisualStyleBackColor = True
        ' 
        ' ck_reli
        ' 
        ck_reli.AutoSize = True
        ck_reli.Location = New Point(7, 136)
        ck_reli.Name = "ck_reli"
        ck_reli.Size = New Size(85, 19)
        ck_reli.TabIndex = 12
        ck_reli.Text = "Religiusitas"
        ck_reli.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 13
        Label4.Text = "MATAKULIAH"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(226), CByte(24), CByte(24))
        GroupBox2.Controls.Add(ck_math)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(ck_reli)
        GroupBox2.Controls.Add(ck_statis)
        GroupBox2.Controls.Add(ck_rob)
        GroupBox2.Controls.Add(ck_akut)
        GroupBox2.Controls.Add(ck_pmro)
        GroupBox2.Location = New Point(389, 21)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(139, 189)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        ' 
        ' ck_math
        ' 
        ck_math.AutoSize = True
        ck_math.Location = New Point(6, 157)
        ck_math.Name = "ck_math"
        ck_math.Size = New Size(83, 19)
        ck_math.TabIndex = 14
        ck_math.Text = "Matematik"
        ck_math.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(15, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 17)
        Label6.TabIndex = 16
        Label6.Text = "NIM :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(6, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 17)
        Label7.TabIndex = 17
        Label7.Text = "Nama : "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(14, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 17)
        Label8.TabIndex = 18
        Label8.Text = "Prodi : "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(24, 135)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 17)
        Label9.TabIndex = 19
        Label9.Text = "UKP : "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(23, 167)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 17)
        Label10.TabIndex = 20
        Label10.Text = "UKV : "
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(18, 206)
        Label11.Name = "Label11"
        Label11.Size = New Size(47, 17)
        Label11.TabIndex = 21
        Label11.Text = "Total : "
        ' 
        ' dt_nim
        ' 
        dt_nim.AutoSize = True
        dt_nim.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dt_nim.Location = New Point(124, 30)
        dt_nim.Name = "dt_nim"
        dt_nim.Size = New Size(53, 17)
        dt_nim.TabIndex = 22
        dt_nim.Text = "_________"
        ' 
        ' dt_nama
        ' 
        dt_nama.AutoSize = True
        dt_nama.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dt_nama.Location = New Point(124, 60)
        dt_nama.Name = "dt_nama"
        dt_nama.Size = New Size(53, 17)
        dt_nama.TabIndex = 23
        dt_nama.Text = "_________"
        ' 
        ' dt_prodi
        ' 
        dt_prodi.AutoSize = True
        dt_prodi.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dt_prodi.Location = New Point(124, 91)
        dt_prodi.Name = "dt_prodi"
        dt_prodi.Size = New Size(53, 17)
        dt_prodi.TabIndex = 24
        dt_prodi.Text = "_________"
        ' 
        ' dt_ukp
        ' 
        dt_ukp.AutoSize = True
        dt_ukp.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dt_ukp.Location = New Point(124, 135)
        dt_ukp.Name = "dt_ukp"
        dt_ukp.Size = New Size(53, 17)
        dt_ukp.TabIndex = 25
        dt_ukp.Text = "_________"
        ' 
        ' dt_ukv
        ' 
        dt_ukv.AutoSize = True
        dt_ukv.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dt_ukv.Location = New Point(124, 167)
        dt_ukv.Name = "dt_ukv"
        dt_ukv.Size = New Size(53, 17)
        dt_ukv.TabIndex = 26
        dt_ukv.Text = "_________"
        ' 
        ' dt_total
        ' 
        dt_total.AutoSize = True
        dt_total.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        dt_total.Location = New Point(124, 206)
        dt_total.Name = "dt_total"
        dt_total.Size = New Size(53, 17)
        dt_total.TabIndex = 27
        dt_total.Text = "_________"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.DarkGray
        GroupBox3.Controls.Add(dt_total)
        GroupBox3.Controls.Add(dt_ukv)
        GroupBox3.Controls.Add(dt_ukp)
        GroupBox3.Controls.Add(dt_prodi)
        GroupBox3.Controls.Add(dt_nama)
        GroupBox3.Controls.Add(dt_nim)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Location = New Point(544, 10)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(262, 248)
        GroupBox3.TabIndex = 28
        GroupBox3.TabStop = False
        GroupBox3.Text = "Hasil"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(221), CByte(131))
        ClientSize = New Size(818, 270)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "fd"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cb_prodi As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents tb_nim As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ck_pmro As CheckBox
    Friend WithEvents ck_akut As CheckBox
    Friend WithEvents ck_rob As CheckBox
    Friend WithEvents ck_statis As CheckBox
    Friend WithEvents ck_reli As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ck_math As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dt_nim As Label
    Friend WithEvents dt_nama As Label
    Friend WithEvents dt_prodi As Label
    Friend WithEvents dt_ukp As Label
    Friend WithEvents dt_ukv As Label
    Friend WithEvents dt_total As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
