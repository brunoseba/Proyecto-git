<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuadroReporteAdmin
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AdminProdMasVendidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Login.DataSet1()
        Me.AdminUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminProdRodadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminMontoRodadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportAdmin1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AdminProdMasVendidosTableAdapter = New Login.DataSet1TableAdapters.AdminProdMasVendidosTableAdapter()
        Me.ReportAdmin2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AdminUsuariosTableAdapter = New Login.DataSet1TableAdapters.AdminUsuariosTableAdapter()
        Me.ReportAdmin3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AdminProdRodadoTableAdapter = New Login.DataSet1TableAdapters.AdminProdRodadoTableAdapter()
        Me.AdminMontoRodadoTableAdapter = New Login.DataSet1TableAdapters.AdminMontoRodadoTableAdapter()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.AdminProdMasVendidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminProdRodadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminMontoRodadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminProdMasVendidosBindingSource
        '
        Me.AdminProdMasVendidosBindingSource.DataMember = "AdminProdMasVendidos"
        Me.AdminProdMasVendidosBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminUsuariosBindingSource
        '
        Me.AdminUsuariosBindingSource.DataMember = "AdminUsuarios"
        Me.AdminUsuariosBindingSource.DataSource = Me.DataSet1
        '
        'AdminProdRodadoBindingSource
        '
        Me.AdminProdRodadoBindingSource.DataMember = "AdminProdRodado"
        Me.AdminProdRodadoBindingSource.DataSource = Me.DataSet1
        '
        'AdminMontoRodadoBindingSource
        '
        Me.AdminMontoRodadoBindingSource.DataMember = "AdminMontoRodado"
        Me.AdminMontoRodadoBindingSource.DataSource = Me.DataSet1
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(593, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 31)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(456, 58)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker2.TabIndex = 40
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(163, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker1.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(469, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "DD/MM/AAAA *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(176, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "DD/MM/AAAA *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(326, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Fecha Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(19, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Fecha Desde"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1074, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 32)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportAdmin1
        '
        Me.ReportAdmin1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.AdminProdMasVendidosBindingSource
        Me.ReportAdmin1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportAdmin1.LocalReport.ReportEmbeddedResource = "Login.ReportAdmin1.rdlc"
        Me.ReportAdmin1.Location = New System.Drawing.Point(12, 114)
        Me.ReportAdmin1.Name = "ReportAdmin1"
        Me.ReportAdmin1.Size = New System.Drawing.Size(1246, 318)
        Me.ReportAdmin1.TabIndex = 42
        Me.ReportAdmin1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'AdminProdMasVendidosTableAdapter
        '
        Me.AdminProdMasVendidosTableAdapter.ClearBeforeFill = True
        '
        'ReportAdmin2
        '
        Me.ReportAdmin2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.AdminUsuariosBindingSource
        Me.ReportAdmin2.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportAdmin2.LocalReport.ReportEmbeddedResource = "Login.ReporteAdmin2.rdlc"
        Me.ReportAdmin2.Location = New System.Drawing.Point(12, 114)
        Me.ReportAdmin2.Name = "ReportAdmin2"
        Me.ReportAdmin2.Size = New System.Drawing.Size(1246, 318)
        Me.ReportAdmin2.TabIndex = 43
        Me.ReportAdmin2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'AdminUsuariosTableAdapter
        '
        Me.AdminUsuariosTableAdapter.ClearBeforeFill = True
        '
        'ReportAdmin3
        '
        Me.ReportAdmin3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.AdminProdRodadoBindingSource
        ReportDataSource8.Name = "DataSet2"
        ReportDataSource8.Value = Me.AdminMontoRodadoBindingSource
        Me.ReportAdmin3.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportAdmin3.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportAdmin3.LocalReport.ReportEmbeddedResource = "Login.ReporteAdmin3.rdlc"
        Me.ReportAdmin3.Location = New System.Drawing.Point(12, 114)
        Me.ReportAdmin3.Name = "ReportAdmin3"
        Me.ReportAdmin3.Size = New System.Drawing.Size(1246, 325)
        Me.ReportAdmin3.TabIndex = 44
        '
        'AdminProdRodadoTableAdapter
        '
        Me.AdminProdRodadoTableAdapter.ClearBeforeFill = True
        '
        'AdminMontoRodadoTableAdapter
        '
        Me.AdminMontoRodadoTableAdapter.ClearBeforeFill = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.Window
        Me.RadioButton3.Location = New System.Drawing.Point(797, 76)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(169, 20)
        Me.RadioButton3.TabIndex = 47
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Ventas por Rodados"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.Window
        Me.RadioButton2.Location = New System.Drawing.Point(867, 38)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(162, 20)
        Me.RadioButton2.TabIndex = 46
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Todos los Usuarios"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.Window
        Me.RadioButton1.Location = New System.Drawing.Point(616, 38)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(197, 20)
        Me.RadioButton1.TabIndex = 45
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Productos mas vendidos"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"12", "13", "14", "15", "16", "17", "18", "19", "20", "22.5", "26", "28", "36", "38"})
        Me.ComboBox1.Location = New System.Drawing.Point(652, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 48
        Me.ComboBox1.Visible = False
        '
        'CuadroReporteAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1270, 516)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ReportAdmin3)
        Me.Controls.Add(Me.ReportAdmin2)
        Me.Controls.Add(Me.ReportAdmin1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CuadroReporteAdmin"
        Me.Text = "CuadroReporteAdmin"
        CType(Me.AdminProdMasVendidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminProdRodadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminMontoRodadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportAdmin1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AdminProdMasVendidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Login.DataSet1
    Friend WithEvents AdminProdMasVendidosTableAdapter As Login.DataSet1TableAdapters.AdminProdMasVendidosTableAdapter
    Friend WithEvents ReportAdmin2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AdminUsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminUsuariosTableAdapter As Login.DataSet1TableAdapters.AdminUsuariosTableAdapter
    Friend WithEvents ReportAdmin3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AdminProdRodadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminMontoRodadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminProdRodadoTableAdapter As Login.DataSet1TableAdapters.AdminProdRodadoTableAdapter
    Friend WithEvents AdminMontoRodadoTableAdapter As Login.DataSet1TableAdapters.AdminMontoRodadoTableAdapter
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
