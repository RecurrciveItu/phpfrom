Imports System

Module SimpleCalculator
    Sub Main()
        Console.Write("Enter a Character: ")
        Dim character As String = Console.ReadLine()
        Dim vowel As String = "aioue"
        If vowel.Contains(character) Then
            Console.WriteLine("The character " & character & " is a vowel.")
        Else
            Console.WriteLine("The Character " & character & " is not a vowel")
        End If
    End Sub
End Module
