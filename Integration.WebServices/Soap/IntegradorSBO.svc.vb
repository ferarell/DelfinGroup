' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "IntegradorSBO" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione IntegradorSBO.svc o IntegradorSBO.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports System.Net
Imports System.Net.Http
Imports System.Net.Security
Imports System.Text
Imports System
Imports System.IO
Imports System.Collections
Imports System.Xml
Imports Newtonsoft.Json
Imports IntegrationServicesRest.DelfinService
Imports IntegrationServicesRest

Public Class IntegradorSBO
    Implements IIntegradorSBO

    Dim client As HttpClient = New HttpClient
    Dim oDelfinService As DelfinServiceClient = New DelfinServiceClient()

    Public Function InsertarActualizarServicio(dsServicio As DataSet) As List(Of Respuesta) Implements IIntegradorSBO.InsertarActualizarServicio
        'Dim dsRespuestaDelfin As DataSet = New DataSet()
        'Dim dsServicio As DataSet = New DataSet()
        Dim listRespuestas As List(Of Respuesta) = New List(Of Respuesta)()
        Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlSAPPOSTServicio")
        'dsServicio.Tables.Add("Servicio")

        '' Add columns
        'dsServicio.Tables("Servicio").Columns.Add("ItemCode", GetType(String))
        'dsServicio.Tables("Servicio").Columns.Add("ItemName", GetType(String))
        'dsServicio.Tables("Servicio").Columns.Add("ItemsGroupCode", GetType(Integer))
        'dsServicio.Tables("Servicio").Columns.Add("SWW", GetType(Integer))


        'dsServicio.Tables("Servicio").Rows.Add("ITN00000895", "MARCO COMUN  895", 113, 2245)

        Dim client As HttpClient = New HttpClient
        Dim dtServicios As DataTable = New DataTable()
        Dim jsonSerialice As String = ""
        If dsServicio IsNot Nothing Then
            If dsServicio.Tables.Count > 0 Then
                dtServicios = dsServicio.Tables(0)
            End If
        End If

        For Each item As DataRow In dtServicios.Rows
            Try
                Dim dictionary = item.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) item(col.ColumnName))
                jsonSerialice = JsonConvert.SerializeObject(dictionary, Xml.Formatting.Indented)
                Dim content As StringContent = New StringContent(jsonSerialice, Encoding.UTF8, "application/json")
                Dim response2 As HttpResponseMessage = client.PostAsync(UrlTarifasRest, content).Result
                Dim receiveStream As String = response2.Content.ReadAsStringAsync().Result
                Dim oRespuesta As Respuesta = New Respuesta()
                oRespuesta = JsonConvert.DeserializeObject(Of Respuesta)(receiveStream)
                If oRespuesta.ResponseStatus = "MessageSuccess" Then
                    oRespuesta.RespuestaSAP = 1
                Else
                    oRespuesta.RespuestaSAP = 0
                End If
                oRespuesta.ItemCode = item("ItemCode").ToString()
                oRespuesta.SWW = item("SWW").ToString()

                If oRespuesta.RespuestaSAP = 1 Then
                    Dim Query As String = "EXEC NextSoft.sap.upUpdateSynchronizedService " & item("SWW").ToString() & " , '" & item("ItemsGroupCode").ToString() & "' , '" & item("ItemCode").ToString() & "' , '" & Format(DateTime.Now, "yyyyMMdd HH:mm") & "' , " & oRespuesta.RespuestaSAP
                    Dim bResult As Boolean = Nothing
                    bResult = oDelfinService.ExecuteSQLNonQuery(Query)
                    If bResult Then
                        oRespuesta.RespuestaNexsoft = 1
                    Else
                        oRespuesta.RespuestaNexsoft = 0
                    End If
                Else
                    oRespuesta.RespuestaNexsoft = 0
                End If

                listRespuestas.Add(oRespuesta)
            Catch ex As Exception

            End Try

        Next

        Return listRespuestas

    End Function


