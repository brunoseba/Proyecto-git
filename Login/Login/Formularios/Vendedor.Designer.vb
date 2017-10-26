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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendedor))
        Me.PanelBuscarProductoVendedor = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LabelBuscarProducto = New System.Windows.Forms.Label()
        Me.LabelNombreProducto = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelRodado = New System.Windows.Forms.Label()
        Me.LabelTipoVehiculo = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.PanelDatosTecnicosVendedor = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridDatosCodigo = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.totalCompra = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxCuilCliente = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelCuilCliente = New System.Windows.Forms.Label()
        Me.ComboBoxTipoPago = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewBuscadorProducto = New System.Windows.Forms.DataGridView()
        Me.Agregar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Datos_Tecn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridCompra = New System.Windows.Forms.DataGridView()
        Me.pro_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_medida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_rodado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_tipo_vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pro_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Eliminar_C = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PanelBuscarProductoVendedor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelDatosTecnicosVendedor.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DataGridDatosCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewBuscadorProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBuscarProductoVendedor
        '
        Me.PanelBuscarProductoVendedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBuscarProductoVendedor.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelBuscarProductoVendedor.Controls.Add(Me.GroupBox1)
        Me.PanelBuscarProductoVendedor.Controls.Add(Me.PanelDatosTecnicosVendedor)
        Me.PanelBuscarProductoVendedor.Controls.Add(Me.GroupBox5)
        Me.PanelBuscarProductoVendedor.Controls.Add(Me.GroupBox2)
        Me.PanelBuscarProductoVendedor.Controls.Add(Me.GroupBox3)
        Me.PanelBuscarProductoVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBuscarProductoVendedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelBuscarProductoVendedor.Name = "PanelBuscarProductoVendedor"
        Me.PanelBuscarProductoVendedor.Size = New System.Drawing.Size(1367, 639)
        Me.PanelBuscarProductoVendedor.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.LabelBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.LabelNombreProducto)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.LabelRodado)
        Me.GroupBox1.Controls.Add(Me.LabelTipoVehiculo)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1329, 88)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Todos", "13", "14", "15", "16", "17", "18", "19", "20", "22.5", "26", "28", "36", "38"})
        Me.ComboBox2.Location = New System.Drawing.Point(662, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox2.TabIndex = 13
        '
        'LabelBuscarProducto
        '
        Me.LabelBuscarProducto.AutoSize = True
        Me.LabelBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelBuscarProducto.Location = New System.Drawing.Point(538, 0)
        Me.LabelBuscarProducto.Name = "LabelBuscarProducto"
        Me.LabelBuscarProducto.Size = New System.Drawing.Size(171, 25)
        Me.LabelBuscarProducto.TabIndex = 0
        Me.LabelBuscarProducto.Text = "Buscar Producto"
        '
        'LabelNombreProducto
        '
        Me.LabelNombreProducto.AutoSize = True
        Me.LabelNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreProducto.Location = New System.Drawing.Point(113, 39)
        Me.LabelNombreProducto.Name = "LabelNombreProducto"
        Me.LabelNombreProducto.Size = New System.Drawing.Size(100, 25)
        Me.LabelNombreProducto.TabIndex = 2
        Me.LabelNombreProducto.Text = "Nombre:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "Automovil"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Todos", "Automóviles", "Camiones/Colectivos", "Camionetas", "Tractores"})
        Me.ComboBox1.Location = New System.Drawing.Point(1075, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "Automovil"
        '
        'LabelRodado
        '
        Me.LabelRodado.AutoSize = True
        Me.LabelRodado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRodado.Location = New System.Drawing.Point(545, 40)
        Me.LabelRodado.Name = "LabelRodado"
        Me.LabelRodado.Size = New System.Drawing.Size(93, 25)
        Me.LabelRodado.TabIndex = 3
        Me.LabelRodado.Text = "Rodado:"
        '
        'LabelTipoVehiculo
        '
        Me.LabelTipoVehiculo.AutoSize = True
        Me.LabelTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipoVehiculo.Location = New System.Drawing.Point(920, 40)
        Me.LabelTipoVehiculo.Name = "LabelTipoVehiculo"
        Me.LabelTipoVehiculo.Size = New System.Drawing.Size(149, 25)
        Me.LabelTipoVehiculo.TabIndex = 5
        Me.LabelTipoVehiculo.Text = "Tipo Vehiculo:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(219, 39)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(157, 26)
        Me.TextBox6.TabIndex = 7
        '
        'PanelDatosTecnicosVendedor
        '
        Me.PanelDatosTecnicosVendedor.Controls.Add(Me.GroupBox8)
        Me.PanelDatosTecnicosVendedor.Location = New System.Drawing.Point(3, 477)
        Me.PanelDatosTecnicosVendedor.Name = "PanelDatosTecnicosVendedor"
        Me.PanelDatosTecnicosVendedor.Size = New System.Drawing.Size(1341, 142)
        Me.PanelDatosTecnicosVendedor.TabIndex = 21
        Me.PanelDatosTecnicosVendedor.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button5)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.DataGridDatosCodigo)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox8.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1335, 123)
        Me.GroupBox8.TabIndex = 25
        Me.GroupBox8.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(616, 83)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 34)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Aceptar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(611, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Datos Técnicos"
        '
        'DataGridDatosCodigo
        '
        Me.DataGridDatosCodigo.AllowUserToAddRows = False
        Me.DataGridDatosCodigo.AllowUserToDeleteRows = False
        Me.DataGridDatosCodigo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridDatosCodigo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridDatosCodigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridDatosCodigo.Location = New System.Drawing.Point(10, 16)
        Me.DataGridDatosCodigo.Name = "DataGridDatosCodigo"
        Me.DataGridDatosCodigo.ReadOnly = True
        Me.DataGridDatosCodigo.Size = New System.Drawing.Size(1320, 65)
        Me.DataGridDatosCodigo.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.TextBoxCuilCliente)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.LabelCuilCliente)
        Me.GroupBox5.Controls.Add(Me.ComboBoxTipoPago)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(12, 518)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1329, 95)
        Me.GroupBox5.TabIndex = 27
        Me.GroupBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Cliente"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.totalCompra)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(971, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(302, 70)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Total"
        '
        'totalCompra
        '
        Me.totalCompra.AutoSize = True
        Me.totalCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalCompra.Location = New System.Drawing.Point(145, 27)
        Me.totalCompra.Name = "totalCompra"
        Me.totalCompra.Size = New System.Drawing.Size(26, 29)
        Me.totalCompra.TabIndex = 23
        Me.totalCompra.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(92, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 29)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "$"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(579, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancelar Compra"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxCuilCliente
        '
        Me.TextBoxCuilCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCuilCliente.Location = New System.Drawing.Point(142, 41)
        Me.TextBoxCuilCliente.Name = "TextBoxCuilCliente"
        Me.TextBoxCuilCliente.Size = New System.Drawing.Size(126, 26)
        Me.TextBoxCuilCliente.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(781, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 46)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Confirmar Compra (F12)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelCuilCliente
        '
        Me.LabelCuilCliente.AutoSize = True
        Me.LabelCuilCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCuilCliente.Location = New System.Drawing.Point(20, 43)
        Me.LabelCuilCliente.Name = "LabelCuilCliente"
        Me.LabelCuilCliente.Size = New System.Drawing.Size(92, 20)
        Me.LabelCuilCliente.TabIndex = 12
        Me.LabelCuilCliente.Text = "Cuil Cliente:"
        '
        'ComboBoxTipoPago
        '
        Me.ComboBoxTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTipoPago.FormattingEnabled = True
        Me.ComboBoxTipoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de Crédito", "Tarjeta de Débito"})
        Me.ComboBoxTipoPago.Location = New System.Drawing.Point(365, 38)
        Me.ComboBoxTipoPago.Name = "ComboBoxTipoPago"
        Me.ComboBoxTipoPago.Size = New System.Drawing.Size(185, 28)
        Me.ComboBoxTipoPago.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DataGridViewBuscadorProducto)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(9, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(681, 380)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(269, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Resultados"
        '
        'DataGridViewBuscadorProducto
        '
        Me.DataGridViewBuscadorProducto.AllowUserToAddRows = False
        Me.DataGridViewBuscadorProducto.AllowUserToDeleteRows = False
        Me.DataGridViewBuscadorProducto.AllowUserToOrderColumns = True
        Me.DataGridViewBuscadorProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewBuscadorProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBuscadorProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewBuscadorProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBuscadorProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Agregar, Me.Datos_Tecn, Me.Imagen})
        Me.DataGridViewBuscadorProducto.Location = New System.Drawing.Point(11, 18)
        Me.DataGridViewBuscadorProducto.Name = "DataGridViewBuscadorProducto"
        Me.DataGridViewBuscadorProducto.ReadOnly = True
        Me.DataGridViewBuscadorProducto.Size = New System.Drawing.Size(660, 354)
        Me.DataGridViewBuscadorProducto.TabIndex = 2
        '
        'Agregar
        '
        Me.Agregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Agregar.DefaultCellStyle = DataGridViewCellStyle1
        Me.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Agregar.HeaderText = "+"
        Me.Agregar.Name = "Agregar"
        Me.Agregar.ReadOnly = True
        Me.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Agregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Agregar.Text = "+"
        Me.Agregar.ToolTipText = "+"
        Me.Agregar.UseColumnTextForButtonValue = True
        Me.Agregar.Width = 42
        '
        'Datos_Tecn
        '
        Me.Datos_Tecn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Datos_Tecn.HeaderText = "DT"
        Me.Datos_Tecn.Name = "Datos_Tecn"
        Me.Datos_Tecn.ReadOnly = True
        Me.Datos_Tecn.Text = "DT"
        Me.Datos_Tecn.UseColumnTextForButtonValue = True
        Me.Datos_Tecn.Width = 40
        '
        'Imagen
        '
        Me.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Imagen.FillWeight = 55.3934!
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.Name = "Imagen"
        Me.Imagen.ReadOnly = True
        Me.Imagen.Width = 62
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login.My.Resources.Resources.RE_050_RFT
        Me.PictureBox1.Location = New System.Drawing.Point(1121, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.DataGridCompra)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(687, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(654, 380)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(293, -1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Compras"
        '
        'DataGridCompra
        '
        Me.DataGridCompra.AllowUserToAddRows = False
        Me.DataGridCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pro_nombre, Me.pro_medida, Me.pro_rodado, Me.pro_tipo_vehiculo, Me.pro_precio_unitario, Me.pro_cantidad, Me.pro_total, Me.DataGridViewImageColumn1, Me.Eliminar_C})
        Me.DataGridCompra.Location = New System.Drawing.Point(9, 20)
        Me.DataGridCompra.Name = "DataGridCompra"
        Me.DataGridCompra.Size = New System.Drawing.Size(639, 354)
        Me.DataGridCompra.TabIndex = 20
        '
        'pro_nombre
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.pro_nombre.HeaderText = "Nombre"
        Me.pro_nombre.Name = "pro_nombre"
        '
        'pro_medida
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_medida.DefaultCellStyle = DataGridViewCellStyle3
        Me.pro_medida.HeaderText = "Medidas"
        Me.pro_medida.Name = "pro_medida"
        '
        'pro_rodado
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_rodado.DefaultCellStyle = DataGridViewCellStyle4
        Me.pro_rodado.HeaderText = "Rodado"
        Me.pro_rodado.Name = "pro_rodado"
        '
        'pro_tipo_vehiculo
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_tipo_vehiculo.DefaultCellStyle = DataGridViewCellStyle5
        Me.pro_tipo_vehiculo.HeaderText = "Tipo Vehiculo"
        Me.pro_tipo_vehiculo.Name = "pro_tipo_vehiculo"
        '
        'pro_precio_unitario
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_precio_unitario.DefaultCellStyle = DataGridViewCellStyle6
        Me.pro_precio_unitario.HeaderText = "Precio Unitario"
        Me.pro_precio_unitario.Name = "pro_precio_unitario"
        '
        'pro_cantidad
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pro_cantidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.pro_cantidad.HeaderText = "Cantidad"
        Me.pro_cantidad.Name = "pro_cantidad"
        '
        'pro_total
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Maroon
        Me.pro_total.DefaultCellStyle = DataGridViewCellStyle8
        Me.pro_total.HeaderText = "Total"
        Me.pro_total.Name = "pro_total"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Eliminar_C
        '
        Me.Eliminar_C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Eliminar_C.HeaderText = "-"
        Me.Eliminar_C.Name = "Eliminar_C"
        Me.Eliminar_C.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar_C.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Eliminar_C.Text = "-"
        Me.Eliminar_C.UseColumnTextForButtonValue = True
        Me.Eliminar_C.Width = 36
        '
        'Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 631)
        Me.Controls.Add(Me.PanelBuscarProductoVendedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Vendedor"
        Me.Text = "Vendedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelBuscarProductoVendedor.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelDatosTecnicosVendedor.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.DataGridDatosCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewBuscadorProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBuscarProductoVendedor As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewBuscadorProducto As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridCompra As System.Windows.Forms.DataGridView
    Friend WithEvents totalCompra As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PanelDatosTecnicosVendedor As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridDatosCodigo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCuilCliente As System.Windows.Forms.TextBox
    Friend WithEvents LabelCuilCliente As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelBuscarProducto As System.Windows.Forms.Label
    Friend WithEvents LabelNombreProducto As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelRodado As System.Windows.Forms.Label
    Friend WithEvents LabelTipoVehiculo As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pro_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_medida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_rodado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_tipo_vehiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_precio_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pro_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Eliminar_C As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Agregar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Datos_Tecn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
