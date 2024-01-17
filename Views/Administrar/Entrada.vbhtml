
@Code
    Layout = Nothing
End Code



<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Inicio</title>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial; align-content:center;text-align:center ;overflow:hidden;">
    <table style="margin:0px;width:100%;height:100%;">
        <tr style="height:30px;">
            <td>
                <div style="float: left; width: 150px; border-bottom: 2px solid #017272;"><img style="height:15px;" src="~/Content/entrada.png" /><b>Entrada</b></div>
                <div style="float: left; width: 120px;"><img style="height:15px;" src="~/Content/proceso.png" />Proceso</div>
                <div style="float: left; width: 120px;"><img style="height:15px;" src="~/Content/salida.png" />Salida</div>
            </td>
            <td>
            </td>

            <td style="width:300px;">
                <div style="padding:0px 12px 0px;width:auto;height:20px; border-radius:13px; color:gold;font-family:'Century Gothic',Arial; align-content:center;text-align:center ;">
                    <div style="width:5px;">

                    </div>
                    @Html.ActionLink("Cuenta", "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.Style = "Color:gold; text-decoration:none;"})
                    <div style="width:5px;">

                    </div>
                </div>
            </td>
        </tr>

        <tr>
            <td colspan="3">
                <div style="height:100%;width:100%;">
                    <iframe name="Paginas" src="/Administrar/Personal" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow:hidden;"></iframe>
                </div>
            </td>
        </tr>
        <tr>
        </tr>
    </table>
    <noscript>
    </noscript>

</body>
</html>
