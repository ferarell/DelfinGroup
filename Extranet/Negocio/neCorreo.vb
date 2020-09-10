Imports System.Configuration
Imports System.Net
Imports System.Net.Mail
Imports System.Text

Public Class neCorreo

    Public Sub EnviarCorreo(ByVal sMaildestino As String, ByVal sAsuntoCorreo As String, ByVal sMensaje As String)
        Dim mmsg As MailMessage = New MailMessage()
        Dim MailSender As String = "webmaster@delfingroupco.com.pe"
        Dim sCorreEnvio As String = ConfigurationManager.AppSettings("CorreoEnvio").ToString()
        Dim sCorrePWD As String = ConfigurationManager.AppSettings("CorreoPWD").ToString()
        Dim sCorreHost As String = ConfigurationManager.AppSettings("CorreoHost").ToString()
        Dim sCorrePort As String = ConfigurationManager.AppSettings("CorreoPort").ToString()
        Dim sCorreSsl As Boolean = ConfigurationManager.AppSettings("CorreoSsl")

        mmsg.[To].Add(sMaildestino)
        mmsg.Subject = sAsuntoCorreo
        mmsg.SubjectEncoding = Encoding.UTF8
        mmsg.Body = sMensaje
        mmsg.BodyEncoding = Encoding.UTF8
        mmsg.IsBodyHtml = True
        mmsg.From = New MailAddress(MailSender, "WebMaster Delfin Group")
        mmsg.ReplyToList.Add(New System.Net.Mail.MailAddress(MailSender, "WebMaster Delfin Group"))
        Dim cliente As SmtpClient = New SmtpClient()
        cliente.Credentials = New NetworkCredential(sCorreEnvio, sCorrePWD)
        cliente.Host = sCorreHost
        cliente.Port = sCorrePort
        cliente.EnableSsl = sCorreSsl

        Try
            cliente.Send(mmsg)
        Catch ex As SmtpException
            Throw ex
        End Try
    End Sub

    Public Function bodyEmail(ByVal iTipoDocumento As Integer, sNroDocumento As String, sNombre As String, sApellidos As String, sCorreo As String, sArea As String, type As Integer, sPassword As String, sBusinessName As String, slink As String) As String
        'type:1 => Registro exitoso
        'type:2 => Solicitud de registro
        'type:3 => Recuperar contraseña
        Dim title As String = ""
        Select Case type
            Case 1
                title = "Correo de Confirmación (Extranet)"
            Case 2
                title = "SOLICITUD DE REGISTRO"
            Case 3
                title = "RECUPERAR CONTRASE&Ntilde;A"
            Case 4
                title = "Cuenta Bloqueada"
            Case Else
                title = ""
        End Select

        Dim message As String = "<!doctype html>
                                    <html xmlns='http://www.w3.org/1999/xhtml' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:o='urn:schemas-microsoft-com:office:office'>

                                    <head>
                                        <title></title>
                                        <meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>
                                        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                                        <style type='text/css'>
                                            #outlook a {
                                                padding: 0;
                                            }

                                            .ReadMsgBody {
                                                width: 100%;
                                            }

                                            .ExternalClass {
                                                width: 100%;
                                            }

                                            .ExternalClass * {
                                                line-height: 100%;
                                            }

                                            body {
                                                margin: 0;
                                                padding: 0;
                                                -webkit-text-size-adjust: 100%;
                                                -ms-text-size-adjust: 100%;
                                            }

                                            table,
                                            td {
                                                border-collapse: collapse;
                                                mso-table-lspace: 0pt;
                                                mso-table-rspace: 0pt;
                                            }

                                            img {
                                                border: 0;
                                                height: auto;
                                                line-height: 100%;
                                                outline: none;
                                                text-decoration: none;
                                                -ms-interpolation-mode: bicubic;
                                            }

                                            p {
                                                display: block;
                                                margin: 13px 0;
                                            }
                                        </style>
                                        <style type='text/css'>
                                            @media only screen and (max-width:480px) {
                                                @-ms-viewport {
                                                    width: 320px;
                                                }
                                                @viewport {
                                                    width: 320px;
                                                }
                                            }
                                        </style>
   
                                        <link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet' type='text/css'>
                                        <style type='text/css'>
                                            @import url(https://fonts.googleapis.com/css?family=Montserrat);
                                        </style>
    
                                        <style type='text/css'>
                                            @media only screen and (min-width:480px) {
                                                .mj-column-per-100 {
                                                    width: 100%!important;
                                                }
                                            }
                                        </style>
                                    </head>

                                    <body>

                                    <div class='mj-container'>
    
                                        <div style='margin:0px auto;max-width:600px;'>
                                            <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;background:#ffffff;' align='center' border='0' >
                                                <tbody>
                                                    <tr>
                                                        <td >
                                                            <img alt='' title='' height='auto' src='http://apps.delfingroupco.com.pe:50443/comunicados/template/headTemplate1.jpg' style='border:none;border-radius:0px;display:block;font-size:13px;outline:none;text-decoration:none;width:600px;height:auto;'>
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                        <div style='margin:0px auto;max-width:600px;background:#ffffff;'>
                                            <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;background:#ffffff;' align='center' border='0'>
                                                <tbody>
                                                <tr>
                                                    <td style='text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:20px 0px;padding-bottom:0px;'>
                   
                                                        <div class='mj-column-per-100 outlook-group-fix' style='vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;'>
                                                            <table role='presentation' cellpadding='0' cellspacing='0' width='100%' border='0'>
                                                                <tbody>
                                                                <tr>
                                                                    <td style='word-wrap:break-word;font-size:0px;padding:10px 45px;' align='center'>
                                                                        <div style='cursor:auto;color:#01213a;font-family:Arial;font-size:20px;line-height:35px;text-align:left;font-weight:700'>" + title + "</div>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style='word-wrap:break-word;font-size:0px;padding:10px 25px;padding-top:15px;padding-bottom:0px;padding-right:0px;padding-left:0px;'>
                                                                        <p style='font-size:1px;margin:0px auto;border-top:1px solid #f8f8f8;width:100%;'></p>
                                                                    </td>
                                                                </tr>
                                                                </tbody>
                                                            </table>
                                                        </div>
                                                    </td>
                                                </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                        <div style='margin:0px auto;max-width:600px;background:#ffffff;'>
                                            <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;background:#ffffff;' align='center' border='0'>
                                                <tbody>
                                                <tr>
                                                    <td style='text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:20px 0px;padding-bottom:0px;padding-top:0px;'>
                   
                                                        <div class='mj-column-per-100 outlook-group-fix' style='vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;'>
                                                            <table role='presentation' cellpadding='0' cellspacing='0' width='100%' border='0'>
                                                                <tbody>
                                                                <tr>
                                                                    <td style='word-wrap:break-word;font-size:0px;padding:10px 45px;' align='left'>
                                                                        <div style='cursor:auto;color:#5f676b;font-family:Helvetica,Arial,sans-serif;font-size:14px;font-weight:300;line-height:22px;text-align:left;'>"
        If (type = 1) Then
            message += "<p>" + sNombre + ", se ha creado una cuenta para usted. Para acceder de forma segura a su cuenta.<br><br>
                            Inicie sesi&oacute;n con el siguiente nombre de usuario y contrase&ntilde;a:
                        </p>
                        <p>
                            <b>Nombre de usuario:</b> " + sCorreo + "<br>
                            <b>Contrase&ntilde;a:</b> " + sPassword + "
                        </p>
                        <p>Ingresar al siguiente link para activar la cuenta: http://apps.delfingroupco.com.pe:50443/seguridad/wactivarcuenta.aspx?e=" + sCorreo + "</p>
                        No dude en contactarnos si necesita ayuda.<br><br>
                        <b>Delfin Group Co.</b><br>
                        webmaster@delfingroupco.com.pe<br>
                        (051) 615-3535"
        End If
        If (type = 2) Then
            Dim typeDocument As String = ""
            Select Case iTipoDocumento
                Case "001"
                    typeDocument = "RUC"
                Case "002"
                    typeDocument = "DNI"
                Case "003"
                    typeDocument = "PASAPORTE"
                Case "004"
                    typeDocument = "SIN RUC"
                Case "005"
                    typeDocument = "OTROS"
                Case Else
                    typeDocument = ""
            End Select
            message += "<table class='content'>
                            <tr>
                                <td>Tipo Documento:</td>
                                <td>" + typeDocument + "</td>
                            </tr>
                            <tr>
                                <td>N&uacute;mero Documento:</td>
                                <td>" + sNroDocumento + "</td>
                            </tr>
                            <tr>
                                <td>Raz&oacute;n Social:</td>
                                <td>" + sBusinessName + "</td>
                            </tr>
                            <tr>
                                <td>Nombre(s):</td>
                                <td>" + sNombre + "</td>
                            </tr>
                            <tr>
                                <td>Apellidos(s):</td>
                                <td>" + sApellidos + "</td>
                            </tr>
                            <tr>
                                <td>Correo:</td>
                                <td>" + sCorreo + "</td>
                            </tr>
                            <tr>
                                <td>&Aacute;rea:</td>
                                <td>" + sArea + "</td>
                            </tr>
                        </table>"
        End If
        If (type = 3) Then
            message += " <p>Para recuperar su contraseña por favor ingresar al siguiente link: <a href='" + slink + "?e=" + sCorreo + "'>" + slink + "?e=" + sCorreo + "</a></p>    
                            No dude en contactarnos si necesita ayuda.<br><br>
                            <b>Delfin Group Co.</b><br>
                            webmaster@delfingroupco.com.pe<br>
                            (051) 615-3535"
        End If

        If (type = 4) Then
            message += " <p>La cuenta " + sCorreo + " ha sido bloqueada el día " + DateTime.Now.ToShortDateString() + " a las " + DateTime.Now.ToShortTimeString() + "</p>"
        End If

        message += "                </div>
                                </td>
                            </tbody>
                        </table>
                    </div>
                </td>
            </tr>
            </tbody>
        </table>
    </div>
    
    <div style='margin:0px auto;max-width:600px;background:#FFFFFF;'>
        <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;background:#FFFFFF;' align='center' border='0'>
            <tbody>
            <tr>
                <td style='text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:0px;'>
                   
                    <div class='mj-column-per-100 outlook-group-fix' style='vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;'>
                        <table role='presentation' cellpadding='0' cellspacing='0' width='100%' border='0'>
                            <tbody>
                            <tr>
                                <td style='word-wrap:break-word;font-size:0px;padding:10px 25px;' align='center'>
                                    <div style='cursor:auto;color:#5f676b;font-family:Helvetica,Arial,sans-serif;font-size:14px;font-weight:300;line-height:22px;text-align:center;'></div>
                                </td>
                            </tr>
                            </tbody>
                        </table>
                    </div>
                </td>
            </tr>
            </tbody>
        </table>
    </div>
    <div style='margin:0px auto;max-width:600px;background:#fafafb;'>
        <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;' align='center' border='0'>
            <tbody>
            <tr>
                <td style='text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:20px 0px;'>
                  
                    <div class='mj-column-per-100 outlook-group-fix' style='vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;font-family:Helvetica;'>
                        <img alt='' title='' height='auto' src='http://apps.delfingroupco.com.pe:50443/seguridad/mailing/footer.jpg' style='border:none;border-radius:0px;display:block;font-size:13px;outline:none;text-decoration:none;width:600px;height:auto;'>
                    </div>
                </td>
            </tr>
            </tbody>
        </table>
    </div>
</html>"
        Return message
    End Function

    Public Function bodyEmailVinculacion(ByVal code As String, ByVal codigoVinculada As String, ByVal contact As String, ByVal email As String, ByVal typeBonding As String, ByVal validityRate As String, ByVal dateStart As String, ByVal dateEnd As String) As String

        Dim title As String = "Solicitud de Vinculación de Empresa"
        Dim typeBondingString As String = "Agente Aduana"
        Dim validityRateString As String = "Limitada"

        If (typeBonding = "001") Then
            typeBondingString = "Empresa Relacionada"
        End If

        If (validityRate = "001") Then
            validityRateString = "Permanente"
        End If

        Dim message As String = "<!doctype html>
                                    <html xmlns='http://www.w3.org/1999/xhtml' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:o='urn:schemas-microsoft-com:office:office'>
                                    <head>
                                        <title></title>
                                        <meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>
                                        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                                        <style type='text/css'>
                                            #outlook a {
                                                padding: 0;
                                            }

                                            .ReadMsgBody {
                                                width: 100%;
                                            }

                                            .ExternalClass {
                                                width: 100%;
                                            }

                                            .ExternalClass * {
                                                line-height: 100%;
                                            }

                                            body {
                                                margin: 0;
                                                padding: 0;
                                                -webkit-text-size-adjust: 100%;
                                                -ms-text-size-adjust: 100%;
                                            }

                                            table,
                                            td {
                                                border-collapse: collapse;
                                                mso-table-lspace: 0pt;
                                                mso-table-rspace: 0pt;
                                            }

                                            img {
                                                border: 0;
                                                height: auto;
                                                line-height: 100%;
                                                outline: none;
                                                text-decoration: none;
                                                -ms-interpolation-mode: bicubic;
                                            }

                                            p {
                                                display: block;
                                                margin: 13px 0;
                                            }
                                        </style>
                                        <style type='text/css'>
                                            @media only screen and (max-width:480px) {
                                                @-ms-viewport {
                                                    width: 320px;
                                                }
                                                @viewport {
                                                    width: 320px;
                                                }
                                            }
                                        </style>

                                        <link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet' type='text/css'>
                                        <style type='text/css'>
                                            @import url(https://fonts.googleapis.com/css?family=Montserrat);
                                        </style>

                                        <style type='text/css'>
                                            @media only screen and (min-width:480px) {
                                                .mj-column-per-100 {
                                                    width: 100%!important;
                                                }
                                            }
                                        </style>
                                    </head>
                                    <body>
                                        <div class='mj-container'>
                                            <div style='margin:0px auto;max-width:600px;'>
                                                <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;background:#ffffff;' align='center' border='0' >
                                                    <tbody>
                                                        <tr>
                                                            <td >
                                                                <img alt='' title='' height='auto' src='http://apps.delfingroupco.com.pe:50443/comunicados/template/headTemplate1.jpg' style='border:none;border-radius:0px;display:block;font-size:13px;outline:none;text-decoration:none;width:600px;height:auto;'>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                            <div style='margin:0px auto;max-width:600px;background:#ffffff;'>
                                                <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;background:#ffffff;' align='center' border='0'>
                                                    <tbody>
                                                    <tr>
                                                        <td style='text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:20px 0px;padding-bottom:0px;'>

                                                            <div class='mj-column-per-100 outlook-group-fix' style='vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;'>
                                                                <table role='presentation' cellpadding='0' cellspacing='0' width='100%' border='0'>
                                                                    <tbody>
                                                                    <tr>
                                                                        <td style='word-wrap:break-word;font-size:0px;padding:10px 45px;' align='center'>
                                                                            <div style='cursor:auto;color:#01213a;font-family:Arial;font-size:20px;line-height:35px;text-align:left;font-weight:700'>" + title + "</div>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style='word-wrap:break-word;font-size:0px;padding:10px 25px;padding-top:15px;padding-bottom:0px;padding-right:0px;padding-left:0px;'>
                                                                            <p style='font-size:1px;margin:0px auto;border-top:1px solid #f8f8f8;width:100%;'></p>
                                                                        </td>
                                                                    </tr>
                                                                    </tbody>
                                                                </table>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                            <div style='margin:0px auto;max-width:600px;background:#ffffff;'>
                                                <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;background:#ffffff;' align='center' border='0'>
                                                    <tbody>
                                                        <tr>
                                                            <td style='text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:20px 0px;padding-bottom:0px;padding-top:0px;'>

                                                                <div class='mj-column-per-100 outlook-group-fix' style='vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;'>
                                                                    <table role='presentation' cellpadding='0' cellspacing='0' width='100%' border='0'>
                                                                        <tbody>
                                                                            <tr>
                                                                                <td style='word-wrap:break-word;font-size:0px;padding:10px 45px;' align='left'>
                                                                                    <div style='cursor:auto;color:#5f676b;font-family:Helvetica,Arial,sans-serif;font-size:14px;font-weight:300;line-height:22px;text-align:left;'>
                                                                                    <table Class='content'>
                                                                                            <tr>
                                                                                                <td> Empresa Principal:</td>
                                                                                                <td>" + code + "</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td> Empresa Vinculada:</td>
                                                                                                <td>" + codigoVinculada + "</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td> Nombre Contacto:</td>
                                                                                                <td>" + contact + "</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td> Correo Contacto:</td>
                                                                                                <td>" + email + "</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td> Tipo Vinculación:</td>
                                                                                                <td>" + typeBondingString + "</td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td> Tipo Vigencia:</td>
                                                                                                <td>" + validityRateString + "</td>
                                                                                            </tr>"
                                                                                            If validityRate = "002" Then
                                                                                                message += "<tr>
                                                                                                                <td>Vigencia Desde: </td>
                                                                                                                <td>" + dateStart + "</td>
                                                                                                            </tr>
                                                                                                            <tr>
                                                                                                                <td>Vigencia Hasta: </td>
                                                                                                                <td>" + dateEnd + "</td>
                                                                                                            </tr>"
                                                                                            End If
        message += "</table>
                                                                                    </div>
                                                                                </td>
                                                                            </tr>
                                                                        </tbody>
                                                                    </table>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>

                                            <div style ='margin:0px auto;max-width:600px;background:#FFFFFF;'>
                                                <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;background:#FFFFFF;' align='center' border='0'>
                                                    <tbody>
                                                        <tr>
                                                            <td style='text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:0px;'>

                                                                <div class='mj-column-per-100 outlook-group-fix' style='vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;'>
                                                                    <table role='presentation' cellpadding='0' cellspacing='0' width='100%' border='0'>
                                                                        <tbody>
                                                                            <tr>
                                                                                <td style='word-wrap:break-word;font-size:0px;padding:10px 25px;' align='center'>
                                                                                    <div style='cursor:auto;color:#5f676b;font-family:Helvetica,Arial,sans-serif;font-size:14px;font-weight:300;line-height:22px;text-align:center;'></div>
                                                                                </td>
                                                                            </tr>
                                                                        </tbody>
                                                                    </table>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                            <div style ='margin:0px auto;max-width:600px;background:#fafafb;'>
                                                <table role='presentation' cellpadding='0' cellspacing='0' style='font-size:0px;width:100%;' align='center' border='0'>
                                                    <tbody>
                                                        <tr>
                                                            <td style='text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:20px 0px;'>

                                                                <div class='mj-column-per-100 outlook-group-fix' style='vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;font-family:Helvetica;'>
                                                                    <img alt='' title='' height='auto' src='http://apps.delfingroupco.com.pe:50443/seguridad/mailing/footer.jpg' style='border:none;border-radius:0px;display:block;font-size:13px;outline:none;text-decoration:none;width:600px;height:auto;'>
                                                            </div>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </body>
                            </html>"
        Return message
    End Function

    Public Function bodyEmailDireccionamiento(ByVal businessName As String, ByVal HBL As String, ByVal currentDeposit As String, ByVal email As String, ByVal depositRequested As String, ByVal state As String) As String

        Dim title As String = "Solicitud de Direccionamiento de Carga"

        Dim message As String = "<html>
                    <head>
                        <style>
                            .titleMail {
                                font-weight: bold;
                                text-align: center;
                                font-family: Arial, Helvetica, sans-serif;
                                font-size: 18px;
                            }
                            .bodyMail {
                                font-size: 16px;
                                font-family: Arial, Helvetica, sans-serif;
                                text-align: justify;
                                padding: 5%;
                                line-height: 18pt;
                            }
                            img {
                                width: 100%;
                            }
                            .centerTable {
                                margin-top: -200px;
                                margin-left: -450px;
                                left: 50%;
                                top: 50%;
                                position: absolute;
                            }
                        </style>
                    </head>
                    <body>
                        <div class='centerTable'>
                            <table style='width: 50%;'>
                                <tr>
                                    <td><img src='http://apps.delfingroupco.com.pe:50443/seguridad/mailing/headInformationImportant.jpg'></td>
                                </tr>
                                <tr>
                                    <td class='titleMail'>" + title + "</td>
                                </tr>
                                <tr>
                                    <td class='bodyMail'>"

        message += "<table class='content'>
                            <tr>
                                <td>Empresa:</td>
                                <td>" + businessName + "</td>
                            </tr>
                            <tr>
                                <td>HBL:</td>
                                <td>" + HBL + "</td>
                            </tr>
                            <tr>
                                <td>Depósito actual:</td>
                                <td>" + currentDeposit + "</td>
                            </tr>
                            <tr>
                                <td>Correo solicitante:</td>
                                <td>" + email + "</td>
                            </tr>
                            <tr>
                                <td>Deposito solicitado:</td>
                                <td>" + depositRequested + "</td>
                            </tr>
                            <tr>
                                <td>Estado:</td>
                                <td>" + state + "</td>
                            </tr>"

        message += "</table>"
        message += "</td></tr><tr><td>&nbsp;</td></tr><tr><td><img src='http://apps.delfingroupco.com.pe:50443/seguridad/mailing/footer.jpg'></td></tr></table></div></body></html>"
        Return message
    End Function

End Class
