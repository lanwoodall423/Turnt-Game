Public Class SoundManager

    'Singleton https://stackoverflow.com/questions/3319108/singleton-pattern-in-vb
    Private Shared ReadOnly _instance As New Lazy(Of SoundManager)(Function() New SoundManager(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As SoundManager
        Get
            Return _instance.Value
        End Get
    End Property


    'Each method is responsible for playing a different sound

    Public Sub wakeMeUpSound()
        Dim media As New Media.SoundPlayer(Application.StartupPath + "/Sounds/WakeMeUp.wav")
        media.Play() ' Async, creates a new thread
    End Sub

    Public Sub hyuckSound()
        Dim media As New Media.SoundPlayer(Application.StartupPath + "/Sounds/Hyuck.wav")
        media.Play() ' Async, creates a new thread
    End Sub

    Public Sub goofyYellSound()
        Dim media As New Media.SoundPlayer(Application.StartupPath + "/Sounds/GoofyYell.wav")
        media.Play() ' Async, creates a new thread
    End Sub


End Class
