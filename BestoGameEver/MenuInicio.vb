Public Class MenuInicio

    Private Sub MenuInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actTabla()
    End Sub
    Public Sub actTabla()
        Try
            Consulta = "select nombre as 'Nombre', resultado as 'Puntaje' from resultados order by 2 desc;"
            consultar()
            dgvResultados.DataSource = Tabla

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSinglePlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinglePlayer.Click
        Me.Hide()
        SinglePlayerMode.Show()
    End Sub

    Private Sub btnMultiPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiPlayer.Click
        Me.Hide()
        MultiPlayerMode.Show()
    End Sub


End Class