Imports System.Web.Mvc

Namespace Controllers
    Public Class AdministrarController
        Inherits Controller


        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function Entrada() As ActionResult
            'En esta vista se muestra el frame de PERSONAL por defecto
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function Personal() As ActionResult
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function Clientes() As ActionResult
            Return View()
        End Function
        <Authorize(Roles:="ADMINISTRADOR_GENERAL,ADMINISTRADOR")>
        Function HistoriaClinica() As ActionResult
            Return View()
        End Function
        ' GET: Administrar
        <Authorize(Roles:="ADMINISTRADOR_GENERAL")>
        Function Presentacion() As ActionResult
            Return View()
        End Function

        ' GET: Administrar
        <Authorize(Roles:="ADMINISTRADOR_GENERAL")>
        Function Dispositivos() As ActionResult
            Return View()
        End Function

    End Class
End Namespace