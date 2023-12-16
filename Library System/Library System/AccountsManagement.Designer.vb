<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountsManagement
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
        Me.txtBookManagement = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.ComboBox()
        Me.TblaccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibrarydbDataSet = New Library_System.librarydbDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.txtStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAccountType = New System.Windows.Forms.ComboBox()
        Me.AccountManagementDataGrid = New System.Windows.Forms.DataGridView()
        Me.TblaccountsTableAdapter = New Library_System.librarydbDataSetTableAdapters.tblaccountsTableAdapter()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.btnShowConfirmPassword = New System.Windows.Forms.Button()
        CType(Me.TblaccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibrarydbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountManagementDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBookManagement
        '
        Me.txtBookManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBookManagement.AutoSize = True
        Me.txtBookManagement.BackColor = System.Drawing.Color.White
        Me.txtBookManagement.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookManagement.Location = New System.Drawing.Point(173, 9)
        Me.txtBookManagement.Name = "txtBookManagement"
        Me.txtBookManagement.Size = New System.Drawing.Size(444, 41)
        Me.txtBookManagement.TabIndex = 118
        Me.txtBookManagement.Text = "ACCOUNTS MANAGEMENT"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.Image = Global.Library_System.My.Resources.Resources.pencil_simple
        Me.btnUpdate.Location = New System.Drawing.Point(150, 482)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 50)
        Me.btnUpdate.TabIndex = 116
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNew.Image = Global.Library_System.My.Resources.Resources.file_plus
        Me.btnNew.Location = New System.Drawing.Point(46, 482)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(89, 50)
        Me.btnNew.TabIndex = 114
        Me.btnNew.Text = "NEW"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(269, 235)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(443, 20)
        Me.txtConfirmPassword.TabIndex = 111
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(269, 202)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(443, 20)
        Me.txtPassword.TabIndex = 110
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtName
        '
        Me.txtName.DataSource = Me.TblaccountsBindingSource
        Me.txtName.DisplayMember = "Name"
        Me.txtName.FormattingEnabled = True
        Me.txtName.Location = New System.Drawing.Point(269, 128)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(494, 21)
        Me.txtName.TabIndex = 108
        '
        'TblaccountsBindingSource
        '
        Me.TblaccountsBindingSource.DataMember = "tblaccounts"
        Me.TblaccountsBindingSource.DataSource = Me.LibrarydbDataSet
        '
        'LibrarydbDataSet
        '
        Me.LibrarydbDataSet.DataSetName = "librarydbDataSet"
        Me.LibrarydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 22)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "STATUS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 22)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "CONFIRM PASSWORD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 22)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "PASSWORD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 22)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "USERNAME:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtBookManagement)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 61)
        Me.Panel1.TabIndex = 119
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
        Me.Background.TabIndex = 120
        Me.Background.TabStop = False
        '
        'txtStatus
        '
        Me.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtStatus.FormattingEnabled = True
        Me.txtStatus.Items.AddRange(New Object() {"Active", "Disabled"})
        Me.txtStatus.Location = New System.Drawing.Point(269, 270)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(111, 21)
        Me.txtStatus.TabIndex = 124
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 22)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "ACCOUNT ROLE:"
        '
        'txtAccountType
        '
        Me.txtAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAccountType.FormattingEnabled = True
        Me.txtAccountType.Items.AddRange(New Object() {"Admin", "Librarian"})
        Me.txtAccountType.Location = New System.Drawing.Point(269, 93)
        Me.txtAccountType.Name = "txtAccountType"
        Me.txtAccountType.Size = New System.Drawing.Size(111, 21)
        Me.txtAccountType.TabIndex = 127
        '
        'AccountManagementDataGrid
        '
        Me.AccountManagementDataGrid.AllowUserToAddRows = False
        Me.AccountManagementDataGrid.AllowUserToDeleteRows = False
        Me.AccountManagementDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountManagementDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.AccountManagementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountManagementDataGrid.Location = New System.Drawing.Point(46, 308)
        Me.AccountManagementDataGrid.Name = "AccountManagementDataGrid"
        Me.AccountManagementDataGrid.ReadOnly = True
        Me.AccountManagementDataGrid.Size = New System.Drawing.Size(717, 168)
        Me.AccountManagementDataGrid.TabIndex = 129
        '
        'TblaccountsTableAdapter
        '
        Me.TblaccountsTableAdapter.ClearBeforeFill = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(269, 163)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(494, 20)
        Me.txtUsername.TabIndex = 130
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Library_System.My.Resources.Resources.trash
        Me.btnDelete.Location = New System.Drawing.Point(269, 482)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 50)
        Me.btnDelete.TabIndex = 117
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnShowPassword
        '
        Me.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassword.Image = Global.Library_System.My.Resources.Resources.eye
        Me.btnShowPassword.Location = New System.Drawing.Point(718, 202)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(45, 20)
        Me.btnShowPassword.TabIndex = 131
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'btnShowConfirmPassword
        '
        Me.btnShowConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowConfirmPassword.Image = Global.Library_System.My.Resources.Resources.eye
        Me.btnShowConfirmPassword.Location = New System.Drawing.Point(718, 235)
        Me.btnShowConfirmPassword.Name = "btnShowConfirmPassword"
        Me.btnShowConfirmPassword.Size = New System.Drawing.Size(45, 20)
        Me.btnShowConfirmPassword.TabIndex = 132
        Me.btnShowConfirmPassword.UseVisualStyleBackColor = True
        '
        'AccountsManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.btnShowConfirmPassword)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.AccountManagementDataGrid)
        Me.Controls.Add(Me.txtAccountType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountsManagement"
        Me.Text = "AccountsManagement"
        CType(Me.TblaccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibrarydbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountManagementDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBookManagement As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtName As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Background As PictureBox
    Friend WithEvents txtStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAccountType As ComboBox
    Friend WithEvents AccountManagementDataGrid As DataGridView
    Friend WithEvents LibrarydbDataSet As librarydbDataSet
    Friend WithEvents TblaccountsBindingSource As BindingSource
    Friend WithEvents TblaccountsTableAdapter As librarydbDataSetTableAdapters.tblaccountsTableAdapter
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents btnShowConfirmPassword As Button
End Class
