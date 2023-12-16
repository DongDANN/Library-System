Imports System.Data.SqlClient

Public Class Dashboard

    Dim Totalbooks As Integer
    Dim Borrowers As Integer
    Dim ActiveBookBorrowed As Integer
    Dim LateReturns As Integer

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        LibrarianInterface.Hide()
        Login.Show()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub WelcomeToAdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BookIssuing.CalculateAndUpdatePenalties()
        LoadAccountStatistics()
        DisplayAccountStatistics()
        data()
        For Each col As DataGridViewColumn In LateReturnsDataGrid.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub
    Private Sub LoadAccountStatistics()
        Try
            con.Open()

            Using cmdTotalbooks As New SqlCommand("SELECT COUNT(*) FROM dbo.tblBookDetails", con)
                Totalbooks = Convert.ToInt32(cmdTotalbooks.ExecuteScalar())
            End Using


            Using cmdBorrowers As New SqlCommand("SELECT COUNT(*) FROM dbo.tblBorrower", con)
                Borrowers = Convert.ToInt32(cmdBorrowers.ExecuteScalar())
            End Using

            Using cmdActiveBookBorrowed As New SqlCommand("SELECT COUNT(*) FROM dbo.tblBookIssuing", con)
                ActiveBookBorrowed = Convert.ToInt32(cmdActiveBookBorrowed.ExecuteScalar())
            End Using

            Using cmdLateReturns As New SqlCommand("SELECT COUNT(*) FROM dbo.tblBookIssuing WHERE Penalty <> 0.00", con)
                LateReturns = Convert.ToInt32(cmdLateReturns.ExecuteScalar())
            End Using
        Finally
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub DisplayAccountStatistics()

        txtTotalBooks.Text = Totalbooks.ToString()
        txtBorrowers.Text = Borrowers.ToString()
        txtActiveBooksBorrowed.Text = ActiveBookBorrowed.ToString()
        txtLateReturns.Text = LateReturns.ToString()


        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("TOTAL BOOKS", Totalbooks)
        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("BORROWERS", Borrowers)
        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("ACTIVE BOOKS BORROWED", ActiveBookBorrowed)
        Me.Chart.Series("TOTAL NUMBER").Points.AddXY("LATE RETURNS", LateReturns)
    End Sub
    Private Sub data()
        Dim query As String = "SELECT * FROM dbo.tblBookIssuing WHERE Penalty <> 0.00"
        cmd = New SqlCommand(query, con)
        sd = New SqlDataAdapter(cmd)
        dt = New DataTable()
        sd.Fill(dt)
        LateReturnsDataGrid.DataSource = dt
    End Sub

    Private Sub txtTotalBooks_TextChanged(sender As Object, e As EventArgs) Handles txtTotalBooks.TextChanged

    End Sub

    Private Sub LateReturnsDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles LateReturnsDataGrid.CellContentClick

    End Sub
End Class