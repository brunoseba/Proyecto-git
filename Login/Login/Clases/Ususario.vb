Public Class Ususario
    Private dni As Integer
    Private nomYape As String
    Private direccion As String
    Private localidad As String
    Private provincia As String
    Private telefono As String
    Private email As String
    Private contraseña As String
    Private estado As Char
    Private tipoUsu As Char
    Private fecha As String
    Private ape As String

#Region "Constructores"
    Public Sub New()
    End Sub

    Public Sub New(ByVal u_dni As Integer)
        SetDni(u_dni)
        SetContraseña("")
        SetNomYape("")
        SetDireccion("")
        SetLocalidad("")
        SetProvincia("")
        SetTelefono("")
        SetEmail("")
        SetEstado("")
        SetTipoUsu("")
        SetFecha("")
    End Sub

    Public Sub New(ByVal u_dni As Integer, ByVal u_contraseña As String)
        SetDni(u_dni)
        SetContraseña(u_contraseña)
        SetNomYape("")
        SetDireccion("")
        SetLocalidad("")
        SetProvincia("")
        SetTelefono("")
        SetEmail("")
        SetEstado("")
        SetTipoUsu("")
        SetFecha("")
    End Sub

    Public Sub New(ByVal u_dni As Integer, ByVal u_nomYape As String, ByVal u_direccion As String, ByVal u_localidad As String, ByVal u_provincia As String, ByVal u_telefono As String, ByVal u_email As String, ByVal u_contraseña As String, ByVal u_estado As Char, ByVal u_tipoUsu As Char, ByVal u_fecha As String, ByVal u_ape As String)
        SetDni(u_dni)
        SetNomYape(u_nomYape)
        SetDireccion(u_direccion)
        SetLocalidad(u_localidad)
        SetProvincia(u_provincia)
        SetTelefono(u_telefono)
        SetEmail(u_email)
        SetContraseña(u_contraseña)
        SetEstado(u_estado)
        SetTipoUsu(u_tipoUsu)
        SetFecha(u_fecha)
        SetApe(u_ape)
    End Sub
#End Region

#Region "Get/Set"

#Region "Get"

    Public Function GetDni()
        Return dni
    End Function

    Public Function GetNomYape()
        Return nomYape
    End Function

    Public Function GetDireccion()
        Return direccion
    End Function

    Public Function GetLocalidad()
        Return localidad
    End Function

    Public Function GetProvincia()
        Return provincia
    End Function

    Public Function GetTelefono()
        Return telefono
    End Function

    Public Function GetEmail()
        Return email
    End Function

    Public Function GetContraseña()
        Return contraseña
    End Function

    Public Function GetEstado()
        Return estado
    End Function

    Public Function GetTipoUsu()
        Return tipoUsu
    End Function

    Public Function GetFecha()
        Return fecha
    End Function

    Public Function GetApe()
        Return ape
    End Function

#End Region
#Region "Set"

    Private Sub SetDni(ByVal u_dni As String)
        dni = u_dni
    End Sub

    Private Sub SetNomYape(ByVal u_nomYape As String)
        nomYape = u_nomYape
    End Sub

    Private Sub SetDireccion(ByVal u_direccion As String)
        direccion = u_direccion
    End Sub

    Private Sub SetLocalidad(ByVal u_localidad As String)
        localidad = u_localidad
    End Sub

    Private Sub SetProvincia(ByVal u_provincia As String)
        provincia = u_provincia
    End Sub

    Private Sub SetTelefono(ByVal u_telefono As String)
        telefono = u_telefono
    End Sub

    Private Sub SetEmail(ByVal u_email As String)
        email = u_email
    End Sub

    Private Sub SetContraseña(ByVal u_contraseña As String)
        contraseña = u_contraseña
    End Sub

    Private Sub SetEstado(ByVal u_estado As Char)
        estado = u_estado
    End Sub

    Private Sub SetTipoUsu(ByVal u_tipoUsu As Char)
        tipoUsu = u_tipoUsu
    End Sub

    Private Sub SetFecha(ByVal u_fecha As String)
        fecha = u_fecha
    End Sub

    Private Sub SetApe(ByVal u_ape As String)
        ape = u_ape
    End Sub
#End Region


#End Region

