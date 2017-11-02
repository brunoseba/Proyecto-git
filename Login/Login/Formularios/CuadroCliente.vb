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
        Me.DataGridCliente.Columns(12).Visible = False
        Me.DataGridCliente.Columns(11).Visible = False
        Me.DataGridCliente.Columns(10).Visible = False
        Me.DataGridCliente.Columns(9).Visible = False
        Me.DataGridCliente.Columns(8).Visible = False
        Me.DataGridCliente.Columns(5).Visible = False
    End Sub


    Private Function estado()
        Dim var As Char
        If CBEstado.SelectedItem = "Activo" Then
            var = "A"
        Else
            var = "B"
        End If
        Return var
    End Function


    Public Function estados() As Char
        If CBEstaCli.SelectedItem = "Alta" Then
            Return "A"
        ElseIf CBEstaCli.SelectedItem = "Baja" Then
            Return "B"
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
                        TB6.Text = (DataGridCliente.Item(4, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB4.Text = (DataGridCliente.Item(5, DataGridCliente.CurrentRow.Index).Value).ToString
                        TB10.Text = (DataGridCliente.Item(6, DataGridCliente.CurrentRow.Index).Value).ToString
                        If ((DataGridCliente.Item(7, DataGridCliente.CurrentRow.Index).Value).ToString) = "A" Then
                            TB11.Text = "ALTA"
                            BBaja.Visible = True
                            BAlta.Visible = False
                        Else
                            TB11.Text = "BAJA"
                            BAlta.Visible = True
                            BBaja.Visible = False
                        End If
                        TB3.Text = (DataGridCliente.Item(3, DataGridCliente.CurrentRow.Index).Value).ToString
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CuadroCliente_Load(sender, e)
        resaltarClienteBaja(Me.DataGridCliente)
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
        DataGridCliente.RowTemplate.Height = 50
        If TApellido2.Text <> "" Then
            TNombreCli.Enabled = False
            TDniCli.Enabled = False
            CBEstaCli.Enabled = False
            Dim cliente As New Cliente
            cliente.mostrarApe(TApellido2.Text, DataGridCliente)
            resaltarClienteBaja(Me.DataGridCliente)
            noMuestra()
        Else
            Call CuadroCliente_Load(sender, e)
            TNombreCli.Enabled = True
            TDniCli.Enabled = True
            CBEstaCli.Enabled = True
            resaltarClienteBaja(Me.DataGridCliente)
        End If
    End Sub


    Private Sub CuadroCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cli As New Cliente
        DataGridCliente.RowTemplate.Height = 50
        CBEstado.SelectedIndex = 0
        CBProvincia.SelectedIndex = 0
        cli.mostrarTdo(DataGridCliente)
        'resaltarClienteBaja(Me.DataGridCliente)
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
            resaltarClienteBaja(Me.DataGridCliente)
            noMuestra()
        Else
            Call CuadroCliente_Load(sender, e)
            TNombreCli.Enabled = True
            TApellido2.Enabled = True
            CBEstaCli.Enabled = True
            resaltarClienteBaja(Me.DataGridCliente)
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
            Me.resaltarClienteBaja(Me.DataGridCliente)
            noMuestra()
        Else
            Call CuadroCliente_Load(sender, e)
            TApellido2.Enabled = True
            TDniCli.Enabled = True
            CBEstaCli.Enabled = True
            resaltarClienteBaja(Me.DataGridCliente)

        End If
    End Sub

    Private Sub CBEstaCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBEstaCli.SelectedIndexChanged
        Dim cli As New Cliente
        If CBEstaCli.SelectedItem = "Alta" Then
            cli.mostrarEstado("a", DataGridCliente)
            resaltarClienteBaja(Me.DataGridCliente)
            TApellido2.Enabled = False
            TDniCli.Enabled = False
            TNombreCli.Enabled = False
            noMuestra()
        ElseIf CBEstaCli.SelectedItem = "Baja" Then
            cli.mostrarEstado("b", DataGridCliente)
            resaltarClienteBaja(Me.DataGridCliente)
            TApellido2.Enabled = False
            TDniCli.Enabled = False
            TNombreCli.Enabled = False
            noMuestra()
        Else
            Call CuadroCliente_Load(sender, e)
            TApellido2.Enabled = True
            TDniCli.Enabled = True
            TNombreCli.Enabled = True
            resaltarClienteBaja(Me.DataGridCliente)
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
        If Not ComprobarVacioModificarClientes() Then
            res = MsgBox("Desea Guardar los Cambios?", 4 + 256 + 32, "Modificar")
            If res = vbYes Then
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
                If TB11.Text = "ALTA" Then
                    BBaja.Visible = True
                    BAlta.Visible = False
                Else
                    BBaja.Visible = False
                    BAlta.Visible = True
                End If
                TB11.Enabled = False
                TB12.Enabled = False
                BCancela.Visible = False
                BAcepta.Visible = False
                BModifica.Visible = True
            End If
        Else

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
                Me.Close()
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
                MsgBox("El Cliente fue dado deAlta", 0 + 0 + 64, "Alta")
                Me.Close()
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

    Private Function ComprobarVacioModificarClientes() As Boolean
        If String.IsNullOrWhiteSpace(TB5.Text) Then
            MsgBox("Debe completar el campo Celular")
            TB5.BackColor = Color.Salmon
            TB5.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TB6.Text) Then
            MsgBox("Debe completar el campo Dirección")
            TB6.BackColor = Color.Salmon
            TB6.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TB4.Text) Then
            MsgBox("Debe completar el campo Teléfono")
            TB4.BackColor = Color.Salmon
            TB4.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TB7.Text) Then
            MsgBox("Debe completar el campo Provincia")
            TB7.BackColor = Color.Salmon
            TB7.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TB8.Text) Then
            MsgBox("Debe completar el campo Localidad")
            TB8.BackColor = Color.Salmon
            TB8.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TB9.Text) Then
            MsgBox("Debe completar el campo CP")
            TB9.BackColor = Color.Salmon
            TB9.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TB10.Text) Then
            MsgBox("Debe completar el campo E-mail")
            TB10.BackColor = Color.Salmon
            TB10.Focus()
            Return True
        Else
            Return False
        End If
    End Function
