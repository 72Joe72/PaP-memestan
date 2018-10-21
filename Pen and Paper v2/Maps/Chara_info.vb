Imports System
Imports System.IO
Imports System.Text
Imports System.Environment
Public Class Chara_info
    Public Function GetText(ByVal Identifier As String) As String
        'ReSet Function
        Try
            Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
            Dim YourPath As String = appData + "\PaP-Memestan\"
            Dim line As New IO.StreamReader(YourPath + Hauptmenü.Chara + ".joe")
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

    Private Sub Chara_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        L_Id.Text = GetText("ID:")
        TextBox1.Text = GetText("NAME:")

        If GetText("GESCHLECHT:") = "Weiblich" Then
            RadioButton2.PerformClick()
        Else
            RadioButton1.PerformClick()
        End If

        ComboBox1.Text = GetText("RASSE:")
        ComboBox2.Text = GetText("ERSTWAFFE:")
        L_HP.Text = GetText("HP:")
        L_ATK.Text = GetText("ATK:")
        L_DEF.Text = GetText("DEF:")
        L_GES.Text = GetText("GES:")
        L_REK.Text = GetText("ATK:")


        TextBox1.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False


    End Sub

    Private Sub BZurück_Click(sender As Object, e As EventArgs) Handles BZurück.Click
        Close()

    End Sub
End Class