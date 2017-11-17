Public Class Form1

    Private Sub btnCalculateAverage_Click(sender As Object, e As EventArgs) Handles btnCalculateAverage.Click
        ' Variables to hold scores and the average score
        Dim dblScore1 As Double
        Dim dblScore2 As Double
        Dim dblScore3 As Double
        Dim dblAverage As Double

        ' Constants
        Const NUM_SCORES As Integer = 3
        Const dblHIGH_SCOES As Double = 95.0

        Try
            ' Copy the Testbox scores into the variables.
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblScore3 = CDbl(txtScore3.Text)

            ' Calculate the average score.
            dblAverage = (dblScore1 + dblScore2 + dblScore3) / NUM_SCORES

            ' Display the average, rounded to 2 decimal places.
            lblAverage.Text = dblAverage.ToString("n2")

            ' If the score is high, compliment the student.
            If dblAverage > dblHIGH_SCOES Then
                lblMessage.Text = "Congratuations! Great Job!"
            End If
        Catch
            ' Display an error message.
            lblMessage.Text = "Scores must be numeric."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblAverage.Text = String.Empty
        lblMessage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
