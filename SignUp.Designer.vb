<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SignUp))
        Panel1 = New Panel()
        Panel2 = New Panel()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonFace
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.ForeColor = Color.DimGray
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1021, 601)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(297, 66)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(418, 476)
        Panel2.TabIndex = 0
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Black
        TextBox4.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.ForeColor = SystemColors.Window
        TextBox4.Location = New Point(26, 277)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Password"
        TextBox4.Size = New Size(366, 49)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Black
        TextBox3.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.ForeColor = SystemColors.Window
        TextBox3.Location = New Point(26, 214)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Email Address"
        TextBox3.Size = New Size(366, 49)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Black
        TextBox2.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.Location = New Point(27, 149)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Birthday"
        TextBox2.Size = New Size(366, 49)
        TextBox2.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(27, 418)
        Button1.Name = "Button1"
        Button1.Size = New Size(366, 37)
        Button1.TabIndex = 7
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Lime
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(27, 375)
        Button3.Name = "Button3"
        Button3.Size = New Size(366, 37)
        Button3.TabIndex = 5
        Button3.Text = "CREATE ACCOUNT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(27, 84)
        TextBox1.Margin = New Padding(3, 10, 3, 3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "GameStop ID"
        TextBox1.Size = New Size(366, 49)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(27, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(351, 29)
        Label2.TabIndex = 1
        Label2.Text = "CREATE GAMESTOP ACCOUNT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(177, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1021, 601)
        Controls.Add(Panel1)
        Name = "SignUp"
        Text = "SignUp"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
