Imports System.Data.SqlClient

Public Class ForgotPassword
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtUsername.Text = ""
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usernameForgotPass As String = txtUsername.Text.Trim()

        If Not String.IsNullOrEmpty(usernameForgotPass) Then
            Try
                con.Open()
                Dim query As String = "SELECT COUNT(*) FROM tblaccounts WHERE Username = @Username"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Username", usernameForgotPass)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Username found.")
                    forgotPasswordUsername = txtUsername.Text
                    Me.Close()
                    ForgotPassword_1.Show()
                Else
                    MessageBox.Show("Username not found.")
                End If
            Finally
                con.Close()
            End Try
        End If
    End Sub

End Class
