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
        Me.lstAusgabeKino = New System.Windows.Forms.ListBox()
        Me.cmdTestAll = New System.Windows.Forms.Button()
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
        Me.cmdTestKinosaal.Location = New System.Drawing.Point(88, 113)
        Me.cmdTestKinosaal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTestKinosaal.Name = "cmdTestKinosaal"
        Me.cmdTestKinosaal.Size = New System.Drawing.Size(262, 65)
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
        Me.cmdTestkinotest.Location = New System.Drawing.Point(636, 113)
        Me.cmdTestkinotest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdTestkinotest.Name = "cmdTestkinotest"
        Me.cmdTestkinotest.Size = New System.Drawing.Size(262, 65)
        Me.cmdTestkinotest.TabIndex = 45
        Me.cmdTestkinotest.Text = "TestKino"
        Me.cmdTestkinotest.UseVisualStyleBackColor = True
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
        Me.lstAusgabeKino.Location = New System.Drawing.Point(600, 319)
        Me.lstAusgabeKino.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstAusgabeKino.Name = "lstAusgabeKino"
        Me.lstAusgabeKino.Size = New System.Drawing.Size(368, 354)
        Me.lstAusgabeKino.TabIndex = 47
        '
        'cmdTestAll
        '
        Me.cmdTestAll.BackgroundImage = CType(resources.GetObject("cmdTestAll.BackgroundImage"), System.Drawing.Image)
        Me.cmdTestAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdTestAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTestAll.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestAll.Location = New System.Drawing.Point(636, 195)
        Me.cmdTestAll.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTestAll.Name = "cmdTestAll"
        Me.cmdTestAll.Size = New System.Drawing.Size(262, 65)
        Me.cmdTestAll.TabIndex = 48
        Me.cmdTestAll.Text = "TestAll"
        Me.cmdTestAll.UseVisualStyleBackColor = True
        '
        'lstTagesplan
        '
        Me.lstTagesplan.FormattingEnabled = True
        Me.lstTagesplan.ItemHeight = 25
        Me.lstTagesplan.Location = New System.Drawing.Point(1385, 418)
        Me.lstTagesplan.Margin = New System.Windows.Forms.Padding(4)
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
        Me.cmdTestTagesplan.Location = New System.Drawing.Point(1425, 259)
        Me.cmdTestTagesplan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTestTagesplan.Name = "cmdTestTagesplan"
        Me.cmdTestTagesplan.Size = New System.Drawing.Size(262, 65)
        Me.cmdTestTagesplan.TabIndex = 50
        Me.cmdTestTagesplan.Text = "TestAll"
        Me.cmdTestTagesplan.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Kinoticketsystem.My.Resources.Resources.The_Wolf_Of_Wall_Street
        Me.ClientSize = New System.Drawing.Size(2400, 1071)
        Me.Controls.Add(Me.cmdTestTagesplan)
        Me.Controls.Add(Me.lstTagesplan)
        Me.Controls.Add(Me.cmdTestAll)
        Me.Controls.Add(Me.lstAusgabeKino)
        Me.Controls.Add(Me.lstAusgabe)
        Me.Controls.Add(Me.cmdTestkinotest)
        Me.Controls.Add(Me.cmdTestKinosaal)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdTestKinosaal As Button
    Friend WithEvents cmdTestkinotest As Button
    Friend WithEvents lstAusgabe As ListBox
    Friend WithEvents lstAusgabeKino As ListBox
    Friend WithEvents cmdTestAll As Button
    Friend WithEvents lstTagesplan As ListBox
    Friend WithEvents cmdTestTagesplan As Button
End Class
