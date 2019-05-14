'Author:            Lan Woodall
'Date:              5/4/19
'Program Name:      Turnt
'Program Purpose:   This is a game for getting the mind up to speed. It is a simple but fast paced engagement.
'                   The user must click an image as quickly as possible with risk of the image disappearing.
'                   The time the image is present(Speed) and size of the image(Difficulty) are adjustible in Options.

'This form is where the leaderboard exists.
Imports System.Threading
Imports System
Imports System.IO
Imports System.Text

Public Class frmLeaderboard
    Dim theSoundManager As SoundManager = SoundManager.Instance

    Private Sub frmLeaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Make sure the file exists. If not, create it.
        If System.IO.File.Exists(Application.StartupPath + "/leaderboard.txt") Then
            'The file exists
        Else
            'Create the file
            File.Create(Application.StartupPath + "/leaderboard.txt")
        End If

        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath + "/leaderboard.txt")

        'List of entries from leaderboard.txt
        Dim leaderboardEntries As List(Of Entry) = New List(Of Entry)

        'Read all entries from leaderboard.txt into list
        Do While fileReader.Peek() <> -1
            'Create entry
            Dim anEntry As Entry = New Entry()
            anEntry.time = fileReader.ReadLine
            anEntry.playerName = fileReader.ReadLine

            'Add entry to the list of entries
            leaderboardEntries.Add(anEntry)
        Loop
        fileReader.Close()

        'Sort the list (sorts by entry.time ascending)
        leaderboardEntries.Sort()

        'Add all entries to the leaderboard listbox
        For index As Integer = 0 To leaderboardEntries.Count - 1
            lboxLeaderboard.Items.Add(leaderboardEntries(index).playerName.ToString + vbTab + vbTab + leaderboardEntries(index).time.ToString + "ms")
        Next
    End Sub

    'Return to main menu
    Private Sub picMainMenu_Click(sender As Object, e As EventArgs) Handles picMainMenu.Click
        frmMainMenu.Show()
        Close()
    End Sub
End Class