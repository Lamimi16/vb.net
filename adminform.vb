
Public Class adminform
    Private vols As New List(Of Vol) ' Liste des vols

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuration initiale du DataGridView
        ConfigureDataGridView()
        ChargerVols()
    End Sub

    Private Sub ConfigureDataGridView()
        DataGridView3.ColumnCount = 5
        DataGridView3.Columns(0).Name = "Numéro"
        DataGridView3.Columns(1).Name = "Destination"
        DataGridView3.Columns(2).Name = "Date et Heure"
        DataGridView3.Columns(3).Name = "Places Disponibles"
        DataGridView3.Columns(4).Name = "Prix (€)"
    End Sub

    Private Sub ChargerVols()
        DataGridView3.Rows.Clear()
        For Each vol In vols
            DataGridView3.Rows.Add(vol.Numero, vol.Destination, vol.DateHeure, vol.PlacesDisponibles, vol.Prix)
        Next
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        If String.IsNullOrEmpty(TxtNumeroVol.Text) OrElse String.IsNullOrEmpty(TxtDestination.Text) OrElse
           String.IsNullOrEmpty(TxtPlacesDisponibles.Text) OrElse String.IsNullOrEmpty(TxtPrix.Text) Then
            MessageBox.Show("Veuillez remplir tous les champs pour ajouter un vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim vol As New Vol With {
            .Numero = TxtNumeroVol.Text,
            .Destination = TxtDestination.Text,
            .DateHeure = DateTimePicker2.Value,
            .PlacesDisponibles = Integer.Parse(TxtPlacesDisponibles.Text),
            .Prix = Decimal.Parse(TxtPrix.Text)
        }

        vols.Add(vol)
        ChargerVols()
        MessageBox.Show("Vol ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        If DataGridView3.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedRow = DataGridView3.SelectedRows(0)
        Dim numeroVol = selectedRow.Cells(0).Value.ToString()
        Dim vol = vols.FirstOrDefault(Function(v) v.Numero = numeroVol)

        If vol IsNot Nothing Then
            vol.Destination = TxtDestination.Text
            vol.DateHeure = DateTimePicker2.Value
            vol.PlacesDisponibles = Integer.Parse(TxtPlacesDisponibles.Text)
            vol.Prix = Decimal.Parse(TxtPrix.Text)
            ChargerVols()
            MessageBox.Show("Vol modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Vol non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        If DataGridView3.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedRow = DataGridView3.SelectedRows(0)
        Dim numeroVol = selectedRow.Cells(0).Value.ToString()
        Dim vol = vols.FirstOrDefault(Function(v) v.Numero = numeroVol)

        If vol IsNot Nothing Then
            vols.Remove(vol)
            ChargerVols()
            MessageBox.Show("Vol supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Vol non trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TxtNumeroVol_TextChanged(sender As Object, e As EventArgs) Handles TxtNumeroVol.TextChanged

    End Sub

    Private Sub TxtDestination_TextChanged(sender As Object, e As EventArgs) Handles TxtDestination.TextChanged

    End Sub
End Class
