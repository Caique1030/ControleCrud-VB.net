@ModelType Controle.Usuario
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Usuario</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Nome:</dt>
        <dd>@Model.Nome</dd>
        <dt>Email:</dt>
        <dd>@Model.Email</dd>
        <dt>Senha:</dt>
        <dd>@Model.Senha</dd>
        <dt>Tipo de Usuário:</dt>
        <dd>@Model.TipoUsuario</dd>/dd>

    </dl>
    @Using (Html.BeginForm("Delete", "Padrao", New With {.id = Model.ID}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"}))
            @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
