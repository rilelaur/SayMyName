'Laura Riley
'RCET0265
'Spring 2021
'Say My Name... Again
'https://github.com/rilelaur/SayMyName.git

Option Strict On
Option Explicit On

'The program greets the user and gives instructions
'has the user input their name and responds using their name if their name is Emily or Joe
Module SayMyNameAgain

    Sub Main()
        Dim userInput As String

        'Prompts the user to write their name
        Console.WriteLine("Please type your name and press 'Enter'." & vbCrLf)

        'Reads the users input
        userInput = Console.ReadLine()

        'The program will respond with Emily or Joe if that is entered by the user
        If userInput = "Emily" Or userInput = "Joe" Then
            Console.WriteLine(vbCrLf & $"Hello {userInput}")
            'If Laura is entered then it will ask the user the about Darth Plagueis The Wise
        ElseIf userInput = "Laura" Then
            Console.WriteLine(vbCrLf & $"Did you ever hear the tragedy of Darth Plagueis The Wise?")
            'If Anything else is entered the program will respond saying they aren't authorized
        Else
            Console.WriteLine(vbCrLf & "You aren't authorized to read these files.")
        End If

        Console.ReadLine()
    End Sub

End Module

'Used the following as a resource to find out how to add a line break
'https://social.msdn.microsoft.com/Forums/en-US/d9153ff8-9c1c-4f8c-8c_5a-a858cc2265b8/inserting-a-line-break-in-a-literal-string?forum=vbgeneral