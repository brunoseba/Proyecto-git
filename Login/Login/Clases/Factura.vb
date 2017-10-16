Public Class Facturas
    Private factura_num As Integer
    Private clienteCuil As Long
    Private empresaCuil As Long
    Private userDni As Integer
    Private fecha As String
    Private tipoPago As String
    Private estado As Char
    Private total As Long

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(ByVal f_numFactura As Integer, ByRef f_clienteCuil As Long, ByRef f_empresaCuil As Long, ByVal f_userDni As Integer, ByVal f_fecha As String, ByVal f_tipoPago As String, ByVal f_estado As Char, ByVal f_total As Long)
        SetFacturaNum(f_numFactura)
        SetClienteCuil(f_clienteCuil)
        SetEmpresaCuil(f_empresaCuil)
        SetUserDni(f_userDni)
        SetFechaFactura(f_fecha)
        SetTipoPago(f_tipoPago)
        SetEstadoFactura(f_estado)
        SetTotal(f_total)
    End Sub

    Public Sub New(ByVal f_numFactura As Integer)
        SetFacturaNum(f_numFactura)
        SetClienteCuil("")
        SetEmpresaCuil("")
        SetUserDni("")
        SetFechaFactura("")
        SetTipoPago("")
        SetEstadoFactura("")
        SetTotal("")
    End Sub
#End Region

#Region "SET/GET"

    Private Sub SetFacturaNum(ByVal f_facturaNum As Integer)
        factura_num = f_facturaNum
    End Sub
    Private Sub SetClienteCuil(ByVal f_clinteCuil As Long)
        clienteCuil = f_clinteCuil
    End Sub
    Private Sub SetEmpresaCuil(ByVal f_empresaCuil As Long)
        empresaCuil = f_empresaCuil
    End Sub
    Private Sub SetUserDNi(ByVal f_userDni As Integer)
        userDni = f_userDni
    End Sub
    Private Sub SetFechaFactura(ByVal f_fechaFactura As String)
        fecha = f_fechaFactura
    End Sub
    Private Sub SetTipoPago(ByVal f_tipoPago As String)
        tipoPago = f_tipoPago
    End Sub
    Private Sub SetEstadoFactura(ByVal f_estado As Char)
        estado = f_estado
    End Sub
    Private Sub SetTotal(ByVal f_total As Long)
        total = f_total
    End Sub

    Public Function GetNumFactura()
        Return factura_num
    End Function
    Public Function GetClienteCuil()
        Return clienteCuil
    End Function
    Public Function GetEmpresaCuil()
        Return empresaCuil
    End Function
    Public Function GetUserDni()
        Return userDni
    End Function
    Public Function GetFecha()
        Return fecha
    End Function
    Public Function GetTipoPago()
        Return tipoPago
    End Function
    Public Function GetEstado()
        Return estado
    End Function
    Public Function GetTotal()
        Return total
    End Function
#End Region

#Region "Procedimientos"

#End Region

End Class
