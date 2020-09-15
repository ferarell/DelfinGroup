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
	public partial class Paquete
	{
		#region [ Variables Validación ]
		private Boolean m_pack_codigoOK;
		private String m_pack_codigoMSGERROR;
		private Boolean m_pack_descOK;
		private String m_pack_descMSGERROR;
		private Boolean m_pack_desccOK;
		private String m_pack_desccMSGERROR;
		private Boolean m_tipo_tabpaqOK;
		private String m_tipo_tabpaqMSGERROR;
		private Boolean m_tipo_codpaqOK;
		private String m_tipo_codpaqMSGERROR;
		private Boolean m_tipo_tabtamOK;
		private String m_tipo_tabtamMSGERROR;
		private Boolean m_tipo_codtamOK;
		private String m_tipo_codtamMSGERROR;
		private Boolean m_tipo_tabcntOK;
		private String m_tipo_tabcntMSGERROR;
		private Boolean m_tipo_codcntOK;
		private String m_tipo_codcntMSGERROR;
		private Boolean m_pack_activoOK;
		private String m_pack_activoMSGERROR;
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
		/// Gets or sets el valor de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PACK_CodigoOK
		{
			get { return m_pack_codigoOK; }
			set
			{
				if (m_pack_codigoOK != value)
				{
					m_pack_codigoOK = value;
					OnPropertyChanged("PACK_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_Codigo.
		/// </summary>
		[DataMember]
		public String PACK_CodigoMSGERROR
		{
			get { return m_pack_codigoMSGERROR; }
			set
			{
				if (m_pack_codigoMSGERROR != value)
				{
					m_pack_codigoMSGERROR = value;
					OnPropertyChanged("PACK_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PACK_Desc.
		/// </summary>
		[DataMember]
		public Boolean PACK_DescOK
		{
			get { return m_pack_descOK; }
			set
			{
				if (m_pack_descOK != value)
				{
					m_pack_descOK = value;
					OnPropertyChanged("PACK_DescOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_Desc.
		/// </summary>
		[DataMember]
		public String PACK_DescMSGERROR
		{
			get { return m_pack_descMSGERROR; }
			set
			{
				if (m_pack_descMSGERROR != value)
				{
					m_pack_descMSGERROR = value;
					OnPropertyChanged("PACK_DescMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PACK_DescC.
		/// </summary>
		[DataMember]
		public Boolean PACK_DescCOK
		{
			get { return m_pack_desccOK; }
			set
			{
				if (m_pack_desccOK != value)
				{
					m_pack_desccOK = value;
					OnPropertyChanged("PACK_DescCOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_DescC.
		/// </summary>
		[DataMember]
		public String PACK_DescCMSGERROR
		{
			get { return m_pack_desccMSGERROR; }
			set
			{
				if (m_pack_desccMSGERROR != value)
				{
					m_pack_desccMSGERROR = value;
					OnPropertyChanged("PACK_DescCMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabPAQ.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabPAQOK
		{
			get { return m_tipo_tabpaqOK; }
			set
			{
				if (m_tipo_tabpaqOK != value)
				{
					m_tipo_tabpaqOK = value;
					OnPropertyChanged("TIPO_TabPAQOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabPAQ.
		/// </summary>
		[DataMember]
		public String TIPO_TabPAQMSGERROR
		{
			get { return m_tipo_tabpaqMSGERROR; }
			set
			{
				if (m_tipo_tabpaqMSGERROR != value)
				{
					m_tipo_tabpaqMSGERROR = value;
					OnPropertyChanged("TIPO_TabPAQMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodPAQ.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodPAQOK
		{
			get { return m_tipo_codpaqOK; }
			set
			{
				if (m_tipo_codpaqOK != value)
				{
					m_tipo_codpaqOK = value;
					OnPropertyChanged("TIPO_CodPAQOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodPAQ.
		/// </summary>
		[DataMember]
		public String TIPO_CodPAQMSGERROR
		{
			get { return m_tipo_codpaqMSGERROR; }
			set
			{
				if (m_tipo_codpaqMSGERROR != value)
				{
					m_tipo_codpaqMSGERROR = value;
					OnPropertyChanged("TIPO_CodPAQMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabTAM.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabTAMOK
		{
			get { return m_tipo_tabtamOK; }
			set
			{
				if (m_tipo_tabtamOK != value)
				{
					m_tipo_tabtamOK = value;
					OnPropertyChanged("TIPO_TabTAMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabTAM.
		/// </summary>
		[DataMember]
		public String TIPO_TabTAMMSGERROR
		{
			get { return m_tipo_tabtamMSGERROR; }
			set
			{
				if (m_tipo_tabtamMSGERROR != value)
				{
					m_tipo_tabtamMSGERROR = value;
					OnPropertyChanged("TIPO_TabTAMMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodTAM.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodTAMOK
		{
			get { return m_tipo_codtamOK; }
			set
			{
				if (m_tipo_codtamOK != value)
				{
					m_tipo_codtamOK = value;
					OnPropertyChanged("TIPO_CodTAMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodTAM.
		/// </summary>
		[DataMember]
		public String TIPO_CodTAMMSGERROR
		{
			get { return m_tipo_codtamMSGERROR; }
			set
			{
				if (m_tipo_codtamMSGERROR != value)
				{
					m_tipo_codtamMSGERROR = value;
					OnPropertyChanged("TIPO_CodTAMMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabCNT.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabCNTOK
		{
			get { return m_tipo_tabcntOK; }
			set
			{
				if (m_tipo_tabcntOK != value)
				{
					m_tipo_tabcntOK = value;
					OnPropertyChanged("TIPO_TabCNTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabCNT.
		/// </summary>
		[DataMember]
		public String TIPO_TabCNTMSGERROR
		{
			get { return m_tipo_tabcntMSGERROR; }
			set
			{
				if (m_tipo_tabcntMSGERROR != value)
				{
					m_tipo_tabcntMSGERROR = value;
					OnPropertyChanged("TIPO_TabCNTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodCNT.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodCNTOK
		{
			get { return m_tipo_codcntOK; }
			set
			{
				if (m_tipo_codcntOK != value)
				{
					m_tipo_codcntOK = value;
					OnPropertyChanged("TIPO_CodCNTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodCNT.
		/// </summary>
		[DataMember]
		public String TIPO_CodCNTMSGERROR
		{
			get { return m_tipo_codcntMSGERROR; }
			set
			{
				if (m_tipo_codcntMSGERROR != value)
				{
					m_tipo_codcntMSGERROR = value;
					OnPropertyChanged("TIPO_CodCNTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PACK_Activo.
		/// </summary>
		[DataMember]
		public Boolean PACK_ActivoOK
		{
			get { return m_pack_activoOK; }
			set
			{
				if (m_pack_activoOK != value)
				{
					m_pack_activoOK = value;
					OnPropertyChanged("PACK_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PACK_Activo.
		/// </summary>
		[DataMember]
		public String PACK_ActivoMSGERROR
		{
			get { return m_pack_activoMSGERROR; }
			set
			{
				if (m_pack_activoMSGERROR != value)
				{
					m_pack_activoMSGERROR = value;
					OnPropertyChanged("PACK_ActivoMSGERROR");
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
				PACK_CodigoOK  = true;
				PACK_CodigoMSGERROR  = "";
				if( PACK_Codigo == null)
				{
					_isCorrect = false;
					PACK_CodigoOK  = false;
					PACK_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PACK_Codigo", "Paquete");
					m_mensajeError += "* Debe ingresar el campo PACK_Codigo" + Environment.NewLine;
				}
				PACK_DescOK  = true;
				PACK_DescMSGERROR  = "";
				if( String.IsNullOrEmpty(PACK_Desc) )
				{
					_isCorrect = false;
					PACK_DescOK  = false;
					PACK_DescMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PACK_Desc", "Paquete");
					m_mensajeError += "* Debe ingresar el campo PACK_Desc" + Environment.NewLine;
				}
				PACK_DescCOK  = true;
				PACK_DescCMSGERROR  = "";
				if( String.IsNullOrEmpty(PACK_DescC) )
				{
					_isCorrect = false;
					PACK_DescCOK  = false;
					PACK_DescCMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "PACK_DescC", "Paquete");
					m_mensajeError += "* Debe ingresar el campo PACK_DescC" + Environment.NewLine;
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
