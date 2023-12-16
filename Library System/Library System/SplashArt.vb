Imports System.Data.SqlClient

Public Class SplashArt

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        pnlLoading.Width += 3

        If pnlLoading.Width >= 599 Then
            Timer.Stop()
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

End Class
