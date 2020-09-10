<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="estado-cuenta.aspx.vb" Inherits="AwExtranet.estado_cuenta" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
		<h1>Estado de Cuenta</h1>
	</section> 
    <section class="content" style="padding-top: 30px;">
		<div class="box">
			<div class="box-header">                    
			    <div class="row">
                    <div class="col-md-3">
                        <label>Cliente</label>
                        <dx:BootstrapComboBox ID="cbo_client" runat="server"></dx:BootstrapComboBox>
                    </div>
                    <div class="col-md-3">
                        <label>Fecha de emisión</label>
                        <div class="input-group">                                              
                            <dx:BootstrapTextBox ID="dateInit" runat="server"></dx:BootstrapTextBox>
                            <div class="input-group-addon">Hasta</div>
                            <dx:BootstrapTextBox ID="dataEnd" runat="server"></dx:BootstrapTextBox>
                        </div>
                    </div>                    
                    <div class="col-md-3">
                        <label>Tipo de consulta</label>
                        <dx:BootstrapComboBox ID="cboType" runat="server" SelectedIndex="1">
                            <Items>
                                <dx:BootstrapListEditItem Text="Todo" Value="T">
                                </dx:BootstrapListEditItem>
                                <dx:BootstrapListEditItem Text="Pendiente" Value="P">
                                </dx:BootstrapListEditItem>
                                <dx:BootstrapListEditItem Text="Cancelado" Value="C">
                                </dx:BootstrapListEditItem>
                            </Items>
                        </dx:BootstrapComboBox>
                    </div>
                    <div class="col-md-1">
                        <label>&nbsp;</label>                       
                        <dx:BootstrapButton ID="btn_search" runat="server" AutoPostBack="false" Text="Consultar">
                            <CssClasses Control="form-control btn btn-block btn-primary " />
                        </dx:BootstrapButton>
                    </div>  
                    <div class="col-md-1">
                        <label>&nbsp;</label>                       
                        <dx:BootstrapButton ID="btn_export" runat="server" AutoPostBack="false" Text="Exportar">
                            <CssClasses Control="form-control btn btn-block btn-primary " />
                        </dx:BootstrapButton>
                    </div>  
			    </div>
            </div>
            <div class="box-body">
                <div class="box">
                    <div class="fix-table" id ="tblConsultant"></div>  
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
                    <p style="font-size:27px">Cargando...</p>
                    <p></p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
