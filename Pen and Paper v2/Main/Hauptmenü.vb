Public Class Hauptmenü
    Public IP As String
    Public Chara As String

    Private Sub Hauptmenü_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Haupt.Dock = DockStyle.Fill

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CharaktererstellungB.Click
        Haupt.Dock = DockStyle.None
        Chara1.Dock = DockStyle.Fill



    End Sub

    Private Sub zurück_chara_Click(sender As Object, e As EventArgs) Handles zurück_chara.Click
        Haupt.Dock = DockStyle.Fill
        Chara1.Dock = DockStyle.None
    End Sub

    Private Sub Beenden_Click(sender As Object, e As EventArgs) Handles Beenden.Click
        Close()
    End Sub

    Private Sub SPIELEN_Click(sender As Object, e As EventArgs) Handles SPIELEN.Click
        Haupt.Dock = DockStyle.None
        SpielenP.Dock = DockStyle.Fill

    End Sub

    Private Sub zurück_Spiel_Click(sender As Object, e As EventArgs) Handles zurück_Spiel.Click
        Haupt.Dock = DockStyle.Fill
        SpielenP.Dock = DockStyle.None
    End Sub

    Private Sub neu_chara_Click(sender As Object, e As EventArgs) Handles Neu_chara.Click
        Charaktererstellung.Show()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Map.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MainGame.Show()

    End Sub

    Private Sub PJoinB_Click(sender As Object, e As EventArgs) Handles PJoinB.Click
        NormalJoin.Show()


    End Sub
End Class