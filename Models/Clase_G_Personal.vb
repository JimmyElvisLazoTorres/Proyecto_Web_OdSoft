Public Class Clase_G_Personal
    Private _BaseDatos As New BaseDatos
    Private _ActualizarEnCadaCampo As Boolean = True
    Private _CargarDatosEnCadaCampo As Boolean = False
    Private _DatosActualizados As Boolean = False
    Private _PersonalClienteVinculado As Integer = 0
    Private _IdClienteVinculado As String = ""
    Private CadProcConsultarCorreoElectronico As String = "PA_G_PersonalConsultarCorreoElectronico"
    Private CadProcActualizarPersonalClienteActualizar As String = "PA_G_PersonalClienteActualizar"
    '


    Private CadProcConsultar As String = "PA_G_PersonalConsultar"
    Private CadProcActualizar As String = "PA_G_PersonalActualizar"
    Private CadProcEliminar As String = "PA_G_PersonalEliminar"
    '
    Private _IdPersonal As String = ""
    Private _IdEmpresa As String = ""
    '
    Private _Usuario As String = ""
    Private _FechaNacimiento As Date = DateTime.Now
    Private _Activo As Boolean = True
    Private _rId As String = ""
    Private _Nombre As String = ""
    Private _ApellidoPaterno As String = ""
    Private _ApellidoMaterno As String = ""
    Private _Region As String = ""
    Private _Especialidad As String = ""
    Private _Observaciones As String = ""
    Private _Telefonos As String = ""
    Private _ROL As String = ""
    Private _Sexo As String = ""
    Private _DNI As String = ""
    Private _CorreoElectronico As String = ""
    Private _Direccion As String = ""
    Private _Distrito As String = ""
    Private _Provincia As String = ""
    Sub New()
    End Sub
    Sub New(_FechaNacimiento_ As Date, _Activo_ As Boolean, _IdPersonal_ As String, _IdEmpresa_ As String, _rId_ As String, _Nombre_ As String, _ApellidoPaterno_ As String, _ApellidoMaterno_ As String, _Region_ As String, _Especialidad_ As String, _Observaciones_ As String, _Telefonos_ As String, _ROL_ As String, _Sexo_ As String, _DNI_ As String, _CorreoElectronico_ As String, _Direccion_ As String, _Distrito_ As String, _Provincia_ As String)
        _FechaNacimiento = _FechaNacimiento_
        _Activo = _Activo_
        _IdPersonal = _IdPersonal_
        _IdEmpresa = _IdEmpresa_
        _rId = _rId_
        _Nombre = _Nombre_
        _ApellidoPaterno = _ApellidoPaterno_
        _ApellidoMaterno = _ApellidoMaterno_
        _Region = _Region_
        _Especialidad = _Especialidad_
        _Observaciones = _Observaciones_
        _Telefonos = _Telefonos_
        _ROL = _ROL_
        _Sexo = _Sexo_
        _DNI = _DNI_
        _CorreoElectronico = _CorreoElectronico_
        _Direccion = _Direccion_
        _Distrito = _Distrito_
        _Provincia = _Provincia_
    End Sub
    Sub New(_IdPersonal_ As String, _Usuario_ As String)
        _Usuario = _Usuario_
        _IdPersonal = _IdPersonal_
        CargarDatos()
    End Sub
    Public Sub CargarDatos()
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcConsultar)
                .AgregarParametroTexto("@IdPersonal", _IdPersonal)
                .AgregarParametroTexto("@Usuario", _Usuario)
                _BaseDatos.EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read
                    _FechaNacimiento = .Datos.GetValue(0)
                    _Activo = .Datos.GetValue(1)
                    _IdPersonal = .Datos.GetValue(2)
                    _IdEmpresa = .Datos.GetValue(3)
                    _rId = .Datos.GetValue(4)
                    _Nombre = .Datos.GetValue(5)
                    _ApellidoPaterno = .Datos.GetValue(6)
                    _ApellidoMaterno = .Datos.GetValue(7)
                    _Region = .Datos.GetValue(8)
                    _Especialidad = .Datos.GetValue(9)
                    _Observaciones = .Datos.GetValue(10)
                    _Telefonos = .Datos.GetValue(11)
                    _ROL = .Datos.GetValue(12)
                    _Sexo = .Datos.GetValue(13)
                    _DNI = .Datos.GetValue(14)
                    _CorreoElectronico = .Datos.GetValue(15)
                    _Direccion = .Datos.GetValue(16)
                    _Distrito = .Datos.GetValue(17)
                    _Provincia = .Datos.GetValue(18)

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                .Desconectar()
            End Try
        End With
    End Sub
    Public Sub CargarDatos(_FechaNacimiento_ As Date, _Activo_ As Boolean, _IdPersonal_ As String, _IdEmpresa_ As String, _rId_ As String, _Nombre_ As String, _ApellidoPaterno_ As String, _ApellidoMaterno_ As String, _Region_ As String, _Especialidad_ As String, _Observaciones_ As String, _Telefonos_ As String, _ROL_ As String, _Sexo_ As String, _DNI_ As String, _CorreoElectronico_ As String, _Direccion_ As String, _Distrito_ As String, _Provincia_ As String)
        _FechaNacimiento = _FechaNacimiento_
        _Activo = _Activo_
        _IdPersonal = _IdPersonal_
        _IdEmpresa = _IdEmpresa_
        _rId = _rId_
        _Nombre = _Nombre_
        _ApellidoPaterno = _ApellidoPaterno_
        _ApellidoMaterno = _ApellidoMaterno_
        _Region = _Region_
        _Especialidad = _Especialidad_
        _Observaciones = _Observaciones_
        _Telefonos = _Telefonos_
        _ROL = _ROL_
        _Sexo = _Sexo_
        _DNI = _DNI_
        _CorreoElectronico = _CorreoElectronico_
        _Direccion = _Direccion_
        _Distrito = _Distrito_
        _Provincia = _Provincia_
    End Sub
    Public Function Actualizar() As Boolean
        Dim Actualizado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcActualizar)
                .AgregarParametroFechaYHora("@FechaNacimiento", _FechaNacimiento)
                .AgregarParametroBit("@Activo", _Activo)
                .AgregarParametroTexto("@IdPersonal", _IdPersonal)
                .AgregarParametroTexto("@IdEmpresa", _IdEmpresa)
                .AgregarParametroTexto("@rId", _rId)
                .AgregarParametroTexto("@Nombre", _Nombre)
                .AgregarParametroTexto("@ApellidoPaterno", _ApellidoPaterno)
                .AgregarParametroTexto("@ApellidoMaterno", _ApellidoMaterno)
                .AgregarParametroTexto("@Region", _Region)
                .AgregarParametroTexto("@Especialidad", _Especialidad)
                .AgregarParametroTexto("@Observaciones", _Observaciones)
                .AgregarParametroTexto("@Telefonos", _Telefonos)
                .AgregarParametroTexto("@ROL", _ROL)
                .AgregarParametroTexto("@Sexo", _Sexo)
                .AgregarParametroTexto("@DNI", _DNI)
                .AgregarParametroTexto("@CorreoElectronico", _CorreoElectronico)
                .AgregarParametroTexto("@Direccion", _Direccion)
                .AgregarParametroTexto("@Distrito", _Distrito)
                .AgregarParametroTexto("@Provincia", _Provincia)
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
                .AgregarParametroTexto("@IdPersonal", _IdPersonal)
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
    Public Property rId As String
        Get
            Return _rId
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _rId = value
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
    Public Property Region As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Region = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Especialidad As String
        Get
            Return _Especialidad
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Especialidad = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Observaciones As String
        Get
            Return _Observaciones
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Observaciones = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Telefonos As String
        Get
            Return _Telefonos
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Telefonos = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property ROL As String
        Get
            Return _ROL
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _ROL = value
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

    ReadOnly Property Mensaje As String
        Get
            If _ROL = "ADMINISTRADOR_GENERAL" Then
                Return "Solo el administrador general puede cambiar sus datos"
            Else
                Return ""
            End If
        End Get
    End Property

    Public Property CorreoElectronico As String
        Get
            Return _CorreoElectronico
        End Get
        Set(ByVal value As String)

            _CorreoElectronico = value

            Dim Actualizado As Boolean = False
            With _BaseDatos
                Try
                    .Conectar()
                    .CrearComandoProcedimientoAlmacendo(CadProcConsultarCorreoElectronico)
                    .AgregarParametroTexto("@CorreoElectronico", _CorreoElectronico)
                    .AgregarParametroTexto("@Usuario", My.User.Name)
                    _BaseDatos.EjecutarConsulta_Y_ObtenerDatos()
                    While .Datos.Read
                        _FechaNacimiento = .Datos.GetValue(0)
                        _Activo = .Datos.GetValue(1)
                        _IdPersonal = .Datos.GetValue(2)
                        _IdEmpresa = .Datos.GetValue(3)
                        _rId = .Datos.GetValue(4)
                        _Nombre = .Datos.GetValue(5)
                        _ApellidoPaterno = .Datos.GetValue(6)
                        _ApellidoMaterno = .Datos.GetValue(7)
                        _Region = .Datos.GetValue(8)
                        _Especialidad = .Datos.GetValue(9)
                        _Observaciones = .Datos.GetValue(10)
                        _Telefonos = .Datos.GetValue(11)
                        _ROL = .Datos.GetValue(12)
                        _Sexo = .Datos.GetValue(13)
                        _DNI = .Datos.GetValue(14)
                        _CorreoElectronico = .Datos.GetValue(15)
                        _Direccion = .Datos.GetValue(16)
                        _Distrito = .Datos.GetValue(17)
                        _Provincia = .Datos.GetValue(18)

                    End While
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    .Desconectar()
                End Try
            End With

        End Set
    End Property
    Public ReadOnly Property Id As String
        Get
            Return _IdPersonal
        End Get
    End Property

    Sub New(_FechaNacimiento_ As Date, _Activo_ As Boolean, _IdPersonal_ As String, _IdEmpresa_ As String, _rId_ As String, _Nombre_ As String, _ApellidoPaterno_ As String, _ApellidoMaterno_ As String, _Region_ As String, _Especialidad_ As String, _Observaciones_ As String, _Telefonos_ As String, _ROL_ As String, _Sexo_ As String, _DNI_ As String, _CorreoElectronico_ As String, _Direccion_ As String, _Distrito_ As String, _Provincia_ As String, _PersonalClienteVinculado_ As Integer, _IdClienteVinculado_ As String)
        _FechaNacimiento = _FechaNacimiento_
        _Activo = _Activo_
        _IdPersonal = _IdPersonal_
        _IdEmpresa = _IdEmpresa_
        _rId = _rId_
        _Nombre = _Nombre_
        _ApellidoPaterno = _ApellidoPaterno_
        _ApellidoMaterno = _ApellidoMaterno_
        _Region = _Region_
        _Especialidad = _Especialidad_
        _Observaciones = _Observaciones_
        _Telefonos = _Telefonos_
        _ROL = _ROL_
        _Sexo = _Sexo_
        _DNI = _DNI_
        _CorreoElectronico = _CorreoElectronico_
        _Direccion = _Direccion_
        _Distrito = _Distrito_
        _Provincia = _Provincia_
        _PersonalClienteVinculado = _PersonalClienteVinculado_
        _IdClienteVinculado = _IdClienteVinculado_
    End Sub
    Public ReadOnly Property PersonalClienteVinculado As Integer
        Get
            Return _PersonalClienteVinculado
        End Get
    End Property
    Public Property IdClienteVinculado As String
        Get
            Return _IdClienteVinculado
        End Get
        Set(value As String)
            _IdClienteVinculado = value
        End Set
    End Property
    Public Sub Vincular()
        Dim Actualizado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcActualizarPersonalClienteActualizar)
                .AgregarParametroTexto("@IdCliente", _IdClienteVinculado)
                .AgregarParametroTexto("@IdPersonal", _IdPersonal)
                _BaseDatos.EjecutarConsulta()
            Catch ex As Exception

            Finally
                .Desconectar()
            End Try
        End With
    End Sub
End Class
