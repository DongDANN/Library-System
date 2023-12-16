<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword_1
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
        Me.txtBookIssuing = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSecretQuestion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSecretQuestionAnswer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSubmitAnswer = New System.Windows.Forms.Button()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBookIssuing
        '
        Me.txtBookIssuing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBookIssuing.AutoSize = True
        Me.txtBookIssuing.BackColor = System.Drawing.Color.White
        Me.txtBookIssuing.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookIssuing.Location = New System.Drawing.Point(101, 9)
        Me.txtBookIssuing.Name = "txtBookIssuing"
        Me.txtBookIssuing.Size = New System.Drawing.Size(390, 41)
        Me.txtBookIssuing.TabIndex = 99
        Me.txtBookIssuing.Text = "PASSWORD RECOVERY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 22)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "SECRET QUESTION:"
        '
        'txtSecretQuestion
        '
        Me.txtSecretQuestion.Enabled = False
        Me.txtSecretQuestion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretQuestion.Location = New System.Drawing.Point(99, 120)
        Me.txtSecretQuestion.Multiline = True
        Me.txtSecretQuestion.Name = "txtSecretQuestion"
        Me.txtSecretQuestion.Size = New System.Drawing.Size(403, 58)
        Me.txtSecretQuestion.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "ANSWER:"
        '
        'txtSecretQuestionAnswer
        '
        Me.txtSecretQuestionAnswer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretQuestionAnswer.Location = New System.Drawing.Point(99, 253)
        Me.txtSecretQuestionAnswer.Multiline = True
        Me.txtSecretQuestionAnswer.Name = "txtSecretQuestionAnswer"
        Me.txtSecretQuestionAnswer.Size = New System.Drawing.Size(403, 28)
        Me.txtSecretQuestionAnswer.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(96, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "(3 tries only)"
        '
        'btnSubmitAnswer
        '
        Me.btnSubmitAnswer.BackColor = System.Drawing.Color.White
        Me.btnSubmitAnswer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmitAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSubmitAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitAnswer.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitAnswer.ForeColor = System.Drawing.Color.Black
        Me.btnSubmitAnswer.Location = New System.Drawing.Point(99, 315)
        Me.btnSubmitAnswer.Name = "btnSubmitAnswer"
        Me.btnSubmitAnswer.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnSubmitAnswer.Size = New System.Drawing.Size(137, 31)
        Me.btnSubmitAnswer.TabIndex = 105
        Me.btnSubmitAnswer.Text = "SUBMIT ANSWER"
        Me.btnSubmitAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmitAnswer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmitAnswer.UseVisualStyleBackColor = False
        '
        'Background
        '
        Me.Background.Image = Global.Library_System.My.Resources.Resources._384527697_288197124071625_7702703534551933066_n
        Me.Background.Location = New System.Drawing.Point(-120, -91)
        Me.Background.Margin = New System.Windows.Forms.Padding(2)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(753, 562)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 106
        Me.Background.TabStop = False
        '
        'ForgotPassword_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 450)
        Me.Controls.Add(Me.btnSubmitAnswer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSecretQuestionAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSecretQuestion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBookIssuing)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassword_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPasswordSecretQuestion"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBookIssuing As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecretQuestion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSecretQuestionAnswer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSubmitAnswer As Button
    Friend WithEvents Background As PictureBox
End Class
