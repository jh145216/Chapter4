Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblBurger As Double = 5.99
        Dim dblTomato As Double = 0.5
        Dim dblFries As Double = 1.99
        Dim Total As Double
        Dim dblCheeseBurger As Double = 5.99
        Dim dblLettuce As Double = 0.5
        Dim dblBonelessMildWings As Double = 2.5
        Dim dblChickenSandwhich As Double = 4.99
        Dim dblMayo As Double = 0.5
        Dim dblOnionRings As Double = 2.5
        Dim dblHamAndTurkeySandwhich As Double = 4.99
        Dim dblJalopenos As Double = 1.0
        If rdCheeseBurger.Checked = True Then
            lblResult.Text = "You selected Cheese Burger"
            Total = dblCheeseBurger + Total
        ElseIf rdChickenSandwhich.Checked = True Then
            lblResult.Text = "You selected Chicken Sandwhich"
            Total = dblChickenSandwhich + Total
        ElseIf rdHamburger.Checked = True Then
            lblResult.Text = "You selected Hamburger"
            Total = dblBurger + Total
        ElseIf rdHamAndTurkeySandwhich.Checked = True Then
            lblResult.Text = "You selected Ham and Turkey Sandwhich"
            Total = dblHamAndTurkeySandwhich + Total
        End If

        If chkTomato.Checked = True Then
            lblResult.Text &= ", and Tomato"
            Total = dblTomato + Total
        End If

        If chkLettuce.Checked = True Then
            lblResult.Text &= ", and Lettuce"
            Total = dblCheeseBurger + Total
        End If

        If chkMayo.Checked = True Then
            lblResult.Text &= ", and Mayo"
            Total = dblMayo + Total
        End If

        If chkJalopenos.Checked = True Then
            lblResult.Text &= ", and Jalopenos"
            Total = dblJalopenos + Total
        End If

        If rdFries.Checked = True Then
            lblResult.Text &= "MMM Fries"
            Total = dblFries + Total
        End If

        If rdOnionRings.Checked = True Then
            lblResult.Text &= "MMM Onion Rings"
            Total = dblOnionRings + Total
        End If

        If rdBonelessMildWings.Checked = True Then
            lblResult.Text &= "MMM Boneless Mild Wings"
            Total = dblOnionRings + Total
        End If
        lblTotal.Text = Total.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdCheeseBurger.Checked = False
        rdChickenSandwhich.Checked = False
        rdHamburger.Checked = False
        rdHamAndTurkeySandwhich.Checked = False
        chkTomato.Checked = False
        chkLettuce.Checked = False
        chkMayo.Checked = False
        chkJalopenos.Checked = False
        rdFries.Checked = False
        rdOnionRings.Checked = False
        rdBonelessMildWings.Checked = False
        lblResult.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
