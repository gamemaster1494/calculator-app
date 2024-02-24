Imports CalculatorApp.clsCalculator

Public Class frmMain
    Dim firstNumber As Double = 0.0
    Dim secondNumber As Double = 0.0
    Dim numOperator As NumberOperations = NumberOperations.NONE


    ''' <summary>
    ''' Used to construct the overall number. So if a user hits 1, then 0, we need it to be 10.
    ''' </summary>
    ''' <param name="number">base number to add to</param>
    ''' <param name="numberToAdd">digit to append to the end</param>
    ''' <returns></returns>
    Private Function AddDigitToNumber(number As Double, numberToAdd As Double) As Double
        Dim result As Double = number
        result *= 10
        result += numberToAdd
        Return result
    End Function

    ''' <summary>
    ''' Sets the operation to do to the numbers
    ''' </summary>
    ''' <param name="numOp"></param>
    ''' <returns></returns>
    Private Function SetNumOperator(numOp As NumberOperations)
        numOperator = numOp
    End Function

    ''' <summary>
    ''' Updates the txtScreen Text depending on certain conditions
    ''' </summary>
    ''' <returns></returns>
    Private Function UpdateScreen()
        Select Case numOperator
            Case NumberOperations.NONE
                txtScreen.Text = firstNumber
            Case NumberOperations.ADD
                If secondNumber > 0 Then
                    txtScreen.Text = secondNumber
                Else
                    txtScreen.Text = "+"
                End If
            Case NumberOperations.SUBTRACT
                If secondNumber > 0 Then
                    txtScreen.Text = secondNumber
                Else
                    txtScreen.Text = "-"
                End If
            Case NumberOperations.MULTIPLY
                If secondNumber > 0 Then
                    txtScreen.Text = secondNumber
                Else
                    txtScreen.Text = "X"
                End If
            Case NumberOperations.DIVIDE
                If secondNumber > 0 Then
                    txtScreen.Text = secondNumber
                Else
                    txtScreen.Text = "\"
                End If
        End Select
    End Function

    Private Function ClearValues()
        firstNumber = 0.0
        secondNumber = 0.0
        numOperator = NumberOperations.NONE
    End Function

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If Not numOperator.Equals(NumberOperations.NONE) Then
            txtScreen.Text = CalculateNumbers(firstNumber, secondNumber, numOperator)
            ClearValues()
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        Select Case numOperator
            Case NumberOperations.NONE
                If firstNumber > 0 Then
                    firstNumber = AddDigitToNumber(firstNumber, 0)
                End If
            Case Else
                If secondNumber > 0 Then
                    secondNumber = AddDigitToNumber(secondNumber, 0)
                End If
        End Select
        UpdateScreen()
    End Sub
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 1)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 1)
        End Select
        UpdateScreen()
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 2)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 2)
        End Select
        UpdateScreen()
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 3)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 3)
        End Select
        UpdateScreen()
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 4)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 4)
        End Select
        UpdateScreen()
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 5)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 5)
        End Select
        UpdateScreen()
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 6)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 6)
        End Select
        UpdateScreen()
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 7)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 7)
        End Select
        UpdateScreen()
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 8)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 8)
        End Select
        UpdateScreen()
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        Select Case numOperator
            Case NumberOperations.NONE
                firstNumber = AddDigitToNumber(firstNumber, 9)
            Case Else
                secondNumber = AddDigitToNumber(secondNumber, 9)
        End Select
        UpdateScreen()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateScreen()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearValues()
        UpdateScreen()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If numOperator.Equals(NumberOperations.NONE) Then
            numOperator = NumberOperations.ADD
        End If
        UpdateScreen()
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If numOperator.Equals(NumberOperations.NONE) Then
            numOperator = NumberOperations.SUBTRACT
        End If
        UpdateScreen()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If numOperator.Equals(NumberOperations.NONE) Then
            numOperator = NumberOperations.MULTIPLY
        End If
        UpdateScreen()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If numOperator.Equals(NumberOperations.NONE) Then
            numOperator = NumberOperations.DIVIDE
        End If
        UpdateScreen()
    End Sub
End Class
