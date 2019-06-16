Public Class Início
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Utilizadores.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Produtos.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ordens.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("http://localhost/oficial_pap/")
    End Sub

    Private Sub InformaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaçõesToolStripMenuItem.Click
        Acerca.Show()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Doações.Show()
    End Sub

    Private Sub Início_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class