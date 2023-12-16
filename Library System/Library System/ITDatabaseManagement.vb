Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ITDatabaseManagement

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            Dim backupDialog As New SaveFileDialog()
            backupDialog.Filter = "Backup Files (*.bak)|*.bak"
            backupDialog.Title = "Select Backup File"

            If backupDialog.ShowDialog() = DialogResult.OK Then
                con.Open()

                Dim backupQuery As String = $"BACKUP DATABASE librarydb TO DISK='{backupDialog.FileName}'"

                Using cmdBackup As New SqlCommand(backupQuery, con)
                    cmdBackup.ExecuteNonQuery()
                End Using

                MessageBox.Show("Database backup successful.")
            End If
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Try
            Dim restoreDialog As New OpenFileDialog()
            restoreDialog.Filter = "Backup Files (*.bak)|*.bak"
            restoreDialog.Title = "Select Backup File"

            If restoreDialog.ShowDialog() = DialogResult.OK Then
                con.Open()

                Dim restoreQuery As String = $"USE master; RESTORE DATABASE librarydb FROM DISK='{restoreDialog.FileName}' WITH REPLACE;"

                Using cmdRestore As New SqlCommand(restoreQuery, con)
                    cmdRestore.ExecuteNonQuery()
                End Using

                MessageBox.Show("Database restore successful.")
            End If
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Background_Click(sender As Object, e As EventArgs) Handles Background.Click

    End Sub
End Class
