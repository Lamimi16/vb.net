<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        TxtNumeroVol = New TextBox()
        TxtPrix = New TextBox()
        TxtPlacesDisponibles = New TextBox()
        TxtDestination = New TextBox()
        DateTimePicker2 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        BtnAjouter = New Button()
        BtnSupprimer = New Button()
        BtnModifier = New Button()
        DataGridView3 = New DataGridView()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtNumeroVol
        ' 
        TxtNumeroVol.Location = New Point(110, 22)
        TxtNumeroVol.Name = "TxtNumeroVol"
        TxtNumeroVol.Size = New Size(100, 23)
        TxtNumeroVol.TabIndex = 0
        ' 
        ' TxtPrix
        ' 
        TxtPrix.Location = New Point(53, 144)
        TxtPrix.Name = "TxtPrix"
        TxtPrix.Size = New Size(100, 23)
        TxtPrix.TabIndex = 1
        ' 
        ' TxtPlacesDisponibles
        ' 
        TxtPlacesDisponibles.Location = New Point(135, 101)
        TxtPlacesDisponibles.Name = "TxtPlacesDisponibles"
        TxtPlacesDisponibles.Size = New Size(100, 23)
        TxtPlacesDisponibles.TabIndex = 2
        ' 
        ' TxtDestination
        ' 
        TxtDestination.Location = New Point(85, 67)
        TxtDestination.Name = "TxtDestination"
        TxtDestination.Size = New Size(100, 23)
        TxtDestination.TabIndex = 3
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(390, 41)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 5
        Label1.Text = "numero de vol"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(345, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 15)
        Label2.TabIndex = 6
        Label2.Text = "date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 15)
        Label3.TabIndex = 7
        Label3.Text = "prix"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 15)
        Label4.TabIndex = 8
        Label4.Text = "pleaces disponibles"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 9
        Label5.Text = "Destination"
        ' 
        ' BtnAjouter
        ' 
        BtnAjouter.Location = New Point(335, 104)
        BtnAjouter.Name = "BtnAjouter"
        BtnAjouter.Size = New Size(75, 23)
        BtnAjouter.TabIndex = 10
        BtnAjouter.Text = "Ajouter"
        BtnAjouter.UseVisualStyleBackColor = True
        ' 
        ' BtnSupprimer
        ' 
        BtnSupprimer.Location = New Point(363, 214)
        BtnSupprimer.Name = "BtnSupprimer"
        BtnSupprimer.Size = New Size(75, 23)
        BtnSupprimer.TabIndex = 11
        BtnSupprimer.Text = "Supprimer"
        BtnSupprimer.UseVisualStyleBackColor = True
        ' 
        ' BtnModifier
        ' 
        BtnModifier.Location = New Point(219, 214)
        BtnModifier.Name = "BtnModifier"
        BtnModifier.Size = New Size(75, 23)
        BtnModifier.TabIndex = 12
        BtnModifier.Text = "Modifier"
        BtnModifier.UseVisualStyleBackColor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column4})
        DataGridView3.Location = New Point(39, 254)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(551, 150)
        DataGridView3.TabIndex = 13
        ' 
        ' Column0
        ' 
        Column0.HeaderText = "Numero"
        Column0.Name = "Column0"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Destination"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Date et Heure"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Places Disponibles"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Prix ($)"
        Column4.Name = "Column4"
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView3)
        Controls.Add(BtnModifier)
        Controls.Add(BtnSupprimer)
        Controls.Add(BtnAjouter)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker2)
        Controls.Add(TxtDestination)
        Controls.Add(TxtPlacesDisponibles)
        Controls.Add(TxtPrix)
        Controls.Add(TxtNumeroVol)
        Name = "admin"
        Text = "admin"
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNumeroVol As TextBox
    Friend WithEvents TxtPrix As TextBox
    Friend WithEvents TxtPlacesDisponibles As TextBox
    Friend WithEvents TxtDestination As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
