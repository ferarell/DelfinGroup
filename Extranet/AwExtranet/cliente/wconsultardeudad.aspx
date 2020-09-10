<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="wconsultardeudad.aspx.vb" Inherits="AwExtranet.wconsultardeudad" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
		<h1>Deuda del cliente</h1>
	</section>
    <section class="content" style="padding-top: 30px;">
		<div class="box">
			<div class="box-header">                    
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
                        <dx:BootstrapButton ID="btn_search" runat="server" AutoPostBack="false" Text="Buscar">
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
