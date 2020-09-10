window.onload = function () {
    init.fnDestroySession();
    init.fnLogin();
    document.getElementById('txtPassword').addEventListener("keypress", function (e) {
        if (event.keyCode === 13) {
            $('.btn-login').trigger('click');
        }
    });
}
var bloqued = 0;
var init = {
    fnLogin: function () {
        $('.btn-login').on('click', function () {
            let sEmail = document.getElementById('txtEmail').value;
            let sPassword = document.getElementById('txtPassword').value;
            if (sEmail == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese un Email", icon: "error" });
                return;
            }
            if (sPassword == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese un Password", icon: "error" });
                return;
            }

            let aParametro = "{'sEmail':'" + sEmail + "','sPassword':'" + sPassword + "'}";
            $.ajax({
                type: 'POST',
                url: 'wlogin.aspx/fnValidarLogin',
                data: aParametro,
                contentType: 'application/json; utf-8',
                dataType: 'json',
                async: false,
                success: function (data) {
                    if (data.d.iTipoResultado == 1) {
                        location.href = "winicio.aspx";
                    } else {
                        if (data.d.iTipoResultado == 2 || data.d.iTipoResultado == 3) {
                            swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                        } else {
                            if (data.d.iTipoResultado == 4 && bloqued < 6) {
                                bloqued++;
                                swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                            }
                            if (bloqued == 5) {
                                init.fnBlockUser(sEmail);
                            }
                        }
                                            
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                }

            });
        });
    },
    fnDestroySession: function () {
        let aParametro = "{'sVacio':'sVacio'}";
        $.ajax({
            type: 'POST',
            url: 'wlogin.aspx/fnDestruirSession',
            data: aParametro,
            contentType: 'application/json; utf-8',
            dataType: 'json',
            async: false,
            success: function (data) {
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }

        });
    },
    fnBlockUser: function (sEmail) {
        let aParametro = "{'sEmail':'" + sEmail + "'}";
        $.ajax({
            type: 'POST',
            url: 'wlogin.aspx/fnBlockUser',
            data: aParametro,
            contentType: 'application/json; utf-8',
            dataType: 'json',
            async: false,
            success: function (data) {
                if (data.d.iTipoResultado == "1") {
                    swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                } 
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }

        });
    }

}