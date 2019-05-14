'Author:            Lan Woodall
'Date:              5/4/19
'Program Name:      Turnt
'Program Purpose:   This is a game for getting the mind up to speed. It is a simple but fast paced engagement.
'                   The user must click an image as quickly as possible with risk of the image disappearing.
'                   The time the image is present(Speed) and size of the image(Difficulty) are adjustible in Options.

'This form is where options are modified.

Imports System.Drawing

Public Class frmOptionsMenu
    Dim theSoundManager As SoundManager = SoundManager.Instance

    Dim targets As String() = IO.Directory.GetFiles(Application.StartupPath + "/Graphics/Targets/")
    Dim numTargets As Integer = targets.Count
    Dim targetIndex As Integer = 0
    Public targetImage As Image = Image.FromFile(targets(targetIndex))


    'Adjusts scale of target in-game
    Private Sub trkbarTargetSize_Scroll(sender As Object, e As EventArgs) Handles trkbarTargetSize.Scroll
        lblTargetSize.Text = trkbarTargetSize.Value
    End Sub

    'Adjust time between target spawns in-game
    Private Sub trkbarSpeed_Scroll(sender As Object, e As EventArgs) Handles trkbarSpeed.Scroll
        lblSpeed.Text = trkbarSpeed.Value.ToString + " ms"
    End Sub


    'Cycles through avaliable target images @ executable folder / graphics / targets
    Private Sub picChangeTarget_Click(sender As Object, e As EventArgs) Handles picChangeTarget.Click

        'Make target next target in folder
        If (targetIndex + 1 < numTargets) Then
            targetIndex += 1
            targetImage = Image.FromFile(targets(targetIndex))
            picTargetPreview.Image = targetImage
        Else
            'Go back to first target
            targetIndex = 0
            targetImage = Image.FromFile(targets(targetIndex))
            picTargetPreview.Image = targetImage
        End If

    End Sub


    'Returns to main menu
    Private Sub picMainMenu_Click(sender As Object, e As EventArgs) Handles picMainMenu.Click
        theSoundManager.hyuckSound()
        frmMainMenu.Show()
        theSoundManager.wakeMeUpSound()
        Hide()
    End Sub
End Class