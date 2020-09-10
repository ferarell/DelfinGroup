
Public Class EventUpdate

    Friend CCOT_Numero As Integer
    Friend TIPO_CodEVE As String
    Friend EVEN_Observaciones As String
    Friend AUDI_UsrCrea As String
    Dim oAppService As New AppService.DelfinServiceClient

    Friend Sub InsertEvent()
        oAppService.ExecuteSQL("EXEC NextSoft.dgp.paAsignaEventoPorOV " & CCOT_Numero.ToString & ",'" & TIPO_CodEVE & "','" & EVEN_Observaciones & "','" & AUDI_UsrCrea & "'")

    End Sub

End Class
