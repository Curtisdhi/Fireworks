Public Class Firework
    Inherits GravParticle

    Dim sngFuseTime As Single
    Dim clrColor As Color

    Dim particles As List(Of FireworkParticle) = New List(Of FireworkParticle)()
    Dim isExploded As Boolean


    Public Sub New(sngX As Single, sngY As Single, size As Size,
                   sngVel As Single, sngAng As Single, clrColor As Color, sngFuseTime As Single)

        MyBase.New(sngX, sngY, size, sngVel, sngAng)
        Me.clrColor = clrColor
        Me.sngFuseTime = sngFuseTime

    End Sub


    Public Overrides Sub Move()
        If Not isExploded Then
            MyBase.Move()
            If GetTimeDiff(GetSecondsFromTicks(Date.Now.Ticks), createdTime) >= sngFuseTime Then
                Explode()
            End If
        End If

        For Each particle As FireworkParticle In particles
            particle.Move()
        Next
    End Sub

    Public Overloads Sub Draw(g As Graphics)
        If Not isExploded Then
            g.FillEllipse(New SolidBrush(clrColor), sngX, sngY, size.Width, size.Height)

            If Form1.DEBUG Then
                MyBase.Draw(g, clrColor)
            End If
        End If
        For Each particle As FireworkParticle In particles
            particle.Draw(g)
        Next

    End Sub

    Public Sub Explode()
        Dim rand As Random = New Random

        particles = New List(Of FireworkParticle)(rand.Next(50, 100))
        isExploded = True

        For index As Integer = 0 To particles.Capacity
            particles.Add(New FireworkParticle(
                          sngX,
                          sngY,
                          New Size(2, 2),
                          sngVel * rand.NextDouble() * 0.5,
                          -rand.Next(360),
                          clrColor,
                          rand.Next(5, 10)
                          ))
        Next
    End Sub

    Public Function IsDone()
        If isExploded Then
            For Each particle As FireworkParticle In particles
                'If particle is not done, then are firework is not done as well.
                If Not particle.IsDone() Then
                    Return False

                End If
            Next
            'We are done here.
            Return True

        End If
        Return False

    End Function

End Class
