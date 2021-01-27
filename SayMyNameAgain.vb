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
            'If Laura is entered then it will tell the user of the Tragety of Darth Plagueis The Wise
        ElseIf userInput = "Laura" Then
            Console.WriteLine(vbCrLf & "Did you ever hear the tragedy of Darth Plagueis The Wise?" & vbCrLf &
            "It's not a story the Jedi would tell you. It's a Sith legend. Darth Plagueis was a Dark" &
            "Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians" &
            "to create life… He had such a knowledge of the dark side, he could even keep the ones he cared about from dying." _
             & vbCrLf & "The dark side of the Force is a pathway to many abilities some" &
            "consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his" &
            "power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything" &
            "he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.")
        'If Anything else is entered the program will respond saying hello
        Else
            Console.WriteLine(vbCrLf & "Hello")
        End If

        Console.ReadLine()
    End Sub

End Module

'Used the following as a resource to find out how to add a line break
'https://social.msdn.microsoft.com/Forums/en-US/d9153ff8-9c1c-4f8c-8c_5a-a858cc2265b8/inserting-a-line-break-in-a-literal-string?forum=vbgeneral
'Used the following for the script of Darth Pleagueis the Wise
'https://knowyourmeme.com/memes/the-tragedy-of-darth-plagueis-the-wise