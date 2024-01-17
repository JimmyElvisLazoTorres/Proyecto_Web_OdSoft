Public Class Clase_O_HistoriaClinica
    Private _BaseDatos As New BaseDatos
    Private _ActualizarEnCadaCampo As Boolean = True
    Private _CargarDatosEnCadaCampo As Boolean = False
    '
    Private CadProcConsultar As String = "PA_O_HistoriaClinicaConsultar"
    Private CadProcActualizar As String = "PA_O_HistoriaClinicaActualizar"
    Private CadProcEliminar As String = "PA_O_HistoriaClinicaEliminar"
    '
    Private _IdHistoriaClinica As String = ""
    Private _IdCliente As String = ""
    Private _IdPersonal As String = ""
    Private _IdEmpresa As String = ""
    '
    Private _Usuario As String = ""
    Private _FechaInicio As Date = DateTime.Now
    Private _FechaCulminacion As Date = DateTime.Now
    Private _Anamnesis15DiasFiebre As Boolean = False
    Private _Anamnesis15DiasGarganta As Boolean = False
    Private _Anamnesis5DiasPerdidaOlfatoGusto As Boolean = False
    Private _Anamnesis15DiasProblemasRespiratorios As Boolean = False
    Private _Anamnesis15DiasDiarrea As Boolean = False
    Private _Anamnesis15DiasCansancio As Boolean = False
    Private _AnamnesisRenalesDialisis As Boolean = False
    Private _AnamnesisAlegiaMedicamento As Boolean = False
    Private _AnamnesisAlteracionNerviosa As Boolean = False
    Private _Activo As Boolean = True
    Private _AnamnesisDigestivasProblemasEstomacales As Boolean = False
    Private _AnamnesisDigestivasProblemasHigado As Boolean = False
    Private _AnamnesisRespiratoriasIsuficienciaRespiratoria As Boolean = False
    Private _AnamnesisRespiratoriasAsma As Boolean = False
    Private _AnamnesisRespiratoriasTuberculosis As Boolean = False
    Private _AnamnesisRenalesInsuficienciaRenal As Boolean = False
    Private _AnamnesisCardioVascularMarcapasos As Boolean = False
    Private _AnamnesisCardioVascularFiebreReumatica As Boolean = False
    Private _AnamnesisHematologicaAlteracionCoagulacion As Boolean = False
    Private _AnamnesisHematologicaAnemia As Boolean = False
    Private _AnamnesisEndocrinasDiabetes As Boolean = False
    Private _AnamnesisEndocrinasTiroides As Boolean = False
    Private _Anamnesis15DiasVisionDoble As Boolean = False
    Private _Anamnesis15DiasEmbarazada As Boolean = False
    Private _Anamnesis15DiasFumador As Boolean = False
    Private _AnamnesisCardioVascularHipertension As Boolean = False
    Private _AnamnesisCardioVascularCadiacas As Boolean = False
    Private _AnamnesisCardioVascularProtesisValvular As Boolean = False
    Private _NroHistoriaclinica As String = ""
    Private _specialistaNombreCompleto As String = ""
    Private _Anamnesis6 As String = ""
    Private _Anamnesis7 As String = ""
    Private _Anamnesis8 As String = ""
    Private _Anamnesis9 As String = ""
    Private _Anamnesis10 As String = ""
    Private _Anamnesis11 As String = ""
    Private _AnamnesisMotivoConsulta As String = ""
    Private _Anamnesis1 As String = ""
    Private _Anamnesis2 As String = ""
    Private _Anamnesis3 As String = ""
    Private _Anamnesis4 As String = ""
    Private _Anamnesis5 As String = ""
    Private _EdadCliente As String = ""
    Private _NombreApoderado As String = ""
    Private _AnamnesisNombreCompleto As String = ""
    Private _AnamnesisOcupacion As String = ""
    Private _AnamnesisEstadoCivil As String = ""
    Private _AnamnesisObservacion As String = ""
    Sub New()
    End Sub
    Sub New(_FechaInicio_ As Date, _FechaCulminacion_ As Date, _Anamnesis15DiasFiebre_ As Boolean, _Anamnesis15DiasGarganta_ As Boolean, _Anamnesis5DiasPerdidaOlfatoGusto_ As Boolean, _Anamnesis15DiasProblemasRespiratorios_ As Boolean, _Anamnesis15DiasDiarrea_ As Boolean, _Anamnesis15DiasCansancio_ As Boolean, _AnamnesisRenalesDialisis_ As Boolean, _AnamnesisAlegiaMedicamento_ As Boolean, _AnamnesisAlteracionNerviosa_ As Boolean, _Activo_ As Boolean, _AnamnesisDigestivasProblemasEstomacales_ As Boolean, _AnamnesisDigestivasProblemasHigado_ As Boolean, _AnamnesisRespiratoriasIsuficienciaRespiratoria_ As Boolean, _AnamnesisRespiratoriasAsma_ As Boolean, _AnamnesisRespiratoriasTuberculosis_ As Boolean, _AnamnesisRenalesInsuficienciaRenal_ As Boolean, _AnamnesisCardioVascularMarcapasos_ As Boolean, _AnamnesisCardioVascularFiebreReumatica_ As Boolean, _AnamnesisHematologicaAlteracionCoagulacion_ As Boolean, _AnamnesisHematologicaAnemia_ As Boolean, _AnamnesisEndocrinasDiabetes_ As Boolean, _AnamnesisEndocrinasTiroides_ As Boolean, _Anamnesis15DiasVisionDoble_ As Boolean, _Anamnesis15DiasEmbarazada_ As Boolean, _Anamnesis15DiasFumador_ As Boolean, _AnamnesisCardioVascularHipertension_ As Boolean, _AnamnesisCardioVascularCadiacas_ As Boolean, _AnamnesisCardioVascularProtesisValvular_ As Boolean, _IdHistoriaClinica_ As String, _IdCliente_ As String, _IdPersonal_ As String, _IdEmpresa_ As String, _NroHistoriaclinica_ As String, _specialistaNombreCompleto_ As String, _Anamnesis6_ As String, _Anamnesis7_ As String, _Anamnesis8_ As String, _Anamnesis9_ As String, _Anamnesis10_ As String, _Anamnesis11_ As String, _AnamnesisMotivoConsulta_ As String, _Anamnesis1_ As String, _Anamnesis2_ As String, _Anamnesis3_ As String, _Anamnesis4_ As String, _Anamnesis5_ As String, _EdadCliente_ As String, _NombreApoderado_ As String, _AnamnesisNombreCompleto_ As String, _AnamnesisOcupacion_ As String, _AnamnesisEstadoCivil_ As String, _AnamnesisObservacion_ As String)
        _FechaInicio = _FechaInicio_
        _FechaCulminacion = _FechaCulminacion_
        _Anamnesis15DiasFiebre = _Anamnesis15DiasFiebre_
        _Anamnesis15DiasGarganta = _Anamnesis15DiasGarganta_
        _Anamnesis5DiasPerdidaOlfatoGusto = _Anamnesis5DiasPerdidaOlfatoGusto_
        _Anamnesis15DiasProblemasRespiratorios = _Anamnesis15DiasProblemasRespiratorios_
        _Anamnesis15DiasDiarrea = _Anamnesis15DiasDiarrea_
        _Anamnesis15DiasCansancio = _Anamnesis15DiasCansancio_
        _AnamnesisRenalesDialisis = _AnamnesisRenalesDialisis_
        _AnamnesisAlegiaMedicamento = _AnamnesisAlegiaMedicamento_
        _AnamnesisAlteracionNerviosa = _AnamnesisAlteracionNerviosa_
        _Activo = _Activo_
        _AnamnesisDigestivasProblemasEstomacales = _AnamnesisDigestivasProblemasEstomacales_
        _AnamnesisDigestivasProblemasHigado = _AnamnesisDigestivasProblemasHigado_
        _AnamnesisRespiratoriasIsuficienciaRespiratoria = _AnamnesisRespiratoriasIsuficienciaRespiratoria_
        _AnamnesisRespiratoriasAsma = _AnamnesisRespiratoriasAsma_
        _AnamnesisRespiratoriasTuberculosis = _AnamnesisRespiratoriasTuberculosis_
        _AnamnesisRenalesInsuficienciaRenal = _AnamnesisRenalesInsuficienciaRenal_
        _AnamnesisCardioVascularMarcapasos = _AnamnesisCardioVascularMarcapasos_
        _AnamnesisCardioVascularFiebreReumatica = _AnamnesisCardioVascularFiebreReumatica_
        _AnamnesisHematologicaAlteracionCoagulacion = _AnamnesisHematologicaAlteracionCoagulacion_
        _AnamnesisHematologicaAnemia = _AnamnesisHematologicaAnemia_
        _AnamnesisEndocrinasDiabetes = _AnamnesisEndocrinasDiabetes_
        _AnamnesisEndocrinasTiroides = _AnamnesisEndocrinasTiroides_
        _Anamnesis15DiasVisionDoble = _Anamnesis15DiasVisionDoble_
        _Anamnesis15DiasEmbarazada = _Anamnesis15DiasEmbarazada_
        _Anamnesis15DiasFumador = _Anamnesis15DiasFumador_
        _AnamnesisCardioVascularHipertension = _AnamnesisCardioVascularHipertension_
        _AnamnesisCardioVascularCadiacas = _AnamnesisCardioVascularCadiacas_
        _AnamnesisCardioVascularProtesisValvular = _AnamnesisCardioVascularProtesisValvular_
        _IdHistoriaClinica = _IdHistoriaClinica_
        _IdCliente = _IdCliente_
        _IdPersonal = _IdPersonal_
        _IdEmpresa = _IdEmpresa_
        _NroHistoriaclinica = _NroHistoriaclinica_
        _specialistaNombreCompleto = _specialistaNombreCompleto_
        _Anamnesis6 = _Anamnesis6_
        _Anamnesis7 = _Anamnesis7_
        _Anamnesis8 = _Anamnesis8_
        _Anamnesis9 = _Anamnesis9_
        _Anamnesis10 = _Anamnesis10_
        _Anamnesis11 = _Anamnesis11_
        _AnamnesisMotivoConsulta = _AnamnesisMotivoConsulta_
        _Anamnesis1 = _Anamnesis1_
        _Anamnesis2 = _Anamnesis2_
        _Anamnesis3 = _Anamnesis3_
        _Anamnesis4 = _Anamnesis4_
        _Anamnesis5 = _Anamnesis5_
        _EdadCliente = _EdadCliente_
        _NombreApoderado = _NombreApoderado_
        _AnamnesisNombreCompleto = _AnamnesisNombreCompleto_
        _AnamnesisOcupacion = _AnamnesisOcupacion_
        _AnamnesisEstadoCivil = _AnamnesisEstadoCivil_
        _AnamnesisObservacion = _AnamnesisObservacion_
    End Sub
    Sub New(_IdHistoriaClinica_ As String, _Usuario_ As String)
        _Usuario = _Usuario_
        _IdHistoriaClinica = _IdHistoriaClinica_
        CargarDatos()
    End Sub
    Public Sub CargarDatos()
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcConsultar)
                .AgregarParametroTexto("@IdHistoriaClinica", _IdHistoriaClinica)
                .AgregarParametroTexto("@Usuario", _Usuario)
                _BaseDatos.EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read
                    _FechaInicio = .Datos.GetValue(0)
                    _FechaCulminacion = .Datos.GetValue(1)
                    _Anamnesis15DiasFiebre = .Datos.GetValue(2)
                    _Anamnesis15DiasGarganta = .Datos.GetValue(3)
                    _Anamnesis5DiasPerdidaOlfatoGusto = .Datos.GetValue(4)
                    _Anamnesis15DiasProblemasRespiratorios = .Datos.GetValue(5)
                    _Anamnesis15DiasDiarrea = .Datos.GetValue(6)
                    _Anamnesis15DiasCansancio = .Datos.GetValue(7)
                    _AnamnesisRenalesDialisis = .Datos.GetValue(8)
                    _AnamnesisAlegiaMedicamento = .Datos.GetValue(9)
                    _AnamnesisAlteracionNerviosa = .Datos.GetValue(10)
                    _Activo = .Datos.GetValue(11)
                    _AnamnesisDigestivasProblemasEstomacales = .Datos.GetValue(12)
                    _AnamnesisDigestivasProblemasHigado = .Datos.GetValue(13)
                    _AnamnesisRespiratoriasIsuficienciaRespiratoria = .Datos.GetValue(14)
                    _AnamnesisRespiratoriasAsma = .Datos.GetValue(15)
                    _AnamnesisRespiratoriasTuberculosis = .Datos.GetValue(16)
                    _AnamnesisRenalesInsuficienciaRenal = .Datos.GetValue(17)
                    _AnamnesisCardioVascularMarcapasos = .Datos.GetValue(18)
                    _AnamnesisCardioVascularFiebreReumatica = .Datos.GetValue(19)
                    _AnamnesisHematologicaAlteracionCoagulacion = .Datos.GetValue(20)
                    _AnamnesisHematologicaAnemia = .Datos.GetValue(21)
                    _AnamnesisEndocrinasDiabetes = .Datos.GetValue(22)
                    _AnamnesisEndocrinasTiroides = .Datos.GetValue(23)
                    _Anamnesis15DiasVisionDoble = .Datos.GetValue(24)
                    _Anamnesis15DiasEmbarazada = .Datos.GetValue(25)
                    _Anamnesis15DiasFumador = .Datos.GetValue(26)
                    _AnamnesisCardioVascularHipertension = .Datos.GetValue(27)
                    _AnamnesisCardioVascularCadiacas = .Datos.GetValue(28)
                    _AnamnesisCardioVascularProtesisValvular = .Datos.GetValue(29)
                    _IdHistoriaClinica = .Datos.GetValue(30)
                    _IdCliente = .Datos.GetValue(31)
                    _IdPersonal = .Datos.GetValue(32)
                    _IdEmpresa = .Datos.GetValue(33)
                    _NroHistoriaclinica = .Datos.GetValue(34)
                    _specialistaNombreCompleto = .Datos.GetValue(35)
                    _Anamnesis6 = .Datos.GetValue(36)
                    _Anamnesis7 = .Datos.GetValue(37)
                    _Anamnesis8 = .Datos.GetValue(38)
                    _Anamnesis9 = .Datos.GetValue(39)
                    _Anamnesis10 = .Datos.GetValue(40)
                    _Anamnesis11 = .Datos.GetValue(41)
                    _AnamnesisMotivoConsulta = .Datos.GetValue(42)
                    _Anamnesis1 = .Datos.GetValue(43)
                    _Anamnesis2 = .Datos.GetValue(44)
                    _Anamnesis3 = .Datos.GetValue(45)
                    _Anamnesis4 = .Datos.GetValue(46)
                    _Anamnesis5 = .Datos.GetValue(47)
                    _EdadCliente = .Datos.GetValue(48)
                    _NombreApoderado = .Datos.GetValue(49)
                    _AnamnesisNombreCompleto = .Datos.GetValue(50)
                    _AnamnesisOcupacion = .Datos.GetValue(51)
                    _AnamnesisEstadoCivil = .Datos.GetValue(52)
                    _AnamnesisObservacion = .Datos.GetValue(53)

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                .Desconectar()
            End Try
        End With
    End Sub
    Public Sub CargarDatos(_FechaInicio_ As Date, _FechaCulminacion_ As Date, _Anamnesis15DiasFiebre_ As Boolean, _Anamnesis15DiasGarganta_ As Boolean, _Anamnesis5DiasPerdidaOlfatoGusto_ As Boolean, _Anamnesis15DiasProblemasRespiratorios_ As Boolean, _Anamnesis15DiasDiarrea_ As Boolean, _Anamnesis15DiasCansancio_ As Boolean, _AnamnesisRenalesDialisis_ As Boolean, _AnamnesisAlegiaMedicamento_ As Boolean, _AnamnesisAlteracionNerviosa_ As Boolean, _Activo_ As Boolean, _AnamnesisDigestivasProblemasEstomacales_ As Boolean, _AnamnesisDigestivasProblemasHigado_ As Boolean, _AnamnesisRespiratoriasIsuficienciaRespiratoria_ As Boolean, _AnamnesisRespiratoriasAsma_ As Boolean, _AnamnesisRespiratoriasTuberculosis_ As Boolean, _AnamnesisRenalesInsuficienciaRenal_ As Boolean, _AnamnesisCardioVascularMarcapasos_ As Boolean, _AnamnesisCardioVascularFiebreReumatica_ As Boolean, _AnamnesisHematologicaAlteracionCoagulacion_ As Boolean, _AnamnesisHematologicaAnemia_ As Boolean, _AnamnesisEndocrinasDiabetes_ As Boolean, _AnamnesisEndocrinasTiroides_ As Boolean, _Anamnesis15DiasVisionDoble_ As Boolean, _Anamnesis15DiasEmbarazada_ As Boolean, _Anamnesis15DiasFumador_ As Boolean, _AnamnesisCardioVascularHipertension_ As Boolean, _AnamnesisCardioVascularCadiacas_ As Boolean, _AnamnesisCardioVascularProtesisValvular_ As Boolean, _IdHistoriaClinica_ As String, _IdCliente_ As String, _IdPersonal_ As String, _IdEmpresa_ As String, _NroHistoriaclinica_ As String, _specialistaNombreCompleto_ As String, _Anamnesis6_ As String, _Anamnesis7_ As String, _Anamnesis8_ As String, _Anamnesis9_ As String, _Anamnesis10_ As String, _Anamnesis11_ As String, _AnamnesisMotivoConsulta_ As String, _Anamnesis1_ As String, _Anamnesis2_ As String, _Anamnesis3_ As String, _Anamnesis4_ As String, _Anamnesis5_ As String, _EdadCliente_ As String, _NombreApoderado_ As String, _AnamnesisNombreCompleto_ As String, _AnamnesisOcupacion_ As String, _AnamnesisEstadoCivil_ As String, _AnamnesisObservacion_ As String)
        _FechaInicio = _FechaInicio_
        _FechaCulminacion = _FechaCulminacion_
        _Anamnesis15DiasFiebre = _Anamnesis15DiasFiebre_
        _Anamnesis15DiasGarganta = _Anamnesis15DiasGarganta_
        _Anamnesis5DiasPerdidaOlfatoGusto = _Anamnesis5DiasPerdidaOlfatoGusto_
        _Anamnesis15DiasProblemasRespiratorios = _Anamnesis15DiasProblemasRespiratorios_
        _Anamnesis15DiasDiarrea = _Anamnesis15DiasDiarrea_
        _Anamnesis15DiasCansancio = _Anamnesis15DiasCansancio_
        _AnamnesisRenalesDialisis = _AnamnesisRenalesDialisis_
        _AnamnesisAlegiaMedicamento = _AnamnesisAlegiaMedicamento_
        _AnamnesisAlteracionNerviosa = _AnamnesisAlteracionNerviosa_
        _Activo = _Activo_
        _AnamnesisDigestivasProblemasEstomacales = _AnamnesisDigestivasProblemasEstomacales_
        _AnamnesisDigestivasProblemasHigado = _AnamnesisDigestivasProblemasHigado_
        _AnamnesisRespiratoriasIsuficienciaRespiratoria = _AnamnesisRespiratoriasIsuficienciaRespiratoria_
        _AnamnesisRespiratoriasAsma = _AnamnesisRespiratoriasAsma_
        _AnamnesisRespiratoriasTuberculosis = _AnamnesisRespiratoriasTuberculosis_
        _AnamnesisRenalesInsuficienciaRenal = _AnamnesisRenalesInsuficienciaRenal_
        _AnamnesisCardioVascularMarcapasos = _AnamnesisCardioVascularMarcapasos_
        _AnamnesisCardioVascularFiebreReumatica = _AnamnesisCardioVascularFiebreReumatica_
        _AnamnesisHematologicaAlteracionCoagulacion = _AnamnesisHematologicaAlteracionCoagulacion_
        _AnamnesisHematologicaAnemia = _AnamnesisHematologicaAnemia_
        _AnamnesisEndocrinasDiabetes = _AnamnesisEndocrinasDiabetes_
        _AnamnesisEndocrinasTiroides = _AnamnesisEndocrinasTiroides_
        _Anamnesis15DiasVisionDoble = _Anamnesis15DiasVisionDoble_
        _Anamnesis15DiasEmbarazada = _Anamnesis15DiasEmbarazada_
        _Anamnesis15DiasFumador = _Anamnesis15DiasFumador_
        _AnamnesisCardioVascularHipertension = _AnamnesisCardioVascularHipertension_
        _AnamnesisCardioVascularCadiacas = _AnamnesisCardioVascularCadiacas_
        _AnamnesisCardioVascularProtesisValvular = _AnamnesisCardioVascularProtesisValvular_
        _IdHistoriaClinica = _IdHistoriaClinica_
        _IdCliente = _IdCliente_
        _IdPersonal = _IdPersonal_
        _IdEmpresa = _IdEmpresa_
        _NroHistoriaclinica = _NroHistoriaclinica_
        _specialistaNombreCompleto = _specialistaNombreCompleto_
        _Anamnesis6 = _Anamnesis6_
        _Anamnesis7 = _Anamnesis7_
        _Anamnesis8 = _Anamnesis8_
        _Anamnesis9 = _Anamnesis9_
        _Anamnesis10 = _Anamnesis10_
        _Anamnesis11 = _Anamnesis11_
        _AnamnesisMotivoConsulta = _AnamnesisMotivoConsulta_
        _Anamnesis1 = _Anamnesis1_
        _Anamnesis2 = _Anamnesis2_
        _Anamnesis3 = _Anamnesis3_
        _Anamnesis4 = _Anamnesis4_
        _Anamnesis5 = _Anamnesis5_
        _EdadCliente = _EdadCliente_
        _NombreApoderado = _NombreApoderado_
        _AnamnesisNombreCompleto = _AnamnesisNombreCompleto_
        _AnamnesisOcupacion = _AnamnesisOcupacion_
        _AnamnesisEstadoCivil = _AnamnesisEstadoCivil_
        _AnamnesisObservacion = _AnamnesisObservacion_
    End Sub
    Public Function Actualizar() As Boolean
        Dim Actualizado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcActualizar)
                .AgregarParametroFechaYHora("@FechaInicio", _FechaInicio)
                .AgregarParametroFechaYHora("@FechaCulminacion", _FechaCulminacion)
                .AgregarParametroBit("@Anamnesis15DiasFiebre", _Anamnesis15DiasFiebre)
                .AgregarParametroBit("@Anamnesis15DiasGarganta", _Anamnesis15DiasGarganta)
                .AgregarParametroBit("@Anamnesis5DiasPerdidaOlfatoGusto", _Anamnesis5DiasPerdidaOlfatoGusto)
                .AgregarParametroBit("@Anamnesis15DiasProblemasRespiratorios", _Anamnesis15DiasProblemasRespiratorios)
                .AgregarParametroBit("@Anamnesis15DiasDiarrea", _Anamnesis15DiasDiarrea)
                .AgregarParametroBit("@Anamnesis15DiasCansancio", _Anamnesis15DiasCansancio)
                .AgregarParametroBit("@AnamnesisRenalesDialisis", _AnamnesisRenalesDialisis)
                .AgregarParametroBit("@AnamnesisAlegiaMedicamento", _AnamnesisAlegiaMedicamento)
                .AgregarParametroBit("@AnamnesisAlteracionNerviosa", _AnamnesisAlteracionNerviosa)
                .AgregarParametroBit("@Activo", _Activo)
                .AgregarParametroBit("@AnamnesisDigestivasProblemasEstomacales", _AnamnesisDigestivasProblemasEstomacales)
                .AgregarParametroBit("@AnamnesisDigestivasProblemasHigado", _AnamnesisDigestivasProblemasHigado)
                .AgregarParametroBit("@AnamnesisRespiratoriasIsuficienciaRespiratoria", _AnamnesisRespiratoriasIsuficienciaRespiratoria)
                .AgregarParametroBit("@AnamnesisRespiratoriasAsma", _AnamnesisRespiratoriasAsma)
                .AgregarParametroBit("@AnamnesisRespiratoriasTuberculosis", _AnamnesisRespiratoriasTuberculosis)
                .AgregarParametroBit("@AnamnesisRenalesInsuficienciaRenal", _AnamnesisRenalesInsuficienciaRenal)
                .AgregarParametroBit("@AnamnesisCardioVascularMarcapasos", _AnamnesisCardioVascularMarcapasos)
                .AgregarParametroBit("@AnamnesisCardioVascularFiebreReumatica", _AnamnesisCardioVascularFiebreReumatica)
                .AgregarParametroBit("@AnamnesisHematologicaAlteracionCoagulacion", _AnamnesisHematologicaAlteracionCoagulacion)
                .AgregarParametroBit("@AnamnesisHematologicaAnemia", _AnamnesisHematologicaAnemia)
                .AgregarParametroBit("@AnamnesisEndocrinasDiabetes", _AnamnesisEndocrinasDiabetes)
                .AgregarParametroBit("@AnamnesisEndocrinasTiroides", _AnamnesisEndocrinasTiroides)
                .AgregarParametroBit("@Anamnesis15DiasVisionDoble", _Anamnesis15DiasVisionDoble)
                .AgregarParametroBit("@Anamnesis15DiasEmbarazada", _Anamnesis15DiasEmbarazada)
                .AgregarParametroBit("@Anamnesis15DiasFumador", _Anamnesis15DiasFumador)
                .AgregarParametroBit("@AnamnesisCardioVascularHipertension", _AnamnesisCardioVascularHipertension)
                .AgregarParametroBit("@AnamnesisCardioVascularCadiacas", _AnamnesisCardioVascularCadiacas)
                .AgregarParametroBit("@AnamnesisCardioVascularProtesisValvular", _AnamnesisCardioVascularProtesisValvular)
                .AgregarParametroTexto("@IdHistoriaClinica", _IdHistoriaClinica)
                .AgregarParametroTexto("@IdCliente", _IdCliente)
                .AgregarParametroTexto("@IdPersonal", _IdPersonal)
                .AgregarParametroTexto("@IdEmpresa", _IdEmpresa)
                .AgregarParametroTexto("@NroHistoriaclinica", _NroHistoriaclinica)
                .AgregarParametroTexto("@specialistaNombreCompleto", _specialistaNombreCompleto)
                .AgregarParametroTexto("@Anamnesis6", _Anamnesis6)
                .AgregarParametroTexto("@Anamnesis7", _Anamnesis7)
                .AgregarParametroTexto("@Anamnesis8", _Anamnesis8)
                .AgregarParametroTexto("@Anamnesis9", _Anamnesis9)
                .AgregarParametroTexto("@Anamnesis10", _Anamnesis10)
                .AgregarParametroTexto("@Anamnesis11", _Anamnesis11)
                .AgregarParametroTexto("@AnamnesisMotivoConsulta", _AnamnesisMotivoConsulta)
                .AgregarParametroTexto("@Anamnesis1", _Anamnesis1)
                .AgregarParametroTexto("@Anamnesis2", _Anamnesis2)
                .AgregarParametroTexto("@Anamnesis3", _Anamnesis3)
                .AgregarParametroTexto("@Anamnesis4", _Anamnesis4)
                .AgregarParametroTexto("@Anamnesis5", _Anamnesis5)
                .AgregarParametroTexto("@EdadCliente", _EdadCliente)
                .AgregarParametroTexto("@NombreApoderado", _NombreApoderado)
                .AgregarParametroTexto("@AnamnesisNombreCompleto", _AnamnesisNombreCompleto)
                .AgregarParametroTexto("@AnamnesisOcupacion", _AnamnesisOcupacion)
                .AgregarParametroTexto("@AnamnesisEstadoCivil", _AnamnesisEstadoCivil)
                .AgregarParametroTexto("@AnamnesisObservacion", _AnamnesisObservacion)
                .AgregarParametroTexto("@Usuario", _Usuario)
                _BaseDatos.EjecutarConsulta()
                Actualizado = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                .Desconectar()
            End Try
        End With
        Return Actualizado
    End Function
    Public Function Eliminar() As Boolean
        Dim Eliminado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcEliminar)
                .AgregarParametroTexto("@IdHistoriaClinica", _IdHistoriaClinica)
                .AgregarParametroTexto("@Usuario", _Usuario)
                Eliminado = True
                _BaseDatos.EjecutarConsulta()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                .Desconectar()
            End Try
        End With
        Return Eliminado
    End Function
    Public Property FechaInicio As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _FechaInicio = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property FechaCulminacion As Date
        Get
            Return _FechaCulminacion
        End Get
        Set(ByVal value As Date)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _FechaCulminacion = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis15DiasFiebre As Boolean
        Get
            Return _Anamnesis15DiasFiebre
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis15DiasFiebre = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis15DiasGarganta As Boolean
        Get
            Return _Anamnesis15DiasGarganta
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis15DiasGarganta = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis5DiasPerdidaOlfatoGusto As Boolean
        Get
            Return _Anamnesis5DiasPerdidaOlfatoGusto
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis5DiasPerdidaOlfatoGusto = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis15DiasProblemasRespiratorios As Boolean
        Get
            Return _Anamnesis15DiasProblemasRespiratorios
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis15DiasProblemasRespiratorios = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis15DiasDiarrea As Boolean
        Get
            Return _Anamnesis15DiasDiarrea
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis15DiasDiarrea = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis15DiasCansancio As Boolean
        Get
            Return _Anamnesis15DiasCansancio
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis15DiasCansancio = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisRenalesDialisis As Boolean
        Get
            Return _AnamnesisRenalesDialisis
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisRenalesDialisis = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisAlegiaMedicamento As Boolean
        Get
            Return _AnamnesisAlegiaMedicamento
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisAlegiaMedicamento = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisAlteracionNerviosa As Boolean
        Get
            Return _AnamnesisAlteracionNerviosa
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisAlteracionNerviosa = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Activo As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Activo = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisDigestivasProblemasEstomacales As Boolean
        Get
            Return _AnamnesisDigestivasProblemasEstomacales
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisDigestivasProblemasEstomacales = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisDigestivasProblemasHigado As Boolean
        Get
            Return _AnamnesisDigestivasProblemasHigado
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisDigestivasProblemasHigado = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisRespiratoriasIsuficienciaRespiratoria As Boolean
        Get
            Return _AnamnesisRespiratoriasIsuficienciaRespiratoria
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisRespiratoriasIsuficienciaRespiratoria = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisRespiratoriasAsma As Boolean
        Get
            Return _AnamnesisRespiratoriasAsma
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisRespiratoriasAsma = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisRespiratoriasTuberculosis As Boolean
        Get
            Return _AnamnesisRespiratoriasTuberculosis
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisRespiratoriasTuberculosis = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisRenalesInsuficienciaRenal As Boolean
        Get
            Return _AnamnesisRenalesInsuficienciaRenal
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisRenalesInsuficienciaRenal = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisCardioVascularMarcapasos As Boolean
        Get
            Return _AnamnesisCardioVascularMarcapasos
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisCardioVascularMarcapasos = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisCardioVascularFiebreReumatica As Boolean
        Get
            Return _AnamnesisCardioVascularFiebreReumatica
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisCardioVascularFiebreReumatica = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisHematologicaAlteracionCoagulacion As Boolean
        Get
            Return _AnamnesisHematologicaAlteracionCoagulacion
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisHematologicaAlteracionCoagulacion = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisHematologicaAnemia As Boolean
        Get
            Return _AnamnesisHematologicaAnemia
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisHematologicaAnemia = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisEndocrinasDiabetes As Boolean
        Get
            Return _AnamnesisEndocrinasDiabetes
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisEndocrinasDiabetes = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisEndocrinasTiroides As Boolean
        Get
            Return _AnamnesisEndocrinasTiroides
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisEndocrinasTiroides = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis15DiasVisionDoble As Boolean
        Get
            Return _Anamnesis15DiasVisionDoble
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis15DiasVisionDoble = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis15DiasEmbarazada As Boolean
        Get
            Return _Anamnesis15DiasEmbarazada
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis15DiasEmbarazada = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis15DiasFumador As Boolean
        Get
            Return _Anamnesis15DiasFumador
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis15DiasFumador = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisCardioVascularHipertension As Boolean
        Get
            Return _AnamnesisCardioVascularHipertension
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisCardioVascularHipertension = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisCardioVascularCadiacas As Boolean
        Get
            Return _AnamnesisCardioVascularCadiacas
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisCardioVascularCadiacas = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisCardioVascularProtesisValvular As Boolean
        Get
            Return _AnamnesisCardioVascularProtesisValvular
        End Get
        Set(ByVal value As Boolean)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisCardioVascularProtesisValvular = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property IdHistoriaClinica As String
        Get
            Return _IdHistoriaClinica
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _IdHistoriaClinica = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property IdCliente As String
        Get
            Return _IdCliente
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _IdCliente = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property IdPersonal As String
        Get
            Return _IdPersonal
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _IdPersonal = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property IdEmpresa As String
        Get
            Return _IdEmpresa
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _IdEmpresa = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property NroHistoriaclinica As String
        Get
            Return _NroHistoriaclinica
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _NroHistoriaclinica = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property specialistaNombreCompleto As String
        Get
            Return _specialistaNombreCompleto
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _specialistaNombreCompleto = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis6 As String
        Get
            Return _Anamnesis6
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis6 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis7 As String
        Get
            Return _Anamnesis7
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis7 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis8 As String
        Get
            Return _Anamnesis8
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis8 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis9 As String
        Get
            Return _Anamnesis9
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis9 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis10 As String
        Get
            Return _Anamnesis10
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis10 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis11 As String
        Get
            Return _Anamnesis11
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis11 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisMotivoConsulta As String
        Get
            Return _AnamnesisMotivoConsulta
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisMotivoConsulta = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis1 As String
        Get
            Return _Anamnesis1
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis1 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis2 As String
        Get
            Return _Anamnesis2
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis2 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis3 As String
        Get
            Return _Anamnesis3
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis3 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis4 As String
        Get
            Return _Anamnesis4
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis4 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Anamnesis5 As String
        Get
            Return _Anamnesis5
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Anamnesis5 = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property EdadCliente As String
        Get
            Return _EdadCliente
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _EdadCliente = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property NombreApoderado As String
        Get
            Return _NombreApoderado
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _NombreApoderado = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisNombreCompleto As String
        Get
            Return _AnamnesisNombreCompleto
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisNombreCompleto = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisOcupacion As String
        Get
            Return _AnamnesisOcupacion
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisOcupacion = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisEstadoCivil As String
        Get
            Return _AnamnesisEstadoCivil
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisEstadoCivil = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AnamnesisObservacion As String
        Get
            Return _AnamnesisObservacion
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AnamnesisObservacion = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property


    Public Property Id As String
        Get
            Return _IdHistoriaClinica
        End Get
        Set(ByVal value As String)
            _IdHistoriaClinica = value
        End Set
    End Property
    Public ReadOnly Property Mensaje As String
        Get
            Return ""
        End Get

    End Property
End Class
