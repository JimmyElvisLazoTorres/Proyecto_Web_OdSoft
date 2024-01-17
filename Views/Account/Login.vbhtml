@ModelType Proyecto_Web_OdSoft.LoginViewModel
@Code
    Layout = Nothing
    ViewBag.Title = "Iniciar sesión"

End Code

<body background="~/Content/imagenes/fondo.jpg" style="        background-position: center;
        background-repeat: no-repeat;
        background-size:cover;" 
      >
    <div class="ContenidoCentrado" style="        position: absolute;
        justify-content: center;
        border-radius: 16px;
        text-align: center;
        top: 0;
        bottom: 0;
        left: 0;
        right: 0;
        margin: auto;
        width: 400px;
        min-height: 200px;
        height: 200px;
        max-height: 400px;
        background-color: #017272;
        opacity: 0.9">
        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                @Html.AntiForgeryToken()

                @<text>
                    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                    <table style="font-family:'Century Gothic',Arial;color:white;width:100%;height:100%;">
                        <tbody>
                            <tr>
                                <td colspan="4"> </td>
                            </tr>
                            <tr>
                                <td colspan="4" align="center">   Iniciar sesión</td>
                            </tr>
                            <tr>
                                <td colspan="4"> </td>
                            </tr>
                            <tr>
                                <td rowspan="7"></td>
                                <td rowspan="7" align="center"> <img style="width:30px;height:30px;" src="~/Content/imagenes/Candado.png"> </td>
                                <td></td>
                                <td></td>
                            </tr>

                            <tr>
                                <td>Usuario</td>
                                <td>
                                   
                                    @Html.TextBoxFor(Function(m) m.Email, New With {.style = "font-family:'Century Gothic',Arial;color:blue;width:90%;value:'asd';", .value = "'jimmyelvislazotorres@gmail.com'"})
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <H6>@Html.ValidationMessageFor(Function(m) m.Email, "", New With {.Style = "font-family:'Century Gothic',Arial;color:yellow;width:90%; "})</H6>
                                </td>
                            </tr>


                            <tr>

                                <td>Contraseña</td>
                                <td>
                                    @Html.PasswordFor(Function(m) m.Password, New With {.Style = "font-family:'Century Gothic',Arial;color:blue;width:90%; "})
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <h6>
                                        @Html.ValidationMessageFor(Function(m) m.Password, "", New With {.Style = "font-family:'Century Gothic',Arial;color:yellow;width:90%;"})
                                    </h6>
                                </td>

                            </tr>
                            <tr>

                                <td></td>
                                <td></td>
                            </tr>

                            <tr>
                                <td colspan="4"></td>

                            </tr>
                            <tr>
                                <td colspan="4" align="center">
                                    <input type="submit" style="font-family:'Century Gothic'; width:150px;height:40px;border-radius:16px;" value="Continuar" align="center">
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">

                                    <ul class="nav navbar-nav navbar-right">
                                        <li>@Html.ActionLink("Registrarse", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})</li>
                                    </ul>
                                </td>
                            </tr>
                        </tbody>
                    </table>



                </text>
            End Using
        </section>

    </div>
    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section
</body>
