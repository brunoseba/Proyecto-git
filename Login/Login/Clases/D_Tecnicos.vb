Public Class D_Tecnicos
    Private codigo As Integer
    Private medida As String
    Private indCarga As Integer
    Private velocidad As String
    Private revPorKm As Integer
    Private anchoLlanta As Double
    Private anchoSesion As Integer
    Private diametro As Integer

#Region "Constructores"
    Public Sub New()

    End Sub

    Public Sub New(ByVal d_codigo As Integer, ByVal d_medida As String, ByVal d_indCarga As Integer, ByVal d_velocidad As String, ByVal d_revPorKm As Integer, ByVal d_anchoLlanta As Double, ByVal d_anchoSesion As Integer, ByVal d_diametro As Integer)
        SetCodigo(d_codigo)
        SetMedida(d_medida)
        SetIndCarga(d_indCarga)
        SetVelocidad(d_velocidad)
        SetRevPorKm(d_revPorKm)
        SetAnchoLlanta(d_anchoLlanta)
        SetAnchoSesion(d_anchoSesion)
        SetDiametro(d_diametro)
    End Sub
#End Region

#Region "Setter"
    Private Sub SetCodigo(ByVal d_codigo As Integer)
        codigo = d_codigo
    End Sub
    Private Sub SetMedida(ByVal d_medida As String)
        medida = d_medida
    End Sub
    Private Sub SetIndCarga(ByVal d_indCarga As Integer)
        indCarga = d_indCarga
    End Sub
    Private Sub SetVelocidad(ByVal d_velocidad As String)
        velocidad = d_velocidad
    End Sub
    Private Sub SetRevPorKm(ByVal d_revPorKm As Integer)
        revPorKm = d_revPorKm
    End Sub
    Private Sub SetAnchoLlanta(ByVal d_anchoLlanta As Double)
        anchoLlanta = d_anchoLlanta
    End Sub
    Private Sub SetAnchoSesion(ByVal d_anchoSesion As Integer)
        anchoSesion = d_anchoSesion
    End Sub
    Private Sub SetDiametro(ByVal d_diametro As Integer)
        diametro = d_diametro
    End Sub
#End Region

#Region "Getter"
    Public Function GetCodigo()
        Return codigo
    End Function
    Public Function GetMedida()
        Return medida
    End Function
    Public Function GetIndCarga()
        Return indCarga
    End Function
    Public Function GetVelocidad()
        Return velocidad
    End Function
    Public Function GetRevPorKm()
        Return revPorKm
    End Function
    Public Function GetAnchoLlanta()
        Return anchoLlanta
    End Function
    Public Function GetAnchoSesion()
        Return anchoSesion
    End Function
    Public Function GetDiametro()
        Return diametro
    End Function







#End Region

#Region "Procedimientos"
    Public Function MostrarTodosDTecnicos(ByVal dataTecnicos As DataGridView)
        Try
            Using Mostrar As New NNeumaticosEntities1
                Dim mostrarD_Tecnicos = (From q In Mostrar.Datos_Tecnicos
                                         Select Codigo = q.Datos_cod, Medida = q.Datos_Medida, Indice_Carga = q.Datos_IndCarga, Velocidad = q.Datos_Velocidad, Revision_Por_KM = q.Datos_RevPorKm, Ancho_Llanta = q.Datos_AnchoLLanta, Ancho_Sesion = q.Datos_AnchoSecion, Diametro = q.Datos_Diametro)
                dataTecnicos.DataSource = mostrarD_Tecnicos
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function MostrarUnicoDTecnicos(ByVal cod As Integer, ByVal dataTecnicos As DataGridView)
        Try
            Using Mostrar As New NNeumaticosEntities1
                Dim mostrarD_Tecnicos = (From q In Mostrar.Datos_Tecnicos Where (q.Datos_cod = cod)
                                         Select Codigo = q.Datos_cod, Medida = q.Datos_Medida, Indice_Carga = q.Datos_IndCarga, Velocidad = q.Datos_Velocidad, Revision_Por_KM = q.Datos_RevPorKm, Ancho_Llanta = q.Datos_AnchoLLanta, Ancho_Sesion = q.Datos_AnchoSecion, Diametro = q.Datos_Diametro)
                dataTecnicos.DataSource = mostrarD_Tecnicos
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
