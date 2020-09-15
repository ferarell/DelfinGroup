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
	public partial class Contrato_Comodity
	{
		#region [ Variables Validación ]
		private Boolean m_cont_codigoOK;
		private String m_cont_codigoMSGERROR;
		private Boolean m_tipo_tabcdtOK;
		private String m_tipo_tabcdtMSGERROR;
		private Boolean m_tipo_codcdtOK;
		private String m_tipo_codcdtMSGERROR;
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
		/// Gets or sets el valor de validación de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CONT_CodigoOK
		{
			get { return m_cont_codigoOK; }
			set
			{
				if (m_cont_codigoOK != value)
				{
					m_cont_codigoOK = value;
					OnPropertyChanged("CONT_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public String CONT_CodigoMSGERROR
		{
			get { return m_cont_codigoMSGERROR; }
			set
			{
				if (m_cont_codigoMSGERROR != value)
				{
					m_cont_codigoMSGERROR = value;
					OnPropertyChanged("CONT_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabCDTOK
		{
			get { return m_tipo_tabcdtOK; }
			set
			{
				if (m_tipo_tabcdtOK != value)
				{
					m_tipo_tabcdtOK = value;
					OnPropertyChanged("TIPO_TabCDTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabCDT.
		/// </summary>
		[DataMember]
		public String TIPO_TabCDTMSGERROR
		{
			get { return m_tipo_tabcdtMSGERROR; }
			set
			{
				if (m_tipo_tabcdtMSGERROR != value)
				{
					m_tipo_tabcdtMSGERROR = value;
					OnPropertyChanged("TIPO_TabCDTMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodCDTOK
		{
			get { return m_tipo_codcdtOK; }
			set
			{
				if (m_tipo_codcdtOK != value)
				{
					m_tipo_codcdtOK = value;
					OnPropertyChanged("TIPO_CodCDTOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodCDT.
		/// </summary>
		[DataMember]
		public String TIPO_CodCDTMSGERROR
		{
			get { return m_tipo_codcdtMSGERROR; }
			set
			{
				if (m_tipo_codcdtMSGERROR != value)
				{
					m_tipo_codcdtMSGERROR = value;
					OnPropertyChanged("TIPO_CodCDTMSGERROR");
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
				CONT_CodigoOK  = true;
				CONT_CodigoMSGERROR  = "";
				if( CONT_Codigo == null)
				{
					_isCorrect = false;
					CONT_CodigoOK  = false;
					CONT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONT_Codigo", "Contrato_Comodity");
					m_mensajeError += "* Debe ingresar el campo CONT_Codigo" + Environment.NewLine;
				}
				TIPO_TabCDTOK  = true;
				TIPO_TabCDTMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_TabCDT) )
				{
					_isCorrect = false;
					TIPO_TabCDTOK  = false;
					TIPO_TabCDTMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_TabCDT", "Contrato_Comodity");
					m_mensajeError += "* Debe ingresar el campo TIPO_TabCDT" + Environment.NewLine;
				}
				TIPO_CodCDTOK  = true;
				TIPO_CodCDTMSGERROR  = "";
				if( String.IsNullOrEmpty(TIPO_CodCDT) )
				{
					_isCorrect = false;
					TIPO_CodCDTOK  = false;
					TIPO_CodCDTMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "TIPO_CodCDT", "Contrato_Comodity");
					m_mensajeError += "* Debe ingresar el campo TIPO_CodCDT" + Environment.NewLine;
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
