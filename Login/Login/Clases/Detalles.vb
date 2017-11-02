Public Class Detalles
    Private detalle_id As Integer
    Private factura_num As Integer
    Private producto_id As Integer
    Private cantidad As Integer
    Private precioUnit As Double
    Private total As Double

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(ByRef d_factNum As Integer, ByRef d_productoID As Integer, ByVal d_cantidad As Integer, ByVal d_precioUnita As Double, ByVal d_total As Double)
        SetFacturaNum(d_factNum)
        SetProductoID(d_productoID)
        SetCantidad(d_cantidad)
        SetPrecioUnitario(d_precioUnita)
        SetTotal(d_total)
    End Sub

#End Region

#Region "SET/GET"
    Private Sub SetFacturaNum(ByVal d_facturaNum As Integer)
        factura_num = d_facturaNum
    End Sub
    Private Sub SetProductoID(ByVal d_productoID As Integer)
        producto_id = d_productoID
    End Sub
    Private Sub SetCantidad(ByVal d_cantidad As Integer)
        cantidad = d_cantidad
    End Sub
    Private Sub SetPrecioUnitario(ByVal d_precioUnita As Double)
        precioUnit = d_precioUnita
    End Sub
    Private Sub SetTotal(ByVal d_total As Double)
        total = d_total
    End Sub

    Public Function GetNumFactura()
        Return factura_num
    End Function
    Public Function GetProductoID()
        Return producto_id
    End Function
    Public Function GetCantidad()
        Return cantidad
    End Function
    Public Function GetPrecioUnitario()
        Return precioUnit
    End Function
    Public Function GetTotal()
        Return total
    End Function
#End Region

#Region "Procedimientos"
    Public Function agregarDetalles()
        Try
            Using Base As New NNeumaticosEntities1
                Dim nuevoDetalle = New Detalle With
                {
                .factura_num = GetNumFactura(),
                .producto_id = GetProductoID(),
                .detalle_cantidad = GetCantidad(),
                .detalle_precio = GetPrecioUnitario(),
                .detalle_total = GetTotal()}
                Base.Detalle.AddObject(nuevoDetalle)
                Base.SaveChanges()
                Return True
            End Using
        Catch ex As Exception
            Return False
            Console.WriteLine("An error occurred: '{0}'", ex)
        End Try
    End Function

    'Trae todos las facturas'
    Public Sub MostrarTodosProductos(ByVal numFactura As Integer, ByVal data As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim consulta = (From d In Base.Detalle
                                Join p In Base.Producto On d.producto_id Equals p.producto_id Order By d.detalle_id Descending Where (numFactura = d.factura_num) Select Cantidad = d.detalle_cantidad, Descripcion = p.producto_nombre, Tipo_Vehiculo = p.tipoVehi_descripcion, Rodado = p.producto_rodado, Medida = p.producto_medida, Precio_Unit = p.producto_precio, Total = d.detalle_total)
                data.DataSource = consulta
            End Using
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class
