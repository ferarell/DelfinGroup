<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="vinculacion_empresa_registro.aspx.vb" Inherits="AwExtranet.vinculacion_empresa_registro" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <div class="row">
            <div class="col-md-10 col-xs-9">
               <h1 class="DG-title-head">Vinculación de empresa <small> / Registro</small></h1>
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
                            <label for="inputEmail3" class="col-sm-3 control-label">Tipo documento</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="typeDocument" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                         
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Empresa</label>
                            <div class="col-sm-9">
                                <dx:BootstrapTextBox ID="bussines" runat="server" Enabled="True" ReadOnly="True"></dx:BootstrapTextBox>
                            </div>
                        </div>                            
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Correo</label>
                            <div class="col-sm-9">
                                <dx:BootstrapTextBox ID="email" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                      
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Tipo vigencia</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapComboBox ID="validityRate" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Nro documento</label>
                            <div class="col-sm-9">
                                <dx:BootstrapTextBox ID="number_document" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                         
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Contacto</label>
                            <div class="col-sm-9">
                                <dx:BootstrapTextBox ID="contact" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                          
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Tipo vinculación</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapComboBox ID="typeBonding" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                             
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Vigencia</label>
                            <div class="col-sm-9">
                                 <div class="input-group">                                              
                                    <dx:BootstrapTextBox ID="dateInit" runat="server"></dx:BootstrapTextBox>
                                    <div class="input-group-addon">Hasta</div>
                                    <dx:BootstrapTextBox ID="dataEnd" runat="server"></dx:BootstrapTextBox>
                                </div>
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
