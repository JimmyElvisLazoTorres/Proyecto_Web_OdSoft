
@Code
    Layout = Nothing
End Code


<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Dispositivos</title>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial; align-content:center;text-align:center ;">
  
    <table style="margin:0px;width:100%;height:100%;">
        <tr style="    height: 100px; ">
            <td style="border: 6px solid #017272; background-color: #017272;">
                <div style="background-color: white; float: left; padding: 0px 12px 0px; height: 100%; border-radius: 5px; border: 2px ridge #017272; color: #017272; font-family: 'Century Gothic',Arial; align-content: center; text-align: center;">
                    <img src="~/Content/dispositivo.png" Style="height:60px" />
                    <div>
                        <H5 style=" margin-bottom: 0px; margin-top: 0px;">Dispositivos</H5>
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

                        <table style="float: left; width:100%; height: 100%; ">
                            <tr style="height:20px;">
                                <td>
                                    <H5 style=" margin-bottom: 0px; margin-top: 0px;">Buscar</H5>
                                </td>
                                <td>
                                    <input />
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <iframe name="PaginaLista" src="/Dispositivo/Lista" style="margin:0px;width: 100%; height:100%;border:0px solid blue;"></iframe>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>


            </td>
        </tr>
    </table>

   
</body>
</html>
