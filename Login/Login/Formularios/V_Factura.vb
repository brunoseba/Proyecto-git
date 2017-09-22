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

    Private Sub ButtonAceptarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptarCF.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridCFProductos.Rows.Add("0239456", "Sanchez Pedro", "Raul Perez", "21/09/2017", "Efectivo", "$2500")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim contraseña As String
       contraseña = InputBox("Ingrese Contraseña del Administrador:", "Baja de Factura")
        If contraseña = "*****" Then
            MsgBox("La factura fue dada de Baja Correctamente", 64, "Atención")
        Else
            MsgBox("Contraseña Incorrecta", 8, "Atención")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Informe Generado Correctamente", 64, "Atención")
    End Sub

End Class