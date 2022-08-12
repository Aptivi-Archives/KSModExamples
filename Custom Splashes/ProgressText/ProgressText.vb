'
' Copyright (c) EoflaOE and its companies. All rights reserved.
' 
' Name: ProgressText.vb
' Description: Entry point for the ProgressText custom splash
' KS Version: 0.0.21
' 
' History:
' 
' | Author   | Date      | Description
' +----------+-----------+--------------
' | EoflaOE  | 5/2/2022  | Initial release
'

Imports KS.ConsoleBase
Imports KS.Misc.Splash
Imports KS.Misc.Writers.DebugWriters
Imports KS.Misc.Writers.ConsoleWriters
Imports KS.ConsoleBase.Colors.ColorTools

Public Class ProgressText
    Implements ISplash

    Public Property SplashClosing As Boolean Implements ISplash.SplashClosing

    Public ReadOnly Property SplashName As String Implements ISplash.SplashName
        Get
            Return "ProgressText"
        End Get
    End Property

    Public ReadOnly Property SplashDisplaysProgress As Boolean Implements ISplash.SplashDisplaysProgress
        Get
            Return True
        End Get
    End Property

    Public Sub Opening() Implements ISplash.Opening
        Wdbg(DebugLevel.I, "Opening()")
        Console.Clear()
    End Sub

    Public Sub Display() Implements ISplash.Display
        Wdbg(DebugLevel.I, "Display()")
    End Sub

    Public Sub Closing() Implements ISplash.Closing
        Wdbg(DebugLevel.I, "Closing()")
        SplashClosing = True
        Console.Clear()
    End Sub

    Public Sub Report(Progress As Integer, ProgressReport As String, ParamArray Vars() As Object) Implements ISplash.Report
        Dim ProgressWritePositionX As Integer = 2
        Dim ProgressWritePositionY As Integer = Console.WindowHeight - 2
        Dim ProgressReportWritePositionX As Integer = 6
        Dim ProgressReportWritePositionY As Integer = Console.WindowHeight - 2

        Wdbg(DebugLevel.I, "Report()")
        WriteWhere($"{Progress}%", ProgressWritePositionX, ProgressWritePositionY, True, ColTypes.Progress)
        WriteWhere($">> {ProgressReport}", ProgressReportWritePositionX, ProgressReportWritePositionY, False, ColTypes.Neutral)
        ClearLineToRight()
    End Sub

End Class
