<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDisabledAccounts = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBookIssuing = New System.Windows.Forms.Label()
        Me.pnlBorrowers = New System.Windows.Forms.Panel()
        Me.txtActiveAccounts = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RecentLoginsDataGrid = New System.Windows.Forms.DataGridView()
        Me.txtTotalAccounts = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlTotalBooks = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.pnlBorrowers.SuspendLayout()
        CType(Me.RecentLoginsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalBooks.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "DISABLED ACCOUNTS:"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtDisabledAccounts)
        Me.Panel3.Location = New System.Drawing.Point(424, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 111
        '
        'txtDisabledAccounts
        '
        Me.txtDisabledAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDisabledAccounts.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisabledAccounts.Location = New System.Drawing.Point(85, 34)
        Me.txtDisabledAccounts.Name = "txtDisabledAccounts"
        Me.txtDisabledAccounts.Size = New System.Drawing.Size(94, 46)
        Me.txtDisabledAccounts.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ACTIVE ACCOUNTS:"
        '
        'txtBookIssuing
        '
        Me.txtBookIssuing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBookIssuing.AutoSize = True
        Me.txtBookIssuing.BackColor = System.Drawing.Color.White
        Me.txtBookIssuing.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookIssuing.Location = New System.Drawing.Point(12, 16)
        Me.txtBookIssuing.Name = "txtBookIssuing"
        Me.txtBookIssuing.Size = New System.Drawing.Size(385, 41)
        Me.txtBookIssuing.TabIndex = 113
        Me.txtBookIssuing.Text = "UCC LIBRARY SYSTEM"
        '
        'pnlBorrowers
        '
        Me.pnlBorrowers.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlBorrowers.BackColor = System.Drawing.Color.White
        Me.pnlBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBorrowers.Controls.Add(Me.Label8)
        Me.pnlBorrowers.Controls.Add(Me.txtActiveAccounts)
        Me.pnlBorrowers.Location = New System.Drawing.Point(218, 72)
        Me.pnlBorrowers.Name = "pnlBorrowers"
        Me.pnlBorrowers.Size = New System.Drawing.Size(200, 100)
        Me.pnlBorrowers.TabIndex = 112
        '
        'txtActiveAccounts
        '
        Me.txtActiveAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtActiveAccounts.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtActiveAccounts.Location = New System.Drawing.Point(60, 34)
        Me.txtActiveAccounts.Multiline = True
        Me.txtActiveAccounts.Name = "txtActiveAccounts"
        Me.txtActiveAccounts.Size = New System.Drawing.Size(95, 46)
        Me.txtActiveAccounts.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TOTAL ACCOUNTS:"
        '
        'RecentLoginsDataGrid
        '
        Me.RecentLoginsDataGrid.AllowUserToAddRows = False
        Me.RecentLoginsDataGrid.AllowUserToDeleteRows = False
        Me.RecentLoginsDataGrid.AllowUserToOrderColumns = True
        Me.RecentLoginsDataGrid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RecentLoginsDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.RecentLoginsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecentLoginsDataGrid.Location = New System.Drawing.Point(424, 221)
        Me.RecentLoginsDataGrid.Name = "RecentLoginsDataGrid"
        Me.RecentLoginsDataGrid.ReadOnly = True
        Me.RecentLoginsDataGrid.Size = New System.Drawing.Size(406, 295)
        Me.RecentLoginsDataGrid.TabIndex = 107
        '
        'txtTotalAccounts
        '
        Me.txtTotalAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalAccounts.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAccounts.Location = New System.Drawing.Point(62, 34)
        Me.txtTotalAccounts.Multiline = True
        Me.txtTotalAccounts.Name = "txtTotalAccounts"
        Me.txtTotalAccounts.Size = New System.Drawing.Size(102, 46)
        Me.txtTotalAccounts.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(580, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "RECENT LOGINS:"
        '
        'Chart
        '
        Me.Chart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Chart.BorderlineColor = System.Drawing.Color.Black
        Me.Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Location = New System.Drawing.Point(12, 187)
        Me.Chart.Name = "Chart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Legend = "Legend1"
        Series1.Name = "TOTAL NUMBER"
        Me.Chart.Series.Add(Series1)
        Me.Chart.Size = New System.Drawing.Size(409, 329)
        Me.Chart.TabIndex = 104
        Me.Chart.Text = "Chart1"
        '
        'pnlTotalBooks
        '
        Me.pnlTotalBooks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlTotalBooks.BackColor = System.Drawing.Color.White
        Me.pnlTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotalBooks.Controls.Add(Me.Label7)
        Me.pnlTotalBooks.Controls.Add(Me.txtTotalAccounts)
        Me.pnlTotalBooks.Location = New System.Drawing.Point(12, 72)
        Me.pnlTotalBooks.Name = "pnlTotalBooks"
        Me.pnlTotalBooks.Size = New System.Drawing.Size(200, 100)
        Me.pnlTotalBooks.TabIndex = 109
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Library_System.My.Resources.Resources.University_of_Caloocan_City_Coat_of_Arms
        Me.PictureBox1.Location = New System.Drawing.Point(765, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'Background
        '
        Me.Background.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Background.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Background.Image = Global.Library_System.My.Resources.Resources.llnmlm2
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(839, 528)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 105
        Me.Background.TabStop = False
        '
        'ITDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 528)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtBookIssuing)
        Me.Controls.Add(Me.pnlBorrowers)
        Me.Controls.Add(Me.RecentLoginsDataGrid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.pnlTotalBooks)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ITDashboard"
        Me.Text = "ITDashboard"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlBorrowers.ResumeLayout(False)
        Me.pnlBorrowers.PerformLayout()
        CType(Me.RecentLoginsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalBooks.ResumeLayout(False)
        Me.pnlTotalBooks.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDisabledAccounts As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBookIssuing As Label
    Friend WithEvents pnlBorrowers As Panel
    Friend WithEvents txtActiveAccounts As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RecentLoginsDataGrid As DataGridView
    Friend WithEvents txtTotalAccounts As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents pnlTotalBooks As Panel
    Friend WithEvents Background As PictureBox
End Class
