<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="listado_vinculacion_empresa.aspx.vb" Inherits="AwExtranet.listado_vinculacion_empresa" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <div class="row">
            <div class="col-md-10 col-xs-9">
               <h1 class="DG-title-head">Vinculación de empresa <small> / Listado</small></h1>
            </div>
            <div class="col-md-2 col-xs-3">
                <dx:BootstrapButton ID="btnnuevo" runat="server" AutoPostBack="false" Text="Nuevo">
                    <CssClasses Control="pull-right btn btn-primary " Icon="fa fa-plus" />
                </dx:BootstrapButton>
            </div>
        </div>
	</section>
    <section class="content" style="padding-top: 30px;">
		<div class="box">
            <div class="box-header">                    
			    <div class="row">
                    
			    </div>
            </div>
            <div class="box-body">
                <div class="row fix-table">
                    <div class="col-md-12">
                        <table id="dtconsult" class="table table-bordered table-hover dataTable" role="grid" aria-describedby="example2_info"></table>             
                    </div>
                </div>
			</div>
        </div>
	</section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
