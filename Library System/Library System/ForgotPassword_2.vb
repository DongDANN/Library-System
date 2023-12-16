Imports System.Data.SqlClient

Public Class ForgotPassword_2
    Private Sub btnPasswordSubmit_Click(sender As Object, e As EventArgs) Handles btnPasswordSubmit.Click
        Dim newPassword As String = txtNewPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        If newPassword = confirmPassword Then
            Try
                Using con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=librarydb;User ID=Ronald;Password=123")
                    con.Open()

                    Dim updateQuery As String = "UPDATE dbo.tblaccounts SET Password = @Password WHERE Username = @Username"

                    Using cmdUpdate As New SqlCommand(updateQuery, con)
                        cmdUpdate.Parameters.AddWithValue("@Password", newPassword)
                        cmdUpdate.Parameters.AddWithValue("@Username", forgotPasswordUsername)
                        cmdUpdate.ExecuteNonQuery()

                        MessageBox.Show("Password has been updated successfully.")
                        Me.Close()
                        Login.Show()
                    End Using
                End Using
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("New password and confirm password do not match.")
        End If
    End Sub

End Class
