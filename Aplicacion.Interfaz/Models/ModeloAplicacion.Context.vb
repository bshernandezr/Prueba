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

Partial Public Class ModeloConnection
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ModeloConnection")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property cargo() As DbSet(Of cargo)
    Public Overridable Property empleado() As DbSet(Of empleado)
    Public Overridable Property tienda() As DbSet(Of tienda)

End Class