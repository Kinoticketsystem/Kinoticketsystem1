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
        CType(Me.StartuhrzeitWert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnduhrzeitWert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdfertig
        '
        Me.cmdfertig.Location = New System.Drawing.Point(524, 509)
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
        Me.lblstartuhrzeit.Size = New System.Drawing.Size(173, 22)
        Me.lblstartuhrzeit.TabIndex = 2
        Me.lblstartuhrzeit.Text = "Startuhrzeit (h, min):"
        '
        'lblEnduhrszeit
        '
        Me.lblEnduhrszeit.AutoSize = True
        Me.lblEnduhrszeit.Location = New System.Drawing.Point(43, 107)
        Me.lblEnduhrszeit.Name = "lblEnduhrszeit"
        Me.lblEnduhrszeit.Size = New System.Drawing.Size(167, 22)
        Me.lblEnduhrszeit.TabIndex = 3
        Me.lblEnduhrszeit.Text = "Enduhrzeit (h, min):"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(251, 35)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(197, 30)
        Me.txtname.TabIndex = 4
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
        Me.cmdFilmHinZuFügen.Location = New System.Drawing.Point(293, 336)
        Me.cmdFilmHinZuFügen.Name = "cmdFilmHinZuFügen"
        Me.cmdFilmHinZuFügen.Size = New System.Drawing.Size(155, 32)
        Me.cmdFilmHinZuFügen.TabIndex = 9
        Me.cmdFilmHinZuFügen.Text = "Film hinzufügen"
        Me.cmdFilmHinZuFügen.UseVisualStyleBackColor = True
        '
        'cmdBesucherHinzufügen
        '
        Me.cmdBesucherHinzufügen.Location = New System.Drawing.Point(251, 509)
        Me.cmdBesucherHinzufügen.Name = "cmdBesucherHinzufügen"
        Me.cmdBesucherHinzufügen.Size = New System.Drawing.Size(182, 32)
        Me.cmdBesucherHinzufügen.TabIndex = 12
        Me.cmdBesucherHinzufügen.Text = "Besucher hinzufügen"
        Me.cmdBesucherHinzufügen.UseVisualStyleBackColor = True
        '
        'lblBesucherAuswähler
        '
        Me.lblBesucherAuswähler.AutoSize = True
        Me.lblBesucherAuswähler.Location = New System.Drawing.Point(43, 374)
        Me.lblBesucherAuswähler.Name = "lblBesucherAuswähler"
        Me.lblBesucherAuswähler.Size = New System.Drawing.Size(177, 22)
        Me.lblBesucherAuswähler.TabIndex = 11
        Me.lblBesucherAuswähler.Text = "Besucher auswählen:"
        '
        'chlFilme
        '
        Me.chlFilme.FormattingEnabled = True
        Me.chlFilme.Location = New System.Drawing.Point(251, 172)
        Me.chlFilme.Name = "chlFilme"
        Me.chlFilme.Size = New System.Drawing.Size(197, 154)
        Me.chlFilme.TabIndex = 13
        '
        'chlBesucherAuswählen
        '
        Me.chlBesucherAuswählen.FormattingEnabled = True
        Me.chlBesucherAuswählen.Location = New System.Drawing.Point(251, 374)
        Me.chlBesucherAuswählen.Name = "chlBesucherAuswählen"
        Me.chlBesucherAuswählen.Size = New System.Drawing.Size(197, 129)
        Me.chlBesucherAuswählen.TabIndex = 14
        '
        'lstBesucher
        '
        Me.lstBesucher.FormattingEnabled = True
        Me.lstBesucher.ItemHeight = 22
        Me.lstBesucher.Location = New System.Drawing.Point(454, 374)
        Me.lstBesucher.Name = "lstBesucher"
        Me.lstBesucher.Size = New System.Drawing.Size(145, 114)
        Me.lstBesucher.TabIndex = 16
        '
        'StartuhrzeitWert
        '
        Me.StartuhrzeitWert.Location = New System.Drawing.Point(251, 69)
        Me.StartuhrzeitWert.Name = "StartuhrzeitWert"
        Me.StartuhrzeitWert.Size = New System.Drawing.Size(76, 30)
        Me.StartuhrzeitWert.TabIndex = 17
        '
        'EnduhrzeitWert
        '
        Me.EnduhrzeitWert.Location = New System.Drawing.Point(251, 107)
        Me.EnduhrzeitWert.Name = "EnduhrzeitWert"
        Me.EnduhrzeitWert.Size = New System.Drawing.Size(76, 30)
        Me.EnduhrzeitWert.TabIndex = 18
        '
        'lblFilmInfos
        '
        Me.lblFilmInfos.AutoSize = True
        Me.lblFilmInfos.Location = New System.Drawing.Point(251, 147)
        Me.lblFilmInfos.Name = "lblFilmInfos"
        Me.lblFilmInfos.Size = New System.Drawing.Size(109, 22)
        Me.lblFilmInfos.TabIndex = 19
        Me.lblFilmInfos.Text = "Beispielfilm"
        '
        'NeueVorstellung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 565)
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
End Class
