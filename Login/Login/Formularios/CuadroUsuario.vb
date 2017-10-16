﻿Public Class CuadroUsuario
    Dim Var1 As Array
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim usu As New Ususario
        Dim dni As Integer
        Dim nom As String
        Dim ape As String
        Dim tipo As Char
        Dim esta As Char
        dni = Val(TDni.Text)
        nom = TNombre.Text
        ape = TApel.Text
        tipo = usuario()
        esta = estados()
        DataGridView1.RowTemplate.Height = 50
        'usu.muestra(DataGridView1, Val(TDni.Text), TNombre.Text, usuario())
        'Si está enlazado a un origen de datos, y la propiedad AutoGenerateColumns tiene su valor por defecto (True), 
        'la manera más sencilla de limpiar el control DataGridView es estableciendo el valor Nothing a su propiedad DataSource:
        'DataGridView1.DataSource = Nothing
        If tipo = "*" Then
            DataGridView1.Rows.Clear()
            Try
                Using Base As New NNeumaticosEntities1
                    Dim mues = (From u In Base.Usuario Select u).ToList
                    'Dni = u.usu_Dni, NombreyApellido = u.usu_nomYape, Direccion = u.usu_Direccon, Localidad = u.usu_Localidad, Telefono = u.usu_Telefono, Email = u.usu_Email, Contraseña = u.usu_Contraseña, Estado = u.usu_Estado, TipoUsuario = u.usu_TipoUsu).ToList
                    'tabla.DataSource = mues
                    For Each u In mues
                        DataGridView1.Rows.Add(u.usu_Dni, u.usu_nomYape & " " & u.usu_ape, u.usu_Direccon, u.usu_Localidad, u.usu_Telefono, u.usu_Email, u.usu_Contraseña, u.usu_Estado, u.usu_TipoUsu, ColVer)
                    Next
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al Cargar los Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            '--limpiar su filas llamando al método Clear de la propiedad Rows:--
            'DataGridView1.Rows.Clear()
        Else
            DataGridView1.Rows.Clear()
            Try
                Using Base As New NNeumaticosEntities1
                    Dim mues = (From u In Base.Usuario Where (u.usu_Dni = dni Or u.usu_nomYape = nom Or u.usu_ape = ape Or u.usu_TipoUsu = tipo Or u.usu_Estado = esta) Select u).ToList
                    'Dni = u.usu_Dni, NombreyApellido = u.usu_nomYape, Direccion = u.usu_Direccon, Localidad = u.usu_Localidad, Telefono = u.usu_Telefono, Email = u.usu_Email, Contraseña = u.usu_Contraseña, Estado = u.usu_Estado, TipoUsuario = u.usu_TipoUsu).ToList
                    'tabla.DataSource = mues
                    For Each u In mues
                        DataGridView1.Rows.Add(u.usu_Dni, u.usu_nomYape & " " & u.usu_ape, u.usu_Direccon, u.usu_Localidad, u.usu_Telefono, u.usu_Email, u.usu_Contraseña, u.usu_Estado, u.usu_TipoUsu, ColVer)
                    Next
                End Using
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub TDni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TDni.KeyDown
        If e.KeyCode = 13 Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub TNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TNombre.KeyDown
        If e.KeyCode = 13 Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub CBUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBUsuario.KeyDown
        If e.KeyCode = 13 Then
            Call Button1_Click(sender, e)
        End If
    End Sub

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
                        'Var1 = DataGridView1.Rows(e.RowIndex).Cells(10).Value
                        Ldni.Text = (DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value).ToString
                        Lnom.Text = (DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value).ToString
                        Ldirec.Text = (DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value).ToString
                        Llocal.Text = (DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value).ToString
                        Ltelef.Text = (DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value).ToString
                        Lemail.Text = (DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value).ToString
                        Lcontra.Text = (DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value).ToString
                        If ((DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value).ToString) = "a" Then
                            Lesta.Text = "ALTA"
                        Else
                            Lesta.Text = "BAJA"
                        End If
                        If ((DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value).ToString) = "a" Then
                            Lusu.Text = "ADMINISTRADOR"
                        ElseIf ((DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value).ToString) = "s" Then
                            Lusu.Text = "SUPERVISOR"
                        Else
                            Lusu.Text = "VENDEDOR"
                        End If
                        'Label10.Text = (DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value).ToString
                        PanelVer.Visible = True
                        'DataGridView1.Rows.RemoveAt(e.RowIndex)
                        'MsgBox("Cliente Eliminado", 0 + 0 + 16, "Eliminado")
                        'End If
                        Exit Select
                End Select
            End If
        End If
    End Sub

    Private Sub BuscaModifica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelVer.Visible = False
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        PanelBusca.Visible = True
        PanelVer.Visible = False
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
        If Lesta.Text <> "BAJA" Then
            res = MsgBox("Desea dar de Baja al Usuario " + Lnom.Text + " ?", 4 + 256 + 32, "Baja")
            If res = vbYes Then
                usu.EliminaUsuario(Val(Ldni.Text), esta)
                MsgBox("El Usuario " + Lnom.Text + "se ha dado de Baja", 0 + 0 + 16, "BAJA")
                PanelBusca.Visible = True
                DataGridView1.Rows.Clear()
                PanelVer.Visible = False
            End If
        Else
            MsgBox("El Usuario ya esta de BAJA", 0 + 0 + 64, "Info")
        End If
    End Sub

    Private Sub BAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAlta.Click
        Dim res As MsgBoxResult
        Dim esta As Char
        esta = "a"
        Dim usu As New Ususario
        If Lesta.Text <> "ALTA" Then
            res = MsgBox("Desea dar de Alta al Usuario " + Lnom.Text + " ?", 4 + 256 + 32, "Alta")
            If res = vbYes Then
                usu.EliminaUsuario(Val(Ldni.Text), esta)
                MsgBox("El Usuario " + Lnom.Text + "se ha dado de Alta", 0 + 0 + 48, "ALTA")
                PanelBusca.Visible = True
                DataGridView1.Rows.Clear()
                PanelVer.Visible = False
            End If
        Else
            MsgBox("El Usuario ya esta de ALTA", 0 + 0 + 64, "Info")
        End If
    End Sub

    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        If Not ComprobarVacioNuevoUsuario() Then
            Dim usus As New Ususario(Val(TDni1.Text), TNomApe.Text, TDire.Text, TLocal.Text, TProv1.Text, TTelef.Text, TEmail.Text, TContra.Text, esta(), usua(), DateTime.Value.Date(), TApellido.Text)
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
End Class