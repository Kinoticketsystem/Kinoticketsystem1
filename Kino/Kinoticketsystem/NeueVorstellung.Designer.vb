<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NeueVorstellung
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
        Me.cmdfertig = New System.Windows.Forms.Button()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblstartuhrzeit = New System.Windows.Forms.Label()
        Me.lblEnduhrszeit = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtStartuhrzeit = New System.Windows.Forms.TextBox()
        Me.txtenduhrzeit = New System.Windows.Forms.TextBox()
        Me.lblFilmAuswählen = New System.Windows.Forms.Label()
        Me.cmdFilmHinZuFügen = New System.Windows.Forms.Button()
        Me.cmdBesucherHinzufügen = New System.Windows.Forms.Button()
        Me.lblBesucherAuswähler = New System.Windows.Forms.Label()
        Me.chlFilme = New System.Windows.Forms.CheckedListBox()
        Me.chlBesucherAuswählen = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'cmdfertig
        '
        Me.cmdfertig.Location = New System.Drawing.Point(554, 474)
        Me.cmdfertig.Name = "cmdfertig"
        Me.cmdfertig.Size = New System.Drawing.Size(75, 32)
        Me.cmdfertig.TabIndex = 0
        Me.cmdfertig.Text = "fertig"
        Me.cmdfertig.UseVisualStyleBackColor = True
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(43, 35)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(143, 22)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Vorstellungstitel:"
        '
        'lblstartuhrzeit
        '
        Me.lblstartuhrzeit.AutoSize = True
        Me.lblstartuhrzeit.Location = New System.Drawing.Point(43, 71)
        Me.lblstartuhrzeit.Name = "lblstartuhrzeit"
        Me.lblstartuhrzeit.Size = New System.Drawing.Size(106, 22)
        Me.lblstartuhrzeit.TabIndex = 2
        Me.lblstartuhrzeit.Text = "Startuhrzeit:"
        '
        'lblEnduhrszeit
        '
        Me.lblEnduhrszeit.AutoSize = True
        Me.lblEnduhrszeit.Location = New System.Drawing.Point(43, 107)
        Me.lblEnduhrszeit.Name = "lblEnduhrszeit"
        Me.lblEnduhrszeit.Size = New System.Drawing.Size(100, 22)
        Me.lblEnduhrszeit.TabIndex = 3
        Me.lblEnduhrszeit.Text = "Enduhrzeit:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(251, 35)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(197, 30)
        Me.txtname.TabIndex = 4
        '
        'txtStartuhrzeit
        '
        Me.txtStartuhrzeit.Location = New System.Drawing.Point(251, 71)
        Me.txtStartuhrzeit.Name = "txtStartuhrzeit"
        Me.txtStartuhrzeit.Size = New System.Drawing.Size(100, 30)
        Me.txtStartuhrzeit.TabIndex = 5
        '
        'txtenduhrzeit
        '
        Me.txtenduhrzeit.Location = New System.Drawing.Point(251, 107)
        Me.txtenduhrzeit.Name = "txtenduhrzeit"
        Me.txtenduhrzeit.Size = New System.Drawing.Size(100, 30)
        Me.txtenduhrzeit.TabIndex = 6
        '
        'lblFilmAuswählen
        '
        Me.lblFilmAuswählen.AutoSize = True
        Me.lblFilmAuswählen.Location = New System.Drawing.Point(43, 143)
        Me.lblFilmAuswählen.Name = "lblFilmAuswählen"
        Me.lblFilmAuswählen.Size = New System.Drawing.Size(141, 22)
        Me.lblFilmAuswählen.TabIndex = 8
        Me.lblFilmAuswählen.Text = "Film auswählen:"
        '
        'cmdFilmHinZuFügen
        '
        Me.cmdFilmHinZuFügen.Location = New System.Drawing.Point(293, 291)
        Me.cmdFilmHinZuFügen.Name = "cmdFilmHinZuFügen"
        Me.cmdFilmHinZuFügen.Size = New System.Drawing.Size(155, 32)
        Me.cmdFilmHinZuFügen.TabIndex = 9
        Me.cmdFilmHinZuFügen.Text = "Film hinzufügen"
        Me.cmdFilmHinZuFügen.UseVisualStyleBackColor = True
        '
        'cmdBesucherHinzufügen
        '
        Me.cmdBesucherHinzufügen.Location = New System.Drawing.Point(266, 464)
        Me.cmdBesucherHinzufügen.Name = "cmdBesucherHinzufügen"
        Me.cmdBesucherHinzufügen.Size = New System.Drawing.Size(182, 32)
        Me.cmdBesucherHinzufügen.TabIndex = 12
        Me.cmdBesucherHinzufügen.Text = "Besucher hinzufügen"
        Me.cmdBesucherHinzufügen.UseVisualStyleBackColor = True
        '
        'lblBesucherAuswähler
        '
        Me.lblBesucherAuswähler.AutoSize = True
        Me.lblBesucherAuswähler.Location = New System.Drawing.Point(43, 329)
        Me.lblBesucherAuswähler.Name = "lblBesucherAuswähler"
        Me.lblBesucherAuswähler.Size = New System.Drawing.Size(177, 22)
        Me.lblBesucherAuswähler.TabIndex = 11
        Me.lblBesucherAuswähler.Text = "Besucher auswählen:"
        '
        'chlFilme
        '
        Me.chlFilme.FormattingEnabled = True
        Me.chlFilme.Location = New System.Drawing.Point(251, 143)
        Me.chlFilme.Name = "chlFilme"
        Me.chlFilme.Size = New System.Drawing.Size(197, 129)
        Me.chlFilme.TabIndex = 13
        '
        'chlBesucherAuswählen
        '
        Me.chlBesucherAuswählen.FormattingEnabled = True
        Me.chlBesucherAuswählen.Location = New System.Drawing.Point(251, 329)
        Me.chlBesucherAuswählen.Name = "chlBesucherAuswählen"
        Me.chlBesucherAuswählen.Size = New System.Drawing.Size(197, 129)
        Me.chlBesucherAuswählen.TabIndex = 14
        '
        'NeueVorstellung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 518)
        Me.Controls.Add(Me.chlBesucherAuswählen)
        Me.Controls.Add(Me.chlFilme)
        Me.Controls.Add(Me.cmdBesucherHinzufügen)
        Me.Controls.Add(Me.lblBesucherAuswähler)
        Me.Controls.Add(Me.cmdFilmHinZuFügen)
        Me.Controls.Add(Me.lblFilmAuswählen)
        Me.Controls.Add(Me.txtenduhrzeit)
        Me.Controls.Add(Me.txtStartuhrzeit)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblEnduhrszeit)
        Me.Controls.Add(Me.lblstartuhrzeit)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.cmdfertig)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "NeueVorstellung"
        Me.Text = "Veranstaltung ändern"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdfertig As Button
    Friend WithEvents lblname As Label
    Friend WithEvents lblstartuhrzeit As Label
    Friend WithEvents lblEnduhrszeit As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtStartuhrzeit As TextBox
    Friend WithEvents txtenduhrzeit As TextBox
    Friend WithEvents lblFilmAuswählen As Label
    Friend WithEvents cmdFilmHinZuFügen As Button
    Friend WithEvents cmdBesucherHinzufügen As Button
    Friend WithEvents lblBesucherAuswähler As Label
    Friend WithEvents chlFilme As CheckedListBox
    Friend WithEvents chlBesucherAuswählen As CheckedListBox
End Class
