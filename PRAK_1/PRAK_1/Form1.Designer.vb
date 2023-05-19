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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(15, 174)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "START"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(70, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(228, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 2
        Label1.Text = "Nama"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 3
        Label2.Text = "NIM"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(71, 61)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(227, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 5
        Label3.Text = "Prodi"' 
        ' ComboBox1
        ' 
        ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Sistem informasi ", "Teknik Informatika ", "Komputerisasi Akutansi ", "Teknik Multimedia Jaringan"})
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Sistem informasi", "Teknik informatika", "Komputerisasi akutansi", "Teknik multimedia dan jaringan"})
        ComboBox1.Location = New Point(70, 97)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(228, 23)
        ComboBox1.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Coral
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(6, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(312, 156)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(327, 221)
        Controls.Add(GroupBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
