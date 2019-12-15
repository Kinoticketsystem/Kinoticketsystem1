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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KinoGUI))
        Me.cmdWochenplan1 = New System.Windows.Forms.Button()
        Me.cmdTexterfassen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdkinosaalAufrufen = New System.Windows.Forms.Button()
        Me.cmdNeueBuchung = New System.Windows.Forms.Button()
        Me.cmdBuchungStonieren = New System.Windows.Forms.Button()
        Me.lblUhrzeit = New System.Windows.Forms.Label()
        Me.lblDatum = New System.Windows.Forms.Label()
        Me.lblTageseinnahmen = New System.Windows.Forms.Label()
        Me.lblFilm1 = New System.Windows.Forms.Label()
        Me.lblFilm2 = New System.Windows.Forms.Label()
        Me.lblFilm3 = New System.Windows.Forms.Label()
        Me.lblFilm4 = New System.Windows.Forms.Label()
        Me.lblFilm5 = New System.Windows.Forms.Label()
        Me.lblFilm6 = New System.Windows.Forms.Label()
        Me.lblKinosaal1 = New System.Windows.Forms.Label()
        Me.lblKinosaal2 = New System.Windows.Forms.Label()
        Me.lblKinosaal3 = New System.Windows.Forms.Label()
        Me.lblKinosaal4 = New System.Windows.Forms.Label()
        Me.lblKinosaal5 = New System.Windows.Forms.Label()
        Me.lblKinosaal6 = New System.Windows.Forms.Label()
        Me.lblFreiePlätze1 = New System.Windows.Forms.Label()
        Me.lblFreiePlätze2 = New System.Windows.Forms.Label()
        Me.lblFreiePlätze3 = New System.Windows.Forms.Label()
        Me.lblFreiePlätze4 = New System.Windows.Forms.Label()
        Me.lblFreiePlätze5 = New System.Windows.Forms.Label()
        Me.lblFreiePlätze6 = New System.Windows.Forms.Label()
        Me.lblFreiePlätzeFarbe1 = New System.Windows.Forms.Label()
        Me.cmdWochenplan2 = New System.Windows.Forms.Button()
        Me.cmdWochenplan3 = New System.Windows.Forms.Button()
        Me.cmdWochenplan4 = New System.Windows.Forms.Button()
        Me.cmdWochenplan5 = New System.Windows.Forms.Button()
        Me.cmdWochenplan6 = New System.Windows.Forms.Button()
        Me.cmdFilmHinzufügen = New System.Windows.Forms.Button()
        Me.cmdVorstellungErstellen = New System.Windows.Forms.Button()
        Me.cmdNeuerKinosaal = New System.Windows.Forms.Button()
        Me.cmdWochenpläneBearbeiten = New System.Windows.Forms.Button()
        Me.cmdKundenDatenbankAufrufen = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdTestVorstellung = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdWochenplan1
        '
        Me.cmdWochenplan1.BackgroundImage = CType(resources.GetObject("cmdWochenplan1.BackgroundImage"), System.Drawing.Image)
        Me.cmdWochenplan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdWochenplan1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdWochenplan1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWochenplan1.Location = New System.Drawing.Point(752, 293)
        Me.cmdWochenplan1.Name = "cmdWochenplan1"
        Me.cmdWochenplan1.Size = New System.Drawing.Size(317, 44)
        Me.cmdWochenplan1.TabIndex = 0
        Me.cmdWochenplan1.Text = "Wochenplan aufrufen Saal1"
        Me.cmdWochenplan1.UseVisualStyleBackColor = True
        '
        'cmdTexterfassen
        '
        Me.cmdTexterfassen.BackColor = System.Drawing.Color.Transparent
        Me.cmdTexterfassen.BackgroundImage = CType(resources.GetObject("cmdTexterfassen.BackgroundImage"), System.Drawing.Image)
        Me.cmdTexterfassen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTexterfassen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTexterfassen.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTexterfassen.Location = New System.Drawing.Point(1982, 812)
        Me.cmdTexterfassen.Name = "cmdTexterfassen"
        Me.cmdTexterfassen.Size = New System.Drawing.Size(262, 66)
        Me.cmdTexterfassen.TabIndex = 1
        Me.cmdTexterfassen.Text = "TestTexterfassen "
        Me.cmdTexterfassen.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 61)
        Me.Label1.TabIndex = 2
        '
        'cmdkinosaalAufrufen
        '
        Me.cmdkinosaalAufrufen.BackgroundImage = CType(resources.GetObject("cmdkinosaalAufrufen.BackgroundImage"), System.Drawing.Image)
        Me.cmdkinosaalAufrufen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdkinosaalAufrufen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdkinosaalAufrufen.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdkinosaalAufrufen.Location = New System.Drawing.Point(1133, 207)
        Me.cmdkinosaalAufrufen.Name = "cmdkinosaalAufrufen"
        Me.cmdkinosaalAufrufen.Size = New System.Drawing.Size(144, 66)
        Me.cmdkinosaalAufrufen.TabIndex = 3
        Me.cmdkinosaalAufrufen.Text = "Kinosaal aufrufen"
        Me.cmdkinosaalAufrufen.UseVisualStyleBackColor = True
        '
        'cmdNeueBuchung
        '
        Me.cmdNeueBuchung.BackColor = System.Drawing.Color.White
        Me.cmdNeueBuchung.BackgroundImage = CType(resources.GetObject("cmdNeueBuchung.BackgroundImage"), System.Drawing.Image)
        Me.cmdNeueBuchung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNeueBuchung.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNeueBuchung.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNeueBuchung.ForeColor = System.Drawing.Color.DarkGreen
        Me.cmdNeueBuchung.Location = New System.Drawing.Point(218, 207)
        Me.cmdNeueBuchung.Name = "cmdNeueBuchung"
        Me.cmdNeueBuchung.Size = New System.Drawing.Size(375, 66)
        Me.cmdNeueBuchung.TabIndex = 5
        Me.cmdNeueBuchung.Text = "NeueBuchung"
        Me.cmdNeueBuchung.UseVisualStyleBackColor = False
        '
        'cmdBuchungStonieren
        '
        Me.cmdBuchungStonieren.BackColor = System.Drawing.Color.White
        Me.cmdBuchungStonieren.BackgroundImage = CType(resources.GetObject("cmdBuchungStonieren.BackgroundImage"), System.Drawing.Image)
        Me.cmdBuchungStonieren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBuchungStonieren.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBuchungStonieren.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBuchungStonieren.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuchungStonieren.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdBuchungStonieren.Location = New System.Drawing.Point(694, 207)
        Me.cmdBuchungStonieren.Name = "cmdBuchungStonieren"
        Me.cmdBuchungStonieren.Size = New System.Drawing.Size(375, 66)
        Me.cmdBuchungStonieren.TabIndex = 8
        Me.cmdBuchungStonieren.Text = "BuchungStonieren"
        Me.cmdBuchungStonieren.UseVisualStyleBackColor = False
        '
        'lblUhrzeit
        '
        Me.lblUhrzeit.AutoSize = True
        Me.lblUhrzeit.BackColor = System.Drawing.Color.Transparent
        Me.lblUhrzeit.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUhrzeit.Location = New System.Drawing.Point(37, 30)
        Me.lblUhrzeit.Name = "lblUhrzeit"
        Me.lblUhrzeit.Size = New System.Drawing.Size(195, 59)
        Me.lblUhrzeit.TabIndex = 10
        Me.lblUhrzeit.Text = "11:11:11"
        '
        'lblDatum
        '
        Me.lblDatum.AutoSize = True
        Me.lblDatum.BackColor = System.Drawing.Color.Transparent
        Me.lblDatum.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatum.Location = New System.Drawing.Point(37, 67)
        Me.lblDatum.Name = "lblDatum"
        Me.lblDatum.Size = New System.Drawing.Size(195, 59)
        Me.lblDatum.TabIndex = 11
        Me.lblDatum.Text = "11.11.19"
        '
        'lblTageseinnahmen
        '
        Me.lblTageseinnahmen.AutoSize = True
        Me.lblTageseinnahmen.BackColor = System.Drawing.Color.Transparent
        Me.lblTageseinnahmen.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTageseinnahmen.Location = New System.Drawing.Point(188, 30)
        Me.lblTageseinnahmen.Name = "lblTageseinnahmen"
        Me.lblTageseinnahmen.Size = New System.Drawing.Size(523, 59)
        Me.lblTageseinnahmen.TabIndex = 12
        Me.lblTageseinnahmen.Text = "Geld in der Kasse: 12,55€"
        '
        'lblFilm1
        '
        Me.lblFilm1.AutoSize = True
        Me.lblFilm1.BackColor = System.Drawing.Color.Transparent
        Me.lblFilm1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFilm1.Location = New System.Drawing.Point(224, 306)
        Me.lblFilm1.Name = "lblFilm1"
        Me.lblFilm1.Size = New System.Drawing.Size(104, 46)
        Me.lblFilm1.TabIndex = 13
        Me.lblFilm1.Text = "Film1"
        '
        'lblFilm2
        '
        Me.lblFilm2.AutoSize = True
        Me.lblFilm2.BackColor = System.Drawing.Color.Transparent
        Me.lblFilm2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFilm2.Location = New System.Drawing.Point(224, 371)
        Me.lblFilm2.Name = "lblFilm2"
        Me.lblFilm2.Size = New System.Drawing.Size(104, 46)
        Me.lblFilm2.TabIndex = 14
        Me.lblFilm2.Text = "Film2"
        '
        'lblFilm3
        '
        Me.lblFilm3.AutoSize = True
        Me.lblFilm3.BackColor = System.Drawing.Color.Transparent
        Me.lblFilm3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFilm3.Location = New System.Drawing.Point(224, 440)
        Me.lblFilm3.Name = "lblFilm3"
        Me.lblFilm3.Size = New System.Drawing.Size(104, 46)
        Me.lblFilm3.TabIndex = 15
        Me.lblFilm3.Text = "Film3"
        '
        'lblFilm4
        '
        Me.lblFilm4.AutoSize = True
        Me.lblFilm4.BackColor = System.Drawing.Color.Transparent
        Me.lblFilm4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFilm4.Location = New System.Drawing.Point(224, 508)
        Me.lblFilm4.Name = "lblFilm4"
        Me.lblFilm4.Size = New System.Drawing.Size(104, 46)
        Me.lblFilm4.TabIndex = 16
        Me.lblFilm4.Text = "Film4"
        '
        'lblFilm5
        '
        Me.lblFilm5.AutoSize = True
        Me.lblFilm5.BackColor = System.Drawing.Color.Transparent
        Me.lblFilm5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFilm5.Location = New System.Drawing.Point(224, 577)
        Me.lblFilm5.Name = "lblFilm5"
        Me.lblFilm5.Size = New System.Drawing.Size(104, 46)
        Me.lblFilm5.TabIndex = 17
        Me.lblFilm5.Text = "Film5"
        '
        'lblFilm6
        '
        Me.lblFilm6.AutoSize = True
        Me.lblFilm6.BackColor = System.Drawing.Color.Transparent
        Me.lblFilm6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFilm6.Location = New System.Drawing.Point(224, 642)
        Me.lblFilm6.Name = "lblFilm6"
        Me.lblFilm6.Size = New System.Drawing.Size(104, 46)
        Me.lblFilm6.TabIndex = 18
        Me.lblFilm6.Text = "Film6"
        '
        'lblKinosaal1
        '
        Me.lblKinosaal1.AutoSize = True
        Me.lblKinosaal1.BackColor = System.Drawing.Color.Transparent
        Me.lblKinosaal1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKinosaal1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKinosaal1.Location = New System.Drawing.Point(408, 306)
        Me.lblKinosaal1.Name = "lblKinosaal1"
        Me.lblKinosaal1.Size = New System.Drawing.Size(168, 46)
        Me.lblKinosaal1.TabIndex = 19
        Me.lblKinosaal1.Text = "Kinosaal1"
        '
        'lblKinosaal2
        '
        Me.lblKinosaal2.AutoSize = True
        Me.lblKinosaal2.BackColor = System.Drawing.Color.Transparent
        Me.lblKinosaal2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKinosaal2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKinosaal2.Location = New System.Drawing.Point(408, 371)
        Me.lblKinosaal2.Name = "lblKinosaal2"
        Me.lblKinosaal2.Size = New System.Drawing.Size(168, 46)
        Me.lblKinosaal2.TabIndex = 20
        Me.lblKinosaal2.Text = "Kinosaal2"
        '
        'lblKinosaal3
        '
        Me.lblKinosaal3.AutoSize = True
        Me.lblKinosaal3.BackColor = System.Drawing.Color.Transparent
        Me.lblKinosaal3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKinosaal3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKinosaal3.Location = New System.Drawing.Point(408, 440)
        Me.lblKinosaal3.Name = "lblKinosaal3"
        Me.lblKinosaal3.Size = New System.Drawing.Size(168, 46)
        Me.lblKinosaal3.TabIndex = 21
        Me.lblKinosaal3.Text = "Kinosaal3"
        '
        'lblKinosaal4
        '
        Me.lblKinosaal4.AutoSize = True
        Me.lblKinosaal4.BackColor = System.Drawing.Color.Transparent
        Me.lblKinosaal4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKinosaal4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKinosaal4.Location = New System.Drawing.Point(408, 508)
        Me.lblKinosaal4.Name = "lblKinosaal4"
        Me.lblKinosaal4.Size = New System.Drawing.Size(168, 46)
        Me.lblKinosaal4.TabIndex = 22
        Me.lblKinosaal4.Text = "Kinosaal4"
        '
        'lblKinosaal5
        '
        Me.lblKinosaal5.AutoSize = True
        Me.lblKinosaal5.BackColor = System.Drawing.Color.Transparent
        Me.lblKinosaal5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKinosaal5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKinosaal5.Location = New System.Drawing.Point(408, 577)
        Me.lblKinosaal5.Name = "lblKinosaal5"
        Me.lblKinosaal5.Size = New System.Drawing.Size(168, 46)
        Me.lblKinosaal5.TabIndex = 23
        Me.lblKinosaal5.Text = "Kinosaal5"
        '
        'lblKinosaal6
        '
        Me.lblKinosaal6.AutoSize = True
        Me.lblKinosaal6.BackColor = System.Drawing.Color.Transparent
        Me.lblKinosaal6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKinosaal6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKinosaal6.Location = New System.Drawing.Point(408, 642)
        Me.lblKinosaal6.Name = "lblKinosaal6"
        Me.lblKinosaal6.Size = New System.Drawing.Size(168, 46)
        Me.lblKinosaal6.TabIndex = 24
        Me.lblKinosaal6.Text = "Kinosaal6"
        '
        'lblFreiePlätze1
        '
        Me.lblFreiePlätze1.AutoSize = True
        Me.lblFreiePlätze1.BackColor = System.Drawing.Color.Green
        Me.lblFreiePlätze1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreiePlätze1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFreiePlätze1.Location = New System.Drawing.Point(559, 308)
        Me.lblFreiePlätze1.Name = "lblFreiePlätze1"
        Me.lblFreiePlätze1.Size = New System.Drawing.Size(208, 46)
        Me.lblFreiePlätze1.TabIndex = 25
        Me.lblFreiePlätze1.Text = "FreiePlätze1"
        '
        'lblFreiePlätze2
        '
        Me.lblFreiePlätze2.AutoSize = True
        Me.lblFreiePlätze2.BackColor = System.Drawing.Color.Green
        Me.lblFreiePlätze2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreiePlätze2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFreiePlätze2.Location = New System.Drawing.Point(559, 373)
        Me.lblFreiePlätze2.Name = "lblFreiePlätze2"
        Me.lblFreiePlätze2.Size = New System.Drawing.Size(208, 46)
        Me.lblFreiePlätze2.TabIndex = 26
        Me.lblFreiePlätze2.Text = "FreiePlätze2"
        '
        'lblFreiePlätze3
        '
        Me.lblFreiePlätze3.AutoSize = True
        Me.lblFreiePlätze3.BackColor = System.Drawing.Color.Green
        Me.lblFreiePlätze3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreiePlätze3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFreiePlätze3.Location = New System.Drawing.Point(559, 442)
        Me.lblFreiePlätze3.Name = "lblFreiePlätze3"
        Me.lblFreiePlätze3.Size = New System.Drawing.Size(208, 46)
        Me.lblFreiePlätze3.TabIndex = 27
        Me.lblFreiePlätze3.Text = "FreiePlätze3"
        '
        'lblFreiePlätze4
        '
        Me.lblFreiePlätze4.AutoSize = True
        Me.lblFreiePlätze4.BackColor = System.Drawing.Color.Green
        Me.lblFreiePlätze4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreiePlätze4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFreiePlätze4.Location = New System.Drawing.Point(559, 510)
        Me.lblFreiePlätze4.Name = "lblFreiePlätze4"
        Me.lblFreiePlätze4.Size = New System.Drawing.Size(208, 46)
        Me.lblFreiePlätze4.TabIndex = 28
        Me.lblFreiePlätze4.Text = "FreiePlätze4"
        '
        'lblFreiePlätze5
        '
        Me.lblFreiePlätze5.AutoSize = True
        Me.lblFreiePlätze5.BackColor = System.Drawing.Color.Green
        Me.lblFreiePlätze5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreiePlätze5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFreiePlätze5.Location = New System.Drawing.Point(559, 579)
        Me.lblFreiePlätze5.Name = "lblFreiePlätze5"
        Me.lblFreiePlätze5.Size = New System.Drawing.Size(208, 46)
        Me.lblFreiePlätze5.TabIndex = 29
        Me.lblFreiePlätze5.Text = "FreiePlätze5"
        '
        'lblFreiePlätze6
        '
        Me.lblFreiePlätze6.AutoSize = True
        Me.lblFreiePlätze6.BackColor = System.Drawing.Color.Green
        Me.lblFreiePlätze6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreiePlätze6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFreiePlätze6.Location = New System.Drawing.Point(559, 644)
        Me.lblFreiePlätze6.Name = "lblFreiePlätze6"
        Me.lblFreiePlätze6.Size = New System.Drawing.Size(208, 46)
        Me.lblFreiePlätze6.TabIndex = 30
        Me.lblFreiePlätze6.Text = "FreiePlätze6"
        '
        'lblFreiePlätzeFarbe1
        '
        Me.lblFreiePlätzeFarbe1.AutoSize = True
        Me.lblFreiePlätzeFarbe1.BackColor = System.Drawing.Color.Lime
        Me.lblFreiePlätzeFarbe1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreiePlätzeFarbe1.ForeColor = System.Drawing.Color.Transparent
        Me.lblFreiePlätzeFarbe1.Location = New System.Drawing.Point(632, 308)
        Me.lblFreiePlätzeFarbe1.Name = "lblFreiePlätzeFarbe1"
        Me.lblFreiePlätzeFarbe1.Size = New System.Drawing.Size(0, 46)
        Me.lblFreiePlätzeFarbe1.TabIndex = 31
        '
        'cmdWochenplan2
        '
        Me.cmdWochenplan2.BackgroundImage = CType(resources.GetObject("cmdWochenplan2.BackgroundImage"), System.Drawing.Image)
        Me.cmdWochenplan2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdWochenplan2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdWochenplan2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWochenplan2.Location = New System.Drawing.Point(752, 358)
        Me.cmdWochenplan2.Name = "cmdWochenplan2"
        Me.cmdWochenplan2.Size = New System.Drawing.Size(317, 44)
        Me.cmdWochenplan2.TabIndex = 32
        Me.cmdWochenplan2.Text = "Wochenplan aufrufen Saal 2"
        Me.cmdWochenplan2.UseVisualStyleBackColor = True
        '
        'cmdWochenplan3
        '
        Me.cmdWochenplan3.BackgroundImage = CType(resources.GetObject("cmdWochenplan3.BackgroundImage"), System.Drawing.Image)
        Me.cmdWochenplan3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdWochenplan3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdWochenplan3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWochenplan3.Location = New System.Drawing.Point(752, 427)
        Me.cmdWochenplan3.Name = "cmdWochenplan3"
        Me.cmdWochenplan3.Size = New System.Drawing.Size(317, 44)
        Me.cmdWochenplan3.TabIndex = 33
        Me.cmdWochenplan3.Text = " Wochenplan aufrufen Saal 3"
        Me.cmdWochenplan3.UseVisualStyleBackColor = True
        '
        'cmdWochenplan4
        '
        Me.cmdWochenplan4.BackgroundImage = CType(resources.GetObject("cmdWochenplan4.BackgroundImage"), System.Drawing.Image)
        Me.cmdWochenplan4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdWochenplan4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdWochenplan4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWochenplan4.Location = New System.Drawing.Point(752, 495)
        Me.cmdWochenplan4.Name = "cmdWochenplan4"
        Me.cmdWochenplan4.Size = New System.Drawing.Size(317, 44)
        Me.cmdWochenplan4.TabIndex = 34
        Me.cmdWochenplan4.Text = "Wochenplan aufrufen Saal 4"
        Me.cmdWochenplan4.UseVisualStyleBackColor = True
        '
        'cmdWochenplan5
        '
        Me.cmdWochenplan5.BackgroundImage = CType(resources.GetObject("cmdWochenplan5.BackgroundImage"), System.Drawing.Image)
        Me.cmdWochenplan5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdWochenplan5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdWochenplan5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWochenplan5.Location = New System.Drawing.Point(752, 564)
        Me.cmdWochenplan5.Name = "cmdWochenplan5"
        Me.cmdWochenplan5.Size = New System.Drawing.Size(317, 44)
        Me.cmdWochenplan5.TabIndex = 35
        Me.cmdWochenplan5.Text = "Wochenplan aufrufen Saal 5"
        Me.cmdWochenplan5.UseVisualStyleBackColor = True
        '
        'cmdWochenplan6
        '
        Me.cmdWochenplan6.BackgroundImage = CType(resources.GetObject("cmdWochenplan6.BackgroundImage"), System.Drawing.Image)
        Me.cmdWochenplan6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdWochenplan6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdWochenplan6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWochenplan6.Location = New System.Drawing.Point(752, 629)
        Me.cmdWochenplan6.Name = "cmdWochenplan6"
        Me.cmdWochenplan6.Size = New System.Drawing.Size(317, 44)
        Me.cmdWochenplan6.TabIndex = 36
        Me.cmdWochenplan6.Text = "Wochenplan aufrufen Saal 6"
        Me.cmdWochenplan6.UseVisualStyleBackColor = True
        '
        'cmdFilmHinzufügen
        '
        Me.cmdFilmHinzufügen.BackgroundImage = CType(resources.GetObject("cmdFilmHinzufügen.BackgroundImage"), System.Drawing.Image)
        Me.cmdFilmHinzufügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFilmHinzufügen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFilmHinzufügen.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilmHinzufügen.Location = New System.Drawing.Point(1133, 279)
        Me.cmdFilmHinzufügen.Name = "cmdFilmHinzufügen"
        Me.cmdFilmHinzufügen.Size = New System.Drawing.Size(144, 66)
        Me.cmdFilmHinzufügen.TabIndex = 37
        Me.cmdFilmHinzufügen.Text = "Film Hinzufügen"
        Me.cmdFilmHinzufügen.UseVisualStyleBackColor = True
        '
        'cmdVorstellungErstellen
        '
        Me.cmdVorstellungErstellen.BackgroundImage = CType(resources.GetObject("cmdVorstellungErstellen.BackgroundImage"), System.Drawing.Image)
        Me.cmdVorstellungErstellen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdVorstellungErstellen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdVorstellungErstellen.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVorstellungErstellen.Location = New System.Drawing.Point(1133, 351)
        Me.cmdVorstellungErstellen.Name = "cmdVorstellungErstellen"
        Me.cmdVorstellungErstellen.Size = New System.Drawing.Size(144, 66)
        Me.cmdVorstellungErstellen.TabIndex = 38
        Me.cmdVorstellungErstellen.Text = "Vortstellung Erstellen"
        Me.cmdVorstellungErstellen.UseVisualStyleBackColor = True
        '
        'cmdNeuerKinosaal
        '
        Me.cmdNeuerKinosaal.BackgroundImage = CType(resources.GetObject("cmdNeuerKinosaal.BackgroundImage"), System.Drawing.Image)
        Me.cmdNeuerKinosaal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNeuerKinosaal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNeuerKinosaal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNeuerKinosaal.Location = New System.Drawing.Point(1133, 423)
        Me.cmdNeuerKinosaal.Name = "cmdNeuerKinosaal"
        Me.cmdNeuerKinosaal.Size = New System.Drawing.Size(144, 66)
        Me.cmdNeuerKinosaal.TabIndex = 39
        Me.cmdNeuerKinosaal.Text = "Neuer Kinosaal"
        Me.cmdNeuerKinosaal.UseVisualStyleBackColor = True
        '
        'cmdWochenpläneBearbeiten
        '
        Me.cmdWochenpläneBearbeiten.BackgroundImage = CType(resources.GetObject("cmdWochenpläneBearbeiten.BackgroundImage"), System.Drawing.Image)
        Me.cmdWochenpläneBearbeiten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdWochenpläneBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdWochenpläneBearbeiten.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWochenpläneBearbeiten.Location = New System.Drawing.Point(1133, 495)
        Me.cmdWochenpläneBearbeiten.Name = "cmdWochenpläneBearbeiten"
        Me.cmdWochenpläneBearbeiten.Size = New System.Drawing.Size(144, 66)
        Me.cmdWochenpläneBearbeiten.TabIndex = 40
        Me.cmdWochenpläneBearbeiten.Text = "Wochenpläne bearbeiten"
        Me.cmdWochenpläneBearbeiten.UseVisualStyleBackColor = True
        '
        'cmdKundenDatenbankAufrufen
        '
        Me.cmdKundenDatenbankAufrufen.BackgroundImage = CType(resources.GetObject("cmdKundenDatenbankAufrufen.BackgroundImage"), System.Drawing.Image)
        Me.cmdKundenDatenbankAufrufen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdKundenDatenbankAufrufen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdKundenDatenbankAufrufen.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKundenDatenbankAufrufen.Location = New System.Drawing.Point(218, 733)
        Me.cmdKundenDatenbankAufrufen.Name = "cmdKundenDatenbankAufrufen"
        Me.cmdKundenDatenbankAufrufen.Size = New System.Drawing.Size(851, 44)
        Me.cmdKundenDatenbankAufrufen.TabIndex = 42
        Me.cmdKundenDatenbankAufrufen.Text = "Kunden"
        Me.cmdKundenDatenbankAufrufen.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        '
        'cmdTestVorstellung
        '
        Me.cmdTestVorstellung.BackgroundImage = CType(resources.GetObject("cmdTestVorstellung.BackgroundImage"), System.Drawing.Image)
        Me.cmdTestVorstellung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTestVorstellung.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTestVorstellung.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestVorstellung.Location = New System.Drawing.Point(1982, 918)
        Me.cmdTestVorstellung.Name = "cmdTestVorstellung"
        Me.cmdTestVorstellung.Size = New System.Drawing.Size(262, 66)
        Me.cmdTestVorstellung.TabIndex = 45
        Me.cmdTestVorstellung.Text = "TestVorstellung"
        Me.cmdTestVorstellung.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.Black
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.White
        Me.NumericUpDown1.Location = New System.Drawing.Point(1133, 171)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(144, 44)
        Me.NumericUpDown1.TabIndex = 46
        '
        'KinoGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2296, 1106)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.cmdTestVorstellung)
        Me.Controls.Add(Me.cmdKundenDatenbankAufrufen)
        Me.Controls.Add(Me.cmdWochenpläneBearbeiten)
        Me.Controls.Add(Me.cmdNeuerKinosaal)
        Me.Controls.Add(Me.cmdVorstellungErstellen)
        Me.Controls.Add(Me.cmdFilmHinzufügen)
        Me.Controls.Add(Me.cmdWochenplan6)
        Me.Controls.Add(Me.cmdWochenplan5)
        Me.Controls.Add(Me.cmdWochenplan4)
        Me.Controls.Add(Me.cmdWochenplan3)
        Me.Controls.Add(Me.cmdWochenplan2)
        Me.Controls.Add(Me.lblFreiePlätzeFarbe1)
        Me.Controls.Add(Me.lblFreiePlätze6)
        Me.Controls.Add(Me.lblFreiePlätze5)
        Me.Controls.Add(Me.lblFreiePlätze4)
        Me.Controls.Add(Me.lblFreiePlätze3)
        Me.Controls.Add(Me.lblFreiePlätze2)
        Me.Controls.Add(Me.lblFreiePlätze1)
        Me.Controls.Add(Me.lblKinosaal6)
        Me.Controls.Add(Me.lblKinosaal5)
        Me.Controls.Add(Me.lblKinosaal4)
        Me.Controls.Add(Me.lblKinosaal3)
        Me.Controls.Add(Me.lblKinosaal2)
        Me.Controls.Add(Me.lblKinosaal1)
        Me.Controls.Add(Me.lblFilm6)
        Me.Controls.Add(Me.lblFilm5)
        Me.Controls.Add(Me.lblFilm4)
        Me.Controls.Add(Me.lblFilm3)
        Me.Controls.Add(Me.lblFilm2)
        Me.Controls.Add(Me.lblFilm1)
        Me.Controls.Add(Me.lblTageseinnahmen)
        Me.Controls.Add(Me.lblDatum)
        Me.Controls.Add(Me.lblUhrzeit)
        Me.Controls.Add(Me.cmdBuchungStonieren)
        Me.Controls.Add(Me.cmdNeueBuchung)
        Me.Controls.Add(Me.cmdkinosaalAufrufen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdTexterfassen)
        Me.Controls.Add(Me.cmdWochenplan1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "KinoGUI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdWochenplan1 As Button
    Friend WithEvents cmdTexterfassen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdkinosaalAufrufen As Button
    Friend WithEvents cmdNeueBuchung As Button
    Friend WithEvents cmdBuchungStonieren As Button
    Friend WithEvents lblUhrzeit As Label
    Friend WithEvents lblDatum As Label
    Friend WithEvents lblTageseinnahmen As Label
    Friend WithEvents lblFilm1 As Label
    Friend WithEvents lblFilm2 As Label
    Friend WithEvents lblFilm3 As Label
    Friend WithEvents lblFilm4 As Label
    Friend WithEvents lblFilm5 As Label
    Friend WithEvents lblFilm6 As Label
    Friend WithEvents lblKinosaal1 As Label
    Friend WithEvents lblKinosaal2 As Label
    Friend WithEvents lblKinosaal3 As Label
    Friend WithEvents lblKinosaal4 As Label
    Friend WithEvents lblKinosaal5 As Label
    Friend WithEvents lblKinosaal6 As Label
    Friend WithEvents lblFreiePlätze1 As Label
    Friend WithEvents lblFreiePlätze2 As Label
    Friend WithEvents lblFreiePlätze3 As Label
    Friend WithEvents lblFreiePlätze4 As Label
    Friend WithEvents lblFreiePlätze5 As Label
    Friend WithEvents lblFreiePlätze6 As Label
    Friend WithEvents lblFreiePlätzeFarbe1 As Label
    Friend WithEvents cmdWochenplan2 As Button
    Friend WithEvents cmdWochenplan3 As Button
    Friend WithEvents cmdWochenplan4 As Button
    Friend WithEvents cmdWochenplan5 As Button
    Friend WithEvents cmdWochenplan6 As Button
    Friend WithEvents cmdFilmHinzufügen As Button
    Friend WithEvents cmdVorstellungErstellen As Button
    Friend WithEvents cmdNeuerKinosaal As Button
    Friend WithEvents cmdWochenpläneBearbeiten As Button
    Friend WithEvents cmdKundenDatenbankAufrufen As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cmdTestVorstellung As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
