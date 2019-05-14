'Author:            Lan Woodall
'Date:              5/4/19
'Program Name:      Turnt
'Program Purpose:   This is a game for getting the mind up to speed. It is a simple but fast paced engagement.
'                   The user must click an image as quickly as possible with risk of the image disappearing.
'                   The time the image is present(Speed) and size of the image(Difficulty) are adjustible in Options.

'This form is where the main menu exists.

Imports System.IO

Public Class frmMainMenu
    Dim theSoundManager As SoundManager = SoundManager.Instance


    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ensure there is a leaderboard file. If not, create one
        If System.IO.File.Exists(Application.StartupPath + "/leaderboard.txt") Then
            'The file exists
        Else
            'Create the file
            Dim fs As FileStream = File.Create(Application.StartupPath + "/leaderboard.txt")
            fs.Close()
        End If

        'Cue epic emotional ballad
        theSoundManager.wakeMeUpSound()

        'Load the frmOptionsMenu in background
        frmOptionsMenu.Show()
        frmOptionsMenu.Hide()
    End Sub

    'Starts the game
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        theSoundManager.hyuckSound()
        frmTurnt.Show()
        Hide()
    End Sub

    'Goes to options
    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        theSoundManager.hyuckSound()
        frmOptionsMenu.Show()
        Hide()
    End Sub

    'Goes to the leaderboard
    Private Sub btnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        theSoundManager.hyuckSound()
        frmLeaderboard.Show()
    End Sub

    'Exits the game
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        theSoundManager.hyuckSound()
        Close()
    End Sub
End Class
