<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentedBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentedBooks))
        Me.RentedBooksDataGrid = New System.Windows.Forms.DataGridView()
        Me.txtRentedBooks = New System.Windows.Forms.Label()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGroupName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowAll = New System.Windows.Forms.Button()
        CType(Me.RentedBooksDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RentedBooksDataGrid
        '
        Me.RentedBooksDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RentedBooksDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.RentedBooksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentedBooksDataGrid.Location = New System.Drawing.Point(12, 180)
        Me.RentedBooksDataGrid.Name = "RentedBooksDataGrid"
        Me.RentedBooksDataGrid.Size = New System.Drawing.Size(776, 367)
        Me.RentedBooksDataGrid.TabIndex = 0
        '
        'txtRentedBooks
        '
        Me.txtRentedBooks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRentedBooks.AutoSize = True
        Me.txtRentedBooks.BackColor = System.Drawing.Color.White
        Me.txtRentedBooks.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRentedBooks.Location = New System.Drawing.Point(262, 9)
        Me.txtRentedBooks.Name = "txtRentedBooks"
        Me.txtRentedBooks.Size = New System.Drawing.Size(277, 41)
        Me.txtRentedBooks.TabIndex = 1
        Me.txtRentedBooks.Text = "RENTED BOOKS"
        '
        'Background
        '
        Me.Background.BackColor = System.Drawing.Color.White
        Me.Background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Background.Image = Global.Library_System.My.Resources.Resources.Blank_1_Panel_Landscape_Comic_Strip__1_
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(800, 559)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 100
        Me.Background.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(743, 82)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(45, 27)
        Me.btnSearch.TabIndex = 103
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(135, 82)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(602, 27)
        Me.txtSearch.TabIndex = 102
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.White
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(12, 82)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(117, 27)
        Me.lblSearch.TabIndex = 101
        Me.lblSearch.Text = "SEARCH:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 15)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "(Search the Transaction ID or Name of Book)"
        '
        'txtGroupName
        '
        Me.txtGroupName.FormattingEnabled = True
        Me.txtGroupName.Location = New System.Drawing.Point(135, 140)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(200, 21)
        Me.txtGroupName.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 22)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "GROUP:"
        '
        'btnShowAll
        '
        Me.btnShowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowAll.BackColor = System.Drawing.Color.White
        Me.btnShowAll.FlatAppearance.BorderSize = 0
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.btnShowAll.Location = New System.Drawing.Point(602, 112)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(198, 23)
        Me.btnShowAll.TabIndex = 119
        Me.btnShowAll.Text = "(Click Me To Show all books)"
        Me.btnShowAll.UseVisualStyleBackColor = False
        '
        'RentedBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtRentedBooks)
        Me.Controls.Add(Me.RentedBooksDataGrid)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RentedBooks"
        CType(Me.RentedBooksDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RentedBooksDataGrid As DataGridView
    Friend WithEvents txtRentedBooks As Label
    Friend WithEvents Background As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGroupName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowAll As Button
End Class
