
@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>ActualizarCampoAutorizaCorreoElectronico</title>
</head>
<body style="margin:0px;">

    @Select Case ViewBag.AutorizaCorreoElectronico
        Case "true"
            @<table>
                <tr>
                    <td>
                        <div style="        border: 2px solid #000000;
        background-color: #008000;
        color: black;
        font-size: 15px;
        border-radius: 15px;
        font-family: neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;
        align-items: center;
        vertical-align: text-bottom;">
                            SI
                        </div>
                    </td>
                    <td>
                        <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/ActualizarCampoAutorizaCorreoElectronico?Dato=@ViewBag.IdCliente|false|AutorizaCorreoElectronico'">
                            NO
                        </div>
                    </td>
                </tr>
            </table>
        Case "false"
                                @<table>
                                    <tr>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/ActualizarCampoAutorizaCorreoElectronico?Dato=@ViewBag.IdCliente|true|AutorizaCorreoElectronico'">
                                                SI
                                            </div>

                                        </td>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:black;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                                                NO
                                            </div>
                                        </td>
                                    </tr>
                                </table>
        Case Else
                                @<table>
                                    <tr>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/ActualizarCampoAutorizaCorreoElectronico?Dato=@ViewBag.IdCliente|true|AutorizaCorreoElectronico'">
                                                SI
                                            </div>
                                        </td>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/ActualizarCampoAutorizaCorreoElectronico?Dato=@ViewBag.IdCliente|false|AutorizaCorreoElectronico'">
                                                NO
                                            </div>
                                        </td>
                                    </tr>
                                </table>
    End Select





</body>
</html>
