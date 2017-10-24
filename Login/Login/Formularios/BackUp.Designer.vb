<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUp
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TRuta = New System.Windows.Forms.TextBox()
        Me.BExamina = New System.Windows.Forms.Button()
        Me.BCancela = New System.Windows.Forms.Button()
        Me.BAcepta = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(17, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ruta :"
        '
        'TRuta
        '
        Me.TRuta.Location = New System.Drawing.Point(74, 98)
        Me.TRuta.Name = "TRuta"
        Me.TRuta.Size = New System.Drawing.Size(244, 20)
        Me.TRuta.TabIndex = 4
        '
        'BExamina
        '
        Me.BExamina.Location = New System.Drawing.Point(324, 94)
        Me.BExamina.Name = "BExamina"
        Me.BExamina.Size = New System.Drawing.Size(75, 23)
        Me.BExamina.TabIndex = 5
        Me.BExamina.Text = "Examinar"
        Me.BExamina.UseVisualStyleBackColor = True
        '
        'BCancela
        '
        Me.BCancela.Location = New System.Drawing.Point(243, 133)
        Me.BCancela.Name = "BCancela"
        Me.BCancela.Size = New System.Drawing.Size(75, 23)
        Me.BCancela.TabIndex = 6
        Me.BCancela.Text = "Cancelar"
        Me.BCancela.UseVisualStyleBackColor = True
        '
        'BAcepta
        '
        Me.BAcepta.Location = New System.Drawing.Point(92, 133)
        Me.BAcepta.Name = "BAcepta"
        Me.BAcepta.Size = New System.Drawing.Size(75, 23)
        Me.BAcepta.TabIndex = 7
        Me.BAcepta.Text = "Aceptar"
        Me.BAcepta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(126, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Generar Backup"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(17, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre del Backup: "
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(189, 61)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(127, 20)
        Me.TNombre.TabIndex = 10
        '
        'BackUp
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(410, 168)
        Me.ControlBox = False
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BAcepta)
        Me.Controls.Add(Me.BCancela)
        Me.Controls.Add(Me.BExamina)
        Me.Controls.Add(Me.TRuta)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BackUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TRuta As System.Windows.Forms.TextBox
    Friend WithEvents BExamina As System.Windows.Forms.Button
    Friend WithEvents BCancela As System.Windows.Forms.Button
    Friend WithEvents BAcepta As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    'Friend WithEvents BackUpCompletoTableAdapter1 As Login.DataSet1TableAdapters.BackUpCompletoTableAdapter
End Class
