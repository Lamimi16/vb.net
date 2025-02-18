Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim op As Char
    Private Sub txt_A_TextChanged(sender As Object, e As EventArgs) Handles txt_A.TextChanged

    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        op = "_"
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        op = "/"
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        op = "*"
    End Sub

    Private Sub btn_egal_Click(sender As Object, e As EventArgs) Handles btn_egal.Click
        If IsNumeric(txt_A.Text) And IsNumeric(txt_B.Text) Then
            Dim a = Integer.Parse(txt_A.Text)
            Dim b = Integer.Parse(txt_B.Text)
            Dim res = 0
            Dim test = True
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" Then
                res = a / b
            Else MessageBox.Show("veuillez choisir un operateur")
                test = False
            End If
            If test Then
                lbl_res.Text = a.ToString + " " + op + " " + b.ToString + " = " + res.ToString

            End If
        Else
            MessageBox.Show("A et B doivent etre des entiers ")
        End If
    End Sub
End Class
