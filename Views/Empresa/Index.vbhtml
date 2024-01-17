@ModelType Proyecto_Web_OdSoft.Clase_S_Empresa

@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()
        @<table>
    <tr>
        <td colspan="3">
            Datos de la Empresa
            @Html.EditorFor(Function(model) model.UserId, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.UserId, "", New With {.class = "text-danger"})
        </td>

    </tr>
    <tr>
        <td colspan="3">
            La sensibilidad de estos datos es alto, se le pide ingresar con la mayor precisión.
        </td>

    </tr>
    <tr>
        <td>
            NOMBRE DE LA EMPRESA
        </td>
        <td>
            @Html.EditorFor(Function(model) model.NombreCompleto, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.NombreCompleto, "", New With {.class = "text-danger"})
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            RUC
        </td>
        <td>
            @Html.EditorFor(Function(model) model.RUC, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.RUC, "", New With {.class = "text-danger"})
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            DIRECCIÓN
        </td>
        <td>
            @Html.EditorFor(Function(model) model.Direccion, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Direccion, "", New With {.class = "text-danger"})
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            NACIONALIDAD
        </td>
        <td>

            @Html.EditorFor(Function(model) model.Nacionalidad, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Nacionalidad, "", New With {.class = "text-danger"})
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            CELULAR
        </td>
        <td>
            @Html.EditorFor(Function(model) model.Celular, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.Celular, "", New With {.class = "text-danger"})
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            WHATSAPP
        </td>
        <td>
            @Html.EditorFor(Function(model) model.WhatsApp, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.WhatsApp, "", New With {.class = "text-danger"})
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
           
        </td>
        <td>
            <input type="submit" value="GUARDAR" class="btn btn-default" />
        </td>
        <td>
            @Model.Mensaje  
        </td>
    </tr>

</table>
    End Using
    
</body>
</html>
