Public Class FormEinnahmeHinzufügen

    ' Klick-Event für den Speichern-Button im modalen Fenster
    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        ' Hier kannst du den Code hinzufügen, um die Einnahme zu speichern
        ' Z. B. Daten aus den Textboxen lesen und verarbeiten

        ' Schließe das modale Fenster nach dem Speichern
        Me.Close()
    End Sub

    ' Klick-Event für den Abbrechen-Button im modalen Fenster
    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        ' Schließe das modale Fenster, ohne etwas zu speichern
        Me.Close()
    End Sub

End Class