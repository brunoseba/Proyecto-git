Public Class Vendedor

    'Procedimiento cuando carga la ventana Principal'
    Private Sub Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelConfirmarCompra.Visible = False
        'PanelClientes.Visible = False
        ComboBoxTipoPago.SelectedIndex = 0
        ComboBoxTipoVehiculo.SelectedIndex = 0
    End Sub


    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        PanelConfirmarCompra.Visible = False
        Me.DataGridViewBuscadorProducto.Rows.Add("AT-53", "175X6", "16", "Automovil", 125, "$300", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Potenza GII", "175x7", "16", "Automovil", 23, "$500", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Toranza", "155x9", "15", "Automovil", 23, "$700", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Potenza GII", "175x7", "15", "Automovil", 23, "$600", PictureBox1.Image)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridViewBuscadorProducto.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridViewBuscadorProducto.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Carrito"
                        DataGridViewCarrito.Rows.Add("Potenza GII", "175x7", "15", "Automovil", "$600", 2, "$1200", PictureBox1.Image)
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
        PanelConfirmarCompra.Visible = False
    End Sub

    Private Sub ButtonVerificarCuil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub
    Private Sub BSalir0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub ButtonCarrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PanelConfirmarCompra.Visible = True
    End Sub

    Private Sub DataGridViewBuscadorProducto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewBuscadorProducto.CellContentClick
        Dim cantidad_Cubiertas As String
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridViewBuscadorProducto.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridViewBuscadorProducto.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Agregar"
                        cantidad_Cubiertas = InputBox("Ingrese la cantidad de cubiertas", "Atención")
                        If IsNumeric(cantidad_Cubiertas) Then
                            If cantidad_Cubiertas > 0 Then
                                DataGridCompra.Rows.Add("Potenza GII", "175x7", "15", "Automovil", "$600", cantidad_Cubiertas, "$1200", PictureBox1.Image)
                                DataGridViewCarrito.Rows.Add("Potenza GII", "175x7", "15", "Automovil", "$600", cantidad_Cubiertas, "$1200", PictureBox1.Image)
                            Else
                                MsgBox("El valor ingresado debe ser mayor a 0")
                            End If
                        Else
                            MsgBox("El valor ingresado no es un número")
                        End If
                        Exit Select
                End Select

            End If
        End If
    End Sub


    Private Sub DataGridCompra_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridCompra.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridCompra.CurrentCell, DataGridViewButtonCell)
        Dim res As MsgBoxResult
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridCompra.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Eliminar_C"
                        res = MsgBox("¿Desea eliminar el producto?", 4 + 256 + 64, "Eliminar")
                        If res = 6 Then
                            DataGridCompra.Rows.RemoveAt(e.RowIndex)
                            MsgBox("Producto Eliminado", 0 + 0 + 16, "Eliminado")
                        End If
                        Exit Select
                End Select

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cantRegistros As Integer = DataGridCompra.Rows.Count


        For Each fila As DataGridViewRow In DataGridCompra.Rows
            'DataGridViewCarrito.Rows.Add(fila.Clone)
            DataGridViewCarrito.Rows.Add(fila.Cells("pro_nombre").Value, fila.Cells("pro_medida").Value, fila.Cells("pro_rodado").Value, fila.Cells("pro_tipo_vehiculo").Value, fila.Cells("pro_precio_unitario").Value, fila.Cells("pro_cantidad").Value, fila.Cells("pro_total").Value, PictureBox1.Image)

        Next
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea Confirmar la Compra?", 4 + 256 + 64, "Confirmar")
        If res = 6 Then
            PanelBuscarProductoVendedor.Visible = False
            PanelConfirmarCompra.Visible = True
        End If

    End Sub

    Private Sub ButtonConfirmarCompra_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConfirmarCompra.Click
        MsgBox("Compra realizada con Exito")
        PanelBuscarProductoVendedor.Visible = True
        PanelConfirmarCompra.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PanelBuscarProductoVendedor.Visible = True
        PanelConfirmarCompra.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea cancelar la compra?", 4 + 256 + 64, "Eliminar")
        If res = 6 Then
            'For Each fila As DataGridViewRow In DataGridCompra.Rows
            DataGridCompra.Rows.Clear()
            'Next
        End If
    End Sub
End Class