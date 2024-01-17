@ModelType IEnumerable(Of Proyecto_Web_OdSoft.Clase_G_Personal)

@Code
    Layout = Nothing
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
               





                @For Each item As Proyecto_Web_OdSoft.Clase_G_Personal In Model
                     @<text>

                        <tr>
                            <td></td>

                            <td>
                                @If item.PersonalClienteVinculado > 0 Then
                                    @<div style="height:25px;border:2px solid #000000;background-color:#017272;color:white;font-size:21px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;">
                                        <div style="float:left;">
                                            <img style="width:20px; height:20px; padding-left:10px;border:2px solid transparent;" src="~/Content/imagenes/feliz.png" />
                                        </div>
                                        <div style="float:left;padding-left:10px;">
                                            @item.NombreCompleto
                                        </div>
                                        <div style="float:left;padding-left:10px;">
                                            @item.PersonalClienteVinculado
                                        </div>
                                    </div>
                                Else
                                    @<div style="height:25px;border:2px solid #000000;background-color:dimgray;color:white;font-size:21px; border-radius:15px;font-family:neo-sans-intel, tahoma, helvetica, Verdana, Sans-Serif;align-items:center;vertical-align:text-bottom;" onclick="location.href='/Cliente/VincularClienteConProfesionalOdontologo?Dato=@item.IdPersonal.ToString|@item.IdClienteVinculado'">
                                        <div style="float:left;">
                                            <img style="width:20px; height:20px; padding-left:10px;border:2px solid transparent;" src="~/Content/imagenes/asingnarodontologo.png" />
                                        </div>
                                        <div style="float:left;padding-left:10px;">
                                            @item.NombreCompleto
                                        </div>
                                        
                                    </div>
                                End If



                            </td>
                       
                        </tr>
                    </text>
                Next

            </table>
        </div>
    </div>

  






</body>
</html>