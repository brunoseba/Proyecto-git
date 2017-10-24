<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuadroCliente
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
        Me.PanelRegistro = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBProvincia = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TLocal = New System.Windows.Forms.TextBox()
        Me.TPostal = New System.Windows.Forms.TextBox()
        Me.TDire = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TCelular = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TNomApe = New System.Windows.Forms.TextBox()
        Me.TTelef = New System.Windows.Forms.TextBox()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.PanelVer = New System.Windows.Forms.Panel()
        Me.BCancela = New System.Windows.Forms.Button()
        Me.BAcepta = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TB12 = New System.Windows.Forms.TextBox()
        Me.TB11 = New System.Windows.Forms.TextBox()
        Me.TB10 = New System.Windows.Forms.TextBox()
        Me.TB9 = New System.Windows.Forms.TextBox()
        Me.TB8 = New System.Windows.Forms.TextBox()
        Me.TB7 = New System.Windows.Forms.TextBox()
        Me.TB6 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.BModifica = New System.Windows.Forms.Button()
        Me.BBaja = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TB5 = New System.Windows.Forms.TextBox()
        Me.TB4 = New System.Windows.Forms.TextBox()
        Me.TB3 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BAlta = New System.Windows.Forms.Button()
        Me.PanelBusca = New System.Windows.Forms.Panel()
        Me.BSalir2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TApellido2 = New System.Windows.Forms.TextBox()
        Me.CBEstaCli = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TNombreCli = New System.Windows.Forms.TextBox()
        Me.TDniCli = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DataGridCliente = New System.Windows.Forms.DataGridView()
        Me.ColVer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PanelRegistro.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelVer.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.PanelBusca.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRegistro
        '
        Me.PanelRegistro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelRegistro.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelRegistro.Controls.Add(Me.GroupBox3)
        Me.PanelRegistro.Controls.Add(Me.GroupBox2)
        Me.PanelRegistro.Controls.Add(Me.GroupBox1)
        Me.PanelRegistro.Controls.Add(Me.BSalir)
        Me.PanelRegistro.Controls.Add(Me.BGuardar)
        Me.PanelRegistro.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.PanelRegistro.Location = New System.Drawing.Point(0, -2)
        Me.PanelRegistro.Name = "PanelRegistro"
        Me.PanelRegistro.Size = New System.Drawing.Size(1370, 632)
        Me.PanelRegistro.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TEmail)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.DateTime)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.CBEstado)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(26, 428)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1332, 100)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS COMPLEMENTARIOS"
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(123, 44)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(243, 20)
        Me.TEmail.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(53, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "EMAIL"
        '
        'DateTime
        '
        Me.DateTime.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime.Location = New System.Drawing.Point(1004, 41)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(116, 20)
        Me.DateTime.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(921, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "FECHA"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(575, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ESTADO *"
        '
        'CBEstado
        '
        Me.CBEstado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CBEstado.Location = New System.Drawing.Point(681, 44)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(121, 21)
        Me.CBEstado.TabIndex = 7
        Me.CBEstado.Text = "Activo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CBProvincia)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TLocal)
        Me.GroupBox2.Controls.Add(Me.TPostal)
        Me.GroupBox2.Controls.Add(Me.TDire)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(26, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1332, 141)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DOMICILIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "CODIGO POSTAL *"
        '
        'CBProvincia
        '
        Me.CBProvincia.FormattingEnabled = True
        Me.CBProvincia.Items.AddRange(New Object() {"Corrientes", "Chaco", "Misiones", "Entre Rios", "Santa Fe"})
        Me.CBProvincia.Location = New System.Drawing.Point(618, 36)
        Me.CBProvincia.Name = "CBProvincia"
        Me.CBProvincia.Size = New System.Drawing.Size(203, 21)
        Me.CBProvincia.TabIndex = 6
        Me.CBProvincia.Text = "Provincia.."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(527, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "PROVINCIA *"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(943, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "LOCALIDAD"
        '
        'TLocal
        '
        Me.TLocal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLocal.Location = New System.Drawing.Point(1050, 37)
        Me.TLocal.Name = "TLocal"
        Me.TLocal.Size = New System.Drawing.Size(243, 20)
        Me.TLocal.TabIndex = 35
        '
        'TPostal
        '
        Me.TPostal.Location = New System.Drawing.Point(160, 97)
        Me.TPostal.Name = "TPostal"
        Me.TPostal.Size = New System.Drawing.Size(238, 20)
        Me.TPostal.TabIndex = 3
        '
        'TDire
        '
        Me.TDire.Location = New System.Drawing.Point(128, 37)
        Me.TDire.Name = "TDire"
        Me.TDire.Size = New System.Drawing.Size(238, 20)
        Me.TDire.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIRECCION *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TCelular)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TApellido)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TDni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TNomApe)
        Me.GroupBox1.Controls.Add(Me.TTelef)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(26, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1332, 163)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS GENERALES"
        '
        'TCelular
        '
        Me.TCelular.Location = New System.Drawing.Point(170, 101)
        Me.TCelular.Name = "TCelular"
        Me.TCelular.Size = New System.Drawing.Size(238, 20)
        Me.TCelular.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(30, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "CELULAR *"
        '
        'TApellido
        '
        Me.TApellido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TApellido.Location = New System.Drawing.Point(618, 41)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(238, 20)
        Me.TApellido.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(506, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "APELLIDO * "
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(170, 41)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(238, 20)
        Me.TDni.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNI / CUIL / CUIT  *"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(940, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE  *"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(506, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TELEFONO *"
        '
        'TNomApe
        '
        Me.TNomApe.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TNomApe.Location = New System.Drawing.Point(1052, 41)
        Me.TNomApe.Name = "TNomApe"
        Me.TNomApe.Size = New System.Drawing.Size(238, 20)
        Me.TNomApe.TabIndex = 2
        '
        'TTelef
        '
        Me.TTelef.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TTelef.Location = New System.Drawing.Point(618, 102)
        Me.TTelef.Name = "TTelef"
        Me.TTelef.Size = New System.Drawing.Size(238, 20)
        Me.TTelef.TabIndex = 4
        '
        'BSalir
        '
        Me.BSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BSalir.ForeColor = System.Drawing.Color.Black
        Me.BSalir.Location = New System.Drawing.Point(825, 588)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(80, 23)
        Me.BSalir.TabIndex = 38
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BGuardar.ForeColor = System.Drawing.Color.Black
        Me.BGuardar.Location = New System.Drawing.Point(541, 588)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(80, 23)
        Me.BGuardar.TabIndex = 37
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'PanelVer
        '
        Me.PanelVer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVer.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelVer.Controls.Add(Me.BCancela)
        Me.PanelVer.Controls.Add(Me.BAcepta)
        Me.PanelVer.Controls.Add(Me.GroupBox6)
        Me.PanelVer.Controls.Add(Me.BModifica)
        Me.PanelVer.Controls.Add(Me.BBaja)
        Me.PanelVer.Controls.Add(Me.GroupBox4)
        Me.PanelVer.Controls.Add(Me.Button1)
        Me.PanelVer.Controls.Add(Me.BAlta)
        Me.PanelVer.Location = New System.Drawing.Point(0, 0)
        Me.PanelVer.Name = "PanelVer"
        Me.PanelVer.Size = New System.Drawing.Size(1370, 644)
        Me.PanelVer.TabIndex = 4
        '
        'BCancela
        '
        Me.BCancela.Location = New System.Drawing.Point(733, 492)
        Me.BCancela.Name = "BCancela"
        Me.BCancela.Size = New System.Drawing.Size(89, 34)
        Me.BCancela.TabIndex = 58
        Me.BCancela.Text = "Cancelar"
        Me.BCancela.UseVisualStyleBackColor = True
        '
        'BAcepta
        '
        Me.BAcepta.Location = New System.Drawing.Point(531, 492)
        Me.BAcepta.Name = "BAcepta"
        Me.BAcepta.Size = New System.Drawing.Size(82, 34)
        Me.BAcepta.TabIndex = 57
        Me.BAcepta.Text = "Aceptar"
        Me.BAcepta.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TB12)
        Me.GroupBox6.Controls.Add(Me.TB11)
        Me.GroupBox6.Controls.Add(Me.TB10)
        Me.GroupBox6.Controls.Add(Me.TB9)
        Me.GroupBox6.Controls.Add(Me.TB8)
        Me.GroupBox6.Controls.Add(Me.TB7)
        Me.GroupBox6.Controls.Add(Me.TB6)
        Me.GroupBox6.Controls.Add(Me.Label32)
        Me.GroupBox6.Controls.Add(Me.Label33)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.Label29)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label31)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 183)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1336, 149)
        Me.GroupBox6.TabIndex = 56
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'TB12
        '
        Me.TB12.Location = New System.Drawing.Point(818, 91)
        Me.TB12.Name = "TB12"
        Me.TB12.Size = New System.Drawing.Size(122, 20)
        Me.TB12.TabIndex = 62
        '
        'TB11
        '
        Me.TB11.Location = New System.Drawing.Point(510, 91)
        Me.TB11.Name = "TB11"
        Me.TB11.Size = New System.Drawing.Size(93, 20)
        Me.TB11.TabIndex = 61
        '
        'TB10
        '
        Me.TB10.Location = New System.Drawing.Point(100, 91)
        Me.TB10.Name = "TB10"
        Me.TB10.Size = New System.Drawing.Size(249, 20)
        Me.TB10.TabIndex = 60
        '
        'TB9
        '
        Me.TB9.Location = New System.Drawing.Point(1140, 31)
        Me.TB9.Name = "TB9"
        Me.TB9.Size = New System.Drawing.Size(115, 20)
        Me.TB9.TabIndex = 59
        '
        'TB8
        '
        Me.TB8.Location = New System.Drawing.Point(804, 31)
        Me.TB8.Name = "TB8"
        Me.TB8.Size = New System.Drawing.Size(147, 20)
        Me.TB8.TabIndex = 58
        '
        'TB7
        '
        Me.TB7.Location = New System.Drawing.Point(510, 31)
        Me.TB7.Name = "TB7"
        Me.TB7.Size = New System.Drawing.Size(151, 20)
        Me.TB7.TabIndex = 57
        '
        'TB6
        '
        Me.TB6.Location = New System.Drawing.Point(142, 31)
        Me.TB6.Name = "TB6"
        Me.TB6.Size = New System.Drawing.Size(163, 20)
        Me.TB6.TabIndex = 56
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(47, 92)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(47, 16)
        Me.Label32.TabIndex = 36
        Me.Label32.Text = "EMAIL"
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(759, 92)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 16)
        Me.Label33.TabIndex = 37
        Me.Label33.Text = "FECHA"
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(432, 92)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 16)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "ESTADO *"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(1010, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(124, 16)
        Me.Label28.TabIndex = 32
        Me.Label28.Text = "CODIGO POSTAL *"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(416, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(88, 16)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "PROVINCIA *"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(712, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 16)
        Me.Label30.TabIndex = 34
        Me.Label30.Text = "LOCALIDAD"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(47, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(89, 16)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "DIRECCION *"
        '
        'BModifica
        '
        Me.BModifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BModifica.Location = New System.Drawing.Point(727, 555)
        Me.BModifica.Name = "BModifica"
        Me.BModifica.Size = New System.Drawing.Size(108, 38)
        Me.BModifica.TabIndex = 53
        Me.BModifica.Text = "MODIFICAR USUARIO"
        Me.BModifica.UseVisualStyleBackColor = True
        '
        'BBaja
        '
        Me.BBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBaja.Location = New System.Drawing.Point(514, 555)
        Me.BBaja.Name = "BBaja"
        Me.BBaja.Size = New System.Drawing.Size(114, 38)
        Me.BBaja.TabIndex = 52
        Me.BBaja.Text = "BAJA CLIENTE"
        Me.BBaja.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TB5)
        Me.GroupBox4.Controls.Add(Me.TB4)
        Me.GroupBox4.Controls.Add(Me.TB3)
        Me.GroupBox4.Controls.Add(Me.TB2)
        Me.GroupBox4.Controls.Add(Me.TB1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1336, 152)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Principales"
        '
        'TB5
        '
        Me.TB5.Location = New System.Drawing.Point(139, 99)
        Me.TB5.Name = "TB5"
        Me.TB5.Size = New System.Drawing.Size(110, 20)
        Me.TB5.TabIndex = 57
        '
        'TB4
        '
        Me.TB4.BackColor = System.Drawing.SystemColors.Window
        Me.TB4.Location = New System.Drawing.Point(1106, 28)
        Me.TB4.Name = "TB4"
        Me.TB4.Size = New System.Drawing.Size(126, 20)
        Me.TB4.TabIndex = 56
        '
        'TB3
        '
        Me.TB3.Location = New System.Drawing.Point(766, 28)
        Me.TB3.Name = "TB3"
        Me.TB3.Size = New System.Drawing.Size(138, 20)
        Me.TB3.TabIndex = 55
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(443, 28)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(151, 20)
        Me.TB2.TabIndex = 54
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(103, 27)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(164, 20)
        Me.TB1.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DNI *"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(359, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "NOMBRE  *"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(49, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "CELULAR  *"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1012, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "TELEFONO *"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(680, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "APELLIDO *"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1106, 542)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BAlta
        '
        Me.BAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAlta.Location = New System.Drawing.Point(301, 555)
        Me.BAlta.Name = "BAlta"
        Me.BAlta.Size = New System.Drawing.Size(123, 38)
        Me.BAlta.TabIndex = 0
        Me.BAlta.Text = "ALTA CLIENTE"
        Me.BAlta.UseVisualStyleBackColor = True
        '
        'PanelBusca
        '
        Me.PanelBusca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBusca.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelBusca.Controls.Add(Me.BSalir2)
        Me.PanelBusca.Controls.Add(Me.GroupBox5)
        Me.PanelBusca.Controls.Add(Me.DataGridCliente)
        Me.PanelBusca.Location = New System.Drawing.Point(0, 0)
        Me.PanelBusca.Name = "PanelBusca"
        Me.PanelBusca.Size = New System.Drawing.Size(1370, 627)
        Me.PanelBusca.TabIndex = 5
        '
        'BSalir2
        '
        Me.BSalir2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BSalir2.Location = New System.Drawing.Point(675, 563)
        Me.BSalir2.Name = "BSalir2"
        Me.BSalir2.Size = New System.Drawing.Size(75, 36)
        Me.BSalir2.TabIndex = 2
        Me.BSalir2.Text = "Salir"
        Me.BSalir2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.TApellido2)
        Me.GroupBox5.Controls.Add(Me.CBEstaCli)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.TNombreCli)
        Me.GroupBox5.Controls.Add(Me.TDniCli)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(10, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1337, 106)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Buscar Cliente"
        '
        'TApellido2
        '
        Me.TApellido2.Location = New System.Drawing.Point(717, 35)
        Me.TApellido2.Name = "TApellido2"
        Me.TApellido2.Size = New System.Drawing.Size(178, 24)
        Me.TApellido2.TabIndex = 9
        '
        'CBEstaCli
        '
        Me.CBEstaCli.FormattingEnabled = True
        Me.CBEstaCli.Items.AddRange(New Object() {"", "Alta", "Baja"})
        Me.CBEstaCli.Location = New System.Drawing.Point(1017, 35)
        Me.CBEstaCli.Name = "CBEstaCli"
        Me.CBEstaCli.Size = New System.Drawing.Size(121, 26)
        Me.CBEstaCli.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(937, 37)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 18)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "ESTADO:"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(612, 37)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(87, 18)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "APELLIDO :"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Image = Global.Login.My.Resources.Resources.search16_h
        Me.Button2.Location = New System.Drawing.Point(1212, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TNombreCli
        '
        Me.TNombreCli.Location = New System.Drawing.Point(390, 34)
        Me.TNombreCli.Name = "TNombreCli"
        Me.TNombreCli.Size = New System.Drawing.Size(153, 24)
        Me.TNombreCli.TabIndex = 3
        '
        'TDniCli
        '
        Me.TDniCli.Location = New System.Drawing.Point(71, 34)
        Me.TDniCli.Name = "TDniCli"
        Me.TDniCli.Size = New System.Drawing.Size(165, 24)
        Me.TDniCli.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(291, 37)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(83, 18)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "NOMBRE :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(27, 38)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 18)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "DNI:"
        '
        'DataGridCliente
        '
        Me.DataGridCliente.AllowUserToAddRows = False
        Me.DataGridCliente.AllowUserToDeleteRows = False
        Me.DataGridCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColVer})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridCliente.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridCliente.Location = New System.Drawing.Point(26, 135)
        Me.DataGridCliente.Name = "DataGridCliente"
        Me.DataGridCliente.ReadOnly = True
        Me.DataGridCliente.Size = New System.Drawing.Size(1314, 401)
        Me.DataGridCliente.TabIndex = 1
        '
        'ColVer
        '
        Me.ColVer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColVer.HeaderText = "Ver"
        Me.ColVer.Name = "ColVer"
        Me.ColVer.ReadOnly = True
        Me.ColVer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColVer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColVer.Text = "Ver"
        Me.ColVer.ToolTipText = "Ver"
        Me.ColVer.UseColumnTextForButtonValue = True
        Me.ColVer.Width = 48
        '
        'CuadroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 623)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelBusca)
        Me.Controls.Add(Me.PanelVer)
        Me.Controls.Add(Me.PanelRegistro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CuadroCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelRegistro.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelVer.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.PanelBusca.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelRegistro As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TDni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TNomApe As System.Windows.Forms.TextBox
    Friend WithEvents TPostal As System.Windows.Forms.TextBox
    Friend WithEvents TTelef As System.Windows.Forms.TextBox
    Friend WithEvents TDire As System.Windows.Forms.TextBox
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents TLocal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBEstado As System.Windows.Forms.ComboBox
    Friend WithEvents PanelVer As System.Windows.Forms.Panel
    Friend WithEvents BModifica As System.Windows.Forms.Button
    Friend WithEvents BBaja As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BAlta As System.Windows.Forms.Button
    Friend WithEvents PanelBusca As System.Windows.Forms.Panel
    Friend WithEvents BSalir2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CBEstaCli As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TNombreCli As System.Windows.Forms.TextBox
    Friend WithEvents TDniCli As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DataGridCliente As System.Windows.Forms.DataGridView
    Friend WithEvents TApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents ColVer As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TB5 As System.Windows.Forms.TextBox
    Friend WithEvents TB4 As System.Windows.Forms.TextBox
    Friend WithEvents TB3 As System.Windows.Forms.TextBox
    Friend WithEvents TB2 As System.Windows.Forms.TextBox
    Friend WithEvents TB1 As System.Windows.Forms.TextBox
    Friend WithEvents TB12 As System.Windows.Forms.TextBox
    Friend WithEvents TB11 As System.Windows.Forms.TextBox
    Friend WithEvents TB10 As System.Windows.Forms.TextBox
    Friend WithEvents TB9 As System.Windows.Forms.TextBox
    Friend WithEvents TB8 As System.Windows.Forms.TextBox
    Friend WithEvents TB7 As System.Windows.Forms.TextBox
    Friend WithEvents TB6 As System.Windows.Forms.TextBox
    Friend WithEvents BCancela As System.Windows.Forms.Button
    Friend WithEvents BAcepta As System.Windows.Forms.Button
End Class
