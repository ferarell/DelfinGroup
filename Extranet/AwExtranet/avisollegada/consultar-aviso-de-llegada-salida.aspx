<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="consultar-aviso-de-llegada-salida.aspx.vb" Inherits="AwExtranet.consultar_aviso_de_llegada_salida" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="content-header">
		<h1>Aviso de llegada/salida</h1>
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
                    <div class="col-md-2">
                        <label>&nbsp;</label>
                        <dx:BootstrapButton ID="btn_preview" runat="server" AutoPostBack="false" Text="Vista previa">
                            <CssClasses Control="form-control btn btn-block btn-primary " />
                        </dx:BootstrapButton>
                        <dx:BootstrapButton ID="btn_preview2" runat="server" AutoPostBack="false" Text="Button">
                            <CssClasses Control="hidden" />
                        </dx:BootstrapButton>
                    </div>
                    <div class="col-md-10 aviso-llegada" style="display:none">
                        <dx:BootstrapTextBox ID="hdPdfAviso" runat="server">
                            <CssClasses Control="hidden" />
                        </dx:BootstrapTextBox>        
                        <iframe id ="ifPdfAviso" style="width:100%; height:800px" frameborder="0"></iframe>
                    </div>  
			    </div>                
			</div>
		</div>
	</section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>