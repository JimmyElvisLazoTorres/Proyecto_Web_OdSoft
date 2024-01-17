Public Class Clase_S_Empresa
    Private _BaseDatos As New BaseDatos
    Private _ActualizarEnCadaCampo As Boolean = False
    Private _CargarDatosEnCadaCampo As Boolean = True
    Private _DatosActualizados As Boolean = False

    '
    Private CadProcConsultar As String = "PA_S_EmpresaConsultar"
    Private CadProcActualizar As String = "PA_S_EmpresaActualizar"
    Private CadProcEliminar As String = "PA_S_EmpresaEliminar"
    '
    Private _Usuario As String = ""
    Private _Activo As Boolean = True
    Private _UserId As String = ""
    Private _NombreCompleto As String = ""
    Private _Imagen As String = ""
    Private _RUC As String = ""
    Private _Direccion As String = ""
    Private _Nacionalidad As String = ""
    Private _Celular As String = ""
    Private _WhatsApp As String = ""

    Sub New()
    End Sub
    Sub New(_Activo_ As Boolean, _UserId_ As String, _NombreCompleto_ As String, _Imagen_ As String, _RUC_ As String, _Direccion_ As String, _Nacionalidad_ As String, _Celular_ As String, _WhatsApp_ As String)
        _Activo = _Activo_
        _UserId = _UserId_
        _NombreCompleto = _NombreCompleto_
        _Imagen = _Imagen_
        _RUC = _RUC_
        _Direccion = _Direccion_
        _Nacionalidad = _Nacionalidad_
        _Celular = _Celular_
        _WhatsApp = _WhatsApp_
    End Sub
    Sub New(_Usuario_ As String)
        _Usuario = _Usuario_
        CargarDatos()
    End Sub
    Public Sub CargarDatos()
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcConsultar)
                .AgregarParametroTexto("@Usuario", _Usuario)
                _BaseDatos.EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read
                    _Activo = .Datos.GetValue(0)
                    _UserId = .Datos.GetValue(1)
                    _NombreCompleto = .Datos.GetValue(2)
                    _Imagen = .Datos.GetValue(3)
                    _RUC = .Datos.GetValue(4)
                    _Direccion = .Datos.GetValue(5)
                    _Nacionalidad = .Datos.GetValue(6)
                    _Celular = .Datos.GetValue(7)
                    _WhatsApp = .Datos.GetValue(8)

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                .Desconectar()
            End Try
        End With
    End Sub
    Public Sub CargarDatos(_Activo_ As Boolean, _UserId_ As String, _NombreCompleto_ As String, _Imagen_ As String, _RUC_ As String, _Direccion_ As String, _Nacionalidad_ As String, _Celular_ As String, _WhatsApp_ As String)
        _Activo = _Activo_
        _UserId = _UserId_
        _NombreCompleto = _NombreCompleto_
        _Imagen = _Imagen_
        _RUC = _RUC_
        _Direccion = _Direccion_
        _Nacionalidad = _Nacionalidad_
        _Celular = _Celular_
        _WhatsApp = _WhatsApp_
    End Sub
    Public Function Actualizar() As Boolean
        Dim Actualizado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcActualizar)
                .AgregarParametroBit("@Activo", _Activo)
                .AgregarParametroTexto("@UserId", _UserId)
                .AgregarParametroTexto("@NombreCompleto", _NombreCompleto)
                .AgregarParametroTexto("@Imagen", _Imagen)
                .AgregarParametroTexto("@RUC", _RUC)
                .AgregarParametroTexto("@Direccion", _Direccion)
                .AgregarParametroTexto("@Nacionalidad", _Nacionalidad)
                .AgregarParametroTexto("@Celular", _Celular)
                .AgregarParametroTexto("@WhatsApp", _WhatsApp)
                .AgregarParametroTexto("@Usuario", _Usuario)
                _BaseDatos.EjecutarConsulta()
                _DatosActualizados = True
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

    Public Property UserId As String
        Get
            Return _UserId
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _UserId = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property NombreCompleto As String
        Get
            Return _NombreCompleto
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _NombreCompleto = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Imagen As String
        Get
            Return _Imagen
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _Imagen = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property RUC As String
        Get
            Return _RUC
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _RUC = value
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
    Public Property WhatsApp As String
        Get
            Return _WhatsApp
        End Get
        Set(ByVal value As String)
            If _CargarDatosEnCadaCampo = True Then
                CargarDatos()
            End If
            _WhatsApp = value
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

    Public ReadOnly Property Mensaje As String
        Get
            Dim Aux_Mensaje As String = ""
            If _DatosActualizados Then
                Aux_Mensaje = "Los Datos ingresados fueron actualizados"
            End If
            Return Aux_Mensaje
        End Get
    End Property


End Class
