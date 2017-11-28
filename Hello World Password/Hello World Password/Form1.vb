Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblPassword As Double

        Try
            dblPassword = txtPassword.Text

            If dblPassword Then
                lblResult.Text = "Correct Passwword"
            ElseIf dblPassword Then
                lblResult.Text = "Incorrect Password"
            End If
        Catch
            lblMessage.Text = "Enter Corect Password"
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Clear()
        lblResult.Text = String.Empty
        lblMessage.Text = String.Empty
    End Sub
End Class

