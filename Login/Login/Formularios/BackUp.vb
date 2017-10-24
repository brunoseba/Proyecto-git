Imports System.Data.SqlClient
Imports System.Data.Linq


Public Class BackUp

    Private Sub BExamina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExamina.Click
        'OpenFileDialog1.Filter = "BAK|*.bak"

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TRuta.Text = FolderBrowserDialog1.SelectedPath
            'PImagen.ImageLocation = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub BCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancela.Click
        Me.Close()
    End Sub


#Region "Conexion"

    Private Sub BAcepta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAcepta.Click
        
        If TNombre.Text = "" Then
            MsgBox("Seleccione una ruta donde Guardar", 0 + 0 + 48, "Atencion")

        ElseIf TRuta.Text = "" Then
            MsgBox("Seleccione una ruta donde Guardar..", 0 + 0 + 48, "Atencion")

        Else
            If generaBak() = True Then
                TRuta.Clear()
                TNombre.Clear()
                MsgBox("Se ha generado Correctamente Backup", 0 + 0 + 64, "Guardado")
            Else
                MsgBox("Ocurrio un error")
            End If
        End If
    End Sub

    Public Function generaBak() As Boolean
        Dim mes As String = Now.Month
        Dim anio As String = Now.Year
        Try
            Using cnn As SqlConnection = New SqlConnection("server=(local)\SQLEXPRESS;database=NNeumaticos;integrated security=true")
                Dim valor As String
                valor = TRuta.Text + "\" + TNombre.Text
                cnn.Open()
                Dim cmd As SqlCommand = New SqlCommand("BackUpCompleto ", cnn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@ruta", valor)


                cmd.ExecuteNonQuery()
                cnn.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

End Class