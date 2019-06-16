Imports MySql.Data.MySqlClient

Public Class login

    Dim str As String = "server=127.0.0.1; userid=root; password=;database=lemais; "
    Dim con As New MySqlConnection(str)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim command As New MySqlCommand("select * from admins where nome = @nome and password = @password", con)
        command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Nome ou palavra-passe errados")
        Else
            Início.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class