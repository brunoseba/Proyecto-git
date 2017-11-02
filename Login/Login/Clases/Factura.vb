Public Class Facturas
    Private factura_num As Integer
    Private clienteCuil As Long
    Private empresaCuil As Long
    Private userDni As Integer
    Private fecha As String
    Private tipoPago As String
    Private estado As String
    Private total As Long

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(ByRef f_clienteCuil As Long, ByRef f_empresaCuil As Long, ByVal f_userDni As Integer, ByVal f_fecha As String, ByVal f_tipoPago As String, ByVal f_estado As String, ByVal f_total As Long)
        SetClienteCuil(f_clienteCuil)
        SetEmpresaCuil(f_empresaCuil)
        SetUserDNi(f_userDni)
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
    Private Sub SetEstadoFactura(ByVal f_estado As String)
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
    Public Function agregarFactura()
        Try
            Using Base As New NNeumaticosEntities1
                Dim agregar = New Factura With
                {
                .cliente_cuil = GetClienteCuil(),
                .empresa_cuit = GetEmpresaCuil(),
                .usu_Dni = GetUserDni(),
                .factura_Fecha = GetFecha(),
                .factura_tipoPago = GetTipoPago(),
                .factura_estado = GetEstado(),
                .factura_Total = GetTotal()}
                Base.Factura.AddObject(agregar)
                Base.SaveChanges()
                Return True
            End Using
        Catch ex As Exception
            Return False
            Console.WriteLine("An error occurred: '{0}'", ex)
        End Try
    End Function
    Public Function ObtenerUltimaFactura()
        Try
            Using Base As New NNeumaticosEntities1
                Dim ultimo = (From f In Base.Factura Select f.factura_num).Max()
                Return ultimo
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Trae todos las facturas'
    Public Sub MostrarTodasFacturas(ByVal data As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim consulta = (From f In Base.Factura Order By f.factura_num Descending Select N_Factura = f.factura_num, CUIL_Cliente = f.cliente_cuil, DNI_Vendedor = f.usu_Dni, Tipo_Pago = f.factura_tipoPago, Fecha = f.factura_Fecha, Monto = f.factura_Total, Estado = f.factura_estado)
                data.DataSource = consulta
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub buscarPorNumeroFactura(ByVal numFactura As Integer, ByVal data As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim busqueda = (From f In Base.Factura Order By f.factura_num Descending Where (numFactura = f.factura_num) Select N_Factura = f.factura_num, CUIL_Cliente = f.cliente_cuil, DNI_Vendedor = f.usu_Dni, Tipo_Pago = f.factura_tipoPago, Fecha = f.factura_Fecha, Monto = f.factura_Total, Estado = f.factura_estado).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Public Sub buscarPorCliente(ByVal cuil As Long, ByVal data As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim busqueda = (From f In Base.Factura Order By f.factura_num Descending Where (cuil = f.cliente_cuil) Select N_Factura = f.factura_num, CUIL_Cliente = f.cliente_cuil, DNI_Vendedor = f.usu_Dni, Tipo_Pago = f.factura_tipoPago, Fecha = f.factura_Fecha, Monto = f.factura_Total, Estado = f.factura_estado).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub buscarPorDniVendedor(ByVal dni As Long, ByVal data As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim busqueda = (From f In Base.Factura Order By f.factura_num Descending Where (dni = f.usu_Dni) Select N_Factura = f.factura_num, CUIL_Cliente = f.cliente_cuil, DNI_Vendedor = f.usu_Dni, Tipo_Pago = f.factura_tipoPago, Fecha = f.factura_Fecha, Monto = f.factura_Total, Estado = f.factura_estado).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub mostrarTipoPago(ByVal tipoPago As String, ByVal data As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim busqueda = (From f In Base.Factura Order By f.factura_num Descending Where (tipoPago = f.factura_tipoPago) Select N_Factura = f.factura_num, CUIL_Cliente = f.cliente_cuil, DNI_Vendedor = f.usu_Dni, Tipo_Pago = f.factura_tipoPago, Fecha = f.factura_Fecha, Monto = f.factura_Total, Estado = f.factura_estado).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Public Sub mostrarPorFecha(ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal data As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim busqueda = (From f In Base.Factura Order By f.factura_num Descending Where (fechaDesde > f.factura_Fecha And fechaHasta < f.factura_Fecha) Select N_Factura = f.factura_num, CUIL_Cliente = f.cliente_cuil, DNI_Vendedor = f.usu_Dni, Tipo_Pago = f.factura_tipoPago, Fecha = f.factura_Fecha, Monto = f.factura_Total, Estado = f.factura_estado).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Function anularFactura(ByVal numero As Integer)
        Try
            Using Base As New NNeumaticosEntities1
                Dim anular = (From f In Base.Factura Where (f.factura_num = numero) Select f).First()
                anular.factura_estado = "Anulada"
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

End Class
