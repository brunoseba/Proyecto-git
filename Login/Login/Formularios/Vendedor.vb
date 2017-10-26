Public Class Vendedor
    Dim clie As New Cliente()
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
        Dim nombre, medida, rodado, t_vehi, stringTotal, unitString, rutaImagen As String
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
                                If cantidad_Cubiertas < stock Then
                                    nombre = DataGridViewBuscadorProducto(4, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    medida = DataGridViewBuscadorProducto(6, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    rodado = DataGridViewBuscadorProducto(5, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    t_vehi = DataGridViewBuscadorProducto(10, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    rutaImagen = DataGridViewBuscadorProducto(9, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    unit = DataGridViewBuscadorProducto(7, DataGridViewBuscadorProducto.CurrentRow.Index).Value
                                    total = unit * cantidad_Cubiertas
                                    unitString = "$ " + Str(unit)
                                    stringTotal = "$ " + Str(total)
                                    PictureBox1.Load(rutaImagen)
                                    'If DataGridCompra.RowCount = 0 Then
                                    DataGridCompra.Rows.Add(nombre, medida, rodado, t_vehi, unitString, cantidad_Cubiertas, stringTotal, PictureBox1.Image)
                                    'Else
                                    'For Each fila As DataGridViewRow In DataGridCompra.Rows
                                    'Pone invisible el id y Ruta de la imagen
                                    '   If nombre = DataGridCompra(0, DataGridCompra.CurrentRow.Index).Value Then

                                    ' DataGridCompra(5, DataGridCompra.CurrentRow.Index).Value = Val(DataGridCompra(5, DataGridCompra.CurrentRow.Index).Value) + Val(cantidad_Cubiertas)
                                    'Else
                                    '   DataGridCompra.Rows.Add(nombre, medida, rodado, t_vehi, unitString, cantidad_Cubiertas, stringTotal, PictureBox1.Image)
                                    '  Exit For
                                    'End If
                                    '   Next
                                    'End If

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
        Dim res As MsgBoxResult
        res = MsgBox("¿Desea Confirmar la Compra?", 4 + 256 + 64, "Confirmar")
        If res = 6 Then
            DataGridCompra.Rows.Clear()
            TextBoxCuilCliente.Text = 0
            ComboBoxTipoPago.SelectedIndex = 0
            totalCompra.Text = "0"
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

    Private Sub TextBoxCuilCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCuilCliente.TextChanged
        Dim res As MsgBoxResult
        If TextBoxCuilCliente.TextLength = 11 Then
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

    End Sub
End Class