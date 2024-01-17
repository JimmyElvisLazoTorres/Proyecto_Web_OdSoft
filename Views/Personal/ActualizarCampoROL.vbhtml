
@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>ActualizarCampoSexo</title>
</head>
<body style="margin:0px;">
    @Select Case ViewBag.ROL
        Case "ADMINISTRADOR_GENERAL"
            @<table>
                <tr>
                    <td>
                        <div style="border:2px solid #000000;background-color:#017272;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                            ADMINISTRADOR GENERAL
                        </div>
                    </td>
                </tr>
            </table>
        Case "ADMINISTRADOR"
                                @<table>
                                  
                                    <tr>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#017272;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                                                ADMINISTRADOR
                                            </div>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Personal/ActualizarCampoROL?Dato=@ViewBag.IdPersonal|ODONTOLOGO|Rol'">
                                                ODONTOLOGO
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Personal/ActualizarCampoROL?Dato=@ViewBag.IdPersonal|RECEPCION|Rol'">
                                                RECEPCIONISTA
                                            </div>
                                        </td>
                                    </tr>


                                </table>
                                                Case "ODONTOLOGO"
                                                    @<table>
                                                        


                                                        <tr>
                                                            <td>
                                                                <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Personal/ActualizarCampoROL?Dato=@ViewBag.IdPersonal|ADMINISTRADOR|Rol'">
                                                                    ADMINISTRADOR
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <div style="border:2px solid #000000;background-color:#017272;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                                                                    ODONTOLOGO
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Personal/ActualizarCampoROL?Dato=@ViewBag.IdPersonal|RECEPCION|Rol'">
                                                                    RECEPCIONISTA
                                                                </div>
                                                            </td>
                                                        </tr>


                                                    </table>

        Case "RECEPCION"
                                                                        @<table>
                                                                           


                                                                            <tr>
                                                                                <td>
                                                                                    <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Personal/ActualizarCampoROL?Dato=@ViewBag.IdPersonal|ADMINISTRADOR|Rol'">
                                                                                        ADMINISTRADOR
                                                                                    </div>
                                                                                </td>
                                                                            </tr>

                                                                            <tr>
                                                                                <td>
                                                                                    <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Personal/ActualizarCampoROL?Dato=@ViewBag.IdPersonal|ODONTOLOGO|Rol'">
                                                                                        ODONTOLOGO
                                                                                    </div>
                                                                                </td>
                                                                            </tr>
                                                                            <tr>
                                                                                <td>
                                                                                    <div style="border:2px solid #000000;background-color:#017272;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                                                                                        RECEPCIONISTA
                                                                                    </div>
                                                                                </td>
                                                                            </tr>

                                                                        </table>
                                                                End Select





</body>
</html>
