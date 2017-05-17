Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tmMain.Stop()


    End Sub

    Private Sub ChangeFormColour(colour As Color)
        With Me
            .BackColor = colour
            .lblColFlash.BackColor = colour
            .MenuStrip1.BackColor = colour

            If colour = Color.Black Then
                .MenuStrip1.ForeColor = Color.White
            Else
                .MenuStrip1.ForeColor = Color.Black
            End If

        End With
    End Sub

    Private Sub ChangeMenuColour(colour As Color)
        With Me.MenuStrip1
            .ForeColor = colour
        End With
    End Sub

    Private Sub tmMain_Tick(sender As Object, e As EventArgs) Handles tmMain.Tick
        Me.tmMain.Interval = gApp.clsPreferences.flashSpeed
        ChangeFormColour(gApp.GetDisplayColour(Me.lblColFlash.BackColor))

        If gApp.clsPreferences.autoSpeedEnabled Then
            If gApp.clsPreferences.autoSpeedNewSettings = True Then
                gApp.clsTimers.autoStart()
                gApp.clsPreferences.autoSpeedNewSettings = False
            End If
        End If

        If gApp.clsPreferences.autoShutDownEnabled Then
            If gApp.clsPreferences.autoShutDownTime < Now Then
                System.Diagnostics.Process.Start("shutdown", "-s -t 00")
            End If
        End If

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If gApp.clsTimers.TimerStarted Then
            gApp.clsTimers.autoStop()
        End If


        If gApp.clsPreferences.autoSpeedEnabled Then
            gApp.clsPreferences.autoSpeedNewSettings = True
            gApp.clsPreferences.autoSpeedCounter = 0
            gApp.clsAutoSpeedCalc.initialiseMe(gApp.clsPreferences.autoSpeedLowValue, gApp.clsPreferences.autoSpeedHighValue, gApp.clsPreferences.autoSpeedTimeSpan)
        End If

        tmMain.Start()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        tmMain.Stop()

        If gApp.clsPreferences.autoSpeedEnabled Then
            gApp.clsPreferences.autoSpeedCounter = 0
            gApp.clsTimers.autoStop()
        End If

        ChangeFormColour(Color.Azure)
    End Sub

    Private Sub FullscreenToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FullscreenToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub NormalSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalSizeToolStripMenuItem.Click
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ShowBlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowBlackToolStripMenuItem.Click
        Me.tmMain.Stop()
        ChangeFormColour(Color.Black)
        ChangeMenuColour(Color.DarkGray)
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.tmMain.Stop()
        ChangeFormColour(Color.White)
        ChangeMenuColour(Color.Black)
    End Sub

    Private Sub RegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegToolStripMenuItem.Click
        Me.tmMain.Stop()
        ChangeFormColour(Color.Red)
        ChangeMenuColour(Color.Black)
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.tmMain.Stop()
        ChangeFormColour(Color.Green)
        ChangeMenuColour(Color.Black)
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.tmMain.Stop()
        ChangeFormColour(Color.Blue)
        ChangeMenuColour(Color.DarkGray)
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        NormalSizeToolStripMenuItem_Click(sender, e)
    End Sub


    Private Sub paramerters_Click(sender As Object, e As EventArgs) Handles paramerters.Click
        frmPreferences.ShowDialog()
    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmDebug.Show()
    End Sub


End Class
