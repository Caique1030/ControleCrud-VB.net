Imports System.Data.Entity

Public Class ControleContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("Data Source=PC-CAIQUEJR23\SQLEXPRESS;Initial Catalog=UsuarioDB;Integrated Security=True")
    End Sub

    Public Property Usuarios As DbSet(Of Usuario)
    Public Property Autenticacaos As System.Data.Entity.DbSet(Of Autenticacao)
End Class

