Public Class inicio

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub inicio_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        BestoGame.Dispose()
    End Sub

    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = BestoGame.avanzar.ToString
        TextBox2.Text = BestoGame.acelereacion.ToString
        TextBox3.Text = BestoGame.salto.ToString
        TextBox4.Text = BestoGame.pixSubida.ToString
        TextBox5.Text = BestoGame.desasubida.ToString
        TextBox6.Text = BestoGame.caida.ToString
        TextBox7.Text = BestoGame.acelcaida.ToString
        TextBox8.Text = BestoGame.limvel.ToString

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        BestoGame.limvel = TextBox8.Text
        BestoGame.avanzar = TextBox1.Text
        BestoGame.acelereacion = TextBox2.Text
        BestoGame.salto = TextBox3.Text
        BestoGame.pixSubida = TextBox4.Text
        BestoGame.desasubida = TextBox5.Text
        BestoGame.caida = TextBox6.Text
        BestoGame.acelcaida = TextBox7.Text

    End Sub
End Class