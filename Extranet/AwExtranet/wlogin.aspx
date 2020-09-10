<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wlogin.aspx.vb" Inherits="AwExtranet.wlogin" %>


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
<body class="hold-transition login-page" style="background-image: url('static/img/login.jpg')">
    <div class="login-box">
        <div class="login-logo">
            <img src="static/img/logob.png" class="img-logo">
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">
                <span class="title-login">Iniciar sesión</span>
            </p>
            <form id="form1" runat="server">
                <div class="form-group has-feedback">
                    <label>Email</label>
                    <input id="txtEmail" type="text" class="form-control" placeholder="Ejemplo: demo@delfingroup.com" maxlength="50" />
                    <span class="form-control-feedback"><img src="static/img/mail.png"></span>
                </div>
                <div class="form-group has-feedback">
                    <label>Contraseña</label>
                    <input id="txtPassword" type="password" class="form-control" placeholder="" maxlength="20" />
                    <span class="form-control-feedback">
                        <img src="static/img/candado.png"></span>
                </div>
                <div class="row">
                    <div class="col-xs-12">
                        <a href="#" class="btn btn-primary btn-block btn-flat btn-login">Iniciar sesi&oacute;n</a>
                    </div>
                    <div class="col-xs-6" style="padding-top: 5%">
                        <a href="<%=sUrl %>seguridad/wrecuperarcontrasenia.aspx">Restablecer contraseña</a>
                    </div>
                    <div class="col-xs-6" style="padding-top: 5%; text-align: right">
                        <a href="<%=sUrl %>seguridad/wregistro.aspx">Crear cuenta</a>
                    </div>
                </div>
            </form>
        </div>
         <div class="col-xs-12" style="padding-top: 5%">
            <a href="http://www.delfingroupco.com.pe/" class="link-return"><img src="static/img/left-arrow.png" />&nbsp; Regresar a Delfin Group</a>
        </div>
    </div>
    <script src="<%=sUrl %>static/bower_components/jquery/dist/jquery.min.js"></script>
    <script src="<%=sUrl %>static/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="<%=sUrl %>static/js/sweetalert.min.js"></script>
    <script src="<%=sUrl %>static/js/wlogin.js?v=1.2"></script>
</body>
</html>
