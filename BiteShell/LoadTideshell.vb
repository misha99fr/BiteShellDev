Imports System.Math
Imports System.Drawing.Drawing2D
Module LoadTideshell
    Public ver As String
    Public im(12) As Image
    Public Sub LoadTdshll()
        'Оболочка
        im(1) = Image.FromFile("Avatars\1.bmp")
        im(2) = Image.FromFile("Avatars\2.jpg")
        im(3) = Image.FromFile("Avatars\3.png")
        im(4) = Image.FromFile("Avatars\4.jpeg")
        im(5) = Image.FromFile("Avatars\5.jpg")
        im(6) = Image.FromFile("Avatars\6.jpg")
        im(7) = Image.FromFile("Avatars\7.png")
        im(8) = Image.FromFile("Avatars\8.jpg")
        im(9) = Image.FromFile("Avatars\9.bmp")
        im(10) = Image.FromFile("Avatars\10.jpg")
        im(11) = Image.FromFile("Avatars\11.jpg")
        im(12) = Image.FromFile("Avatars\12.bmp")
        ver = "2.0"
        Control.Version.Text = "BiteShell Release Build " & ver
        Bite.vers.Text = "BiteShell.release.build." & ver
        Try
            Bite.oboi.BackgroundImage = Image.FromFile(GetSetting("Tideshell", "personalization", "TideWallpaper", ""))
        Catch
            Bite.oboi.BackgroundImage = Nothing
        End Try
        Try
            Bite.oboi.BackgroundImageLayout = GetSetting("Tideshell", "tidedesktop", "tide.backgroundimagelayout", ImageLayout.None)
        Catch
            Bite.oboi.BackgroundImageLayout = ImageLayout.Tile
        End Try
        Try
            Control.avatars = GetSetting("Tideshell", "personalization", "avatars")
        Catch
            Control.avatars = "0"
        End Try
        Try
            Bite.PictureBox1.Image = Image.FromFile(GetSetting("Tideshell", "personalization", "Avatarka", ""))
        Catch
            If Control.avatars = "0" Then
                Bite.PictureBox1.Image = Nothing
            ElseIf Control.avatars = "1" Then
                Bite.PictureBox1.Image = im(1)
            ElseIf Control.avatars = "2" Then
                Bite.PictureBox1.Image = im(2)
            ElseIf Control.avatars = "3" Then
                Bite.PictureBox1.Image = im(3)
            ElseIf Control.avatars = "4" Then
                Bite.PictureBox1.Image = im(4)
            ElseIf Control.avatars = "5" Then
                Bite.PictureBox1.Image = im(5)
            ElseIf Control.avatars = "6" Then
                Bite.PictureBox1.Image = im(6)
            ElseIf Control.avatars = "7" Then
                Bite.PictureBox1.Image = im(7)
            ElseIf Control.avatars = "8" Then
                Bite.PictureBox1.Image = im(8)
            ElseIf Control.avatars = "9" Then
                Bite.PictureBox1.Image = im(9)
            ElseIf Control.avatars = "10" Then
                Bite.PictureBox1.Image = im(10)
            ElseIf Control.avatars = "11" Then
                Bite.PictureBox1.Image = im(11)
            ElseIf Control.avatars = "12" Then
                Bite.PictureBox1.Image = im(12)
            Else
                MsgBox("Ах ты маленький шалунишка. В реестре балуешся?))))")
            End If
        End Try
        Beep()
    End Sub
    Public Sub LoadCntrl()
        'Панель управления
        'АВТОЗАГРУЗКА
        Control.NameUser.Text = GetSetting("Tideshell", "Information", "Username", "")
        Control.AvatarUser.Image = Bite.PictureBox1.Image
        Control.ControlPanel.Appearance = TabAppearance.FlatButtons
        Control.ControlPanel.ItemSize = New Size(0, 1)
        Control.ControlPanel.SizeMode = TabSizeMode.Fixed
        Control.ControlPanel.SelectTab(0)
        'Персонализация'
        Control.PictureBoxwallpaper.Image = Bite.oboi.BackgroundImage
        Control.TideWallpaper.Text = GetSetting("tideshell", "personalization", "TideWallpaper", "")
        Control.Avatarka.Text = GetSetting("Tideshell", "personalization", "Avatarka", "")
        Control.PictureBoxAva.Image = Bite.PictureBox1.Image
        Control.avatars = "0"
        Control.defava1.Image = im(1)
        Control.defava2.Image = im(2)
        Control.defava3.Image = im(3)
        Control.defava4.Image = im(4)
        Control.defava5.Image = im(5)
        Control.defava6.Image = im(6)
        Control.defava7.Image = im(7)
        Control.defava8.Image = im(8)
        Control.defava9.Image = im(9)
        Control.defava10.Image = im(10)
        Control.defava11.Image = im(11)
        Control.defava12.Image = im(12)
        'Пользователь'
        Control.PictureBox5.Image = Bite.PictureBox1.Image
        Control.UserName.Text = Control.NameUser.Text
        'Дата, время, регион'
        Dim Rectangle = New Rectangle(Control.PictureBox1.Location.X, Control.PictureBox1.Location.Y, Control.PictureBox1.Width, Control.PictureBox1.Height)
        Rectangle.Location = New Point(Rectangle.Location.X + 4, Rectangle.Location.Y + 4)
        Control.sec = Date.Now.Second
        Control.min = Date.Now.Minute
        Control.ch = Date.Now.Hour
        Control.time()
        'Сведения о оболочке'
        Dim ram As UInteger
        ram = ((My.Computer.Info.TotalPhysicalMemory / 1000) / 1000) / 1000
        Control.RemandRam.Text = ram & " Гигабайт"
    End Sub
End Module
