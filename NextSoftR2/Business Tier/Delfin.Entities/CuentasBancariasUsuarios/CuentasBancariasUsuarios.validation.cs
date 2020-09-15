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
	public partial class CuentasBancariasUsuarios
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_cuba_codigoOK;
		private String m_cuba_codigoMSGERROR;
		private Boolean m_user_codigoOK;
		private String m_user_codigoMSGERROR;
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
		/// Gets or sets el valor de validación de: CUBA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean CUBA_CodigoOK
		{
			get { return m_cuba_codigoOK; }
			set
			{
				if (m_cuba_codigoOK != value)
				{ m_cuba_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CUBA_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String CUBA_CodigoMSGERROR
		{
			get { return m_cuba_codigoMSGERROR; }
			set
			{
				if (m_cuba_codigoMSGERROR != value)
				{m_cuba_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: USER_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean USER_CodigoOK
		{
			get { return m_user_codigoOK; }
			set
			{
				if (m_user_codigoOK != value)
				{ m_user_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: USER_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String USER_CodigoMSGERROR
		{
			get { return m_user_codigoMSGERROR; }
			set
			{
				if (m_user_codigoMSGERROR != value)
				{m_user_codigoMSGERROR = value; }
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
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "CuentaBancosUsuarios");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				CUBA_CodigoOK  = true;
				CUBA_CodigoMSGERROR  = "";
				if( String.IsNullOrEmpty(CUBA_Codigo) )
				{
					_isCorrect = false;
					CUBA_CodigoOK  = false;
					CUBA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CUBA_Codigo", "CuentaBancosUsuarios");
					m_mensajeError += "* Debe ingresar el campo CUBA_Codigo" + Environment.NewLine;
				}
				USER_CodigoOK  = true;
				USER_CodigoMSGERROR  = "";
				if( String.IsNullOrEmpty(USER_Codigo) )
				{
					_isCorrect = false;
					USER_CodigoOK  = false;
					USER_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "USER_Codigo", "CuentaBancosUsuarios");
					m_mensajeError += "* Debe ingresar el campo USER_Codigo" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
