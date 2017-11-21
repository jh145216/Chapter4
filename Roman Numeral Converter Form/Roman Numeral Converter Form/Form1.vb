Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNumber As Integer

        Try
            intNumber = txtDecimalInteger.Text
            If intNumber = 1 Then
                lblEquivalentRomanNumeral.Text = "I"
            ElseIf intNumber = 2 Then
                lblEquivalentRomanNumeral.Text = "II"
            ElseIf intNumber = 3 Then
                lblEquivalentRomanNumeral.Text = "III"
            ElseIf intNumber = 4 Then
                lblEquivalentRomanNumeral.Text = "IV"
            ElseIf intNumber = 5 Then
                lblEquivalentRomanNumeral.Text = "V"
            ElseIf intNumber = 6 Then
                lblEquivalentRomanNumeral.Text = "VI"
            ElseIf intNumber = 7 Then
                lblEquivalentRomanNumeral.Text = "VII"
            ElseIf intNumber = 8 Then
                lblEquivalentRomanNumeral.Text = "VIII"
            ElseIf intNumber = 9 Then
                lblEquivalentRomanNumeral.Text = "IX"
            ElseIf intNumber = 10 Then
                lblEquivalentRomanNumeral.Text = "X"
                lblMessage.Text = "Make sure it is between 1 and 10"
            End If
        Catch
            lblMessage.Text = "Make sure you enter a number between 1 and 10"
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblEquivalentRomanNumeral.Text = String.Empty
        lblMessage.Text = String.Empty
        txtDecimalInteger.Clear()
        txtDecimalInteger.Focus()
    End Sub
End Class
