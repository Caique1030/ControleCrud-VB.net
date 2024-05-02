@ModelType Controle.Usuario
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Usuario</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.Nome)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Senha)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.Senha)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TipoUsuario)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.TipoUsuario)
        </dd>
    </dl>
</div>

<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.ID}) |
    @Html.ActionLink("Back to List", "Index")
</p>
