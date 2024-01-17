
@Code
    Layout = Nothing
End Code


<Html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Permisos de uso de aplicación</title>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial; align-content:center;text-align:center ; overflow:hidden;">

    <Table style="margin:0px;width:100%;height:100%;">
        <tr style="    height: 100px; ">
            <td style="border: 6px solid #017272; background-color: #017272;">
                <div style="background-color: white; float: left; padding: 0px 12px 0px; height: 100%; border-radius: 5px; border: 2px ridge #017272; color: #017272; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                    <img src="~/Content/imagenes/clientes.png" Style="height:60px" />
                    <div>
                        <H5 style=" margin-bottom: 0px; margin-top: 0px;">Permiso de uso de aplicación</H5>
                    </div>
                </div>
                <div style="float: left; padding: 0px 2px 0px; height: 100%; border-radius: 5px; border: 2px; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                </div>
                <div onclick="Paginas.location.href='Entrada'" style="float: left; padding: 0px 12px 0px; height: 100%; border-radius: 5px; border: 2px ridge gold; color: gold; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                    <img src="~/Content/dispositivo.png" Style="height:60px" />
                    <div>
                        <H5 style=" margin-bottom: 0px; margin-top: 0px;">Entrada</H5>
                    </div>
                </div>
                <div style="float: left; padding: 0px 2px 0px; height: 100%; border-radius: 5px; border: 2px; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                </div>
                <div onclick="Paginas.location.href='Entrada'" style="float: left; padding: 0px 12px 0px; height: 100%; border-radius: 5px; border: 2px ridge gold; color: gold; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                    <img src="~/Content/dispositivo.png" Style="height:60px" />
                    <div>
                        <H5 style=" margin-bottom: 0px; margin-top: 0px;">Entrada</H5>
                    </div>
                </div>
                <div style="float: left; padding: 0px 2px 0px; height: 100%; border-radius: 5px; border: 2px; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                </div>

            </td>
        </tr>
        <tr style="    height: 100%; ">
            <td style="background-color:white ;">
                <div style="float: left; padding: 0px 12px 0px; width:98%; height: 100%; border-radius: 5px; color: gold; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                    <div>

                        <table style="float: left; ">
                            <tr style="height:20px;">
                                <td>
                                    <H5 style=" margin-bottom: 0px; margin-top: 0px;">Buscar</H5>
                                </td>
                                <td>
                                   
                                    <input  name="Buscar" onkeyup="PaginaLista.location.href = '/Sistema/ListaUsuariosSinRoles?Buscar='+this.value" />
                                </td>
                                <td>

                                   
                                </td>

                            </tr>
                        </table>
                        <br /><br />


                        <table style="margin:0px;width:100%;height:100%;">
                            <tr>
                                <td>
                                    <iframe name="PaginaLista" src="/Sistema/ListaUsuariosSinRoles" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow:hidden;"></iframe>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>


            </td>
        </tr>
    </Table>


</body>
</Html>
