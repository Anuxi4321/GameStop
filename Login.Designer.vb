<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        Button3 = New Button()
        TextBox2 = New TextBox()
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
        Panel1.Size = New Size(1061, 609)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(297, 66)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(418, 476)
        Panel2.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(50, 448)
        Label5.Name = "Label5"
        Label5.Size = New Size(329, 14)
        Label5.TabIndex = 9
        Label5.Text = "THIS APP IS A TEST PRODUCT FOR SCHOOL REQUIREMENT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(185, 429)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 2
        Label4.Text = "V.0.0.01"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Silver
        Button2.Location = New Point(27, 370)
        Button2.Name = "Button2"
        Button2.Size = New Size(366, 37)
        Button2.TabIndex = 8
        Button2.Text = "BACK"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(27, 303)
        Button1.Name = "Button1"
        Button1.Size = New Size(366, 37)
        Button1.TabIndex = 7
        Button1.Text = "SIGN UP"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.AppWorkspace
        Label3.Location = New Point(284, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 15)
        Label3.TabIndex = 6
        Label3.Text = "Forgot Password?"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Lime
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(27, 260)
        Button3.Name = "Button3"
        Button3.Size = New Size(366, 37)
        Button3.TabIndex = 5
        Button3.Text = "LOG IN"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Black
        TextBox2.ForeColor = SystemColors.Window
        TextBox2.Location = New Point(27, 153)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(366, 41)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = SystemColors.Window
        TextBox1.Location = New Point(27, 92)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(366, 41)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(27, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(244, 29)
        Label2.TabIndex = 1
        Label2.Text = "GAMESTOP ID LOGIN" & vbCrLf
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
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1061, 609)
        Controls.Add(Panel1)
        Name = "Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
