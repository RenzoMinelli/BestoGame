Public Class resultados

    Private Sub resultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub actTabla()
        Try
            Consulta = "select nombre as 'Nombre', resultado as 'Puntaje' from resultados order by 2 desc;"
            consultar()
            dgvResultados.DataSource = Tabla

        Catch ex As Exception

        End Try
    End Sub
End Class