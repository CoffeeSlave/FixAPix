Public Class frmDebug

    Private Sub tmRefresh_Tick(sender As Object, e As EventArgs) Handles tmRefresh.Tick
        Me.Label1.Text = "Original Count = " & gApp.clsPreferences.autoSpeedOriginalCount & vbNewLine & "AutospeedCounter = " & gApp.clsPreferences.autoSpeedCounter & vbNewLine & "MillisecondChange = " & gApp.clsAutoSpeedCalc.millisecondsChange & vbNewLine & "FlashSpeed = " & gApp.clsPreferences.flashSpeed
        Me.Label1.Refresh()
    End Sub
   
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub frmDebug_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class