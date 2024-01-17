
@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>VincularCuenta</title>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial; overflow:hidden;">
    <form action="/Personal/VincularCuenta" method="post" >
        <table>
            <tr>
                <td colspan="3">
                    Ingrese el correo del usuario para lograr la vinculación, el usuario debe registrarse en el inicio de sesión
                </td>

            </tr>
            <tr>
                <td colspan="3">
                </td>

            </tr>
            <tr>
                <td>
                    CORREO ELECTRONICO
                </td>
                <td>
                    <input value="" type="text" name="CorreoElectronico">
                </td>
            </tr>
            <tr>
                <td>
                    <button style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" >
                        Continuar
                    </button>
                </td>
            </tr>
        </table>
    </form>

</body>
</html>
