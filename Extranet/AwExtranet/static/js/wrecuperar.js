window.onload = function () {
    init.recoveryPassword(); 
    init.backLogin();
    init.updatePasswod();
    init.recoveryUserKeyEnter();
};
       
var init = {
    recoveryPassword : function() {
        $('#btnRecuperar').on('click', function() {
            var sEmail = $('#txtEmail').val();
             if ($.trim(sEmail) == "") {
               swal({ title: '¡Error!', text: "Por favor ingresar Email", icon: "error" });
            } else {
                let aParametro = "{'sEmail':'" + sEmail + "'}";
                $.ajax({
                    type: 'POST',
                    url: '../seguridad/wrecuperarcontrasenia.aspx/fnRecuperarContrasenia',
                    data: aParametro,
                    contentType: 'application/json; utf-8',
                    dataType: 'json',
                    async: false,
                    success: function (data) {
                        if (data.d.iTipoResultado == "1") {
                            swal({ title: '¡Exito!', text: data.d.sValor1, icon: "success" })
                            .then((value) => {
                                if (value == true) {
                                    location.href = '../wlogin.aspx';
                                }
                            });
                        } else {
                            swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                        }
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                    }

                });
            }
        })
    },
    backLogin: function () {
        $('#btnRegresar').on('click', function () {
            location.href = '../wlogin.aspx';
        })
    },
    updatePasswod: function () {
        $('#btnReset').on('click', function () {
            var email = $('#txtemail_I').val();
            var spwd1 = $('#txtpwd').val();
            var spwd2 = $('#txtpwdRepit').val();;
            if ($.trim(email) == "") {
                swal({ title: '¡Error!', text: "Link incorrecto", icon: "error" });
                return;
            } 
            if (spwd1 == "") {
                swal({ title: '¡Error!', text: "Ingrese nueva contraseña", icon: "error" });
                return;
            }
            if (spwd2 == "") {
                swal({ title: '¡Error!', text: "Repetir nueva contraseña", icon: "error" });
                return;
            }
            if (spwd2 != spwd1) {
                swal({ title: '¡Error!', text: "Las contraseñas ingresadas no coinciden", icon: "error" });
                return;
            }
            let aParametro = "{'sEmail':'" + email + "','spwd':'" + spwd1 + "'}";
            $.ajax({
                type: 'POST',
                url: '/seguridad/wrestablecercontrasenia.aspx/fnRecoveryPassword',
                data: aParametro,
                contentType: 'application/json; utf-8',
                dataType: 'json',
                async: false,
                success: function (data) {
                    swal({ title: '¡Exito!', text: data.d.sValor1, icon: "success" }).then((value) => {
                        if (value == true) {
                            location.href = '../wlogin.aspx';
                        }
                    });
                },
                error: function (jqXHR, textStatus, errorThrown) {
                }

            });
        })
    },
    recoveryUserKeyEnter: function () {
        $("#txtEmail").keypress(function (e) {
            if (e.which == 13) {
                event.preventDefault();
                $('#btnRecuperar').trigger("click");
            }
        });
    }
}