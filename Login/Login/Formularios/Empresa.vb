Public Class Empresas

    Private Sub ButtonGuardarEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardarEmpresa.Click
        MsgBox("Los datos fueron modificados")
        Me.Close()
    End Sub

    Private Sub ButtonSalirEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalirEmpresa.Click
        Me.Close()
    End Sub

    Private Sub ButtonEAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEAceptar.Click
        Me.Close()
    End Sub

    Private Sub Empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LabelEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelEmail.Click

    End Sub
End Class