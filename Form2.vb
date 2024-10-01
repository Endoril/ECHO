Public Class FormEinnahmeHinzufügen

    ' Klick-Event für den Speichern-Button im modalen Fenster
    Private Sub BtnSpeichern_Click(sender As Object, e As EventArgs) Handles BtnSpeichern.Click
        Dim betrag As Decimal

        ' Versuchen, den Text in TxtBetrag in eine Dezimalzahl zu konvertieren
        If Decimal.TryParse(TxtBetrag.Text, betrag) Then
            ' Überprüfen, ob es maximal 2 Nachkommastellen gibt
            Dim splitBetrag As String() = TxtBetrag.Text.Split(","c)

            ' Überprüfen, ob der Vorkomma-Teil maximal 7 Ziffern enthält
            If splitBetrag(0).Length <= 7 AndAlso (splitBetrag.Length = 1 OrElse splitBetrag(1).Length = 2) Then
                ' Betrag ist gültig, jetzt kannst du ihn speichern
                MessageBox.Show("Eingabe ist gültig! Betrag: " & betrag.ToString())
                ' Hier kommt der Code zum Speichern der Daten hin
            Else
                ' Fehler: Zu viele Vorkommastellen oder falsche Anzahl Nachkommastellen
                MessageBox.Show("Bitte gib einen Betrag mit maximal 7 Vorkommastellen und genau 2 Nachkommastellen ein.")
            End If
        Else
            ' Fehler: Keine gültige Zahl
            MessageBox.Show("Bitte gib einen gültigen Betrag ein.")
        End If
    End Sub

    ' Klick-Event für den Abbrechen-Button im modalen Fenster
    Private Sub BtnAbbrechen_Click(sender As Object, e As EventArgs) Handles BtnAbbrechen.Click
        ' Schließe das modale Fenster, ohne etwas zu speichern
        Me.Close()
    End Sub

End Class

