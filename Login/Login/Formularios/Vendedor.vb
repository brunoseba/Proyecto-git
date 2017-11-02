Public Class Vendedor
    Dim clie As New Cliente()
    'Metodo cuando carga la ventana'
    Public Sub cargarLoad()
        ComboBoxTipoPago.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        DataGridCompra.Columns("pro_id").Visible = False
        Dim prod As New Productos()
        prod.MostrarTodos(Me.DataGridViewBuscadorProducto, Ventana.cargo.Text)
        Dim ima As Image
        For Each fila As DataGridViewRow In DataGridViewBuscadorProducto.Rows
            'Pone invisible el id y Ruta de la imagen
            DataGridViewBuscadorProducto.Columns("ID").Visible = False
            DataGridViewBuscadorProducto.Columns("Ruta").Visible = False
            DataGridViewBuscadorProducto.Columns("Datos").Visible = False
            DataGridViewBuscadorProducto.Columns("Estado").Visible = False
            DataGridViewBuscadorProducto.Columns("Nombre").Width = 110
            DataGridViewBuscadorProducto.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewBuscadorProducto.Columns("Rod").Width = 33
            DataGridViewBuscadorProducto.Columns("Rod").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewBuscadorProducto.Columns("Medida").Width = 52
            DataGridViewBuscadorProducto.Columns("Medida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewBuscadorProducto.Columns("Precio").Width = 50
            DataGridViewBuscadorProducto.Columns("Precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewBuscadorProducto.Columns("Stock").Width = 45
            DataGridViewBuscadorProducto.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewBuscadorProducto.Columns("Tipo_Vehiculo").Width = 95
            DataGridViewBuscadorProducto.Columns("Tipo_Vehiculo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'Àsigno a imagen.fromfile el valor de la ruta de la imagen de la DB
            ima = Image.FromFile(fila.Cells("Ruta").Value)
            'asigno a la columna datagriedviewImage la imagen asignada fromfile
            fila.Cells("Imagen").Value = ima
        Next
    End Sub

    Private Sub ButtonVerificarCuil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub DataGridViewBuscadorProducto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewBuscadorProducto.CellContentClick
        Dim stock, unit, total As Integer
        Dim id, nombre, medida, rodado, t_vehi, rutaImagen As String
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
                                stock = DataGridViewBuscadorProducto(8, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                If cantidad_Cubiertas <= stock Then
                                    id = DataGridViewBuscadorProducto(3, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    nombre = DataGridViewBuscadorProducto(4, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    medida = DataGridViewBuscadorProducto(6, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    rodado = DataGridViewBuscadorProducto(5, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    t_vehi = DataGridViewBuscadorProducto(10, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    rutaImagen = DataGridViewBuscadorProducto(9, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    unit = DataGridViewBuscadorProducto(7, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    total = unit * cantidad_Cubiertas
                                    PictureBox1.Load(rutaImagen)
                                    'Descontar Stock en la clase'
                                    Dim prod As New Productos()
                                    prod.descontarStock(id, cantidad_Cubiertas)
                                    'Actualizar datagridview'
                                    prod.MostrarTodos(DataGridViewBuscadorProducto, Ventana.cargo.Text)
                                    Me.cargaImagen()
                                    'Pregunta si existe el producto'    
                                    Dim existe As Boolean = DataGridCompra.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells("pro_id").Value) = id)
                                    If Not existe Then
                                        DataGridCompra.Rows.Add(id, nombre, medida, rodado, t_vehi, unit, cantidad_Cubiertas, total, PictureBox1.Image)
                                       Else
                                        'Datagrid de compras'
                                        For Each fila As DataGridViewRow In DataGridCompra.Rows
                                            If id = fila.Cells("pro_id").Value Then
                                                fila.Cells("pro_cantidad").Value = Val((fila.Cells("pro_cantidad").Value)) + Val(cantidad_Cubiertas)
                                                fila.Cells("pro_total").Value = Val(fila.Cells("pro_cantidad").Value) * Val(fila.Cells("pro_precio_unitario").Value)
                                                calcularTotal()
                                            End If
                                        Next
                                    End If
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
                        Dim id, cantidad As Integer
                        res = MsgBox("¿Desea eliminar el producto?", 4 + 256 + 64, "Eliminar")
                        If res = 6 Then
                            id = DataGridCompra(0, DataGridCompra.CurrentRow.Index).Value
                            cantidad = DataGridCompra(6, DataGridCompra.CurrentRow.Index).Value
                            DataGridCompra.Rows.RemoveAt(e.RowIndex)
                            MsgBox("Producto Eliminado", 0 + 0 + 16, "Eliminado")
                            Me.calcularTotal()

                            Dim prod As New Productos()
                            prod.ActualizarStock(id, cantidad)
                            prod.MostrarTodos(DataGridViewBuscadorProducto, Ventana.cargo.Text)
                            cargaImagen()
                        End If
                        Exit Select
                End Select
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim res As MsgBoxResult
        If TextBoxCuilCliente.Text = "" Then
            MsgBox("Cuil del cliente se encuentra vacio", 0 + 0 + 16, "Aviso")
        Else

            res = MsgBox("¿Desea Confirmar la Compra?", 4 + 256 + 64, "Confirmar")
            If res = 6 Then
                If DataGridCompra.RowCount > 0 Or DataGridViewFactura.RowCount > 0 Then
                    PanelBuscarProductoVendedor.Visible = False
                    PanelFactura.Visible = True
                    'Pregunta si existe el producto'   
                    For Each filaCompra As DataGridViewRow In DataGridCompra.Rows
                        Dim existeId As Boolean = DataGridViewFactura.Rows.Cast(Of DataGridViewRow).Any(Function(x) CInt(x.Cells("idProdFactura").Value) = filaCompra.Cells("pro_id").Value)
                        If Not existeId Then
                            DataGridViewFactura.Rows.Add(filaCompra.Cells("pro_id").Value, filaCompra.Cells("pro_cantidad").Value, filaCompra.Cells("pro_nombre").Value, filaCompra.Cells("pro_tipo_vehiculo").Value, filaCompra.Cells("pro_rodado").Value, filaCompra.Cells("pro_medida").Value, filaCompra.Cells("pro_precio_unitario").Value, filaCompra.Cells("pro_total").Value)
                            calcularTotalFactura()
                        Else
                            'Datagrid facturas'
                            For Each fila As DataGridViewRow In DataGridViewFactura.Rows
                                If (filaCompra.Cells("pro_id").Value = fila.Cells("idProdFactura").Value) And (filaCompra.Cells("pro_cantidad").Value <> fila.Cells("Cantidad").Value) Then
                                    fila.Cells("Cantidad").Value = Val((fila.Cells("Cantidad").Value)) + (Val(filaCompra.Cells("pro_cantidad").Value) - Val((fila.Cells("Cantidad").Value)))
                                    fila.Cells("Total").Value = Val(fila.Cells("Cantidad").Value) * Val(fila.Cells("Precio_Unitario").Value)
                                    calcularTotalFactura()
                                End If
                            Next
                        End If
                    Next
                    calcularTotalFactura()
                    'Obtengo datos de empresa'
                    Dim empresa As New Empresa()
                    empresa.MostrarDatosEmpresa()
                    TextBoxCuitEmpresa.Text = empresa.GetCuit()
                    TextBoxDireccionEmpresa.Text = empresa.GetDireccion()
                    TextBoxTelefonoEmpresa.Text = empresa.GetTelefono()
                    TextBoxEmailEmpresa.Text = empresa.GetEmail()
                    TextBCuilCliente.Text = TextBoxCuilCliente.Text
                    TextBNomApeCliente.Text = Label2.Text
                    TextBDniVendedor.Text = Ventana.DniToolStripMenuItem.Text()
                    TextBNomyApeVendedor.Text = Ventana.UserFacturaToolStripMenuItem.Text()
                    TextBTipoPago.Text = ComboBoxTipoPago.Text
                Else
                    MsgBox("No tiene ningun producto seleccionado", 0 + 0 + 16, "Aviso")
                End If
            End If

        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea cancelar la compra?", 4 + 256 + 64, "Eliminar")

        If res = 6 Then
            For Each fila As DataGridViewRow In DataGridCompra.Rows
                Dim prod As New Productos()
                prod.ActualizarStock(fila.Cells("pro_id").Value, fila.Cells("pro_cantidad").Value)
                prod.MostrarTodos(DataGridViewBuscadorProducto, Ventana.cargo.Text)
                cargaImagen()
            Next
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
            prod.MostrarTodos(Me.DataGridViewBuscadorProducto, Ventana.cargo.Text)
            cargaImagen()
        Else
            Dim prod As New Productos
            prod.BuscarPorNombre(TextBox6.Text, DataGridViewBuscadorProducto, Ventana.cargo.Text)
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
            prod.MostrarTodos(Me.DataGridViewBuscadorProducto, Ventana.cargo.Text)
            cargaImagen()
        ElseIf (ComboBox2.SelectedIndex = 0) And (ComboBox1.SelectedIndex > 0) Then
            prod.BuscarPorRodaTipoVehi("a", ComboBox1.SelectedItem, DataGridViewBuscadorProducto, Ventana.cargo.Text, , ComboBox1.SelectedItem)
            cargaImagen()
        ElseIf (ComboBox2.SelectedIndex > 0) And (ComboBox1.SelectedIndex = 0) Then
            prod.BuscarPorRodaTipoVehi(ComboBox2.SelectedItem, "a", DataGridViewBuscadorProducto, Ventana.cargo.Text, ComboBox2.SelectedItem, )
            cargaImagen()
        Else
            prod.BuscarPorRodaTipoVehi(ComboBox2.SelectedItem, ComboBox1.SelectedItem, DataGridViewBuscadorProducto, Ventana.cargo.Text)
            cargaImagen()
        End If
    End Sub

    Private Sub TextBoxCuilCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCuilCliente.TextChanged
        Dim res As MsgBoxResult
        If (TextBoxCuilCliente.TextLength = 11) Then
            Label2.Text = clie.verificarExistencia(TextBoxCuilCliente.Text, Label2.Text)
            If Label2.Text <> "Cliente" And Label2.Text <> "False" Then
                MsgBox("El cliente " + Label2.Text + " se encuentra registrado")
            Else
                Label2.Text = "Cliente"
                res = MsgBox("Cliente NO REGISTRADO ¿Desea agregarlo?", 4 + 256 + 64, "Agregar Cliente")
                If res = 6 Then
                    CuadroCliente.MaximizeBox = True
                    CuadroCliente.Show()
                    CuadroCliente.PanelRegistro.Visible = True
                    CuadroCliente.PanelBusca.Visible = False
                    CuadroCliente.PanelVer.Visible = False
                End If
            End If
        End If
    End Sub
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
    Private Sub TextBoxCuilCliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCuilCliente.KeyPress
        ComprobarNumero(e)
    End Sub

    Private Sub Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridCompra.Columns("pro_id").Visible = False
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PanelFactura.Visible = False
        PanelBuscarProductoVendedor.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ultimaFactura As String
        Dim fatura As New Facturas(TextBCuilCliente.Text(), TextBoxCuitEmpresa.Text, TextBDniVendedor.Text, DateTimePicker1.Text, TextBTipoPago.Text, "Confirmada", LabelTotal.Text)
        If fatura.agregarFactura() Then
            MsgBox("Factura generada correctamente", 0 + 0 + 64, "Aviso")
            ultimaFactura = fatura.ObtenerUltimaFactura()
            For Each fila As DataGridViewRow In DataGridViewFactura.Rows
                Dim deta As New Detalles(Val(ultimaFactura), Val(fila.Cells("idProdFactura").Value), Val(fila.Cells("Cantidad").Value), Val(fila.Cells("Precio_Unitario").Value), Val(fila.Cells("Total").Value))
                deta.agregarDetalles()
            Next
            limpiarCampos()
        Else
            MsgBox("No se pudo generar la Factura, intente mas tarde", 0 + 0 + 64, "Aviso")
        End If
    End Sub

    Private Sub DataGridViewFactura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewFactura.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridViewFactura.CurrentCell, DataGridViewButtonCell)
        Dim res As MsgBoxResult
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridViewFactura.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "eliminar"
                        Dim id, cantidad As Integer
                        res = MsgBox("¿Desea eliminar el producto?", 4 + 256 + 64, "Eliminar")
                        If res = 6 Then
                            id = DataGridViewFactura(0, DataGridViewFactura.CurrentRow.Index).Value
                            cantidad = DataGridViewFactura(6, DataGridViewFactura.CurrentRow.Index).Value
                            DataGridViewFactura.Rows.RemoveAt(e.RowIndex)
                            MsgBox("Producto Eliminado", 0 + 0 + 16, "Eliminado")
                            Me.calcularTotalFactura()
                            'Dim prod As New Productos()
                            'prod.ActualizarStock(id, cantidad)
                        End If
                        Exit Select
                End Select
            End If
        End If
    End Sub
    Private Sub calcularTotalFactura()
        Dim total As Integer
        For Each fila As DataGridViewRow In DataGridViewFactura.Rows
            total = (fila.Cells("Total").Value) + total
        Next
        LabelTotal.Text = total
    End Sub

    Private Sub Vendedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyData = Keys.Control + Keys.F) Then 'And (ButtonAgregarProducto.Visible = True) 
            Dim produ As String
            produ = InputBox("Ingrese la cantidad de cubiertas", "Atención")
            Dim prod As New Productos
            prod.BuscarPorNombre(produ, DataGridViewBuscadorProducto, Ventana.cargo.Text)
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
    Private Sub limpiarCampos()
        PanelFactura.Visible = False
        ComboBoxTipoPago.SelectedIndex = 0
        totalCompra.Text = "0"
        LabelTotal.Text = "0"
        DataGridCompra.Rows.Clear()
        DataGridViewFactura.Rows.Clear()
        PanelBuscarProductoVendedor.Visible = True
        TextBoxCuitEmpresa.Text = ""
        TextBoxDireccionEmpresa.Text = ""
        TextBoxTelefonoEmpresa.Text = ""
        TextBoxEmailEmpresa.Text = ""
        TextBCuilCliente.Text = ""
        TextBNomApeCliente.Text = ""
        TextBDniVendedor.Text = ""
        TextBNomyApeVendedor.Text = ""
        TextBTipoPago.Text = ""
    End Sub

End Class