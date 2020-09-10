<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/cmsTemplate.Master" CodeBehind="comunicados.aspx.vb" Inherits="AwExtranet.comunicados" ValidateRequest="false"%>
<%@ Register Assembly="DevExpress.Web.Bootstrap.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.Bootstrap" TagPrefix="dx" %>
<%@ Register TagPrefix="dx" Namespace="DevExpress.Web" Assembly="DevExpress.Web.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
		<h1 >Comunicados</h1>
	</section>
	<section class="content" style="padding-top: 30px;">
		<div class="row">
			<div class="col-xs-12">
				<div class="box">
					<div class="box-body">                    
						<div class="nav-tabs-custom">
							<ul class="nav nav-tabs">
								<li class="active"><a href="#template" data-toggle="tab">Plantilla</a></li>
								<li><a href="#content" data-toggle="tab">Contenido</a></li>
							</ul>
							<div class="tab-content">
								<div class="tab-pane" id="content">
									<div class="row">
                                     <div class="col-md-12">
                                        <div class="box-body">
                                            <div class="col-md-10">
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Para</label>
                                                    <div class="col-sm-9">
                                                       <dx:BootstrapTextBox ID="from" runat="server"></dx:BootstrapTextBox>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Asunto</label>
                                                    <div class="col-sm-9">
                                                       <dx:BootstrapTextBox ID="subject" runat="server"></dx:BootstrapTextBox>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Titulo</label>
                                                    <div class="col-sm-9">
                                                        <dx:BootstrapTextBox ID="titleContent" runat="server"></dx:BootstrapTextBox>
                                                    </div>
                                                </div>
                                                 <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Imagen</label>
                                                     <div class="col-sm-9">
                                                        <asp:FileUpload ID="fileImage" runat="server" />
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label for="inputEmail3" class="col-sm-3 control-label">Contenido</label>                                                        
                                                    &nbsp;
                                                    <div class="col-sm-9">
                                                        <asp:TextBox ID="contentBody" runat="server" TextMode="MultiLine" CssClass="form-control click2edit"></asp:TextBox>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                      </div>                     
									</div>    
								</div>
								<div class="tab-pane active" id="template">
								    <div class="row" style="margin-top:2%">											
										<div class="col-md-4">
                                            <img class="imgTemplate" data-type ="1" src="template/mailing1.jpg" style="width:50%"/>
                                            <input class="hidden" id ="typeTemplate1" name ="typeTemplate" type="radio" value="1" />
										</div>										
										<div class="col-md-4">
                                            <img class="imgTemplate" data-type ="2" src="template/mailing2.jpg" style="width:50%" />
                                            <input class="hidden" id="typeTemplate2" name ="typeTemplate" type="radio" value="2" />
										</div>										
										<div class="col-md-4">
                                            <img class="imgTemplate" data-type ="3" src="template/mailing3.jpg" style="width:50%" />
                                            <input class="hidden"id ="typeTemplate3" name ="typeTemplate" type="radio" value="3" />
										</div>
									</div>
								</div>

							    <dx:BootstrapImage ID="BootstrapImage1" runat="server">
                                </dx:BootstrapImage>
                                <dx:BootstrapTextBox ID="templateIDhd" runat="server">
                                    <CssClasses Control="hidden" />
                                </dx:BootstrapTextBox>
                                <dx:BootstrapTextBox ID="messageHd" runat="server">
                                    <CssClasses Control="hidden" />
                                </dx:BootstrapTextBox>
							</div>
						</div>     
						<div class="col-md-1 pull-right">
                            <dx:BootstrapButton ID="save" runat="server" AutoPostBack="false" Text="Enviar">
                                <CssClasses Control="btn btn-block btn-primary " />
                            </dx:BootstrapButton>
						    <dx:BootstrapButton ID="BootstrapButton1" runat="server" AutoPostBack="false" Text="Button">
                                <CssClasses Control="hidden" />
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
