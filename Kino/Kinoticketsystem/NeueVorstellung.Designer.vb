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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NeueVorstellung))
        Me.cmdfertig = New System.Windows.Forms.Button()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblstartuhrzeit = New System.Windows.Forms.Label()
        Me.lblEnduhrszeit = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblFilmAuswählen = New System.Windows.Forms.Label()
        Me.cmdFilmHinZuFügen = New System.Windows.Forms.Button()
        Me.cmdBesucherHinzufügen = New System.Windows.Forms.Button()
        Me.lblBesucherAuswähler = New System.Windows.Forms.Label()
        Me.chlFilme = New System.Windows.Forms.CheckedListBox()
        Me.chlBesucherAuswählen = New System.Windows.Forms.CheckedListBox()
        Me.lstBesucher = New System.Windows.Forms.ListBox()
        Me.StartuhrzeitWert = New System.Windows.Forms.NumericUpDown()
        Me.EnduhrzeitWert = New System.Windows.Forms.NumericUpDown()
        Me.lblFilmInfos = New System.Windows.Forms.Label()
        Me.lblKinosaal = New System.Windows.Forms.Label()
        Me.NUDKinosaal = New System.Windows.Forms.NumericUpDown()
        Me.cmdBesucherNEtfernen = New System.Windows.Forms.Button()
        Me.lblFilmlänge = New System.Windows.Forms.Label()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.NUDTag = New System.Windows.Forms.NumericUpDown()
        CType(Me.StartuhrzeitWert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnduhrzeitWert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDKinosaal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDTag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdfertig
        '
        Me.cmdfertig.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdfertig.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdfertig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdfertig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdfertig.Location = New System.Drawing.Point(565, 537)
        Me.cmdfertig.Name = "cmdfertig"
        Me.cmdfertig.Size = New System.Drawing.Size(75, 32)
        Me.cmdfertig.TabIndex = 0
        Me.cmdfertig.Text = "fertig"
        Me.cmdfertig.UseVisualStyleBackColor = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.White
        Me.lblname.Location = New System.Drawing.Point(43, 35)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(147, 23)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Vorstellungstitel:"
        '
        'lblstartuhrzeit
        '
        Me.lblstartuhrzeit.AutoSize = True
        Me.lblstartuhrzeit.BackColor = System.Drawing.Color.Transparent
        Me.lblstartuhrzeit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstartuhrzeit.ForeColor = System.Drawing.Color.White
        Me.lblstartuhrzeit.Location = New System.Drawing.Point(43, 178)
        Me.lblstartuhrzeit.Name = "lblstartuhrzeit"
        Me.lblstartuhrzeit.Size = New System.Drawing.Size(176, 23)
        Me.lblstartuhrzeit.TabIndex = 2
        Me.lblstartuhrzeit.Text = "Startuhrzeit (h, min):"
        '
        'lblEnduhrszeit
        '
        Me.lblEnduhrszeit.AutoSize = True
        Me.lblEnduhrszeit.BackColor = System.Drawing.Color.Transparent
        Me.lblEnduhrszeit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnduhrszeit.ForeColor = System.Drawing.Color.White
        Me.lblEnduhrszeit.Location = New System.Drawing.Point(43, 236)
        Me.lblEnduhrszeit.Name = "lblEnduhrszeit"
        Me.lblEnduhrszeit.Size = New System.Drawing.Size(166, 23)
        Me.lblEnduhrszeit.TabIndex = 3
        Me.lblEnduhrszeit.Text = "Enduhrzeit (h, min):"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(251, 32)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(197, 31)
        Me.txtname.TabIndex = 4
        '
        'lblFilmAuswählen
        '
        Me.lblFilmAuswählen.AutoSize = True
        Me.lblFilmAuswählen.BackColor = System.Drawing.Color.Transparent
        Me.lblFilmAuswählen.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilmAuswählen.ForeColor = System.Drawing.Color.White
        Me.lblFilmAuswählen.Location = New System.Drawing.Point(43, 80)
        Me.lblFilmAuswählen.Name = "lblFilmAuswählen"
        Me.lblFilmAuswählen.Size = New System.Drawing.Size(138, 23)
        Me.lblFilmAuswählen.TabIndex = 8
        Me.lblFilmAuswählen.Text = "Film auswählen:"
        '
        'cmdFilmHinZuFügen
        '
        Me.cmdFilmHinZuFügen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdFilmHinZuFügen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdFilmHinZuFügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFilmHinZuFügen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFilmHinZuFügen.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilmHinZuFügen.Location = New System.Drawing.Point(589, 107)
        Me.cmdFilmHinZuFügen.Name = "cmdFilmHinZuFügen"
        Me.cmdFilmHinZuFügen.Size = New System.Drawing.Size(155, 32)
        Me.cmdFilmHinZuFügen.TabIndex = 9
        Me.cmdFilmHinZuFügen.Text = "Film hinzufügen"
        Me.cmdFilmHinZuFügen.UseVisualStyleBackColor = False
        '
        'cmdBesucherHinzufügen
        '
        Me.cmdBesucherHinzufügen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdBesucherHinzufügen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdBesucherHinzufügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBesucherHinzufügen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBesucherHinzufügen.Location = New System.Drawing.Point(251, 537)
        Me.cmdBesucherHinzufügen.Name = "cmdBesucherHinzufügen"
        Me.cmdBesucherHinzufügen.Size = New System.Drawing.Size(182, 32)
        Me.cmdBesucherHinzufügen.TabIndex = 12
        Me.cmdBesucherHinzufügen.Text = "Besucher hinzufügen"
        Me.cmdBesucherHinzufügen.UseVisualStyleBackColor = False
        '
        'lblBesucherAuswähler
        '
        Me.lblBesucherAuswähler.AutoSize = True
        Me.lblBesucherAuswähler.BackColor = System.Drawing.Color.Transparent
        Me.lblBesucherAuswähler.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBesucherAuswähler.ForeColor = System.Drawing.Color.White
        Me.lblBesucherAuswähler.Location = New System.Drawing.Point(43, 417)
        Me.lblBesucherAuswähler.Name = "lblBesucherAuswähler"
        Me.lblBesucherAuswähler.Size = New System.Drawing.Size(178, 23)
        Me.lblBesucherAuswähler.TabIndex = 11
        Me.lblBesucherAuswähler.Text = "Besucher auswählen:"
        '
        'chlFilme
        '
        Me.chlFilme.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlFilme.FormattingEnabled = True
        Me.chlFilme.Location = New System.Drawing.Point(251, 80)
        Me.chlFilme.Name = "chlFilme"
        Me.chlFilme.Size = New System.Drawing.Size(197, 70)
        Me.chlFilme.TabIndex = 13
        '
        'chlBesucherAuswählen
        '
        Me.chlBesucherAuswählen.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlBesucherAuswählen.FormattingEnabled = True
        Me.chlBesucherAuswählen.Location = New System.Drawing.Point(251, 417)
        Me.chlBesucherAuswählen.Name = "chlBesucherAuswählen"
        Me.chlBesucherAuswählen.Size = New System.Drawing.Size(197, 70)
        Me.chlBesucherAuswählen.TabIndex = 14
        '
        'lstBesucher
        '
        Me.lstBesucher.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBesucher.FormattingEnabled = True
        Me.lstBesucher.ItemHeight = 19
        Me.lstBesucher.Location = New System.Drawing.Point(454, 417)
        Me.lstBesucher.Name = "lstBesucher"
        Me.lstBesucher.Size = New System.Drawing.Size(145, 80)
        Me.lstBesucher.TabIndex = 16
        '
        'StartuhrzeitWert
        '
        Me.StartuhrzeitWert.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartuhrzeitWert.Location = New System.Drawing.Point(251, 178)
        Me.StartuhrzeitWert.Name = "StartuhrzeitWert"
        Me.StartuhrzeitWert.Size = New System.Drawing.Size(76, 31)
        Me.StartuhrzeitWert.TabIndex = 17
        '
        'EnduhrzeitWert
        '
        Me.EnduhrzeitWert.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnduhrzeitWert.Location = New System.Drawing.Point(251, 234)
        Me.EnduhrzeitWert.Name = "EnduhrzeitWert"
        Me.EnduhrzeitWert.Size = New System.Drawing.Size(76, 31)
        Me.EnduhrzeitWert.TabIndex = 18
        '
        'lblFilmInfos
        '
        Me.lblFilmInfos.AutoSize = True
        Me.lblFilmInfos.BackColor = System.Drawing.Color.Transparent
        Me.lblFilmInfos.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilmInfos.ForeColor = System.Drawing.Color.White
        Me.lblFilmInfos.Location = New System.Drawing.Point(653, 22)
        Me.lblFilmInfos.Name = "lblFilmInfos"
        Me.lblFilmInfos.Size = New System.Drawing.Size(105, 23)
        Me.lblFilmInfos.TabIndex = 19
        Me.lblFilmInfos.Text = "Beispielfilm"
        '
        'lblKinosaal
        '
        Me.lblKinosaal.AutoSize = True
        Me.lblKinosaal.BackColor = System.Drawing.Color.Transparent
        Me.lblKinosaal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKinosaal.ForeColor = System.Drawing.Color.White
        Me.lblKinosaal.Location = New System.Drawing.Point(43, 360)
        Me.lblKinosaal.Name = "lblKinosaal"
        Me.lblKinosaal.Size = New System.Drawing.Size(170, 23)
        Me.lblKinosaal.TabIndex = 20
        Me.lblKinosaal.Text = "Kinosaal auswählen:"
        '
        'NUDKinosaal
        '
        Me.NUDKinosaal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUDKinosaal.Location = New System.Drawing.Point(251, 358)
        Me.NUDKinosaal.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NUDKinosaal.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDKinosaal.Name = "NUDKinosaal"
        Me.NUDKinosaal.Size = New System.Drawing.Size(76, 31)
        Me.NUDKinosaal.TabIndex = 21
        Me.NUDKinosaal.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmdBesucherNEtfernen
        '
        Me.cmdBesucherNEtfernen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdBesucherNEtfernen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdBesucherNEtfernen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBesucherNEtfernen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBesucherNEtfernen.Location = New System.Drawing.Point(454, 537)
        Me.cmdBesucherNEtfernen.Name = "cmdBesucherNEtfernen"
        Me.cmdBesucherNEtfernen.Size = New System.Drawing.Size(92, 32)
        Me.cmdBesucherNEtfernen.TabIndex = 22
        Me.cmdBesucherNEtfernen.Text = "entfernen"
        Me.cmdBesucherNEtfernen.UseVisualStyleBackColor = False
        '
        'lblFilmlänge
        '
        Me.lblFilmlänge.AutoSize = True
        Me.lblFilmlänge.Location = New System.Drawing.Point(480, 107)
        Me.lblFilmlänge.Name = "lblFilmlänge"
        Me.lblFilmlänge.Size = New System.Drawing.Size(66, 19)
        Me.lblFilmlänge.TabIndex = 23
        Me.lblFilmlänge.Text = "Filmlänge"
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.Location = New System.Drawing.Point(383, 364)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(101, 19)
        Me.lblTag.TabIndex = 24
        Me.lblTag.Text = "Tag auswählen "
        '
        'NUDTag
        '
        Me.NUDTag.Location = New System.Drawing.Point(504, 360)
        Me.NUDTag.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.NUDTag.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDTag.Name = "NUDTag"
        Me.NUDTag.Size = New System.Drawing.Size(95, 26)
        Me.NUDTag.TabIndex = 25
        Me.NUDTag.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NeueVorstellung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(793, 711)
        Me.Controls.Add(Me.NUDTag)
        Me.Controls.Add(Me.lblTag)
        Me.Controls.Add(Me.lblFilmlänge)
        Me.Controls.Add(Me.cmdBesucherNEtfernen)
        Me.Controls.Add(Me.NUDKinosaal)
        Me.Controls.Add(Me.lblKinosaal)
        Me.Controls.Add(Me.lblFilmInfos)
        Me.Controls.Add(Me.EnduhrzeitWert)
        Me.Controls.Add(Me.StartuhrzeitWert)
        Me.Controls.Add(Me.lstBesucher)
        Me.Controls.Add(Me.chlBesucherAuswählen)
        Me.Controls.Add(Me.chlFilme)
        Me.Controls.Add(Me.cmdBesucherHinzufügen)
        Me.Controls.Add(Me.lblBesucherAuswähler)
        Me.Controls.Add(Me.cmdFilmHinZuFügen)
        Me.Controls.Add(Me.lblFilmAuswählen)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblEnduhrszeit)
        Me.Controls.Add(Me.lblstartuhrzeit)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.cmdfertig)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NeueVorstellung"
        Me.Text = "Veranstaltung ändern"
        CType(Me.StartuhrzeitWert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnduhrzeitWert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDKinosaal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDTag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdfertig As Button
    Friend WithEvents lblname As Label
    Friend WithEvents lblstartuhrzeit As Label
    Friend WithEvents lblEnduhrszeit As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblFilmAuswählen As Label
    Friend WithEvents cmdFilmHinZuFügen As Button
    Friend WithEvents cmdBesucherHinzufügen As Button
    Friend WithEvents lblBesucherAuswähler As Label
    Friend WithEvents chlFilme As CheckedListBox
    Friend WithEvents chlBesucherAuswählen As CheckedListBox
    Friend WithEvents lstBesucher As ListBox
    Friend WithEvents StartuhrzeitWert As NumericUpDown
    Friend WithEvents EnduhrzeitWert As NumericUpDown
    Friend WithEvents lblFilmInfos As Label
    Friend WithEvents lblKinosaal As Label
    Friend WithEvents NUDKinosaal As NumericUpDown
    Friend WithEvents cmdBesucherNEtfernen As Button
    Friend WithEvents lblFilmlänge As Label
    Friend WithEvents lblTag As Label
    Friend WithEvents NUDTag As NumericUpDown
End Class
