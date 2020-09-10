<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wactivarcuenta.aspx.vb" Inherits="AwExtranet.wactivarcuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <script src="/static/bower_components/jquery/dist/jquery.min.js"></script>
    <script>
        var init = {
            fnActiveAccount: function () {
                var url = window.location;
                var urlSegment = url.href.split('=');
                var sEmail = urlSegment[urlSegment.length - 1];

                let aParametro = "{'sEmail':'" + sEmail + "'}";
                $.ajax({
                    type: 'POST',
                    url: 'wactivarcuenta.aspx/fnActiveAccount',
                    data: aParametro,
                    contentType: 'application/json; utf-8',
                    dataType: 'json',
                    async: false,
                    success: function (data) {
                        if (data.d.iTipoResultado == "1") {
                            location.href="/wlogin.aspx";
                        } 
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                    }

                });
            }
        }
        init.fnActiveAccount();
    </script>
</body>
</html>
