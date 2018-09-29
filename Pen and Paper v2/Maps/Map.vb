Imports System.IO

Public Class Map

    'ReSet Function

    Public Function GetText(ByVal Identifier As String) As String

        Try
            Dim S As New StringReader(My.Resources.Player) : Dim Result As String = ""

            'Do While (S.Peek <> -1)
            Dim Line As String = S.ReadLine
            If Line.ToLower.StartsWith(Identifier.ToLower) Then
                Result = Line.Substring(Identifier.Length + 3)
                S.Close()
            End If
            'Loop
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

        mapvis = GetText("A1_A1")
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

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click

    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click

    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click

    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click

    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click

    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click

    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click

    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click

    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click

    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click

    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click

    End Sub

    Private Sub C4_Click(sender As Object, e As EventArgs) Handles C4.Click

    End Sub

    Private Sub C5_Click(sender As Object, e As EventArgs) Handles C5.Click

    End Sub

    Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click

    End Sub

    Private Sub C7_Click(sender As Object, e As EventArgs) Handles C7.Click

    End Sub

    Private Sub C8_Click(sender As Object, e As EventArgs) Handles C8.Click

    End Sub

    Private Sub C9_Click(sender As Object, e As EventArgs) Handles C9.Click

    End Sub

    Private Sub C10_Click(sender As Object, e As EventArgs) Handles C10.Click

    End Sub

    Private Sub D1_Click(sender As Object, e As EventArgs) Handles D1.Click

    End Sub

    Private Sub D2_Click(sender As Object, e As EventArgs) Handles D2.Click

    End Sub

    Private Sub D3_Click(sender As Object, e As EventArgs) Handles D3.Click

    End Sub

    Private Sub D4_Click(sender As Object, e As EventArgs) Handles D4.Click

    End Sub

    Private Sub D5_Click(sender As Object, e As EventArgs) Handles D5.Click

    End Sub

    Private Sub D6_Click(sender As Object, e As EventArgs) Handles D6.Click

    End Sub

    Private Sub D7_Click(sender As Object, e As EventArgs) Handles D7.Click

    End Sub

    Private Sub D8_Click(sender As Object, e As EventArgs) Handles D8.Click

    End Sub

    Private Sub D9_Click(sender As Object, e As EventArgs) Handles D9.Click

    End Sub

    Private Sub D10_Click(sender As Object, e As EventArgs) Handles D10.Click

    End Sub

    Private Sub E1_Click(sender As Object, e As EventArgs) Handles E1.Click

    End Sub

    Private Sub E2_Click(sender As Object, e As EventArgs) Handles E2.Click

    End Sub

    Private Sub E3_Click(sender As Object, e As EventArgs) Handles E3.Click

    End Sub

    Private Sub E4_Click(sender As Object, e As EventArgs) Handles E4.Click

    End Sub

    Private Sub E5_Click(sender As Object, e As EventArgs) Handles E5.Click

    End Sub

    Private Sub E6_Click(sender As Object, e As EventArgs) Handles E6.Click

    End Sub

    Private Sub E7_Click(sender As Object, e As EventArgs) Handles E7.Click

    End Sub

    Private Sub E8_Click(sender As Object, e As EventArgs) Handles E8.Click

    End Sub

    Private Sub E9_Click(sender As Object, e As EventArgs) Handles E9.Click

    End Sub

    Private Sub E10_Click(sender As Object, e As EventArgs) Handles E10.Click

    End Sub

    Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click

    End Sub

    Private Sub F2_Click(sender As Object, e As EventArgs) Handles F2.Click

    End Sub

    Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click

    End Sub

    Private Sub F4_Click(sender As Object, e As EventArgs) Handles F4.Click

    End Sub

    Private Sub F5_Click(sender As Object, e As EventArgs) Handles F5.Click

    End Sub

    Private Sub F6_Click(sender As Object, e As EventArgs) Handles F6.Click

    End Sub

    Private Sub F7_Click(sender As Object, e As EventArgs) Handles F7.Click

    End Sub

    Private Sub F8_Click(sender As Object, e As EventArgs) Handles F8.Click

    End Sub

    Private Sub F9_Click(sender As Object, e As EventArgs) Handles F9.Click

    End Sub

    Private Sub F10_Click(sender As Object, e As EventArgs) Handles F10.Click

    End Sub

    Private Sub G1_Click(sender As Object, e As EventArgs) Handles G1.Click

    End Sub

    Private Sub G2_Click(sender As Object, e As EventArgs) Handles G2.Click

    End Sub

    Private Sub G3_Click(sender As Object, e As EventArgs) Handles G3.Click

    End Sub

    Private Sub G4_Click(sender As Object, e As EventArgs) Handles G4.Click

    End Sub

    Private Sub G5_Click(sender As Object, e As EventArgs) Handles G5.Click

    End Sub

    Private Sub G6_Click(sender As Object, e As EventArgs) Handles G6.Click

    End Sub

    Private Sub G7_Click(sender As Object, e As EventArgs) Handles G7.Click

    End Sub

    Private Sub G8_Click(sender As Object, e As EventArgs) Handles G8.Click

    End Sub

    Private Sub G9_Click(sender As Object, e As EventArgs) Handles G9.Click

    End Sub

    Private Sub G10_Click(sender As Object, e As EventArgs) Handles G10.Click

    End Sub

    Private Sub H1_Click(sender As Object, e As EventArgs) Handles H1.Click

    End Sub

    Private Sub H2_Click(sender As Object, e As EventArgs) Handles H2.Click

    End Sub

    Private Sub H3_Click(sender As Object, e As EventArgs) Handles H3.Click

    End Sub

    Private Sub H4_Click(sender As Object, e As EventArgs) Handles H4.Click

    End Sub

    Private Sub H5_Click(sender As Object, e As EventArgs) Handles H5.Click

    End Sub

    Private Sub H6_Click(sender As Object, e As EventArgs) Handles H6.Click

    End Sub

    Private Sub H7_Click(sender As Object, e As EventArgs) Handles H7.Click

    End Sub

    Private Sub H8_Click(sender As Object, e As EventArgs) Handles H8.Click

    End Sub

    Private Sub H9_Click(sender As Object, e As EventArgs) Handles H9.Click

    End Sub

    Private Sub H10_Click(sender As Object, e As EventArgs) Handles H10.Click

    End Sub

    Private Sub I1_Click(sender As Object, e As EventArgs) Handles I1.Click

    End Sub

    Private Sub I2_Click(sender As Object, e As EventArgs) Handles I2.Click

    End Sub

    Private Sub I3_Click(sender As Object, e As EventArgs) Handles I3.Click

    End Sub

    Private Sub I4_Click(sender As Object, e As EventArgs) Handles I4.Click

    End Sub

    Private Sub I5_Click(sender As Object, e As EventArgs) Handles I5.Click

    End Sub

    Private Sub I6_Click(sender As Object, e As EventArgs) Handles I6.Click

    End Sub

    Private Sub I7_Click(sender As Object, e As EventArgs) Handles I7.Click

    End Sub

    Private Sub I8_Click(sender As Object, e As EventArgs) Handles I8.Click

    End Sub

    Private Sub I9_Click(sender As Object, e As EventArgs) Handles I9.Click

    End Sub

    Private Sub I10_Click(sender As Object, e As EventArgs) Handles I10.Click

    End Sub

    Private Sub J1_Click(sender As Object, e As EventArgs) Handles J1.Click

    End Sub

    Private Sub J2_Click(sender As Object, e As EventArgs) Handles J2.Click

    End Sub

    Private Sub J3_Click(sender As Object, e As EventArgs) Handles J3.Click

    End Sub

    Private Sub J4_Click(sender As Object, e As EventArgs) Handles J4.Click

    End Sub

    Private Sub J5_Click(sender As Object, e As EventArgs) Handles J5.Click

    End Sub

    Private Sub J6_Click(sender As Object, e As EventArgs) Handles J6.Click

    End Sub

    Private Sub J7_Click(sender As Object, e As EventArgs) Handles J7.Click

    End Sub

    Private Sub J8_Click(sender As Object, e As EventArgs) Handles J8.Click

    End Sub

    Private Sub J9_Click(sender As Object, e As EventArgs) Handles J9.Click

    End Sub

    Private Sub J10_Click(sender As Object, e As EventArgs) Handles J10.Click

    End Sub

End Class