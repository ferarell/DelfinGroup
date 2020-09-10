<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="seguimiento-operativo.aspx.vb" Inherits="AwExtranet.seguimiento_operativo" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <div class="row">
            <div class="col-md-10 col-xs-9">
               <h1 class="DG-title-head"> Seguimiento Operativo</h1>
            </div>
        </div>
	</section>
    <section class="content" style="padding-top: 30px;">
		<div class="box">
			<div class="box-header">                    
			    <div class="row">
                    <div class="col-md-4">
                        <label>Cliente</label>
                        <dx:BootstrapComboBox ID="client" runat="server"></dx:BootstrapComboBox>
                    </div>
                    <div class="col-md-3">
                        <label>Número HBL</label>
                        <dx:BootstrapTextBox ID="numberHBL" runat="server"></dx:BootstrapTextBox>
                    </div>
                    <div class="col-md-1">
                        <label>&nbsp;</label>
                        <dx:BootstrapButton ID="search" runat="server" AutoPostBack="false" Text="Consultar">
                            <CssClasses Control="form-control btn btn-block btn-primary " />
                        </dx:BootstrapButton>
                    </div>
			    </div>
            </div>
            <div class="box-body">
                <div class="row">
                    <div class="col-md-3">&nbsp;</div>
                    <div class="col-md-5"  id="traking">
                        
                    </div>
                </div>
			</div>
        </div>
	</section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
