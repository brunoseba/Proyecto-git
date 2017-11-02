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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(V_Factura))
        Me.Panel_Informe_Factura = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ver_detalles = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ButtonAceptarF = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxInformeNFactura = New System.Windows.Forms.TextBox()
        Me.ComboBoxTipoPago = New System.Windows.Forms.ComboBox()
        Me.DateTimeFHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel_Cancelar_Factura = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridCFProductos = New System.Windows.Forms.DataGridView()
        Me.CF_Producto = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonAceptarCF = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBuscarFacturaCancelar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_Informe_Factura.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_Cancelar_Factura.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridCFProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Informe_Factura
        '
        Me.Panel_Informe_Factura.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel_Informe_Factura.Controls.Add(Me.GroupBox3)
        Me.Panel_Informe_Factura.Controls.Add(Me.ButtonAceptarF)
        Me.Panel_Informe_Factura.Controls.Add(Me.GroupBox1)
        Me.Panel_Informe_Factura.Controls.Add(Me.Label6)
        Me.Panel_Informe_Factura.Location = New System.Drawing.Point(0, 1)
        Me.Panel_Informe_Factura.Name = "Panel_Informe_Factura"
        Me.Panel_Informe_Factura.Size = New System.Drawing.Size(1324, 610)
        Me.Panel_Informe_Factura.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(28, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1248, 322)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ver_detalles})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1229, 158)
        Me.DataGridView1.TabIndex = 15
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
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 183)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1229, 118)
        Me.DataGridView2.TabIndex = 18
        '
        'ButtonAceptarF
        '
        Me.ButtonAceptarF.Location = New System.Drawing.Point(617, 552)
        Me.ButtonAceptarF.Name = "ButtonAceptarF"
        Me.ButtonAceptarF.Size = New System.Drawing.Size(102, 41)
        Me.ButtonAceptarF.TabIndex = 16
        Me.ButtonAceptarF.Text = "Salir"
        Me.ButtonAceptarF.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBoxInformeNFactura)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTipoPago)
        Me.GroupBox1.Controls.Add(Me.DateTimeFHasta)
        Me.GroupBox1.Controls.Add(Me.DateTimeFDesde)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(18, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1294, 138)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1054, 23)
        Me.TextBox3.MaxLength = 11
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(170, 26)
        Me.TextBox3.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(902, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 23)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "CUIL Cliente:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(633, 29)
        Me.TextBox2.MaxLength = 9
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 26)
        Me.TextBox2.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(468, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "DNI Vendedor:"
        '
        'TextBoxInformeNFactura
        '
        Me.TextBoxInformeNFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInformeNFactura.Location = New System.Drawing.Point(209, 29)
        Me.TextBoxInformeNFactura.MaxLength = 8
        Me.TextBoxInformeNFactura.Name = "TextBoxInformeNFactura"
        Me.TextBoxInformeNFactura.Size = New System.Drawing.Size(170, 26)
        Me.TextBoxInformeNFactura.TabIndex = 11
        '
        'ComboBoxTipoPago
        '
        Me.ComboBoxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoPago.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTipoPago.FormattingEnabled = True
        Me.ComboBoxTipoPago.Items.AddRange(New Object() {"Todos", "Efectivo", "Tarjeta de Crédito", "Tarjeta de Débito"})
        Me.ComboBoxTipoPago.Location = New System.Drawing.Point(102, 94)
        Me.ComboBoxTipoPago.Name = "ComboBoxTipoPago"
        Me.ComboBoxTipoPago.Size = New System.Drawing.Size(174, 26)
        Me.ComboBoxTipoPago.TabIndex = 10
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
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(57, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nº de Factura:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(830, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 23)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Hasta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(420, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(436, 38)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Visualización de Facturas"
        '
        'Panel_Cancelar_Factura
        '
        Me.Panel_Cancelar_Factura.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel_Cancelar_Factura.Controls.Add(Me.GroupBox5)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.GroupBox4)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.Button2)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.ButtonAceptarCF)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.GroupBox2)
        Me.Panel_Cancelar_Factura.Controls.Add(Me.Label8)
        Me.Panel_Cancelar_Factura.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Cancelar_Factura.Name = "Panel_Cancelar_Factura"
        Me.Panel_Cancelar_Factura.Size = New System.Drawing.Size(1321, 607)
        Me.Panel_Cancelar_Factura.TabIndex = 17
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.DataGridView3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(28, 317)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1278, 184)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(585, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Detalles"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(17, 31)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1207, 145)
        Me.DataGridView3.TabIndex = 14
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.DataGridCFProductos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(28, 169)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1278, 136)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(585, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Factura"
        '
        'DataGridCFProductos
        '
        Me.DataGridCFProductos.AllowUserToAddRows = False
        Me.DataGridCFProductos.AllowUserToDeleteRows = False
        Me.DataGridCFProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridCFProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridCFProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCFProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CF_Producto})
        Me.DataGridCFProductos.Location = New System.Drawing.Point(17, 29)
        Me.DataGridCFProductos.Name = "DataGridCFProductos"
        Me.DataGridCFProductos.ReadOnly = True
        Me.DataGridCFProductos.Size = New System.Drawing.Size(1207, 86)
        Me.DataGridCFProductos.TabIndex = 3
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
        'Button2
        '
        Me.Button2.Image = Global.Login.My.Resources.Resources.table_delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(852, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 44)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Anular Factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonAceptarCF
        '
        Me.ButtonAceptarCF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptarCF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonAceptarCF.Location = New System.Drawing.Point(448, 529)
        Me.ButtonAceptarCF.Name = "ButtonAceptarCF"
        Me.ButtonAceptarCF.Size = New System.Drawing.Size(119, 41)
        Me.ButtonAceptarCF.TabIndex = 12
        Me.ButtonAceptarCF.Text = "Volver"
        Me.ButtonAceptarCF.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxBuscarFacturaCancelar)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(28, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1284, 88)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Factura"
        '
        'TextBoxBuscarFacturaCancelar
        '
        Me.TextBoxBuscarFacturaCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarFacturaCancelar.Location = New System.Drawing.Point(653, 33)
        Me.TextBoxBuscarFacturaCancelar.MaxLength = 9
        Me.TextBoxBuscarFacturaCancelar.Name = "TextBoxBuscarFacturaCancelar"
        Me.TextBoxBuscarFacturaCancelar.Size = New System.Drawing.Size(175, 26)
        Me.TextBoxBuscarFacturaCancelar.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(395, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nº de Factura:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(541, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(268, 38)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Anular Factura"
        '
        'V_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1324, 606)
        Me.Controls.Add(Me.Panel_Cancelar_Factura)
        Me.Controls.Add(Me.Panel_Informe_Factura)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "V_Factura"
        Me.Text = "V_Factura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Informe_Factura.ResumeLayout(False)
        Me.Panel_Informe_Factura.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel_Cancelar_Factura.ResumeLayout(False)
        Me.Panel_Cancelar_Factura.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridCFProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Informe_Factura As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonAceptarF As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxInformeNFactura As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimeFHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimeFDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel_Cancelar_Factura As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBuscarFacturaCancelar As System.Windows.Forms.TextBox
    Friend WithEvents DataGridCFProductos As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonAceptarCF As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Ver_detalles As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CF_Producto As System.Windows.Forms.DataGridViewButtonColumn
End Class
