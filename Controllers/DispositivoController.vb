Imports System.Web.Mvc

Namespace Controllers
    Public Class DispositivoController
        Inherits Controller

        ' GET: Dispositivo
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Dispositivo/Details/5


        Function Lista(ByVal Buscar As String) As ActionResult
            If IsNothing(Buscar) Then
                Buscar = ""
            End If
            Dim ListaDeClases As New Clase_G_DevolverListaDeClases
            Return View(ListaDeClases.Lista_Clase_G_Dispositivo(Buscar))
        End Function
        ' GET: Dispositivo/Details/5

        Function Objeto(ByVal Id As Guid) As ActionResult
            MsgBox(Id.ToString)
            Return View(New Clase_G_Dispositivo(Id, User.Identity.Name))
        End Function

        ' GET: Dispositivo/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Dispositivo/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Dispositivo/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Dispositivo/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Dispositivo/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Dispositivo/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace