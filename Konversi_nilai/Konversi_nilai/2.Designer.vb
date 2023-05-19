<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _2
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
        cbx_stauan = New ComboBox()
        tb_stokbox = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        tb_stokkeluar = New TextBox()
        Button1 = New Button()
        tb_stokdus = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' cbx_stauan
        ' 
        cbx_stauan.FormattingEnabled = True
        cbx_stauan.Items.AddRange(New Object() {"Dus", "Box"})
        cbx_stauan.Location = New Point(232, 129)
        cbx_stauan.Name = "cbx_stauan"
        cbx_stauan.Size = New Size(156, 23)
        cbx_stauan.TabIndex = 15
        ' 
        ' tb_stokbox
        ' 
        tb_stokbox.Location = New Point(230, 50)
        tb_stokbox.Name = "tb_stokbox"
        tb_stokbox.Size = New Size(158, 23)
        tb_stokbox.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 13
        Label3.Text = "Jumlah"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 12
        Label2.Text = "Stok Keluar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 11
        Label1.Text = "Stok"
        ' 
        ' tb_stokkeluar
        ' 
        tb_stokkeluar.Location = New Point(12, 126)
        tb_stokkeluar.Name = "tb_stokkeluar"
        tb_stokkeluar.Size = New Size(158, 23)
        tb_stokkeluar.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 202)
        Button1.Name = "Button1"
        Button1.Size = New Size(338, 23)
        Button1.TabIndex = 9
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' tb_stokdus
        ' 
        tb_stokdus.Location = New Point(12, 50)
        tb_stokdus.Name = "tb_stokdus"
        tb_stokdus.Size = New Size(158, 23)
        tb_stokdus.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(230, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 16
        Label4.Text = "Satuan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(232, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 15)
        Label5.TabIndex = 17
        Label5.Text = "Box"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 15)
        Label6.TabIndex = 18
        Label6.Text = "Dus"
        ' 
        ' _2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(407, 239)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cbx_stauan)
        Controls.Add(tb_stokbox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tb_stokkeluar)
        Controls.Add(Button1)
        Controls.Add(tb_stokdus)
        Name = "_2"
        Text = "_2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbx_stauan As ComboBox
    Friend WithEvents tb_stokbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_stokkeluar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_stokdus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
