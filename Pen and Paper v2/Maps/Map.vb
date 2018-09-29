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
#Disable Warning BC42105 ' Die Funktion gibt nicht für alle Codepfade einen Wert zurück.
    End Function
#Enable Warning BC42105 ' Die Funktion gibt nicht für alle Codepfade einen Wert zurück.

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