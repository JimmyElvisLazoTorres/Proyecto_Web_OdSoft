
@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>ActualizarCampo</title>
</head>
<body style="margin:0px;">
  
        @If ViewBag.DatoActualizado Then
            @<img src="/Content/imagenes/correcto.png"/>

        Else
            @<img src="/Content/imagenes/mal.png" />
            @<h3> @ViewBag.Mensaje</h3>

        End If


</body>
</html>
