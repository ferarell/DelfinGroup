<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="wactualizardatos.aspx.vb" Inherits="AwExtranet.wactualizardatos" %>

<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web" Assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
		<h1 >Registro / Actualización de Datos del Cliente</h1>
	</section>
	<section class="content" style="padding-top: 30px;">
		<div class="row">
			<div class="col-xs-12">
				<div class="box">
					<div class="box-body">                    
						<div class="nav-tabs-custom">
							<ul class="nav nav-tabs">
								<li class="active"><a href="#general" data-toggle="tab">Datos Generales</a></li>
								<li><a href="#address" data-toggle="tab">Dirección</a></li>
								<li><a href="#contacts" data-toggle="tab">Contactos</a></li>
							</ul>
							<div class="tab-content">
								<div class="tab-pane active" id="general">
									<div class="row">
                                     <div class="col-md-12">
                                        <div class="box-body">
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Tipo Documento</label>
                                                    <div class="col-sm-9">
                                                        <dx:BootstrapComboBox ID="typeDocument" runat="server"></dx:BootstrapComboBox>
                                                    </div>
                                                </div>
            
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Razon Social</label>
                                                    <div class="col-sm-9">
                                                        <dx:BootstrapTextBox ID="legalName" runat="server"></dx:BootstrapTextBox>
                                                    </div>
                                                </div>
                                  
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Teléfono</label>
                                                    <div class="col-sm-9">
                                                        <dx:BootstrapTextBox ID="phone" runat="server"></dx:BootstrapTextBox>
                                                    </div>
                                                </div>
                                            </div>
                                
                                            <div class="col-md-6">
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Nro Documento</label>
                                                    <div class="col-sm-9">
                                                        <dx:BootstrapTextBox ID="number_document" runat="server"></dx:BootstrapTextBox>
                                                    </div>
                                                </div>
                                  
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Correo</label>
                                                    <div class="col-sm-9">
                                                        <dx:BootstrapTextBox ID="email" runat="server"></dx:BootstrapTextBox>
                                                    </div>
                                                </div>
                                  
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Sitio Web</label>
                                                    <div class="col-sm-9">
                                                        <dx:BootstrapTextBox ID="web" runat="server"></dx:BootstrapTextBox>
                                                    </div>
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
                                                    <dx:BootstrapGridView ID="tableAdress" runat="server" AutoGenerateColumns="False">
                                                        <Columns>
                                                            <dx:BootstrapGridViewCommandColumn SelectAllCheckboxMode="Page" ShowSelectCheckbox="True" VisibleIndex="0">
                                                            </dx:BootstrapGridViewCommandColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Establecimiento" VisibleIndex="1">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Domicilio Fiscal" VisibleIndex="2">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Dirección" VisibleIndex="3">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Número" VisibleIndex="4">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Interior" VisibleIndex="5">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Urbanización" VisibleIndex="6">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Provincia" VisibleIndex="7">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Departamento" VisibleIndex="8">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Distrito" VisibleIndex="9">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Mapa" VisibleIndex="10">
                                                            </dx:BootstrapGridViewTextColumn>
                                                        </Columns>
                                                    </dx:BootstrapGridView>
                                                </div>
                                            </div>
										</div>
									</div>
								</div>

                                <div class="tab-pane" id="contacts">
								    <div class="row">											
										<div class="col-md-12">
                                            <div>
                                                <div class="box-header with-border">
                                                   <dx:BootstrapButton ID="deleteContacts" runat="server" AutoPostBack="false">
                                                        <CssClasses Icon="fa fa-trash" />
                                                        <SettingsBootstrap Sizing="Normal" />
                                                    </dx:BootstrapButton>
                                                    <dx:BootstrapButton ID="newContacts" runat="server" AutoPostBack="false" Text="Nuevo">
                                                        <CssClasses Icon="fa fa-plus" Control="pull-right" />
                                                        <SettingsBootstrap Sizing="Normal" />
                                                    </dx:BootstrapButton>
                                                </div>
                                                <div class="box-body fix-table">
                                                    <dx:BootstrapGridView ID="BootstrapGridView1" runat="server" AutoGenerateColumns="False">
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
                                                            <dx:BootstrapGridViewTextColumn Caption="Cargo" VisibleIndex="6">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Fecha Cumpleaños" VisibleIndex="7">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Sexo" VisibleIndex="8">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Teléfono" VisibleIndex="9">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Correo" VisibleIndex="10">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Chat " VisibleIndex="11">
                                                            </dx:BootstrapGridViewTextColumn>
                                                            <dx:BootstrapGridViewTextColumn Caption="Foto" VisibleIndex="12">
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
			</div>
		</div>
	</section>	
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
