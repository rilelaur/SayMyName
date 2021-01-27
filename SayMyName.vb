﻿'Laura Riley
'RCET0265
'Spring 2021
'Say My Name... Again
'https://github.com/rilelaur/SayMyName.git

Option Strict On
Option Explicit On

'The program greets the user and gives instructions
'has the user input their name and responds using their name
Module SayMyName
    
    Sub Main()
        Dim userInput As String

        Console.WriteLine("Please type your name and press 'Enter'." & vbCrLf)

        userInput = Console.ReadLine()

        If userInput = "Emily" Or userInput = "Joe" Then
            Console.WriteLine(vbCrLf & $"Hello {userInput}")
        ElseIf userInput = "Laura" Then
            Console.WriteLine(vbCrLf & $"Did you ever hear the tragedy of Darth Plagueis The Wise?")
        Else
            Console.WriteLine(vbCrLf & "You aren't authorized to read these files.")
        End If

        Console.ReadLine()
    End Sub

End Module

'Used the following as a resource to find out how to add a line break
'https://social.msdn.microsoft.com/Forums/en-US/d9153ff8-9c1c-4f8c-8c_5a-a858cc2265b8/inserting-a-line-break-in-a-literal-string?forum=vbgeneral