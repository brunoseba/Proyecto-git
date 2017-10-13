Public Class V_Producto

    'Procedimiento cuando carga la ventana Principal'
    Private Sub Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim d_Tec As New D_Tecnicos()
        d_Tec.MostrarDTecnicos(Me.DataGridViewDatosCodigo)
     
        ComboBoxMedidaProducto.SelectedIndex = 0
        ComboBoxRodadoProducto.SelectedIndex = 0
        ComboBoxTipoVehiculo.SelectedIndex = 0
    End Sub

    Private Sub ButtonCancelarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelarProducto.Click
        Me.Close()
    End Sub

    Private Sub ButtonBuscarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscarProducto.Click
        Me.DataGridViewResultadosProductos.Rows.Add("AT-53", "175X6", "16", "Automovil", 25, "$ 450", PictureBox2.Image)
        Me.DataGridViewResultadosProductos.Rows.Add("Potenza GII", "175x7", "16", "Automovil", 13, "$ 500", PictureBox2.Image)
        Me.DataGridViewResultadosProductos.Rows.Add("Toranza", "155x9", "15", "Automovil", 10, "$ 700", PictureBox2.Image)
        Me.DataGridViewResultadosProductos.Rows.Add("Potenza GII", "175x7", "15", "Automovil", 55, "$ 600", PictureBox2.Image)
        Me.DataGridViewResultadosProductos.Rows.Add("AT-53", "175X6", "16", "Automovil", 45, "$ 300", PictureBox2.Image)
        Me.DataGridViewResultadosProductos.Rows.Add("Potenza_RE_050A", "175x7", "16", "Automovil", 3, "$ 650", PictureBox2.Image)
        Me.DataGridViewResultadosProductos.Rows.Add("Toranza", "155x9", "15", "Automovil", 37, "$ 300", PictureBox2.Image)
        Me.DataGridViewResultadosProductos.Rows.Add("Potenza GII", "175x7", "15", "Automovil", 22, "$ 600", PictureBox2.Image)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Stock Actualizado")
        Me.PanelActualizarStock.Visible = False
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
                        DataGridView1.Rows.Add("1", "LT215/75R15", "1", "S180", "466", "6", "216", "703")
                End Select
                Select Case bc.Name
                    Case "A_Stock"
                        Me.PanelAgregarProductos.Visible = False
                        Me.PanelMostrarDatosTecnicos.Visible = False
                        Me.PanelActualizarStock.Visible = True
                End Select
                Select Case bc.Name
                    Case "Modificar"
                        Me.PanelMostrarDatosTecnicos.Visible = False
                        Me.PanelActualizarStock.Visible = False
                        Me.PanelProductosBuscar.Visible = False
                        Me.ButtonAgregarProducto.Visible = False
                        Me.ButtonActualizarProducto.Visible = True
                        Me.PanelAgregarProductos.Visible = True
                End Select

            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.PanelMostrarDatosTecnicos.Visible = False
    End Sub

    Private Sub ButtonActualizarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActualizarProducto.Click
        MsgBox("Producto Actuañizado")
        ButtonActualizarProducto.Visible = False
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
                MsgBox("No se agrego el Producto", 0 + 0 + 64)
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
            MsgBox("Debe completar el campo Nombre")
            TextBoxNombreProducto.BackColor = Color.Salmon
            TextBoxNombreProducto.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxPrecio.Text) Then
            MsgBox("Debe completar el campo Precio")
            TextBoxPrecio.BackColor = Color.Salmon
            TextBoxPrecio.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxCod_Datos.Text) Then
            MsgBox("Debe completar el campo Cod de Datos")
            TextBoxCod_Datos.BackColor = Color.Salmon
            TextBoxCod_Datos.Focus()
            Return True
        ElseIf String.IsNullOrWhiteSpace(TextBoxStock.Text) Then
            MsgBox("Debe completar el campo Stock")
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

End Class