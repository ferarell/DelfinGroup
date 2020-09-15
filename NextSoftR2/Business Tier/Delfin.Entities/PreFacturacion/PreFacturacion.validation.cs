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
	public partial class PreFacturacion
	{
		#region [ Variables Validación ]
		private Boolean m_pfac_numeroOK;
		private String m_pfac_numeroMSGERROR;
		private Boolean m_pfac_fecemiOK;
		private String m_pfac_fecemiMSGERROR;
		private Boolean m_pfac_estadoOK;
		private String m_pfac_estadoMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_pfac_fecaprobacionOK;
		private String m_pfac_fecaprobacionMSGERROR;
		private Boolean m_pfac_feccancelacionOK;
		private String m_pfac_feccancelacionMSGERROR;
		private Boolean m_pfac_usrcancelacionOK;
		private String m_pfac_usrcancelacionMSGERROR;
		private Boolean m_pfac_usraprobacionOK;
		private String m_pfac_usraprobacionMSGERROR;
		private Boolean m_nvia_codigoOK;
		private String m_nvia_codigoMSGERROR;
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_sucr_codigoOK;
		private String m_sucr_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: PFAC_Numero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PFAC_NumeroOK
		{
			get { return m_pfac_numeroOK; }
			set
			{
				if (m_pfac_numeroOK != value)
				{ m_pfac_numeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PFAC_Numero.
		/// </summary>
		[IgnoreDataMember]
		public String PFAC_NumeroMSGERROR
		{
			get { return m_pfac_numeroMSGERROR; }
			set
			{
				if (m_pfac_numeroMSGERROR != value)
				{m_pfac_numeroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PFAC_FecEmi.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PFAC_FecEmiOK
		{
			get { return m_pfac_fecemiOK; }
			set
			{
				if (m_pfac_fecemiOK != value)
				{ m_pfac_fecemiOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PFAC_FecEmi.
		/// </summary>
		[IgnoreDataMember]
		public String PFAC_FecEmiMSGERROR
		{
			get { return m_pfac_fecemiMSGERROR; }
			set
			{
				if (m_pfac_fecemiMSGERROR != value)
				{m_pfac_fecemiMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PFAC_Estado.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PFAC_EstadoOK
		{
			get { return m_pfac_estadoOK; }
			set
			{
				if (m_pfac_estadoOK != value)
				{ m_pfac_estadoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PFAC_Estado.
		/// </summary>
		[IgnoreDataMember]
		public String PFAC_EstadoMSGERROR
		{
			get { return m_pfac_estadoMSGERROR; }
			set
			{
				if (m_pfac_estadoMSGERROR != value)
				{m_pfac_estadoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PFAC_FecAprobacion.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PFAC_FecAprobacionOK
		{
			get { return m_pfac_fecaprobacionOK; }
			set
			{
				if (m_pfac_fecaprobacionOK != value)
				{ m_pfac_fecaprobacionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PFAC_FecAprobacion.
		/// </summary>
		[IgnoreDataMember]
		public String PFAC_FecAprobacionMSGERROR
		{
			get { return m_pfac_fecaprobacionMSGERROR; }
			set
			{
				if (m_pfac_fecaprobacionMSGERROR != value)
				{m_pfac_fecaprobacionMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PFAC_FecCancelacion.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PFAC_FecCancelacionOK
		{
			get { return m_pfac_feccancelacionOK; }
			set
			{
				if (m_pfac_feccancelacionOK != value)
				{ m_pfac_feccancelacionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PFAC_FecCancelacion.
		/// </summary>
		[IgnoreDataMember]
		public String PFAC_FecCancelacionMSGERROR
		{
			get { return m_pfac_feccancelacionMSGERROR; }
			set
			{
				if (m_pfac_feccancelacionMSGERROR != value)
				{m_pfac_feccancelacionMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PFAC_UsrCancelacion.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PFAC_UsrCancelacionOK
		{
			get { return m_pfac_usrcancelacionOK; }
			set
			{
				if (m_pfac_usrcancelacionOK != value)
				{ m_pfac_usrcancelacionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PFAC_UsrCancelacion.
		/// </summary>
		[IgnoreDataMember]
		public String PFAC_UsrCancelacionMSGERROR
		{
			get { return m_pfac_usrcancelacionMSGERROR; }
			set
			{
				if (m_pfac_usrcancelacionMSGERROR != value)
				{m_pfac_usrcancelacionMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PFAC_UsrAprobacion.
		/// </summary>
		[IgnoreDataMember]
		public Boolean PFAC_UsrAprobacionOK
		{
			get { return m_pfac_usraprobacionOK; }
			set
			{
				if (m_pfac_usraprobacionOK != value)
				{ m_pfac_usraprobacionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PFAC_UsrAprobacion.
		/// </summary>
		[IgnoreDataMember]
		public String PFAC_UsrAprobacionMSGERROR
		{
			get { return m_pfac_usraprobacionMSGERROR; }
			set
			{
				if (m_pfac_usraprobacionMSGERROR != value)
				{m_pfac_usraprobacionMSGERROR = value; }
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
		/// Gets or sets el valor de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EMPR_CodigoOK
		{
			get { return m_empr_codigoOK; }
			set
			{
				if (m_empr_codigoOK != value)
				{ m_empr_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String EMPR_CodigoMSGERROR
		{
			get { return m_empr_codigoMSGERROR; }
			set
			{
				if (m_empr_codigoMSGERROR != value)
				{m_empr_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SUCR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SUCR_CodigoOK
		{
			get { return m_sucr_codigoOK; }
			set
			{
				if (m_sucr_codigoOK != value)
				{ m_sucr_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SUCR_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String SUCR_CodigoMSGERROR
		{
			get { return m_sucr_codigoMSGERROR; }
			set
			{
				if (m_sucr_codigoMSGERROR != value)
				{m_sucr_codigoMSGERROR = value; }
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
				PFAC_NumeroOK  = true;
				PFAC_NumeroMSGERROR  = "";
				if( String.IsNullOrEmpty(PFAC_Numero) )
				{
					_isCorrect = false;
					PFAC_NumeroOK  = false;
					PFAC_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PFAC_Numero", "PreFacturacion");
					m_mensajeError += "* Debe ingresar el campo PFAC_Numero" + Environment.NewLine;
				}
				PFAC_EstadoOK  = true;
				PFAC_EstadoMSGERROR  = "";
				if( String.IsNullOrEmpty(PFAC_Estado) )
				{
					_isCorrect = false;
					PFAC_EstadoOK  = false;
					PFAC_EstadoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PFAC_Estado", "PreFacturacion");
					m_mensajeError += "* Debe ingresar el campo PFAC_Estado" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
