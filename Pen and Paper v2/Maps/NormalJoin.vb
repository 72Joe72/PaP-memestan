Imports System.Net.Sockets
Imports System.IO
Imports System.Environment
Public Class NormalJoin
    Public Function GetText(ByVal Identifier As String) As String
        'ReSet Function
        Try

            Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
            Dim YourPath As String = appData + "\PaP-Memestan"
            Dim line As New IO.StreamReader(YourPath + "\info.joe")
            Dim Result As String = ""

            While line.Peek > -1
                Dim out As String = line.ReadLine()

                If out.StartsWith(Identifier) Then
                    Result = out.Substring(Identifier.Length)
                End If
            End While
            Return Result

        Catch ex As Exception
        End Try

    End Function



    Private Sub B_connect_Click(sender As Object, e As EventArgs) Handles B_connect.Click
        Hauptmenü.IP = TB_IP.Text
        Hauptmenü.Chara = L_chara.Text

        Dim x1 As Boolean = False
        Dim x2 As Boolean = False



        If Hauptmenü.IP = Nothing Then
            MsgBox("Zum verbinden Bitte die server IP eintragen")
        Else
            x1 = True
        End If

        If Hauptmenü.Chara = Nothing Then
            MsgBox("Zum verbinden Bitte Ein Charakter erstellen" + vbCrLf + "oder die Chrakter ID eingeben")
        Else
            x2 = True
        End If

        If x1 = True Then
            If x2 = True Then
                MainGame.Show()
                Close()
            End If
        End If




    End Sub

    Private Sub NormalJoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        L_chara.Text = GetText("1: ")
        Hauptmenü.Chara = L_chara.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_Chara_Auto.Visible = False
        Panel_Chara_Manu.Visible = True
    End Sub

    Private Sub B_Chara_Manu_Zurück_Click(sender As Object, e As EventArgs) Handles B_Chara_Manu_Zurück.Click
        Panel_Chara_Auto.Visible = True
        Panel_Chara_Manu.Visible = False
    End Sub

    Private Sub B_Char_Manu_Ändern_Click(sender As Object, e As EventArgs) Handles B_Char_Manu_Ändern.Click
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        Dim YourPath As String = appData + "\PaP-Memestan"
        Dim exist As Boolean = False

        If (System.IO.File.Exists(YourPath + "\" + TB_Chara_Manu.Text + ".joe")) Then

            exist = True
        Else

            MsgBox("Chara Id ist falsch bzw. nicht vorhanden !!!")
        End If

        If exist = True Then
            L_chara.Text = TB_Chara_Manu.Text
            Panel_Chara_Auto.Visible = True
            Panel_Chara_Manu.Visible = False
            Hauptmenü.Chara = L_chara.Text

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        L_chara.Text = Hauptmenü.Chara
        Chara_info.Show()

    End Sub
End Class