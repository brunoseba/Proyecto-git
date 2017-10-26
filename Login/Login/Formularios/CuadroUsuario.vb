Public Class CuadroUsuario
    Dim Var1 As Array
    Dim tod As New Ususario()
    Public Function usuario() As Char
        If CBUsuario.SelectedItem = "Administrador" Then
            Return "a"
        ElseIf CBUsuario.SelectedItem = "Supervisor" Then
            Return "s"
        ElseIf CBUsuario.SelectedItem = "Vendedor" Then
            Return "v"
        ElseIf CBUsuario.SelectedItem = "Todos" Then
            Return "*"
        End If
        Return ""
    End Function

    Public Function estados() As Char
        If CBEsta.SelectedItem = "Alta" Then
            Return "a"
        ElseIf CBEsta.SelectedItem = "Baja" Then
            Return "b"
        Else
            Return ""
        End If
    End Function

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(DataGridView1.CurrentCell, DataGridViewButtonCell)
        Dim res As MsgBoxResult
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DataGridView1.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
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
                        TextBoxUDni.Text = (DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value).ToString
                        TextBoxUDni.Enabled = False
                        TextBoxUNombre.Text = (DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value).ToString
                        TextBoxUApellido.Text = (DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value).ToString
                        TextBoxUDireccion.Text = (DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value).ToString
                        TextBoxULocalidad.Text = (DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value).ToString
                        TextBoxUProvincia.Text = (DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value).ToString
                        TextBoxUTelefono.Text = (DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value).ToString
                        TextBoxUEmail.Text = (DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value).ToString
                        TextBoxUPass.Text = (DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value).ToString
                        If ((DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value).ToString) = "a" Then
                            TextBoxUestado.Text = "ALTA"
                            TextBoxUestado.Enabled = False
                        Else
                            TextBoxUestado.Text = "BAJA"
                            TextBoxUestado.Enabled = False
                        End If
                        If ((DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value).ToString) = "a" Then
                            ComboBox1.SelectedIndex = 1
                        ElseIf ((DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value).ToString) = "s" Then
                            ComboBox1.SelectedIndex = 2
                        Else
                            ComboBox1.SelectedIndex = 3
                        End If
                        DateTime.Text = (DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value).ToString
                        If TextBoxUestado.Text = "ALTA" Then
                            BBaja.Visible = True
                            BAlta.Visible = False
                        Else
                            BAlta.Visible = True
                            BBaja.Visible = False
                        End If
                        PanelModificarUser.Visible = True
                        Exit Select
                End Select
            End If
        End If
    End Sub

    Private Sub BuscaModifica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PanelModificarUser.Visible = False
        Me.CBEsta.SelectedIndex = 0
        DataGridView1.RowTemplate.Height = 50
        tod.MostrarTodos(Me.DataGridView1)
        mostrarAlSupervisor()

    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        PanelBusca.Visible = True
        PanelModificarUser.Visible = False
        tod.MostrarTodos(DataGridView1)
    End Sub

    Private Sub BSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir2.Click
        Me.Close()
    End Sub

    Private Sub BSalir3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir3.Click
        Me.Close()
    End Sub

    Private Sub BBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBaja.Click
        Dim res As MsgBoxResult
        Dim esta As Char
        esta = "b"
        Dim usu As New Ususario
        res = MsgBox("Desea dar de Baja al Usuario " + TextBoxUNombre.Text + " ?", 4 + 256 + 32, "Baja")
        If res = vbYes Then
            usu.EliminaUsuario(Val(TextBoxUDni.Text), esta)
            MsgBox("El Usuario " + TextBoxUNombre.Text + "se ha dado de Baja", 0 + 0 + 16, "BAJA")
            PanelBusca.Visible = True
            PanelModificarUser.Visible = False
            tod.MostrarTodos(DataGridView1)
            'DataGridView1.Rows.Clear()
        End If

    End Sub

    Private Sub BAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAlta.Click
        Dim res As MsgBoxResult
        Dim esta As Char
        esta = "a"
        Dim usu As New Ususario
        res = MsgBox("Desea dar de Alta al Usuario " + TextBoxUNombre.Text + " ?", 4 + 256 + 32, "Alta")
        If res = vbYes Then
            usu.EliminaUsuario(Val(TextBoxUDni.Text), esta)
            MsgBox("El Usuario " + TextBoxUNombre.Text + "se ha dado de Alta", 0 + 0 + 48, "ALTA")
            PanelBusca.Visible = True
            PanelModificarUser.Visible = False
            tod.MostrarTodos(DataGridView1)
            'DataGridView1.Rows.Clear()
        End If

    End Sub

    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        If Not ComprobarVacioNuevoUsuario() Then
            Dim usus As New Ususario(Val(TDni1.Text), TNomApe.Text, TDire.Text, TLocal.Text, TProv1.Text, TTelef.Text, TEmail.Text, TContra.Text, esta(), usua(), DateTime.Text, TApellido.Text)
            TDni1.BackColor = Color.LightGreen
            TContra.BackColor = Color.LightGreen
            TDire.BackColor = Color.LightGreen
            TNomApe.BackColor = Color.LightGreen
            TTelef.BackColor = Color.LightGreen
            TApellido.BackColor = Color.LightGreen
            TProv1.BackColor = Color.LightGreen
            TLocal.BackColor = Color.LightGreen
            TEmail.BackColor = Color.LightGreen
            Dim res As MsgBoxResult
            res = MsgBox("Desea Agregar un nuevo usuario?", 4 + 0 + 32, "Aviso")
            If res = vbYes Then
                If usus.Verificar_Existencia(Val(TDni1.Text)) Then
                    MsgBox("Este Usuario ya se encuentra Registrado", 0 + 0 + 64)
                Else
                    If usus.AgregarUsuario() Then
                        MsgBox("Cliente agregado", 0 + 0 + 64)
                        Me.limpiarCampos()
                    Else
                        MsgBox("Ocurrio un error, no se pudo agregar el USUARIO")
                    End If
                End If
            End If
        End If
    End Sub

    Private Function usua2()
        Dim var As Char
        If ComboBox1.SelectedItem = "Administrador" Then
            var = "a"
        ElseIf ComboBox1.SelectedItem = "Supervisor" Then
            var = "s"
        Else
            var = "v"
        End If
        Return var
    End Function

    Private Function usua()
        Dim var As Char
        If CBUsu.SelectedItem = "Administrador" Then
            var = "a"
        ElseIf CBUsu.SelectedItem = "Supervisor" Then
            var = "s"
        Else
            var = "v"
        End If
        Return var
    End Function

    Private Function esta()
        Dim var As Char
        If CBEsta1.SelectedItem = "Activo" Then
            var = "a"
        Else
            var = "b"
        End If
        Return var
    End Function

    'Procedimiento que verifica que sea número'
    Public Sub ComprobarNumero(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Verifica que sea numero lo que se ingresa'
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
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

    Private Sub TDni1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TTelef.KeyPress, TDni1.KeyPress
        ComprobarNumero(e)
    End Sub

    Private Sub TNomApe_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TProv1.KeyPress, TNomApe.KeyPress, TLocal.KeyPress, TApellido.KeyPress
        ComprobarLetra(e)
    End Sub

    Private Function ComprobarVacioNuevoUsuario() As Boolean
        If String.IsNullOrWhiteSpace(TDni1.Text) Then
            MsgBox("Debe completar el campo DNI")
            TDni1.BackColor = Color.Salmon
            TDni1.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TContra.Text) Then
            MsgBox("Debe completar el campo Contraseña")
            TContra.BackColor = Color.Salmon
            TContra.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TDire.Text) Then
            MsgBox("Debe completar el campo Domicilio")
            TDire.BackColor = Color.Salmon
            TDire.Focus()
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
        ElseIf String.IsNullOrWhiteSpace(TApellido.Text) Then
            MsgBox("Debe completar el campo Apellido")
            TApellido.BackColor = Color.Salmon
            TApellido.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TProv1.Text) Then
            MsgBox("Debe completar el campo Provincia")
            TProv1.BackColor = Color.Salmon
            TProv1.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TLocal.Text) Then
            MsgBox("Debe completar el campo Localidad")
            TLocal.BackColor = Color.Salmon
            TLocal.Focus()
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

    Private Function ComprobarVacioModificarUsuario() As Boolean
        If String.IsNullOrWhiteSpace(TextBoxUPass.Text) Then
            MsgBox("Debe completar el campo Contraseña")
            TextBoxUPass.BackColor = Color.Salmon
            TextBoxUPass.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxUDireccion.Text) Then
            MsgBox("Debe completar el campo Dirección")
            TextBoxUDireccion.BackColor = Color.Salmon
            TextBoxUDireccion.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxUTelefono.Text) Then
            MsgBox("Debe completar el campo Teléfono")
            TextBoxUTelefono.BackColor = Color.Salmon
            TextBoxUTelefono.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxUProvincia.Text) Then
            MsgBox("Debe completar el campo Provincia")
            TextBoxUProvincia.BackColor = Color.Salmon
            TextBoxUProvincia.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxULocalidad.Text) Then
            MsgBox("Debe completar el campo Localidad")
            TextBoxULocalidad.BackColor = Color.Salmon
            TextBoxULocalidad.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxUEmail.Text) Then
            MsgBox("Debe completar el campo E-mail")
            TextBoxUEmail.BackColor = Color.Salmon
            TextBoxUEmail.Focus()
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub TDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDni.KeyPress
        Me.ComprobarNumero(e)
    End Sub

    Private Sub TNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress, TApel.KeyPress
        Me.ComprobarLetra(e)
    End Sub

    Private Sub limpiarCampos()
        TDni1.Text = ""
        TContra.Text = ""
        TDire.Text = ""
        TNomApe.Text = ""
        TTelef.Text = ""
        TApellido.Text = ""
        TProv1.Text = ""
        TLocal.Text = ""
        TEmail.Text = ""
    End Sub


    Private Sub TextBoxUDni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxUTelefono.KeyPress, TextBoxUDni.KeyPress
        Me.ComprobarNumero(e)
    End Sub


    Private Sub TextBoxUProvincia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxUProvincia.KeyPress, TextBoxUNombre.KeyPress, TextBoxULocalidad.KeyPress, TextBoxUApellido.KeyPress, TextBoxUestado.KeyPress
        Me.ComprobarLetra(e)
    End Sub

    Private Sub BModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BModifica.Click
        If Not ComprobarVacioModificarUsuario() Then
            Dim usuarioModificar As New Ususario()
            If (usuarioModificar.ModificarUsuario(Val(TextBoxUDni.Text), TextBoxUNombre.Text, TextBoxUDireccion.Text, TextBoxULocalidad.Text, TextBoxUProvincia.Text, TextBoxUTelefono.Text, TextBoxUEmail.Text, TextBoxUPass.Text, esta(), usua2(), DateTime.Text, TextBoxUApellido.Text)) Then
                MsgBox("El usuario fue modificado con exito")
                PanelBusca.Visible = True
                PanelModificarUser.Visible = False
                tod.MostrarTodos(DataGridView1)
                Me.TDni.Text = ""
                Me.TNombre.Text = ""
                Me.TApel.Text = ""
                Me.CBUsu.SelectedIndex = 0
                Me.CBEsta.SelectedIndex = 0
            Else
                MsgBox("El usuario no fue modificado.")
            End If
        End If
    End Sub

    Private Sub TDni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDni.TextChanged
        Me.TNombre.Text = ""
        Me.TApel.Text = ""
        Me.CBEsta.SelectedIndex = 0
        Me.CBUsuario.SelectedIndex = 0
        Dim usua As New Ususario
        If Me.TDni.Text = "" Then
            tod.MostrarTodos(Me.DataGridView1)
            mostrarAlSupervisor()
        Else
            usua.BuscarPorDni(TDni.Text, DataGridView1)
            mostrarAlSupervisor()
        End If
    End Sub

    Private Sub TNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TNombre.TextChanged
        Me.TApel.Text = ""
        Me.TDni.Text = ""
        Me.CBEsta.SelectedIndex = 0
        Me.CBUsuario.SelectedIndex = 0
        Dim usua As New Ususario
        If (Me.TNombre.Text = "") Then
            tod.MostrarTodos(Me.DataGridView1)
            mostrarAlSupervisor()
        Else
            usua.BuscarPorNombre(Me.TNombre.Text, Me.DataGridView1)
            mostrarAlSupervisor()
        End If
    End Sub

    Private Sub TApel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TApel.TextChanged
        Me.TNombre.Text = ""
        Me.TDni.Text = ""
        Me.CBEsta.SelectedIndex = 0
        Me.CBUsuario.SelectedIndex = 0
        Dim usua As New Ususario
        If (Me.TApel.Text = "") Then
            tod.MostrarTodos(Me.DataGridView1)
            mostrarAlSupervisor()
        Else
            usua.BuscarPorApellido(Me.TApel.Text, Me.DataGridView1)
            mostrarAlSupervisor()
        End If
    End Sub

    Private Sub CBEsta_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBUsuario.SelectionChangeCommitted, CBEsta.SelectionChangeCommitted
        Dim usua As New Ususario
        Me.TNombre.Text = ""
        Me.TDni.Text = ""
        Me.TApel.Text = ""
        If (Me.CBEsta.SelectedIndex = 0) And (Me.CBUsuario.SelectedIndex = 0) Then
            tod.MostrarTodos(Me.DataGridView1)
            mostrarAlSupervisor()
        ElseIf (Me.CBEsta.SelectedIndex = 0) And (Me.CBUsuario.SelectedIndex > 0) Then
            usua.BuscarPorEstadoTipoUser("a", Me.usuario(), Me.DataGridView1, "b", Me.usuario(), , )
            mostrarAlSupervisor()
        ElseIf (Me.CBEsta.SelectedIndex > 0) And (Me.CBUsuario.SelectedIndex = 0) Then
            usua.BuscarPorEstadoTipoUser(Me.estados(), "a", Me.DataGridView1, Me.estados(), "s", Me.estados(), "v")
            mostrarAlSupervisor()
        Else
            usua.BuscarPorEstadoTipoUser(Me.estados(), Me.usuario(), Me.DataGridView1, , , , )
            mostrarAlSupervisor()
        End If
    End Sub
    Private Sub mostrarAlSupervisor()
        If Ventana.cargo.Text = "supervisor" Then
            For Each fila As DataGridViewRow In DataGridView1.Rows
                DataGridView1.Columns("ColVer").Visible = False
            Next
        End If
    End Sub

    Private Sub TextBoxUDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxUTelefono.TextChanged, TextBoxUProvincia.TextChanged, TextBoxUPass.TextChanged, TextBoxULocalidad.TextChanged, TextBoxUEmail.TextChanged, TextBoxUDireccion.TextChanged
        If String.IsNullOrWhiteSpace(TextBoxUPass.Text) Then
            TextBoxUPass.BackColor = Color.White
        Else
            Me.TextBoxUPass.BackColor = Color.Aquamarine
        End If
        If TextBoxUEmail.Text = "" Then
            Me.TextBoxUEmail.BackColor = Color.White
        Else
            Me.TextBoxUEmail.BackColor = Color.Aquamarine
        End If
        If TextBoxUTelefono.Text = "" Then
            Me.TextBoxUTelefono.BackColor = Color.White
        Else
            Me.TextBoxUTelefono.BackColor = Color.Aquamarine
        End If
        If TextBoxUDireccion.Text = "" Then
            Me.TextBoxUDireccion.BackColor = Color.White
        Else
            Me.TextBoxUDireccion.BackColor = Color.Aquamarine
        End If
        If TextBoxUProvincia.Text = "" Then
            Me.TextBoxUProvincia.BackColor = Color.White
        Else
            Me.TextBoxUProvincia.BackColor = Color.Aquamarine
        End If
        If TextBoxULocalidad.Text = "" Then
            Me.TextBoxULocalidad.BackColor = Color.White
        Else
            Me.TextBoxULocalidad.BackColor = Color.Aquamarine
        End If
    End Sub

    Private Sub TDni1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TTelef.TextChanged, TProv1.TextChanged, TNomApe.TextChanged, TLocal.TextChanged, TEmail.TextChanged, TDni1.TextChanged, TDire.TextChanged, TContra.TextChanged, TApellido.TextChanged
        If String.IsNullOrWhiteSpace(TDni1.Text) Then
            TDni1.BackColor = Color.White
        Else
            TDni1.BackColor = Color.Aquamarine
        End If

        If String.IsNullOrWhiteSpace(TContra.Text) Then
            TContra.BackColor = Color.White
        Else
            TContra.BackColor = Color.Aquamarine
        End If
        If String.IsNullOrWhiteSpace(TDire.Text) Then
            TDire.BackColor = Color.White
        Else
            TDire.BackColor = Color.Aquamarine
        End If

        If String.IsNullOrWhiteSpace(TNomApe.Text) Then
            TNomApe.BackColor = Color.White
        Else
            TNomApe.BackColor = Color.Aquamarine
        End If

        If String.IsNullOrWhiteSpace(TTelef.Text) Then
            TTelef.BackColor = Color.White
        Else
            TTelef.BackColor = Color.Aquamarine
        End If

        If String.IsNullOrWhiteSpace(TApellido.Text) Then
            TApellido.BackColor = Color.White
        Else
            TApellido.BackColor = Color.Aquamarine
        End If

        If String.IsNullOrWhiteSpace(TProv1.Text) Then
            TProv1.BackColor = Color.White
        Else
            TProv1.BackColor = Color.Aquamarine
        End If

        If String.IsNullOrWhiteSpace(TLocal.Text) Then
            TLocal.BackColor = Color.White
        Else
            TLocal.BackColor = Color.Aquamarine
        End If

        If String.IsNullOrWhiteSpace(TEmail.Text) Then
            TEmail.BackColor = Color.White
        Else
            TEmail.BackColor = Color.Aquamarine
        End If
    End Sub

    Private Sub CuadroUsuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyData = Keys.F10) And (BSalir3.Visible) = True Then
            Me.Close()
        End If
    End Sub
End Class