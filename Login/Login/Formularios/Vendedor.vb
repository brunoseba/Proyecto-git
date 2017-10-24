Public Class Vendedor

    'Metodo cuando carga la ventana'
    Public Sub cargarLoad()
        ComboBoxTipoPago.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        Dim prod As New Productos()
        prod.MostrarTodos(Me.DataGridViewBuscadorProducto)
        Dim ima As Image
        For Each fila As DataGridViewRow In DataGridViewBuscadorProducto.Rows
            'Pone invisible el id y Ruta de la imagen
            DataGridViewBuscadorProducto.Columns("ID").Visible = False
            DataGridViewBuscadorProducto.Columns("Ruta").Visible = False
            DataGridViewBuscadorProducto.Columns("Datos").Visible = False
            DataGridViewBuscadorProducto.Columns("Estado").Visible = False
            'Àsigno a imagen.fromfile el valor de la ruta de la imagen de la DB
            ima = Image.FromFile(fila.Cells("Ruta").Value)
            'asigno a la columna datagriedviewImage la imagen asignada fromfile
            fila.Cells("Imagen").Value = ima
        Next
    End Sub


    'Procedimiento para eliminar los productos del carrito en la ultima confirmacion de compra'
    Private Sub DataGridViewCarrito_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        '  Dim cell As DataGridViewButtonCell = TryCast(DataGridViewCarrito.CurrentCell, DataGridViewButtonCell)
        ' Dim res As MsgBoxResult
        'If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
        '       Dim bc As DataGridViewButtonColumn = TryCast(DataGridViewCarrito.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
        'If bc IsNot Nothing Then
        'Dim s As String = Convert.ToString(cell.Value)
        'Select Case bc.Name
        '   Case "Eliminar_Carrito"
        'Eliminar Poner el nombre de la columna donde se desa dar un evento()
        'aquí dentro poner las acciones cuando se precione el botón eliminar()
        'DataGrid.Item(DataGrid.CurrentCell, DataGrid.CurrentRow.Index).Value()
        'res = MsgBox("¿Desea eliminar el producto?", 4 + 256 + 64, "Eliminar")
        'If res = 6 Then
        '                        DataGridViewCarrito.Rows.RemoveAt(e.RowIndex)
        MsgBox("Producto Eliminado", 0 + 0 + 16, "Eliminado")
        'End If
        'Exit Select
        'End Select

        'End If
        'End If
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
                Select Case bc.Name
                    Case "Datos_Tecn"
                        PanelDatosTecnicosVendedor.Visible = True
                        Dim d_Tec As New D_Tecnicos()
                        d_Tec.MostrarUnicoDTecnicos(Val(DataGridViewBuscadorProducto.Item(12, DataGridViewBuscadorProducto.CurrentRow.Index).Value), Me.DataGridDatosCodigo)
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
            'DataGridViewCarrito.Rows.Add(fila.Cells("pro_nombre").Value, fila.Cells("pro_medida").Value, fila.Cells("pro_rodado").Value, fila.Cells("pro_tipo_vehiculo").Value, fila.Cells("pro_precio_unitario").Value, fila.Cells("pro_cantidad").Value, fila.Cells("pro_total").Value, PictureBox1.Image)
        Next
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea Confirmar la Compra?", 4 + 256 + 64, "Confirmar")
        If res = 6 Then
            DataGridViewBuscadorProducto.Rows.Clear()
            DataGridCompra.Rows.Clear()
            totalCompra.Text = "0"
            PanelBuscarProductoVendedor.Visible = False

        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea cancelar la compra?", 4 + 256 + 64, "Eliminar")

        If res = 6 Then
            DataGridCompra.Rows.Clear()
            totalCompra.Text = "0"
        End If
    End Sub

    Private Sub calcularTotal()
        Dim total As Integer
        For Each fila As DataGridViewRow In DataGridCompra.Rows
            total = (fila.Cells("pro_total").Value) + total
        Next
        totalCompra.Text = total
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea Cancelar la Compra?", 4 + 256 + 64, "Confirmar")
        If res = 6 Then
            '        DataGridViewCarrito.Rows.Clear()
        End If
    End Sub

    Private Sub ButtonVerificarCuil_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBoxCuilCliente.Text = "20365397695" Then
            MsgBox("Cliente Registrado: " + "Pedro Lautaro Sanchez", 0 + 0 + 64, "Aviso")
        Else
            Dim res As MsgBoxResult
            res = MsgBox("Cliente no registrado, ¿Desea registrarlo?", 4 + 256 + 64, "Confirmar")
            If res = 6 Then
                CuadroCliente.MaximizeBox = True
                CuadroCliente.Show()
                CuadroCliente.PanelRegistro.Visible = True
                CuadroCliente.PanelBusca.Visible = False
                CuadroCliente.PanelVer.Visible = False

            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PanelDatosTecnicosVendedor.Visible = False
    End Sub

    'Metodo que busca por nombre cuando se realiza cambios en el TextBox
    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        If TextBox6.Text = "" Then
            Dim prod As New Productos()
            prod.MostrarTodos(Me.DataGridViewBuscadorProducto)
            cargaImagen()
        Else
            Dim prod As New Productos
            prod.BuscarPorNombre(TextBox6.Text, DataGridViewBuscadorProducto)
            Dim ima As Image
            For Each fila As DataGridViewRow In DataGridViewBuscadorProducto.Rows
                'Pone invisible el id y Ruta de la imagen
                DataGridViewBuscadorProducto.Columns("ID").Visible = False
                DataGridViewBuscadorProducto.Columns("Ruta").Visible = False
                DataGridViewBuscadorProducto.Columns("Datos").Visible = False
                'Àsigno a imagen.fromfile el valor de la ruta de la imagen de la DB
                ima = Image.FromFile(fila.Cells("Ruta").Value)
                'asigno a la columna datagriedviewImage la imagen asignada fromfile
                fila.Cells("Imagen").Value = ima
            Next
        End If
    End Sub

    'Metodo que carga la imagen en el datagrid'
    Public Sub cargaImagen()
        Dim ima As Image
        For Each fila As DataGridViewRow In DataGridViewBuscadorProducto.Rows
            'Pone invisible el id y Ruta de la imagen
            DataGridViewBuscadorProducto.Columns("ID").Visible = False
            DataGridViewBuscadorProducto.Columns("Ruta").Visible = False
            DataGridViewBuscadorProducto.Columns("Datos").Visible = False
            'Àsigno a imagen.fromfile el valor de la ruta de la imagen de la DB
            ima = Image.FromFile(fila.Cells("Ruta").Value)
            'asigno a la columna datagriedviewImage la imagen asignada fromfile
            fila.Cells("Imagen").Value = ima
        Next
    End Sub

    'Busqueda por Rodado y/o Tipo de vehiculo cuando cambia de valor de/los Combobox
    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted, ComboBox1.SelectionChangeCommitted
        TextBox6.Text = ""
        Dim prod As New Productos
        If (ComboBox2.SelectedIndex = 0) And (ComboBox1.SelectedIndex = 0) Then
            prod.MostrarTodos(Me.DataGridViewBuscadorProducto)
            cargaImagen()
        ElseIf (ComboBox2.SelectedIndex = 0) And (ComboBox1.SelectedIndex > 0) Then
            prod.BuscarPorRodaTipoVehi("a", ComboBox1.SelectedItem, DataGridViewBuscadorProducto, , ComboBox1.SelectedItem)
            cargaImagen()
        ElseIf (ComboBox2.SelectedIndex > 0) And (ComboBox1.SelectedIndex = 0) Then
            prod.BuscarPorRodaTipoVehi(ComboBox2.SelectedItem, "a", DataGridViewBuscadorProducto, ComboBox2.SelectedItem, )
            cargaImagen()
        Else
            prod.BuscarPorRodaTipoVehi(ComboBox2.SelectedItem, ComboBox1.SelectedItem, DataGridViewBuscadorProducto)
            cargaImagen()
        End If
    End Sub
End Class