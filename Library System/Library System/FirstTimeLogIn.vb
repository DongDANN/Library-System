Imports System.Data.SqlClient

Public Class FirstTimeLogIn
    Private Sub btnSecretQuestionSubmit_Click(sender As Object, e As EventArgs) Handles btnSecretQuestionSubmit.Click
        Me.Close()
        Login.Show()
        Login.btnLogIn.PerformClick()
    End Sub
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtNewAnswer.Text = txtConfirmAnswer.Text Then
                UpdateSecretQuestionAndAnswer(txtNewQuestion.Text, txtNewAnswer.Text)

                MessageBox.Show("Secret question and answer updated successfully.")
                txtNewAnswer.Text = ""
                txtNewQuestion.Text = ""
                Me.Close()
                Login.Show()
                Login.btnLogIn.PerformClick()
            Else
                MessageBox.Show("Incorrect existing secret question answer.")
            End If
        Finally
            con.Close()
        End Try
    End Sub
End Class