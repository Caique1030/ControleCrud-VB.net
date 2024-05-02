@ModelType Controle.Usuario

@Code
    ViewData("Title") = "Meu Perfil"
    Dim usuario As Controle.Usuario = ViewData("Usuario") ' Recupera o usuário autenticado dos dados da view
End Code

<p>
    @Html.ActionLink("Editar Perfil", "Edit")
</p>
<table class="table">
    <tr>
        <th>
            Nome
        </th>
        <th>
            Email
        </th>
        <th>
            Senha
        </th>
        <th>
            Tipo de Usuário
        </th>
        <th></th>
    </tr>

    <tr>
        <td>
            @usuario.Nome
        </td>
        <td>
            @usuario.Email
        </td>
        <td>
            @usuario.Senha
        </td>
        <td>
            @usuario.TipoUsuario.ToString() ' Converte o valor do tipo de usuário para seu nome de enumeração
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit") |
            @Html.ActionLink("Excluir", "Delete", New With {.id = usuario.ID})
        </td>
    </tr>
</table>
