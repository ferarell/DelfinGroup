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
	public partial class DetNaveViaje
	{
		#region [ Variables Validación ]
		private Boolean m_dvia_codigoOK;
		private String m_dvia_codigoMSGERROR;
		private Boolean m_nvia_codigoOK;
		private String m_nvia_codigoMSGERROR;
		private Boolean m_puer_codigoOK;
		private String m_puer_codigoMSGERROR;
		private Boolean m_dvia_feceta_expo_etdmaster_impoOK;
		private String m_dvia_feceta_expo_etdmaster_impoMSGERROR;
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
		/// Gets or sets el valor de validación de: DVIA_Codigo.
		/// </summary>
		[DataMember]
		public Boolean DVIA_CodigoOK
		{
			get { return m_dvia_codigoOK; }
			set
			{
				if (m_dvia_codigoOK != value)
				{
					m_dvia_codigoOK = value;
					OnPropertyChanged("DVIA_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DVIA_Codigo.
		/// </summary>
		[DataMember]
		public String DVIA_CodigoMSGERROR
		{
			get { return m_dvia_codigoMSGERROR; }
			set
			{
				if (m_dvia_codigoMSGERROR != value)
				{
					m_dvia_codigoMSGERROR = value;
					OnPropertyChanged("DVIA_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: NVIA_Codigo.
		/// </summary>
		[DataMember]
		public Boolean NVIA_CodigoOK
		{
			get { return m_nvia_codigoOK; }
			set
			{
				if (m_nvia_codigoOK != value)
				{
					m_nvia_codigoOK = value;
					OnPropertyChanged("NVIA_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: NVIA_Codigo.
		/// </summary>
		[DataMember]
		public String NVIA_CodigoMSGERROR
		{
			get { return m_nvia_codigoMSGERROR; }
			set
			{
				if (m_nvia_codigoMSGERROR != value)
				{
					m_nvia_codigoMSGERROR = value;
					OnPropertyChanged("NVIA_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_Codigo.
		/// </summary>
		[DataMember]
		public Boolean PUER_CodigoOK
		{
			get { return m_puer_codigoOK; }
			set
			{
				if (m_puer_codigoOK != value)
				{
					m_puer_codigoOK = value;
					OnPropertyChanged("PUER_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_Codigo.
		/// </summary>
		[DataMember]
		public String PUER_CodigoMSGERROR
		{
			get { return m_puer_codigoMSGERROR; }
			set
			{
				if (m_puer_codigoMSGERROR != value)
				{
					m_puer_codigoMSGERROR = value;
					OnPropertyChanged("PUER_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DVIA_FecETA_EXPO_ETDMaster_IMPO.
		/// </summary>
		[DataMember]
		public Boolean DVIA_FecETA_EXPO_ETDMaster_IMPOOK
		{
			get { return m_dvia_feceta_expo_etdmaster_impoOK; }
			set
			{
				if (m_dvia_feceta_expo_etdmaster_impoOK != value)
				{
					m_dvia_feceta_expo_etdmaster_impoOK = value;
					OnPropertyChanged("DVIA_FecETA_EXPO_ETDMaster_IMPOOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DVIA_FecETA_EXPO_ETDMaster_IMPO.
		/// </summary>
		[DataMember]
		public String DVIA_FecETA_EXPO_ETDMaster_IMPOMSGERROR
		{
			get { return m_dvia_feceta_expo_etdmaster_impoMSGERROR; }
			set
			{
				if (m_dvia_feceta_expo_etdmaster_impoMSGERROR != value)
				{
					m_dvia_feceta_expo_etdmaster_impoMSGERROR = value;
					OnPropertyChanged("DVIA_FecETA_EXPO_ETDMaster_IMPOMSGERROR");
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
				DVIA_CodigoOK  = true;
				DVIA_CodigoMSGERROR  = "";
				if( DVIA_Codigo == null)
				{
					_isCorrect = false;
					DVIA_CodigoOK  = false;
					DVIA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DVIA_Codigo", "DetNaveViaje");
					m_mensajeError += "* Debe ingresar el campo DVIA_Codigo" + Environment.NewLine;
				}
				NVIA_CodigoOK  = true;
				NVIA_CodigoMSGERROR  = "";
				if( NVIA_Codigo == null)
				{
					_isCorrect = false;
					NVIA_CodigoOK  = false;
					NVIA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "NVIA_Codigo", "DetNaveViaje");
					m_mensajeError += "* Debe ingresar el campo NVIA_Codigo" + Environment.NewLine;
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
