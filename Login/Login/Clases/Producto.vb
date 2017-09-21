﻿Public Class Producto

    Private nombre As String
    Private rodado As String
    Private medida As String
    Private precio As Double
    Private datos As Char
    Private stock As Integer
    Private imagen As String
    Private vehiculo As String
    

#Region "Constructores"

    Public Sub New()
    End Sub

    Public Sub New(ByVal p_nombre As Integer, ByVal p_rodado As String, ByVal p_medida As String, ByVal p_precio As Double, ByVal p_datos As Char, ByVal p_stock As Integer, ByVal p_imagen As String, ByVal p_vehiculo As String)
        SetNombre(p_nombre)
        SetRodado(p_rodado)
        SetMedida(p_medida)
        SetPrecio(p_precio)
        SetDatos(p_datos)
        SetStock(p_stock)
        SetImagen(p_imagen)
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

    Private Sub SetDatos(ByVal p_datos As Char)
        datos = p_datos
    End Sub

    Private Sub SetStock(ByVal p_stock As String)
        stock = p_stock
    End Sub

    Private Sub SetImagen(ByVal p_imagen As String)
        imagen = p_imagen
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

                Dim agrega = New Producto With
                    {
                    .producto_nombre = GetNombre(),
                    .producto_rodado = GetRodado(),
                    .producto_medida = GetMedida(),
                    .producto_precio = GetPrecio(),
                    .Datos_cod = GetDatos(),
                    .producto_stock = GetStock(),
                    .producto_imagen = GetImagen(),
                    .tipoVehi_descripcion = GetVehiculo()}
                Base.Producto.AddObject(agrega)
                Base.SaveChanges()
            End Using
        Catch ex As Exception
        End Try
    End Sub



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