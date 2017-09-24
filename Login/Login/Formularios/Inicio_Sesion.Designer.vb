<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_Sesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio_Sesion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LIcontra = New System.Windows.Forms.Label()
        Me.LIusu = New System.Windows.Forms.Label()
        Me.TContra = New System.Windows.Forms.TextBox()
        Me.Tusuario = New System.Windows.Forms.TextBox()
        Me.LContra = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.PBarra = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBarra2 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BSalir)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.LIcontra)
        Me.Panel1.Controls.Add(Me.LIusu)
        Me.Panel1.Controls.Add(Me.TContra)
        Me.Panel1.Controls.Add(Me.Tusuario)
        Me.Panel1.Controls.Add(Me.LContra)
        Me.Panel1.Controls.Add(Me.LUsuario)
        Me.Panel1.Location = New System.Drawing.Point(76, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 178)
        Me.Panel1.TabIndex = 0
        '
        'BSalir
        '
        Me.BSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BSalir.Location = New System.Drawing.Point(84, 139)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(75, 23)
        Me.BSalir.TabIndex = 7
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(254, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LIcontra
        '
        Me.LIcontra.AutoSize = True
        Me.LIcontra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIcontra.ForeColor = System.Drawing.Color.Red
        Me.LIcontra.Location = New System.Drawing.Point(246, 71)
        Me.LIcontra.Name = "LIcontra"
        Me.LIcontra.Size = New System.Drawing.Size(123, 16)
        Me.LIcontra.TabIndex = 5
        Me.LIcontra.Text = "Ingrese contraseña"
        Me.LIcontra.Visible = False
        '
        'LIusu
        '
        Me.LIusu.AutoSize = True
        Me.LIusu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIusu.ForeColor = System.Drawing.Color.Red
        Me.LIusu.Location = New System.Drawing.Point(269, 10)
        Me.LIusu.Name = "LIusu"
        Me.LIusu.Size = New System.Drawing.Size(100, 16)
        Me.LIusu.TabIndex = 4
        Me.LIusu.Text = "Ingrese usuario"
        Me.LIusu.Visible = False
        '
        'TContra
        '
        Me.TContra.Location = New System.Drawing.Point(43, 91)
        Me.TContra.Name = "TContra"
        Me.TContra.Size = New System.Drawing.Size(326, 20)
        Me.TContra.TabIndex = 3
        Me.TContra.UseSystemPasswordChar = True
        '
        'Tusuario
        '
        Me.Tusuario.Location = New System.Drawing.Point(43, 30)
        Me.Tusuario.Name = "Tusuario"
        Me.Tusuario.Size = New System.Drawing.Size(326, 20)
        Me.Tusuario.TabIndex = 2
        '
        'LContra
        '
        Me.LContra.AutoSize = True
        Me.LContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContra.ForeColor = System.Drawing.Color.White
        Me.LContra.Location = New System.Drawing.Point(39, 68)
        Me.LContra.Name = "LContra"
        Me.LContra.Size = New System.Drawing.Size(102, 20)
        Me.LContra.TabIndex = 1
        Me.LContra.Text = "Contraseña"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.ForeColor = System.Drawing.Color.White
        Me.LUsuario.Location = New System.Drawing.Point(39, 7)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(71, 20)
        Me.LUsuario.TabIndex = 0
        Me.LUsuario.Text = "Usuario"
        '
        'PBarra
        '
        Me.PBarra.Location = New System.Drawing.Point(178, 385)
        Me.PBarra.Name = "PBarra"
        Me.PBarra.Size = New System.Drawing.Size(200, 23)
        Me.PBarra.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PBarra.TabIndex = 1
        Me.PBarra.Visible = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(201, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'PBarra2
        '
        Me.PBarra2.Location = New System.Drawing.Point(178, 385)
        Me.PBarra2.Name = "PBarra2"
        Me.PBarra2.Size = New System.Drawing.Size(200, 23)
        Me.PBarra2.TabIndex = 3
        Me.PBarra2.Visible = False
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Login.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(548, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.PBarra2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBarra)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TContra As System.Windows.Forms.TextBox
    Friend WithEvents Tusuario As System.Windows.Forms.TextBox
    Friend WithEvents LContra As System.Windows.Forms.Label
    Friend WithEvents LUsuario As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LIcontra As System.Windows.Forms.Label
    Friend WithEvents LIusu As System.Windows.Forms.Label
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents PBarra As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBarra2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
