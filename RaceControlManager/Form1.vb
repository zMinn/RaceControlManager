﻿Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim redState As Boolean
    Dim yellowState As Boolean
    Dim dyellowState As Boolean
    Dim flag, greenState, x
    Dim ye1, ye2, ye3, ye4, ye5, ye6, ye7, ye8, ye9, ye10 As Boolean
    Dim dy1, dy2, dy3, dy4, dy5, dy6, dy7, dy8, dy9, dy10 As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ye1 = False : ye2 = False : ye3 = False : ye4 = False : ye5 = False : ye6 = False : ye7 = False : ye8 = False : ye9 = False : ye10 = False
        dy1 = False : dy2 = False : dy3 = False : dy4 = False : dy5 = False : dy6 = False : dy7 = False : dy8 = False : dy9 = False : dy10 = False
    End Sub

    'Flag Handlng 
    'Red Flag
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        flag = "red"
        TimerRed.Enabled = True
    End Sub
    Private Sub TimerRed_Tick(sender As Object, e As EventArgs) Handles TimerRed.Tick
        redState = Not redState
        If redState = True Then
            PictureBox1.Image = RaceControlManager.My.Resources.Red
        Else
            PictureBox1.Image = RaceControlManager.My.Resources.Black
        End If
    End Sub








    'Yellow Flags
    Private Sub y1_Click(sender As Object, e As EventArgs) Handles y1.Click
        ye1 = True
        If dy1 = True Then dy1 = False : ry1.BackColor = Color.White
        y1.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout1
    End Sub
    Private Sub y2_Click(sender As Object, e As EventArgs) Handles y2.Click
        ye2 = True
        If dy2 = True Then dy2 = False : ry2.BackColor = Color.White
        y2.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout2
    End Sub
    Private Sub y3_Click(sender As Object, e As EventArgs) Handles y3.Click
        ye3 = True
        If dy3 = True Then dy3 = False : ry3.BackColor = Color.White
        y3.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout3
    End Sub
    Private Sub y4_Click(sender As Object, e As EventArgs) Handles y4.Click
        ye4 = True
        If dy4 = True Then dy4 = False : ry4.BackColor = Color.White
        y4.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout4
    End Sub
    Private Sub y5_Click(sender As Object, e As EventArgs) Handles y5.Click
        ye5 = True
        If dy5 = True Then dy5 = False : ry5.BackColor = Color.White
        y5.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout5
    End Sub
    Private Sub y6_Click(sender As Object, e As EventArgs) Handles y6.Click
        ye6 = True
        If dy6 = True Then dy6 = False : ry6.BackColor = Color.White
        y6.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout6
    End Sub
    Private Sub y7_Click(sender As Object, e As EventArgs) Handles y7.Click
        ye7 = True
        If dy7 = True Then dy7 = False : ry7.BackColor = Color.White
        y7.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout7
    End Sub
    Private Sub y8_Click(sender As Object, e As EventArgs) Handles y8.Click
        ye8 = True
        If dy8 = True Then dy8 = False : ry8.BackColor = Color.White
        y8.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout8
    End Sub
    Private Sub y9_Click(sender As Object, e As EventArgs) Handles y9.Click
        ye9 = True
        If dy9 = True Then dy9 = False : ry9.BackColor = Color.White
        y9.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout9
    End Sub
    Private Sub y10_Click(sender As Object, e As EventArgs) Handles y10.Click
        ye10 = True
        If dy10 = True Then dy10 = False : ry10.BackColor = Color.White
        y10.BackColor = Color.Red
        PictureBox2.Image = RaceControlManager.My.Resources.Layout10
    End Sub

    Private Sub ry1_Click(sender As Object, e As EventArgs) Handles ry1.Click
        dy1 = True
        If ye1 = True Then y1.BackColor = Color.White : ye1 = False
        ry1.BackColor = Color.Red
    End Sub
    Private Sub ry2_Click(sender As Object, e As EventArgs) Handles ry2.Click
        dy2 = True
        If ye2 = True Then y2.BackColor = Color.White : ye2 = False
        ry2.BackColor = Color.Red
    End Sub
    Private Sub ry3_Click(sender As Object, e As EventArgs) Handles ry3.Click
        dy3 = True
        If ye3 = True Then y3.BackColor = Color.White : ye3 = False
        ry3.BackColor = Color.Red
    End Sub
    Private Sub ry4_Click(sender As Object, e As EventArgs) Handles ry4.Click
        dy4 = True
        If ye4 = True Then y4.BackColor = Color.White : ye4 = False
        ry4.BackColor = Color.Red
    End Sub
    Private Sub ry5_Click(sender As Object, e As EventArgs) Handles ry5.Click
        dy5 = True
        If ye5 = True Then y5.BackColor = Color.White : ye5 = False
        ry5.BackColor = Color.Red
    End Sub
    Private Sub ry6_Click(sender As Object, e As EventArgs) Handles ry6.Click
        dy6 = True
        If ye6 = True Then y6.BackColor = Color.White : ye6 = False
        ry6.BackColor = Color.Red
    End Sub
    Private Sub ry7_Click(sender As Object, e As EventArgs) Handles ry7.Click
        dy7 = True
        If ye7 = True Then y7.BackColor = Color.White : ye7 = False
        ry7.BackColor = Color.Red
    End Sub
    Private Sub ry8_Click(sender As Object, e As EventArgs) Handles ry8.Click
        dy8 = True
        If ye8 = True Then y8.BackColor = Color.White : ye8 = False
        ry8.BackColor = Color.Red
    End Sub
    Private Sub ry9_Click(sender As Object, e As EventArgs) Handles ry9.Click
        dy9 = True
        If ye9 = True Then y9.BackColor = Color.White : ye9 = False
        ry9.BackColor = Color.Red
    End Sub
    Private Sub ry10_Click(sender As Object, e As EventArgs) Handles ry10.Click
        dy10 = True
        If ye10 = True Then y10.BackColor = Color.White : ye10 = False
        ry10.BackColor = Color.Red
    End Sub

    Private Sub g_Click(sender As Object, e As EventArgs) Handles g.Click
        ye1 = False : dy1 = False : y1.BackColor = Color.White : ry1.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0

    End Sub
    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click
        ye2 = False : dy2 = False : y2.BackColor = Color.White : ry2.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub
    Private Sub g3_Click(sender As Object, e As EventArgs) Handles g3.Click
        ye3 = False : dy3 = False : y3.BackColor = Color.White : ry3.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub
    Private Sub g4_Click(sender As Object, e As EventArgs) Handles g4.Click
        ye4 = False : dy4 = False : y4.BackColor = Color.White : ry4.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub
    Private Sub g5_Click(sender As Object, e As EventArgs) Handles g5.Click
        ye5 = False : dy5 = False : y5.BackColor = Color.White : ry5.BackColor = Color.White
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub
    Private Sub g6_Click(sender As Object, e As EventArgs) Handles g6.Click
        ye6 = False : dy6 = False : y6.BackColor = Color.White : ry6.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub
    Private Sub g7_Click(sender As Object, e As EventArgs) Handles g7.Click
        ye7 = False : dy7 = False : y7.BackColor = Color.White : ry7.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub
    Private Sub g8_Click(sender As Object, e As EventArgs) Handles g8.Click
        ye8 = False : dy8 = False : y8.BackColor = Color.White : ry8.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub
    Private Sub g9_Click(sender As Object, e As EventArgs) Handles g9.Click
        ye9 = False : dy9 = False : y9.BackColor = Color.White : ry9.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub
    Private Sub g10_Click(sender As Object, e As EventArgs) Handles g10.Click
        ye10 = False : dy10 = False : y10.BackColor = Color.White : ry10.BackColor = Color.White
        x = 0
        greenState = True
        GreenTimer.Enabled = True
        greenState = 0
    End Sub



    'SC
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles sc1.Click
        ye1 = False : ye2 = False : ye3 = False : ye4 = False : ye5 = False : ye6 = False : ye7 = False : ye8 = False : ye9 = False : ye10 = False
        dy1 = False : dy2 = False : dy3 = False : dy4 = False : dy5 = False : dy6 = False : dy7 = False : dy8 = False : dy9 = False : dy10 = False
        TimerSC.Enabled = True
        PictureBox2.Image = RaceControlManager.My.Resources.fcy
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles sc2.Click

    End Sub











    Private Sub TimerYellow_Tick(sender As Object, e As EventArgs) Handles TimerYellow.Tick
        If TimerRed.Enabled = False Then
            If ye1 = True Or ye2 = True Or ye3 = True Or ye4 = True Or ye5 = True Or ye6 = True Or ye7 = True Or ye8 = True Or ye9 = True Or ye10 = True Then
                yellowState = Not yellowState
                If yellowState = True Then
                    PictureBox1.Image = RaceControlManager.My.Resources.Yellow
                Else
                    PictureBox1.Image = RaceControlManager.My.Resources.Black
                End If
            End If
        End If

    End Sub
    Private Sub DYellow_Tick(sender As Object, e As EventArgs) Handles DYellow.Tick
        If TimerRed.Enabled = False Then
            If dy1 = True Or dy2 = True Or dy3 = True Or dy4 = True Or dy5 = True Or dy6 = True Or dy7 = True Or dy8 = True Or dy9 = True Or dy10 = True Then
                dyellowState = Not dyellowState
                If dyellowState = True Then
                    PictureBox1.Image = RaceControlManager.My.Resources.DoubleYellow1
                Else
                    PictureBox1.Image = RaceControlManager.My.Resources.DoubleYellow2
                End If
            End If
        End If
    End Sub
    Private Sub GreenTimer_Tick(sender As Object, e As EventArgs) Handles GreenTimer.Tick
        If ye1 = False And ye2 = False And ye3 = False And ye4 = False And ye5 = False And ye6 = False And ye7 = False And ye8 = False And ye9 = False And ye10 = False And dy1 = False And dy2 = False And dy3 = False And dy4 = False And dy5 = False And dy6 = False And dy7 = False And dy8 = False And dy9 = False And dy10 = False Then
            PictureBox2.Image = RaceControlManager.My.Resources.Layout
            greenState = Not greenState
            If x = 20 Then
                GreenTimer.Enabled = False
                PictureBox1.Image = RaceControlManager.My.Resources.Black
            ElseIf greenState = False Then
                PictureBox1.Image = RaceControlManager.My.Resources.Black
                x += 1
            ElseIf greenState = True Then
                PictureBox1.Image = RaceControlManager.My.Resources.Green
                x += 1
            End If
        Else
            GreenTimer.Enabled = False
        End If


    End Sub




    'Remove Flag
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        flag = ""
        TimerRed.Enabled = False
        PictureBox1.Image = RaceControlManager.My.Resources.Black
        ye1 = False : ye2 = False : ye3 = False : ye4 = False : ye5 = False : ye6 = False : ye7 = False : ye8 = False : ye9 = False : ye10 = False
        dy1 = False : dy2 = False : dy3 = False : dy4 = False : dy5 = False : dy6 = False : dy7 = False : dy8 = False : dy9 = False : dy10 = False
        y1.BackColor = Color.White : y2.BackColor = Color.White : y3.BackColor = Color.White : y4.BackColor = Color.White : y5.BackColor = Color.White : y6.BackColor = Color.White : y7.BackColor = Color.White : y8.BackColor = Color.White : y9.BackColor = Color.White : y10.BackColor = Color.White
        ry1.BackColor = Color.White : ry2.BackColor = Color.White : ry3.BackColor = Color.White : ry4.BackColor = Color.White : ry5.BackColor = Color.White : ry6.BackColor = Color.White : ry7.BackColor = Color.White : ry8.BackColor = Color.White : ry9.BackColor = Color.White : ry10.BackColor = Color.White
    End Sub
End Class