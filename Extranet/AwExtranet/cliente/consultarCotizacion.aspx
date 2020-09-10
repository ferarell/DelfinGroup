<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="consultarCotizacion.aspx.vb" Inherits="AwExtranet.consultarCotizacion" %>
<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <div class="row">
            <div class="col-md-10 col-xs-9">
               <h1 class="DG-title-head"> Consultar Cotización</h1>
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
                            <label for="inputEmail3" class="col-sm-3 control-label">Pais Origen</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="countryOrigin" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                         
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Pais Destino</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="countryFinal" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                           
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Tipo Unidad</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="typeUnid" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                               
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Incoterm</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="incoterm" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                                  
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Tipo Embalaje</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="typeEmbalaje" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                           
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Peso</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapTextBox ID="peso" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                          
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Ancho</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapTextBox ID="ancho" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                          
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Volumen</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapTextBox ID="volumen" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                         
                    </div>
                    <div class="col-md-5">
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Puerto Origen</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="portOrigin" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                         
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Puerto Destino</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="portFinal" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                          
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Cantidad</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapTextBox ID="quantity" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                               
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Tipo de Carga</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="typeCarga" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                              
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Mercaderia</label>
                            <div class="col-sm-9">
                                <dx:BootstrapComboBox ID="mercaderia" runat="server"></dx:BootstrapComboBox>
                            </div>
                        </div>                           
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Largo</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapTextBox ID="largo" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                          
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Alto</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapTextBox ID="alto" runat="server"></dx:BootstrapTextBox>
                            </div>
                        </div>                          
                        <div class="form-group">
                            <label for="inputEmail3" class="col-sm-3 control-label">Importe (US$)</label>
                            <div class="col-sm-9">
                                 <dx:BootstrapTextBox ID="import" runat="server"></dx:BootstrapTextBox>
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
            </div>
        </div>
	</section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ctpScript" runat="server">
</asp:Content>
