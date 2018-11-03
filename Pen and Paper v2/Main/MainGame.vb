Imports System.Net.Sockets
Imports System.IO
Public Class MainGame
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
            streamw.Write("CON:" + Hauptmenü.Chara + vbCrLf)
            streamw.Flush()
        End If

        Dim fs As FileStream = File.Create("C:\\Users\\Janis\\Desktop\\stuff3\\" + TextBox1.Text + ".joe")

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
        Label1.Text = s

        Dim Split = s.Substring(0, 9)
        Dim OnlineName As String

        If Split = Hauptmenü.Chara Then
            streamw.Write("Info:" + s.Substring(4) + " connected to Game" + vbCrLf)
            streamw.Flush()
            OnlineName = s.Substring(10)
            Label5.Text = OnlineName
        End If



    End Sub

End Class