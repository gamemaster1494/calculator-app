Public Module clsCalculator
    Public Enum NumberOperations
        MULTIPLY
        DIVIDE
        SUBTRACT
        ADD
        NONE
    End Enum
    Private Function AddNumbers(numOne As Double, numTwo As Double) As Double
        Return numOne + numTwo
    End Function

    Private Function DivideNumbers(numOne As Double, numTwo As Double) As Double
        Return numOne / numTwo
    End Function

    Private Function SubtractNumbers(numOne As Double, numTwo As Double) As Double
        Return numOne - numTwo
    End Function

    Private Function MultiplyNumbers(numOne As Double, numTwo As Double) As Double
        Return numOne * numTwo
    End Function

    Public Function CalculateNumbers(numOne As Double, numTwo As Double, numOperator As NumberOperations) As Double
        Select Case numOperator
            Case NumberOperations.MULTIPLY
                Return MultiplyNumbers(numOne, numTwo)
            Case NumberOperations.ADD
                Return AddNumbers(numOne, numTwo)
            Case NumberOperations.DIVIDE
                Return DivideNumbers(numOne, numTwo)
            Case NumberOperations.SUBTRACT
                Return SubtractNumbers(numOne, numTwo)
            Case Else
                Return 0
        End Select
    End Function
End Module
