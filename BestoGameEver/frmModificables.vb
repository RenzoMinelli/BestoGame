Public Class frmModificables

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub inicio_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frmSinglePlayerMode.Dispose()
    End Sub

    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = frmSinglePlayerMode.avanzar.ToString
        TextBox2.Text = frmSinglePlayerMode.acelereacion.ToString
        TextBox3.Text = frmSinglePlayerMode.salto.ToString
        TextBox4.Text = frmSinglePlayerMode.pixSubida.ToString
        TextBox5.Text = frmSinglePlayerMode.desasubida.ToString
        TextBox6.Text = frmSinglePlayerMode.caida.ToString
        TextBox7.Text = frmSinglePlayerMode.acelcaida.ToString
        TextBox8.Text = frmSinglePlayerMode.limvel.ToString

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        frmSinglePlayerMode.limvel = TextBox8.Text
        frmSinglePlayerMode.avanzar = TextBox1.Text
        frmSinglePlayerMode.acelereacion = TextBox2.Text
        frmSinglePlayerMode.salto = TextBox3.Text
        frmSinglePlayerMode.pixSubida = TextBox4.Text
        frmSinglePlayerMode.desasubida = TextBox5.Text
        frmSinglePlayerMode.caida = TextBox6.Text
        frmSinglePlayerMode.acelcaida = TextBox7.Text

    End Sub
End Class