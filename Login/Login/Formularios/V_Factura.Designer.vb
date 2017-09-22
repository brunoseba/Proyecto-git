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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_VerFacturas = New System.Windows.Forms.Panel()
        Me.DataGridVerFacturas = New System.Windows.Forms.DataGridView()
        Me.ButtonBuscarFactura = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerHasta = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalles_Ventas = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel_VerFacturas.SuspendLayout()
        CType(Me.DataGridVerFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_VerFacturas
        '
        Me.Panel_VerFacturas.BackColor = System.Drawing.Color.LightSeaGreen
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
        Me.DataGridVerFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Cliente, Me.Vendedor, Me.Monto_Total, Me.Tipo_Pago, Me.detalles_Ventas})
        Me.DataGridVerFacturas.Location = New System.Drawing.Point(47, 222)
        Me.DataGridVerFacturas.Name = "DataGridVerFacturas"
        Me.DataGridVerFacturas.ReadOnly = True
        Me.DataGridVerFacturas.Size = New System.Drawing.Size(1144, 297)
        Me.DataGridVerFacturas.TabIndex = 6
        '
        'ButtonBuscarFactura
        '
        Me.ButtonBuscarFactura.Location = New System.Drawing.Point(1039, 141)
        Me.ButtonBuscarFactura.Name = "ButtonBuscarFactura"
        Me.ButtonBuscarFactura.Size = New System.Drawing.Size(99, 37)
        Me.ButtonBuscarFactura.TabIndex = 5
        Me.ButtonBuscarFactura.Text = "Buscar"
        Me.ButtonBuscarFactura.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(573, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Desde:"
        '
        'DateTimePickerHasta
        '
        Me.DateTimePickerHasta.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerHasta.Location = New System.Drawing.Point(672, 151)
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
        Me.DateTimePickerDesde.Location = New System.Drawing.Point(192, 152)
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
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(577, 534)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(130, 31)
        Me.ButtonAceptar.TabIndex = 7
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
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
        'detalles_Ventas
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = Nothing
        Me.detalles_Ventas.DefaultCellStyle = DataGridViewCellStyle6
        Me.detalles_Ventas.HeaderText = "Detalles"
        Me.detalles_Ventas.Name = "detalles_Ventas"
        Me.detalles_Ventas.ReadOnly = True
        Me.detalles_Ventas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.detalles_Ventas.Text = "Detalles"
        Me.detalles_Ventas.ToolTipText = "Detalles"
        Me.detalles_Ventas.UseColumnTextForButtonValue = True
        '
        'V_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1324, 606)
        Me.Controls.Add(Me.Panel_VerFacturas)
        Me.Name = "V_Factura"
        Me.Text = "V_Factura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_VerFacturas.ResumeLayout(False)
        Me.Panel_VerFacturas.PerformLayout()
        CType(Me.DataGridVerFacturas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto_Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detalles_Ventas As System.Windows.Forms.DataGridViewButtonColumn
End Class
