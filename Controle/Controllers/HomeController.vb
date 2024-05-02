Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Dim model As New Usuario() With {.Nome = "Usuário"}
            Return View(model)
        End Function

    End Class
End Namespace
