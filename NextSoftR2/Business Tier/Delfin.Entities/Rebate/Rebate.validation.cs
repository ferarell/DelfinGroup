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
	public partial class Rebate
	{
		#region [ Variables Validación ]
		private Boolean m_reba_codigoOK;
		private String m_reba_codigoMSGERROR;
		private Boolean m_cont_codigoOK;
		private String m_cont_codigoMSGERROR;
		private Boolean m_reba_feciniOK;
		private String m_reba_feciniMSGERROR;
		private Boolean m_reba_fecfinOK;
		private String m_reba_fecfinMSGERROR;
		private Boolean m_entc_codtransportistaOK;
		private String m_entc_codtransportistaMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_empr_codigoOK;
		private String m_empr_codigoMSGERROR;
		private Boolean m_puer_coddestinoOK;
		private String m_puer_coddestinoMSGERROR;
		private Boolean m_puer_codorigenOK;
		private String m_puer_codorigenMSGERROR;
		private Boolean m_conc_tabrebOK;
		private String m_conc_tabrebMSGERROR;
		private Boolean m_conc_codrebOK;
		private String m_conc_codrebMSGERROR;
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
		/// Gets or sets el valor de validación de: REBA_Codigo.
		/// </summary>
		[DataMember]
		public Boolean REBA_CodigoOK
		{
			get { return m_reba_codigoOK; }
			set
			{
				if (m_reba_codigoOK != value)
				{
					m_reba_codigoOK = value;
					OnPropertyChanged("REBA_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: REBA_Codigo.
		/// </summary>
		[DataMember]
		public String REBA_CodigoMSGERROR
		{
			get { return m_reba_codigoMSGERROR; }
			set
			{
				if (m_reba_codigoMSGERROR != value)
				{
					m_reba_codigoMSGERROR = value;
					OnPropertyChanged("REBA_CodigoMSGERROR");
				}
			}
		}
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
		/// Gets or sets el valor de validación de: REBA_FecIni.
		/// </summary>
		[DataMember]
		public Boolean REBA_FecIniOK
		{
			get { return m_reba_feciniOK; }
			set
			{
				if (m_reba_feciniOK != value)
				{
					m_reba_feciniOK = value;
					OnPropertyChanged("REBA_FecIniOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: REBA_FecIni.
		/// </summary>
		[DataMember]
		public String REBA_FecIniMSGERROR
		{
			get { return m_reba_feciniMSGERROR; }
			set
			{
				if (m_reba_feciniMSGERROR != value)
				{
					m_reba_feciniMSGERROR = value;
					OnPropertyChanged("REBA_FecIniMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: REBA_FecFin.
		/// </summary>
		[DataMember]
		public Boolean REBA_FecFinOK
		{
			get { return m_reba_fecfinOK; }
			set
			{
				if (m_reba_fecfinOK != value)
				{
					m_reba_fecfinOK = value;
					OnPropertyChanged("REBA_FecFinOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: REBA_FecFin.
		/// </summary>
		[DataMember]
		public String REBA_FecFinMSGERROR
		{
			get { return m_reba_fecfinMSGERROR; }
			set
			{
				if (m_reba_fecfinMSGERROR != value)
				{
					m_reba_fecfinMSGERROR = value;
					OnPropertyChanged("REBA_FecFinMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodTransportistaOK
		{
			get { return m_entc_codtransportistaOK; }
			set
			{
				if (m_entc_codtransportistaOK != value)
				{
					m_entc_codtransportistaOK = value;
					OnPropertyChanged("ENTC_CodTransportistaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public String ENTC_CodTransportistaMSGERROR
		{
			get { return m_entc_codtransportistaMSGERROR; }
			set
			{
				if (m_entc_codtransportistaMSGERROR != value)
				{
					m_entc_codtransportistaMSGERROR = value;
					OnPropertyChanged("ENTC_CodTransportistaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabMndOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{
					m_tipo_tabmndOK = value;
					OnPropertyChanged("TIPO_TabMndOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMnd.
		/// </summary>
		[DataMember]
		public String TIPO_TabMndMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{
					m_tipo_tabmndMSGERROR = value;
					OnPropertyChanged("TIPO_TabMndMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodMndOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{
					m_tipo_codmndOK = value;
					OnPropertyChanged("TIPO_CodMndOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMnd.
		/// </summary>
		[DataMember]
		public String TIPO_CodMndMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{
					m_tipo_codmndMSGERROR = value;
					OnPropertyChanged("TIPO_CodMndMSGERROR");
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
		/// Gets or sets el valor de validación de: PUER_CodDestino.
		/// </summary>
		[DataMember]
		public Boolean PUER_CodDestinoOK
		{
			get { return m_puer_coddestinoOK; }
			set
			{
				if (m_puer_coddestinoOK != value)
				{
					m_puer_coddestinoOK = value;
					OnPropertyChanged("PUER_CodDestinoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_CodDestino.
		/// </summary>
		[DataMember]
		public String PUER_CodDestinoMSGERROR
		{
			get { return m_puer_coddestinoMSGERROR; }
			set
			{
				if (m_puer_coddestinoMSGERROR != value)
				{
					m_puer_coddestinoMSGERROR = value;
					OnPropertyChanged("PUER_CodDestinoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: PUER_CodOrigen.
		/// </summary>
		[DataMember]
		public Boolean PUER_CodOrigenOK
		{
			get { return m_puer_codorigenOK; }
			set
			{
				if (m_puer_codorigenOK != value)
				{
					m_puer_codorigenOK = value;
					OnPropertyChanged("PUER_CodOrigenOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: PUER_CodOrigen.
		/// </summary>
		[DataMember]
		public String PUER_CodOrigenMSGERROR
		{
			get { return m_puer_codorigenMSGERROR; }
			set
			{
				if (m_puer_codorigenMSGERROR != value)
				{
					m_puer_codorigenMSGERROR = value;
					OnPropertyChanged("PUER_CodOrigenMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONC_TabReb.
		/// </summary>
		[DataMember]
		public Boolean CONC_TabRebOK
		{
			get { return m_conc_tabrebOK; }
			set
			{
				if (m_conc_tabrebOK != value)
				{
					m_conc_tabrebOK = value;
					OnPropertyChanged("CONC_TabRebOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONC_TabReb.
		/// </summary>
		[DataMember]
		public String CONC_TabRebMSGERROR
		{
			get { return m_conc_tabrebMSGERROR; }
			set
			{
				if (m_conc_tabrebMSGERROR != value)
				{
					m_conc_tabrebMSGERROR = value;
					OnPropertyChanged("CONC_TabRebMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONC_CodReb.
		/// </summary>
		[DataMember]
		public Boolean CONC_CodRebOK
		{
			get { return m_conc_codrebOK; }
			set
			{
				if (m_conc_codrebOK != value)
				{
					m_conc_codrebOK = value;
					OnPropertyChanged("CONC_CodRebOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONC_CodReb.
		/// </summary>
		[DataMember]
		public String CONC_CodRebMSGERROR
		{
			get { return m_conc_codrebMSGERROR; }
			set
			{
				if (m_conc_codrebMSGERROR != value)
				{
					m_conc_codrebMSGERROR = value;
					OnPropertyChanged("CONC_CodRebMSGERROR");
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
				REBA_CodigoOK  = true;
				REBA_CodigoMSGERROR  = "";
				if( REBA_Codigo == null)
				{
					_isCorrect = false;
					REBA_CodigoOK  = false;
					REBA_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "REBA_Codigo", "Rebate");
					m_mensajeError += "* Debe ingresar el campo REBA_Codigo" + Environment.NewLine;
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
