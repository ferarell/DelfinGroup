Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Linq.Dynamic
Imports Microsoft.Practices.Unity
Imports Infrastructure.Aspect.Importacion
Imports Infrastructure.Aspect.Collections

Public Class LoadingListUpload



    Public Class DetalladoController
        Inherits Delfin.Web.Std.Controllers.BaseController

        Public Function Index() As ActionResult
            Dim _model As Models.LoadingListImportacionModel = New Models.LoadingListImportacionModel()
            Return View(_model)
        End Function

        <HttpPost>
        Public Function UploadFile(ByVal x_model As Models.LoadingListImportacionModel) As ActionResult
            Try
                x_model.LOAD_MensajeError = Nothing

                If Not ModelState.IsValid Then
                    Dim _LOAD_MensajeError As String = ""

                    If String.IsNullOrEmpty(x_model.Via) Then
                        _LOAD_MensajeError += "* Debe seleccionar la Vía"
                    End If

                    If String.IsNullOrEmpty(x_model.CargaFecha) Then
                        _LOAD_MensajeError += "* Debe ingresar la Fecha de Carga (dd/mm/yyyy)"
                    End If

                    Dim _LOAD_CargaFecha As DateTime = DateTime.Now
                    Dim _culture = System.Globalization.CultureInfo.CreateSpecificCulture("es-PE")

                    If Not DateTime.TryParse(x_model.CargaFecha, _culture, System.Globalization.DateTimeStyles.None, _LOAD_CargaFecha) Then
                        _LOAD_MensajeError += "* Debe ingresar una fecha válida de Carga (dd/mm/yyyy)"
                    End If

                    If x_model.Archivo Is Nothing OrElse String.IsNullOrEmpty(x_model.Archivo.FileName) Then
                        _LOAD_MensajeError += "* Debe seleccionar el archivo de importación"
                    End If

                    If Not String.IsNullOrEmpty(_LOAD_MensajeError) Then
                        x_model.LOAD_MensajeError = _LOAD_MensajeError
                    End If

                    Return View("Index", x_model)
                Else
                    Dim _fileName As String = ""

                    If x_model.Archivo IsNot Nothing AndAlso Not String.IsNullOrEmpty(x_model.Archivo.FileName) Then

                        If x_model.Archivo IsNot Nothing AndAlso x_model.Archivo.ContentLength > 0 AndAlso (Path.GetExtension(x_model.Archivo.FileName) = ".xls" OrElse Path.GetExtension(x_model.Archivo.FileName) = ".xlsx") Then
                            Dim fileName = Path.GetFileName(x_model.Archivo.FileName)
                            _fileName = Path.Combine(Server.MapPath("~/Images/"), fileName)
                            x_model.Archivo.SaveAs(_fileName)
                            Dim excel As ImportarExcel = New ImportarExcel()
                            Dim _message As String = ""
                            Dim DataTableImportacion As System.Data.DataTable = excel.Excel(_fileName, _message)
                            System.IO.File.Delete(_fileName)

                            If DataTableImportacion IsNot Nothing AndAlso DataTableImportacion.Rows.Count > 0 Then

                                For Each _column As System.Data.DataColumn In DataTableImportacion.Columns
                                    _column.ColumnName = _column.ColumnName.Trim().ToUpper()
                                Next

                                If ValidateArchivo(DataTableImportacion) Then
                                    Dim columna As String = ""
                                    columna = "HBL"

                                    If DataTableImportacion.Columns.Contains(columna) Then
                                        DataTableImportacion.DefaultView.RowFilter = columna & " IS NOT NULL"
                                        DataTableImportacion = DataTableImportacion.DefaultView.ToTable()
                                    End If

                                    Dim ContainerService = TryCast(System.Web.HttpContext.Current.Application("ContainerService"), UnityContainer)
                                    Dim Client = ContainerService.Resolve(Of ServiceContracts.IDelfinServices)()
                                    Dim _list As ObservableCollection(Of Entities.LoadingListDetallado) = New ObservableCollection(Of Entities.LoadingListDetallado)()
                                    Dim _item As Entities.LoadingListDetallado = New Entities.LoadingListDetallado()

                                    For Each _DataRowImportacion As System.Data.DataRow In DataTableImportacion.Rows
                                        _item = New Entities.LoadingListDetallado()
                                        columna = "RO NO.UP"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_RONOUP = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "FOLLOWUP"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_FOLLOWUP = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "SHIPPER NAME"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_SHIPPER = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "CONSIGNEE NAME"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_CONSIGNEE = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "NOTIFY NAME"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_NOTIFY = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "POL"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_POL = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "POL_NAME"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_POLNAME = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "POD"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_POD = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "POD_NAME"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_PODNAME = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "CARRIER"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_CARRIER = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "BOOKINGNBR"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_BOOKING = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "MBL"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_MBL = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "HBL"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_HBL = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "ETD"

                                        If DataTableImportacion.Columns.Contains(columna) Then
                                            Dim _LOAD_ETD As DateTime

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) AndAlso DateTime.TryParse(_DataRowImportacion(columna).ToString(), _LOAD_ETD) Then
                                                _item.LOAD_ETD = _LOAD_ETD
                                            End If
                                        End If

                                        columna = "ETA"

                                        If DataTableImportacion.Columns.Contains(columna) Then
                                            Dim _LOAD_ETA As DateTime

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) AndAlso DateTime.TryParse(_DataRowImportacion(columna).ToString(), _LOAD_ETA) Then
                                                _item.LOAD_ETA = _LOAD_ETA
                                            End If
                                        End If

                                        columna = "CNTRTYPE"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_TIPOCNT = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "CNTRSIZE"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_TAMANIOCNTR = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "CNTR ID"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_NUMEROCNTR = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "SEAL NUMBER"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_PRECINTO = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "HAZARDOUS"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_CARGAPELIGROSA = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "IMO CLASS"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_IMOCLASS = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "GROSS WEIGHT"

                                        If DataTableImportacion.Columns.Contains(columna) Then
                                            Dim _LODE_PESOBRUTO As Decimal

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) AndAlso Decimal.TryParse(_DataRowImportacion(columna).ToString(), _LODE_PESOBRUTO) Then
                                                _item.LODE_PESOBRUTO = _LODE_PESOBRUTO
                                            End If
                                        End If

                                        columna = "PACK TYPE"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_PACKTYPE = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "PACK QTY"

                                        If DataTableImportacion.Columns.Contains(columna) Then
                                            Dim _LODE_CANTBULTOS As Decimal

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) AndAlso Decimal.TryParse(_DataRowImportacion(columna).ToString(), _LODE_CANTBULTOS) Then
                                                _item.LODE_CANTBULTOS = _LODE_CANTBULTOS
                                            End If
                                        End If

                                        columna = "VOLUME"

                                        If DataTableImportacion.Columns.Contains(columna) Then
                                            Dim _LODE_VOLUMEN As Decimal

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) AndAlso Decimal.TryParse(_DataRowImportacion(columna).ToString(), _LODE_VOLUMEN) Then
                                                _item.LODE_VOLUMEN = _LODE_VOLUMEN
                                            End If
                                        End If

                                        columna = "COMMODITY DESCRIPTION"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_DESCCARGA = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "MARKS & NUMBERS"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LODE_MARCASNUMEROS = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        columna = "CONTRACT CODE"

                                        If DataTableImportacion.Columns.Contains(columna) Then

                                            If Not String.IsNullOrEmpty(_DataRowImportacion(columna).ToString()) Then
                                                _item.LOAD_CONTRACTCODE = _DataRowImportacion(columna).ToString()
                                            End If
                                        End If

                                        _list.Add(_item)
                                    Next

                                    Dim distribucionSession As Delfin.Web.Std.Util.DistribucionSession = Delfin.Web.Std.AdministracionSession.Obtener()
                                    Dim sUsuario = distribucionSession.usuario
                                    Dim LOAD_CargaUsuario As String = sUsuario
                                    Dim LOAD_CargaFecha As DateTime = DateTime.Now
                                    Dim culture = System.Globalization.CultureInfo.CreateSpecificCulture("es-PE")

                                    If DateTime.TryParse(x_model.CargaFecha, culture, System.Globalization.DateTimeStyles.None, LOAD_CargaFecha) Then
                                        Dim CONS_TabVIA As String = "VIA"
                                        Dim CONS_CodVIA As String = x_model.Via
                                        Dim LOAD_MensajeError As String = ""

                                        If Client.SaveLoadingListImportDetallado(_list.ToTableValuedParameter(), LOAD_CargaUsuario, LOAD_CargaFecha, CONS_TabVIA, CONS_CodVIA, LOAD_MensajeError) Then

                                            If String.IsNullOrEmpty(LOAD_MensajeError) Then
                                                x_model.LOAD_MensajeError = "Se ha cargado satisfactoriamente el archivo."
                                            Else
                                                x_model.LOAD_MensajeError = LOAD_MensajeError
                                            End If

                                            Return View("Index", x_model)
                                        Else
                                            x_model.LOAD_MensajeError = LOAD_MensajeError
                                            Return View("Index", x_model)
                                        End If
                                    Else
                                        x_model.LOAD_MensajeError = "* Debe ingresar una fecha válida de Carga (dd/mm/yyyy)"
                                        Return View("Index", x_model)
                                    End If
                                Else
                                    x_model.LOAD_MensajeError = "El archivo seleccionado no contiene las columnas según el formato."
                                    Return View("Index", x_model)
                                End If
                            Else
                                x_model.LOAD_MensajeError = "* El archivo seleccionado no devolvio ningún registro, seleccione otro archivo."
                                Return View("Index", x_model)
                            End If
                        Else
                            x_model.LOAD_MensajeError = "* El archivo seleccionado no es correcto, debe ingresar un Archivo de Excel (*.xls, *.xlsx)"
                            Return View("Index", x_model)
                        End If
                    End If

                    Return View("Index", x_model)
                End If

            Catch __unusedException1__ As Exception
                Return View("Index", x_model)
            End Try
        End Function

        Public Function ListImportacion(ByVal Optional CargaFecha As String = Nothing, ByVal Optional sortBy As String = "LOAD_HBL", ByVal Optional ascending As Boolean = True, ByVal Optional page As Integer = 1, ByVal Optional pageSize As Integer = 10, ByVal Optional ShowLoadingListAsociado As Boolean = True, ByVal Optional ShowLoadingListNoAsociado As Boolean = True, ByVal Optional ShowOrdenVentaAsociada As Boolean = True, ByVal Optional LoadingListAsociado As Int32 = 0, ByVal Optional LoadingListNoAsociado As Int32 = 0, ByVal Optional OrdenVentaAsociada As Int32 = 0) As ActionResult
            Try
                Dim _LOAD_CargaFecha As DateTime
                Dim _culture = System.Globalization.CultureInfo.CreateSpecificCulture("es-PE")

                If Not String.IsNullOrEmpty(CargaFecha) AndAlso DateTime.TryParse(CargaFecha, _culture, System.Globalization.DateTimeStyles.None, _LOAD_CargaFecha) Then
                    Dim ContainerService = TryCast(System.Web.HttpContext.Current.Application("ContainerService"), UnityContainer)
                    Dim Client = ContainerService.Resolve(Of ServiceContracts.IDelfinServices)()
                    Dim ListLoadingList = Client.GetAllLoadingListImportDetallado(_LOAD_CargaFecha).AsQueryable()
                    Dim model = New Models.LoadingListImportacionModel() With {
                        .CargaFecha = CargaFecha,
                        .sortBy = sortBy,
                        .SortAscending = ascending,
                        .CurrentPageIndex = page,
                        .pageSize = pageSize,
                        .ShowLoadingListAsociado = ShowLoadingListAsociado,
                        .ShowLoadingListNoAsociado = ShowLoadingListNoAsociado,
                        .ShowOrdenVentaAsociada = ShowOrdenVentaAsociada
                    }
                    model.ListLoadingListDetalladoTotal = ListLoadingList.ToObservableCollection()
                    Dim _newListLoadingList As ObservableCollection(Of Entities.LoadingListDetallado) = New ObservableCollection(Of Entities.LoadingListDetallado)()
                    _newListLoadingList = _newListLoadingList.Concat(ListLoadingList).ToObservableCollection()
                    model.TotalRecordCount = _newListLoadingList.Count()
                    model.ListLoadingListDetallado = (_newListLoadingList.OrderBy(model.SortExpression).Skip((model.CurrentPageIndex - 1) * model.PageSize).Take(model.PageSize)).ToObservableCollection()
                    Return View(model)
                End If

                Return View()
            Catch __unusedException1__ As Exception
                Return View()
            End Try
        End Function

        Private Function ValidateArchivo(ByVal DataTableImportacion As System.Data.DataTable) As Boolean
            Dim columna As String
            columna = "RO NO.UP"
            columna = "FOLLOWUP"
            columna = "SHIPPER NAME"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "CONSIGNEE NAME"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "NOTIFY NAME"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "POL"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "POL_NAME"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "POD"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "POD_NAME"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "CARRIER"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "BOOKINGNBR"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "MBL"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "HBL"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "ETD"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "ETA"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "CNTRTYPE"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "CNTRSIZE"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "CNTR ID"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "SEAL NUMBER"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "HAZARDOUS"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "IMO CLASS"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "GROSS WEIGHT"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "PACK TYPE"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "PACK QTY"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "VOLUME"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "COMMODITY DESCRIPTION"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "MARKS & NUMBERS"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            columna = "CONTRACT CODE"

            If Not DataTableImportacion.Columns.Contains(columna) Then
                Return False
            End If

            Return True
        End Function
    End Class


