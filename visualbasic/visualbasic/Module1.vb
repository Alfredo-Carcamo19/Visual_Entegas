Imports MySql.Data.MySqlClient

Module Module1

    ' Función que crea y abre una conexión con la base de datos MySQL
    Public Function conectar() As MySqlConnection
        Dim conexion As New MySqlConnection
        Try
            ' ¡OJO! Revisa y ajusta esta cadena de conexión con tus datos.
            ' El password="1234" podría ser diferente en tu caso o no tener contraseña.
            conexion.ConnectionString = "server=localhost; user id=root; password=1234; database=inventario;"
            conexion.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido realizar la conexión a la base de datos.")
            ' Cierra la aplicación si no se puede conectar
            End
        End Try
        Return conexion
    End Function

    Function cargar_grid(ByVal sql As String, ByVal conn As MySqlConnection) As DataTable
        Dim da As New MySqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        ' Llenar el dataset con los datos de la consulta
        da.Fill(ds)
        ' Devolver la primera tabla del dataset
        Return ds.Tables(0)
    End Function

    Public CurrentUserRole As String = ""

End Module