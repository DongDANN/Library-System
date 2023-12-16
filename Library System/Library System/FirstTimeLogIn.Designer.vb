<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstTimeLogIn
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
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.btnSecretQuestionSubmit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNewAnswer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBookManagement = New System.Windows.Forms.Label()
        Me.txtConfirmAnswer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewQuestion = New System.Windows.Forms.ComboBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Background
        '
        Me.Background.Image = Global.Library_System.My.Resources.Resources._384527697_288197124071625_7702703534551933066_n
        Me.Background.Location = New System.Drawing.Point(-33, -149)
        Me.Background.Margin = New System.Windows.Forms.Padding(2)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(703, 544)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 31
        Me.Background.TabStop = False
        '
        'btnSecretQuestionSubmit
        '
        Me.btnSecretQuestionSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSecretQuestionSubmit.BackColor = System.Drawing.Color.White
        Me.btnSecretQuestionSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecretQuestionSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSecretQuestionSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecretQuestionSubmit.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecretQuestionSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSecretQuestionSubmit.Location = New System.Drawing.Point(481, 323)
        Me.btnSecretQuestionSubmit.Name = "btnSecretQuestionSubmit"
        Me.btnSecretQuestionSubmit.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnSecretQuestionSubmit.Size = New System.Drawing.Size(87, 43)
        Me.btnSecretQuestionSubmit.TabIndex = 167
        Me.btnSecretQuestionSubmit.Text = "CANCEL"
        Me.btnSecretQuestionSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSecretQuestionSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSecretQuestionSubmit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(26, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(79, 49)
        Me.Button1.TabIndex = 173
        Me.Button1.Text = "SUBMIT"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtNewAnswer
        '
        Me.txtNewAnswer.Location = New System.Drawing.Point(222, 144)
        Me.txtNewAnswer.Name = "txtNewAnswer"
        Me.txtNewAnswer.Size = New System.Drawing.Size(241, 20)
        Me.txtNewAnswer.TabIndex = 171
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 22)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "QUESTION:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 22)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "ANSWER:"
        '
        'txtBookManagement
        '
        Me.txtBookManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBookManagement.AutoSize = True
        Me.txtBookManagement.BackColor = System.Drawing.Color.White
        Me.txtBookManagement.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookManagement.Location = New System.Drawing.Point(84, 20)
        Me.txtBookManagement.Name = "txtBookManagement"
        Me.txtBookManagement.Size = New System.Drawing.Size(407, 41)
        Me.txtBookManagement.TabIndex = 174
        Me.txtBookManagement.Text = "ADD SECRET QUESTION"
        '
        'txtConfirmAnswer
        '
        Me.txtConfirmAnswer.Location = New System.Drawing.Point(222, 179)
        Me.txtConfirmAnswer.Name = "txtConfirmAnswer"
        Me.txtConfirmAnswer.Size = New System.Drawing.Size(241, 20)
        Me.txtConfirmAnswer.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 22)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "CONFIRM ANSWER:"
        '
        'txtNewQuestion
        '
        Me.txtNewQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtNewQuestion.FormattingEnabled = True
        Me.txtNewQuestion.Items.AddRange(New Object() {"What color do you like the most?", "Who’s your favorite artist?", "What book do you recommend to your friends?", "What was the name of your first school teacher?", "What year did you enter college?", "What is your grandmother’s maiden name?", "What is your child’s nickname?", "What is the manufacturer of your first car?", "What sport do you prefer the most?"})
        Me.txtNewQuestion.Location = New System.Drawing.Point(222, 108)
        Me.txtNewQuestion.Name = "txtNewQuestion"
        Me.txtNewQuestion.Size = New System.Drawing.Size(330, 21)
        Me.txtNewQuestion.TabIndex = 178
        '
        'FirstTimeLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 378)
        Me.Controls.Add(Me.txtNewQuestion)
        Me.Controls.Add(Me.txtConfirmAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBookManagement)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNewAnswer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSecretQuestionSubmit)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FirstTimeLogIn"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Background As PictureBox
    Friend WithEvents btnSecretQuestionSubmit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNewAnswer As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBookManagement As Label
    Friend WithEvents txtConfirmAnswer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewQuestion As ComboBox
End Class
