Imports System.Data
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class ReadXML

    Friend Function LoadFile(FileName As String) As XmlDocument
        Dim dsFactura As New DataSet
        Dim bResult As Boolean = True
        Dim xmlDoc As New XmlDocument
        Dim oAddIn As ThisAddIn
        Try
            xmlDoc.Load(FileName)
            dsFactura = ConvertXMLToDataSet(File.ReadAllText(FileName), FileName)
        Catch ex As Exception
            SendErrorMessage(oAddIn.items, Identifier, "No se descargó el archivo adjunto.", Nothing)
            Return Nothing
        End Try
        Return xmlDoc
    End Function

    'Private Sub XmlSunat(sender As Object, e As EventArgs)
    '    Dim serial As New XmlSerializer(GetType(InvoiceType))
    '    Dim fs As New FileStream("C:\Sunat\Clases Sergio\20527744548-01-FF14-0000010.xml", FileMode.Open)
    '    Dim _comprobante = CType(serial.Deserialize(fs), InvoiceType)

    '    Dim ruc = _comprobante.AccountingSupplierParty.CustomerAssignedAccountID.Value

    '    Dim items = New List(Of EntidadesSunat)()
    '    For Each element As Object In _comprobante.InvoiceLine
    '        Dim line = New EntidadesSunat
    '        line.Id = element.ID.Value
    '        line.Quantity = element.InvoicedQuantity.Value.ToString()
    '        line.Ammount = element.LineExtensionAmount.Value.ToString()
    '        line.Description = element.Item.Description(0).Value

    '        items.Add(line)
    '    Next
    'End Sub

    ' Function to convert passed XML data to dataset
    Public Function ConvertXMLToDataSet(xmlData As String, xmlUrl As String) As DataSet
        Dim stream As StringReader = Nothing
        Dim reader As XmlTextReader = Nothing
        Dim fileXML As XDocument
        Try
            Dim xmlDS As New DataSet()

            Using sr As New StreamReader(xmlUrl, Encoding.GetEncoding("iso-8859-1"))
                Dim xmlString As String = sr.ReadToEnd()
                Dim _reader As New StringReader(xmlString)
                fileXML = XDocument.Load(_reader, LoadOptions.None)
            End Using

            stream = New StringReader(xmlData)
            ' Load the XmlTextReader from the stream
            reader = New XmlTextReader(stream)
            xmlDS.ReadXml(reader)

            'If xmlDS Is Nothing Then
            '    xmlDS.ReadXml(fileXML)
            'End If
            Return xmlDS
        Catch
            Return Nothing
        Finally
            If reader IsNot Nothing Then
                reader.Close()
            End If
        End Try
    End Function
    ' Use this function to get XML string from a dataset
    ' Function to convert passed dataset to XML data
    Public Function ConvertDataSetToXML(xmlDS As DataSet) As String
        Dim stream As MemoryStream = Nothing
        Dim writer As XmlTextWriter = Nothing
        Try
            stream = New MemoryStream()
            ' Load the XmlTextReader from the stream
            writer = New XmlTextWriter(stream, Encoding.Unicode)
            ' Write to the file with the WriteXml method.
            xmlDS.WriteXml(writer)
            Dim count As Integer = CType(stream.Length, Integer)
            Dim arr As Byte() = New Byte(count - 1) {}
            stream.Seek(0, SeekOrigin.Begin)
            stream.Read(arr, 0, count)
            Dim utf As New UnicodeEncoding()
            Return utf.GetString(arr).Trim()
        Catch
            Return [String].Empty
        Finally
            If writer IsNot Nothing Then
                writer.Close()
            End If
        End Try
    End Function
End Class
