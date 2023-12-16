<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalBooks = New System.Windows.Forms.TextBox()
        Me.txtBorrowers = New System.Windows.Forms.TextBox()
        Me.txtActiveBooksBorrowed = New System.Windows.Forms.TextBox()
        Me.LateReturnsDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlTotalBooks = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlBorrowers = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlLateReturns = New System.Windows.Forms.Panel()
        Me.txtLateReturns = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBookIssuing = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LateReturnsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalBooks.SuspendLayout()
        Me.pnlBorrowers.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlLateReturns.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Background.TabIndex = 10
        Me.Background.TabStop = False
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
        Me.Chart.TabIndex = 0
        Me.Chart.Text = "Chart1"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(587, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "LATE RETURNS:"
        '
        'txtTotalBooks
        '
        Me.txtTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalBooks.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalBooks.Location = New System.Drawing.Point(74, 34)
        Me.txtTotalBooks.Multiline = True
        Me.txtTotalBooks.Name = "txtTotalBooks"
        Me.txtTotalBooks.Size = New System.Drawing.Size(102, 46)
        Me.txtTotalBooks.TabIndex = 18
        '
        'txtBorrowers
        '
        Me.txtBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBorrowers.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtBorrowers.Location = New System.Drawing.Point(73, 34)
        Me.txtBorrowers.Multiline = True
        Me.txtBorrowers.Name = "txtBorrowers"
        Me.txtBorrowers.Size = New System.Drawing.Size(95, 46)
        Me.txtBorrowers.TabIndex = 19
        '
        'txtActiveBooksBorrowed
        '
        Me.txtActiveBooksBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtActiveBooksBorrowed.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActiveBooksBorrowed.Location = New System.Drawing.Point(86, 34)
        Me.txtActiveBooksBorrowed.Name = "txtActiveBooksBorrowed"
        Me.txtActiveBooksBorrowed.Size = New System.Drawing.Size(100, 46)
        Me.txtActiveBooksBorrowed.TabIndex = 20
        '
        'LateReturnsDataGrid
        '
        Me.LateReturnsDataGrid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LateReturnsDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.LateReturnsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LateReturnsDataGrid.Location = New System.Drawing.Point(424, 221)
        Me.LateReturnsDataGrid.Name = "LateReturnsDataGrid"
        Me.LateReturnsDataGrid.Size = New System.Drawing.Size(406, 295)
        Me.LateReturnsDataGrid.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(571, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 99
        '
        'pnlTotalBooks
        '
        Me.pnlTotalBooks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlTotalBooks.BackColor = System.Drawing.Color.White
        Me.pnlTotalBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotalBooks.Controls.Add(Me.Label7)
        Me.pnlTotalBooks.Controls.Add(Me.txtTotalBooks)
        Me.pnlTotalBooks.Location = New System.Drawing.Point(12, 72)
        Me.pnlTotalBooks.Name = "pnlTotalBooks"
        Me.pnlTotalBooks.Size = New System.Drawing.Size(200, 100)
        Me.pnlTotalBooks.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "TOTAL BOOKS:"
        '
        'pnlBorrowers
        '
        Me.pnlBorrowers.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlBorrowers.BackColor = System.Drawing.Color.White
        Me.pnlBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBorrowers.Controls.Add(Me.Label8)
        Me.pnlBorrowers.Controls.Add(Me.txtBorrowers)
        Me.pnlBorrowers.Location = New System.Drawing.Point(218, 72)
        Me.pnlBorrowers.Name = "pnlBorrowers"
        Me.pnlBorrowers.Size = New System.Drawing.Size(200, 100)
        Me.pnlBorrowers.TabIndex = 101
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "BORROWERS:"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtActiveBooksBorrowed)
        Me.Panel3.Location = New System.Drawing.Point(424, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ACTIVE BOOKS BORROWED:"
        '
        'pnlLateReturns
        '
        Me.pnlLateReturns.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnlLateReturns.BackColor = System.Drawing.Color.White
        Me.pnlLateReturns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLateReturns.Controls.Add(Me.txtLateReturns)
        Me.pnlLateReturns.Controls.Add(Me.Label1)
        Me.pnlLateReturns.Location = New System.Drawing.Point(630, 72)
        Me.pnlLateReturns.Name = "pnlLateReturns"
        Me.pnlLateReturns.Size = New System.Drawing.Size(200, 100)
        Me.pnlLateReturns.TabIndex = 101
        '
        'txtLateReturns
        '
        Me.txtLateReturns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLateReturns.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLateReturns.Location = New System.Drawing.Point(85, 34)
        Me.txtLateReturns.Name = "txtLateReturns"
        Me.txtLateReturns.Size = New System.Drawing.Size(100, 46)
        Me.txtLateReturns.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "LATE RETURNS:"
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
        Me.txtBookIssuing.TabIndex = 102
        Me.txtBookIssuing.Text = "UCC LIBRARY SYSTEM"
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
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 528)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBookIssuing)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pnlLateReturns)
        Me.Controls.Add(Me.LateReturnsDataGrid)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlBorrowers)
        Me.Controls.Add(Me.pnlTotalBooks)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LateReturnsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalBooks.ResumeLayout(False)
        Me.pnlTotalBooks.PerformLayout()
        Me.pnlBorrowers.ResumeLayout(False)
        Me.pnlBorrowers.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlLateReturns.ResumeLayout(False)
        Me.pnlLateReturns.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As PictureBox
    Friend WithEvents Chart As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalBooks As TextBox
    Friend WithEvents txtBorrowers As TextBox
    Friend WithEvents txtActiveBooksBorrowed As TextBox
    Friend WithEvents LateReturnsDataGrid As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlTotalBooks As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlBorrowers As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents pnlLateReturns As Panel
    Friend WithEvents txtLateReturns As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBookIssuing As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
