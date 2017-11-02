Imports System.Windows.Forms

Public Class Ventana

    Private Sub Ventana_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim usu As New Ususario(Inicio_Sesion.Tusuario.Text)
        usu.Dato(usu.GetDni(), usu.GetNomYape())
        If usu.GetTipoUsu = "a" And usu.GetEstado = "a" Then
            Me.usuario.Text = ("Administrador :  " + usu.GetNomYape())
            Me.usuario.Image = My.Resources.user_gray
            Me.cargo.Text = "admin"
            Me.MenuClientes.Visible = False
            Me.MenuClientesAgregar.Enabled = False
            Me.MenuClientesMostrar.Enabled = False
            Me.MenuFacturas.Visible = False
            Me.GenerarInformeToolStripMenuItem.Enabled = False
            Me.CancelarFacturaToolStripMenuItem.Enabled = False
        ElseIf usu.GetTipoUsu = "s" And usu.GetEstado = "a" Then
            Me.BackgroundImage = My.Resources.bridgestone_wallpapers_163
            Me.usuario.Text = ("Supervisor :  " + usu.GetNomYape())
            Me.usuario.Image = My.Resources.user_suit
            Me.BackUp.Visible = False
            Me.BackUp.Enabled = False
            Me.Productos.Visible = False
            Me.AgregarProductoToolStripMenuItem.Enabled = False
            Me.BuscarProductosToolStripMenuItem.Enabled = False
            Me.AgregarToolStripMenuItem.Visible = False
            Me.AgregarToolStripMenuItem.Enabled = False
            Me.MenuClientesAgregar.Visible = False
            Me.MenuClientesAgregar.Enabled = False
            Me.MenuEmpresa.Visible = False
            Me.MenuEmpresa.Enabled = False
            Me.cargo.Text = "supervisor"
        Else
            'Me.BackgroundImage = My.Resources.BRIDGESTONE_MOTOGP__7_
            Me.usuario.Text = ("Vendedor :  " + usu.GetNomYape())
            Me.usuario.Image = My.Resources.user_orange
            Me.BackUp.Visible = False
            Me.BackUp.Enabled = False
            Me.Productos.Visible = False
            Me.AgregarProductoToolStripMenuItem.Enabled = False
            Me.BuscarProductosToolStripMenuItem.Enabled = False
            Me.MenuUsuarios.Visible = False
            Me.AgregarToolStripMenuItem.Enabled = False
            Me.BuscarToolStripMenuItem.Enabled = False
            Me.MenuFacturas.Visible = False
            Me.GenerarInformeToolStripMenuItem.Enabled = False
            Me.CancelarFacturaToolStripMenuItem.Enabled = False
            Me.MenuEmpresa.Visible = False
            Vendedor.Show()
            Vendedor.MdiParent = Me
            Vendedor.cargarLoad()
            Me.UserFacturaToolStripMenuItem.Text = usu.GetNomYape()
            Me.DniToolStripMenuItem.Text = usu.GetDni()
            Me.cargo.Text = "vende"
        End If
    End Sub


    Private Sub MenuClientesAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientesAgregar.Click
        CuadroCliente.MaximizeBox = True
        CuadroCliente.Show()
        CuadroCliente.PanelRegistro.Visible = True
        CuadroCliente.PanelBusca.Visible = False
        CuadroCliente.PanelVer.Visible = False
        CuadroCliente.MdiParent = Me

    End Sub

    Private Sub MenuClientesMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuClientesMostrar.Click
        CuadroCliente.MaximizeBox = True
        CuadroCliente.Show()
        CuadroCliente.PanelBusca.Visible = True
        CuadroCliente.PanelRegistro.Visible = False
        CuadroCliente.CBEstaCli.SelectedIndex = 0
        CuadroCliente.MdiParent = Me
        CuadroCliente.resaltarClienteBaja(CuadroCliente.DataGridCliente)
    End Sub


    Private Sub MenuProductosMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Principal.PanelProductos.Visible = True
        'V_Producto.PanelProductosBuscar.Visible = True
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        CuadroUsuario.MaximizeBox = True
        CuadroUsuario.Show()
        CuadroUsuario.BSalir3.Visible = False
        CuadroUsuario.PanelBusca.Visible = True
        CuadroUsuario.CBUsuario.SelectedIndex = 0
        CuadroUsuario.MdiParent = Me
        CuadroUsuario.resaltarBaja(CuadroUsuario.DataGridView1)
    End Sub


    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Inicio_Sesion.Show()
        Me.Close()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        CuadroUsuario.MaximizeBox = True
        CuadroUsuario.Show()
        CuadroUsuario.TDni1.Focus()
        CuadroUsuario.BSalir3.Visible = True
        CuadroUsuario.PanelRegistro.Visible = True
        CuadroUsuario.PanelBusca.Visible = False
        CuadroUsuario.CBUsu.SelectedIndex = 2
        CuadroUsuario.CBEsta1.SelectedIndex = 0
        CuadroUsuario.MdiParent = Me

    End Sub

    Private Sub VerProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Vendedor.Show()
        Vendedor.PanelBuscarProductoVendedor.Visible = True
        Vendedor.MdiParent = Me

    End Sub

    Private Sub BuscarProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProductosToolStripMenuItem.Click
        V_Producto.PanelAgregarProductos.Visible = False
        V_Producto.PanelProductosBuscar.Visible = True
        V_Producto.MaximizeBox = True
        V_Producto.Show()
        V_Producto.ComboBox1.SelectedIndex = 0
        V_Producto.ComboBox2.SelectedIndex = 0
        V_Producto.PanelMostrarDatosTecnicos.Visible = False
        V_Producto.PanelActualizarStock.Visible = False
        V_Producto.PanelAgregarProductos.Visible = False
        V_Producto.MdiParent = Me
        V_Producto.cargarLoad()
        V_Producto.resaltarProductosBaja(V_Producto.DataGridViewResultadosProductos)
    End Sub

    Private Sub MenuEmpresaVerDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmpresaVerDatos.Click
        Empresas.MaximizeBox = True
        Empresas.Show()
        Empresas.Panel_modificar_Empresa.Visible = False
        Empresas.Panel_Ver_Datos_Empresa.Visible = True
        Empresas.MdiParent = Me
    End Sub

    Private Sub MenuEmpresaModificarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuEmpresaModificarDatos.Click
        Empresas.MaximizeBox = True
        Empresas.Show()
        Empresas.Panel_Ver_Datos_Empresa.Visible = False
        Empresas.Panel_modificar_Empresa.Visible = True
        Empresas.MdiParent = Me
    End Sub

    Private Sub VerFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Factura.MaximizeBox = True
        V_Factura.Show()
        V_Factura.Panel_Cancelar_Factura.Visible = False
        V_Factura.Panel_Informe_Factura.Visible = False
        V_Factura.MdiParent = Me
    End Sub

    Private Sub GenerarInformeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarInformeToolStripMenuItem.Click
        V_Factura.MaximizeBox = True
        V_Factura.Show()
        V_Factura.Panel_Cancelar_Factura.Visible = False
        V_Factura.Panel_Informe_Factura.Visible = True
        V_Factura.MdiParent = Me
        Dim fatura As New Facturas()
        fatura.MostrarTodasFacturas(V_Factura.DataGridView1)
        For Each fila As DataGridViewRow In V_Factura.DataGridView1.Rows
            If fila.Cells("Estado").Value = "Anulada" Then
                fila.Cells("Estado").Style.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub CancelarFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarFacturaToolStripMenuItem.Click
        V_Factura.MaximizeBox = True
        V_Factura.Show()
        V_Factura.Panel_Informe_Factura.Visible = False
        V_Factura.Panel_Cancelar_Factura.Visible = True
        V_Factura.MdiParent = Me
    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        V_Producto.MaximizeBox = True
        V_Producto.ComboBoxMedidaProducto.SelectedIndex = 0
        V_Producto.ComboBoxRodadoProducto.SelectedIndex = 0
        V_Producto.ComboBoxTipoVehiculo.SelectedIndex = 0
        V_Producto.TextBoxNombreProducto.Text = ""
        V_Producto.TextBoxPrecio.Text = ""
        V_Producto.TextBoxStock.Text = ""
        V_Producto.LabelRutaArchivo.Text = "Ruta:"
        V_Producto.PictureBox1.Image = My.Resources.image_not_found__1_
        V_Producto.Show()
        V_Producto.PanelAgregarProductos.Visible = True
        V_Producto.PanelProductosBuscar.Visible = False
        V_Producto.TextBoxNombreProducto.Focus()
        V_Producto.ButtonAgregarProducto.Visible = True
        V_Producto.Button4.Visible = True
        V_Producto.ButtonBajaProducto.Visible = False
        V_Producto.ButtonAltaProducto.Visible = False
        V_Producto.ButtonActualizarProducto.Visible = False
        V_Producto.MdiParent = Me
    End Sub

    Private Sub CargarStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Producto.MaximizeBox = True
        V_Producto.Show()
        V_Producto.PanelAgregarProductos.Visible = False
        V_Producto.PanelMostrarDatosTecnicos.Visible = False
        V_Producto.PanelActualizarStock.Visible = False
        V_Producto.PanelProductosBuscar.Visible = True
        V_Producto.MdiParent = Me
    End Sub

End Class
