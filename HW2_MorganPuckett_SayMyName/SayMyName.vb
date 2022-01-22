'Morgan Puckett
'RCET0265
'Spring 2022
'Say my name 
'https://github.com/Morgan-Puckett/HW2_MorganPuckett_SayMyName.git

Option Explicit On
Option Strict On
Module SayMyName
    Sub Main()
        Dim response As String
        Console.WriteLine("Hello, can I get your name please?")
        response = Console.ReadLine()
        Console.WriteLine($"So {response}, it looks like you're not on the list... I'm going to have to ask you to leave.")
        Console.ReadLine()
    End Sub

End Module
