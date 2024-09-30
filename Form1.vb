Public Class Form1

    Private Sub btnEinnahmeHinzufügen_Click(sender As Object, e As EventArgs) Handles btnEinnahmeHinzufügen.Click
        ' Erstelle eine Instanz des Einnahme-Hinzufügen-Formulars
        Dim neuesFormular As New FormEinnahmeHinzufügen()

        ' Zeige das Formular als modales Dialogfenster
        neuesFormular.ShowDialog() ' Blockiert das Hauptfenster, bis das neue Formular geschlossen wird
    End Sub

End Class
