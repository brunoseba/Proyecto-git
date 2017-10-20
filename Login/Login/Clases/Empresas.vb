Public Class Empresa
    Private emp_cuit As Long
    Private emp_nombre As String
    Private emp_direccion As String
    Private emp_email As String
    Private emp_telefono As String

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
        emp_cuit = e_cuit
    End Sub

    Private Sub SetNom(ByVal e_nom As String)
        emp_nombre = e_nom
    End Sub

    Private Sub SetDireccion(ByVal e_direc As String)
        emp_direccion = e_direc
    End Sub

    Private Sub SetTelefono(ByVal e_tel As String)
        emp_telefono = e_tel
    End Sub

    Private Sub SetEmail(ByVal e_email As String)
        emp_email = e_email
    End Sub

    Public Function GetCuit()
        Return emp_cuit
    End Function

    Public Function GetNom()
        Return emp_nombre
    End Function

    Public Function GetDireccion()
        Return emp_direccion
    End Function

    Public Function GetTelefono()
        Return emp_telefono
    End Function

    Public Function GetEmail()
        Return emp_email
    End Function

#End Region

#Region "Metodos"
    Function MostrarDatosEmpresa()
        Try
            Using Base As New NNeumaticosEntities1
                Dim empConsulta As Empresa = (From e In Base.Empresa Select e).First()
                SetCUIT(empConsulta.empresa_cuit)
                SetNom(empConsulta.empresa_nombre)
                SetDireccion(empConsulta.empresa_direccion)
                SetEmail(empConsulta.empresa_email)
                SetTelefono(empConsulta.empresa_telefono)
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function ActualizarDatos(ByVal p_cuit As Long, ByVal p_nombre As String, ByVal p_direccion As String, ByVal p_email As String, ByVal p_telefono As String)
        Try

            Using Base As New NNeumaticosEntities1
                Dim modif = (From q In Base.Empresa Where (q.empresa_cuit = p_cuit) Select q).First
                modif.empresa_cuit = p_cuit
                modif.empresa_nombre = p_nombre
                modif.empresa_direccion = p_direccion
                modif.empresa_email = p_email
                modif.empresa_telefono = p_telefono
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region
End Class
