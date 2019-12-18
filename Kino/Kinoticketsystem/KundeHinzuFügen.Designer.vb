<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KundeHinzuFügen
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.txtSuchen = New System.Windows.Forms.TextBox()
        Me.cmdSuchen = New System.Windows.Forms.Button()
        Me.cmdKundenHinzufügen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(98, 81)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(430, 706)
        Me.CheckedListBox1.TabIndex = 2
        '
        'txtSuchen
        '
        Me.txtSuchen.Location = New System.Drawing.Point(152, 840)
        Me.txtSuchen.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSuchen.Name = "txtSuchen"
        Me.txtSuchen.Size = New System.Drawing.Size(228, 31)
        Me.txtSuchen.TabIndex = 4
        Me.txtSuchen.Visible = False
        '
        'cmdSuchen
        '
        Me.cmdSuchen.Location = New System.Drawing.Point(484, 833)
        Me.cmdSuchen.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdSuchen.Name = "cmdSuchen"
        Me.cmdSuchen.Size = New System.Drawing.Size(150, 44)
        Me.cmdSuchen.TabIndex = 5
        Me.cmdSuchen.Text = "Suchen"
        Me.cmdSuchen.UseVisualStyleBackColor = True
        Me.cmdSuchen.Visible = False
        '
        'cmdKundenHinzufügen
        '
        Me.cmdKundenHinzufügen.BackColor = System.Drawing.Color.Black
        Me.cmdKundenHinzufügen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdKundenHinzufügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdKundenHinzufügen.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmdKundenHinzufügen.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKundenHinzufügen.Location = New System.Drawing.Point(199, 893)
        Me.cmdKundenHinzufügen.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdKundenHinzufügen.Name = "cmdKundenHinzufügen"
        Me.cmdKundenHinzufügen.Size = New System.Drawing.Size(435, 79)
        Me.cmdKundenHinzufügen.TabIndex = 6
        Me.cmdKundenHinzufügen.Text = "Neuen Kunden hinzufügen"
        Me.cmdKundenHinzufügen.UseVisualStyleBackColor = False
        '
        'KundeHinzuFügen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.NebenformenGUI_Hintergrund
        Me.ClientSize = New System.Drawing.Size(1254, 987)
        Me.Controls.Add(Me.cmdKundenHinzufügen)
        Me.Controls.Add(Me.cmdSuchen)
        Me.Controls.Add(Me.txtSuchen)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "KundeHinzuFügen"
        Me.Text = "KundeHinzuFügen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents txtSuchen As TextBox
    Friend WithEvents cmdSuchen As Button
    Friend WithEvents cmdKundenHinzufügen As Button
End Class
