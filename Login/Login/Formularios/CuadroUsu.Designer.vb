<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuadroUsu
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
        Me.PanelRegistro = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBUsuario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TNomApe = New System.Windows.Forms.TextBox()
        Me.TContra = New System.Windows.Forms.TextBox()
        Me.TTelef = New System.Windows.Forms.TextBox()
        Me.TDire = New System.Windows.Forms.TextBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.TLocal = New System.Windows.Forms.TextBox()
        Me.TProv = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelRegistro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRegistro
        '
        Me.PanelRegistro.Controls.Add(Me.GroupBox1)
        Me.PanelRegistro.Controls.Add(Me.BSalir)
        Me.PanelRegistro.Controls.Add(Me.BGuardar)
        Me.PanelRegistro.Controls.Add(Me.TEmail)
        Me.PanelRegistro.Controls.Add(Me.TLocal)
        Me.PanelRegistro.Controls.Add(Me.TProv)
        Me.PanelRegistro.Controls.Add(Me.Label11)
        Me.PanelRegistro.Controls.Add(Me.DateTime)
        Me.PanelRegistro.Controls.Add(Me.Label4)
        Me.PanelRegistro.Controls.Add(Me.Label7)
        Me.PanelRegistro.Controls.Add(Me.Label5)
        Me.PanelRegistro.Location = New System.Drawing.Point(0, -2)
        Me.PanelRegistro.Name = "PanelRegistro"
        Me.PanelRegistro.Size = New System.Drawing.Size(1028, 416)
        Me.PanelRegistro.TabIndex = 0
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
        Me.GroupBox1.Location = New System.Drawing.Point(33, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(972, 183)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Campos Obligatorios"
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(145, 19)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(238, 20)
        Me.TDni.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE y APELLIDO *"
        '
        'CBUsuario
        '
        Me.CBUsuario.FormattingEnabled = True
        Me.CBUsuario.Items.AddRange(New Object() {"Administrador", "Supervisor", "Vendedor"})
        Me.CBUsuario.Location = New System.Drawing.Point(567, 135)
        Me.CBUsuario.Name = "CBUsuario"
        Me.CBUsuario.Size = New System.Drawing.Size(121, 21)
        Me.CBUsuario.TabIndex = 6
        Me.CBUsuario.Text = "Tipo usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIRECCION *"
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CBEstado.Location = New System.Drawing.Point(807, 135)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(121, 21)
        Me.CBEstado.TabIndex = 7
        Me.CBEstado.Text = "Selecione.."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(476, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TELEFONO *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "CONTRASEÑA *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(728, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ESTADO *"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(476, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "USUARIO *"
        '
        'TNomApe
        '
        Me.TNomApe.Location = New System.Drawing.Point(624, 22)
        Me.TNomApe.Name = "TNomApe"
        Me.TNomApe.Size = New System.Drawing.Size(238, 20)
        Me.TNomApe.TabIndex = 2
        '
        'TContra
        '
        Me.TContra.Location = New System.Drawing.Point(145, 79)
        Me.TContra.Name = "TContra"
        Me.TContra.Size = New System.Drawing.Size(238, 20)
        Me.TContra.TabIndex = 3
        '
        'TTelef
        '
        Me.TTelef.Location = New System.Drawing.Point(624, 79)
        Me.TTelef.Name = "TTelef"
        Me.TTelef.Size = New System.Drawing.Size(238, 20)
        Me.TTelef.TabIndex = 4
        '
        'TDire
        '
        Me.TDire.Location = New System.Drawing.Point(145, 135)
        Me.TDire.Name = "TDire"
        Me.TDire.Size = New System.Drawing.Size(238, 20)
        Me.TDire.TabIndex = 5
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(558, 347)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(80, 23)
        Me.BSalir.TabIndex = 38
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(369, 347)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(80, 23)
        Me.BGuardar.TabIndex = 37
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(178, 281)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(243, 20)
        Me.TEmail.TabIndex = 36
        '
        'TLocal
        '
        Me.TLocal.Location = New System.Drawing.Point(636, 221)
        Me.TLocal.Name = "TLocal"
        Me.TLocal.Size = New System.Drawing.Size(243, 20)
        Me.TLocal.TabIndex = 35
        '
        'TProv
        '
        Me.TProv.Location = New System.Drawing.Point(178, 221)
        Me.TProv.Name = "TProv"
        Me.TProv.Size = New System.Drawing.Size(243, 20)
        Me.TProv.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(534, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "FECHA"
        '
        'DateTime
        '
        Me.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime.Location = New System.Drawing.Point(636, 281)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(116, 20)
        Me.DateTime.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(509, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "LOCALIDAD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(108, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "EMAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "PROVINCIA"
        '
        'CuadroUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 453)
        Me.Controls.Add(Me.PanelRegistro)
        Me.Name = "CuadroUsu"
        Me.Text = "CuadroUsu"
        Me.PanelRegistro.ResumeLayout(False)
        Me.PanelRegistro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelRegistro As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TDni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TNomApe As System.Windows.Forms.TextBox
    Friend WithEvents TContra As System.Windows.Forms.TextBox
    Friend WithEvents TTelef As System.Windows.Forms.TextBox
    Friend WithEvents TDire As System.Windows.Forms.TextBox
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents TEmail As System.Windows.Forms.TextBox
    Friend WithEvents TLocal As System.Windows.Forms.TextBox
    Friend WithEvents TProv As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
