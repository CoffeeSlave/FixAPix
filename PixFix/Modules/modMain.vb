Module modMain


    Public gApp As New clsAppConfig
    Private mainForm As frmMain

    Public Sub Main()
        gApp.InitialiseMe()
        Application.EnableVisualStyles()
        mainForm = frmMain
        mainForm.ShowDialog()
    End Sub
End Module
