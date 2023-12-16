<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyAccount
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
        Me.txtBookManagement = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExistingSecretQuestion = New System.Windows.Forms.TextBox()
        Me.txtNewQuestion = New System.Windows.Forms.ComboBox()
        Me.txtNewAnswer = New System.Windows.Forms.TextBox()
        Me.txtExistingSecretQuestionAnswer = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtExistingPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSecretQuestionSubmit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPasswordSubmit = New System.Windows.Forms.Button()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Background.TabIndex = 128
        Me.Background.TabStop = False
        '
        'txtBookManagement
        '
        Me.txtBookManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBookManagement.AutoSize = True
        Me.txtBookManagement.BackColor = System.Drawing.Color.White
        Me.txtBookManagement.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookManagement.Location = New System.Drawing.Point(269, 19)
        Me.txtBookManagement.Name = "txtBookManagement"
        Me.txtBookManagement.Size = New System.Drawing.Size(239, 41)
        Me.txtBookManagement.TabIndex = 138
        Me.txtBookManagement.Text = "MY ACCOUNT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(132, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 22)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "NEW QUESTION:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(132, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 22)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "NEW ANSWER:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 22)
        Me.Label8.TabIndex = 149
        Me.Label8.Text = "EXISTING ANSWER:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(131, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 22)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "EXISTING QUESTION:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 22)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "CHANGE SECRET QUESTION:"
        '
        'txtExistingSecretQuestion
        '
        Me.txtExistingSecretQuestion.Enabled = False
        Me.txtExistingSecretQuestion.Location = New System.Drawing.Point(366, 136)
        Me.txtExistingSecretQuestion.Name = "txtExistingSecretQuestion"
        Me.txtExistingSecretQuestion.Size = New System.Drawing.Size(411, 20)
        Me.txtExistingSecretQuestion.TabIndex = 155
        '
        'txtNewQuestion
        '
        Me.txtNewQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtNewQuestion.FormattingEnabled = True
        Me.txtNewQuestion.Items.AddRange(New Object() {"What color do you like the most?", "Who’s your favorite artist?", "What book do you recommend to your friends?", "What was the name of your first school teacher?", "What year did you enter college?", "What is your grandmother’s maiden name?", "What is your child’s nickname?", "What is the manufacturer of your first car?", "What sport do you prefer the most?"})
        Me.txtNewQuestion.Location = New System.Drawing.Point(366, 203)
        Me.txtNewQuestion.Name = "txtNewQuestion"
        Me.txtNewQuestion.Size = New System.Drawing.Size(411, 21)
        Me.txtNewQuestion.TabIndex = 154
        '
        'txtNewAnswer
        '
        Me.txtNewAnswer.Location = New System.Drawing.Point(366, 233)
        Me.txtNewAnswer.Name = "txtNewAnswer"
        Me.txtNewAnswer.Size = New System.Drawing.Size(241, 20)
        Me.txtNewAnswer.TabIndex = 153
        '
        'txtExistingSecretQuestionAnswer
        '
        Me.txtExistingSecretQuestionAnswer.Location = New System.Drawing.Point(366, 169)
        Me.txtExistingSecretQuestionAnswer.Name = "txtExistingSecretQuestionAnswer"
        Me.txtExistingSecretQuestionAnswer.Size = New System.Drawing.Size(241, 20)
        Me.txtExistingSecretQuestionAnswer.TabIndex = 152
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(371, 423)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(241, 20)
        Me.txtConfirmPassword.TabIndex = 163
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 22)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "CONFIRM PASSWORD:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(371, 393)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(241, 20)
        Me.txtNewPassword.TabIndex = 161
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 22)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "NEW PASSWORD:"
        '
        'txtExistingPassword
        '
        Me.txtExistingPassword.Location = New System.Drawing.Point(371, 363)
        Me.txtExistingPassword.Name = "txtExistingPassword"
        Me.txtExistingPassword.Size = New System.Drawing.Size(241, 20)
        Me.txtExistingPassword.TabIndex = 159
        Me.txtExistingPassword.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(143, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 22)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "EXISTING PASSWORD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 22)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "CHANGE PASSWORD:"
        '
        'btnSecretQuestionSubmit
        '
        Me.btnSecretQuestionSubmit.BackColor = System.Drawing.Color.White
        Me.btnSecretQuestionSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecretQuestionSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSecretQuestionSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecretQuestionSubmit.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecretQuestionSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSecretQuestionSubmit.Location = New System.Drawing.Point(135, 266)
        Me.btnSecretQuestionSubmit.Name = "btnSecretQuestionSubmit"
        Me.btnSecretQuestionSubmit.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnSecretQuestionSubmit.Size = New System.Drawing.Size(79, 49)
        Me.btnSecretQuestionSubmit.TabIndex = 166
        Me.btnSecretQuestionSubmit.Text = "SUBMIT"
        Me.btnSecretQuestionSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSecretQuestionSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSecretQuestionSubmit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Library_System.My.Resources.Resources.University_of_Caloocan_City_Coat_of_Arms
        Me.PictureBox1.Location = New System.Drawing.Point(708, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 165
        Me.PictureBox1.TabStop = False
        '
        'btnPasswordSubmit
        '
        Me.btnPasswordSubmit.BackColor = System.Drawing.Color.White
        Me.btnPasswordSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPasswordSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPasswordSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasswordSubmit.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasswordSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnPasswordSubmit.Location = New System.Drawing.Point(140, 460)
        Me.btnPasswordSubmit.Name = "btnPasswordSubmit"
        Me.btnPasswordSubmit.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnPasswordSubmit.Size = New System.Drawing.Size(79, 49)
        Me.btnPasswordSubmit.TabIndex = 164
        Me.btnPasswordSubmit.Text = "SUBMIT"
        Me.btnPasswordSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPasswordSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPasswordSubmit.UseVisualStyleBackColor = False
        '
        'btnShowPassword
        '
        Me.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassword.Image = Global.Library_System.My.Resources.Resources.eye
        Me.btnShowPassword.Location = New System.Drawing.Point(629, 363)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(45, 20)
        Me.btnShowPassword.TabIndex = 167
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Library_System.My.Resources.Resources.eye
        Me.Button1.Location = New System.Drawing.Point(629, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 20)
        Me.Button1.TabIndex = 168
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Library_System.My.Resources.Resources.eye
        Me.Button2.Location = New System.Drawing.Point(629, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 20)
        Me.Button2.TabIndex = 169
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MyAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 559)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.btnSecretQuestionSubmit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPasswordSubmit)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtExistingPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtExistingSecretQuestion)
        Me.Controls.Add(Me.txtNewQuestion)
        Me.Controls.Add(Me.txtNewAnswer)
        Me.Controls.Add(Me.txtExistingSecretQuestionAnswer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBookManagement)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MyAccount"
        Me.Text = "MY ACCOUNT"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Background As PictureBox
    Friend WithEvents txtBookManagement As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExistingSecretQuestion As TextBox
    Friend WithEvents txtNewQuestion As ComboBox
    Friend WithEvents txtNewAnswer As TextBox
    Friend WithEvents txtExistingSecretQuestionAnswer As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtExistingPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSecretQuestionSubmit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPasswordSubmit As Button
    Friend WithEvents btnShowPassword As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
