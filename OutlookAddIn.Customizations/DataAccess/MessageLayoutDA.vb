Imports System.Data
Imports System.Data.SqlClient

Public Class MessageLayoutDA

    Dim cnx As New SqlConnection(ConexionDAO.GetCnx)
    Dim cmd As New SqlCommand

    Public Function Insert(ByVal BE As MessageLayoutBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MESSAGELAYOUT_INS01"

            With .Parameters
                .Clear()
                .Add("@IDMESSAGELAYOUT", SqlDbType.Int).Value = BE.IdMessageLayout
                .Add("@IDMESSAGESTRUCTURE", SqlDbType.Int).Value = BE.IdMessageStructure
                .Add("@IDINPUTCONFIGURATION", SqlDbType.Int).Value = BE.IdInputConfiguration
                .Add("@MESSAGETEXT", SqlDbType.VarBinary, -1).Value = BE.MessageText
                .Add("@VALIDFROM", SqlDbType.DateTime).Value = BE.ValidFrom
                .Add("@VALIDTO", SqlDbType.DateTime).Value = BE.ValidTo
                .Add("@USERCREATE", SqlDbType.NVarChar, 150).Value = BE.UserCreate
                .Add("@DATECREATE", SqlDbType.DateTime).Value = BE.DateCreate
                .Add("@USERUPDATE", SqlDbType.NVarChar, 150).Value = BE.UserUpdate
                .Add("@DATEUPDATE", SqlDbType.DateTime).Value = BE.DateUpdate
                .Add("@IDMESSAGELAYOUT", SqlDbType.Int).Value = BE.IdMessageLayout
                .Add("@IDMESSAGESTRUCTURE", SqlDbType.Int).Value = BE.IdMessageStructure
                .Add("@IDINPUTCONFIGURATION", SqlDbType.Int).Value = BE.IdInputConfiguration
                .Add("@MESSAGETEXT", SqlDbType.VarBinary, -1).Value = BE.MessageText
                .Add("@VALIDFROM", SqlDbType.DateTime).Value = BE.ValidFrom
                .Add("@VALIDTO", SqlDbType.DateTime).Value = BE.ValidTo
                .Add("@USERCREATE", SqlDbType.NVarChar, 150).Value = BE.UserCreate
                .Add("@DATECREATE", SqlDbType.DateTime).Value = BE.DateCreate
                .Add("@USERUPDATE", SqlDbType.NVarChar, 150).Value = BE.UserUpdate
                .Add("@DATEUPDATE", SqlDbType.DateTime).Value = BE.DateUpdate
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
    Public Function Update(ByVal BE As MessageLayoutBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MESSAGELAYOUT_UPD01"

            With .Parameters
                .Clear()
                .Add("@IDMESSAGELAYOUT", SqlDbType.Int).Value = BE.IdMessageLayout
                .Add("@IDMESSAGESTRUCTURE", SqlDbType.Int).Value = BE.IdMessageStructure
                .Add("@IDINPUTCONFIGURATION", SqlDbType.Int).Value = BE.IdInputConfiguration
                .Add("@MESSAGETEXT", SqlDbType.VarBinary, -1).Value = BE.MessageText
                .Add("@VALIDFROM", SqlDbType.DateTime).Value = BE.ValidFrom
                .Add("@VALIDTO", SqlDbType.DateTime).Value = BE.ValidTo
                .Add("@USERCREATE", SqlDbType.NVarChar, 150).Value = BE.UserCreate
                .Add("@DATECREATE", SqlDbType.DateTime).Value = BE.DateCreate
                .Add("@USERUPDATE", SqlDbType.NVarChar, 150).Value = BE.UserUpdate
                .Add("@DATEUPDATE", SqlDbType.DateTime).Value = BE.DateUpdate
                .Add("@IDMESSAGELAYOUT", SqlDbType.Int).Value = BE.IdMessageLayout
                .Add("@IDMESSAGESTRUCTURE", SqlDbType.Int).Value = BE.IdMessageStructure
                .Add("@IDINPUTCONFIGURATION", SqlDbType.Int).Value = BE.IdInputConfiguration
                .Add("@MESSAGETEXT", SqlDbType.VarBinary, -1).Value = BE.MessageText
                .Add("@VALIDFROM", SqlDbType.DateTime).Value = BE.ValidFrom
                .Add("@VALIDTO", SqlDbType.DateTime).Value = BE.ValidTo
                .Add("@USERCREATE", SqlDbType.NVarChar, 150).Value = BE.UserCreate
                .Add("@DATECREATE", SqlDbType.DateTime).Value = BE.DateCreate
                .Add("@USERUPDATE", SqlDbType.NVarChar, 150).Value = BE.UserUpdate
                .Add("@DATEUPDATE", SqlDbType.DateTime).Value = BE.DateUpdate
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
    Public Function Delete(ByVal strIdMessageLayout As String) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MESSAGELAYOUT_DEL01"

            With .Parameters
                .Clear()
                .Add("@IdMessageLayout", SqlDbType.Int, ).Value = strIdMessageLayout
                .Add("@IdMessageLayout", SqlDbType.Int, ).Value = strIdMessageLayout
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
    Public Function GetMessageLayout(ByVal strIdMessageLayout As String) As MessageLayoutBE
        Dim dr As SqlDataReader
        Dim MessageLayoutBE As New MessageLayoutBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MESSAGELAYOUT_GET01"

            With .Parameters
                .Clear()
                .Add("@IdMessageLayout", SqlDbType.Int, ).Value = strIdMessageLayout
                .Add("@IdMessageLayout", SqlDbType.Int, ).Value = strIdMessageLayout
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With MessageLayoutBE
                        If dr("IdMessageLayout") Is DBNull.Value Then
                            .IdMessageLayout = Nothing
                        Else
                            .IdMessageLayout = dr("IdMessageLayout")
                        End If

                        If dr("IdMessageStructure") Is DBNull.Value Then
                            .IdMessageStructure = Nothing
                        Else
                            .IdMessageStructure = dr("IdMessageStructure")
                        End If

                        If dr("IdInputConfiguration") Is DBNull.Value Then
                            .IdInputConfiguration = Nothing
                        Else
                            .IdInputConfiguration = dr("IdInputConfiguration")
                        End If

                        If dr("MessageText") Is DBNull.Value Then
                            .MessageText = Nothing
                        Else
                            .MessageText = dr("MessageText")
                        End If

                        If dr("ValidFrom") Is DBNull.Value Then
                            .ValidFrom = Nothing
                        Else
                            .ValidFrom = dr("ValidFrom")
                        End If

                        If dr("ValidTo") Is DBNull.Value Then
                            .ValidTo = Nothing
                        Else
                            .ValidTo = dr("ValidTo")
                        End If

                        If dr("UserCreate") Is DBNull.Value Then
                            .UserCreate = Nothing
                        Else
                            .UserCreate = dr("UserCreate")
                        End If

                        If dr("DateCreate") Is DBNull.Value Then
                            .DateCreate = Nothing
                        Else
                            .DateCreate = dr("DateCreate")
                        End If

                        If dr("UserUpdate") Is DBNull.Value Then
                            .UserUpdate = Nothing
                        Else
                            .UserUpdate = dr("UserUpdate")
                        End If

                        If dr("DateUpdate") Is DBNull.Value Then
                            .DateUpdate = Nothing
                        Else
                            .DateUpdate = dr("DateUpdate")
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
        Return MessageLayoutBE
    End Function
    Public Function GetMessageLayoutes() As DataTable
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MESSAGELAYOUT_GET02"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            Return dt
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function
End Class
