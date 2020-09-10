' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "NextSoftService" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione NextSoftService.svc o NextSoftService.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports Application.BusinessEntities
Imports Application.BusinessLogic

Public Class NextSoftService
    Implements INextSoftService

    Public Function ExecuteSQL(ByVal QueryString As String) As DataSet Implements INextSoftService.ExecuteSQL
        Dim dsResult As New DataSet
        Dim oDataAccess As New DataAccess
        dsResult = oDataAccess.NewExecuteSQL(QueryString)
        Return dsResult
    End Function

    Public Function ExecuteSQLNonQuery(ByVal QueryString As String) As ArrayList Implements INextSoftService.ExecuteSQLNonQuery
        Dim aResult As New ArrayList
        aResult.AddRange({True, ""})
        Try
            Dim oDataAccess As New DataAccess
            aResult(0) = oDataAccess.ExecuteSQLNonQuery(QueryString)
        Catch ex As Exception
            aResult(1) = ex.Message
        End Try
        Return aResult
    End Function

#Region "COM_Sobrestadia"

    Dim oSobrestadiaBL As New COM_Sobrestadia_BL

    Public Function InsertSobrestadia(oSobrestadiaBE As COM_Sobrestadia_BE) As Boolean Implements INextSoftService.InsertSobrestadia
        Return oSobrestadiaBL.Insert(oSobrestadiaBE)
    End Function


    Public Function UpdateSobrestadia(oSobrestadiaBE As COM_Sobrestadia_BE) As Boolean Implements INextSoftService.UpdateSobrestadia
        Return oSobrestadiaBL.Update(oSobrestadiaBE)
    End Function

    Public Function DeleteSobrestadia(oSobrestadiaBE As COM_Sobrestadia_BE) As Boolean Implements INextSoftService.DeleteSobrestadia
        Return oSobrestadiaBL.Delete(oSobrestadiaBE)
    End Function

    Public Function GetAllSobrestadia(oSobrestadiaBE As COM_Sobrestadia_BE) As COM_Sobrestadia_BE Implements INextSoftService.GetAllSobrestadia
        Return oSobrestadiaBL.GetAll(oSobrestadiaBE)
    End Function

    Public Function GetSobrestadiaByFilter(oSobrestadiaBE As COM_Sobrestadia_BE) As DataTable Implements INextSoftService.GetSobrestadiaByFilter
        Return oSobrestadiaBL.GetDataTableByFilter(oSobrestadiaBE)
    End Function


#End Region

#Region "COM_DetSobrestadia"

    Dim oDetSobrestadiaBL As New COM_DetSobrestadia_BL

    Public Function InsertDetSobrestadia(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As Boolean Implements INextSoftService.InsertDetSobrestadia
        Return oDetSobrestadiaBL.Insert(oDetSobrestadiaBE)
    End Function


    Public Function UpdateDetSobrestadia(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As Boolean Implements INextSoftService.UpdateDetSobrestadia
        Return oDetSobrestadiaBL.Update(oDetSobrestadiaBE)
    End Function

    Public Function DeleteDetSobrestadia(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As Boolean Implements INextSoftService.DeleteDetSobrestadia
        Return oDetSobrestadiaBL.Delete(oDetSobrestadiaBE)
    End Function

    Public Function GetAllDetSobrestadia(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As COM_DetSobrestadia_BE Implements INextSoftService.GetAllDetSobrestadia
        Return oDetSobrestadiaBL.GetAll(oDetSobrestadiaBE)
    End Function

    Public Function GetDetSobrestadiaByFilter(oDetSobrestadiaBE As COM_DetSobrestadia_BE) As DataTable Implements INextSoftService.GetDetSobrestadiaByFilter
        Return oDetSobrestadiaBL.GetDataTableByFilter(oDetSobrestadiaBE)
    End Function


#End Region


End Class
