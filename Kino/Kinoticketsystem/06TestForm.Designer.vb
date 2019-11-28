<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.cmdTestKinosaal = New System.Windows.Forms.Button()
        Me.cmdTestkinotest = New System.Windows.Forms.Button()
        Me.lstAusgabe = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdTestKinosaal
        '
        Me.cmdTestKinosaal.BackgroundImage = CType(resources.GetObject("cmdTestKinosaal.BackgroundImage"), System.Drawing.Image)
        Me.cmdTestKinosaal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTestKinosaal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTestKinosaal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestKinosaal.Location = New System.Drawing.Point(337, 185)
        Me.cmdTestKinosaal.Name = "cmdTestKinosaal"
        Me.cmdTestKinosaal.Size = New System.Drawing.Size(262, 66)
        Me.cmdTestKinosaal.TabIndex = 44
        Me.cmdTestKinosaal.Text = "TestKinosaal"
        Me.cmdTestKinosaal.UseVisualStyleBackColor = True
        '
        'cmdTestkinotest
        '
        Me.cmdTestkinotest.BackgroundImage = CType(resources.GetObject("cmdTestkinotest.BackgroundImage"), System.Drawing.Image)
        Me.cmdTestkinotest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTestkinotest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTestkinotest.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestkinotest.Location = New System.Drawing.Point(697, 185)
        Me.cmdTestkinotest.Name = "cmdTestkinotest"
        Me.cmdTestkinotest.Size = New System.Drawing.Size(262, 66)
        Me.cmdTestkinotest.TabIndex = 45
        Me.cmdTestkinotest.Text = "TestKino"
        Me.cmdTestkinotest.UseVisualStyleBackColor = True
        '
        'lstAusgabe
        '
        Me.lstAusgabe.FormattingEnabled = True
        Me.lstAusgabe.ItemHeight = 25
        Me.lstAusgabe.Location = New System.Drawing.Point(1224, 68)
        Me.lstAusgabe.Name = "lstAusgabe"
        Me.lstAusgabe.Size = New System.Drawing.Size(368, 354)
        Me.lstAusgabe.TabIndex = 46
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2540, 580)
        Me.Controls.Add(Me.lstAusgabe)
        Me.Controls.Add(Me.cmdTestkinotest)
        Me.Controls.Add(Me.cmdTestKinosaal)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdTestKinosaal As Button
    Friend WithEvents cmdTestkinotest As Button
    Friend WithEvents lstAusgabe As ListBox
End Class
