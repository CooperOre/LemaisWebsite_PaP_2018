Imports MySql.Data.MySqlClient

Public Class Produtos
    Dim str As String = "server=127.0.0.1; userid=root; password=;database=lemais;"
    Dim con As New MySqlConnection(str)

    Sub Load()
        Dim reader As MySqlDataReader
        Try
            con.Open()
            Dim query1 As String
            query1 = "select * from lemais.livros_venda"

            Dim Comando As New MySqlCommand(query1, con)
            reader = Comando.ExecuteReader
            While reader.Read
                Dim isbn = reader.GetString("isbn")
                ComboBox1.Items.Add(isbn)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        Dim query As String = "select * from produtos"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        RichTextBox1.Clear()
        txtsearch.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox7.Clear()
        TextBox9.Clear()
        imagem.Clear()
    End Sub

    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub

    Private Sub Inserir_Click(sender As Object, e As EventArgs) Handles Inserir.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "insert into produtos (id,isbn,titulo,sinopse,autor,edicao,editora,imagem_produto,quantidade,preco)values(@id,@isbn,@titulo,@sinopse,@autor,@edicao,@editora,@imagem_produto,@quantidade,@preco);"
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@isbn", TextBox2.Text)
            cmd.Parameters.AddWithValue("@titulo", TextBox3.Text)
            cmd.Parameters.AddWithValue("@sinopse", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@autor", TextBox6.Text)
            cmd.Parameters.AddWithValue("@edicao", TextBox7.Text)
            cmd.Parameters.AddWithValue("@editora", TextBox9.Text)
            cmd.Parameters.AddWithValue("@quantidade", TextBox4.Text)
            cmd.Parameters.AddWithValue("@preco", TextBox5.Text)
            cmd.Parameters.AddWithValue("@imagem_produto", imagem.Text)
            cmd.ExecuteNonQuery()
            Load()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBox1.Text = row.Cells(0).Value.ToString()
            TextBox2.Text = row.Cells(1).Value.ToString()
            TextBox3.Text = row.Cells(2).Value.ToString()
            RichTextBox1.Text = row.Cells(6).Value.ToString()
            TextBox4.Text = row.Cells(8).Value.ToString()
            TextBox5.Text = row.Cells(9).Value.ToString()
            TextBox6.Text = row.Cells(3).Value.ToString()
            TextBox7.Text = row.Cells(4).Value.ToString()
            TextBox9.Text = row.Cells(5).Value.ToString()
            imagem.Text = row.Cells(7).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Atualizar_Click(sender As Object, e As EventArgs) Handles Atualizar.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update produtos set isbn=@isbn, titulo=@titulo, sinopse=@sinopse, quantidade=@quantidade, preco=@preco, autor=@autor, edicao=@edicao, editora=@editora, imagem_produto=@imagem_produto where id=@id"
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@isbn", TextBox2.Text)
            cmd.Parameters.AddWithValue("@titulo", TextBox3.Text)
            cmd.Parameters.AddWithValue("@sinopse", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@autor", TextBox6.Text)
            cmd.Parameters.AddWithValue("@edicao", TextBox7.Text)
            cmd.Parameters.AddWithValue("@editora", TextBox9.Text)
            cmd.Parameters.AddWithValue("@quantidade", TextBox4.Text)
            cmd.Parameters.AddWithValue("@preco", TextBox5.Text)
            cmd.Parameters.AddWithValue("@imagem_produto", imagem.Text)
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
            cmd.CommandText = "delete from produtos where id=@id"
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@isbn", TextBox2.Text)
            cmd.ExecuteNonQuery()
            Load()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Load()
    End Sub

    Private Sub textoprocura_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim adapater As MySqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapater = New MySqlDataAdapter("select * from produtos where titulo like '%" & txtsearch.Text & "%'", con)
            adapater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox9.Clear()
            RichTextBox1.Clear()
            imagem.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim str As String = "server=127.0.0.1; userid=root; password=;database=lemais;"
        Dim con As New MySqlConnection(str)

        Dim reader As MySqlDataReader
        Try
            con.Open()
            Dim query1 As String
            query1 = "select * from lemais.livros_venda where isbn='" & ComboBox1.Text & "' "

            Dim Comando As New MySqlCommand(query1, con)
            reader = Comando.ExecuteReader
            While reader.Read
                TextBox1.Clear()
                TextBox2.Text = reader.GetString("isbn")
                TextBox3.Text = reader.GetString("titulo")
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Text = reader.GetString("autor")
                TextBox7.Text = reader.GetString("edicao")
                RichTextBox1.Clear()
                imagem.Clear()
                TextBox9.Text = reader.GetString("editora")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

    End Sub
End Class