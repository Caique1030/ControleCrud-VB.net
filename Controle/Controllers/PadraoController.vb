Imports System.Data.Entity
Imports System.Web.Mvc
Imports Controle ' Importa o namespace Controle para acessar o contexto do banco de dados e o modelo de usuário

Namespace Controllers
    Public Class PadraoController
        Inherits System.Web.Mvc.Controller

        Private db As New ControleContext

        ' Método para autenticar o usuário
        Private Function AutenticarUsuario() As Usuario
            ' Verifica se o usuário está autenticado
            If Not User.Identity.IsAuthenticated Then
                ' Se não estiver autenticado, redireciona para a página de login
                Return Nothing
            End If

            ' Obtém o email do usuário autenticado
            Dim userEmail As String = User.Identity.Name

            ' Obtém o tipo de usuário correspondente ao email autenticado
            Dim tipoUsuario As TipoUsuario = GetUserTypeByEmail(userEmail)

            ' Verifica se o tipo de usuário é válido
            If tipoUsuario = tipoUsuario.NaoAutenticado Then
                ' Se não for um tipo de usuário válido, retorna nulo ou lança uma exceção
                ' Throw New HttpException(500, "Tipo de usuário inválido.")
                Return Nothing
            End If

            ' Obtém o usuário correspondente ao email autenticado e ao tipo de usuário
            Dim usuario As Usuario = db.Usuarios.FirstOrDefault(Function(u) u.Email = userEmail AndAlso u.TipoUsuario = tipoUsuario)

            ' Se o usuário não for encontrado, retorna nulo
            If usuario Is Nothing Then
                ' Ou você pode lançar uma exceção
                Throw New HttpException(500, "Usuário não encontrado.")
                Return Nothing
            End If

            ' Retorna o usuário autenticado
            Return usuario
        End Function

        ' Método para obter o tipo de usuário pelo email
        Private Function GetUserTypeByEmail(email As String) As TipoUsuario
            ' Consulta o banco de dados para encontrar o usuário correspondente ao email
            Dim usuario As Usuario = db.Usuarios.FirstOrDefault(Function(u) u.Email = email)

            ' Verifica se o usuário foi encontrado
            If usuario IsNot Nothing Then
                ' Retorna o tipo de usuário associado ao usuário encontrado
                Return usuario.TipoUsuario
            Else
                ' Se o usuário não for encontrado, retorna NaoAutenticado
                Return TipoUsuario.NaoAutenticado
            End If
        End Function

        Function Index() As ActionResult
            ' Autentica o usuário
            Dim usuario As Usuario = AutenticarUsuario()

            ' Verifica se o usuário está autenticado
            If usuario Is Nothing Then
                ' Se não estiver autenticado, redireciona para a página de login
                Return RedirectToAction("Login", "Autenticacao")
            End If

            ' Adiciona o usuário aos dados da view
            ViewData("Usuario") = usuario

            ' Retorna a visualização com as informações do usuário autenticado
            Return View(usuario)
        End Function

        ' GET: Padrao/Edit
        Function Edit() As ActionResult
            ' Autentica o usuário
            Dim usuario As Usuario = AutenticarUsuario()

            ' Verifica se o usuário está autenticado
            If usuario Is Nothing Then
                ' Se não estiver autenticado, redireciona para a página de login
                Return RedirectToAction("Login", "Autenticacao")
            End If

            ' Retorna a visualização para edição do próprio cadastro do usuário autenticado
            Return View(usuario)
        End Function

        ' Método POST para editar o usuário
        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Edit(usuario As Usuario) As ActionResult
            ' Verifica se o modelo é válido
            If ModelState.IsValid Then
                ' Atualiza o usuário no banco de dados
                db.Entry(usuario).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            ' Se houver problemas com o modelo, retorna a view de edição com os erros
            Return View(usuario)
        End Function

        ' Outros métodos omitidos para brevidade...
    End Class
End Namespace
