Imports System.Net.Sockets
Imports System.IO
Public Class NormalPlayerJoin
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)


    Public Function GetText(ByVal Identifier As String) As String
        'ReSet Function
        Try
            Dim line As New IO.StreamReader("C:\Users\Janis\Desktop\Player.txt")
            Dim Result As String = ""

            While line.Peek > -1
                Dim out As String = line.ReadLine()

                If out.StartsWith(Identifier) Then
                    Result = out.Substring(Identifier.Length + 1)
                End If
            End While
            Return Result

        Catch ex As Exception
        End Try

    End Function
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Public Function GetAppDataPath() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    End Function



    Public Sub B_Connect_Click(sender As Object, e As EventArgs)

    End Sub


    'Private nick As String = "unknown"
    Private Sub AddItem(ByVal s As String)
        ListBox1.Items.Add(s)
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            client.Connect("joe88.ddns.net", 88) ' hier die ip des servers eintragen. 
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

        End Try
    End Sub
    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch ex As Exception

            End Try
        End While
    End Sub


    Private Sub B_Connect_Click_1(sender As Object, e As EventArgs) Handles B_Connect.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        streamw.WriteLine(TextBox1.Text)
        streamw.Flush()
        TextBox1.Clear()
    End Sub

    Private Sub NormalPlayerJoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class