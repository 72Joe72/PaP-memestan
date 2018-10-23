<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterJoin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_connect = New System.Windows.Forms.Button()
        Me.TB_IP = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "IP- Adresse:"
        '
        'B_connect
        '
        Me.B_connect.Location = New System.Drawing.Point(99, 406)
        Me.B_connect.Name = "B_connect"
        Me.B_connect.Size = New System.Drawing.Size(81, 36)
        Me.B_connect.TabIndex = 18
        Me.B_connect.Text = "Connect"
        Me.B_connect.UseVisualStyleBackColor = True
        '
        'TB_IP
        '
        Me.TB_IP.Location = New System.Drawing.Point(82, 6)
        Me.TB_IP.Name = "TB_IP"
        Me.TB_IP.Size = New System.Drawing.Size(168, 20)
        Me.TB_IP.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 36)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Zurück"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MasterJoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_connect)
        Me.Controls.Add(Me.TB_IP)
        Me.Controls.Add(Me.Button2)
        Me.Name = "MasterJoin"
        Me.Text = "MasterJoin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents B_connect As Button
    Friend WithEvents TB_IP As TextBox
    Friend WithEvents Button2 As Button
End Class
