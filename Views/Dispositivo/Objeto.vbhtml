@ModelType Proyecto_Web_OdSoft.Clase_G_Dispositivo

@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Objeto</title>
</head>
<body>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()
        
        @<div class="form-horizontal">
            <h4>Clase_G_Dispositivo</h4>
            <hr />
            @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
            @Html.HiddenFor(Function(model) model.Id)
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.IdEmpresa, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.IdEmpresa, New With { .htmlAttributes = New With { .class = "form-control" } })
                    @Html.ValidationMessageFor(Function(model) model.IdEmpresa, "", New With { .class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Orden, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Orden, New With { .htmlAttributes = New With { .class = "form-control" } })
                    @Html.ValidationMessageFor(Function(model) model.Orden, "", New With { .class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.FechaInscripcion, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.FechaInscripcion, New With { .htmlAttributes = New With { .class = "form-control" } })
                    @Html.ValidationMessageFor(Function(model) model.FechaInscripcion, "", New With { .class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Activo, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    <div class="checkbox">
                        @Html.EditorFor(Function(model) model.Activo)
                        @Html.ValidationMessageFor(Function(model) model.Activo, "", New With { .class = "text-danger" })
                    </div>
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Vinculado, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    <div class="checkbox">
                        @Html.EditorFor(Function(model) model.Vinculado)
                        @Html.ValidationMessageFor(Function(model) model.Vinculado, "", New With { .class = "text-danger" })
                    </div>
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.NombreDispositivo, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.NombreDispositivo, New With { .htmlAttributes = New With { .class = "form-control" } })
                    @Html.ValidationMessageFor(Function(model) model.NombreDispositivo, "", New With { .class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Color, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Color, New With { .htmlAttributes = New With { .class = "form-control" } })
                    @Html.ValidationMessageFor(Function(model) model.Color, "", New With { .class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Usuario, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Usuario, New With { .htmlAttributes = New With { .class = "form-control" } })
                    @Html.ValidationMessageFor(Function(model) model.Usuario, "", New With { .class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Save" class="btn btn-default" />
                </div>
            </div>
        </div>
    End Using
    
    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
</body>
</html>
