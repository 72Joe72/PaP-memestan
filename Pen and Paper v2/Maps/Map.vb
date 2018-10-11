Imports System.IO

Public Class Map
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





    Private Sub Zurück_Click(sender As Object, e As EventArgs) Handles Zurück.Click
        MainMap.Visible = True
        SubMap.Visible = False
        Zurück.Visible = False

    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String


        If GetText("A1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A2_A1")
        If GetText("A2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A3_A1")
        If GetText("A3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A4_A1")
        If GetText("A4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A5_A1")
        If GetText("A5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A6_A1")
        If GetText("A6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A7_Click(sender As Object, e As EventArgs) Handles A7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A7_A1")
        If GetText("A7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A8_Click(sender As Object, e As EventArgs) Handles A8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A8_A1")
        If GetText("A8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A9_Click(sender As Object, e As EventArgs) Handles A9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A9_A1")
        If GetText("A9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub A10_Click(sender As Object, e As EventArgs) Handles A10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "A-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.A_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("A10_A1")
        If GetText("A10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("A10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("A10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("A10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("A10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("A10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("A10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("A10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("A10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("A10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("A10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("A10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("A10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("A10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("A10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("A10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("A10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("A10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("A10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("A10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("A10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("A10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("A10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B1_A1")
        If GetText("B1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B2_A1")
        If GetText("B2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B3_A1")
        If GetText("B3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click

        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B4_A1")
        If GetText("B4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click

        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B5_A1")
        If GetText("B5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click

        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B6_A1")
        If GetText("B6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If

    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click


        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B7_A1")
        If GetText("B7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click

        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B8_A1")
        If GetText("B8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If

    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click

        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B9_A1")
        If GetText("B9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If

    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click

        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "B-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.B_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("B10_A1")
        If GetText("B10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("B10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("B10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("B10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("B10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("B10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("B10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("B10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("B10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("B10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("B10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("B10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("B10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("B10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("B10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("B10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("B10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("B10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("B10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("B10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("B10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("B10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("B10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If

    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C1_A1")
        If GetText("C1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C2_A1")
        If GetText("C2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C3_A1")
        If GetText("C3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub C4_Click(sender As Object, e As EventArgs) Handles C4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C4_A1")
        If GetText("C4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub C5_Click(sender As Object, e As EventArgs) Handles C5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C5_A1")
        If GetText("C5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If

    End Sub

    Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C6_A1")
        If GetText("C6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub C7_Click(sender As Object, e As EventArgs) Handles C7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C7_A1")
        If GetText("C7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub C8_Click(sender As Object, e As EventArgs) Handles C8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C8_A1")
        If GetText("C8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub C9_Click(sender As Object, e As EventArgs) Handles C9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C9_A1")
        If GetText("C9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub C10_Click(sender As Object, e As EventArgs) Handles C10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "C-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.C_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("C10_A1")
        If GetText("C10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("C10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("C10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("C10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("C10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("C10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("C10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("C10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("C10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("C10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("C10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("C10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("C10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("C10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("C10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("C10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("C10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("C10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("C10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("C10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("C10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("C10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("C10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub D1_Click(sender As Object, e As EventArgs) Handles D1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D1_A1")
        If GetText("D1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub D2_Click(sender As Object, e As EventArgs) Handles D2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D2_A1")
        If GetText("D2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub D3_Click(sender As Object, e As EventArgs) Handles D3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D3_A1")
        If GetText("D3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub D4_Click(sender As Object, e As EventArgs) Handles D4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D4_A1")
        If GetText("D4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub D5_Click(sender As Object, e As EventArgs) Handles D5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D5_A1")
        If GetText("D5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub D6_Click(sender As Object, e As EventArgs) Handles D6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D6_A1")
        If GetText("D6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If


    End Sub

    Private Sub D7_Click(sender As Object, e As EventArgs) Handles D7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D7_A1")
        If GetText("D7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub D8_Click(sender As Object, e As EventArgs) Handles D8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D8_A1")
        If GetText("D8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub D9_Click(sender As Object, e As EventArgs) Handles D9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D9_A1")
        If GetText("D9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub D10_Click(sender As Object, e As EventArgs) Handles D10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "D-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.D_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("D10_A1")
        If GetText("D10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("D10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("D10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("D10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("D10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("D10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("D10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("D10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("D10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("D10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("D10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("D10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("D10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("D10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("D10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("D10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("D10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("D10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("D10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("D10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("D10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("D10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("D10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E1_Click(sender As Object, e As EventArgs) Handles E1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E1_A1")
        If GetText("E1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E2_Click(sender As Object, e As EventArgs) Handles E2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E2_A1")
        If GetText("E2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E3_Click(sender As Object, e As EventArgs) Handles E3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E3_A1")
        If GetText("E3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E4_Click(sender As Object, e As EventArgs) Handles E4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E4_A1")
        If GetText("E4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E5_Click(sender As Object, e As EventArgs) Handles E5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E5_A1")
        If GetText("E5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E6_Click(sender As Object, e As EventArgs) Handles E6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E6_A1")
        If GetText("E6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E7_Click(sender As Object, e As EventArgs) Handles E7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E7_A1")
        If GetText("E7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E8_Click(sender As Object, e As EventArgs) Handles E8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E8_A1")
        If GetText("E8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E9_Click(sender As Object, e As EventArgs) Handles E9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E9_A1")
        If GetText("E9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub E10_Click(sender As Object, e As EventArgs) Handles E10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "E-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.E_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("E10_A1")
        If GetText("E10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("E10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("E10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("E10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("E10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("E10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("E10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("E10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("E10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("E10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("E10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("E10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("E10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("E10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("E10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("E10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("E10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("E10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("E10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("E10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("E10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("E10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("E10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F1_A1")
        If GetText("F1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F2_Click(sender As Object, e As EventArgs) Handles F2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F2_A1")
        If GetText("F2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F3_A1")
        If GetText("F3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F4_Click(sender As Object, e As EventArgs) Handles F4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F4_A1")
        If GetText("F4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F5_Click(sender As Object, e As EventArgs) Handles F5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F5_A1")
        If GetText("F5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F6_Click(sender As Object, e As EventArgs) Handles F6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F6_A1")
        If GetText("F6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F7_Click(sender As Object, e As EventArgs) Handles F7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F7_A1")
        If GetText("F7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F8_Click(sender As Object, e As EventArgs) Handles F8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F8_A1")
        If GetText("F8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F9_Click(sender As Object, e As EventArgs) Handles F9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F9_A1")
        If GetText("F9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub F10_Click(sender As Object, e As EventArgs) Handles F10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "F-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.F_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("F10_A1")
        If GetText("F10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("F10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("F10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("F10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("F10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("F10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("F10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("F10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("F10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("F10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("F10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("F10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("F10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("F10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("F10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("F10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("F10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("F10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("F10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("F10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("F10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("F10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("F10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G1_Click(sender As Object, e As EventArgs) Handles G1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G1_A1")
        If GetText("G1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G2_Click(sender As Object, e As EventArgs) Handles G2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G2_A1")
        If GetText("G2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G3_Click(sender As Object, e As EventArgs) Handles G3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G3_A1")
        If GetText("G3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G4_Click(sender As Object, e As EventArgs) Handles G4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G4_A1")
        If GetText("G4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G5_Click(sender As Object, e As EventArgs) Handles G5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G5_A1")
        If GetText("G5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G6_Click(sender As Object, e As EventArgs) Handles G6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G6_A1")
        If GetText("G6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G7_Click(sender As Object, e As EventArgs) Handles G7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G7_A1")
        If GetText("G7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G8_Click(sender As Object, e As EventArgs) Handles G8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G8_A1")
        If GetText("G8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G9_Click(sender As Object, e As EventArgs) Handles G9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G9_A1")
        If GetText("G9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub G10_Click(sender As Object, e As EventArgs) Handles G10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "G-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.G_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("G10_A1")
        If GetText("G10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("G10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("G10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("G10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("G10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("G10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("G10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("G10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("G10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("G10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("G10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("G10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("G10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("G10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("G10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("G10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("G10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("G10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("G10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("G10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("G10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("G10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("G10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H1_Click(sender As Object, e As EventArgs) Handles H1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H1_A1")
        If GetText("H1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H2_Click(sender As Object, e As EventArgs) Handles H2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H2_A1")
        If GetText("H2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H3_Click(sender As Object, e As EventArgs) Handles H3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H3_A1")
        If GetText("H3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H4_Click(sender As Object, e As EventArgs) Handles H4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H4_A1")
        If GetText("H4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H5_Click(sender As Object, e As EventArgs) Handles H5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H5_A1")
        If GetText("H5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H6_Click(sender As Object, e As EventArgs) Handles H6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H6_A1")
        If GetText("H6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H7_Click(sender As Object, e As EventArgs) Handles H7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H7_A1")
        If GetText("H7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H8_Click(sender As Object, e As EventArgs) Handles H8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H8_A1")
        If GetText("H8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H9_Click(sender As Object, e As EventArgs) Handles H9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H9_A1")
        If GetText("H9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub H10_Click(sender As Object, e As EventArgs) Handles H10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "H-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.H_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("H10_A1")
        If GetText("H10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("H10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("H10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("H10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("H10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("H10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("H10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("H10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("H10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("H10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("H10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("H10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("H10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("H10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("H10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("H10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("H10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("H10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("H10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("H10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("H10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("H10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("H10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I1_Click(sender As Object, e As EventArgs) Handles I1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I1_A1")
        If GetText("I1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I2_Click(sender As Object, e As EventArgs) Handles I2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I2_A1")
        If GetText("I2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I3_Click(sender As Object, e As EventArgs) Handles I3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I3_A1")
        If GetText("I3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I4_Click(sender As Object, e As EventArgs) Handles I4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I4_A1")
        If GetText("I4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I5_Click(sender As Object, e As EventArgs) Handles I5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I5_A1")
        If GetText("I5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I6_Click(sender As Object, e As EventArgs) Handles I6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I6_A1")
        If GetText("I6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I7_Click(sender As Object, e As EventArgs) Handles I7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I7_A1")
        If GetText("I7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I8_Click(sender As Object, e As EventArgs) Handles I8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I8_A1")
        If GetText("I8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I9_Click(sender As Object, e As EventArgs) Handles I9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I9_A1")
        If GetText("I9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub I10_Click(sender As Object, e As EventArgs) Handles I10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "I-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.I_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("I10_A1")
        If GetText("I10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("I10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("I10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("I10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("I10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("I10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("I10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("I10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("I10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("I10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("I10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("I10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("I10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("I10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("I10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("I10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("I10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("I10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("I10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("I10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("I10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("I10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("I10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J1_Click(sender As Object, e As EventArgs) Handles J1.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-1"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_1
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J1_A1")
        If GetText("J1_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J1_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J1_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J1_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J1_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J1_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J1_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J1_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J1_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J1_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J1_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J1_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J1_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J1_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J1_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J1_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J1_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J1_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J1_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J1_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J1_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J1_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J1_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J1_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J1_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J2_Click(sender As Object, e As EventArgs) Handles J2.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-2"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_2
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J2_A1")
        If GetText("J2_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J2_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J2_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J2_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J2_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J2_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J2_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J2_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J2_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J2_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J2_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J2_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J2_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J2_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J2_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J2_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J2_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J2_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J2_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J2_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J2_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J2_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J2_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J2_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J2_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J3_Click(sender As Object, e As EventArgs) Handles J3.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-3"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_3
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J3_A1")
        If GetText("J3_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J3_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J3_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J3_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J3_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J3_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J3_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J3_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J3_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J3_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J3_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J3_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J3_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J3_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J3_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J3_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J3_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J3_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J3_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J3_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J3_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J3_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J3_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J3_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J3_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J4_Click(sender As Object, e As EventArgs) Handles J4.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-4"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_4
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J4_A1")
        If GetText("J4_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J4_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J4_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J4_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J4_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J4_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J4_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J4_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J4_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J4_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J4_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J4_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J4_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J4_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J4_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J4_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J4_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J4_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J4_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J4_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J4_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J4_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J4_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J4_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J4_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J5_Click(sender As Object, e As EventArgs) Handles J5.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-5"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_5
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J5_A1")
        If GetText("J5_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J5_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J5_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J5_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J5_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J5_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J5_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J5_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J5_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J5_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J5_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J5_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J5_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J5_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J5_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J5_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J5_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J5_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J5_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J5_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J5_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J5_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J5_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J5_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J5_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J6_Click(sender As Object, e As EventArgs) Handles J6.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-6"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_6
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J6_A1")
        If GetText("J6_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J6_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J6_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J6_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J6_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J6_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J6_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J6_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J6_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J6_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J6_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J6_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J6_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J6_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J6_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J6_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J6_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J6_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J6_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J6_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J6_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J6_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J6_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J6_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J6_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J7_Click(sender As Object, e As EventArgs) Handles J7.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-7"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_7
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J7_A1")
        If GetText("J7_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J7_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J7_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J7_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J7_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J7_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J7_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J7_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J7_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J7_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J7_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J7_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J7_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J7_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J7_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J7_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J7_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J7_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J7_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J7_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J7_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J7_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J7_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J7_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J7_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J8_Click(sender As Object, e As EventArgs) Handles J8.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-8"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_8
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J8_A1")
        If GetText("J8_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J8_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J8_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J8_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J8_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J8_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J8_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J8_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J8_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J8_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J8_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J8_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J8_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J8_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J8_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J8_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J8_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J8_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J8_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J8_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J8_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J8_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J8_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J8_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J8_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J9_Click(sender As Object, e As EventArgs) Handles J9.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-9"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_9
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J9_A1")
        If GetText("J9_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J9_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J9_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J9_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J9_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J9_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J9_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J9_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J9_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J9_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J9_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J9_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J9_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J9_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J9_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J9_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J9_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J9_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J9_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J9_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J9_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J9_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J9_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J9_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J9_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub J10_Click(sender As Object, e As EventArgs) Handles J10.Click
        'Sichtbarkeits Änderungen
        MainMap.Visible = False
        SubMap.Visible = True
        Zurück.Visible = True
        Zurück2.Visible = False
        'Mapteil anzeige
        SInfo.Text = "J-10"
        'Map "Hintergrund" import
        Dim SMXx As Bitmap = My.Resources.J_10
        SMX.Image = SMXx
        'Nebel ein oder aus Blenden
        Dim mapvis As String

        mapvis = GetText("J10_A1")
        If GetText("J10_A1") = "True" Then
            SA1.Visible = False
        Else
            SA1.Visible = True
        End If

        mapvis = GetText("J10_A2")
        If mapvis = "True" Then
            SA2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J10_A3")
        If mapvis = "True" Then
            SA3.Visible = False
        Else
            SA3.Visible = True
        End If

        mapvis = GetText("J10_A4")
        If mapvis = "True" Then
            SA4.Visible = False
        Else
            SA4.Visible = True
        End If

        mapvis = GetText("J10_A5")
        If mapvis = "True" Then
            SA5.Visible = False
        Else
            SA5.Visible = True
        End If

        mapvis = GetText("J10_B1")
        If mapvis = "True" Then
            SB1.Visible = False
        Else
            SB1.Visible = True
        End If

        mapvis = GetText("J10_B2")
        If mapvis = "True" Then
            SB2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J10_B3")
        If mapvis = "True" Then
            SB3.Visible = False
        Else
            SB3.Visible = True
        End If

        mapvis = GetText("J10_B4")
        If mapvis = "True" Then
            SB4.Visible = False
        Else
            SB4.Visible = True
        End If

        mapvis = GetText("J10_B5")
        If mapvis = "True" Then
            SB5.Visible = False
        Else
            SB5.Visible = True
        End If

        mapvis = GetText("J10_C1")
        If mapvis = "True" Then
            SC1.Visible = False
        Else
            SC1.Visible = True
        End If

        mapvis = GetText("J10_C2")
        If mapvis = "True" Then
            SC2.Visible = False
        Else
            SC2.Visible = True
        End If

        mapvis = GetText("J10_C3")
        If mapvis = "True" Then
            SC3.Visible = False
        Else
            SC3.Visible = True
        End If

        mapvis = GetText("J10_C4")
        If mapvis = "True" Then
            SC4.Visible = False
        Else
            SC4.Visible = True
        End If

        mapvis = GetText("J10_C5")
        If mapvis = "True" Then
            SC5.Visible = False
        Else
            SC5.Visible = True
        End If

        mapvis = GetText("J10_D1")
        If mapvis = "True" Then
            SD1.Visible = False
        Else
            SD1.Visible = True
        End If

        mapvis = GetText("J10_D2")
        If mapvis = "True" Then
            SD2.Visible = False
        Else
            SD2.Visible = True
        End If

        mapvis = GetText("J10_D3")
        If mapvis = "True" Then
            SD3.Visible = False
        Else
            SD3.Visible = True
        End If

        mapvis = GetText("J10_D4")
        If mapvis = "True" Then
            SD4.Visible = False
        Else
            SD4.Visible = True
        End If

        mapvis = GetText("J10_D5")
        If mapvis = "True" Then
            SD5.Visible = False
        Else
            SD5.Visible = True
        End If

        mapvis = GetText("J10_E1")
        If mapvis = "True" Then
            SE1.Visible = False
        Else
            SE1.Visible = True
        End If

        mapvis = GetText("J10_E2")
        If mapvis = "True" Then
            SE2.Visible = False
        Else
            SA2.Visible = True
        End If

        mapvis = GetText("J10_E3")
        If mapvis = "True" Then
            SE3.Visible = False
        Else
            SE3.Visible = True
        End If

        mapvis = GetText("J10_E4")
        If mapvis = "True" Then
            SE4.Visible = False
        Else
            SE4.Visible = True
        End If

        mapvis = GetText("J10_E5")
        If mapvis = "True" Then
            SE5.Visible = False
        Else
            SE5.Visible = True
        End If
    End Sub

    Private Sub SB1_Click(sender As Object, e As EventArgs) Handles SB1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("C:\WINDOWS\system32\magnify.exe")
    End Sub
End Class