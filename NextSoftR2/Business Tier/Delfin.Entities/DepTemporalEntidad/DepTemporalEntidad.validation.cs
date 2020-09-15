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
	public partial class DepTemporalEntidad
	{
		#region [ Variables Validación ]
		private Boolean m_dete_codigoOK;
		private String m_dete_codigoMSGERROR;
		private Boolean m_entc_codlnavieraOK;
		private String m_entc_codlnavieraMSGERROR;
		private Boolean m_entc_coddeptemporalOK;
		private String m_entc_coddeptemporalMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: DETE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean DETE_CodigoOK
		{
			get { return m_dete_codigoOK; }
			set
			{
				if (m_dete_codigoOK != value)
				{
					m_dete_codigoOK = value;
					OnPropertyChanged("DETE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DETE_Codigo.
		/// </summary>
		[DataMember]
		public String DETE_CodigoMSGERROR
		{
			get { return m_dete_codigoMSGERROR; }
			set
			{
				if (m_dete_codigoMSGERROR != value)
				{
					m_dete_codigoMSGERROR = value;
					OnPropertyChanged("DETE_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodLNaviera.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodLNavieraOK
		{
			get { return m_entc_codlnavieraOK; }
			set
			{
				if (m_entc_codlnavieraOK != value)
				{
					m_entc_codlnavieraOK = value;
					OnPropertyChanged("ENTC_CodLNavieraOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodLNaviera.
		/// </summary>
		[DataMember]
		public String ENTC_CodLNavieraMSGERROR
		{
			get { return m_entc_codlnavieraMSGERROR; }
			set
			{
				if (m_entc_codlnavieraMSGERROR != value)
				{
					m_entc_codlnavieraMSGERROR = value;
					OnPropertyChanged("ENTC_CodLNavieraMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodDepTemporal.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodDepTemporalOK
		{
			get { return m_entc_coddeptemporalOK; }
			set
			{
				if (m_entc_coddeptemporalOK != value)
				{
					m_entc_coddeptemporalOK = value;
					OnPropertyChanged("ENTC_CodDepTemporalOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodDepTemporal.
		/// </summary>
		[DataMember]
		public String ENTC_CodDepTemporalMSGERROR
		{
			get { return m_entc_coddeptemporalMSGERROR; }
			set
			{
				if (m_entc_coddeptemporalMSGERROR != value)
				{
					m_entc_coddeptemporalMSGERROR = value;
					OnPropertyChanged("ENTC_CodDepTemporalMSGERROR");
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
				DETE_CodigoOK  = true;
				DETE_CodigoMSGERROR  = "";
				if( DETE_Codigo == null)
				{
					_isCorrect = false;
					DETE_CodigoOK  = false;
					DETE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DETE_Codigo", "DepTemporalEntidad");
					m_mensajeError += "* Debe ingresar el campo DETE_Codigo" + Environment.NewLine;
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
