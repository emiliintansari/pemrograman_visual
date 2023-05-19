<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cth2
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
        tpk_pembuatan = New DateTimePicker()
        tpk_exp = New DateTimePicker()
        Label4 = New Label()
        tb_nama_produk = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' tpk_pembuatan
        ' 
        tpk_pembuatan.Location = New Point(148, 78)
        tpk_pembuatan.Name = "tpk_pembuatan"
        tpk_pembuatan.Size = New Size(200, 23)
        tpk_pembuatan.TabIndex = 0
        ' 
        ' tpk_exp
        ' 
        tpk_exp.Location = New Point(148, 111)
        tpk_exp.Name = "tpk_exp"
        tpk_exp.Size = New Size(200, 23)
        tpk_exp.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 15)
        Label4.TabIndex = 8
        Label4.Text = "nama_produk"
        ' 
        ' tb_nama_produk
        ' 
        tb_nama_produk.Location = New Point(126, 14)
        tb_nama_produk.Name = "tb_nama_produk"
        tb_nama_produk.Size = New Size(100, 23)
        tb_nama_produk.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(285, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 10
        Button1.Text = "HITUNG"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 15)
        Label1.TabIndex = 11
        Label1.Text = "tanggal_pembuatan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 12
        Label2.Text = "tanggal_expired"
        ' 
        ' cth2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 242)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(tb_nama_produk)
        Controls.Add(Label4)
        Controls.Add(tpk_exp)
        Controls.Add(tpk_pembuatan)
        Name = "cth2"
        Text = "cth2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tpk_pembuatan As DateTimePicker
    Friend WithEvents tpk_exp As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_nama_produk As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
