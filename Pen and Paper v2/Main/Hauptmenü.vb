Public Class Hauptmenü


    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CharaktererstellungB.Click
        Haupt.Visible = False
        Chara1.Visible = True
    End Sub

    Private Sub zurück_chara_Click(sender As Object, e As EventArgs) Handles zurück_chara.Click
        Haupt.Visible = True
        Chara1.Visible = False
    End Sub

    Private Sub Beenden_Click(sender As Object, e As EventArgs) Handles Beenden.Click
        Close()
    End Sub

    Private Sub SPIELEN_Click(sender As Object, e As EventArgs) Handles SPIELEN.Click
        Haupt.Visible = False
        SpielenP.Visible = True

    End Sub

    Private Sub zurück_Spiel_Click(sender As Object, e As EventArgs) Handles zurück_Spiel.Click
        Haupt.Visible = True
        SpielenP.Visible = False
    End Sub

    Private Sub neu_chara_Click(sender As Object, e As EventArgs) Handles Neu_chara.Click
        Charaktererstellung.Show()




    End Sub
End Class