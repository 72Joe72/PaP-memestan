<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptmenü
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SPIELEN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CharaktererstellungB = New System.Windows.Forms.Button()
        Me.Beenden = New System.Windows.Forms.Button()
        Me.Haupt = New System.Windows.Forms.Panel()
        Me.Chara1 = New System.Windows.Forms.Panel()
        Me.zurück_chara = New System.Windows.Forms.Button()
        Me.load_chara = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Neu_chara = New System.Windows.Forms.Button()
        Me.SpielenP = New System.Windows.Forms.Panel()
        Me.zurück_Spiel = New System.Windows.Forms.Button()
        Me.PJoinB = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GMJoinB = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Haupt.SuspendLayout()
        Me.Chara1.SuspendLayout()
        Me.SpielenP.SuspendLayout()
        Me.SuspendLayout()
        '
        'SPIELEN
        '
        Me.SPIELEN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SPIELEN.Location = New System.Drawing.Point(19, 154)
        Me.SPIELEN.Name = "SPIELEN"
        Me.SPIELEN.Size = New System.Drawing.Size(243, 45)
        Me.SPIELEN.TabIndex = 0
        Me.SPIELEN.Text = "SPIELEN"
        Me.SPIELEN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pen and Paper"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Memestan"
        '
        'CharaktererstellungB
        '
        Me.CharaktererstellungB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CharaktererstellungB.Location = New System.Drawing.Point(19, 231)
        Me.CharaktererstellungB.Name = "CharaktererstellungB"
        Me.CharaktererstellungB.Size = New System.Drawing.Size(243, 45)
        Me.CharaktererstellungB.TabIndex = 3
        Me.CharaktererstellungB.Text = "Charaktererstellung"
        Me.CharaktererstellungB.UseVisualStyleBackColor = True
        '
        'Beenden
        '
        Me.Beenden.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Beenden.Location = New System.Drawing.Point(19, 308)
        Me.Beenden.Name = "Beenden"
        Me.Beenden.Size = New System.Drawing.Size(243, 45)
        Me.Beenden.TabIndex = 4
        Me.Beenden.Text = "Beenden"
        Me.Beenden.UseVisualStyleBackColor = True
        '
        'Haupt
        '
        Me.Haupt.BackColor = System.Drawing.SystemColors.Highlight
        Me.Haupt.Controls.Add(Me.Beenden)
        Me.Haupt.Controls.Add(Me.CharaktererstellungB)
        Me.Haupt.Controls.Add(Me.Label2)
        Me.Haupt.Controls.Add(Me.Label1)
        Me.Haupt.Controls.Add(Me.SPIELEN)
        Me.Haupt.Location = New System.Drawing.Point(381, 415)
        Me.Haupt.Name = "Haupt"
        Me.Haupt.Size = New System.Drawing.Size(285, 382)
        Me.Haupt.TabIndex = 5
        '
        'Chara1
        '
        Me.Chara1.BackColor = System.Drawing.SystemColors.Window
        Me.Chara1.Controls.Add(Me.zurück_chara)
        Me.Chara1.Controls.Add(Me.load_chara)
        Me.Chara1.Controls.Add(Me.Label4)
        Me.Chara1.Controls.Add(Me.Neu_chara)
        Me.Chara1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Chara1.Location = New System.Drawing.Point(680, 30)
        Me.Chara1.Name = "Chara1"
        Me.Chara1.Size = New System.Drawing.Size(276, 367)
        Me.Chara1.TabIndex = 6
        '
        'zurück_chara
        '
        Me.zurück_chara.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.zurück_chara.Location = New System.Drawing.Point(19, 308)
        Me.zurück_chara.Name = "zurück_chara"
        Me.zurück_chara.Size = New System.Drawing.Size(243, 45)
        Me.zurück_chara.TabIndex = 4
        Me.zurück_chara.Text = "Zurück"
        Me.zurück_chara.UseVisualStyleBackColor = True
        '
        'load_chara
        '
        Me.load_chara.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.load_chara.Location = New System.Drawing.Point(19, 231)
        Me.load_chara.Name = "load_chara"
        Me.load_chara.Size = New System.Drawing.Size(243, 45)
        Me.load_chara.TabIndex = 3
        Me.load_chara.Text = "Load"
        Me.load_chara.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Charaktererstellung"
        '
        'Neu_chara
        '
        Me.Neu_chara.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Neu_chara.Location = New System.Drawing.Point(19, 154)
        Me.Neu_chara.Name = "Neu_chara"
        Me.Neu_chara.Size = New System.Drawing.Size(243, 45)
        Me.Neu_chara.TabIndex = 0
        Me.Neu_chara.Text = "Neu"
        Me.Neu_chara.UseVisualStyleBackColor = True
        '
        'SpielenP
        '
        Me.SpielenP.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SpielenP.Controls.Add(Me.zurück_Spiel)
        Me.SpielenP.Controls.Add(Me.PJoinB)
        Me.SpielenP.Controls.Add(Me.Label3)
        Me.SpielenP.Controls.Add(Me.GMJoinB)
        Me.SpielenP.Location = New System.Drawing.Point(381, 30)
        Me.SpielenP.Name = "SpielenP"
        Me.SpielenP.Size = New System.Drawing.Size(276, 367)
        Me.SpielenP.TabIndex = 7
        '
        'zurück_Spiel
        '
        Me.zurück_Spiel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.zurück_Spiel.Location = New System.Drawing.Point(19, 308)
        Me.zurück_Spiel.Name = "zurück_Spiel"
        Me.zurück_Spiel.Size = New System.Drawing.Size(243, 45)
        Me.zurück_Spiel.TabIndex = 4
        Me.zurück_Spiel.Text = "Zurück"
        Me.zurück_Spiel.UseVisualStyleBackColor = True
        '
        'PJoinB
        '
        Me.PJoinB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PJoinB.Location = New System.Drawing.Point(19, 231)
        Me.PJoinB.Name = "PJoinB"
        Me.PJoinB.Size = New System.Drawing.Size(243, 45)
        Me.PJoinB.TabIndex = 3
        Me.PJoinB.Text = "Player Join"
        Me.PJoinB.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Spielen"
        '
        'GMJoinB
        '
        Me.GMJoinB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GMJoinB.Location = New System.Drawing.Point(19, 154)
        Me.GMJoinB.Name = "GMJoinB"
        Me.GMJoinB.Size = New System.Drawing.Size(243, 45)
        Me.GMJoinB.TabIndex = 0
        Me.GMJoinB.Text = "Gamemaster Join"
        Me.GMJoinB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(51, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 82)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Hauptmenü
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Haupt)
        Me.Controls.Add(Me.SpielenP)
        Me.Controls.Add(Me.Chara1)
        Me.Name = "Hauptmenü"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hauptmenü"
        Me.Haupt.ResumeLayout(False)
        Me.Haupt.PerformLayout()
        Me.Chara1.ResumeLayout(False)
        Me.Chara1.PerformLayout()
        Me.SpielenP.ResumeLayout(False)
        Me.SpielenP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SPIELEN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CharaktererstellungB As Button
    Friend WithEvents Beenden As Button
    Friend WithEvents Haupt As Panel
    Friend WithEvents Chara1 As Panel
    Friend WithEvents zurück_chara As Button
    Friend WithEvents load_chara As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Neu_chara As Button
    Friend WithEvents SpielenP As Panel
    Friend WithEvents zurück_Spiel As Button
    Friend WithEvents PJoinB As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GMJoinB As Button
    Friend WithEvents Button1 As Button
End Class
