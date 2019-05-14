'Author:            Lan Woodall
'Date:              5/4/19
'Program Name:      Turnt
'Program Purpose:   This is a game for getting the mind up to speed. It is a simple but fast paced engagement.
'                   The user must click an image as quickly as possible with risk of the image disappearing.
'                   The time the image is present(Speed) and size of the image(Difficulty) are adjustible in Options.

'Represents a leaderboard entry comparable by time value
Class Entry
    Implements IComparable(Of Entry)

    Public time As Integer
    Public playerName As String

    'Compares entries by time in order to allow to sort by time ascending
    Public Function CompareTo(ByVal other As Entry) As Integer Implements System.IComparable(Of Entry).CompareTo
        If (Me.time = other.time) Then
            Return 0
        ElseIf (Me.time < other.time) Then
            Return -1
        ElseIf (Me.time > other.time) Then
            Return 1
        End If
        Return 0
    End Function

End Class