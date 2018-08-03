Public Class inicio

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.avanzar.ToString
        TextBox2.Text = Form1.acelereacion.ToString
        TextBox3.Text = Form1.salto.ToString
        TextBox4.Text = Form1.velsubida.ToString
        TextBox5.Text = Form1.desasubida.ToString
        TextBox6.Text = Form1.caida.ToString
        TextBox7.Text = Form1.acelcaida.ToString
        TextBox8.Text = Form1.limvel.ToString

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Form1.limvel = TextBox8.Text
        Form1.avanzar = TextBox1.Text
        Form1.acelereacion = TextBox2.Text
        Form1.salto = TextBox3.Text
        Form1.velsubida = TextBox4.Text
        Form1.desasubida = TextBox5.Text
        Form1.caida = TextBox6.Text
        Form1.acelcaida = TextBox7.Text

    End Sub
End Class