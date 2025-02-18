<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminform
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
        DataGridView3 = New DataGridView()
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        TxtNumeroVol = New TextBox()
        TxtPrix = New TextBox()
        TxtPlacesDisponibles = New TextBox()
        TxtDestination = New TextBox()
        DateTimePicker2 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        BtnAjouter = New Button()
        BtnSupprimer = New Button()
        BtnModifier = New Button()
        LblNumeroVol = New Label()
        LblDateHeure = New Label()
        LblPlacesDisponibles = New Label()
        LblPrix = New Label()
        LblDestination = New Label()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView3
        ' 
        DataGridView3.BackgroundColor = SystemColors.ControlLight
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column4})
        DataGridView3.GridColor = SystemColors.InactiveCaption
        DataGridView3.Location = New Point(126, 179)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(502, 102)
        DataGridView3.TabIndex = 0
        ' 
        ' Column0
        ' 
        Column0.HeaderText = "Numéro"
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
        Column3.HeaderText = "Places Disponibes"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Prix ($)"
        Column4.Name = "Column4"
        ' 
        ' TxtNumeroVol
        ' 
        TxtNumeroVol.BackColor = Color.Snow
        TxtNumeroVol.Location = New Point(122, 28)
        TxtNumeroVol.Name = "TxtNumeroVol"
        TxtNumeroVol.Size = New Size(100, 23)
        TxtNumeroVol.TabIndex = 1
        ' 
        ' TxtPrix
        ' 
        TxtPrix.BackColor = Color.Snow
        TxtPrix.Location = New Point(597, 48)
        TxtPrix.Name = "TxtPrix"
        TxtPrix.Size = New Size(100, 23)
        TxtPrix.TabIndex = 2
        ' 
        ' TxtPlacesDisponibles
        ' 
        TxtPlacesDisponibles.BackColor = Color.Snow
        TxtPlacesDisponibles.Location = New Point(122, 99)
        TxtPlacesDisponibles.Name = "TxtPlacesDisponibles"
        TxtPlacesDisponibles.Size = New Size(100, 23)
        TxtPlacesDisponibles.TabIndex = 3
        ' 
        ' TxtDestination
        ' 
        TxtDestination.BackColor = Color.Snow
        TxtDestination.Location = New Point(122, 63)
        TxtDestination.Name = "TxtDestination"
        TxtDestination.Size = New Size(100, 23)
        TxtDestination.TabIndex = 4
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarMonthBackground = SystemColors.GradientInactiveCaption
        DateTimePicker2.Location = New Point(126, 132)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 5
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(58, 300)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(191, 23)
        ComboBox1.TabIndex = 6
        ' 
        ' BtnAjouter
        ' 
        BtnAjouter.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnAjouter.ForeColor = Color.IndianRed
        BtnAjouter.Location = New Point(357, 287)
        BtnAjouter.Name = "BtnAjouter"
        BtnAjouter.Size = New Size(89, 41)
        BtnAjouter.TabIndex = 7
        BtnAjouter.Text = "Ajouter"
        BtnAjouter.UseVisualStyleBackColor = True
        ' 
        ' BtnSupprimer
        ' 
        BtnSupprimer.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnSupprimer.ForeColor = Color.IndianRed
        BtnSupprimer.Location = New Point(613, 287)
        BtnSupprimer.Name = "BtnSupprimer"
        BtnSupprimer.Size = New Size(114, 41)
        BtnSupprimer.TabIndex = 8
        BtnSupprimer.Text = "Supprimer"
        BtnSupprimer.UseVisualStyleBackColor = True
        ' 
        ' BtnModifier
        ' 
        BtnModifier.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnModifier.ForeColor = Color.IndianRed
        BtnModifier.Location = New Point(473, 287)
        BtnModifier.Name = "BtnModifier"
        BtnModifier.Size = New Size(100, 41)
        BtnModifier.TabIndex = 9
        BtnModifier.Text = "Modifier"
        BtnModifier.UseVisualStyleBackColor = True
        ' 
        ' LblNumeroVol
        ' 
        LblNumeroVol.AutoSize = True
        LblNumeroVol.BackColor = Color.LavenderBlush
        LblNumeroVol.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblNumeroVol.ForeColor = Color.Salmon
        LblNumeroVol.Location = New Point(27, 28)
        LblNumeroVol.Name = "LblNumeroVol"
        LblNumeroVol.Size = New Size(87, 20)
        LblNumeroVol.TabIndex = 10
        LblNumeroVol.Text = "NumeroVol"
        ' 
        ' LblDateHeure
        ' 
        LblDateHeure.AutoSize = True
        LblDateHeure.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblDateHeure.ForeColor = Color.Salmon
        LblDateHeure.Location = New Point(12, 134)
        LblDateHeure.Name = "LblDateHeure"
        LblDateHeure.Size = New Size(105, 20)
        LblDateHeure.TabIndex = 11
        LblDateHeure.Text = "Date et Heure"
        ' 
        ' LblPlacesDisponibles
        ' 
        LblPlacesDisponibles.AutoSize = True
        LblPlacesDisponibles.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblPlacesDisponibles.ForeColor = Color.Salmon
        LblPlacesDisponibles.Location = New Point(414, 48)
        LblPlacesDisponibles.Name = "LblPlacesDisponibles"
        LblPlacesDisponibles.Size = New Size(134, 20)
        LblPlacesDisponibles.TabIndex = 12
        LblPlacesDisponibles.Text = "Places Disponibles"
        ' 
        ' LblPrix
        ' 
        LblPrix.AutoSize = True
        LblPrix.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblPrix.ForeColor = Color.Salmon
        LblPrix.Location = New Point(78, 98)
        LblPrix.Name = "LblPrix"
        LblPrix.Size = New Size(36, 20)
        LblPrix.TabIndex = 13
        LblPrix.Text = "Prix"
        ' 
        ' LblDestination
        ' 
        LblDestination.AutoSize = True
        LblDestination.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LblDestination.ForeColor = Color.Salmon
        LblDestination.Location = New Point(27, 66)
        LblDestination.Name = "LblDestination"
        LblDestination.Size = New Size(87, 20)
        LblDestination.TabIndex = 14
        LblDestination.Text = "Destination"
        ' 
        ' adminform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(800, 450)
        Controls.Add(LblDestination)
        Controls.Add(LblPrix)
        Controls.Add(LblPlacesDisponibles)
        Controls.Add(LblDateHeure)
        Controls.Add(LblNumeroVol)
        Controls.Add(BtnModifier)
        Controls.Add(BtnSupprimer)
        Controls.Add(BtnAjouter)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker2)
        Controls.Add(TxtDestination)
        Controls.Add(TxtPlacesDisponibles)
        Controls.Add(TxtPrix)
        Controls.Add(TxtNumeroVol)
        Controls.Add(DataGridView3)
        ForeColor = SystemColors.Highlight
        Name = "adminform"
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents TxtNumeroVol As TextBox
    Friend WithEvents TxtPrix As TextBox
    Friend WithEvents TxtPlacesDisponibles As TextBox
    Friend WithEvents TxtDestination As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents LblNumeroVol As Label
    Friend WithEvents LblDateHeure As Label
    Friend WithEvents LblPlacesDisponibles As Label
    Friend WithEvents LblPrix As Label
    Friend WithEvents LblDestination As Label
End Class
