Module Module1

    Sub Main()
        Dim x As Decimal
        Dim y As Decimal
        Dim func As String
        While func <> "q"
            Console.WriteLine("First Number")
            x = Console.ReadLine()
            Console.WriteLine("Which Function: + - * / ^ (R)ound (T)runcate \ (M)od")
            func = Console.ReadLine()
            If (func <> "R" And func <> "T") Then
                Console.WriteLine("Second Number")
                y = Console.ReadLine()
            End If
            Console.WriteLine("Result = ")

            Select Case func
                Case "+"
                    Console.WriteLine(x & " + " & y & " = " & x + y)
                Case "-"
                    Console.WriteLine(x - y)
                Case "*"
                    Console.WriteLine(x * y)
                Case "/"
                    Console.WriteLine(x / y)
                Case "^"
                    Console.WriteLine(x ^ y)
                Case "R"
                    Console.WriteLine(Math.Round(x))
                Case "T"
                    Console.WriteLine(Math.Truncate(x))
                Case "\"
                    Console.WriteLine(x \ y)
                Case "M"
                    Console.WriteLine(x Mod y)
            End Select

        End While
        Console.ReadLine()
    End Sub

End Module