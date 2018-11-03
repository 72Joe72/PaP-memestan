Imports System.Net.Sockets
Imports System.IO
Imports System.Environment
Imports System.Text

Public Class MainGameMaster
    Public SPA As Integer = 0

    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Public t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)



    Private Sub MainGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            client.Connect(Hauptmenü.IP, 88) ' hier die ip des servers eintragen. 
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                'streamw.WriteLine(nick) ' das ist optional.
                streamw.Flush()
                t.Start()

            End If
        Catch ex As Exception
            MsgBox("Fail")
            t.Interrupt()
            Close()


        End Try

        If client.Client.Connected = True Then
            streamw.Write("Gott ist erschienen !!!" + vbCrLf)
            streamw.Flush()
        End If
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        Dim YourPath As String = appData + "\PaP-Memestan"

    End Sub

    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch ex As Exception
                MsgBox("Fail")
                t.Interrupt()
                Close()
            End Try
        End While
    End Sub

    Private Sub AddItem(ByVal s As String)
        LB_info.Items.Add(s)
        Label1.Text = s


        Dim Split = s.Substring(0, 4)

        If Split = "CON:" Then 'Connect
            streamw.Write("Info:" + s.Substring(4).ToString + " connected to Game" + vbCrLf)
            streamw.Flush()

            SPA = SPA + 1
            If SPA <= 10 Then
                streamw.Write(s.Substring(4).ToString + " S-0" + SPA.ToString + vbCrLf)
                streamw.Flush()


            Else
                streamw.Write(s.Substring(4).ToString + " S-" + SPA.ToString + vbCrLf)
                streamw.Flush()
            End If



        End If
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        Dim YourPath As String = appData + "\PaP-Memestan"

        If Split = "GMM: " Then
            If s.Substring(4, 7) = "CHÜ:" Then

                If (Not System.IO.File.Exists(YourPath + )) Then
                    Dim fss As FileStream = File.Create(YourPath + "\info.joe")
                    Dim info3 As Byte() = New UTF8Encoding(True).GetBytes("")
                    fss.Write(info3, 0, info3.Length)
                    fss.Close()

                End If

                If s.Substring(7, 9) = "NM:" Then
                    Dim xd As String = s.Substring(9)
                    My.Computer.FileSystem.WriteAllText(xd, True)

                End If

                If s.Substring(7, 9) = "GL:" Then
                    s.Substring(9)
                End If

                If s.Substring(7, 9) = "RS:" Then
                    s.Substring(9)
                End If

                If s.Substring(7, 9) = "EW:" Then
                    s.Substring(9)
                End If

                If s.Substring(7, 9) = "HP:" Then
                    s.Substring(9)
                End If

                If s.Substring(7, 9) = "AK:" Then
                    s.Substring(9)
                End If

                If s.Substring(7, 9) = "DF:" Then
                    s.Substring(9)
                End If

                If s.Substring(7, 9) = "GS:" Then
                    s.Substring(9)
                End If

                If s.Substring(7, 9) = "RK:" Then
                    s.Substring(9)
                End If
            End If





        End If
    End Sub
End Class
