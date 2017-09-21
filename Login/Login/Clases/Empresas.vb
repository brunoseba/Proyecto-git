Public Class Empresas
    Private empresa_cuit As Long
    Private empresa_nombre As String
    Private empresa_direccion As String
    Private empresa_email As String
    Private empresa_telefono As String

#Region "Constructores"
    Public Sub New()

    End Sub

    Public Sub New(ByVal e_cuit As Long, ByVal e_nom As String, ByVal e_direc As String, ByVal e_email As String, ByVal e_telefono As String)
        SetCUIT(e_cuit)
        SetNom(e_nom)
        SetDireccion(e_direc)
        SetEmail(e_email)
        SetTelefono(e_telefono)
    End Sub

#End Region

#Region "Set/Get"

    Private Sub SetCUIT(ByVal e_cuit As Long)
        empresa_cuit = e_cuit
    End Sub

    Private Sub SetNom(ByVal e_nom As String)
        empresa_nombre = e_nom
    End Sub

    Private Sub SetDireccion(ByVal e_direc As String)
        empresa_direccion = e_direc
    End Sub

    Private Sub SetTelefono(ByVal e_tel As String)
        empresa_telefono = e_tel
    End Sub

    Private Sub SetEmail(ByVal e_email As String)
        empresa_email = e_email
    End Sub

    Public Function GetCuit()
        Return empresa_cuit
    End Function

    Public Function GetNom()
        Return empresa_nombre
    End Function

    Public Function GetDireccion()
        Return empresa_direccion
    End Function

    Public Function GetTelefono()
        Return empresa_telefono
    End Function

    Public Function GetEmail()
        Return empresa_email
    End Function

#End Region

#Region "Metodos"
    Function Mostrar()
        Try
            Using Base As New NNeumaticosEntities1
                Dim empConsulta = (From q In Base.Cliente Select q).ToList
                Return empConsulta
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

End Class
