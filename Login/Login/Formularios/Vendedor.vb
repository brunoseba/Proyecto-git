Public Class Vendedor

    'Procedimiento cuando carga la ventana Principal'
    Private Sub Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelConfirmarCompra.Visible = False
        'PanelClientes.Visible = False
        ComboBoxTipoPago.SelectedIndex = 0
        ComboBoxTipoVehiculo.SelectedIndex = 0
    End Sub

    'Procedimiento cuando apreta en el boton buscar y carga el datagrid de los productos'
    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        PanelConfirmarCompra.Visible = False
        Me.DataGridViewBuscadorProducto.Rows.Add("AT-53", "175X6", "16", "Automovil", 25, "$ 450", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Potenza GII", "175x7", "16", "Automovil", 13, "$ 500", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Toranza", "155x9", "15", "Automovil", 10, "$ 700", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Potenza GII", "175x7", "15", "Automovil", 55, "$ 600", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("AT-53", "175X6", "16", "Automovil", 45, "$ 300", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Potenza_RE_050A", "175x7", "16", "Automovil", 3, "$ 650", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Toranza", "155x9", "15", "Automovil", 37, "$ 300", PictureBox1.Image)
        Me.DataGridViewBuscadorProducto.Rows.Add("Potenza GII", "175x7", "15", "Automovil", 22, "$ 600", PictureBox1.Image)

        For Each fila As DataGridViewRow In DataGridViewBuscadorProducto.Rows
            If Val(fila.Cells("Stock").Value) < 20 Then
                fila.Cells("Stock").Style.ForeColor = Color.Red
            ElseIf Val(fila.Cells("Stock").Value) < 40 Then
                fila.Cells("Stock").Style.ForeColor = Color.Orange
            Else
                fila.Cells("Stock").Style.ForeColor = Color.Green
            End If
        Next
    End Sub


    ' Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    'Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridViewBuscadorProducto.CurrentCell, DataGridViewButtonCell)
    '   If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
    'Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridViewBuscadorProducto.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
    '       If bc IsNot Nothing Then
    'Dim s As String = Convert.ToString(cell.Value)
    '           Select Case bc.Name
    '              Case "Carrito"
    '                 DataGridViewCarrito.Rows.Add("Potenza GII", "175x7", "15", "Automovil", "$600", 2, "$1200", PictureBox1.Image)
    '                Exit Select
    '       End Select

    '        End If
    '   End If
    'End Sub

    'Procedimiento para eliminar los productos del carrito en la ultima confirmacion de compra'
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

    'Boton confirmar compra'
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


    Private Sub DataGridViewBuscadorProducto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewBuscadorProducto.CellContentClick
        Dim stock, unit, total As Integer
        Dim nombre, medida, rodado, t_vehi, stringTotal, unitString As String
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
                                'Obtengo los datos de la fila del datagrid'
                                stock = DataGridViewBuscadorProducto(4, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                If cantidad_Cubiertas < stock Then
                                    nombre = DataGridViewBuscadorProducto(0, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    medida = DataGridViewBuscadorProducto(1, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    rodado = DataGridViewBuscadorProducto(2, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    t_vehi = DataGridViewBuscadorProducto(3, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    unit = DataGridViewBuscadorProducto(5, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    total = unit * cantidad_Cubiertas
                                    unitString = "$ " + Str(unit)
                                    stringTotal = "$ " + Str(total)
                                    DataGridCompra.Rows.Add(nombre, medida, rodado, t_vehi, unitString, cantidad_Cubiertas, stringTotal, PictureBox1.Image)
                                    Me.calcularTotal()
                                Else
                                    MsgBox("No hay stock disponible para monto ingresado", 0 + 0 + 16, "Error stock")
                                End If

                            Else
                                MsgBox("El valor ingresado debe ser mayor a 0", 0 + 0 + 16, "Valor Incorrecto")
                            End If
                        Else
                            MsgBox("El valor ingresado no es un Número", 0 + 0 + 16, "Valor Incorrecto")
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
                            Me.calcularTotal()
                        End If
                        Exit Select
                End Select

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each fila As DataGridViewRow In DataGridCompra.Rows
            DataGridViewCarrito.Rows.Add(fila.Cells("pro_nombre").Value, fila.Cells("pro_medida").Value, fila.Cells("pro_rodado").Value, fila.Cells("pro_tipo_vehiculo").Value, fila.Cells("pro_precio_unitario").Value, fila.Cells("pro_cantidad").Value, fila.Cells("pro_total").Value, PictureBox1.Image)
        Next
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea Confirmar la Compra?", 4 + 256 + 64, "Confirmar")
        If res = 6 Then
            DataGridViewBuscadorProducto.Rows.Clear()
            DataGridCompra.Rows.Clear()
            MontoTotal.Text = Val(MontoTotal.Text) + Val(totalCompra.Text)
            totalCompra.Text = "0"
            PanelBuscarProductoVendedor.Visible = False
            PanelConfirmarCompra.Visible = True
        End If

    End Sub

    Private Sub ButtonConfirmarCompra_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConfirmarCompra.Click
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea Confirmar la Compra?", 4 + 256 + 64, "Confirmar")
        If res = 6 Then
            MsgBox("Compra realizada con Exito")
            DataGridViewCarrito.Rows.Clear()
            MontoTotal.Text = "0"
            TextBoxCuilCliente.Text = ""
            PanelBuscarProductoVendedor.Visible = True
            PanelConfirmarCompra.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PanelBuscarProductoVendedor.Visible = True
        PanelConfirmarCompra.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea cancelar la compra?", 4 + 256 + 64, "Eliminar")
        If res = 6 Then
            DataGridCompra.Rows.Clear()
        End If
    End Sub

    Private Sub calcularTotal()
        Dim total As Integer
        For Each fila As DataGridViewRow In DataGridCompra.Rows
            total = (fila.Cells("pro_total").Value) + total
        Next
        totalCompra.Text = total
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea Cancelar la Compra?", 4 + 256 + 64, "Confirmar")
        If res = 6 Then
            DataGridViewCarrito.Rows.Clear()
            MontoTotal.Text = "0"
        End If
    End Sub

    Private Sub ButtonVerificarCuil_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerificarCuil.Click
        If TextBoxCuilCliente.Text = "20365397695" Then
            MsgBox("Cliente Registrado: " + "Pedro Lautaro Sanchez", 0 + 0 + 64, "Aviso")
        Else
            Dim res As MsgBoxResult
            res = MsgBox("Cliente no registrado, ¿Desea registrarlo?", 4 + 256 + 64, "Confirmar")
            If res = 6 Then
                CuadroUsu.MaximizeBox = True
                CuadroUsu.Show()
                CuadroUsu.PanelRegistro.Visible = True
                CuadroUsu.PanelBusca.Visible = False
                CuadroUsu.PanelVer.Visible = False
            End If
        End If
    End Sub


End Class