Public Class Clase_G_Dispositivo
    Private _BaseDatos As New BaseDatos
    Private _ActualizarEnCadaCampo As Boolean = False
    '
    Private CadProcConsultar As String = "PA_G_DispositivoConsultar"
    Private CadProcActualizar As String = "PA_G_DispositivoActualizar"
    Private CadProcEliminar As String = "PA_G_DispositivoEliminar"
    '
    Private _IdDispositivo As Guid = Guid.NewGuid()
    Private _IdEmpresa As Guid = Guid.NewGuid()
    '
    Private _Usuario As String = ""
    Private _Orden As Integer = 0
    Private _FechaInscripcion As Date = DateTime.Now
    Private _Activo As Boolean = True
    Private _Vinculado As Boolean = True
    Private _NombreDispositivo As String = ""
    Private _Color As String = ""
    Sub New()
    End Sub
    Sub New(_IdDispositivo_ As Guid, _IdEmpresa_ As Guid, _Orden_ As Integer, _FechaInscripcion_ As Date, _Activo_ As Boolean, _Vinculado_ As Boolean, _NombreDispositivo_ As String, _Color_ As String)
        _IdDispositivo = _IdDispositivo_
        _IdEmpresa = _IdEmpresa_
        _Orden = _Orden_
        _FechaInscripcion = _FechaInscripcion_
        _Activo = _Activo_
        _Vinculado = _Vinculado_
        _NombreDispositivo = _NombreDispositivo_
        _Color = _Color_
    End Sub
    Sub New(_IdDispositivo_ As Guid, _Usuario_ As String)
        _Usuario = _Usuario_
        _IdDispositivo = _IdDispositivo_
        CargarDatos()
    End Sub
    Public Sub CargarDatos()
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcConsultar)
                .AgregarParametroGuid("@IdDispositivo", _IdDispositivo)
                .AgregarParametroTexto("@Usuario", _Usuario)
                _BaseDatos.EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read
                    _IdDispositivo = .Datos.GetValue(0)
                    _IdEmpresa = .Datos.GetValue(1)
                    _Orden = .Datos.GetValue(2)
                    _FechaInscripcion = .Datos.GetValue(3)
                    _Activo = .Datos.GetValue(4)
                    _Vinculado = .Datos.GetValue(5)
                    _NombreDispositivo = .Datos.GetValue(6)
                    _Color = .Datos.GetValue(7)

                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                .Desconectar()
            End Try
        End With
    End Sub
    Public Sub CargarDatos(_IdDispositivo_ As Guid, _IdEmpresa_ As Guid, _Orden_ As Integer, _FechaInscripcion_ As Date, _Activo_ As Boolean, _Vinculado_ As Boolean, _NombreDispositivo_ As String, _Color_ As String)
        _IdDispositivo = _IdDispositivo_
        _IdEmpresa = _IdEmpresa_
        _Orden = _Orden_
        _FechaInscripcion = _FechaInscripcion_
        _Activo = _Activo_
        _Vinculado = _Vinculado_
        _NombreDispositivo = _NombreDispositivo_
        _Color = _Color_
    End Sub
    Public Function Actualizar() As Boolean
        Dim Actualizado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(CadProcActualizar)
                .AgregarParametroGuid("@IdDispositivo", _IdDispositivo)
                .AgregarParametroGuid("@IdEmpresa", _IdEmpresa)
                .AgregarParametroEntero("@Orden", _Orden)
                .AgregarParametroFechaYHora("@FechaInscripcion", _FechaInscripcion)
                .AgregarParametroBit("@Activo", _Activo)
                .AgregarParametroBit("@Vinculado", _Vinculado)
                .AgregarParametroTexto("@NombreDispositivo", _NombreDispositivo)
                .AgregarParametroTexto("@Color", _Color)
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
                .AgregarParametroGuid("@IdDispositivo", _IdDispositivo)
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
    Public Property Id As Guid
        Get
            Return _IdDispositivo
        End Get
        Set(ByVal value As Guid)
            _IdDispositivo = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property IdEmpresa As Guid
        Get
            Return _IdEmpresa
        End Get
        Set(ByVal value As Guid)
            _IdEmpresa = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Orden As Integer
        Get
            Return _Orden
        End Get
        Set(ByVal value As Integer)
            _Orden = value
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
            _FechaInscripcion = value
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
            _Activo = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Vinculado As Boolean
        Get
            Return _Vinculado
        End Get
        Set(ByVal value As Boolean)
            _Vinculado = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property NombreDispositivo As String
        Get
            Return _NombreDispositivo
        End Get
        Set(ByVal value As String)
            _NombreDispositivo = value
            If _ActualizarEnCadaCampo = True Then
                Actualizar()
            End If
        End Set
    End Property
    Public Property Color As String
        Get
            Return _Color
        End Get
        Set(ByVal value As String)
            _Color = value
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

End Class
