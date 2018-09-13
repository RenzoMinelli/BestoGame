Public Class Cambios

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub inicio_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        SinglePlayerMode.Dispose()
    End Sub

    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = SinglePlayerMode.avanzar.ToString
        TextBox2.Text = SinglePlayerMode.acelereacion.ToString
        TextBox3.Text = SinglePlayerMode.salto.ToString
        TextBox4.Text = SinglePlayerMode.pixSubida.ToString
        TextBox5.Text = SinglePlayerMode.desasubida.ToString
        TextBox6.Text = SinglePlayerMode.caida.ToString
        TextBox7.Text = SinglePlayerMode.acelcaida.ToString
        TextBox8.Text = SinglePlayerMode.limvel.ToString

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        SinglePlayerMode.limvel = TextBox8.Text
        SinglePlayerMode.avanzar = TextBox1.Text
        SinglePlayerMode.acelereacion = TextBox2.Text
        SinglePlayerMode.salto = TextBox3.Text
        SinglePlayerMode.pixSubida = TextBox4.Text
        SinglePlayerMode.desasubida = TextBox5.Text
        SinglePlayerMode.caida = TextBox6.Text
        SinglePlayerMode.acelcaida = TextBox7.Text

    End Sub
End Class