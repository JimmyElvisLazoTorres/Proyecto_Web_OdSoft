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

    Dim Aux_Contar_Activos As Integer = 0

    Dim Aux_IdHistoriaClinicaActivo As String = ""
    For Each item As Proyecto_Web_OdSoft.Clase_O_HistoriaClinica In Model.Lista_Clase_O_HistoriaClinica
        If item.Activo Then
            Aux_Contar_Activos = Aux_Contar_Activos + 1
            Aux_IdHistoriaClinicaActivo = item.IdHistoriaClinica
        End If
    Next
End Code



<html>
<head>
    <title>Index</title>
</head>
<body topmargin="0" leftmargin="0" marginwidth="0" marginheight="0" scroll="no" style="overflow:hidden;font:12px arial,verdana;">
    <table border="1" cellspacing="1" style="border-collapse: collapse" bordercolor=" #9368A8" width="100%">

        <tr>
            <td colspan="2" style="background-color: #9368A8;color:white;font:30px arial,verdana;" width="100%">
                @Model.NombreCompleto
            </td>
        </tr>
        <tr>

            <td style="background-color: #9368A8;color:white;font:10px arial,verdana;" width="10%">
                Observaciones
            </td>

            <td>
                @Model.Observacion
            </td>
        </tr>


    </table>
    <table border="1" cellspacing="1" style="border-collapse: collapse" bordercolor=" #9368A8" width="100%" height="100%">

        <tr>
            <td style="background-color: #9368A8;color:white;font:30px arial,verdana;" width="30px" height="100%">
                @If Aux_Contar_Activos = 0 Then
                    @<div onclick="location.href='/HistoriaClinica/AgregarHistoria?Id=@Model.IdCliente'"><img src="~/Content/imagenes/agregahistoria.png" style="width:30px;height:30px;"/> </div>
                End If
                @For Each item As Proyecto_Web_OdSoft.Clase_O_HistoriaClinica In Model.Lista_Clase_O_HistoriaClinica
                    If item.Activo Then
                        Aux_Contar_Activos = Aux_Contar_Activos + 1
                        @<div onclick="PaginaObjeto.location.href='/HistoriaClinica/Anamnesis?Id=@item.IdHistoriaClinica.ToString'"><img src="~/Content/imagenes/Diente.png" style="width:30px;height:30px;"/> </div>
                    Else
                        @<div onclick="PaginaObjeto.location.href='/HistoriaClinica/Anamnesis?Id=@item.IdHistoriaClinica.ToString'"><img src="~/Content/imagenes/dientecurado.png"  style="width:30px;height:30px;"/> </div>
                    End If
                Next
            </td>
            <td style="background-color: #9368A8;color:white;font:10px arial,verdana;" width="100%">
                @If Aux_Contar_Activos = 0 Then
                    @<iframe name="PaginaObjeto" src="/HistoriaClinica/EnBlanco" style="margin:0px;width: 100%; height:100%;border:0px solid blue;overflow:hidden;"></iframe>
                Else
                    @<iframe name="PaginaObjeto" src="/HistoriaClinica/Anamnesis?Id=@Aux_IdHistoriaClinicaActivo" style="margin:0px;width: 100%;height:100%; border:0px solid blue;overflow:hidden;"></iframe>
                End If

            </td>
            </tr>
            <tr>
            </tr>


        </table>



</body>
</html>
