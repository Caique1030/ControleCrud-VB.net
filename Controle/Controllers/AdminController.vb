Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Controle

Namespace Controllers
    Public Class AdminController
        Inherits System.Web.Mvc.Controller

        Private db As New ControleContext

        Function Index() As ActionResult

            Dim usuarios As IEnumerable(Of Usuario) = db.Usuarios.ToList()
            Return View(usuarios)
        End Function

        ' GET: Admin/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuarios.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' GET: Admin/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Admin/Create
        ' To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        ' more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Nome,Email,Senha,TipoUsuario")> ByVal usuario As Usuario) As ActionResult
            If ModelState.IsValid Then
                db.Usuarios.Add(usuario)
                db.SaveChanges()

                ' Verifica o tipo de usuário
                If usuario.TipoUsuario = TipoUsuario.Padrao Then
                    ' Se for usuário "Padrao", redireciona para a página inicial do PadraoController
                    Return RedirectToAction("Index", "Admin")
                Else
                    ' Para outros tipos de usuário, redireciona para a página inicial do AdminController
                    Return RedirectToAction("Index")
                End If
            End If
            Return View(usuario)
        End Function


        ' GET: Admin/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuarios.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' POST: Admin/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Nome,Email,Senha,TipoUsuario")> ByVal usuario As Usuario) As ActionResult
            If ModelState.IsValid Then
                db.Entry(usuario).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(usuario)
        End Function

        ' GET: Admin/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim usuario As Usuario = db.Usuarios.Find(id)
            If IsNothing(usuario) Then
                Return HttpNotFound()
            End If
            Return View(usuario)
        End Function

        ' POST: Admin/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim usuario As Usuario = db.Usuarios.Find(id)
            db.Usuarios.Remove(usuario)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        ' GET: Admin/Logout
        Function Logout() As ActionResult
            ' Realizar logout do usuário
            FormsAuthentication.SignOut()
            Return RedirectToAction("Index", "Home") ' Redirecionar para a página inicial
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
