Imports System.Data.SqlClient
Imports System.Configuration
Public Class BaseDatos
    Private _Conexion As SqlConnection = Nothing
    Private _Comando As SqlCommand = Nothing
    Private _Transaccion As SqlTransaction = Nothing
    Private _LecturaDeDatos As System.Data.SqlClient.SqlDataReader = Nothing
    Private _CadenaConexion As String
    Private _Excepciones As SqlException

    Public Sub New()
        Try

            Me._CadenaConexion = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
            _Conexion = New SqlConnection(Me._CadenaConexion)

        Catch
            MsgBox("Error al cargar la configuración del acceso a datos.")
        End Try
    End Sub
    Public Sub New(ByVal CadenaDeConexion As String)
        Me._CadenaConexion = CadenaDeConexion
        _Conexion = New SqlConnection(Me._CadenaConexion)
    End Sub

    ''' <summary>
    ''' Permite desconectarse de la base de datos.
    ''' </summary>
    Public Sub Desconectar()
        If Me._Conexion.State.Equals(ConnectionState.Open) Then
            Me._Conexion.Close()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Conectar() As Boolean
        Dim Conectado As Boolean = False
        If Not Me._Conexion Is Nothing Then
            If Me._Conexion.State.Equals(ConnectionState.Open) Then
                Conectado = True
            Else
                Try
                    Me._Conexion.Open()
                    Conectado = True
                Catch
                    My.Settings.Save()
                    Conectado = False
                End Try
            End If
        Else
            Me._Conexion.ConnectionString = _CadenaConexion
            Try
                Me._Conexion.Open()
                Conectado = True
            Catch
                My.Settings.Save()
                Conectado = False
            End Try
        End If
        Return Conectado
    End Function
    Public Property Excepcion As SqlException
        Get
            Return _Excepciones
        End Get
        Set(value As SqlException)
            _Excepciones = value
        End Set
    End Property

    ''' <summary>
    ''' Ingresa cualquier consulta SQL este simplemente se ejecutará
    ''' </summary>
    ''' <param name="sentenciaSQL"></param>
    ''' <remarks></remarks>
    Public Sub CrearComandoTextoSimple(ByVal sentenciaSQL As String)
        Me._Comando = New SqlCommand(sentenciaSQL, _Conexion)
        Me._Comando.CommandType = CommandType.Text
        If Not Me._Transaccion Is Nothing Then
            Me._Comando.Transaction = Me._Transaccion
        End If
    End Sub
    ''' <summary>
    ''' Ingresa cualquier consulta SQL este simplemente se ejecutará
    ''' </summary>
    ''' <param name="sentenciaSQL"></param>
    ''' <remarks></remarks>
    Public Sub CrearComandoProcedimientoAlmacendo(ByVal sentenciaSQL As String)
        Me._Comando = New SqlCommand(sentenciaSQL, _Conexion)
        Me._Comando.CommandType = CommandType.StoredProcedure
        If Not Me._Transaccion Is Nothing Then
            Me._Comando.Transaction = Me._Transaccion
        End If
    End Sub
    Public Sub AgregarParametroBit(NombreCampo As String, Valor As Object)
        Me._Comando.Parameters.Add(NombreCampo, SqlDbType.Bit).Value = Valor
    End Sub
    Public Sub AgregarParametroEntero(NombreCampo As String, Valor As Object)
        Me._Comando.Parameters.Add(NombreCampo, SqlDbType.Int).Value = Valor
    End Sub
    Public Sub AgregarParametroDecimal(NombreCampo As String, Valor As Object)
        Me._Comando.Parameters.Add(NombreCampo, SqlDbType.Decimal).Value = Valor
    End Sub
    Public Sub AgregarParametroFechaYHora(NombreCampo As String, Valor As Object)
        Me._Comando.Parameters.Add(NombreCampo, SqlDbType.DateTime).Value = Valor
    End Sub
    Public Sub AgregarParametroTexto(NombreCampo As String, Valor As Object)
        Me._Comando.Parameters.Add(NombreCampo, SqlDbType.VarChar).Value = Valor
    End Sub
    Public Sub AgregarParametroImagen(NombreCampo As String, Valor As Object)
        Me._Comando.Parameters.Add(NombreCampo, SqlDbType.Image).Value = Valor
    End Sub
    Public Sub AgregarParametroGuid(NombreCampo As String, Valor As Object)
        Me._Comando.Parameters.Add(NombreCampo, SqlDbType.UniqueIdentifier).Value = Valor
    End Sub
    Public Function EjecutarConsulta() As SqlDataReader
        Return Me._Comando.ExecuteReader()
    End Function

    Public Function EjecutarEscalar() As Integer
        Dim escalar As Integer = 0
        Try
            escalar = Integer.Parse(Me._Comando.ExecuteScalar().ToString())
        Catch ex As InvalidCastException
            MsgBox("Error al ejecutar un escalar.")
        End Try
        Return escalar
    End Function
    ''' <summary>
    ''' Ejecuta el comando creado.
    ''' </summary>
    Public Sub EjecutarComando()
        Me._Comando.ExecuteNonQuery()
    End Sub

    ''' <summary>
    ''' Comienza una transacción en base a la conexion abierta.
    ''' Todo lo que se ejecute luego de esta ionvocación estará 
    ''' dentro de una tranasacción.
    ''' </summary>
    Public Sub ComenzarTransaccion()
        If Me._Transaccion Is Nothing Then
            Me._Transaccion = Me._Conexion.BeginTransaction()
        End If
    End Sub

    ''' <summary>
    ''' Cancela la ejecución de una transacción.
    ''' Todo lo ejecutado entre ésta invocación y su 
    ''' correspondiente <c>ComenzarTransaccion</c> será perdido.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CancelarTransaccion()
        If Not Me._Transaccion Is Nothing Then
            Me._Transaccion.Rollback()
        End If
    End Sub

    ''' <summary>
    ''' Confirma todo los comandos ejecutados entre el <c>ComanzarTransaccion</c>
    ''' y ésta invocación.
    ''' </summary>
    Public Sub ConfirmarTransaccion()
        If Not Me._Transaccion Is Nothing Then
            Me._Transaccion.Commit()
        End If
    End Sub

    Public Sub EjecutarConsulta_Y_ObtenerDatos()
        Me._LecturaDeDatos = Nothing
        Me._LecturaDeDatos = Me.EjecutarConsulta()
    End Sub
    Public ReadOnly Property Datos As System.Data.SqlClient.SqlDataReader
        Get
            Return Me._LecturaDeDatos
        End Get
    End Property

End Class
