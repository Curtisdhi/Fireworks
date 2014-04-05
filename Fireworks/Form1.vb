Public Class Form1

    Public Shared COLORS() As Color = {Color.Red, Color.Pink,
        Color.RoyalBlue, Color.Yellow, Color.Snow, Color.Purple,
        Color.ForestGreen, Color.FloralWhite, Color.DarkTurquoise,
        Color.DarkGoldenrod, Color.Cornsilk}
    Public Const DEBUG As Boolean = True
    Const AUTOFIRE_RATE As Single = 1

    Dim fireworks As List(Of Firework) = New List(Of Firework)

    Dim intMaxFireworks As Integer = 1
    Dim boolAuto As Boolean
    Dim dblLastFired As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        StartFireWorks()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        UpdateTime()
    End Sub

    Private Sub StartFireWorks()
        Dim rand As Random = New Random
        For index As Integer = 0 To intMaxFireworks - 1
            fireworks.Add(New Firework(
                rand.Next(10, Me.Width - 10),
                Me.Height - 10,
                New Size(5, 5),
                rand.Next(20, 30),
                (rand.Next(120) + 30) - 270,
                COLORS(rand.Next(COLORS.Length)),
                rand.Next(2, 5)
                ))
        Next
        dblLastFired = GravParticle.GetSecondsFromTicks(Date.Now.Ticks)
    End Sub

    Private Sub UpdateTime()
        If boolAuto And
            GravParticle.GetTimeDiff(GravParticle.GetSecondsFromTicks(Date.Now.Ticks), dblLastFired) > AUTOFIRE_RATE Then
            StartFireWorks()

        End If

        For index As Integer = fireworks.Count - 1 To 0 Step -1
            fireworks(index).Move()
            If fireworks(index).IsDone() Then
                fireworks.RemoveAt(index)
            End If
        Next
        Refresh()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        For Each fw As Firework In fireworks
            fw.Draw(e.Graphics)
        Next
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        fireworks.Clear()

    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        Timer1.Enabled = Not Timer1.Enabled
        If Timer1.Enabled Then
            btnPause.Text = "Pause"
        Else
            btnPause.Text = "UnPause"
        End If
    End Sub

    Private Sub fwCountTrackBar_Scroll(sender As Object, e As EventArgs) Handles fwCountTrackBar.Scroll
        If chkUltra.Checked Then
            intMaxFireworks = fwCountTrackBar.Value * 10
        Else
            intMaxFireworks = fwCountTrackBar.Value
        End If
        lblFireworkCount.Text = intMaxFireworks.ToString()
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        StartFireWorks()

    End Sub

    Private Sub chkUltra_CheckedChanged(sender As Object, e As EventArgs) Handles chkUltra.CheckedChanged
        If chkUltra.Checked Then
            intMaxFireworks = fwCountTrackBar.Value * 10
        Else
            intMaxFireworks = fwCountTrackBar.Value
        End If
        lblFireworkCount.Text = intMaxFireworks.ToString()

    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        boolAuto = Not boolAuto
        If boolAuto Then
            btnAuto.Text = "Auto Off"
        Else
            btnAuto.Text = "Auto On"
        End If

    End Sub
End Class
