<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresa))
        Me.Panel_Ver_Datos_Empresa = New System.Windows.Forms.Panel()
        Me.LabelETitulo = New System.Windows.Forms.Label()
        Me.LabelECuit = New System.Windows.Forms.Label()
        Me.LabelENombre = New System.Windows.Forms.Label()
        Me.LabelEEmail = New System.Windows.Forms.Label()
        Me.LabelEDireccion = New System.Windows.Forms.Label()
        Me.LabelETelefono = New System.Windows.Forms.Label()
        Me.LabelCuit = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.ButtonEAceptar = New System.Windows.Forms.Button()
        Me.ButtonECancelar = New System.Windows.Forms.Button()
        Me.Panel_Ver_Datos_Empresa.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Ver_Datos_Empresa
        '
        Me.Panel_Ver_Datos_Empresa.BackColor = System.Drawing.Color.Firebrick
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.ButtonECancelar)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.ButtonEAceptar)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelTelefono)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelDireccion)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelEmail)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelNombre)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelCuit)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelETelefono)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelEDireccion)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelEEmail)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelENombre)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelECuit)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelETitulo)
        Me.Panel_Ver_Datos_Empresa.Location = New System.Drawing.Point(12, 12)
        Me.Panel_Ver_Datos_Empresa.Name = "Panel_Ver_Datos_Empresa"
        Me.Panel_Ver_Datos_Empresa.Size = New System.Drawing.Size(1300, 582)
        Me.Panel_Ver_Datos_Empresa.TabIndex = 0
        '
        'LabelETitulo
        '
        Me.LabelETitulo.AutoSize = True
        Me.LabelETitulo.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelETitulo.Location = New System.Drawing.Point(464, 38)
        Me.LabelETitulo.Name = "LabelETitulo"
        Me.LabelETitulo.Size = New System.Drawing.Size(344, 45)
        Me.LabelETitulo.TabIndex = 0
        Me.LabelETitulo.Text = "Datos de la Empresa"
        '
        'LabelECuit
        '
        Me.LabelECuit.AutoSize = True
        Me.LabelECuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelECuit.Location = New System.Drawing.Point(80, 167)
        Me.LabelECuit.Name = "LabelECuit"
        Me.LabelECuit.Size = New System.Drawing.Size(72, 24)
        Me.LabelECuit.TabIndex = 1
        Me.LabelECuit.Text = "C.U.I.T:"
        '
        'LabelENombre
        '
        Me.LabelENombre.AutoSize = True
        Me.LabelENombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelENombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelENombre.Location = New System.Drawing.Point(550, 167)
        Me.LabelENombre.Name = "LabelENombre"
        Me.LabelENombre.Size = New System.Drawing.Size(84, 24)
        Me.LabelENombre.TabIndex = 2
        Me.LabelENombre.Text = "Nombre:"
        '
        'LabelEEmail
        '
        Me.LabelEEmail.AutoSize = True
        Me.LabelEEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelEEmail.Location = New System.Drawing.Point(1006, 167)
        Me.LabelEEmail.Name = "LabelEEmail"
        Me.LabelEEmail.Size = New System.Drawing.Size(68, 24)
        Me.LabelEEmail.TabIndex = 3
        Me.LabelEEmail.Text = "E-mail:"
        '
        'LabelEDireccion
        '
        Me.LabelEDireccion.AutoSize = True
        Me.LabelEDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelEDireccion.Location = New System.Drawing.Point(80, 357)
        Me.LabelEDireccion.Name = "LabelEDireccion"
        Me.LabelEDireccion.Size = New System.Drawing.Size(95, 24)
        Me.LabelEDireccion.TabIndex = 4
        Me.LabelEDireccion.Text = "Direccion:"
        '
        'LabelETelefono
        '
        Me.LabelETelefono.AutoSize = True
        Me.LabelETelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelETelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelETelefono.Location = New System.Drawing.Point(662, 357)
        Me.LabelETelefono.Name = "LabelETelefono"
        Me.LabelETelefono.Size = New System.Drawing.Size(90, 24)
        Me.LabelETelefono.TabIndex = 5
        Me.LabelETelefono.Text = "Teléfono:"
        '
        'LabelCuit
        '
        Me.LabelCuit.AutoSize = True
        Me.LabelCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCuit.Location = New System.Drawing.Point(158, 166)
        Me.LabelCuit.Name = "LabelCuit"
        Me.LabelCuit.Size = New System.Drawing.Size(70, 25)
        Me.LabelCuit.TabIndex = 6
        Me.LabelCuit.Text = "label2"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(640, 167)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(70, 25)
        Me.LabelNombre.TabIndex = 7
        Me.LabelNombre.Text = "label2"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(1069, 167)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(70, 25)
        Me.LabelEmail.TabIndex = 8
        Me.LabelEmail.Text = "label2"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDireccion.Location = New System.Drawing.Point(181, 356)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(70, 25)
        Me.LabelDireccion.TabIndex = 9
        Me.LabelDireccion.Text = "label2"
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefono.Location = New System.Drawing.Point(762, 356)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(70, 25)
        Me.LabelTelefono.TabIndex = 10
        Me.LabelTelefono.Text = "label2"
        '
        'ButtonEAceptar
        '
        Me.ButtonEAceptar.Location = New System.Drawing.Point(420, 494)
        Me.ButtonEAceptar.Name = "ButtonEAceptar"
        Me.ButtonEAceptar.Size = New System.Drawing.Size(127, 36)
        Me.ButtonEAceptar.TabIndex = 11
        Me.ButtonEAceptar.Text = "Aceptar"
        Me.ButtonEAceptar.UseVisualStyleBackColor = True
        '
        'ButtonECancelar
        '
        Me.ButtonECancelar.Location = New System.Drawing.Point(792, 494)
        Me.ButtonECancelar.Name = "ButtonECancelar"
        Me.ButtonECancelar.Size = New System.Drawing.Size(127, 36)
        Me.ButtonECancelar.TabIndex = 12
        Me.ButtonECancelar.Text = "Cancelar"
        Me.ButtonECancelar.UseVisualStyleBackColor = True
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 606)
        Me.Controls.Add(Me.Panel_Ver_Datos_Empresa)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Empresa"
        Me.Text = "Empresa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_Ver_Datos_Empresa.ResumeLayout(False)
        Me.Panel_Ver_Datos_Empresa.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Ver_Datos_Empresa As System.Windows.Forms.Panel
    Friend WithEvents LabelETelefono As System.Windows.Forms.Label
    Friend WithEvents LabelEDireccion As System.Windows.Forms.Label
    Friend WithEvents LabelEEmail As System.Windows.Forms.Label
    Friend WithEvents LabelENombre As System.Windows.Forms.Label
    Friend WithEvents LabelECuit As System.Windows.Forms.Label
    Friend WithEvents LabelETitulo As System.Windows.Forms.Label
    Friend WithEvents LabelCuit As System.Windows.Forms.Label
    Friend WithEvents LabelTelefono As System.Windows.Forms.Label
    Friend WithEvents LabelDireccion As System.Windows.Forms.Label
    Friend WithEvents LabelEmail As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents ButtonECancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonEAceptar As System.Windows.Forms.Button
End Class
