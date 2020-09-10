Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports Application.BusinessEntities

Public Class EntidadDireccionamiento_DA
    Dim constr As String = ConfigurationSettings.AppSettings("dbSolution").ToString()
    Dim cnx As New SqlConnection(constr)
    Dim cmd As New SqlCommand

    Public Function Insert(ByVal BE As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dgp.upEntidadDireccionamientoInsert"

            With .Parameters
                .Clear()
                '.Add("@ENDI_Numero", SqlDbType.Int).Value = BE.ENDI_Numero
                .Add("@ENTC_Codigo", SqlDbType.Int).Value = BE.ENTC_Codigo
                .Add("@ENTC_EMailSolicitante", SqlDbType.VarChar, 50).Value = BE.ENTC_EMailSolicitante
                .Add("@DOOV_HBL", SqlDbType.NVarChar, 50).Value = BE.DOOV_HBL
                .Add("@ENTC_CodDepTemporal", SqlDbType.Int).Value = BE.ENTC_CodDepTemporal
                .Add("@DescargaDirecta", SqlDbType.Bit).Value = BE.DescargaDirecta
                .Add("@ENTC_CodDepTemporalSolicitado", SqlDbType.Int).Value = BE.ENTC_CodDepTemporalSolicitado
                '.Add("@ENDI_Estado", SqlDbType.Char, 1).Value = BE.ENDI_Estado
                .Add("@AUDI_USRCREA", SqlDbType.VarChar, 20).Value = BE.AUDI_UsrCrea
                .Add("@AUDI_FECCREA", SqlDbType.DateTime).Value = BE.AUDI_FecCrea
            End With
        End With


        Dim pENDI_Numero As New SqlParameter("@ENDI_Numero", SqlDbType.Int)
        pENDI_Numero.Direction = ParameterDirection.InputOutput
        pENDI_Numero.Value = BE.ENDI_Numero
        cmd.Parameters.Add(pENDI_Numero)
        Dim pENDI_Estado As New SqlParameter("@ENDI_Estado", SqlDbType.Char, 1)
        pENDI_Estado.Direction = ParameterDirection.InputOutput
        pENDI_Estado.Value = BE.ENDI_Estado
        cmd.Parameters.Add(pENDI_Estado)



        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                BE.ENDI_Estado = cmd.Parameters("@ENDI_Estado").Value.ToString
                BE.ENDI_Numero = Convert.ToInt32(cmd.Parameters("@ENDI_Numero").Value)
                BE.DescripcionRespuesta = "OK"
                BE.CodigoRespuesta = "OK"
            Else

                BE.DescripcionRespuesta = "ERROR"
                BE.CodigoRespuesta = "ERROR"
            End If
        Catch ex As Exception
            BE.DescripcionRespuesta = ex.Message
            BE.CodigoRespuesta = "ERROR"
        Finally
            cnx.Close()
        End Try
        Return BE
    End Function

    Public Function Update(ByVal BE As EntidadDireccionamiento_BE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dgp.upEntidadDireccionamientoUpdate"

            With .Parameters
                .Clear()
                .Add("@ENDI_Numero", SqlDbType.Int).Value = BE.ENDI_Numero
                .Add("@ENTC_Codigo", SqlDbType.Int).Value = BE.ENTC_Codigo
                .Add("@ENTC_EMailSolicitante", SqlDbType.VarChar, 50).Value = BE.ENTC_EMailSolicitante
                .Add("@DOOV_HBL", SqlDbType.NVarChar, 50).Value = BE.DOOV_HBL
                .Add("@ENTC_CodDepTemporal", SqlDbType.Int).Value = BE.ENTC_CodDepTemporal
                .Add("@DescargaDirecta", SqlDbType.Bit).Value = BE.DescargaDirecta
                .Add("@ENTC_CodDepTemporalSolicitado", SqlDbType.Int).Value = BE.ENTC_CodDepTemporalSolicitado
                .Add("@ENDI_Estado", SqlDbType.Char, 1).Value = BE.ENDI_Estado
                .Add("@AUDI_USRCREA", SqlDbType.VarChar, 20).Value = BE.AUDI_UsrCrea
                .Add("@AUDI_FECCREA", SqlDbType.DateTime).Value = BE.AUDI_FecCrea
            End With
        End With

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

    Public Function Delete(ByVal BE As EntidadDireccionamiento_BE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dgp.upEntidadDireccionamientoDelete"

            With .Parameters
                .Clear()
                .Add("@ENTC_Codigo", SqlDbType.Int).Value = BE.ENTC_Codigo
                .Add("@ENTC_EMailSolicitante", SqlDbType.VarChar, 50).Value = BE.ENTC_EMailSolicitante
                .Add("@DOOV_HBL", SqlDbType.NVarChar, 50).Value = BE.DOOV_HBL
                .Add("@ENTC_CodDepTemporal", SqlDbType.Int).Value = BE.ENTC_CodDepTemporal
                .Add("@DescargaDirecta", SqlDbType.Bit).Value = BE.DescargaDirecta
                .Add("@ENTC_CodDepTemporalSolicitado", SqlDbType.Int).Value = BE.ENTC_CodDepTemporalSolicitado
                .Add("@AUDI_UsrMod", SqlDbType.VarChar, 20).Value = BE.AUDI_UsrMod
                .Add("@AUDI_FecMod", SqlDbType.DateTime).Value = BE.AUDI_FecMod
            End With
        End With

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

    Public Function GetAll(ByVal BE As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE
        Dim dr As SqlDataReader
        Dim EntidadDireccionamientoBE As New EntidadDireccionamiento_BE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dgp.upEntidadDireccionamientoSelectAll"

            With .Parameters
                .Clear()
                .Add("@ENDI_Numero", SqlDbType.Int).Value = BE.ENDI_Numero
                .Add("@ENTC_Codigo", SqlDbType.Int).Value = BE.ENTC_Codigo
                .Add("@ENTC_EMailSolicitante", SqlDbType.VarChar, 50).Value = BE.ENTC_EMailSolicitante
                .Add("@DOOV_HBL", SqlDbType.NVarChar, 50).Value = BE.DOOV_HBL
                .Add("@DescargaDirecta", SqlDbType.Bit).Value = BE.DescargaDirecta
                .Add("@ENTC_CodDepTemporal", SqlDbType.Int).Value = BE.ENTC_CodDepTemporal
                .Add("@ENTC_CodDepTemporalSolicitado", SqlDbType.Int).Value = BE.ENTC_CodDepTemporalSolicitado
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With EntidadDireccionamientoBE
                        If dr("ENDI_Numero") Is DBNull.Value Then
                            .ENDI_Numero = Nothing
                        Else
                            .ENDI_Numero = dr("ENDI_Numero")
                        End If

                        If dr("ENTC_Codigo") Is DBNull.Value Then
                            .ENTC_Codigo = Nothing
                        Else
                            .ENTC_Codigo = dr("ENTC_Codigo")
                        End If

                        If dr("ENTC_EMailSolicitante") Is DBNull.Value Then
                            .ENTC_EMailSolicitante = Nothing
                        Else
                            .ENTC_EMailSolicitante = dr("ENTC_EMailSolicitante")
                        End If

                        If dr("DOOV_HBL") Is DBNull.Value Then
                            .DOOV_HBL = Nothing
                        Else
                            .DOOV_HBL = dr("DOOV_HBL")
                        End If

                        If dr("ENTC_CodDepTemporal") Is DBNull.Value Then
                            .ENTC_CodDepTemporal = Nothing
                        Else
                            .ENTC_CodDepTemporal = dr("ENTC_CodDepTemporal")
                        End If

                        If dr("ENTC_CodDepTemporalSolicitado") Is DBNull.Value Then
                            .ENTC_CodDepTemporalSolicitado = Nothing
                        Else
                            .ENTC_CodDepTemporalSolicitado = dr("ENTC_CodDepTemporalSolicitado")
                        End If

                        If dr("ENDI_Estado") Is DBNull.Value Then
                            .ENDI_Estado = Nothing
                        Else
                            .ENDI_Estado = dr("ENDI_Estado")
                        End If


                        If dr("DescargaDirecta") Is DBNull.Value Then
                            .DescargaDirecta = Nothing
                        Else
                            .DescargaDirecta = dr("DescargaDirecta")
                        End If



                        If dr("AUDI_UsrCrea") Is DBNull.Value Then
                            .AUDI_UsrCrea = Nothing
                        Else
                            .AUDI_UsrCrea = dr("AUDI_UsrCrea")
                        End If

                        If dr("AUDI_FecCrea") Is DBNull.Value Then
                            .AUDI_FecCrea = Nothing
                        Else
                            .AUDI_FecCrea = dr("AUDI_FecCrea")
                        End If

                        If dr("AUDI_UsrMod") Is DBNull.Value Then
                            .AUDI_UsrMod = Nothing
                        Else
                            .AUDI_UsrMod = dr("AUDI_UsrMod")
                        End If

                        If dr("AUDI_FecMod") Is DBNull.Value Then
                            .AUDI_FecMod = Nothing
                        Else
                            .AUDI_FecMod = dr("AUDI_FecMod")
                        End If


                        If dr("NombreCliente") Is DBNull.Value Then
                            .NombreCliente = Nothing
                        Else
                            .NombreCliente = dr("NombreCliente")
                        End If


                        If dr("NombreDepositoTemporal") Is DBNull.Value Then
                            .NombreDepositoTemporal = Nothing
                        Else
                            .NombreDepositoTemporal = dr("NombreDepositoTemporal")
                        End If


                        If dr("NombreDepositoTemporalAsignado") Is DBNull.Value Then
                            .NombreDepositoTemporalAsignado = Nothing
                        Else
                            .NombreDepositoTemporalAsignado = dr("NombreDepositoTemporalAsignado")
                        End If



                        If dr("FechaMaxDireccionamiento") Is DBNull.Value Then
                            .FechaMaxDireccionamiento = Nothing
                        Else
                            .FechaMaxDireccionamiento = dr("FechaMaxDireccionamiento")
                        End If

                        If dr("DescripcionEstado") Is DBNull.Value Then
                            .DescripcionEstado = Nothing
                        Else
                            .DescripcionEstado = dr("DescripcionEstado")
                        End If

                        If dr("EsAnulable") Is DBNull.Value Then
                            .EsAnulable = Nothing
                        Else
                            .EsAnulable = dr("EsAnulable")
                        End If



                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return EntidadDireccionamientoBE
    End Function


    Public Function GetByFilter(ByVal BE As EntidadDireccionamiento_BE) As List(Of EntidadDireccionamiento_BE)
        Dim dr As SqlDataReader
        Dim ListEntDir As List(Of EntidadDireccionamiento_BE) = New List(Of EntidadDireccionamiento_BE)()

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dgp.upEntidadDireccionamientoSelectByFilter"

            With .Parameters
                .Clear()
                .Add("@ENDI_Numero", SqlDbType.Int).Value = BE.ENDI_Numero
                .Add("@ENTC_Codigo", SqlDbType.Int).Value = BE.ENTC_Codigo
                .Add("@ENTC_EMailSolicitante", SqlDbType.VarChar, 50).Value = BE.ENTC_EMailSolicitante
                .Add("@DOOV_HBL", SqlDbType.NVarChar, 50).Value = BE.DOOV_HBL
                .Add("@ENTC_CodDepTemporal", SqlDbType.Int).Value = BE.ENTC_CodDepTemporal
                .Add("@DescargaDirecta", SqlDbType.Bit).Value = BE.DescargaDirecta
                .Add("@ENTC_CodDepTemporalSolicitado", SqlDbType.Int).Value = BE.ENTC_CodDepTemporalSolicitado
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim EntidadDireccionamientoBE As New EntidadDireccionamiento_BE
                    With EntidadDireccionamientoBE
                        If dr("ENDI_Numero") Is DBNull.Value Then
                            .ENDI_Numero = Nothing
                        Else
                            .ENDI_Numero = dr("ENDI_Numero")
                        End If

                        If dr("ENTC_Codigo") Is DBNull.Value Then
                            .ENTC_Codigo = Nothing
                        Else
                            .ENTC_Codigo = dr("ENTC_Codigo")
                        End If

                        If dr("ENTC_EMailSolicitante") Is DBNull.Value Then
                            .ENTC_EMailSolicitante = Nothing
                        Else
                            .ENTC_EMailSolicitante = dr("ENTC_EMailSolicitante")
                        End If

                        If dr("DOOV_HBL") Is DBNull.Value Then
                            .DOOV_HBL = Nothing
                        Else
                            .DOOV_HBL = dr("DOOV_HBL")
                        End If

                        If dr("DescargaDirecta") Is DBNull.Value Then
                            .DescargaDirecta = Nothing
                        Else
                            .DescargaDirecta = dr("DescargaDirecta")
                        End If

                        If dr("ENTC_CodDepTemporal") Is DBNull.Value Then
                            .ENTC_CodDepTemporal = Nothing
                        Else
                            .ENTC_CodDepTemporal = dr("ENTC_CodDepTemporal")
                        End If

                        If dr("ENTC_CodDepTemporalSolicitado") Is DBNull.Value Then
                            .ENTC_CodDepTemporalSolicitado = Nothing
                        Else
                            .ENTC_CodDepTemporalSolicitado = dr("ENTC_CodDepTemporalSolicitado")
                        End If

                        If dr("ENDI_Estado") Is DBNull.Value Then
                            .ENDI_Estado = Nothing
                        Else
                            .ENDI_Estado = dr("ENDI_Estado")
                        End If

                        If dr("AUDI_UsrCrea") Is DBNull.Value Then
                            .AUDI_UsrCrea = Nothing
                        Else
                            .AUDI_UsrCrea = dr("AUDI_UsrCrea")
                        End If

                        If dr("AUDI_FecCrea") Is DBNull.Value Then
                            .AUDI_FecCrea = Nothing
                        Else
                            .AUDI_FecCrea = dr("AUDI_FecCrea")
                        End If

                        If dr("AUDI_UsrMod") Is DBNull.Value Then
                            .AUDI_UsrMod = Nothing
                        Else
                            .AUDI_UsrMod = dr("AUDI_UsrMod")
                        End If

                        If dr("AUDI_FecMod") Is DBNull.Value Then
                            .AUDI_FecMod = Nothing
                        Else
                            .AUDI_FecMod = dr("AUDI_FecMod")
                        End If


                        If dr("NombreCliente") Is DBNull.Value Then
                            .NombreCliente = Nothing
                        Else
                            .NombreCliente = dr("NombreCliente")
                        End If


                        If dr("NombreDepositoTemporal") Is DBNull.Value Then
                            .NombreDepositoTemporal = Nothing
                        Else
                            .NombreDepositoTemporal = dr("NombreDepositoTemporal")
                        End If


                        If dr("NombreDepositoTemporalAsignado") Is DBNull.Value Then
                            .NombreDepositoTemporalAsignado = Nothing
                        Else
                            .NombreDepositoTemporalAsignado = dr("NombreDepositoTemporalAsignado")
                        End If


                        If dr("FechaMaxDireccionamiento") Is DBNull.Value Then
                            .FechaMaxDireccionamiento = Nothing
                        Else
                            .FechaMaxDireccionamiento = dr("FechaMaxDireccionamiento")
                        End If

                        If dr("DescripcionEstado") Is DBNull.Value Then
                            .DescripcionEstado = Nothing
                        Else
                            .DescripcionEstado = dr("DescripcionEstado")
                        End If

                        If dr("EsAnulable") Is DBNull.Value Then
                            .EsAnulable = Nothing
                        Else
                            .EsAnulable = dr("EsAnulable")
                        End If

                    End With
                    ListEntDir.Add(EntidadDireccionamientoBE)
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return ListEntDir
    End Function




    Public Function ValidarDireccionamiento(ByVal BE As EntidadDireccionamiento_BE) As EntidadDireccionamiento_BE
        Dim dr As SqlDataReader
        Dim EntidadDireccionamientoBE As New EntidadDireccionamiento_BE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dgp.upEntidadDireccionamientoValidate"

            With .Parameters
                .Clear()
                .Add("@DOOV_HBL", SqlDbType.NVarChar, 50).Value = BE.DOOV_HBL
                .Add("@DescargaDirecta", SqlDbType.Bit).Value = BE.DescargaDirecta
                .Add("@ENTC_CodDepTemporal", SqlDbType.Int).Value = BE.ENTC_CodDepTemporal
                .Add("@ENTC_CodDepTemporalSolicitado", SqlDbType.Int).Value = BE.ENTC_CodDepTemporalSolicitado
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With EntidadDireccionamientoBE
                        If dr("CodigoRespuesta") Is DBNull.Value Then
                            .CodigoRespuesta = Nothing
                        Else
                            .CodigoRespuesta = dr("CodigoRespuesta")
                        End If

                        If dr("DescripcionRespuesta") Is DBNull.Value Then
                            .DescripcionRespuesta = Nothing
                        Else
                            .DescripcionRespuesta = dr("DescripcionRespuesta")
                        End If

                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return EntidadDireccionamientoBE
    End Function









    Public Function GetAllDataTable(ByVal BE As EntidadDireccionamiento_BE) As DataTable
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "dgp.upEntidadDireccionamientoSelectAll"

            With .Parameters
                .Clear()
                .Add("@ENDI_Numero", SqlDbType.Int).Value = BE.ENDI_Numero
                .Add("@ENTC_Codigo", SqlDbType.Int).Value = BE.ENTC_Codigo
                .Add("@ENTC_EMailSolicitante", SqlDbType.VarChar, 50).Value = BE.ENTC_EMailSolicitante
                .Add("@DOOV_HBL", SqlDbType.NVarChar, 50).Value = BE.DOOV_HBL
                .Add("@ENTC_CodDepTemporal", SqlDbType.Int).Value = BE.ENTC_CodDepTemporal
                .Add("@DescargaDirecta", SqlDbType.Bit).Value = BE.DescargaDirecta
                .Add("@ENTC_CodDepTemporalSolicitado", SqlDbType.Int).Value = BE.ENTC_CodDepTemporalSolicitado
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            dt.TableName = "Result"
            Return dt
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function


End Class
