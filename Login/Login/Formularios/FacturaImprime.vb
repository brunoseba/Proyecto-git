Public Class FacturaImprime

    Private Sub FacturaImprime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fatura As New Facturas
        Dim ultimaFactura, numero As Integer
        ultimaFactura = fatura.ObtenerUltimaFactura()

        numero = Ventana.numeroFac()

        Me.TraigoFacturaTableAdapter1.Fill(Me.DataSet11.TraigoFactura, numero)

        Me.TraigoDetalleTableAdapter1.Fill(Me.DataSet11.TraigoDetalle, numero)

        Me.TraigoVendedorTableAdapter1.Fill(Me.DataSet11.TraigoVendedor, Ventana.DniToolStripMenuItem.Text)

        Me.ReportFactura.RefreshReport()
    End Sub

    Private Sub BSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

End Class