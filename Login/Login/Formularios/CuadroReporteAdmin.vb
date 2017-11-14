Public Class CuadroReporteAdmin

    Private Sub CuadroReporteAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            ReportAdmin1.Visible = True
            ReportAdmin2.Visible = False
            ReportAdmin3.Visible = False
            'TODO: esta línea de código carga datos en la tabla 'DataSet1.AdminProdMasVendidos' Puede moverla o quitarla según sea necesario.
            Me.AdminProdMasVendidosTableAdapter.Fill(Me.DataSet1.AdminProdMasVendidos, DateTimePicker1.Text, DateTimePicker2.Text)

            Me.ReportAdmin1.RefreshReport()

        ElseIf RadioButton2.Checked = True Then
            ReportAdmin1.Visible = False
            ReportAdmin2.Visible = True
            ReportAdmin3.Visible = False
            'TODO: esta línea de código carga datos en la tabla 'DataSet1.AdminUsuarios' Puede moverla o quitarla según sea necesario.
            Me.AdminUsuariosTableAdapter.Fill(Me.DataSet1.AdminUsuarios)

            Me.ReportAdmin2.RefreshReport()

        ElseIf RadioButton3.Checked = True Then
            ComboBox1.Visible = True
            ReportAdmin1.Visible = False
            ReportAdmin2.Visible = False
            ReportAdmin3.Visible = True
            'TODO: esta línea de código carga datos en la tabla 'DataSet1.AdminProdRodado' Puede moverla o quitarla según sea necesario.
            Me.AdminProdRodadoTableAdapter.Fill(Me.DataSet1.AdminProdRodado, ComboBox1.SelectedItem)
            'TODO: esta línea de código carga datos en la tabla 'DataSet1.AdminMontoRodado' Puede moverla o quitarla según sea necesario.
            Me.AdminMontoRodadoTableAdapter.Fill(Me.DataSet1.AdminMontoRodado, DateTimePicker1.Text, DateTimePicker2.Text)

            Me.ReportAdmin3.RefreshReport()

        End If
    End Sub
End Class