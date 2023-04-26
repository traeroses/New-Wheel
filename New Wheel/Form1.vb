Public Class Form1

    Dim wheelstate = 0
    Dim RandGen As New Random
    Dim intRandNum As Integer
    Dim uppertime 

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWheel.Image = imgWheel.Images(0)
        Timer1.Interval = 1000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Timer1.Start()
        intRandNum = RandGen.Next(15, 26)
        uppertime = intRandNum
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim wheelstate = 0
        Dim RandGen As New Random
        Dim intRandNum As Integer
        Dim uppertime As Double
        intRandNum = RandGen.Next(15, 26)
        uppertime = intRandNum


        Do Until wheelstate = uppertime
            Timer1.Start()

            picWheel.Image = imgWheel.Images(wheelstate)
            wheelstate += 1
        Loop

        If wheelstate = 24 Then

        End If
    End Sub
End Class
