﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace phonebook_data

    Partial Public Class phonebookEntities
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=phonebookEntities")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property Phonebooks() As DbSet(Of Phonebook)
        Public Property PhoneNumber As String
    End Class

End Namespace