Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Dim _Stopwatch As New System.Diagnostics.Stopwatch

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        label_Time.MinimumSize = New Size(Me.Width, 0)


    End Sub

    Private Sub but_StartStop_Click(sender As Object, e As EventArgs) Handles but_StartStop.Click
        StartStop()

    End Sub
    Public Sub StartStop()
        If _Stopwatch.IsRunning Then
            _Stopwatch.Stop()
        Else
            _Stopwatch.Start()
        End If
    End Sub

    Private Sub but_Reset_Click(sender As Object, e As EventArgs) Handles but_Reset.Click
        _Stopwatch.Stop()
        _Stopwatch.Reset()

    End Sub

    Private Sub timer_StopwatchMonitor_Tick(sender As Object, e As EventArgs) Handles timer_StopwatchMonitor.Tick
        Dim elapsedTime As String
        If _Stopwatch.Elapsed > TimeSpan.FromMinutes(59) Then
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _Stopwatch.Elapsed.Hours, _Stopwatch.Elapsed.Minutes,
        _Stopwatch.Elapsed.Seconds, _Stopwatch.Elapsed.Milliseconds / 10)
        Else
            elapsedTime = String.Format("{0:00}:{1:00}.{2:00}", _Stopwatch.Elapsed.Minutes,
               _Stopwatch.Elapsed.Seconds, _Stopwatch.Elapsed.Milliseconds / 10)
        End If





        label_Time.Text = elapsedTime
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Space
                StartStop()
            Case Keys.Escape
                _Stopwatch.Stop()
                _Stopwatch.Reset()

        End Select
    End Sub


    Dim hover As Boolean = False
    Private Sub but_StartStop_MouseEnter(sender As Object, e As EventArgs) Handles but_StartStop.MouseEnter, but_Reset.MouseEnter
        hover = True
        sender.backcolor = Color.White
    End Sub

    Private Sub but_StartStop_MouseLeave(sender As Object, e As EventArgs) Handles but_StartStop.MouseLeave, but_Reset.MouseLeave
        sender.backcolor = Color.Transparent
    End Sub

    Private Sub but_StartStop_MouseUp(sender As Object, e As MouseEventArgs) Handles but_StartStop.MouseUp, but_Reset.MouseUp
        If hover Then
            sender.backcolor = Color.White
        Else
            sender.backcolor = Color.Transparent
        End If
    End Sub

    Private Sub but_StartStop_MouseDown(sender As Object, e As MouseEventArgs) Handles but_StartStop.MouseDown, but_Reset.MouseDown
        sender.backcolor = Color.Silver
    End Sub

    Private Sub cb_OnTop_CheckedChanged(sender As Object, e As EventArgs) Handles cb_OnTop.CheckedChanged
        Select Case cb_OnTop.Checked
            Case True
                Me.TopMost = True

            Case False
                Me.TopMost = False

        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case My.Settings.OnTop
            Case True
                cb_OnTop.Checked = True

            Case False
                cb_OnTop.Checked = False

        End Select
    End Sub

    Private Sub cb_OnTop_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles cb_OnTop.PreviewKeyDown
        '  Dim val As Boolean = sender.checked
        Select Case e.KeyCode
            Case Keys.Space
                StartStop()
            Case Keys.Escape
                _Stopwatch.Stop()
                _Stopwatch.Reset()

        End Select
        '  sender.checked = val
    End Sub


End Class


Public Class MyPictureBox
    Inherits PictureBox

    Public Sub New()
        Me.SetStyle(ControlStyles.StandardDoubleClick, False)
    End Sub

End Class



Public Class MyCheckBox
    Inherits DevExpress.XtraEditors.CheckEdit

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Return
        End If
        If e.KeyCode = Keys.Space Then
            Return
        End If

        MyBase.OnKeyDown(e)
    End Sub


End Class

