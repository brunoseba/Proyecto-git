Imports System.Data.SqlClient
Imports System.Data.Linq



Public Class Backup

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
            MsgBox("Coloque un nombre ", 0 + 0 + 48, "Atencion")

        ElseIf TRuta.Text = "" Then
            MsgBox("Seleccione una ruta donde Guardar..", 0 + 0 + 48, "Atencion")

        Else
            If generaBack() = True Then
                TRuta.Clear()
                TNombre.Clear()
                MsgBox("Se ha generado Correctamente Backup", 0 + 0 + 64, "Guardado")
            Else
                MsgBox("Ocurrio un error")
            End If
        End If
    End Sub

    'Public Function generaBak() As Boolean
    'Dim mes As String = Now.Month
    'Dim anio As String = Now.Year
    'Try
    'Using cnn As SqlConnection = New SqlConnection("server=(local)\SQLEXPRESS;database=NNeumaticos;integrated security=true")
    'Dim valor As String
    'valor = TRuta.Text + "\" + TNombre.Text
    'cnn.Open()
    'Dim cmd As SqlCommand = New SqlCommand("BackUpCompleto ", cnn)
    'cmd.CommandType = CommandType.StoredProcedure

    'cmd.Parameters.AddWithValue("@ruta", valor)


    'cmd.ExecuteNonQuery()
    'cnn.Close()
    'End Using
    'Return True
    'Catch ex As Exception
    'Return False
    'End Try
    'End Function




    Public Function generaBack()
        Dim usu As New Ususario
        Dim valor As String
        valor = TRuta.Text + "\" + TNombre.Text

        usu.Back(valor)
        Return True

    End Function

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'OpenFileDialog1.Filter = "Jpg|*.jpg|Bmp|*.bmp|Png|*.png"

        'If OpenFileDialog1.ShowDialog = DialogResult.OK Then
        'TDireccion.Text = OpenFileDialog1.FileName

        OpenFileDialog1.Filter = "BAK|*.bak"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            TRuta2.Text = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TRuta2.Text = "" Then
            MsgBox("Seleccione donde Cargar una ruta ", 0 + 0 + 48, "Atencion")

        Else
            If restaura() = True Then
                TRuta2.Clear()
                MsgBox("Se ha generado Correctamente la Restauracion", 0 + 0 + 64, "Reestablecido")
            Else
                MsgBox("Ocurrio un error")

            End If
        End If

    End Sub


    Private Function restaura()
        'Try
        Dim conexion As New SqlConnection("server=(local)\SQLEXPRESS;database=NNeumaticos;integrated security=true; user id=Bruno-PC\Bruno")
        conexion.Open()

        Dim Alter1 As String = "ALTER DATABASE [NNeumaticos] SET SINGLE_USER WITH ROLLBACK IMMEDIATE"
        Dim comandoA As SqlCommand = New SqlCommand(Alter1, conexion)
        comandoA.ExecuteNonQuery()


        Dim master As String = "USE MASTER RESTORE DATABASE [NNeumaticos] FROM DISK='" + TRuta2.Text + "' WITH REPLACE"
        Dim comandoB As SqlCommand = New SqlCommand(master, conexion)
        comandoB.ExecuteNonQuery()

        Dim Alter2 As String = "ALTER DATABASE [NNeumaticos] SET MULTI_USER"
        Dim comandoC As SqlCommand = New SqlCommand(Alter2, conexion)
        comandoC.ExecuteNonQuery()

        conexion.Close()
        'End Using
        Return True
        'Catch ex As Exception
        'Return False

        'End Try

    End Function



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class