Imports System.Net.Sockets
Imports System.IO
Imports System.Environment

Public Class MasterJoin


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


        Dim x1 As Boolean = False




        If Hauptmenü.IP = Nothing Then
            MsgBox("Zum verbinden Bitte die server IP eintragen")
        Else
            x1 = True
        End If


        If x1 = True Then

            MainGameMaster.Show()
            Close()

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

End Class