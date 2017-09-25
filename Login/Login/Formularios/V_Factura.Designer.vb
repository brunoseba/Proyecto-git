<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V_Factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(V_Factura))
        Me.Panel_VerFacturas = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.DataGridVerFacturas = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonBuscarFactura = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Informe_Factura = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonAceptarF = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.N_Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUIL_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI_Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FTipo_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ver_detalles = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonBuscarFacturas = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxInformeNFactura = New System.Windows.Forms.TextBox()
        Me.ComboBoxTipoPago = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCuilCliente = New System.Windows.Forms.ComboBox()
        Me.DateTimeFHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxDniVendedor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel_Cancelar_Factura = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonAceptarCF = New System.Windows.Forms.Button()
        Me.DataGridCFProductos = New System.Windows.Forms.DataGridView()
        Me.NroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CF_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CF_Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CF_Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CF_Tipo_PAgo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CF_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CF_Producto = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxBuscarFacturaCancelar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_VerFacturas.SuspendLayout()
        CType(Me.DataGridVerFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Informe_Factura.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_Cancelar_Factura.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCFProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_VerFacturas
        '
        Me.Panel_VerFacturas.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel_VerFacturas.Controls.Add(Me.Label5)
        Me.Panel_VerFacturas.Controls.Add(Me.TextBox1)
        Me.Panel_VerFacturas.Controls.Add(Me.Label4)
        Me.Panel_VerFacturas.Controls.Add(Me.ButtonAceptar)
        Me.Panel_VerFacturas.Controls.Add(Me.DataGridVerFacturas)
        Me.Panel_VerFacturas.Controls.Add(Me.ButtonBuscarFactura)
        Me.Panel_VerFacturas.Controls.Add(Me.Label3)
        Me.Panel_VerFacturas.Controls.Add(Me.Label2)
        Me.Panel_VerFacturas.Controls.Add(Me.DateTimePickerHasta)
        Me.Panel_VerFacturas.Controls.Add(Me.DateTimePickerDesde)
        Me.Panel_VerFacturas.Controls.Add(Me.Label1)
        Me.Panel_VerFacturas.Location = New System.Drawing.Point(12, 12)
        Me.Panel_VerFacturas.Name = "Panel_VerFacturas"
        Me.Panel_VerFacturas.Size = New System.Drawing.Size(1300, 582)
        Me.Panel_VerFacturas.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Image = Global.Login.My.Resources.Resources._16__Help_2_
        Me.Label5.Location = New System.Drawing.Point(388, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "       "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(207, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 26)
        Me.TextBox1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nº de Factura: "
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(577, 534)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(130, 31)
        Me.ButtonAceptar.TabIndex = 7
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'DataGridVerFacturas
        '
        Me.DataGridVerFacturas.AllowUserToAddRows = False
        Me.DataGridVerFacturas.AllowUserToDeleteRows = False
        Me.DataGridVerFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridVerFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridVerFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridVerFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVerFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Cliente, Me.Vendedor, Me.Monto_Total, Me.Tipo_Pago})
        Me.DataGridVerFacturas.Location = New System.Drawing.Point(47, 222)
        Me.DataGridVerFacturas.Name = "DataGridVerFacturas"
        Me.DataGridVerFacturas.ReadOnly = True
        Me.DataGridVerFacturas.Size = New System.Drawing.Size(1144, 297)
        Me.DataGridVerFacturas.TabIndex = 6
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Cliente
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Cliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Vendedor
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Vendedor.DefaultCellStyle = DataGridViewCellStyle3
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        '
        'Monto_Total
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Monto_Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Monto_Total.HeaderText = "Monto Total"
        Me.Monto_Total.Name = "Monto_Total"
        Me.Monto_Total.ReadOnly = True
        '
        'Tipo_Pago
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Tipo_Pago.DefaultCellStyle = DataGridViewCellStyle5
        Me.Tipo_Pago.HeaderText = "Tipo Pago"
        Me.Tipo_Pago.Name = "Tipo_Pago"
        Me.Tipo_Pago.ReadOnly = True
        '
        'ButtonBuscarFactura
        '
        Me.ButtonBuscarFactura.Image = Global.Login.My.Resources.Resources.search16_h
        Me.ButtonBuscarFactura.Location = New System.Drawing.Point(1031, 150)
        Me.ButtonBuscarFactura.Name = "ButtonBuscarFactura"
        Me.ButtonBuscarFactura.Size = New System.Drawing.Size(72, 37)
        Me.ButtonBuscarFactura.TabIndex = 5
        Me.ButtonBuscarFactura.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(751, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(441, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(850, 152)
        Me.DateTimePickerHasta.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerHasta.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerHasta.Name = "DateTimePickerHasta"
        Me.DateTimePickerHasta.Size = New System.Drawing.Size(161, 26)
        Me.DateTimePickerHasta.TabIndex = 2
        '
        'DateTimePickerDesde
        '
        Me.DateTimePickerDesde.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(546, 155)
        Me.DateTimePickerDesde.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerDesde.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerDesde.Name = "DateTimePickerDesde"
        Me.DateTimePickerDesde.Size = New System.Drawing.Size(161, 26)
        Me.DateTimePickerDesde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(495, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mostrar Facturas"
        '
        'Panel_Informe_Factura
        '
        Me.Panel_Informe_Factura.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel_Informe_Factura.Controls.Add(Me.DataGridView2)
        Me.Panel_Informe_Factura.Controls.Add(Me.Button3)
        Me.Panel_Informe_Factura.Controls.Add(Me.ButtonAceptarF)
        Me.Panel_Informe_Factura.Controls.Add(Me.DataGridView1)
        Me.Panel_Informe_Factura.Controls.Add(Me.ButtonBuscarFacturas)
        Me.Panel_Informe_Factura.Controls.Add(Me.GroupBox1)
        Me.Panel_Informe_Factura.Controls.Add(Me.Label6)
        Me.Panel_Informe_Factura.Location = New System.Drawing.Point(0, 1)
        Me.Panel_Informe_Factura.Name = "Panel_Informe_Factura"
        Me.Panel_Informe_Factura.Size = New System.Drawing.Size(1324, 610)
        Me.Panel_Informe_Factura.TabIndex = 11
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(69, 438)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1229, 118)
        Me.DataGridView2.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(626, 562)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 31)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Generar Informe"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonAceptarF
        '
        Me.ButtonAceptarF.Location = New System.Drawing.Point(1128, 565)
        Me.ButtonAceptarF.Name = "ButtonAceptarF"
        Me.ButtonAceptarF.Size = New System.Drawing.Size(93, 28)
        Me.ButtonAceptarF.TabIndex = 16
        Me.ButtonAceptarF.Text = "Salir"
        Me.ButtonAceptarF.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.N_Factura, Me.CUIL_Cliente, Me.DNI_Vendedor, Me.FTipo_Pago, Me.Fecha_F, Me.monto, Me.Ver_detalles})
        Me.DataGridView1.Location = New System.Drawing.Point(69, 274)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1229, 158)
        Me.DataGridView1.TabIndex = 15
        '
        'N_Factura
        '
        Me.N_Factura.HeaderText = "Nº Factura"
        Me.N_Factura.Name = "N_Factura"
        Me.N_Factura.ReadOnly = True
        '
        'CUIL_Cliente
        '
        Me.CUIL_Cliente.HeaderText = "CUIL-Cliente"
        Me.CUIL_Cliente.Name = "CUIL_Cliente"
        Me.CUIL_Cliente.ReadOnly = True
        '
        'DNI_Vendedor
        '
        Me.DNI_Vendedor.HeaderText = "DNI-Vendedor"
        Me.DNI_Vendedor.Name = "DNI_Vendedor"
        Me.DNI_Vendedor.ReadOnly = True
        '
        'FTipo_Pago
        '
        Me.FTipo_Pago.HeaderText = "Tipo Pago"
        Me.FTipo_Pago.Name = "FTipo_Pago"
        Me.FTipo_Pago.ReadOnly = True
        '
        'Fecha_F
        '
        Me.Fecha_F.HeaderText = "Fecha "
        Me.Fecha_F.Name = "Fecha_F"
        Me.Fecha_F.ReadOnly = True
        '
        'monto
        '
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        Me.monto.ReadOnly = True
        '
        'Ver_detalles
        '
        Me.Ver_detalles.HeaderText = "Ver Productos"
        Me.Ver_detalles.Name = "Ver_detalles"
        Me.Ver_detalles.ReadOnly = True
        Me.Ver_detalles.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ver_detalles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Ver_detalles.Text = "Ver Productos"
        Me.Ver_detalles.ToolTipText = "Ver Productos"
        Me.Ver_detalles.UseColumnTextForButtonValue = True
        '
        'ButtonBuscarFacturas
        '
        Me.ButtonBuscarFacturas.Image = Global.Login.My.Resources.Resources.search16_h1
        Me.ButtonBuscarFacturas.Location = New System.Drawing.Point(626, 223)
        Me.ButtonBuscarFacturas.Name = "ButtonBuscarFacturas"
        Me.ButtonBuscarFacturas.Size = New System.Drawing.Size(93, 28)
        Me.ButtonBuscarFacturas.TabIndex = 14
        Me.ButtonBuscarFacturas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxInformeNFactura)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTipoPago)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCuilCliente)
        Me.GroupBox1.Controls.Add(Me.DateTimeFHasta)
        Me.GroupBox1.Controls.Add(Me.DateTimeFDesde)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDniVendedor)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(18, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1294, 138)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de Facturas"
        '
        'TextBoxInformeNFactura
        '
        Me.TextBoxInformeNFactura.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInformeNFactura.Location = New System.Drawing.Point(209, 25)
        Me.TextBoxInformeNFactura.Name = "TextBoxInformeNFactura"
        Me.TextBoxInformeNFactura.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxInformeNFactura.TabIndex = 11
        '
        'ComboBoxTipoPago
        '
        Me.ComboBoxTipoPago.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTipoPago.FormattingEnabled = True
        Me.ComboBoxTipoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de Crédito", "Tarjeta de Débito"})
        Me.ComboBoxTipoPago.Location = New System.Drawing.Point(102, 94)
        Me.ComboBoxTipoPago.Name = "ComboBoxTipoPago"
        Me.ComboBoxTipoPago.Size = New System.Drawing.Size(174, 26)
        Me.ComboBoxTipoPago.TabIndex = 10
        Me.ComboBoxTipoPago.Text = "Tipo Pago"
        '
        'ComboBoxCuilCliente
        '
        Me.ComboBoxCuilCliente.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCuilCliente.FormattingEnabled = True
        Me.ComboBoxCuilCliente.Items.AddRange(New Object() {"20336575425", "27287653457", "25165432671", "20398765433"})
        Me.ComboBoxCuilCliente.Location = New System.Drawing.Point(608, 25)
        Me.ComboBoxCuilCliente.Name = "ComboBoxCuilCliente"
        Me.ComboBoxCuilCliente.Size = New System.Drawing.Size(156, 26)
        Me.ComboBoxCuilCliente.TabIndex = 12
        Me.ComboBoxCuilCliente.Text = "CUIL Cliente"
        '
        'DateTimeFHasta
        '
        Me.DateTimeFHasta.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFHasta.Location = New System.Drawing.Point(913, 94)
        Me.DateTimeFHasta.Name = "DateTimeFHasta"
        Me.DateTimeFHasta.Size = New System.Drawing.Size(136, 26)
        Me.DateTimeFHasta.TabIndex = 8
        '
        'DateTimeFDesde
        '
        Me.DateTimeFDesde.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeFDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFDesde.Location = New System.Drawing.Point(540, 94)
        Me.DateTimeFDesde.Name = "DateTimeFDesde"
        Me.DateTimeFDesde.Size = New System.Drawing.Size(136, 26)
        Me.DateTimeFDesde.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(57, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nº de Factura:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(830, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 23)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Hasta:"
        '
        'ComboBoxDniVendedor
        '
        Me.ComboBoxDniVendedor.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxDniVendedor.FormattingEnabled = True
        Me.ComboBoxDniVendedor.Items.AddRange(New Object() {"33657542", "28765345", "16543267", "39876543"})
        Me.ComboBoxDniVendedor.Location = New System.Drawing.Point(1028, 25)
        Me.ComboBoxDniVendedor.Name = "ComboBoxDniVendedor"
        Me.ComboBoxDniVendedor.Size = New System.Drawing.Size(156, 26)
        Me.ComboBoxDniVendedor.TabIndex = 9
        Me.ComboBoxDniVendedor.Text = "DNI Vendedor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(453, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 23)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Desde:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(484, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(353, 38)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Informe de Facturas"
        '
        'Panel_Cancelar_Factura
        '
        Me.Panel_Cancelar_Factura.BackColor = System.Drawing.Color.Teal
        Me.Panel_Cancelar_Factura.Controls.Add(Me.DataGridView3)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.Button2)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.ButtonAceptarCF)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.DataGridCFProductos)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.GroupBox2)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.Label8)
        Me.Panel_Cancelar_Factura.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Cancelar_Factura.Name = "Panel_Cancelar_Factura"
        Me.Panel_Cancelar_Factura.Size = New System.Drawing.Size(1321, 607)
        Me.Panel_Cancelar_Factura.TabIndex = 17
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(69, 310)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1207, 159)
        Me.DataGridView3.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Image = Global.Login.My.Resources.Resources.table_delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(501, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 44)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Baja Factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonAceptarCF
        '
        Me.ButtonAceptarCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptarCF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonAceptarCF.Location = New System.Drawing.Point(947, 537)
        Me.ButtonAceptarCF.Name = "ButtonAceptarCF"
        Me.ButtonAceptarCF.Size = New System.Drawing.Size(111, 33)
        Me.ButtonAceptarCF.TabIndex = 12
        Me.ButtonAceptarCF.Text = "Aceptar"
        Me.ButtonAceptarCF.UseVisualStyleBackColor = True
        '
        'DataGridCFProductos
        '
        Me.DataGridCFProductos.AllowUserToAddRows = False
        Me.DataGridCFProductos.AllowUserToDeleteRows = False
        Me.DataGridCFProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridCFProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridCFProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCFProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroFactura, Me.CF_Cliente, Me.CF_Vendedor, Me.CF_Fecha, Me.CF_Tipo_PAgo, Me.CF_Total, Me.CF_Producto})
        Me.DataGridCFProductos.Location = New System.Drawing.Point(69, 200)
        Me.DataGridCFProductos.Name = "DataGridCFProductos"
        Me.DataGridCFProductos.ReadOnly = True
        Me.DataGridCFProductos.Size = New System.Drawing.Size(1207, 86)
        Me.DataGridCFProductos.TabIndex = 3
        '
        'NroFactura
        '
        Me.NroFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NroFactura.HeaderText = "Nº Factura"
        Me.NroFactura.Name = "NroFactura"
        Me.NroFactura.ReadOnly = True
        '
        'CF_Cliente
        '
        Me.CF_Cliente.HeaderText = "Cliente"
        Me.CF_Cliente.Name = "CF_Cliente"
        Me.CF_Cliente.ReadOnly = True
        '
        'CF_Vendedor
        '
        Me.CF_Vendedor.HeaderText = "Vendedor"
        Me.CF_Vendedor.Name = "CF_Vendedor"
        Me.CF_Vendedor.ReadOnly = True
        '
        'CF_Fecha
        '
        Me.CF_Fecha.HeaderText = "Fecha"
        Me.CF_Fecha.Name = "CF_Fecha"
        Me.CF_Fecha.ReadOnly = True
        '
        'CF_Tipo_PAgo
        '
        Me.CF_Tipo_PAgo.HeaderText = "Tipo Pago"
        Me.CF_Tipo_PAgo.Name = "CF_Tipo_PAgo"
        Me.CF_Tipo_PAgo.ReadOnly = True
        '
        'CF_Total
        '
        Me.CF_Total.HeaderText = "Total"
        Me.CF_Total.Name = "CF_Total"
        Me.CF_Total.ReadOnly = True
        '
        'CF_Producto
        '
        Me.CF_Producto.HeaderText = "Productos"
        Me.CF_Producto.Name = "CF_Producto"
        Me.CF_Producto.ReadOnly = True
        Me.CF_Producto.Text = "Ver Productos"
        Me.CF_Producto.ToolTipText = "Ver Productos"
        Me.CF_Producto.UseColumnTextForButtonValue = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBoxBuscarFacturaCancelar)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(28, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1284, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Factura"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.Login.My.Resources.Resources.search16_h1
        Me.Button1.Location = New System.Drawing.Point(789, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxBuscarFacturaCancelar
        '
        Me.TextBoxBuscarFacturaCancelar.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarFacturaCancelar.Location = New System.Drawing.Point(566, 41)
        Me.TextBoxBuscarFacturaCancelar.Name = "TextBoxBuscarFacturaCancelar"
        Me.TextBoxBuscarFacturaCancelar.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxBuscarFacturaCancelar.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(395, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nº de Factura:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(494, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(299, 38)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Cancelar Factura"
        '
        'V_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1324, 606)
        Me.Controls.Add(Me.Panel_Informe_Factura)
        Me.Controls.Add(Me.Panel_VerFacturas)
        Me.Controls.Add(Me.Panel_Cancelar_Factura)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "V_Factura"
        Me.Text = "V_Factura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_VerFacturas.ResumeLayout(False)
        Me.Panel_VerFacturas.PerformLayout()
        CType(Me.DataGridVerFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Informe_Factura.ResumeLayout(False)
        Me.Panel_Informe_Factura.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel_Cancelar_Factura.ResumeLayout(False)
        Me.Panel_Cancelar_Factura.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCFProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_VerFacturas As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonBuscarFactura As System.Windows.Forms.Button
    Friend WithEvents DataGridVerFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel_Informe_Factura As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonAceptarF As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents N_Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUIL_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNI_Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FTipo_Pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ver_detalles As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ButtonBuscarFacturas As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxInformeNFactura As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCuilCliente As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimeFHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimeFDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDniVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel_Cancelar_Factura As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBuscarFacturaCancelar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridCFProductos As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAceptarCF As System.Windows.Forms.Button
    Friend WithEvents NroFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CF_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CF_Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CF_Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CF_Tipo_PAgo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CF_Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CF_Producto As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto_Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Pago As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
