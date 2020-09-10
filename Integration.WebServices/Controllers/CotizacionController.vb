Imports System.Data.Entity.Core.Objects
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Threading
Imports System.Web.Http
Imports System.Web.Http.Results

Namespace Controllers
    <RoutePrefix("api/Cotizacion")>
    Public Class CotizacionController
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
        <HttpPost()>
        Public Function GuardarCotizacion(zoho_paInsertaCotizacion As Zoho_paInsertaCotizacion) As ObjectResult(Of paInsertaCotizacion_Result)
            Dim respuesta As ObjectResult(Of paInsertaCotizacion_Result)
            Try

                'Dim w As StreamWriter = File.AppendText("C:\Log\REST\log.txt")
                'w.Write("Entra")
                'w.Close()
                'w.Dispose()

                respuesta = db.paInsertaCotizacion(zoho_paInsertaCotizacion.IdCRM,
                    zoho_paInsertaCotizacion.Cliente,
                    zoho_paInsertaCotizacion.Transportista,
                    CDate(zoho_paInsertaCotizacion.FechaCierre),
                    zoho_paInsertaCotizacion.ServicioLogistico,
                    zoho_paInsertaCotizacion.Observaciones,
                    zoho_paInsertaCotizacion.Regimen,
                    zoho_paInsertaCotizacion.Via,
                    zoho_paInsertaCotizacion.PuertoDestino,
                    zoho_paInsertaCotizacion.PuertoOrigen,
                    zoho_paInsertaCotizacion.Moneda,
                    zoho_paInsertaCotizacion.Usuario)
                'Return respuesta
            Catch ex As Exception

                Dim ruta As String = "c:\Log\fichero.txt"
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
            Return respuesta
        End Function

    End Class
End Namespace