using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using Infrastructure.Aspect;
using Infrastructure.Aspect.BusinessEntity;

namespace Delfin.Entities
{
	public partial class LoadingList
	{
		#region [ Variables Validación ]
		private Boolean m_load_shipperOK;
		private String m_load_shipperMSGERROR;
		private Boolean m_load_consigneeOK;
		private String m_load_consigneeMSGERROR;
		private Boolean m_load_notifyOK;
		private String m_load_notifyMSGERROR;
		private Boolean m_load_carrierOK;
		private String m_load_carrierMSGERROR;
		private Boolean m_load_bookingOK;
		private String m_load_bookingMSGERROR;
		private Boolean m_load_mblOK;
		private String m_load_mblMSGERROR;
		private Boolean m_load_hblOK;
		private String m_load_hblMSGERROR;
		private Boolean m_load_etaOK;
		private String m_load_etaMSGERROR;
		private Boolean m_load_etdOK;
		private String m_load_etdMSGERROR;
		private Boolean m_load_paymentOK;
		private String m_load_paymentMSGERROR;
		private Boolean m_load_naveviajeOK;
		private String m_load_naveviajeMSGERROR;
		private Boolean m_load_codigoOK;
		private String m_load_codigoMSGERROR;
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_load_contractnroOK;
		private String m_load_contractnroMSGERROR;
		private Boolean m_load_primerusuarioOK;
		private String m_load_primerusuarioMSGERROR;
		private Boolean m_load_segundookOK;
		private String m_load_segundookMSGERROR;
		private Boolean m_load_segundousuarioOK;
		private String m_load_segundousuarioMSGERROR;
		private Boolean m_load_cargausuarioOK;
		private String m_load_cargausuarioMSGERROR;
		private Boolean m_load_primerokOK;
		private String m_load_primerokMSGERROR;
		private Boolean m_load_errorOK;
		private String m_load_errorMSGERROR;
		private Boolean m_load_enviocorreoOK;
		private String m_load_enviocorreoMSGERROR;
		private Boolean m_load_enviocorreofechaOK;
		private String m_load_enviocorreofechaMSGERROR;
		private Boolean m_load_enviocorreousuarioOK;
		private String m_load_enviocorreousuarioMSGERROR;
		private Boolean m_load_errordescripcionOK;
		private String m_load_errordescripcionMSGERROR;
		private Boolean m_load_cargafechaOK;
		private String m_load_cargafechaMSGERROR;
		private Boolean m_puer_codorigenOK;
		private String m_puer_codorigenMSGERROR;
		private Boolean m_puer_coddestinoOK;
		private String m_puer_coddestinoMSGERROR;
		private Boolean m_load_fecprimerokOK;
		private String m_load_fecprimerokMSGERROR;
		private Boolean m_load_fecsegundookOK;
		private String m_load_fecsegundookMSGERROR;
		private Boolean m_nvia_codigoOK;
		private String m_nvia_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Shipper.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_ShipperOK
		{
			get { return m_load_shipperOK; }
			set
			{
				if (m_load_shipperOK != value)
				{ m_load_shipperOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Shipper.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_ShipperMSGERROR
		{
			get { return m_load_shipperMSGERROR; }
			set
			{
				if (m_load_shipperMSGERROR != value)
				{m_load_shipperMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Consignee.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_ConsigneeOK
		{
			get { return m_load_consigneeOK; }
			set
			{
				if (m_load_consigneeOK != value)
				{ m_load_consigneeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Consignee.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_ConsigneeMSGERROR
		{
			get { return m_load_consigneeMSGERROR; }
			set
			{
				if (m_load_consigneeMSGERROR != value)
				{m_load_consigneeMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Notify.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_NotifyOK
		{
			get { return m_load_notifyOK; }
			set
			{
				if (m_load_notifyOK != value)
				{ m_load_notifyOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Notify.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_NotifyMSGERROR
		{
			get { return m_load_notifyMSGERROR; }
			set
			{
				if (m_load_notifyMSGERROR != value)
				{m_load_notifyMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Carrier.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_CarrierOK
		{
			get { return m_load_carrierOK; }
			set
			{
				if (m_load_carrierOK != value)
				{ m_load_carrierOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Carrier.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_CarrierMSGERROR
		{
			get { return m_load_carrierMSGERROR; }
			set
			{
				if (m_load_carrierMSGERROR != value)
				{m_load_carrierMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Booking.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_BookingOK
		{
			get { return m_load_bookingOK; }
			set
			{
				if (m_load_bookingOK != value)
				{ m_load_bookingOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Booking.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_BookingMSGERROR
		{
			get { return m_load_bookingMSGERROR; }
			set
			{
				if (m_load_bookingMSGERROR != value)
				{m_load_bookingMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_MBL.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_MBLOK
		{
			get { return m_load_mblOK; }
			set
			{
				if (m_load_mblOK != value)
				{ m_load_mblOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_MBL.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_MBLMSGERROR
		{
			get { return m_load_mblMSGERROR; }
			set
			{
				if (m_load_mblMSGERROR != value)
				{m_load_mblMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_HBL.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_HBLOK
		{
			get { return m_load_hblOK; }
			set
			{
				if (m_load_hblOK != value)
				{ m_load_hblOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_HBL.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_HBLMSGERROR
		{
			get { return m_load_hblMSGERROR; }
			set
			{
				if (m_load_hblMSGERROR != value)
				{m_load_hblMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_ETA.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_ETAOK
		{
			get { return m_load_etaOK; }
			set
			{
				if (m_load_etaOK != value)
				{ m_load_etaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_ETA.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_ETAMSGERROR
		{
			get { return m_load_etaMSGERROR; }
			set
			{
				if (m_load_etaMSGERROR != value)
				{m_load_etaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_ETD.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_ETDOK
		{
			get { return m_load_etdOK; }
			set
			{
				if (m_load_etdOK != value)
				{ m_load_etdOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_ETD.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_ETDMSGERROR
		{
			get { return m_load_etdMSGERROR; }
			set
			{
				if (m_load_etdMSGERROR != value)
				{m_load_etdMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Payment.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_PaymentOK
		{
			get { return m_load_paymentOK; }
			set
			{
				if (m_load_paymentOK != value)
				{ m_load_paymentOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Payment.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_PaymentMSGERROR
		{
			get { return m_load_paymentMSGERROR; }
			set
			{
				if (m_load_paymentMSGERROR != value)
				{m_load_paymentMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_NaveViaje.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_NaveViajeOK
		{
			get { return m_load_naveviajeOK; }
			set
			{
				if (m_load_naveviajeOK != value)
				{ m_load_naveviajeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_NaveViaje.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_NaveViajeMSGERROR
		{
			get { return m_load_naveviajeMSGERROR; }
			set
			{
				if (m_load_naveviajeMSGERROR != value)
				{m_load_naveviajeMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_CodigoOK
		{
			get { return m_load_codigoOK; }
			set
			{
				if (m_load_codigoOK != value)
				{ m_load_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_CodigoMSGERROR
		{
			get { return m_load_codigoMSGERROR; }
			set
			{
				if (m_load_codigoMSGERROR != value)
				{m_load_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCOT_NumeroOK
		{
			get { return m_ccot_numeroOK; }
			set
			{
				if (m_ccot_numeroOK != value)
				{ m_ccot_numeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String CCOT_NumeroMSGERROR
		{
			get { return m_ccot_numeroMSGERROR; }
			set
			{
				if (m_ccot_numeroMSGERROR != value)
				{m_ccot_numeroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCOT_TipoOK
		{
			get { return m_ccot_tipoOK; }
			set
			{
				if (m_ccot_tipoOK != value)
				{ m_ccot_tipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public String CCOT_TipoMSGERROR
		{
			get { return m_ccot_tipoMSGERROR; }
			set
			{
				if (m_ccot_tipoMSGERROR != value)
				{m_ccot_tipoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_ContractNRO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_ContractNROOK
		{
			get { return m_load_contractnroOK; }
			set
			{
				if (m_load_contractnroOK != value)
				{ m_load_contractnroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_ContractNRO.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_ContractNROMSGERROR
		{
			get { return m_load_contractnroMSGERROR; }
			set
			{
				if (m_load_contractnroMSGERROR != value)
				{m_load_contractnroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_PrimerUsuario.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_PrimerUsuarioOK
		{
			get { return m_load_primerusuarioOK; }
			set
			{
				if (m_load_primerusuarioOK != value)
				{ m_load_primerusuarioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_PrimerUsuario.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_PrimerUsuarioMSGERROR
		{
			get { return m_load_primerusuarioMSGERROR; }
			set
			{
				if (m_load_primerusuarioMSGERROR != value)
				{m_load_primerusuarioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_SegundoOK.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_SegundoOKOK
		{
			get { return m_load_segundookOK; }
			set
			{
				if (m_load_segundookOK != value)
				{ m_load_segundookOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_SegundoOK.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_SegundoOKMSGERROR
		{
			get { return m_load_segundookMSGERROR; }
			set
			{
				if (m_load_segundookMSGERROR != value)
				{m_load_segundookMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_SegundoUsuario.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_SegundoUsuarioOK
		{
			get { return m_load_segundousuarioOK; }
			set
			{
				if (m_load_segundousuarioOK != value)
				{ m_load_segundousuarioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_SegundoUsuario.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_SegundoUsuarioMSGERROR
		{
			get { return m_load_segundousuarioMSGERROR; }
			set
			{
				if (m_load_segundousuarioMSGERROR != value)
				{m_load_segundousuarioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_CargaUsuario.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_CargaUsuarioOK
		{
			get { return m_load_cargausuarioOK; }
			set
			{
				if (m_load_cargausuarioOK != value)
				{ m_load_cargausuarioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_CargaUsuario.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_CargaUsuarioMSGERROR
		{
			get { return m_load_cargausuarioMSGERROR; }
			set
			{
				if (m_load_cargausuarioMSGERROR != value)
				{m_load_cargausuarioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_PrimerOK.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_PrimerOKOK
		{
			get { return m_load_primerokOK; }
			set
			{
				if (m_load_primerokOK != value)
				{ m_load_primerokOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_PrimerOK.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_PrimerOKMSGERROR
		{
			get { return m_load_primerokMSGERROR; }
			set
			{
				if (m_load_primerokMSGERROR != value)
				{m_load_primerokMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_Error.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_ErrorOK
		{
			get { return m_load_errorOK; }
			set
			{
				if (m_load_errorOK != value)
				{ m_load_errorOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_Error.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_ErrorMSGERROR
		{
			get { return m_load_errorMSGERROR; }
			set
			{
				if (m_load_errorMSGERROR != value)
				{m_load_errorMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_EnvioCorreo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_EnvioCorreoOK
		{
			get { return m_load_enviocorreoOK; }
			set
			{
				if (m_load_enviocorreoOK != value)
				{ m_load_enviocorreoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_EnvioCorreo.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_EnvioCorreoMSGERROR
		{
			get { return m_load_enviocorreoMSGERROR; }
			set
			{
				if (m_load_enviocorreoMSGERROR != value)
				{m_load_enviocorreoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_EnvioCorreoFecha.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_EnvioCorreoFechaOK
		{
			get { return m_load_enviocorreofechaOK; }
			set
			{
				if (m_load_enviocorreofechaOK != value)
				{ m_load_enviocorreofechaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_EnvioCorreoFecha.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_EnvioCorreoFechaMSGERROR
		{
			get { return m_load_enviocorreofechaMSGERROR; }
			set
			{
				if (m_load_enviocorreofechaMSGERROR != value)
				{m_load_enviocorreofechaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_EnvioCorreoUsuario.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_EnvioCorreoUsuarioOK
		{
			get { return m_load_enviocorreousuarioOK; }
			set
			{
				if (m_load_enviocorreousuarioOK != value)
				{ m_load_enviocorreousuarioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_EnvioCorreoUsuario.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_EnvioCorreoUsuarioMSGERROR
		{
			get { return m_load_enviocorreousuarioMSGERROR; }
			set
			{
				if (m_load_enviocorreousuarioMSGERROR != value)
				{m_load_enviocorreousuarioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_ErrorDescripcion.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_ErrorDescripcionOK
		{
			get { return m_load_errordescripcionOK; }
			set
			{
				if (m_load_errordescripcionOK != value)
				{ m_load_errordescripcionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_ErrorDescripcion.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_ErrorDescripcionMSGERROR
		{
			get { return m_load_errordescripcionMSGERROR; }
			set
			{
				if (m_load_errordescripcionMSGERROR != value)
				{m_load_errordescripcionMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_CargaFecha.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_CargaFechaOK
		{
			get { return m_load_cargafechaOK; }
			set
			{
				if (m_load_cargafechaOK != value)
				{ m_load_cargafechaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_CargaFecha.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_CargaFechaMSGERROR
		{
			get { return m_load_cargafechaMSGERROR; }
			set
			{
				if (m_load_cargafechaMSGERROR != value)
				{m_load_cargafechaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_CodOrigen.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PUER_CodOrigenOK
		{
			get { return m_puer_codorigenOK; }
			set
			{
				if (m_puer_codorigenOK != value)
				{ m_puer_codorigenOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_CodOrigen.
		/// </summary>
		[IgnoreDataMember]
		public String PUER_CodOrigenMSGERROR
		{
			get { return m_puer_codorigenMSGERROR; }
			set
			{
				if (m_puer_codorigenMSGERROR != value)
				{m_puer_codorigenMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_CodDestino.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PUER_CodDestinoOK
		{
			get { return m_puer_coddestinoOK; }
			set
			{
				if (m_puer_coddestinoOK != value)
				{ m_puer_coddestinoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_CodDestino.
		/// </summary>
		[IgnoreDataMember]
		public String PUER_CodDestinoMSGERROR
		{
			get { return m_puer_coddestinoMSGERROR; }
			set
			{
				if (m_puer_coddestinoMSGERROR != value)
				{m_puer_coddestinoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_FecPrimerOK.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_FecPrimerOKOK
		{
			get { return m_load_fecprimerokOK; }
			set
			{
				if (m_load_fecprimerokOK != value)
				{ m_load_fecprimerokOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_FecPrimerOK.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_FecPrimerOKMSGERROR
		{
			get { return m_load_fecprimerokMSGERROR; }
			set
			{
				if (m_load_fecprimerokMSGERROR != value)
				{m_load_fecprimerokMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: LOAD_FecSegundoOK.
		/// </summary>
		[IgnoreDataMember]
		public Boolean LOAD_FecSegundoOKOK
		{
			get { return m_load_fecsegundookOK; }
			set
			{
				if (m_load_fecsegundookOK != value)
				{ m_load_fecsegundookOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: LOAD_FecSegundoOK.
		/// </summary>
		[IgnoreDataMember]
		public String LOAD_FecSegundoOKMSGERROR
		{
			get { return m_load_fecsegundookMSGERROR; }
			set
			{
				if (m_load_fecsegundookMSGERROR != value)
				{m_load_fecsegundookMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: NVIA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean NVIA_CodigoOK
		{
			get { return m_nvia_codigoOK; }
			set
			{
				if (m_nvia_codigoOK != value)
				{ m_nvia_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: NVIA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String NVIA_CodigoMSGERROR
		{
			get { return m_nvia_codigoMSGERROR; }
			set
			{
				if (m_nvia_codigoMSGERROR != value)
				{m_nvia_codigoMSGERROR = value; }
			}
		}
		#endregion

		#region [ Validacion ]
		private String m_mensajeError;
		
		[DataMember]
		public String MensajeError
		{
			get { return m_mensajeError; }
		}
		public Boolean Validar()
		{
			try
			{
				Boolean _isCorrect = true;
				m_mensajeError = "";
				LOAD_ShipperOK  = true;
				LOAD_ShipperMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_Shipper) )
				{
					_isCorrect = false;
					LOAD_ShipperOK  = false;
					LOAD_ShipperMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Shipper", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_Shipper" + Environment.NewLine;
				}
				LOAD_ConsigneeOK  = true;
				LOAD_ConsigneeMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_Consignee) )
				{
					_isCorrect = false;
					LOAD_ConsigneeOK  = false;
					LOAD_ConsigneeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Consignee", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_Consignee" + Environment.NewLine;
				}
				LOAD_NotifyOK  = true;
				LOAD_NotifyMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_Notify) )
				{
					_isCorrect = false;
					LOAD_NotifyOK  = false;
					LOAD_NotifyMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Notify", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_Notify" + Environment.NewLine;
				}
				LOAD_CarrierOK  = true;
				LOAD_CarrierMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_Carrier) )
				{
					_isCorrect = false;
					LOAD_CarrierOK  = false;
					LOAD_CarrierMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Carrier", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_Carrier" + Environment.NewLine;
				}
				LOAD_BookingOK  = true;
				LOAD_BookingMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_Booking) )
				{
					_isCorrect = false;
					LOAD_BookingOK  = false;
					LOAD_BookingMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Booking", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_Booking" + Environment.NewLine;
				}
				LOAD_MBLOK  = true;
				LOAD_MBLMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_MBL) )
				{
					_isCorrect = false;
					LOAD_MBLOK  = false;
					LOAD_MBLMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_MBL", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_MBL" + Environment.NewLine;
				}
				LOAD_HBLOK  = true;
				LOAD_HBLMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_HBL) )
				{
					_isCorrect = false;
					LOAD_HBLOK  = false;
					LOAD_HBLMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_HBL", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_HBL" + Environment.NewLine;
				}
				LOAD_PaymentOK  = true;
				LOAD_PaymentMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_Payment) )
				{
					_isCorrect = false;
					LOAD_PaymentOK  = false;
					LOAD_PaymentMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Payment", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_Payment" + Environment.NewLine;
				}
				LOAD_NaveViajeOK  = true;
				LOAD_NaveViajeMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_NaveViaje) )
				{
					_isCorrect = false;
					LOAD_NaveViajeOK  = false;
					LOAD_NaveViajeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_NaveViaje", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_NaveViaje" + Environment.NewLine;
				}
				LOAD_CodigoOK  = true;
				LOAD_CodigoMSGERROR  = "";
				if( LOAD_Codigo == 0)
				{
					_isCorrect = false;
					LOAD_CodigoOK  = false;
					LOAD_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_Codigo", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_Codigo" + Environment.NewLine;
				}
				LOAD_ContractNROOK  = true;
				LOAD_ContractNROMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_ContractNRO) )
				{
					_isCorrect = false;
					LOAD_ContractNROOK  = false;
					LOAD_ContractNROMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_ContractNRO", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_ContractNRO" + Environment.NewLine;
				}
				LOAD_ErrorDescripcionOK  = true;
				LOAD_ErrorDescripcionMSGERROR  = "";
				if( String.IsNullOrEmpty(LOAD_ErrorDescripcion) )
				{
					_isCorrect = false;
					LOAD_ErrorDescripcionOK  = false;
					LOAD_ErrorDescripcionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "LOAD_ErrorDescripcion", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo LOAD_ErrorDescripcion" + Environment.NewLine;
				}
				NVIA_CodigoOK  = true;
				NVIA_CodigoMSGERROR  = "";
				if( NVIA_Codigo == 0)
				{
					_isCorrect = false;
					NVIA_CodigoOK  = false;
					NVIA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "NVIA_Codigo", "LoadingList");
					m_mensajeError += "* Debe ingresar el campo NVIA_Codigo" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
