<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ITDatabaseManagement
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
        Me.txtAllBooks = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAllBooks
        '
        Me.txtAllBooks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAllBooks.AutoSize = True
        Me.txtAllBooks.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllBooks.Location = New System.Drawing.Point(170, 9)
        Me.txtAllBooks.Name = "txtAllBooks"
        Me.txtAllBooks.Size = New System.Drawing.Size(435, 41)
        Me.txtAllBooks.TabIndex = 115
        Me.txtAllBooks.Text = "DATABASE MANAGEMENT"
        '
        'btnBackup
        '
        Me.btnBackup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackup.BackColor = System.Drawing.Color.White
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBackup.ForeColor = System.Drawing.Color.Black
        Me.btnBackup.Image = Global.Library_System.My.Resources.Resources.download
        Me.btnBackup.Location = New System.Drawing.Point(177, 136)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(157, 238)
        Me.btnBackup.TabIndex = 121
        Me.btnBackup.Text = "BACKUP"
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.BackColor = System.Drawing.Color.White
        Me.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.Black
        Me.btnRestore.Image = Global.Library_System.My.Resources.Resources.clock_clockwise
        Me.btnRestore.Location = New System.Drawing.Point(431, 136)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(174, 238)
        Me.btnRestore.TabIndex = 120
        Me.btnRestore.Text = "RESTORE"
        Me.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRestore.UseVisualStyleBackColor = False
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
        Me.Background.TabIndex = 119
        Me.Background.TabStop = False
        '
        'ITDatabaseManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.txtAllBooks)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ITDatabaseManagement"
        Me.Text = "ITDatabaseManagement"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Background As PictureBox
    Friend WithEvents txtAllBooks As Label
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnBackup As Button
End Class
