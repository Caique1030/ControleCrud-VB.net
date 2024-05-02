@ModelType Controle.Usuario

@Code
    ViewData("Title") = "Detalhes do Perfil"
End Code

<h2>Detalhes do Perfil</h2>

<div>
    <dl class="dl-horizontal">
        <dt>Nome:</dt>
        <dd>@Model.Nome</dd>
        <dt>Email:</dt>
        <dd>@Model.Email</dd>
        <dt>Senha:</dt>
        <dd>@Model.Senha</dd>
        <dt>Tipo de Usuário:</dt>
        <dd>@Model.TipoUsuario</dd>
    </dl>
</div>

<p>
    @Html.ActionLink("Voltar", "Index")
</p>
