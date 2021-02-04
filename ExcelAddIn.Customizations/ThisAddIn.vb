Imports System.Globalization
Imports System.Threading

Public Class ThisAddIn

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        Dim currentWithOverriddenNumber As CultureInfo = New CultureInfo("es-PE")
        currentWithOverriddenNumber.NumberFormat.CurrencyPositivePattern = 0 '; // make sure there is no space between symbol and number
        currentWithOverriddenNumber.NumberFormat.CurrencySymbol = "S/." '; // no currency symbol
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

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
