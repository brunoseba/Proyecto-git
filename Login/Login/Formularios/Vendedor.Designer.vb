<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedor
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelBuscarProducto = New System.Windows.Forms.Panel()
        Me.BSalir0 = New System.Windows.Forms.Button()
        Me.PanelResultadosProductos = New System.Windows.Forms.Panel()
        Me.LabelBuscadorProductos = New System.Windows.Forms.Label()
        Me.DataGridViewBuscadorProducto = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rodado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoVehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Carrito = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonCarrito = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ComboBoxTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCarrito = New System.Windows.Forms.Panel()
        Me.BProducto = New System.Windows.Forms.Button()
        Me.ButtonVerificarCuil = New System.Windows.Forms.Button()
        Me.ComboBoxTipoPago = New System.Windows.Forms.ComboBox()
        Me.TextBoxCuilCliente = New System.Windows.Forms.TextBox()
        Me.LabelCuilCliente = New System.Windows.Forms.Label()
        Me.LabelCarritoDeCompra = New System.Windows.Forms.Label()
        Me.ButtonConfirmarCompra = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.MontoTotal = New System.Windows.Forms.Label()
        Me.DataGridViewCarrito = New System.Windows.Forms.DataGridView()
        Me.Id_carrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Carrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Medida_carrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rodado_Carrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Vehi_Carrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitCarrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_Carrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Carrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen_Carrito = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar_Carrito = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PanelBuscarProducto.SuspendLayout()
        Me.PanelResultadosProductos.SuspendLayout()
        CType(Me.DataGridViewBuscadorProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelCarrito.SuspendLayout()
        CType(Me.DataGridViewCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBuscarProducto
        '
        Me.PanelBuscarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBuscarProducto.BackColor = System.Drawing.Color.IndianRed
        Me.PanelBuscarProducto.Controls.Add(Me.BSalir0)
        Me.PanelBuscarProducto.Controls.Add(Me.PanelResultadosProductos)
        Me.PanelBuscarProducto.Controls.Add(Me.GroupBox1)
        Me.PanelBuscarProducto.Location = New System.Drawing.Point(0, 0)
        Me.PanelBuscarProducto.Name = "PanelBuscarProducto"
        Me.PanelBuscarProducto.Size = New System.Drawing.Size(1367, 560)
        Me.PanelBuscarProducto.TabIndex = 14
        '
        'BSalir0
        '
        Me.BSalir0.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BSalir0.Location = New System.Drawing.Point(642, 502)
        Me.BSalir0.Name = "BSalir0"
        Me.BSalir0.Size = New System.Drawing.Size(75, 23)
        Me.BSalir0.TabIndex = 16
        Me.BSalir0.Text = "Salir"
        Me.BSalir0.UseVisualStyleBackColor = True
        '
        'PanelResultadosProductos
        '
        Me.PanelResultadosProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelResultadosProductos.BackColor = System.Drawing.Color.Ivory
        Me.PanelResultadosProductos.Controls.Add(Me.LabelBuscadorProductos)
        Me.PanelResultadosProductos.Controls.Add(Me.DataGridViewBuscadorProducto)
        Me.PanelResultadosProductos.Controls.Add(Me.ButtonCarrito)
        Me.PanelResultadosProductos.Location = New System.Drawing.Point(0, 95)
        Me.PanelResultadosProductos.Name = "PanelResultadosProductos"
        Me.PanelResultadosProductos.Size = New System.Drawing.Size(1361, 376)
        Me.PanelResultadosProductos.TabIndex = 15
        '
        'LabelBuscadorProductos
        '
        Me.LabelBuscadorProductos.AutoSize = True
        Me.LabelBuscadorProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscadorProductos.Location = New System.Drawing.Point(574, 31)
        Me.LabelBuscadorProductos.Name = "LabelBuscadorProductos"
        Me.LabelBuscadorProductos.Size = New System.Drawing.Size(236, 25)
        Me.LabelBuscadorProductos.TabIndex = 12
        Me.LabelBuscadorProductos.Text = "Buscador de Productos"
        '
        'DataGridViewBuscadorProducto
        '
        Me.DataGridViewBuscadorProducto.AllowUserToAddRows = False
        Me.DataGridViewBuscadorProducto.AllowUserToOrderColumns = True
        Me.DataGridViewBuscadorProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBuscadorProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBuscadorProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewBuscadorProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBuscadorProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Medida, Me.Rodado, Me.TipoVehiculo, Me.Stock, Me.Precio_Unit, Me.Imagen, Me.Carrito})
        Me.DataGridViewBuscadorProducto.Location = New System.Drawing.Point(3, 90)
        Me.DataGridViewBuscadorProducto.Name = "DataGridViewBuscadorProducto"
        Me.DataGridViewBuscadorProducto.Size = New System.Drawing.Size(1355, 273)
        Me.DataGridViewBuscadorProducto.TabIndex = 2
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.DefaultCellStyle = DataGridViewCellStyle6
        Me.Id.FillWeight = 55.3934!
        Me.Id.HeaderText = "Id "
        Me.Id.Name = "Id"
        '
        'Nombre
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle7
        Me.Nombre.FillWeight = 55.3934!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Medida
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medida.DefaultCellStyle = DataGridViewCellStyle8
        Me.Medida.FillWeight = 55.3934!
        Me.Medida.HeaderText = "Medida"
        Me.Medida.Name = "Medida"
        '
        'Rodado
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rodado.DefaultCellStyle = DataGridViewCellStyle9
        Me.Rodado.FillWeight = 55.3934!
        Me.Rodado.HeaderText = "Rodado"
        Me.Rodado.Name = "Rodado"
        '
        'TipoVehiculo
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoVehiculo.DefaultCellStyle = DataGridViewCellStyle10
        Me.TipoVehiculo.FillWeight = 55.3934!
        Me.TipoVehiculo.HeaderText = "Tipo Vehiculo"
        Me.TipoVehiculo.Name = "TipoVehiculo"
        '
        'Stock
        '
        Me.Stock.FillWeight = 55.3934!
        Me.Stock.HeaderText = "Stock Disponible"
        Me.Stock.Name = "Stock"
        '
        'Precio_Unit
        '
        Me.Precio_Unit.FillWeight = 55.3934!
        Me.Precio_Unit.HeaderText = "Precio Unit."
        Me.Precio_Unit.Name = "Precio_Unit"
        '
        'Imagen
        '
        Me.Imagen.FillWeight = 55.3934!
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.Name = "Imagen"
        '
        'Carrito
        '
        Me.Carrito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Carrito.HeaderText = "Agregar al Carrito"
        Me.Carrito.Name = "Carrito"
        Me.Carrito.Text = "Agregar al Carrito"
        Me.Carrito.UseColumnTextForButtonValue = True
        '
        'ButtonCarrito

        'Me.ButtonCarrito.Image = Global.Login.My.Resources.Resources.carrit

        '


        Me.ButtonCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCarrito.Location = New System.Drawing.Point(1288, 31)
        Me.ButtonCarrito.Name = "ButtonCarrito"
        Me.ButtonCarrito.Size = New System.Drawing.Size(43, 39)
        Me.ButtonCarrito.TabIndex = 6
        Me.ButtonCarrito.UseVisualStyleBackColor = True
        Me.ButtonCarrito.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTipoVehiculo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1332, 64)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUSCAR PRODUCTOS"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.Location = New System.Drawing.Point(1119, 17)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(103, 39)
        Me.ButtonBuscar.TabIndex = 10
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'ComboBoxTipoVehiculo
        '
        Me.ComboBoxTipoVehiculo.DisplayMember = "Automóviles"
        Me.ComboBoxTipoVehiculo.FormattingEnabled = True
        Me.ComboBoxTipoVehiculo.Items.AddRange(New Object() {"Automóviles", "Camiones", "Camionetas", "Tractores"})
        Me.ComboBoxTipoVehiculo.Location = New System.Drawing.Point(910, 26)
        Me.ComboBoxTipoVehiculo.Name = "ComboBoxTipoVehiculo"
        Me.ComboBoxTipoVehiculo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTipoVehiculo.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(830, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo Vehículo"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(68, 26)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Código"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(702, 26)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(654, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Medida"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(535, 26)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(484, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Rodado"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(342, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Producto"
        '
        'PanelCarrito
        '
        Me.PanelCarrito.BackColor = System.Drawing.Color.Teal
        Me.PanelCarrito.Controls.Add(Me.BProducto)
        Me.PanelCarrito.Controls.Add(Me.ButtonVerificarCuil)
        Me.PanelCarrito.Controls.Add(Me.ComboBoxTipoPago)
        Me.PanelCarrito.Controls.Add(Me.TextBoxCuilCliente)
        Me.PanelCarrito.Controls.Add(Me.LabelCuilCliente)
        Me.PanelCarrito.Controls.Add(Me.LabelCarritoDeCompra)
        Me.PanelCarrito.Controls.Add(Me.ButtonConfirmarCompra)
        Me.PanelCarrito.Controls.Add(Me.LabelTotal)
        Me.PanelCarrito.Controls.Add(Me.MontoTotal)
        Me.PanelCarrito.Controls.Add(Me.DataGridViewCarrito)
        Me.PanelCarrito.Location = New System.Drawing.Point(0, 0)
        Me.PanelCarrito.Name = "PanelCarrito"
        Me.PanelCarrito.Size = New System.Drawing.Size(1367, 555)
        Me.PanelCarrito.TabIndex = 16
        '
        'BProducto
        '
        Me.BProducto.Location = New System.Drawing.Point(1206, 17)
        Me.BProducto.Name = "BProducto"
        Me.BProducto.Size = New System.Drawing.Size(75, 23)
        Me.BProducto.TabIndex = 16
        Me.BProducto.Text = "Productos"
        Me.BProducto.UseVisualStyleBackColor = True
        '
        'ButtonVerificarCuil
        '
        Me.ButtonVerificarCuil.Location = New System.Drawing.Point(436, 509)
        Me.ButtonVerificarCuil.Name = "ButtonVerificarCuil"
        Me.ButtonVerificarCuil.Size = New System.Drawing.Size(104, 33)
        Me.ButtonVerificarCuil.TabIndex = 15
        Me.ButtonVerificarCuil.Text = "Verificar"
        Me.ButtonVerificarCuil.UseVisualStyleBackColor = True
        '
        'ComboBoxTipoPago
        '
        Me.ComboBoxTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTipoPago.FormattingEnabled = True
        Me.ComboBoxTipoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de Crédito", "Tarjeta de Débito"})
        Me.ComboBoxTipoPago.Location = New System.Drawing.Point(732, 504)
        Me.ComboBoxTipoPago.Name = "ComboBoxTipoPago"
        Me.ComboBoxTipoPago.Size = New System.Drawing.Size(121, 28)
        Me.ComboBoxTipoPago.TabIndex = 14
        '
        'TextBoxCuilCliente
        '
        Me.TextBoxCuilCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCuilCliente.Location = New System.Drawing.Point(230, 511)
        Me.TextBoxCuilCliente.Name = "TextBoxCuilCliente"
        Me.TextBoxCuilCliente.Size = New System.Drawing.Size(181, 26)
        Me.TextBoxCuilCliente.TabIndex = 13
        '
        'LabelCuilCliente
        '
        Me.LabelCuilCliente.AutoSize = True
        Me.LabelCuilCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCuilCliente.Location = New System.Drawing.Point(121, 517)
        Me.LabelCuilCliente.Name = "LabelCuilCliente"
        Me.LabelCuilCliente.Size = New System.Drawing.Size(92, 20)
        Me.LabelCuilCliente.TabIndex = 12
        Me.LabelCuilCliente.Text = "Cuil Cliente:"
        '
        'LabelCarritoDeCompra
        '
        Me.LabelCarritoDeCompra.AutoSize = True
        Me.LabelCarritoDeCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCarritoDeCompra.Location = New System.Drawing.Point(13, 20)
        Me.LabelCarritoDeCompra.Name = "LabelCarritoDeCompra"
        Me.LabelCarritoDeCompra.Size = New System.Drawing.Size(187, 25)
        Me.LabelCarritoDeCompra.TabIndex = 10
        Me.LabelCarritoDeCompra.Text = "Carrito de Compra"
        '
        'ButtonConfirmarCompra
        '
        Me.ButtonConfirmarCompra.Location = New System.Drawing.Point(959, 495)
        Me.ButtonConfirmarCompra.Name = "ButtonConfirmarCompra"
        Me.ButtonConfirmarCompra.Size = New System.Drawing.Size(128, 42)
        Me.ButtonConfirmarCompra.TabIndex = 7
        Me.ButtonConfirmarCompra.Text = "Confirmar Compra"
        Me.ButtonConfirmarCompra.UseVisualStyleBackColor = True
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(1125, 501)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(72, 25)
        Me.LabelTotal.TabIndex = 8
        Me.LabelTotal.Text = "Total: "
        '
        'MontoTotal
        '
        Me.MontoTotal.AutoSize = True
        Me.MontoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoTotal.Location = New System.Drawing.Point(1245, 501)
        Me.MontoTotal.Name = "MontoTotal"
        Me.MontoTotal.Size = New System.Drawing.Size(0, 25)
        Me.MontoTotal.TabIndex = 9
        '
        'DataGridViewCarrito
        '
        Me.DataGridViewCarrito.AllowUserToAddRows = False
        Me.DataGridViewCarrito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCarrito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_carrito, Me.Nombre_Carrito, Me.Medida_carrito, Me.Rodado_Carrito, Me.Tipo_Vehi_Carrito, Me.PrecioUnitCarrito, Me.Cantidad_Carrito, Me.Total_Carrito, Me.Imagen_Carrito, Me.Eliminar_Carrito})
        Me.DataGridViewCarrito.Location = New System.Drawing.Point(0, 59)
        Me.DataGridViewCarrito.Name = "DataGridViewCarrito"
        Me.DataGridViewCarrito.Size = New System.Drawing.Size(1367, 426)
        Me.DataGridViewCarrito.TabIndex = 11
        '
        'Id_carrito
        '
        Me.Id_carrito.HeaderText = "Id"
        Me.Id_carrito.Name = "Id_carrito"
        '
        'Nombre_Carrito
        '
        Me.Nombre_Carrito.HeaderText = "Nombre"
        Me.Nombre_Carrito.Name = "Nombre_Carrito"
        '
        'Medida_carrito
        '
        Me.Medida_carrito.HeaderText = "Medidas"
        Me.Medida_carrito.Name = "Medida_carrito"
        '
        'Rodado_Carrito
        '
        Me.Rodado_Carrito.HeaderText = "Rodado"
        Me.Rodado_Carrito.Name = "Rodado_Carrito"
        '
        'Tipo_Vehi_Carrito
        '
        Me.Tipo_Vehi_Carrito.HeaderText = "Tipo Vehiculo"
        Me.Tipo_Vehi_Carrito.Name = "Tipo_Vehi_Carrito"
        '
        'PrecioUnitCarrito
        '
        Me.PrecioUnitCarrito.HeaderText = "Precio Unitario"
        Me.PrecioUnitCarrito.Name = "PrecioUnitCarrito"
        '
        'Cantidad_Carrito
        '
        Me.Cantidad_Carrito.HeaderText = "Cantidad"
        Me.Cantidad_Carrito.Name = "Cantidad_Carrito"
        '
        'Total_Carrito
        '
        Me.Total_Carrito.HeaderText = "Total"
        Me.Total_Carrito.Name = "Total_Carrito"
        '
        'Imagen_Carrito
        '
        Me.Imagen_Carrito.HeaderText = "Imagen"
        Me.Imagen_Carrito.Name = "Imagen_Carrito"
        Me.Imagen_Carrito.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imagen_Carrito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Eliminar_Carrito
        '
        Me.Eliminar_Carrito.HeaderText = "Eliminar "
        Me.Eliminar_Carrito.Name = "Eliminar_Carrito"
        Me.Eliminar_Carrito.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar_Carrito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar_Carrito.Text = "Eliminar del Carrito"
        Me.Eliminar_Carrito.UseColumnTextForButtonValue = True
        '
        'Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1370, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelBuscarProducto)
        Me.Controls.Add(Me.PanelCarrito)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vendedor"
        Me.ShowIcon = False
        Me.Text = "Vendedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBuscarProducto.ResumeLayout(False)
        Me.PanelResultadosProductos.ResumeLayout(False)
        Me.PanelResultadosProductos.PerformLayout()
        CType(Me.DataGridViewBuscadorProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelCarrito.ResumeLayout(False)
        Me.PanelCarrito.PerformLayout()
        CType(Me.DataGridViewCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBuscarProducto As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTipoVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelResultadosProductos As System.Windows.Forms.Panel
    Friend WithEvents LabelBuscadorProductos As System.Windows.Forms.Label
    Friend WithEvents DataGridViewBuscadorProducto As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Medida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rodado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoVehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Carrito As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ButtonCarrito As System.Windows.Forms.Button
    Friend WithEvents PanelCarrito As System.Windows.Forms.Panel
    Friend WithEvents ButtonVerificarCuil As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxCuilCliente As System.Windows.Forms.TextBox
    Friend WithEvents LabelCuilCliente As System.Windows.Forms.Label
    Friend WithEvents LabelCarritoDeCompra As System.Windows.Forms.Label
    Friend WithEvents ButtonConfirmarCompra As System.Windows.Forms.Button
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents MontoTotal As System.Windows.Forms.Label
    Friend WithEvents DataGridViewCarrito As System.Windows.Forms.DataGridView
    Friend WithEvents Id_carrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Carrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Medida_carrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rodado_Carrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Vehi_Carrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitCarrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_Carrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Carrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imagen_Carrito As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar_Carrito As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents BSalir0 As System.Windows.Forms.Button
    Friend WithEvents BProducto As System.Windows.Forms.Button
End Class
