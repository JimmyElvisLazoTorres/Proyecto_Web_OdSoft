
@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>ActualizarCampoSexo</title>
</head>
<body style="margin:0px;">

    @Select Case ViewBag.Sexo
        Case "MASCULINO"
            @<table>
                <tr>
                    <td>
                        <div style="border:2px solid #000000;background-color:#017272;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                            MASCULINO
                        </div>
                    </td>
                    <td>
                        <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/ActualizarCampoSexo?Dato=@ViewBag.IdCliente|FEMENINO|Sexo'">
                            FEMENINO
                        </div>
                    </td>
                </tr>
            </table>
        Case "FEMENINO"
                                @<table>
                                    <tr>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/ActualizarCampoSexo?Dato=@ViewBag.IdCliente|MASCULINO|Sexo'">
                                                MASCULINO
                                            </div>
                                            
                                        </td>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#017272;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                                                FEMENINO
                                            </div>
                                        </td>
                                    </tr>
                                </table>
        Case Else
                                @<table>
                                    <tr>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/ActualizarCampoSexo?Dato=@ViewBag.IdCliente|MASCULINO|Sexo'">
                                                MASCULINO
                                            </div>
                                        </td>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/ActualizarCampoSexo?Dato=@ViewBag.IdCliente|FEMENINO|Sexo'">
                                                FEMENINO
                                            </div>
                                        </td>
                                    </tr>
                                </table>
    End Select





</body>
</html>
