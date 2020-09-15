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
	public partial class Excepciones
	{
		#region [ Variables Validación ]
		private Boolean m_exce_internoOK;
		private String m_exce_internoMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_exce_usrsolicitaOK;
		private String m_exce_usrsolicitaMSGERROR;
		private Boolean m_entc_codigoOK;
		private String m_entc_codigoMSGERROR;
		private Boolean m_docv_codigoOK;
		private String m_docv_codigoMSGERROR;
		private Boolean m_ccct_codigoOK;
		private String m_ccct_codigoMSGERROR;
		private Boolean m_exce_fechaOK;
		private String m_exce_fechaMSGERROR;
		private Boolean m_exce_usrOK;
		private String m_exce_usrMSGERROR;
		private Boolean m_exce_usrapruebaOK;
		private String m_exce_usrapruebaMSGERROR;
		private Boolean m_exce_montorequeridoOK;
		private String m_exce_montorequeridoMSGERROR;
		private Boolean m_exce_montoexcedidoOK;
		private String m_exce_montoexcedidoMSGERROR;
		private Boolean m_exce_fecapruebaOK;
		private String m_exce_fecapruebaMSGERROR;
		private Boolean m_exce_motivoapruebaOK;
		private String m_exce_motivoapruebaMSGERROR;
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
		/// Gets or sets el valor de validación de: EXCE_Interno.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_InternoOK
		{
			get { return m_exce_internoOK; }
			set
			{
				if (m_exce_internoOK != value)
				{ m_exce_internoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_Interno.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_InternoMSGERROR
		{
			get { return m_exce_internoMSGERROR; }
			set
			{
				if (m_exce_internoMSGERROR != value)
				{m_exce_internoMSGERROR = value; }
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
		/// Gets or sets el valor de validación de: EXCE_UsrSolicita.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_UsrSolicitaOK
		{
			get { return m_exce_usrsolicitaOK; }
			set
			{
				if (m_exce_usrsolicitaOK != value)
				{ m_exce_usrsolicitaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_UsrSolicita.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_UsrSolicitaMSGERROR
		{
			get { return m_exce_usrsolicitaMSGERROR; }
			set
			{
				if (m_exce_usrsolicitaMSGERROR != value)
				{m_exce_usrsolicitaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean ENTC_CodigoOK
		{
			get { return m_entc_codigoOK; }
			set
			{
				if (m_entc_codigoOK != value)
				{ m_entc_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String ENTC_CodigoMSGERROR
		{
			get { return m_entc_codigoMSGERROR; }
			set
			{
				if (m_entc_codigoMSGERROR != value)
				{m_entc_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOCV_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean DOCV_CodigoOK
		{
			get { return m_docv_codigoOK; }
			set
			{
				if (m_docv_codigoOK != value)
				{ m_docv_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOCV_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String DOCV_CodigoMSGERROR
		{
			get { return m_docv_codigoMSGERROR; }
			set
			{
				if (m_docv_codigoMSGERROR != value)
				{m_docv_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCCT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CCCT_CodigoOK
		{
			get { return m_ccct_codigoOK; }
			set
			{
				if (m_ccct_codigoOK != value)
				{ m_ccct_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCCT_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CCCT_CodigoMSGERROR
		{
			get { return m_ccct_codigoMSGERROR; }
			set
			{
				if (m_ccct_codigoMSGERROR != value)
				{m_ccct_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EXCE_Fecha.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_FechaOK
		{
			get { return m_exce_fechaOK; }
			set
			{
				if (m_exce_fechaOK != value)
				{ m_exce_fechaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_Fecha.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_FechaMSGERROR
		{
			get { return m_exce_fechaMSGERROR; }
			set
			{
				if (m_exce_fechaMSGERROR != value)
				{m_exce_fechaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EXCE_Usr.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_UsrOK
		{
			get { return m_exce_usrOK; }
			set
			{
				if (m_exce_usrOK != value)
				{ m_exce_usrOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_Usr.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_UsrMSGERROR
		{
			get { return m_exce_usrMSGERROR; }
			set
			{
				if (m_exce_usrMSGERROR != value)
				{m_exce_usrMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EXCE_UsrAprueba.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_UsrApruebaOK
		{
			get { return m_exce_usrapruebaOK; }
			set
			{
				if (m_exce_usrapruebaOK != value)
				{ m_exce_usrapruebaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_UsrAprueba.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_UsrApruebaMSGERROR
		{
			get { return m_exce_usrapruebaMSGERROR; }
			set
			{
				if (m_exce_usrapruebaMSGERROR != value)
				{m_exce_usrapruebaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EXCE_MontoRequerido.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_MontoRequeridoOK
		{
			get { return m_exce_montorequeridoOK; }
			set
			{
				if (m_exce_montorequeridoOK != value)
				{ m_exce_montorequeridoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_MontoRequerido.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_MontoRequeridoMSGERROR
		{
			get { return m_exce_montorequeridoMSGERROR; }
			set
			{
				if (m_exce_montorequeridoMSGERROR != value)
				{m_exce_montorequeridoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EXCE_MontoExcedido.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_MontoExcedidoOK
		{
			get { return m_exce_montoexcedidoOK; }
			set
			{
				if (m_exce_montoexcedidoOK != value)
				{ m_exce_montoexcedidoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_MontoExcedido.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_MontoExcedidoMSGERROR
		{
			get { return m_exce_montoexcedidoMSGERROR; }
			set
			{
				if (m_exce_montoexcedidoMSGERROR != value)
				{m_exce_montoexcedidoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EXCE_FecAprueba.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_FecApruebaOK
		{
			get { return m_exce_fecapruebaOK; }
			set
			{
				if (m_exce_fecapruebaOK != value)
				{ m_exce_fecapruebaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_FecAprueba.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_FecApruebaMSGERROR
		{
			get { return m_exce_fecapruebaMSGERROR; }
			set
			{
				if (m_exce_fecapruebaMSGERROR != value)
				{m_exce_fecapruebaMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EXCE_MotivoAprueba.
		/// </summary>
		[IgnoreDataMember]
		public Boolean EXCE_MotivoApruebaOK
		{
			get { return m_exce_motivoapruebaOK; }
			set
			{
				if (m_exce_motivoapruebaOK != value)
				{ m_exce_motivoapruebaOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EXCE_MotivoAprueba.
		/// </summary>
		[IgnoreDataMember]
		public String EXCE_MotivoApruebaMSGERROR
		{
			get { return m_exce_motivoapruebaMSGERROR; }
			set
			{
				if (m_exce_motivoapruebaMSGERROR != value)
				{m_exce_motivoapruebaMSGERROR = value; }
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
				EXCE_InternoOK  = true;
				EXCE_InternoMSGERROR  = "";
				if( EXCE_Interno == 0)
				{
					_isCorrect = false;
					EXCE_InternoOK  = false;
					EXCE_InternoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EXCE_Interno", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EXCE_Interno" + Environment.NewLine;
				}
				EMPR_CodigoOK  = true;
				EMPR_CodigoMSGERROR  = "";
				if( EMPR_Codigo == null)
				{
					_isCorrect = false;
					EMPR_CodigoOK  = false;
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				EXCE_UsrSolicitaOK  = true;
				EXCE_UsrSolicitaMSGERROR  = "";
				if( String.IsNullOrEmpty(EXCE_UsrSolicita) )
				{
					_isCorrect = false;
					EXCE_UsrSolicitaOK  = false;
					EXCE_UsrSolicitaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EXCE_UsrSolicita", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EXCE_UsrSolicita" + Environment.NewLine;
				}
				ENTC_CodigoOK  = true;
				ENTC_CodigoMSGERROR  = "";
				if( ENTC_Codigo == 0)
				{
					_isCorrect = false;
					ENTC_CodigoOK  = false;
					ENTC_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "ENTC_Codigo", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo ENTC_Codigo" + Environment.NewLine;
				}
				EXCE_UsrOK  = true;
				EXCE_UsrMSGERROR  = "";
				if( String.IsNullOrEmpty(EXCE_Usr) )
				{
					_isCorrect = false;
					EXCE_UsrOK  = false;
					EXCE_UsrMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EXCE_Usr", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EXCE_Usr" + Environment.NewLine;
				}
				EXCE_UsrApruebaOK  = true;
				EXCE_UsrApruebaMSGERROR  = "";
				if( String.IsNullOrEmpty(EXCE_UsrAprueba) )
				{
					_isCorrect = false;
					EXCE_UsrApruebaOK  = false;
					EXCE_UsrApruebaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EXCE_UsrAprueba", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EXCE_UsrAprueba" + Environment.NewLine;
				}
				EXCE_MontoRequeridoOK  = true;
				EXCE_MontoRequeridoMSGERROR  = "";
				if( EXCE_MontoRequerido == 0)
				{
					_isCorrect = false;
					EXCE_MontoRequeridoOK  = false;
					EXCE_MontoRequeridoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EXCE_MontoRequerido", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EXCE_MontoRequerido" + Environment.NewLine;
				}
				EXCE_MontoExcedidoOK  = true;
				EXCE_MontoExcedidoMSGERROR  = "";
				if( EXCE_MontoExcedido == 0)
				{
					_isCorrect = false;
					EXCE_MontoExcedidoOK  = false;
					EXCE_MontoExcedidoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EXCE_MontoExcedido", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EXCE_MontoExcedido" + Environment.NewLine;
				}
				EXCE_FecApruebaOK  = true;
				EXCE_FecApruebaMSGERROR  = "";
				if( EXCE_FecAprueba == null)
				{
					_isCorrect = false;
					EXCE_FecApruebaOK  = false;
					EXCE_FecApruebaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EXCE_FecAprueba", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EXCE_FecAprueba" + Environment.NewLine;
				}
				EXCE_MotivoApruebaOK  = true;
				EXCE_MotivoApruebaMSGERROR  = "";
				if( String.IsNullOrEmpty(EXCE_MotivoAprueba) )
				{
					_isCorrect = false;
					EXCE_MotivoApruebaOK  = false;
					EXCE_MotivoApruebaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EXCE_MotivoAprueba", "Excepciones");
					m_mensajeError += "* Debe ingresar el campo EXCE_MotivoAprueba" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
