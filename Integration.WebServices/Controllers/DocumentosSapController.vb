Imports System.Data.Entity.Core.Objects
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Web.Http
Imports System.Web.Http.Results
Imports IntegrationServicesRest.IntegrationServicesRest

Namespace Controllers
    <RoutePrefix("api/sap")>
    Public Class DocumentosSapController
        Inherits ApiController

        Dim db As NextSoftEntities = New NextSoftEntities()

        Public Sub New()
            Dim currentWithOverriddenNumber As CultureInfo = New CultureInfo(CultureInfo.CurrentCulture.Name)
            currentWithOverriddenNumber.NumberFormat.CurrencyPositivePattern = 0 '; // make sure there is no space between symbol and number
            currentWithOverriddenNumber.NumberFormat.CurrencyDecimalSeparator = "." '; //decimal separator
            currentWithOverriddenNumber.NumberFormat.CurrencyGroupSizes = {3} '; //no digit groupings
            currentWithOverriddenNumber.NumberFormat.CurrencyGroupSeparator = ","
            currentWithOverriddenNumber.NumberFormat.NumberGroupSizes = {3} ';
            currentWithOverriddenNumber.NumberFormat.NumberGroupSeparator = ","
            currentWithOverriddenNumber.NumberFormat.NumberDecimalSeparator = "." '; //decimal separator
            currentWithOverriddenNumber.DateTimeFormat.FullDateTimePattern = "dd/MM/yyyy HH:mm:ss"
            currentWithOverriddenNumber.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
            Thread.CurrentThread.CurrentCulture = currentWithOverriddenNumber
        End Sub



        <Route("")>
        <HttpPut()>
        Public Function SincornizarNumeroDocumento(sap_upUpdateSynchronizedDocumentNumber As Sap_upUpdateSynchronizedDocumentNumber) As Integer
            Dim respuesta As Integer
            Try

                'Dim w As StreamWriter = File.AppendText("C:\Log\REST\log.txt")
                'w.Write("Entra")
                'w.Close()
                'w.Dispose()

                respuesta = db.upUpdateSynchronizedDocumentNumber(sap_upUpdateSynchronizedDocumentNumber.CCCT_Codigo,
                    sap_upUpdateSynchronizedDocumentNumber.DocEntry,
                    sap_upUpdateSynchronizedDocumentNumber.DocNum, sap_upUpdateSynchronizedDocumentNumber.EventLog)

                Return respuesta
            Catch ex As Exception

                Dim ruta As String = "c:\Log\sap.txt"
                Dim escritor As StreamWriter
                escritor = File.AppendText(ruta)
                escritor.Write(ex.Message)
                escritor.Write(vbCrLf)
                escritor.Write(ex.InnerException)
                escritor.Write(vbCrLf)
                escritor.Write(ex.Source)
                escritor.Write(vbCrLf)
                escritor.Flush()
                escritor.Close()

                Throw ex

            End Try

        End Function

    End Class
End Namespace