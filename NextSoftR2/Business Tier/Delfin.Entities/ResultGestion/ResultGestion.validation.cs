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
	public partial class ResultGestion
	{
		#region [ Variables Validación ]
		private Boolean m_resg_codigoOK;
		private String m_resg_codigoMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_resg_codpadreOK;
		private String m_resg_codpadreMSGERROR;
		private Boolean m_resg_descOK;
		private String m_resg_descMSGERROR;
		private Boolean m_resg_desccOK;
		private String m_resg_desccMSGERROR;
		private Boolean m_resg_positivonegativoOK;
		private String m_resg_positivonegativoMSGERROR;
		private Boolean m_resg_activoOK;
		private String m_resg_activoMSGERROR;
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
		/// Gets or sets el valor de validación de: RESG_Codigo.
		/// </summary>
		[DataMember]
		public Boolean RESG_CodigoOK
		{
			get { return m_resg_codigoOK; }
			set
			{
				if (m_resg_codigoOK != value)
				{
					m_resg_codigoOK = value;
					OnPropertyChanged("RESG_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: RESG_Codigo.
		/// </summary>
		[DataMember]
		public String RESG_CodigoMSGERROR
		{
			get { return m_resg_codigoMSGERROR; }
			set
			{
				if (m_resg_codigoMSGERROR != value)
				{
					m_resg_codigoMSGERROR = value;
					OnPropertyChanged("RESG_CodigoMSGERROR");
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
		/// <summary>
		/// Gets or sets el valor de validación de: RESG_CodPadre.
		/// </summary>
		[DataMember]
		public Boolean RESG_CodPadreOK
		{
			get { return m_resg_codpadreOK; }
			set
			{
				if (m_resg_codpadreOK != value)
				{
					m_resg_codpadreOK = value;
					OnPropertyChanged("RESG_CodPadreOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: RESG_CodPadre.
		/// </summary>
		[DataMember]
		public String RESG_CodPadreMSGERROR
		{
			get { return m_resg_codpadreMSGERROR; }
			set
			{
				if (m_resg_codpadreMSGERROR != value)
				{
					m_resg_codpadreMSGERROR = value;
					OnPropertyChanged("RESG_CodPadreMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: RESG_Desc.
		/// </summary>
		[DataMember]
		public Boolean RESG_DescOK
		{
			get { return m_resg_descOK; }
			set
			{
				if (m_resg_descOK != value)
				{
					m_resg_descOK = value;
					OnPropertyChanged("RESG_DescOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: RESG_Desc.
		/// </summary>
		[DataMember]
		public String RESG_DescMSGERROR
		{
			get { return m_resg_descMSGERROR; }
			set
			{
				if (m_resg_descMSGERROR != value)
				{
					m_resg_descMSGERROR = value;
					OnPropertyChanged("RESG_DescMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: RESG_DescC.
		/// </summary>
		[DataMember]
		public Boolean RESG_DescCOK
		{
			get { return m_resg_desccOK; }
			set
			{
				if (m_resg_desccOK != value)
				{
					m_resg_desccOK = value;
					OnPropertyChanged("RESG_DescCOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: RESG_DescC.
		/// </summary>
		[DataMember]
		public String RESG_DescCMSGERROR
		{
			get { return m_resg_desccMSGERROR; }
			set
			{
				if (m_resg_desccMSGERROR != value)
				{
					m_resg_desccMSGERROR = value;
					OnPropertyChanged("RESG_DescCMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: RESG_PositivoNegativo.
		/// </summary>
		[DataMember]
		public Boolean RESG_PositivoNegativoOK
		{
			get { return m_resg_positivonegativoOK; }
			set
			{
				if (m_resg_positivonegativoOK != value)
				{
					m_resg_positivonegativoOK = value;
					OnPropertyChanged("RESG_PositivoNegativoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: RESG_PositivoNegativo.
		/// </summary>
		[DataMember]
		public String RESG_PositivoNegativoMSGERROR
		{
			get { return m_resg_positivonegativoMSGERROR; }
			set
			{
				if (m_resg_positivonegativoMSGERROR != value)
				{
					m_resg_positivonegativoMSGERROR = value;
					OnPropertyChanged("RESG_PositivoNegativoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: RESG_Activo.
		/// </summary>
		[DataMember]
		public Boolean RESG_ActivoOK
		{
			get { return m_resg_activoOK; }
			set
			{
				if (m_resg_activoOK != value)
				{
					m_resg_activoOK = value;
					OnPropertyChanged("RESG_ActivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: RESG_Activo.
		/// </summary>
		[DataMember]
		public String RESG_ActivoMSGERROR
		{
			get { return m_resg_activoMSGERROR; }
			set
			{
				if (m_resg_activoMSGERROR != value)
				{
					m_resg_activoMSGERROR = value;
					OnPropertyChanged("RESG_ActivoMSGERROR");
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
				RESG_CodigoOK  = true;
				RESG_CodigoMSGERROR  = "";
				if( RESG_Codigo == null)
				{
					_isCorrect = false;
					RESG_CodigoOK  = false;
					RESG_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "RESG_Codigo", "ResultGestion");
					m_mensajeError += "* Debe ingresar el campo RESG_Codigo" + Environment.NewLine;
				}
				RESG_DescOK  = true;
				RESG_DescMSGERROR  = "";
				if( String.IsNullOrEmpty(RESG_Desc) )
				{
					_isCorrect = false;
					RESG_DescOK  = false;
					RESG_DescMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "RESG_Desc", "ResultGestion");
					m_mensajeError += "* Debe ingresar el campo RESG_Desc" + Environment.NewLine;
				}
				RESG_PositivoNegativoOK  = true;
				RESG_PositivoNegativoMSGERROR  = "";
				if( RESG_PositivoNegativo == null)
				{
					_isCorrect = false;
					RESG_PositivoNegativoOK  = false;
					RESG_PositivoNegativoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "RESG_PositivoNegativo", "ResultGestion");
					m_mensajeError += "* Debe ingresar el campo RESG_PositivoNegativo" + Environment.NewLine;
				}
				RESG_ActivoOK  = true;
				RESG_ActivoMSGERROR  = "";
				if( RESG_Activo == null)
				{
					_isCorrect = false;
					RESG_ActivoOK  = false;
					RESG_ActivoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "RESG_Activo", "ResultGestion");
					m_mensajeError += "* Debe ingresar el campo RESG_Activo" + Environment.NewLine;
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
