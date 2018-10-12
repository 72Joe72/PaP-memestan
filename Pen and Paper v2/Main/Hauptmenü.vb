Public Class Hauptmenü
    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Charaktererstellung.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Map.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Server.Show()


    End Sub
End Class