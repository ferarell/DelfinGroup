<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="direccionamiento-cargas.aspx.vb" Inherits="AwExtranet.direccionamiento_cargas" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="content-header">
        <div class="row">
            <div class="col-md-10 col-xs-9">
               <h1 class="DG-title-head"> Direccionamiento de Carga <small> / Listado</small></h1>
            </div>
            <div class="col-md-2 col-xs-3">
                <dx:BootstrapButton ID="new" runat="server" AutoPostBack="False" Text="Nuevo">
                    <CssClasses Control="pull-right btn btn-primary " Icon="fa fa-plus" />
                </dx:BootstrapButton>
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
                    <div class="col-md-12">
                        <div class="fix-table" id ="tblDireccionamiento">
                           
                        </div> 
                    </div>
                </div>
			</div>
        </div>
	</section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
