<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KundenGUI
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
        Me.lstSammlung = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdLöschenHinzufügen = New System.Windows.Forms.Button()
        Me.cmdKundeEntfernen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstSammlung
        '
        Me.lstSammlung.FormattingEnabled = True
        Me.lstSammlung.Location = New System.Drawing.Point(364, 16)
        Me.lstSammlung.Name = "lstSammlung"
        Me.lstSammlung.Size = New System.Drawing.Size(242, 407)
        Me.lstSammlung.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Calibri", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name: "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(80, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(197, 26)
        Me.txtName.TabIndex = 2
        '
        'cmdLöschenHinzufügen
        '
        Me.cmdLöschenHinzufügen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdLöschenHinzufügen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdLöschenHinzufügen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLöschenHinzufügen.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLöschenHinzufügen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLöschenHinzufügen.Location = New System.Drawing.Point(26, 80)
        Me.cmdLöschenHinzufügen.Name = "cmdLöschenHinzufügen"
        Me.cmdLöschenHinzufügen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLöschenHinzufügen.Size = New System.Drawing.Size(251, 29)
        Me.cmdLöschenHinzufügen.TabIndex = 3
        Me.cmdLöschenHinzufügen.Text = "Kunde hinzufügen "
        Me.cmdLöschenHinzufügen.UseVisualStyleBackColor = True
        '
        'cmdKundeEntfernen
        '
        Me.cmdKundeEntfernen.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.Button_Hintergrund
        Me.cmdKundeEntfernen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdKundeEntfernen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdKundeEntfernen.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cmdKundeEntfernen.Location = New System.Drawing.Point(26, 151)
        Me.cmdKundeEntfernen.Name = "cmdKundeEntfernen"
        Me.cmdKundeEntfernen.Size = New System.Drawing.Size(250, 32)
        Me.cmdKundeEntfernen.TabIndex = 4
        Me.cmdKundeEntfernen.Text = "Kunde entfernen"
        Me.cmdKundeEntfernen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(283, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alle Kunden:"
        '
        'KundenGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.NebenformenGUI_Hintergrund
        Me.ClientSize = New System.Drawing.Size(629, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdKundeEntfernen)
        Me.Controls.Add(Me.cmdLöschenHinzufügen)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSammlung)
        Me.name = "KundenGUI"
        Me.Text = "Kunden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSammlung As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdLöschenHinzufügen As Button
    Friend WithEvents cmdKundeEntfernen As Button
    Friend WithEvents Label2 As Label
End Class
