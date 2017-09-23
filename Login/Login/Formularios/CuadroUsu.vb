Public Class CuadroUsu

   
    Private Sub BGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGuardar.Click
        Dim cli As New Cliente(Val(TDni.Text), TNomApe.Text, TDire.Text, TTelef.Text, TEmail.Text, estado(), TApellido.Text, TLocal.Text, CBProvincia.SelectedItem, DateTime.Value.Date(), TPostal.Text, TCelular.Text)
        Dim res As MsgBoxResult

        res = MsgBox("Desea Agregar un nuevo usuario?", 4 + 0 + 32, "Aviso")
        If res = vbYes Then

            If cli.AgregaCliente() Then 'Val(TDni.Text), TNomApe.Text, TDire.Text, TLocal.Text, TProv.Text, TTelef.Text, TEmail.Text, TContra.Text, TEstado.Text, TUsu.Text, TFecha.Text)
                MsgBox("Cliente agregado", 0 + 0 + 64)

            Else
                MsgBox("Ocurrio un error!!")
            End If

        End If
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub


    'Private Function Provin()
    'Dim var As Char
    'If CBProvincia.SelectedItem = "Administrador" Then
    'var = "a"

    'ElseIf CBProvincia.SelectedItem = "Supervisor" Then
    'var = "s"

    'Else
    'var = "v"

    'End If
    'Return var
    'End Function


    Private Function estado()
        Dim var As Char
        If CBEstado.SelectedItem = "Activo" Then
            var = "a"

        Else
            var = "b"

        End If
        Return var
    End Function



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dni As Integer
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


        DataGridCliente.Rows.Clear()
        Try
            Using Base As New NNeumaticosEntities1

                Dim mues = (From c In Base.Cliente Where (c.cliente_cuil = dni Or c.cliente_NomYape = nom Or c.cliente_Ape = apel Or c.cliente_estado = esta) Select c).ToList

                'Dni = u.usu_Dni, NombreyApellido = u.usu_nomYape, Direccion = u.usu_Direccon, Localidad = u.usu_Localidad, Telefono = u.usu_Telefono, Email = u.usu_Email, Contraseña = u.usu_Contraseña, Estado = u.usu_Estado, TipoUsuario = u.usu_TipoUsu).ToList

                'tabla.DataSource = mues
                For Each c In mues
                    DataGridCliente.Rows.Add(c.cliente_cuil, c.cliente_NomYape & " " & c.cliente_Ape, c.cliente_Direccion, c.cliente_Telefono, c.cliente_Email, c.cliente_estado, c.cliente_Ape, c.cliente_Localidad, c.cliente_Provincia, c.cliente_Fecha, c.cliente_Cpostal, c.cliente_Celular)
                Next

            End Using
        Catch ex As Exception

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
        Dim cell As DataGridViewButtonCell = TryCast(DataGridCliente.CurrentCell, DataGridViewButtonCell)
        Dim res As MsgBoxResult
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

                        Ldni.Text = (DataGridCliente.Item(0, DataGridCliente.CurrentRow.Index).Value).ToString
                        Lnom.Text = (DataGridCliente.Item(1, DataGridCliente.CurrentRow.Index).Value).ToString
                        Ldirec.Text = (DataGridCliente.Item(2, DataGridCliente.CurrentRow.Index).Value).ToString
                        Ltelef.Text = (DataGridCliente.Item(3, DataGridCliente.CurrentRow.Index).Value).ToString
                        Lemail.Text = (DataGridCliente.Item(4, DataGridCliente.CurrentRow.Index).Value).ToString
                        'Lcontra.Text = (DataGridCliente.Item(6, DataGridCliente.CurrentRow.Index).Value).ToString

                        If ((DataGridCliente.Item(5, DataGridCliente.CurrentRow.Index).Value).ToString) = "a" Then
                            Lesta.Text = "ALTA"
                        Else
                            Lesta.Text = "BAJA"
                        End If

                        Lape.Text = (DataGridCliente.Item(6, DataGridCliente.CurrentRow.Index).Value).ToString
                        Lloca.Text = (DataGridCliente.Item(7, DataGridCliente.CurrentRow.Index).Value).ToString
                        Lprov.Text = (DataGridCliente.Item(8, DataGridCliente.CurrentRow.Index).Value).ToString
                        Lfecha.Text = (DataGridCliente.Item(9, DataGridCliente.CurrentRow.Index).Value).ToString
                        LPostal.Text = (DataGridCliente.Item(10, DataGridCliente.CurrentRow.Index).Value).ToString
                        Lcelu.Text = (DataGridCliente.Item(11, DataGridCliente.CurrentRow.Index).Value).ToString

                        'If ((DataGridCliente.Item(8, DataGridCliente.CurrentRow.Index).Value).ToString) = "a" Then
                        'Lusu.Text = "ADMINISTRADOR"
                        'ElseIf ((DataGridCliente.Item(8, DataGridCliente.CurrentRow.Index).Value).ToString) = "s" Then
                        'Lusu.Text = "SUPERVISOR"
                        'Else
                        'Lusu.Text = "VENDEDOR"
                        'End If

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
        PanelBusca.Visible = True
        PanelVer.Visible = False

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PanelBusca.Visible = True
        PanelModifica.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
    End Sub


End Class