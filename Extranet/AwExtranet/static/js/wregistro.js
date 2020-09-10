
window.onload = function () {
    init.backLogin();
    init.loadDataByDocument();
    init.registerUser();
    init.registerUserKeyEnter();
};

let piIdUsuario = 0;

var init = {
    backLogin: function () {
        $('#btnRegresar').on('click', function () {
            location.href = '../wlogin.aspx';
        })
    },
    loadDataByDocument: function () {
        $('#txtNroDocumento_I').on('blur', function () {
            let iTipoDocumento = $('#cboTipoDocumento_L_VI').val();
            let sNroDocumento = document.getElementById('txtNroDocumento_I').value;
            if (sNroDocumento != "") {
                let aParametro = "{'iTipoDocumento':'" + iTipoDocumento + "','sNroDocumento':'" + sNroDocumento + "'}";
                $.ajax({
                    type: 'POST',
                    url: 'wregistro.aspx/fnValidarRegistro',
                    data: aParametro,
                    contentType: 'application/json; utf-8',
                    dataType: 'json',
                    async: false,
                    success: function (data) {
                        $('#hExists').val(data.d.iTipoResultado);
                        $('#txtBusinessName_I').val(data.d.sValor1);
                        if (data.d.sValor2 > 0) {
                            $('#hCodeCustomer').val(data.d.sValor2);
                        }
                        $('#hUserType').val(data.d.nValor1);
                    },
                    error: function (jqXHR, textStatus, errorThrown) {

                    }

                });
            }            
        });
    },
    changeDocument: function () {
        var typeDocument = $('#cboTipoDocumento_I').val();
        $('#businessName').css('display', 'block');
        if (typeDocument != 'RUC') {
            $('#businessName').css('display', 'none');
        } 
    },
    registerUser: function () {
        $('#btnRegistrar').on('click', function () {
            let iTipoDocumento = $('#cboTipoDocumento_L_VI').val();
            let sNroDocumento = document.getElementById('txtNroDocumento_I').value;
            let sNombre = document.getElementById('txtNombre_I').value;
            let sApellidos = document.getElementById('txtApellido_I').value;
            let sCorreo = document.getElementById('txtCorreo_I').value;
            let sArea = document.getElementById('txtArea_I').value;
            let sPassword = document.getElementById('txtPassword_I').value;
            let sBusinessName = document.getElementById('txtBusinessName_I').value;
            let hCodeCustomer = document.getElementById('hCodeCustomer').value;
            let sphone = document.getElementById('phone_I').value;
            let iUserType = document.getElementById('hUserType').value;

            if (iTipoDocumento == 0) {
                swal({ title: '¡Error!', text: "Por favor seleccionar el Tipo de Documento", icon: "error" });
                return;
            }
            if (sNroDocumento == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese el Nro Ddocumento", icon: "error" });
                return;
            }
            if (sNombre == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese Nombres", icon: "error" });
                return;
            }
            if (sApellidos == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese Apellidos", icon: "error" });
                return;
            }
            if (sCorreo == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese Correo", icon: "error" });
                return;
            }
            if (sPassword == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese el Password", icon: "error" });
                return;
            }

            if (sBusinessName == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese la razon social de su empresa", icon: "error" });
                return;
            }

            if (sphone == "") {
                swal({ title: '¡Error!', text: "Por favor ingrese número de contacto", icon: "error" });
                return;
            }

            var isExists = $('#hExists').val();

            let aParametro = "{'iIdUsuario':'" + piIdUsuario + "','iTipoDocumento':'" + iTipoDocumento + "','sNroDocumento':'" + sNroDocumento +
                "','sNombre':'" + sNombre + "','sApellidos':'" + sApellidos + "','sCorreo':'" + sCorreo +
                "','sArea':'" + sArea + "','isExists':" + isExists + ",'sPassword':'" + sPassword + "','sBusinessName':'" + sBusinessName + "','sCodeCustomer':" + hCodeCustomer + ",'sphone':'" + sphone + "', 'iUserType':" + iUserType+"}";

            $.ajax({
                type: 'POST',
                url: 'wregistro.aspx/fnRegistro',
                data: aParametro,
                contentType: 'application/json; utf-8',
                dataType: 'json',
                async: false,
                success: function (data) {
                    if (data.d.iTipoResultado == "1") {
                        swal({ title: '¡Exito!', text: data.d.sMensajeError, icon: "success" });
                    } else if (data.d.iTipoResultado == 3) {
                        swal({ title: '¡Advertencia!', text: data.d.sMensajeError, icon: "warning" });
                    } else {
                        swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                    }
                    $('.swal-button--confirm').on('click', function () {
                        location.href = "../wlogin.aspx"
                    });
                },
                error: function (jqXHR, textStatus, errorThrown) {
                }

            });
        });
    },
    registerUserKeyEnter: function () {
        $("#txtPassword_I").keypress(function (e) {
            if (e.which == 13) {
                event.preventDefault();
                $('#btnRegistrar').trigger("click");
            }
        });
    }
};
