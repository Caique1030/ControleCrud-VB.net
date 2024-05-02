Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Usuario
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property ID As Integer

    <Required(ErrorMessage:="O campo Nome é obrigatório.")>
    Public Property Nome As String

    <Required(ErrorMessage:="O campo Email é obrigatório.")>
    Public Property Email As String

    <Required(ErrorMessage:="O campo Senha é obrigatório.")>
    Public Property Senha As String

    <Required(ErrorMessage:="O campo TipoUsuario é obrigatório.")>
    <EnumDataType(GetType(TipoUsuario))>
    Public Property TipoUsuario As TipoUsuario ' Pode ser "admin" ou "padrao"
End Class
