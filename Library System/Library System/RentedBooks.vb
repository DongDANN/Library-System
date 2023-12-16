Imports System.Data.SqlClient

Public Class RentedBooks
    Private Sub data()
        Try
            con.Open()

            Dim query As String = "SELECT BD.*, BI.IssueTo, BI.IssueDate, BI.DueDate " &
                                 "FROM dbo.tblBookDetails BD " &
                                 "LEFT JOIN dbo.tblBookIssuing BI ON BD.ISBN = BI.ISBN " &
                                 "WHERE BD.Status = 'Borrowed'"
            cmd = New SqlCommand(query, con)
            sd = New SqlDataAdapter(cmd)
            dt = New DataTable()
            sd.Fill(dt)
            RentedBooksDataGrid.DataSource = dt
        Finally
            con.Close()
        End Try

        cmd = New SqlCommand("SELECT DISTINCT GroupName FROM dbo.tblBookDetails WHERE Status = 'Borrowed'", con)
        sd = New SqlDataAdapter(cmd)
        Dim groupNameTable As New DataTable()
        sd.Fill(groupNameTable)
        txtGroupName.DataSource = groupNameTable
        txtGroupName.DisplayMember = "GroupName"
        txtGroupName.ValueMember = "GroupName"

    End Sub

    Private Sub RentedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()

        txtGroupName.SelectedIndex = -1
        txtSearch.Text = ""
        For Each col As DataGridViewColumn In RentedBooksDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchKeyword As String = txtSearch.Text.Trim()

        If Not String.IsNullOrEmpty(searchKeyword) Then
            Dim filteredRows() As DataRow = dt.Select($"ISBN LIKE '%{searchKeyword}%' OR GroupName LIKE '%{searchKeyword}%' OR BookName LIKE '%{searchKeyword}%' OR Publisher LIKE '%{searchKeyword}%' OR Author LIKE '%{searchKeyword}%' OR IssueTo LIKE '%{searchKeyword}%'")
            Dim filteredTable As DataTable = dt.Clone()
            For Each row As DataRow In filteredRows
                filteredTable.ImportRow(row)
            Next
            RentedBooksDataGrid.DataSource = filteredTable
        Else
            RentedBooksDataGrid.DataSource = dt
        End If
    End Sub

    Private Sub txtGroupName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtGroupName.SelectedIndexChanged
        If txtGroupName.SelectedIndex <> -1 Then
            Dim selectedGroupName As String = txtGroupName.SelectedValue.ToString()
            Dim filteredRows() As DataRow = dt.Select($"GroupName = '{selectedGroupName}'")
            Dim filteredTable As DataTable = dt.Clone()
            For Each row As DataRow In filteredRows
                filteredTable.ImportRow(row)
            Next
            RentedBooksDataGrid.DataSource = filteredTable
        Else
            RentedBooksDataGrid.DataSource = dt
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        RentedBooksDataGrid.DataSource = dt
        txtSearch.Text = ""
        txtGroupName.SelectedIndex = -1
    End Sub
End Class
