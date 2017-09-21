Public Class Vendedor

    'Procedimiento cuando carga la ventana Principal'
    Private Sub Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelCarrito.Visible = False
        'PanelClientes.Visible = False
        ComboBoxTipoPago.SelectedIndex = 0
        ComboBoxTipoVehiculo.SelectedIndex = 0
    End Sub


    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        PanelCarrito.Visible = False
        PanelResultadosProductos.Visible = True
        Me.DataGridViewBuscadorProducto.Rows.Add("123", "AT-53", "175X6", "16", "Automovil", 125, "$300")
        Me.DataGridViewBuscadorProducto.Rows.Add("155", "Potenza GII", "175x7", "16", "Automovil", 23, "$500")
        Me.DataGridViewBuscadorProducto.Rows.Add("100", "Toranza", "155x9", "15", "Automovil", 23, "$700")
        Me.DataGridViewBuscadorProducto.Rows.Add("88", "Potenza GII", "175x7", "15", "Automovil", 23, "$600")
    End Sub

    'Private Sub BCarrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCarrito.Click
    'PanelResultadosProductos.Visible = False
    'PanelCarrito.Visible = True

    'End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridViewBuscadorProducto.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridViewBuscadorProducto.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Carrito"
                        DataGridViewCarrito.Rows.Add("88", "Potenza GII", "175x7", "15", "Automovil", "$600", 2, "$1200")
                        ButtonCarrito.Visible = True
                        Exit Select
                End Select

            End If
        End If
    End Sub

    Private Sub DataGridViewCarrito_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim cell As DataGridViewButtonCell = TryCast(DataGridViewCarrito.CurrentCell, DataGridViewButtonCell)
        Dim res As MsgBoxResult
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DataGridViewCarrito.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Eliminar_Carrito"
                        'Eliminar Poner el nombre de la columna donde se desa dar un evento()
                        'aquí dentro poner las acciones cuando se precione el botón eliminar()
                        'DataGrid.Item(DataGrid.CurrentCell, DataGrid.CurrentRow.Index).Value()
                        res = MsgBox("¿Desea eliminar el producto?", 4 + 256 + 64, "Eliminar")
                        If res = 6 Then
                            DataGridViewCarrito.Rows.RemoveAt(e.RowIndex)
                            MsgBox("Producto Eliminado", 0 + 0 + 16, "Eliminado")
                        End If
                        Exit Select
                End Select

            End If
        End If
    End Sub

    Private Sub ButtonConfirmarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Compra realizada con exito")
        PanelCarrito.Visible = False
        PanelResultadosProductos.Visible = True
    End Sub

    'Private Sub ButtonVerificarCuil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim res As MsgBoxResult
    'If TextBoxCuilCliente.Text = "20365397695" Then
    'MsgBox("Cliente Registrado")
    ''Else
    'res = MsgBox("Cliente NO REGISTRADO ¿Desea agregarlo?", 4 + 256 + 64, "Agregar Cliente")
    'If res = 6 Then
    'PanelCarrito.Visible = False
    'PanelClientes.Visible = True
    'PanelMostrarCliente.Visible = False
    'PanelAgregarModificarCliente.Visible = True
    'End If

    'End If
    'End Sub

    'Private Sub ButtonAceptarMCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptarMCliente.Click
    'PanelClientes.Visible = False
    'End Sub

    'Private Sub ButtonGuardarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGuardarCliente.Click
    'MsgBox("Cliente agregado con exito")
    'PanelClientes.Visible = False
    'End Sub

    'Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
    'PanelProductos.Visible = False
    'PanelProductosBuscar.Visible = False
    'End Sub

    Private Sub BSalir0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir0.Click
        Me.Close()
    End Sub



    Private Sub BProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BProducto.Click
        PanelBuscarProducto.Visible = True
        PanelCarrito.Visible = False
    End Sub

    Private Sub ButtonCarrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCarrito.Click
        PanelResultadosProductos.Visible = False
        PanelCarrito.Visible = True
    End Sub
End Class