Public Class Clase_G_Cliente
    Private _BaseDatos As New BaseDatos
    Private _ActualizarEnCadaCampo As Boolean = True
    Private _CargarDatosEnCadaCampo As Boolean = False

    Private _Lista_Clase_O_HistoriaClinica As New List(Of Clase_O_HistoriaClinica)
    '
    Private CadProcConsultar As String = "PA_G_ClienteConsultar"
    Private CadProcActualizar As String = "PA_G_ClienteActualizar"
    Private CadProcEliminar As String = "PA_G_ClienteEliminar"
    '
    Private _IdCliente As String = Guid.NewGuid.ToString
    Private _IdEmpresa As String = ""
    '
    Private _Usuario As String = ""
    Private _FechaNacimiento As Date = DateTime.Now
    Private _FechaInscripcion As Date = DateTime.Now
    Private _Nombre As String = ""
    Private _ApellidoPaterno As String = ""
    Private _ApellidoMaterno As String = ""
    Private _Sexo As String = ""
    Private _Ocupacion As String = ""
    Private _Observacion As String = ""
    Private _Provincia As String = ""
    Private _Distrito As String = ""
    Private _Celular As String = ""
    Private _AutorizaCorreoElectronico As String = "false"
    Private _AutorizaWhatsApp As String = "false"
    Private _QuienRecomendo As String = ""
    Private _DNI As String = ""
    Private _CorreoElectronico As String = ""
    Private _Nacionalidad As String = ""
    Private _Referencia As String = ""
    Private _Direccion As String = ""
    Private _Departamento As String = ""
    Sub New()
    End Sub
    Sub New(_FechaNacimiento_ As Date, _FechaInscripcion_ As Date, _IdCliente_ As String, _IdEmpresa_ As String, _Nombre_ As String, _ApellidoPaterno_ As String, _ApellidoMaterno_ As String, _Sexo_ As String, _Ocupacion_ As String, _Observacion_ As String, _Provincia_ As String, _Distrito_ As String, _Celular_ As String, _AutorizaCorreoElectronico_ As String, _AutorizaWhatsApp_ As String, _QuienRecomendo_ As String, _DNI_ As String, _CorreoElectronico_ As String, _Nacionalidad_ As String, _Referencia_ As String, _Direccion_ As String, _Departamento_ As String)
        _FechaNacimiento = _FechaNacimiento_
        _FechaInscripcion = _FechaInscripcion_
        _IdCliente = _IdCliente_
        _IdEmpresa = _IdEmpresa_
        _Nombre = _Nombre_
        _ApellidoPaterno = _ApellidoPaterno_
        _ApellidoMaterno = _ApellidoMaterno_
        _Sexo = _Sexo_
        _Ocupacion = _Ocupacion_
        _Observacion = _Observacion_
        _Provincia = _Provincia_
        _Distrito = _Distrito_
        _Celular = _Celular_
        _AutorizaCorreoElectronico = _AutorizaCorreoElectronico_
        _AutorizaWhatsApp = _AutorizaWhatsApp_
        _QuienRecomendo = _QuienRecomendo_
        _DNI = _DNI_
        _CorreoElectronico = _CorreoElectronico_
        _Nacionalidad = _Nacionalidad_
        _Referencia = _Referencia_
        _Direccion = _Direccion_
        _Departamento = _Departamento_
    End Sub
    Sub New(_IdCliente_ As String, _Usuario_ As String)
        _Usuario = _Usuario_
        _IdCliente = _IdCliente_
        CargarDatos()
    End Sub
    Public Sub CargarDatos()
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcConsultar)
                .AgregarParametroTexto("@IdCliente", _IdCliente)
                .AgregarParametroTexto("@Usuario", _Usuario)
                _BaseDatos.EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read
                    _FechaNacimiento = .Datos.GetValue(0)
                    _FechaInscripcion = .Datos.GetValue(1)
                    _IdCliente = .Datos.GetValue(2)
                    _IdEmpresa = .Datos.GetValue(3)
                    _Nombre = .Datos.GetValue(4)
                    _ApellidoPaterno = .Datos.GetValue(5)
                    _ApellidoMaterno = .Datos.GetValue(6)
                    _Sexo = .Datos.GetValue(7)
                    _Ocupacion = .Datos.GetValue(8)
                    _Observacion = .Datos.GetValue(9)
                    _Provincia = .Datos.GetValue(10)
                    _Distrito = .Datos.GetValue(11)
                    _Celular = .Datos.GetValue(12)
                    _AutorizaCorreoElectronico = .Datos.GetValue(13)
                    _AutorizaWhatsApp = .Datos.GetValue(14)
                    _QuienRecomendo = .Datos.GetValue(15)
                    _DNI = .Datos.GetValue(16)
                    _CorreoElectronico = .Datos.GetValue(17)
                    _Nacionalidad = .Datos.GetValue(18)
                    _Referencia = .Datos.GetValue(19)
                    _Direccion = .Datos.GetValue(20)
                    _Departamento = .Datos.GetValue(21)

                End While
            Catch ex As Exception
            Finally
                .Desconectar()
            End Try
        End With
    End Sub
    Public Sub CargarDatos(_FechaNacimiento_ As Date, _FechaInscripcion_ As Date, _IdCliente_ As String, _IdEmpresa_ As String, _Nombre_ As String, _ApellidoPaterno_ As String, _ApellidoMaterno_ As String, _Sexo_ As String, _Ocupacion_ As String, _Observacion_ As String, _Provincia_ As String, _Distrito_ As String, _Celular_ As String, _AutorizaCorreoElectronico_ As String, _AutorizaWhatsApp_ As String, _QuienRecomendo_ As String, _DNI_ As String, _CorreoElectronico_ As String, _Nacionalidad_ As String, _Referencia_ As String, _Direccion_ As String, _Departamento_ As String)
        _FechaNacimiento = _FechaNacimiento_
        _FechaInscripcion = _FechaInscripcion_
        _IdCliente = _IdCliente_
        _IdEmpresa = _IdEmpresa_
        _Nombre = _Nombre_
        _ApellidoPaterno = _ApellidoPaterno_
        _ApellidoMaterno = _ApellidoMaterno_
        _Sexo = _Sexo_
        _Ocupacion = _Ocupacion_
        _Observacion = _Observacion_
        _Provincia = _Provincia_
        _Distrito = _Distrito_
        _Celular = _Celular_
        _AutorizaCorreoElectronico = _AutorizaCorreoElectronico_
        _AutorizaWhatsApp = _AutorizaWhatsApp_
        _QuienRecomendo = _QuienRecomendo_
        _DNI = _DNI_
        _CorreoElectronico = _CorreoElectronico_
        _Nacionalidad = _Nacionalidad_
        _Referencia = _Referencia_
        _Direccion = _Direccion_
        _Departamento = _Departamento_
    End Sub
    Public Function Actualizar() As Boolean
        Dim Actualizado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcActualizar)
                .AgregarParametroFechaYHora("@FechaNacimiento", _FechaNacimiento)
                .AgregarParametroFechaYHora("@FechaInscripcion", _FechaInscripcion)
                .AgregarParametroTexto("@IdCliente", _IdCliente)
                .AgregarParametroTexto("@IdEmpresa", _IdEmpresa)
                .AgregarParametroTexto("@Nombre", _Nombre)
                .AgregarParametroTexto("@ApellidoPaterno", _ApellidoPaterno)
                .AgregarParametroTexto("@ApellidoMaterno", _ApellidoMaterno)
                .AgregarParametroTexto("@Sexo", _Sexo)
                .AgregarParametroTexto("@Ocupacion", _Ocupacion)
                .AgregarParametroTexto("@Observacion", _Observacion)
                .AgregarParametroTexto("@Provincia", _Provincia)
                .AgregarParametroTexto("@Distrito", _Distrito)
                .AgregarParametroTexto("@Celular", _Celular)
                .AgregarParametroTexto("@AutorizaCorreoElectronico", _AutorizaCorreoElectronico)
                .AgregarParametroTexto("@AutorizaWhatsApp", _AutorizaWhatsApp)
                .AgregarParametroTexto("@QuienRecomendo", _QuienRecomendo)
                .AgregarParametroTexto("@DNI", _DNI)
                .AgregarParametroTexto("@CorreoElectronico", _CorreoElectronico)
                .AgregarParametroTexto("@Nacionalidad", _Nacionalidad)
                .AgregarParametroTexto("@Referencia", _Referencia)
                .AgregarParametroTexto("@Direccion", _Direccion)
                .AgregarParametroTexto("@Departamento", _Departamento)
                .AgregarParametroTexto("@Usuario", _Usuario)
                _BaseDatos.EjecutarConsulta()
                Actualizado = True
            Catch ex As Exception
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
                .AgregarParametroTexto("@IdCliente", _IdCliente)
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
    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(ByVal value As Date)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _FechaNacimiento = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property FechaInscripcion As Date
        Get
            Return _FechaInscripcion
        End Get
        Set(ByVal value As Date)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _FechaInscripcion = value
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
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Nombre = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property ApellidoPaterno As String
        Get
            Return _ApellidoPaterno
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _ApellidoPaterno = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property ApellidoMaterno As String
        Get
            Return _ApellidoMaterno
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _ApellidoMaterno = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Sexo As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Sexo = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Ocupacion As String
        Get
            Return _Ocupacion
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Ocupacion = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Observacion As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Observacion = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Provincia = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Distrito As String
        Get
            Return _Distrito
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Distrito = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Celular As String
        Get
            Return _Celular
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Celular = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AutorizaCorreoElectronico As String
        Get
            Return _AutorizaCorreoElectronico
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AutorizaCorreoElectronico = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property AutorizaWhatsApp As String
        Get
            Return _AutorizaWhatsApp
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _AutorizaWhatsApp = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property QuienRecomendo As String
        Get
            Return _QuienRecomendo
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _QuienRecomendo = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property DNI As String
        Get
            Return _DNI
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _DNI = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property CorreoElectronico As String
        Get
            Return _CorreoElectronico
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _CorreoElectronico = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Nacionalidad As String
        Get
            Return _Nacionalidad
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Nacionalidad = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Referencia As String
        Get
            Return _Referencia
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Referencia = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Direccion = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Departamento As String
        Get
            Return _Departamento
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Departamento = value
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

    ReadOnly Property NombreCompleto As String
        Get
            If _Nombre.Length = 0 Or _ApellidoPaterno.Length = 0 Or _ApellidoMaterno.Length = 0 Then
                Return "Completar Datos"
            Else
                Return Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno
            End If

        End Get
    End Property
    Public ReadOnly Property Mensaje As String
        Get
            Return ""
        End Get

    End Property


    Public ReadOnly Property Edad() As String


        Get
            Dim _AuxFechaNacimiento As Date = _FechaNacimiento
            Dim Años As Integer = 0
            Dim Meses As Integer = 0
            Dim Dias As Integer = 0
            _AuxFechaNacimiento = _AuxFechaNacimiento.AddYears(1)
            While _AuxFechaNacimiento < Date.Now
                _AuxFechaNacimiento = _AuxFechaNacimiento.AddYears(1)
                Años = Años + 1
            End While
            _AuxFechaNacimiento = _AuxFechaNacimiento.AddYears(-1)
            _AuxFechaNacimiento = _AuxFechaNacimiento.AddMonths(1)
            While _AuxFechaNacimiento < Date.Now
                _AuxFechaNacimiento = _AuxFechaNacimiento.AddMonths(1)
                Meses = Meses + 1
            End While
            _AuxFechaNacimiento = _AuxFechaNacimiento.AddMonths(-1)
            _AuxFechaNacimiento = _AuxFechaNacimiento.AddDays(1)

            While _AuxFechaNacimiento < Date.Now
                _AuxFechaNacimiento = _AuxFechaNacimiento.AddDays(1)
                Dias = Dias + 1
            End While
            Return Años.ToString + " Año(s) " + Meses.ToString + " Mes(es) " + Dias.ToString + "Dia(s)"
        End Get


    End Property

    Public Sub RellenarLista_Clase_O_HistoriaClinica()
        _Lista_Clase_O_HistoriaClinica = New Clase_G_DevolverListaDeClases().Lista_Clase_O_HistoriaClinica(_IdCliente)
    End Sub
    Public Property Lista_Clase_O_HistoriaClinica As List(Of Clase_O_HistoriaClinica)
        Get
            Return _Lista_Clase_O_HistoriaClinica
        End Get
        Set(value As List(Of Clase_O_HistoriaClinica))
            _Lista_Clase_O_HistoriaClinica = value
        End Set
    End Property

End Class
