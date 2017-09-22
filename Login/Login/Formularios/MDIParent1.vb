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

            Me.usuario.Text = ("Administrador :  " + usu.GetNomYape())
            Me.usuario.Image = My.Resources.user_gray



        ElseIf usu.GetTipoUsu = "s" And usu.GetEstado = "a" Then
            'Principal.Show()
            Me.BackgroundImage = My.Resources.bridgestone_wallpapers_163
            Me.usuario.Text = ("Supervisor :  " + usu.GetNomYape())
            Me.usuario.Image = My.Resources.user_suit
            'Principal.MdiParent = Me
            Me.MenuClientes.Visible = False
            Me.MenuUsuarios.Visible = False
            Me.MenuEmpresa.Visible = False

        Else
           
            Me.BackgroundImage = My.Resources.BRIDGESTONE_MOTOGP__7_

            Me.usuario.Text = ("Vendedor :  " + usu.GetNomYape())
            Me.usuario.Image = My.Resources.user_orange
            Me.MenuUsuarios.Visible = False
            Me.MenuEmpresa.Visible = False
            Me.MenuFacturas.Visible = False
            Me.AgregarProductoToolStripMenuItem.Visible = False
            Me.BuscarProductosToolStripMenuItem.Visible = False
            Me.ModificarProductosToolStripMenuItem.Visible = False
            Me.CargarStockToolStripMenuItem.Visible = False
            Me.EliminarProductosToolStripMenuItem.Visible = False
            Vendedor.Show()
            Vendedor.PanelCarrito.Visible = False
            Vendedor.MdiParent = Me
        End If
    End Sub


    Private Sub MenuClientesAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientesAgregar.Click
        CuadroUsu.MaximizeBox = True
        CuadroUsu.Show()
        CuadroUsu.PanelRegistro.Visible = True
        CuadroUsu.PanelBusca.Visible = False
        CuadroUsu.PanelVer.Visible = False
        CuadroUsu.MdiParent = Me

        'Principal.PanelBuscarClientes.Visible = False
        'Principal.PanelClientes.Visible = True
        'Principal.PanelMostrarCliente.Visible = False
        'Principal.PanelAgregarModificarCliente.Visible = True


    End Sub

    Private Sub MenuClientesMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientesMostrar.Click
        CuadroUsu.MaximizeBox = True
        CuadroUsu.Show()
        CuadroUsu.PanelBusca.Visible = True
        CuadroUsu.PanelRegistro.Visible = False
        CuadroUsu.MdiParent = Me
    End Sub

    Private Sub MenuClientesModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Principal.PanelBuscarClientes.Visible = True
        'Principal.PanelClientes.Visible = True
        'Principal.PanelMostrarCliente.Visible = False
        'Principal.PanelAgregarModificarCliente.Visible = True
    End Sub

    Private Sub MenuProductosAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Principal.PanelProductos.Visible = True
        'Principal.PanelAgregarProductos.Visible = True
        'Principal.PanelBuscarProducto.Visible = True

    End Sub

    Private Sub MenuProductosMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Principal.PanelProductos.Visible = True
        Principal.PanelProductosBuscar.Visible = True
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        BuscaModifica.MaximizeBox = True
        BuscaModifica.Show()
        BuscaModifica.PanelBusca.Visible = True
        BuscaModifica.MdiParent = Me

    End Sub

    
    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        BuscaModifica.MaximizeBox = True
        BuscaModifica.Show()
        BuscaModifica.PanelRegistro.Visible = True
        BuscaModifica.PanelBusca.Visible = False
        BuscaModifica.MdiParent = Me

    End Sub

    Private Sub MenuClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientes.Click

    End Sub

    Private Sub VerProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerProductosToolStripMenuItem.Click
        Vendedor.Show()
        Vendedor.PanelBuscarProducto.Visible = True
        Vendedor.PanelResultadosProductos.Visible = True
        Vendedor.MdiParent = Me

    End Sub

    Private Sub BuscarProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProductosToolStripMenuItem.Click

    End Sub

    Private Sub MenuEmpresaVerDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmpresaVerDatos.Click
        Empresa.MaximizeBox = True
        Empresa.Show()
        Empresa.Panel_modificar_Empresa.Visible = False
        Empresa.Panel_Ver_Datos_Empresa.Visible = True
        Empresa.MdiParent = Me
    End Sub

    Private Sub MenuEmpresaModificarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmpresaModificarDatos.Click
        Empresa.MaximizeBox = True
        Empresa.Show()
        Empresa.Panel_Ver_Datos_Empresa.Visible = False
        Empresa.Panel_modificar_Empresa.Visible = True
        Empresa.MdiParent = Me
    End Sub

    Private Sub VerFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerFacturasToolStripMenuItem.Click
        V_Factura.MaximizeBox = True
        V_Factura.Show()
        V_Factura.Panel_Informe_Factura.Visible = False
        V_Factura.Panel_VerFacturas.Visible = True
        V_Factura.MdiParent = Me
    End Sub

    Private Sub GenerarInformeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarInformeToolStripMenuItem.Click
        V_Factura.MaximizeBox = True
        V_Factura.Show()
        V_Factura.Panel_VerFacturas.Visible = False
        V_Factura.Panel_Informe_Factura.Visible = True
        V_Factura.MdiParent = Me
    End Sub
End Class
