Public Class clsAutoSpeedCalc

    Private m_millisecondsChange As Long

    Public Property millisecondsChange() As Long

        Get
            Return m_millisecondsChange
        End Get
        Set(ByVal value As Long)
            m_millisecondsChange = value
        End Set

    End Property

    Public Sub initialiseMe(ByVal minSpeed As Integer, ByVal maxSpeed As Integer, ByVal timeSpan As Integer)
        millisecondsChange = ChangeCount(minSpeed, maxSpeed, timeSpan) 'returns milliseconds until change

        gApp.clsPreferences.flashSpeed = CInt(frmPreferences.dMinSpeed.Text)

    End Sub

    Private Function ChangeCount(ByVal minSpeed As Integer, ByVal maxSpeed As Integer, ByVal timeSpan As Integer) As Long '60000 Milliseconds in 1 minute
        Dim difference As Decimal
        'Dim rate As Decimal
        Dim millSecondCount As Decimal

        'difference = (maxSpeed - minSpeed) 'difference between the speed values
        'rate = CLng((difference / timeSpan)) 'how many times a minute to change
        'rate = (60 / rate)
        'millSecondCount = Math.Floor(rate * 1000)
        'ChangeCount = CLng(millSecondCount)

        difference = (maxSpeed - minSpeed) 'difference between the speed values
        millSecondCount = (timeSpan * 60000) 'how many milliseconds in timespan
        ChangeCount = CLng((millSecondCount / difference))

        ChangeCount = CLng((ChangeCount / 16))

        Return ChangeCount
    End Function

End Class