#End Region

    Private Sub TNombreCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNombreCli.KeyPress, TApellido2.KeyPress
        ComprobarLetra(e)
    End Sub

    Private Sub TDniCli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDniCli.KeyPress
        ComprobarNumero(e)
    End Sub

    Public Sub resaltarClienteBaja(ByVal data As DataGridView)
        For Each fila As DataGridViewRow In data.Rows
            If fila.Cells("Estado").Value = "B" Then
                fila.Cells("Estado").Style.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub TB2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB8.KeyPress, TB7.KeyPress, TB3.KeyPress, TB2.KeyPress
        ComprobarLetra(e)
    End Sub

    Private Sub TB1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB9.KeyPress, TB5.KeyPress, TB4.KeyPress, TB1.KeyPress
        ComprobarNumero(e)
    End Sub

    Private Sub TB5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB9.TextChanged, TB8.TextChanged, TB7.TextChanged, TB6.TextChanged, TB5.TextChanged, TB4.TextChanged, TB10.TextChanged
        If TB5.Text = "" Then
            Me.TB5.BackColor = Color.White
        Else
            Me.TB5.BackColor = Color.Aquamarine
        End If

        If TB6.Text = "" Then
            Me.TB6.BackColor = Color.White
        Else
            Me.TB6.BackColor = Color.Aquamarine
        End If

        If TB4.Text = "" Then
            Me.TB4.BackColor = Color.White
        Else
            Me.TB4.BackColor = Color.Aquamarine
        End If

        If TB7.Text = "" Then
            Me.TB7.BackColor = Color.White
        Else
            Me.TB7.BackColor = Color.Aquamarine
        End If
        If TB8.Text = "" Then
            Me.TB8.BackColor = Color.White
        Else
            Me.TB8.BackColor = Color.Aquamarine
        End If
        If TB9.Text = "" Then
            Me.TB9.BackColor = Color.White
        Else
            Me.TB9.BackColor = Color.Aquamarine
        End If
        If TB10.Text = "" Then
            Me.TB10.BackColor = Color.White
        Else
            Me.TB10.BackColor = Color.Aquamarine
        End If
    End Sub

    Private Sub TDni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDni.TextChanged
        Dim clien As New Cliente()
        Dim nombreApeCliente As String
        nombreApeCliente = ""
        If (TDni.TextLength = 11) Then
            nombreApeCliente = clien.verificarExistencia(TDni.Text, nombreApeCliente)
            If nombreApeCliente <> "False" Then
                MsgBox("El cliente: " + nombreApeCliente + " se encuentra registrado")
            End If
        End If
    End Sub

    Private Sub TApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TNomApe.KeyPress, TLocal.KeyPress, TApellido.KeyPress
        ComprobarLetra(e)
    End Sub
End Class