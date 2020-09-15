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
	public partial class GastosBancarios
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_tran_codigoOK;
		private String m_tran_codigoMSGERROR;
		private Boolean m_gban_codigoOK;
		private String m_gban_codigoMSGERROR;
		private Boolean m_gban_tipocambioOK;
		private String m_gban_tipocambioMSGERROR;
		private Boolean m_gban_montodebeOK;
		private String m_gban_montodebeMSGERROR;
		private Boolean m_gban_montohaberOK;
		private String m_gban_montohaberMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
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
		/// Gets or sets el valor de validación de: TRAN_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean TRAN_CodigoOK
		{
			get { return m_tran_codigoOK; }
			set
			{
				if (m_tran_codigoOK != value)
				{ m_tran_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TRAN_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String TRAN_CodigoMSGERROR
		{
			get { return m_tran_codigoMSGERROR; }
			set
			{
				if (m_tran_codigoMSGERROR != value)
				{m_tran_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: GBAN_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public Boolean GBAN_CodigoOK
		{
			get { return m_gban_codigoOK; }
			set
			{
				if (m_gban_codigoOK != value)
				{ m_gban_codigoOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GBAN_Codigo.
		/// </summary>
		[IgnoreDataMember]
		public String GBAN_CodigoMSGERROR
		{
			get { return m_gban_codigoMSGERROR; }
			set
			{
				if (m_gban_codigoMSGERROR != value)
				{m_gban_codigoMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: GBAN_TipoCambio.
		/// </summary>
		[IgnoreDataMember]
		public Boolean GBAN_TipoCambioOK
		{
			get { return m_gban_tipocambioOK; }
			set
			{
				if (m_gban_tipocambioOK != value)
				{ m_gban_tipocambioOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GBAN_TipoCambio.
		/// </summary>
		[IgnoreDataMember]
		public String GBAN_TipoCambioMSGERROR
		{
			get { return m_gban_tipocambioMSGERROR; }
			set
			{
				if (m_gban_tipocambioMSGERROR != value)
				{m_gban_tipocambioMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: GBAN_MontoDebe.
		/// </summary>
		[IgnoreDataMember]
		public Boolean GBAN_MontoDebeOK
		{
			get { return m_gban_montodebeOK; }
			set
			{
				if (m_gban_montodebeOK != value)
				{ m_gban_montodebeOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GBAN_MontoDebe.
		/// </summary>
		[IgnoreDataMember]
		public String GBAN_MontoDebeMSGERROR
		{
			get { return m_gban_montodebeMSGERROR; }
			set
			{
				if (m_gban_montodebeMSGERROR != value)
				{m_gban_montodebeMSGERROR = value; }
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: GBAN_MontoHaber.
		/// </summary>
		[IgnoreDataMember]
		public Boolean GBAN_MontoHaberOK
		{
			get { return m_gban_montohaberOK; }
			set
			{
				if (m_gban_montohaberOK != value)
				{ m_gban_montohaberOK = value; }
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GBAN_MontoHaber.
		/// </summary>
		[IgnoreDataMember]
		public String GBAN_MontoHaberMSGERROR
		{
			get { return m_gban_montohaberMSGERROR; }
			set
			{
				if (m_gban_montohaberMSGERROR != value)
				{m_gban_montohaberMSGERROR = value; }
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
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "GastosBancarios");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				TRAN_CodigoOK  = true;
				TRAN_CodigoMSGERROR  = "";
				if( TRAN_Codigo == 0)
				{
					_isCorrect = false;
					TRAN_CodigoOK  = false;
					TRAN_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TRAN_Codigo", "GastosBancarios");
					m_mensajeError += "* Debe ingresar el campo TRAN_Codigo" + Environment.NewLine;
				}
				GBAN_CodigoOK  = true;
				GBAN_CodigoMSGERROR  = "";
				if( GBAN_Codigo == 0)
				{
					_isCorrect = false;
					GBAN_CodigoOK  = false;
					GBAN_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "GBAN_Codigo", "GastosBancarios");
					m_mensajeError += "* Debe ingresar el campo GBAN_Codigo" + Environment.NewLine;
				}
				GBAN_MontoDebeOK  = true;
				GBAN_MontoDebeMSGERROR  = "";
				if( GBAN_MontoDebe == 0)
				{
					_isCorrect = false;
					GBAN_MontoDebeOK  = false;
					GBAN_MontoDebeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "GBAN_MontoDebe", "GastosBancarios");
					m_mensajeError += "* Debe ingresar el campo GBAN_MontoDebe" + Environment.NewLine;
				}
				GBAN_MontoHaberOK  = true;
				GBAN_MontoHaberMSGERROR  = "";
				if( GBAN_MontoHaber == 0)
				{
					_isCorrect = false;
					GBAN_MontoHaberOK  = false;
					GBAN_MontoHaberMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "GBAN_MontoHaber", "GastosBancarios");
					m_mensajeError += "* Debe ingresar el campo GBAN_MontoHaber" + Environment.NewLine;
				}
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
