<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userform
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
        Label1 = New Label()
        TxtDestination = New TextBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        BtnRechercher = New Button()
        DataGridView1 = New DataGridView()
        Columns0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        TxtNom = New TextBox()
        TxtPrenom = New TextBox()
        Label4 = New Label()
        TxtTelephone = New TextBox()
        Label5 = New Label()
        BtnReserver = New Button()
        DataGridView2 = New DataGridView()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Salmon
        Label1.Location = New Point(41, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 0
        Label1.Text = "Destination"
        ' 
        ' TxtDestination
        ' 
        TxtDestination.ForeColor = Color.Salmon
        TxtDestination.Location = New Point(134, 25)
        TxtDestination.Name = "TxtDestination"
        TxtDestination.Size = New Size(100, 23)
        TxtDestination.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Salmon
        Label2.Location = New Point(451, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 2
        Label2.Text = "Date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(520, 25)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' BtnRechercher
        ' 
        BtnRechercher.BackColor = Color.Gainsboro
        BtnRechercher.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnRechercher.ForeColor = Color.IndianRed
        BtnRechercher.Location = New Point(620, 137)
        BtnRechercher.Name = "BtnRechercher"
        BtnRechercher.Size = New Size(140, 37)
        BtnRechercher.TabIndex = 4
        BtnRechercher.Text = "Rechercher"
        BtnRechercher.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Columns0, Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(3, 138)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(544, 62)
        DataGridView1.TabIndex = 5
        ' 
        ' Columns0
        ' 
        Columns0.HeaderText = "Numero de vol"
        Columns0.Name = "Columns0"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Destination"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Date et heure"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "places disponible"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Prix"
        Column4.Name = "Column4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.IndianRed
        Label3.Location = New Point(541, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 25)
        Label3.TabIndex = 7
        Label3.Text = "Nom"
        ' 
        ' TxtNom
        ' 
        TxtNom.Location = New Point(602, 203)
        TxtNom.Name = "TxtNom"
        TxtNom.Size = New Size(100, 23)
        TxtNom.TabIndex = 8
        ' 
        ' TxtPrenom
        ' 
        TxtPrenom.Location = New Point(605, 253)
        TxtPrenom.Name = "TxtPrenom"
        TxtPrenom.Size = New Size(100, 23)
        TxtPrenom.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.IndianRed
        Label4.Location = New Point(520, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 25)
        Label4.TabIndex = 10
        Label4.Text = "Prenom"
        ' 
        ' TxtTelephone
        ' 
        TxtTelephone.Location = New Point(605, 295)
        TxtTelephone.Name = "TxtTelephone"
        TxtTelephone.Size = New Size(100, 23)
        TxtTelephone.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.IndianRed
        Label5.Location = New Point(497, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 25)
        Label5.TabIndex = 12
        Label5.Text = "Telephone"
        ' 
        ' BtnReserver
        ' 
        BtnReserver.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnReserver.ForeColor = Color.DarkSalmon
        BtnReserver.Location = New Point(643, 335)
        BtnReserver.Name = "BtnReserver"
        BtnReserver.Size = New Size(117, 28)
        BtnReserver.TabIndex = 13
        BtnReserver.Text = "Réserver"
        BtnReserver.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column5, Column6, Column7, Column8})
        DataGridView2.Location = New Point(30, 243)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(445, 46)
        DataGridView2.TabIndex = 14
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Nom"
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Prenom"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Téléphone"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Vol réservé"
        Column8.Name = "Column8"
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView2)
        Controls.Add(BtnReserver)
        Controls.Add(Label5)
        Controls.Add(TxtTelephone)
        Controls.Add(Label4)
        Controls.Add(TxtPrenom)
        Controls.Add(TxtNom)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(BtnRechercher)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(TxtDestination)
        Controls.Add(Label1)
        Name = "UserForm"
        Text = "userform"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDestination As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTelephone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnReserver As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Columns0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
