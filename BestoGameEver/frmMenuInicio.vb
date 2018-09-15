Public Class frmMenuInicio

    Private Sub MenuInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actTabla()
    End Sub
    Public Sub actTabla()
        Try
            dgvRanking.RowCount = 0
            Consulta = "select nombre as 'Nombre', resultado as 'Puntaje' from resultados order by 2 desc;"
            consultar()
            dgvAuxiliar.DataSource = Tabla

            dgvRanking.ColumnCount = 3
            dgvRanking.Columns(0).HeaderText = "Posición"
            dgvRanking.Columns(1).HeaderText = "Nombre"
            dgvRanking.Columns(2).HeaderText = "Puntaje"
            For x = 0 To dgvAuxiliar.RowCount - 1

                dgvRanking.Rows.Add((x + 1).ToString + "°", dgvAuxiliar.Rows(x).Cells(0).Value, dgvAuxiliar.Rows(x).Cells(1).Value)

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSinglePlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinglePlayer.Click
        Me.Hide()
        frmSinglePlayerMode.Show()
    End Sub

    Private Sub btnMultiPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiPlayer.Click
        Me.Hide()
        frmMultiPlayerMode.Show()
    End Sub


End Class