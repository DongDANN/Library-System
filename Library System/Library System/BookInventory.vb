Imports System.Data.SqlClient

Public Class BookInventory

    Private Sub data()
        cmd = New SqlCommand("Select * from dbo.tblBookDetails", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        BookManagementDataGrid.DataSource = dt

        txtBookISBN.DataSource = dt
        txtBookISBN.DisplayMember = "ISBN"

        cmd = New SqlCommand("SELECT DISTINCT GroupName FROM dbo.tblBookDetails", con)
        sd = New SqlDataAdapter(cmd)
        Dim groupNameTable As New DataTable()
        sd.Fill(groupNameTable)
        txtGroupName.DataSource = groupNameTable
        txtGroupName.DisplayMember = "GroupName"

        cmd = New SqlCommand("SELECT DISTINCT Publisher FROM dbo.tblBookDetails", con)
        sd = New SqlDataAdapter(cmd)
        Dim publisherNameTable As New DataTable()
        sd.Fill(publisherNameTable)
        txtPublisher.DataSource = publisherNameTable
        txtPublisher.DisplayMember = "Publisher"
    End Sub

    Private Function IsISBNExists(ISBN As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM dbo.tblBookDetails WHERE ISBN = '" + ISBN + "'"

        Try
            con.Open()

            Using cmdCheckISBN As New SqlCommand(query, con)
                Dim count As Integer = Convert.ToInt32(cmdCheckISBN.ExecuteScalar())
                Return count > 0
            End Using
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Function

    Private Sub BookDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data()
        For Each col As DataGridViewColumn In BookManagementDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        SetGridViewSortState(BookManagementDataGrid, DataGridViewColumnSortMode.NotSortable)
    End Sub

    Public Sub SetGridViewSortState(dgv As DataGridView, sortMode As DataGridViewColumnSortMode)
        For Each col As DataGridViewColumn In BookManagementDataGrid.Columns
            col.SortMode = sortMode
        Next
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not String.IsNullOrEmpty(txtBookISBN.Text) AndAlso
        Not String.IsNullOrEmpty(txtGroupName.Text) AndAlso
        Not String.IsNullOrEmpty(txtBookName.Text) AndAlso
        Not String.IsNullOrEmpty(txtPublisher.Text) AndAlso
        Not String.IsNullOrEmpty(txtAuthor.Text) AndAlso
        Not String.IsNullOrEmpty(txtStatus.Text) AndAlso
        Not String.IsNullOrEmpty(txtPrice.Text) Then

            Try
                con.Open()

                Dim checkQuery As String = "SELECT COUNT(*) FROM dbo.tblBookDetails WHERE ISBN=@ISBN"
                cmd = New SqlCommand(checkQuery, con)
                cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count > 0 Then

                    Dim query As String = "UPDATE dbo.tblBookDetails SET GroupName=@GroupName, BookName=@BookName, Publisher=@Publisher, Author=@Author, Status=@Status, Price=@Price WHERE ISBN=@ISBN"
                    cmd = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@GroupName", txtGroupName.Text)
                    cmd.Parameters.AddWithValue("@BookName", txtBookName.Text)
                    cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text)
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text)
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully updated.")
                    data()
                Else
                    MessageBox.Show("Book with ISBN " + txtBookISBN.Text + " does not exist.")
                End If
            Finally
                con.Close()
            End Try
        Else
            MessageBox.Show("All fields must be filled out.")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Not String.IsNullOrEmpty(txtBookISBN.Text) AndAlso
        Not String.IsNullOrEmpty(txtGroupName.Text) AndAlso
        Not String.IsNullOrEmpty(txtBookName.Text) AndAlso
        Not String.IsNullOrEmpty(txtPublisher.Text) AndAlso
        Not String.IsNullOrEmpty(txtAuthor.Text) AndAlso
        Not String.IsNullOrEmpty(txtStatus.Text) AndAlso
        Not String.IsNullOrEmpty(txtPrice.Text) Then

            If Not IsISBNExists(txtBookISBN.Text) Then
                Try
                    con.Open()

                    Dim query As String = "INSERT INTO dbo.tblBookDetails (ISBN, GroupName, BookName, Publisher, Author, Status, Price) VALUES (@ISBN, @GroupName, @BookName, @Publisher, @Author, @Status, @Price)"
                    cmd = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                    cmd.Parameters.AddWithValue("@GroupName", txtGroupName.Text)
                    cmd.Parameters.AddWithValue("@BookName", txtBookName.Text)
                    cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text)
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text)
                    cmd.Parameters.AddWithValue("@Price", txtPrice.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Successfully added.")
                    con.Close()
                    data()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show("ISBN already exists. Please choose a different ISBN.")
            End If
        Else
            MessageBox.Show("Fields cannot be empty.")
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtBookISBN.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete and archive this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    con.Open()


                    Dim archiveQuery As String = "INSERT INTO dbo.tblBookDetails_archive (ISBN, GroupName, BookName, Publisher, Author, Status, Price) " &
                                            "SELECT ISBN, GroupName, BookName, Publisher, Author, Status, Price FROM dbo.tblBookDetails WHERE ISBN=@ISBN"
                    cmd = New SqlCommand(archiveQuery, con)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                    cmd.ExecuteNonQuery()

                    Dim deleteQuery As String = "DELETE FROM dbo.tblBookDetails WHERE ISBN=@ISBN"
                    cmd = New SqlCommand(deleteQuery, con)
                    cmd.Parameters.AddWithValue("@ISBN", txtBookISBN.Text)
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Successfully Deleted and Archived.")
                    data()
                Catch Borrowed As Exception
                    MessageBox.Show("Book is still being borrowed")
                Finally
                    con.Close()
                End Try
            End If
        Else
            MessageBox.Show("Enter ISBN of the Book Above.")
        End If
    End Sub



    Private Sub txtBookISBN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBookISBN.SelectedIndexChanged
        If txtBookISBN.SelectedIndex <> -1 Then
            Dim selectedRow As DataRow = dt.Rows(txtBookISBN.SelectedIndex)
            txtGroupName.Text = selectedRow("GroupName").ToString()
            txtBookName.Text = selectedRow("BookName").ToString()
            txtPublisher.Text = selectedRow("Publisher").ToString()
            txtAuthor.Text = selectedRow("Author").ToString()
            txtStatus.Text = selectedRow("Status").ToString()
            txtPrice.Text = selectedRow("Price").ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        con.Open()
        cmd = New SqlCommand("Select * from dbo.tblBookDetails where Name='" + txtBookISBN.Text + "'", con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        BookManagementDataGrid.DataSource = dt
        con.Close()
    End Sub

    Private Sub txtBookISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBookISBN.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtGroupName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGroupName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAuthor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuthor.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPublisher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPublisher.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBookName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBookName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Background_Click(sender As Object, e As EventArgs) Handles Background.Click

    End Sub

    Private Sub BookManagementDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookManagementDataGrid.CellContentClick

    End Sub
End Class