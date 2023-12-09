Imports System.Drawing.Drawing2D

Public Class DashboardGuest
    Private Sub ApplyRoundedCorners(control As Control, radius As Integer)
        Dim path As New GraphicsPath()
        Dim rectangle As Rectangle = New Rectangle(0, 0, control.Width, control.Height)

        path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90)
        path.AddArc(rectangle.Right - radius, rectangle.Y, radius, radius, 270, 90)
        path.AddArc(rectangle.Right - radius, rectangle.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rectangle.X, rectangle.Bottom - radius, radius, radius, 90, 90)

        control.Region = New Region(path)
    End Sub

    Private Sub DashboardGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adjust the radius as needed
        ApplyRoundedCorners(Panel3, 20)
        ApplyRoundedCorners(Panel5, 20)
        ApplyRoundedCorners(Panel6, 20)
        ApplyRoundedCorners(Panel7, 20)
        ApplyRoundedCorners(Panel4, 20)
        ApplyRoundedCorners(Panel8, 20)
        ApplyRoundedCorners(Panel9, 20)
        ApplyRoundedCorners(Panel10, 20)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


End Class

