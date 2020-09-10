<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wrestablecercontrasenia.aspx.vb" Inherits="AwExtranet.wrestablecercontrasenia" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Administrador | Delfin Group</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- Bootstrap 3.3.7 -->
    <link rel="stylesheet" href="<%=sUrl %>static/bower_components/bootstrap/dist/css/bootstrap.min.css">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="<%=sUrl %>static/bower_components/font-awesome/css/font-awesome.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="<%=sUrl %>static/bower_components/Ionicons/css/ionicons.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="<%=sUrl %>static/dist/css/AdminLTE.min.css">
    <link rel="stylesheet" href="<%=sUrl %>static/css/main.css">
</head>
<body class="hold-transition login-page" style="background-image: url('/static/img/login.jpg')">
    <div class="login-box">
        <div class="login-logo">
            <img src="/static/img/logob.png" class="img-logo">
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">
                <span class="title-login">Restablecer Contraseña</span>
            </p>
            <form id="form1" runat="server">
                <div class="form-group has-feedback">
                    <dx:BootstrapTextBox ID="txtemail" runat="server" ReadOnly="True"></dx:BootstrapTextBox>
                    <span class="form-control-feedback"><img src="../static/img/mail.png"></span>
                </div>
                <div class="form-group has-feedback">
                    <input id="txtpwd" type="password" class="form-control" placeholder="Ingrese contraseña" maxlength="50" />
                    <span class="form-control-feedback"><img src="../static/img/candado.png"></span>
                </div>
                <div class="form-group has-feedback">
                    <input id="txtpwdRepit" type="password" class="form-control" placeholder="Repetir contraseña" maxlength="50" />
                    <span class="form-control-feedback"><img src="../static/img/candado.png"></span>
                </div>
                <div class="row">
                    <div class="col-xs-6">
                        <dx:BootstrapButton ID="btnRegresar" runat="server" AutoPostBack="false" Text="Cancelar">
                            <CssClasses  Control="btn btn-default  btn-block btn-flat" />
                        </dx:BootstrapButton>
                    </div>
                    <div class="col-xs-6">
                        <dx:BootstrapButton ID="btnReset" runat="server" AutoPostBack="false" Text="Actualizar">
                            <CssClasses Control="btn btn-primary btn-block btn-flat" />
                        </dx:BootstrapButton>
                    </div>
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
    <script src="<%=sUrl %>static/js/wrecuperar.js?v=1.2"></script>
</body>
</html>
