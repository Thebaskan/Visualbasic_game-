Public Class Form1
    Public araba1hiz, araba2hiz As Integer
    Public araba1isim, araba2isim As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Timer2.Enabled = True
        Form2.Hide()
        araba1isim = My.Settings.araba1isim
        araba2isim = My.Settings.araba2isim


        Label6.Text = My.Settings.araba1isim
        Label19.Text = My.Settings.araba2isim



        If My.Settings.araba1isim = "" Or My.Settings.araba2isim = "" Then
            Form3.ShowDialog()
            PictureBox1.Left = 12
            karakter.Left = 12
        End If


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles karakter.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.ShowDialog()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label20.Text = Label20.Text.Substring(1) + Label20.Text.Substring(0, 1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        araba1isim = My.Settings.araba1isim
        araba2isim = My.Settings.araba2isim


        Label6.Text = My.Settings.araba1isim
        Label19.Text = My.Settings.araba2isim


        Randomize()
        araba1hiz = Math.Ceiling(Rnd() * 10)
        PictureBox1.Left = PictureBox1.Left + araba1hiz

        araba2hiz = Math.Ceiling(Rnd() * 10)
        karakter.Left = karakter.Left + araba2hiz

        If PictureBox1.Left > Label1.Left Then
            Timer1.Stop()
            MsgBox(araba1isim & " KAZANDI ")
            PictureBox1.Left = 12
            karakter.Left = 12



        End If


        If karakter.Left > Label1.Left Then
            Timer1.Stop()
            MsgBox(araba2isim & " KAZANDI ")
            PictureBox1.Left = 12
            karakter.Left = 12

        End If





    End Sub


End Class
