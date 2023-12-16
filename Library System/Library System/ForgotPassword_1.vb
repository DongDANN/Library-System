Imports System.Data.SqlClient

Public Class ForgotPassword_1
    Private attemptCount As Integer = 0

    Private Sub ForgotPassword_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        If Not String.IsNullOrEmpty(forgotPasswordUsername) Then
            Try
                con.Open()
                Dim query As String = "SELECT SecretQuestion FROM tblaccounts WHERE Username = @Username"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Username", forgotPasswordUsername)

                Dim secretQuestion As Object = cmd.ExecuteScalar()

                If secretQuestion IsNot Nothing AndAlso Not IsDBNull(secretQuestion) Then
                    txtSecretQuestion.Text = secretQuestion.ToString()
                Else
                    MessageBox.Show("No secret question found for this account.")
                    Me.Close()
                    Login.Show()
                End If
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btnSubmitAnswer_Click(sender As Object, e As EventArgs) Handles btnSubmitAnswer.Click
        Dim providedAnswer As String = txtSecretQuestionAnswer.Text.Trim()

        If Not String.IsNullOrEmpty(providedAnswer) Then
            Try
                con.Open()
                Dim answerQuery As String = "SELECT COUNT(*) FROM tblaccounts WHERE Username = @Username AND SecretQuestionAnswer = @SecretQuestionAnswer"
                cmd = New SqlCommand(answerQuery, con)
                cmd.Parameters.AddWithValue("@Username", forgotPasswordUsername)
                cmd.Parameters.AddWithValue("@SecretQuestionAnswer", providedAnswer)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Answer is correct")

                    ForgotPassword_2.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Answer is incorrect")
                    txtSecretQuestionAnswer.Text = ""
                    attemptCount += 1

                    If attemptCount >= 3 Then
                        MessageBox.Show("Maximum attempts reached. Account has been Disabled. Closing the form.")

                        Dim updateStatusQuery As String = "UPDATE tblaccounts SET Status = 'Disabled' WHERE Username = @Username"
                        cmd = New SqlCommand(updateStatusQuery, con)
                        cmd.Parameters.AddWithValue("@Username", forgotPasswordUsername)
                        cmd.ExecuteNonQuery()

                        Me.Close()
                        Login.Show()
                    End If
                End If
            Finally
                con.Close()
            End Try
        End If
    End Sub

End Class