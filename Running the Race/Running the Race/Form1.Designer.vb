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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRunnerName1 = New System.Windows.Forms.TextBox()
        Me.txtRunnerName2 = New System.Windows.Forms.TextBox()
        Me.txtRunnerName3 = New System.Windows.Forms.TextBox()
        Me.txtFinishingTime1 = New System.Windows.Forms.TextBox()
        Me.txtFinishingTime2 = New System.Windows.Forms.TextBox()
        Me.txtFinishingTime3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResult3 = New System.Windows.Forms.Label()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.lblResult1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalculateResults = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the three runners' names" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          and finishing times."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(228, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Finishing Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( in seconds)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Runner 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Runner 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Runner 3:"
        '
        'txtRunnerName1
        '
        Me.txtRunnerName1.Location = New System.Drawing.Point(108, 139)
        Me.txtRunnerName1.Name = "txtRunnerName1"
        Me.txtRunnerName1.Size = New System.Drawing.Size(100, 20)
        Me.txtRunnerName1.TabIndex = 6
        '
        'txtRunnerName2
        '
        Me.txtRunnerName2.Location = New System.Drawing.Point(108, 175)
        Me.txtRunnerName2.Name = "txtRunnerName2"
        Me.txtRunnerName2.Size = New System.Drawing.Size(100, 20)
        Me.txtRunnerName2.TabIndex = 7
        '
        'txtRunnerName3
        '
        Me.txtRunnerName3.Location = New System.Drawing.Point(108, 213)
        Me.txtRunnerName3.Name = "txtRunnerName3"
        Me.txtRunnerName3.Size = New System.Drawing.Size(100, 20)
        Me.txtRunnerName3.TabIndex = 8
        '
        'txtFinishingTime1
        '
        Me.txtFinishingTime1.Location = New System.Drawing.Point(231, 139)
        Me.txtFinishingTime1.Name = "txtFinishingTime1"
        Me.txtFinishingTime1.Size = New System.Drawing.Size(78, 20)
        Me.txtFinishingTime1.TabIndex = 9
        '
        'txtFinishingTime2
        '
        Me.txtFinishingTime2.Location = New System.Drawing.Point(231, 179)
        Me.txtFinishingTime2.Name = "txtFinishingTime2"
        Me.txtFinishingTime2.Size = New System.Drawing.Size(78, 20)
        Me.txtFinishingTime2.TabIndex = 10
        '
        'txtFinishingTime3
        '
        Me.txtFinishingTime3.Location = New System.Drawing.Point(231, 213)
        Me.txtFinishingTime3.Name = "txtFinishingTime3"
        Me.txtFinishingTime3.Size = New System.Drawing.Size(78, 20)
        Me.txtFinishingTime3.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResult3)
        Me.GroupBox1.Controls.Add(Me.lblResult2)
        Me.GroupBox1.Controls.Add(Me.lblResult1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 263)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 149)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Race Results"
        '
        'lblResult3
        '
        Me.lblResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult3.Location = New System.Drawing.Point(103, 113)
        Me.lblResult3.Name = "lblResult3"
        Me.lblResult3.Size = New System.Drawing.Size(76, 26)
        Me.lblResult3.TabIndex = 5
        '
        'lblResult2
        '
        Me.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult2.Location = New System.Drawing.Point(103, 73)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(76, 26)
        Me.lblResult2.TabIndex = 4
        '
        'lblResult1
        '
        Me.lblResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult1.Location = New System.Drawing.Point(103, 29)
        Me.lblResult1.Name = "lblResult1"
        Me.lblResult1.Size = New System.Drawing.Size(76, 25)
        Me.lblResult1.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "3rd Place:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "2nd Place:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "1st Place:"
        '
        'btnCalculateResults
        '
        Me.btnCalculateResults.Location = New System.Drawing.Point(43, 434)
        Me.btnCalculateResults.Name = "btnCalculateResults"
        Me.btnCalculateResults.Size = New System.Drawing.Size(75, 35)
        Me.btnCalculateResults.TabIndex = 13
        Me.btnCalculateResults.Text = "Calculate Results"
        Me.btnCalculateResults.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(150, 434)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(248, 434)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 481)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFinishingTime3)
        Me.Controls.Add(Me.txtFinishingTime2)
        Me.Controls.Add(Me.txtFinishingTime1)
        Me.Controls.Add(Me.txtRunnerName3)
        Me.Controls.Add(Me.txtRunnerName2)
        Me.Controls.Add(Me.txtRunnerName1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Race Results"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRunnerName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunnerName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunnerName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishingTime1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishingTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishingTime3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblResult3 As System.Windows.Forms.Label
    Friend WithEvents lblResult2 As System.Windows.Forms.Label
    Friend WithEvents lblResult1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateResults As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
