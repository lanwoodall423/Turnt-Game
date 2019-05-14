'Author:            Lan Woodall
'Date:              5/4/19
'Program Name:      Turnt
'Program Purpose:   This is a game for getting the mind up to speed. It is a simple but fast paced engagement.
'                   The user must click an image as quickly as possible with risk of the image disappearing.
'                   The time the image is present(Speed) and size of the image(Difficulty) are adjustible in Options.

'This form is where the game occurs. 

Imports System.Threading
Imports System
Imports System.IO
Imports System.Text

Public Class frmTurnt
    Dim theSoundManager As SoundManager = SoundManager.Instance

    Private Declare Function GetTickCount Lib "kernel32" () As Long

    Dim random As New Random

    'Track accuracy
    Dim hits As List(Of Integer) = New List(Of Integer)
    Dim misses As Integer
    Dim accuracy As Double

    'Values taken from options
    Public targetScale As Integer
    Public speed As Integer


    Private Sub frmTurnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get values from options
        speed = frmOptionsMenu.trkbarSpeed.Value
        targetScale = frmOptionsMenu.trkbarTargetSize.Value
        'Display values from options
        lblTargetSize.Text = targetScale
        lblSpeed.Text = speed.ToString + " ms"

        'Set the proper Target Image
        picTarget.Image = frmOptionsMenu.targetImage

        'Scale the target appropriately
        picTarget.Size = New Size(picTarget.Width * targetScale, picTarget.Height * targetScale)
        picTarget.Visible = False
    End Sub



    'Begins the game
    Private Sub picClickHereToBegin_Click(sender As Object, e As EventArgs) Handles picClickHereToBegin.Click
        'Hide the button
        picClickHereToBegin.Visible = False

        'Enables the ability to miss
        picMiss.Enabled = True

        'Places the target
        moveTarget()
    End Sub



    'Successful target click
    Private Sub picTarget_Click(sender As Object, e As EventArgs) Handles picTarget.Click
        'Record time
        Dim hitTime = getTime()
        hits.Add(hitTime)

        'Indicate click
        theSoundManager.hyuckSound()
        picTarget.Visible = False

        'Update Stats
        updateStats()

        'Move
        moveTarget()
    End Sub


    'Unsuccessful target click
    Private Sub picMiss_Click(sender As Object, e As EventArgs) Handles picMiss.Click
        'Indicate click (indicate miss?)
        theSoundManager.hyuckSound()
        picTarget.Visible = False

        'Record miss
        misses += 1

        'Update Stats
        updateStats()

        'Move
        moveTarget()
    End Sub



    'This sub waits the designated amount of time then moves the target and begins the timer
    Private Sub moveTarget()
        picTarget.Visible = False

        'Random time wait
        wait(speed)

        'Place target at random location (with padding on all sides of window that scales with target scale)
        picTarget.Left = random.Next((Size.Width * (targetScale / 1.5 / 10)) - picTarget.Width / 2, (Size.Width * (1 - (targetScale / 1.5 / 10))) - picTarget.Width / 2)
        picTarget.Top = random.Next((Size.Height * (targetScale / 1.5 / 10)) - picTarget.Height / 2, (Size.Height * (1 - (targetScale / 1.5 / 10))) - picTarget.Height / 2)

        picTarget.Visible = True

        StartTiming()
    End Sub



    'Waits for a given number of milliseconds without halting thread or causing high CPU usage
    'https://stackoverflow.com/questions/15857893/wait-5-seconds-before-continuing-code-vb-net
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds / 10
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub



    'Records the start time (milliseconds since Windows has started) 
    Private startTime As Long

    Private Sub StartTiming()
        startTime = GetTickCount()
    End Sub



    'Returns time since startTime() in truncated milliseconds
    Private Function getTime() As Single
        Dim StopTime As Long
        StopTime = GetTickCount()
        getTime = Math.Truncate((StopTime - startTime))
    End Function



    'This sub calculates stats and updates their labels
    Private Sub updateStats()
        If (Not (hits.Count = 0)) Then
            lblLastHit.Text = hits.Last.ToString + "ms"
            lblAvgDelayValue.Text = Math.Truncate(hits.Average).ToString + "ms"
        End If
        lblAccuracyValue.Text = Math.Truncate((hits.Count / (hits.Count + misses)) * 100).ToString + "%"
        lblHitsValue.Text = hits.Count.ToString + "/" + (hits.Count + misses).ToString
    End Sub


    'Reveals the save widgets
    Private Sub picSaveToLeaderboard_Click(sender As Object, e As EventArgs) Handles picSaveToLeaderboard.Click
        theSoundManager.hyuckSound()
        picSave.Visible = True
        lblName.Visible = True
        tboxName.Visible = True
    End Sub


    'Hides the save widgets and records to the leaderboard
    Private Sub picSave_Click(sender As Object, e As EventArgs) Handles picSave.Click
        theSoundManager.goofyYellSound()
        recordToLeaderboard()
        picSave.Visible = False
        lblName.Visible = False
        tboxName.Visible = False
    End Sub


    'Writes the supplied name and average ms delay to the leaderboard. Writes 99999999 for cheaters
    Sub recordToLeaderboard()
        Dim leaderboard As System.IO.StreamWriter

        'Write score
        leaderboard = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath + "/leaderboard.txt", True)
        If (hits.Count > 0) Then
            leaderboard.WriteLine(Math.Truncate(hits.Average).ToString)
        Else
            leaderboard.WriteLine("99999999")
        End If

        'Write name
        leaderboard.WriteLine(tboxName.Text)

        leaderboard.Close()
    End Sub




    'This sub returns the user to the main menu.
    Private Sub picMainMenu_Click(sender As Object, e As EventArgs) Handles picMainMenu.Click
        theSoundManager.hyuckSound()
        frmMainMenu.Show()
        theSoundManager.wakeMeUpSound()
        Close()
    End Sub

End Class