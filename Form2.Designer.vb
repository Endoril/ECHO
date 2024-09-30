<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEinnahmeHinzufügen
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
        TextBox1 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        btnSpeichern = New Button()
        btnAbbrechen = New Button()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(306, 99)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(174, 34)
        TextBox1.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(491, 198)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(284, 27)
        DateTimePicker1.TabIndex = 1
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 12F)
        RadioButton1.Location = New Point(6, 26)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(105, 32)
        RadioButton1.TabIndex = 2
        RadioButton1.TabStop = True
        RadioButton1.Text = "€ Euro €"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 12F)
        RadioButton2.Location = New Point(6, 61)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(118, 32)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "$ Dollar $"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(48, 197)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(284, 28)
        ComboBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(48, 298)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(284, 27)
        TextBox2.TabIndex = 5
        ' 
        ' btnSpeichern
        ' 
        btnSpeichern.Font = New Font("Segoe UI", 12F)
        btnSpeichern.Location = New Point(602, 415)
        btnSpeichern.Name = "btnSpeichern"
        btnSpeichern.Size = New Size(173, 64)
        btnSpeichern.TabIndex = 6
        btnSpeichern.Text = "Speichern"
        btnSpeichern.UseVisualStyleBackColor = True
        ' 
        ' btnAbbrechen
        ' 
        btnAbbrechen.Font = New Font("Segoe UI", 12F)
        btnAbbrechen.Location = New Point(48, 415)
        btnAbbrechen.Name = "btnAbbrechen"
        btnAbbrechen.Size = New Size(173, 59)
        btnAbbrechen.TabIndex = 7
        btnAbbrechen.Text = "Abbrechen"
        btnAbbrechen.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 12F)
        RadioButton3.Location = New Point(6, 26)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(167, 32)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Wiederkehrend"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 12F)
        RadioButton4.Location = New Point(6, 66)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(108, 32)
        RadioButton4.TabIndex = 9
        RadioButton4.TabStop = True
        RadioButton4.Text = "Einmalig"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 20)
        Label1.TabIndex = 10
        Label1.Text = "Kategorie"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 275)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 20)
        Label2.TabIndex = 11
        Label2.Text = "Beschreibung (optional)"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Location = New Point(48, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(145, 110)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Location = New Point(596, 40)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(179, 110)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(306, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 28)
        Label3.TabIndex = 14
        Label3.Text = "Betrag"
        ' 
        ' FormEinnahmeHinzufügen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(818, 532)
        Controls.Add(Label3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAbbrechen)
        Controls.Add(btnSpeichern)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox1)
        Name = "FormEinnahmeHinzufügen"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnSpeichern As Button
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
End Class
