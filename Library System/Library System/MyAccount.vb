Imports System.Data.SqlClient

Public Class MyAccount
    Dim query As String = "SELECT SecretQuestion FROM dbo.tblaccounts WHERE Username = @Username"

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LibrarianInterface.Hide()
        Login.Show()
    End Sub

    Private Sub ITMyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSecretQuestion()
    End Sub

    Private Sub LoadSecretQuestion()
        Try
            con.Open()

            Dim username As String = loggedInUsername

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Username", username)

                Dim secretQuestion As String = Convert.ToString(cmd.ExecuteScalar())


                txtExistingSecretQuestion.Text = secretQuestion
            End Using
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSecretQuestionSubmit.Click
        Try
            If txtExistingSecretQuestionAnswer.Text = GetStoredSecretQuestionAnswer() Then
                UpdateSecretQuestionAndAnswer(txtNewQuestion.Text, txtNewAnswer.Text)

                MessageBox.Show("Secret question and answer updated successfully.")
                txtExistingSecretQuestion.Text = ""
                txtExistingSecretQuestionAnswer.Text = ""
                txtNewAnswer.Text = ""
                txtNewQuestion.Text = ""
            Else

                MessageBox.Show("Incorrect existing secret question answer.")
            End If
        Finally
            con.Close()
        End Try
    End Sub

    Private Function GetStoredSecretQuestionAnswer() As String
        Dim storedAnswer As String = ""

        Try
            Using con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=librarydb;User ID=Ronald;Password=123")
                con.Open()

                Dim query As String = "SELECT SecretQuestionAnswer FROM dbo.tblaccounts WHERE Username = @Username"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", loggedInUsername)
                    storedAnswer = Convert.ToString(cmd.ExecuteScalar())
                End Using
            End Using
        Finally
            con.Close()
        End Try

        Return storedAnswer
    End Function

    Private Sub UpdateSecretQuestionAndAnswer(newQuestion As String, newAnswer As String)
        Try
            Using con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=librarydb;User ID=Ronald;Password=123")
                con.Open()

                Dim updateQuery As String = "UPDATE dbo.tblaccounts SET SecretQuestion = @NewQuestion, SecretQuestionAnswer = @NewAnswer WHERE Username = @Username"

                Using cmdUpdate As New SqlCommand(updateQuery, con)
                    cmdUpdate.Parameters.AddWithValue("@NewQuestion", newQuestion)
                    cmdUpdate.Parameters.AddWithValue("@NewAnswer", newAnswer)
                    cmdUpdate.Parameters.AddWithValue("@Username", loggedInUsername)
                    cmdUpdate.ExecuteNonQuery()
                End Using
            End Using
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnPasswordSubmit.Click
        Try
            Dim existingPassword As String = txtExistingPassword.Text
            Dim newPassword As String = txtNewPassword.Text
            Dim confirmPassword As String = txtConfirmPassword.Text

            If Not IsValidPassword(newPassword) Then
                MessageBox.Show("New password must be between 8 and 20 characters.")
                Return
            End If

            If existingPassword = GetStoredPassword() AndAlso newPassword = confirmPassword Then
                UpdatePassword(newPassword)

                MessageBox.Show("Password has been updated successfully.")
                txtExistingPassword.Text = ""
                txtNewPassword.Text = ""
                txtConfirmPassword.Text = ""
            Else
                MessageBox.Show("Incorrect existing password or confirm password.")
            End If
        Finally
            con.Close()
        End Try
    End Sub
    Private Function GetStoredPassword() As String
        Dim storedPassword As String = ""

        Try
            Using con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=librarydb;User ID=Ronald;Password=123")
                con.Open()

                Dim query As String = "SELECT Password FROM dbo.tblaccounts WHERE Username = @Username"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", loggedInUsername)
                    storedPassword = Convert.ToString(cmd.ExecuteScalar())
                End Using
            End Using
        Finally
            con.Close()
        End Try

        Return storedPassword
    End Function
    Private Sub UpdatePassword(newPassword As String)
        Try
            Using con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=librarydb;User ID=Ronald;Password=123")
                con.Open()

                Dim updateQuery As String = "UPDATE dbo.tblaccounts SET Password = @newPassword WHERE Username = @Username"

                Using cmdUpdate As New SqlCommand(updateQuery, con)
                    cmdUpdate.Parameters.AddWithValue("@NewPassword", newPassword)
                    cmdUpdate.Parameters.AddWithValue("@Username", loggedInUsername)
                    cmdUpdate.ExecuteNonQuery()
                End Using
            End Using
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Background_Click(sender As Object, e As EventArgs) Handles Background.Click

    End Sub

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtExistingPassword.UseSystemPasswordChar Then
            txtExistingPassword.UseSystemPasswordChar = False
        Else
            txtExistingPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNewPassword.UseSystemPasswordChar Then
            txtNewPassword.UseSystemPasswordChar = False
        Else
            txtNewPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtConfirmPassword.UseSystemPasswordChar Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtExistingPassword_TextChanged(sender As Object, e As EventArgs) Handles txtExistingPassword.TextChanged
        Dim currentText As String = txtExistingPassword.Text


        If currentText.Length > 20 Then
            MessageBox.Show("Password cannot exceed 20 characters.")
            txtExistingPassword.Text = currentText.Substring(0, 20)
            txtExistingPassword.SelectionStart = txtExistingPassword.TextLength
        End If
    End Sub
    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged
        Dim currentText As String = txtNewPassword.Text

        If currentText.Length > 20 Then
            MessageBox.Show("Password cannot exceed 20 characters.")
            txtNewPassword.Text = currentText.Substring(0, 20)
            txtNewPassword.SelectionStart = txtNewPassword.TextLength
        End If
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        Dim currentText As String = txtConfirmPassword.Text

        If currentText.Length > 20 Then
            MessageBox.Show("Password cannot exceed 20 characters.")
            txtConfirmPassword.Text = currentText.Substring(0, 20)
            txtConfirmPassword.SelectionStart = txtConfirmPassword.TextLength
        End If
    End Sub

    Private Function IsValidPassword(password As String) As Boolean
        Return password.Length >= 8 AndAlso password.Length <= 20
    End Function

    Private Sub txtExistingPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExistingPassword.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        Dim currentText As String = txtConfirmPassword.Text

        If currentText.Length > 20 Then
            MessageBox.Show("Password cannot exceed 20 characters.")
            txtConfirmPassword.Text = currentText.Substring(0, 20)
            txtConfirmPassword.SelectionStart = txtConfirmPassword.TextLength
        End If
    End Sub

    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        Dim currentText As String = txtConfirmPassword.Text

        If currentText.Length > 20 Then
            MessageBox.Show("Password cannot exceed 20 characters.")
            txtConfirmPassword.Text = currentText.Substring(0, 20)
            txtConfirmPassword.SelectionStart = txtConfirmPassword.TextLength
        End If
    End Sub

    Private Sub txtConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirmPassword.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        Dim currentText As String = txtConfirmPassword.Text

        If currentText.Length > 20 Then
            MessageBox.Show("Password cannot exceed 20 characters.")
            txtConfirmPassword.Text = currentText.Substring(0, 20)
            txtConfirmPassword.SelectionStart = txtConfirmPassword.TextLength
        End If
    End Sub
End Class
