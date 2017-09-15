Public Class Cliente

    Private cliente_id As Integer
    Private nomYape As String
    Private direccion As String
    Private telefono As String
    Private email As String
    Private estado As Char

#Region "Constructore"

    Public Sub New()

    End Sub


    Public Sub New(ByVal c_id As Long, ByVal c_nomYape As String, ByVal c_direc As String, ByVal c_tel As String, ByVal c_email As String, ByVal c_estado As Char)
        SetID(c_id)
        SetNomYape(c_nomYape)
        SetDireccion(c_direc)
        SetTelefono(c_tel)
        SetEmail(c_email)
        SetEstado(c_estado)
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




    Public Sub AgregaCliente()
        Try

            Using Base As New NNeumaticosEntities1
                Dim alta = New Cliente With
                           {.cliente_cuil = GetID(),
                            .cliente_Direccion = GetDireccion(),
                            .cliente_Telefono = GetTelefono(),
                            .cliente_Email = GetEmail(),
                            .cliente_estado = GetEstado()
                           }
                Base.Cliente.AddObject(alta)
                Base.SaveChanges()
            End Using

        Catch ex As Exception

        End Try
    End Sub



    Public Sub ModifCliente(ByVal cliente As Long, ByVal nombe As String, ByVal direc As String, ByVal tel As String, ByVal email As String, ByVal estado As Char)
        Try

            Using Base As New NNeumaticosEntities1
                Dim modifica = (From c In Base.Cliente Where (cliente = c.cliente_cuil)
                                Select c).First
                modifica.cliente_cuil = cliente
                modifica.cliente_Direccion = direc
                modifica.cliente_Telefono = tel
                modifica.cliente_Email = email
                modifica.cliente_estado = estado

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
