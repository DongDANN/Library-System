<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtLogIn = New System.Windows.Forms.Label()
        Me.txtForgotPassword = New System.Windows.Forms.Label()
        Me.btnShowPassword = New System.Windows.Forms.Button()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.Location = New System.Drawing.Point(140, 240)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(272, 29)
        Me.txtPassword.TabIndex = 15
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtUsername.Location = New System.Drawing.Point(140, 188)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(272, 29)
        Me.txtUsername.TabIndex = 14
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.White
        Me.lblPass.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblPass.ForeColor = System.Drawing.Color.Black
        Me.lblPass.Location = New System.Drawing.Point(28, 240)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(105, 22)
        Me.lblPass.TabIndex = 13
        Me.lblPass.Text = "Password  :"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.White
        Me.lblUser.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(24, 191)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(110, 22)
        Me.lblUser.TabIndex = 12
        Me.lblUser.Text = "Username  :"
        '
        'txtLogIn
        '
        Me.txtLogIn.AutoSize = True
        Me.txtLogIn.BackColor = System.Drawing.Color.Transparent
        Me.txtLogIn.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogIn.ForeColor = System.Drawing.Color.Black
        Me.txtLogIn.Location = New System.Drawing.Point(170, 120)
        Me.txtLogIn.Name = "txtLogIn"
        Me.txtLogIn.Size = New System.Drawing.Size(145, 50)
        Me.txtLogIn.TabIndex = 11
        Me.txtLogIn.Text = "LOGIN"
        '
        'txtForgotPassword
        '
        Me.txtForgotPassword.AutoSize = True
        Me.txtForgotPassword.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForgotPassword.Location = New System.Drawing.Point(301, 272)
        Me.txtForgotPassword.Name = "txtForgotPassword"
        Me.txtForgotPassword.Size = New System.Drawing.Size(111, 16)
        Me.txtForgotPassword.TabIndex = 31
        Me.txtForgotPassword.Text = "Forgot Password?"
        '
        'btnShowPassword
        '
        Me.btnShowPassword.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowPassword.Image = Global.Library_System.My.Resources.Resources.eye
        Me.btnShowPassword.Location = New System.Drawing.Point(418, 240)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New System.Drawing.Size(45, 30)
        Me.btnShowPassword.TabIndex = 32
        Me.btnShowPassword.UseVisualStyleBackColor = True
        '
        'LOGO
        '
        Me.LOGO.BackColor = System.Drawing.Color.White
        Me.LOGO.Image = CType(resources.GetObject("LOGO.Image"), System.Drawing.Image)
        Me.LOGO.Location = New System.Drawing.Point(392, 12)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(71, 63)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 18
        Me.LOGO.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Image = Global.Library_System.My.Resources.Resources.sign_out__1_
        Me.btnExit.Location = New System.Drawing.Point(284, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(17, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(127, 46)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "EXIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.White
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.Black
        Me.btnLogIn.Image = Global.Library_System.My.Resources.Resources.sign_in__1_
        Me.btnLogIn.Location = New System.Drawing.Point(140, 330)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnLogIn.Size = New System.Drawing.Size(124, 46)
        Me.btnLogIn.TabIndex = 16
        Me.btnLogIn.Text = "LOGIN"
        Me.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'Background
        '
        Me.Background.Image = Global.Library_System.My.Resources.Resources._384527697_288197124071625_7702703534551933066_n
        Me.Background.Location = New System.Drawing.Point(-12, -4)
        Me.Background.Margin = New System.Windows.Forms.Padding(2)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(541, 456)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 30
        Me.Background.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(475, 450)
        Me.Controls.Add(Me.btnShowPassword)
        Me.Controls.Add(Me.txtForgotPassword)
        Me.Controls.Add(Me.LOGO)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtLogIn)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminLogin"
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LOGO As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents txtLogIn As Label
    Friend WithEvents Background As PictureBox
    Friend WithEvents txtForgotPassword As Label
    Friend WithEvents btnShowPassword As Button
End Class
