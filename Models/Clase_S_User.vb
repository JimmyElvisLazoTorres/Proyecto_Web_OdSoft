Public Class Clase_S_User
    Private _BaseDatos As New BaseDatos
    Private PA_01 As String = "PA_S_UsuarioComoADMINISTRADORGENERAL"
    Private PA_02 As String = "PA_S_ExisteUsuario"
    Private PA_03 As String = "PA_S_UsuarioComoRECEPCION"

    Private _UserId As String = ""
    Private _Email As String = ""
    Sub New()

    End Sub
    Sub New(_UserId_ As String)
        _UserId = _UserId_
    End Sub

    Sub New(_UserId_ As String, _Email_ As String)
        _UserId = _UserId_
        _Email = _Email_
    End Sub
    Public Property UserId As String
        Get
            Return _UserId
        End Get
        Set(value As String)
            _UserId = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
    Public Function UsuarioComoADMINISTRADORGENERAL(UserName As String) As String
        Dim Actualizado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(PA_03)
                .AgregarParametroTexto("@UserId", _UserId)
                .AgregarParametroTexto("@UserName", UserName)
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
    Public Function ExisteUsuario() As Boolean
        Dim _ExisteUsuario As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(PA_02)
                .AgregarParametroTexto("@Email", _Email)
                _BaseDatos.EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read
                    _ExisteUsuario = .Datos.GetValue(0)
                    _UserId = .Datos.GetValue(1)

                End While

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                .Desconectar()
            End Try
        End With
        Return _ExisteUsuario
    End Function
    Public Function UsuarioComoRECEPCIONISTA(UserName As String) As String
        Dim Actualizado As Boolean = False
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo(PA_03)
                .AgregarParametroTexto("@UserId", _UserId)
                .AgregarParametroTexto("@UserName", UserName)
                _BaseDatos.EjecutarConsulta()
                Actualizado = True
            Catch ex As Exception

            Finally
                .Desconectar()
            End Try
        End With
        Return Actualizado
    End Function
End Class
