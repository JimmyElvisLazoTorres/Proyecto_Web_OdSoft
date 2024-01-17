@ModelType IEnumerable(Of Proyecto_Web_OdSoft.Clase_G_Dispositivo)

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

    <div style="overflow-y: scroll; float: left; padding: 0px 12px 0px; width: 47%; height: 100%; border-radius: 5px; color: #017272; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
       <div>
            <table style="width:100%;">

                @For Each item As Proyecto_Web_OdSoft.Clase_G_Dispositivo In Model
                    @<text>
                        @if item.NombreDispositivo = AuxNombre Then

                        Else
                            @<tr>
                                <td colspan="3">
                                    <div style="height:25px;border:2px solid white;background-color:red ;color:black ;font-size:15px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                                        <div style="float:left;padding-left:10px;">
                                            @item.NombreDispositivo
                                        </div>
                                    </div>

                                </td>
                            </tr>
                            @code
                                AuxNombre = item.NombreDispositivo
                            End Code
                        End If
                        <tr>
                            <td></td>

                            <td>
                                <div style="height:25px;border:2px solid #000000;background-color:#017272;color:white;font-size:21px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="PaginaObjeto.location.href='/Dispositivo/Objeto?Id=@item.Id.ToString'">
                                    <div style="float:left;">
                                        <img style="width:20px; height:20px; padding-left:10px;border:2px solid transparent;" src="~/Content/dispositivo.png" />
                                    </div>
                                    <div style="float:left;padding-left:10px;">
                                        @item.NombreDispositivo
                                    </div>
                                </div>
                            </td>
                            <td style="width:25px;">
                                <div style="height:25px;background-color:transparent;" onclick="location.href = 'EliminarSeleccionado?Id=@item.Id';">
                                    <img style="height:25px;width:25px;" src="~/Content/eliminar.png" />
                                </div>
                            </td>
                        </tr>
                    </text>
                                Next

            </table>
        </div>
    </div>
   
    <div style="float: left; padding: 0px 2px 0px;  width:1%;height: 100%; border-radius: 5px; border: 2px; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
    </div>
    <div style="overflow-x:scroll;float: left; padding: 0px 12px 0px; width:47%; height: 100%; border-radius: 5px; border: 0px ridge gold; color: gold; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
        <div>
            <H5 style=" margin-bottom: 0px; margin-top: 0px;">Entrada</H5>
            <iframe name="PaginaObjeto" src="/Dispositivo/Objeto?Id=@Model" style="margin:0px;width: 100%; height:100%;border:0px solid blue;"></iframe>
        </div>
    </div>







</body>
</html>