#Region "Procedimientos"
    '---AGREGA USUARIO---
    Public Function AgregarUsuario()
        Try
            Using Base As New NNeumaticosEntities1

                Dim consulta = New Usuario With
                {
                .usu_Dni = GetDni(),
                .usu_nomYape = GetNomYape(),
                .usu_Direccon = GetDireccion(),
                .usu_Localidad = GetLocalidad(),
                .usu_Provincia = GetProvincia(),
                .usu_Telefono = GetTelefono(),
                .usu_Email = GetEmail(),
                .usu_Contraseña = GetContraseña(),
                .usu_Estado = GetEstado(),
                .usu_TipoUsu = GetTipoUsu(),
                .usu_Fecha = GetFecha(),
                .usu_ape = GetApe()
                }
                Base.Usuario.AddObject(consulta)
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '--- Verifica si esta en la base de datos el USER Y PASS para ingresar al sistema ---
    Public Function Verificar_Ingreso(ByVal u_dni As Integer, ByVal u_contra As String)
        Try
            Using Consulta As New NNeumaticosEntities1
                Dim objMostrar = (From q In Consulta.Usuario Where (q.usu_Dni = u_dni And q.usu_Contraseña = u_contra And q.usu_Estado = "a")
                                  Select q).First
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '-- Verifica si existe el dni antes de agregar uno nuevo ---
    Public Function Verificar_Existencia(ByVal u_dni As Integer)
        Try
            Using Consulta As New NNeumaticosEntities1
                Dim objMostrar = (From q In Consulta.Usuario Where (q.usu_Dni = u_dni) Select q).First
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '---borrado logico (BAJA)----
    Public Sub EliminaUsuario(ByVal usua_dni As Integer, ByVal usu_estado As Char)
        Try
            Using Base As New NNeumaticosEntities1
                Dim borra = (From u In Base.Usuario Where (usua_dni = u.usu_Dni)
                Select u).First
                borra.usu_Estado = usu_estado
                Base.SaveChanges()
            End Using
        Catch ex As Exception
        End Try
    End Sub

    '-- Buscar el usuario por DNI'
    Public Sub BuscarPorDni(ByVal p_dni As Integer, ByVal p_resultado As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim consulta = (From u In Base.Usuario Where (u.usu_Dni = p_dni) Select New With {.DNI = u.usu_Dni, .Nombre = u.usu_nomYape, .Apellido = u.usu_ape, .Direccion = u.usu_Direccon, .Localidad = u.usu_Localidad, .Provincia = u.usu_Provincia, .Telefono = u.usu_Telefono, .Email = u.usu_Email, .Contraseña = u.usu_Contraseña, .Estado = u.usu_Estado, .Tipo_Usuario = u.usu_TipoUsu}).ToList
                p_resultado.DataSource = consulta
            End Using
        Catch ex As Exception

        End Try
    End Sub

    '-- Modificar Usuario'
    Public Function ModificarUsuario(ByVal u_dni As Integer, ByVal u_nomYape As String, ByVal u_direccion As String, ByVal u_localidad As String, ByVal u_provincia As String, ByVal u_telefono As String, ByVal u_email As String, ByVal u_contraseña As String, ByVal u_estado As Char, ByVal u_tipoUsu As Char, ByVal u_fecha As String, ByVal u_ape As String)
        Try
            Using Base As New NNeumaticosEntities1
                Dim modificar = (From u In Base.Usuario Where (u.usu_Dni = u_dni) Select u).First
                modificar.usu_Dni = u_dni
                modificar.usu_nomYape = u_nomYape
                modificar.usu_Direccon = u_direccion
                modificar.usu_Localidad = u_localidad
                modificar.usu_Provincia = u_provincia
                modificar.usu_Telefono = u_telefono
                modificar.usu_Email = u_email
                modificar.usu_Contraseña = u_contraseña
                modificar.usu_Estado = u_estado
                modificar.usu_TipoUsu = u_tipoUsu
                modificar.usu_Fecha = u_fecha
                modificar.usu_ape = u_ape
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Metodos que no se jaaj'
    Public Sub Dato(ByVal dni As Integer, ByVal nombre As String)
        Try
            Using Base As New NNeumaticosEntities1
                Dim trae = (From u In Base.Usuario Where (u.usu_Dni = dni Or u.usu_nomYape = nombre)
                           Select u).First
                SetDni(trae.usu_Dni)
                SetNomYape(trae.usu_nomYape)
                SetDireccion(trae.usu_Direccon)
                SetLocalidad(trae.usu_Localidad)
                SetProvincia(trae.usu_Provincia)
                SetTelefono(trae.usu_Telefono)
                SetEmail(trae.usu_Email)
                SetContraseña(trae.usu_Contraseña)
                SetEstado(trae.usu_Estado)
                SetTipoUsu(trae.usu_TipoUsu)
                SetFecha(trae.usu_Fecha)
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub muestra(ByVal tabla As DataGridView, ByVal u_dni As Integer, ByVal nombre As String, ByVal usu As Char)
        Try
            Using Base As New NNeumaticosEntities1
                Dim mues = (From u In Base.Usuario Where (u.usu_Dni = u_dni Or u.usu_nomYape = nombre Or u.usu_TipoUsu = usu)
                            Select Dni = u.usu_Dni, NombreyApellido = u.usu_nomYape & u.usu_ape, Direccion = u.usu_Direccon, Localidad = u.usu_Localidad, Telefono = u.usu_Telefono, Email = u.usu_Email, Contraseña = u.usu_Contraseña, Estado = u.usu_Estado, TipoUsuario = u.usu_TipoUsu).ToList
                tabla.DataSource = mues
            End Using
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class