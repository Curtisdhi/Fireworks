Public Class FireworkParticle
    Inherits GravParticle

    Dim sngFuseTime As Single
    Dim clrColor As Color
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

    End Sub

    Public Overloads Sub Draw(g As Graphics)
        If Not isExploded Then
            g.FillEllipse(New SolidBrush(clrColor), sngX, sngY, size.Width, size.Height)

            If Form1.DEBUG Then
                MyBase.Draw(g, clrColor)
            End If
        End If

    End Sub

    Public Sub Explode()
        isExploded = True
    End Sub

    Public Function IsDone() As Boolean
        Return isExploded

    End Function
End Class
