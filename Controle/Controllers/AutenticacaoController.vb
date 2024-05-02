Imports System.Data.Entity
Imports System.Web.Mvc
Imports System.Web.Security

Public Class AutenticacaoController
    Inherits Controller

    Private db As New ControleContext()

    ' GET: Autenticacao/Login
    Function Login() As ActionResult
        Return View()
    End Function

    ' POST: Autenticacao/Login
    <HttpPost>
    <ValidateAntiForgeryToken>
    Function Autenticar(model As Autenticacao) As ActionResult
        If ModelState.IsValid Then
            Dim usuario = db.Usuarios.FirstOrDefault(Function(u) u.Email = model.Email AndAlso u.Senha = model.Senha)

            If usuario IsNot Nothing Then
                If usuario.TipoUsuario = TipoUsuario.Admin Then
                    FormsAuthentication.SetAuthCookie(usuario.Email, False)
                    Return RedirectToAction("Index", "Admin")
                ElseIf usuario.TipoUsuario = TipoUsuario.Padrao Then
                    FormsAuthentication.SetAuthCookie(usuario.Email, False)
                    Return RedirectToAction("Index", "Padrao1")
                Else
                    ModelState.AddModelError("", "Tipo de conta inválido.")
                End If
            Else
                ModelState.AddModelError("", "Email ou senha inválidos.")
            End If
        End If

        Return View("Login", model)
    End Function

    ' GET: Autenticacao/Logout
    Function Logout() As ActionResult
        FormsAuthentication.SignOut()
        Return RedirectToAction("Login")
    End Function

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            db.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
End Class
