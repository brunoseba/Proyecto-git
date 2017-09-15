<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventana))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuUsuarioVendedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioVendedorAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioVendedorModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioVendedorMostrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioVendedorEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraMenu = New System.Windows.Forms.MenuStrip()
        Me.MenuProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuProductosAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuProductosMostrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuProductosModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuProductosCargarStock = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuProductosEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuClientesAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuClientesMostrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuClientesModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuClientesEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioAdministrador = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioAdministradorAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioAdministradorModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioAdministradorMostrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioAdministradorEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioSupervisor = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioSupervisorAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioSupervisorModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioSupervisorMostrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarioSupervisorEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFacturas = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarInformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEmpresaVerDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEmpresaModificarDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSeesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraMenu.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuUsuarioVendedor
        '
        Me.MenuUsuarioVendedor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUsuarioVendedorAlta, Me.MenuUsuarioVendedorModificar, Me.MenuUsuarioVendedorMostrar, Me.MenuUsuarioVendedorEliminar})
        Me.MenuUsuarioVendedor.Name = "MenuUsuarioVendedor"
        Me.MenuUsuarioVendedor.Size = New System.Drawing.Size(152, 22)
        Me.MenuUsuarioVendedor.Text = "Vendedor"
        '
        'MenuUsuarioVendedorAlta
        '
        Me.MenuUsuarioVendedorAlta.Name = "MenuUsuarioVendedorAlta"
        Me.MenuUsuarioVendedorAlta.Size = New System.Drawing.Size(179, 22)
        Me.MenuUsuarioVendedorAlta.Text = "Alta Vendedor"
        '
        'MenuUsuarioVendedorModificar
        '
        Me.MenuUsuarioVendedorModificar.Name = "MenuUsuarioVendedorModificar"
        Me.MenuUsuarioVendedorModificar.Size = New System.Drawing.Size(179, 22)
        Me.MenuUsuarioVendedorModificar.Text = "Modificar Vendedor"
        '
        'MenuUsuarioVendedorMostrar
        '
        Me.MenuUsuarioVendedorMostrar.Name = "MenuUsuarioVendedorMostrar"
        Me.MenuUsuarioVendedorMostrar.Size = New System.Drawing.Size(179, 22)
        Me.MenuUsuarioVendedorMostrar.Text = "Mostrar Vendedor"
        '
        'MenuUsuarioVendedorEliminar
        '
        Me.MenuUsuarioVendedorEliminar.Name = "MenuUsuarioVendedorEliminar"
        Me.MenuUsuarioVendedorEliminar.Size = New System.Drawing.Size(179, 22)
        Me.MenuUsuarioVendedorEliminar.Text = "Eliminar Vendedor"
        '
        'BarraMenu
        '
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuProductos, Me.MenuClientes, Me.MenuUsuarios, Me.MenuFacturas, Me.MenuEmpresa, Me.CerrarSeesion})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(991, 24)
        Me.BarraMenu.TabIndex = 9
        Me.BarraMenu.Text = "MenuStrip"
        '
        'MenuProductos
        '
        Me.MenuProductos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuProductosAgregar, Me.ToolStripSeparator9, Me.MenuProductosMostrar, Me.ToolStripSeparator1, Me.MenuProductosModificar, Me.ToolStripSeparator2, Me.MenuProductosCargarStock, Me.ToolStripSeparator10, Me.MenuProductosEliminar})
        Me.MenuProductos.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuProductos.Name = "MenuProductos"
        Me.MenuProductos.Size = New System.Drawing.Size(73, 20)
        Me.MenuProductos.Text = "&Productos"
        '
        'MenuProductosAgregar
        '
        Me.MenuProductosAgregar.Name = "MenuProductosAgregar"
        Me.MenuProductosAgregar.Size = New System.Drawing.Size(182, 22)
        Me.MenuProductosAgregar.Text = "Agregar Productos"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(179, 6)
        '
        'MenuProductosMostrar
        '
        Me.MenuProductosMostrar.Name = "MenuProductosMostrar"
        Me.MenuProductosMostrar.Size = New System.Drawing.Size(182, 22)
        Me.MenuProductosMostrar.Text = "Buscar Productos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'MenuProductosModificar
        '
        Me.MenuProductosModificar.Name = "MenuProductosModificar"
        Me.MenuProductosModificar.Size = New System.Drawing.Size(182, 22)
        Me.MenuProductosModificar.Text = "Modificar Productos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
        '
        'MenuProductosCargarStock
        '
        Me.MenuProductosCargarStock.Name = "MenuProductosCargarStock"
        Me.MenuProductosCargarStock.Size = New System.Drawing.Size(182, 22)
        Me.MenuProductosCargarStock.Text = "Cargar Stock"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(179, 6)
        '
        'MenuProductosEliminar
        '
        Me.MenuProductosEliminar.Name = "MenuProductosEliminar"
        Me.MenuProductosEliminar.Size = New System.Drawing.Size(182, 22)
        Me.MenuProductosEliminar.Text = "Eliminar Productos"
        '
        'MenuClientes
        '
        Me.MenuClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuClientesAgregar, Me.ToolStripSeparator11, Me.MenuClientesMostrar, Me.ToolStripSeparator12, Me.MenuClientesModificar, Me.ToolStripSeparator13, Me.MenuClientesEliminar})
        Me.MenuClientes.Name = "MenuClientes"
        Me.MenuClientes.Size = New System.Drawing.Size(61, 20)
        Me.MenuClientes.Text = "&Clientes"
        '
        'MenuClientesAgregar
        '
        Me.MenuClientesAgregar.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuClientesAgregar.Name = "MenuClientesAgregar"
        Me.MenuClientesAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MenuClientesAgregar.ShowShortcutKeys = False
        Me.MenuClientesAgregar.Size = New System.Drawing.Size(163, 22)
        Me.MenuClientesAgregar.Text = "Agregar Clientes"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(160, 6)
        '
        'MenuClientesMostrar
        '
        Me.MenuClientesMostrar.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuClientesMostrar.Name = "MenuClientesMostrar"
        Me.MenuClientesMostrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.MenuClientesMostrar.ShowShortcutKeys = False
        Me.MenuClientesMostrar.Size = New System.Drawing.Size(163, 22)
        Me.MenuClientesMostrar.Text = "Buscar Clientes"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(160, 6)
        '
        'MenuClientesModificar
        '
        Me.MenuClientesModificar.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuClientesModificar.Name = "MenuClientesModificar"
        Me.MenuClientesModificar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.MenuClientesModificar.ShowShortcutKeys = False
        Me.MenuClientesModificar.Size = New System.Drawing.Size(163, 22)
        Me.MenuClientesModificar.Text = "Modificar Clientes"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(160, 6)
        '
        'MenuClientesEliminar
        '
        Me.MenuClientesEliminar.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuClientesEliminar.Name = "MenuClientesEliminar"
        Me.MenuClientesEliminar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.MenuClientesEliminar.ShowShortcutKeys = False
        Me.MenuClientesEliminar.Size = New System.Drawing.Size(163, 22)
        Me.MenuClientesEliminar.Text = "Eliminar Clientes"
        '
        'MenuUsuarios
        '
        Me.MenuUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUsuarioAdministrador, Me.MenuUsuarioSupervisor, Me.MenuUsuarioVendedor, Me.BuscarToolStripMenuItem})
        Me.MenuUsuarios.Name = "MenuUsuarios"
        Me.MenuUsuarios.Size = New System.Drawing.Size(64, 20)
        Me.MenuUsuarios.Text = "Usuarios"
        '
        'MenuUsuarioAdministrador
        '
        Me.MenuUsuarioAdministrador.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUsuarioAdministradorAlta, Me.MenuUsuarioAdministradorModificar, Me.MenuUsuarioAdministradorMostrar, Me.MenuUsuarioAdministradorEliminar})
        Me.MenuUsuarioAdministrador.Name = "MenuUsuarioAdministrador"
        Me.MenuUsuarioAdministrador.Size = New System.Drawing.Size(152, 22)
        Me.MenuUsuarioAdministrador.Text = "Administrador"
        '
        'MenuUsuarioAdministradorAlta
        '
        Me.MenuUsuarioAdministradorAlta.Name = "MenuUsuarioAdministradorAlta"
        Me.MenuUsuarioAdministradorAlta.Size = New System.Drawing.Size(215, 22)
        Me.MenuUsuarioAdministradorAlta.Text = "Alta Administrador"
        '
        'MenuUsuarioAdministradorModificar
        '
        Me.MenuUsuarioAdministradorModificar.Name = "MenuUsuarioAdministradorModificar"
        Me.MenuUsuarioAdministradorModificar.Size = New System.Drawing.Size(215, 22)
        Me.MenuUsuarioAdministradorModificar.Text = "Modificar Admministrador"
        '
        'MenuUsuarioAdministradorMostrar
        '
        Me.MenuUsuarioAdministradorMostrar.Name = "MenuUsuarioAdministradorMostrar"
        Me.MenuUsuarioAdministradorMostrar.Size = New System.Drawing.Size(215, 22)
        Me.MenuUsuarioAdministradorMostrar.Text = "Buscar Administrador"
        '
        'MenuUsuarioAdministradorEliminar
        '
        Me.MenuUsuarioAdministradorEliminar.Name = "MenuUsuarioAdministradorEliminar"
        Me.MenuUsuarioAdministradorEliminar.Size = New System.Drawing.Size(215, 22)
        Me.MenuUsuarioAdministradorEliminar.Text = "Eliminar Administrador"
        '
        'MenuUsuarioSupervisor
        '
        Me.MenuUsuarioSupervisor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUsuarioSupervisorAlta, Me.MenuUsuarioSupervisorModificar, Me.MenuUsuarioSupervisorMostrar, Me.MenuUsuarioSupervisorEliminar})
        Me.MenuUsuarioSupervisor.Name = "MenuUsuarioSupervisor"
        Me.MenuUsuarioSupervisor.Size = New System.Drawing.Size(152, 22)
        Me.MenuUsuarioSupervisor.Text = "Supervisor"
        '
        'MenuUsuarioSupervisorAlta
        '
        Me.MenuUsuarioSupervisorAlta.Name = "MenuUsuarioSupervisorAlta"
        Me.MenuUsuarioSupervisorAlta.Size = New System.Drawing.Size(183, 22)
        Me.MenuUsuarioSupervisorAlta.Text = "Alta Supervisor"
        '
        'MenuUsuarioSupervisorModificar
        '
        Me.MenuUsuarioSupervisorModificar.Name = "MenuUsuarioSupervisorModificar"
        Me.MenuUsuarioSupervisorModificar.Size = New System.Drawing.Size(183, 22)
        Me.MenuUsuarioSupervisorModificar.Text = "Modificar Supervisor"
        '
        'MenuUsuarioSupervisorMostrar
        '
        Me.MenuUsuarioSupervisorMostrar.Name = "MenuUsuarioSupervisorMostrar"
        Me.MenuUsuarioSupervisorMostrar.Size = New System.Drawing.Size(183, 22)
        Me.MenuUsuarioSupervisorMostrar.Text = "Mostrar Supervisor"
        '
        'MenuUsuarioSupervisorEliminar
        '
        Me.MenuUsuarioSupervisorEliminar.Name = "MenuUsuarioSupervisorEliminar"
        Me.MenuUsuarioSupervisorEliminar.Size = New System.Drawing.Size(183, 22)
        Me.MenuUsuarioSupervisorEliminar.Text = "Eliminar Supervisor"
        '
        'MenuFacturas
        '
        Me.MenuFacturas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarInformeToolStripMenuItem, Me.CancelarFacturaToolStripMenuItem, Me.VerFacturasToolStripMenuItem})
        Me.MenuFacturas.Name = "MenuFacturas"
        Me.MenuFacturas.Size = New System.Drawing.Size(63, 20)
        Me.MenuFacturas.Text = "Facturas"
        '
        'GenerarInformeToolStripMenuItem
        '
        Me.GenerarInformeToolStripMenuItem.Name = "GenerarInformeToolStripMenuItem"
        Me.GenerarInformeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.GenerarInformeToolStripMenuItem.Text = "Generar Informe"
        '
        'CancelarFacturaToolStripMenuItem
        '
        Me.CancelarFacturaToolStripMenuItem.Name = "CancelarFacturaToolStripMenuItem"
        Me.CancelarFacturaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CancelarFacturaToolStripMenuItem.Text = "Cancelar Factura"
        '
        'VerFacturasToolStripMenuItem
        '
        Me.VerFacturasToolStripMenuItem.Name = "VerFacturasToolStripMenuItem"
        Me.VerFacturasToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.VerFacturasToolStripMenuItem.Text = "Ver Facturas"
        '
        'MenuEmpresa
        '
        Me.MenuEmpresa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuEmpresaVerDatos, Me.MenuEmpresaModificarDatos})
        Me.MenuEmpresa.Name = "MenuEmpresa"
        Me.MenuEmpresa.Size = New System.Drawing.Size(64, 20)
        Me.MenuEmpresa.Text = "Empresa"
        '
        'MenuEmpresaVerDatos
        '
        Me.MenuEmpresaVerDatos.Name = "MenuEmpresaVerDatos"
        Me.MenuEmpresaVerDatos.Size = New System.Drawing.Size(158, 22)
        Me.MenuEmpresaVerDatos.Text = "Ver Datos"
        '
        'MenuEmpresaModificarDatos
        '
        Me.MenuEmpresaModificarDatos.Name = "MenuEmpresaModificarDatos"
        Me.MenuEmpresaModificarDatos.Size = New System.Drawing.Size(158, 22)
        Me.MenuEmpresaModificarDatos.Text = "Modificar Datos"
        '
        'CerrarSeesion
        '
        Me.CerrarSeesion.Name = "CerrarSeesion"
        Me.CerrarSeesion.Size = New System.Drawing.Size(88, 20)
        Me.CerrarSeesion.Text = "Cerrar Sesión"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 427)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(991, 22)
        Me.StatusStrip.TabIndex = 10
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'Ventana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 449)
        Me.Controls.Add(Me.BarraMenu)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Ventana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NNeumaticos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuUsuarioVendedor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioVendedorAlta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioVendedorModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioVendedorMostrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioVendedorEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuProductosAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuProductosMostrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuProductosModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuProductosCargarStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuProductosEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuClientesAgregar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuClientesMostrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuClientesModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuClientesEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioAdministrador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioAdministradorAlta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioAdministradorModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioAdministradorMostrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioAdministradorEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioSupervisor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioSupervisorAlta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioSupervisorModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioSupervisorMostrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarioSupervisorEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFacturas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarInformeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmpresa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmpresaVerDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmpresaModificarDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSeesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
