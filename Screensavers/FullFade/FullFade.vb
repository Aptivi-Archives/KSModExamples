'
' Copyright (c) EoflaOE and its companies. All rights reserved.
' 
' Name: FullFade.vb
' Description: Entry point for the FullFade screensaver
' KS Version: 0.0.16
' 
' History:
' 
' | Author   | Date      | Description
' +----------+-----------+--------------
' | EoflaOE  | 6/13/2021 | Initial release
'

Imports KS.ThreadManager
Imports KS.CustomDisplay
Imports KS.ColorTools
Imports KS

Public Class FullFade
    Implements ICustomSaver

    Public Property Initialized As Boolean Implements ICustomSaver.Initialized
    Public Property DelayForEachWrite As Integer Implements ICustomSaver.DelayForEachWrite
    Public Property SaverName As String Implements ICustomSaver.SaverName
    Public Property SaverSettings As Dictionary(Of String, Object) Implements ICustomSaver.SaverSettings

    Public Sub InitSaver() Implements ICustomSaver.InitSaver
        SaverName = "FullFade"
        DelayForEachWrite = 10
        Initialized = True
    End Sub

    Public Sub PreDisplay() Implements ICustomSaver.PreDisplay
    End Sub

    Public Sub PostDisplay() Implements ICustomSaver.PostDisplay
    End Sub

    Public Sub ScrnSaver() Implements ICustomSaver.ScrnSaver
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
            If Custom.CancellationPending Then Exit For
            SleepNoBlock(DelayForEachWrite, Custom)
            Dim CurrentColorRed As Integer = RedColorNum / CurrentStep
            Dim CurrentColorGreen As Integer = GreenColorNum / CurrentStep
            Dim CurrentColorBlue As Integer = BlueColorNum / CurrentStep
            SetConsoleColor(New KS.Color($"{CurrentColorRed};{CurrentColorGreen};{CurrentColorBlue}"), True)
            Console.Clear()
        Next

        'Wait until fade out
        SleepNoBlock(3000, Custom)

        'Fade out
        For CurrentStep As Integer = 1 To 50
            If Custom.CancellationPending Then Exit For
            SleepNoBlock(DelayForEachWrite, Custom)
            Dim CurrentColorRed As Integer = RedColorNum - ThresholdRed * CurrentStep
            Dim CurrentColorGreen As Integer = GreenColorNum - ThresholdGreen * CurrentStep
            Dim CurrentColorBlue As Integer = BlueColorNum - ThresholdBlue * CurrentStep
            SetConsoleColor(New KS.Color($"{CurrentColorRed};{CurrentColorGreen};{CurrentColorBlue}"), True)
            Console.Clear()
        Next
    End Sub
End Class
