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
	public partial class Empresa
	{
		#region [ Variables Validación ]
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_empr_razonsocialOK;
		private String m_empr_razonsocialMSGERROR;
		private Boolean m_empr_razoncomercialOK;
		private String m_empr_razoncomercialMSGERROR;
		private Boolean m_empr_rucOK;
		private String m_empr_rucMSGERROR;
		private Boolean m_empr_direccionOK;
		private String m_empr_direccionMSGERROR;
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
		/// Gets or sets el valor de validación de: EMPR_RazonSocial.
		/// </summary>
		[DataMember]
		public Boolean EMPR_RazonSocialOK
		{
			get { return m_empr_razonsocialOK; }
			set
			{
				if (m_empr_razonsocialOK != value)
				{
					m_empr_razonsocialOK = value;
					OnPropertyChanged("EMPR_RazonSocialOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_RazonSocial.
		/// </summary>
		[DataMember]
		public String EMPR_RazonSocialMSGERROR
		{
			get { return m_empr_razonsocialMSGERROR; }
			set
			{
				if (m_empr_razonsocialMSGERROR != value)
				{
					m_empr_razonsocialMSGERROR = value;
					OnPropertyChanged("EMPR_RazonSocialMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EMPR_RazonComercial.
		/// </summary>
		[DataMember]
		public Boolean EMPR_RazonComercialOK
		{
			get { return m_empr_razoncomercialOK; }
			set
			{
				if (m_empr_razoncomercialOK != value)
				{
					m_empr_razoncomercialOK = value;
					OnPropertyChanged("EMPR_RazonComercialOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_RazonComercial.
		/// </summary>
		[DataMember]
		public String EMPR_RazonComercialMSGERROR
		{
			get { return m_empr_razoncomercialMSGERROR; }
			set
			{
				if (m_empr_razoncomercialMSGERROR != value)
				{
					m_empr_razoncomercialMSGERROR = value;
					OnPropertyChanged("EMPR_RazonComercialMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EMPR_RUC.
		/// </summary>
		[DataMember]
		public Boolean EMPR_RUCOK
		{
			get { return m_empr_rucOK; }
			set
			{
				if (m_empr_rucOK != value)
				{
					m_empr_rucOK = value;
					OnPropertyChanged("EMPR_RUCOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_RUC.
		/// </summary>
		[DataMember]
		public String EMPR_RUCMSGERROR
		{
			get { return m_empr_rucMSGERROR; }
			set
			{
				if (m_empr_rucMSGERROR != value)
				{
					m_empr_rucMSGERROR = value;
					OnPropertyChanged("EMPR_RUCMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: EMPR_Direccion.
		/// </summary>
		[DataMember]
		public Boolean EMPR_DireccionOK
		{
			get { return m_empr_direccionOK; }
			set
			{
				if (m_empr_direccionOK != value)
				{
					m_empr_direccionOK = value;
					OnPropertyChanged("EMPR_DireccionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: EMPR_Direccion.
		/// </summary>
		[DataMember]
		public String EMPR_DireccionMSGERROR
		{
			get { return m_empr_direccionMSGERROR; }
			set
			{
				if (m_empr_direccionMSGERROR != value)
				{
					m_empr_direccionMSGERROR = value;
					OnPropertyChanged("EMPR_DireccionMSGERROR");
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
					EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Empresa");
					m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
				}
				EMPR_RazonSocialOK  = true;
				EMPR_RazonSocialMSGERROR  = "";
				if( String.IsNullOrEmpty(EMPR_RazonSocial) )
				{
					_isCorrect = false;
					EMPR_RazonSocialOK  = false;
					EMPR_RazonSocialMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_RazonSocial", "Empresa");
					m_mensajeError += "* Debe ingresar el campo EMPR_RazonSocial" + Environment.NewLine;
				}
				EMPR_RazonComercialOK  = true;
				EMPR_RazonComercialMSGERROR  = "";
				if( String.IsNullOrEmpty(EMPR_RazonComercial) )
				{
					_isCorrect = false;
					EMPR_RazonComercialOK  = false;
					EMPR_RazonComercialMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_RazonComercial", "Empresa");
					m_mensajeError += "* Debe ingresar el campo EMPR_RazonComercial" + Environment.NewLine;
				}
				EMPR_RUCOK  = true;
				EMPR_RUCMSGERROR  = "";
				if( String.IsNullOrEmpty(EMPR_RUC) )
				{
					_isCorrect = false;
					EMPR_RUCOK  = false;
					EMPR_RUCMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_RUC", "Empresa");
					m_mensajeError += "* Debe ingresar el campo EMPR_RUC" + Environment.NewLine;
				}
				EMPR_DireccionOK  = true;
				EMPR_DireccionMSGERROR  = "";
				if( String.IsNullOrEmpty(EMPR_Direccion) )
				{
					_isCorrect = false;
					EMPR_DireccionOK  = false;
					EMPR_DireccionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Direccion", "Empresa");
					m_mensajeError += "* Debe ingresar el campo EMPR_Direccion" + Environment.NewLine;
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
