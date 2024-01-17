
@Code
    Layout = Nothing
End Code



<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Inicio</title>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial; align-content:center;text-align:center ;">
    <table style="margin:0px;width:100%;height:100%;">
        <tr  style="height:30px;">
            <td>
                <div style="float: left; width: 80px; border-bottom: 2px solid #017272;"> Inicio</div>
                <div style="float: left; width: 80px;">Entrada</div>
                <div style="float: left; width: 80px;">Proceso</div>
                <div style="float: left; width: 80px;">Salida</div>
            </td>
            <td>
            </td>

            <td style="width:300px;">
                <div style="padding:0px 12px 0px;width:auto;height:20px; border-radius:13px; border:2px ridge gold; color:gold;font-family:'Century Gothic',Arial; align-content:center;text-align:center ;">
                    <div style="width:5px;">

                    </div>
                    @Html.ActionLink("Cuenta", "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.Style = "Color:gold; text-decoration:none;"})
                    <div style="width:5px;">

                    </div>
                </div>
            </td>
        </tr>

        <tr>
            <td style="background-color:#017272;" colspan="3">
            </td>
        </tr>
        <tr>
            <td style="background-color:#017272;" colspan="3">
               <div style="height:100%;width:100%;">
                   sASD
               </div>
            </td>
        </tr>
        <tr>
        </tr>
    </table>


</body>
</html>
