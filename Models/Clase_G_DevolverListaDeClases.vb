Public Class Clase_G_DevolverListaDeClases
    Public Function Lista_Clase_G_Dispositivo(_Filtro As String) As List(Of Clase_G_Dispositivo)
        Dim _BaseDatos As New BaseDatos()
        Dim _Lista_Clase_ As New List(Of Clase_G_Dispositivo)
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo("PA_G_DispositivoConsultarLista")
                .AgregarParametroTexto("@Filtro", _Filtro)
                .EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read()
                    _Lista_Clase_.Add(New Clase_G_Dispositivo(.Datos.GetValue(0), .Datos.GetValue(1), .Datos.GetValue(2), .Datos.GetValue(3), .Datos.GetValue(4), .Datos.GetValue(5), .Datos.GetValue(6), .Datos.GetValue(7)))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                _BaseDatos.Desconectar()
            End Try
        End With
        For Each _Clase_ As Clase_G_Dispositivo In _Lista_Clase_
            _Clase_.CargarDatos()
        Next
        Return (_Lista_Clase_)
    End Function

    Friend Function Lista_Clase_S_UsuariosSinRoles(_Filtro As String, UserName As String) As Object
        Dim _BaseDatos As New BaseDatos()
        Dim _Lista_Clase_ As New List(Of Clase_S_User)
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo("PA_S_UsuariosSinRoles")
                .AgregarParametroTexto("@Filtro", _Filtro)
                .AgregarParametroTexto("@UserName", UserName)
                .EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read()
                    _Lista_Clase_.Add(New Clase_S_User(.Datos.GetValue(0), .Datos.GetValue(1)))

                End While
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                _BaseDatos.Desconectar()
            End Try
        End With
        Return (_Lista_Clase_)



    End Function



    Public Function Lista_Clase_G_Personal(_Filtro As String) As List(Of Clase_G_Personal)

        Dim _BaseDatos As New BaseDatos()
        Dim _Lista_Clase_ As New List(Of Clase_G_Personal)
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo("PA_G_PersonalConsultarLista")
                .AgregarParametroTexto("@Filtro", _Filtro)
                .AgregarParametroTexto("@Usuario", My.User.Name)
                .EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read()
                    _Lista_Clase_.Add(New Clase_G_Personal(.Datos.GetValue(0), .Datos.GetValue(1), .Datos.GetValue(2), .Datos.GetValue(3), .Datos.GetValue(4), .Datos.GetValue(5), .Datos.GetValue(6), .Datos.GetValue(7), .Datos.GetValue(8), .Datos.GetValue(9), .Datos.GetValue(10), .Datos.GetValue(11), .Datos.GetValue(12), .Datos.GetValue(13), .Datos.GetValue(14), .Datos.GetValue(15), .Datos.GetValue(16), .Datos.GetValue(17), .Datos.GetValue(18)))
                End While
            Catch ex As Exception
            Finally
                _BaseDatos.Desconectar()
            End Try
        End With
        Return (_Lista_Clase_)
    End Function

    Public Function Lista_Clase_G_Cliente(_Filtro As String) As List(Of Clase_G_Cliente)

        Dim _BaseDatos As New BaseDatos()
        Dim _Lista_Clase_ As New List(Of Clase_G_Cliente)
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo("PA_G_ClienteConsultarLista")
                .AgregarParametroTexto("@Filtro", _Filtro)
                .AgregarParametroTexto("@Usuario", My.User.Name)
                .EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read()
                    _Lista_Clase_.Add(New Clase_G_Cliente(.Datos.GetValue(0), .Datos.GetValue(1), .Datos.GetValue(2), .Datos.GetValue(3), .Datos.GetValue(4), .Datos.GetValue(5), .Datos.GetValue(6), .Datos.GetValue(7), .Datos.GetValue(8), .Datos.GetValue(9), .Datos.GetValue(10), .Datos.GetValue(11), .Datos.GetValue(12), .Datos.GetValue(13), .Datos.GetValue(14), .Datos.GetValue(15), .Datos.GetValue(16), .Datos.GetValue(17), .Datos.GetValue(18), .Datos.GetValue(19), .Datos.GetValue(20), .Datos.GetValue(21)))
                End While
            Catch ex As Exception
            Finally
                _BaseDatos.Desconectar()
            End Try
        End With
        Return (_Lista_Clase_)

    End Function

    Public Function lista_Clase_G_PersonalConsultarListaOdontoloConClienteVinculado(IdCliente As String) As List(Of Clase_G_Personal)

        Dim _BaseDatos As New BaseDatos()
        Dim _Lista_Clase_ As New List(Of Clase_G_Personal)
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo("PA_G_PersonalConsultarListaOdontoloConClienteVinculado")
                .AgregarParametroTexto("@IdCliente", IdCliente)
                .AgregarParametroTexto("@Usuario", My.User.Name)
                .EjecutarConsulta_Y_ObtenerDatos()
                'Advertencia se agrego IDCLIENTE
                'Advertencia se agrego IDCLIENTE
                'Advertencia se agrego IDCLIENTE
                'Advertencia se agrego IDCLIENTE
                'Advertencia se agrego IDCLIENTE
                While .Datos.Read()
                    _Lista_Clase_.Add(New Clase_G_Personal(.Datos.GetValue(0), .Datos.GetValue(1), .Datos.GetValue(2), .Datos.GetValue(3), .Datos.GetValue(4), .Datos.GetValue(5), .Datos.GetValue(6), .Datos.GetValue(7), .Datos.GetValue(8), .Datos.GetValue(9), .Datos.GetValue(10), .Datos.GetValue(11), .Datos.GetValue(12), .Datos.GetValue(13), .Datos.GetValue(14), .Datos.GetValue(15), .Datos.GetValue(16), .Datos.GetValue(17), .Datos.GetValue(18), .Datos.GetValue(19), IdCliente))
                End While
            Catch ex As Exception
            Finally
                _BaseDatos.Desconectar()
            End Try
        End With
        Return (_Lista_Clase_)
    End Function

    Public Function Lista_Clase_O_HistoriaClinica(_Id As String) As List(Of Clase_O_HistoriaClinica)
        Dim _BaseDatos As New BaseDatos()
        Dim _Lista_Clase_ As New List(Of Clase_O_HistoriaClinica)
        With _BaseDatos
            Try
                .Conectar()
                .CrearComandoProcedimientoAlmacendo("PA_O_HistoriaClinicaConsultarLista")
                .AgregarParametroTexto("@IdCliente", _Id)
                .AgregarParametroTexto("@Usuario", My.User.Name)
                .EjecutarConsulta_Y_ObtenerDatos()
                While .Datos.Read()
                    _Lista_Clase_.Add(New Clase_O_HistoriaClinica(.Datos.GetValue(0), .Datos.GetValue(1), .Datos.GetValue(2), .Datos.GetValue(3), .Datos.GetValue(4), .Datos.GetValue(5), .Datos.GetValue(6), .Datos.GetValue(7), .Datos.GetValue(8), .Datos.GetValue(9), .Datos.GetValue(10), .Datos.GetValue(11), .Datos.GetValue(12), .Datos.GetValue(13), .Datos.GetValue(14), .Datos.GetValue(15), .Datos.GetValue(16), .Datos.GetValue(17), .Datos.GetValue(18), .Datos.GetValue(19), .Datos.GetValue(20), .Datos.GetValue(21), .Datos.GetValue(22), .Datos.GetValue(23), .Datos.GetValue(24), .Datos.GetValue(25), .Datos.GetValue(26), .Datos.GetValue(27), .Datos.GetValue(28), .Datos.GetValue(29), .Datos.GetValue(30), .Datos.GetValue(31), .Datos.GetValue(32), .Datos.GetValue(33), .Datos.GetValue(34), .Datos.GetValue(35), .Datos.GetValue(36), .Datos.GetValue(37), .Datos.GetValue(38), .Datos.GetValue(39), .Datos.GetValue(40), .Datos.GetValue(41), .Datos.GetValue(42), .Datos.GetValue(43), .Datos.GetValue(44), .Datos.GetValue(45), .Datos.GetValue(46), .Datos.GetValue(47), .Datos.GetValue(48), .Datos.GetValue(49), .Datos.GetValue(50), .Datos.GetValue(51), .Datos.GetValue(52), .Datos.GetValue(53)))
                End While
            Catch ex As Exception
            Finally
                _BaseDatos.Desconectar()
            End Try
        End With
        For Each _Clase_ As Clase_O_HistoriaClinica In _Lista_Clase_
            _Clase_.CargarDatos()
        Next
        Return (_Lista_Clase_)
    End Function




End Class
