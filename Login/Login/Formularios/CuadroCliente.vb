Public Class CuadroCliente


    Private Sub CuadroCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CBEstaCli.SelectedIndex = 0
    End Sub

    'Procedimiento guardar Cliente'
    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        If Not ComprobarVacioNuevoClientes() Then
            Dim cli As New Cliente(Val(Me.TDni.Text), Me.TNomApe.Text, Me.TDire.Text, Me.TTelef.Text, Me.TEmail.Text, Me.estado(), Me.TApellido.Text, Me.TLocal.Text, Me.CBProvincia.SelectedItem, Me.DateTime.Value.Date(), Me.TPostal.Text, Me.TCelular.Text)
            Dim res As MsgBoxResult
            TDni.BackColor = Color.LightGreen
            TNomApe.BackColor = Color.LightGreen
            TDire.BackColor = Color.LightGreen
            TTelef.BackColor = Color.LightGreen
            TEmail.BackColor = Color.LightGreen
            TApellido.BackColor = Color.LightGreen
            TLocal.BackColor = Color.LightGreen
            TPostal.BackColor = Color.LightGreen
            TCelular.BackColor = Color.LightGreen
            res = MsgBox("Desea Agregar un nuevo Cliente?", 4 + 0 + 32, "Aviso")
            If res = vbYes Then
                If cli.AgregaCliente() Then
                    MsgBox("Cliente agregado", 0 + 0 + 64)
                    TDni.Text = ""
                    TNomApe.Text = ""
                    TDire.Text = ""
                    TTelef.Text = ""
                    TEmail.Text = ""
                    TApellido.Text = ""
                    TLocal.Text = ""
                    TPostal.Text = ""
                    TCelular.Text = ""
                Else
                    MsgBox("Ocurrio un error!!")
                End If
            End If
        Else

        End If
    End Sub

    'Salir'
    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    'Devuelve el valor del estado'
    Private Function estado()
        Dim var As Char
        If Me.CBEstado.SelectedItem = "Activo" Then
            var = "a"
        Else
            var = "b"
        End If
        Return var
    End Function


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim dni As Long
        Dim nom As String
        Dim apel As String
        Dim esta As Char
        dni = Val(TDniCli.Text)
        nom = TNombreCli.Text
        apel = TApellido2.Text
        esta = estados()
        DataGridCliente.RowTemplate.Height = 50
        
        DataGridCliente.Rows.Clear()
        Try
            Using Base As New NNeumaticosEntities1

                Dim mues = (From c In Base.Cliente Where (c.cliente_cuil = dni Or c.cliente_NomYape = nom Or c.cliente_Ape = apel Or c.cliente_estado = esta) Select c).ToList
                For Each c In mues
                    DataGridCliente.Rows.Add(c.cliente_cuil, c.cliente_NomYape & " " & c.cliente_Ape, c.cliente_Direccion, c.cliente_Telefono, c.cliente_Email, c.cliente_estado, c.cliente_Ape, c.cliente_Localidad, c.cliente_Provincia, c.cliente_Fecha, c.cliente_Cpostal, c.cliente_Celular)
                Next

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function estados() As Char
        If CBEstaCli.SelectedItem = "Alta" Then
            Return "a"
        ElseIf CBEstaCli.SelectedItem = "Baja" Then
            Return "b"
        Else
            Return ""
        End If
    End Function

    Private Sub BSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir2.Click
        Me.Close()
    End Sub

    Private Sub DataGridCliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridCliente.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridCliente.CurrentCell, DataGridViewButtonCell)
        Dim res As MsgBoxResult
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridCliente.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "ColVer"

                        Me.PanelBusca.Visible = False
                        Me.Ldni.Text = (Me.DataGridCliente.Item(0, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.Lnom.Text = (Me.DataGridCliente.Item(1, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.Ldirec.Text = (Me.DataGridCliente.Item(2, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.Ltelef.Text = (Me.DataGridCliente.Item(3, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.Lemail.Text = (Me.DataGridCliente.Item(4, Me.DataGridCliente.CurrentRow.Index).Value).ToString

                        If ((Me.DataGridCliente.Item(5, Me.DataGridCliente.CurrentRow.Index).Value).ToString) = "a" Then
                            Me.Lesta.Text = "ALTA"
                        Else
                            Me.Lesta.Text = "BAJA"
                        End If

                        Me.Lape.Text = (Me.DataGridCliente.Item(6, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.Lloca.Text = (Me.DataGridCliente.Item(7, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.Lprov.Text = (Me.DataGridCliente.Item(8, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.Lfecha.Text = (Me.DataGridCliente.Item(9, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.LPostal.Text = (Me.DataGridCliente.Item(10, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.Lcelu.Text = (Me.DataGridCliente.Item(11, Me.DataGridCliente.CurrentRow.Index).Value).ToString
                        Me.PanelVer.Visible = True
                        Exit Select
                End Select

            End If
        End If
    End Sub

    Private Sub TDniCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TDniCli.KeyDown
        If e.KeyCode = 13 Then
            Call Button2_Click(sender, e)
        End If
    End Sub

    Private Sub TNombreCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TNombreCli.KeyDown
        If e.KeyCode = 13 Then
            Call Button2_Click(sender, e)
        End If
    End Sub

    Private Sub TApellido2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TApellido2.KeyDown
        If e.KeyCode = 13 Then
            Call Button2_Click(sender, e)
        End If
    End Sub

    Private Sub CBEstaCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBEstaCli.KeyDown
        If e.KeyCode = 13 Then
            Call Button2_Click(sender, e)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.PanelBusca.Visible = True
        Me.PanelVer.Visible = False

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PanelBusca.Visible = True
        Me.PanelModifica.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        Me.TextBox3.Clear()
        Me.TextBox4.Clear()
        Me.TextBox5.Clear()
        Me.TextBox6.Clear()
        Me.TextBox7.Clear()
        Me.TextBox8.Clear()
        Me.TextBox9.Clear()
        Me.ComboBox1.Items.Clear()
        Me.ComboBox2.Items.Clear()
    End Sub
    'Procedimiento que verifica que sea número'
    Public Sub ComprobarNumero(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Verifica que sea numero lo que se ingresa'
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "-" Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    'Función comprobar si es letra lo que se presiona'
    Public Sub ComprobarLetra(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Función que verifica que los TextBox no esten vacio en NUEVO CLIENTE'
    Private Function ComprobarVacioNuevoClientes() As Boolean
         If String.IsNullOrWhiteSpace(TDni.Text) Then
            MsgBox("Debe completar el campo DNI")
            TDni.BackColor = Color.Salmon
            TDni.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TApellido.Text) Then
            MsgBox("Debe completar el campo Apellido")
            TApellido.BackColor = Color.Salmon
            TApellido.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TNomApe.Text) Then
            MsgBox("Debe completar el campo Nombre")
            TNomApe.BackColor = Color.Salmon
            TNomApe.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TTelef.Text) Then
            MsgBox("Debe completar el campo Teléfono")
            TTelef.BackColor = Color.Salmon
            TTelef.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TDire.Text) Then
            MsgBox("Debe completar el campo Dirección")
            TDire.BackColor = Color.Salmon
            TDire.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TLocal.Text) Then
            MsgBox("Debe completar el campo Localidad")
            TLocal.BackColor = Color.Salmon
            TLocal.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TPostal.Text) Then
            MsgBox("Debe completar el campo CP")
            TPostal.BackColor = Color.Salmon
            TPostal.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TEmail.Text) Then
            MsgBox("Debe completar el campo E-mail")
            TEmail.BackColor = Color.Salmon
            TEmail.Focus()
            Return True

        Else
            Return False
        End If
    End Function

    'COMPROBACIOES DE LOS CAMPOS'
    Private Sub TDniCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDniCli.KeyPress
        Me.ComprobarNumero(e)
    End Sub

    Private Sub TNombreCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNombreCli.KeyPress
        Me.ComprobarLetra(e)
    End Sub

    Private Sub TApellido2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido2.KeyPress
        Me.ComprobarLetra(e)
    End Sub

    'Comprobacion de lo que se ingresa si es numero en los campos "TELEFONO, CP, DNI,CELULAR" en nuevo CLiente'
    Private Sub TDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TTelef.KeyPress, TPostal.KeyPress, TDni.KeyPress, TCelular.KeyPress
        Me.ComprobarNumero(e)
    End Sub
    'Comprobacion de lo que se ingresa si es letra en los campos "NOMBRE, LOCALIDAD Y APELLIDO" en nuevo CLiente'
    Private Sub TApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNomApe.KeyPress, TLocal.KeyPress, TApellido.KeyPress
        Me.ComprobarLetra(e)
    End Sub
    'Comprobacion de lo que se ingresa si es numero en los campos "TELEFONO, CP, DNI,CELULAR" en modificar CLiente'
    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox7.KeyPress, TextBox5.KeyPress, TextBox3.KeyPress
        Me.ComprobarNumero(e)
    End Sub
    'Comprobacion de lo que se ingresa si es letra en los campos "NOMBRE, LOCALIDAD Y APELLIDO" en modificar CLiente'
    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress, TextBox6.KeyPress, TextBox2.KeyPress
        Me.ComprobarLetra(e)
    End Sub

    Private Sub BAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAlta.Click
        Dim res As MsgBoxResult
        res = MsgBox("Desea dar de alta al Cliente?", 4 + 0 + 32, "Aviso")
        If res = vbYes Then
            If Lesta.Text = "ALTA" Then
                MsgBox("El cliente ya estaba activo")
            Else
                MsgBox("Cliente dado de Alta")
                Lesta.Text = "ALTA"
            End If
        End If
    End Sub

    Private Sub BBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBaja.Click
        Dim res As MsgBoxResult
        res = MsgBox("Desea dar de alta al Cliente?", 4 + 0 + 32, "Aviso")
        If res = vbYes Then
            If Lesta.Text = "BAJA" Then
                MsgBox("El cliente ya estaba inactivo")
            Else
                MsgBox("Cliente dado de Baja")
                Lesta.Text = "BAJA"
            End If
        End If
    End Sub
End Class