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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtSuchen = New System.Windows.Forms.TextBox()
        Me.cmdSuchen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(49, 42)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(217, 379)
        Me.CheckedListBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'txtSuchen
        '
        Me.txtSuchen.Location = New System.Drawing.Point(49, 460)
        Me.txtSuchen.Name = "txtSuchen"
        Me.txtSuchen.Size = New System.Drawing.Size(116, 20)
        Me.txtSuchen.TabIndex = 4
        '
        'cmdSuchen
        '
        Me.cmdSuchen.Location = New System.Drawing.Point(238, 460)
        Me.cmdSuchen.Name = "cmdSuchen"
        Me.cmdSuchen.Size = New System.Drawing.Size(75, 23)
        Me.cmdSuchen.TabIndex = 5
        Me.cmdSuchen.Text = "Suchen"
        Me.cmdSuchen.UseVisualStyleBackColor = True
        '
        'KundeHinzuFügen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.NebenformenGUI_Hintergrund
        Me.ClientSize = New System.Drawing.Size(343, 511)
        Me.Controls.Add(Me.cmdSuchen)
        Me.Controls.Add(Me.txtSuchen)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "KundeHinzuFügen"
        Me.Text = "KundeHinzuFügen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtSuchen As TextBox
    Friend WithEvents cmdSuchen As Button
End Class
