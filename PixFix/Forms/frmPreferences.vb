Public Class frmPreferences
    Private isOnLoad As Boolean
    Dim autoShutdowntime As DateTime

    Private Sub frmPreferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isOnLoad = True

        With tbSpeed
            .SmallChange = 1
            .TickFrequency = 1
            .Maximum = 500
            .Minimum = 1
            .Value = 100
        End With

        With Me
            .chkRed.Checked = gApp.clsPreferences.useRed
            .chkGreen.Checked = gApp.clsPreferences.useGreen
            .chkBlue.Checked = gApp.clsPreferences.useBlue
            .chkBlack.Checked = gApp.clsPreferences.useBlack
            .chkWhite.Checked = gApp.clsPreferences.useWhite
            .tbSpeed.Value = gApp.clsPreferences.flashSpeed
            .lblSpeed.Text = gApp.clsPreferences.flashSpeed.ToString
        End With

        isOnLoad = False
    End Sub

    Private Sub refreshSpeedLabel()
        Me.lblSpeed.Text = gApp.clsPreferences.flashSpeed.ToString
    End Sub


    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        saveForm()
        Me.Close()
    End Sub

    Private Sub saveForm()
       
            gApp.clsPreferences.autoSpeedCounter = 0

        With gApp.clsPreferences
            .useRed = Me.chkRed.Checked
            .useGreen = Me.chkGreen.Checked
            .useBlue = Me.chkBlue.Checked
            .useBlack = Me.chkBlack.Checked
            .useWhite = Me.chkWhite.Checked

            If Me.chkAutoSpeed.Checked Then
                .autoSpeedEnabled = True
                .autoSpeedHighValue = CInt(Me.dHighSpeed.Text)
                .autoSpeedLowValue = CInt(Me.dMinSpeed.Text)
                .autoSpeedTimeSpan = CInt(Me.dTimeSpan.Text)
                .autoSpeedNewSettings = True
                .flashSpeed = CInt(Me.dMinSpeed.Text)
                gApp.clsAutoSpeedCalc.initialiseMe(CInt(Me.dMinSpeed.Text), CInt(Me.dHighSpeed.Text), CInt(Me.dTimeSpan.Text))
            Else
                If gApp.clsTimers.TimerStarted Then
                    gApp.clsTimers.autoStop()
                End If
                .autoSpeedEnabled = False
                .flashSpeed = Me.tbSpeed.Value
            End If

            If Me.chkAutoShutdown.Checked Then
                .autoShutDownEnabled = True
                .autoShutDownTime = autoShutdowntime
            End If


        End With
        refreshSpeedLabel()
    End Sub


    Private Sub chkRed_CheckedChanged(sender As Object, e As EventArgs) Handles chkRed.CheckedChanged
        If Not isOnLoad Then
            saveForm()
        End If
    End Sub

    Private Sub chkBlue_CheckedChanged(sender As Object, e As EventArgs) Handles chkBlue.CheckedChanged
        If Not isOnLoad Then
            saveForm()
        End If
    End Sub

    Private Sub chkGreen_CheckedChanged(sender As Object, e As EventArgs) Handles chkGreen.CheckedChanged
        If Not isOnLoad Then
            saveForm()
        End If
    End Sub

    Private Sub chkBlack_CheckedChanged(sender As Object, e As EventArgs) Handles chkBlack.CheckedChanged
        If Not isOnLoad Then
            saveForm()
        End If
    End Sub

    Private Sub chkWhite_CheckedChanged(sender As Object, e As EventArgs) Handles chkWhite.CheckedChanged
        If Not isOnLoad Then
            saveForm()
        End If
    End Sub

    Private Sub tbSpeed_Scroll(sender As Object, e As EventArgs) Handles tbSpeed.Scroll
        If Not isOnLoad Then
            saveForm()
        End If
    End Sub

    Private Sub cmbShutDownHours_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShutDownHours.SelectedIndexChanged
        autoShutdowntime = Now.AddHours(CDbl(Me.cmbShutDownHours.Text))

        Me.Label6.Text = autoShutdowntime.ToString

    End Sub
End Class