<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="estado-hbl.aspx.vb" Inherits="AwExtranet.estado_hbl" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <section class="content-header">
		<h1>Estado del HBL</h1>
	</section>
    <section class="content" style="padding-top: 30px;">
		<div class="box">
            <div class="box-body">
                <div class="row">
                    <div class="col-md-4">
                        <label>Cliente</label>
                        <dx:BootstrapComboBox ID="cbo_client" runat="server"></dx:BootstrapComboBox>
                    </div>
                    <div class="col-md-4">
                        <label>Número HBL</label>
                        <dx:BootstrapTextBox ID="txt_hbl" runat="server"></dx:BootstrapTextBox>
                    </div> 
                    <div class="col-md-1">
                        <label>&nbsp;</label>
                        <dx:BootstrapButton ID="btn_export2" runat="server" AutoPostBack="false" Text="Consultar">
                            <CssClasses Control="form-control btn btn-block btn-primary " />
                        </dx:BootstrapButton>

                        <dx:BootstrapButton ID="btn_export" runat="server" AutoPostBack="false" Text="Exportar">
                            <CssClasses Control="form-control btn btn-block btn-primary hidden" />
                        </dx:BootstrapButton>
                        
                    </div> 
                    <div class="col-md-8 aviso-llegada" style="display:none">
                        <table class="table table-bordered" >
                            <tr>
                                <td class="table-hbl"><label>Nave</label></td>
                                <td style="width:50%; background: #eeeeee;" id="nave"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Viaje - Vuelo</label></td>
                                <td id="viaje" style="background: #fafafa;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Fecha ETA/ETD</label></td>
                                <td id="eta" style="background: #eeeeee;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Transportista</label></td>
                                <td id="transportista" style="background: #fafafa;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>VoBo</label></td>
                                <td id="vobo" style="background: #eeeeee;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Terminal portuario</label></td>
                                <td id="terminal" style="background: #fafafa;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Depósito</label></td>
                                <td id="deposito" style="background: #eeeeee;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Fecha cierre direccionamiento</label></td>
                                <td id="fechacierre" style="background: #fafafa;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Emisión HBL</label></td>
                                <td id="hbl" style="background: #eeeeee;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Transmisión aduana</label></td>
                                <td id="tranmision" style="background: #fafafa;"></td>
                            </tr>
                            <tr>
                                <td class="table-hbl"><label>Entrega de desglose al agente marítimo</label></td>
                                <td id="agente" style="background: #eeeeee;"></td>
                            </tr>
                        </table>
                    </div>
                    <div class="col-md-10 iframe-hbl" style="display:none; padding-top:2%">
                        <dx:BootstrapTextBox ID="hdPdfHBL" runat="server">
                            <CssClasses Control="hidden" />
                        </dx:BootstrapTextBox>        
                        <iframe id ="ifPdfHBL" style="width:100%; height:800px" frameborder="0"></iframe>
                    </div>  
			    </div>
			</div>
        </div>
	</section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