Public Function InsertarActualizarSocioNegocio(dsCliente As DataSet) As List(Of Respuesta) Implements IIntegradorSBO.InsertarActualizarSocioNegocio
        'Dim dsRespuestaDelfin As DataSet = New DataSet()
        'Dim dsServicio As DataSet = New DataSet()
        Dim listRespuestas As List(Of Respuesta) = New List(Of Respuesta)()
        Dim UrlClientesRest As String = ConfigurationManager.AppSettings("urlSAPPOSTCliente")
        'dsServicio.Tables.Add("Servicio")

        '' Add columns
        'dsServicio.Tables("Servicio").Columns.Add("ItemCode", GetType(String))
        'dsServicio.Tables("Servicio").Columns.Add("ItemName", GetType(String))
        'dsServicio.Tables("Servicio").Columns.Add("ItemsGroupCode", GetType(Integer))
        'dsServicio.Tables("Servicio").Columns.Add("SWW", GetType(Integer))


        'dsServicio.Tables("Servicio").Rows.Add("ITN00000895", "MARCO COMUN  895", 113, 2245)

        Dim client As HttpClient = New HttpClient
        Dim dtCliente As DataTable = New DataTable()
        Dim dtDirecciones As DataTable = New DataTable()
        Dim dtContactos As DataTable = New DataTable()
        Dim dtAdicionales As DataTable = New DataTable()
        Dim jsonSerialiceCliente As String = ""
        Dim jsonSerialiceDireccion As String = ""
        If dsCliente IsNot Nothing Then
            If dsCliente.Tables.Count > 0 Then
                dtCliente = dsCliente.Tables(0)
                dtDirecciones = dsCliente.Tables(1)
                dtAdicionales = dsCliente.Tables(2)
            End If
        End If

        For Each item As DataRow In dtCliente.Rows
            Dim dictionaryCliente = item.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) item(col.ColumnName))
            jsonSerialiceCliente = JsonConvert.SerializeObject(dictionaryCliente, Xml.Formatting.Indented)

            'Dim itemDireccion As DataRow = dtDirecciones.Rows.Item(0)
            'Dim dictionaryDirecciones = itemDireccion.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemDireccion(col.ColumnName))
            'jsonSerialiceDireccion = JsonConvert.SerializeObject(dictionaryDirecciones, Xml.Formatting.Indented)

            If dtDirecciones.Rows.Count > 0 Then
                Dim itemDireccion As DataRow = dtDirecciones.Rows.Item(0)
                Dim dictionaryDirecciones = itemDireccion.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemDireccion(col.ColumnName))
                jsonSerialiceDireccion = JsonConvert.SerializeObject(dictionaryDirecciones, Xml.Formatting.Indented)
            End If

            jsonSerialiceCliente = jsonSerialiceCliente.Replace("-1", "[" & jsonSerialiceDireccion & "]")


            Dim content As StringContent = New StringContent(jsonSerialiceCliente, Encoding.UTF8, "application/json")
            Dim URL As String = UrlClientesRest
            Dim response2 As HttpResponseMessage = client.PostAsync(URL, content).Result
            Dim receiveStream As String = response2.Content.ReadAsStringAsync().Result
            Dim oRespuesta As Respuesta = New Respuesta()
            oRespuesta = JsonConvert.DeserializeObject(Of Respuesta)(receiveStream)




            If oRespuesta.ResponseStatus = "MessageSuccess" Then
                oRespuesta.RespuestaSAP = 1
            Else
                oRespuesta.RespuestaSAP = 0
            End If

            Dim ENTC_Codigo As String = dtAdicionales.Rows(0).Item("ENTC_Codigo").ToString()
            Dim TIPE_Codigo As String = dtAdicionales.Rows(0).Item("TIPE_Codigo").ToString()
            Dim ENTC_CodSAP As String = dtCliente.Rows(0).Item("CardCode").ToString()
            Dim TipoSocio As String = dtAdicionales.Rows(0).Item("TipoSocio").ToString()

            If oRespuesta.RespuestaSAP = 1 Then
                Dim Query As String = "EXEC NextSoft.sap.upUpdateSynchronizedPartner " & ENTC_Codigo & " ," & TIPE_Codigo & " , '" & ENTC_CodSAP & "' , '" & Format(DateTime.Now, "yyyyMMdd HH:mm") & "' , " & oRespuesta.RespuestaSAP & ",'" & TipoSocio & "'"
                Dim bResult As Boolean = Nothing
                bResult = oDelfinService.ExecuteSQLNonQuery(Query)
                If bResult Then
                    oRespuesta.RespuestaNexsoft = 1
                Else
                    oRespuesta.RespuestaNexsoft = 0
                End If
            Else
                oRespuesta.RespuestaNexsoft = 0
            End If

            listRespuestas.Add(oRespuesta)
        Next

        Return listRespuestas

    End Function

    Public Function InsertarActualizarReferencias(dsReferencias As DataSet) As List(Of Respuesta) Implements IIntegradorSBO.InsertarActualizarReferencias
        Dim dsRespuestaDelfin As DataSet = New DataSet()
        'Dim dsServicio As DataSet = New DataSet()
        Dim listRespuestas As List(Of Respuesta) = New List(Of Respuesta)()
        Dim UrlTarifasRest As String = ConfigurationManager.AppSettings("urlSAPPOSTReferencias")
        'dsServicio.Tables.Add("Servicio")

        '' Add columns
        'dsServicio.Tables("Servicio").Columns.Add("ItemCode", GetType(String))
        'dsServicio.Tables("Servicio").Columns.Add("ItemName", GetType(String))
        'dsServicio.Tables("Servicio").Columns.Add("ItemsGroupCode", GetType(Integer))
        'dsServicio.Tables("Servicio").Columns.Add("SWW", GetType(Integer))


        'dsServicio.Tables("Servicio").Rows.Add("ITN00000895", "MARCO COMUN  895", 113, 2245)

        Dim client As HttpClient = New HttpClient
        Dim dtNave As DataTable = New DataTable()
        Dim dtReferencias As DataTable = New DataTable()
        Dim dtContenedores As DataTable = New DataTable()
        Dim jsonSerialiceNave As String = ""
        Dim jsonSerialiceReferencia As String = ""
        Dim jsonSerialiceContenedores As String = ""
        If dsReferencias IsNot Nothing Then
            If dsReferencias.Tables.Count > 0 Then
                dtNave = dsReferencias.Tables(0)
                dtReferencias = dsReferencias.Tables(1)
                dtContenedores = dsReferencias.Tables(2)
            End If
        End If

        For Each item As DataRow In dtNave.Rows
            Dim dictionaryNave = item.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) item(col.ColumnName))
            jsonSerialiceNave = JsonConvert.SerializeObject(dictionaryNave, Xml.Formatting.Indented)


            Dim itemReferencias As DataRow = dtReferencias.Rows.Item(0)
            Dim dictionaryReferencias = itemReferencias.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemReferencias(col.ColumnName))
            jsonSerialiceReferencia = JsonConvert.SerializeObject(dictionaryReferencias, Xml.Formatting.Indented)

            'Dim itemContenedores As DataRow = dtContenedores.Rows.Item(0)
            'Dim dictionaryContenedores = itemContenedores.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemContenedores(col.ColumnName))
            'jsonSerialiceContenedores = JsonConvert.SerializeObject(dictionaryContenedores, Xml.Formatting.Indented)
            Dim contadorContenedores As Integer = 1
            For Each itemDetalleContenedores As DataRow In dtContenedores.Rows

                Dim dictionaryContenedores = itemDetalleContenedores.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemDetalleContenedores(col.ColumnName))


                If contadorContenedores < dtContenedores.Rows.Count Then
                    jsonSerialiceContenedores = jsonSerialiceContenedores + JsonConvert.SerializeObject(dictionaryContenedores, Xml.Formatting.Indented) + " , "

                Else
                    jsonSerialiceContenedores = jsonSerialiceContenedores + JsonConvert.SerializeObject(dictionaryContenedores, Xml.Formatting.Indented)
                End If

                contadorContenedores = contadorContenedores + 1

            Next

            jsonSerialiceNave = jsonSerialiceNave.Replace("-999999", "[" & jsonSerialiceReferencia & "]")
            jsonSerialiceNave = jsonSerialiceNave.Replace("-999998", "[" & jsonSerialiceContenedores & "]")

            Dim content As StringContent = New StringContent(jsonSerialiceNave, Encoding.UTF8, "application/json")
            Dim URL As String = UrlTarifasRest
            Dim response2 As HttpResponseMessage = client.PostAsync(URL, content).Result
            Dim receiveStream As String = response2.Content.ReadAsStringAsync().Result
            Dim oRespuesta As Respuesta = New Respuesta()
            oRespuesta = JsonConvert.DeserializeObject(Of Respuesta)(receiveStream)

            If oRespuesta.ResponseStatus = "MessageSuccess" Then
                oRespuesta.RespuestaSAP = 1
            Else
                oRespuesta.RespuestaSAP = 0
            End If

            oRespuesta.RespuestaNexsoft = 1



            listRespuestas.Add(oRespuesta)
        Next

        Return listRespuestas
    End Function




    Public Function InsertarActualizarJournalEntry(dsJournalEntry As DataSet) As List(Of Respuesta) Implements IIntegradorSBO.InsertarActualizarJournalEntry
        Dim dsRespuestaDelfin As DataSet = New DataSet()
        'Dim dsServicio As DataSet = New DataSet()
        Dim listRespuestas As List(Of Respuesta) = New List(Of Respuesta)()
        Dim dtAdicionales As DataTable = New DataTable()
        Dim UrlJournalEntryRest As String = ConfigurationManager.AppSettings("urlSAPPOSTJournalEntry")

        Dim client As HttpClient = New HttpClient
        Dim dtCabecera As DataTable = New DataTable()
        Dim dtDetalle As DataTable = New DataTable()

        Dim jsonSerialiceCabecera As String = ""
        Dim jsonSerialiceDetalle As String = ""

        If dsJournalEntry IsNot Nothing Then
            If dsJournalEntry.Tables.Count > 0 Then
                dtCabecera = dsJournalEntry.Tables(0)
                dtDetalle = dsJournalEntry.Tables(1)
                dtAdicionales = dsJournalEntry.Tables(2)
            End If
        End If

        For Each item As DataRow In dtCabecera.Rows
            Dim dictionaryCabecera = item.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) item(col.ColumnName))
            jsonSerialiceCabecera = JsonConvert.SerializeObject(dictionaryCabecera, Xml.Formatting.Indented)

            Dim contador As Integer = 1
            For Each itemDetalle As DataRow In dtDetalle.Rows

                Dim dictionaryDetalle = itemDetalle.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemDetalle(col.ColumnName))


                If contador < dtDetalle.Rows.Count Then
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented) + " , "

                Else
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented)
                End If

                contador = contador + 1

            Next

            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999999", "[" & jsonSerialiceDetalle & "]")
            'jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999998", "[" & "]")
            'jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999997", "[" & "]")



            Dim content As StringContent = New StringContent(jsonSerialiceCabecera, Encoding.UTF8, "application/json")
            Dim URL As String = UrlJournalEntryRest
            Dim response2 As HttpResponseMessage = client.PostAsync(URL, content).Result
            Dim receiveStream As String = response2.Content.ReadAsStringAsync().Result
            Dim oRespuesta As Respuesta = New Respuesta()
            oRespuesta = JsonConvert.DeserializeObject(Of Respuesta)(receiveStream)




            If oRespuesta.ResponseStatus = "MessageSuccess" Then
                oRespuesta.RespuestaSAP = 1
            Else
                oRespuesta.RespuestaSAP = 0
            End If
            oRespuesta.RespuestaNexsoft = 1
            Dim InterfaceName As String = dtAdicionales.Rows(0).Item("InterfaceName").ToString()
            Dim TableName As String = dtAdicionales.Rows(0).Item("TableName").ToString()
            Dim NVIA_Codigo As String = ""
            If IsDBNull(dtAdicionales.Rows(0).Item("NVIA_Codigo")) Then
                NVIA_Codigo = "NULL"
            Else
                NVIA_Codigo = "'" & dtAdicionales.Rows(0).Item("NVIA_Codigo").ToString() & "'"
            End If

            Dim CONS_CodLNG As String = ""
            If IsDBNull(dtAdicionales.Rows(0).Item("CONS_CodLNG")) Then
                CONS_CodLNG = "NULL"
            Else
                CONS_CodLNG = "'" & dtAdicionales.Rows(0).Item("CONS_CodLNG").ToString() & "'"
            End If


            Dim CCCT_Codigo As String = ""
            If IsDBNull(dtAdicionales.Rows(0).Item("CCCT_Codigo")) Then
                CCCT_Codigo = "NULL"
            Else
                CCCT_Codigo = dtAdicionales.Rows(0).Item("CCCT_Codigo").ToString()
            End If
            Dim AUDI_Usuario As String = dtAdicionales.Rows(0).Item("AUDI_Usuario").ToString()
            If oRespuesta.RespuestaSAP = 1 Then
                Dim Query As String = "EXEC NextSoft.sap.upUpdateSynchronizedJournalEntry  '" & oRespuesta.Response.Item(0).JdtNum.ToString() & "' ," & "'" & InterfaceName & "'" & " , '" & TableName & "' , " & NVIA_Codigo & " , " & CONS_CodLNG & " , " & CCCT_Codigo & ", '" & AUDI_Usuario & "'"
                Dim bResult As Boolean = Nothing
                bResult = oDelfinService.ExecuteSQLNonQuery(Query)
                If bResult Then
                    oRespuesta.RespuestaNexsoft = 1
                Else
                    oRespuesta.RespuestaNexsoft = 0
                End If
            Else
                oRespuesta.RespuestaNexsoft = 0
            End If
            listRespuestas.Add(oRespuesta)
        Next
        Return listRespuestas
    End Function



    Public Function InsertarActualizarInvoiceBills(dsInvoiceBills As DataSet) As List(Of Respuesta) Implements IIntegradorSBO.InsertarActualizarInvoiceBills
        Dim dsRespuestaDelfin As DataSet = New DataSet()
        'Dim dsServicio As DataSet = New DataSet()
        Dim listRespuestas As List(Of Respuesta) = New List(Of Respuesta)()
        Dim dtAdicionales As DataTable = New DataTable()
        Dim UrlInvoiceBillsRest As String = ConfigurationManager.AppSettings("urlSAPPOSTInvoiceBills")

        Dim client As HttpClient = New HttpClient
        Dim dtCabecera As DataTable = New DataTable()
        Dim dtDetalle As DataTable = New DataTable()

        Dim jsonSerialiceCabecera As String = ""
        Dim jsonSerialiceDetalle As String = ""

        If dsInvoiceBills IsNot Nothing Then
            If dsInvoiceBills.Tables.Count > 0 Then
                dtCabecera = dsInvoiceBills.Tables(0)
                dtDetalle = dsInvoiceBills.Tables(1)
                dtAdicionales = dsInvoiceBills.Tables(2)
            End If
        End If

        For Each item As DataRow In dtCabecera.Rows
            Dim dictionaryCabecera = item.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) item(col.ColumnName))
            jsonSerialiceCabecera = JsonConvert.SerializeObject(dictionaryCabecera, Xml.Formatting.Indented)

            Dim contador As Integer = 1
            For Each itemDetalle As DataRow In dtDetalle.Rows

                Dim dictionaryDetalle = itemDetalle.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemDetalle(col.ColumnName))


                If contador < dtDetalle.Rows.Count Then
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented) + " , "

                Else
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented)
                End If

                contador = contador + 1

            Next

            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999999", "[" & jsonSerialiceDetalle & "]")
            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999998", "[" & "]")
            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999997", "[" & "]")



            Dim content As StringContent = New StringContent(jsonSerialiceCabecera, Encoding.UTF8, "application/json")
            Dim URL As String = UrlInvoiceBillsRest
            Dim response2 As HttpResponseMessage = client.PostAsync(URL, content).Result
            Dim receiveStream As String = response2.Content.ReadAsStringAsync().Result
            Dim oRespuesta As Respuesta = New Respuesta()
            oRespuesta = JsonConvert.DeserializeObject(Of Respuesta)(receiveStream)




            If oRespuesta.ResponseStatus = "MessageSuccess" Then
                oRespuesta.RespuestaSAP = 1
            Else
                oRespuesta.RespuestaSAP = 0
            End If
            oRespuesta.RespuestaNexsoft = 1
            Dim InterfaceName As String = dtAdicionales.Rows(0).Item("InterfaceName").ToString()
            Dim TableName As String = dtAdicionales.Rows(0).Item("TableName").ToString()


            Dim CCCT_Codigo As String = ""
            If IsDBNull(dtAdicionales.Rows(0).Item("CCCT_Codigo")) Then
                CCCT_Codigo = "NULL"
            Else
                CCCT_Codigo = dtAdicionales.Rows(0).Item("CCCT_Codigo").ToString()
            End If
            Dim AUDI_Usuario As String = dtAdicionales.Rows(0).Item("AUDI_Usuario").ToString()
            If oRespuesta.RespuestaSAP = 1 Then
                Dim Query As String = "EXEC NextSoft.sap.upUpdateSynchronizedInvoiceBills '" & oRespuesta.Response.Item(0).DocEntry.ToString() & "' ," & "'" & InterfaceName & "'" & " , '" & TableName & "' , " & CCCT_Codigo & ", '" & AUDI_Usuario & "'"
                Dim bResult As Boolean = Nothing
                bResult = oDelfinService.ExecuteSQLNonQuery(Query)
                If bResult Then
                    oRespuesta.RespuestaNexsoft = 1
                Else
                    oRespuesta.RespuestaNexsoft = 0
                End If
            Else
                oRespuesta.RespuestaNexsoft = 0
            End If
            listRespuestas.Add(oRespuesta)
        Next
        Return listRespuestas
    End Function



    Public Function InsertarActualizarCreditMemo(dsCreditMemo As DataSet) As List(Of Respuesta) Implements IIntegradorSBO.InsertarActualizarCreditMemo
        Dim dsRespuestaDelfin As DataSet = New DataSet()
        'Dim dsServicio As DataSet = New DataSet()
        Dim listRespuestas As List(Of Respuesta) = New List(Of Respuesta)()
        Dim dtAdicionales As DataTable = New DataTable()
        Dim UrlCreditMemoRest As String = ConfigurationManager.AppSettings("urlSAPPOSTCreditMemo")

        Dim client As HttpClient = New HttpClient
        Dim dtCabecera As DataTable = New DataTable()
        Dim dtDetalle As DataTable = New DataTable()

        Dim jsonSerialiceCabecera As String = ""
        Dim jsonSerialiceDetalle As String = ""

        If dsCreditMemo IsNot Nothing Then
            If dsCreditMemo.Tables.Count > 0 Then
                dtCabecera = dsCreditMemo.Tables(0)
                dtDetalle = dsCreditMemo.Tables(1)
                dtAdicionales = dsCreditMemo.Tables(2)
            End If
        End If

        For Each item As DataRow In dtCabecera.Rows
            Dim dictionaryCabecera = item.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) item(col.ColumnName))
            jsonSerialiceCabecera = JsonConvert.SerializeObject(dictionaryCabecera, Xml.Formatting.Indented)

            Dim contador As Integer = 1
            For Each itemDetalle As DataRow In dtDetalle.Rows

                Dim dictionaryDetalle = itemDetalle.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemDetalle(col.ColumnName))


                If contador < dtDetalle.Rows.Count Then
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented) + " , "

                Else
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented)
                End If

                contador = contador + 1

            Next

            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999999", "[" & jsonSerialiceDetalle & "]")
            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999998", "[" & "]")
            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999997", "[" & "]")



            Dim content As StringContent = New StringContent(jsonSerialiceCabecera, Encoding.UTF8, "application/json")
            Dim URL As String = UrlCreditMemoRest
            Dim response2 As HttpResponseMessage = client.PostAsync(URL, content).Result
            Dim receiveStream As String = response2.Content.ReadAsStringAsync().Result
            Dim oRespuesta As Respuesta = New Respuesta()
            oRespuesta = JsonConvert.DeserializeObject(Of Respuesta)(receiveStream)




            If oRespuesta.ResponseStatus = "MessageSuccess" Then
                oRespuesta.RespuestaSAP = 1
            Else
                oRespuesta.RespuestaSAP = 0
            End If
            oRespuesta.RespuestaNexsoft = 1
            Dim InterfaceName As String = dtAdicionales.Rows(0).Item("InterfaceName").ToString()
            Dim TableName As String = dtAdicionales.Rows(0).Item("TableName").ToString()


            Dim CCCT_Codigo As String = ""
            If IsDBNull(dtAdicionales.Rows(0).Item("CCCT_Codigo")) Then
                CCCT_Codigo = "NULL"
            Else
                CCCT_Codigo = dtAdicionales.Rows(0).Item("CCCT_Codigo").ToString()
            End If
            Dim AUDI_Usuario As String = dtAdicionales.Rows(0).Item("AUDI_Usuario").ToString()
            If oRespuesta.RespuestaSAP = 1 Then
                Dim Query As String = "EXEC NextSoft.sap.upUpdateSynchronizedCreditMemo '" & oRespuesta.Response.Item(0).DocEntry.ToString() & "' ," & "'" & InterfaceName & "'" & " , '" & TableName & "' , " & CCCT_Codigo & ", '" & AUDI_Usuario & "'"
                Dim bResult As Boolean = Nothing
                bResult = oDelfinService.ExecuteSQLNonQuery(Query)
                If bResult Then
                    oRespuesta.RespuestaNexsoft = 1
                Else
                    oRespuesta.RespuestaNexsoft = 0
                End If
            Else
                oRespuesta.RespuestaNexsoft = 0
            End If
            listRespuestas.Add(oRespuesta)
        Next
        Return listRespuestas
    End Function





    Public Function InsertarActualizarPurchaseInvoice(dsPurchaseInvoice As DataSet) As List(Of Respuesta) Implements IIntegradorSBO.InsertarActualizarPurchaseInvoice
        Dim dsRespuestaDelfin As DataSet = New DataSet()
        'Dim dsServicio As DataSet = New DataSet()
        Dim listRespuestas As List(Of Respuesta) = New List(Of Respuesta)()
        Dim dtAdicionales As DataTable = New DataTable()
        Dim UrlPurchaseInvoice As String = ConfigurationManager.AppSettings("urlSAPPOSTPurchaseInvoice")

        Dim client As HttpClient = New HttpClient
        Dim dtCabecera As DataTable = New DataTable()
        Dim dtDetalle As DataTable = New DataTable()

        Dim jsonSerialiceCabecera As String = ""
        Dim jsonSerialiceDetalle As String = ""

        If dsPurchaseInvoice IsNot Nothing Then
            If dsPurchaseInvoice.Tables.Count > 0 Then
                dtCabecera = dsPurchaseInvoice.Tables(0)
                dtDetalle = dsPurchaseInvoice.Tables(1)
                dtAdicionales = dsPurchaseInvoice.Tables(2)
            End If
        End If

        For Each item As DataRow In dtCabecera.Rows
            Dim dictionaryCabecera = item.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) item(col.ColumnName))
            jsonSerialiceCabecera = JsonConvert.SerializeObject(dictionaryCabecera, Xml.Formatting.Indented)

            Dim contador As Integer = 1
            For Each itemDetalle As DataRow In dtDetalle.Rows

                Dim dictionaryDetalle = itemDetalle.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemDetalle(col.ColumnName))


                If contador < dtDetalle.Rows.Count Then
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented) + " , "

                Else
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented)
                End If

                contador = contador + 1

            Next

            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999999", "[" & jsonSerialiceDetalle & "]")
            'jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999998", "[" & "]")
            'jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999997", "[" & "]")



            Dim content As StringContent = New StringContent(jsonSerialiceCabecera, Encoding.UTF8, "application/json")
            Dim URL As String = UrlPurchaseInvoice
            Dim response2 As HttpResponseMessage = client.PostAsync(URL, content).Result
            Dim receiveStream As String = response2.Content.ReadAsStringAsync().Result
            Dim oRespuesta As Respuesta = New Respuesta()
            oRespuesta = JsonConvert.DeserializeObject(Of Respuesta)(receiveStream)




            If oRespuesta.ResponseStatus = "MessageSuccess" Then
                oRespuesta.RespuestaSAP = 1
            Else
                oRespuesta.RespuestaSAP = 0
            End If
            oRespuesta.RespuestaNexsoft = 1
            Dim InterfaceName As String = dtAdicionales.Rows(0).Item("InterfaceName").ToString()
            Dim TableName As String = dtAdicionales.Rows(0).Item("TableName").ToString()


            Dim CCCT_Codigo As String = ""
            If IsDBNull(dtAdicionales.Rows(0).Item("CCCT_Codigo")) Then
                CCCT_Codigo = "NULL"
            Else
                CCCT_Codigo = dtAdicionales.Rows(0).Item("CCCT_Codigo").ToString()
            End If
            Dim AUDI_Usuario As String = dtAdicionales.Rows(0).Item("AUDI_Usuario").ToString()
            If oRespuesta.RespuestaSAP = 1 Then
                Dim Query As String = "EXEC NextSoft.sap.upUpdateSynchronizedPurchaseInvoice '" & oRespuesta.Response.Item(0).Number.ToString() & "' ," & "'" & InterfaceName & "'" & " , '" & TableName & "' , " & CCCT_Codigo & ", " & AUDI_Usuario & "'"
                Dim bResult As Boolean = Nothing
                bResult = oDelfinService.ExecuteSQLNonQuery(Query)
                If bResult Then
                    oRespuesta.RespuestaNexsoft = 1
                Else
                    oRespuesta.RespuestaNexsoft = 0
                End If
            Else
                oRespuesta.RespuestaNexsoft = 0
            End If
            listRespuestas.Add(oRespuesta)
        Next
        Return listRespuestas
    End Function



    Public Function InsertarActualizarPurchaseCreditMemo(dsPurchaseCreditMemo As DataSet) As List(Of Respuesta) Implements IIntegradorSBO.InsertarActualizarPurchaseCreditMemo
        Dim dsRespuestaDelfin As DataSet = New DataSet()
        'Dim dsServicio As DataSet = New DataSet()
        Dim listRespuestas As List(Of Respuesta) = New List(Of Respuesta)()
        Dim dtAdicionales As DataTable = New DataTable()
        Dim UrlPurchaseInvoice As String = ConfigurationManager.AppSettings("urlSAPPOSTPurchaseCreditMemo")

        Dim client As HttpClient = New HttpClient
        Dim dtCabecera As DataTable = New DataTable()
        Dim dtDetalle As DataTable = New DataTable()

        Dim jsonSerialiceCabecera As String = ""
        Dim jsonSerialiceDetalle As String = ""

        If dsPurchaseCreditMemo IsNot Nothing Then
            If dsPurchaseCreditMemo.Tables.Count > 0 Then
                dtCabecera = dsPurchaseCreditMemo.Tables(0)
                dtDetalle = dsPurchaseCreditMemo.Tables(1)
                dtAdicionales = dsPurchaseCreditMemo.Tables(2)
            End If
        End If

        For Each item As DataRow In dtCabecera.Rows
            Dim dictionaryCabecera = item.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) item(col.ColumnName))
            jsonSerialiceCabecera = JsonConvert.SerializeObject(dictionaryCabecera, Xml.Formatting.Indented)

            Dim contador As Integer = 1
            For Each itemDetalle As DataRow In dtDetalle.Rows

                Dim dictionaryDetalle = itemDetalle.Table.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) itemDetalle(col.ColumnName))


                If contador < dtDetalle.Rows.Count Then
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented) + " , "

                Else
                    jsonSerialiceDetalle = jsonSerialiceDetalle + JsonConvert.SerializeObject(dictionaryDetalle, Xml.Formatting.Indented)
                End If

                contador = contador + 1

            Next

            jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999999", "[" & jsonSerialiceDetalle & "]")
            'jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999998", "[" & "]")
            'jsonSerialiceCabecera = jsonSerialiceCabecera.Replace("-999997", "[" & "]")



            Dim content As StringContent = New StringContent(jsonSerialiceCabecera, Encoding.UTF8, "application/json")
            Dim URL As String = UrlPurchaseInvoice
            Dim response2 As HttpResponseMessage = client.PostAsync(URL, content).Result
            Dim receiveStream As String = response2.Content.ReadAsStringAsync().Result
            Dim oRespuesta As Respuesta = New Respuesta()
            oRespuesta = JsonConvert.DeserializeObject(Of Respuesta)(receiveStream)




            If oRespuesta.ResponseStatus = "MessageSuccess" Then
                oRespuesta.RespuestaSAP = 1
            Else
                oRespuesta.RespuestaSAP = 0
            End If
            oRespuesta.RespuestaNexsoft = 1
            Dim InterfaceName As String = dtAdicionales.Rows(0).Item("InterfaceName").ToString()
            Dim TableName As String = dtAdicionales.Rows(0).Item("TableName").ToString()


            Dim CCCT_Codigo As String = ""
            If IsDBNull(dtAdicionales.Rows(0).Item("CCCT_Codigo")) Then
                CCCT_Codigo = "NULL"
            Else
                CCCT_Codigo = dtAdicionales.Rows(0).Item("CCCT_Codigo").ToString()
            End If
            Dim AUDI_Usuario As String = dtAdicionales.Rows(0).Item("AUDI_Usuario").ToString()
            If oRespuesta.RespuestaSAP = 1 Then
                Dim Query As String = "EXEC NextSoft.sap.upUpdateSynchronizedPurchaseCreditMemo '" & oRespuesta.Response.Item(0).Number.ToString() & "' ," & "'" & InterfaceName & "'" & " , '" & TableName & "' , " & CCCT_Codigo & ", " & AUDI_Usuario & "'"
                Dim bResult As Boolean = Nothing
                bResult = oDelfinService.ExecuteSQLNonQuery(Query)
                If bResult Then
                    oRespuesta.RespuestaNexsoft = 1
                Else
                    oRespuesta.RespuestaNexsoft = 0
                End If
            Else
                oRespuesta.RespuestaNexsoft = 0
            End If
            listRespuestas.Add(oRespuesta)
        Next
        Return listRespuestas
    End Function



End Class
