<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllAccounts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllAccounts))
        Me.txtAllBooks = New System.Windows.Forms.Label()
        Me.AccountsGrid = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.LibrarydbDataSet = New Library_System.librarydbDataSet()
        Me.TblaccountsTableAdapter = New Library_System.librarydbDataSetTableAdapters.tblaccountsTableAdapter()
        Me.TblaccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShowAll = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.AccountsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblaccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAllBooks
        '
        Me.txtAllBooks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAllBooks.AutoSize = True
        Me.txtAllBooks.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllBooks.Location = New System.Drawing.Point(251, 9)
        Me.txtAllBooks.Name = "txtAllBooks"
        Me.txtAllBooks.Size = New System.Drawing.Size(271, 41)
        Me.txtAllBooks.TabIndex = 108
        Me.txtAllBooks.Text = "ALL ACCOUNTS"
        '
        'AccountsGrid
        '
        Me.AccountsGrid.AllowUserToAddRows = False
        Me.AccountsGrid.AllowUserToDeleteRows = False
        Me.AccountsGrid.AllowUserToOrderColumns = True
        Me.AccountsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountsGrid.BackgroundColor = System.Drawing.Color.White
        Me.AccountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountsGrid.Location = New System.Drawing.Point(17, 133)
        Me.AccountsGrid.Name = "AccountsGrid"
        Me.AccountsGrid.ReadOnly = True
        Me.AccountsGrid.Size = New System.Drawing.Size(771, 408)
        Me.AccountsGrid.TabIndex = 107
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(743, 84)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(45, 27)
        Me.btnSearch.TabIndex = 111
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(135, 84)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(602, 27)
        Me.txtSearch.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 27)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "SEARCH:"
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
        Me.Background.TabIndex = 112
        Me.Background.TabStop = False
        '
        'LibrarydbDataSet
        '
        Me.LibrarydbDataSet.DataSetName = "librarydbDataSet"
        Me.LibrarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblaccountsTableAdapter
        '
        Me.TblaccountsTableAdapter.ClearBeforeFill = True
        '
        'TblaccountsBindingSource
        '
        Me.TblaccountsBindingSource.DataMember = "tblaccounts"
        Me.TblaccountsBindingSource.DataSource = Me.LibrarydbDataSet
        '
        'ShowAll
        '
        Me.ShowAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowAll.AutoSize = True
        Me.ShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAll.Location = New System.Drawing.Point(592, 114)
        Me.ShowAll.Name = "ShowAll"
        Me.ShowAll.Size = New System.Drawing.Size(196, 16)
        Me.ShowAll.TabIndex = 113
        Me.ShowAll.Text = "(Click Me To Show all accounts)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 15)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "(Search using a detail of account ex. Username)"
        '
        'AllAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShowAll)
        Me.Controls.Add(Me.txtAllBooks)
        Me.Controls.Add(Me.AccountsGrid)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllAccounts"
        Me.Text = "All Accounts"
        CType(Me.AccountsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblaccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAllBooks As Label
    Friend WithEvents AccountsGrid As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Background As PictureBox
    Friend WithEvents LibrarydbDataSet As librarydbDataSet
    Friend WithEvents TblaccountsTableAdapter As librarydbDataSetTableAdapters.tblaccountsTableAdapter
    Friend WithEvents TblaccountsBindingSource As BindingSource
    Friend WithEvents ShowAll As Label
    Friend WithEvents Label6 As Label
End Class
