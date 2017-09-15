Public Class BuscaModifica

    Public Function usuario() As Char
        If CBUsuario.SelectedItem = "Administrador" Then
            Return "a"

        ElseIf CBUsuario.SelectedItem = "Supervisor" Then
            Return "s"

        Else
            Return "v"
        End If
    End Function


    Public Function estado() As Char
        If CBEstado.SelectedItem = "Activo" Then
            Return "a"

        Else
            Return "b"

        End If
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim usu As New Ususario
        Dim modi As Button
        If CBUsuario IsNot Nothing Or CBEstado IsNot Nothing Then

            TDni.Text = 11111
            usu.muestra(DataGridView1, TDni.Text, TNombre.Text, usuario(), estado())
        End If

    End Sub

    Private Sub CBUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUsuario.SelectedIndexChanged
        If CBUsuario IsNot Nothing Then
            TDni.Visible = False

        End If
    End Sub

    Private Sub CBEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEstado.SelectedIndexChanged
        If CBEstado IsNot Nothing Then
            TDni.Visible = False

        End If
    End Sub
End Class