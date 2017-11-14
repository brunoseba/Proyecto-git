Public Class CuadroReporteSuper

    Private Sub CuadroReporteSuper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            ReportSuper1.Visible = True
            ReportSuper2.Visible = False
            ReportSuper3.Visible = False
            'TODO: esta línea de código carga datos en la tabla 'DataSet1.SuperMejoresVendedore' Puede moverla o quitarla según sea necesario.
            Me.SuperMejoresVendedoreTableAdapter.Fill(Me.DataSet1.SuperMejoresVendedore)

            Me.ReportSuper1.RefreshReport()

        ElseIf RadioButton2.Checked = True Then
            ReportSuper1.Visible = False
            ReportSuper2.Visible = True
            ReportSuper3.Visible = False
            'TODO: esta línea de código carga datos en la tabla 'DataSet1.SuperMejorCliente' Puede moverla o quitarla según sea necesario.
            Me.SuperMejorClienteTableAdapter.Fill(Me.DataSet1.SuperMejorCliente)

            Me.ReportSuper2.RefreshReport()

        ElseIf RadioButton3.Checked = True Then
            ReportSuper1.Visible = False
            ReportSuper2.Visible = False
            ReportSuper3.Visible = True
            'TODO: esta línea de código carga datos en la tabla 'DataSet1.SuperFormasPago' Puede moverla o quitarla según sea necesario.
            Me.SuperFormasPagoTableAdapter.Fill(Me.DataSet1.SuperFormasPago, DateTimePicker1.Text, DateTimePicker2.Text)

            Me.ReportSuper3.RefreshReport()

        End If
    End Sub
End Class