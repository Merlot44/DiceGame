Public Class WNDMain
    Public PlayerName As String = "ABC" ' Player's name
    Public Guess As Integer = 99 ' Player's Guess
    Public Dice As Integer = 6 ' Dice value
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        If Not TBXName.Text = "" Then ' Make sure the user has entered their name
            LBLName.Visible = False ' Hide the name label
            TBXName.Visible = False ' Hide the name text box
            BTNStart.Visible = False ' Hide the start button textbox
            PlayerName = TBXName.Text
            LBLWelcome.Text = "Bienvenue " & PlayerName & "!"
            BTNInstructions.Visible = True
            BTNGuess.Visible = True
        End If
    End Sub

    Private Sub BTNInstructions_Click(sender As Object, e As EventArgs) Handles BTNInstructions.Click
        BTNInstructions.Visible = False
        TBXInstructions.Visible = True
    End Sub

    Private Sub BTNGuess_Click(sender As Object, e As EventArgs) Handles BTNGuess.Click
        LBLWelcome.Text = "Veuillez deviner la valeur du dé :"
        BTNInstructions.Visible = False
        TBXInstructions.Visible = False
        BTNGuess.Visible = False
        TBXGuess.Visible = True
        BTNConfirm.Visible = True
    End Sub

    Private Sub BTNConfirm_Click(sender As Object, e As EventArgs) Handles BTNConfirm.Click
        If Not TBXGuess.Text = "" Then
            Guess = CInt(TBXGuess.Text)
            BTNConfirm.Visible = False
            TBXGuess.Visible = False

            ' Calculate dice value
            Dice = (Rnd() * 6) + 1
            If Dice = Guess Then
                LBLWelcome.Text = "Félicitation " & PlayerName & "," & vbCrLf & "Vôtre choix est correcte!"
            Else
                LBLWelcome.Text = "Désolé " & PlayerName & "," & vbCrLf & "Vôtre choix est incorrecte!"
            End If
            BTNRestart.Visible = True
        End If
    End Sub

    Private Sub BTNRestart_Click(sender As Object, e As EventArgs) Handles BTNRestart.Click
        LBLWelcome.Text = "Bienvenue à la simulation d'un dé!"
        LBLName.Visible = True
        TBXName.Text = ""
        TBXName.Visible = True
        BTNStart.Visible = True
        BTNRestart.Visible = False
        TBXGuess.Text = ""
    End Sub
End Class
