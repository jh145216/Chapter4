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
        Me.ListColor = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListEst = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListNumber = New System.Windows.Forms.ListBox()
        Me.ListPluralNoun = New System.Windows.Forms.ListBox()
        Me.ListBodyPartPlural = New System.Windows.Forms.ListBox()
        Me.ListAnimal = New System.Windows.Forms.ListBox()
        Me.ListNoun = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListColor
        '
        Me.ListColor.FormattingEnabled = True
        Me.ListColor.Items.AddRange(New Object() {"Blue", "Red", "Yellow", "Green"})
        Me.ListColor.Location = New System.Drawing.Point(29, 43)
        Me.ListColor.Name = "ListColor"
        Me.ListColor.Size = New System.Drawing.Size(120, 95)
        Me.ListColor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Color"
        '
        'ListEst
        '
        Me.ListEst.FormattingEnabled = True
        Me.ListEst.Items.AddRange(New Object() {"biggest", "fattest", "fasttests", "greatest", "shorest", "roundest", "smallest", "reafforest"})
        Me.ListEst.Location = New System.Drawing.Point(186, 43)
        Me.ListEst.Name = "ListEst"
        Me.ListEst.Size = New System.Drawing.Size(120, 95)
        Me.ListEst.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Words ending inest"
        '
        'ListNumber
        '
        Me.ListNumber.FormattingEnabled = True
        Me.ListNumber.Items.AddRange(New Object() {"100", "69", "45", "12", "498", "254", "472", "154", "365"})
        Me.ListNumber.Location = New System.Drawing.Point(354, 43)
        Me.ListNumber.Name = "ListNumber"
        Me.ListNumber.Size = New System.Drawing.Size(120, 95)
        Me.ListNumber.TabIndex = 4
        '
        'ListPluralNoun
        '
        Me.ListPluralNoun.FormattingEnabled = True
        Me.ListPluralNoun.Items.AddRange(New Object() {"houses", "desks", "trees", "footballs"})
        Me.ListPluralNoun.Location = New System.Drawing.Point(29, 322)
        Me.ListPluralNoun.Name = "ListPluralNoun"
        Me.ListPluralNoun.Size = New System.Drawing.Size(120, 95)
        Me.ListPluralNoun.TabIndex = 5
        '
        'ListBodyPartPlural
        '
        Me.ListBodyPartPlural.FormattingEnabled = True
        Me.ListBodyPartPlural.Items.AddRange(New Object() {"arms", "legs", "toes", "fingers", "heads", "belly buttons", "hips"})
        Me.ListBodyPartPlural.Location = New System.Drawing.Point(29, 191)
        Me.ListBodyPartPlural.Name = "ListBodyPartPlural"
        Me.ListBodyPartPlural.Size = New System.Drawing.Size(120, 95)
        Me.ListBodyPartPlural.TabIndex = 6
        '
        'ListAnimal
        '
        Me.ListAnimal.FormattingEnabled = True
        Me.ListAnimal.Items.AddRange(New Object() {"dragon", "dog", "bear", "cat", "turtle", "monkey", "raccoon"})
        Me.ListAnimal.Location = New System.Drawing.Point(186, 191)
        Me.ListAnimal.Name = "ListAnimal"
        Me.ListAnimal.Size = New System.Drawing.Size(120, 95)
        Me.ListAnimal.TabIndex = 7
        '
        'ListNoun
        '
        Me.ListNoun.FormattingEnabled = True
        Me.ListNoun.Items.AddRange(New Object() {"house", "boat", "car", "city", "planet"})
        Me.ListNoun.Location = New System.Drawing.Point(345, 191)
        Me.ListNoun.Name = "ListNoun"
        Me.ListNoun.Size = New System.Drawing.Size(120, 95)
        Me.ListNoun.TabIndex = 8
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(211, 336)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(211, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(345, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(351, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Body Part plural"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Animal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Noun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Plural Noun"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.ListNoun)
        Me.Controls.Add(Me.ListAnimal)
        Me.Controls.Add(Me.ListBodyPartPlural)
        Me.Controls.Add(Me.ListPluralNoun)
        Me.Controls.Add(Me.ListNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListEst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListColor As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListEst As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListNumber As System.Windows.Forms.ListBox
    Friend WithEvents ListPluralNoun As System.Windows.Forms.ListBox
    Friend WithEvents ListBodyPartPlural As System.Windows.Forms.ListBox
    Friend WithEvents ListAnimal As System.Windows.Forms.ListBox
    Friend WithEvents ListNoun As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
