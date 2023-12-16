Imports System.Data.SqlClient

Public Class AllAccounts

    Private Sub HideSensitiveColumns()

        AccountsGrid.Columns("Password").Visible = False
        AccountsGrid.Columns("SecretQuestion").Visible = False
        AccountsGrid.Columns("SecretQuestionAnswer").Visible = False

    End Sub
    Private Sub data()
        cmd = New SqlCommand("Select * from dbo.tblaccounts", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        AccountsGrid.DataSource = dt
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountsGrid.CellContentClick

    End Sub


    Private Sub AllAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()
        HideSensitiveColumns()
        For Each col As DataGridViewColumn In AccountsGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchKeyword As String = txtSearch.Text.Trim()

        If Not String.IsNullOrEmpty(searchKeyword) Then
            Dim filteredRows() As DataRow = dt.Select($"Name LIKE '%{searchKeyword}%' OR Username LIKE '%{searchKeyword}%' OR AccountType LIKE '%{searchKeyword}%' OR Status LIKE '%{searchKeyword}%'")
            Dim filteredTable As DataTable = dt.Clone()
            For Each row As DataRow In filteredRows
                filteredTable.ImportRow(row)
            Next
            AccountsGrid.DataSource = filteredTable
        Else
            AccountsGrid.DataSource = dt
        End If
    End Sub

    Private Sub lblSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub txtAllBooks_Click(sender As Object, e As EventArgs) Handles txtAllBooks.Click

    End Sub

    Private Sub ShowAll_Click(sender As Object, e As EventArgs) Handles ShowAll.Click
        AccountsGrid.DataSource = dt
        txtSearch.Text = ""
    End Sub
End Class