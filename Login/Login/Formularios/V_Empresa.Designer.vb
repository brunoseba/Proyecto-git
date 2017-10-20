<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresas
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
        Me.Panel_modificar_Empresa = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxEmailEmpresa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTelefonoEmpresa = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccionEmpresa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.ButtonSalirEmpresa = New System.Windows.Forms.Button()
        Me.ButtonGuardarEmpresa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Ver_Datos_Empresa = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelCuit = New System.Windows.Forms.Label()
        Me.LabelECuit = New System.Windows.Forms.Label()
        Me.LabelDireccion = New System.Windows.Forms.Label()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelEDireccion = New System.Windows.Forms.Label()
        Me.LabelENombre = New System.Windows.Forms.Label()
        Me.LabelEEmail = New System.Windows.Forms.Label()
        Me.LabelETelefono = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.ButtonEAceptar = New System.Windows.Forms.Button()
        Me.LabelETitulo = New System.Windows.Forms.Label()
        Me.TextBoxCuitEmpresa = New System.Windows.Forms.TextBox()
        Me.Panel_modificar_Empresa.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel_Ver_Datos_Empresa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_modificar_Empresa
        '
        Me.Panel_modificar_Empresa.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel_modificar_Empresa.Controls.Add(Me.GroupBox2)
        Me.Panel_modificar_Empresa.Controls.Add(Me.ButtonSalirEmpresa)
        Me.Panel_modificar_Empresa.Controls.Add(Me.ButtonGuardarEmpresa)
        Me.Panel_modificar_Empresa.Controls.Add(Me.Label1)
        Me.Panel_modificar_Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_modificar_Empresa.Location = New System.Drawing.Point(2, 1)
        Me.Panel_modificar_Empresa.Name = "Panel_modificar_Empresa"
        Me.Panel_modificar_Empresa.Size = New System.Drawing.Size(1370, 620)
        Me.Panel_modificar_Empresa.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxEmailEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxTelefonoEmpresa)
        Me.GroupBox2.Controls.Add(Me.TextBoxDireccionEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBoxCuitEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxNombreEmpresa)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1224, 340)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'TextBoxEmailEmpresa
        '
        Me.TextBoxEmailEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmailEmpresa.Location = New System.Drawing.Point(947, 67)
        Me.TextBoxEmailEmpresa.Name = "TextBoxEmailEmpresa"
        Me.TextBoxEmailEmpresa.Size = New System.Drawing.Size(253, 26)
        Me.TextBoxEmailEmpresa.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "C.U.I.T:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(478, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombre:"
        '
        'TextBoxTelefonoEmpresa
        '
        Me.TextBoxTelefonoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefonoEmpresa.Location = New System.Drawing.Point(787, 172)
        Me.TextBoxTelefonoEmpresa.Name = "TextBoxTelefonoEmpresa"
        Me.TextBoxTelefonoEmpresa.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxTelefonoEmpresa.TabIndex = 9
        '
        'TextBoxDireccionEmpresa
        '
        Me.TextBoxDireccionEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDireccionEmpresa.Location = New System.Drawing.Point(325, 172)
        Me.TextBoxDireccionEmpresa.Name = "TextBoxDireccionEmpresa"
        Me.TextBoxDireccionEmpresa.Size = New System.Drawing.Size(247, 26)
        Me.TextBoxDireccionEmpresa.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(850, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "E-mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(204, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(663, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono:"
        '
        'TextBoxNombreEmpresa
        '
        Me.TextBoxNombreEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombreEmpresa.Location = New System.Drawing.Point(588, 67)
        Me.TextBoxNombreEmpresa.Name = "TextBoxNombreEmpresa"
        Me.TextBoxNombreEmpresa.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxNombreEmpresa.TabIndex = 6
        '
        'ButtonSalirEmpresa
        '
        Me.ButtonSalirEmpresa.Location = New System.Drawing.Point(705, 494)
        Me.ButtonSalirEmpresa.Name = "ButtonSalirEmpresa"
        Me.ButtonSalirEmpresa.Size = New System.Drawing.Size(139, 35)
        Me.ButtonSalirEmpresa.TabIndex = 11
        Me.ButtonSalirEmpresa.Text = "Salir"
        Me.ButtonSalirEmpresa.UseVisualStyleBackColor = True
        '
        'ButtonGuardarEmpresa
        '
        Me.ButtonGuardarEmpresa.Location = New System.Drawing.Point(446, 494)
        Me.ButtonGuardarEmpresa.Name = "ButtonGuardarEmpresa"
        Me.ButtonGuardarEmpresa.Size = New System.Drawing.Size(139, 35)
        Me.ButtonGuardarEmpresa.TabIndex = 10
        Me.ButtonGuardarEmpresa.Text = "Modificar"
        Me.ButtonGuardarEmpresa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(466, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modificar Datos de la Empresa"
        '
        'Panel_Ver_Datos_Empresa
        '
        Me.Panel_Ver_Datos_Empresa.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.GroupBox1)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.ButtonEAceptar)
        Me.Panel_Ver_Datos_Empresa.Controls.Add(Me.LabelETitulo)
        Me.Panel_Ver_Datos_Empresa.Location = New System.Drawing.Point(2, 1)
        Me.Panel_Ver_Datos_Empresa.Name = "Panel_Ver_Datos_Empresa"
        Me.Panel_Ver_Datos_Empresa.Size = New System.Drawing.Size(1373, 623)
        Me.Panel_Ver_Datos_Empresa.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelCuit)
        Me.GroupBox1.Controls.Add(Me.LabelECuit)
        Me.GroupBox1.Controls.Add(Me.LabelDireccion)
        Me.GroupBox1.Controls.Add(Me.LabelTelefono)
        Me.GroupBox1.Controls.Add(Me.LabelEmail)
        Me.GroupBox1.Controls.Add(Me.LabelEDireccion)
        Me.GroupBox1.Controls.Add(Me.LabelENombre)
        Me.GroupBox1.Controls.Add(Me.LabelEEmail)
        Me.GroupBox1.Controls.Add(Me.LabelETelefono)
        Me.GroupBox1.Controls.Add(Me.LabelNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(46, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1286, 286)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'LabelCuit
        '
        Me.LabelCuit.AutoSize = True
        Me.LabelCuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCuit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelCuit.Location = New System.Drawing.Point(159, 74)
        Me.LabelCuit.Name = "LabelCuit"
        Me.LabelCuit.Size = New System.Drawing.Size(0, 25)
        Me.LabelCuit.TabIndex = 6
        '
        'LabelECuit
        '
        Me.LabelECuit.AutoSize = True
        Me.LabelECuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelECuit.Location = New System.Drawing.Point(81, 75)
        Me.LabelECuit.Name = "LabelECuit"
        Me.LabelECuit.Size = New System.Drawing.Size(80, 24)
        Me.LabelECuit.TabIndex = 1
        Me.LabelECuit.Text = "C.U.I.T:"
        '
        'LabelDireccion
        '
        Me.LabelDireccion.AutoSize = True
        Me.LabelDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelDireccion.Location = New System.Drawing.Point(178, 174)
        Me.LabelDireccion.Name = "LabelDireccion"
        Me.LabelDireccion.Size = New System.Drawing.Size(0, 25)
        Me.LabelDireccion.TabIndex = 9
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelTelefono.Location = New System.Drawing.Point(1107, 76)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(0, 25)
        Me.LabelTelefono.TabIndex = 10
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelEmail.Location = New System.Drawing.Point(681, 172)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(0, 25)
        Me.LabelEmail.TabIndex = 8
        '
        'LabelEDireccion
        '
        Me.LabelEDireccion.AutoSize = True
        Me.LabelEDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelEDireccion.Location = New System.Drawing.Point(67, 174)
        Me.LabelEDireccion.Name = "LabelEDireccion"
        Me.LabelEDireccion.Size = New System.Drawing.Size(105, 24)
        Me.LabelEDireccion.TabIndex = 4
        Me.LabelEDireccion.Text = "Direccion:"
        '
        'LabelENombre
        '
        Me.LabelENombre.AutoSize = True
        Me.LabelENombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelENombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelENombre.Location = New System.Drawing.Point(551, 75)
        Me.LabelENombre.Name = "LabelENombre"
        Me.LabelENombre.Size = New System.Drawing.Size(91, 24)
        Me.LabelENombre.TabIndex = 2
        Me.LabelENombre.Text = "Nombre:"
        '
        'LabelEEmail
        '
        Me.LabelEEmail.AutoSize = True
        Me.LabelEEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelEEmail.Location = New System.Drawing.Point(600, 173)
        Me.LabelEEmail.Name = "LabelEEmail"
        Me.LabelEEmail.Size = New System.Drawing.Size(75, 24)
        Me.LabelEEmail.TabIndex = 3
        Me.LabelEEmail.Text = "E-mail:"
        '
        'LabelETelefono
        '
        Me.LabelETelefono.AutoSize = True
        Me.LabelETelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelETelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelETelefono.Location = New System.Drawing.Point(1007, 77)
        Me.LabelETelefono.Name = "LabelETelefono"
        Me.LabelETelefono.Size = New System.Drawing.Size(99, 24)
        Me.LabelETelefono.TabIndex = 5
        Me.LabelETelefono.Text = "Teléfono:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelNombre.Location = New System.Drawing.Point(641, 75)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(0, 25)
        Me.LabelNombre.TabIndex = 7
        '
        'ButtonEAceptar
        '
        Me.ButtonEAceptar.Location = New System.Drawing.Point(601, 503)
        Me.ButtonEAceptar.Name = "ButtonEAceptar"
        Me.ButtonEAceptar.Size = New System.Drawing.Size(127, 36)
        Me.ButtonEAceptar.TabIndex = 11
        Me.ButtonEAceptar.Text = "Aceptar"
        Me.ButtonEAceptar.UseVisualStyleBackColor = True
        '
        'LabelETitulo
        '
        Me.LabelETitulo.AutoSize = True
        Me.LabelETitulo.Font = New System.Drawing.Font("Georgia", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelETitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelETitulo.Location = New System.Drawing.Point(518, 56)
        Me.LabelETitulo.Name = "LabelETitulo"
        Me.LabelETitulo.Size = New System.Drawing.Size(359, 38)
        Me.LabelETitulo.TabIndex = 0
        Me.LabelETitulo.Text = "Datos de la Empresa"
        '
        'TextBoxCuitEmpresa
        '
        Me.TextBoxCuitEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCuitEmpresa.Location = New System.Drawing.Point(127, 67)
        Me.TextBoxCuitEmpresa.Name = "TextBoxCuitEmpresa"
        Me.TextBoxCuitEmpresa.Size = New System.Drawing.Size(207, 26)
        Me.TextBoxCuitEmpresa.TabIndex = 5
        '
        'Empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 623)
        Me.Controls.Add(Me.Panel_modificar_Empresa)
        Me.Controls.Add(Me.Panel_Ver_Datos_Empresa)
        Me.Name = "Empresas"
        Me.Text = "Empresa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel_modificar_Empresa.ResumeLayout(False)
        Me.Panel_modificar_Empresa.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel_Ver_Datos_Empresa.ResumeLayout(False)
        Me.Panel_Ver_Datos_Empresa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_modificar_Empresa As System.Windows.Forms.Panel
    Friend WithEvents ButtonSalirEmpresa As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardarEmpresa As System.Windows.Forms.Button
    Friend WithEvents TextBoxTelefonoEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDireccionEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmailEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombreEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel_Ver_Datos_Empresa As System.Windows.Forms.Panel
    Friend WithEvents ButtonEAceptar As System.Windows.Forms.Button
    Friend WithEvents LabelTelefono As System.Windows.Forms.Label
    Friend WithEvents LabelDireccion As System.Windows.Forms.Label
    Friend WithEvents LabelEmail As System.Windows.Forms.Label
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents LabelCuit As System.Windows.Forms.Label
    Friend WithEvents LabelETelefono As System.Windows.Forms.Label
    Friend WithEvents LabelEDireccion As System.Windows.Forms.Label
    Friend WithEvents LabelEEmail As System.Windows.Forms.Label
    Friend WithEvents LabelENombre As System.Windows.Forms.Label
    Friend WithEvents LabelECuit As System.Windows.Forms.Label
    Friend WithEvents LabelETitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCuitEmpresa As System.Windows.Forms.TextBox
End Class
