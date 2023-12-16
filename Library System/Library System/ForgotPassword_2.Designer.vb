<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPassword_2
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
        Me.btnPasswordSubmit = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBookIssuing = New System.Windows.Forms.Label()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPasswordSubmit
        '
        Me.btnPasswordSubmit.BackColor = System.Drawing.Color.White
        Me.btnPasswordSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPasswordSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPasswordSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasswordSubmit.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasswordSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnPasswordSubmit.Location = New System.Drawing.Point(107, 205)
        Me.btnPasswordSubmit.Name = "btnPasswordSubmit"
        Me.btnPasswordSubmit.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnPasswordSubmit.Size = New System.Drawing.Size(79, 49)
        Me.btnPasswordSubmit.TabIndex = 172
        Me.btnPasswordSubmit.Text = "SUBMIT"
        Me.btnPasswordSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPasswordSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPasswordSubmit.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(331, 170)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(241, 20)
        Me.txtConfirmPassword.TabIndex = 171
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 22)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "CONFIRM PASSWORD:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(331, 141)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(241, 20)
        Me.txtNewPassword.TabIndex = 169
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 22)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "NEW PASSWORD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 22)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "CHANGE PASSWORD:"
        '
        'txtBookIssuing
        '
        Me.txtBookIssuing.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBookIssuing.AutoSize = True
        Me.txtBookIssuing.BackColor = System.Drawing.Color.White
        Me.txtBookIssuing.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookIssuing.Location = New System.Drawing.Point(114, 9)
        Me.txtBookIssuing.Name = "txtBookIssuing"
        Me.txtBookIssuing.Size = New System.Drawing.Size(390, 41)
        Me.txtBookIssuing.TabIndex = 173
        Me.txtBookIssuing.Text = "PASSWORD RECOVERY"
        '
        'Background
        '
        Me.Background.BackColor = System.Drawing.Color.White
        Me.Background.Image = Global.Library_System.My.Resources.Resources._384527697_288197124071625_7702703534551933066_n
        Me.Background.Location = New System.Drawing.Point(-62, -91)
        Me.Background.Margin = New System.Windows.Forms.Padding(2)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(753, 496)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 174
        Me.Background.TabStop = False
        '
        'ForgotPassword_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 314)
        Me.Controls.Add(Me.txtBookIssuing)
        Me.Controls.Add(Me.btnPasswordSubmit)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassword_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "/"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPasswordSubmit As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBookIssuing As Label
    Friend WithEvents Background As PictureBox
End Class
