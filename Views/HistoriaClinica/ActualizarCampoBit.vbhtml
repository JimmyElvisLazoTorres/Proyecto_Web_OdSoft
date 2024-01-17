
@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>ActualizarCampoBit</title>
</head>
<body style="margin:0px;">

    @Select Case ViewBag.Respuesta
        Case "True"
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
                        <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/HistoriaClinica/ActualizarCampoBit?Dato=@ViewBag.Id|False|@ViewBag.Campo'">
                            NO
                        </div>
                    </td>
                </tr>
            </table>
        Case "False"
                                @<table>
                                    <tr>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/HistoriaClinica/ActualizarCampoBit?Dato=@ViewBag.Id|True|@ViewBag.Campo'">
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
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/HistoriaClinica/ActualizarCampoBit?Dato=@ViewBag.Id|True|@ViewBag.Campo'">
                                                SI
                                            </div>
                                        </td>
                                        <td>
                                            <div style="border:2px solid #000000;background-color:#9B9B9B;color:white;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/HistoriaClinica/ActualizarCampoBit?Dato=@ViewBag.Id|False|@ViewBag.Campo'">
                                                NO
                                            </div>
                                        </td>
                                    </tr>
                                </table>
    End Select





</body>
</html>
