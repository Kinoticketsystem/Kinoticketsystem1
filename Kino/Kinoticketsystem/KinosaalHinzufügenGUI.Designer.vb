<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KinosaalHinzufügenGUI
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
        Me.txtAnzahlReihe = New System.Windows.Forms.TextBox()
        Me.txtSitzeproReihe = New System.Windows.Forms.TextBox()
        Me.cmdKinosaalHinzufügen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAnzahlReihe
        '
        Me.txtAnzahlReihe.Location = New System.Drawing.Point(61, 128)
        Me.txtAnzahlReihe.Name = "txtAnzahlReihe"
        Me.txtAnzahlReihe.Size = New System.Drawing.Size(243, 20)
        Me.txtAnzahlReihe.TabIndex = 0
        '
        'txtSitzeproReihe
        '
        Me.txtSitzeproReihe.Location = New System.Drawing.Point(60, 213)
        Me.txtSitzeproReihe.Name = "txtSitzeproReihe"
        Me.txtSitzeproReihe.Size = New System.Drawing.Size(244, 20)
        Me.txtSitzeproReihe.TabIndex = 1
        '
        'cmdKinosaalHinzufügen
        '
        Me.cmdKinosaalHinzufügen.BackColor = System.Drawing.SystemColors.ControlText
        Me.cmdKinosaalHinzufügen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdKinosaalHinzufügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdKinosaalHinzufügen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdKinosaalHinzufügen.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKinosaalHinzufügen.Location = New System.Drawing.Point(410, 141)
        Me.cmdKinosaalHinzufügen.Name = "cmdKinosaalHinzufügen"
        Me.cmdKinosaalHinzufügen.Size = New System.Drawing.Size(196, 32)
        Me.cmdKinosaalHinzufügen.TabIndex = 2
        Me.cmdKinosaalHinzufügen.Text = "Kinosaal hinzufügen"
        Me.cmdKinosaalHinzufügen.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Anzahl der Reihen "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Anzahl der Sitze in einer Reihe "
        '
        'KinosaalHinzufügenGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.NebenformenGUI_Hintergrund
        Me.ClientSize = New System.Drawing.Size(655, 419)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdKinosaalHinzufügen)
        Me.Controls.Add(Me.txtSitzeproReihe)
        Me.Controls.Add(Me.txtAnzahlReihe)
        Me.Name = "KinosaalHinzufügenGUI"
        Me.Text = "KinosaalHinzufügenGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAnzahlReihe As TextBox
    Friend WithEvents txtSitzeproReihe As TextBox
    Friend WithEvents cmdKinosaalHinzufügen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
