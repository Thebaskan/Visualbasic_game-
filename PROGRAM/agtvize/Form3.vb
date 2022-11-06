Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.araba1isim = TextBox1.Text
        My.Settings.araba2isim = TextBox2.Text
        My.Settings.Save()
        Form1.Show()
        Me.Close()




    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.araba1isim
        TextBox2.Text = My.Settings.araba2isim

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextBox2.SelectedIndexChanged

    End Sub
End Class