Imports MySql.Data.MySqlClient

Public Class Utilizadores
    Dim str As String = "server=127.0.0.1; userid=root; password=;database=lemais;"
    Dim con As New MySqlConnection(str)

    Private Sub Utilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub

    Sub Load()
        Dim query As String = "select * from utilizadores"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBox1.Text = row.Cells(0).Value.ToString()
            TextBox4.Text = row.Cells(1).Value.ToString()
            TextBox3.Text = row.Cells(2).Value.ToString()
            TextBox2.Text = row.Cells(3).Value.ToString()
            cidade.Text = row.Cells(4).Value.ToString()
            TextBox5.Text = row.Cells(6).Value.ToString()
            TextBox6.Text = row.Cells(5).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Inserir_Click(sender As Object, e As EventArgs) Handles Inserir.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "insert into utilizadores (id,primeiro,ultimo,morada,email,password,cidade)values(@id,@primeiro,@ultimo,@morada,@email,@password,@cidade);"
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@primeiro", TextBox4.Text)
            cmd.Parameters.AddWithValue("@ultimo", TextBox3.Text)
            cmd.Parameters.AddWithValue("@morada", TextBox2.Text)
            cmd.Parameters.AddWithValue("@email", TextBox6.Text)
            cmd.Parameters.AddWithValue("@password", TextBox5.Text)
            cmd.Parameters.AddWithValue("@cidade", cidade.Text)
            cmd.ExecuteNonQuery()
            Load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Load()
    End Sub

    Private Sub Atualizar_Click(sender As Object, e As EventArgs) Handles Atualizar.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update utilizadores set primeiro=@primeiro, ultimo=@ultimo, morada=@morada, email=@email, password=@password, cidade=@cidade where id=@id"
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@primeiro", TextBox4.Text)
            cmd.Parameters.AddWithValue("@ultimo", TextBox3.Text)
            cmd.Parameters.AddWithValue("@morada", TextBox2.Text)
            cmd.Parameters.AddWithValue("@email", TextBox6.Text)
            cmd.Parameters.AddWithValue("@password", TextBox5.Text)
            cmd.Parameters.AddWithValue("@cidade", cidade.Text)
            cmd.ExecuteNonQuery()
            Load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from utilizadores where id=@id"
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@primeiro", TextBox4.Text)
            cmd.ExecuteNonQuery()
            Load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim adapater As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapater = New MySqlDataAdapter("select * from utilizadores where email like '%" & txtsearch.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            cidade.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub sair_Click(sender As Object, e As EventArgs) Handles sair.Click

        Me.Close()

    End Sub
End Class
