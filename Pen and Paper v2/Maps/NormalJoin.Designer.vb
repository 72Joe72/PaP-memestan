<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NormalJoin
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TB_IP = New System.Windows.Forms.TextBox()
        Me.B_connect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_chara = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel_Chara_Auto = New System.Windows.Forms.Panel()
        Me.Panel_Chara_Manu = New System.Windows.Forms.Panel()
        Me.B_Chara_Manu_Zurück = New System.Windows.Forms.Button()
        Me.TB_Chara_Manu = New System.Windows.Forms.TextBox()
        Me.B_Char_Manu_Ändern = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel_Chara_Auto.SuspendLayout()
        Me.Panel_Chara_Manu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 36)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Zurück"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TB_IP
        '
        Me.TB_IP.Location = New System.Drawing.Point(82, 6)
        Me.TB_IP.Name = "TB_IP"
        Me.TB_IP.Size = New System.Drawing.Size(168, 20)
        Me.TB_IP.TabIndex = 7
        '
        'B_connect
        '
        Me.B_connect.Location = New System.Drawing.Point(99, 406)
        Me.B_connect.Name = "B_connect"
        Me.B_connect.Size = New System.Drawing.Size(81, 36)
        Me.B_connect.TabIndex = 8
        Me.B_connect.Text = "Connect"
        Me.B_connect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "IP- Adresse:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Charakter:"
        '
        'L_chara
        '
        Me.L_chara.AutoSize = True
        Me.L_chara.Location = New System.Drawing.Point(0, 5)
        Me.L_chara.Name = "L_chara"
        Me.L_chara.Size = New System.Drawing.Size(67, 13)
        Me.L_chara.TabIndex = 11
        Me.L_chara.Text = "0000000000"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Manuel Ändern"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel_Chara_Auto
        '
        Me.Panel_Chara_Auto.Controls.Add(Me.L_chara)
        Me.Panel_Chara_Auto.Controls.Add(Me.Button1)
        Me.Panel_Chara_Auto.Location = New System.Drawing.Point(74, 32)
        Me.Panel_Chara_Auto.Name = "Panel_Chara_Auto"
        Me.Panel_Chara_Auto.Size = New System.Drawing.Size(216, 54)
        Me.Panel_Chara_Auto.TabIndex = 13
        '
        'Panel_Chara_Manu
        '
        Me.Panel_Chara_Manu.Controls.Add(Me.B_Chara_Manu_Zurück)
        Me.Panel_Chara_Manu.Controls.Add(Me.TB_Chara_Manu)
        Me.Panel_Chara_Manu.Controls.Add(Me.B_Char_Manu_Ändern)
        Me.Panel_Chara_Manu.Location = New System.Drawing.Point(74, 32)
        Me.Panel_Chara_Manu.Name = "Panel_Chara_Manu"
        Me.Panel_Chara_Manu.Size = New System.Drawing.Size(216, 54)
        Me.Panel_Chara_Manu.TabIndex = 14
        Me.Panel_Chara_Manu.Visible = False
        '
        'B_Chara_Manu_Zurück
        '
        Me.B_Chara_Manu_Zurück.Location = New System.Drawing.Point(115, 28)
        Me.B_Chara_Manu_Zurück.Name = "B_Chara_Manu_Zurück"
        Me.B_Chara_Manu_Zurück.Size = New System.Drawing.Size(98, 23)
        Me.B_Chara_Manu_Zurück.TabIndex = 14
        Me.B_Chara_Manu_Zurück.Text = "zurück"
        Me.B_Chara_Manu_Zurück.UseVisualStyleBackColor = True
        '
        'TB_Chara_Manu
        '
        Me.TB_Chara_Manu.Location = New System.Drawing.Point(0, 2)
        Me.TB_Chara_Manu.Name = "TB_Chara_Manu"
        Me.TB_Chara_Manu.Size = New System.Drawing.Size(109, 20)
        Me.TB_Chara_Manu.TabIndex = 13
        '
        'B_Char_Manu_Ändern
        '
        Me.B_Char_Manu_Ändern.Location = New System.Drawing.Point(115, 0)
        Me.B_Char_Manu_Ändern.Name = "B_Char_Manu_Ändern"
        Me.B_Char_Manu_Ändern.Size = New System.Drawing.Size(98, 23)
        Me.B_Char_Manu_Ändern.TabIndex = 12
        Me.B_Char_Manu_Ändern.Text = "Ändern"
        Me.B_Char_Manu_Ändern.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(296, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 54)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Anzeigen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NormalJoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 454)
        Me.Controls.Add(Me.Panel_Chara_Auto)
        Me.Controls.Add(Me.Panel_Chara_Manu)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_connect)
        Me.Controls.Add(Me.TB_IP)
        Me.Controls.Add(Me.Button2)
        Me.Name = "NormalJoin"
        Me.Text = "NormalJoin"
        Me.Panel_Chara_Auto.ResumeLayout(False)
        Me.Panel_Chara_Auto.PerformLayout()
        Me.Panel_Chara_Manu.ResumeLayout(False)
        Me.Panel_Chara_Manu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents TB_IP As TextBox
    Friend WithEvents B_connect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents L_chara As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_Chara_Auto As Panel
    Friend WithEvents Panel_Chara_Manu As Panel
    Friend WithEvents B_Chara_Manu_Zurück As Button
    Friend WithEvents TB_Chara_Manu As TextBox
    Friend WithEvents B_Char_Manu_Ändern As Button
    Friend WithEvents Button3 As Button
End Class
