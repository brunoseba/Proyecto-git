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
    'Agregar Nuevo Producto'
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

    'Modificar Producto'
    Public Function ModificarProducto(ByVal p_cod As Integer, ByVal p_nombre As String, ByVal p_rodado As String, ByVal p_medida As String, ByVal p_precio As Double, ByVal p_datos As Integer, ByVal p_stock As Integer, ByVal p_imagen As String, ByVal p_estado As Char, ByVal p_vehiculo As String)
        Try
            Using Base As New NNeumaticosEntities1
                Dim modificar = (From u In Base.Producto Where (u.producto_id = p_cod) Select u).First
                modificar.producto_nombre = p_nombre
                modificar.producto_rodado = p_rodado
                modificar.producto_medida = p_medida
                modificar.producto_precio = p_precio
                modificar.Datos_cod = p_datos
                modificar.producto_stock = p_stock
                modificar.producto_imagen = p_imagen
                modificar.producto_estado = p_estado
                modificar.tipoVehi_descripcion = p_vehiculo
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("An error occurred: '{0}'", ex)
            Return False
        End Try
    End Function

    'Public Sub MostrarTodos(ByVal tabla1 As DataGridView) ', ByVal imagen As PictureBox
    Public Sub MostrarTodos(ByVal tabla As DataGridView)
        Try
            Using Base As New NNeumaticosEntities1
                Dim todos = (From p In Base.Producto Select ID = p.producto_id, Nombre = p.producto_nombre, Rod = p.producto_rodado, Medida = p.producto_medida, Precio = p.producto_precio, Stock = p.producto_stock, Ruta = p.producto_imagen, Tipo_Vehiculo = p.tipoVehi_descripcion, Estado = p.producto_estado, Datos = p.Datos_cod).ToList
                tabla.DataSource = todos
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub BuscarPorNombre(ByVal p_nombre As String, ByVal p_resultados As DataGridView)
        Try
            Using base As New NNeumaticosEntities1
                Dim consulta = (From p In base.Producto Where (p.producto_nombre.Contains(p_nombre)) Select ID = p.producto_id, Nombre = p.producto_nombre, Rodado = p.producto_rodado, Medida = p.producto_medida, Precio = p.producto_precio, Stock = p.producto_stock, Ruta = p.producto_imagen, Tipo_Vehiculo = p.tipoVehi_descripcion, Estado = p.producto_estado, Datos = p.Datos_cod).ToList
                p_resultados.DataSource = consulta
            End Using
        Catch ex As Exception
            MsgBox("No se pudo realizar la consulta")
        End Try
    End Sub

    Public Sub BuscarPorRodaTipoVehi(ByVal p_rodado As String, ByVal p_tipoV As String, ByVal p_data As DataGridView, Optional ByVal p_rodado_O As String = "*", Optional ByVal p_tipoV_O As String = "*")
        Try
            Using Base As New NNeumaticosEntities1
                Dim consulta = (From p In Base.Producto Where (((p.producto_rodado = p_rodado) And (p.tipoVehi_descripcion = p_tipoV)) Or
                                                               ((p.producto_rodado = p_rodado_O) Or (p.tipoVehi_descripcion = p_tipoV_O)))
                                Select ID = p.producto_id, Nombre = p.producto_nombre, Rodado = p.producto_rodado, Medida = p.producto_medida, Precio = p.producto_precio, Stock = p.producto_stock, Ruta = p.producto_imagen, Tipo_Vehiculo = p.tipoVehi_descripcion, Estado = p.producto_estado, Datos = p.Datos_cod).ToList
                p_data.DataSource = consulta
            End Using
        Catch ex As Exception
        End Try
    End Sub
    '---ActualizarStock----
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

    '---Baja de Producto----
    Public Function BajaProducto(ByVal pro_id As Integer)
        Try
            Using Base As New NNeumaticosEntities1
                Dim baja = (From p In Base.Producto Where (pro_id = p.producto_id) Select p).First
                baja.producto_estado = "B"
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    '---Alta de Producto----
    Public Function AltaProducto(ByVal pro_id As Integer)
        Try
            Using Base As New NNeumaticosEntities1
                Dim baja = (From p In Base.Producto Where (pro_id = p.producto_id) Select p).First
                baja.producto_estado = "A"
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    '---borrado fisico----
    Public Sub Eliminar(ByVal pro_id As Integer)
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

    'Descontar Stock'
    Public Function descontarStock(ByVal pro_id As Integer, ByVal cantidad As Integer)
        Try
            Using Base As New NNeumaticosEntities1
                Dim consulta = (From p In Base.Producto Where (pro_id = p.producto_id) Select p).First()
                consulta.producto_stock = (consulta.producto_stock - cantidad)
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
