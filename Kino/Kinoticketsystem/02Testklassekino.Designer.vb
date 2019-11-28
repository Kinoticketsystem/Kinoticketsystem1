<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Testklassekino
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
        Me.cmdNeueBUchung = New System.Windows.Forms.Button()
        Me.cmdtestsetkinosaal = New System.Windows.Forms.Button()
        Me.cmdTestSetFilm = New System.Windows.Forms.Button()
        Me.cmdTestSetKunden = New System.Windows.Forms.Button()
        Me.cmdTestSetAnzahlkinosaal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdNeueBUchung
        '
        Me.cmdNeueBUchung.Location = New System.Drawing.Point(424, 283)
        Me.cmdNeueBUchung.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdNeueBUchung.Name = "cmdNeueBUchung"
        Me.cmdNeueBUchung.Size = New System.Drawing.Size(308, 94)
        Me.cmdNeueBUchung.TabIndex = 2
        Me.cmdNeueBUchung.Text = "neue Buchung"
        Me.cmdNeueBUchung.UseVisualStyleBackColor = True
        '
        'cmdtestsetkinosaal
        '
        Me.cmdtestsetkinosaal.Location = New System.Drawing.Point(780, 313)
        Me.cmdtestsetkinosaal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdtestsetkinosaal.Name = "cmdtestsetkinosaal"
        Me.cmdtestsetkinosaal.Size = New System.Drawing.Size(136, 63)
        Me.cmdtestsetkinosaal.TabIndex = 3
        Me.cmdtestsetkinosaal.Text = "setkinosaal"
        Me.cmdtestsetkinosaal.UseVisualStyleBackColor = True
        '
        'cmdTestSetFilm
        '
        Me.cmdTestSetFilm.Location = New System.Drawing.Point(990, 313)
        Me.cmdTestSetFilm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTestSetFilm.Name = "cmdTestSetFilm"
        Me.cmdTestSetFilm.Size = New System.Drawing.Size(136, 63)
        Me.cmdTestSetFilm.TabIndex = 4
        Me.cmdTestSetFilm.Text = "setfilm"
        Me.cmdTestSetFilm.UseVisualStyleBackColor = True
        '
        'cmdTestSetKunden
        '
        Me.cmdTestSetKunden.Location = New System.Drawing.Point(1156, 313)
        Me.cmdTestSetKunden.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTestSetKunden.Name = "cmdTestSetKunden"
        Me.cmdTestSetKunden.Size = New System.Drawing.Size(136, 63)
        Me.cmdTestSetKunden.TabIndex = 5
        Me.cmdTestSetKunden.Text = "setKunden"
        Me.cmdTestSetKunden.UseVisualStyleBackColor = True
        '
        'cmdTestSetAnzahlkinosaal
        '
        Me.cmdTestSetAnzahlkinosaal.Location = New System.Drawing.Point(1342, 313)
        Me.cmdTestSetAnzahlkinosaal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTestSetAnzahlkinosaal.Name = "cmdTestSetAnzahlkinosaal"
        Me.cmdTestSetAnzahlkinosaal.Size = New System.Drawing.Size(136, 63)
        Me.cmdTestSetAnzahlkinosaal.TabIndex = 7
        Me.cmdTestSetAnzahlkinosaal.Text = "setAnzahlKinosaal"
        Me.cmdTestSetAnzahlkinosaal.UseVisualStyleBackColor = True
        '
        'Testklassekino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2064, 749)
        Me.Controls.Add(Me.cmdTestSetAnzahlkinosaal)
        Me.Controls.Add(Me.cmdTestSetKunden)
        Me.Controls.Add(Me.cmdTestSetFilm)
        Me.Controls.Add(Me.cmdtestsetkinosaal)
        Me.Controls.Add(Me.cmdNeueBUchung)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Testklassekino"
        Me.Text = "Testklassekino"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdNeueBUchung As Button
    Friend WithEvents cmdtestsetkinosaal As Button
    Friend WithEvents cmdTestSetFilm As Button
    Friend WithEvents cmdTestSetKunden As Button
    Friend WithEvents cmdTestSetAnzahlkinosaal As Button
End Class
