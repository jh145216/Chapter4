Public Class Form1

    Private Sub btnCalculateResults_Click(sender As Object, e As EventArgs) Handles btnCalculateResults.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = txtFinishingTime1.Text
        dblTime2 = txtFinishingTime2.Text
        dblTime3 = txtFinishingTime3.Text

        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lblResult1.Text = txtRunnerName1.Text
            If dblTime2 < dblTime3 Then
                lblResult2.Text = txtRunnerName2.Text
                lblResult3.Text = txtRunnerName3.Text
            ElseIf dblTime3 < dblTime2 Then
                lblResult2.Text = txtRunnerName3.Text
                lblResult3.Text = txtRunnerName2.Text
            End If
        End If

        If dblTime2 < dblTime1 And dblTime2 < dblTime1 Then
            lblResult1.Text = txtRunnerName2.Text
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRunnerName1.Clear()
        txtRunnerName2.Clear()
        txtRunnerName3.Clear()
        txtFinishingTime1.Clear()
        txtFinishingTime2.Clear()
        txtFinishingTime3.Clear()
        lblResult1.Text = String.Empty
        lblResult2.Text = String.Empty
        lblResult3.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
