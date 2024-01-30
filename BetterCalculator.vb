'Rahiel Rodriguez
'RCET0265
'Spring 2024
'Better Calculator
'https://github.com/rahielrodriguez/BetterCalculator.git

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
        Dim quit As Boolean = False

        Do
            Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")

            Do Until firstNumberValid = True Or quit = True
                userInput = Console.ReadLine()
                Try
                    firstNumber = CInt(userInput)
                    firstNumberValid = True
                Catch ex As Exception
                    If userInput = "q" Or userInput = "Q" Then
                        quit = True
                    Else
                        Console.WriteLine($"You entered {userInput}, please enter a whole number")
                    End If

                End Try

            Loop

            Do Until secondNumberValid = True Or quit = True

                Console.WriteLine("Please, enter second number. Press Q any time to quit.")
                userInput = Console.ReadLine()

                Try
                    secondNumber = CInt(userInput)
                    secondNumberValid = True
                Catch ex As Exception
                    If userInput = "q" Or userInput = "Q" Then
                        quit = True
                    Else
                        Console.WriteLine($"You entered {userInput}, please enter a whole number")
                    End If

                End Try

            Loop

            Do Until validOption = True Or quit = True
                Console.WriteLine("Please, choose an option:" & vbNewLine _
                    & "1. Add" & vbNewLine _
                    & "2. Subtract" & vbNewLine _
                    & "3. Multiply" & vbNewLine _
                    & "4. Divide" & vbNewLine _
                    & "Q to Quit" & vbNewLine
                    )
                userInput = Console.ReadLine()

                If userInput = "q" Or userInput = "Q" Then
                    quit = True
                ElseIf userInput = "1" Then
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
                    validOption = True
                ElseIf userInput = "2" Then
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
                    validOption = True
                ElseIf userInput = "3" Then
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
                    validOption = True
                ElseIf userInput = "4" Then
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
                    validOption = True
                Else
                    Console.WriteLine($"You entered {userInput}.")
                End If

            Loop

            firstNumberValid = False
            secondNumberValid = False
            validOption = False

        Loop Until quit = True

        Console.WriteLine("You entered ""Q""" & vbNewLine _
                          & "Have a nice day" & vbNewLine _
                          & "Press enter to close this window")

        Console.Read()

    End Sub

End Module