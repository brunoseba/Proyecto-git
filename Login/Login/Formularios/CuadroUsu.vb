Public Class CuadroUsu

   
    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        Dim cli As New Cliente(Val(TDni.Text), TNomApe.Text, TDire.Text, TTelef.Text, TEmail.Text, estado(), TApellido.Text, TLocal.Text, Provin(), DateTime.Value.Date(), TPostal.Text, TCelular.Text)
        Dim res As MsgBoxResult

        res = MsgBox("Desea Agregar un nuevo usuario?", 4 + 0 + 32, "Aviso")
        If res = vbYes Then

            If cli.AgregaCliente() Then 'Val(TDni.Text), TNomApe.Text, TDire.Text, TLocal.Text, TProv.Text, TTelef.Text, TEmail.Text, TContra.Text, TEstado.Text, TUsu.Text, TFecha.Text)
                MsgBox("Cliente agregado", 0 + 0 + 64)

            Else
                MsgBox("Ocurrio un error!!")
            End If

        End If
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub


    Private Function Provin()
        Dim var As Char
        If CBProvincia.SelectedItem = "Administrador" Then
            var = "a"

        ElseIf CBProvincia.SelectedItem = "Supervisor" Then
            var = "s"

        Else
            var = "v"

        End If
        Return var
    End Function


    Private Function estado()
        Dim var As Char
        If CBEstado.SelectedItem = "Activo" Then
            var = "a"

        Else
            var = "b"

        End If
        Return var
    End Function



End Class