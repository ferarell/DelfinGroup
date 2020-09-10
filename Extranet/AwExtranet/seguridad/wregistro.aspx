<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wregistro.aspx.vb" Inherits="AwExtranet.wregistro1" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>Extranet | Delfin Group</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <!-- Bootstrap 3.3.7 -->
    <link rel="stylesheet" href="<%=sUrl %>static/bower_components/bootstrap/dist/css/bootstrap.min.css" />
    <!-- Font Awesome -->
    <link rel="stylesheet" href="<%=sUrl %>static/bower_components/font-awesome/css/font-awesome.min.css" />
    <!-- Ionicons -->
    <link rel="stylesheet" href="<%=sUrl %>static/bower_components/Ionicons/css/ionicons.min.css" />
    <!-- Theme style -->
    <link rel="stylesheet" href="<%=sUrl %>static/dist/css/AdminLTE.min.css" />
    <link rel="stylesheet" href="<%=sUrl %>static/css/main.css" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

</head>
<body class="hold-transition login-page" style="background-image: url('/static/img/login.jpg')">
    <div class="register-box">
        <div class="login-logo">
            <img src="<%=sUrl %>static/img/logob.png" class="img-logo-register" />
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">
                <span class="title-login">Crear cuenta</span>
                <br />
            </p>
            <form id="frmRegistro" runat="server">
                <div id="dvRegistro">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Tipo documento</label>
                                <dx:BootstrapComboBox ID="cboTipoDocumento" runat="server">
                                    <ClientSideEvents ValueChanged="function(s, e) {}" />
                                </dx:BootstrapComboBox>
                            </div>                            
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Número documento</label>
                               <dx:BootstrapTextBox ID="txtNroDocumento" runat="server" tabindex=1></dx:BootstrapTextBox>
                            </div>
                                                      
                        </div>
                        <div class="col-md-12">
                            <div class="form-group" id="businessName">
                                <label>Razón social</label>
                                <dx:BootstrapTextBox ID="txtBusinessName" runat="server" tabindex=2></dx:BootstrapTextBox>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Nombre</label>
                                <dx:BootstrapTextBox ID="txtNombre" runat="server" tabindex=3></dx:BootstrapTextBox>
                            </div> 
                            <div class="form-group">
                                <label>Email</label>
                                <dx:BootstrapTextBox ID="txtCorreo" runat="server" tabindex=5></dx:BootstrapTextBox>
                            </div>  
                            <div class="form-group">
                                <label>Área</label>
                                <dx:BootstrapTextBox ID="txtArea" runat="server" tabindex=7></dx:BootstrapTextBox>
                            </div>
                             
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label>Apellidos</label>
                               <dx:BootstrapTextBox ID="txtApellido" runat="server" tabindex=4></dx:BootstrapTextBox>
                            </div>   
                            <div class="form-group">
                                <label>Contraseña</label>
                                <dx:BootstrapTextBox ID="txtPassword" runat="server" Password="True" tabindex=6></dx:BootstrapTextBox>
                            </div>  
                            <div class="form-group">
                                <label>Teléfono</label>
                                 <dx:BootstrapTextBox ID="phone" runat="server" tabindex=8></dx:BootstrapTextBox>
                            </div>
                        </div>
                         <div class="col-md-6">
                            <div class="form-group">
                                <dx:BootstrapButton ID="btnRegresar" runat="server" AutoPostBack="false" Text="Regresar">
                                    <CssClasses Icon="fa fa-reply" Control="btn btn-default  btn-block btn-flat" />
                                </dx:BootstrapButton>
                            </div> 
                         </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <dx:BootstrapButton ID="btnRegistrar" runat="server" AutoPostBack="false" Text="Registrar">
                                    <CssClasses Control="btn btn-primary btn-block btn-flat" Icon="fa fa-floppy-o" />
                                </dx:BootstrapButton>
                            </div> 
                         </div>
                    </div>                    
                    <input type="hidden" id="hExists" name ="hExists" />
                    <input type="hidden" id="hCodeCustomer" name ="hCodeCustomer" value ="0" />
                    <input type="hidden" id="hUserType" name ="hUserType" value ="1" />
                </div>
            </form>
        </div>
         <div class="col-xs-12" style="padding-top: 5%">
            <a href="http://www.delfingroupco.com.pe/" class="link-return"><img src="../static/img/left-arrow.png" />&nbsp; Regresar a Delfin Group</a>
        </div>
    </div>
    <script src="<%=sUrl %>static/bower_components/jquery/dist/jquery.min.js"></script>
    <script src="<%=sUrl %>static/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="<%=sUrl %>static/js/sweetalert.min.js"></script>
    <script src="<%=sUrl %>static/js/wregistro.js?v=1.2"></script>
    
</body>

</html>
