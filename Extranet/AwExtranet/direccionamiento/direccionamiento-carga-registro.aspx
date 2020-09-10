<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="direccionamiento-carga-registro.aspx.vb" Inherits="AwExtranet.direccionamiento_carga_registro" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web" Assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <div class="row">
            <div class="col-md-10 col-xs-9">
               <h1 class="DG-title-head"> Direccionamiento de Carga <small> / Registro</small></h1>
            </div>
            <div class="col-md-2 col-xs-3">
                
            </div>
        </div>
	</section>
    <section class="content" style="padding-top: 30px;">
		<div class="box">
            <div class="box-body">
                <div class="row">
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Cliente</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="client" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Tipo</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="type" runat="server" TabIndex="2">
                                    <Items>
                                        <dx:BootstrapListEditItem Text="DEPOSITO TEMPORAL" Value="0">
                                        </dx:BootstrapListEditItem>
                                        <dx:BootstrapListEditItem Text="DESCARGA DIRECTA" Value="1">
                                        </dx:BootstrapListEditItem>
                                    </Items>
                                    <ClientSideEvents ValueChanged="function(s, e) {
                                           if ($('#ContentPlaceHolder1_type_VI ').val() == 0) {
                                               $('#df').removeClass('hidden');
                                           } else {
                                               $('#df').addClass('hidden');
                                           }
                                    }" />
                                </dx:BootstrapComboBox>
                            </div>
                        </div>    
                        <div class="form-group hidden" id="df">
                            <label for="inputEmail3" class="col-sm-3 control-label">Depósito Solicitado</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="depositoF" runat="server">
                                </dx:BootstrapComboBox>
                            </div>
                        </div>          
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">N° HBL</label>
                            <div class="col-sm-9">
                                <dx:BootstrapTextBox ID="txtHbl" runat="server" TabIndex="1">
                                    <ClientSideEvents LostFocus="function(s, e) {
}" />
                                </dx:BootstrapTextBox>
                            </div>
                        </div>   
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Depósito Actual</label>
                            <div class="col-sm-9">
                                <dx:BootstrapTextBox ID="depositoInit" runat="server" ReadOnly="True"></dx:BootstrapTextBox>
                                <dx:BootstrapTextBox ID="depositoInitH" runat="server">
                                    <CssClasses Control="hidden" />
                                </dx:BootstrapTextBox>
                            </div>
                        </div>          
                    </div>
                </div>
			</div>
            <div class="box-footer">
                <div class="col-md-1 pull-right">
                    <dx:BootstrapButton ID="save" runat="server" AutoPostBack="false" Text="Guardar">
                        <CssClasses Control="btn btn-block btn-primary " />
                    </dx:BootstrapButton>
				</div>     
                <div class="col-md-1 pull-right">
                    <dx:BootstrapButton ID="returnList" runat="server" AutoPostBack="false" Text="Cancelar">
                        <CssClasses Control="btn btn-block btn-default " />
                    </dx:BootstrapButton>
				</div>     
            </div>
        </div>
	</section>
    <div id ="container" style="display:none"></div>  
     <div class="modal preloadModal" tabindex="-1" role="dialog">
        <div class="modal-dialog " role="document" style="width: 478px;">
            <div class="modal-content modalEstadoCuenta">
                <div class="modal-body" style="text-align:center">
                    <img src="../static/img/load.gif" />
                    <p style="font-size:27px">Guardando...</p>
                    <p></p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
