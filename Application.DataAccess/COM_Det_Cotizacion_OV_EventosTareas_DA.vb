Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Application.BusinessEntities
Public Class COM_Det_Cotizacion_OV_EventosTareas_DA
    Dim constr As String = ConfigurationSettings.AppSettings("dbNextSoft").ToString()
    Dim cnx As New SqlConnection(constr)
    Dim cmd As New SqlCommand

    Public Function Insert(ByVal BE As COM_Det_Cotizacion_OV_EventosTareas_BE) As COM_Det_Cotizacion_OV_EventosTareas_BE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dbo.COM_EVENSI_UnReg"

            With .Parameters
                .Clear()
                .Add("@pintCCOT_Numero", SqlDbType.Int).Value = BE.CCOT_Numero
                .Add("@psinCCOT_Tipo", SqlDbType.SmallInt).Value = BE.CCOT_Tipo


                .Add("@pdtmEVEN_Fecha", SqlDbType.DateTime).Value = BE.EVEN_Fecha
                .Add("@pbitEVEN_Cumplida", SqlDbType.Bit).Value = BE.EVEN_Cumplida
                .Add("@pvchEVEN_Usuario", SqlDbType.VarChar, 8).Value = BE.EVEN_Usuario

                .Add("@pvchEVEN_Observaciones", SqlDbType.VarChar, 8000).Value = BE.EVEN_Observaciones
                .Add("@pchrTIPO_TabEVE", SqlDbType.Char, 3).Value = BE.TIPO_TabEVE
                .Add("@pchrTIPO_CodEVE", SqlDbType.Char, 3).Value = BE.TIPO_CodEVE
                .Add("@pchrCONS_TabMOD", SqlDbType.Char, 3).Value = BE.CONS_TabMOD
                .Add("@pchrCONS_CodMOD", SqlDbType.Char, 3).Value = BE.CONS_CodMOD
                .Add("@pbitEVEN_Manual", SqlDbType.Bit).Value = BE.EVEN_Manual
                .Add("@pvchAUDI_UsrCrea", SqlDbType.VarChar, 20).Value = BE.AUDI_UsrCrea
            End With
        End With


        Dim pEVEN_Item As New SqlParameter("@psinEVEN_Item", SqlDbType.SmallInt)
        pEVEN_Item.Direction = ParameterDirection.InputOutput
        pEVEN_Item.Value = BE.EVEN_Item
        cmd.Parameters.Add(pEVEN_Item)

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                BE.EVEN_Item = cmd.Parameters("@psinEVEN_Item").Value.ToString
            Else
                BE.CCOT_Numero = -1
                '    Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return BE
    End Function

    Public Function Update(ByVal BE As COM_Det_Cotizacion_OV_EventosTareas_BE) As Boolean
        Dim Updated As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dbo.COM_EVENSU_UnReg"

            With .Parameters
                .Clear()
                .Add("@pintCCOT_Numero", SqlDbType.Int).Value = BE.CCOT_Numero
                .Add("@psinCCOT_Tipo", SqlDbType.SmallInt).Value = BE.CCOT_Tipo


                .Add("@pdtmEVEN_Fecha", SqlDbType.DateTime).Value = BE.EVEN_Fecha
                .Add("@pbitEVEN_Cumplida", SqlDbType.Bit).Value = BE.EVEN_Cumplida
                .Add("@pvchEVEN_Usuario", SqlDbType.VarChar, 8).Value = BE.EVEN_Usuario

                .Add("@pvchEVEN_Observaciones", SqlDbType.VarChar, 8000).Value = BE.EVEN_Observaciones
                .Add("@pchrTIPO_TabEVE", SqlDbType.Char, 3).Value = BE.TIPO_TabEVE
                .Add("@pchrTIPO_CodEVE", SqlDbType.Char, 3).Value = BE.TIPO_CodEVE
                .Add("@pchrCONS_TabMOD", SqlDbType.Char, 3).Value = BE.CONS_TabMOD
                .Add("@pchrCONS_CodMOD", SqlDbType.Char, 3).Value = BE.CONS_CodMOD
                .Add("@pbitEVEN_Manual", SqlDbType.Bit).Value = BE.EVEN_Manual
                .Add("@pvchAUDI_UsrMod", SqlDbType.VarChar, 20).Value = BE.AUDI_UsrMod
            End With
        End With


        Dim pEVEN_Item As New SqlParameter("@psinEVEN_Item", SqlDbType.SmallInt)
        pEVEN_Item.Direction = ParameterDirection.Input
        pEVEN_Item.Value = BE.EVEN_Item
        cmd.Parameters.Add(pEVEN_Item)

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Updated = True
            Else
                Updated = False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try

        Return Updated
    End Function

    Public Function Delete(ByVal BE As COM_Det_Cotizacion_OV_EventosTareas_BE) As Boolean
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dbo.COM_EVENSD_UnReg"

            With .Parameters
                .Clear()
                .Add("@pintCCOT_Numero", SqlDbType.Int).Value = BE.CCOT_Numero
                .Add("@psinCCOT_Tipo", SqlDbType.SmallInt).Value = BE.CCOT_Tipo
            End With
        End With

        Dim pEVEN_Item As New SqlParameter("@psinEVEN_Item", SqlDbType.SmallInt)
        pEVEN_Item.Direction = ParameterDirection.Input
        pEVEN_Item.Value = BE.EVEN_Item
        cmd.Parameters.Add(pEVEN_Item)

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function


End Class
