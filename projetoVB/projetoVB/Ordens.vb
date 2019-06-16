Imports MySql.Data.MySqlClient

Public Class ordens

    Dim str As String = "server=127.0.0.1; userid=root; password=;database=lemais;"
    Dim con As New MySqlConnection(str)

    Sub Load()
        Dim query As String = "select * from ordens"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub ordens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub
End Class