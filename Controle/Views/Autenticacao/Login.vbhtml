@ModelType Controle.Autenticacao
@Code
    ViewData("Title") = "Login"
End Code

<h2>@ViewData("Title")</h2>

<form action="@Url.Action("Autenticar", "Autenticacao")" method="post">
    @Html.AntiForgeryToken()

    <div class="form-group">
        <label for="Email">Email</label>
        <input type="text" id="Email" name="Email" class="form-control" />
    </div>

    <div class="form-group">
        <label for="Senha">Senha</label>
        <input type="password" id="Senha" name="Senha" class="form-control" />
    </div>

    <button type="submit" class="btn btn-primary">Login</button>
</form>

<div class="mt-3">
    <a href="https://github.com/Caique1030/ControleCrud-VB.net" class="btn btn-secondary">Ir para o Repositório</a>
</div>
