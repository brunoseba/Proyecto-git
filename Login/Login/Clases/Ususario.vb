﻿Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization

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

    Public Sub New(ByVal u_dni As Integer, ByVal u_nomYape As String, ByVal u_direccion As String, ByVal u_localidad As String, ByVal u_provincia As String, ByVal u_telefono As String, ByVal u_email As String, ByVal u_contraseña As String, ByVal u_estado As Char, ByVal u_tipoUsu As Char, ByVal u_fecha As String)
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
#End Region


#End Region

#Region "Procedimientos"


    '---agrega usuario---
    Public Function AgregarUsuario() 'ByVal dni As Integer, ByVal nomYape As String, ByVal direc As String, ByVal local As String, ByVal prov As String, ByVal tel As String, ByVal email As String, ByVal contra As String, ByVal estado As Char, ByVal tipoUsu As Char, ByVal fecha As String)
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
                .usu_Fecha = GetFecha()
                }
                Base.Usuario.AddObject(consulta)
                Base.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    '---Verifica si esta en la base de datos---
    Public Function Verifica(ByVal u_dni As Integer, ByVal u_contra As String)
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
                            Select Dni = u.usu_Dni, NombreyApellido = u.usu_nomYape, Direccion = u.usu_Direccon, Localidad = u.usu_Localidad, Telefono = u.usu_Telefono, Email = u.usu_Email, Contraseña = u.usu_Contraseña, Estado = u.usu_Estado, TipoUsuario = u.usu_TipoUsu).ToList

                tabla.DataSource = mues

            End Using
        Catch ex As Exception

        End Try
    End Sub




#End Region

End Class