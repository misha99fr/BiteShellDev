﻿Imports Tideshell.LoadTideshell
Public Class Bite
    Dim i As String
    Public under = "Разработка идет"
    Private Sub Tideshell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTdshll()
    End Sub

    Private Sub ShkafBlyat_Click(sender As System.Object, e As System.EventArgs) Handles ShkafBlyat.Click
        Calendar.Visible = False
        Panel3.Visible = False
        MsgBox("В следующем билде будет удален Шкаф.exe")
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)
        Time.Text = Now.ToLongTimeString
        Data.Text = Now.Date
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panel3.Visible = False
        Calendar.Visible = False
        Beep()
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Calendar.Visible = False
        Panel3.Visible = True
    End Sub
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Panel3.Visible = False
        Calendar.Visible = False
    End Sub
    Private Sub Tide_Click(sender As Object, e As EventArgs)
        Panel3.Visible = False
        Calendar.Visible = False
    End Sub
    Private Sub Tide_Paint(sender As Object, e As PaintEventArgs)
        Panel3.Visible = False
        Calendar.Visible = False
    End Sub
    Private Sub vers_Click(sender As Object, e As EventArgs) Handles vers.Click
        Panel3.Visible = False
        Calendar.Visible = False
    End Sub
    Private Sub NewControlButton_Click(sender As Object, e As EventArgs) Handles NewControlButton.Click
        i = i + 5
        Panel3.Visible = False
        Calendar.Visible = False
        If i = 10 Then
            MsgBox("Поздравляю! Ты нашёл секретную пасхалку. 10 мая родился создатель этой оболочки", 0 + 64, "Пасхалка!")
        End If
        Control.ShowDialog()
    End Sub
    Private Sub oboi_Click(sender As Object, e As EventArgs) Handles oboi.Click
        Panel3.Visible = False
        Calendar.Visible = False
    End Sub
    Private Sub Data_Click(sender As Object, e As EventArgs) Handles Data.Click
        Panel3.Visible = False
        Calendar.Visible = True
    End Sub
    Private Sub Time_Click(sender As Object, e As EventArgs) Handles Time.Click
        Panel3.Visible = False
        Calendar.Visible = True
    End Sub
    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Panel3.Visible = False
        Calendar.Visible = True
    End Sub

    Private Sub oboi_Paint(sender As Object, e As PaintEventArgs) Handles oboi.Paint

    End Sub
End Class
