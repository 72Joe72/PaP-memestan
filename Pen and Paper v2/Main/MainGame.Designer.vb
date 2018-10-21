<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGame
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
        Me.LB_info = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LB_info
        '
        Me.LB_info.FormattingEnabled = True
        Me.LB_info.Location = New System.Drawing.Point(12, 12)
        Me.LB_info.Name = "LB_info"
        Me.LB_info.Size = New System.Drawing.Size(79, 69)
        Me.LB_info.TabIndex = 0
        '
        'MainGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LB_info)
        Me.Name = "MainGame"
        Me.Text = "MainGame"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LB_info As ListBox
End Class
