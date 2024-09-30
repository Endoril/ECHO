<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnEinnahmeHinzufügen = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnEinnahmeHinzufügen
        ' 
        btnEinnahmeHinzufügen.Location = New Point(31, 38)
        btnEinnahmeHinzufügen.Name = "btnEinnahmeHinzufügen"
        btnEinnahmeHinzufügen.Size = New Size(94, 56)
        btnEinnahmeHinzufügen.TabIndex = 0
        btnEinnahmeHinzufügen.Text = "Einnahme hinzufügen"
        btnEinnahmeHinzufügen.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(31, 148)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 53)
        Button2.TabIndex = 1
        Button2.Text = "Ausgabe hinzufügen"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(165, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 2
        Label1.Text = "Verfügbares Budget"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(165, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 20)
        Label2.TabIndex = 3
        Label2.Text = "Ausgaben (Monat)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(165, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 20)
        Label3.TabIndex = 4
        Label3.Text = "Einnahmen (Monat)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 248)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(btnEinnahmeHinzufügen)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEinnahmeHinzufügen As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
