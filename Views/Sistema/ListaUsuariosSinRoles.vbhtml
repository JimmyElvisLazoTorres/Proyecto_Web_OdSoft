@ModelType IEnumerable(Of Proyecto_Web_OdSoft.Clase_S_User)

@Code
    Layout = Nothing
    Dim AuxNombre As String = ""
End Code


    <html>
    <head>
        <meta name="viewport" content="width=device-width" />
        <title>Lista</title>
    </head>
    <body>

        <div style="overflow-y: scroll; float: left; padding: 0px 12px 0px; width: 100%; height: 100%; border-radius: 5px; color: #017272; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
            <div>
                <img style="width:40px; height:40px; padding-left:10px;border:2px solid transparent;" src="~/Content/imagenes/Advertencia.png" />
                Cuando le de click en el USUARIO, tendra el rol de ADMINISTRADOR_GENERAL de la empresa que dirije, con este rol podra ser habilitado para poder registrar su empresa
                <table style="width:100%;">

                    @For Each item As Proyecto_Web_OdSoft.Clase_S_User In Model
                        @<text>
                            @if item.Email = AuxNombre Then

                            Else
                                @<tr>
                                    <td colspan="3">
                                        <div style="height:0px;border:0px solid white;background-color:white ;color:white ;">
                                            <div style="float:left;padding-left:1px;">
                                                @*@item.Email*@
                                            </div>
                                        </div>

                                    </td>
                                </tr>
                                @code
                                    AuxNombre = item.Email
                                End Code
                            End If
                            <tr>
                                <td></td>

                                <td>
                                    <div style="height:25px;border:2px solid #000000;background-color:#017272;color:white;font-size:21px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Sistema/UsuarioComoADMINISTRADORGENERAL?UserId=@item.UserId.ToString'">
                                        <div style="float:left;">
                                            <img style="width:20px; height:20px; padding-left:10px;border:2px solid transparent;" src="~/Content/imagenes/User.png" />
                                        </div>
                                        <div style="float:left;padding-left:10px;">
                                            @item.Email
                                        </div>
                                    </div>
                                </td>

                            </tr>
                        </text>
                    Next

                </table>
            </div>
        </div>

        







    </body>
    </html>
