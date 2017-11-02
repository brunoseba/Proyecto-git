Public Class V_Factura


    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub ButtonAceptarF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptarF.Click
        Me.Close()
    End Sub

    Private Sub ButtonAceptarCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptarCF.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fatura As New Facturas()
        If fatura.anularFactura(TextBoxBuscarFacturaCancelar.Text) Then
            MsgBox("La factura se anuló Correctamente", 64, "Atención")
        Else
            MsgBox("No se pudo anular la factura, el número de factura ingresado no existe", 64, "Atención")
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

    Private Sub TextBoxBuscarFacturaCancelar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxBuscarFacturaCancelar.KeyPress
        Me.ComprobarNumero(e)
    End Sub

    Private Sub TextBoxInformeNFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ComprobarNumero(e)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ComprobarNumero(e)
    End Sub

    Private Sub TextBoxInformeNFactura_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxInformeNFactura.KeyPress, TextBox3.KeyPress, TextBox2.KeyPress
        Me.ComprobarNumero(e)
    End Sub

    Private Sub TextBoxInformeNFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxInformeNFactura.TextChanged
        Dim fact As New Facturas()
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBoxTipoPago.SelectedIndex = 0
        If TextBoxInformeNFactura.Text = "" Then
            fact.MostrarTodasFacturas(Me.DataGridView1)
            For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                If fila.Cells("Estado").Value = "Anulada" Then
                    fila.Cells("Estado").Style.BackColor = Color.Tomato
                End If
            Next
        Else
            fact.buscarPorNumeroFactura(TextBoxInformeNFactura.Text, DataGridView1)
            For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                If fila.Cells("Estado").Value = "Anulada" Then
                    fila.Cells("Estado").Style.BackColor = Color.Tomato
                End If
            Next
        End If
    End Sub
    Private Sub V_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxTipoPago.SelectedIndex = 0
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim fact As New Facturas()
        TextBoxInformeNFactura.Text = ""
        TextBox3.Text = ""
        ComboBoxTipoPago.SelectedIndex = 0
        If TextBox2.Text = "" Then
            fact.MostrarTodasFacturas(Me.DataGridView1)
            For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                If fila.Cells("Estado").Value = "Anulada" Then
                    fila.Cells("Estado").Style.BackColor = Color.Tomato
                End If
            Next
        Else
            fact.buscarPorDniVendedor(TextBox2.Text, DataGridView1)
            For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                If fila.Cells("Estado").Value = "Anulada" Then
                    fila.Cells("Estado").Style.BackColor = Color.Tomato
                End If
            Next
        End If
    End Sub

   
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim fact As New Facturas()
        TextBoxInformeNFactura.Text = ""
        TextBox2.Text = ""
        ComboBoxTipoPago.SelectedIndex = 0
        If TextBox3.Text = "" Then
            fact.MostrarTodasFacturas(Me.DataGridView1)
            For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                If fila.Cells("Estado").Value = "Anulada" Then
                    fila.Cells("Estado").Style.BackColor = Color.Tomato
                End If
            Next
        Else
            fact.buscarPorCliente(TextBox3.Text, DataGridView1)
            For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                If fila.Cells("Estado").Value = "Anulada" Then
                    fila.Cells("Estado").Style.BackColor = Color.Tomato
                End If
            Next
        End If
    End Sub

    Private Sub ComboBoxTipoPago_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTipoPago.SelectionChangeCommitted
        Dim fact As New Facturas()
        TextBoxInformeNFactura.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        If ComboBoxTipoPago.SelectedIndex = 0 Then
            fact.MostrarTodasFacturas(Me.DataGridView1)
            For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                If fila.Cells("Estado").Value = "Anulada" Then
                    fila.Cells("Estado").Style.BackColor = Color.Tomato
                End If
            Next
        Else
            fact.mostrarTipoPago(ComboBoxTipoPago.SelectedItem, DataGridView1)
            For Each fila As DataGridViewRow In Me.DataGridView1.Rows
                If fila.Cells("Estado").Value = "Anulada" Then
                    fila.Cells("Estado").Style.BackColor = Color.Tomato
                End If
            Next
        End If
    End Sub

    Private Sub DateTimeFDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimeFHasta.ValueChanged, DateTimeFDesde.ValueChanged
        Dim fact As New Facturas()
        TextBoxInformeNFactura.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBoxTipoPago.SelectedIndex = 0
        fact.mostrarPorFecha(DateTimeFDesde.Text, DateTimeFHasta.Text, DataGridView1)
        For Each fila As DataGridViewRow In Me.DataGridView1.Rows
            If fila.Cells("Estado").Value = "Anulada" Then
                fila.Cells("Estado").Style.BackColor = Color.Tomato
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridView1.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridView1.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Ver_detalles"
                        Dim deta As New Detalles()
                        deta.MostrarTodosProductos(DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value, Me.DataGridView2)
                        Exit Select
                End Select
            End If
        End If
    End Sub

    Private Sub TextBoxBuscarFacturaCancelar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscarFacturaCancelar.TextChanged
        Dim fact As New Facturas()
        If TextBoxBuscarFacturaCancelar.Text <> "" Then
            fact.buscarPorNumeroFactura(TextBoxBuscarFacturaCancelar.Text, DataGridCFProductos)
        For Each fila As DataGridViewRow In Me.DataGridCFProductos.Rows
            If fila.Cells("Estado").Value = "Anulada" Then
                fila.Cells("Estado").Style.BackColor = Color.Tomato
            End If
            Next
        End If

    End Sub

    Private Sub DataGridCFProductos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridCFProductos.CellContentClick
        Dim cell As DataGridViewButtonCell = TryCast(Me.DataGridCFProductos.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(Me.DataGridCFProductos.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "CF_Producto"
                        Dim deta As New Detalles()
                        deta.MostrarTodosProductos(DataGridCFProductos.Item(1, DataGridCFProductos.CurrentRow.Index).Value, Me.DataGridView3)
                        Exit Select
                End Select
            End If
        End If
    End Sub
End Class