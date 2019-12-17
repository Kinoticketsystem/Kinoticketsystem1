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
        Me.lblstartuhrzeit = New System.Windows.Forms.Label()
        Me.lblEnduhrszeit = New System.Windows.Forms.Label()
        Me.lblFilmAuswählen = New System.Windows.Forms.Label()
        Me.cmdFilmHinZuFügen = New System.Windows.Forms.Button()
        Me.chlFilme = New System.Windows.Forms.CheckedListBox()
        Me.StartuhrzeitWert = New System.Windows.Forms.NumericUpDown()
        Me.EnduhrzeitWert = New System.Windows.Forms.NumericUpDown()
        Me.lblKinosaal = New System.Windows.Forms.Label()
        Me.NUDKinosaal = New System.Windows.Forms.NumericUpDown()
        Me.lblFilmlänge = New System.Windows.Forms.Label()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.NUDTag = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstBesucher = New System.Windows.Forms.ListBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.chlBesucherAuswählen = New System.Windows.Forms.CheckedListBox()
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
        Me.cmdfertig.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdfertig.Location = New System.Drawing.Point(43, 422)
        Me.cmdfertig.Name = "cmdfertig"
        Me.cmdfertig.Size = New System.Drawing.Size(598, 52)
        Me.cmdfertig.TabIndex = 0
        Me.cmdfertig.Text = "Vorstellung erstellen"
        Me.cmdfertig.UseVisualStyleBackColor = False
        '
        'lblstartuhrzeit
        '
        Me.lblstartuhrzeit.AutoSize = True
        Me.lblstartuhrzeit.BackColor = System.Drawing.Color.Transparent
        Me.lblstartuhrzeit.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstartuhrzeit.ForeColor = System.Drawing.Color.White
        Me.lblstartuhrzeit.Location = New System.Drawing.Point(39, 233)
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
        Me.lblEnduhrszeit.Location = New System.Drawing.Point(361, 239)
        Me.lblEnduhrszeit.Name = "lblEnduhrszeit"
        Me.lblEnduhrszeit.Size = New System.Drawing.Size(166, 23)
        Me.lblEnduhrszeit.TabIndex = 3
        Me.lblEnduhrszeit.Text = "Enduhrzeit (h, min):"
        '
        'lblFilmAuswählen
        '
        Me.lblFilmAuswählen.AutoSize = True
        Me.lblFilmAuswählen.BackColor = System.Drawing.Color.Transparent
        Me.lblFilmAuswählen.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilmAuswählen.ForeColor = System.Drawing.Color.White
        Me.lblFilmAuswählen.Location = New System.Drawing.Point(39, 63)
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
        Me.cmdFilmHinZuFügen.Location = New System.Drawing.Point(43, 284)
        Me.cmdFilmHinZuFügen.Name = "cmdFilmHinZuFügen"
        Me.cmdFilmHinZuFügen.Size = New System.Drawing.Size(598, 46)
        Me.cmdFilmHinZuFügen.TabIndex = 9
        Me.cmdFilmHinZuFügen.Text = "Film hinzufügen"
        Me.cmdFilmHinZuFügen.UseVisualStyleBackColor = False
        '
        'chlFilme
        '
        Me.chlFilme.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlFilme.FormattingEnabled = True
        Me.chlFilme.Location = New System.Drawing.Point(363, 63)
        Me.chlFilme.Name = "chlFilme"
        Me.chlFilme.Size = New System.Drawing.Size(278, 114)
        Me.chlFilme.TabIndex = 13
        '
        'StartuhrzeitWert
        '
        Me.StartuhrzeitWert.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartuhrzeitWert.Location = New System.Drawing.Point(244, 231)
        Me.StartuhrzeitWert.Name = "StartuhrzeitWert"
        Me.StartuhrzeitWert.Size = New System.Drawing.Size(76, 31)
        Me.StartuhrzeitWert.TabIndex = 17
        '
        'EnduhrzeitWert
        '
        Me.EnduhrzeitWert.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnduhrzeitWert.Location = New System.Drawing.Point(565, 233)
        Me.EnduhrzeitWert.Name = "EnduhrzeitWert"
        Me.EnduhrzeitWert.Size = New System.Drawing.Size(76, 31)
        Me.EnduhrzeitWert.TabIndex = 18
        '
        'lblKinosaal
        '
        Me.lblKinosaal.AutoSize = True
        Me.lblKinosaal.BackColor = System.Drawing.Color.Transparent
        Me.lblKinosaal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKinosaal.ForeColor = System.Drawing.Color.White
        Me.lblKinosaal.Location = New System.Drawing.Point(39, 364)
        Me.lblKinosaal.Name = "lblKinosaal"
        Me.lblKinosaal.Size = New System.Drawing.Size(170, 23)
        Me.lblKinosaal.TabIndex = 20
        Me.lblKinosaal.Text = "Kinosaal auswählen:"
        '
        'NUDKinosaal
        '
        Me.NUDKinosaal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUDKinosaal.Location = New System.Drawing.Point(244, 356)
        Me.NUDKinosaal.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NUDKinosaal.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDKinosaal.Name = "NUDKinosaal"
        Me.NUDKinosaal.Size = New System.Drawing.Size(76, 31)
        Me.NUDKinosaal.TabIndex = 21
        Me.NUDKinosaal.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblFilmlänge
        '
        Me.lblFilmlänge.AutoSize = True
        Me.lblFilmlänge.BackColor = System.Drawing.Color.Transparent
        Me.lblFilmlänge.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilmlänge.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFilmlänge.Location = New System.Drawing.Point(240, 154)
        Me.lblFilmlänge.Name = "lblFilmlänge"
        Me.lblFilmlänge.Size = New System.Drawing.Size(87, 23)
        Me.lblFilmlänge.TabIndex = 23
        Me.lblFilmlänge.Text = "Filmlänge"
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.BackColor = System.Drawing.Color.Transparent
        Me.lblTag.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTag.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTag.Location = New System.Drawing.Point(397, 364)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(130, 23)
        Me.lblTag.TabIndex = 24
        Me.lblTag.Text = "Tag auswählen:"
        '
        'NUDTag
        '
        Me.NUDTag.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NUDTag.Location = New System.Drawing.Point(565, 356)
        Me.NUDTag.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.NUDTag.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDTag.Name = "NUDTag"
        Me.NUDTag.Size = New System.Drawing.Size(76, 31)
        Me.NUDTag.TabIndex = 25
        Me.NUDTag.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(39, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Laufzeit des Filmes: "
        '
        'lstBesucher
        '
        Me.lstBesucher.FormattingEnabled = True
        Me.lstBesucher.ItemHeight = 19
        Me.lstBesucher.Location = New System.Drawing.Point(208, 559)
        Me.lstBesucher.Name = "lstBesucher"
        Me.lstBesucher.Size = New System.Drawing.Size(119, 118)
        Me.lstBesucher.TabIndex = 27
        Me.lstBesucher.Visible = False
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(507, 651)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(134, 26)
        Me.txtname.TabIndex = 29
        Me.txtname.Visible = False
        '
        'chlBesucherAuswählen
        '
        Me.chlBesucherAuswählen.FormattingEnabled = True
        Me.chlBesucherAuswählen.Location = New System.Drawing.Point(351, 568)
        Me.chlBesucherAuswählen.Name = "chlBesucherAuswählen"
        Me.chlBesucherAuswählen.Size = New System.Drawing.Size(136, 109)
        Me.chlBesucherAuswählen.TabIndex = 30
        Me.chlBesucherAuswählen.Visible = False
        '
        'NeueVorstellung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(793, 711)
        Me.Controls.Add(Me.chlBesucherAuswählen)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lstBesucher)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NUDTag)
        Me.Controls.Add(Me.lblTag)
        Me.Controls.Add(Me.lblFilmlänge)
        Me.Controls.Add(Me.NUDKinosaal)
        Me.Controls.Add(Me.lblKinosaal)
        Me.Controls.Add(Me.EnduhrzeitWert)
        Me.Controls.Add(Me.StartuhrzeitWert)
        Me.Controls.Add(Me.chlFilme)
        Me.Controls.Add(Me.cmdFilmHinZuFügen)
        Me.Controls.Add(Me.lblFilmAuswählen)
        Me.Controls.Add(Me.lblEnduhrszeit)
        Me.Controls.Add(Me.lblstartuhrzeit)
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
    Friend WithEvents lblstartuhrzeit As Label
    Friend WithEvents lblEnduhrszeit As Label
    Friend WithEvents lblFilmAuswählen As Label
    Friend WithEvents cmdFilmHinZuFügen As Button
    Friend WithEvents chlFilme As CheckedListBox
    Friend WithEvents StartuhrzeitWert As NumericUpDown
    Friend WithEvents EnduhrzeitWert As NumericUpDown
    Friend WithEvents lblKinosaal As Label
    Friend WithEvents NUDKinosaal As NumericUpDown
    Friend WithEvents lblFilmlänge As Label
    Friend WithEvents lblTag As Label
    Friend WithEvents NUDTag As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents lstBesucher As ListBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents chlBesucherAuswählen As CheckedListBox
End Class
