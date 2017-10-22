Public Class V_Producto


    Private Sub ButtonCancelarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelarProducto.Click
        Me.Close()
    End Sub

    Private Sub ButtonBuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscarProducto.Click
        cargarImagen()
        'Dim prod As New Productos()
        'prod.MostrarTodos(Me.DataGridViewResultadosProductos)
        ''Cargo la FOTO'
        'For Each fila As DataGridViewRow In DataGridViewResultadosProductos.Rows
        ' PictureBox3.Load(fila.Cells("Ruta").Value)
        ' fila.Cells("Imagen").Value = (PictureBox3.Image)
        ' Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MsgBox("Se encuentra vacio el campo", 16, "Error")
            TextBox1.Focus()
            TextBox1.BackColor = Color.Red
        Else
            Dim prod As New Productos()
        If prod.ActualizarStock(Val((DataGridViewResultadosProductos.Item(4, DataGridViewResultadosProductos.CurrentRow.Index).Value)), Val(TextBox1.Text)) Then
            MsgBox("Stock Actualizado", 0 + 0 + 64)
        Else
            MsgBox("No se actualizo el stock del Producto", 16, "Atención")
        End If
        Me.PanelActualizarStock.Visible = False
            cargarImagen()
        End If

    End Sub

    Private Sub DataGridViewResultadosProductos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewResultadosProductos.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridViewResultadosProductos.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridViewResultadosProductos.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Datos_Tecnicos"
                        Me.PanelActualizarStock.Visible = False
                        Me.PanelAgregarProductos.Visible = False
                        Me.PanelMostrarDatosTecnicos.Visible = True
                        TextBox1.Text = ""
                        TextBox1.BackColor = Color.White
                        Dim d_Tec As New D_Tecnicos()
                        d_Tec.MostrarUnicoDTecnicos(DataGridViewResultadosProductos.Item(13, DataGridViewResultadosProductos.CurrentRow.Index).Value, Me.DataGridView1)
                End Select
                Select Case bc.Name
                    Case "A_Stock"
                        Me.PanelAgregarProductos.Visible = False
                        Me.PanelMostrarDatosTecnicos.Visible = False
                        Me.PanelActualizarStock.Visible = True
                        TextBox1.Text = ""
                        TextBox1.BackColor = Color.White
                        Label3.Text = DataGridViewResultadosProductos.Item(5, DataGridViewResultadosProductos.CurrentRow.Index).Value
                        Label6.Text = DataGridViewResultadosProductos.Item(7, DataGridViewResultadosProductos.CurrentRow.Index).Value
                        Label8.Text = DataGridViewResultadosProductos.Item(6, DataGridViewResultadosProductos.CurrentRow.Index).Value
                        Label9.Text = DataGridViewResultadosProductos.Item(9, DataGridViewResultadosProductos.CurrentRow.Index).Value
                End Select
                Select Case bc.Name
                    Case "Modificar"
                        TextBox1.Text = ""
                        TextBox1.BackColor = Color.White
                        Me.PanelMostrarDatosTecnicos.Visible = False
                        Me.PanelActualizarStock.Visible = False
                        Me.PanelProductosBuscar.Visible = False
                        Me.ButtonAgregarProducto.Visible = False
                        Me.Button4.Visible = False
                        Me.ButtonBajaProducto.Visible = True
                        Me.ButtonAltaProducto.Visible = True
                        Me.ButtonActualizarProducto.Visible = True
                        Me.PanelAgregarProductos.Visible = True
                        TextBoxNombreProducto.Text = DataGridViewResultadosProductos.Item(5, DataGridViewResultadosProductos.CurrentRow.Index).Value
                        TextBoxPrecio.Text = Val(DataGridViewResultadosProductos.Item(8, DataGridViewResultadosProductos.CurrentRow.Index).Value)
                        TextBoxStock.Text = DataGridViewResultadosProductos.Item(9, DataGridViewResultadosProductos.CurrentRow.Index).Value
                        asignarMedida(ComboBoxMedidaProducto, DataGridViewResultadosProductos.Item(7, DataGridViewResultadosProductos.CurrentRow.Index).Value)
                        asignarRodado(ComboBoxRodadoProducto, DataGridViewResultadosProductos.Item(6, DataGridViewResultadosProductos.CurrentRow.Index).Value)
                        asignarTipoVehiculo(ComboBoxTipoVehiculo, DataGridViewResultadosProductos.Item(11, DataGridViewResultadosProductos.CurrentRow.Index).Value)
                        PictureBox1.Load(DataGridViewResultadosProductos.Item(10, DataGridViewResultadosProductos.CurrentRow.Index).Value)
                        LabelRutaArchivo.Text = DataGridViewResultadosProductos.Item(10, DataGridViewResultadosProductos.CurrentRow.Index).Value
                        LabelestadoProducto.Text = DataGridViewResultadosProductos.Item(12, DataGridViewResultadosProductos.CurrentRow.Index).Value
                        If LabelestadoProducto.Text = "A" Then
                            ButtonAltaProducto.Visible = False
                        Else
                            ButtonBajaProducto.Visible = False
                        End If
                End Select

            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PanelMostrarDatosTecnicos.Visible = False
    End Sub

    Private Sub ButtonActualizarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActualizarProducto.Click
        Dim prod As New Productos()
        If (prod.ModificarProducto(DataGridViewResultadosProductos.Item(4, DataGridViewResultadosProductos.CurrentRow.Index).Value, TextBoxNombreProducto.Text, ComboBoxRodadoProducto.SelectedItem, ComboBoxMedidaProducto.SelectedItem, Val(TextBoxPrecio.Text), Val(TextBoxCod_Datos.Text), Val(TextBoxStock.Text), LabelRutaArchivo.Text, "A", ComboBoxTipoVehiculo.SelectedItem)) Then
            MsgBox("Producto se modifico con Éxito", 0 + 0 + 64)
        Else
            MsgBox("No se pudo modificar el Producto", 16, "Atención")
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Png|*.png|Jpg|*.jpg|Bmp|*.bmp"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            LabelRutaArchivo.Text = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregarProducto.Click
        If Not ComprobarVacioNuevoProducto() Then
            TextBoxNombreProducto.BackColor = Color.LightGreen
            TextBoxPrecio.BackColor = Color.LightGreen
            TextBoxCod_Datos.BackColor = Color.LightGreen
            TextBoxStock.BackColor = Color.LightGreen
            Dim prod As New Productos(TextBoxNombreProducto.Text, ComboBoxRodadoProducto.SelectedItem, ComboBoxMedidaProducto.SelectedItem, Val(TextBoxPrecio.Text), Val(TextBoxCod_Datos.Text), Val(TextBoxStock.Text), LabelRutaArchivo.Text, "A", ComboBoxTipoVehiculo.SelectedItem)
            Dim res, res2, res_img As MsgBoxResult

            res = MsgBox("Desea Agregar un nuevo Producto?", 4 + 0 + 32, "Aviso")
            If res = vbYes Then
                If Me.LabelRutaArchivo.Text = "Ruta:" Then
                    res_img = MsgBox("El producto no tiene imagen asignada, ¿Desea agregar una?", 4 + 0 + 32, "Aviso")
                    If res_img = vbNo Then
                        prod.AgregarProducto()
                        MsgBox("Producto Agregado", 0 + 0 + 64)
                        res2 = MsgBox("¿Desea Agregar otro Producto?", 4 + 0 + 32, "Aviso")
                        If res2 = vbYes Then
                            TextBoxNombreProducto.Text = ""
                            TextBoxCod_Datos.Text = ""
                            TextBoxStock.Text = ""
                            TextBoxPrecio.Text = ""
                            LabelRutaArchivo.Text = "Ruta:"
                            TextBoxNombreProducto.BackColor = Color.White
                            TextBoxPrecio.BackColor = Color.White
                            TextBoxCod_Datos.BackColor = Color.White
                            TextBoxStock.BackColor = Color.White
                            PictureBox1.Image = My.Resources.image_not_found__1_
                        Else
                            Me.Close()
                        End If
                    End If
                Else
                    prod.AgregarProducto()
                    MsgBox("Producto Agregado", 0 + 0 + 64)
                    res2 = MsgBox("¿Desea Agregar otro Producto?", 4 + 0 + 32, "Aviso")
                    If res2 = vbYes Then
                        TextBoxNombreProducto.Text = ""
                        TextBoxCod_Datos.Text = ""
                        TextBoxStock.Text = ""
                        TextBoxPrecio.Text = ""
                        LabelRutaArchivo.Text = "Ruta:"
                        TextBoxNombreProducto.BackColor = Color.White
                        TextBoxPrecio.BackColor = Color.White
                        TextBoxCod_Datos.BackColor = Color.White
                        TextBoxStock.BackColor = Color.White
                        PictureBox1.Image = My.Resources.image_not_found__1_
                    Else
                        Me.Close()
                    End If
                End If
            Else
                MsgBox("No se agrego el Producto", 16, "Atención")
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

    Private Function ComprobarVacioNuevoProducto() As Boolean
        If String.IsNullOrWhiteSpace(TextBoxNombreProducto.Text) Then
            MsgBox("Debe completar el campo Nombre", 16, "Atención")
            TextBoxNombreProducto.BackColor = Color.Salmon
            TextBoxNombreProducto.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxPrecio.Text) Then
            MsgBox("Debe completar el campo Precio", 16, "Atención")
            TextBoxPrecio.BackColor = Color.Salmon
            TextBoxPrecio.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxStock.Text) Then
            MsgBox("Debe completar el campo Stock", 16, "Atención")
            TextBoxStock.BackColor = Color.Salmon
            TextBoxStock.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TextBoxPrecio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxStock.KeyPress, TextBoxPrecio.KeyPress
        Me.ComprobarNumero(e)
    End Sub

    Private Sub ComboBoxMedidaProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMedidaProducto.SelectedIndexChanged
        For Each fila As DataGridViewRow In DataGridViewDatosCodigo.Rows
            If fila.Cells("Medida").Value = ComboBoxMedidaProducto.Text Then
                TextBoxCod_Datos.Text = fila.Cells("Codigo").Value
                fila.Cells("Codigo").Style.BackColor = Color.Aquamarine
                fila.Cells("Medida").Style.BackColor = Color.Aquamarine
                fila.Cells("Indice_Carga").Style.BackColor = Color.Aquamarine
                fila.Cells("Velocidad").Style.BackColor = Color.Aquamarine
                fila.Cells("Revision_Por_Km").Style.BackColor = Color.Aquamarine
                fila.Cells("Ancho_Llanta").Style.BackColor = Color.Aquamarine
                fila.Cells("Ancho_Sesion").Style.BackColor = Color.Aquamarine
                fila.Cells("Diametro").Style.BackColor = Color.Aquamarine
            Else
                fila.Cells("Codigo").Style.BackColor = Color.White
                fila.Cells("Medida").Style.BackColor = Color.White
                fila.Cells("Indice_Carga").Style.BackColor = Color.White
                fila.Cells("Velocidad").Style.BackColor = Color.White
                fila.Cells("Revision_Por_Km").Style.BackColor = Color.White
                fila.Cells("Ancho_Llanta").Style.BackColor = Color.White
                fila.Cells("Ancho_Sesion").Style.BackColor = Color.White
                fila.Cells("Diametro").Style.BackColor = Color.White
            End If
        Next
    End Sub

    Public Sub cargarImagen()
        Dim prod As New Productos()
        prod.MostrarTodos(Me.DataGridViewResultadosProductos)

        Dim ima As Image
        For Each fila As DataGridViewRow In DataGridViewResultadosProductos.Rows
            'Pone invisible el id y Ruta de la imagen
            DataGridViewResultadosProductos.Columns("ID").Visible = False
            DataGridViewResultadosProductos.Columns("Ruta").Visible = False
            DataGridViewResultadosProductos.Columns("Datos").Visible = False
            'Àsigno a imagen.fromfile el valor de la ruta de la imagen de la DB
            ima = Image.FromFile(fila.Cells("Ruta").Value)
            'asigno a la columna datagriedviewImage la imagen asignada fromfile
            fila.Cells("Imagen").Value = ima

        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBoxNombreProducto.Text = ""
        'ComboBoxRodadoProducto.SelectedIndex = 0
        'ComboBoxMedidaProducto.SelectedIndex = 0
        TextBoxPrecio.Text = ""
        TextBoxStock.Text = ""
        'ComboBoxTipoVehiculo.SelectedIndex = 0
        LabelRutaArchivo.Text = "Ruta:"
        PictureBox1.Image = My.Resources.image_not_found__1_
    End Sub


    Private Sub V_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim d_Tec As New D_Tecnicos()
        d_Tec.MostrarTodosDTecnicos(Me.DataGridViewDatosCodigo)
        'ComboBoxMedidaProducto.SelectedIndex = 0
        'ComboBoxRodadoProducto.SelectedIndex = 0
        ' ComboBoxTipoVehiculo.SelectedIndex = 0
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        ComprobarNumero(e)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.BackColor = Color.Red
        Else
            TextBox1.BackColor = Color.Green
        End If
    End Sub

    Private Sub asignarMedida(ByVal combo As ComboBox, ByVal valor As String)
        If valor = "27x8.5" Then
            combo.SelectedIndex = 0
        ElseIf valor = "31x10" Then
            combo.SelectedIndex = 1
        ElseIf valor = "32x11.5" Then
            combo.SelectedIndex = 2
        ElseIf valor = "215/60" Then
            combo.SelectedIndex = 3
        ElseIf valor = "215/120" Then
            combo.SelectedIndex = 4
        ElseIf valor = "235/60" Then
            combo.SelectedIndex = 5
        ElseIf valor = "235/120" Then
            combo.SelectedIndex = 6
        ElseIf valor = "255/75" Then
            combo.SelectedIndex = 7
        ElseIf valor = "255/100" Then
            combo.SelectedIndex = 8
        ElseIf valor = "290/24" Then
            combo.SelectedIndex = 9
        ElseIf valor = "290/90" Then
            combo.SelectedIndex = 10
        Else
            combo.SelectedIndex = 11
        End If
    End Sub
    Private Sub asignarRodado(ByVal combo As ComboBox, ByVal valor As String)
        If valor = "12" Then
            combo.SelectedIndex = 0
        ElseIf valor = "13" Then
            combo.SelectedIndex = 1
        ElseIf valor = "14" Then
            combo.SelectedIndex = 2
        ElseIf valor = "15" Then
            combo.SelectedIndex = 3
        ElseIf valor = "16" Then
            combo.SelectedIndex = 4
        ElseIf valor = "17" Then
            combo.SelectedIndex = 5
        ElseIf valor = "18" Then
            combo.SelectedIndex = 6
        ElseIf valor = "19" Then
            combo.SelectedIndex = 7
        ElseIf valor = "20" Then
            combo.SelectedIndex = 8
        ElseIf valor = "22.5" Then
            combo.SelectedIndex = 9
        ElseIf valor = "26" Then
            combo.SelectedIndex = 10
        ElseIf valor = "28" Then
            combo.SelectedIndex = 11
        ElseIf valor = "36" Then
            combo.SelectedIndex = 12
        Else
            combo.SelectedIndex = 13
        End If
    End Sub
    Private Sub asignarTipoVehiculo(ByVal combo As ComboBox, ByVal valor As String)
        If valor = "Automóviles" Then
            combo.SelectedIndex = 0
        ElseIf valor = "Camiones/Colectivos" Then
            combo.SelectedIndex = 1
        ElseIf valor = "Camionetas" Then
            combo.SelectedIndex = 2
        Else
            combo.SelectedIndex = 3
        End If
    End Sub

    Private Sub ButtonBajaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBajaProducto.Click
        Dim prod As New Productos()
        If (prod.BajaProducto(DataGridViewResultadosProductos.Item(4, DataGridViewResultadosProductos.CurrentRow.Index).Value)) Then
            MsgBox("El Producto se dio de Baja Correctamente", 0 + 0 + 64)
        Else
            MsgBox("El producto no se pudo dar de Baja", 16, "Atención")
        End If
        Me.Close()
    End Sub

    Private Sub ButtonAltaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAltaProducto.Click
        Dim prod As New Productos()
        If (prod.AltaProducto(DataGridViewResultadosProductos.Item(4, DataGridViewResultadosProductos.CurrentRow.Index).Value)) Then
            MsgBox("El Producto se dio de Alta Correctamente", 0 + 0 + 64)
        Else
            MsgBox("El producto no se pudo dar de Alta", 16, "Atención")
        End If
        Me.Close()
    End Sub
End Class