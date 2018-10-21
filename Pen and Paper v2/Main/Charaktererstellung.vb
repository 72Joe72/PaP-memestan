Imports System
Imports System.IO
Imports System.Text
Imports System.Environment

Public Class Charaktererstellung
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
                    Result = out '.Substring(Identifier.Length + 1)
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


    Private Sub Charaktererstellung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ran_id As Integer = GetRandom(100000000, 1000000000)
        L_Id.Text = ran_id
        ComboBox1.Text = "Mensch"
        L_Attribut.Text = "Mensch"
        RadioButton1.Checked = True
        L_AP.Text = 0


        L_HP.Text = TB_HP.Value
        L_ATK.Text = TB_ATK.Value
        L_DEF.Text = TB_DEF.Value
        L_GES.Text = TB_GES.Value
        L_REK.Text = TB_REK.Value


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ran_id As Integer = GetRandom(100000000, 1000000000)
        L_Id.Text = ran_id
    End Sub



    Private Sub B_H_id_Click(sender As Object, e As EventArgs) Handles B_H_id.Click
        MsgBox("Die ID des Charakters ist nur für die Serverkominikation nötig!!")
    End Sub

    Private Sub B_H_Name_Click_1(sender As Object, e As EventArgs) Handles B_H_Name.Click
        MsgBox("Der Name deines Charakters")
    End Sub

    Private Sub B_H_Rasse_Click(sender As Object, e As EventArgs) Handles B_H_Rasse.Click
        MsgBox("Die Rasse deines Charakters")
    End Sub

    Private Sub B_H_waffe_Click(sender As Object, e As EventArgs) Handles B_H_waffe.Click
        MsgBox("Die erste Waffe deines Charakters")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        L_Attribut.Text = ComboBox1.Text
        L_AP.Text = 0

        If ComboBox1.Text = "Mensch" Then
            TB_HP.Minimum = 15
            TB_HP.Maximum = 25
            TB_ATK.Minimum = 5
            TB_ATK.Maximum = 15
            TB_DEF.Minimum = 5
            TB_DEF.Maximum = 15
            TB_GES.Minimum = 5
            TB_GES.Maximum = 15
            TB_REK.Minimum = 0
            TB_REK.Maximum = 10

            TB_HP.Value = 20
            TB_ATK.Value = 10
            TB_DEF.Value = 10
            TB_GES.Value = 10
            TB_REK.Value = 5

            L_HP.Text = TB_HP.Value
            L_ATK.Text = TB_ATK.Value
            L_DEF.Text = TB_DEF.Value
            L_GES.Text = TB_GES.Value
            L_REK.Text = TB_REK.Value

        End If


        If ComboBox1.Text = "Elb" Then

            TB_HP.Minimum = 15
            TB_HP.Maximum = 25
            TB_ATK.Minimum = 5
            TB_ATK.Maximum = 15
            TB_DEF.Minimum = 0
            TB_DEF.Maximum = 10
            TB_GES.Minimum = 10
            TB_GES.Maximum = 20
            TB_REK.Minimum = 0
            TB_REK.Maximum = 10

            TB_HP.Value = 20
            TB_ATK.Value = 10
            TB_DEF.Value = 5
            TB_GES.Value = 15
            TB_REK.Value = 5

            L_HP.Text = TB_HP.Value
            L_ATK.Text = TB_ATK.Value
            L_DEF.Text = TB_DEF.Value
            L_GES.Text = TB_GES.Value
            L_REK.Text = TB_REK.Value
        End If

        If ComboBox1.Text = "Zwerg" Then

            TB_HP.Minimum = 20
            TB_HP.Maximum = 30
            TB_ATK.Minimum = 10
            TB_ATK.Maximum = 20
            TB_DEF.Minimum = 10
            TB_DEF.Maximum = 20
            TB_GES.Minimum = 0
            TB_GES.Maximum = 5
            TB_REK.Minimum = 0
            TB_REK.Maximum = 5

            TB_HP.Value = 25
            TB_ATK.Value = 15
            TB_DEF.Value = 15
            TB_GES.Value = 0
            TB_REK.Value = 0

            L_HP.Text = TB_HP.Value
            L_ATK.Text = TB_ATK.Value
            L_DEF.Text = TB_DEF.Value
            L_GES.Text = TB_GES.Value
            L_REK.Text = TB_REK.Value
        End If

        If ComboBox1.Text = "Kobold" Then

            TB_HP.Minimum = 10
            TB_HP.Maximum = 20
            TB_ATK.Minimum = 5
            TB_ATK.Maximum = 15
            TB_DEF.Minimum = 5
            TB_DEF.Maximum = 15
            TB_GES.Minimum = 15
            TB_GES.Maximum = 25
            TB_REK.Minimum = 0
            TB_REK.Maximum = 5

            TB_HP.Value = 15
            TB_ATK.Value = 10
            TB_DEF.Value = 10
            TB_GES.Value = 20
            TB_REK.Value = 0

            L_HP.Text = TB_HP.Value
            L_ATK.Text = TB_ATK.Value
            L_DEF.Text = TB_DEF.Value
            L_GES.Text = TB_GES.Value
        End If

        If ComboBox1.Text = "Wasser Echse" Then

            TB_HP.Minimum = 20
            TB_HP.Maximum = 30
            TB_ATK.Minimum = 5
            TB_ATK.Maximum = 15
            TB_DEF.Minimum = 0
            TB_DEF.Maximum = 10
            TB_GES.Minimum = 10
            TB_GES.Maximum = 20
            TB_REK.Minimum = 0
            TB_REK.Maximum = 5

            TB_HP.Value = 25
            TB_ATK.Value = 10
            TB_DEF.Value = 5
            TB_GES.Value = 15
            TB_REK.Value = 0

            L_HP.Text = TB_HP.Value
            L_ATK.Text = TB_ATK.Value
            L_DEF.Text = TB_DEF.Value
            L_GES.Text = TB_GES.Value
        End If

        If ComboBox1.Text = "Wüsten Echse" Then

            TB_HP.Minimum = 15
            TB_HP.Maximum = 25
            TB_ATK.Minimum = 10
            TB_ATK.Maximum = 20
            TB_DEF.Minimum = 10
            TB_DEF.Maximum = 20
            TB_GES.Minimum = 0
            TB_GES.Maximum = 10
            TB_REK.Minimum = 0
            TB_REK.Maximum = 5

            TB_HP.Value = 20
            TB_ATK.Value = 15
            TB_DEF.Value = 15
            TB_GES.Value = 5
            TB_REK.Value = 0

            L_HP.Text = TB_HP.Value
            L_ATK.Text = TB_ATK.Value
            L_DEF.Text = TB_DEF.Value
            L_GES.Text = TB_GES.Value
            L_REK.Text = TB_REK.Value
        End If

        If ComboBox1.Text = "Weiß Magier" Then

            TB_HP.Minimum = 15
            TB_HP.Maximum = 25
            TB_ATK.Minimum = 5
            TB_ATK.Maximum = 15
            TB_DEF.Minimum = 0
            TB_DEF.Maximum = 10
            TB_GES.Minimum = 5
            TB_GES.Maximum = 15
            TB_REK.Minimum = 5
            TB_REK.Maximum = 15

            TB_HP.Value = 20
            TB_ATK.Value = 10
            TB_DEF.Value = 5
            TB_GES.Value = 10
            TB_REK.Value = 10

            L_HP.Text = TB_HP.Value
            L_ATK.Text = TB_ATK.Value
            L_DEF.Text = TB_DEF.Value
            L_GES.Text = TB_GES.Value
            L_REK.Text = TB_REK.Value
        End If

        If ComboBox1.Text = "Schwarz Magier" Then

            TB_HP.Minimum = 10
            TB_HP.Maximum = 20
            TB_ATK.Minimum = 15
            TB_ATK.Maximum = 25
            TB_DEF.Minimum = 5
            TB_DEF.Maximum = 15
            TB_GES.Minimum = 0
            TB_GES.Maximum = 10
            TB_REK.Minimum = 0
            TB_REK.Maximum = 10

            TB_HP.Value = 15
            TB_ATK.Value = 20
            TB_DEF.Value = 10
            TB_GES.Value = 5
            TB_REK.Value = 5

            L_HP.Text = TB_HP.Value
            L_ATK.Text = TB_ATK.Value
            L_DEF.Text = TB_DEF.Value
            L_GES.Text = TB_GES.Value
            L_REK.Text = TB_REK.Value
        End If


    End Sub

    Private Sub TB_HP_Scroll(sender As Object, e As EventArgs) Handles TB_HP.Scroll

        Dim ins As Integer
        Dim ap As Integer

        L_HP.Text = TB_HP.Value
        L_ATK.Text = TB_ATK.Value
        L_DEF.Text = TB_DEF.Value
        L_GES.Text = TB_GES.Value
        L_REK.Text = TB_REK.Value

        ins = TB_HP.Value + TB_ATK.Value + TB_DEF.Value + TB_GES.Value + TB_REK.Value
        ap = ins - 55
        ap = ap * (-1)

        L_AP.Text = ap

    End Sub

    Private Sub TB_ATK_Scroll(sender As Object, e As EventArgs) Handles TB_ATK.Scroll
        Dim ins As Integer
        Dim ap As Integer

        L_HP.Text = TB_HP.Value
        L_ATK.Text = TB_ATK.Value
        L_DEF.Text = TB_DEF.Value
        L_GES.Text = TB_GES.Value
        L_REK.Text = TB_REK.Value

        ins = TB_HP.Value + TB_ATK.Value + TB_DEF.Value + TB_GES.Value + TB_REK.Value
        ap = ins - 55
        ap = ap * (-1)

        L_AP.Text = ap

    End Sub

    Private Sub TB_DEF_Scroll(sender As Object, e As EventArgs) Handles TB_DEF.Scroll
        Dim ins As Integer
        Dim ap As Integer

        L_HP.Text = TB_HP.Value
        L_ATK.Text = TB_ATK.Value
        L_DEF.Text = TB_DEF.Value
        L_GES.Text = TB_GES.Value
        L_REK.Text = TB_REK.Value

        ins = TB_HP.Value + TB_ATK.Value + TB_DEF.Value + TB_GES.Value + TB_REK.Value
        ap = ins - 55
        ap = ap * (-1)

        L_AP.Text = ap

    End Sub

    Private Sub TB_GES_Scroll(sender As Object, e As EventArgs) Handles TB_GES.Scroll
        Dim ins As Integer
        Dim ap As Integer

        L_HP.Text = TB_HP.Value
        L_ATK.Text = TB_ATK.Value
        L_DEF.Text = TB_DEF.Value
        L_GES.Text = TB_GES.Value
        L_REK.Text = TB_REK.Value

        ins = TB_HP.Value + TB_ATK.Value + TB_DEF.Value + TB_GES.Value + TB_REK.Value
        ap = ins - 55
        ap = ap * (-1)

        L_AP.Text = ap

    End Sub

    Private Sub TB_REK_Scroll(sender As Object, e As EventArgs) Handles TB_REK.Scroll
        Dim ins As Integer
        Dim ap As Integer

        L_HP.Text = TB_HP.Value
        L_ATK.Text = TB_ATK.Value
        L_DEF.Text = TB_DEF.Value
        L_GES.Text = TB_GES.Value
        L_REK.Text = TB_REK.Value

        ins = TB_HP.Value + TB_ATK.Value + TB_DEF.Value + TB_GES.Value + TB_REK.Value
        ap = ins - 55
        ap = ap * (-1)

        L_AP.Text = ap

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Die Attributpunkte müssen auf 0 sein um den Charakter zu speichern")

    End Sub

    Private Sub BZurück_Click(sender As Object, e As EventArgs) Handles BZurück.Click

        If MsgBox("Wollen sie ohne Spiechern zurückkehren ?", vbYesNo) = vbYes Then
            Close()
        End If

    End Sub

    Private Sub BSpeichern_Click(sender As Object, e As EventArgs) Handles BSpeichern.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Im Namensfeld ist nichts eingetragen !!!", vbCritical)
        Else
            If Not L_AP.Text = 0 Then
                MsgBox("Die Attribut Punkte mussen auf 0 stehen", vbCritical)
            Else
                Dim geschlecht As String
                If RadioButton1.Checked Then
                    geschlecht = "Männlich"
                Else
                    geschlecht = "Weiblich"
                End If


                'Variabeln ...
                Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
                Dim YourPath As String = appData + "\PaP-Memestan"
                Dim list As String

                'liste füllen....
                list = "ID: " + L_Id.Text.ToString + vbCrLf + "NAME: " + TextBox1.Text.ToString + vbCrLf + "GESCHLECHT: " + geschlecht.ToString + vbCrLf + "RASSE: " + ComboBox1.Text.ToString + vbCrLf + "ERSTWAFFE: " + ComboBox2.Text.ToString + vbCrLf + "HP: " + TB_HP.Value.ToString + vbCrLf + "ATK: " + TB_ATK.Value.ToString + vbCrLf + "DEF: " + TB_DEF.Value.ToString + vbCrLf + "GES: " + TB_GES.Value.ToString + vbCrLf + "REK: " + TB_REK.Value.ToString + vbCrLf

                'Create Path
                If (Not System.IO.Directory.Exists(YourPath)) Then
                    System.IO.Directory.CreateDirectory(YourPath)
                End If

                'joe datei erstellen mit infos
                Dim fs As FileStream = File.Create(YourPath + "\" + L_Id.Text + ".joe")
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(list)
                fs.Write(info, 0, info.Length)
                fs.Close()


                If (Not System.IO.Directory.Exists(YourPath + "\info.joe")) Then
                    Dim fss As FileStream = File.Create(YourPath + "\info.joe")
                    Dim info3 As Byte() = New UTF8Encoding(True).GetBytes("1: " + L_Id.Text)
                    fss.Write(info3, 0, info3.Length)
                    fss.Close()

                End If

                MsgBox("Charakter erfolgreich erstellt !!!", vbInformation)
                Close()
                End If
            End If
    End Sub
End Class