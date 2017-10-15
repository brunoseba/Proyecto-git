Public Class Empresas

    Private Sub ButtonGuardarEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardarEmpresa.Click
        Dim modEmpresa As New Empresa()
        If modEmpresa.ActualizarDatos(Val(TextBoxCuitEmpresa.Text), TextBoxNombreEmpresa.Text, TextBoxDireccionEmpresa.Text, TextBoxEmailEmpresa.Text, TextBoxTelefonoEmpresa.Text) Then
            MsgBox("Los datos fueron modificados")
        Else
            MsgBox("Los datos fueron modificados")
        End If
        Me.Close()
    End Sub

    Private Sub ButtonSalirEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSalirEmpresa.Click
        Me.Close()
    End Sub

    Private Sub ButtonEAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEAceptar.Click
        Me.Close()
    End Sub

    Private Sub Empresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim emp As New Empresa()
        emp.MostrarDatosEmpresa()
        TextBoxCuitEmpresa.Text = emp.GetCuit()
        TextBoxDireccionEmpresa.Text = emp.GetDireccion()
        TextBoxEmailEmpresa.Text = emp.GetEmail()
        TextBoxNombreEmpresa.Text = emp.GetNom()
        TextBoxTelefonoEmpresa.Text = emp.GetTelefono()

        LabelCuit.Text = emp.GetCuit()
        LabelDireccion.Text = emp.GetDireccion()
        LabelEmail.Text = emp.GetEmail()
        LabelTelefono.Text = emp.GetTelefono()
        LabelNombre.Text = emp.GetNom()

    End Sub
End Class