Imports System.Data.SqlClient

Public Class ITInterface

    Private currentChildForm As Form

    Private Sub ITInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDashboard.PerformClick()

    End Sub



    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New ITDashboard()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage
        btnDashboard.BackColor = Color.FromArgb(248, 146, 87)

        btnAccountsManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountsManagement.BackColor = Color.Transparent
        btnAllAccounts.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllAccounts.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent
        btnDatabaseManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDatabaseManagement.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnAccountsManagement_Click(sender As Object, e As EventArgs) Handles btnAccountsManagement.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New AccountsManagement()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnAccountsManagement.TextImageRelation = TextImageRelation.TextBeforeImage
        btnAccountsManagement.BackColor = Color.FromArgb(248, 146, 87)

        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent
        btnAllAccounts.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllAccounts.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent
        btnDatabaseManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDatabaseManagement.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnAllAccounts_Click(sender As Object, e As EventArgs) Handles btnAllAccounts.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New AllAccounts()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnAllAccounts.TextImageRelation = TextImageRelation.TextBeforeImage
        btnAllAccounts.BackColor = Color.FromArgb(248, 146, 87)

        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent
        btnAccountsManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountsManagement.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent
        btnDatabaseManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDatabaseManagement.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

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

        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent
        btnAccountsManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountsManagement.BackColor = Color.Transparent
        btnAllAccounts.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllAccounts.BackColor = Color.Transparent
        btnDatabaseManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDatabaseManagement.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnDatabaseManagement_Click(sender As Object, e As EventArgs) Handles btnDatabaseManagement.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Hide()
        End If

        Dim childForm As New ITDatabaseManagement()
        childForm.TopLevel = False
        pnlFill.Controls.Add(childForm)
        childForm.Dock = DockStyle.Fill
        childForm.Show()

        btnDatabaseManagement.TextImageRelation = TextImageRelation.TextBeforeImage
        btnDatabaseManagement.BackColor = Color.FromArgb(248, 146, 87)

        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.BackColor = Color.Transparent
        btnAccountsManagement.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountsManagement.BackColor = Color.Transparent
        btnAllAccounts.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAllAccounts.BackColor = Color.Transparent
        btnAccountSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAccountSetting.BackColor = Color.Transparent

        currentChildForm = childForm
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class