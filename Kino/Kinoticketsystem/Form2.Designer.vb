<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.cmdFilmtitel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdFilmlaenge = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdFilmtitel
        '
        Me.cmdFilmtitel.Location = New System.Drawing.Point(40, 36)
        Me.cmdFilmtitel.Name = "cmdFilmtitel"
        Me.cmdFilmtitel.Size = New System.Drawing.Size(137, 23)
        Me.cmdFilmtitel.TabIndex = 0
        Me.cmdFilmtitel.Text = "Filmtitel festlegen"
        Me.cmdFilmtitel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 1
        '
        'cmdFilmlaenge
        '
        Me.cmdFilmlaenge.Location = New System.Drawing.Point(293, 36)
        Me.cmdFilmlaenge.Name = "cmdFilmlaenge"
        Me.cmdFilmlaenge.Size = New System.Drawing.Size(75, 23)
        Me.cmdFilmlaenge.TabIndex = 2
        Me.cmdFilmlaenge.Text = "Filmlänge"
        Me.cmdFilmlaenge.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdFilmlaenge)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdFilmtitel)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdFilmtitel As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmdFilmlaenge As Button
    Friend WithEvents Button2 As Button
End Class
