Public Class Productos
    Private nombre As String
    Private rodado As String
    Private medida As String
    Private precio As Double
    Private datos As Integer
    Private stock As Integer
    Private imagen As String
    Private estado As Char
    Private vehiculo As String

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_nombre As String, ByVal p_rodado As String, ByVal p_medida As String, ByVal p_precio As Double, ByVal p_datos As Integer, ByVal p_stock As Integer, ByVal p_imagen As String, ByVal p_estado As Char, ByVal p_vehiculo As String)
        SetNombre(p_nombre)
        SetRodado(p_rodado)
        SetMedida(p_medida)
        SetPrecio(p_precio)
        SetDatos(p_datos)
        SetStock(p_stock)
        SetImagen(p_imagen)
        SetEstado(p_estado)
        SetVehiculo(p_vehiculo)

    End Sub
#End Region

#Region "Get/Set"

#Region "Get"

    Public Function GetNombre()
        Return nombre
    End Function

    Public Function GetRodado()
        Return rodado
    End Function

    Public Function GetMedida()
        Return medida
    End Function

    Public Function GetPrecio()
        Return precio
    End Function

    Function GetDatos()
        Return datos
    End Function

    Public Function GetStock()
        Return stock
    End Function

    Public Function GetImagen()
        Return imagen
    End Function

    Public Function GetEstado()
        Return estado
    End Function

    Public Function GetVehiculo()
        Return vehiculo
    End Function

#End Region
#Region "Set"

    Private Sub SetNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub

    Private Sub SetRodado(ByVal p_rodado As String)
        rodado = p_rodado
    End Sub

    Private Sub SetMedida(ByVal p_medida As String)
        medida = p_medida
    End Sub

    Private Sub SetPrecio(ByVal p_Precio As String)
        precio = p_Precio
    End Sub

    Private Sub SetDatos(ByVal p_datos As Integer)
        datos = p_datos
    End Sub

    Private Sub SetStock(ByVal p_stock As Integer)
        stock = p_stock
    End Sub

    Private Sub SetImagen(ByVal p_imagen As String)
        imagen = p_imagen
    End Sub
    Private Sub SetEstado(ByVal p_estado As Char)
        estado = p_estado
    End Sub

    Private Sub SetVehiculo(ByVal p_vehiculo As String)
        vehiculo = p_vehiculo
    End Sub
#End Region


#End Region

#Region "Procedimientos"
    Public Sub AgregarProducto()
        Try
            Using Base As New NNeumaticosEntities1
                Dim agregar = New Producto With
                    {
                    .producto_nombre = GetNombre(),
                    .producto_rodado = GetRodado(),
                    .producto_medida = GetMedida(),
                    .producto_precio = GetPrecio(),
                    .Datos_cod = GetDatos(),
                    .producto_stock = GetStock(),
                    .producto_imagen = GetImagen(),
                    .producto_estado = GetEstado(),
                    .tipoVehi_descripcion = GetVehiculo()}
                Base.Producto.AddObject(agregar)
                Base.SaveChanges()
            End Using
        Catch ex As Exception
            Console.WriteLine("An error occurred: '{0}'", ex)
        End Try
    End Sub

    'Trae todos los productos para mostrar en el datagrid al principio'
    'Public Sub MostrarTodos(ByVal tabla1 As DataGridView) ', ByVal imagen As PictureBox
    Public Sub MostrarTodos(ByVal tabla As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim todos = (From p In Base.Producto Select ID = p.producto_id, Nombre = p.producto_nombre, Rodado = p.producto_rodado, Medida = p.producto_medida, Precio = p.producto_precio, Stock = p.producto_stock, Ruta = p.producto_imagen, Tipo_Vehiculo = p.tipoVehi_descripcion, Estado = p.producto_estado, Datos = p.Datos_cod).ToList
                tabla.DataSource = todos
            End Using
        Catch ex As Exception
        End Try
    End Sub

    '---borrado logico----
    Public Function ActualizarStock(ByVal pro_id As Integer, ByVal p_cantidad As Integer)
        Try
            Using Base As New NNeumaticosEntities1
                Dim consulta = (From p In Base.Producto Where (pro_id = p.producto_id) Select p).First
                consulta.producto_stock = consulta.producto_stock + p_cantidad
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    '---borrado logico----
    Public Sub EliminaProducto(ByVal pro_id As Integer, ByVal p_estado As Char)
        Try

            Using Base As New NNeumaticosEntities1
                Dim borra = (From p In Base.Producto Where (pro_id = p.producto_id)
                             Select p).First
                borra.producto_estado = p_estado

                Base.SaveChanges()
            End Using

        Catch ex As Exception

        End Try
    End Sub

    '---borrado fisico----
    Public Sub Eliminar(ByVal pro_id)
        Try
            Using Base As New NNeumaticosEntities1

                Dim borra = (From p In Base.Producto Where (pro_id = p.producto_id)
                             Select p).First()
                Base.Producto.DeleteObject(borra)
                Base.SaveChanges()
            End Using
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class
