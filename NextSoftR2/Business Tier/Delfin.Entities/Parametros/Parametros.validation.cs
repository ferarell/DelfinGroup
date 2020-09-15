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
	public partial class Parametros
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_sucr_codigoOK;
		private String m_sucr_codigoMSGERROR;
		private Boolean m_para_codigoOK;
		private String m_para_codigoMSGERROR;
		private Boolean m_para_claveOK;
		private String m_para_claveMSGERROR;
		private Boolean m_para_descOK;
		private String m_para_descMSGERROR;
		private Boolean m_para_valorOK;
		private String m_para_valorMSGERROR;
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
		[DataMember]
		public Boolean EMPR_CodigoOK
		{
			get { return m_empr_codigoOK; }
			set
			{
				if (m_empr_codigoOK != value)
				{
					m_empr_codigoOK = value;
					OnPropertyChanged("EMPR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public String EMPR_CodigoMSGERROR
		{
			get { return m_empr_codigoMSGERROR; }
			set
			{
				if (m_empr_codigoMSGERROR != value)
				{
					m_empr_codigoMSGERROR = value;
					OnPropertyChanged("EMPR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean SUCR_CodigoOK
		{
			get { return m_sucr_codigoOK; }
			set
			{
				if (m_sucr_codigoOK != value)
				{
					m_sucr_codigoOK = value;
					OnPropertyChanged("SUCR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public String SUCR_CodigoMSGERROR
		{
			get { return m_sucr_codigoMSGERROR; }
			set
			{
				if (m_sucr_codigoMSGERROR != value)
				{
					m_sucr_codigoMSGERROR = value;
					OnPropertyChanged("SUCR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PARA_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PARA_CodigoOK
		{
			get { return m_para_codigoOK; }
			set
			{
				if (m_para_codigoOK != value)
				{
					m_para_codigoOK = value;
					OnPropertyChanged("PARA_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PARA_Codigo.
		/// </summary>
		[DataMember]
		public String PARA_CodigoMSGERROR
		{
			get { return m_para_codigoMSGERROR; }
			set
			{
				if (m_para_codigoMSGERROR != value)
				{
					m_para_codigoMSGERROR = value;
					OnPropertyChanged("PARA_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PARA_Clave.
		/// </summary>
		[DataMember]
		public Boolean PARA_ClaveOK
		{
			get { return m_para_claveOK; }
			set
			{
				if (m_para_claveOK != value)
				{
					m_para_claveOK = value;
					OnPropertyChanged("PARA_ClaveOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PARA_Clave.
		/// </summary>
		[DataMember]
		public String PARA_ClaveMSGERROR
		{
			get { return m_para_claveMSGERROR; }
			set
			{
				if (m_para_claveMSGERROR != value)
				{
					m_para_claveMSGERROR = value;
					OnPropertyChanged("PARA_ClaveMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PARA_Desc.
		/// </summary>
		[DataMember]
		public Boolean PARA_DescOK
		{
			get { return m_para_descOK; }
			set
			{
				if (m_para_descOK != value)
				{
					m_para_descOK = value;
					OnPropertyChanged("PARA_DescOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PARA_Desc.
		/// </summary>
		[DataMember]
		public String PARA_DescMSGERROR
		{
			get { return m_para_descMSGERROR; }
			set
			{
				if (m_para_descMSGERROR != value)
				{
					m_para_descMSGERROR = value;
					OnPropertyChanged("PARA_DescMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PARA_Valor.
		/// </summary>
		[DataMember]
		public Boolean PARA_ValorOK
		{
			get { return m_para_valorOK; }
			set
			{
				if (m_para_valorOK != value)
				{
					m_para_valorOK = value;
					OnPropertyChanged("PARA_ValorOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PARA_Valor.
		/// </summary>
		[DataMember]
		public String PARA_ValorMSGERROR
		{
			get { return m_para_valorMSGERROR; }
			set
			{
				if (m_para_valorMSGERROR != value)
				{
					m_para_valorMSGERROR = value;
					OnPropertyChanged("PARA_ValorMSGERROR");
				}
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
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Parametros");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				SUCR_CodigoOK  = true;
				SUCR_CodigoMSGERROR  = "";
				if( SUCR_Codigo == null)
				{
					_isCorrect = false;
					SUCR_CodigoOK  = false;
					SUCR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SUCR_Codigo", "Parametros");
					m_mensajeError += "* Debe ingresar el campo SUCR_Codigo" + Environment.NewLine;
				}
				PARA_CodigoOK  = true;
				PARA_CodigoMSGERROR  = "";
				if( PARA_Codigo == null)
				{
					_isCorrect = false;
					PARA_CodigoOK  = false;
					PARA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PARA_Codigo", "Parametros");
					m_mensajeError += "* Debe ingresar el campo PARA_Codigo" + Environment.NewLine;
				}
				PARA_ClaveOK  = true;
				PARA_ClaveMSGERROR  = "";
				if( String.IsNullOrEmpty(PARA_Clave) )
				{
					_isCorrect = false;
					PARA_ClaveOK  = false;
					PARA_ClaveMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PARA_Clave", "Parametros");
					m_mensajeError += "* Debe ingresar el campo PARA_Clave" + Environment.NewLine;
				}
				PARA_DescOK  = true;
				PARA_DescMSGERROR  = "";
				if( String.IsNullOrEmpty(PARA_Desc) )
				{
					_isCorrect = false;
					PARA_DescOK  = false;
					PARA_DescMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PARA_Desc", "Parametros");
					m_mensajeError += "* Debe ingresar el campo PARA_Desc" + Environment.NewLine;
				}
				PARA_ValorOK  = true;
				PARA_ValorMSGERROR  = "";
				if( String.IsNullOrEmpty(PARA_Valor) )
				{
					_isCorrect = false;
					PARA_ValorOK  = false;
					PARA_ValorMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PARA_Valor", "Parametros");
					m_mensajeError += "* Debe ingresar el campo PARA_Valor" + Environment.NewLine;
				}
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
