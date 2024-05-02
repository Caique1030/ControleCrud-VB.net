Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            ' Aqui você pode adicionar lógica para obter dados ou qualquer outra coisa que precise ser feita para a página inicial
            Dim model As New Usuario() With {.Nome = "Usuário"}
            Return View(model)
        End Function

    End Class
End Namespace
