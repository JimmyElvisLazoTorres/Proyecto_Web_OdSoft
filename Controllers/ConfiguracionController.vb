Imports System.Web.Mvc

Namespace Controllers
    Public Class ConfiguracionController
        Inherits Controller

        ' GET: Configuracion
        <Authorize(Roles:="ADMINISTRADOR_GENERAL")>
        Function Index() As ActionResult
            Return View()
        End Function

        <Authorize(Roles:="ADMINISTRADOR_GENERAL")>
        Function Empresa() As ActionResult
            Return View()
        End Function



    End Class
End Namespace