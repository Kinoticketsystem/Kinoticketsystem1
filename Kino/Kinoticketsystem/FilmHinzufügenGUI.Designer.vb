﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FilmHinzufügenGUI
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFilmtitel = New System.Windows.Forms.TextBox()
        Me.txtFilmlänge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFilmHinzufügen = New System.Windows.Forms.Button()
        Me.lstAlleFilme = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtAltersfreigabe = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdFilmEntfernen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vorstellungstitel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.No
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(69, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filmlänge:"
        '
        'txtFilmtitel
        '
        Me.txtFilmtitel.Location = New System.Drawing.Point(209, 69)
        Me.txtFilmtitel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFilmtitel.Name = "txtFilmtitel"
        Me.txtFilmtitel.Size = New System.Drawing.Size(132, 22)
        Me.txtFilmtitel.TabIndex = 1
        '
        'txtFilmlänge
        '
        Me.txtFilmlänge.Location = New System.Drawing.Point(209, 116)
        Me.txtFilmlänge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFilmlänge.Name = "txtFilmlänge"
        Me.txtFilmlänge.Size = New System.Drawing.Size(132, 22)
        Me.txtFilmlänge.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.No
        Me.Label3.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(348, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "in min"
        '
        'cmdFilmHinzufügen
        '
        Me.cmdFilmHinzufügen.BackColor = System.Drawing.Color.Black
        Me.cmdFilmHinzufügen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdFilmHinzufügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFilmHinzufügen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFilmHinzufügen.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilmHinzufügen.ForeColor = System.Drawing.Color.Black
        Me.cmdFilmHinzufügen.Location = New System.Drawing.Point(143, 274)
        Me.cmdFilmHinzufügen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFilmHinzufügen.Name = "cmdFilmHinzufügen"
        Me.cmdFilmHinzufügen.Size = New System.Drawing.Size(273, 37)
        Me.cmdFilmHinzufügen.TabIndex = 5
        Me.cmdFilmHinzufügen.Text = "Film Hinzufügen"
        Me.cmdFilmHinzufügen.UseVisualStyleBackColor = False
        '
        'lstAlleFilme
        '
        Me.lstAlleFilme.FormattingEnabled = True
        Me.lstAlleFilme.ItemHeight = 16
        Me.lstAlleFilme.Location = New System.Drawing.Point(743, 32)
        Me.lstAlleFilme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstAlleFilme.Name = "lstAlleFilme"
        Me.lstAlleFilme.Size = New System.Drawing.Size(255, 516)
        Me.lstAlleFilme.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.No
        Me.Label4.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(149, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(40, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "3D"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.No
        Me.Label5.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Altersfreigabe:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(221, 199)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(45, 21)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Ja"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtAltersfreigabe
        '
        Me.txtAltersfreigabe.Location = New System.Drawing.Point(209, 146)
        Me.txtAltersfreigabe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAltersfreigabe.Name = "txtAltersfreigabe"
        Me.txtAltersfreigabe.Size = New System.Drawing.Size(132, 22)
        Me.txtAltersfreigabe.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.No
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(632, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Alle Filme:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.No
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(283, 194)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(390, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Wenn es kein 3D-Film ist dann nicht ankreuzen"
        '
        'cmdFilmEntfernen
        '
        Me.cmdFilmEntfernen.BackColor = System.Drawing.Color.Black
        Me.cmdFilmEntfernen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdFilmEntfernen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdFilmEntfernen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFilmEntfernen.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFilmEntfernen.ForeColor = System.Drawing.Color.Black
        Me.cmdFilmEntfernen.Location = New System.Drawing.Point(143, 338)
        Me.cmdFilmEntfernen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFilmEntfernen.Name = "cmdFilmEntfernen"
        Me.cmdFilmEntfernen.Size = New System.Drawing.Size(273, 37)
        Me.cmdFilmEntfernen.TabIndex = 11
        Me.cmdFilmEntfernen.Text = "Film Entfernen"
        Me.cmdFilmEntfernen.UseVisualStyleBackColor = False
        '
        'FilmHinzufügenGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.NebenformenGUI_Hintergrund
        Me.ClientSize = New System.Drawing.Size(1173, 639)
        Me.Controls.Add(Me.cmdFilmEntfernen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAltersfreigabe)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstAlleFilme)
        Me.Controls.Add(Me.cmdFilmHinzufügen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFilmlänge)
        Me.Controls.Add(Me.txtFilmtitel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FilmHinzufügenGUI"
        Me.Text = "FilmHinzufügenGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFilmtitel As TextBox
    Friend WithEvents txtFilmlänge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdFilmHinzufügen As Button
    Friend WithEvents lstAlleFilme As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtAltersfreigabe As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdFilmEntfernen As Button
End Class
