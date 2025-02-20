Public Class WNDMain
    Public PlayerName As String = "ABC" ' Player's name
    Public Guess As Integer = 99 ' Player's Guess
    Public Dice As Integer = 6 ' Dice value

    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        If Not TBXName.Text = "" Then ' Make sure the user has entered their name

            ' Hide unused elements
            LBLName.Visible = False
            TBXName.Visible = False
            BTNStart.Visible = False

            ' Store the player's name and welcome them
            PlayerName = TBXName.Text
            LBLWelcome.Text = "Bienvenue " & PlayerName & "!"

            ' Show next menu elements
            BTNInstructions.Visible = True
            BTNGuess.Visible = True
        End If
    End Sub

    Private Sub BTNInstructions_Click(sender As Object, e As EventArgs) Handles BTNInstructions.Click
        ' Show instructions
        BTNInstructions.Visible = False
        TBXInstructions.Visible = True
    End Sub

    Private Sub BTNGuess_Click(sender As Object, e As EventArgs) Handles BTNGuess.Click
        ' Show next elements for guessing
        LBLWelcome.Text = "Veuillez deviner la valeur du dé :"
        BTNInstructions.Visible = False
        TBXInstructions.Visible = False
        BTNGuess.Visible = False
        TBXGuess.Visible = True
        BTNConfirm.Visible = True
    End Sub

    Private Sub BTNConfirm_Click(sender As Object, e As EventArgs) Handles BTNConfirm.Click
        If TBXGuess.Text = "1" Or TBXGuess.Text = "2" Or TBXGuess.Text = "3" Or TBXGuess.Text = "4" Or TBXGuess.Text = "5" Or TBXGuess.Text = "6" Then ' Make sure the information in the text box is valid
            Guess = CInt(TBXGuess.Text) ' Convert guess to integer

            ' Hide unused elements
            BTNConfirm.Visible = False
            TBXGuess.Visible = False

            ' Show dice image representation
            If Guess = 1 Then

            ElseIf Guess = 2 Then

            ElseIf Guess = 3 Then

            ElseIf Guess = 4 Then

            ElseIf Guess = 5 Then

            ElseIf Guess = 6 Then

            End If
            PBXDice.Visible = True

            ' Calculate dice value
            Dice = (Rnd() * 6) + 1
            If Dice = Guess Then
                LBLWelcome.Text = "Félicitation " & PlayerName & "," & vbCrLf & "Vôtre choix est correcte!" ' Correct choice
            Else
                LBLWelcome.Text = "Désolé " & PlayerName & "," & vbCrLf & "Vôtre choix est incorrecte!" ' Incorrect choice
            End If
            BTNRestart.Visible = True ' Show restart button
        Else
            LBLHint.Visible = True ' Show answer hint
        End If
    End Sub

    Private Sub BTNRestart_Click(sender As Object, e As EventArgs) Handles BTNRestart.Click
        ' Reset enviroment
        LBLWelcome.Text = "Bienvenue à la simulation d'un dé!"
        LBLName.Visible = True
        TBXName.Text = ""
        TBXName.Visible = True
        BTNStart.Visible = True
        BTNRestart.Visible = False
        TBXGuess.Text = ""
    End Sub

    Private Sub TBXGuess_TextChanged(sender As Object, e As EventArgs) Handles TBXGuess.TextChanged
        ' Hide answer hint
        LBLHint.Visible = False
    End Sub
End Class
