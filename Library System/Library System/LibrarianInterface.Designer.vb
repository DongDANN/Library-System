<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibrarianInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibrarianInterface))
        Me.pnlSide = New System.Windows.Forms.Panel()
        Me.btnAccountSetting = New System.Windows.Forms.Button()
        Me.btnAllBooks = New System.Windows.Forms.Button()
        Me.btnRentedBooks = New System.Windows.Forms.Button()
        Me.btnBookIssuing = New System.Windows.Forms.Button()
        Me.btnBookDetails = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.txtLibrarianName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlFill = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlSide.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSide
        '
        Me.pnlSide.BackColor = System.Drawing.Color.White
        Me.pnlSide.Controls.Add(Me.Button1)
        Me.pnlSide.Controls.Add(Me.btnAccountSetting)
        Me.pnlSide.Controls.Add(Me.btnAllBooks)
        Me.pnlSide.Controls.Add(Me.btnRentedBooks)
        Me.pnlSide.Controls.Add(Me.btnBookIssuing)
        Me.pnlSide.Controls.Add(Me.btnBookDetails)
        Me.pnlSide.Controls.Add(Me.btnDashboard)
        Me.pnlSide.Controls.Add(Me.pnlLogo)
        Me.pnlSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlSide.Name = "pnlSide"
        Me.pnlSide.Size = New System.Drawing.Size(200, 605)
        Me.pnlSide.TabIndex = 1
        '
        'btnAccountSetting
        '
        Me.btnAccountSetting.BackColor = System.Drawing.Color.White
        Me.btnAccountSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccountSetting.FlatAppearance.BorderSize = 0
        Me.btnAccountSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountSetting.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountSetting.Image = Global.Library_System.My.Resources.Resources.user_circle_gear
        Me.btnAccountSetting.Location = New System.Drawing.Point(0, 483)
        Me.btnAccountSetting.Name = "btnAccountSetting"
        Me.btnAccountSetting.Size = New System.Drawing.Size(200, 60)
        Me.btnAccountSetting.TabIndex = 16
        Me.btnAccountSetting.Text = "My Account"
        Me.btnAccountSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccountSetting.UseVisualStyleBackColor = False
        '
        'btnAllBooks
        '
        Me.btnAllBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAllBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAllBooks.FlatAppearance.BorderSize = 0
        Me.btnAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllBooks.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnAllBooks.Image = Global.Library_System.My.Resources.Resources.books
        Me.btnAllBooks.Location = New System.Drawing.Point(0, 419)
        Me.btnAllBooks.Name = "btnAllBooks"
        Me.btnAllBooks.Size = New System.Drawing.Size(200, 64)
        Me.btnAllBooks.TabIndex = 15
        Me.btnAllBooks.Text = "All Books"
        Me.btnAllBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAllBooks.UseVisualStyleBackColor = True
        '
        'btnRentedBooks
        '
        Me.btnRentedBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRentedBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRentedBooks.FlatAppearance.BorderSize = 0
        Me.btnRentedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRentedBooks.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRentedBooks.Image = Global.Library_System.My.Resources.Resources.book_open
        Me.btnRentedBooks.Location = New System.Drawing.Point(0, 354)
        Me.btnRentedBooks.Name = "btnRentedBooks"
        Me.btnRentedBooks.Size = New System.Drawing.Size(200, 65)
        Me.btnRentedBooks.TabIndex = 14
        Me.btnRentedBooks.Text = "Rented Books"
        Me.btnRentedBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRentedBooks.UseVisualStyleBackColor = True
        '
        'btnBookIssuing
        '
        Me.btnBookIssuing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookIssuing.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBookIssuing.FlatAppearance.BorderSize = 0
        Me.btnBookIssuing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookIssuing.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBookIssuing.Image = Global.Library_System.My.Resources.Resources.calendar
        Me.btnBookIssuing.Location = New System.Drawing.Point(0, 292)
        Me.btnBookIssuing.Name = "btnBookIssuing"
        Me.btnBookIssuing.Size = New System.Drawing.Size(200, 62)
        Me.btnBookIssuing.TabIndex = 13
        Me.btnBookIssuing.Text = "Book Issuing/Returning"
        Me.btnBookIssuing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBookIssuing.UseVisualStyleBackColor = True
        '
        'btnBookDetails
        '
        Me.btnBookDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnBookDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBookDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBookDetails.FlatAppearance.BorderSize = 0
        Me.btnBookDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookDetails.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookDetails.Image = Global.Library_System.My.Resources.Resources.book_bookmark
        Me.btnBookDetails.Location = New System.Drawing.Point(0, 234)
        Me.btnBookDetails.Name = "btnBookDetails"
        Me.btnBookDetails.Size = New System.Drawing.Size(200, 58)
        Me.btnBookDetails.TabIndex = 12
        Me.btnBookDetails.Text = "Book Inventory"
        Me.btnBookDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBookDetails.UseMnemonic = False
        Me.btnBookDetails.UseVisualStyleBackColor = False
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
        Me.pnlLogo.Controls.Add(Me.txtLibrarianName)
        Me.pnlLogo.Controls.Add(Me.PictureBox1)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(200, 176)
        Me.pnlLogo.TabIndex = 2
        '
        'txtLibrarianName
        '
        Me.txtLibrarianName.AutoSize = True
        Me.txtLibrarianName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLibrarianName.Location = New System.Drawing.Point(60, 145)
        Me.txtLibrarianName.Name = "txtLibrarianName"
        Me.txtLibrarianName.Size = New System.Drawing.Size(77, 19)
        Me.txtLibrarianName.TabIndex = 2
        Me.txtLibrarianName.Text = "Librarian"
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
        Me.pnlFill.Size = New System.Drawing.Size(826, 605)
        Me.pnlFill.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Library_System.My.Resources.Resources.user_switch
        Me.Button1.Location = New System.Drawing.Point(0, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 60)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Log Out"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LibrarianInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 605)
        Me.Controls.Add(Me.pnlFill)
        Me.Controls.Add(Me.pnlSide)
        Me.Name = "LibrarianInterface"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Librarian Interface"
        Me.pnlSide.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlSide As Panel
    Friend WithEvents pnlFill As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnBookDetails As Button
    Friend WithEvents btnBookIssuing As Button
    Friend WithEvents btnRentedBooks As Button
    Friend WithEvents btnAllBooks As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtLibrarianName As Label
    Friend WithEvents btnAccountSetting As Button
    Friend WithEvents Button1 As Button
End Class
