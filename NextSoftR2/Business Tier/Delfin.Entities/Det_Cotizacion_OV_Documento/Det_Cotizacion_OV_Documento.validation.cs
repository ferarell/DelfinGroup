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
	public partial class Det_Cotizacion_OV_Documento
	{
		#region [ Variables Validación ]
		private Boolean m_ccot_numeroOK;
		private String m_ccot_numeroMSGERROR;
		private Boolean m_doov_codigoOK;
		private String m_doov_codigoMSGERROR;
		private Boolean m_ccot_tipoOK;
		private String m_ccot_tipoMSGERROR;
		private Boolean m_doov_viajeOK;
		private String m_doov_viajeMSGERROR;
		private Boolean m_doov_feederOK;
		private String m_doov_feederMSGERROR;
		private Boolean m_doov_etaOK;
		private String m_doov_etaMSGERROR;
		private Boolean m_doov_etdfOK;
		private String m_doov_etdfMSGERROR;
		private Boolean m_doov_etdmOK;
		private String m_doov_etdmMSGERROR;
		private Boolean m_doov_cntrOK;
		private String m_doov_cntrMSGERROR;
		private Boolean m_doov_hblOK;
		private String m_doov_hblMSGERROR;
		private Boolean m_doov_mblOK;
		private String m_doov_mblMSGERROR;
		private Boolean m_doov_codreferenciaOK;
		private String m_doov_codreferenciaMSGERROR;
		private Boolean m_tipo_tabdtmOK;
		private String m_tipo_tabdtmMSGERROR;
		private Boolean m_tipo_coddtmOK;
		private String m_tipo_coddtmMSGERROR;
		private Boolean m_tipo_tabvaporOK;
		private String m_tipo_tabvaporMSGERROR;
		private Boolean m_tipo_codvaporOK;
		private String m_tipo_codvaporMSGERROR;
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
		/// Gets or sets el valor de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Boolean CCOT_NumeroOK
		{
			get { return m_ccot_numeroOK; }
			set
			{
				if (m_ccot_numeroOK != value)
				{
					m_ccot_numeroOK = value;
					OnPropertyChanged("CCOT_NumeroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public String CCOT_NumeroMSGERROR
		{
			get { return m_ccot_numeroMSGERROR; }
			set
			{
				if (m_ccot_numeroMSGERROR != value)
				{
					m_ccot_numeroMSGERROR = value;
					OnPropertyChanged("CCOT_NumeroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_Codigo.
		/// </summary>
		[DataMember]
		public Boolean DOOV_CodigoOK
		{
			get { return m_doov_codigoOK; }
			set
			{
				if (m_doov_codigoOK != value)
				{
					m_doov_codigoOK = value;
					OnPropertyChanged("DOOV_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_Codigo.
		/// </summary>
		[DataMember]
		public String DOOV_CodigoMSGERROR
		{
			get { return m_doov_codigoMSGERROR; }
			set
			{
				if (m_doov_codigoMSGERROR != value)
				{
					m_doov_codigoMSGERROR = value;
					OnPropertyChanged("DOOV_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_TipoOK
		{
			get { return m_ccot_tipoOK; }
			set
			{
				if (m_ccot_tipoOK != value)
				{
					m_ccot_tipoOK = value;
					OnPropertyChanged("CCOT_TipoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public String CCOT_TipoMSGERROR
		{
			get { return m_ccot_tipoMSGERROR; }
			set
			{
				if (m_ccot_tipoMSGERROR != value)
				{
					m_ccot_tipoMSGERROR = value;
					OnPropertyChanged("CCOT_TipoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_Viaje.
		/// </summary>
		[DataMember]
		public Boolean DOOV_ViajeOK
		{
			get { return m_doov_viajeOK; }
			set
			{
				if (m_doov_viajeOK != value)
				{
					m_doov_viajeOK = value;
					OnPropertyChanged("DOOV_ViajeOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_Viaje.
		/// </summary>
		[DataMember]
		public String DOOV_ViajeMSGERROR
		{
			get { return m_doov_viajeMSGERROR; }
			set
			{
				if (m_doov_viajeMSGERROR != value)
				{
					m_doov_viajeMSGERROR = value;
					OnPropertyChanged("DOOV_ViajeMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_Feeder.
		/// </summary>
		[DataMember]
		public Boolean DOOV_FeederOK
		{
			get { return m_doov_feederOK; }
			set
			{
				if (m_doov_feederOK != value)
				{
					m_doov_feederOK = value;
					OnPropertyChanged("DOOV_FeederOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_Feeder.
		/// </summary>
		[DataMember]
		public String DOOV_FeederMSGERROR
		{
			get { return m_doov_feederMSGERROR; }
			set
			{
				if (m_doov_feederMSGERROR != value)
				{
					m_doov_feederMSGERROR = value;
					OnPropertyChanged("DOOV_FeederMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_ETA.
		/// </summary>
		[DataMember]
		public Boolean DOOV_ETAOK
		{
			get { return m_doov_etaOK; }
			set
			{
				if (m_doov_etaOK != value)
				{
					m_doov_etaOK = value;
					OnPropertyChanged("DOOV_ETAOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_ETA.
		/// </summary>
		[DataMember]
		public String DOOV_ETAMSGERROR
		{
			get { return m_doov_etaMSGERROR; }
			set
			{
				if (m_doov_etaMSGERROR != value)
				{
					m_doov_etaMSGERROR = value;
					OnPropertyChanged("DOOV_ETAMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_ETDF.
		/// </summary>
		[DataMember]
		public Boolean DOOV_ETDFOK
		{
			get { return m_doov_etdfOK; }
			set
			{
				if (m_doov_etdfOK != value)
				{
					m_doov_etdfOK = value;
					OnPropertyChanged("DOOV_ETDFOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_ETDF.
		/// </summary>
		[DataMember]
		public String DOOV_ETDFMSGERROR
		{
			get { return m_doov_etdfMSGERROR; }
			set
			{
				if (m_doov_etdfMSGERROR != value)
				{
					m_doov_etdfMSGERROR = value;
					OnPropertyChanged("DOOV_ETDFMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_ETDM.
		/// </summary>
		[DataMember]
		public Boolean DOOV_ETDMOK
		{
			get { return m_doov_etdmOK; }
			set
			{
				if (m_doov_etdmOK != value)
				{
					m_doov_etdmOK = value;
					OnPropertyChanged("DOOV_ETDMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_ETDM.
		/// </summary>
		[DataMember]
		public String DOOV_ETDMMSGERROR
		{
			get { return m_doov_etdmMSGERROR; }
			set
			{
				if (m_doov_etdmMSGERROR != value)
				{
					m_doov_etdmMSGERROR = value;
					OnPropertyChanged("DOOV_ETDMMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_Cntr.
		/// </summary>
		[DataMember]
		public Boolean DOOV_CntrOK
		{
			get { return m_doov_cntrOK; }
			set
			{
				if (m_doov_cntrOK != value)
				{
					m_doov_cntrOK = value;
					OnPropertyChanged("DOOV_CntrOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_Cntr.
		/// </summary>
		[DataMember]
		public String DOOV_CntrMSGERROR
		{
			get { return m_doov_cntrMSGERROR; }
			set
			{
				if (m_doov_cntrMSGERROR != value)
				{
					m_doov_cntrMSGERROR = value;
					OnPropertyChanged("DOOV_CntrMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_HBL.
		/// </summary>
		[DataMember]
		public Boolean DOOV_HBLOK
		{
			get { return m_doov_hblOK; }
			set
			{
				if (m_doov_hblOK != value)
				{
					m_doov_hblOK = value;
					OnPropertyChanged("DOOV_HBLOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_HBL.
		/// </summary>
		[DataMember]
		public String DOOV_HBLMSGERROR
		{
			get { return m_doov_hblMSGERROR; }
			set
			{
				if (m_doov_hblMSGERROR != value)
				{
					m_doov_hblMSGERROR = value;
					OnPropertyChanged("DOOV_HBLMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_MBL.
		/// </summary>
		[DataMember]
		public Boolean DOOV_MBLOK
		{
			get { return m_doov_mblOK; }
			set
			{
				if (m_doov_mblOK != value)
				{
					m_doov_mblOK = value;
					OnPropertyChanged("DOOV_MBLOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_MBL.
		/// </summary>
		[DataMember]
		public String DOOV_MBLMSGERROR
		{
			get { return m_doov_mblMSGERROR; }
			set
			{
				if (m_doov_mblMSGERROR != value)
				{
					m_doov_mblMSGERROR = value;
					OnPropertyChanged("DOOV_MBLMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: DOOV_CodReferencia.
		/// </summary>
		[DataMember]
		public Boolean DOOV_CodReferenciaOK
		{
			get { return m_doov_codreferenciaOK; }
			set
			{
				if (m_doov_codreferenciaOK != value)
				{
					m_doov_codreferenciaOK = value;
					OnPropertyChanged("DOOV_CodReferenciaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: DOOV_CodReferencia.
		/// </summary>
		[DataMember]
		public String DOOV_CodReferenciaMSGERROR
		{
			get { return m_doov_codreferenciaMSGERROR; }
			set
			{
				if (m_doov_codreferenciaMSGERROR != value)
				{
					m_doov_codreferenciaMSGERROR = value;
					OnPropertyChanged("DOOV_CodReferenciaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabDTM.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabDTMOK
		{
			get { return m_tipo_tabdtmOK; }
			set
			{
				if (m_tipo_tabdtmOK != value)
				{
					m_tipo_tabdtmOK = value;
					OnPropertyChanged("TIPO_TabDTMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabDTM.
		/// </summary>
		[DataMember]
		public String TIPO_TabDTMMSGERROR
		{
			get { return m_tipo_tabdtmMSGERROR; }
			set
			{
				if (m_tipo_tabdtmMSGERROR != value)
				{
					m_tipo_tabdtmMSGERROR = value;
					OnPropertyChanged("TIPO_TabDTMMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodDTM.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodDTMOK
		{
			get { return m_tipo_coddtmOK; }
			set
			{
				if (m_tipo_coddtmOK != value)
				{
					m_tipo_coddtmOK = value;
					OnPropertyChanged("TIPO_CodDTMOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodDTM.
		/// </summary>
		[DataMember]
		public String TIPO_CodDTMMSGERROR
		{
			get { return m_tipo_coddtmMSGERROR; }
			set
			{
				if (m_tipo_coddtmMSGERROR != value)
				{
					m_tipo_coddtmMSGERROR = value;
					OnPropertyChanged("TIPO_CodDTMMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabVapor.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabVaporOK
		{
			get { return m_tipo_tabvaporOK; }
			set
			{
				if (m_tipo_tabvaporOK != value)
				{
					m_tipo_tabvaporOK = value;
					OnPropertyChanged("TIPO_TabVaporOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabVapor.
		/// </summary>
		[DataMember]
		public String TIPO_TabVaporMSGERROR
		{
			get { return m_tipo_tabvaporMSGERROR; }
			set
			{
				if (m_tipo_tabvaporMSGERROR != value)
				{
					m_tipo_tabvaporMSGERROR = value;
					OnPropertyChanged("TIPO_TabVaporMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodVapor.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodVaporOK
		{
			get { return m_tipo_codvaporOK; }
			set
			{
				if (m_tipo_codvaporOK != value)
				{
					m_tipo_codvaporOK = value;
					OnPropertyChanged("TIPO_CodVaporOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodVapor.
		/// </summary>
		[DataMember]
		public String TIPO_CodVaporMSGERROR
		{
			get { return m_tipo_codvaporMSGERROR; }
			set
			{
				if (m_tipo_codvaporMSGERROR != value)
				{
					m_tipo_codvaporMSGERROR = value;
					OnPropertyChanged("TIPO_CodVaporMSGERROR");
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
				CCOT_NumeroOK  = true;
				CCOT_NumeroMSGERROR  = "";
            //if( CCOT_Numero == null)
            //{
            //   _isCorrect = false;
            //   CCOT_NumeroOK  = false;
            //   CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "Det_Cotizacion_OV_Documento");
            //   m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
            //}
				DOOV_CodigoOK  = true;
				DOOV_CodigoMSGERROR  = "";
            //if( DOOV_Codigo == null)
            //{
            //   _isCorrect = false;
            //   DOOV_CodigoOK  = false;
            //   DOOV_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOOV_Codigo", "Det_Cotizacion_OV_Documento");
            //   m_mensajeError += "* Debe ingresar el campo DOOV_Codigo" + Environment.NewLine;
            //}
				CCOT_TipoOK  = true;
				CCOT_TipoMSGERROR  = "";
            //if( CCOT_Tipo == null)
            //{
            //   _isCorrect = false;
            //   CCOT_TipoOK  = false;
            //   CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "Det_Cotizacion_OV_Documento");
            //   m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
            //}
				DOOV_ViajeOK  = true;
				DOOV_ViajeMSGERROR  = "";
				if( String.IsNullOrEmpty(DOOV_Viaje) )
				{
					_isCorrect = false;
					DOOV_ViajeOK  = false;
					DOOV_ViajeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOOV_Viaje", "Det_Cotizacion_OV_Documento");
					m_mensajeError += "* Debe ingresar el campo DOOV_Viaje" + Environment.NewLine;
				}
				DOOV_FeederOK  = true;
				DOOV_FeederMSGERROR  = "";
				if( String.IsNullOrEmpty(DOOV_Feeder) )
				{
					_isCorrect = false;
					DOOV_FeederOK  = false;
					DOOV_FeederMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOOV_Feeder", "Det_Cotizacion_OV_Documento");
					m_mensajeError += "* Debe ingresar el campo DOOV_Feeder" + Environment.NewLine;
				}
				DOOV_CntrOK  = true;
				DOOV_CntrMSGERROR  = "";
				if( String.IsNullOrEmpty(DOOV_Cntr) )
				{
					_isCorrect = false;
					DOOV_CntrOK  = false;
					DOOV_CntrMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "DOOV_Cntr", "Det_Cotizacion_OV_Documento");
					m_mensajeError += "* Debe ingresar el campo DOOV_Cntr" + Environment.NewLine;
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
