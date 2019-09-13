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
        Me.cmdFilmÄndern = New System.Windows.Forms.Button()
        Me.txtFilmnummer = New System.Windows.Forms.TextBox()
        Me.txtFilmname = New System.Windows.Forms.TextBox()
        Me.chbMontag = New System.Windows.Forms.CheckBox()
        Me.chbFreitag = New System.Windows.Forms.CheckBox()
        Me.chbMittwoch = New System.Windows.Forms.CheckBox()
        Me.chbDienstag = New System.Windows.Forms.CheckBox()
        Me.chbDonnerstag = New System.Windows.Forms.CheckBox()
        Me.chb830 = New System.Windows.Forms.CheckBox()
        Me.chb1830 = New System.Windows.Forms.CheckBox()
        Me.chb1600 = New System.Windows.Forms.CheckBox()
        Me.chb1330 = New System.Windows.Forms.CheckBox()
        Me.chb1100 = New System.Windows.Forms.CheckBox()
        Me.chbSonntag = New System.Windows.Forms.CheckBox()
        Me.chbSamstag = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.chb2100 = New System.Windows.Forms.CheckBox()
        Me.chb2330 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdTagesPlanErstellen
        '
        Me.cmdTagesPlanErstellen.Location = New System.Drawing.Point(775, 545)
        Me.cmdTagesPlanErstellen.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTagesPlanErstellen.Name = "cmdTagesPlanErstellen"
        Me.cmdTagesPlanErstellen.Size = New System.Drawing.Size(185, 32)
        Me.cmdTagesPlanErstellen.TabIndex = 0
        Me.cmdTagesPlanErstellen.Text = "Tagesplan erstellen"
        Me.cmdTagesPlanErstellen.UseVisualStyleBackColor = True
        '
        'cmdFilmÄndern
        '
        Me.cmdFilmÄndern.Location = New System.Drawing.Point(863, 439)
        Me.cmdFilmÄndern.Name = "cmdFilmÄndern"
        Me.cmdFilmÄndern.Size = New System.Drawing.Size(75, 28)
        Me.cmdFilmÄndern.TabIndex = 1
        Me.cmdFilmÄndern.Text = "Film ändern"
        Me.cmdFilmÄndern.UseVisualStyleBackColor = True
        '
        'txtFilmnummer
        '
        Me.txtFilmnummer.Location = New System.Drawing.Point(491, 502)
        Me.txtFilmnummer.Name = "txtFilmnummer"
        Me.txtFilmnummer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFilmnummer.Size = New System.Drawing.Size(47, 30)
        Me.txtFilmnummer.TabIndex = 2
        Me.txtFilmnummer.Text = "00"
        '
        'txtFilmname
        '
        Me.txtFilmname.Location = New System.Drawing.Point(596, 437)
        Me.txtFilmname.Name = "txtFilmname"
        Me.txtFilmname.Size = New System.Drawing.Size(100, 30)
        Me.txtFilmname.TabIndex = 3
        Me.txtFilmname.Text = "Filmname"
        '
        'chbMontag
        '
        Me.chbMontag.AutoSize = True
        Me.chbMontag.Location = New System.Drawing.Point(150, 30)
        Me.chbMontag.Name = "chbMontag"
        Me.chbMontag.Size = New System.Drawing.Size(91, 26)
        Me.chbMontag.TabIndex = 5
        Me.chbMontag.Text = "Montag"
        Me.chbMontag.UseVisualStyleBackColor = True
        '
        'chbFreitag
        '
        Me.chbFreitag.AutoSize = True
        Me.chbFreitag.Location = New System.Drawing.Point(751, 30)
        Me.chbFreitag.Name = "chbFreitag"
        Me.chbFreitag.Size = New System.Drawing.Size(88, 26)
        Me.chbFreitag.TabIndex = 6
        Me.chbFreitag.Text = "Freitag"
        Me.chbFreitag.UseVisualStyleBackColor = True
        '
        'chbMittwoch
        '
        Me.chbMittwoch.AutoSize = True
        Me.chbMittwoch.Location = New System.Drawing.Point(432, 30)
        Me.chbMittwoch.Name = "chbMittwoch"
        Me.chbMittwoch.Size = New System.Drawing.Size(108, 26)
        Me.chbMittwoch.TabIndex = 7
        Me.chbMittwoch.Text = "Mittwoch"
        Me.chbMittwoch.UseVisualStyleBackColor = True
        '
        'chbDienstag
        '
        Me.chbDienstag.AutoSize = True
        Me.chbDienstag.Location = New System.Drawing.Point(286, 30)
        Me.chbDienstag.Name = "chbDienstag"
        Me.chbDienstag.Size = New System.Drawing.Size(101, 26)
        Me.chbDienstag.TabIndex = 8
        Me.chbDienstag.Text = "Dienstag"
        Me.chbDienstag.UseVisualStyleBackColor = True
        '
        'chbDonnerstag
        '
        Me.chbDonnerstag.AutoSize = True
        Me.chbDonnerstag.Location = New System.Drawing.Point(585, 30)
        Me.chbDonnerstag.Name = "chbDonnerstag"
        Me.chbDonnerstag.Size = New System.Drawing.Size(121, 26)
        Me.chbDonnerstag.TabIndex = 9
        Me.chbDonnerstag.Text = "Donnerstag"
        Me.chbDonnerstag.UseVisualStyleBackColor = True
        '
        'chb830
        '
        Me.chb830.AutoSize = True
        Me.chb830.Location = New System.Drawing.Point(30, 70)
        Me.chb830.Name = "chb830"
        Me.chb830.Size = New System.Drawing.Size(78, 26)
        Me.chb830.TabIndex = 10
        Me.chb830.Text = "08:30"
        Me.chb830.UseVisualStyleBackColor = True
        '
        'chb1830
        '
        Me.chb1830.AutoSize = True
        Me.chb1830.Location = New System.Drawing.Point(30, 254)
        Me.chb1830.Name = "chb1830"
        Me.chb1830.Size = New System.Drawing.Size(78, 26)
        Me.chb1830.TabIndex = 11
        Me.chb1830.Text = "18:30"
        Me.chb1830.UseVisualStyleBackColor = True
        '
        'chb1600
        '
        Me.chb1600.AutoSize = True
        Me.chb1600.Location = New System.Drawing.Point(30, 208)
        Me.chb1600.Name = "chb1600"
        Me.chb1600.Size = New System.Drawing.Size(78, 26)
        Me.chb1600.TabIndex = 12
        Me.chb1600.Text = "16:00"
        Me.chb1600.UseVisualStyleBackColor = True
        '
        'chb1330
        '
        Me.chb1330.AutoSize = True
        Me.chb1330.Location = New System.Drawing.Point(30, 162)
        Me.chb1330.Name = "chb1330"
        Me.chb1330.Size = New System.Drawing.Size(78, 26)
        Me.chb1330.TabIndex = 13
        Me.chb1330.Text = "13:30"
        Me.chb1330.UseVisualStyleBackColor = True
        '
        'chb1100
        '
        Me.chb1100.AutoSize = True
        Me.chb1100.Location = New System.Drawing.Point(30, 116)
        Me.chb1100.Name = "chb1100"
        Me.chb1100.Size = New System.Drawing.Size(77, 26)
        Me.chb1100.TabIndex = 14
        Me.chb1100.Text = "11:00"
        Me.chb1100.UseVisualStyleBackColor = True
        '
        'chbSonntag
        '
        Me.chbSonntag.AutoSize = True
        Me.chbSonntag.Location = New System.Drawing.Point(1026, 30)
        Me.chbSonntag.Name = "chbSonntag"
        Me.chbSonntag.Size = New System.Drawing.Size(94, 26)
        Me.chbSonntag.TabIndex = 15
        Me.chbSonntag.Text = "Sonntag"
        Me.chbSonntag.UseVisualStyleBackColor = True
        '
        'chbSamstag
        '
        Me.chbSamstag.AutoSize = True
        Me.chbSamstag.Location = New System.Drawing.Point(884, 30)
        Me.chbSamstag.Name = "chbSamstag"
        Me.chbSamstag.Size = New System.Drawing.Size(97, 26)
        Me.chbSamstag.TabIndex = 16
        Me.chbSamstag.Text = "Samstag"
        Me.chbSamstag.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(491, 582)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(248, 30)
        Me.DateTimePicker1.TabIndex = 17
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(921, 458)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 20
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(566, 503)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 30)
        Me.NumericUpDown1.TabIndex = 22
        '
        'chb2100
        '
        Me.chb2100.AutoSize = True
        Me.chb2100.Location = New System.Drawing.Point(30, 300)
        Me.chb2100.Name = "chb2100"
        Me.chb2100.Size = New System.Drawing.Size(78, 26)
        Me.chb2100.TabIndex = 23
        Me.chb2100.Text = "21:00"
        Me.chb2100.UseVisualStyleBackColor = True
        '
        'chb2330
        '
        Me.chb2330.AutoSize = True
        Me.chb2330.Location = New System.Drawing.Point(30, 346)
        Me.chb2330.Name = "chb2330"
        Me.chb2330.Size = New System.Drawing.Size(78, 26)
        Me.chb2330.TabIndex = 24
        Me.chb2330.Text = "23:30"
        Me.chb2330.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(150, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 26)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(150, 116)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 26)
        Me.Button2.TabIndex = 26
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(150, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 26)
        Me.Button3.TabIndex = 27
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(150, 208)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 26)
        Me.Button4.TabIndex = 28
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(150, 254)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 26)
        Me.Button5.TabIndex = 29
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(150, 300)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 26)
        Me.Button6.TabIndex = 30
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(150, 346)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 26)
        Me.Button7.TabIndex = 31
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(286, 70)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(101, 26)
        Me.Button8.TabIndex = 32
        Me.Button8.UseVisualStyleBackColor = True
        '
        'FTagesplan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 667)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chb2330)
        Me.Controls.Add(Me.chb2100)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.chbSamstag)
        Me.Controls.Add(Me.chbSonntag)
        Me.Controls.Add(Me.chb1100)
        Me.Controls.Add(Me.chb1330)
        Me.Controls.Add(Me.chb1600)
        Me.Controls.Add(Me.chb1830)
        Me.Controls.Add(Me.chb830)
        Me.Controls.Add(Me.chbDonnerstag)
        Me.Controls.Add(Me.chbDienstag)
        Me.Controls.Add(Me.chbMittwoch)
        Me.Controls.Add(Me.chbFreitag)
        Me.Controls.Add(Me.chbMontag)
        Me.Controls.Add(Me.txtFilmname)
        Me.Controls.Add(Me.txtFilmnummer)
        Me.Controls.Add(Me.cmdFilmÄndern)
        Me.Controls.Add(Me.cmdTagesPlanErstellen)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FTagesplan"
        Me.Text = "Tagesplan"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdTagesPlanErstellen As Button
    Friend WithEvents cmdFilmÄndern As Button
    Friend WithEvents txtFilmnummer As TextBox
    Friend WithEvents txtFilmname As TextBox
    Friend WithEvents chbMontag As CheckBox
    Friend WithEvents chbFreitag As CheckBox
    Friend WithEvents chbMittwoch As CheckBox
    Friend WithEvents chbDienstag As CheckBox
    Friend WithEvents chbDonnerstag As CheckBox
    Friend WithEvents chb830 As CheckBox
    Friend WithEvents chb1830 As CheckBox
    Friend WithEvents chb1600 As CheckBox
    Friend WithEvents chb1330 As CheckBox
    Friend WithEvents chb1100 As CheckBox
    Friend WithEvents chbSonntag As CheckBox
    Friend WithEvents chbSamstag As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents chb2100 As CheckBox
    Friend WithEvents chb2330 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
