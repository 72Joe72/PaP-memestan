<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chara_info
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
        Me.BZurück = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.L_ATK = New System.Windows.Forms.Label()
        Me.L_DEF = New System.Windows.Forms.Label()
        Me.L_GES = New System.Windows.Forms.Label()
        Me.L_REK = New System.Windows.Forms.Label()
        Me.L_Attribut = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_HP = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Lable3 = New System.Windows.Forms.Label()
        Me.L_Id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BZurück
        '
        Me.BZurück.Location = New System.Drawing.Point(12, 381)
        Me.BZurück.Name = "BZurück"
        Me.BZurück.Size = New System.Drawing.Size(387, 26)
        Me.BZurück.TabIndex = 49
        Me.BZurück.Text = "Zurück"
        Me.BZurück.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Location = New System.Drawing.Point(185, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(187, 30)
        Me.Panel2.TabIndex = 48
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(95, 6)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton2.TabIndex = 28
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Weiblich"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(3, 6)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton1.TabIndex = 27
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Männlich"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 25)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Geschlecht:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.L_ATK)
        Me.Panel1.Controls.Add(Me.L_DEF)
        Me.Panel1.Controls.Add(Me.L_GES)
        Me.Panel1.Controls.Add(Me.L_REK)
        Me.Panel1.Controls.Add(Me.L_Attribut)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.L_HP)
        Me.Panel1.Location = New System.Drawing.Point(405, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 401)
        Me.Panel1.TabIndex = 45
        '
        'L_ATK
        '
        Me.L_ATK.AutoSize = True
        Me.L_ATK.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ATK.Location = New System.Drawing.Point(59, 141)
        Me.L_ATK.Name = "L_ATK"
        Me.L_ATK.Size = New System.Drawing.Size(17, 25)
        Me.L_ATK.TabIndex = 28
        Me.L_ATK.Text = "."
        '
        'L_DEF
        '
        Me.L_DEF.AutoSize = True
        Me.L_DEF.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DEF.Location = New System.Drawing.Point(61, 206)
        Me.L_DEF.Name = "L_DEF"
        Me.L_DEF.Size = New System.Drawing.Size(17, 25)
        Me.L_DEF.TabIndex = 27
        Me.L_DEF.Text = "."
        '
        'L_GES
        '
        Me.L_GES.AutoSize = True
        Me.L_GES.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_GES.Location = New System.Drawing.Point(59, 271)
        Me.L_GES.Name = "L_GES"
        Me.L_GES.Size = New System.Drawing.Size(17, 25)
        Me.L_GES.TabIndex = 26
        Me.L_GES.Text = "."
        '
        'L_REK
        '
        Me.L_REK.AutoSize = True
        Me.L_REK.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_REK.Location = New System.Drawing.Point(59, 327)
        Me.L_REK.Name = "L_REK"
        Me.L_REK.Size = New System.Drawing.Size(17, 25)
        Me.L_REK.TabIndex = 25
        Me.L_REK.Text = "."
        '
        'L_Attribut
        '
        Me.L_Attribut.AutoSize = True
        Me.L_Attribut.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Attribut.Location = New System.Drawing.Point(101, 0)
        Me.L_Attribut.Name = "L_Attribut"
        Me.L_Attribut.Size = New System.Drawing.Size(0, 25)
        Me.L_Attribut.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Attribute:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "HP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ATK:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "DEF:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "GES:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REK:"
        '
        'L_HP
        '
        Me.L_HP.AutoSize = True
        Me.L_HP.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_HP.Location = New System.Drawing.Point(59, 76)
        Me.L_HP.Name = "L_HP"
        Me.L_HP.Size = New System.Drawing.Size(17, 25)
        Me.L_HP.TabIndex = 1
        Me.L_HP.Text = "."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(755, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 25)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "."
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Einhänder-Schwert", "Zweihänder-Schwert", "Einhänder-Axt", "Zweihänder-Axt", "Einhänder-Stab", "Zweihänder-Stab", "Dolch", "Schild"})
        Me.ComboBox2.Location = New System.Drawing.Point(185, 245)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox2.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Erstwaffe:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mensch", "Elb", "Zwerg", "Kobold", "Wasser Echse", "Wüsten Echse", "Weiß Magier", "Schwarz Magier"})
        Me.ComboBox1.Location = New System.Drawing.Point(185, 126)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox1.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Rasse:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 20)
        Me.TextBox1.TabIndex = 36
        '
        'Lable3
        '
        Me.Lable3.AutoSize = True
        Me.Lable3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable3.Location = New System.Drawing.Point(12, 45)
        Me.Lable3.Name = "Lable3"
        Me.Lable3.Size = New System.Drawing.Size(65, 25)
        Me.Lable3.TabIndex = 35
        Me.Lable3.Text = "Name:"
        '
        'L_Id
        '
        Me.L_Id.AutoSize = True
        Me.L_Id.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Id.Location = New System.Drawing.Point(180, 10)
        Me.L_Id.Name = "L_Id"
        Me.L_Id.Size = New System.Drawing.Size(112, 25)
        Me.L_Id.TabIndex = 33
        Me.L_Id.Text = "0000000000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "ID:"
        '
        'Chara_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 450)
        Me.Controls.Add(Me.BZurück)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Lable3)
        Me.Controls.Add(Me.L_Id)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Chara_info"
        Me.Text = "Chara_info"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BZurück As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents L_ATK As Label
    Friend WithEvents L_DEF As Label
    Friend WithEvents L_GES As Label
    Friend WithEvents L_REK As Label
    Friend WithEvents L_Attribut As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents L_HP As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lable3 As Label
    Friend WithEvents L_Id As Label
    Friend WithEvents Label2 As Label
End Class
