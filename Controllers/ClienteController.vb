Imports System.Web.Mvc

Namespace Controllers
    Public Class ClienteController
        Inherits Controller


        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function Lista(ByVal Filtro As String) As ActionResult
            If IsNothing(Filtro) Then
                Filtro = ""
            End If
            Dim ListaDeClases As New Clase_G_DevolverListaDeClases
            Return View(ListaDeClases.Lista_Clase_G_Cliente(Filtro))
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function Objeto(ByVal Id As String) As ActionResult
            If IsNothing(Id) Then
                Id = Guid.NewGuid.ToString()
            End If
            Dim _Objeto As New Clase_G_Cliente(Id, My.User.Name)
            Return View(_Objeto)
        End Function

        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function EnBlanco() As ActionResult
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function ActualizarCampo(ByVal Dato As String) As ActionResult
            Dim DatoActualizado As Boolean = False
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_G_Cliente(Dato_Aux(0), My.User.Name)
            Dim Mensaje = ""
            Select Case Dato_Aux(2)

                Case "FechaNacimiento"
                    _Clase.FechaNacimiento = DateAndTime.DateValue(Dato_Aux(1).ToString)
                    DatoActualizado = True
                Case "Nombre"

                    _Clase.Nombre = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "ApellidoPaterno"
                    _Clase.ApellidoPaterno = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "ApellidoMaterno"
                    _Clase.ApellidoMaterno = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Sexo"
                    _Clase.Sexo = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Ocupacion"
                    _Clase.Ocupacion = Dato_Aux(1).ToString
                    DatoActualizado = True


                Case "Observaciones"
                    _Clase.Observacion = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "Provincia"
                    _Clase.Provincia = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "Distrito"
                    _Clase.Distrito = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Celular"
                    _Clase.Celular = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AutorizaCorreoElectronico"
                    _Clase.AutorizaCorreoElectronico = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "AutorizaWhatsApp"
                    _Clase.AutorizaWhatsApp = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "QuienRecomendo"
                    _Clase.QuienRecomendo = Dato_Aux(1).ToString
                    DatoActualizado = True


                Case "DNI"
                    _Clase.DNI = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "CorreoElectronico"
                    _Clase.CorreoElectronico = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Nacionalidad"
                    _Clase.Nacionalidad = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Referencia"
                    _Clase.Referencia = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Direccion"
                    _Clase.Direccion = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Departamento"
                    _Clase.Departamento = Dato_Aux(1).ToString
                    DatoActualizado = True



            End Select

            ViewBag.Mensaje = Mensaje
            ViewBag.DatoActualizado = DatoActualizado

            Return View()
        End Function

        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function SinActualizacion() As ActionResult
            Return View()
        End Function

        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function ActualizarCampoAutorizaCorreoElectronico(ByVal Dato As String) As ActionResult
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_G_Cliente(Dato_Aux(0), My.User.Name)
            Dim AutorizaCorreoElectronico = ""
            If Dato_Aux(2) = "AutorizaCorreoElectronico" Then
                _Clase.AutorizaCorreoElectronico = Dato_Aux(1).ToString
                AutorizaCorreoElectronico = Dato_Aux(1).ToString
            End If
            ViewBag.AutorizaCorreoElectronico = AutorizaCorreoElectronico
            ViewBag.IdCliente = Dato_Aux(0)
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function ActualizarCampoAutorizaWhatsApp(ByVal Dato As String) As ActionResult
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_G_Cliente(Dato_Aux(0), My.User.Name)
            Dim AutorizaWhatsApp = ""
            If Dato_Aux(2) = "AutorizaWhatsApp" Then
                _Clase.AutorizaWhatsApp = Dato_Aux(1).ToString
                AutorizaWhatsApp = Dato_Aux(1).ToString
            End If
            ViewBag.AutorizaWhatsApp = AutorizaWhatsApp
            ViewBag.IdCliente = Dato_Aux(0)
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function ActualizarCampoSexo(ByVal Dato As String) As ActionResult
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_G_Cliente(Dato_Aux(0), My.User.Name)
            Dim Sexo = ""
            If Dato_Aux(2) = "Sexo" Then
                _Clase.Sexo = Dato_Aux(1).ToString
                Sexo = Dato_Aux(1).ToString
            End If
            ViewBag.Sexo = Sexo
            ViewBag.IdCliente = Dato_Aux(0)
            Return View()
        End Function


        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function WhatsApp(ByVal Dato As String) As ActionResult
            ViewBag.Dato = Dato
            Return View()
        End Function




        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR,RECEPCION")>
        Function VincularClienteConProfesional(IdCliente As String) As ActionResult
            If IsNothing(IdCliente) Then
                IdCliente = ""
            End If
            Dim ListaDeClases As New Clase_G_DevolverListaDeClases
            Return View(ListaDeClases.lista_Clase_G_PersonalConsultarListaOdontoloConClienteVinculado(IdCliente))
        End Function



        Function VincularClienteConProfesionalOdontologo(Dato As String) As ActionResult
            Try
                Dim Dato_Aux As String() = Dato.Split("|")
                Dim _Clase As New Clase_G_Personal(Dato_Aux(0), My.User.Name)
                _Clase.IdClienteVinculado = Dato_Aux(1)
                Dim IdCliente As String = _Clase.IdClienteVinculado
                _Clase.Vincular()
                Return RedirectToAction("VincularClienteConProfesional", New With {
                    IdCliente
                })

            Catch
                ViewBag.Mensaje = "Ingrese un correo electronico"
                Return View()
            End Try

        End Function


    End Class
End Namespace