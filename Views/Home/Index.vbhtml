@Code
    Layout = Nothing
End Code
@Imports Microsoft.AspNet.Identity
<html>
<head>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial; align-content:center;text-align:center ;overflow:hidden;">
    <tbody style="margin:0px;">
        <table style="margin:0px;width:100%;height:100%;border:0px solid red; font-size:9px;color:white;font-family:'Century Gothic','Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif ;">
            <tr>
                <td>
                    @If My.User.IsInRole("ADMINISTRADOR_GENERAL") Then
                        @<iframe name="Paginas" src="/Administrar/Entrada" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow: hidden;"></iframe>
                    elseIf My.User.IsInRole("ADMINISTRADOR") Then
                        @<iframe name="Paginas" src="/Administrar/Entrada" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow: hidden;"></iframe>
                    elseIf My.User.IsInRole("ODONTOLOGO") Then
                        @<iframe name="Paginas" src="/Administrar/Entrada" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow: hidden;"></iframe>
                    elseIf My.User.IsInRole("RECEPCION") Then
                        @<iframe name="Paginas" src="/Administrar/Entrada" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow: hidden;"></iframe>
                    Else
                        @<iframe name="Paginas" src="/Home/SolicitarVinculacion" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow: hidden;"></iframe>
                    End If

                </td>
            </tr>



            @* Inferior*@
            @* Inferior*@
            @* Inferior*@
            @* Inferior*@
            @* Inferior*@

            <tr style="        height: 30px;         background-color: #017272;">

                <td style="width:200px;">
                    Desarrollado por Jimmy Elvis Lazo Torres
                </td>
            </tr>
        </table>
        @* Inferior*@
        @* Inferior*@
        @* Inferior*@
        @* Inferior*@
        @* Inferior*@

        <noscript>
        </noscript>
    </tbody>
   
</body>
</html>
