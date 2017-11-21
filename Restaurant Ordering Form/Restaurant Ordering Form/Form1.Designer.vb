<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkJalopenos = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.rdHamburger = New System.Windows.Forms.RadioButton()
        Me.rdCheeseBurger = New System.Windows.Forms.RadioButton()
        Me.rdChickenSandwhich = New System.Windows.Forms.RadioButton()
        Me.rdHamAndTurkeySandwhich = New System.Windows.Forms.RadioButton()
        Me.rdFries = New System.Windows.Forms.RadioButton()
        Me.rdOnionRings = New System.Windows.Forms.RadioButton()
        Me.rdBonelessMildWings = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdHamAndTurkeySandwhich)
        Me.GroupBox1.Controls.Add(Me.rdChickenSandwhich)
        Me.GroupBox1.Controls.Add(Me.rdCheeseBurger)
        Me.GroupBox1.Controls.Add(Me.rdHamburger)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 180)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Yout Meal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkJalopenos)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(203, 180)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'chkJalopenos
        '
        Me.chkJalopenos.AutoSize = True
        Me.chkJalopenos.Location = New System.Drawing.Point(57, 145)
        Me.chkJalopenos.Name = "chkJalopenos"
        Me.chkJalopenos.Size = New System.Drawing.Size(74, 17)
        Me.chkJalopenos.TabIndex = 3
        Me.chkJalopenos.Text = "Jalopenos"
        Me.chkJalopenos.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(57, 110)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(57, 78)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(57, 39)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdBonelessMildWings)
        Me.GroupBox3.Controls.Add(Me.rdOnionRings)
        Me.GroupBox3.Controls.Add(Me.rdFries)
        Me.GroupBox3.Location = New System.Drawing.Point(309, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 148)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Order"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(28, 369)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'rdHamburger
        '
        Me.rdHamburger.AutoSize = True
        Me.rdHamburger.Location = New System.Drawing.Point(31, 38)
        Me.rdHamburger.Name = "rdHamburger"
        Me.rdHamburger.Size = New System.Drawing.Size(77, 17)
        Me.rdHamburger.TabIndex = 0
        Me.rdHamburger.TabStop = True
        Me.rdHamburger.Text = "Hamburger"
        Me.rdHamburger.UseVisualStyleBackColor = True
        '
        'rdCheeseBurger
        '
        Me.rdCheeseBurger.AutoSize = True
        Me.rdCheeseBurger.Location = New System.Drawing.Point(31, 78)
        Me.rdCheeseBurger.Name = "rdCheeseBurger"
        Me.rdCheeseBurger.Size = New System.Drawing.Size(95, 17)
        Me.rdCheeseBurger.TabIndex = 1
        Me.rdCheeseBurger.TabStop = True
        Me.rdCheeseBurger.Text = "Cheese Burger"
        Me.rdCheeseBurger.UseVisualStyleBackColor = True
        '
        'rdChickenSandwhich
        '
        Me.rdChickenSandwhich.AutoSize = True
        Me.rdChickenSandwhich.Location = New System.Drawing.Point(31, 109)
        Me.rdChickenSandwhich.Name = "rdChickenSandwhich"
        Me.rdChickenSandwhich.Size = New System.Drawing.Size(120, 17)
        Me.rdChickenSandwhich.TabIndex = 2
        Me.rdChickenSandwhich.TabStop = True
        Me.rdChickenSandwhich.Text = "Chicken Sandwhich"
        Me.rdChickenSandwhich.UseVisualStyleBackColor = True
        '
        'rdHamAndTurkeySandwhich
        '
        Me.rdHamAndTurkeySandwhich.AutoSize = True
        Me.rdHamAndTurkeySandwhich.Location = New System.Drawing.Point(31, 145)
        Me.rdHamAndTurkeySandwhich.Name = "rdHamAndTurkeySandwhich"
        Me.rdHamAndTurkeySandwhich.Size = New System.Drawing.Size(160, 17)
        Me.rdHamAndTurkeySandwhich.TabIndex = 3
        Me.rdHamAndTurkeySandwhich.TabStop = True
        Me.rdHamAndTurkeySandwhich.Text = "Ham and Turkey Sandwhich"
        Me.rdHamAndTurkeySandwhich.UseVisualStyleBackColor = True
        '
        'rdFries
        '
        Me.rdFries.AutoSize = True
        Me.rdFries.Location = New System.Drawing.Point(57, 34)
        Me.rdFries.Name = "rdFries"
        Me.rdFries.Size = New System.Drawing.Size(47, 17)
        Me.rdFries.TabIndex = 0
        Me.rdFries.TabStop = True
        Me.rdFries.Text = "Fries"
        Me.rdFries.UseVisualStyleBackColor = True
        '
        'rdOnionRings
        '
        Me.rdOnionRings.AutoSize = True
        Me.rdOnionRings.Location = New System.Drawing.Point(57, 71)
        Me.rdOnionRings.Name = "rdOnionRings"
        Me.rdOnionRings.Size = New System.Drawing.Size(83, 17)
        Me.rdOnionRings.TabIndex = 1
        Me.rdOnionRings.TabStop = True
        Me.rdOnionRings.Text = "Onion Rings"
        Me.rdOnionRings.UseVisualStyleBackColor = True
        '
        'rdBonelessMildWings
        '
        Me.rdBonelessMildWings.AutoSize = True
        Me.rdBonelessMildWings.Location = New System.Drawing.Point(57, 111)
        Me.rdBonelessMildWings.Name = "rdBonelessMildWings"
        Me.rdBonelessMildWings.Size = New System.Drawing.Size(123, 17)
        Me.rdBonelessMildWings.TabIndex = 2
        Me.rdBonelessMildWings.TabStop = True
        Me.rdBonelessMildWings.Text = "Boneless Mild Wings"
        Me.rdBonelessMildWings.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(28, 244)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(254, 51)
        Me.lblResult.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(156, 369)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(28, 315)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(108, 35)
        Me.lblTotal.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 404)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Applebees"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkJalopenos As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents rdHamAndTurkeySandwhich As System.Windows.Forms.RadioButton
    Friend WithEvents rdChickenSandwhich As System.Windows.Forms.RadioButton
    Friend WithEvents rdCheeseBurger As System.Windows.Forms.RadioButton
    Friend WithEvents rdHamburger As System.Windows.Forms.RadioButton
    Friend WithEvents rdBonelessMildWings As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnionRings As System.Windows.Forms.RadioButton
    Friend WithEvents rdFries As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
