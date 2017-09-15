Public Class Registro

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        Dim usus As New Ususario(Val(TDni.Text), TNomApe.Text, TDire.Text, TLocal.Text, TProv.Text, TTelef.Text, TEmail.Text, TContra.Text, estado(), usuario(), DateTime.Value.Date())

        usus.AgregarUsuario() 'Val(TDni.Text), TNomApe.Text, TDire.Text, TLocal.Text, TProv.Text, TTelef.Text, TEmail.Text, TContra.Text, TEstado.Text, TUsu.Text, TFecha.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click

        Me.Close()
    End Sub


    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Function usuario()
        Dim var As Char
        If CBUsuario.SelectedItem = "Administrador" Then
            var = "a"

        ElseIf CBUsuario.SelectedItem = "Supervisor" Then
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