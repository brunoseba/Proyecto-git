<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuadroReporteSuper
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
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SuperMejoresVendedoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Login.DataSet1()
        Me.ReportSuper1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuperMejoresVendedoreTableAdapter = New Login.DataSet1TableAdapters.SuperMejoresVendedoreTableAdapter()
        Me.ReportSuper2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuperMejorClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuperMejorClienteTableAdapter = New Login.DataSet1TableAdapters.SuperMejorClienteTableAdapter()
        Me.ReportSuper3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuperFormasPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuperFormasPagoTableAdapter = New Login.DataSet1TableAdapters.SuperFormasPagoTableAdapter()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        CType(Me.SuperMejoresVendedoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperMejorClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperFormasPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperMejoresVendedoreBindingSource
        '
        Me.SuperMejoresVendedoreBindingSource.DataMember = "SuperMejoresVendedore"
        Me.SuperMejoresVendedoreBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportSuper1
        '
        Me.ReportSuper1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.SuperMejoresVendedoreBindingSource
        Me.ReportSuper1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportSuper1.LocalReport.ReportEmbeddedResource = "Login.ReporteSuper1.rdlc"
        Me.ReportSuper1.Location = New System.Drawing.Point(12, 102)
        Me.ReportSuper1.Name = "ReportSuper1"
        Me.ReportSuper1.Size = New System.Drawing.Size(1238, 284)
        Me.ReportSuper1.TabIndex = 0
        Me.ReportSuper1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(528, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker2.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(235, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(541, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "DD/MM/AAAA *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(248, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "DD/MM/AAAA *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(398, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Fecha Hasta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(91, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Fecha Desde"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1078, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 32)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(597, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SuperMejoresVendedoreTableAdapter
        '
        Me.SuperMejoresVendedoreTableAdapter.ClearBeforeFill = True
        '
        'ReportSuper2
        '
        Me.ReportSuper2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource8.Name = "DataSet1"
        ReportDataSource8.Value = Me.SuperMejorClienteBindingSource
        Me.ReportSuper2.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportSuper2.LocalReport.ReportEmbeddedResource = "Login.ReporteSuper2.rdlc"
        Me.ReportSuper2.Location = New System.Drawing.Point(12, 102)
        Me.ReportSuper2.Name = "ReportSuper2"
        Me.ReportSuper2.Size = New System.Drawing.Size(1238, 284)
        Me.ReportSuper2.TabIndex = 34
        Me.ReportSuper2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'SuperMejorClienteBindingSource
        '
        Me.SuperMejorClienteBindingSource.DataMember = "SuperMejorCliente"
        Me.SuperMejorClienteBindingSource.DataSource = Me.DataSet1
        '
        'SuperMejorClienteTableAdapter
        '
        Me.SuperMejorClienteTableAdapter.ClearBeforeFill = True
        '
        'ReportSuper3
        '
        Me.ReportSuper3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource9.Name = "DataSet1"
        ReportDataSource9.Value = Me.SuperFormasPagoBindingSource
        Me.ReportSuper3.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportSuper3.LocalReport.ReportEmbeddedResource = "Login.ReporteSuper3.rdlc"
        Me.ReportSuper3.Location = New System.Drawing.Point(12, 102)
        Me.ReportSuper3.Name = "ReportSuper3"
        Me.ReportSuper3.Size = New System.Drawing.Size(1238, 284)
        Me.ReportSuper3.TabIndex = 35
        Me.ReportSuper3.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'SuperFormasPagoBindingSource
        '
        Me.SuperFormasPagoBindingSource.DataMember = "SuperFormasPago"
        Me.SuperFormasPagoBindingSource.DataSource = Me.DataSet1
        '
        'SuperFormasPagoTableAdapter
        '
        Me.SuperFormasPagoTableAdapter.ClearBeforeFill = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.Window
        Me.RadioButton1.Location = New System.Drawing.Point(693, 41)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(111, 20)
        Me.RadioButton1.TabIndex = 36
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Vendedores"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.Window
        Me.RadioButton2.Location = New System.Drawing.Point(828, 41)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 20)
        Me.RadioButton2.TabIndex = 37
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Clientes"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.Window
        Me.RadioButton3.Location = New System.Drawing.Point(926, 40)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(133, 20)
        Me.RadioButton3.TabIndex = 38
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Forma de Pago"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'CuadroReporteSuper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1262, 488)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ReportSuper3)
        Me.Controls.Add(Me.ReportSuper2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportSuper1)
        Me.Name = "CuadroReporteSuper"
        Me.Text = "CuadroReporteSuper"
        CType(Me.SuperMejoresVendedoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperMejorClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperFormasPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportSuper1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SuperMejoresVendedoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Login.DataSet1
    Friend WithEvents SuperMejoresVendedoreTableAdapter As Login.DataSet1TableAdapters.SuperMejoresVendedoreTableAdapter
    Friend WithEvents ReportSuper2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SuperMejorClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuperMejorClienteTableAdapter As Login.DataSet1TableAdapters.SuperMejorClienteTableAdapter
    Friend WithEvents ReportSuper3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SuperFormasPagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuperFormasPagoTableAdapter As Login.DataSet1TableAdapters.SuperFormasPagoTableAdapter
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
End Class
