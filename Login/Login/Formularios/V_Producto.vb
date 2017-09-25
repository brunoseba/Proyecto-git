Public Class V_Producto

    'Procedimiento cuando carga la ventana Principal'
    Private Sub Vendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataGridViewDatosCodigo.Rows.Add("1", "LT215/75R15", "1", "S180", "466", "6", "216", "703")
        Me.DataGridViewDatosCodigo.Rows.Add("2", "LT235/75R15", "1", "R 170", "447", "6,5", "235", "733")
        Me.DataGridViewDatosCodigo.Rows.Add("3", "215/80R16", "107", "S 180", "437", "6", "216", "751")
        Me.DataGridViewDatosCodigo.Rows.Add("4", "235/75R15", "108", "S 180", "447", "6,5", "235", "733")
        Me.DataGridViewDatosCodigo.Rows.Add("5", "31x10,5R", "109", "S 180", "423", "8,5", "268", "775")
        Me.DataGridViewDatosCodigo.Rows.Add("6", "LT255/75R15", "1", "S 180", "430", "7", "255", "763")
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
        OpenFileDialog1.Filter = "Jpg|*.jpg|Bmp|*.bmp|Png|*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            LabelRutaArchivo.Text = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregarProducto.Click
        Dim prod As New Productos(TextBoxNombreProducto.Text, ComboBoxRodadoProducto.SelectedItem, ComboBoxMedidaProducto.SelectedItem, Val(TextBoxPrecio.Text), Val(TextBoxCod_Datos.Text), Val(TextBoxStock.Text), LabelRutaArchivo.Text, "A", ComboBoxTipoVehiculo.SelectedItem)
        Dim res, res2 As MsgBoxResult
        res = MsgBox("Desea Agregar un nuevo Producto?", 4 + 0 + 32, "Aviso")
        If res = vbYes Then
            prod.AgregarProducto()
            MsgBox("Producto Agregado", 0 + 0 + 64)
            res2 = MsgBox("¿Desea Agregar un otro Producto?", 4 + 0 + 32, "Aviso")
            If res2 = vbYes Then
                TextBoxNombreProducto.Text = ""
                TextBoxCod_Datos.Text = ""
                TextBoxStock.Text = ""
                TextBoxPrecio.Text = ""
            Else
                Me.Close()
            End If
        Else
            MsgBox("No se agrego el Producto", 0 + 0 + 64)
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class