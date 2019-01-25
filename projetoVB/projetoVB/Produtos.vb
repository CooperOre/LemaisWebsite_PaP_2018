Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Produtos

    Dim imagem As String

    Dim str As String = "server=127.0.0.1; userid=root; password=;database=bolt;"
    Dim con As New MySqlConnection(str)

    Sub carregarimagem()
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then

                imagem = OpenFileDialog1.FileName
                Dim largo As Integer = imagem.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(imagem), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(imagem), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If
                    PictureBox1.Load(imagem)
                End If
            End If
        Catch ex As Exception

        End Try
        PictureBox1.Load(imagem)
    End Sub

    Sub Load()
        Dim query As String = "select * from products"
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
        textoprocura.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
        If cantidadImagenes() > 0 Then
            cantidadImagenes(cbImagenes)
            cbImagenes.SelectedIndex = 0
        Else
            MsgBox("Não existe imagens")
        End If


        Dim command As New MySqlCommand("select * from products", con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.DataSource = table
        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        imgc = DataGridView1.Columns(4)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub Inserir_Click(sender As Object, e As EventArgs) Handles Inserir.Click
        Dim cmd As MySqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand
            cmd.CommandText = "insert into products (id,product_code,product_name,product_desc,qty,price)values(@id,@product_code,@product_name,@product_desc,@qty,@price);"
            cmd.Parameters.AddWithValue("@id", TextBox1.Text)
            cmd.Parameters.AddWithValue("@product_code", TextBox2.Text)
            cmd.Parameters.AddWithValue("@product_name", TextBox3.Text)
            cmd.Parameters.AddWithValue("@product_desc", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@qty", TextBox4.Text)
            cmd.Parameters.AddWithValue("@price", TextBox5.Text)
            cmd.ExecuteNonQuery()
            Load()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        carregarimagem()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextBox1.Text = row.Cells(0).Value.ToString()
            TextBox2.Text = row.Cells(1).Value.ToString()
            TextBox3.Text = row.Cells(2).Value.ToString()
            RichTextBox1.Text = row.Cells(3).Value.ToString()
            TextBox4.Text = row.Cells(5).Value.ToString()
            TextBox5.Text = row.Cells(6).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim nombre As String = InputBox("Escreva o nome da imagem que quer procurar")
        MsgBox(insertarImagen(nombre, imagem))
        carregarimagem(cbImagenes)
        cbImagenes.SelectedIndex = 0
        PictureBox1.Image = Nothing
    End Sub

    Private Sub carregarimagem(cbImagenes As ComboBox)
        Throw New NotImplementedException()
    End Sub

    Private Sub cbImagenes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbImagenes.SelectedIndexChanged
        Dim caminho As String = consultacaminho(cbImagenes.SelectedItem.ToString)
        PictureBox1.Load(caminho)
    End Sub
End Class