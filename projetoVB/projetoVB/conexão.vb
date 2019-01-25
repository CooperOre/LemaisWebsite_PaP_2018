Imports MySql.Data.MySqlClient

Module conexão

    Public enunciado As MySqlCommand
    Public respuesta As MySqlDataReader
    Public adaptador As MySqlDataAdapter

    Dim str As String = "server=127.0.0.1; userid=root; password=;database=bolt;"
    Dim con As New MySqlConnection(str)

    Sub reconectar()
        con.Close()
        con.Open()
    End Sub

    'Guardar la identificacion y la ruta de la imagen
    Function insertarImagen(ByVal id As String, ByVal ruta As String) As String

        Dim resultado As String = ""
        reconectar()
        Try
            enunciado = New MySqlCommand("insert into Imagenes(Id_Foto,foto) values('" & id & "','" & ruta & "')", con)
            enunciado.ExecuteNonQuery()
            resultado = "Se realizo correctamente la insercion"
            con.Close()

        Catch ex As Exception
            resultado = "No se pudo realizar el registro de manera correcta" + ex.ToString
            con.Close()

        End Try
        Return resultado
    End Function

    'Retorna la ruta apartir de la identificacion'
    Function consultacaminho(ByVal identificacion As String) As String
        reconectar()
        Dim resultado As String = ""

        Try
            enunciado = New MySqlCommand("select foto from Imagenes where Id_Foto='" & identificacion & "'", con)
            respuesta = enunciado.ExecuteReader()

            While respuesta.Read
                resultado = respuesta.Item("foto")
                respuesta.Close()
            End While


        Catch ex As Exception

        End Try
        Return resultado

    End Function

    'Despliega la lista de imagenes disponibles en el comboBox'
    Sub carregarimagem(ByVal combo As ComboBox)
        reconectar()
        Dim resultado As String = ""

        Try
            enunciado = New MySqlCommand("select Id_Foto from Imagenes", con)
            respuesta = enunciado.ExecuteReader()

            While respuesta.Read
                combo.Items.Add(respuesta.Item("Id_Foto"))
            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error al cargar las imagenes: " + ex.ToString)
        End Try

    End Sub

    'Retorna la cantidad de imagenes almacenadas en la base'
    Function cantidadImagenes() As Integer
        Dim contador As Integer = 0

        Try
            enunciado = New MySqlCommand("select * from Imagenes", con)
            respuesta = enunciado.ExecuteReader()

            While respuesta.Read
                contador += 1
            End While
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return contador
    End Function


End Module
