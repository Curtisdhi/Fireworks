Public Class GravParticle

    Public Const sngLENGTH_OF_VECTOR_LINE As Single = 5
    Public Const GRAVITY As Single = 9.81
    Public Const RADIANS As Single = Math.PI / 365

    Protected sngX As Single
    Protected sngY As Single
    Protected size As Size
    Protected sngVel As Single
    Protected sngAng As Single

    Protected createdTime As Long

    Protected voX As Single
    Protected voY As Single

    Public Sub New(sngX As Single, sngY As Single, size As Size, sngVel As Single, sngAng As Single)

        Me.sngX = sngX
        Me.sngY = sngY
        Me.size = size
        Me.sngVel = sngVel
        Me.sngAng = sngAng


        Me.createdTime = GetSecondsFromTicks(Date.Now.Ticks)

    End Sub


    Public Overridable Sub Move()

        Dim time As Double = GetTimeDiff(GetSecondsFromTicks(Date.Now.Ticks), createdTime)

        voX = sngVel * Math.Cos(sngAng * RADIANS)
        voY = sngVel * Math.Sin(sngAng * RADIANS) + ((GRAVITY * Math.Sin(270 * RADIANS)) * time)
        sngX += voX
        sngY += voY

    End Sub

    Public Overridable Sub Draw(g As Graphics, clr As Color)
        Dim center As Point = GetCenter()

        g.DrawLine(
            New Pen(clr),
            center.X,
            center.Y,
            center.X + (voX + sngLENGTH_OF_VECTOR_LINE),
            center.Y + (voY + sngLENGTH_OF_VECTOR_LINE))
    End Sub

    Public Function GetCenter() As Point
        Return New Point(sngX + size.Width / 2, sngY + size.Height / 2)

    End Function

    Public Shared Function GetSecondsFromTicks(lngTicks As Long) As Double
        Return lngTicks / TimeSpan.TicksPerSecond

    End Function

    Public Shared Function GetTimeDiff(dblSecondsStart As Double, dblSecondsEnd As Double) As Double
        Return dblSecondsStart - dblSecondsEnd

    End Function
End Class
