Imports System
Module Program
    Sub Main(args As String())
        Console.Write("Enter a number: ")
        Dim input As Integer = Console.ReadLine()
        Console.WriteLine("Square of " & input & " = " & Math.Pow(input, 2))
        Console.WriteLine("cube of " & input & " = " & Math.Pow(input, 3))
    End Sub
End Module
