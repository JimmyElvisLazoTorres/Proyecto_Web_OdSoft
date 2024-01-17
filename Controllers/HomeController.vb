Public Class HomeController
    Inherits System.Web.Mvc.Controller
    <Authorize>
    Function Index() As ActionResult





        Return View()
    End Function
    <Authorize>
    Function SolicitarVinculacion() As ActionResult





        Return View()
    End Function


End Class
