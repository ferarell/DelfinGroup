<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="solicitud-de-autorizaciones.aspx.vb" Inherits="AwExtranet.solicitud_de_autorizaciones" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="content-header">
        <div class="row">
            <div class="col-md-10 col-xs-9">
               <h1 class="DG-title-head"> Solicitud de Autorizaciones <small> / Listado</small></h1>
            </div>
            <div class="col-md-2 col-xs-3">
                <dx:BootstrapButton ID="btnNew" runat="server" AutoPostBack="False" Text="Nuevo">
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
                        <dx:BootstrapComboBox ID="cbo_client" runat="server"></dx:BootstrapComboBox>
                    </div>
                    <div class="col-md-4">
                        <label>Tipo de Autorización</label>
                        <dx:BootstrapComboBox ID="cbo_type" runat="server"></dx:BootstrapComboBox>
                    </div>
                    <div class="col-md-1">
                        <label>&nbsp;</label>
                        <dx:BootstrapButton ID="btn_search" runat="server" AutoPostBack="false" Text="Buscar">
                            <CssClasses Control="form-control btn btn-block btn-primary " />
                        </dx:BootstrapButton>
                    </div>
			    </div>
            </div>
            <div class="box-body">
                <div class="row">
                    <div class="col-md-12">
                        <div class="fix-table">
                            <dx:BootstrapGridView ID="tblAuthorizationList" runat="server" AutoGenerateColumns="False">
                                <SettingsDataSecurity AllowEdit="True" />
                                <Columns>
                                    <dx:BootstrapGridViewTextColumn Caption="Tipo Vinculación" VisibleIndex="2">
                                    </dx:BootstrapGridViewTextColumn>
                                    <dx:BootstrapGridViewTextColumn Caption="Razón Social" VisibleIndex="3">
                                    </dx:BootstrapGridViewTextColumn>
                                    <dx:BootstrapGridViewTextColumn Caption="Tipo Vigencia" VisibleIndex="4">
                                    </dx:BootstrapGridViewTextColumn>
                                    <dx:BootstrapGridViewTextColumn Caption="Vigencia" VisibleIndex="5">
                                    </dx:BootstrapGridViewTextColumn>
                                </Columns>
                            </dx:BootstrapGridView>
                        </div>                        
                    </div>
                </div>
			</div>
        </div>
	</section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
