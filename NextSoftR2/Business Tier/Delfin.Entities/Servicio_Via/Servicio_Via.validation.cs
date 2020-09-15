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
	public partial class Servicio_Via
	{
		#region [ Variables Validación ]
		private Boolean m_cons_tabviaOK;
		private String m_cons_tabviaMSGERROR;
		private Boolean m_cons_codviaOK;
		private String m_cons_codviaMSGERROR;
		private Boolean m_serv_codigoOK;
		private String m_serv_codigoMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabVIA.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabVIAOK
		{
			get { return m_cons_tabviaOK; }
			set
			{
				if (m_cons_tabviaOK != value)
				{
					m_cons_tabviaOK = value;
					OnPropertyChanged("CONS_TabVIAOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabVIA.
		/// </summary>
		[DataMember]
		public String CONS_TabVIAMSGERROR
		{
			get { return m_cons_tabviaMSGERROR; }
			set
			{
				if (m_cons_tabviaMSGERROR != value)
				{
					m_cons_tabviaMSGERROR = value;
					OnPropertyChanged("CONS_TabVIAMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodVIA.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodVIAOK
		{
			get { return m_cons_codviaOK; }
			set
			{
				if (m_cons_codviaOK != value)
				{
					m_cons_codviaOK = value;
					OnPropertyChanged("CONS_CodVIAOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodVIA.
		/// </summary>
		[DataMember]
		public String CONS_CodVIAMSGERROR
		{
			get { return m_cons_codviaMSGERROR; }
			set
			{
				if (m_cons_codviaMSGERROR != value)
				{
					m_cons_codviaMSGERROR = value;
					OnPropertyChanged("CONS_CodVIAMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public Boolean SERV_CodigoOK
		{
			get { return m_serv_codigoOK; }
			set
			{
				if (m_serv_codigoOK != value)
				{
					m_serv_codigoOK = value;
					OnPropertyChanged("SERV_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: SERV_Codigo.
		/// </summary>
		[DataMember]
		public String SERV_CodigoMSGERROR
		{
			get { return m_serv_codigoMSGERROR; }
			set
			{
				if (m_serv_codigoMSGERROR != value)
				{
					m_serv_codigoMSGERROR = value;
					OnPropertyChanged("SERV_CodigoMSGERROR");
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
				CONS_TabVIAOK  = true;
				CONS_TabVIAMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_TabVIA) )
				{
					_isCorrect = false;
					CONS_TabVIAOK  = false;
					CONS_TabVIAMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_TabVIA", "Servicio_Via");
					m_mensajeError += "* Debe ingresar el campo CONS_TabVIA" + Environment.NewLine;
				}
				CONS_CodVIAOK  = true;
				CONS_CodVIAMSGERROR  = "";
				if( String.IsNullOrEmpty(CONS_CodVIA) )
				{
					_isCorrect = false;
					CONS_CodVIAOK  = false;
					CONS_CodVIAMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_CodVIA", "Servicio_Via");
					m_mensajeError += "* Debe ingresar el campo CONS_CodVIA" + Environment.NewLine;
				}
				SERV_CodigoOK  = true;
				SERV_CodigoMSGERROR  = "";
				if( SERV_Codigo == null)
				{
					_isCorrect = false;
					SERV_CodigoOK  = false;
					SERV_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SERV_Codigo", "Servicio_Via");
					m_mensajeError += "* Debe ingresar el campo SERV_Codigo" + Environment.NewLine;
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
