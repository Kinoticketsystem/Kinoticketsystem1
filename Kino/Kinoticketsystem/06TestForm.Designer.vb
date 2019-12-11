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
        Me.lstAusgabe = New System.Windows.Forms.ListBox()
        Me.lstAusgabeKino = New System.Windows.Forms.ListBox()
        Me.cmdTestKino = New System.Windows.Forms.Button()
        Me.lstTagesplan = New System.Windows.Forms.ListBox()
        Me.cmdTestTagesplan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdTestKinosaal
        '
        Me.cmdTestKinosaal.BackgroundImage = CType(resources.GetObject("cmdTestKinosaal.BackgroundImage"), System.Drawing.Image)
        Me.cmdTestKinosaal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTestKinosaal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTestKinosaal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestKinosaal.Location = New System.Drawing.Point(88, 140)
        Me.cmdTestKinosaal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTestKinosaal.Name = "cmdTestKinosaal"
        Me.cmdTestKinosaal.Size = New System.Drawing.Size(352, 65)
        Me.cmdTestKinosaal.TabIndex = 44
        Me.cmdTestKinosaal.Text = "TestAllKinosaal"
        Me.cmdTestKinosaal.UseVisualStyleBackColor = True
        '
        'lstAusgabe
        '
        Me.lstAusgabe.FormattingEnabled = True
        Me.lstAusgabe.ItemHeight = 25
        Me.lstAusgabe.Location = New System.Drawing.Point(68, 277)
        Me.lstAusgabe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstAusgabe.Name = "lstAusgabe"
        Me.lstAusgabe.Size = New System.Drawing.Size(368, 354)
        Me.lstAusgabe.TabIndex = 46
        '
        'lstAusgabeKino
        '
        Me.lstAusgabeKino.FormattingEnabled = True
        Me.lstAusgabeKino.ItemHeight = 25
        Me.lstAusgabeKino.Location = New System.Drawing.Point(602, 277)
        Me.lstAusgabeKino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstAusgabeKino.Name = "lstAusgabeKino"
        Me.lstAusgabeKino.Size = New System.Drawing.Size(368, 354)
        Me.lstAusgabeKino.TabIndex = 47
        '
        'cmdTestKino
        '
        Me.cmdTestKino.BackgroundImage = CType(resources.GetObject("cmdTestKino.BackgroundImage"), System.Drawing.Image)
        Me.cmdTestKino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTestKino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTestKino.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestKino.Location = New System.Drawing.Point(628, 140)
        Me.cmdTestKino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTestKino.Name = "cmdTestKino"
        Me.cmdTestKino.Size = New System.Drawing.Size(346, 65)
        Me.cmdTestKino.TabIndex = 48
        Me.cmdTestKino.Text = "TestAllKino"
        Me.cmdTestKino.UseVisualStyleBackColor = True
        '
        'lstTagesplan
        '
        Me.lstTagesplan.FormattingEnabled = True
        Me.lstTagesplan.ItemHeight = 25
        Me.lstTagesplan.Location = New System.Drawing.Point(1222, 277)
        Me.lstTagesplan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstTagesplan.Name = "lstTagesplan"
        Me.lstTagesplan.Size = New System.Drawing.Size(368, 354)
        Me.lstTagesplan.TabIndex = 49
        '
        'cmdTestTagesplan
        '
        Me.cmdTestTagesplan.BackgroundImage = CType(resources.GetObject("cmdTestTagesplan.BackgroundImage"), System.Drawing.Image)
        Me.cmdTestTagesplan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTestTagesplan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTestTagesplan.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestTagesplan.Location = New System.Drawing.Point(1222, 140)
        Me.cmdTestTagesplan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTestTagesplan.Name = "cmdTestTagesplan"
        Me.cmdTestTagesplan.Size = New System.Drawing.Size(332, 65)
        Me.cmdTestTagesplan.TabIndex = 50
        Me.cmdTestTagesplan.Text = "TestAllTagesplan"
        Me.cmdTestTagesplan.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.NebenformenGUI_Hintergrund
        Me.ClientSize = New System.Drawing.Size(2126, 1058)
        Me.Controls.Add(Me.cmdTestTagesplan)
        Me.Controls.Add(Me.lstTagesplan)
        Me.Controls.Add(Me.cmdTestKino)
        Me.Controls.Add(Me.lstAusgabeKino)
        Me.Controls.Add(Me.lstAusgabe)
        Me.Controls.Add(Me.cmdTestKinosaal)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdTestKinosaal As Button
    Friend WithEvents lstAusgabe As ListBox
    Friend WithEvents lstAusgabeKino As ListBox
    Friend WithEvents cmdTestKino As Button
    Friend WithEvents lstTagesplan As ListBox
    Friend WithEvents cmdTestTagesplan As Button
End Class
