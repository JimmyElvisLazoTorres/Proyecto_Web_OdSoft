@ModelType IEnumerable(Of Proyecto_Web_OdSoft.Clase_G_Cliente)

@Code
    Layout = Nothing
    Dim AuxId As String = ""
    Dim AuxEsPrimero As Boolean = True
     Dim Rol As String = "NOOOOOOOOOOOO"
    If User.IsInRole("ADMINISTRADOR_GENERAL") Then
        Rol = "ADMINISTRADOR_GENERAL"
    End If
    If User.IsInRole("ADMINISTRADOR") Then
        Rol = "ADMINISTRADOR"
    End If
    If User.IsInRole("RECEPCIONISTA") Then
        Rol = "RECEPCIONISTA"
    End If
End Code


<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Lista</title>
</head>
<body>

    <div style="overflow-y: scroll; float: left; padding: 0px 12px 0px; width: 47%; height: 100%; border-radius: 5px; color: #017272; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="3">
                        <div onclick="PaginaObjeto.location.href='/Cliente/Objeto'" style="float: right; padding: 0px 12px 0px; height: 100%; border-radius: 5px; border: 2px ridge gold; color: gold; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                            <table>
                                <tr>
                                    <td>
                                        Agregar
                                    </td>
                                    <td>
                                        <img style="height:20px;width:20px;" src="~/Content/imagenes/Mas.png">
                                    </td>
                                </tr>
                            </table>
                        </div>

                    </td>
                </tr>





                @For Each item As Proyecto_Web_OdSoft.Clase_G_Cliente In Model
                    If AuxEsPrimero Then
                        AuxId = item.IdCliente
                        AuxEsPrimero = False
                    End If
                    @<text>

                                    <tr>

                                        @If Rol = "ADMINISTRADOR_GENERAL" Or Rol = "ADMINISTRADOR" Then

                                            @<td>
                                                <div style="height:25px;border:2px solid #000000;background-color:#017272;color:white;font-size:21px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="PaginaObjeto.location.href='/Cliente/Objeto?Id=@item.IdCliente.ToString'">
                                                    <div style="float:left;">
                                                        <img style="width:20px; height:20px; padding-left:10px;border:2px solid transparent;" src="~/Content/imagenes/User.png" />
                                                    </div>
                                                    <div style="float:left;padding-left:10px;">
                                                        @item.NombreCompleto
                                                    </div>
                                                </div>
                                            </td>
                                            @<td style="width:25px;">
                                                <div style="height:25px;background-color:transparent;" onclick="window.open( '/HistoriaClinica?Id=@item.IdCliente','Historia Clinica','width=10000,height=10000,location=no, status=no,toolbar=no,menubar=no,scrollbars=no,');">
                                                    <img style="height:25px;width:25px;" src="~/Content/imagenes/diente.png" />
                                                </div>
                                            </td>
                                            @<td style="width:25px;">
                                                <div style="height:25px;background-color:transparent;" onclick="PaginaObjeto.location.href='/Cliente/VincularClienteConProfesional?IdCliente=@item.IdCliente.ToString'">
                                                    <img style="height:25px;width:25px;" src="~/Content/imagenes/asingnarodontologo.png" />
                                                </div>
                                            </td>
                                        Else
                                            @<td>
                                                <div style="height:25px;border:2px solid #000000;background-color:#017272;color:white;font-size:21px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="PaginaObjeto.location.href='/Cliente/Objeto?Id=@item.IdCliente.ToString'">
                                                    <div style="float:left;">
                                                        <img style="width:20px; height:20px; padding-left:10px;border:2px solid transparent;" src="~/Content/imagenes/User.png" />
                                                    </div>
                                                    <div style="float:left;padding-left:10px;">
                                                        @item.NombreCompleto
                                                    </div>
                                                </div>
                                            </td>

                                            @<td style="width:25px;">
                                                <div style="height:25px;background-color:transparent;" onclick="PaginaObjeto.location.href='/Cliente/VincularClienteConProfesional?IdCliente=@item.IdCliente.ToString'">
                                                    <img style="height:25px;width:25px;" src="~/Content/imagenes/asingnarodontologo.png" />
                                                </div>
                                            </td>
                                        End If
                                    </tr>
                    </text>
                Next

            </table>
                                            </div>
                                        </div>

                                        <div style = "float: left; padding: 0px 2px 0px;  width:1%;height: 100%; border-radius: 5px; border: 2px; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;" >
                                        </div>
                                        <div style = "overflow-x:scroll;float: left; padding: 0px 12px 0px; width:47%; height: 100%; border-radius: 5px; border: 0px ridge gold; color: gold; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;" >
                                            <div>
                                    @If AuxId = "" Then
                                    @<iframe name="PaginaObjeto" src="/Cliente/EnBlanco" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow:hidden;"></iframe>
                                    Else
                                    @<iframe name="PaginaObjeto" src="/Cliente/Objeto?Id=@AuxId" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow:hidden;"></iframe>
                                    End If


                                            </div>
                                                                    </div>







</body>
</html>
