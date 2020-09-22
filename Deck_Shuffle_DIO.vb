'D. Ivan Ochoa
'RCET0265
'Fall 2020
'Deck_shuffle
'https://github.com/ochodieg/Deck_Shuffle_DIO
Module Deck_Shuffle_DIO

    Sub Main()

        Dim card_Type As String

        Dim card_Type_2 As String

        Dim card_Number As String

        Dim Column1 As Integer

        Dim Row1 As Integer

        Dim row As Integer = 12

        Dim column As Integer = 3

        Dim Array(row, column) As Boolean

        Dim daGewds As Boolean

        Dim given_Card As Integer


        Randomize(
            )

        Do

            Console.WriteLine("Press enter for card. 
Type ''shuffle'' to shuffle the deck (no caps).
Type shift + Q to quit. ")

            given_Card += 1

            Console.WriteLine(StrDup(4, vbTab) & "Received " & given_Card & " cards"
                              )

            daGewds = False

            Do Until daGewds = True

                Column1 = CInt(Int((4 * Rnd())))

                Row1 = CInt(Int((13 * Rnd())))

                If Not Array(Row1, Column1) = True Then

                    Array(Row1, Column1) = True

                    daGewds = True

                ElseIf daGewds = False Then

                End If

            Loop



            card_Number = CStr(Row1 + 1)

            If card_Number = "13" Then

                card_Type = "Jack"

            ElseIf card_Number = "11" Then

                card_Type = "Ace"

            ElseIf card_Number = "12" Then

                card_Type = "Queen"

            ElseIf card_Number = "1" Then

                card_Type = "King"




            Else card_Type = card_Number

            End If


            If Column1 = 0 Then

                card_Type_2 = "Spades"

            ElseIf Column1 = 1 Then

                card_Type_2 = "Diamonds"

            ElseIf Column1 = 2 Then

                card_Type_2 = "Hearts"

            ElseIf Column1 = 3 Then

                card_Type_2 = "Clubs"

            End If

            Console.WriteLine(card_Type & " Of " & card_Type_2)

            If given_Card = 50 Then

                Console.WriteLine(StrDup(4, vbTab) & "Cards Shuffled"
                                  )
                For row = 0 To 12

                    For column = 0 To 3

                        Array(row, column) = False
                    Next

                    given_Card = 0

                Next

            Else

            End If

            Select Case Console.ReadLine(
                )

                Case "Q"

                    Exit Sub

                Case "shuffle"

                    Console.WriteLine(StrDup(4, vbTab) & "Cards Shuffled")

                    For row = 0 To 12

                        For column = 0 To 3

                            Array(row, column) = False

                        Next

                        given_Card = 0

                    Next

                    Console.ReadLine()

            End Select

            Console.Clear()

        Loop

    End Sub

End Module







