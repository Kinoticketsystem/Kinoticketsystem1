<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KinosaalTest
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
        Me.txtAnzahl = New System.Windows.Forms.TextBox()
        Me.txtReihe = New System.Windows.Forms.TextBox()
        Me.txtSitz = New System.Windows.Forms.TextBox()
        Me.txtFilm = New System.Windows.Forms.TextBox()
        Me.cmdErstellen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEingabeJ = New System.Windows.Forms.TextBox()
        Me.txtAusgabeX = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdAufrufen = New System.Windows.Forms.Button()
        Me.txtAusgabeY = New System.Windows.Forms.TextBox()
        Me.txtKunde = New System.Windows.Forms.TextBox()
        Me.txtEingabeI = New System.Windows.Forms.TextBox()
        Me.txtEingabeKunde = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAnzahl
        '
        Me.txtAnzahl.Location = New System.Drawing.Point(32, 38)
        Me.txtAnzahl.Name = "txtAnzahl"
        Me.txtAnzahl.Size = New System.Drawing.Size(248, 20)
        Me.txtAnzahl.TabIndex = 0
        '
        'txtReihe
        '
        Me.txtReihe.Location = New System.Drawing.Point(26, 180)
        Me.txtReihe.Name = "txtReihe"
        Me.txtReihe.Size = New System.Drawing.Size(246, 20)
        Me.txtReihe.TabIndex = 1
        '
        'txtSitz
        '
        Me.txtSitz.Location = New System.Drawing.Point(26, 227)
        Me.txtSitz.Name = "txtSitz"
        Me.txtSitz.Size = New System.Drawing.Size(245, 20)
        Me.txtSitz.TabIndex = 2
        '
        'txtFilm
        '
        Me.txtFilm.Location = New System.Drawing.Point(36, 87)
        Me.txtFilm.Name = "txtFilm"
        Me.txtFilm.Size = New System.Drawing.Size(244, 20)
        Me.txtFilm.TabIndex = 3
        '
        'cmdErstellen
        '
        Me.cmdErstellen.Location = New System.Drawing.Point(32, 296)
        Me.cmdErstellen.Name = "cmdErstellen"
        Me.cmdErstellen.Size = New System.Drawing.Size(240, 62)
        Me.cmdErstellen.TabIndex = 4
        Me.cmdErstellen.Text = "Button1"
        Me.cmdErstellen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Erstellen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(832, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Abrufen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Buchen"
        '
        'txtEingabeJ
        '
        Me.txtEingabeJ.Location = New System.Drawing.Point(391, 198)
        Me.txtEingabeJ.Name = "txtEingabeJ"
        Me.txtEingabeJ.Size = New System.Drawing.Size(248, 20)
        Me.txtEingabeJ.TabIndex = 8
        '
        'txtAusgabeX
        '
        Me.txtAusgabeX.Location = New System.Drawing.Point(788, 122)
        Me.txtAusgabeX.Name = "txtAusgabeX"
        Me.txtAusgabeX.Size = New System.Drawing.Size(127, 20)
        Me.txtAusgabeX.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(383, 276)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(256, 47)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdAufrufen
        '
        Me.cmdAufrufen.Location = New System.Drawing.Point(788, 270)
        Me.cmdAufrufen.Name = "cmdAufrufen"
        Me.cmdAufrufen.Size = New System.Drawing.Size(261, 53)
        Me.cmdAufrufen.TabIndex = 11
        Me.cmdAufrufen.Text = "Button3"
        Me.cmdAufrufen.UseVisualStyleBackColor = True
        '
        'txtAusgabeY
        '
        Me.txtAusgabeY.Location = New System.Drawing.Point(788, 180)
        Me.txtAusgabeY.Name = "txtAusgabeY"
        Me.txtAusgabeY.Size = New System.Drawing.Size(126, 20)
        Me.txtAusgabeY.TabIndex = 12
        '
        'txtKunde
        '
        Me.txtKunde.Location = New System.Drawing.Point(796, 437)
        Me.txtKunde.Name = "txtKunde"
        Me.txtKunde.Size = New System.Drawing.Size(175, 20)
        Me.txtKunde.TabIndex = 13
        '
        'txtEingabeI
        '
        Me.txtEingabeI.Location = New System.Drawing.Point(391, 111)
        Me.txtEingabeI.Name = "txtEingabeI"
        Me.txtEingabeI.Size = New System.Drawing.Size(247, 20)
        Me.txtEingabeI.TabIndex = 14
        '
        'txtEingabeKunde
        '
        Me.txtEingabeKunde.Location = New System.Drawing.Point(382, 421)
        Me.txtEingabeKunde.Name = "txtEingabeKunde"
        Me.txtEingabeKunde.Size = New System.Drawing.Size(255, 20)
        Me.txtEingabeKunde.TabIndex = 15
        '
        'KinosaalTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 626)
        Me.Controls.Add(Me.txtEingabeKunde)
        Me.Controls.Add(Me.txtEingabeI)
        Me.Controls.Add(Me.txtKunde)
        Me.Controls.Add(Me.txtAusgabeY)
        Me.Controls.Add(Me.cmdAufrufen)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtAusgabeX)
        Me.Controls.Add(Me.txtEingabeJ)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdErstellen)
        Me.Controls.Add(Me.txtFilm)
        Me.Controls.Add(Me.txtSitz)
        Me.Controls.Add(Me.txtReihe)
        Me.Controls.Add(Me.txtAnzahl)
        Me.Name = "KinosaalTest"
        Me.Text = "KinosaalTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAnzahl As TextBox
    Friend WithEvents txtReihe As TextBox
    Friend WithEvents txtSitz As TextBox
    Friend WithEvents txtFilm As TextBox
    Friend WithEvents cmdErstellen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEingabeJ As TextBox
    Friend WithEvents txtAusgabeX As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdAufrufen As Button
    Friend WithEvents txtAusgabeY As TextBox
    Friend WithEvents txtKunde As TextBox
    Friend WithEvents txtEingabeI As TextBox
    Friend WithEvents txtEingabeKunde As TextBox
End Class
