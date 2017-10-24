Public Class CuadroCliente

    Dim uno As String
    Dim dos As String
    Dim tres As String
    Dim cua As String
    Dim cin As String
    Dim sei As String
    Dim siete As String


#Region "Funciones y Procedimientos"

    Public Sub noMuestra()
        Me.DataGridCliente.Columns(13).Visible = False
        Me.DataGridCliente.Columns(11).Visible = False
        Me.DataGridCliente.Columns(10).Visible = False
        Me.DataGridCliente.Columns(9).Visible = False
        Me.DataGridCliente.Columns(8).Visible = False
        'Me.DataGridCliente.Columns(7).Visible = False//este noo
        Me.DataGridCliente.Columns(5).Visible = False
    End Sub


    Private Function estado()
        Dim var As Char
        If CBEstado.SelectedItem = "Activo" Then
            var = "a"

        Else
            var = "b"

        End If
        Return var
    End Function


    Public Function estados() As Char
        If CBEstaCli.SelectedItem = "Alta" Then
            Return "a"
        ElseIf CBEstaCli.SelectedItem = "Baja" Then
            Return "b"
        Else
            Return ""
        End If
    End Function


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




#End Region


    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        If Not ComprobarVacioNuevoClientes() Then 'And Not CompruebaCamposCompletos() 
            Dim cli As New Cliente(Val(TDni.Text), TNomApe.Text, TDire.Text, TTelef.Text, TEmail.Text, estado(), TApellido.Text, TLocal.Text, CBProvincia.SelectedItem, DateTime.Value.Date(), TPostal.Text, TCelular.Text)
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
        End If
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cliente As New Cliente
        cliente.mostrarApe(TApellido2.Text, DataGridCliente)
        Dim dni As Long
        Dim nom As String
        Dim apel As String
        Dim esta As Char
        dni = Val(TDniCli.Text)
        nom = TNombreCli.Text
        apel = TApellido2.Text
        esta = estados()
        DataGridCliente.RowTemplate.Height = 50
        'usu.muestra(DataGridView1, Val(TDni.Text), TNombre.Text, usuario())

        'Si está enlazado a un origen de datos, y la propiedad AutoGenerateColumns tiene su valor por defecto (True), 
        'la manera más sencilla de limpiar el control DataGridView es estableciendo el valor Nothing a su propiedad DataSource:

        'DataGridView1.DataSource = Nothing



        '--limpiar su filas llamando al método Clear de la propiedad Rows:--
        'DataGridView1.Rows.Clear()


        'DataGridCliente.Rows.Clear()
        Try
            Using Base As New NNeumaticosEntities1

                Dim mues = (From c In Base.Cliente Where (c.cliente_cuil = dni Or c.cliente_NomYape = nom Or c.cliente_Ape = apel Or c.cliente_estado = esta) Select c).ToList
                'Dim mues = (From c In Base.Cliente Select c).ToList

                'Dni = u.usu_Dni, NombreyApellido = u.usu_nomYape, Direccion = u.usu_Direccon, Localidad = u.usu_Localidad, Telefono = u.usu_Telefono, Email = u.usu_Email, Contraseña = u.usu_Contraseña, Estado = u.usu_Estado, TipoUsuario = u.usu_TipoUsu).ToList

                'tabla.DataSource = mues
                For Each c In mues
                    DataGridCliente.Rows.Add(c.cliente_cuil, c.cliente_NomYape & " " & c.cliente_Ape, c.cliente_Direccion, c.cliente_Telefono, c.cliente_Email, c.cliente_estado, c.cliente_Ape, c.cliente_Localidad, c.cliente_Provincia, c.cliente_Fecha, c.cliente_Cpostal, c.cliente_Celular)
                Next

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub BSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir2.Click
        Me.Close()
    End Sub

    Private Sub DataGridCliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridCliente.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DataGridCliente.CurrentCell, DataGridViewButtonCell)

        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DataGridCliente.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "ColVer"
                        'Eliminar Poner el nombre de la columna donde se desa dar un evento()
                        'aquí dentro poner las acciones cuando se precione el botón eliminar()
                        'DataGrid.Item(DataGrid.CurrentCell, DataGrid.CurrentRow.Index).Value()
                        'res = MsgBox("Desea ver el cliente ", 4 + 256 + 16, "ver")
                        'If res = 6 Then
                        PanelBusca.Visible = False
                        'Var1 = DataGridView1.Rows(e.RowIndex).Cells(10).Value
                        TB1.Text = (DataGridCliente.Item(1, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB2.Text = (DataGridCliente.Item(2, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB6.Text = (DataGridCliente.Item(3, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB4.Text = (DataGridCliente.Item(4, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB10.Text = (DataGridCliente.Item(5, DataGridCliente.CurrentRow.Index).Value).ToString
                        'Lcontra.Text = (DataGridCliente.Item(6, DataGridCliente.CurrentRow.Index).Value).ToString
                        If ((DataGridCliente.Item(6, DataGridCliente.CurrentRow.Index).Value).ToString) = "A" Then
                            TB11.Text = "ALTA"
                        Else
                            TB11.Text = "BAJA"
                        End If
                        TB3.Text = (DataGridCliente.Item(7, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB8.Text = (DataGridCliente.Item(8, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB7.Text = (DataGridCliente.Item(9, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB12.Text = (DataGridCliente.Item(10, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB9.Text = (DataGridCliente.Item(11, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB5.Text = (DataGridCliente.Item(12, DataGridCliente.CurrentRow.Index).Value).ToString

                        'inactivos
                        TB1.Enabled = False
                        TB2.Enabled = False
                        TB3.Enabled = False
                        TB4.Enabled = False
                        TB5.Enabled = False
                        TB6.Enabled = False
                        TB7.Enabled = False
                        TB8.Enabled = False
                        TB9.Enabled = False
                        TB10.Enabled = False
                        TB11.Enabled = False
                        TB12.Enabled = False

                        PanelVer.Visible = True
                        BAcepta.Visible = False
                        BCancela.Visible = False



                        'DataGridView1.Rows.RemoveAt(e.RowIndex)
                        'MsgBox("Cliente Eliminado", 0 + 0 + 16, "Eliminado")

                        'End If
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


    Private Sub CBEstaCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBEstaCli.KeyDown
        If e.KeyCode = 13 Then
            Call Button2_Click(sender, e)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CuadroCliente_Load(sender, e)

        PanelBusca.Visible = True
        PanelVer.Visible = False

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PanelBusca.Visible = True
        'PanelModifica.Visible = False
    End Sub

    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'TextBox1.Clear()
    'TextBox2.Clear()
    'TextBox3.Clear()
    'TextBox4.Clear()
    'TextBox5.Clear()
    'TextBox6.Clear()
    'TextBox7.Clear()
    'TextBox8.Clear()
    'TextBox9.Clear()
    'ComboBox1.Items.Clear()
    'ComboBox2.Items.Clear()
    'End Sub


    Private Sub TApellido2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TApellido2.TextChanged
        'DataGridCliente.Rows.Clear()
        DataGridCliente.RowTemplate.Height = 50

        If TApellido2.Text <> "" Then
            TNombreCli.Enabled = False
            TDniCli.Enabled = False
            CBEstaCli.Enabled = False

            Dim cliente As New Cliente
            cliente.mostrarApe(TApellido2.Text, DataGridCliente)

            Me.DataGridCliente.Columns(1).Name = "Cuil / Dni"
            Me.DataGridCliente.Columns(2).Name = "Nombre"
            Me.DataGridCliente.Columns(3).Name = "Direccion"
            Me.DataGridCliente.Columns(4).Name = "Telefono-Fijo"
            Me.DataGridCliente.Columns(5).Name = "Estado"


            noMuestra()
        Else
            Call CuadroCliente_Load(sender, e)
            TNombreCli.Enabled = True
            TDniCli.Enabled = True
            CBEstaCli.Enabled = True

        End If
    End Sub


    Private Sub CuadroCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cli As New Cliente
        DataGridCliente.RowTemplate.Height = 50
        cli.mostrarTdo(DataGridCliente)
        noMuestra()

    End Sub



    Private Sub TDniCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDniCli.TextChanged
        DataGridCliente.RowTemplate.Height = 50

        If TDniCli.Text <> "" Then
            TNombreCli.Enabled = False
            TApellido2.Enabled = False
            CBEstaCli.Enabled = False

            Dim cliente As New Cliente
            cliente.mostrarDni(TDniCli.Text, DataGridCliente)

            noMuestra()

        Else
            Call CuadroCliente_Load(sender, e)
            TNombreCli.Enabled = True
            TApellido2.Enabled = True
            CBEstaCli.Enabled = True

        End If
    End Sub

    Private Sub TNombreCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TNombreCli.TextChanged
        DataGridCliente.RowTemplate.Height = 50

        If TNombreCli.Text <> "" Then
            TApellido2.Enabled = False
            TDniCli.Enabled = False
            CBEstaCli.Enabled = False

            Dim cliente As New Cliente
            cliente.mostrarNom(TNombreCli.Text, DataGridCliente)

            Me.DataGridCliente.Columns(1).Name = "Cuil / Dni"
            Me.DataGridCliente.Columns(2).Name = "Nombre"
            Me.DataGridCliente.Columns(3).Name = "Direccion"
            Me.DataGridCliente.Columns(4).Name = "Telefono-Fijo"
            Me.DataGridCliente.Columns(5).Name = "Estado"

            noMuestra()

        Else
            Call CuadroCliente_Load(sender, e)
            TApellido2.Enabled = True
            TDniCli.Enabled = True
            CBEstaCli.Enabled = True

        End If
    End Sub

    Private Sub CBEstaCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEstaCli.SelectedIndexChanged
        Dim cli As New Cliente
        If CBEstaCli.SelectedItem = "Alta" Then
            cli.mostrarEstado("a", DataGridCliente)

            TApellido2.Enabled = False
            TDniCli.Enabled = False
            TNombreCli.Enabled = False

            noMuestra()

        ElseIf CBEstaCli.SelectedItem = "Baja" Then
            cli.mostrarEstado("b", DataGridCliente)

            TApellido2.Enabled = False
            TDniCli.Enabled = False
            TNombreCli.Enabled = False

            noMuestra()

        Else
            Call CuadroCliente_Load(sender, e)
            TApellido2.Enabled = True
            TDniCli.Enabled = True
            TNombreCli.Enabled = True
        End If
    End Sub


#Region "Botones Acepta y Cancela Modificacion"

    Private Sub BCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancela.Click
        'Call DataGridCliente_CellContentClick(sender, e)

        TB4.Text = uno
        TB5.Text = dos
        TB6.Text = tres
        TB7.Text = cua
        TB8.Text = cin
        TB9.Text = sei
        TB10.Text = siete

        BCancela.Visible = False
        BAcepta.Visible = False

        BAlta.Visible = True
        BBaja.Visible = True
        BModifica.Visible = True

        TB1.Enabled = False
        TB2.Enabled = False
        TB3.Enabled = False
        TB4.Enabled = False
        TB5.Enabled = False
        TB6.Enabled = False
        TB7.Enabled = False
        TB8.Enabled = False
        TB9.Enabled = False
        TB10.Enabled = False
        TB11.Enabled = False
        TB12.Enabled = False
    End Sub

    Private Sub BAcepta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAcepta.Click
        Dim cli As New Cliente
        Dim res As MsgBoxResult
        res = MsgBox("Desea Guardar los Cambios?", 4 + 256 + 32, "Modificar")
        If res = vbYes Then
            'cli.ModifCliente(TB1.Text, TB4.Text, TB5.Text, TB6.Text, TB7.Text, TB8.Text, TB9.Text, TB10.Text)
            cli.ModifCliente(TB1.Text, TB2.Text, TB6.Text, TB4.Text, TB10.Text, TB11.Text, TB3.Text, TB8.Text, TB7.Text, TB12.Text, TB9.Text, TB5.Text)
            MsgBox("Los datos se han Modificado", 0 + 0 + 64, "info")
            TB1.Enabled = False
            TB2.Enabled = False
            TB3.Enabled = False
            TB4.Enabled = False
            TB5.Enabled = False
            TB6.Enabled = False
            TB7.Enabled = False
            TB8.Enabled = False
            TB9.Enabled = False
            TB10.Enabled = False
            TB11.Enabled = False
            TB12.Enabled = False


            BCancela.Visible = False
            BAcepta.Visible = False

            BAlta.Visible = True
            BBaja.Visible = True
            BModifica.Visible = True

        End If

    End Sub

#End Region



#Region "Botones Modifica, Baja y Alta"

    Private Sub BModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BModifica.Click
        uno = TB4.Text
        dos = TB5.Text
        tres = TB6.Text
        cua = TB7.Text
        cin = TB8.Text
        sei = TB9.Text
        siete = TB10.Text
        'TB1.Enabled = True
        'TB2.Enabled = True
        'TB3.Enabled = True
        TB4.Enabled = True
        TB5.Enabled = True
        TB6.Enabled = True
        TB7.Enabled = True
        TB8.Enabled = True
        TB9.Enabled = True
        TB10.Enabled = True
        'TB11.Enabled = True
        'TB12.Enabled = True



        BAlta.Visible = False
        BBaja.Visible = False
        BModifica.Visible = False

        BAcepta.Visible = True
        BCancela.Visible = True
    End Sub



    Private Sub BBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBaja.Click
        Dim cli As New Cliente
        Dim res As MsgBoxResult

        If TB11.Text <> "BAJA" Then
            res = MsgBox("Desea dar de baja al Cliente?", 4 + 256 + 48, "Baja-Cliente")

            If res = vbYes Then
                cli.BajaCliente(TB1.Text)
                TB11.Text = "BAJA"

                MsgBox("El Cliente fue dado de Baja", 0 + 0 + 64, "Baja")

            End If

        Else
            MsgBox("El cliente ya dado de Baja", 0 + 0 + 64, "info")

        End If

    End Sub

    Private Sub BAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAlta.Click
        Dim cli As New Cliente
        Dim res As MsgBoxResult
        If TB11.Text <> "ALTA" Then
            res = MsgBox("Desea dar de Alta al Cliente?", 4 + 256 + 48, "Alta-Cliente")
            If res = vbYes Then
                cli.AltaCliente(TB1.Text)
                TB11.Text = "ALTA"
                MsgBox("El Cliente fue dado de Baja", 0 + 0 + 64, "Aaja")
            End If
        Else
            MsgBox("El cliente ya esta dado de Alta", 0 + 0 + 64, "info")
        End If
    End Sub

#End Region


#Region "Comprobacion"


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


    Public Function CompruebaCamposCompletos() As Boolean

        If TDni.Text <> "" Then
            TDni.BackColor = Color.LightGreen
            Return True

        ElseIf TApellido.Text <> "" Then
            TApellido.BackColor = Color.LightGreen
            Return True

        ElseIf TNomApe.Text <> "" Then
            TNomApe.BackColor = Color.LightGreen
            Return True

        ElseIf TTelef.Text <> "" Then
            TTelef.BackColor = Color.LightGreen
            Return True

        ElseIf TDire.Text <> "" Then
            TDire.BackColor = Color.LightGreen
            Return True

        ElseIf TLocal.Text <> "" Then
            TLocal.BackColor = Color.LightGreen
            Return True

        ElseIf TPostal.Text <> "" Then
            TPostal.BackColor = Color.LightGreen
            Return True

        ElseIf TEmail.Text <> "" Then
            TEmail.BackColor = Color.LightGreen
            Return True

        Else
            Return False

        End If

    End Function





    'COMPROBACIOES DE LOS CAMPOS'
    'Private Sub TDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDni.KeyPress
    'Me.ComprobarNumero(e)
    'End Sub

    'Private Sub TNomApe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNomApe.KeyPress
    'Me.ComprobarLetra(e)
    'End Sub

    'Private Sub TApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido.KeyPress
    'Me.ComprobarLetra(e)
    'End Sub


    'Comprobacion de lo que se ingresa si es numero en los campos "TELEFONO, CP, DNI,CELULAR" en nuevo CLiente'
    Private Sub TDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TTelef.KeyPress, TPostal.KeyPress, TDni.KeyPress, TCelular.KeyPress
        Me.ComprobarNumero(e)
    End Sub

    'Comprobacion de lo que se ingresa si es letra en los campos "NOMBRE, LOCALIDAD Y APELLIDO" en nuevo CLiente'
    'Private Sub TApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNomApe.KeyPress, TLocal.KeyPress, TApellido.KeyPress
    'Me.ComprobarLetra(e)
    'End Sub


    'Comprobacion de lo que se ingresa si es numero en los campos "TELEFONO, CP, DNI,CELULAR" en modificar CLiente'
    'Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox7.KeyPress, TextBox5.KeyPress, TextBox3.KeyPress
    'Me.ComprobarNumero(e)
    'End Sub
    'Comprobacion de lo que se ingresa si es letra en los campos "NOMBRE, LOCALIDAD Y APELLIDO" en modificar CLiente'
    'Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress, TextBox6.KeyPress, TextBox2.KeyPress
    'Me.ComprobarLetra(e)
    'End Sub


#End Region

End Class