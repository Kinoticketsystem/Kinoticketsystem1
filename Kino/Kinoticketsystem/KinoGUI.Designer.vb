﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KinoGUI
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
        Me.cmdWochenplan = New System.Windows.Forms.Button()
        Me.cmdTexterfassen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdkinosaalAufrufen = New System.Windows.Forms.Button()
        Me.cmdKinosaalTest = New System.Windows.Forms.Button()
        Me.cmdNeueBuchung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdWochenplan
        '
        Me.cmdWochenplan.Location = New System.Drawing.Point(980, 602)
        Me.cmdWochenplan.Name = "cmdWochenplan"
        Me.cmdWochenplan.Size = New System.Drawing.Size(193, 52)
        Me.cmdWochenplan.TabIndex = 0
        Me.cmdWochenplan.Text = "Wochenplan aufrufen"
        Me.cmdWochenplan.UseVisualStyleBackColor = True
        '
        'cmdTexterfassen
        '
        Me.cmdTexterfassen.Location = New System.Drawing.Point(32, 584)
        Me.cmdTexterfassen.Name = "cmdTexterfassen"
        Me.cmdTexterfassen.Size = New System.Drawing.Size(225, 66)
        Me.cmdTexterfassen.TabIndex = 1
        Me.cmdTexterfassen.Text = "Texterfassen Erik"
        Me.cmdTexterfassen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 38)
        Me.Label1.TabIndex = 2
        '
        'cmdkinosaalAufrufen
        '
        Me.cmdkinosaalAufrufen.Location = New System.Drawing.Point(386, 584)
        Me.cmdkinosaalAufrufen.Name = "cmdkinosaalAufrufen"
        Me.cmdkinosaalAufrufen.Size = New System.Drawing.Size(135, 41)
        Me.cmdkinosaalAufrufen.TabIndex = 3
        Me.cmdkinosaalAufrufen.Text = "Kinosaal aufrufen"
        Me.cmdkinosaalAufrufen.UseVisualStyleBackColor = True
        '
        'cmdKinosaalTest
        '
        Me.cmdKinosaalTest.Location = New System.Drawing.Point(1333, 578)
        Me.cmdKinosaalTest.Name = "cmdKinosaalTest"
        Me.cmdKinosaalTest.Size = New System.Drawing.Size(248, 53)
        Me.cmdKinosaalTest.TabIndex = 4
        Me.cmdKinosaalTest.Text = "Kinosaal Test"
        Me.cmdKinosaalTest.UseVisualStyleBackColor = True
        '
        'cmdNeueBuchung
        '
        Me.cmdNeueBuchung.Location = New System.Drawing.Point(626, 575)
        Me.cmdNeueBuchung.Name = "cmdNeueBuchung"
        Me.cmdNeueBuchung.Size = New System.Drawing.Size(289, 85)
        Me.cmdNeueBuchung.TabIndex = 5
        Me.cmdNeueBuchung.Text = "NeueBuchung"
        Me.cmdNeueBuchung.UseVisualStyleBackColor = True
        '
        'KinoGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.cmdNeueBuchung)
        Me.Controls.Add(Me.cmdKinosaalTest)
        Me.Controls.Add(Me.cmdkinosaalAufrufen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdTexterfassen)
        Me.Controls.Add(Me.cmdWochenplan)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "KinoGUI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdWochenplan As Button
    Friend WithEvents cmdTexterfassen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdkinosaalAufrufen As Button
    Friend WithEvents cmdKinosaalTest As Button
    Friend WithEvents cmdNeueBuchung As Button
End Class
