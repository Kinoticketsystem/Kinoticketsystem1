<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FTagesplan
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
        Me.cmdTagesPlanErstellen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdTagesPlanErstellen
        '
        Me.cmdTagesPlanErstellen.Location = New System.Drawing.Point(76, 52)
        Me.cmdTagesPlanErstellen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTagesPlanErstellen.Name = "cmdTagesPlanErstellen"
        Me.cmdTagesPlanErstellen.Size = New System.Drawing.Size(185, 32)
        Me.cmdTagesPlanErstellen.TabIndex = 0
        Me.cmdTagesPlanErstellen.Text = "Tagesplan erstellen"
        Me.cmdTagesPlanErstellen.UseVisualStyleBackColor = True
        '
        'FTagesplan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 403)
        Me.Controls.Add(Me.cmdTagesPlanErstellen)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FTagesplan"
        Me.Text = "Tagesplan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdTagesPlanErstellen As Button
End Class
