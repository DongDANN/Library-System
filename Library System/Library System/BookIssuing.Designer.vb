<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookIssuing
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
        Me.txtBookIssuing = New System.Windows.Forms.Label()
        Me.txtIssuingDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIssueTo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BookIssuingDataGrid = New System.Windows.Forms.DataGridView()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtGroupName = New System.Windows.Forms.ComboBox()
        Me.txtBookISBN = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.PriceDue = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.ComboBox()
        Me.txtIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTrs = New System.Windows.Forms.Label()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        CType(Me.BookIssuingDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBookIssuing
        '
        Me.txtBookIssuing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBookIssuing.AutoSize = True
        Me.txtBookIssuing.BackColor = System.Drawing.Color.White
        Me.txtBookIssuing.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookIssuing.Location = New System.Drawing.Point(175, 9)
        Me.txtBookIssuing.Name = "txtBookIssuing"
        Me.txtBookIssuing.Size = New System.Drawing.Size(462, 41)
        Me.txtBookIssuing.TabIndex = 91
        Me.txtBookIssuing.Text = "BOOK ISSUING/RETURNING"
        '
        'txtIssuingDueDate
        '
        Me.txtIssuingDueDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIssuingDueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtIssuingDueDate.Location = New System.Drawing.Point(576, 285)
        Me.txtIssuingDueDate.Name = "txtIssuingDueDate"
        Me.txtIssuingDueDate.Size = New System.Drawing.Size(185, 20)
        Me.txtIssuingDueDate.TabIndex = 90
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(419, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 22)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "DUE DATE:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(419, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 22)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "ISSUING DATE:"
        '
        'txtIssueTo
        '
        Me.txtIssueTo.FormattingEnabled = True
        Me.txtIssueTo.Location = New System.Drawing.Point(182, 247)
        Me.txtIssueTo.Name = "txtIssueTo"
        Me.txtIssueTo.Size = New System.Drawing.Size(200, 21)
        Me.txtIssueTo.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 22)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "ISSUE TO:"
        '
        'BookIssuingDataGrid
        '
        Me.BookIssuingDataGrid.AllowUserToAddRows = False
        Me.BookIssuingDataGrid.AllowUserToDeleteRows = False
        Me.BookIssuingDataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookIssuingDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.BookIssuingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BookIssuingDataGrid.Location = New System.Drawing.Point(44, 321)
        Me.BookIssuingDataGrid.Name = "BookIssuingDataGrid"
        Me.BookIssuingDataGrid.ReadOnly = True
        Me.BookIssuingDataGrid.Size = New System.Drawing.Size(717, 147)
        Me.BookIssuingDataGrid.TabIndex = 80
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuthor.Enabled = False
        Me.txtAuthor.Location = New System.Drawing.Point(561, 79)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(200, 20)
        Me.txtAuthor.TabIndex = 77
        '
        'txtPublisher
        '
        Me.txtPublisher.Enabled = False
        Me.txtPublisher.Location = New System.Drawing.Point(182, 197)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(200, 20)
        Me.txtPublisher.TabIndex = 76
        '
        'txtBookName
        '
        Me.txtBookName.Enabled = False
        Me.txtBookName.Location = New System.Drawing.Point(182, 155)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(200, 20)
        Me.txtBookName.TabIndex = 75
        '
        'txtGroupName
        '
        Me.txtGroupName.Enabled = False
        Me.txtGroupName.FormattingEnabled = True
        Me.txtGroupName.Location = New System.Drawing.Point(182, 113)
        Me.txtGroupName.Name = "txtGroupName"
        Me.txtGroupName.Size = New System.Drawing.Size(200, 21)
        Me.txtGroupName.TabIndex = 74
        '
        'txtBookISBN
        '
        Me.txtBookISBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBookISBN.FormattingEnabled = True
        Me.txtBookISBN.Location = New System.Drawing.Point(182, 77)
        Me.txtBookISBN.Name = "txtBookISBN"
        Me.txtBookISBN.Size = New System.Drawing.Size(200, 21)
        Me.txtBookISBN.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(419, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 22)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "STATUS:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(419, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 22)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "AUTHOR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 22)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "PUBLISHER:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 22)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "BOOK NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 22)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "GROUP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "ISBN:"
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(561, 157)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 20)
        Me.txtPrice.TabIndex = 93
        Me.txtPrice.Text = "0"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(419, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 22)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "PRICE:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 61)
        Me.Panel1.TabIndex = 94
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = Global.Library_System.My.Resources.Resources.trash
        Me.btnDelete.Location = New System.Drawing.Point(253, 485)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 50)
        Me.btnDelete.TabIndex = 97
        Me.btnDelete.Text = "RETURN"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.Image = Global.Library_System.My.Resources.Resources.pencil_simple
        Me.btnEdit.Location = New System.Drawing.Point(148, 485)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(81, 50)
        Me.btnEdit.TabIndex = 96
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNew.Image = Global.Library_System.My.Resources.Resources.file_plus
        Me.btnNew.Location = New System.Drawing.Point(44, 485)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(79, 50)
        Me.btnNew.TabIndex = 95
        Me.btnNew.Text = "NEW"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Background
        '
        Me.Background.BackColor = System.Drawing.Color.White
        Me.Background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Background.Image = Global.Library_System.My.Resources.Resources.Blank_1_Panel_Landscape_Comic_Strip__1_1
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(800, 559)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 98
        Me.Background.TabStop = False
        '
        'txtPenalty
        '
        Me.txtPenalty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPenalty.Enabled = False
        Me.txtPenalty.Location = New System.Drawing.Point(561, 197)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(200, 20)
        Me.txtPenalty.TabIndex = 100
        Me.txtPenalty.Text = "0"
        '
        'PriceDue
        '
        Me.PriceDue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PriceDue.AutoSize = True
        Me.PriceDue.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceDue.Location = New System.Drawing.Point(419, 193)
        Me.PriceDue.Name = "PriceDue"
        Me.PriceDue.Size = New System.Drawing.Size(105, 22)
        Me.PriceDue.TabIndex = 99
        Me.PriceDue.Text = "PENALTY:"
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.BackColor = System.Drawing.Color.White
        Me.txtStatus.DisplayMember = "Name"
        Me.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtStatus.Enabled = False
        Me.txtStatus.FormattingEnabled = True
        Me.txtStatus.Items.AddRange(New Object() {"Available", "Borrowed"})
        Me.txtStatus.Location = New System.Drawing.Point(561, 115)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(200, 21)
        Me.txtStatus.TabIndex = 110
        '
        'txtIssueDate
        '
        Me.txtIssueDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtIssueDate.Location = New System.Drawing.Point(576, 247)
        Me.txtIssueDate.Name = "txtIssueDate"
        Me.txtIssueDate.Size = New System.Drawing.Size(185, 20)
        Me.txtIssueDate.TabIndex = 111
        '
        'txtTrs
        '
        Me.txtTrs.AutoSize = True
        Me.txtTrs.BackColor = System.Drawing.Color.White
        Me.txtTrs.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrs.Location = New System.Drawing.Point(40, 285)
        Me.txtTrs.Name = "txtTrs"
        Me.txtTrs.Size = New System.Drawing.Size(179, 22)
        Me.txtTrs.TabIndex = 112
        Me.txtTrs.Text = "TRANSACTION ID:"
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Enabled = False
        Me.txtTransactionID.Location = New System.Drawing.Point(225, 285)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(157, 20)
        Me.txtTransactionID.TabIndex = 113
        '
        'BookIssuing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTransactionID)
        Me.Controls.Add(Me.txtTrs)
        Me.Controls.Add(Me.txtIssueDate)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtPenalty)
        Me.Controls.Add(Me.PriceDue)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBookIssuing)
        Me.Controls.Add(Me.txtIssuingDueDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIssueTo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BookIssuingDataGrid)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.txtGroupName)
        Me.Controls.Add(Me.txtBookISBN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookIssuing"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BookIssuingDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBookIssuing As Label
    Friend WithEvents txtIssuingDueDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIssueTo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BookIssuingDataGrid As DataGridView
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtGroupName As ComboBox
    Friend WithEvents txtBookISBN As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Background As PictureBox
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents PriceDue As Label
    Friend WithEvents txtStatus As ComboBox
    Friend WithEvents txtIssueDate As DateTimePicker
    Friend WithEvents txtTrs As Label
    Friend WithEvents txtTransactionID As TextBox
End Class
