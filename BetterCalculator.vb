Option Explicit On
Option Strict On

Module BetterCalculator

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String
        Dim firstNumberValid As Boolean = False
        Dim secondNumberValid As Boolean = False
        Dim validOption As Boolean = False

        Do
            Console.WriteLine("Please, enter first number")
            userInput = Console.ReadLine()

            Try
                firstNumber = CInt(userInput)
                firstNumberValid = True
            Catch ex As Exception
                Console.WriteLine($"You entered {userInput}, please enter a whole number")
            End Try
        Loop While firstNumberValid = False

        Do
            Console.WriteLine("Please, enter second number")
            userInput = Console.ReadLine()

            Try
                secondNumber = CInt(userInput)
                secondNumberValid = True
            Catch ex As Exception
                Console.WriteLine($"You entered {userInput}, please enter a whole number")
            End Try
        Loop Until secondNumberValid = True

        Do
            Console.WriteLine("Please, choose an option:" & vbNewLine _
            & "1. Add" & vbNewLine _
            & "2. Multiply" & vbNewLine _
            & "Q to Quit" & vbNewLine
            )
            userInput = Console.ReadLine()

            If userInput = "Q" Then
                Console.WriteLine("See you next time!")
                validOption = True
            ElseIf userInput = "1" Then
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
                validOption = True
            ElseIf userInput = "2" Then
                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
                validOption = True
            Else
                Console.WriteLine($"You entered {userInput}. Please enter a valid number.")
            End If

        Loop Until validOption = True

        Console.Read()
    End Sub

End Module
