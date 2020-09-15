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
	public partial class Series
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_seri_serieOK;
		private String m_seri_serieMSGERROR;
		private Boolean m_sucr_codigoOK;
		private String m_sucr_codigoMSGERROR;
		private Boolean m_seri_ultnumeroOK;
		private String m_seri_ultnumeroMSGERROR;
		private Boolean m_seri_maxitemsOK;
		private String m_seri_maxitemsMSGERROR;
		private Boolean m_seri_numinicialOK;
		private String m_seri_numinicialMSGERROR;
		private Boolean m_seri_numfinalOK;
		private String m_seri_numfinalMSGERROR;
		private Boolean m_seri_descOK;
		private String m_seri_descMSGERROR;
		private Boolean m_seri_activoOK;
		private String m_seri_activoMSGERROR;
		private Boolean m_seri_tipofacturacionOK;
		private String m_seri_tipofacturacionMSGERROR;
		private Boolean m_seri_unidadnegocioOK;
		private String m_seri_unidadnegocioMSGERROR;
		private Boolean m_seri_impresoraOK;
		private String m_seri_impresoraMSGERROR;
		private Boolean m_tipo_tabtdoOK;
		private String m_tipo_tabtdoMSGERROR;
		private Boolean m_tipo_codtdoOK;
		private String m_tipo_codtdoMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
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
		/// Gets or sets el valor de validación de: SERI_Serie.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_SerieOK
		{
			get { return m_seri_serieOK; }
			set
			{
				if (m_seri_serieOK != value)
				{ m_seri_serieOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_Serie.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_SerieMSGERROR
		{
			get { return m_seri_serieMSGERROR; }
			set
			{
				if (m_seri_serieMSGERROR != value)
				{m_seri_serieMSGERROR = value; }
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
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_UltNumero.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_UltNumeroOK
		{
			get { return m_seri_ultnumeroOK; }
			set
			{
				if (m_seri_ultnumeroOK != value)
				{ m_seri_ultnumeroOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_UltNumero.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_UltNumeroMSGERROR
		{
			get { return m_seri_ultnumeroMSGERROR; }
			set
			{
				if (m_seri_ultnumeroMSGERROR != value)
				{m_seri_ultnumeroMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_MaxItems.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_MaxItemsOK
		{
			get { return m_seri_maxitemsOK; }
			set
			{
				if (m_seri_maxitemsOK != value)
				{ m_seri_maxitemsOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_MaxItems.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_MaxItemsMSGERROR
		{
			get { return m_seri_maxitemsMSGERROR; }
			set
			{
				if (m_seri_maxitemsMSGERROR != value)
				{m_seri_maxitemsMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_NumInicial.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_NumInicialOK
		{
			get { return m_seri_numinicialOK; }
			set
			{
				if (m_seri_numinicialOK != value)
				{ m_seri_numinicialOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_NumInicial.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_NumInicialMSGERROR
		{
			get { return m_seri_numinicialMSGERROR; }
			set
			{
				if (m_seri_numinicialMSGERROR != value)
				{m_seri_numinicialMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_NumFinal.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_NumFinalOK
		{
			get { return m_seri_numfinalOK; }
			set
			{
				if (m_seri_numfinalOK != value)
				{ m_seri_numfinalOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_NumFinal.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_NumFinalMSGERROR
		{
			get { return m_seri_numfinalMSGERROR; }
			set
			{
				if (m_seri_numfinalMSGERROR != value)
				{m_seri_numfinalMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_Desc.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_DescOK
		{
			get { return m_seri_descOK; }
			set
			{
				if (m_seri_descOK != value)
				{ m_seri_descOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_Desc.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_DescMSGERROR
		{
			get { return m_seri_descMSGERROR; }
			set
			{
				if (m_seri_descMSGERROR != value)
				{m_seri_descMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_Activo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_ActivoOK
		{
			get { return m_seri_activoOK; }
			set
			{
				if (m_seri_activoOK != value)
				{ m_seri_activoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_Activo.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_ActivoMSGERROR
		{
			get { return m_seri_activoMSGERROR; }
			set
			{
				if (m_seri_activoMSGERROR != value)
				{m_seri_activoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_TipoFacturacion.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_TipoFacturacionOK
		{
			get { return m_seri_tipofacturacionOK; }
			set
			{
				if (m_seri_tipofacturacionOK != value)
				{ m_seri_tipofacturacionOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_TipoFacturacion.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_TipoFacturacionMSGERROR
		{
			get { return m_seri_tipofacturacionMSGERROR; }
			set
			{
				if (m_seri_tipofacturacionMSGERROR != value)
				{m_seri_tipofacturacionMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_UnidadNegocio.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_UnidadNegocioOK
		{
			get { return m_seri_unidadnegocioOK; }
			set
			{
				if (m_seri_unidadnegocioOK != value)
				{ m_seri_unidadnegocioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_UnidadNegocio.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_UnidadNegocioMSGERROR
		{
			get { return m_seri_unidadnegocioMSGERROR; }
			set
			{
				if (m_seri_unidadnegocioMSGERROR != value)
				{m_seri_unidadnegocioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERI_Impresora.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERI_ImpresoraOK
		{
			get { return m_seri_impresoraOK; }
			set
			{
				if (m_seri_impresoraOK != value)
				{ m_seri_impresoraOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERI_Impresora.
		/// </summary>
		[IgnoreDataMember]
		public String SERI_ImpresoraMSGERROR
		{
			get { return m_seri_impresoraMSGERROR; }
			set
			{
				if (m_seri_impresoraMSGERROR != value)
				{m_seri_impresoraMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabTDO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabTDOOK
		{
			get { return m_tipo_tabtdoOK; }
			set
			{
				if (m_tipo_tabtdoOK != value)
				{ m_tipo_tabtdoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabTDO.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabTDOMSGERROR
		{
			get { return m_tipo_tabtdoMSGERROR; }
			set
			{
				if (m_tipo_tabtdoMSGERROR != value)
				{m_tipo_tabtdoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodTDO.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodTDOOK
		{
			get { return m_tipo_codtdoOK; }
			set
			{
				if (m_tipo_codtdoOK != value)
				{ m_tipo_codtdoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTDO.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodTDOMSGERROR
		{
			get { return m_tipo_codtdoMSGERROR; }
			set
			{
				if (m_tipo_codtdoMSGERROR != value)
				{m_tipo_codtdoMSGERROR = value; }
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
				EMPR_CodigoOK  = true;
				EMPR_CodigoMSGERROR  = "";
				if( EMPR_Codigo == null)
				{
					_isCorrect = false;
					EMPR_CodigoOK  = false;
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Empresa", "Series");
               m_mensajeError += "* Debe ingresar el campo Empresa" + Environment.NewLine;
				}
				SERI_SerieOK  = true;
				SERI_SerieMSGERROR  = "";
				if( String.IsNullOrEmpty(SERI_Serie) )
				{
					_isCorrect = false;
					SERI_SerieOK  = false;
					SERI_SerieMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Serie", "Series");
               m_mensajeError += "* Debe ingresar el campo Serie" + Environment.NewLine;
				}
				SERI_UltNumeroOK  = true;
				SERI_UltNumeroMSGERROR  = "";
				if( SERI_UltNumero == null)
				{
					_isCorrect = false;
					SERI_UltNumeroOK  = false;
					SERI_UltNumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "último número", "Series");
               m_mensajeError += "* Debe ingresar el campo último número" + Environment.NewLine;
				}
				SERI_MaxItemsOK  = true;
				SERI_MaxItemsMSGERROR  = "";
				if( SERI_MaxItems == null)
				{
					_isCorrect = false;
					SERI_MaxItemsOK  = false;
					SERI_MaxItemsMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "máximo numero de items", "Series");
               m_mensajeError += "* Debe ingresar el campo máximo numero de items" + Environment.NewLine;
				}
				SERI_NumInicialOK  = true;
				SERI_NumInicialMSGERROR  = "";
				if( SERI_NumInicial == null)
				{
					_isCorrect = false;
					SERI_NumInicialOK  = false;
					SERI_NumInicialMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "número inicial", "Series");
               m_mensajeError += "* Debe ingresar el campo número inicial" + Environment.NewLine;
				}
				SERI_NumFinalOK  = true;
				SERI_NumFinalMSGERROR  = "";
				if( SERI_NumFinal == null)
				{
					_isCorrect = false;
					SERI_NumFinalOK  = false;
					SERI_NumFinalMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "número final", "Series");
               m_mensajeError += "* Debe ingresar el campo número final" + Environment.NewLine;
				}
				SERI_DescOK  = true;
				SERI_DescMSGERROR  = "";
				if( String.IsNullOrEmpty(SERI_Desc) )
				{
					_isCorrect = false;
					SERI_DescOK  = false;
					SERI_DescMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "descripción", "Series");
               m_mensajeError += "* Debe ingresar el campo descripción" + Environment.NewLine;
				}
				SERI_TipoFacturacionOK  = true;
				SERI_TipoFacturacionMSGERROR  = "";
            //if( String.IsNullOrEmpty(SERI_TipoFacturacion) )
            //{
            //   _isCorrect = false;
            //   SERI_TipoFacturacionOK  = false;
            //   SERI_TipoFacturacionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "tipo de facturación", "Series");
            //   m_mensajeError += "* Debe ingresar el campo tipo de facturación" + Environment.NewLine;
            //}
				TIPO_TabTDOOK  = true;
				TIPO_TabTDOMSGERROR  = "";
            //if( String.IsNullOrEmpty(TIPO_TabTDO) )
            //{
            //   _isCorrect = false;
            //   TIPO_TabTDOOK  = false;
            //   TIPO_TabTDOMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabTDO", "Series");
            //   m_mensajeError += "* Debe ingresar el campo TIPO_TabTDO" + Environment.NewLine;
            //}
				TIPO_CodTDOOK  = true;
				TIPO_CodTDOMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodTDO) )
				{
					_isCorrect = false;
					TIPO_CodTDOOK  = false;
					TIPO_CodTDOMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "tipo de documento", "Series");
               m_mensajeError += "* Debe ingresar el campo tipo de documento" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
