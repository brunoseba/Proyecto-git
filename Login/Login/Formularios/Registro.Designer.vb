<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNomApe = New System.Windows.Forms.TextBox()
        Me.TTelef = New System.Windows.Forms.TextBox()
        Me.TProv = New System.Windows.Forms.TextBox()
        Me.TLocal = New System.Windows.Forms.TextBox()
        Me.TDire = New System.Windows.Forms.TextBox()
        Me.TContra = New System.Windows.Forms.TextBox()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.CBUsuario = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dni *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(361, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre y apellido *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(403, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Provincia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(387, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefono *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Contraseña *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(560, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(361, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Usuario *"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(404, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fecha"
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(91, 19)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(238, 20)
        Me.TDni.TabIndex = 1
        '
        'TNomApe
        '
        Me.TNomApe.Location = New System.Drawing.Point(475, 19)
        Me.TNomApe.Name = "TNomApe"
        Me.TNomApe.Size = New System.Drawing.Size(238, 20)
        Me.TNomApe.TabIndex = 2
        '
        'TTelef
        '
        Me.TTelef.Location = New System.Drawing.Point(475, 57)
        Me.TTelef.Name = "TTelef"
        Me.TTelef.Size = New System.Drawing.Size(238, 20)
        Me.TTelef.TabIndex = 4
        '
        'TProv
        '
        Me.TProv.Location = New System.Drawing.Point(111, 150)
        Me.TProv.Name = "TProv"
        Me.TProv.Size = New System.Drawing.Size(238, 20)
        Me.TProv.TabIndex = 14
        '
        'TLocal
        '
        Me.TLocal.Location = New System.Drawing.Point(478, 150)
        Me.TLocal.Name = "TLocal"
        Me.TLocal.Size = New System.Drawing.Size(238, 20)
        Me.TLocal.TabIndex = 15
        '
        'TDire
        '
        Me.TDire.Location = New System.Drawing.Point(91, 95)
        Me.TDire.Name = "TDire"
        Me.TDire.Size = New System.Drawing.Size(238, 20)
        Me.TDire.TabIndex = 5
        '
        'TContra
        '
        Me.TContra.Location = New System.Drawing.Point(91, 57)
        Me.TContra.Name = "TContra"
        Me.TContra.Size = New System.Drawing.Size(238, 20)
        Me.TContra.TabIndex = 3
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(112, 190)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(238, 20)
        Me.TEmail.TabIndex = 20
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(259, 256)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 22
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(448, 256)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 23
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CBEstado.Location = New System.Drawing.Point(610, 90)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(121, 21)
        Me.CBEstado.TabIndex = 7
        Me.CBEstado.Text = "Selecione.."
        '
        'CBUsuario
        '
        Me.CBUsuario.FormattingEnabled = True
        Me.CBUsuario.Items.AddRange(New Object() {"Administrador", "Supervisor", "Vendedor"})
        Me.CBUsuario.Location = New System.Drawing.Point(417, 88)
        Me.CBUsuario.Name = "CBUsuario"
        Me.CBUsuario.Size = New System.Drawing.Size(121, 21)
        Me.CBUsuario.TabIndex = 6
        Me.CBUsuario.Text = "Tipo usuario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TDni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CBUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CBEstado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TNomApe)
        Me.GroupBox1.Controls.Add(Me.TContra)
        Me.GroupBox1.Controls.Add(Me.TTelef)
        Me.GroupBox1.Controls.Add(Me.TDire)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 127)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Campos Obligatorios"
        '
        'DateTime
        '
        Me.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime.Location = New System.Drawing.Point(478, 187)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(111, 20)
        Me.DateTime.TabIndex = 29
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 297)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.TEmail)
        Me.Controls.Add(Me.TLocal)
        Me.Controls.Add(Me.TProv)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TDni As System.Windows.Forms.TextBox
    Friend WithEvents TNomApe As System.Windows.Forms.TextBox
    Friend WithEvents TTelef As System.Windows.Forms.TextBox
    Friend WithEvents TProv As System.Windows.Forms.TextBox
    Friend WithEvents TLocal As System.Windows.Forms.TextBox
    Friend WithEvents TDire As System.Windows.Forms.TextBox
    Friend WithEvents TContra As System.Windows.Forms.TextBox
    Friend WithEvents TEmail As System.Windows.Forms.TextBox
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents CBEstado As System.Windows.Forms.ComboBox
    Friend WithEvents CBUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTime As System.Windows.Forms.DateTimePicker
End Class
