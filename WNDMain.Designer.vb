<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WNDMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LBLWelcome = New Label()
        BTNStart = New Button()
        LBLName = New Label()
        TBXName = New TextBox()
        BTNInstructions = New Button()
        BTNGuess = New Button()
        TBXInstructions = New TextBox()
        TBXGuess = New TextBox()
        BTNConfirm = New Button()
        BTNRestart = New Button()
        SuspendLayout()
        ' 
        ' LBLWelcome
        ' 
        LBLWelcome.AutoSize = True
        LBLWelcome.Font = New Font("Segoe UI", 40F)
        LBLWelcome.Location = New Point(88, 35)
        LBLWelcome.Name = "LBLWelcome"
        LBLWelcome.Size = New Size(848, 72)
        LBLWelcome.TabIndex = 0
        LBLWelcome.Text = "Bienvenue à la simulation d'un dé!"
        LBLWelcome.UseWaitCursor = True
        ' 
        ' BTNStart
        ' 
        BTNStart.Font = New Font("Segoe UI", 20F)
        BTNStart.Location = New Point(427, 400)
        BTNStart.Name = "BTNStart"
        BTNStart.Size = New Size(170, 70)
        BTNStart.TabIndex = 1
        BTNStart.Text = "Commencer"
        BTNStart.UseVisualStyleBackColor = True
        BTNStart.UseWaitCursor = True
        ' 
        ' LBLName
        ' 
        LBLName.AutoSize = True
        LBLName.Location = New Point(414, 250)
        LBLName.Name = "LBLName"
        LBLName.Size = New Size(196, 15)
        LBLName.TabIndex = 2
        LBLName.Text = "Veuillez entrer vôre nom ci-dessous:"
        LBLName.UseWaitCursor = True
        ' 
        ' TBXName
        ' 
        TBXName.Location = New Point(414, 275)
        TBXName.Name = "TBXName"
        TBXName.Size = New Size(196, 23)
        TBXName.TabIndex = 3
        TBXName.UseWaitCursor = True
        ' 
        ' BTNInstructions
        ' 
        BTNInstructions.Location = New Point(170, 250)
        BTNInstructions.Name = "BTNInstructions"
        BTNInstructions.Size = New Size(196, 131)
        BTNInstructions.TabIndex = 4
        BTNInstructions.Text = "Instructions"
        BTNInstructions.UseVisualStyleBackColor = True
        BTNInstructions.UseWaitCursor = True
        BTNInstructions.Visible = False
        ' 
        ' BTNGuess
        ' 
        BTNGuess.Location = New Point(664, 250)
        BTNGuess.Name = "BTNGuess"
        BTNGuess.Size = New Size(196, 131)
        BTNGuess.TabIndex = 5
        BTNGuess.Text = "Deviner"
        BTNGuess.UseVisualStyleBackColor = True
        BTNGuess.UseWaitCursor = True
        BTNGuess.Visible = False
        ' 
        ' TBXInstructions
        ' 
        TBXInstructions.Location = New Point(278, 286)
        TBXInstructions.Multiline = True
        TBXInstructions.Name = "TBXInstructions"
        TBXInstructions.Size = New Size(238, 73)
        TBXInstructions.TabIndex = 6
        TBXInstructions.Text = "Instructions :" & vbCrLf & "--------------" & vbCrLf & "Vous devez essayer de deviner le numéro dont le dé vas donner." & vbCrLf & vbCrLf
        TBXInstructions.UseWaitCursor = True
        TBXInstructions.Visible = False
        ' 
        ' TBXGuess
        ' 
        TBXGuess.Location = New Point(496, 155)
        TBXGuess.Name = "TBXGuess"
        TBXGuess.Size = New Size(37, 23)
        TBXGuess.TabIndex = 7
        TBXGuess.UseWaitCursor = True
        TBXGuess.Visible = False
        ' 
        ' BTNConfirm
        ' 
        BTNConfirm.Location = New Point(427, 184)
        BTNConfirm.Name = "BTNConfirm"
        BTNConfirm.Size = New Size(182, 36)
        BTNConfirm.TabIndex = 8
        BTNConfirm.Text = "Confirmer"
        BTNConfirm.UseVisualStyleBackColor = True
        BTNConfirm.UseWaitCursor = True
        BTNConfirm.Visible = False
        ' 
        ' BTNRestart
        ' 
        BTNRestart.Font = New Font("Segoe UI", 20F)
        BTNRestart.Location = New Point(405, 400)
        BTNRestart.Name = "BTNRestart"
        BTNRestart.Size = New Size(214, 70)
        BTNRestart.TabIndex = 9
        BTNRestart.Text = "Recommencer?"
        BTNRestart.UseVisualStyleBackColor = True
        BTNRestart.UseWaitCursor = True
        BTNRestart.Visible = False
        ' 
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1008, 537)
        Controls.Add(BTNRestart)
        Controls.Add(BTNConfirm)
        Controls.Add(TBXGuess)
        Controls.Add(TBXInstructions)
        Controls.Add(BTNGuess)
        Controls.Add(BTNInstructions)
        Controls.Add(TBXName)
        Controls.Add(LBLName)
        Controls.Add(BTNStart)
        Controls.Add(LBLWelcome)
        Name = "WNDMain"
        Text = "Jeu de dé"
        UseWaitCursor = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBLWelcome As Label
    Friend WithEvents BTNStart As Button
    Friend WithEvents LBLName As Label
    Friend WithEvents TBXName As TextBox
    Friend WithEvents BTNInstructions As Button
    Friend WithEvents BTNGuess As Button
    Friend WithEvents TBXInstructions As TextBox
    Friend WithEvents TBXGuess As TextBox
    Friend WithEvents BTNConfirm As Button
    Friend WithEvents BTNRestart As Button

End Class
