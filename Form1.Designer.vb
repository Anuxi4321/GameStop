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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-4, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1023, 612)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(302, 66)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(408, 500)
        Panel2.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(25, 316)
        Button3.Name = "Button3"
        Button3.Size = New Size(356, 37)
        Button3.TabIndex = 4
        Button3.Text = "CONTINUE AS GUEST"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lime
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(207, 258)
        Button2.Name = "Button2"
        Button2.Size = New Size(174, 37)
        Button2.TabIndex = 3
        Button2.Text = "SIGN UP"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(25, 258)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 37)
        Button1.TabIndex = 2
        Button1.Text = "LOG IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Location = New Point(3, 55)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(402, 135)
        Panel3.TabIndex = 1
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(176, 444)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 1
        Label2.Text = "V.0.0.01"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(42, 464)
        Label3.Name = "Label3"
        Label3.Size = New Size(329, 14)
        Label3.TabIndex = 5
        Label3.Text = "THIS APP IS A TEST PRODUCT FOR SCHOOL REQUIREMENT"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 604)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
