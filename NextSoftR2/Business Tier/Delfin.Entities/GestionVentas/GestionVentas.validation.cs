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
	public partial class GestionVentas
	{
		#region [ Variables Validación ]
		private Boolean m_gest_codigoOK;
		private String m_gest_codigoMSGERROR;
		private Boolean m_sucr_codigoOK;
		private String m_sucr_codigoMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_tipo_tabgesOK;
		private String m_tipo_tabgesMSGERROR;
		private Boolean m_tipo_codgesOK;
		private String m_tipo_codgesMSGERROR;
		private Boolean m_gest_fechaOK;
		private String m_gest_fechaMSGERROR;
		private Boolean m_gest_observacionOK;
		private String m_gest_observacionMSGERROR;
		private Boolean m_gest_fechaproximagestionOK;
		private String m_gest_fechaproximagestionMSGERROR;
		private Boolean m_gest_tiempoproximagestionOK;
		private String m_gest_tiempoproximagestionMSGERROR;
		private Boolean m_tipo_tabgesproximaOK;
		private String m_tipo_tabgesproximaMSGERROR;
		private Boolean m_tipo_codgesproximaOK;
		private String m_tipo_codgesproximaMSGERROR;
		private Boolean m_resg_codigoOK;
		private String m_resg_codigoMSGERROR;
		private Boolean m_pros_codigoOK;
		private String m_pros_codigoMSGERROR;
		private Boolean m_entc_codclienteOK;
		private String m_entc_codclienteMSGERROR;
		private Boolean m_entc_codejecutivoOK;
		private String m_entc_codejecutivoMSGERROR;
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
		/// Gets or sets el valor de validación de: GEST_Codigo.
		/// </summary>
		[DataMember]
		public Boolean GEST_CodigoOK
		{
			get { return m_gest_codigoOK; }
			set
			{
				if (m_gest_codigoOK != value)
				{
					m_gest_codigoOK = value;
					OnPropertyChanged("GEST_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GEST_Codigo.
		/// </summary>
		[DataMember]
		public String GEST_CodigoMSGERROR
		{
			get { return m_gest_codigoMSGERROR; }
			set
			{
				if (m_gest_codigoMSGERROR != value)
				{
					m_gest_codigoMSGERROR = value;
					OnPropertyChanged("GEST_CodigoMSGERROR");
				}
			}
		}
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
		/// Gets or sets el valor de validación de: TIPO_TabGES.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabGESOK
		{
			get { return m_tipo_tabgesOK; }
			set
			{
				if (m_tipo_tabgesOK != value)
				{
					m_tipo_tabgesOK = value;
					OnPropertyChanged("TIPO_TabGESOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabGES.
		/// </summary>
		[DataMember]
		public String TIPO_TabGESMSGERROR
		{
			get { return m_tipo_tabgesMSGERROR; }
			set
			{
				if (m_tipo_tabgesMSGERROR != value)
				{
					m_tipo_tabgesMSGERROR = value;
					OnPropertyChanged("TIPO_TabGESMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodGES.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodGESOK
		{
			get { return m_tipo_codgesOK; }
			set
			{
				if (m_tipo_codgesOK != value)
				{
					m_tipo_codgesOK = value;
					OnPropertyChanged("TIPO_CodGESOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodGES.
		/// </summary>
		[DataMember]
		public String TIPO_CodGESMSGERROR
		{
			get { return m_tipo_codgesMSGERROR; }
			set
			{
				if (m_tipo_codgesMSGERROR != value)
				{
					m_tipo_codgesMSGERROR = value;
					OnPropertyChanged("TIPO_CodGESMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: GEST_Fecha.
		/// </summary>
		[DataMember]
		public Boolean GEST_FechaOK
		{
			get { return m_gest_fechaOK; }
			set
			{
				if (m_gest_fechaOK != value)
				{
					m_gest_fechaOK = value;
					OnPropertyChanged("GEST_FechaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GEST_Fecha.
		/// </summary>
		[DataMember]
		public String GEST_FechaMSGERROR
		{
			get { return m_gest_fechaMSGERROR; }
			set
			{
				if (m_gest_fechaMSGERROR != value)
				{
					m_gest_fechaMSGERROR = value;
					OnPropertyChanged("GEST_FechaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: GEST_Observacion.
		/// </summary>
		[DataMember]
		public Boolean GEST_ObservacionOK
		{
			get { return m_gest_observacionOK; }
			set
			{
				if (m_gest_observacionOK != value)
				{
					m_gest_observacionOK = value;
					OnPropertyChanged("GEST_ObservacionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GEST_Observacion.
		/// </summary>
		[DataMember]
		public String GEST_ObservacionMSGERROR
		{
			get { return m_gest_observacionMSGERROR; }
			set
			{
				if (m_gest_observacionMSGERROR != value)
				{
					m_gest_observacionMSGERROR = value;
					OnPropertyChanged("GEST_ObservacionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: GEST_FechaProximaGestion.
		/// </summary>
		[DataMember]
		public Boolean GEST_FechaProximaGestionOK
		{
			get { return m_gest_fechaproximagestionOK; }
			set
			{
				if (m_gest_fechaproximagestionOK != value)
				{
					m_gest_fechaproximagestionOK = value;
					OnPropertyChanged("GEST_FechaProximaGestionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GEST_FechaProximaGestion.
		/// </summary>
		[DataMember]
		public String GEST_FechaProximaGestionMSGERROR
		{
			get { return m_gest_fechaproximagestionMSGERROR; }
			set
			{
				if (m_gest_fechaproximagestionMSGERROR != value)
				{
					m_gest_fechaproximagestionMSGERROR = value;
					OnPropertyChanged("GEST_FechaProximaGestionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: GEST_TiempoProximaGestion.
		/// </summary>
		[DataMember]
		public Boolean GEST_TiempoProximaGestionOK
		{
			get { return m_gest_tiempoproximagestionOK; }
			set
			{
				if (m_gest_tiempoproximagestionOK != value)
				{
					m_gest_tiempoproximagestionOK = value;
					OnPropertyChanged("GEST_TiempoProximaGestionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: GEST_TiempoProximaGestion.
		/// </summary>
		[DataMember]
		public String GEST_TiempoProximaGestionMSGERROR
		{
			get { return m_gest_tiempoproximagestionMSGERROR; }
			set
			{
				if (m_gest_tiempoproximagestionMSGERROR != value)
				{
					m_gest_tiempoproximagestionMSGERROR = value;
					OnPropertyChanged("GEST_TiempoProximaGestionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabGESProxima.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabGESProximaOK
		{
			get { return m_tipo_tabgesproximaOK; }
			set
			{
				if (m_tipo_tabgesproximaOK != value)
				{
					m_tipo_tabgesproximaOK = value;
					OnPropertyChanged("TIPO_TabGESProximaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabGESProxima.
		/// </summary>
		[DataMember]
		public String TIPO_TabGESProximaMSGERROR
		{
			get { return m_tipo_tabgesproximaMSGERROR; }
			set
			{
				if (m_tipo_tabgesproximaMSGERROR != value)
				{
					m_tipo_tabgesproximaMSGERROR = value;
					OnPropertyChanged("TIPO_TabGESProximaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodGESProxima.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodGESProximaOK
		{
			get { return m_tipo_codgesproximaOK; }
			set
			{
				if (m_tipo_codgesproximaOK != value)
				{
					m_tipo_codgesproximaOK = value;
					OnPropertyChanged("TIPO_CodGESProximaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodGESProxima.
		/// </summary>
		[DataMember]
		public String TIPO_CodGESProximaMSGERROR
		{
			get { return m_tipo_codgesproximaMSGERROR; }
			set
			{
				if (m_tipo_codgesproximaMSGERROR != value)
				{
					m_tipo_codgesproximaMSGERROR = value;
					OnPropertyChanged("TIPO_CodGESProximaMSGERROR");
				}
			}
		}
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
		/// Gets or sets el valor de validación de: PROS_codigo.
		/// </summary>
		[DataMember]
		public Boolean PROS_codigoOK
		{
			get { return m_pros_codigoOK; }
			set
			{
				if (m_pros_codigoOK != value)
				{
					m_pros_codigoOK = value;
					OnPropertyChanged("PROS_codigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PROS_codigo.
		/// </summary>
		[DataMember]
		public String PROS_codigoMSGERROR
		{
			get { return m_pros_codigoMSGERROR; }
			set
			{
				if (m_pros_codigoMSGERROR != value)
				{
					m_pros_codigoMSGERROR = value;
					OnPropertyChanged("PROS_codigoMSGERROR");
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
		/// Gets or sets el valor de validación de: ENTC_CodEjecutivo.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodEjecutivoOK
		{
			get { return m_entc_codejecutivoOK; }
			set
			{
				if (m_entc_codejecutivoOK != value)
				{
					m_entc_codejecutivoOK = value;
					OnPropertyChanged("ENTC_CodEjecutivoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodEjecutivo.
		/// </summary>
		[DataMember]
		public String ENTC_CodEjecutivoMSGERROR
		{
			get { return m_entc_codejecutivoMSGERROR; }
			set
			{
				if (m_entc_codejecutivoMSGERROR != value)
				{
					m_entc_codejecutivoMSGERROR = value;
					OnPropertyChanged("ENTC_CodEjecutivoMSGERROR");
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
				GEST_CodigoOK  = true;
				GEST_CodigoMSGERROR  = "";
				if( GEST_Codigo == null)
				{
					_isCorrect = false;
					GEST_CodigoOK  = false;
					GEST_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "GEST_Codigo", "GestionVentas");
					m_mensajeError += "* Debe ingresar el campo GEST_Codigo" + Environment.NewLine;
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
