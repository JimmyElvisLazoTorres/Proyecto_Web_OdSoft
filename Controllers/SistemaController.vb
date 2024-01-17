Imports System.Web.Mvc

Namespace Controllers
    Public Class SistemaController
        Inherits Controller

        ' GET: Sistema
        <Authorize(Roles:="SISTEMA")>
        Function Index() As ActionResult
            Return View()
        End Function

        <Authorize(Roles:="SISTEMA")>
        Function Entrada() As ActionResult
            Return View()
        End Function

        <Authorize(Roles:="SISTEMA")>
        Function PermisoUsoDeAplicacion() As ActionResult
            Return View()
        End Function
        <Authorize(Roles:="SISTEMA")>
        Function ListaUsuariosSinRoles(ByVal Buscar As String) As ActionResult

            If IsNothing(Buscar) Or Buscar = "" Then
                Buscar = "----"
            End If
            Dim ListaDeClases As New Clase_G_DevolverListaDeClases
            Return View(ListaDeClases.Lista_Clase_S_UsuariosSinRoles(Buscar, My.User.Name))
        End Function

        <Authorize(Roles:="SISTEMA")>
        Function UsuarioComoADMINISTRADORGENERAL(ByVal UserId As String) As ActionResult
            Dim _Clase_S_User As New Clase_S_User(UserId)
            _Clase_S_User.UsuarioComoADMINISTRADORGENERAL(My.User.Name)
            Return RedirectToAction("ListaUsuariosSinRoles")
        End Function

    End Class
End Namespace
