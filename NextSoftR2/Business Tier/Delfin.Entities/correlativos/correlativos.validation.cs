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
	public partial class correlativos
	{
		#region [ Variables Validación ]
		private Boolean m_corr_servernameOK;
		private String m_corr_servernameMSGERROR;
		private Boolean m_corr_codcorrOK;
		private String m_corr_codcorrMSGERROR;
		private Boolean m_corr_ultnumOK;
		private String m_corr_ultnumMSGERROR;
		private Boolean m_corr_usrmodOK;
		private String m_corr_usrmodMSGERROR;
		private Boolean m_corr_fecmodOK;
		private String m_corr_fecmodMSGERROR;
		private Boolean m_corr_descOK;
		private String m_corr_descMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CORR_ServerName.
		/// </summary>
		[DataMember]
		public Boolean CORR_ServerNameOK
		{
			get { return m_corr_servernameOK; }
			set
			{
				if (m_corr_servernameOK != value)
				{
					m_corr_servernameOK = value;
					OnPropertyChanged("CORR_ServerNameOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CORR_ServerName.
		/// </summary>
		[DataMember]
		public String CORR_ServerNameMSGERROR
		{
			get { return m_corr_servernameMSGERROR; }
			set
			{
				if (m_corr_servernameMSGERROR != value)
				{
					m_corr_servernameMSGERROR = value;
					OnPropertyChanged("CORR_ServerNameMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CORR_CodCorr.
		/// </summary>
		[DataMember]
		public Boolean CORR_CodCorrOK
		{
			get { return m_corr_codcorrOK; }
			set
			{
				if (m_corr_codcorrOK != value)
				{
					m_corr_codcorrOK = value;
					OnPropertyChanged("CORR_CodCorrOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CORR_CodCorr.
		/// </summary>
		[DataMember]
		public String CORR_CodCorrMSGERROR
		{
			get { return m_corr_codcorrMSGERROR; }
			set
			{
				if (m_corr_codcorrMSGERROR != value)
				{
					m_corr_codcorrMSGERROR = value;
					OnPropertyChanged("CORR_CodCorrMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CORR_UltNum.
		/// </summary>
		[DataMember]
		public Boolean CORR_UltNumOK
		{
			get { return m_corr_ultnumOK; }
			set
			{
				if (m_corr_ultnumOK != value)
				{
					m_corr_ultnumOK = value;
					OnPropertyChanged("CORR_UltNumOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CORR_UltNum.
		/// </summary>
		[DataMember]
		public String CORR_UltNumMSGERROR
		{
			get { return m_corr_ultnumMSGERROR; }
			set
			{
				if (m_corr_ultnumMSGERROR != value)
				{
					m_corr_ultnumMSGERROR = value;
					OnPropertyChanged("CORR_UltNumMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CORR_Desc.
		/// </summary>
		[DataMember]
		public Boolean CORR_DescOK
		{
			get { return m_corr_descOK; }
			set
			{
				if (m_corr_descOK != value)
				{
					m_corr_descOK = value;
					OnPropertyChanged("CORR_DescOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CORR_Desc.
		/// </summary>
		[DataMember]
		public String CORR_DescMSGERROR
		{
			get { return m_corr_descMSGERROR; }
			set
			{
				if (m_corr_descMSGERROR != value)
				{
					m_corr_descMSGERROR = value;
					OnPropertyChanged("CORR_DescMSGERROR");
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
				CORR_ServerNameOK  = true;
				CORR_ServerNameMSGERROR  = "";
				if( String.IsNullOrEmpty(CORR_ServerName) )
				{
					_isCorrect = false;
					CORR_ServerNameOK  = false;
					CORR_ServerNameMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CORR_ServerName", "correlativos");
					m_mensajeError += "* Debe ingresar el campo CORR_ServerName" + Environment.NewLine;
				}
				CORR_CodCorrOK  = true;
				CORR_CodCorrMSGERROR  = "";
				if( String.IsNullOrEmpty(CORR_CodCorr) )
				{
					_isCorrect = false;
					CORR_CodCorrOK  = false;
					CORR_CodCorrMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CORR_CodCorr", "correlativos");
					m_mensajeError += "* Debe ingresar el campo CORR_CodCorr" + Environment.NewLine;
				}
				CORR_UltNumOK  = true;
				CORR_UltNumMSGERROR  = "";
				if( CORR_UltNum == null)
				{
					_isCorrect = false;
					CORR_UltNumOK  = false;
					CORR_UltNumMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CORR_UltNum", "correlativos");
					m_mensajeError += "* Debe ingresar el campo CORR_UltNum" + Environment.NewLine;
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
