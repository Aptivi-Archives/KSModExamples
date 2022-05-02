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

Public Class ProgressText
    Implements ISplash

    Public Property SplashClosing As Boolean Implements ISplash.SplashClosing

    Public ReadOnly Property ProgressWritePositionX As Integer Implements ISplash.ProgressWritePositionX
        Get
            Return 2
        End Get
    End Property

    Public ReadOnly Property ProgressWritePositionY As Integer Implements ISplash.ProgressWritePositionY
        Get
            Return Console.WindowHeight - 2
        End Get
    End Property

    Public ReadOnly Property ProgressReportWritePositionX As Integer Implements ISplash.ProgressReportWritePositionX
        Get
            Return 6
        End Get
    End Property

    Public ReadOnly Property ProgressReportWritePositionY As Integer Implements ISplash.ProgressReportWritePositionY
        Get
            Return Console.WindowHeight - 2
        End Get
    End Property

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

    Public Sub Report(Progress As Integer, ProgressReport As String, ProgressWritePositionX As Integer, ProgressWritePositionY As Integer, ProgressReportWritePositionX As Integer, ProgressReportWritePositionY As Integer, ParamArray Vars() As Object) Implements ISplash.Report
        Wdbg(DebugLevel.I, "Report()")
        WriteWhere($"{Progress}%", ProgressWritePositionX, ProgressWritePositionY, True, ColTypes.Progress)
        WriteWhere($">> {ProgressReport}", ProgressReportWritePositionX, ProgressReportWritePositionY, False, ColTypes.Neutral)
        ClearLineToRight()
    End Sub

End Class
