Imports System.Web.Mvc

Namespace Controllers
    Public Class EmpresaController
        Inherits Controller


        ' GET: Empresa/Index
        <Authorize(Roles:="ADMINISTRADOR_GENERAL")>
        Function Index() As ActionResult
            Dim _Clase_S_Empresa As New Clase_S_Empresa(My.User.Name)
            Return View(_Clase_S_Empresa)
        End Function


        ' POST: Default/Edit/5
        <Authorize(Roles:="ADMINISTRADOR_GENERAL")>
        <HttpPost()>
        Function Index(ByVal _Clase_S_Empresa As Clase_S_Empresa) As ActionResult
            Try
                _Clase_S_Empresa.Usuario = My.User.Name.ToString
                _Clase_S_Empresa.Actualizar()
                Return View(_Clase_S_Empresa)
            Catch ex As Exception
                Return View()
            End Try

        End Function


        <Authorize(Roles:="ADMINISTRADOR_GENERAL")>
        Function ActualizarCampo(ByVal Dato As String) As ActionResult
            Dim Dato_Aux As String() = Dato.Split("|")
            Dim _Clase As New Clase_S_Empresa(My.User.Name)
            Select Case Dato_Aux(1)
                Case "NombreCompleto"
                    _Clase.NombreCompleto = Dato_Aux(0)
                Case "RUC"
                    _Clase.RUC = Dato_Aux(0)
            End Select

            Return View()
        End Function


    End Class
End Namespace