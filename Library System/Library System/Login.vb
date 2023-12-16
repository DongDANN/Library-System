Imports System.Data.SqlClient

Public Class Login

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Try
            Using con As New SqlConnection("Data Source=RONALD\SQLEXPRESS;Initial Catalog=librarydb;User ID=Ronald;Password=123")
                con.Open()

                Dim query As String = "SELECT * FROM dbo.tblaccounts WHERE Username = @Username AND Password = @Password"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

                    Dim myread As SqlDataReader = cmd.ExecuteReader()

                    If myread.Read() Then
                        Dim accountType As String = myread("AccountType").ToString()
                        Dim accountStatus As String = myread("Status").ToString()

                        If String.Equals(accountStatus, "Active", StringComparison.OrdinalIgnoreCase) Then
                            If String.Equals(accountType, "Admin", StringComparison.Ordinal) OrElse
                           String.Equals(accountType, "Librarian", StringComparison.Ordinal) Then

                                Dim username As String = myread("Username").ToString()
                                myread.Close()


                                If Not AccountHasLastLogin(username) Then
                                    Me.Hide()
                                    loggedInUsername = username
                                    FirstTimeLogIn.Show()
                                    UpdateLastLoginDateTime(con, username)
                                    MessageBox.Show("1st time login detected, add secret question")
                                Else
                                    UpdateLastLoginDateTime(con, username)
                                    loggedInUsername = username

                                    If String.Equals(accountType, "Admin", StringComparison.Ordinal) Then
                                        Me.Hide()
                                        ITInterface.Show()
                                        ITInterface.btnDashboard.PerformClick()
                                    ElseIf String.Equals(accountType, "Librarian", StringComparison.Ordinal) Then
                                        Me.Hide()
                                        LibrarianInterface.Show()
                                        LibrarianInterface.btnDashboard.PerformClick()
                                    End If

                                    txtUsername.Text = ""
                                    txtPassword.Text = ""
                                End If
                            End If
                        Else
                            MsgBox("Account is disabled.")
                            txtUsername.Text = ""
                            txtPassword.Text = ""
                        End If
                    Else
                        MsgBox("Invalid Username or Password")
                        txtUsername.Text = ""
                        txtPassword.Text = ""
                    End If
                End Using
            End Using
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub txtForgotPassword_Click(sender As Object, e As EventArgs) Handles txtForgotPassword.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub

    Private Sub UpdateLastLoginDateTime(con As SqlConnection, username As String)
        Try
            Dim loginDateTime As DateTime = DateTime.Now

            Dim updateLoginQuery As String = "UPDATE dbo.tblaccounts SET LastLoginDateTime = @LastLoginDateTime WHERE Username = @Username"

            Using cmdUpdate As New SqlCommand(updateLoginQuery, con)
                cmdUpdate.Parameters.AddWithValue("@LastLoginDateTime", loginDateTime)
                cmdUpdate.Parameters.AddWithValue("@Username", username)
                cmdUpdate.ExecuteNonQuery()
            End Using
        Finally
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Function AccountHasLastLogin(loggedInUsername As String) As Boolean
        Try
            con.Open()
            Dim query As String = "SELECT LastLoginDateTime FROM tblaccounts WHERE Username = @Username"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", loggedInUsername)
            Return Not IsDBNull(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error checking LastLoginDateTime: " & ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click
        If txtPassword.UseSystemPasswordChar Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
