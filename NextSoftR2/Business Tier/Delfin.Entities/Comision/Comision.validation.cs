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
	public partial class Comision
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_sucr_codigoOK;
		private String m_sucr_codigoMSGERROR;
		private Boolean m_comi_codigoOK;
		private String m_comi_codigoMSGERROR;
		private Boolean m_comi_feciniOK;
		private String m_comi_feciniMSGERROR;
		private Boolean m_comi_fecfinOK;
		private String m_comi_fecfinMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
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
		/// Gets or sets el valor de validación de: COMI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean COMI_CodigoOK
		{
			get { return m_comi_codigoOK; }
			set
			{
				if (m_comi_codigoOK != value)
				{ m_comi_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COMI_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String COMI_CodigoMSGERROR
		{
			get { return m_comi_codigoMSGERROR; }
			set
			{
				if (m_comi_codigoMSGERROR != value)
				{m_comi_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COMI_FecIni.
		/// </summary>
		[IgnoreDataMember]
		public Boolean COMI_FecIniOK
		{
			get { return m_comi_feciniOK; }
			set
			{
				if (m_comi_feciniOK != value)
				{ m_comi_feciniOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COMI_FecIni.
		/// </summary>
		[IgnoreDataMember]
		public String COMI_FecIniMSGERROR
		{
			get { return m_comi_feciniMSGERROR; }
			set
			{
				if (m_comi_feciniMSGERROR != value)
				{m_comi_feciniMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COMI_FecFin.
		/// </summary>
		[IgnoreDataMember]
		public Boolean COMI_FecFinOK
		{
			get { return m_comi_fecfinOK; }
			set
			{
				if (m_comi_fecfinOK != value)
				{ m_comi_fecfinOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COMI_FecFin.
		/// </summary>
		[IgnoreDataMember]
		public String COMI_FecFinMSGERROR
		{
			get { return m_comi_fecfinMSGERROR; }
			set
			{
				if (m_comi_fecfinMSGERROR != value)
				{m_comi_fecfinMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMND.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_TabMNDOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{ m_tipo_tabmndOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMND.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_TabMNDMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{m_tipo_tabmndMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMND.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TIPO_CodMNDOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{ m_tipo_codmndOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMND.
		/// </summary>
		[IgnoreDataMember]
		public String TIPO_CodMNDMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{m_tipo_codmndMSGERROR = value; }
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
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Comision");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				SUCR_CodigoOK  = true;
				SUCR_CodigoMSGERROR  = "";
				if( SUCR_Codigo == null)
				{
					_isCorrect = false;
					SUCR_CodigoOK  = false;
					SUCR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SUCR_Codigo", "Comision");
					m_mensajeError += "* Debe ingresar el campo SUCR_Codigo" + Environment.NewLine;
				}
				COMI_CodigoOK  = true;
				COMI_CodigoMSGERROR  = "";
            //if( COMI_Codigo == 0)
            //{
            //   _isCorrect = false;
            //   COMI_CodigoOK  = false;
            //   COMI_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "COMI_Codigo", "Comision");
            //   m_mensajeError += "* Debe ingresar el campo COMI_Codigo" + Environment.NewLine;
            //}
				COMI_FecIniOK  = true;
				COMI_FecIniMSGERROR  = "";
				if( COMI_FecIni == null)
				{
					_isCorrect = false;
					COMI_FecIniOK  = false;
					COMI_FecIniMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "COMI_FecIni", "Comision");
					m_mensajeError += "* Debe ingresar el campo COMI_FecIni" + Environment.NewLine;
				}
				COMI_FecFinOK  = true;
				COMI_FecFinMSGERROR  = "";
				if( COMI_FecFin == null)
				{
					_isCorrect = false;
					COMI_FecFinOK  = false;
					COMI_FecFinMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "COMI_FecFin", "Comision");
					m_mensajeError += "* Debe ingresar el campo COMI_FecFin" + Environment.NewLine;
				}
				TIPO_TabMNDOK  = true;
				TIPO_TabMNDMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_TabMND) )
				{
					_isCorrect = false;
					TIPO_TabMNDOK  = false;
					TIPO_TabMNDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabMND", "Comision");
					m_mensajeError += "* Debe ingresar el campo TIPO_TabMND" + Environment.NewLine;
				}
				TIPO_CodMNDOK  = true;
				TIPO_CodMNDMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodMND) )
				{
					_isCorrect = false;
					TIPO_CodMNDOK  = false;
					TIPO_CodMNDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_CodMND", "Comision");
					m_mensajeError += "* Debe ingresar el campo TIPO_CodMND" + Environment.NewLine;
				}

            if (ListDet_Comision.Count == 0)
            {
               _isCorrect = false;
               m_mensajeError += "* Debe ingresar un detalle de comisión" + Environment.NewLine;
            }

				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
