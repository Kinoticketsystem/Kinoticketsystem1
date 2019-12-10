<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vorstellungstitel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filmlänge:"
        '
        'txtFilmtitel
        '
        Me.txtFilmtitel.Location = New System.Drawing.Point(157, 56)
        Me.txtFilmtitel.Name = "txtFilmtitel"
        Me.txtFilmtitel.Size = New System.Drawing.Size(100, 20)
        Me.txtFilmtitel.TabIndex = 2
        '
        'txtFilmlänge
        '
        Me.txtFilmlänge.Location = New System.Drawing.Point(157, 94)
        Me.txtFilmlänge.Name = "txtFilmlänge"
        Me.txtFilmlänge.Size = New System.Drawing.Size(100, 20)
        Me.txtFilmlänge.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "in min"
        '
        'cmdFilmHinzufügen
        '
        Me.cmdFilmHinzufügen.Location = New System.Drawing.Point(361, 112)
        Me.cmdFilmHinzufügen.Name = "cmdFilmHinzufügen"
        Me.cmdFilmHinzufügen.Size = New System.Drawing.Size(133, 23)
        Me.cmdFilmHinzufügen.TabIndex = 5
        Me.cmdFilmHinzufügen.Text = "Film Hinzufügen"
        Me.cmdFilmHinzufügen.UseVisualStyleBackColor = True
        '
        'lstAlleFilme
        '
        Me.lstAlleFilme.FormattingEnabled = True
        Me.lstAlleFilme.Location = New System.Drawing.Point(157, 218)
        Me.lstAlleFilme.Name = "lstAlleFilme"
        Me.lstAlleFilme.Size = New System.Drawing.Size(141, 355)
        Me.lstAlleFilme.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "3D"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Altersfreigabe:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(157, 156)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "3D?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtAltersfreigabe
        '
        Me.txtAltersfreigabe.Location = New System.Drawing.Point(157, 119)
        Me.txtAltersfreigabe.Name = "txtAltersfreigabe"
        Me.txtAltersfreigabe.Size = New System.Drawing.Size(100, 20)
        Me.txtAltersfreigabe.TabIndex = 10
        '
        'FilmHinzufügenGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 585)
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
End Class
