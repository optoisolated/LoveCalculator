Module loveCalc

    Sub Main()

        Dim loveName1 As String
        Dim loveName2 As String

        'Lets get started. Find out the names
        Console.Write("First name: ")
        loveName1 = Console.ReadLine().ToUpper.ToCharArray

        Console.Write("Second name: ")
        loveName2 = Console.ReadLine().ToUpper.ToCharArray

        Console.Clear()

        Dim cntL As Integer = 0
        Dim cntO As Integer = 0
        Dim cntV As Integer = 0
        Dim cntE As Integer = 0
        Dim cntS As Integer = 0
        Dim prev1 As Integer = 0
        Dim prev2 As Integer = 1

        'Add up each of the L,O,V,E,S characters
        For Each element In loveName1 & loveName2
            If element = "L" Then cntL += 1
            If element = "O" Then cntO += 1
            If element = "V" Then cntV += 1
            If element = "E" Then cntE += 1
            If element = "S" Then cntS += 1
        Next

        'Build the first line
        Dim loveLine1 As String = cntL & cntO & cntV & cntE & cntS

        'Present the patterrn
        Console.WriteLine(loveName1)
        Console.WriteLine("LOVES")
        Console.WriteLine(loveName2)
        Console.WriteLine()
        Console.WriteLine(loveLine1)

        Dim nextRes As String = ""
        Dim procInp As String = loveLine1

        'Repeat the counting until it's a proper percentage ( < 100 )
        While Val(procInp) > 100

            'For each number pair in the array, add the adjacent digits together,
            'And join those results into a New string
            For seg = 1 To procInp.Length - 1
                nextRes &= Val(procInp(seg - 1)) + Val(procInp(seg))
            Next

            'Print the findings (with the % and a space if it's a real result)
            If Val(nextRes) <= 100 Then
                Console.WriteLine()
                Console.WriteLine(nextRes & "%")
            Else
                Console.WriteLine(nextRes)
            End If

            'Handle endless loop by assuming 0%
            If prev2 = nextRes Then
                Console.WriteLine()

                Console.WriteLine("0% - Endless loop.")
                Exit While
            End If

            prev2 = prev1
            prev1 = nextRes
            procInp = nextRes
            nextRes = ""

        End While
        Console.WriteLine()
        Console.WriteLine("Press any key to end.")
        Console.ReadKey()

    End Sub

End Module
