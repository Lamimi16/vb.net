<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btn_mult = New Button()
        Label1 = New Label()
        txt_A = New TextBox()
        txt_B = New TextBox()
        btn_minus = New Button()
        btn_rest = New Button()
        btn_div = New Button()
        btn_plus = New Button()
        btn_egal = New Button()
        Label2 = New Label()
        Label3 = New Label()
        lbl_res = New Label()
        SuspendLayout()
        ' 
        ' btn_mult
        ' 
        btn_mult.Location = New Point(123, 186)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(75, 23)
        btn_mult.TabIndex = 0
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 158)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 1
        Label1.Text = "RESULTAT"
        ' 
        ' txt_A
        ' 
        txt_A.Location = New Point(123, 107)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(100, 23)
        txt_A.TabIndex = 2
        ' 
        ' txt_B
        ' 
        txt_B.Location = New Point(285, 107)
        txt_B.Name = "txt_B"
        txt_B.Size = New Size(100, 23)
        txt_B.TabIndex = 3
        ' 
        ' btn_minus
        ' 
        btn_minus.Location = New Point(204, 186)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(75, 23)
        btn_minus.TabIndex = 4
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = True
        ' 
        ' btn_rest
        ' 
        btn_rest.Location = New Point(202, 311)
        btn_rest.Name = "btn_rest"
        btn_rest.Size = New Size(75, 23)
        btn_rest.TabIndex = 5
        btn_rest.Text = "RESET"
        btn_rest.UseVisualStyleBackColor = True
        ' 
        ' btn_div
        ' 
        btn_div.Location = New Point(202, 224)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(75, 23)
        btn_div.TabIndex = 6
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = True
        ' 
        ' btn_plus
        ' 
        btn_plus.Location = New Point(202, 282)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(75, 23)
        btn_plus.TabIndex = 7
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = True
        ' 
        ' btn_egal
        ' 
        btn_egal.Location = New Point(202, 253)
        btn_egal.Name = "btn_egal"
        btn_egal.Size = New Size(75, 23)
        btn_egal.TabIndex = 8
        btn_egal.Text = "="
        btn_egal.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(229, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(14, 15)
        Label2.TabIndex = 9
        Label2.Text = "B"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(15, 15)
        Label3.TabIndex = 10
        Label3.Text = "A"
        ' 
        ' lbl_res
        ' 
        lbl_res.AutoSize = True
        lbl_res.Location = New Point(150, 156)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(0, 15)
        lbl_res.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbl_res)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btn_egal)
        Controls.Add(btn_plus)
        Controls.Add(btn_div)
        Controls.Add(btn_rest)
        Controls.Add(btn_minus)
        Controls.Add(txt_B)
        Controls.Add(txt_A)
        Controls.Add(Label1)
        Controls.Add(btn_mult)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_mult As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_rest As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_egal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_res As Label

End Class
