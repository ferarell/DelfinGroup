﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class NextSoftTarifarioEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=NextSoftTarifarioEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property COM_Servicio() As DbSet(Of COM_Servicio)
    Public Overridable Property Tipos() As DbSet(Of Tipos)
    Public Overridable Property Constantes() As DbSet(Of Constantes)

End Class
