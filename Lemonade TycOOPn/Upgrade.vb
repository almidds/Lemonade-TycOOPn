﻿Public Class Upgrade
    Dim upgradeMultiplier As Integer = 1
    Private Sub Upgrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Log_in.newplayer.getmoney()
    End Sub
    Private Sub Upgrade_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Label2.Text = Log_in.newplayer.getmoney()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Log_in.newplayer.setmoney(-100)
        Label2.Text = Log_in.newplayer.getmoney()
        upgradeMultiplier *= 2
        Button2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub


End Class