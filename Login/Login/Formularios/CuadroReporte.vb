Public Class CuadroReporte

    Private Sub CuadroReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.VendedorVentasDia' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ProFacturaPrue2' Puede moverla o quitarla según sea necesario.
        'Me.ReportViewer1.LocalReport.ReportEmbeddedResource
        'Me.ReportViewer1.LocalReport.ReportPath = Login.ReporteVende.rdlc

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DateTimePicker1.Text = DateTimePicker2.Text Then
            ReportViewer1.Visible = False
            ReportViewer2.Visible = True


            Me.VendedorVentasDiaTableAdapter.Fill(Me.DataSet1.VendedorVentasDia, Ventana.DniToolStripMenuItem.Text, DateTimePicker1.Text)

            Me.ReportViewer2.RefreshReport()

        Else
            ReportViewer1.Visible = True
            ReportViewer2.Visible = False

            'TODO: esta línea de código carga datos en la tabla 'DataSet1.FacturaVendedor' Puede moverla o quitarla según sea necesario.
            Me.FacturaVendedorTableAdapter.Fill(Me.DataSet1.FacturaVendedor, Ventana.DniToolStripMenuItem.Text, DateTimePicker1.Text, DateTimePicker2.Text)


            Me.ReportViewer1.RefreshReport()
            'Me.ProFacturaPrue2TableAdapter.Fill(Me.DataSet1.ProFacturaPrue2, Ventana.DniToolStripMenuItem.Text, DateTimePicker1.Text, DateTimePicker2.Text)

            'Me.ReportViewer1.RefreshReport()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    'Public Sub tipoReporte()
    ' if 
    'End Sub




End Class