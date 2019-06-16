Public Class Acerca
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.facebook.com/marciomreis?ref=bookmarks")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://twitter.com/marciomreis1")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://www.facebook.com/marciomreis")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class