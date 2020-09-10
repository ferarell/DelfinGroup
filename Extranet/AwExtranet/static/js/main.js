var url = window.location;
var urlSegment = url.href.split('/');
var page = urlSegment[urlSegment.length - 1];
var element = '';
var aoa = [];

$(function () {
    master.calendarAutorizacion();
    master.loadOptionMenu();
    $('#ContentPlaceHolder1_contentBody').summernote({
        height: 150,   //set editable area's height
        toolbar: [
            ['style', ['style']],
            ['font', ['bold', 'underline', 'clear']],
            ['color', ['color']],
            ['para', ['ul', 'ol', 'paragraph']],
            ['table', ['table']],
            ['insert', ['link', 'video']]
        ],
        codemirror: { // codemirror options
            theme: 'monokai'
        }
    });
});
var loadD = 0;

var master =  {
    obtenerURL: function () { //Funcion para agregar clase active en el menú        
        page = page.split('?');
        console.log(page);
        switch (page[0]) {
            case 'wactualizardatos.aspx':
                element = 'perfil';
                break;
            case 'consultarCotizacion.aspx':
                element = 'consultar-cotizacion';
                break;
            case 'solicitud-de-autorizaciones.aspx':
                element = 'solicitud-autorizaciones';
                break;
            case 'solicitud-de-autorizaciones.aspx':
            case 'solicitud-de-autorizaciones-registro.aspx':
                element = 'solicitud-autorizaciones';
                break;
            case 'direccionamiento-cargas.aspx':
                element = 'direccionamiento-carga';
                master.loadDireccionamiento();
                master.loadFormDireccionamiento();
                               
                var param = page[1];
                if (param != undefined && param != "") {
                    console.log(param);
                    param = param.split('&');
                    var code = param[0].substring(2);
                    var name = param[1].substring(5);
                    name = name.replace('_', ' ');
                    $('#ContentPlaceHolder1_client_I').val(name);
                    $('#ContentPlaceHolder1_client_VI').val(code);
                }
                
                window.setTimeout(function () {
                    $("#ContentPlaceHolder1_search").trigger("click");
                }, 100);                
                break;
            case 'direccionamiento-carga-registro.aspx':
                element = 'direccionamiento-carga';
                master.cancelDireccionamiento();
                master.saveDireccionamito();
                master.loadHBL();
                window.setTimeout(function () {
                    $('#ContentPlaceHolder1_depositoI_I').attr('disabled', true);
                }, 100);                
                break;
            case 'gestion-de-autorizaciones.aspx':
                element = 'gestion-autorizaciones';
                break;
            case 'facturacion-electronica.aspx':
                element = 'facturacion-electronica';
                master.loadPlaceHolder();
                master.listBillingByCustomer();
                master.exportExcel(element);
                break;
            case 'listado_vinculacion_empresa.aspx':
                element = 'vinculacion-empresa';
                master.listRelatedCompany();
                break;
            case  'vinculacion_empresa_registro.aspx':
                element = 'vinculacion-empresa';
                master.saveRelatedCompany();
                master.returnList();
                master.loadDataByDocument();
                break;
            case 'wconsultardeudad.aspx':
                element = 'deuda-cliente';
                master.searchHBLByCustomerBill();
                master.exportExcel('wconsultardeudad');
                break;
            case 'estado-hbl.aspx':
                element = 'estado-hbl';
                master.searchHblByCustomer();
                master.exportPDFValid();
                master.exportPDF();
                break;
            case 'consultar-aviso-de-llegada-salida.aspx':
                element = 'aviso-llegada';
                master.validHBLByAviso();
                var urlPDF = $('#ContentPlaceHolder1_hdPdfAviso_I').val();
                if (urlPDF != "") {
                    $('#ifPdfAviso').attr('src', urlPDF);
                    $('.aviso-llegada').css("display", "block");
                } 
                break;
            case 'comunicados.aspx':
                element = 'comunicados';
                master.selectTemplate();
                master.sendMail();
                master.load();
                break;
            case 'estado-cuenta.aspx':
                element = 'estado-cuenta';
                master.customerDebt();
                master.exportcustomerDebt();
                break;
            case 'seguimiento-operativo.aspx':
                element = 'seguimiento-operativo';
                master.seguiemiento();
                break;
        }
        if (element != '') {
            $('.sidebar-menu>li[data-title*=' + element + ']').addClass('active');
        }
    },
    menuResponsive: function () {
        $('.sidebar-toggle').on('click', function () {
            if ($('.sidebar-collapse').length > 0) {
                $('.menu-texto-doble-linea').css("float", "left");
                $('.menu-texto-doble-linea').css("margin-top", "-25px");
                $('.menu-texto-doble-linea').css("margin-left", "24px");
            } else {
                $('.menu-texto-doble-linea').css("float", "");
                $('.menu-texto-doble-linea').css("margin-left", "");
            }
        });
    },
    calendarAutorizacion: function () {
        $('#ContentPlaceHolder1_dateInit_I').datepicker({
            autoclose: true,
            format: "dd/mm/yyyy"
        });
        $('#ContentPlaceHolder1_dataEnd_I').datepicker({
            autoclose: true,
            format: "dd/mm/yyyy"
        });
    },
    searchHblByCustomer: function () {
        $('#ContentPlaceHolder1_btn_search').on('click', function () {
            var code = $('#ContentPlaceHolder1_cbo_client_VI').val();
            var hbl = $("#ContentPlaceHolder1_txt_hbl_I").val();
            let aParametro = "{'scode':" + code +",'shbl':'" + hbl + "'}";
            if (hbl == "") {
                swal({ title: '¡Error!', text: "Ingrese Número HBL", icon: "error" });
                return;
            }
            $.ajax({
                type: 'POST',
                url: '/hbl/estado-hbl.aspx/fnsearchHblByCustomer',
                data: aParametro, 
                contentType: 'application/json; utf-8',
                dataType: 'json',
                async: false,
                success: function (data) {
                    if (data.d.iTipoResultado == 1) {
                        var val = data.d.sValor1.split('|');
                        $('#nave').html(val[0]);
                        $('#viaje').html(val[1]);
                        $('#eta').html(val[2]);
                        $('#transportista').html(val[3]);
                        $('#vobo').html(val[4]);
                        $('#terminal').html(val[5]);
                        $('#deposito').html(val[6]);
                        $('#fechacierre').html(val[7]);
                        $('#hbl').html(val[8]);
                        $('#tranmision').html(val[9]=="True"?'Si':'No');
                        $('#agente').html(val[10]);
                        $('.aviso-llegada').css("display", "block");
                    } else {
                        $('#nave').html('');
                        $('#viaje').html('');
                        $('#eta').html('');
                        $('#transportista').html('');
                        $('#vobo').html('');
                        $('#terminal').html('');
                        $('#deposito').html('');
                        $('#fechacierre').html('');
                        $('#hbl').html('');
                        $('#tranmision').html('');
                        $('#agente').html('');
                        $('.aviso-llegada').css("display", "none");
                        swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                    }

                },
                error: function (jqXHR, textStatus, errorThrown) {
                }
            });
        })
    },
    loadtableBill: function () {
        $('#dtconsult').DataTable({
            'paging': false,
            'lengthChange': false,
            'searching': false,
            'ordering': false,
            'info': true,
            'autoWidth': false,
            "language": {
                "lengthMenu": "Display _MENU_ records per page",
                "zeroRecords": "No hay datos a mostrar",
                "info": "Showing page _PAGE_ of _PAGES_",
                "infoEmpty": "",
                "paginate": {
                    "previous": "Anterior",
                    "next": "Siguiente"
                }
            }
        });
    },
    searchHBLByCustomerBill: function () {
        $('#ContentPlaceHolder1_btn_search').on('click', function () {
            master.searchHBLByCustomerBill2('search');
        });      
    },
    searchHBLByCustomerBill2: function (typeFormat) {
        var code = $('#ContentPlaceHolder1_cbo_client_VI').val();
        var hbl = $("#ContentPlaceHolder1_txt_hbl_I").val();
        let aParametro = "{'scode':" + code + ",'shbl':'" + hbl + "'}";
        $.ajax({
            type: 'POST',
            url: '/cliente/wconsultardeudad.aspx/fnsearchHblByCustomer',
            data: aParametro,
            contentType: 'application/json; utf-8',
            dataType: 'json',
            async: false,
            success: function (data) {
                $('#tblConsultant').html('');
                if (data.d.iTipoResultado == 1) {
                    var content = new Array();
                    var type = new Array();
                    var moneda = new Array();
                    var arrVal = data.d.sValor1.split('|');
                    for (i = 0; i < arrVal.length; i++) {
                        if (arrVal[i] != '') {
                            var items = arrVal[i].split(',');
                            if (content[items[1]] == undefined) {
                                content[items[1]] = new Array();
                            }
                            if (!type.includes(items[1])) {
                                type.push(items[1]);
                            }
                            if (content[items[1]][items[4]] == undefined) {
                                content[items[1]][items[4]] = new Array();
                            }
                            if (!moneda.includes(items[4])) {
                                moneda.push(items[4]);
                            }
                            content[items[1]][items[4]][i] = items;
                        }
                    }

                    if (typeFormat == 'export') {
                        var index = 0;
                        aoa[index] = [""];
                    } else {
                        var html = "";
                    }
                    for (var i = 0; i < type.length; i++) {

                        if (typeFormat == 'export') {
                            index++;
                            aoa[index] = ["", "Tipo de Servicio: " + type[i]];
                        }

                        var sumSoles = 0;
                        var sumDolares = 0;
                        for (var a = 0; a < moneda.length; a++) {
                            if (typeFormat == 'export') {
                                index++;
                                aoa[index] = ["", "Tipo Moneda: " + moneda[a]];
                                index++;
                                aoa[index] = ["", "Nro. HBL", "Tipo documento", "Concepto", "Importe", "Forma pago", "Fecha vcto."];
                            } else {
                                html += '<table class="table table-bordered dataTable"><tr><td style="width:30%"><label>Tipo de Servicio:</label><br /><i class="fa fa-circle color-orange"></i>&nbsp;&nbsp;&nbsp;<span class="sub-text">' + type[i] + '</span></td><td style="width:30%"><label>Tipo Moneda:</label><br /><i class="fa fa-circle color-orange"></i>&nbsp;&nbsp;&nbsp;<span class="sub-text">' + moneda[a] + '</span></td><td></td></tr> '
                                html += '<tr><td colspan="3">';
                                html += '<table class="table table-bordered dataTable">';
                                html += '<tr class="cabecera-tabla-deuda-cliente"><td>Nro. HBL</td><td>Tipo documento</td><td>Concepto</td><td>Importe</td><td>Forma pago</td><td>Fecha vcto.</td></tr>';
                            }

                            var sumTotal = 0;
                            if (content[type[i]][moneda[a]] != undefined) {
                                for (var b = 0; b < content[type[i]][moneda[a]].length; b++) {
                                    if (content[type[i]][moneda[a]][b] != undefined) {
                                        var fecven = ""
                                        if (content[type[i]][moneda[a]][b][7] != "") {
                                            var fecVen = content[type[i]][moneda[a]][b][7].split(" ");
                                            fecven = fecVen[0];
                                        }
                                        if (typeFormat != 'export') {
                                            html += '<tr><td>' + content[type[i]][moneda[a]][b][0] + '</td><td style="text-align:center">' + content[type[i]][moneda[a]][b][2] + '</td><td>' + content[type[i]][moneda[a]][b][3] + '</td><td style="text-align:right">' + master.formatNumber(content[type[i]][moneda[a]][b][5]) + '</td><td style="text-align:center">' + content[type[i]][moneda[a]][b][6] + '</td><td style="text-align:center">' + fecven + '</td></tr>';
                                        }

                                        sumTotal += parseFloat(content[type[i]][moneda[a]][b][5]);
                                        if (moneda[a] == "USD") {
                                            sumDolares += parseFloat(content[type[i]][moneda[a]][b][5]);
                                        } else {
                                            sumSoles += parseFloat(content[type[i]][moneda[a]][b][5]);
                                        }
                                        if (typeFormat == 'export') {
                                            index++;
                                            aoa[index] = ["", content[type[i]][moneda[a]][b][0], content[type[i]][moneda[a]][b][2], content[type[i]][moneda[a]][b][3], master.formatNumber(content[type[i]][moneda[a]][b][5]), content[type[i]][moneda[a]][b][6], fecven];
                                        }
                                    }
                                }
                            }

                            if (typeFormat == 'export') {
                                index++;
                                aoa[index] = ["", "", "", "", master.formatNumber(sumTotal), ""];
                            } else {
                                html += '<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td style="text-align:right">' + master.formatNumber(sumTotal) + '</td><td>&nbsp;</td></tr>';
                                html += '</table >';
                                html += '</td></tr>';
                            }


                            if (typeFormat != 'export') {
                                var monedaText = moneda[a];
                                if (moneda[a] == "PEN") {
                                    monedaText = "S/.";
                                }
                                html += '<tr><td colspan="3"><label class="text-total"> Total ' + monedaText + ': ' + master.formatNumber(sumTotal) + ' </label></td></tr>';
                            }

                            if (typeFormat != 'export') {
                                html += ' </table>';
                            }
                        }

                        if (sumSoles > 0) {
                            if (typeFormat == 'export') {
                                index++;
                                aoa[index] = ["", "", "", "Total Soles:", master.formatNumber(sumSoles), ""];
                            }
                        }
                        if (sumDolares > 0) {
                            if (typeFormat == 'export') {
                                index++;
                                aoa[index] = ["", "", "", "Total USD:", master.formatNumber(sumDolares), ""];
                            }
                        }
                    }
                    if (typeFormat != 'export') {
                        $('#tblConsultant').html(html);
                    }
                } else {
                    swal({ title: '¡Alerta!', text: data.d.sMensajeError, icon: "warning" });
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }
        });    
    },
    loadPlaceHolder : function(){
        $("#ContentPlaceHolder1_dateInit_I").attr("placeholder", "Fecha inicio");
        $("#ContentPlaceHolder1_dataEnd_I").attr("placeholder", "Fecha final");
    },
    listBillingByCustomer: function () {
        $('#ContentPlaceHolder1_btn_search').on('click', function () {
           master.listBillingByCustomer2('search');
        });   
    },
    listBillingByCustomer2: function(typeFormat) {
        var code = $('#ContentPlaceHolder1_client_VI').val();
        var dateInit = $("#ContentPlaceHolder1_dateInit_I").val();
        var dateEnd = $("#ContentPlaceHolder1_dataEnd_I").val();
        if (dateInit == "") {
            swal({ title: '¡Error!', text: "Por favor seleccione fecha inicio", icon: "error" });
            return;
        }
        if (dateEnd == "") {
            swal({ title: '¡Error!', text: "Por favor seleccione fecha fin", icon: "error" });
            return;
        }
        let aParametro = "{'scode':" + code + ",'dateInit':'" + dateInit + "','dateEnd': '" + dateEnd + "'}";
         
        $.ajax({
            type: 'POST',
            url: '/cliente/facturacion-electronica.aspx/fnlistBillingByCustomer',
            data: aParametro,
            contentType: 'application/json; utf-8',
            dataType: 'json',
            async: false,
            success: function (data) {
                if (data.d.iTipoResultado == 1) {  
                   var arrVal = data.d.sValor1.split('|');
                   if (typeFormat == 'excel') {
                        aoa[0] = ["Nro. HBL", "Cliente", "Fecha emisión", "Tipo documento", "Serie documento", "Número documento", "Moneda", "Importe", "Transportista", "Almacen", "Terminal portuario", "Agente portuario"];
                    } else {
                       var html = '<thead class="cabecera-tabla"><tr role="row"><th class="inputEvents"></th><th>Nro. HBL</th><th>Cliente</th><th>Fecha emisión</th><th>Tipo documento</th><th>Serie documento</th><th>Número documento</th><th>Moneda</th><th>Importe</th><th>Transportista</th><th>Almacen</th><th>Terminal portuario</th><th>Agente portuario</th></thead >';
                        html += '<tbody>';
                    }
                    var index = 1; 
                    for (i = 0; i < arrVal.length; i++) {
                        if (arrVal[i] != '') {
                            var items = arrVal[i].split(',');                            
                            if (typeFormat == 'excel') {
                                aoa[index] = items;
                                index++;                           
                            } else {
                                html += '<tr>';
                                html += '<td><button type="button" onclick=\'viewPDF("' + items[3] + '", "' + items[5] + '", "' + items[4] +'")\' class="btn btn-default viewPDF"><i class="fa fa-file-pdf-o"></i></button></td>';
                                for (a = 0; a < items.length; a++) {
                                    var style = "";
                                    if (a > 1 && a < 7) {
                                        style = "text-align: center;";
                                    }
                                    if (a == 7) {
                                        style = "text-align: right;";
                                    }
                                    html += "<td style ='"+style+"'>" + items[a] + "</td>";
                                }
                                html += '</tr>';
                            }      
                        }
                    }
                   
                    if (typeFormat != 'excel') {
                        html += '</tbody>';
                        master.reloadTable(html);  
                        $("th").removeClass('sorting_asc sorting_disabled');
                    } 
                } else { 
                     if (typeFormat != 'excel') {
                        var html = '<thead><tr role="row"><th></th><th>Nro. HBL</th><th>Cliente</th><th>Fecha Emisión</th><th>Tipo Documento</th><th>Serie Documento</th><th>Número Documento</th><th>Moneda</th><th>Importe</th><th>Transportista</th><th>Almacen</th><th>Terminal Portuario</th><th>Agente Portuario</th></tr></thead >';
                        html += '<tbody>';
                        html += '</tbody>';
                        $('#dtconsult').html(html);
                        $('#dtconsult').DataTable().destroy();    
                        master.loadtableBill();
                    }                    
                    swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }
        });
    },
    exportExcel: function (type) {
        $('#ContentPlaceHolder1_btn_export').on('click', function () {
            if (type == 'wconsultardeudad') {
                master.searchHBLByCustomerBill2('export');
            } else {
                master.listBillingByCustomer2('excel');   
            }
            var ws = XLSX.utils.aoa_to_sheet(aoa);
            var html_string = XLSX.utils.sheet_to_html(ws, { id: "data-table", editable: true });
            document.getElementById("container").innerHTML = html_string;
            doit(type + ".", 'xlsx');
            $('#container').html('');
        })        
    },
    loadOptionMenu: function () {
        let aParametro = "{profileID:" + $('#hdPerfilID').val() + "}";
        $.ajax({
            type: 'POST',
            url: '../winicio.aspx/fnListarPermisosUsuario',
            data: aParametro,
            contentType: 'application/json; utf-8',
            dataType: 'json',
            async: false,
            success: function (data) {
                $('.sidebar-menu').html('');
                if (data.d.sValor1 != "") {
                    var modulos = data.d.sValor1.split(",");
                    var html = '';
                    for (var i = 0; i < modulos.length; i++) {
                        var title = ''; var link = ''; var img = ''; var classMenu = ''; var space = "&nbsp;&nbsp;";
                        switch (modulos[i]) {
                            case 'Registro / actualización de datos del cliente':
                                title = 'perfil';
                                link = 'seguridad/wactualizardatos.aspx';
                                img = '/static/img/perfil.png';
                                classMenu = 'menu-texto-doble-linea';
                                break;
                            case 'Aviso llegada / salida':
                                title = 'aviso-llegada';
                                link = 'avisollegada/consultar-aviso-de-llegada-salida.aspx';
                                img = '/static/img/aviso_llegada.png';
                                classMenu = '';
                                break;
                            case 'Gestión de autorizaciones':
                                title = 'solicitud-autorizaciones';
                                link = 'autorizaciones/solicitud-de-autorizaciones.aspx';
                                img = '/static/img/autorizaciones.png';
                                classMenu = '';
                                break;
                            case 'Direccionamiento de carga':
                                title = 'direccionamiento-carga';
                                link = 'direccionamiento/direccionamiento-cargas.aspx';
                                img = '/static/img/direccionamiento.png';
                                classMenu = '';
                                break;
                            case 'Vinculación de empresa':
                                title = 'vinculacion-empresa';
                                link = 'vinculacion/listado_vinculacion_empresa.aspx';
                                img = '/static/img/vinculacion.png';
                                classMenu = '';
                                break;
                            case 'Facturación electrónica':
                                title = 'facturacion-electronica';
                                link = 'cliente/facturacion-electronica.aspx';
                                img = '/static/img/facturacion.png';
                                classMenu = '';
                                break;
                            case 'Estado del HBL':
                                title = 'estado-hbl';
                                link = 'hbl/estado-hbl.aspx';
                                img = '/static/img/hbl.png';
                                classMenu = '';
                                break;
                            case 'Deuda del cliente':
                                title = 'deuda-cliente';
                                link = 'cliente/wconsultardeudad.aspx';
                                img = '/static/img/aviso_llegada.png';
                                classMenu = '';
                                break;
                            case 'Estado de cuenta':
                                title = 'estado-cuenta';
                                link = 'cliente/estado-cuenta.aspx';
                                img = '/static/img/aviso_llegada.png';
                                classMenu = '';
                                break;
                            case 'Consulta cotización':
                                title = 'consultar-cotizacion';
                                link = 'cliente/consultarCotizacion.aspx';
                                img = '/static/img/hbl.png';
                                classMenu = '';
                                break;
                            case 'Comunicados':
                                title = 'comunicados';
                                link = 'comunicados/comunicados.aspx';
                                img = '/static/img/comunicados.png';
                                classMenu = '';
                                break;
                            case 'Seguimiento operativo':
                                title = 'seguimiento-operativo';
                                link = 'seguimiento/seguimiento-operativo.aspx';
                                img = '/static/img/hbl.png';
                                classMenu = '';
                                break;
                        }
                        html += '<li class="" data-title="' + title+'">';
                        html += '<a href = "/' + link+'" >';
                        html += '<img src="' + img + '"><span class="menu-delfingroup' + classMenu + '">' + space + modulos[i] + '</span>';
                        html += '</a>';
                        html += '</li >';
                    }
                    html += '<li class="">';
                    html += '<a href = "/wlogin.aspx" >';
                    html += '<img src="/static/img/cerrar.png">&nbsp;&nbsp;<span class="menu-delfingroup">Cerrar sesión</span>';
                    html += '</a>';
                    html += '</li >'
                    $('.sidebar-menu').html(html);
                }               
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }

        });

        master.menuResponsive();
        master.obtenerURL();
    },
    listRelatedCompany: function () {
        var code = $('#hdCode').val();
        var scorreo = $('#hcorreoClient').val();

        let aParametro = "{scode:" + code + ", scorreo: '" + scorreo+"'}";

        $.ajax({
            type: 'POST',
            url: '/vinculacion/listado_vinculacion_empresa.aspx/fnlistRelatedCompany',
            data: aParametro,
            contentType: 'application/json; utf-8',
            dataType: 'json',
            async: false,
            success: function (data) {
                if (data.d.iTipoResultado == 1) {
                    var arrVal = data.d.sValor1.split('|');
                    var html = '<thead class="cabecera-tabla"><tr><th>Número de identificación</th><th>Razón social</th><th>Contacto</th><th>Correo</th><th>Tipo de vinculación</th><th>Tipo de vigencia</th><th>Inicio vigencia</th><th>Fin vigencia</th><th>Estado</th><th>Desvincular</th></tr></thead>';
                    html += '<tbody>';
                    for (i = 0; i < arrVal.length; i++) {
                        if (arrVal[i] != '') {
                            var items = arrVal[i].split(',');
                            html += '<tr>';
                            for (a = 0; a < items.length; a++) {
                                html += "<td>" + items[a] + "</td>";
                            }
                            html += "<td class='text-center'><button class='btn btn-xs btn-default unlink' data-code = '" + items[0]+"' type='button'><i class='fa fa-close'></i></button></td>";
                            html += '</tr>';
                        }
                    }
                    html += '</tbody>';
                    master.reloadTable(html);
                    master.unlink();
                } else {
                    var html = '<thead><tr role="row"> <th>Número de Identificación</th><th>Razón Social</th><th>Contacto</th><th>Correo</th><th>Tipo de Vinculación</th><th>Tipo de Vigencia</th><th>Inicio Vigencia</th><th>Fin Vigencia</th><th>Estado</th><th>Desvincular</th></tr></thead >';
                    html += '<tbody>';
                    html += '</tbody>';
                    $('#dtconsult').html(html);
                    $('#dtconsult').DataTable().destroy();
                    master.loadtableBill();
                }
                $("th").removeClass('sorting_asc sorting_disabled');
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }
        }); 
    },
    validEmail: function (email) {
        if (/^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i.test(email)) {
            return true;
        } else {
            return false;
        }
    },
    saveRelatedCompany: function () {
        $('#ContentPlaceHolder1_save').on('click', function () {
            var numberDocument = $('#ContentPlaceHolder1_number_document_I').val();
            var contact = $('#ContentPlaceHolder1_contact_I').val();
            var email = $('#ContentPlaceHolder1_email_I').val();
            var typeBonding = $('#ContentPlaceHolder1_typeBonding_VI').val();
            var validityRate = $('#ContentPlaceHolder1_validityRate_VI').val();
            var dateStart = $('#ContentPlaceHolder1_dateInit_I').val();
            var dateEnd = $('#ContentPlaceHolder1_dataEnd_I').val();
            var code = $('#hdCode').val();
            var scorreo = $('#hcorreoClient').val();
            var sEmpresaP = $('#hdRazonSocial').val();
            var sEmpresaV = $('#ContentPlaceHolder1_bussines_I').val();

            if (numberDocument == '') {
                swal({ title: '¡Error!', text: "Ingrese número de documento", icon: "error" });
                return;
            }
            if (contact == '') {
                swal({ title: '¡Error!', text: "Ingrese nombre del contacto", icon: "error" });
                return;
            }
            if (email == '') {
                swal({ title: '¡Error!', text: "Ingrese correo del contacto", icon: "error" });
                return;
            } else {
                if (master.validEmail(email) == false) {
                    swal({ title: '¡Error!', text: "Ingrese correo valido", icon: "error" });
                    return;
                }
            }
            if (validityRate == '002') {
                if (dateStart == '') {
                    swal({ title: '¡Error!', text: "Seleccione fecha de inicio", icon: "error" });
                    return;
                }
                if (dateEnd == '') {
                    swal({ title: '¡Error!', text: "Seleccione fecha de termino", icon: "error" });
                    return;
                }
            }

            swal({
                title: 'Espere por favor...',
                text: ' ',
                icon: "/static/img/load.gif",
                buttons: false,
                closeOnClickOutside: false
            });

            let aParametro = '{"code":' + code + ',"numberDocument":"' + numberDocument + '", "contact": "' + contact + '", "email": "' + email + '", "typeBonding": "' + typeBonding + '", "validityRate": "' + validityRate + '", "dateStart": "' + dateStart + '", "dateEnd": "' + dateEnd + '", "scorreo":"' + scorreo + '", "sEmpresaP":"' + sEmpresaP + '", "sEmpresaV":"' + sEmpresaV+'"}';
            $.ajax({
                type: 'POST',
                url: '/vinculacion/vinculacion_empresa_registro.aspx/fnsaveRelatedCompany',
                data: aParametro,
                contentType: 'application/json; utf-8',
                dataType: 'json',
                async: false,
                success: function (data) {
                    swal.close();
                    if (data.d.iTipoResultado == 1) {
                        swal({ title: '¡Exito!', text: data.d.sValor1, icon: "success" })
                        .then((value) => {
                            if (value == true) {
                                location.href = '../vinculacion/listado_vinculacion_empresa.aspx';
                            }
                        });
                    } else {
                        swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                }

            });

        })
    },
    returnList: function () {
        $('#ContentPlaceHolder1_returnList').on('click', function () {
            location.href = "/vinculacion/listado_vinculacion_empresa.aspx";
        })
    },
    loadDataByDocument: function () {
        $('#ContentPlaceHolder1_number_document_I').on('blur', function () {
            let iTipoDocumento = $('#ContentPlaceHolder1_typeDocument_VI').val();
            let sNroDocumento = document.getElementById('ContentPlaceHolder1_number_document_I').value;
            if (sNroDocumento != "") {
                let aParametro = "{'iTipoDocumento':'" + iTipoDocumento + "','sNroDocumento':'" + sNroDocumento + "'}";
                $.ajax({
                    type: 'POST',
                    url: '../seguridad/wregistro.aspx/fnValidarRegistro',
                    data: aParametro,
                    contentType: 'application/json; utf-8',
                    dataType: 'json',
                    async: false,
                    success: function (data) {
                        if (data.d.iTipoResultado == 1) {
                            $('#ContentPlaceHolder1_bussines_I').val(data.d.sValor1);
                        } else {
                            swal({ title: '¡Alerta!', text: "Nro documento no se encuentra registrado en el sistema.", icon: "warning" });
                        }
                    },
                    error: function (jqXHR, textStatus, errorThrown) {

                    }

                });
            }
        });
    },
    reloadTable: function (html) {
        $('#dtconsult').html(html);
        $('#dtconsult').DataTable().destroy();
        $('#dtconsult').DataTable({
            'paging': true,
            'lengthChange': true,
            'searching': false,
            'ordering': false,
            'info': true,
            'autoWidth': false,
            "language": {
                "lengthMenu": "&nbsp;&nbsp;Ver &nbsp;_MENU_ &nbsp;&nbsp;registros por p&aacute;gina",
                "zeroRecords": "No hay datos a mostrar",
                "info": "&nbsp;&nbsp;P&aacute;gina _PAGE_ de _PAGES_",
                "infoEmpty": "",
                "paginate": {
                    "previous": "Anterior",
                    "next": "Siguiente"
                }
            }
        });
    },
    selectTemplate: function () {
        $('.imgTemplate').on('click', function () {
            var type = $(this).attr('data-type');
            $('.imgTemplate').removeClass('imgSelected');
            $(this).addClass('imgSelected');
            $('.hidden').removeAttr('checked');
            $('#typeTemplate' + type).attr('checked','checked');
        });
    },
    sendMail: function () {
        $('#ContentPlaceHolder1_save').on('click', function () {
            if ($("input[name='typeTemplate']:radio").is(':checked') == false) {
                swal({ title: '¡Error!', text: "Seleccione template", icon: "error" });
                return;
            } 
            var from = $('#ContentPlaceHolder1_from_I').val();
            var subject = $('#ContentPlaceHolder1_subject_I').val();
            var titleContent = $('#ContentPlaceHolder1_titleContent_I').val();
            var body = $('.click2edit').summernote('code');
            var templateID = $('input:radio[name=typeTemplate]:checked').val();
            if (from == "") {
                swal({ title: '¡Error!', text: "Ingrese destinatario", icon: "error" });
                return;
            } else {
               /* if (master.validEmail(from) == false) {
                    swal({ title: '¡Error!', text: "Ingrese correo valido", icon: "error" });
                    return;
                }*/
            }
            if (subject == "") {
                swal({ title: '¡Error!', text: "Ingrese asunto", icon: "error" });
                return;
            }
            if (titleContent == "") {
                swal({ title: '¡Error!', text: "Ingrese titulo del correo", icon: "error" });
                return;
            }
            if (body == "") {
                swal({ title: '¡Error!', text: "Ingrese texto del correo", icon: "error" });
                return;
            }            
            $('#ContentPlaceHolder1_templateIDhd_I').val(templateID);
            $('#ContentPlaceHolder1_BootstrapButton1').trigger('click');
            swal({
                title: 'Espere por favor...',
                text: ' ',
                icon: "/static/img/load.gif",
                buttons: false,
                closeOnClickOutside: false
            });
           
        })
    },
    formatNumber: function (num) {
        var numIni = new Intl.NumberFormat('en-IN').format(num);
        numIni = numIni.split('.');
        var numFinal = new Intl.NumberFormat('en-IN').format(num)+".00";
        if (numIni.length == 2) {
            numFinal = numIni[0] + '.' + numIni[1];
            if (numIni[1].length == 1) {
                numFinal = numIni[0] + '.' + numIni[1] + '0';
            }
        }
        return numFinal;
    },
    unlink: function () {
        $('.unlink').on('click', function () {
            swal({
                title: "Confirmación",
                text: "Esta seguro que desea desvincular la empresa seleccionada?",
                icon: "warning",
                buttons: ["Cancelar", "Aceptar"]
            })
            .then((willDelete) => {
                if (willDelete) {
                    var code = $('#hdCode').val();
                    var scorreo = $('#hcorreoClient').val();
                    var sNumberDocument = $(this).attr('data-code');
                    let aParametro = "{scode:" + code + ",sNumberDocument: " + sNumberDocument + ", scorreo: '" + scorreo + "'}";

                    swal({
                        title: 'Cargando...',
                        text: ' ',
                        icon: "/static/img/load.gif",
                        buttons: false,
                        closeOnClickOutside: false
                    });

                    $.ajax({
                        type: 'POST',
                        url: '/vinculacion/listado_vinculacion_empresa.aspx/fnunlink',
                        data: aParametro,
                        contentType: 'application/json; utf-8',
                        dataType: 'json',
                        async: false,
                        success: function (data) {
                            swal.close();
                            if (data.d.iTipoResultado == 1) {
                                swal({ title: '¡Exito!', text: data.d.sMensajeError, icon: "success" });
                                master.listRelatedCompany();
                            } else {
                                swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                            }
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                        }
                    });
                } 
            });
           
        })
       
    },
    validHBLByAviso: function () {
        $('#ContentPlaceHolder1_btn_preview').on('click', function () {
            var hbl = $("#ContentPlaceHolder1_txt_hbl_I").val();
            if (hbl != "") {
                let aParametro = "{shbl:'" + hbl +"'}";
                $.ajax({
                    type: 'POST',
                    url: '/avisollegada/consultar-aviso-de-llegada-salida.aspx/fnValidHBLByAviso',
                    data: aParametro,
                    contentType: 'application/json; utf-8',
                    dataType: 'json',
                    async: false,
                    success: function (data) {
                        if (data.d.iTipoResultado == 1) {
                            swal({
                                title: 'Cargando...',
                                text: ' ',
                                icon: "/static/img/load.gif",
                                buttons: false,
                                closeOnClickOutside: false
                            });
                            $('#ContentPlaceHolder1_btn_preview2').trigger('click');
                        } else {
                            $('.aviso-llegada').css("display", "none");
                            swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                        }
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                    }
                });
            } else {
                swal({ title: '¡Error!', text: "Ingrese número HBL", icon: "error" });
            }
        });
    },
    load: function () {
        if ($('#ContentPlaceHolder1_messageHd_I').val() != "") {
            if ($('#ContentPlaceHolder1_messageHd_I').val() == "true") {
                title = "¡Exito!";
                text = "Mensaje enviado.";
                icon = "success";               
            } else {
                title = "¡Error!";
                text = "No se pudo enviar el mensaje, por favor intentarlo en unos minutos.";
                icon = "error";
            }
            $('#ContentPlaceHolder1_messageHd_I').val('');
            $('#ContentPlaceHolder1_from_I').val('');
            $('#ContentPlaceHolder1_subject_I').val('');
            $('#ContentPlaceHolder1_titleContent_I').val('');
            $('.click2edit').summernote('code', '');
            swal({ title: title, text: text, icon: icon });
        }
    },
    exportPDF: function () {
        $('#ifPdfHBL').attr('src', $('#ContentPlaceHolder1_hdPdfHBL_I').val());
        $('.iframe-hbl').css("display", "block");
    },
    exportPDFValid: function () {
        $('#ContentPlaceHolder1_btn_export2').on('click', function () {
            var code = $('#ContentPlaceHolder1_cbo_client_VI').val();
            var hbl = $("#ContentPlaceHolder1_txt_hbl_I").val();
            if (hbl == "") {
                swal({ title: '¡Error!', text: "Ingrese Número HBL", icon: "error" });
                return;
            } 
            $('#ContentPlaceHolder1_btn_export').trigger('click');
        })
    },
    customerDebt: function () {
        $('#ContentPlaceHolder1_btn_search').on('click', function () {
            var code = $('#ContentPlaceHolder1_cbo_client_VI').val();
            var dateStart = $('#ContentPlaceHolder1_dateInit_I').val();
            var dateEnd = $('#ContentPlaceHolder1_dataEnd_I').val();
            var type = $('#ContentPlaceHolder1_cboType_VI').val();

            if (dateStart == "" || dateEnd == "") {
                swal({ title: '¡Error!', text: "Rango de fecha invalido", icon: "error" });
            } else {
                var di = dateStart.split('/');
                var df = dateEnd.split('/');

                var dateI = new Date(di[2] + '-' + di[1] + '-' + di[0]).getTime();
                var dateE = new Date(df[2] + '-' + df[1] + '-' + df[0]).getTime();

                var diff = (dateE - dateI) / (1000 * 60 * 60 * 24);
                if (diff > 180) {
                    swal({ title: '¡Alerta!', text: "El rango de fecha es máximo de 6 meses", icon: "warning" });
                } else {    
                    $('.preloadModal').modal('show');
                    setTimeout(function () {
                        master.loadCustomerDeb(code, dateStart, dateEnd, type, 'search');
                    }, 1000);                    
                }
            }            
        });
    },
    exportcustomerDebt: function () {
        $('#ContentPlaceHolder1_btn_export').on('click', function () {
            var code = $('#ContentPlaceHolder1_cbo_client_VI').val();
            var dateStart = $('#ContentPlaceHolder1_dateInit_I').val();
            var dateEnd = $('#ContentPlaceHolder1_dataEnd_I').val();
            var type = $('#ContentPlaceHolder1_cboType_VI').val();

            if (dateStart == "" || dateEnd == "") {
                swal({ title: '¡Error!', text: "Rango de fecha invalido", icon: "error" });
            } else {
                var di = dateStart.split('/');
                var df = dateEnd.split('/');

                var dateI = new Date(di[2] + '-' + di[1] + '-' + di[0]).getTime();
                var dateE = new Date(df[2] + '-' + df[1] + '-' + df[0]).getTime();

                var diff = (dateE - dateI) / (1000 * 60 * 60 * 24);
                if (diff > 180) {
                    swal({ title: '¡Alerta!', text: "El rango de fecha es máximo de 6 meses", icon: "warning" });
                } else {
                    //$('.preloadModal').modal('show');
                    master.loadCustomerDeb(code, dateStart, dateEnd, type, 'export');
                }
            }  
        })
    },
    loadCustomerDeb: function (code, dateStart, dateEnd, type, typeFormat) {   
        let aParametro = "{'scode':" + code + ",'dateInit':'" + dateStart + "','dateEnd':'" + dateEnd + "', 'type':'" + type + "'}";
        $.ajax({
            type: 'POST',
            url: '/cliente/estado-cuenta.aspx/fnsearchHblByCustomer',
            data: aParametro,
            contentType: 'application/json; utf-8',
            dataType: 'json',
            async: false,
            success: function (data) {                
               $('#tblConsultant').html('');
                if (data.d.iTipoResultado == 1) {
                    var content = new Array();
                    var type = new Array();
                    var moneda = new Array();
                    var arrVal = data.d.sValor1.split('|');
                    for (i = 0; i < arrVal.length; i++) {
                        if (arrVal[i] != '') {
                            var items = arrVal[i].split(',');

                            if (content[items[0]] == undefined) {
                                content[items[0]] = new Array();
                            }
                            if (!type.includes(items[0])) {
                                type.push(items[0]);
                            }
                            if (content[items[0]][items[6]] == undefined) {
                                content[items[0]][items[6]] = new Array();
                            }
                            if (!moneda.includes(items[6])) {
                                moneda.push(items[6]);
                            }
                            content[items[0]][items[6]][i] = items;
                        }
                    }
                    if (typeFormat == 'export') {
                        var index = 0;
                        aoa[index] = [""];
                    } else {
                        var html = "";
                    }
                    for (var i = 0; i < type.length; i++) {
                        if (typeFormat == 'export') {
                            index++;
                            aoa[index] = ["", "Tipo de Servicio: " + type[i]];
                        }
                        var sumSoles = 0;
                        var sumDolares = 0;
                        for (var a = 0; a < moneda.length; a++) {
                            var sumTotal = 0;
                            if (content[type[i]][moneda[a]] != undefined) {
                                if (typeFormat == 'export') {
                                    index++;
                                    aoa[index] = ["", "Tipo Moneda: " + moneda[a]];
                                    index++;
                                    aoa[index] = ["", "Nro. HBL", "Nave", "Viaje", "Tipo Documento", "Fecha Emisión", "Concepto", "Importe", "Fecha Vecimiento", "Forma Pago", "Saldo"];
                                } else {
                                    html += '<table class="table table-bordered dataTable"><tr><td style="width:30%"><label>Tipo de Servicio:</label><br /><i class="fa fa-circle color-orange"></i>&nbsp;&nbsp;&nbsp;<span class="sub-text">' + type[i] + '</span></td><td style="width:30%"><label>Tipo Moneda:</label><br /><i class="fa fa-circle color-orange"></i>&nbsp;&nbsp;&nbsp;<span class="sub-text">' + moneda[a] + '</span></td><td></td></tr> '
                                    html += '<tr><td colspan="3">';
                                    html += '<table class="table table-bordered dataTable">';
                                    html += '<tr class="cabecera-tabla-deuda-cliente"><td>Nro. HBL</td><td>Nave</td><td>Viaje</td><td>Tipo Documento</td><td>Fecha Emisión</td><td>Concepto</td><td>Importe</td><td>Fecha Vecimiento</td><td>Forma Pago</td><td>Saldo</td></tr>';
                                }
                                                                
                                for (var b = 0; b < content[type[i]][moneda[a]].length; b++) {
                                    if (content[type[i]][moneda[a]][b] != undefined) {
                                        var fecven = ""
                                        if (content[type[i]][moneda[a]][b][5] != "") {
                                            var fecVen = content[type[i]][moneda[a]][b][5].split(" ");
                                            fecven = fecVen[0];
                                        }
                                        if (typeFormat != 'export') {
                                            html += '<tr><td>' + content[type[i]][moneda[a]][b][1] + '</td><td style="text-align:center">' + content[type[i]][moneda[a]][b][9] + '</td><td>' + content[type[i]][moneda[a]][b][10] + '</td><td>' + content[type[i]][moneda[a]][b][2] + '</td><td style="text-align:center">' + content[type[i]][moneda[a]][b][4] + '</td><td>' + content[type[i]][moneda[a]][b][3] + '</td><td style="text-align:right">' + master.formatNumber(content[type[i]][moneda[a]][b][7]) + '</td><td style="text-align:center">' + fecven + '</td><td>' + content[type[i]][moneda[a]][b][8] + '</td><td style="text-align:right">' + master.formatNumber(content[type[i]][moneda[a]][b][11]) + '</td></tr>';
                                        }
                                        
                                        sumTotal += parseFloat(content[type[i]][moneda[a]][b][7]);
                                        if (moneda[a] == "USD") {
                                            sumDolares += parseFloat(content[type[i]][moneda[a]][b][7]);
                                        } else {
                                            sumSoles += parseFloat(content[type[i]][moneda[a]][b][7]);
                                        }
                                        if (typeFormat == 'export') {
                                            index++;
                                            aoa[index] = ["", content[type[i]][moneda[a]][b][1], content[type[i]][moneda[a]][b][9], content[type[i]][moneda[a]][b][10], content[type[i]][moneda[a]][b][2], content[type[i]][moneda[a]][b][4], content[type[i]][moneda[a]][b][3], master.formatNumber(content[type[i]][moneda[a]][b][7]), fecven, content[type[i]][moneda[a]][b][8], master.formatNumber(content[type[i]][moneda[a]][b][11])];
                                        }
                                    }
                                }
                                if (typeFormat == 'export') {
                                    index++;
                                    aoa[index] = ["", "", "", "", "", "", master.formatNumber(sumTotal), ""];
                                } else {
                                    html += '<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td style="text-align:right">' + master.formatNumber(sumTotal) + '</td><td>&nbsp;</td></tr>';
                                    html += '</table >';
                                    html += '</td></tr>';
                                }

                                if(typeFormat != 'export') {
                                    var monedaText = moneda[a];
                                    if (moneda[a] == "PEN") {
                                        monedaText = "S/.";
                                    }
                                    html += '<tr><td colspan="3"><label class="text-total"> Total ' + monedaText + ': ' + master.formatNumber(sumTotal) + ' </label></td></tr>';

                                    html += ' </table>';
                                }                                
                            }
                        }
                    }
                    if (html != "" && typeFormat == 'search') {
                        $('.preloadModal').modal('hide');
                        $('#tblConsultant').html(html);
                    } else {
                        var ws = XLSX.utils.aoa_to_sheet(aoa);
                        var html_string = XLSX.utils.sheet_to_html(ws, { id: "data-table", editable: true });
                        document.getElementById("container").innerHTML = html_string;
                        doit("estado-cuenta.", 'xlsx');
                        $('#container').html('');
                    }
                } else {
                    $('.preloadModal').modal('hide');
                    swal({ title: '¡Alerta!', text: data.d.sMensajeError, icon: "warning" });
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }
        });
    },
    loadDireccionamiento: function () {
        $('#ContentPlaceHolder1_search').on('click', function (e) {
            e.preventDefault();
            var code = $('#ContentPlaceHolder1_client_VI').val();
            var hbl = $('#ContentPlaceHolder1_numberHBL_I').val();
            let aParametro = "{'scode':" + code + ",'shbl':'"+hbl+"'}";
            $.ajax({
                type: 'POST',
                url: '/direccionamiento/direccionamiento-cargas.aspx/fnlistarDireccionamiento',
                data: aParametro,
                contentType: 'application/json; utf-8',
                dataType: 'json',
                async: false,
                success: function (data) {
                    if (data.d.iTipoResultado == 1) {
                        master.loadDataDireccionamiento(data.d.sValor1);
                    } else {
                        if (loadD > 0) {
                            swal({ title: '¡Alerta!', text: data.d.sMensajeError, icon: "warning" });
                        }                        
                        $('#tblDireccionamiento').html('');
                    }
                    loadD++;
                },
                error: function (jqXHR, textStatus, errorThrown) {
                }
            });            
        })
    },
    loadDataDireccionamiento: function (data) {
        var res = data.split('|');
        var html = ""; var items = new Array();
        for (i = 0; i < res.length; i++) {
            if (res[i] != '') {
                var item = res[i].split(',');
                if (items[item[0]]) {
                    items[item[0]].push(item); 
                } else {
                    items[item[0]] = new Array();
                    items[item[0]].push(item); 
                }
                
            }
        }
        for (var arrayIndex in items) {
            html += '<table class="table table-bordered table-hover dataTable">';
            html += '<tr><td><b>HBL N° ' + arrayIndex +'</b></td></tr>';
            html += '<tr><td>';
            html += '<table class="table table-bordered table-hover dataTable" ><tr><th>Fecha de Solicitud</th><th>Correo del Solicitante</th><th>Deposito Actual</th><th>Deposito Solicitado</th><th>Estado de la Solicitud</th><th>Eliminar</th></tr>';
            for (var a = 0; a < items[arrayIndex].length; a++) {
                html += '<tr>';
                for (var b = 1; b < items[arrayIndex][a].length; b++) {
                    if (b != 5 && b < 7) {
                        html += '<td width="18%">' + items[arrayIndex][a][b] + '</td>';
                    }                    
                }
                html += "<td class='text-center'>";
                if (items[arrayIndex][a][5] == 'P') {
                    html += "<button class='btn btn-xs btn-default unlink' code = '" + items[arrayIndex][a][7] + "' hbl='" + items[arrayIndex][a][0] + "' codTemporal='" + items[arrayIndex][a][8] + "' descargaDirecta ='" + items[arrayIndex][a][9] + "' codDepTemporalSolicitado ='" + items[arrayIndex][a][10] + "' email = '" + items[arrayIndex][a][2] +"' type='button'><i class='fa fa-close'></i></button>";
                } 
                html += "</td>";
                html += '</tr>';
            }
            html += '</table></td></tr>';
            html += '</table> ';
        }       
        $('#tblDireccionamiento').html(html);
        master.deleteDireccionamiento();
    },
    loadFormDireccionamiento: function () {
        $('#ContentPlaceHolder1_new').on('click', function () {
            location.href = "/direccionamiento/direccionamiento-carga-registro.aspx";
        });
    },
    cancelDireccionamiento: function () {
        $('#ContentPlaceHolder1_returnList').on('click', function () {
            location.href = "/direccionamiento/direccionamiento-cargas.aspx";
        });
    },
    saveDireccionamito: function () {
        $('#ContentPlaceHolder1_save').on('click', function (e) {
            e.preventDefault();
            var hbl = $('#ContentPlaceHolder1_txtHbl_I').val();
            var type = $('#ContentPlaceHolder1_type_L_VI').val();
            var depositoI = $('#ContentPlaceHolder1_depositoInitH_I').val();
            var depositoF = $('#ContentPlaceHolder1_depositoF_VI').val() != "" ? $('#ContentPlaceHolder1_depositoF_VI').val():"0";
            var code = $('#ContentPlaceHolder1_client_VI').val();
            var userID = $('#idUser').val();
            var email = $('#hcorreoClient').val();
            
            if (code == "") {
                swal({ title: '¡Alerta!', text: "Cliente es obligatorio.", icon: "warning" });
                return;
            }

            if (hbl == "") {
                swal({ title: '¡Alerta!', text: "HBL es obligatorio.", icon: "warning" });
                return;
            }
            if (type == "") {
                swal({ title: '¡Alerta!', text: "Tipo es obligatorio.", icon: "warning" });
                return;
            }

            if (depositoI == "") {
                swal({ title: '¡Alerta!', text: "Deposito Inicial es obligatorio.", icon: "warning" });
                return;
            }
            if (type == "0" && depositoF == "") {
                swal({ title: '¡Alerta!', text: "Deposito Final es obligatorio.", icon: "warning" });
                return;
            }

            let aParametro = "{'scode':" + code + ",'shbl':'" + hbl + "', 'type':" + type + ",'depositoI':'" + depositoI + "','depositoF':" + depositoF + ",'email':'" + email + "','userID':" + userID + "}";
            $('.preloadModal').modal('show');
            setTimeout(function () {
                master.saveDireccionamiento(aParametro);
            }, 1000);  
            
        });
    },
    saveDireccionamiento: function (aParametro) {
        $.ajax({
            type: 'POST',
            url: '/direccionamiento/direccionamiento-carga-registro.aspx/fsave',
            data: aParametro,
            contentType: 'application/json; utf-8',
            dataType: 'json',
            async: false,
            success: function (data) {
                $('.preloadModal').modal('hide');
                if (data.d.iTipoResultado) {
                    swal({ title: '¡Exito!', text: data.d.sValor1, icon: "success" })
                        .then((value) => {
                            if (value == true) {
                                var name = $("#ContentPlaceHolder1_client_I").val().replace(" ", "_");;
                                location.href = '../direccionamiento/direccionamiento-cargas.aspx?v=' + code + '&name=' + name;
                            }
                        });
                } else {
                    swal({ title: '¡Error!', text: data.d.sValor1, icon: "error" });
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
            }
        });
    },
    loadHBL: function () {
        $('#ContentPlaceHolder1_txtHbl_I').on('blur', function () {
            var hbl = $('#ContentPlaceHolder1_txtHbl_I').val();
            var code = $('#ContentPlaceHolder1_client_VI').val();
            let aParametro = "{'scode':" + code + ",'shbl':'" + hbl + "'}";
            $.ajax({
                type: 'POST',
                url: '/direccionamiento/direccionamiento-carga-registro.aspx/fnloadHbl',
                data: aParametro,
                contentType: 'application/json; utf-8',
                dataType: 'json',
                async: false,
                success: function (data) {
                    if (data.d.iTipoResultado == 1) {
                        $('#ContentPlaceHolder1_depositoInit_I').val(data.d.sValor2);
                        $('#ContentPlaceHolder1_depositoInitH_I').val(data.d.sValor1);
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                }
            });
        });
    },
    seguiemiento: function () {
        $('#ContentPlaceHolder1_search').on('click', function (e) {

            e.preventDefault();
            var code = $('#ContentPlaceHolder1_client_VI').val();
            var hbl = $('#ContentPlaceHolder1_numberHBL_I').val();
            let aParametro = "{'scode':" + code + ",'shbl':'" + hbl + "'}";
            var html = "";
            $.ajax({
                type: 'POST',
                url: '/seguimiento/seguimiento-operativo.aspx/fnSeguimiento',
                data: aParametro,
                contentType: 'application/json; utf-8',
                dataType: 'json',
                async: false,
                success: function (data) {
                    if (data.d.iTipoResultado == 1) {
                        var res = data.d.sValor1.split('|');
                        if (res.length > 0) {
                            html += '<ul class="timeline">';
                            for (var i = 0; i < res.length; i++) {
                                if (res[i] != "") {
                                    
                                    var content = res[i].split(',');
                                    var icon = "fa-circle bg-orange";
                                    if (content[0] == "True") {
                                        icon = "fa-check bg-blue";
                                    }
                                    html += '<li><i class="fa ' + icon+'"></i><div class="timeline-item">';
                                    html += '<div class="timeline-body"><span class="time"><i class="fa fa-calendar"></i> ' + master.fechaString(content[1])+'</span><br />';
                                    html += '<span class="time"><i class="fa fa-clock-o"></i> ' + content[2] + '</span> <br /><label class="c-blue">' + content[3]+'</label></div></div></li>';

                                }
                            }
                            html += '</ul>';
                        }
                    } else {
                        swal({ title: '¡Error!', text: data.d.sValor1, icon: "error" });
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                }
            });      

            $('#traking').html(html);
        })
    },
    fechaString: function (fecha) {
        var fecha = fecha.split('/');
        switch (fecha[1]) {
            case '01':
                month = "Enero";
                break;
            case '02':
                month = "Febrero";
                break;
            case '03':
                month = "Marzo";
                break;
            case '04':
                month = "Abril";
                break;
            case '05':
                month = "Mayo";
                break;
            case '06':
                month = "Junio";
                break;
            case '07':
                month = "Julio";
                break;
            case '08':
                month = "Agosto";
                break;
            case '09':
                month = "Setiembre";
                break;
            case '10':
                month = "Octubre";
                break;
            case '11':
                month = "Noviembre";
                break;
            case '12':
                month = "Diciembre";
                break;
            default:
                month = "";
                break;
        }
        return month + ' ' + fecha[0] + ', ' + fecha[2];
    },
    deleteDireccionamiento: function () {
        $('.unlink').on('click', function () {
            swal({
                title: "Confirmación",
                text: "Esta seguro que desea eliminar la solicitud de Direccionamiento?",
                icon: "warning",
                buttons: ["Cancelar", "Aceptar"]
            })
            .then((willDelete) => {
                if (willDelete) {
                    var userID = $('#idUser').val();
                    var email = $(this).attr('email');
                    var codigo = $(this).attr('code');
                    var hbl = $(this).attr('hbl');
                    var codtemporal = $(this).attr('codtemporal');
                    var descargadirecta = $(this).attr('descargadirecta')=='True'?1:0;
                    var coddeptemporalsolicitado = $(this).attr('coddeptemporalsolicitado');

                    let aParametro = "{'codigo':" + codigo + ",'hbl': '" + hbl + "', 'codtemporal': " + codtemporal + ", 'descargadirecta':" + descargadirecta + ", 'coddeptemporalsolicitado': " + coddeptemporalsolicitado + ", 'userID': " + userID + ", 'email':'" + email+"' }";

                     $.ajax({
                        type: 'POST',
                         url: '/direccionamiento/direccionamiento-cargas.aspx/deleteDireccionamiento',
                        data: aParametro,
                        contentType: 'application/json; utf-8',
                        dataType: 'json',
                        async: false,
                        success: function (data) {
                            if (data.d.iTipoResultado == 1) {
                                swal({ title: '¡Exito!', text: data.d.sMensajeError, icon: "success" });
                                $("#ContentPlaceHolder1_search").trigger("click");
                            } else {
                                swal({ title: '¡Error!', text: data.d.sMensajeError, icon: "error" });
                            }
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                        }
                    });
                }
            });
        })
    }
};

function viewPDF(type, number, serie) {
    
    var TipDocSunat = "";
    var folder = "";
    if (type == 'FT') {
        TipDocSunat = "01";
        folder = "facturas";
    } else if (type == 'BV') {
        TipDocSunat = "03";
        folder = "boletas";
    } else if (type == 'NC') {
        TipDocSunat = "07";
        folder = "notascredito";
    } else if (type == 'RC') {
        TipDocSunat = "RC";
        folder = "recibos";
    }
    var url = "";

    if (TipDocSunat != "" && folder != "")
    {
        if (TipDocSunat == 'RC')
        {
            url = "http://apps.delfingroupco.com.pe:50443/" + folder + "/" + TipDocSunat + "-" + serie + "-" + number + ".pdf";
        }
        else
        {
            url = "http://apps.delfingroupco.com.pe:50443/" + folder + "/20516667550-" + TipDocSunat + "-" + serie + "-" + number + ".pdf";
        }              
    }
    
    $('#pdfcomprobante').attr('src', url);
    $('#pdfView').modal('show');
}

//Exportar Excel libreria
function doit(title, type, fn, dl) {
    var elt = document.getElementById('data-table');
    var wb = XLSX.utils.table_to_book(elt, { sheet: "Sheet JS" });
    return dl ?
        XLSX.write(wb, { bookType: type, bookSST: true, type: 'base64' }) :
        XLSX.writeFile(wb, fn || (title + (type || 'xlsx')));
}