﻿function verificaPossuiAcompanhante() {
    var htmlContent = `
    <div class="row">
        <div class="col-md-4">
            <form asp-action="Create">
                <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                <div class="form-group">
                    <label asp-for="Nome" class="control-label"></label>
                    <input asp-for="Nome" class="form-control" />
                    <span asp-validation-for="Nome" class="text-danger"></span>
                </div>
                <div class="form-group">
                    <label asp-for="Sexo" class="control-label"></label>
                    <input asp-for="Sexo" class="form-control" />
                    <span asp-validation-for="Sexo" class="text-danger"></span>
                </div>
                <div class="form-group">
                    <label asp-for="CPF" class="control-label"></label>
                    <input asp-for="CPF" class="form-control" />
                    <span asp-validation-for="CPF" class="text-danger"></span>
                </div>
                <div class="form-group">
                    <label asp-for="Email" class="control-label"></label>
                    <input asp-for="Email" class="form-control" />
                    <span asp-validation-for="Email" class="text-danger"></span>
                </div>
                <div class="form-group">
                    <label asp-for="Celular" class="control-label"></label>
                    <input asp-for="Celular" class="form-control" />
                    <span asp-validation-for="Celular" class="text-danger"></span>
                </div>
                <div class="form-group form-check">
                    <label class="form-check-label">
                        <input class="form-check-input" asp-for="UtilizarApp" /> @Html.DisplayNameFor(model => model.UtilizarApp)
                    </label>
                </div>
                <br>
                <div class="form-group">
                    <input type="submit" value="Cadastrar" class="btn btn-primary" />
                    <a class="btn btn-secondary" asp-action="Index">Voltar</a>
                </div>
            </form>
        </div>
    </div>`;
    document.getElementById("content").innerHTML = htmlContent;
}