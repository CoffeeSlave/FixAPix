Public Class clsAppConfig

    Public clsPreferences As New clsPreferences
    Public clsAutoSpeedCalc As New clsAutoSpeedCalc
    Public clsTimers As New clsTimers

    Public Sub InitialiseMe()
        gApp.clsPreferences.InitialiseMe()
    End Sub

    Private Function getColours() As Collection
        Dim myColours As New Collection

        With gApp.clsPreferences
            If .useRed Then
                myColours.Add(Color.Red)
            End If

            If .useBlue Then
                myColours.Add(Color.Blue)
            End If

            If .useGreen Then
                myColours.Add(Color.Green)
            End If

            If .useBlack Then
                myColours.Add(Color.Black)
            End If

            If .useWhite Then
                myColours.Add(Color.White)
            End If
        End With
        Return myColours
    End Function

    Public Function GetDisplayColour(previousColor As Color) As Color
        Dim totalColours As Integer = gApp.getColours.Count
        Dim count As Integer = 1
        Dim colourFlag As Boolean = False
        Dim thisColour As Color

        For Each colour As Color In gApp.getColours
            'Dim colstr As String = gApp.getColours.Item(count).ToString

            If colourFlag = True Then 'this is the colour we need. Grab and exit
                thisColour = colour
                Exit For
            End If

            If totalColours = count Then 'this is the last colour in the chain, restart from the beginning
                thisColour = CType(gApp.getColours.Item(1), Color)
                Exit For
            End If

            If previousColor = colour Then 'get the next one in the chain
                colourFlag = True
            End If
            count += 1
        Next

        Return thisColour
    End Function

End Class
