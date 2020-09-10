Imports System.IO
Imports Microsoft.Office.Interop
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraVerticalGrid

Module SharedModule
    Dim oAppService As New AppService.DelfinServiceClient

    <System.Runtime.CompilerServices.Extension>
    Public Function Contains(ByVal str As String, ByVal ParamArray values As String()) As Boolean
        For Each value In values
            If str.Contains(value) Then
                Return True
            End If
        Next
        Return False
    End Function

    Friend Function GetShipline(ShiplineCode As String) As DataTable
        Dim dtQuery As New DataTable
        Dim sShiplineCode As String = IIf(ShiplineCode Is Nothing, "NULL", ShiplineCode)
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaTransportista " & sShiplineCode).Tables(0)
        Return dtQuery
    End Function

    Friend Function GetCustomer(CustomerCode As String) As DataTable
        Dim dtQuery As New DataTable
        Dim sCustomerCode As String = IIf(CustomerCode Is Nothing, "NULL", CustomerCode)
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaCliente " & sCustomerCode).Tables(0)
        Return dtQuery
    End Function

    Friend Function GetVoyage(VoyageCode As String, ShiplineCode As String) As DataTable
        Dim dtQuery As New DataTable
        Dim sVoyageCode As String = IIf(VoyageCode Is Nothing, "NULL", VoyageCode)
        Dim sShiplineCode As String = IIf(ShiplineCode Is Nothing, "NULL", ShiplineCode)
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaNaveViaje " & sVoyageCode & "," & sShiplineCode).Tables(0)
        Return dtQuery
    End Function

    Friend Function GetDepot(DepotCode As String) As DataTable
        Dim dtQuery As New DataTable
        Dim sDepotCode As String = IIf(DepotCode Is Nothing, "NULL", DepotCode)
        dtQuery = oAppService.ExecuteSQL("EXEC NextSoft.dgp.paListaDeposito " & sDepotCode).Tables(0)
        Return dtQuery
    End Function

    Friend Sub ExportToExcel(sender As System.Object)
        Dim sFileName As String = GetTmpFileName("xlsx")
        If sender.ProductName = "DevExpress.XtraVerticalGrid" Then
            Dim oVGridControl As New VGridControl
            oVGridControl = sender
            oVGridControl.ExportToXlsx(sFileName)
        Else
            Dim oGridView As New GridView
            oGridView = sender.FocusedView
            oGridView.OptionsPrint.AutoWidth = False
            oGridView.BestFitColumns()
            oGridView.BestFitMaxRowCount = oGridView.RowCount
            oGridView.ExportToXlsx(sFileName)
        End If
        If IO.File.Exists(sFileName) Then
            Dim oXls As New Excel.Application 'Crea el objeto excel 
            oXls.Workbooks.Open(sFileName, , False) 'El true es para abrir el archivo en modo Solo lectura (False si lo quieres de otro modo)
            oXls.Visible = True
            oXls.WindowState = Excel.XlWindowState.xlMaximized 'Para que la ventana aparezca maximizada.
        End If
    End Sub

    Friend Function GetTmpFileName(sExtFile As String) As String
        Dim sResult As String = ""
        Dim sPath As String = Path.GetTempPath
        sResult = (FileIO.FileSystem.GetTempFileName).Replace(".tmp", ".xlsx")
        Return sResult
    End Function

    Friend Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function

    Friend Function UnicodeBytesToString(ByVal bytes() As Byte) As String
        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

    Friend Function LoadExcel(ByVal FileName As String, ByRef Hoja As String) As DataSet
        Dim dsResult As New DataSet
        Dim ExcelConnectionString As String = "provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & FileName & "'; Extended Properties='Excel 12.0 Xml; IMEX=1'"
        Using connection As New System.Data.OleDb.OleDbConnection(ExcelConnectionString)
            Try
                connection.Open()
                If Hoja = "{0}" Then
                    For r = 0 To connection.GetSchema("Tables").Rows.Count - 1
                        If Not connection.GetSchema("Tables").Rows(r)("TABLE_NAME").ToString.ToUpper.Contains({"FILTER", "PRINT"}) Then
                            Hoja = connection.GetSchema("Tables").Rows(r)("TABLE_NAME")
                            Exit For
                        End If
                    Next
                End If
                Dim Command As New System.Data.OleDb.OleDbDataAdapter("select * from [" & Hoja & "]", connection)
                Command.Fill(dsResult)
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
            Return dsResult
        End Using
    End Function

End Module
