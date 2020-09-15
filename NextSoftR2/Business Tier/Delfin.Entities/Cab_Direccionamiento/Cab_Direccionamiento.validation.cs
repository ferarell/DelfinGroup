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
	public partial class Cab_Direccionamiento
	{
		#region [ Variables Validación ]
		private Boolean m_cdir_codigoOK;
		private String m_cdir_codigoMSGERROR;
		private Boolean m_cdir_hblOK;
		private String m_cdir_hblMSGERROR;
		private Boolean m_cdir_mblOK;
		private String m_cdir_mblMSGERROR;
		private Boolean m_cdir_fecarriboOK;
		private String m_cdir_fecarriboMSGERROR;
		private Boolean m_cdir_observacionesOK;
		private String m_cdir_observacionesMSGERROR;
		private Boolean m_entc_codclienteOK;
		private String m_entc_codclienteMSGERROR;
		private Boolean m_entc_codlineaOK;
		private String m_entc_codlineaMSGERROR;
		private Boolean m_entc_codtemporalOK;
		private String m_entc_codtemporalMSGERROR;
		private Boolean m_cdir_fecemisionOK;
		private String m_cdir_fecemisionMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_cdir_naveOK;
		private String m_cdir_naveMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CDIR_CodigoOK
		{
			get { return m_cdir_codigoOK; }
			set
			{
				if (m_cdir_codigoOK != value)
				{
					m_cdir_codigoOK = value;
					OnPropertyChanged("CDIR_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_Codigo.
		/// </summary>
		[DataMember]
		public String CDIR_CodigoMSGERROR
		{
			get { return m_cdir_codigoMSGERROR; }
			set
			{
				if (m_cdir_codigoMSGERROR != value)
				{
					m_cdir_codigoMSGERROR = value;
					OnPropertyChanged("CDIR_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_HBL.
		/// </summary>
		[DataMember]
		public Boolean CDIR_HBLOK
		{
			get { return m_cdir_hblOK; }
			set
			{
				if (m_cdir_hblOK != value)
				{
					m_cdir_hblOK = value;
					OnPropertyChanged("CDIR_HBLOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_HBL.
		/// </summary>
		[DataMember]
		public String CDIR_HBLMSGERROR
		{
			get { return m_cdir_hblMSGERROR; }
			set
			{
				if (m_cdir_hblMSGERROR != value)
				{
					m_cdir_hblMSGERROR = value;
					OnPropertyChanged("CDIR_HBLMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_MBL.
		/// </summary>
		[DataMember]
		public Boolean CDIR_MBLOK
		{
			get { return m_cdir_mblOK; }
			set
			{
				if (m_cdir_mblOK != value)
				{
					m_cdir_mblOK = value;
					OnPropertyChanged("CDIR_MBLOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_MBL.
		/// </summary>
		[DataMember]
		public String CDIR_MBLMSGERROR
		{
			get { return m_cdir_mblMSGERROR; }
			set
			{
				if (m_cdir_mblMSGERROR != value)
				{
					m_cdir_mblMSGERROR = value;
					OnPropertyChanged("CDIR_MBLMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_FecArribo.
		/// </summary>
		[DataMember]
		public Boolean CDIR_FecArriboOK
		{
			get { return m_cdir_fecarriboOK; }
			set
			{
				if (m_cdir_fecarriboOK != value)
				{
					m_cdir_fecarriboOK = value;
					OnPropertyChanged("CDIR_FecArriboOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_FecArribo.
		/// </summary>
		[DataMember]
		public String CDIR_FecArriboMSGERROR
		{
			get { return m_cdir_fecarriboMSGERROR; }
			set
			{
				if (m_cdir_fecarriboMSGERROR != value)
				{
					m_cdir_fecarriboMSGERROR = value;
					OnPropertyChanged("CDIR_FecArriboMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_Observaciones.
		/// </summary>
		[DataMember]
		public Boolean CDIR_ObservacionesOK
		{
			get { return m_cdir_observacionesOK; }
			set
			{
				if (m_cdir_observacionesOK != value)
				{
					m_cdir_observacionesOK = value;
					OnPropertyChanged("CDIR_ObservacionesOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_Observaciones.
		/// </summary>
		[DataMember]
		public String CDIR_ObservacionesMSGERROR
		{
			get { return m_cdir_observacionesMSGERROR; }
			set
			{
				if (m_cdir_observacionesMSGERROR != value)
				{
					m_cdir_observacionesMSGERROR = value;
					OnPropertyChanged("CDIR_ObservacionesMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodClienteOK
		{
			get { return m_entc_codclienteOK; }
			set
			{
				if (m_entc_codclienteOK != value)
				{
					m_entc_codclienteOK = value;
					OnPropertyChanged("ENTC_CodClienteOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public String ENTC_CodClienteMSGERROR
		{
			get { return m_entc_codclienteMSGERROR; }
			set
			{
				if (m_entc_codclienteMSGERROR != value)
				{
					m_entc_codclienteMSGERROR = value;
					OnPropertyChanged("ENTC_CodClienteMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodLinea.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodLineaOK
		{
			get { return m_entc_codlineaOK; }
			set
			{
				if (m_entc_codlineaOK != value)
				{
					m_entc_codlineaOK = value;
					OnPropertyChanged("ENTC_CodLineaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodLinea.
		/// </summary>
		[DataMember]
		public String ENTC_CodLineaMSGERROR
		{
			get { return m_entc_codlineaMSGERROR; }
			set
			{
				if (m_entc_codlineaMSGERROR != value)
				{
					m_entc_codlineaMSGERROR = value;
					OnPropertyChanged("ENTC_CodLineaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodTemporal.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodTemporalOK
		{
			get { return m_entc_codtemporalOK; }
			set
			{
				if (m_entc_codtemporalOK != value)
				{
					m_entc_codtemporalOK = value;
					OnPropertyChanged("ENTC_CodTemporalOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodTemporal.
		/// </summary>
		[DataMember]
		public String ENTC_CodTemporalMSGERROR
		{
			get { return m_entc_codtemporalMSGERROR; }
			set
			{
				if (m_entc_codtemporalMSGERROR != value)
				{
					m_entc_codtemporalMSGERROR = value;
					OnPropertyChanged("ENTC_CodTemporalMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_FecEmision.
		/// </summary>
		[DataMember]
		public Boolean CDIR_FecEmisionOK
		{
			get { return m_cdir_fecemisionOK; }
			set
			{
				if (m_cdir_fecemisionOK != value)
				{
					m_cdir_fecemisionOK = value;
					OnPropertyChanged("CDIR_FecEmisionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_FecEmision.
		/// </summary>
		[DataMember]
		public String CDIR_FecEmisionMSGERROR
		{
			get { return m_cdir_fecemisionMSGERROR; }
			set
			{
				if (m_cdir_fecemisionMSGERROR != value)
				{
					m_cdir_fecemisionMSGERROR = value;
					OnPropertyChanged("CDIR_FecEmisionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CDIR_Nave.
		/// </summary>
		[DataMember]
		public Boolean CDIR_NaveOK
		{
			get { return m_cdir_naveOK; }
			set
			{
				if (m_cdir_naveOK != value)
				{
					m_cdir_naveOK = value;
					OnPropertyChanged("CDIR_NaveOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CDIR_Nave.
		/// </summary>
		[DataMember]
		public String CDIR_NaveMSGERROR
		{
			get { return m_cdir_naveMSGERROR; }
			set
			{
				if (m_cdir_naveMSGERROR != value)
				{
					m_cdir_naveMSGERROR = value;
					OnPropertyChanged("CDIR_NaveMSGERROR");
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
				CDIR_CodigoOK  = true;
				CDIR_CodigoMSGERROR  = "";
				if( CDIR_Codigo == null)
				{
					_isCorrect = false;
					CDIR_CodigoOK  = false;
					CDIR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CDIR_Codigo", "Cab_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo CDIR_Codigo" + Environment.NewLine;
				}
				CDIR_HBLOK  = true;
				CDIR_HBLMSGERROR  = "";
				if( String.IsNullOrEmpty(CDIR_HBL) )
				{
					_isCorrect = false;
					CDIR_HBLOK  = false;
					CDIR_HBLMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CDIR_HBL", "Cab_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo CDIR_HBL" + Environment.NewLine;
				}
				CDIR_MBLOK  = true;
				CDIR_MBLMSGERROR  = "";
				if( String.IsNullOrEmpty(CDIR_MBL) )
				{
					_isCorrect = false;
					CDIR_MBLOK  = false;
					CDIR_MBLMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CDIR_MBL", "Cab_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo CDIR_MBL" + Environment.NewLine;
				}
				CDIR_ObservacionesOK  = true;
				CDIR_ObservacionesMSGERROR  = "";
				if( String.IsNullOrEmpty(CDIR_Observaciones) )
				{
					_isCorrect = false;
					CDIR_ObservacionesOK  = false;
					CDIR_ObservacionesMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CDIR_Observaciones", "Cab_Direccionamiento");
					m_mensajeError += "* Debe ingresar el campo CDIR_Observaciones" + Environment.NewLine;
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
