@ModelType IEnumerable(Of Controle.Usuario)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
@If User.Identity.IsAuthenticated Then
    @<p>
        @Html.ActionLink("Logout", "Logout", "Admin")
    </p>
End If
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Senha)
        </th>
        <td>
            @Html.DisplayNameFor(Function(model) model.TipoUsuario)
        </td>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Nome)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Email)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Senha)
            </td>
            <td>
                @item.TipoUsuario.ToString()
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.ID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.ID})
            </td>
        </tr>
    Next
</table>
