<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="solicitud-de-autorizaciones-registro.aspx.vb" Inherits="AwExtranet.solicitud_de_autorizaciones_registro" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <section class="content-header">
       <h1 > Solicitud de Autorizaciones <small> / Registro</small></h1>
	</section>
    <section class="content" style="padding-top: 30px;">
        <div class="box">
            <div class="box-body">
                <div class="nav-tabs-custom">
					<ul class="nav nav-tabs">
						<li class="active"><a href="#general" data-toggle="tab">Datos Empresa</a></li>
						<li><a href="#address" data-toggle="tab">Personal Autorizado</a></li>
					</ul>
					<div class="tab-content">
						<div class="tab-pane active" id="general">
							 <div class="row">
                                <div class="col-md-6">
                                     <div class="form-group">
                                        <label for="inputEmail3" class="col-sm-3 control-label">Cliente</label>
                                        <div class="col-sm-9">
                                            <dx:BootstrapComboBox ID="client" runat="server"></dx:BootstrapComboBox>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputEmail3" class="col-sm-3 control-label">Tipo Vinculación</label>
                                        <div class="col-sm-9">
                                            <dx:BootstrapComboBox ID="typeVinculacion" runat="server"></dx:BootstrapComboBox>
                                        </div>
                                    </div>   
                                    <div class="form-group">
                                        <label for="inputEmail3" class="col-sm-3 control-label">Tipo Vigencia</label>
                                        <div class="col-sm-9">
                                            <dx:BootstrapComboBox ID="typeVigencia" runat="server"></dx:BootstrapComboBox>
                                        </div>
                                    </div>                         
                                </div>                    
                                <div class="col-md-6">
                                    <div class="form-group">
                                        <label for="inputEmail3" class="col-sm-3 control-label">Tipo de Autorización</label>
                                        <div class="col-sm-9">
                                            <dx:BootstrapComboBox ID="typeAuthorization" runat="server"></dx:BootstrapComboBox>
                                        </div>
                                    </div>
                                     <div class="form-group">
                                        <label for="inputEmail3" class="col-sm-3 control-label">Razón Social</label>
                                        <div class="col-sm-9">
                                            <dx:BootstrapComboBox ID="businessName" runat="server"></dx:BootstrapComboBox>
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
						<div class="tab-pane" id="address">
							<div class="row">											
								<div class="col-md-12">
                                    <div>
                                        <div class="box-header with-border">
                                            <dx:BootstrapButton ID="deleteAdress" runat="server" AutoPostBack="false">
                                                <CssClasses Icon="fa fa-trash" />
                                                <SettingsBootstrap Sizing="Normal" />
                                            </dx:BootstrapButton>
                                            <dx:BootstrapButton ID="newAdress" runat="server" AutoPostBack="false" Text="Nuevo">
                                                <CssClasses Icon="fa fa-plus" Control="pull-right" />
                                                <SettingsBootstrap Sizing="Normal" />
                                            </dx:BootstrapButton>
                                        </div>
                                        <div class="box-body fix-table">
                                            <dx:BootstrapGridView ID="listPerson" runat="server" AutoGenerateColumns="False">
                                                <Columns>
                                                    <dx:BootstrapGridViewCommandColumn SelectAllCheckboxMode="Page" ShowSelectCheckbox="True" VisibleIndex="0">
                                                    </dx:BootstrapGridViewCommandColumn>
                                                    <dx:BootstrapGridViewTextColumn Caption="Tipo Documento" VisibleIndex="1">
                                                    </dx:BootstrapGridViewTextColumn>
                                                    <dx:BootstrapGridViewTextColumn Caption="Número Documento" VisibleIndex="2">
                                                    </dx:BootstrapGridViewTextColumn>
                                                    <dx:BootstrapGridViewTextColumn Caption="Nombre" VisibleIndex="3">
                                                    </dx:BootstrapGridViewTextColumn>
                                                    <dx:BootstrapGridViewTextColumn Caption="Apellido Paterno" VisibleIndex="4">
                                                    </dx:BootstrapGridViewTextColumn>
                                                    <dx:BootstrapGridViewTextColumn Caption="Apellido Materno" VisibleIndex="5">
                                                    </dx:BootstrapGridViewTextColumn>
                                                    <dx:BootstrapGridViewTextColumn Caption="Teléfono" VisibleIndex="6">
                                                    </dx:BootstrapGridViewTextColumn>
                                                </Columns>
                                            </dx:BootstrapGridView>
                                        </div>
                                    </div>
								</div>
							</div>
						</div>                         
					</div>

				</div>
               <div class="col-md-1 pull-right">
                    <dx:BootstrapButton ID="save" runat="server" AutoPostBack="false" Text="Guardar">
                        <CssClasses Control="btn btn-block btn-primary " />
                    </dx:BootstrapButton>
				</div>      
            </div>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
