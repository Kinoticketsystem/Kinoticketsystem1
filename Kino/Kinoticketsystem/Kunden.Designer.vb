<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KundenGUI
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
        Me.lstSammlung = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdLöschenHinzufügen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSammlung
        '
        Me.lstSammlung.FormattingEnabled = True
        Me.lstSammlung.ItemHeight = 25
        Me.lstSammlung.Location = New System.Drawing.Point(24, 23)
        Me.lstSammlung.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstSammlung.Name = "lstSammlung"
        Me.lstSammlung.Size = New System.Drawing.Size(684, 804)
        Me.lstSammlung.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(722, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name: "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(840, 23)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(390, 44)
        Me.txtName.TabIndex = 2
        '
        'cmdLöschenHinzufügen
        '
        Me.cmdLöschenHinzufügen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLöschenHinzufügen.Location = New System.Drawing.Point(732, 140)
        Me.cmdLöschenHinzufügen.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmdLöschenHinzufügen.Name = "cmdLöschenHinzufügen"
        Me.cmdLöschenHinzufügen.Size = New System.Drawing.Size(502, 56)
        Me.cmdLöschenHinzufügen.TabIndex = 3
        Me.cmdLöschenHinzufügen.UseVisualStyleBackColor = True
        '
        'KundenGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 865)
        Me.Controls.Add(Me.cmdLöschenHinzufügen)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSammlung)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "KundenGUI"
        Me.Text = "Kunden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSammlung As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdLöschenHinzufügen As Button
End Class
