Imports System

Module SimpleCalculator
    Sub Main()
        Console.Write("Enter the first number: ")
        Dim num1 As Double = Console.ReadLine()
        Console.Write("Enter the operator (+, -, *, /): ")
        Dim opt As String = Console.ReadLine()
        Console.Write("Enter the second number: ")
        Dim num2 As Double = Console.ReadLine()
        Dim result As Double
        Select Case opt
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                If num2 = 0 Then
                    Console.WriteLine("Error: Division by zero is not allowed.")
                    Return
                End If
                result = num1 / num2
            Case Else
                Console.WriteLine("Invalid operator. Please use one of +, -, *, /.")
                Return
        End Select
        Console.WriteLine("Result: " & result)
    End Sub
End Module
