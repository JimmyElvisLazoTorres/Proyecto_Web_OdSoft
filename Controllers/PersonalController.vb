Imports System.Web.Mvc

Namespace Controllers
    Public Class PersonalController
        Inherits Controller


        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function Lista(ByVal Filtro As String) As ActionResult
            If IsNothing(Filtro) Then
                Filtro = ""
            End If
            Dim ListaDeClases As New Clase_G_DevolverListaDeClases
            Return View(ListaDeClases.Lista_Clase_G_Personal(Filtro))
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function Objeto(ByVal Id As String) As ActionResult
            If IsNothing(Id) Then
                Id = ""
            End If
            Dim _Objeto As New Clase_G_Personal(Id, My.User.Name)
            Return View(_Objeto)
        End Function

        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function EnBlanco() As ActionResult
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function ActualizarCampo(ByVal Dato As String) As ActionResult
            Dim DatoActualizado As Boolean = False
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_G_Personal(Dato_Aux(0), My.User.Name)
            Dim Mensaje = ""
            Select Case Dato_Aux(2)
                Case "Nombre"

                    _Clase.Nombre = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "ApellidoPaterno"
                    _Clase.ApellidoPaterno = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "ApellidoMaterno"
                    _Clase.ApellidoMaterno = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "FechaNacimiento"
                    _Clase.FechaNacimiento = DateAndTime.DateValue(Dato_Aux(1).ToString)
                    DatoActualizado = True

                Case "Region"
                    _Clase.Region = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "Provincia"
                    _Clase.Provincia = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "Distrito"
                    _Clase.Distrito = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Telefonos"
                    _Clase.Telefonos = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "Sexo"
                    _Clase.Sexo = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "DNI"
                    _Clase.DNI = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "CorreoElectronico"
                    _Clase.CorreoElectronico = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "Direccion"
                    _Clase.Direccion = Dato_Aux(1).ToString
                    DatoActualizado = True
                Case "Especialidad"
                    _Clase.Especialidad = Dato_Aux(1).ToString
                    DatoActualizado = True

                Case "Observaciones"
                    _Clase.Observaciones = Dato_Aux(1).ToString
                    DatoActualizado = True
            End Select

            ViewBag.Mensaje = Mensaje
            ViewBag.DatoActualizado = DatoActualizado

            Return View()
        End Function

        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function SinActualizacion() As ActionResult
            Return View()
        End Function

        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function ActualizarCampoSexo(ByVal Dato As String) As ActionResult
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_G_Personal(Dato_Aux(0), My.User.Name)
            Dim Sexo = ""
            If Dato_Aux(2) = "Sexo" Then
                _Clase.Sexo = Dato_Aux(1).ToString
                Sexo = Dato_Aux(1).ToString
            End If
            ViewBag.Sexo = Sexo
            ViewBag.IdPersonal = Dato_Aux(0)
            Return View()
        End Function

        <Authorize>
        Function ActualizarCampoROL(ByVal Dato As String) As ActionResult
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_G_Personal(Dato_Aux(0), My.User.Name)
            Dim ROL = ""
            If Dato_Aux(2) = "Rol" Then
                _Clase.ROL = Dato_Aux(1).ToString
                ROL = Dato_Aux(1).ToString
            End If
            ViewBag.ROL = ROL
            ViewBag.IdPersonal = Dato_Aux(0)
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function WhatsApp(ByVal Dato As String) As ActionResult
            ViewBag.Dato = Dato
            Return View()
        End Function

        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function VincularCuenta(Mensaje As String) As ActionResult
            ViewBag.Mensaje = Mensaje
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        <HttpPost()>
        Function VincularCuenta(ByVal collection As FormCollection, Mensaje As String) As ActionResult

            Try
                ' TODO: Add insert logic here
                Dim CorreoElectronico As String = collection("CorreoElectronico")
                Dim _Clase_S_User As New Clase_S_User()
                _Clase_S_User.Email = CorreoElectronico
                If _Clase_S_User.ExisteUsuario() Then

                    _Clase_S_User.UsuarioComoRECEPCIONISTA(My.User.Name)
                    Dim _Clase_G_Personal As New Clase_G_Personal
                    _Clase_G_Personal.CorreoElectronico = _Clase_S_User.Email
                    Return RedirectToAction("Objeto", New With {
                    _Clase_G_Personal.Id
                })
                Else
                    Mensaje = "Este correo no se encuentra registrado"
                    Return RedirectToAction("VincularCuenta", New With {
                    Mensaje
                })
                End If
                Return View()
            Catch
                ViewBag.Mensaje = "Ingrese un correo electronico"
                Return View()
            End Try
        End Function
    End Class
End Namespace