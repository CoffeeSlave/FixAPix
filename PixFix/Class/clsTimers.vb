Imports System
Imports System.Timers

Public Class clsTimers
    Private Shared aTimer As System.Timers.Timer
    Private m_TimerStarted As Boolean

    Public Property TimerStarted() As Boolean

        Get
            Return m_TimerStarted
        End Get
        Set(ByVal value As Boolean)
            m_TimerStarted = value
        End Set

    End Property

    Public Sub autoStart()
        TimerStarted = True
        MainTimer()
    End Sub

    Public Sub autoStop()
        aTimer.Stop()
        TimerStarted = True
    End Sub

    Public Shared Sub MainTimer()
        aTimer = New System.Timers.Timer(1)
        AddHandler aTimer.Elapsed, AddressOf OnTimedEvent
        aTimer.Interval = 1
        aTimer.Enabled = True
        gApp.clsPreferences.autoSpeedOriginalCount = gApp.clsAutoSpeedCalc.millisecondsChange
        GC.KeepAlive(aTimer)

        ' If the timer is declared in a long-running method, use 
        ' KeepAlive to prevent garbage collection from occurring 
        ' before the method ends. 
        'GC.KeepAlive(aTimer) 
    End Sub

    Private Shared Sub OnTimedEvent(source As Object, e As ElapsedEventArgs)

        If gApp.clsAutoSpeedCalc.millisecondsChange <> gApp.clsPreferences.autoSpeedCounter Then
            gApp.clsPreferences.autoSpeedCounter += 1
        Else
            gApp.clsPreferences.flashSpeed += 1
            gApp.clsAutoSpeedCalc.millisecondsChange += gApp.clsPreferences.autoSpeedOriginalCount
        End If

        If gApp.clsPreferences.flashSpeed = gApp.clsPreferences.autoSpeedHighValue Then
            'MsgBox(gApp.clsPreferences.autoSpeedLowValue)
            gApp.clsPreferences.autoSpeedCounter = 0
            gApp.clsAutoSpeedCalc.millisecondsChange = 0
            gApp.clsAutoSpeedCalc.initialiseMe(gApp.clsPreferences.autoSpeedLowValue, gApp.clsPreferences.autoSpeedHighValue, gApp.clsPreferences.autoSpeedTimeSpan)
        End If

        If gApp.clsPreferences.autoSpeedLowValue = gApp.clsPreferences.autoSpeedHighValue Then
            gApp.clsAutoSpeedCalc.initialiseMe(gApp.clsPreferences.autoSpeedLowValue, gApp.clsPreferences.autoSpeedHighValue, gApp.clsPreferences.autoSpeedTimeSpan)
        End If


    End Sub
End Class
