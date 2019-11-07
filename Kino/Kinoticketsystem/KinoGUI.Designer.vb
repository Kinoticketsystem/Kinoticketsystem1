<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KinoGUI
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KinoGUI))
        Me.cmdWochenplan = New System.Windows.Forms.Button()
        Me.cmdTexterfassen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdkinosaalAufrufen = New System.Windows.Forms.Button()
        Me.cmdNeueBuchung = New System.Windows.Forms.Button()
        Me.cmdTestKino = New System.Windows.Forms.Button()
        Me.cmdBuchungStonieren = New System.Windows.Forms.Button()
        Me.txtTageseinnahmen = New System.Windows.Forms.TextBox()
        Me.lblUhrzeit = New System.Windows.Forms.Label()
        Me.lblDatum = New System.Windows.Forms.Label()
        Me.lblTageseinnahmen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdWochenplan
        '
        Me.cmdWochenplan.Location = New System.Drawing.Point(692, 222)
        Me.cmdWochenplan.Name = "cmdWochenplan"
        Me.cmdWochenplan.Size = New System.Drawing.Size(412, 140)
        Me.cmdWochenplan.TabIndex = 0
        Me.cmdWochenplan.Text = "Wochenplan aufrufen"
        Me.cmdWochenplan.UseVisualStyleBackColor = True
        '
        'cmdTexterfassen
        '
        Me.cmdTexterfassen.Location = New System.Drawing.Point(1536, 853)
        Me.cmdTexterfassen.Name = "cmdTexterfassen"
        Me.cmdTexterfassen.Size = New System.Drawing.Size(183, 140)
        Me.cmdTexterfassen.TabIndex = 1
        Me.cmdTexterfassen.Text = "Texterfassen Erik"
        Me.cmdTexterfassen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 2
        '
        'cmdkinosaalAufrufen
        '
        Me.cmdkinosaalAufrufen.Location = New System.Drawing.Point(647, 110)
        Me.cmdkinosaalAufrufen.Name = "cmdkinosaalAufrufen"
        Me.cmdkinosaalAufrufen.Size = New System.Drawing.Size(412, 140)
        Me.cmdkinosaalAufrufen.TabIndex = 3
        Me.cmdkinosaalAufrufen.Text = "Kinosaal aufrufen"
        Me.cmdkinosaalAufrufen.UseVisualStyleBackColor = True
        '
        'cmdNeueBuchung
        '
        Me.cmdNeueBuchung.Location = New System.Drawing.Point(160, 9)
        Me.cmdNeueBuchung.Name = "cmdNeueBuchung"
        Me.cmdNeueBuchung.Size = New System.Drawing.Size(375, 66)
        Me.cmdNeueBuchung.TabIndex = 5
        Me.cmdNeueBuchung.Text = "NeueBuchung"
        Me.cmdNeueBuchung.UseVisualStyleBackColor = True
        '
        'cmdTestKino
        '
        Me.cmdTestKino.Location = New System.Drawing.Point(1725, 853)
        Me.cmdTestKino.Name = "cmdTestKino"
        Me.cmdTestKino.Size = New System.Drawing.Size(183, 140)
        Me.cmdTestKino.TabIndex = 7
        Me.cmdTestKino.Text = "testkino"
        Me.cmdTestKino.UseVisualStyleBackColor = True
        '
        'cmdBuchungStonieren
        '
        Me.cmdBuchungStonieren.Location = New System.Drawing.Point(541, 9)
        Me.cmdBuchungStonieren.Name = "cmdBuchungStonieren"
        Me.cmdBuchungStonieren.Size = New System.Drawing.Size(183, 77)
        Me.cmdBuchungStonieren.TabIndex = 8
        Me.cmdBuchungStonieren.Text = "BuchungStonieren"
        Me.cmdBuchungStonieren.UseVisualStyleBackColor = True
        '
        'txtTageseinnahmen
        '
        Me.txtTageseinnahmen.Location = New System.Drawing.Point(1766, 12)
        Me.txtTageseinnahmen.Name = "txtTageseinnahmen"
        Me.txtTageseinnahmen.Size = New System.Drawing.Size(142, 26)
        Me.txtTageseinnahmen.TabIndex = 9
        Me.txtTageseinnahmen.Text = "Tageseinnahmen"
        '
        'lblUhrzeit
        '
        Me.lblUhrzeit.AutoSize = True
        Me.lblUhrzeit.Location = New System.Drawing.Point(12, 9)
        Me.lblUhrzeit.Name = "lblUhrzeit"
        Me.lblUhrzeit.Size = New System.Drawing.Size(52, 19)
        Me.lblUhrzeit.TabIndex = 10
        Me.lblUhrzeit.Text = "Uhrzeit"
        '
        'lblDatum
        '
        Me.lblDatum.AutoSize = True
        Me.lblDatum.Location = New System.Drawing.Point(69, 9)
        Me.lblDatum.Name = "lblDatum"
        Me.lblDatum.Size = New System.Drawing.Size(49, 19)
        Me.lblDatum.TabIndex = 11
        Me.lblDatum.Text = "Datum"
        '
        'lblTageseinnahmen
        '
        Me.lblTageseinnahmen.AutoSize = True
        Me.lblTageseinnahmen.Location = New System.Drawing.Point(12, 56)
        Me.lblTageseinnahmen.Name = "lblTageseinnahmen"
        Me.lblTageseinnahmen.Size = New System.Drawing.Size(107, 19)
        Me.lblTageseinnahmen.TabIndex = 12
        Me.lblTageseinnahmen.Text = "Tageseinnahmen"
        '
        'KinoGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1280, 1024)
        Me.Controls.Add(Me.lblTageseinnahmen)
        Me.Controls.Add(Me.lblDatum)
        Me.Controls.Add(Me.lblUhrzeit)
        Me.Controls.Add(Me.txtTageseinnahmen)
        Me.Controls.Add(Me.cmdBuchungStonieren)
        Me.Controls.Add(Me.cmdTestKino)
        Me.Controls.Add(Me.cmdNeueBuchung)
        Me.Controls.Add(Me.cmdkinosaalAufrufen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdTexterfassen)
        Me.Controls.Add(Me.cmdWochenplan)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "KinoGUI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdWochenplan As Button
    Friend WithEvents cmdTexterfassen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdkinosaalAufrufen As Button
    Friend WithEvents cmdNeueBuchung As Button
    Friend WithEvents cmdTestKino As Button
    Friend WithEvents cmdBuchungStonieren As Button
    Friend WithEvents txtTageseinnahmen As TextBox
    Friend WithEvents lblUhrzeit As Label
    Friend WithEvents lblDatum As Label
    Friend WithEvents lblTageseinnahmen As Label
End Class
