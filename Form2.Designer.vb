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
        TxtBetrag = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        BtnSpeichern = New Button()
        BtnAbbrechen = New Button()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton7 = New RadioButton()
        RadioButton8 = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TxtBetrag
        ' 
        TxtBetrag.Font = New Font("Segoe UI", 12F)
        TxtBetrag.Location = New Point(306, 99)
        TxtBetrag.Multiline = True
        TxtBetrag.Name = "TxtBetrag"
        TxtBetrag.Size = New Size(174, 34)
        TxtBetrag.TabIndex = 0
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
        ' BtnSpeichern
        ' 
        BtnSpeichern.Font = New Font("Segoe UI", 12F)
        BtnSpeichern.Location = New Point(602, 415)
        BtnSpeichern.Name = "BtnSpeichern"
        BtnSpeichern.Size = New Size(173, 64)
        BtnSpeichern.TabIndex = 6
        BtnSpeichern.Text = "Speichern"
        BtnSpeichern.UseVisualStyleBackColor = True
        ' 
        ' BtnAbbrechen
        ' 
        BtnAbbrechen.Font = New Font("Segoe UI", 12F)
        BtnAbbrechen.Location = New Point(48, 415)
        BtnAbbrechen.Name = "BtnAbbrechen"
        BtnAbbrechen.Size = New Size(173, 59)
        BtnAbbrechen.TabIndex = 7
        BtnAbbrechen.Text = "Abbrechen"
        BtnAbbrechen.UseVisualStyleBackColor = True
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(491, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 20)
        Label4.TabIndex = 15
        Label4.Text = "Datum der Einnahme"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton8)
        GroupBox3.Controls.Add(RadioButton7)
        GroupBox3.Controls.Add(RadioButton6)
        GroupBox3.Controls.Add(RadioButton5)
        GroupBox3.Location = New Point(491, 266)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(284, 113)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(14, 26)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(96, 24)
        RadioButton5.TabIndex = 0
        RadioButton5.TabStop = True
        RadioButton5.Text = "monatlich"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(14, 73)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(78, 24)
        RadioButton6.TabIndex = 1
        RadioButton6.TabStop = True
        RadioButton6.Text = "jährlich"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(157, 26)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(75, 24)
        RadioButton7.TabIndex = 2
        RadioButton7.TabStop = True
        RadioButton7.Text = "täglich"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(157, 73)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(109, 24)
        RadioButton8.TabIndex = 17
        RadioButton8.TabStop = True
        RadioButton8.Text = "wöchentlich"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' FormEinnahmeHinzufügen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(818, 532)
        Controls.Add(GroupBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnAbbrechen)
        Controls.Add(BtnSpeichern)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TxtBetrag)
        Name = "FormEinnahmeHinzufügen"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtBetrag As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnSpeichern As Button
    Friend WithEvents BtnAbbrechen As Button
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
End Class
