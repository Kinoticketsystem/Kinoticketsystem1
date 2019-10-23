<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TexterfassenTest
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
        Me.lstTextausgabe = New System.Windows.Forms.ListBox()
        Me.cmdTexterfassen = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstTextausgabe
        '
        Me.lstTextausgabe.FormattingEnabled = True
        Me.lstTextausgabe.ItemHeight = 16
        Me.lstTextausgabe.Location = New System.Drawing.Point(48, 15)
        Me.lstTextausgabe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstTextausgabe.Name = "lstTextausgabe"
        Me.lstTextausgabe.Size = New System.Drawing.Size(784, 436)
        Me.lstTextausgabe.TabIndex = 0
        '
        'cmdTexterfassen
        '
        Me.cmdTexterfassen.Location = New System.Drawing.Point(919, 110)
        Me.cmdTexterfassen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTexterfassen.Name = "cmdTexterfassen"
        Me.cmdTexterfassen.Size = New System.Drawing.Size(233, 62)
        Me.cmdTexterfassen.TabIndex = 1
        Me.cmdTexterfassen.Text = "TextErfassen"
        Me.cmdTexterfassen.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(112, 522)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(223, 22)
        Me.txtInput.TabIndex = 2
        '
        'TexterfassenTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1555, 583)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.cmdTexterfassen)
        Me.Controls.Add(Me.lstTextausgabe)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TexterfassenTest"
        Me.Text = "TexterfassenTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstTextausgabe As ListBox
    Friend WithEvents cmdTexterfassen As Button
    Friend WithEvents txtInput As TextBox
End Class
