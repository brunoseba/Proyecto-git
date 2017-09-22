Public Class V_Factura

    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        MsgBox("Ingrese el número de Factura sin guinoes y/o espacios", 64, "Atención")

    End Sub

    Private Sub ButtonAceptarF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptarF.Click
        Me.Close()
    End Sub
End Class