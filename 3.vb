Imports System
Imports System.Runtime.CompilerServices
Module Program
    Sub Main(args As String())
        Console.Write("Enter marks of ENGLISH: ")
        Dim eng As Integer = Console.ReadLine()

        Console.Write("Enter marks of HINDI: ")
        Dim hin As Integer = Console.ReadLine()

        Console.Write("Enter marks of MATHAMATICS: ")
        Dim math As Integer = Console.ReadLine()

        Dim Tmarks As Integer = eng + math + hin

        Dim Lsub As String

        Dim Lmarks As Integer = MathF.Min(eng, MathF.Min(hin, math))

        If Lmarks = hin Then
            Lsub = "HINDI"
        ElseIf Lmarks = eng Then
            Lsub = "ENHGLISH"
        Else
            Lsub = "Mathamatics"
        End If

        Console.WriteLine("Marks in English : " & eng)
        Console.WriteLine("Marks in MATHAMATICS : " & math)
        Console.WriteLine("Marks in HINDI : " & hin)
        Console.WriteLine("Total Marks : " & Tmarks)
        Console.WriteLine("Lowest Marks in : " & Lsub)
    End Sub
End Module
