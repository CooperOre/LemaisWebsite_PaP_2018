Imports MySql.Data.MySqlClient
Public Class Doações
    Dim str As String = "server=127.0.0.1; userid=root; password=;database=lemais;"
    Dim con As New MySqlConnection(str)
    Sub Load()
        Dim query As String = "select * from livros_venda"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Doações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update livros_venda set estado=@estado where id_venda=@id_venda"
            cmd.Parameters.AddWithValue("@id_venda", TextBox1.Text)
            cmd.Parameters.AddWithValue("@estado", TextBox2.Text)
            cmd.ExecuteNonQuery()
            Load()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBox1.Text = row.Cells(0).Value.ToString()
            TextBox2.Text = row.Cells(7).Value.ToString()
        Catch ex As Exception
        End Try
    End Sub
End Class