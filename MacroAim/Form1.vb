Imports System.Threading

Public Class Form1
    Private WithEvents MouseDetector As MouseDetector
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Long
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Long
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Public Const MOUSEEVENTF_LEFTUP = &H4 ' left button up
    Public Limit = 3
    Public Times = 0
    Public Working = False
    Public milliseconds = 100
    Dim textBoxes() As TextBox

    Private Sub EmulateClickEvent()
        mouse_event(&H2, 0, 0, 0, 1) 'cursor will go down (like a click)
        mouse_event(&H4, 0, 0, 0, 1) ' cursor goes up again
        TextBox3.Text = Times

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Hotkey As Boolean
        Hotkey = GetAsyncKeyState(Keys.F3)
        If Hotkey = True Then
            Working = True
            Timer1.Start()
        End If

        Hotkey = GetAsyncKeyState(Keys.F4)
        If Hotkey = True Then
            Working = False
            Timer1.Stop()
        End If

        Times = Times + 1
        If Times <= Limit Then
            EmulateClickEvent()
        Else
            Times = 0
            Timer1.Stop()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Working = True
        Timer2.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Working = False
        Times = 0
        Timer1.Stop()
    End Sub

    Private Sub Interval_Click(sender As Object, e As EventArgs) Handles Interval.Click
        If IntervalInput.Text = ("") Or IntervalInput.Text = 0 Then
            MsgBox("Please, put a valid number value", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
        Else
            Timer1.Interval = ((IntervalInput.Text) * (1))
            My.Settings.SettingInterval = Timer1.Interval
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Timer1.Start()
        End If
    End Sub



    Private Sub NumberClicks_Click(sender As Object, e As EventArgs) Handles NumberClicks.Click
        If NumberOfClicksInput.Text <> ("") Then
            Limit = NumberOfClicksInput.Text
            My.Settings.SettingNumberClicks = NumberOfClicksInput.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MouseDetector = New MouseDetector
        If My.Settings.SettingInterval <> 0 Then
            IntervalInput.Text = My.Settings.SettingInterval
        Else
            IntervalInput.Text = milliseconds
        End If
        If My.Settings.SettingNumberClicks <> 0 Then
            NumberOfClicksInput.Text = My.Settings.SettingNumberClicks
        Else
            NumberOfClicksInput.Text = Times
        End If


        My.Settings.Save()
    End Sub
    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        RemoveHandler MouseDetector.MouseLeftButtonClick, AddressOf MouseDetector_MouseLeftButtonClick
        MouseDetector.Dispose()
    End Sub

    Private Sub MouseDetector_MouseLeftButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MouseDetector.MouseLeftButtonClick

        If Not Timer1.Enabled And Working Then
            Timer1.Start()
        End If
        'Not working long clicks
        'If milliseconds > 1 Then
        'mouse_event(&H4, 0, 0, 0, 0)
        'End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Hotkey As Boolean
        Hotkey = GetAsyncKeyState(Keys.F3)
        If Hotkey = True Then
            Working = True
        End If

        Hotkey = GetAsyncKeyState(Keys.F4)
        If Hotkey = True Then
            Working = False
        End If

    End Sub
End Class
