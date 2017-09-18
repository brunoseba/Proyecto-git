﻿Public Class BuscaModifica
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
        Dim tipo As Char
        Dim esta As Char
        dni = Val(TDni.Text)
        nom = TNombre.Text
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
                        DataGridView1.Rows.Add(u.usu_Dni, u.usu_nomYape, u.usu_Direccon, u.usu_Localidad, u.usu_Telefono, u.usu_Email, u.usu_Contraseña, u.usu_Estado, u.usu_TipoUsu, ColVer)
                    Next

                End Using
            Catch ex As Exception

            End Try

            '--limpiar su filas llamando al método Clear de la propiedad Rows:--
            'DataGridView1.Rows.Clear()

        Else
            DataGridView1.Rows.Clear()
            Try
                Using Base As New NNeumaticosEntities1

                    Dim mues = (From u In Base.Usuario Where (u.usu_Dni = dni Or u.usu_nomYape = nom Or u.usu_TipoUsu = tipo Or u.usu_Estado = esta) Select u).ToList

                    'Dni = u.usu_Dni, NombreyApellido = u.usu_nomYape, Direccion = u.usu_Direccon, Localidad = u.usu_Localidad, Telefono = u.usu_Telefono, Email = u.usu_Email, Contraseña = u.usu_Contraseña, Estado = u.usu_Estado, TipoUsuario = u.usu_TipoUsu).ToList

                    'tabla.DataSource = mues
                    For Each u In mues
                        DataGridView1.Rows.Add(u.usu_Dni, u.usu_nomYape, u.usu_Direccon, u.usu_Localidad, u.usu_Telefono, u.usu_Email, u.usu_Contraseña, u.usu_Estado, u.usu_TipoUsu, ColVer)
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



    'Private Sub Ver()

    'End Sub

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

End Class