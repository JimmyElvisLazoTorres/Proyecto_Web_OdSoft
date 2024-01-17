Imports System.Web.Mvc

Namespace Controllers
    Public Class HistoriaClinicaController
        Inherits Controller


        Function index(ByVal Id As String) As ActionResult

            If IsNothing(Id) Then
                Id = Guid.NewGuid.ToString()
            End If
            Dim _Objeto As New Clase_G_Cliente(Id, My.User.Name)
            _Objeto.RellenarLista_Clase_O_HistoriaClinica()
            Return View(_Objeto)

        End Function
        Function Odontograma() As ActionResult


            Return View()

        End Function


        Function AgregarHistoria(ByVal Id As String) As ActionResult
            If IsNothing(Id) Then
                Id = ""
            End If

            Dim _Clase_O_HistoriaClinica As New Clase_O_HistoriaClinica(Guid.NewGuid.ToString, My.User.Name.ToString)
            Dim _Objeto As New Clase_G_Cliente(Id, My.User.Name)
            _Clase_O_HistoriaClinica.IdCliente = Id
            _Clase_O_HistoriaClinica.EdadCliente = _Objeto.Edad
            _Clase_O_HistoriaClinica.AnamnesisNombreCompleto = _Objeto.NombreCompleto
            _Clase_O_HistoriaClinica.Activo = True
            Return RedirectToAction("index", New With {
                    Id
                })
        End Function

        Function Anamnesis(ByVal Id As String) As ActionResult
            If IsNothing(Id) Then
                Id = Guid.NewGuid.ToString()
            End If
            Dim _Objeto As New Clase_O_HistoriaClinica(Id, My.User.Name)
            Return View(_Objeto)
        End Function
        Function EnBlanco() As ActionResult
            Return View()
        End Function
        Function ActualizarCampo(ByVal Dato As String) As ActionResult

            Dim DatoActualizado As Boolean = False
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_O_HistoriaClinica(Dato_Aux(0), My.User.Name)
            Dim Mensaje = ""
            Select Case Dato_Aux(2)
                Case "FechaInicio"
                    _Clase.FechaInicio = DateAndTime.DateValue(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "FechaCulminacion"
                    _Clase.FechaCulminacion = DateAndTime.DateValue(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Anamnesis15DiasFiebre"
                    _Clase.Anamnesis15DiasFiebre = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis15DiasGarganta"
                    _Clase.Anamnesis15DiasGarganta = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis5DiasPerdidaOlfatoGusto"
                    _Clase.Anamnesis5DiasPerdidaOlfatoGusto = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis15DiasProblemasRespiratorios"
                    _Clase.Anamnesis15DiasProblemasRespiratorios = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis15DiasDiarrea"
                    _Clase.Anamnesis15DiasDiarrea = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis15DiasCansancio"
                    _Clase.Anamnesis15DiasCansancio = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisRenalesDialisis"
                    _Clase.AnamnesisRenalesDialisis = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisAlegiaMedicamento"
                    _Clase.AnamnesisAlegiaMedicamento = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisAlteracionNerviosa"
                    _Clase.AnamnesisAlteracionNerviosa = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Activo"
                    _Clase.Activo = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "AnamnesisDigestivasProblemasEstomacales"
                    _Clase.AnamnesisDigestivasProblemasEstomacales = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisDigestivasProblemasHigado"
                    _Clase.AnamnesisDigestivasProblemasHigado = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisRespiratoriasIsuficienciaRespiratoria"
                    _Clase.AnamnesisRespiratoriasIsuficienciaRespiratoria = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisRespiratoriasAsma"
                    _Clase.AnamnesisRespiratoriasAsma = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisRespiratoriasTuberculosis"
                    _Clase.AnamnesisRespiratoriasTuberculosis = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisRenalesInsuficienciaRenal"
                    _Clase.AnamnesisRenalesInsuficienciaRenal = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisCardioVascularMarcapasos"
                    _Clase.AnamnesisCardioVascularMarcapasos = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisCardioVascularFiebreReumatica"
                    _Clase.AnamnesisCardioVascularFiebreReumatica = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisHematologicaAlteracionCoagulacion"
                    _Clase.AnamnesisHematologicaAlteracionCoagulacion = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisHematologicaAnemia"
                    _Clase.AnamnesisHematologicaAnemia = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisEndocrinasDiabetes"
                    _Clase.AnamnesisEndocrinasDiabetes = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisEndocrinasTiroides"
                    _Clase.AnamnesisEndocrinasTiroides = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis15DiasVisionDoble"
                    _Clase.Anamnesis15DiasVisionDoble = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis15DiasEmbarazada"
                    _Clase.Anamnesis15DiasEmbarazada = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis15DiasFumador"
                    _Clase.Anamnesis15DiasFumador = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisCardioVascularHipertension"
                    _Clase.AnamnesisCardioVascularHipertension = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisCardioVascularCadiacas"
                    _Clase.AnamnesisCardioVascularCadiacas = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisCardioVascularProtesisValvular"
                    _Clase.AnamnesisCardioVascularProtesisValvular = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "IdHistoriaClinica"
                    _Clase.IdHistoriaClinica = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "IdCliente"
                    _Clase.IdCliente = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "IdPersonal"
                    _Clase.IdPersonal = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "IdEmpresa"
                    _Clase.IdEmpresa = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "NroHistoriaclinica"
                    _Clase.NroHistoriaclinica = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "specialistaNombreCompleto"
                    _Clase.specialistaNombreCompleto = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis6"
                    _Clase.Anamnesis6 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis7"
                    _Clase.Anamnesis7 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis8"
                    _Clase.Anamnesis8 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis9"
                    _Clase.Anamnesis9 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis10"
                    _Clase.Anamnesis10 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis11"
                    _Clase.Anamnesis11 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisMotivoConsulta"
                    _Clase.AnamnesisMotivoConsulta = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis1"
                    _Clase.Anamnesis1 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis2"
                    _Clase.Anamnesis2 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis3"
                    _Clase.Anamnesis3 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis4"
                    _Clase.Anamnesis4 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Anamnesis5"
                    _Clase.Anamnesis5 = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "EdadCliente"
                    _Clase.EdadCliente = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "NombreApoderado"
                    _Clase.NombreApoderado = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisNombreCompleto"
                    _Clase.AnamnesisNombreCompleto = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisOcupacion"
                    _Clase.AnamnesisOcupacion = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisEstadoCivil"
                    _Clase.AnamnesisEstadoCivil = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AnamnesisObservacion"
                    _Clase.AnamnesisObservacion = Dato_Aux(1).ToString
                    DatoActualizado = True
            End Select
            ViewBag.Mensaje = Mensaje
            ViewBag.DatoActualizado = DatoActualizado
            Return View()
        End Function
        Function SinActualizacion() As ActionResult
            Return View()
        End Function
        Function ActualizarCampoBit(ByVal Dato As String) As ActionResult
            Dim DatoActualizado As Boolean = False
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_O_HistoriaClinica(Dato_Aux(0), My.User.Name)
            Dim Campo As String = ""

            Select Case Dato_Aux(2)
                Case "Anamnesis15DiasFiebre"

                    _Clase.Anamnesis15DiasFiebre = Boolean.Parse(Dato_Aux(1).ToString)

                    DatoActualizado = True
                Case "Anamnesis15DiasGarganta"
                    _Clase.Anamnesis15DiasGarganta = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Anamnesis5DiasPerdidaOlfatoGusto"
                    _Clase.Anamnesis5DiasPerdidaOlfatoGusto = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Anamnesis15DiasProblemasRespiratorios"
                    _Clase.Anamnesis15DiasProblemasRespiratorios = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Anamnesis15DiasDiarrea"
                    _Clase.Anamnesis15DiasDiarrea = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Anamnesis15DiasCansancio"
                    _Clase.Anamnesis15DiasCansancio = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisRenalesDialisis"
                    _Clase.AnamnesisRenalesDialisis = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisAlegiaMedicamento"
                    _Clase.AnamnesisAlegiaMedicamento = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisAlteracionNerviosa"
                    _Clase.AnamnesisAlteracionNerviosa = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Activo"
                    _Clase.Activo = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisDigestivasProblemasEstomacales"
                    _Clase.AnamnesisDigestivasProblemasEstomacales = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisDigestivasProblemasHigado"
                    _Clase.AnamnesisDigestivasProblemasHigado = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisRespiratoriasIsuficienciaRespiratoria"
                    _Clase.AnamnesisRespiratoriasIsuficienciaRespiratoria = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisRespiratoriasAsma"
                    _Clase.AnamnesisRespiratoriasAsma = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisRespiratoriasTuberculosis"
                    _Clase.AnamnesisRespiratoriasTuberculosis = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisRenalesInsuficienciaRenal"
                    _Clase.AnamnesisRenalesInsuficienciaRenal = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisCardioVascularMarcapasos"
                    _Clase.AnamnesisCardioVascularMarcapasos = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisCardioVascularFiebreReumatica"
                    _Clase.AnamnesisCardioVascularFiebreReumatica = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisHematologicaAlteracionCoagulacion"
                    _Clase.AnamnesisHematologicaAlteracionCoagulacion = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisHematologicaAnemia"
                    _Clase.AnamnesisHematologicaAnemia = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisEndocrinasDiabetes"
                    _Clase.AnamnesisEndocrinasDiabetes = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisEndocrinasTiroides"
                    _Clase.AnamnesisEndocrinasTiroides = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Anamnesis15DiasVisionDoble"
                    _Clase.Anamnesis15DiasVisionDoble = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Anamnesis15DiasEmbarazada"
                    _Clase.Anamnesis15DiasEmbarazada = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Anamnesis15DiasFumador"
                    _Clase.Anamnesis15DiasFumador = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisCardioVascularHipertension"
                    _Clase.AnamnesisCardioVascularHipertension = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisCardioVascularCadiacas"
                    _Clase.AnamnesisCardioVascularCadiacas = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "AnamnesisCardioVascularProtesisValvular"
                    _Clase.AnamnesisCardioVascularProtesisValvular = Boolean.Parse(Dato_Aux(1).ToString)
                    DatoActualizado = True
            End Select
            Campo = Dato_Aux(2).ToString
            ViewBag.Campo = Campo
            ViewBag.Respuesta = Boolean.Parse(Dato_Aux(1).ToString)
            ViewBag.Id = Dato_Aux(0)
            Return View()
        End Function


    End Class
End Namespace