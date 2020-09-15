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
	public partial class Sucursales
	{
		#region [ Variables Validación ]
		private Boolean m_sucr_codigoOK;
		private String m_sucr_codigoMSGERROR;
		private Boolean m_sucr_descOK;
		private String m_sucr_descMSGERROR;
		private Boolean m_sucr_desccOK;
		private String m_sucr_desccMSGERROR;
		private Boolean m_sucr_rucOK;
		private String m_sucr_rucMSGERROR;
		private Boolean m_sucr_direcOK;
		private String m_sucr_direcMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
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
		/// Gets or sets el valor de validación de: SUCR_Desc.
		/// </summary>
		[DataMember]
		public Boolean SUCR_DescOK
		{
			get { return m_sucr_descOK; }
			set
			{
				if (m_sucr_descOK != value)
				{
					m_sucr_descOK = value;
					OnPropertyChanged("SUCR_DescOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SUCR_Desc.
		/// </summary>
		[DataMember]
		public String SUCR_DescMSGERROR
		{
			get { return m_sucr_descMSGERROR; }
			set
			{
				if (m_sucr_descMSGERROR != value)
				{
					m_sucr_descMSGERROR = value;
					OnPropertyChanged("SUCR_DescMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SUCR_DescC.
		/// </summary>
		[DataMember]
		public Boolean SUCR_DescCOK
		{
			get { return m_sucr_desccOK; }
			set
			{
				if (m_sucr_desccOK != value)
				{
					m_sucr_desccOK = value;
					OnPropertyChanged("SUCR_DescCOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SUCR_DescC.
		/// </summary>
		[DataMember]
		public String SUCR_DescCMSGERROR
		{
			get { return m_sucr_desccMSGERROR; }
			set
			{
				if (m_sucr_desccMSGERROR != value)
				{
					m_sucr_desccMSGERROR = value;
					OnPropertyChanged("SUCR_DescCMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SUCR_RUC.
		/// </summary>
		[DataMember]
		public Boolean SUCR_RUCOK
		{
			get { return m_sucr_rucOK; }
			set
			{
				if (m_sucr_rucOK != value)
				{
					m_sucr_rucOK = value;
					OnPropertyChanged("SUCR_RUCOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SUCR_RUC.
		/// </summary>
		[DataMember]
		public String SUCR_RUCMSGERROR
		{
			get { return m_sucr_rucMSGERROR; }
			set
			{
				if (m_sucr_rucMSGERROR != value)
				{
					m_sucr_rucMSGERROR = value;
					OnPropertyChanged("SUCR_RUCMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SUCR_Direc.
		/// </summary>
		[DataMember]
		public Boolean SUCR_DirecOK
		{
			get { return m_sucr_direcOK; }
			set
			{
				if (m_sucr_direcOK != value)
				{
					m_sucr_direcOK = value;
					OnPropertyChanged("SUCR_DirecOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SUCR_Direc.
		/// </summary>
		[DataMember]
		public String SUCR_DirecMSGERROR
		{
			get { return m_sucr_direcMSGERROR; }
			set
			{
				if (m_sucr_direcMSGERROR != value)
				{
					m_sucr_direcMSGERROR = value;
					OnPropertyChanged("SUCR_DirecMSGERROR");
				}
			}
		}
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
				SUCR_CodigoOK  = true;
				SUCR_CodigoMSGERROR  = "";
				if( SUCR_Codigo == null)
				{
					_isCorrect = false;
					SUCR_CodigoOK  = false;
					SUCR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SUCR_Codigo", "Sucursales");
					m_mensajeError += "* Debe ingresar el campo SUCR_Codigo" + Environment.NewLine;
				}
				SUCR_DescOK  = true;
				SUCR_DescMSGERROR  = "";
				if( String.IsNullOrEmpty(SUCR_Desc) )
				{
					_isCorrect = false;
					SUCR_DescOK  = false;
					SUCR_DescMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SUCR_Desc", "Sucursales");
					m_mensajeError += "* Debe ingresar el campo SUCR_Desc" + Environment.NewLine;
				}
				SUCR_DescCOK  = true;
				SUCR_DescCMSGERROR  = "";
				if( String.IsNullOrEmpty(SUCR_DescC) )
				{
					_isCorrect = false;
					SUCR_DescCOK  = false;
					SUCR_DescCMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SUCR_DescC", "Sucursales");
					m_mensajeError += "* Debe ingresar el campo SUCR_DescC" + Environment.NewLine;
				}
				SUCR_DirecOK  = true;
				SUCR_DirecMSGERROR  = "";
				if( String.IsNullOrEmpty(SUCR_Direc) )
				{
					_isCorrect = false;
					SUCR_DirecOK  = false;
					SUCR_DirecMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SUCR_Direc", "Sucursales");
					m_mensajeError += "* Debe ingresar el campo SUCR_Direc" + Environment.NewLine;
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
