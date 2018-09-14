Public Class frmNotificacion


    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        Me.Dispose()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Notificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class