Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String ' Hold selected from the list boxes

        If ListColor.SelectedIndex = -1 Then
            MessageBox.Show("Select a color.")
        ElseIf ListEst.SelectedIndex = -1 Then
            MessageBox.Show("No word ending in EST was selected.")
        End If

        strInput = ListColor.SelectedItem.ToString() &
            ListEst.SelectedItem.ToString() & " Dragon of all. It has " & ListNumber.SelectedItem.ToString() &
            " " & ListBodyPartPlural.SelectedItem.ToString() & ", and a " &
            ListAnimal.SelectedItem.ToString() & " shaped like a " & ListNoun.SelectedItem.ToString() & " It loves to eat" &
            ListPluralNoun.SelectedItem.ToString()

        MessageBox.Show("The " & strInput & ", although it will feast on nearily anything.")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListColor.SelectedIndex = -1
        ListEst.SelectedIndex = -1
        ListNumber.SelectedIndex = -1
        ListBodyPartPlural.SelectedIndex = -1
        ListAnimal.SelectedIndex = -1
        ListNoun.SelectedIndex = -1
        ListPluralNoun.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
