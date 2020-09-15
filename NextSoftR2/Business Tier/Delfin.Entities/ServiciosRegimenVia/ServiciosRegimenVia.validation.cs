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
	public partial class ServiciosRegimenVia
    {
		#region [ Variables Validación ]
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		private Boolean m_tipo_tabtdoOK;
		private String m_tipo_tabtdoMSGERROR;
		private Boolean m_tipo_codtdoOK;
		private String m_tipo_codtdoMSGERROR;
		private Boolean m_sedo_tipoOK;
		private String m_sedo_tipoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: SERV_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SERV_CodigoOK
		{
			get { return m_serv_codigoOK; }
			set
			{
				if (m_serv_codigoOK != value)
				{ m_serv_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERV_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String SERV_CodigoMSGERROR
		{
			get { return m_serv_codigoMSGERROR; }
			set
			{
				if (m_serv_codigoMSGERROR != value)
				{m_serv_codigoMSGERROR = value; }
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
		/// <summary>
		/// Gets or sets el valor de validación de: SEDO_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean SEDO_TipoOK
		{
			get { return m_sedo_tipoOK; }
			set
			{
				if (m_sedo_tipoOK != value)
				{ m_sedo_tipoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SEDO_Tipo.
		/// </summary>
		[IgnoreDataMember]
		public String SEDO_TipoMSGERROR
		{
			get { return m_sedo_tipoMSGERROR; }
			set
			{
				if (m_sedo_tipoMSGERROR != value)
				{m_sedo_tipoMSGERROR = value; }
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
				SERV_CodigoOK  = true;
				SERV_CodigoMSGERROR  = "";
				if( SERV_Codigo == 0)
				{
					_isCorrect = false;
					SERV_CodigoOK  = false;
					SERV_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SERV_Codigo", "ServiciosDocumentos");
					m_mensajeError += "* Debe ingresar el campo SERV_Codigo" + Environment.NewLine;
				}
				SEDO_TipoOK  = true;
				SEDO_TipoMSGERROR  = "";
				//if( String.IsNullOrEmpty(SEDO_Tipo) )
				//{
				//	_isCorrect = false;
				//	SEDO_TipoOK  = false;
				//	SEDO_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SEDO_Tipo", "ServiciosDocumentos");
				//	m_mensajeError += "* Debe ingresar el campo SEDO_Tipo" + Environment.NewLine;
				//}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
