'
' Copyright (c) Aptivi. All rights reserved.
' 
' Name: FullFade.vb
' Description: Entry point for the FullFade screensaver
' KS Version: 0.0.23
' 
' History:
' 
' | Author   | Date      | Description
' +----------+-----------+--------------
' | Aptivi   | 6/13/2021 | Initial release
' | Aptivi   | 7/11/2022 | Changed implementation to IScreensaver and BaseScreensaver
'

Imports KS.ConsoleBase
Imports KS.ConsoleBase.Colors
Imports KS.Misc.Screensaver
Imports KS.Misc.Threading

Public Class FullFade
    Inherits BaseScreensaver
    Implements IScreensaver

    Public Overrides Property ScreensaverName As String
    Public Overrides Property ScreensaverSettings As Dictionary(Of String, Object)

    Public Overrides Sub ScreensaverLogic()
        'Set thresholds and colors
        Dim RandomDriver As New Random()
        Dim RedColorNum As Integer = RandomDriver.Next(255)
        Dim GreenColorNum As Integer = RandomDriver.Next(255)
        Dim BlueColorNum As Integer = RandomDriver.Next(255)
        Dim ThresholdRed As Double = RedColorNum / 50
        Dim ThresholdGreen As Double = GreenColorNum / 50
        Dim ThresholdBlue As Double = BlueColorNum / 50

        'Fade in
        For CurrentStep As Integer = 50 To 1 Step -1
            SleepNoBlock(50, ScreensaverDisplayerThread)
            Dim CurrentColorRed As Integer = RedColorNum / CurrentStep
            Dim CurrentColorGreen As Integer = GreenColorNum / CurrentStep
            Dim CurrentColorBlue As Integer = BlueColorNum / CurrentStep
            SetConsoleColor(New Color($"{CurrentColorRed};{CurrentColorGreen};{CurrentColorBlue}"), True)
            Console.Clear()
        Next

        'Wait until fade out
        SleepNoBlock(3000, ScreensaverDisplayerThread)

        'Fade out
        For CurrentStep As Integer = 1 To 50
            SleepNoBlock(50, ScreensaverDisplayerThread)
            Dim CurrentColorRed As Integer = RedColorNum - ThresholdRed * CurrentStep
            Dim CurrentColorGreen As Integer = GreenColorNum - ThresholdGreen * CurrentStep
            Dim CurrentColorBlue As Integer = BlueColorNum - ThresholdBlue * CurrentStep
            SetConsoleColor(New Color($"{CurrentColorRed};{CurrentColorGreen};{CurrentColorBlue}"), True)
            Console.Clear()
        Next
    End Sub
End Class
