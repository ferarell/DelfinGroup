Public Class Class1

    Function GetNewText(OldText As String) As String
        Dim NewText As String = """"

        OldText = "[{""tipoContenedor"":""40ST"",""cantidadTipoContenedor"":""2.0000""}]}"

        For c = 1 To OldText.Length
            If Mid(OldText, c, 1) <> """" Then
                NewText += Mid(OldText, c, 1)
            End If
            If Mid(OldText, c, 1) = "]" Then
                NewText += Mid(OldText, c, 1) & """"
            End If
        Next

        Return NewText

    End Function


End Class
