<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaImprime
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportFactura = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.TraigoFacturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraigoFacturaTableAdapter1 = New Login.DataSet1TableAdapters.TraigoFacturaTableAdapter()
        Me.TraigoDetalleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraigoDetalleTableAdapter1 = New Login.DataSet1TableAdapters.TraigoDetalleTableAdapter()
        Me.TraigoVendedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraigoVendedorTableAdapter1 = New Login.DataSet1TableAdapters.TraigoVendedorTableAdapter()
        Me.DataSet11 = New Login.DataSet1()
        Me.TraigoFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraigoFacturaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraigoDetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraigoVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraigoDetalleBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TraigoFacturaBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TraigoFacturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraigoDetalleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraigoVendedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraigoFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraigoFacturaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraigoDetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraigoVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraigoDetalleBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraigoFacturaBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportFactura
        '
        Me.ReportFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TraigoDetalleBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.TraigoFacturaBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.TraigoVendedorBindingSource
        Me.ReportFactura.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportFactura.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportFactura.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportFactura.LocalReport.ReportEmbeddedResource = "Login.RepoFactura.rdlc"
        Me.ReportFactura.Location = New System.Drawing.Point(1, 1)
        Me.ReportFactura.Name = "ReportFactura"
        Me.ReportFactura.Size = New System.Drawing.Size(908, 332)
        Me.ReportFactura.TabIndex = 0
        '
        'BSalir
        '
        Me.BSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BSalir.Location = New System.Drawing.Point(413, 349)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(83, 29)
        Me.BSalir.TabIndex = 1
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'TraigoFacturaTableAdapter1
        '
        Me.TraigoFacturaTableAdapter1.ClearBeforeFill = True
        '
        'TraigoDetalleTableAdapter1
        '
        Me.TraigoDetalleTableAdapter1.ClearBeforeFill = True
        '
        'TraigoVendedorTableAdapter1
        '
        Me.TraigoVendedorTableAdapter1.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TraigoFacturaBindingSource
        '
        Me.TraigoFacturaBindingSource.DataMember = "TraigoFactura"
        Me.TraigoFacturaBindingSource.DataSource = Me.DataSet11
        '
        'TraigoFacturaBindingSource2
        '
        Me.TraigoFacturaBindingSource2.DataMember = "TraigoFactura"
        Me.TraigoFacturaBindingSource2.DataSource = Me.DataSet11
        '
        'TraigoDetalleBindingSource
        '
        Me.TraigoDetalleBindingSource.DataMember = "TraigoDetalle"
        Me.TraigoDetalleBindingSource.DataSource = Me.DataSet11
        '
        'TraigoVendedorBindingSource
        '
        Me.TraigoVendedorBindingSource.DataMember = "TraigoVendedor"
        Me.TraigoVendedorBindingSource.DataSource = Me.DataSet11
        '
        'TraigoDetalleBindingSource2
        '
        Me.TraigoDetalleBindingSource2.DataMember = "TraigoDetalle"
        Me.TraigoDetalleBindingSource2.DataSource = Me.DataSet11
        '
        'TraigoFacturaBindingSource3
        '
        Me.TraigoFacturaBindingSource3.DataMember = "TraigoFactura"
        Me.TraigoFacturaBindingSource3.DataSource = Me.DataSet11
        '
        'FacturaImprime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(910, 390)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.ReportFactura)
        Me.Name = "FacturaImprime"
        Me.Text = "FacturaImprime"
        CType(Me.TraigoFacturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraigoDetalleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraigoVendedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraigoFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraigoFacturaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraigoDetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraigoVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraigoDetalleBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraigoFacturaBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportFactura As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents TraigoFacturaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TraigoFacturaTableAdapter1 As Login.DataSet1TableAdapters.TraigoFacturaTableAdapter
    Friend WithEvents TraigoDetalleBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TraigoDetalleTableAdapter1 As Login.DataSet1TableAdapters.TraigoDetalleTableAdapter
    Friend WithEvents TraigoVendedorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TraigoVendedorTableAdapter1 As Login.DataSet1TableAdapters.TraigoVendedorTableAdapter
    Friend WithEvents DataSet11 As Login.DataSet1
    Friend WithEvents TraigoDetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TraigoFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TraigoVendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TraigoFacturaBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TraigoDetalleBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TraigoFacturaBindingSource3 As System.Windows.Forms.BindingSource
End Class
