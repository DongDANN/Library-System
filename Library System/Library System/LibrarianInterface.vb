Public Class LibrarianInterface
    Private currentChildForm As Form
    Private Sub btnAccountSetting_Click(sender As Object, e As EventArgs) Handles btnAccountSetting.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New MyAccount()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnAccountSetting.TextImageRelation = TextImageRelation.TextBeforeImage
        btnAccountSetting.BackColor = Color.FromArgb(248, 146, 87)

        btnBookIssuing.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookIssuing.BackColor = Color.Transparent
        btnAllBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllBooks.BackColor = Color.Transparent
        btnRentedBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRentedBooks.BackColor = Color.Transparent
        btnBookDetails.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookDetails.BackColor = Color.Transparent
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnAllBooks_Click(sender As Object, e As EventArgs) Handles btnAllBooks.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New AllBooks()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnAllBooks.TextImageRelation = TextImageRelation.TextBeforeImage
        btnAllBooks.BackColor = Color.FromArgb(248, 146, 87)

        btnBookIssuing.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookIssuing.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent
        btnRentedBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRentedBooks.BackColor = Color.Transparent
        btnBookDetails.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookDetails.BackColor = Color.Transparent
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnRentedBooks_Click(sender As Object, e As EventArgs) Handles btnRentedBooks.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New RentedBooks()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnRentedBooks.TextImageRelation = TextImageRelation.TextBeforeImage
        btnRentedBooks.BackColor = Color.FromArgb(248, 146, 87)

        btnBookIssuing.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookIssuing.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent
        btnBookDetails.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookDetails.BackColor = Color.Transparent
        btnAllBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllBooks.BackColor = Color.Transparent
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnBookIssuing_Click(sender As Object, e As EventArgs) Handles btnBookIssuing.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New BookIssuing()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnBookIssuing.TextImageRelation = TextImageRelation.TextBeforeImage
        btnBookIssuing.BackColor = Color.FromArgb(248, 146, 87)

        btnBookDetails.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookDetails.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent
        btnRentedBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRentedBooks.BackColor = Color.Transparent
        btnAllBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllBooks.BackColor = Color.Transparent
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnBookDetails_Click(sender As Object, e As EventArgs) Handles btnBookDetails.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New BookInventory()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnBookDetails.TextImageRelation = TextImageRelation.TextBeforeImage
        btnBookDetails.BackColor = Color.FromArgb(248, 146, 87)

        btnBookIssuing.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookIssuing.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent
        btnRentedBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRentedBooks.BackColor = Color.Transparent
        btnAllBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllBooks.BackColor = Color.Transparent
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New Dashboard()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage
        btnDashboard.BackColor = Color.FromArgb(248, 146, 87)

        btnBookDetails.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookDetails.BackColor = Color.Transparent
        btnBookIssuing.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBookIssuing.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent
        btnRentedBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnRentedBooks.BackColor = Color.Transparent
        btnAllBooks.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllBooks.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub LibrarianInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.PerformClick()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlSide_Paint(sender As Object, e As PaintEventArgs) Handles pnlSide.Paint

    End Sub

    Private Sub pnlLogo_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogo.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class