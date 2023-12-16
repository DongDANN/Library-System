Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BookIssuing
    Private Sub data()

        cmd = New SqlCommand("SELECT * FROM dbo.tblBookIssuing", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        BookIssuingDataGrid.DataSource = dt


        cmd = New SqlCommand("SELECT DISTINCT ISBN FROM dbo.tblBookDetails", con)
        sd = New SqlDataAdapter(cmd)
        Dim isbnTable As New DataTable()
        sd.Fill(isbnTable)
        txtBookISBN.DataSource = isbnTable
        txtBookISBN.DisplayMember = "ISBN"

        cmd = New SqlCommand("SELECT DISTINCT GroupName FROM dbo.tblBookDetails", con)
        sd = New SqlDataAdapter(cmd)
        Dim groupNameTable As New DataTable()
        sd.Fill(groupNameTable)
        txtGroupName.DataSource = groupNameTable
        txtGroupName.DisplayMember = "GroupName"

        cmd = New SqlCommand("SELECT DISTINCT StudentNo FROM dbo.tblBorrower", con)
        sd = New SqlDataAdapter(cmd)
        Dim studentNoTable As New DataTable()
        sd.Fill(studentNoTable)
        txtIssueTo.DataSource = studentNoTable
        txtIssueTo.DisplayMember = "StudentNo"
    End Sub

    Private Sub txtBookISBN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBookISBN.SelectedIndexChanged
        If txtBookISBN.SelectedIndex <> -1 Then

            cmd = New SqlCommand($"SELECT * FROM dbo.tblBookDetails WHERE ISBN = '{txtBookISBN.Text}'", con)
            sd = New SqlDataAdapter(cmd)
            Dim detailsTable As New DataTable()
            sd.Fill(detailsTable)

            If detailsTable.Rows.Count > 0 Then
                Dim detailsRow As DataRow = detailsTable.Rows(0)
                txtGroupName.Text = detailsRow("GroupName").ToString()
                txtBookName.Text = detailsRow("BookName").ToString()
                txtPublisher.Text = detailsRow("Publisher").ToString()
                txtAuthor.Text = detailsRow("Author").ToString()
                txtStatus.Text = detailsRow("Status").ToString()
                txtPrice.Text = detailsRow("Price").ToString()

                cmd = New SqlCommand($"SELECT * FROM dbo.tblBookIssuing WHERE ISBN = '{txtBookISBN.Text}'", con)
                sd = New SqlDataAdapter(cmd)
                Dim issuingTable As New DataTable()
                sd.Fill(issuingTable)

                If issuingTable.Rows.Count > 0 Then
                    Dim issuingRow As DataRow = issuingTable.Rows(0)

                    txtIssueTo.Text = issuingRow("IssueTo").ToString()
                    txtIssueDate.Text = issuingRow("IssueDate").ToString()
                    txtIssuingDueDate.Text = issuingRow("DueDate").ToString()
                    txtTransactionID.Text = issuingRow("TransactionID").ToString()
                Else

                    txtIssueTo.Text = String.Empty
                    txtIssueDate.Text = String.Empty
                    txtIssuingDueDate.Text = String.Empty
                End If
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        con.Open()
        cmd = New SqlCommand("Select * from dbo.tblBookIssuing where TransactionID='" + txtTransactionID.Text + "'", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        BookIssuingDataGrid.DataSource = dt
        con.Close()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Not String.IsNullOrEmpty(txtBookISBN.Text) AndAlso
       Not String.IsNullOrEmpty(txtGroupName.Text) AndAlso
       Not String.IsNullOrEmpty(txtBookName.Text) AndAlso
       Not String.IsNullOrEmpty(txtPublisher.Text) AndAlso
       Not String.IsNullOrEmpty(txtAuthor.Text) AndAlso
       Not String.IsNullOrEmpty(txtStatus.Text) AndAlso
       Not String.IsNullOrEmpty(txtPrice.Text) AndAlso
       Not String.IsNullOrEmpty(txtPenalty.Text) AndAlso
       Not String.IsNullOrEmpty(txtIssueTo.Text) Then

            Try
                con.Open()

                Dim existingBorrowerCountQuery As String = "SELECT COUNT(*) FROM dbo.tblBorrower WHERE StudentNo = @StudentNo"
                cmd = New SqlCommand(existingBorrowerCountQuery, con)
                cmd.Parameters.AddWithValue("@StudentNo", txtIssueTo.Text)
                Dim existingBorrowerCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If existingBorrowerCount = 0 Then

                    Dim insertBorrowerQuery As String = "INSERT INTO dbo.tblBorrower (StudentNo) VALUES (@StudentNo)"
                    cmd = New SqlCommand(insertBorrowerQuery, con)
                    cmd.Parameters.AddWithValue("@StudentNo", txtIssueTo.Text)
                    cmd.ExecuteNonQuery()
                End If


                Dim bookStatusQuery As String = "SELECT Status FROM dbo.tblBookDetails WHERE ISBN = @ISBN"
                cmd = New SqlCommand(bookStatusQuery, con)
                cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                Dim status As String = Convert.ToString(cmd.ExecuteScalar())

                If status = "Borrowed" Then
                    MessageBox.Show("The book is already Borrowed. Cannot issue a new copy.")
                Else

                    Dim issueDate As String = txtIssueDate.Value.ToString("yyyy-MM-dd")
                    Dim dueDate As String = txtIssuingDueDate.Value.ToString("yyyy-MM-dd")

                    Dim issueBookQuery As String = "INSERT INTO dbo.tblBookIssuing (ISBN, Penalty, IssueTo, IssueDate, DueDate) VALUES (@ISBN, @Penalty, @IssueTo, @IssueDate, @DueDate)"
                    cmd = New SqlCommand(issueBookQuery, con)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                    cmd.Parameters.AddWithValue("@Penalty", txtPenalty.Text)
                    cmd.Parameters.AddWithValue("@IssueTo", txtIssueTo.Text)
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate)
                    cmd.Parameters.AddWithValue("@DueDate", dueDate)
                    cmd.ExecuteNonQuery()

                    Dim updateStatusQuery As String = "UPDATE dbo.tblBookDetails SET Status = 'Borrowed' WHERE ISBN = @ISBN"
                    cmd = New SqlCommand(updateStatusQuery, con)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Book has been issued")
                End If
            Finally
                con.Close()
                CalculateAndUpdatePenalties()
                data()
            End Try
        Else
            MessageBox.Show("Fields cannot be empty.")
        End If
    End Sub



    Private Sub BookIssuing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()
        CalculateAndUpdatePenalties()
        AddHandler BookIssuingDataGrid.CellClick, AddressOf BookIssuingDataGrid_CellClick
        For Each col As DataGridViewColumn In BookIssuingDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        SetGridViewSortState(BookIssuingDataGrid, DataGridViewColumnSortMode.NotSortable)
    End Sub

    Public Sub SetGridViewSortState(dgv As DataGridView, sortMode As DataGridViewColumnSortMode)
        For Each col As DataGridViewColumn In BookIssuingDataGrid.Columns
            col.SortMode = sortMode
        Next
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not String.IsNullOrEmpty(txtBookISBN.Text) Then
            Try
                con.Open()


                Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.tblBookIssuing WHERE ISBN = @ISBN"
                cmd = New SqlCommand(checkQuery, con)
                cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())

                Dim issueDate As String = txtIssueDate.Value.ToString("yyyy-MM-dd")
                Dim dueDate As String = txtIssuingDueDate.Value.ToString("yyyy-MM-dd")

                If count > 0 Then

                    Dim issuingQuery As String = "UPDATE dbo.tblBookIssuing SET IssueTo = @IssueTo, IssueDate = @IssueDate, DueDate = @DueDate WHERE ISBN = @ISBN"
                    cmd = New SqlCommand(issuingQuery, con)
                    cmd.Parameters.AddWithValue("@IssueTo", txtIssueTo.Text)
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate)
                    cmd.Parameters.AddWithValue("@DueDate", dueDate)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Successfully updated.")
                Else
                    MessageBox.Show("Book with ISBN " + txtBookISBN.Text + " has not been issued.")
                End If

            Finally
                con.Close()
                CalculateAndUpdatePenalties()
                data()
            End Try
        Else
            MessageBox.Show("All fields must be filled out.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtBookISBN.Text <> "" Then
            Try
                con.Open()


                Dim checkStatusQuery As String = "SELECT Status FROM dbo.tblBookDetails WHERE ISBN = @ISBN"
                cmd = New SqlCommand(checkStatusQuery, con)
                cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                Dim status As String = Convert.ToString(cmd.ExecuteScalar())

                If status = "Borrowed" Then
                    Dim updateStatusQuery As String = "UPDATE dbo.tblBookDetails SET Status = 'Available' WHERE ISBN = @ISBN"
                    cmd = New SqlCommand(updateStatusQuery, con)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                    cmd.ExecuteNonQuery()

                    Dim deleteQuery As String = "DELETE FROM dbo.tblBookIssuing WHERE ISBN = @ISBN"
                    cmd = New SqlCommand(deleteQuery, con)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Successfully Deleted and Archived.")
                Else
                    MessageBox.Show("The book is not currently borrowed. It is still available.")
                End If

            Finally
                con.Close()
                data()
            End Try
        Else
            MessageBox.Show("Enter ISBN of the Book Above.")
        End If
    End Sub

    Private Sub BookIssuingDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookIssuingDataGrid.CellClick

        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = BookIssuingDataGrid.Rows(e.RowIndex)


            txtBookISBN.Text = selectedRow.Cells("ISBN").Value.ToString()
            txtIssueTo.Text = selectedRow.Cells("IssueTo").Value.ToString()
            txtIssueDate.Text = selectedRow.Cells("IssueDate").Value.ToString()
            txtIssuingDueDate.Text = selectedRow.Cells("DueDate").Value.ToString()

        End If
    End Sub

    Public Sub CalculateAndUpdatePenalties()
        Try
            con.Open()

            cmd = New SqlCommand("SELECT * FROM dbo.tblBookIssuing", con)
            sd = New SqlDataAdapter(cmd)
            dt = New DataTable()
            sd.Fill(dt)

            For Each row As DataRow In dt.Rows
                Dim dueDate As DateTime = Convert.ToDateTime(row("DueDate"))
                Dim currentDate As DateTime = DateTime.Now


                If currentDate >= dueDate Then

                    Dim daysOverdue As Integer = Convert.ToInt32(Math.Max(0, (currentDate - dueDate).TotalDays))

                    Dim penalty As Decimal = 50 * daysOverdue

                    Dim transactionID As Integer = Convert.ToInt32(row("TransactionID"))
                    cmd = New SqlCommand($"UPDATE dbo.tblBookIssuing SET Penalty = '{penalty}' WHERE TransactionID = '{transactionID}'", con)
                    cmd.ExecuteNonQuery()

                    txtPenalty.Text = penalty.ToString()
                End If
            Next

        Finally
            con.Close()
            data()
        End Try
    End Sub

    Private Sub txtIssueTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIssueTo.KeyPress
        If Not (e.KeyChar = "N"c OrElse e.KeyChar = "S"c OrElse Char.IsWhiteSpace(e.KeyChar) OrElse e.KeyChar = "-"c OrElse Char.IsControl(e.KeyChar) OrElse Char.IsNumber(e.KeyChar)) Then
            e.Handled = True
        End If

        If txtIssueTo.Text.Length >= 15 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class