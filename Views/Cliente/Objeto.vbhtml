@ModelType Proyecto_Web_OdSoft.Clase_G_Cliente

@Code
    Layout = Nothing
    Dim Rol As String = ""
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
    <title>Index</title>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial; overflow:hidden;">
    
    <table>
        <tr>
            <td colspan="3">
                Datos del Cliente @Model.Edad
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
                <input value="@Model.Nombre" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaNombre.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Nombre'">
            </td>
            <td>
                <iframe name="PaginaNombre" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
    


        <tr>
            <td>
                APELLIDO PATERNO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.ApellidoPaterno" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaApellidoPaterno.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|ApellidoPaterno'">
            </td>
            <td>
                <iframe name="PaginaApellidoPaterno" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                APELLIDO MATERNO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.ApellidoMaterno" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaApellidoMaterno.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|ApellidoMaterno'">
            </td>
            <td>
                <iframe name="PaginaApellidoMaterno" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                SEXO
            </td>
            <td colspan="2">
                @*                                                                                                                          Id|value|Campo *@
                <iframe name="PaginaSexo" src="/Cliente/ActualizarCampoSexo?Dato=@Model.IdCliente|@Model.Sexo|Sexo" style="height:30px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>

        </tr>

        <tr>
            <td>
                FECHA NACIMIENTO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Format(Model.FechaNacimiento, "yyyy-MM-dd")" type="date" onblur="PaginaFechaNacimiento.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|FechaNacimiento'">
            </td>
            <td>
                <iframe name="PaginaFechaNacimiento" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                NACIONALIDAD
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Nacionalidad  " type="text" onblur="PaginaNacionalidad.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Nacionalidad'">
            </td>
            <td>
                <iframe name="PaginaNacionalidad" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                DNI O DE IDENTIFICACION
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.DNI  " type="text" onblur="PaginaDNI.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|DNI'">
            </td>
            <td>
                <iframe name="PaginaDNI" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                OCUPACIÓN
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Ocupacion  " type="text" onblur="PaginaOcupacion.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Ocupacion'">
            </td>
            <td>
                <iframe name="PaginaOcupacion" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                DIRECCION
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Direccion  " type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaDireccion.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Direccion'">
            </td>
            <td>
                <iframe name="PaginaDireccion" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>


        <tr>
            <td>
                DEPARTAMENTO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Departamento " type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaRegion.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Departamento'">
            </td>
            <td>
                <iframe name="PaginaRegion" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                PROVINCIA
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Provincia" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaProvincia.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Provincia'">
            </td>
            <td>
                <iframe name="PaginaProvincia" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                DISTRITO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Distrito" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaDistrito.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Distrito'">
            </td>
            <td>
                <iframe name="PaginaDistrito" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                CORREO ELECTRÓNICO
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.CorreoElectronico" type="number" onblur="PaginaCorreoElectronico.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|CorreoElectronico'">
            </td>
            <td>
                <iframe name="PaginaCorreoElectronico" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                Autoriza envio de promociones a CorreoElectronico
            </td>
            <td colspan="2">

                @*                                                                                                                          Id|value|Campo *@
                <iframe name="PaginaAutorizaCorreoElectronico" src="/Cliente/ActualizarCampoAutorizaCorreoElectronico?Dato=@Model.IdCliente|@Model.AutorizaCorreoElectronico|AutorizaCorreoElectronico" style="height:30px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>

        </tr>
        <tr>
            <td>
                CELULAR
            </td>
            <td>

                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Celular" type="number" onblur="PaginaCelular.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Celular'" onkeyup="PaginaWhatsApp.location.href='/Cliente/WhatsApp?Dato='+this.value+''">
            </td>
            <td>
                <iframe name="PaginaCelular" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>

        </tr>
        <tr>
            <td>
                Autoriza envio de promociones a WhatsApp
            </td>
            <td colspan="2">
                @*                                                                                                                          Id|value|Campo *@
                <iframe name="PaginaAutorizaWhatsApp" src="/Cliente/ActualizarCampoAutorizaWhatsApp?Dato=@Model.IdCliente|@Model.AutorizaWhatsApp|AutorizaWhatsApp" style="height:30px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>

        </tr>

        <tr>
            <td>
                WHATSAPP
            </td>
            <td colspan="2">
                <iframe name="PaginaWhatsApp" src="/Cliente/WhatsApp?Dato=@Model.Celular" style="margin:0px;width: 100px; height:40px;border:0px solid blue;overflow-y:hidden;"></iframe>

            </td>
        </tr>
        <tr>
            <td>
                RECOMENDACION
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.QuienRecomendo" type="text" onblur="PaginaQuienRecomendo.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|QuienRecomendo'">
            </td>
            <td>
                <iframe name="PaginaQuienRecomendo" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>
        <tr>
            <td>
                OBSERVACIONES
            </td>
            <td>
                @*                                                                                                                          Id|value|Campo *@
                <input value="@Model.Observacion" type="text" onblur="PaginaObservaciones.location.href='/Cliente/ActualizarCampo?Dato=@Model.IdCliente|'+this.value+'|Observaciones'">
            </td>
            <td>
                <iframe name="PaginaObservaciones" src="/Cliente/SinActualizacion" style="margin:0px;width: 200px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
            </td>
        </tr>

    </table>
</body>
</html>
