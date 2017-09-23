Public Class Cliente

    Private cliente_id As Integer
    Private nomYape As String
    Private direccion As String
    Private telefono As String
    Private email As String
    Private estado As Char
    Private ape As String
    Private localidad As String
    Private provincia As String
    Private fecha As String
    Private postal As String
    Private celular As String

#Region "Constructore"

    Public Sub New()

    End Sub


    Public Sub New(ByVal c_id As Long, ByVal c_nomYape As String, ByVal c_direc As String, ByVal c_tel As String, ByVal c_email As String, ByVal c_estado As Char, ByVal c_ape As String, ByVal c_local As String, ByVal c_prov As String, ByVal c_fecha As String, ByVal c_postal As String, ByVal c_celu As String)

        SetID(c_id)
        SetNomYape(c_nomYape)
        SetDireccion(c_direc)
        SetTelefono(c_tel)
        SetEmail(c_email)
        SetEstado(c_estado)
        SetApe(c_ape)
        SetLocalidad(c_local)
        SetProvincia(c_prov)
        SetFecha(c_fecha)
        SetPostal(c_postal)
        SetCelular(c_celu)

    End Sub

#End Region


#Region "Set/Get"

    Private Sub SetID(ByVal c_id As Long)
        cliente_id = c_id
    End Sub

    Private Sub SetNomYape(ByVal c_nomYape As String)
        nomYape = c_nomYape
    End Sub

    Private Sub SetDireccion(ByVal c_direc As String)
        direccion = c_direc
    End Sub

    Private Sub SetTelefono(ByVal c_tel As String)
        telefono = c_tel
    End Sub

    Private Sub SetEmail(ByVal c_email As String)
        email = c_email
    End Sub

    Private Sub SetEstado(ByVal c_estado As Char)
        estado = c_estado
    End Sub

    Private Sub SetApe(ByVal c_ape As String)
        ape = c_ape
    End Sub

    Private Sub SetLocalidad(ByVal c_local As String)
        localidad = c_local
    End Sub

    Private Sub SetProvincia(ByVal c_prov As String)
        provincia = c_prov
    End Sub

    Private Sub SetFecha(ByVal c_fecha As String)
        fecha = c_fecha
    End Sub

    Private Sub SetPostal(ByVal c_postal As String)
        postal = c_postal
    End Sub

    Private Sub SetCelular(ByVal c_celu As String)
        celular = c_celu
    End Sub



    Public Function GetID()
        Return cliente_id
    End Function

    Public Function GetNomYape()
        Return nomYape
    End Function

    Public Function GetDireccion()
        Return direccion
    End Function

    Public Function GetTelefono()
        Return telefono
    End Function

    Public Function GetEmail()
        Return email
    End Function

    Public Function GetApe()
        Return ape
    End Function

    Public Function GetLocalida()
        Return localidad
    End Function

    Public Function GetProvincia()
        Return provincia
    End Function

    Public Function GetFecha()
        Return fecha
    End Function

    Public Function GetPostal()
        Return postal
    End Function

    Public Function GetCelular()
        Return celular
    End Function

    Public Function GetEstado()
        Return estado
    End Function
#End Region


#Region "Metodos"

    Public Sub Consulta(ByVal cliente As Long)
        Try

            Using Base As New NNeumaticosEntities1
                Dim cliConsul = (From c In Base.Cliente Where (c.cliente_cuil = cliente And c.cliente_estado = "a")
                               Select c).First

            End Using

        Catch ex As Exception

        End Try
    End Sub




    Public Function AgregaCliente()
        Try

            Using Base As New NNeumaticosEntities1
                Dim altas = New Cliente With
                           {.cliente_cuil = GetID(),
                            .cliente_NomYape = GetNomYape(),
                            .cliente_Direccion = GetDireccion(),
                            .cliente_Telefono = GetTelefono(),
                            .cliente_Email = GetEmail(),
                            .cliente_estado = GetEstado(),
                            .cliente_Ape = GetApe(),
                            .cliente_Localidad = GetLocalida(),
                            .cliente_Provincia = GetProvincia(),
                            .cliente_Fecha = GetFecha(),
                            .cliente_Cpostal = GetPostal(),
                            .cliente_Celular = GetCelular()}
                Base.Cliente.AddObject(altas)
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function



    Public Sub ModifCliente(ByVal cliente As Long, ByVal nombe As String, ByVal direc As String, ByVal tel As String, ByVal email As String, ByVal estado As Char, ByVal ape As String, ByVal local As String, ByVal prov As String, ByVal fecha As String, ByVal postal As String, ByVal celu As String)
        Try

            Using Base As New NNeumaticosEntities1
                Dim modifica = (From c In Base.Cliente Where (cliente = c.cliente_cuil)
                                Select c).First
                modifica.cliente_cuil = cliente
                modifica.cliente_Direccion = direc
                modifica.cliente_Telefono = tel
                modifica.cliente_Email = email
                modifica.cliente_estado = estado
                modifica.cliente_Ape = ape
                modifica.cliente_Localidad = local
                modifica.cliente_Provincia = prov
                modifica.cliente_Fecha = fecha
                modifica.cliente_Cpostal = postal
                modifica.cliente_Celular = celu


                Base.SaveChanges()
            End Using

        Catch ex As Exception

        End Try
    End Sub



    Public Sub AltaCliente(ByVal cliente As Long)
        Try
            Using Base As New NNeumaticosEntities1
                Dim alta = (From c In Base.Cliente Where (cliente = c.cliente_cuil And c.cliente_estado = "b")
                            Select c).First

                alta.cliente_estado = "a"
                Base.SaveChanges()
            End Using
        Catch ex As Exception

        End Try
    End Sub



    Public Sub BajaCliente(ByVal cliente As Long)
        Try

            Using Base As New NNeumaticosEntities1
                Dim baja = (From c In Base.Cliente Where (cliente = c.cliente_cuil And c.cliente_estado = "a")
                            Select c).First

                baja.cliente_estado = "b"
                Base.SaveChanges()

            End Using

        Catch ex As Exception

        End Try
    End Sub


#End Region


End Class
