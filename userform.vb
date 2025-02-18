

Imports System.Linq

Public Class UserForm
    Public Class Vol
        Public Property Numero As String
        Public Property Destination As String
        Public Property DateHeure As DateTime
        Public Property PlacesDisponibles As Integer
        Public Property Prix As Decimal
    End Class

    ' Classe pour représenter une réservation
    Public Class Reservation
        Public Property Nom As String
        Public Property Prenom As String
        Public Property Telephone As String
        Public Property Vol As Vol
    End Class

    ' Déclaration des listes pour les vols et les réservations
    Private vols As New List(Of Vol) ' Liste des vols
    Private reservations As New List(Of Reservation) ' Liste des réservations

    ' Événement de chargement du formulaire
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialiser les vols
        vols.Add(New Vol With {
            .Numero = "001",
            .Destination = "Paris",
            .DateHeure = DateTime.Now.AddDays(1),
            .PlacesDisponibles = 50,
            .Prix = 200
        })
        vols.Add(New Vol With {
            .Numero = "002",
            .Destination = "New York",
            .DateHeure = DateTime.Now.AddDays(2),
            .PlacesDisponibles = 30,
            .Prix = 500
        })
        vols.Add(New Vol With {
            .Numero = "003",
            .Destination = "Tokyo",
            .DateHeure = DateTime.Now.AddDays(3),
            .PlacesDisponibles = 20,
            .Prix = 700
        })

        ' Configurer les colonnes des DataGridView
        ConfigureDataGridViews()

        ' Charger les vols dans le DataGridView1
        ChargerVols(vols)
    End Sub

    ' Configuration des colonnes des DataGridView
    Private Sub ConfigureDataGridViews()
        ' Configurer DataGridView1 pour afficher les vols
        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "Numéro"
        DataGridView1.Columns(1).Name = "Destination"
        DataGridView1.Columns(2).Name = "Date et Heure"
        DataGridView1.Columns(3).Name = "Places Disponibles"
        DataGridView1.Columns(4).Name = "Prix (€)"

        ' Configurer DataGridView2 pour afficher les réservations
        DataGridView2.ColumnCount = 4
        DataGridView2.Columns(0).Name = "Nom"
        DataGridView2.Columns(1).Name = "Prénom"
        DataGridView2.Columns(2).Name = "Téléphone"
        DataGridView2.Columns(3).Name = "Vol (Destination)"
    End Sub

    ' Méthode pour charger les vols dans DataGridView1
    Private Sub ChargerVols(volsFiltrés As List(Of Vol))
        DataGridView1.Rows.Clear()
        For Each vol In volsFiltrés
            DataGridView1.Rows.Add(vol.Numero, vol.Destination, vol.DateHeure, vol.PlacesDisponibles, vol.Prix)
        Next
    End Sub

    ' Méthode pour charger les réservations dans DataGridView2
    Private Sub ChargerReservations()
        DataGridView2.Rows.Clear()
        For Each res In reservations
            DataGridView2.Rows.Add(res.Nom, res.Prenom, res.Telephone, res.Vol.Destination)
        Next
    End Sub

    ' Événement pour le bouton "Rechercher"
    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        Dim destination As String = TxtDestination.Text.Trim().ToLower()
        Dim dateVol As Date = DateTimePicker1.Value.Date

        ' Filtrer les vols selon la destination et la date
        Dim volsFiltrés = vols.Where(Function(v) v.Destination.ToLower().Contains(destination) AndAlso v.DateHeure.Date = dateVol).ToList()
        ChargerVols(volsFiltrés)
    End Sub

    ' Événement pour le bouton "Réserver"
    Private Sub BtnReserver_Click(sender As Object, e As EventArgs) Handles BtnReserver.Click
        ' Vérifier les champs du client
        If String.IsNullOrEmpty(TxtNom.Text.Trim()) OrElse String.IsNullOrEmpty(TxtPrenom.Text.Trim()) OrElse String.IsNullOrEmpty(TxtTelephone.Text.Trim()) Then
            MessageBox.Show("Veuillez remplir tous les champs pour effectuer une réservation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Vérifier qu'un vol est sélectionné
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol dans la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Récupérer le vol sélectionné
        Dim selectedRow = DataGridView1.SelectedRows(0)
        Dim numeroVol = selectedRow.Cells(0).Value.ToString()
        Dim vol = vols.FirstOrDefault(Function(v) v.Numero = numeroVol)

        If vol Is Nothing OrElse vol.PlacesDisponibles <= 0 Then
            MessageBox.Show("Le vol sélectionné n'est pas disponible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ajouter une nouvelle réservation
        Dim reservation = New Reservation With {
            .Nom = TxtNom.Text.Trim(),
            .Prenom = TxtPrenom.Text.Trim(),
            .Telephone = TxtTelephone.Text.Trim(),
            .vol = vol
        }
        reservations.Add(reservation)

        ' Mettre à jour le nombre de places disponibles
        vol.PlacesDisponibles -= 1

        ' Mettre à jour les DataGridView
        ChargerVols(vols)
        ChargerReservations()

        ' Confirmer la réservation
        MessageBox.Show("Réservation effectuée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

' Classe pour représenter un vol




