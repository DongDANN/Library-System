<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ITInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ITInterface))
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnDatabaseManagement = New System.Windows.Forms.Button()
        Me.btnAccountSetting = New System.Windows.Forms.Button()
        Me.btnAllAccounts = New System.Windows.Forms.Button()
        Me.btnAccountsManagement = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.txtITName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlFill = New System.Windows.Forms.Panel()
        Me.pnlSide.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.White
        Me.pnlSide.Controls.Add(Me.btnLogOut)
        Me.pnlSide.Controls.Add(Me.btnDatabaseManagement)
        Me.pnlSide.Controls.Add(Me.btnAccountSetting)
        Me.pnlSide.Controls.Add(Me.btnAllAccounts)
        Me.pnlSide.Controls.Add(Me.btnAccountsManagement)
        Me.pnlSide.Controls.Add(Me.btnDashboard)
        Me.pnlSide.Controls.Add(Me.pnlLogo)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(200, 543)
        Me.pnlSide.TabIndex = 2
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Image = Global.Library_System.My.Resources.Resources.user_switch
        Me.btnLogOut.Location = New System.Drawing.Point(0, 476)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(200, 60)
        Me.btnLogOut.TabIndex = 18
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnDatabaseManagement
        '
        Me.btnDatabaseManagement.BackColor = System.Drawing.Color.White
        Me.btnDatabaseManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDatabaseManagement.FlatAppearance.BorderSize = 0
        Me.btnDatabaseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatabaseManagement.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatabaseManagement.Image = Global.Library_System.My.Resources.Resources.database
        Me.btnDatabaseManagement.Location = New System.Drawing.Point(0, 416)
        Me.btnDatabaseManagement.Name = "btnDatabaseManagement"
        Me.btnDatabaseManagement.Size = New System.Drawing.Size(200, 60)
        Me.btnDatabaseManagement.TabIndex = 17
        Me.btnDatabaseManagement.Text = "Database Management"
        Me.btnDatabaseManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDatabaseManagement.UseVisualStyleBackColor = False
        '
        'btnAccountSetting
        '
        Me.btnAccountSetting.BackColor = System.Drawing.Color.White
        Me.btnAccountSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccountSetting.FlatAppearance.BorderSize = 0
        Me.btnAccountSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountSetting.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountSetting.Image = Global.Library_System.My.Resources.Resources.user_circle_gear
        Me.btnAccountSetting.Location = New System.Drawing.Point(0, 356)
        Me.btnAccountSetting.Name = "btnAccountSetting"
        Me.btnAccountSetting.Size = New System.Drawing.Size(200, 60)
        Me.btnAccountSetting.TabIndex = 16
        Me.btnAccountSetting.Text = "My Account"
        Me.btnAccountSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccountSetting.UseVisualStyleBackColor = False
        '
        'btnAllAccounts
        '
        Me.btnAllAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAllAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAllAccounts.FlatAppearance.BorderSize = 0
        Me.btnAllAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllAccounts.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAllAccounts.Image = Global.Library_System.My.Resources.Resources.user_list
        Me.btnAllAccounts.Location = New System.Drawing.Point(0, 292)
        Me.btnAllAccounts.Name = "btnAllAccounts"
        Me.btnAllAccounts.Size = New System.Drawing.Size(200, 64)
        Me.btnAllAccounts.TabIndex = 15
        Me.btnAllAccounts.Text = "All Accounts"
        Me.btnAllAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllAccounts.UseVisualStyleBackColor = True
        '
        'btnAccountsManagement
        '
        Me.btnAccountsManagement.BackColor = System.Drawing.Color.Transparent
        Me.btnAccountsManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccountsManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccountsManagement.FlatAppearance.BorderSize = 0
        Me.btnAccountsManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountsManagement.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountsManagement.Image = Global.Library_System.My.Resources.Resources.user_circle_plus
        Me.btnAccountsManagement.Location = New System.Drawing.Point(0, 234)
        Me.btnAccountsManagement.Name = "btnAccountsManagement"
        Me.btnAccountsManagement.Size = New System.Drawing.Size(200, 58)
        Me.btnAccountsManagement.TabIndex = 12
        Me.btnAccountsManagement.Text = "Accounts Management"
        Me.btnAccountsManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccountsManagement.UseMnemonic = False
        Me.btnAccountsManagement.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.White
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Image = Global.Library_System.My.Resources.Resources.chart_pie
        Me.btnDashboard.Location = New System.Drawing.Point(0, 176)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 58)
        Me.btnDashboard.TabIndex = 11
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.txtITName)
        Me.pnlLogo.Controls.Add(Me.PictureBox1)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(200, 176)
        Me.pnlLogo.TabIndex = 2
        '
        'txtITName
        '
        Me.txtITName.AutoSize = True
        Me.txtITName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtITName.Location = New System.Drawing.Point(63, 145)
        Me.txtITName.Name = "txtITName"
        Me.txtITName.Size = New System.Drawing.Size(75, 19)
        Me.txtITName.TabIndex = 2
        Me.txtITName.Text = "IT Admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.Library_System.My.Resources.Resources.user_circle__1_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlFill
        '
        Me.pnlFill.AutoSize = True
        Me.pnlFill.BackColor = System.Drawing.Color.White
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(200, 0)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(826, 543)
        Me.pnlFill.TabIndex = 3
        '
        'ITInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 543)
        Me.Controls.Add(Me.pnlFill)
        Me.Controls.Add(Me.pnlSide)
        Me.Name = "ITInterface"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITInterface"
        Me.pnlSide.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSide As Panel
    Friend WithEvents btnAccountSetting As Button
    Friend WithEvents btnAllAccounts As Button
    Friend WithEvents btnAccountsManagement As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents txtITName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlFill As Panel
    Friend WithEvents btnDatabaseManagement As Button
    Friend WithEvents btnLogOut As Button
End Class
