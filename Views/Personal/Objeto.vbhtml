@ModelType Proyecto_Web_OdSoft.Clase_G_Personal

@Code
    Layout = Nothing
End Code

 

<html>
<head>
    <title>Index</title>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial; overflow:hidden;">

    <table>
        <tr>
            <td colspan="3">
                Datos del Personal
            </td>

        </tr>
        <tr>
            <td colspan="3" style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial;color:red  ;overflow:hidden;">
                @Model.Mensaje  
            </td>

        </tr>
        <tr>
            <td>
                NOMBRE
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Nombre" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaNombre.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|Nombre'">
            </td>
            <td>
                <iframe name="PaginaNombre" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                APELLIDO PATERNO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.ApellidoPaterno" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaApellidoPaterno.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|ApellidoPaterno'">
            </td>
            <td>
                <iframe name="PaginaApellidoPaterno" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                APELLIDO MATERNO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.ApellidoMaterno" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaApellidoMaterno.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|ApellidoMaterno'">
            </td>
            <td>
                <iframe name="PaginaApellidoMaterno" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                SEXO
            </td>
            <td colspan="2">
                @*                                                                                                                          Id|value|Campo *@
                <iframe name="PaginaSexo" src="/Personal/ActualizarCampoSexo?Dato=@Model.IdPersonal|@Model.Sexo|Sexo" style="height:30px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>

        </tr>

        <tr>
            <td>
                FECHA NACIMIENTO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Format(Model.FechaNacimiento, "yyyy-MM-dd")" type="date" onblur="PaginaFechaNacimiento.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|FechaNacimiento'">
            </td>
            <td>
                <iframe name="PaginaFechaNacimiento" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                DNI
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.DNI  " type="text" onblur="PaginaDNI.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|DNI'">
            </td>
            <td>
                <iframe name="PaginaDNI" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                DIRECCION
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Direccion  " type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaDireccion.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|Direccion'">
            </td>
            <td>
                <iframe name="PaginaDireccion" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>


        <tr>
            <td>
                REGION
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Region " type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaRegion.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|Region'">
            </td>
            <td>
                <iframe name="PaginaRegion" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                PROVINCIA
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Provincia" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaProvincia.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|Provincia'">
            </td>
            <td>
                <iframe name="PaginaProvincia" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                DISTRITO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Distrito" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaDistrito.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|Distrito'">
            </td>
            <td>
                <iframe name="PaginaDistrito" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                CORREO ELECTRÓNICO
            </td>
            <td>
                @Model.CorreoElectronico
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                CELULAR
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Telefonos" type="number" onblur="PaginaTelefonos.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|Telefonos'" onkeyup="PaginaWhatsApp.location.href='/Personal/WhatsApp?Dato='+this.value+''">
            </td>
            <td>
                <iframe name="PaginaTelefonos" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>

        </tr>
        <tr>
            <td>
                WHATSAPP
            </td>
            <td colspan="2">
                <iframe name="PaginaWhatsApp" src="/Personal/WhatsApp?Dato=@Model.Telefonos" style="margin:0px;width: 100px; height:40px;border:0px solid blue;overflow-y:hidden;"></iframe>

            </td>
        </tr>
        <tr>
            <td>
                ESPECIALIDAD
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Especialidad" type="text" onblur="PaginaEspecialidad.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|Especialidad'">
            </td>
            <td>
                <iframe name="PaginaEspecialidad" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                OBSERVACIONES
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Observaciones" type="text" onblur="PaginaObservaciones.location.href='/Personal/ActualizarCampo?Dato=@Model.IdPersonal|'+this.value+'|Observaciones'">
            </td>
            <td>
                <iframe name="PaginaObservaciones" src="/Personal/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                ROL:Según el rol que pose el personal podra interactuar con la aplicacion
            </td>
            <td colspan="2">
                @*                                                                                                                          Id|value|Campo *@
                <iframe name="PaginaRol" src="/Personal/ActualizarCampoROL?Dato=@Model.IdPersonal|@Model.ROL|Rol" style="height:100px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>

        </tr>
    </table>
</body>
</html>
