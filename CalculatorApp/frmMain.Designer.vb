<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        btnZero = New Button()
        btnNine = New Button()
        btnEight = New Button()
        btnSeven = New Button()
        btnSix = New Button()
        btnFive = New Button()
        btnFour = New Button()
        btnThree = New Button()
        btnTwo = New Button()
        btnDivide = New Button()
        btnMultiply = New Button()
        btnSubtract = New Button()
        btnAdd = New Button()
        btnDecimal = New Button()
        btnEqual = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(33, 35)
        Button1.TabIndex = 0
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnZero
        ' 
        btnZero.Location = New Point(51, 164)
        btnZero.Name = "btnZero"
        btnZero.Size = New Size(33, 35)
        btnZero.TabIndex = 1
        btnZero.Text = "0"
        btnZero.UseVisualStyleBackColor = True
        ' 
        ' btnNine
        ' 
        btnNine.Location = New Point(90, 42)
        btnNine.Name = "btnNine"
        btnNine.Size = New Size(33, 35)
        btnNine.TabIndex = 2
        btnNine.Text = "9"
        btnNine.UseVisualStyleBackColor = True
        ' 
        ' btnEight
        ' 
        btnEight.Location = New Point(51, 42)
        btnEight.Name = "btnEight"
        btnEight.Size = New Size(33, 35)
        btnEight.TabIndex = 3
        btnEight.Text = "8"
        btnEight.UseVisualStyleBackColor = True
        ' 
        ' btnSeven
        ' 
        btnSeven.Location = New Point(12, 41)
        btnSeven.Name = "btnSeven"
        btnSeven.Size = New Size(33, 35)
        btnSeven.TabIndex = 4
        btnSeven.Text = "7"
        btnSeven.UseVisualStyleBackColor = True
        ' 
        ' btnSix
        ' 
        btnSix.Location = New Point(90, 83)
        btnSix.Name = "btnSix"
        btnSix.Size = New Size(33, 35)
        btnSix.TabIndex = 5
        btnSix.Text = "6"
        btnSix.UseVisualStyleBackColor = True
        ' 
        ' btnFive
        ' 
        btnFive.Location = New Point(51, 83)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(33, 35)
        btnFive.TabIndex = 6
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = True
        ' 
        ' btnFour
        ' 
        btnFour.Location = New Point(12, 82)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(33, 35)
        btnFour.TabIndex = 7
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        ' 
        ' btnThree
        ' 
        btnThree.Location = New Point(90, 123)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(33, 35)
        btnThree.TabIndex = 8
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        ' 
        ' btnTwo
        ' 
        btnTwo.Location = New Point(51, 123)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(33, 35)
        btnTwo.TabIndex = 9
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(129, 42)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(33, 35)
        btnDivide.TabIndex = 10
        btnDivide.Text = "\"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(129, 82)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(33, 35)
        btnMultiply.TabIndex = 11
        btnMultiply.Text = "X"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(129, 123)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(33, 35)
        btnSubtract.TabIndex = 12
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(129, 164)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(33, 35)
        btnAdd.TabIndex = 13
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDecimal
        ' 
        btnDecimal.Location = New Point(90, 164)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(33, 35)
        btnDecimal.TabIndex = 14
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = True
        ' 
        ' btnEqual
        ' 
        btnEqual.Location = New Point(12, 164)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(33, 35)
        btnEqual.TabIndex = 15
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 23)
        TextBox1.TabIndex = 16
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(179, 218)
        Controls.Add(TextBox1)
        Controls.Add(btnEqual)
        Controls.Add(btnDecimal)
        Controls.Add(btnAdd)
        Controls.Add(btnSubtract)
        Controls.Add(btnMultiply)
        Controls.Add(btnDivide)
        Controls.Add(btnTwo)
        Controls.Add(btnThree)
        Controls.Add(btnFour)
        Controls.Add(btnFive)
        Controls.Add(btnSix)
        Controls.Add(btnSeven)
        Controls.Add(btnEight)
        Controls.Add(btnNine)
        Controls.Add(btnZero)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmMain"
        Text = "My First Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents TextBox1 As TextBox

End Class
