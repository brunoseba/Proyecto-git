﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BarraMenu = New System.Windows.Forms.MenuStrip()
        Me.Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuClientesAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuClientesMostrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFacturas = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarInformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEmpresa = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEmpresaVerDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEmpresaModificarDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.usuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.BarraEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BarraMenu.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Productos, Me.MenuClientes, Me.MenuUsuarios, Me.MenuFacturas, Me.MenuEmpresa, Me.ToolStripMenuItem1, Me.usuario})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(991, 24)
        Me.BarraMenu.TabIndex = 9
        Me.BarraMenu.Text = "MenuStrip"
        '
        'Productos
        '
        Me.Productos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProductoToolStripMenuItem, Me.BuscarProductosToolStripMenuItem, Me.CargarStockToolStripMenuItem, Me.EliminarProductosToolStripMenuItem})
        Me.Productos.Image = Global.Login.My.Resources.Resources.bricks
        Me.Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(89, 20)
        Me.Productos.Text = "&Productos"
        Me.Productos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AgregarProductoToolStripMenuItem
        '
        Me.AgregarProductoToolStripMenuItem.Image = Global.Login.My.Resources.Resources.brick_add
        Me.AgregarProductoToolStripMenuItem.Name = "AgregarProductoToolStripMenuItem"
        Me.AgregarProductoToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AgregarProductoToolStripMenuItem.Text = "Agregar Productos"
        '
        'BuscarProductosToolStripMenuItem
        '
        Me.BuscarProductosToolStripMenuItem.Image = Global.Login.My.Resources.Resources.search16_h
        Me.BuscarProductosToolStripMenuItem.Name = "BuscarProductosToolStripMenuItem"
        Me.BuscarProductosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.BuscarProductosToolStripMenuItem.Text = "Buscar Productos"
        '
        'CargarStockToolStripMenuItem
        '
        Me.CargarStockToolStripMenuItem.Image = Global.Login.My.Resources.Resources.pencil
        Me.CargarStockToolStripMenuItem.Name = "CargarStockToolStripMenuItem"
        Me.CargarStockToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.CargarStockToolStripMenuItem.Text = "Actualizar Stock"
        '
        'EliminarProductosToolStripMenuItem
        '
        Me.EliminarProductosToolStripMenuItem.Image = Global.Login.My.Resources.Resources.delete_square16
        Me.EliminarProductosToolStripMenuItem.Name = "EliminarProductosToolStripMenuItem"
        Me.EliminarProductosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EliminarProductosToolStripMenuItem.Text = "Eliminar Productos"
        '
        'MenuClientes
        '
        Me.MenuClientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuClientesAgregar, Me.ToolStripSeparator11, Me.MenuClientesMostrar})
        Me.MenuClientes.Image = Global.Login.My.Resources.Resources.user_green
        Me.MenuClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MenuClientes.Name = "MenuClientes"
        Me.MenuClientes.Size = New System.Drawing.Size(77, 20)
        Me.MenuClientes.Text = "&Clientes"
        Me.MenuClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuClientesAgregar
        '
        Me.MenuClientesAgregar.Image = Global.Login.My.Resources.Resources.user_add16
        Me.MenuClientesAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MenuClientesAgregar.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuClientesAgregar.Name = "MenuClientesAgregar"
        Me.MenuClientesAgregar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MenuClientesAgregar.ShowShortcutKeys = False
        Me.MenuClientesAgregar.Size = New System.Drawing.Size(154, 22)
        Me.MenuClientesAgregar.Text = "Agregar Clientes"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(151, 6)
        '
        'MenuClientesMostrar
        '
        Me.MenuClientesMostrar.Image = Global.Login.My.Resources.Resources.search16_h1
        Me.MenuClientesMostrar.ImageTransparentColor = System.Drawing.Color.Black
        Me.MenuClientesMostrar.Name = "MenuClientesMostrar"
        Me.MenuClientesMostrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.MenuClientesMostrar.ShowShortcutKeys = False
        Me.MenuClientesMostrar.Size = New System.Drawing.Size(154, 22)
        Me.MenuClientesMostrar.Text = "Buscar Clientes"
        '
        'MenuUsuarios
        '
        Me.MenuUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.BuscarToolStripMenuItem})
        Me.MenuUsuarios.Image = Global.Login.My.Resources.Resources.group_user16
        Me.MenuUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MenuUsuarios.Name = "MenuUsuarios"
        Me.MenuUsuarios.Size = New System.Drawing.Size(80, 20)
        Me.MenuUsuarios.Text = "Usuarios"
        Me.MenuUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.Login.My.Resources.Resources.user_add16
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar Usuarios"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Image = Global.Login.My.Resources.Resources.search16_h
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar Usuarios"
        '
        'MenuFacturas
        '
        Me.MenuFacturas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerFacturasToolStripMenuItem, Me.GenerarInformeToolStripMenuItem, Me.CancelarFacturaToolStripMenuItem})
        Me.MenuFacturas.Image = Global.Login.My.Resources.Resources._16__Edit_3_
        Me.MenuFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MenuFacturas.Name = "MenuFacturas"
        Me.MenuFacturas.Size = New System.Drawing.Size(79, 20)
        Me.MenuFacturas.Text = "Facturas"
        Me.MenuFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VerFacturasToolStripMenuItem
        '
        Me.VerFacturasToolStripMenuItem.Image = Global.Login.My.Resources.Resources._16__Zoom_
        Me.VerFacturasToolStripMenuItem.Name = "VerFacturasToolStripMenuItem"
        Me.VerFacturasToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.VerFacturasToolStripMenuItem.Text = "Ver Facturas"
        '
        'GenerarInformeToolStripMenuItem
        '
        Me.GenerarInformeToolStripMenuItem.Image = Global.Login.My.Resources.Resources._16__Edit_2_
        Me.GenerarInformeToolStripMenuItem.Name = "GenerarInformeToolStripMenuItem"
        Me.GenerarInformeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.GenerarInformeToolStripMenuItem.Text = "Generar Informe"
        '
        'CancelarFacturaToolStripMenuItem
        '
        Me.CancelarFacturaToolStripMenuItem.Image = Global.Login.My.Resources.Resources.delete_square161
        Me.CancelarFacturaToolStripMenuItem.Name = "CancelarFacturaToolStripMenuItem"
        Me.CancelarFacturaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CancelarFacturaToolStripMenuItem.Text = "Cancelar Factura"
        '
        'MenuEmpresa
        '
        Me.MenuEmpresa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuEmpresaVerDatos, Me.MenuEmpresaModificarDatos})
        Me.MenuEmpresa.Image = Global.Login.My.Resources.Resources.building
        Me.MenuEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MenuEmpresa.Name = "MenuEmpresa"
        Me.MenuEmpresa.Size = New System.Drawing.Size(80, 20)
        Me.MenuEmpresa.Text = "Empresa"
        Me.MenuEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuEmpresaVerDatos
        '
        Me.MenuEmpresaVerDatos.Image = Global.Login.My.Resources.Resources._16__Zoom_1
        Me.MenuEmpresaVerDatos.Name = "MenuEmpresaVerDatos"
        Me.MenuEmpresaVerDatos.Size = New System.Drawing.Size(158, 22)
        Me.MenuEmpresaVerDatos.Text = "Ver Datos"
        '
        'MenuEmpresaModificarDatos
        '
        Me.MenuEmpresaModificarDatos.Image = Global.Login.My.Resources.Resources.building_edit
        Me.MenuEmpresaModificarDatos.Name = "MenuEmpresaModificarDatos"
        Me.MenuEmpresaModificarDatos.Size = New System.Drawing.Size(158, 22)
        Me.MenuEmpresaModificarDatos.Text = "Modificar Datos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'usuario
        '
        Me.usuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem})
        Me.usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(59, 20)
        Me.usuario.Text = "Usuario"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Image = Global.Login.My.Resources.Resources.delete_square16
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarraEstado})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 427)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(991, 22)
        Me.StatusStrip.TabIndex = 10
        Me.StatusStrip.Text = "StatusStrip"
        '
        'BarraEstado
        '
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(42, 17)
        Me.BarraEstado.Text = "Estado"
        '
        'Ventana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Login.My.Resources.Resources.Bridgestone_BATTLAX_MotoGP_slick_tyre
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
    Friend WithEvents BarraMenu As System.Windows.Forms.MenuStrip
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
    Friend WithEvents MenuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuFacturas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarInformeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelarFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmpresa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmpresaVerDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuEmpresaModificarDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents usuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents BarraEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Productos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargarStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
