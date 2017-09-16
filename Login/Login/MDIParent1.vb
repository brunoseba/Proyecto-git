Imports System.Windows.Forms

Public Class Ventana

    Private Sub Ventana_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim usu As New Ususario(Form1.Tusuario.Text)
        usu.Dato(usu.GetDni(), usu.GetNomYape())
        If usu.GetTipoUsu = "a" And usu.GetEstado = "a" Then
            'Principal.MaximizeBox = True
            'Principal.ControlBox = False
            'Principal.StartPosition = FormStartPosition.CenterScreen
            'Principal.Show()
            'Principal.MdiParent = Me
            Registro.Show()
            Registro.MdiParent = Me

        ElseIf usu.GetTipoUsu = "s" And usu.GetEstado = "a" Then
            Principal.Show()
            Principal.MdiParent = Me
        End If
    End Sub


    Private Sub MenuClientesAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientesAgregar.Click
        Principal.PanelBuscarClientes.Visible = False
        Principal.PanelClientes.Visible = True
        Principal.PanelMostrarCliente.Visible = False
        Principal.PanelAgregarModificarCliente.Visible = True


    End Sub

    Private Sub MenuClientesMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientesMostrar.Click
        'BuscaModifica.Show()
        'Principal.PanelBuscarClientes.Visible = True
        'Principal.PanelClientes.Visible = True
        'Principal.PanelMostrarCliente.Visible = True
        'Principal.PanelAgregarModificarCliente.Visible = False
    End Sub

    Private Sub MenuClientesModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientesModificar.Click
        Principal.PanelBuscarClientes.Visible = True
        Principal.PanelClientes.Visible = True
        Principal.PanelMostrarCliente.Visible = False
        Principal.PanelAgregarModificarCliente.Visible = True
    End Sub

    Private Sub MenuProductosAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProductosAgregar.Click
        Principal.PanelProductos.Visible = True
        Principal.PanelAgregarProductos.Visible = True
        Principal.PanelBuscarProducto.Visible = True

    End Sub

    Private Sub MenuProductosMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProductosMostrar.Click
        Principal.PanelProductos.Visible = True
        Principal.PanelProductosBuscar.Visible = True
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click

        BuscaModifica.Show()

    End Sub

    
    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
