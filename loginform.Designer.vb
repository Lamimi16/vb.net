<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        LblUsername = New Label()
        LblPassword = New Label()
        BtnLogin = New Button()
        SuspendLayout()
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(109, 151)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(255, 23)
        TxtUsername.TabIndex = 0
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(109, 222)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(255, 23)
        TxtPassword.TabIndex = 1
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblUsername.ForeColor = Color.IndianRed
        LblUsername.Location = New Point(44, 151)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(42, 21)
        LblUsername.TabIndex = 2
        LblUsername.Text = "nom"
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblPassword.ForeColor = Color.IndianRed
        LblPassword.Location = New Point(-1, 222)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(104, 21)
        LblPassword.TabIndex = 3
        LblPassword.Text = "Mot de passe"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.LavenderBlush
        BtnLogin.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = Color.DarkSalmon
        BtnLogin.Location = New Point(484, 264)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(150, 50)
        BtnLogin.TabIndex = 4
        BtnLogin.Text = "se connecter"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' loginform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnLogin)
        Controls.Add(LblPassword)
        Controls.Add(LblUsername)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Name = "loginform"
        Text = "loginform"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents BtnLogin As Button
End Class
