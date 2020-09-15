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
	public partial class Ubigeos
	{
		#region [ Variables Validación ]
		private Boolean m_ubig_codigoOK;
		private String m_ubig_codigoMSGERROR;
		private Boolean m_tipo_codpaisOK;
		private String m_tipo_codpaisMSGERROR;
		private Boolean m_tipo_tabpaisOK;
		private String m_tipo_tabpaisMSGERROR;
		private Boolean m_ubig_descOK;
		private String m_ubig_descMSGERROR;
		private Boolean m_ubig_desccOK;
		private String m_ubig_desccMSGERROR;
		private Boolean m_ubig_codpadreOK;
		private String m_ubig_codpadreMSGERROR;
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
		/// Gets or sets el valor de validación de: UBIG_Codigo.
		/// </summary>
		[DataMember]
		public Boolean UBIG_CodigoOK
		{
			get { return m_ubig_codigoOK; }
			set
			{
				if (m_ubig_codigoOK != value)
				{
					m_ubig_codigoOK = value;
					OnPropertyChanged("UBIG_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: UBIG_Codigo.
		/// </summary>
		[DataMember]
		public String UBIG_CodigoMSGERROR
		{
			get { return m_ubig_codigoMSGERROR; }
			set
			{
				if (m_ubig_codigoMSGERROR != value)
				{
					m_ubig_codigoMSGERROR = value;
					OnPropertyChanged("UBIG_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodPais.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodPaisOK
		{
			get { return m_tipo_codpaisOK; }
			set
			{
				if (m_tipo_codpaisOK != value)
				{
					m_tipo_codpaisOK = value;
					OnPropertyChanged("TIPO_CodPaisOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodPais.
		/// </summary>
		[DataMember]
		public String TIPO_CodPaisMSGERROR
		{
			get { return m_tipo_codpaisMSGERROR; }
			set
			{
				if (m_tipo_codpaisMSGERROR != value)
				{
					m_tipo_codpaisMSGERROR = value;
					OnPropertyChanged("TIPO_CodPaisMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabPais.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabPaisOK
		{
			get { return m_tipo_tabpaisOK; }
			set
			{
				if (m_tipo_tabpaisOK != value)
				{
					m_tipo_tabpaisOK = value;
					OnPropertyChanged("TIPO_TabPaisOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabPais.
		/// </summary>
		[DataMember]
		public String TIPO_TabPaisMSGERROR
		{
			get { return m_tipo_tabpaisMSGERROR; }
			set
			{
				if (m_tipo_tabpaisMSGERROR != value)
				{
					m_tipo_tabpaisMSGERROR = value;
					OnPropertyChanged("TIPO_TabPaisMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: UBIG_Desc.
		/// </summary>
		[DataMember]
		public Boolean UBIG_DescOK
		{
			get { return m_ubig_descOK; }
			set
			{
				if (m_ubig_descOK != value)
				{
					m_ubig_descOK = value;
					OnPropertyChanged("UBIG_DescOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: UBIG_Desc.
		/// </summary>
		[DataMember]
		public String UBIG_DescMSGERROR
		{
			get { return m_ubig_descMSGERROR; }
			set
			{
				if (m_ubig_descMSGERROR != value)
				{
					m_ubig_descMSGERROR = value;
					OnPropertyChanged("UBIG_DescMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: UBIG_DescC.
		/// </summary>
		[DataMember]
		public Boolean UBIG_DescCOK
		{
			get { return m_ubig_desccOK; }
			set
			{
				if (m_ubig_desccOK != value)
				{
					m_ubig_desccOK = value;
					OnPropertyChanged("UBIG_DescCOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: UBIG_DescC.
		/// </summary>
		[DataMember]
		public String UBIG_DescCMSGERROR
		{
			get { return m_ubig_desccMSGERROR; }
			set
			{
				if (m_ubig_desccMSGERROR != value)
				{
					m_ubig_desccMSGERROR = value;
					OnPropertyChanged("UBIG_DescCMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: UBIG_CodPadre.
		/// </summary>
		[DataMember]
		public Boolean UBIG_CodPadreOK
		{
			get { return m_ubig_codpadreOK; }
			set
			{
				if (m_ubig_codpadreOK != value)
				{
					m_ubig_codpadreOK = value;
					OnPropertyChanged("UBIG_CodPadreOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: UBIG_CodPadre.
		/// </summary>
		[DataMember]
		public String UBIG_CodPadreMSGERROR
		{
			get { return m_ubig_codpadreMSGERROR; }
			set
			{
				if (m_ubig_codpadreMSGERROR != value)
				{
					m_ubig_codpadreMSGERROR = value;
					OnPropertyChanged("UBIG_CodPadreMSGERROR");
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
				UBIG_CodigoOK  = true;
				UBIG_CodigoMSGERROR  = "";
				if( String.IsNullOrEmpty(UBIG_Codigo) )
				{
					_isCorrect = false;
					UBIG_CodigoOK  = false;
					UBIG_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "UBIG_Codigo", "Ubigeos");
					m_mensajeError += "* Debe ingresar el campo UBIG_Codigo" + Environment.NewLine;
				}
				TIPO_CodPaisOK  = true;
				TIPO_CodPaisMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodPais) )
				{
					_isCorrect = false;
					TIPO_CodPaisOK  = false;
					TIPO_CodPaisMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_CodPais", "Ubigeos");
					m_mensajeError += "* Debe ingresar el campo TIPO_CodPais" + Environment.NewLine;
				}
				TIPO_TabPaisOK  = true;
				TIPO_TabPaisMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_TabPais) )
				{
					_isCorrect = false;
					TIPO_TabPaisOK  = false;
					TIPO_TabPaisMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabPais", "Ubigeos");
					m_mensajeError += "* Debe ingresar el campo TIPO_TabPais" + Environment.NewLine;
				}
				UBIG_DescOK  = true;
				UBIG_DescMSGERROR  = "";
				if( String.IsNullOrEmpty(UBIG_Desc) )
				{
					_isCorrect = false;
					UBIG_DescOK  = false;
					UBIG_DescMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "UBIG_Desc", "Ubigeos");
					m_mensajeError += "* Debe ingresar el campo UBIG_Desc" + Environment.NewLine;
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
