@ModelType Proyecto_Web_OdSoft.Clase_O_HistoriaClinica
@Code
    Layout = Nothing
    Dim Rol As String = ""
    If User.IsInRole("ADMINISTRADOR_GENERAL") Then
        Rol = "ADMINISTRADOR_GENERAL"
    End If
    If User.IsInRole("ADMINISTRADOR") Then
        Rol = "ADMINISTRADOR"
    End If
    If User.IsInRole("ASISTENTE") Then
        Rol = "ASISTENTE"
    End If
End Code

<html>
<head>
    <title>HistoriaClinica</title>
</head>
<body style="margin:0px;zoom:100%;font-family:'Century Gothic',Arial;background-color:white;">
    <table style=" width:100%;height:100%; box-decoration-break:inherit;" >
        <tr>
            <td>

                <div style="font-size:30px;">
                    <table style=" width:100%;">
                        <tr>
                            <td>
                                <div style="font-size:30px;">
                                    Numero Historia: @Model.NroHistoriaclinica.ToString
                                </div>
                            </td>
                            <td>
                                <div style="font-size:30px;">
                                    Especialista:@Model.specialistaNombreCompleto
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>

        </tr>
        <tr>
            <td>
                <table style=" width:100%;">
                    <tr>
                        <td>
                            <div style="font-size:30px;">
                                Anamnesis
                            </div>
                        </td>
                        <td>
                            <div style="background-color:#9368A8;font-size:30px;color:white;">
                                Odontograma
                            </div>
                        </td>
                    </tr>
                </table>



            </td>
        </tr>

        <tr>
            <td colspan="7" style="background-color: #9368A8; font-size: 15px; color: white; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                Datos del paciente
            </td>
        </tr>
        <tr>
            <td>
                <table style=" width:100%;">
                    <tr>
                        <td>
                            Edad:
                        </td>
                        <td>
                            @Model.EdadCliente
                        </td>
                        <td>
                        </td>
                        <td>
                            Nombre Apoderado:
                        </td>
                        <td>
                            <input value="@Model.NombreApoderado" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaNombreApoderado.location.href='/HistoriaClinica/ActualizarCampo?Dato=@Model.IdHistoriaClinica|'+this.value+'|NombreApoderado'"><iframe name="PaginaNombreApoderado" src="/HistoriaClinica/SinActualizacion" style="margin:0px;width: 40px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Estado Civil:
                        </td>
                        <td>

                            <input value="@Model.AnamnesisEstadoCivil" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaAnamnesisEstadoCivil.location.href='/HistoriaClinica/ActualizarCampo?Dato=@Model.IdHistoriaClinica|'+this.value+'|AnamnesisEstadoCivil'">

                            <iframe name="PaginaAnamnesisEstadoCivil" src="/HistoriaClinica/SinActualizacion" style="margin:0px;width: 40px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                        <td>
                        </td>
                        <td>
                            Ocupación:
                        </td>
                        <td>
                            <input value="@Model.AnamnesisOcupacion" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaAnamnesisOcupacion.location.href='/HistoriaClinica/ActualizarCampo?Dato=@Model.IdHistoriaClinica|'+this.value+'|AnamnesisOcupacion'">

                            <iframe name="PaginaAnamnesisOcupacion" src="/HistoriaClinica/SinActualizacion" style="margin:0px;width: 40px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="background-color: #9368A8; font-size: 15px; color: white; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                Estado en los ultimos 15 dias
            </td>
        </tr>
        <tr>
            <td>
                <table style=" width:100%;">
                    <tr>
                        <td style="width:40%;">
                            1. ¿Ha tenido fiebre?
                        </td>
                        <td style="width:9%;">
                            <iframe name="PaginaAnamnesis15DiasFiebre" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis15DiasFiebre.ToString()|Anamnesis15DiasFiebre" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                        <td>
                        </td>
                        <td style="width:40%;">
                            6.  ¿Ha tenido sensación de mucho cansacio?
                        </td>
                        <td style="width:9%;">
                            <iframe name="PaginaAnamnesis15DiasCansancio" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis15DiasCansancio.ToString()|Anamnesis15DiasCansancio" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            2.  ¿Ha tenido dolor de garganta?
                        </td>
                        <td>
                            <iframe name="PaginaAnamnesis15DiasGarganta" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis15DiasGarganta.ToString()|Anamnesis15DiasGarganta" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                        <td>
                        </td>
                        <td>
                            7. ¿Ha tenido visión doble?
                        </td>
                        <td>
                            <iframe name="PaginaAnamnesis15DiasVisionDoble" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis15DiasVisionDoble.ToString()|Anamnesis15DiasVisionDoble" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            3. ¿Ha tenido pérdida del gusto o del olfato?
                        </td>
                        <td>
                            <iframe name="PaginaAnamnesis5DiasPerdidaOlfatoGusto" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis5DiasPerdidaOlfatoGusto.ToString()|Anamnesis5DiasPerdidaOlfatoGusto" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                        <td>
                        </td>
                        <td>
                            8. ¿Es fumador de cigarros?
                        </td>
                        <td>
                            <iframe name="PaginaAnamnesis15DiasFumador" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis15DiasFumador.ToString()|Anamnesis15DiasFumador" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            4.  ¿Ha tenido algun problema respiratorio, tos, fatiga?
                        </td>
                        <td>
                            <iframe name="PaginaAnamnesis15DiasProblemasRespiratorios" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis15DiasProblemasRespiratorios.ToString()|Anamnesis15DiasProblemasRespiratorios" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                        <td>
                        </td>
                        <td>
                            9. ¿Cree usted que esta embarazada?
                        </td>
                        <td>
                            <iframe name="PaginaAnamnesis15DiasEmbarazada" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis15DiasEmbarazada.ToString()|Anamnesis15DiasEmbarazada" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            5.  ¿Ha tenido diarrea o algun problema digestivo?
                        </td>
                        <td>
                            <iframe name="PaginaAnamnesis15DiasDiarrea" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.Anamnesis15DiasDiarrea.ToString()|Anamnesis15DiasDiarrea" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                        </td>
                    </tr>
                </table>
    </td>
    </tr>



    <tr>
        <td  style="background-color: #9368A8; font-size: 15px; color: white; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
            Padece de alguna enfermedad
        </td>
    </tr>

    <tr>
        <td>
            <table style=" width:100%;">
                <tr>

                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        Cardiovasculares
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        Respiratorias
                    </td>
                </tr>
                <tr>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        <table>
                            <tr>
                                <td style="width:40%;">
                                    Marcapasos
                                </td>
                                <td style="width:8%;">
                                    <iframe name="PaginaAnamnesisCardioVascularMarcapasos" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisCardioVascularMarcapasos.ToString()|AnamnesisCardioVascularMarcapasos" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Hipertensión (tensión alta)
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisCardioVascularHipertension" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisCardioVascularHipertension.ToString()|AnamnesisCardioVascularHipertension" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Infarto, insuficencia coronaria
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisCardioVascularCadiacas" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisCardioVascularCadiacas.ToString()|AnamnesisCardioVascularCadiacas" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Protesis valvular,stents
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisCardioVascularProtesisValvular" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisCardioVascularProtesisValvular.ToString()|AnamnesisCardioVascularProtesisValvular" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    Fiebre reumática
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisCardioVascularFiebreReumatica" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisCardioVascularFiebreReumatica.ToString()|AnamnesisCardioVascularFiebreReumatica" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        <table>

                            <tr>
                                <td style="width:40%;">
                                    Insuficiencia respiratoria
                                </td>
                                <td style="width:8%;">
                                    <iframe name="PaginaAnamnesisRespiratoriasIsuficienciaRespiratoria" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisRespiratoriasIsuficienciaRespiratoria.ToString()|AnamnesisRespiratoriasIsuficienciaRespiratoria" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Asma
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisRespiratoriasAsma" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisRespiratoriasAsma.ToString()|AnamnesisRespiratoriasAsma" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tuberculosis
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisRespiratoriasTuberculosis" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisRespiratoriasTuberculosis.ToString()|AnamnesisRespiratoriasTuberculosis" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                        </table>
                    </td>

                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>

                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        Hematológicas
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        Digestivas
                    </td>
                </tr>
                <tr>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        <table>
                            <tr>
                                <td style="width:40%;">
                                    Alteracion coagulacion
                                </td>
                                <td style="width:8%;">
                                    <iframe name="PaginaAnamnesisHematologicaAlteracionCoagulacion" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisHematologicaAlteracionCoagulacion.ToString()|AnamnesisHematologicaAlteracionCoagulacion" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Anemia
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisHematologicaAnemia" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisHematologicaAnemia.ToString()|AnamnesisHematologicaAnemia" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>

                        </table>
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        <table>
                            <tr>
                                <td style="width:40%;">
                                    Problemas de estomago (Gastritis, hernia de hiato , úlcera)
                                </td>
                                <td style="width:8%;">
                                    <iframe name="PaginaAnamnesisDigestivasProblemasEstomacales" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisDigestivasProblemasEstomacales.ToString()|AnamnesisDigestivasProblemasEstomacales" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Problemas de Higado (hepatitis, cirrosis,ictericia)
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisDigestivasProblemasHigado" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisDigestivasProblemasHigado.ToString()|AnamnesisDigestivasProblemasHigado" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>


                        </table>
                    </td>

                </tr>
                <tr>
                    <td>
                    </td>
                </tr>
                <tr>

                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        Endocrinas
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        Renales
                    </td>
                </tr>
                <tr>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        <table>
                            <tr>
                                <td style="width:40%;">
                                    Diabetes
                                </td>
                                <td style="width:8%;">
                                    <iframe name="PaginaAnamnesisEndocrinasDiabetes" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisEndocrinasDiabetes.ToString()|AnamnesisEndocrinasDiabetes" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tiroides
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisEndocrinasTiroides" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisEndocrinasTiroides.ToString()|AnamnesisEndocrinasTiroides" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>

                        </table>
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                    </td>
                    <td style="background-color:white; font-size: 15px; color:  #9368A8; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
                        <table>

                            <tr>
                                <td style="width:40%;">
                                    Insuficiencia Renal
                                </td>
                                <td style="width:8%;">
                                    <iframe name="PaginaAnamnesisRenalesInsuficienciaRenal" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisRenalesInsuficienciaRenal.ToString()|AnamnesisRenalesInsuficienciaRenal" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    Dialisis
                                </td>
                                <td>
                                    <iframe name="PaginaAnamnesisRenalesDialisis" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisRenalesDialisis.ToString()|AnamnesisRenalesDialisis" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                                </td>
                            </tr>

                        </table>
                    </td>


                </tr>
            </table>
        </td>
    </tr>

    <tr>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="7" style="background-color: #9368A8; font-size: 15px; color: white; margin: 0px; zoom: 100%; font-family: 'Century Gothic',Arial; overflow: hidden;">
            Otros de importancia
        </td>
    </tr>
    
    <tr>
        <td>
            <table style=" width:100%;">
                <tr>
                    <td>
                        Alegia a algun medicamento
                    </td>
                    <td>
                        <iframe name="PaginaAnamnesisAlegiaMedicamento" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisAlegiaMedicamento.ToString()|AnamnesisAlegiaMedicamento" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                    </td>
                </tr>
                <tr>
                    <td>
                        Alteracion nerviosa
                    </td>
                    <td>
                        <iframe name="PaginaAnamnesisAlteracionNerviosa" src="/HistoriaClinica/ActualizarCampoBit?Dato=@Model.IdHistoriaClinica|@Model.AnamnesisAlteracionNerviosa.ToString()|AnamnesisAlteracionNerviosa" style="height:30px;width:65px;border:0px solid blue;overflow-y:hidden;"></iframe>
                    </td>
                </tr>
                <tr>
                    <td>
                        Motivo consulta
                    </td>
                    <td>
                        <input value="@Model.AnamnesisMotivoConsulta" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaAnamnesisMotivoConsulta.location.href='/HistoriaClinica/ActualizarCampo?Dato=@Model.IdHistoriaClinica|'+this.value+'|AnamnesisMotivoConsulta'">
                    </td>
                    <td>
                        <iframe name="PaginaAnamnesisMotivoConsulta" src="/HistoriaClinica/SinActualizacion" style="margin:0px;width: 40px; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
                    </td>
                </tr>


                <tr>
                    <td>
                        Observacion
                    </td>
                    <td>
                        <input value="@Model.AnamnesisObservacion" type="text" onKeyUp="this.value=this.value.toUpperCase();" onblur="PaginaAnamnesisObservacion.location.href='/HistoriaClinica/ActualizarCampo?Dato=@Model.IdHistoriaClinica|'+this.value+'|AnamnesisObservacion'">
                    </td>
                    <td>
                        <iframe name="PaginaAnamnesisObservacion" src="/HistoriaClinica/SinActualizacion" style="margin:0px;width: 40px;height:auto; height:25px;border:0px solid blue;overflow-y:hidden;"></iframe>
                    </td>
                </tr>
            </table>
        </td>
    </tr>


    </table>
    
    <br><br><br><br><br><br><br><br><br><br><br>

</body>
</html>
