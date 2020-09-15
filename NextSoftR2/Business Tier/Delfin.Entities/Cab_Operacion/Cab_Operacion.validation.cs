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
    public partial class Cab_Operacion
	{
		#region [ Variables Validación ]
		private Boolean m_cope_codigoOK;
		private String m_cope_codigoMSGERROR;
		private Boolean m_cope_numdocOK;
		private String m_cope_numdocMSGERROR;
		private Boolean m_cope_fecemiOK;
		private String m_cope_fecemiMSGERROR;
		private Boolean m_cope_observacionOK;
		private String m_cope_observacionMSGERROR;
		private Boolean m_cope_hblOK;
		private String m_cope_hblMSGERROR;
		private Boolean m_ccot_codigoOK;
		private String m_ccot_codigoMSGERROR;
		private Boolean m_entc_codclienteOK;
		private String m_entc_codclienteMSGERROR;
		private Boolean m_entc_codtransporteOK;
		private String m_entc_codtransporteMSGERROR;
		private Boolean m_entc_codagenteOK;
		private String m_entc_codagenteMSGERROR;
		private Boolean m_cons_codestadoOK;
		private String m_cons_codestadoMSGERROR;
		private Boolean m_cons_tabestadoOK;
		private String m_cons_tabestadoMSGERROR;
		private Boolean m_cope_excepcionOK;
		private String m_cope_excepcionMSGERROR;
		private Boolean m_cope_fobOK;
		private String m_cope_fobMSGERROR;
		private Boolean m_cope_seguroOK;
		private String m_cope_seguroMSGERROR;
		private Boolean m_cope_fleteOK;
		private String m_cope_fleteMSGERROR;
		private Boolean m_cope_cifOK;
		private String m_cope_cifMSGERROR;
		private Boolean m_cope_partarancelariaOK;
		private String m_cope_partarancelariaMSGERROR;
		private Boolean m_cope_ipmOK;
		private String m_cope_ipmMSGERROR;
		private Boolean m_cope_igvOK;
		private String m_cope_igvMSGERROR;
		private Boolean m_cope_percepcionOK;
		private String m_cope_percepcionMSGERROR;
		private Boolean m_cope_tasadespachoOK;
		private String m_cope_tasadespachoMSGERROR;
		private Boolean m_cope_advaloremOK;
		private String m_cope_advaloremMSGERROR;
		private Boolean m_cope_1erembarqueOK;
		private String m_cope_1erembarqueMSGERROR;
		private Boolean m_audi_usrcreaOK;
		private String m_audi_usrcreaMSGERROR;
		private Boolean m_audi_feccreaOK;
		private String m_audi_feccreaMSGERROR;
		private Boolean m_audi_usrmodOK;
		private String m_audi_usrmodMSGERROR;
		private Boolean m_audi_fecmodOK;
		private String m_audi_fecmodMSGERROR;
		private Boolean m_tipo_tabmndOK;
		private String m_tipo_tabmndMSGERROR;
		private Boolean m_tipo_codmndOK;
		private String m_tipo_codmndMSGERROR;
		private Boolean m_cons_codcrgOK;
		private String m_cons_codcrgMSGERROR;
		private Boolean m_cons_tabcrgOK;
		private String m_cons_tabcrgMSGERROR;
		#endregion

		#region [ Propiedades Validación ]
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public Boolean COPE_CodigoOK
		{
			get { return m_cope_codigoOK; }
			set
			{
				if (m_cope_codigoOK != value)
				{
					m_cope_codigoOK = value;
					OnPropertyChanged("COPE_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Codigo.
		/// </summary>
		[DataMember]
		public String COPE_CodigoMSGERROR
		{
			get { return m_cope_codigoMSGERROR; }
			set
			{
				if (m_cope_codigoMSGERROR != value)
				{
					m_cope_codigoMSGERROR = value;
					OnPropertyChanged("COPE_CodigoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_NumDoc.
		/// </summary>
		[DataMember]
		public Boolean COPE_NumDocOK
		{
			get { return m_cope_numdocOK; }
			set
			{
				if (m_cope_numdocOK != value)
				{
					m_cope_numdocOK = value;
					OnPropertyChanged("COPE_NumDocOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_NumDoc.
		/// </summary>
		[DataMember]
		public String COPE_NumDocMSGERROR
		{
			get { return m_cope_numdocMSGERROR; }
			set
			{
				if (m_cope_numdocMSGERROR != value)
				{
					m_cope_numdocMSGERROR = value;
					OnPropertyChanged("COPE_NumDocMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_FecEmi.
		/// </summary>
		[DataMember]
		public Boolean COPE_FecEmiOK
		{
			get { return m_cope_fecemiOK; }
			set
			{
				if (m_cope_fecemiOK != value)
				{
					m_cope_fecemiOK = value;
					OnPropertyChanged("COPE_FecEmiOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_FecEmi.
		/// </summary>
		[DataMember]
		public String COPE_FecEmiMSGERROR
		{
			get { return m_cope_fecemiMSGERROR; }
			set
			{
				if (m_cope_fecemiMSGERROR != value)
				{
					m_cope_fecemiMSGERROR = value;
					OnPropertyChanged("COPE_FecEmiMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Observacion.
		/// </summary>
		[DataMember]
		public Boolean COPE_ObservacionOK
		{
			get { return m_cope_observacionOK; }
			set
			{
				if (m_cope_observacionOK != value)
				{
					m_cope_observacionOK = value;
					OnPropertyChanged("COPE_ObservacionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Observacion.
		/// </summary>
		[DataMember]
		public String COPE_ObservacionMSGERROR
		{
			get { return m_cope_observacionMSGERROR; }
			set
			{
				if (m_cope_observacionMSGERROR != value)
				{
					m_cope_observacionMSGERROR = value;
					OnPropertyChanged("COPE_ObservacionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_HBL.
		/// </summary>
		[DataMember]
		public Boolean COPE_HBLOK
		{
			get { return m_cope_hblOK; }
			set
			{
				if (m_cope_hblOK != value)
				{
					m_cope_hblOK = value;
					OnPropertyChanged("COPE_HBLOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_HBL.
		/// </summary>
		[DataMember]
		public String COPE_HBLMSGERROR
		{
			get { return m_cope_hblMSGERROR; }
			set
			{
				if (m_cope_hblMSGERROR != value)
				{
					m_cope_hblMSGERROR = value;
					OnPropertyChanged("COPE_HBLMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public Boolean CCOT_CodigoOK
		{
			get { return m_ccot_codigoOK; }
			set
			{
				if (m_ccot_codigoOK != value)
				{
					m_ccot_codigoOK = value;
					OnPropertyChanged("CCOT_CodigoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CCOT_Codigo.
		/// </summary>
		[DataMember]
		public String CCOT_CodigoMSGERROR
		{
			get { return m_ccot_codigoMSGERROR; }
			set
			{
				if (m_ccot_codigoMSGERROR != value)
				{
					m_ccot_codigoMSGERROR = value;
					OnPropertyChanged("CCOT_CodigoMSGERROR");
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
		/// Gets or sets el valor de validación de: ENTC_CodTransporte.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodTransporteOK
		{
			get { return m_entc_codtransporteOK; }
			set
			{
				if (m_entc_codtransporteOK != value)
				{
					m_entc_codtransporteOK = value;
					OnPropertyChanged("ENTC_CodTransporteOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodTransporte.
		/// </summary>
		[DataMember]
		public String ENTC_CodTransporteMSGERROR
		{
			get { return m_entc_codtransporteMSGERROR; }
			set
			{
				if (m_entc_codtransporteMSGERROR != value)
				{
					m_entc_codtransporteMSGERROR = value;
					OnPropertyChanged("ENTC_CodTransporteMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: ENTC_CodAgente.
		/// </summary>
		[DataMember]
		public Boolean ENTC_CodAgenteOK
		{
			get { return m_entc_codagenteOK; }
			set
			{
				if (m_entc_codagenteOK != value)
				{
					m_entc_codagenteOK = value;
					OnPropertyChanged("ENTC_CodAgenteOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: ENTC_CodAgente.
		/// </summary>
		[DataMember]
		public String ENTC_CodAgenteMSGERROR
		{
			get { return m_entc_codagenteMSGERROR; }
			set
			{
				if (m_entc_codagenteMSGERROR != value)
				{
					m_entc_codagenteMSGERROR = value;
					OnPropertyChanged("ENTC_CodAgenteMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodEstado.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodEstadoOK
		{
			get { return m_cons_codestadoOK; }
			set
			{
				if (m_cons_codestadoOK != value)
				{
					m_cons_codestadoOK = value;
					OnPropertyChanged("CONS_CodEstadoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodEstado.
		/// </summary>
		[DataMember]
		public String CONS_CodEstadoMSGERROR
		{
			get { return m_cons_codestadoMSGERROR; }
			set
			{
				if (m_cons_codestadoMSGERROR != value)
				{
					m_cons_codestadoMSGERROR = value;
					OnPropertyChanged("CONS_CodEstadoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabEstado.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabEstadoOK
		{
			get { return m_cons_tabestadoOK; }
			set
			{
				if (m_cons_tabestadoOK != value)
				{
					m_cons_tabestadoOK = value;
					OnPropertyChanged("CONS_TabEstadoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabEstado.
		/// </summary>
		[DataMember]
		public String CONS_TabEstadoMSGERROR
		{
			get { return m_cons_tabestadoMSGERROR; }
			set
			{
				if (m_cons_tabestadoMSGERROR != value)
				{
					m_cons_tabestadoMSGERROR = value;
					OnPropertyChanged("CONS_TabEstadoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Excepcion.
		/// </summary>
		[DataMember]
		public Boolean COPE_ExcepcionOK
		{
			get { return m_cope_excepcionOK; }
			set
			{
				if (m_cope_excepcionOK != value)
				{
					m_cope_excepcionOK = value;
					OnPropertyChanged("COPE_ExcepcionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Excepcion.
		/// </summary>
		[DataMember]
		public String COPE_ExcepcionMSGERROR
		{
			get { return m_cope_excepcionMSGERROR; }
			set
			{
				if (m_cope_excepcionMSGERROR != value)
				{
					m_cope_excepcionMSGERROR = value;
					OnPropertyChanged("COPE_ExcepcionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Fob.
		/// </summary>
		[DataMember]
		public Boolean COPE_FobOK
		{
			get { return m_cope_fobOK; }
			set
			{
				if (m_cope_fobOK != value)
				{
					m_cope_fobOK = value;
					OnPropertyChanged("COPE_FobOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Fob.
		/// </summary>
		[DataMember]
		public String COPE_FobMSGERROR
		{
			get { return m_cope_fobMSGERROR; }
			set
			{
				if (m_cope_fobMSGERROR != value)
				{
					m_cope_fobMSGERROR = value;
					OnPropertyChanged("COPE_FobMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Seguro.
		/// </summary>
		[DataMember]
		public Boolean COPE_SeguroOK
		{
			get { return m_cope_seguroOK; }
			set
			{
				if (m_cope_seguroOK != value)
				{
					m_cope_seguroOK = value;
					OnPropertyChanged("COPE_SeguroOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Seguro.
		/// </summary>
		[DataMember]
		public String COPE_SeguroMSGERROR
		{
			get { return m_cope_seguroMSGERROR; }
			set
			{
				if (m_cope_seguroMSGERROR != value)
				{
					m_cope_seguroMSGERROR = value;
					OnPropertyChanged("COPE_SeguroMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Flete.
		/// </summary>
		[DataMember]
		public Boolean COPE_FleteOK
		{
			get { return m_cope_fleteOK; }
			set
			{
				if (m_cope_fleteOK != value)
				{
					m_cope_fleteOK = value;
					OnPropertyChanged("COPE_FleteOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Flete.
		/// </summary>
		[DataMember]
		public String COPE_FleteMSGERROR
		{
			get { return m_cope_fleteMSGERROR; }
			set
			{
				if (m_cope_fleteMSGERROR != value)
				{
					m_cope_fleteMSGERROR = value;
					OnPropertyChanged("COPE_FleteMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Cif.
		/// </summary>
		[DataMember]
		public Boolean COPE_CifOK
		{
			get { return m_cope_cifOK; }
			set
			{
				if (m_cope_cifOK != value)
				{
					m_cope_cifOK = value;
					OnPropertyChanged("COPE_CifOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Cif.
		/// </summary>
		[DataMember]
		public String COPE_CifMSGERROR
		{
			get { return m_cope_cifMSGERROR; }
			set
			{
				if (m_cope_cifMSGERROR != value)
				{
					m_cope_cifMSGERROR = value;
					OnPropertyChanged("COPE_CifMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_PartArancelaria.
		/// </summary>
		[DataMember]
		public Boolean COPE_PartArancelariaOK
		{
			get { return m_cope_partarancelariaOK; }
			set
			{
				if (m_cope_partarancelariaOK != value)
				{
					m_cope_partarancelariaOK = value;
					OnPropertyChanged("COPE_PartArancelariaOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_PartArancelaria.
		/// </summary>
		[DataMember]
		public String COPE_PartArancelariaMSGERROR
		{
			get { return m_cope_partarancelariaMSGERROR; }
			set
			{
				if (m_cope_partarancelariaMSGERROR != value)
				{
					m_cope_partarancelariaMSGERROR = value;
					OnPropertyChanged("COPE_PartArancelariaMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Ipm.
		/// </summary>
		[DataMember]
		public Boolean COPE_IpmOK
		{
			get { return m_cope_ipmOK; }
			set
			{
				if (m_cope_ipmOK != value)
				{
					m_cope_ipmOK = value;
					OnPropertyChanged("COPE_IpmOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Ipm.
		/// </summary>
		[DataMember]
		public String COPE_IpmMSGERROR
		{
			get { return m_cope_ipmMSGERROR; }
			set
			{
				if (m_cope_ipmMSGERROR != value)
				{
					m_cope_ipmMSGERROR = value;
					OnPropertyChanged("COPE_IpmMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Igv.
		/// </summary>
		[DataMember]
		public Boolean COPE_IgvOK
		{
			get { return m_cope_igvOK; }
			set
			{
				if (m_cope_igvOK != value)
				{
					m_cope_igvOK = value;
					OnPropertyChanged("COPE_IgvOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Igv.
		/// </summary>
		[DataMember]
		public String COPE_IgvMSGERROR
		{
			get { return m_cope_igvMSGERROR; }
			set
			{
				if (m_cope_igvMSGERROR != value)
				{
					m_cope_igvMSGERROR = value;
					OnPropertyChanged("COPE_IgvMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_Percepcion.
		/// </summary>
		[DataMember]
		public Boolean COPE_PercepcionOK
		{
			get { return m_cope_percepcionOK; }
			set
			{
				if (m_cope_percepcionOK != value)
				{
					m_cope_percepcionOK = value;
					OnPropertyChanged("COPE_PercepcionOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_Percepcion.
		/// </summary>
		[DataMember]
		public String COPE_PercepcionMSGERROR
		{
			get { return m_cope_percepcionMSGERROR; }
			set
			{
				if (m_cope_percepcionMSGERROR != value)
				{
					m_cope_percepcionMSGERROR = value;
					OnPropertyChanged("COPE_PercepcionMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_TasaDespacho.
		/// </summary>
		[DataMember]
		public Boolean COPE_TasaDespachoOK
		{
			get { return m_cope_tasadespachoOK; }
			set
			{
				if (m_cope_tasadespachoOK != value)
				{
					m_cope_tasadespachoOK = value;
					OnPropertyChanged("COPE_TasaDespachoOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_TasaDespacho.
		/// </summary>
		[DataMember]
		public String COPE_TasaDespachoMSGERROR
		{
			get { return m_cope_tasadespachoMSGERROR; }
			set
			{
				if (m_cope_tasadespachoMSGERROR != value)
				{
					m_cope_tasadespachoMSGERROR = value;
					OnPropertyChanged("COPE_TasaDespachoMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_AdValorem.
		/// </summary>
		[DataMember]
		public Boolean COPE_AdValoremOK
		{
			get { return m_cope_advaloremOK; }
			set
			{
				if (m_cope_advaloremOK != value)
				{
					m_cope_advaloremOK = value;
					OnPropertyChanged("COPE_AdValoremOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_AdValorem.
		/// </summary>
		[DataMember]
		public String COPE_AdValoremMSGERROR
		{
			get { return m_cope_advaloremMSGERROR; }
			set
			{
				if (m_cope_advaloremMSGERROR != value)
				{
					m_cope_advaloremMSGERROR = value;
					OnPropertyChanged("COPE_AdValoremMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: COPE_1erEmbarque.
		/// </summary>
		[DataMember]
		public Boolean COPE_1erEmbarqueOK
		{
			get { return m_cope_1erembarqueOK; }
			set
			{
				if (m_cope_1erembarqueOK != value)
				{
					m_cope_1erembarqueOK = value;
					OnPropertyChanged("COPE_1erEmbarqueOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: COPE_1erEmbarque.
		/// </summary>
		[DataMember]
		public String COPE_1erEmbarqueMSGERROR
		{
			get { return m_cope_1erembarqueMSGERROR; }
			set
			{
				if (m_cope_1erembarqueMSGERROR != value)
				{
					m_cope_1erembarqueMSGERROR = value;
					OnPropertyChanged("COPE_1erEmbarqueMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public Boolean TIPO_TabMNDOK
		{
			get { return m_tipo_tabmndOK; }
			set
			{
				if (m_tipo_tabmndOK != value)
				{
					m_tipo_tabmndOK = value;
					OnPropertyChanged("TIPO_TabMNDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_TabMND.
		/// </summary>
		[DataMember]
		public String TIPO_TabMNDMSGERROR
		{
			get { return m_tipo_tabmndMSGERROR; }
			set
			{
				if (m_tipo_tabmndMSGERROR != value)
				{
					m_tipo_tabmndMSGERROR = value;
					OnPropertyChanged("TIPO_TabMNDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public Boolean TIPO_CodMNDOK
		{
			get { return m_tipo_codmndOK; }
			set
			{
				if (m_tipo_codmndOK != value)
				{
					m_tipo_codmndOK = value;
					OnPropertyChanged("TIPO_CodMNDOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: TIPO_CodMND.
		/// </summary>
		[DataMember]
		public String TIPO_CodMNDMSGERROR
		{
			get { return m_tipo_codmndMSGERROR; }
			set
			{
				if (m_tipo_codmndMSGERROR != value)
				{
					m_tipo_codmndMSGERROR = value;
					OnPropertyChanged("TIPO_CodMNDMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_CodCRG.
		/// </summary>
		[DataMember]
		public Boolean CONS_CodCRGOK
		{
			get { return m_cons_codcrgOK; }
			set
			{
				if (m_cons_codcrgOK != value)
				{
					m_cons_codcrgOK = value;
					OnPropertyChanged("CONS_CodCRGOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_CodCRG.
		/// </summary>
		[DataMember]
		public String CONS_CodCRGMSGERROR
		{
			get { return m_cons_codcrgMSGERROR; }
			set
			{
				if (m_cons_codcrgMSGERROR != value)
				{
					m_cons_codcrgMSGERROR = value;
					OnPropertyChanged("CONS_CodCRGMSGERROR");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de validación de: CONS_TabCRG.
		/// </summary>
		[DataMember]
		public Boolean CONS_TabCRGOK
		{
			get { return m_cons_tabcrgOK; }
			set
			{
				if (m_cons_tabcrgOK != value)
				{
					m_cons_tabcrgOK = value;
					OnPropertyChanged("CONS_TabCRGOK");
				}
			}
		}
		/// <summary>
		/// Gets or sets el mensaje de validación de: CONS_TabCRG.
		/// </summary>
		[DataMember]
		public String CONS_TabCRGMSGERROR
		{
			get { return m_cons_tabcrgMSGERROR; }
			set
			{
				if (m_cons_tabcrgMSGERROR != value)
				{
					m_cons_tabcrgMSGERROR = value;
					OnPropertyChanged("CONS_TabCRGMSGERROR");
				}
			}
		}

        [DataMember]
        public String CCOT_CodAduanaMSGERROR { set; get; }
        [DataMember]
        public String CCOT_CodTransporteMSGERROR { set; get; }
        [DataMember]
        public String CCOT_CodLogisticoMSGERROR { set; get; }

        [DataMember]
        public String COPE_NaveMSGERROR { set; get; }

        [DataMember]
        public String COPE_ViajeMSGERROR { set; get; }

        [DataMember]
        public String COPE_MBLMSGERROR { set; get; }

        [DataMember]
        public String COPE_FechaArriboMSGERROR { set; get; }

        [DataMember]
        public String COPE_CantidadDiasMSGERROR { get; set; }
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
				COPE_CodigoOK  = true;
				COPE_CodigoMSGERROR  = "";
                //if( COPE_Codigo == null)
                //{
                //    _isCorrect = false;
                //    COPE_CodigoOK  = false;
                //    COPE_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "COPE_Codigo", "Operación");
                //    m_mensajeError += "* Debe ingresar el campo COPE_Codigo" + Environment.NewLine;
                //}
				COPE_NumDocOK  = true;
				COPE_NumDocMSGERROR  = "";
                //if( String.IsNullOrEmpty(COPE_NumDoc) )
                //{
                //    _isCorrect = false;
                //    COPE_NumDocOK  = false;
                //    COPE_NumDocMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "COPE_NumDoc", "Operación");
                //    m_mensajeError += "* Debe ingresar el campo COPE_NumDoc" + Environment.NewLine;
                //}
				COPE_ObservacionOK  = true;
				COPE_ObservacionMSGERROR  = "";
                //if( String.IsNullOrEmpty(COPE_Observacion) )
                //{
                //    _isCorrect = false;
                //    COPE_ObservacionOK  = false;
                //    COPE_ObservacionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "COPE_Observacion", "Operación");
                //    m_mensajeError += "* Debe ingresar el campo COPE_Observacion" + Environment.NewLine;
                //}
                COPE_FecEmiMSGERROR="";
                if (COPE_FecEmi== null)
                {
                    _isCorrect = false;
                    COPE_FecEmiMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Emisión", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Fecha Emisión." + Environment.NewLine;
                }

                ENTC_CodAgenteMSGERROR = "";
                if (ENTC_CodAgente==null)
                {
                    _isCorrect = false;
                    ENTC_CodAgenteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Agente", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Agente." + Environment.NewLine;
                }

                ENTC_CodClienteMSGERROR = "";
                if (ENTC_CodCliente == null)
                {
                    _isCorrect = false;
                    ENTC_CodClienteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cliente", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Cliente." + Environment.NewLine;
                }

                ENTC_CodTransporteMSGERROR = "";
                if (ENTC_CodTransporte == null)
                {
                    _isCorrect = false;
                    ENTC_CodTransporteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Transporte", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Transporte." + Environment.NewLine;
                }
                CONS_CodEstadoMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodEstado))
                {
                    _isCorrect = false;
                    CONS_CodEstadoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Estado", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Estado." + Environment.NewLine; 
                }
                TIPO_CodMNDMSGERROR = "";
                if (String.IsNullOrEmpty(TIPO_CodMND))
                {
                    _isCorrect = false;
                    TIPO_CodMNDMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Moneda", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Moneda." + Environment.NewLine;
                }
                CONS_CodCRGMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_CodCRG) && CCOT_CodLogistico == null)
                {
                    _isCorrect = false;
                    CONS_CodCRGMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Carga", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Tipo de Carga." + Environment.NewLine;
                }

                CCOT_CodAduanaMSGERROR = "";
                if (CCOT_CodAduana == null && CCOT_CodLogistico == null && CCOT_CodTransporte == null)
                //{
                //    _isCorrect = false;
                //    //CCOT_CodAduanaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Servicio Aduana", "Operación");
                //    m_mensajeError += "* Debe ingresar un Servicio de cotización." + Environment.NewLine;
                //}
                //CCOT_CodLogisticoMSGERROR = "";
                //if (CCOT_CodLogistico == null)
                //{
                //    _isCorrect = false;
                //    CCOT_CodLogisticoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Servicio Logístico", "Operación");
                //    m_mensajeError += "* Debe ingresar el campo Servicio Logístico." + Environment.NewLine;
                //}
                //CCOT_CodTransporteMSGERROR = "";
                //if (CCOT_CodTransporte == null)
                //{
                //    _isCorrect = false;
                //    CCOT_CodTransporteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Servicio Transporte", "Operación");
                //    m_mensajeError += "* Debe ingresar el campo Servicio Transporte." + Environment.NewLine;
                //}
				COPE_HBLMSGERROR  = "";
				if( String.IsNullOrEmpty(COPE_HBL) )
				{
					_isCorrect = false;
					COPE_HBLOK  = false;
					COPE_HBLMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "HBL", "Operación");
					m_mensajeError += "* Debe ingresar el campo HBL" + Environment.NewLine;
				}
				COPE_FobOK  = true;
				COPE_FobMSGERROR  = "";
            //if( COPE_Fob == 0)
            //{
            //   _isCorrect = false;
            //   COPE_FobOK  = false;
            //   COPE_FobMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Fob", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo Fob" + Environment.NewLine;
            //}
				COPE_SeguroOK  = true;
				COPE_SeguroMSGERROR  = "";
            //if( COPE_Seguro == 0)
            //{
            //   _isCorrect = false;
            //   COPE_SeguroOK  = false;
            //   COPE_SeguroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Seguro", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo Seguro" + Environment.NewLine;
            //}
				COPE_FleteOK  = true;
				COPE_FleteMSGERROR  = "";
            //if( COPE_Flete == 0)
            //{
            //   _isCorrect = false;
            //   COPE_FleteOK  = false;
            //   COPE_FleteMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Flete", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo Flete" + Environment.NewLine;
            //}
				COPE_CifOK  = true;
				COPE_CifMSGERROR  = "";
            //if( COPE_Cif == 0)
            //{
            //   _isCorrect = false;
            //   COPE_CifOK  = false;
            //   COPE_CifMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Cif", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo Cif" + Environment.NewLine;
            //}
				COPE_PartArancelariaOK  = true;
				COPE_PartArancelariaMSGERROR  = "";
            //if( COPE_PartArancelaria == 0)
            //{
            //   _isCorrect = false;
            //   COPE_PartArancelariaOK  = false;
            //   COPE_PartArancelariaMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Parte Arancelaria", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo Parte Arancelaria" + Environment.NewLine;
            //}
				COPE_IpmOK  = true;
				COPE_IpmMSGERROR  = "";
            //if( COPE_Ipm == 0)
            //{
            //   _isCorrect = false;
            //   COPE_IpmOK  = false;
            //   COPE_IpmMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Ipm", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo Ipm" + Environment.NewLine;
            //}
				COPE_IgvOK  = true;
				COPE_IgvMSGERROR  = "";
            //if( COPE_Igv == 0)
            //{
            //   _isCorrect = false;
            //   COPE_IgvOK  = false;
            //   COPE_IgvMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Igv", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo Igv" + Environment.NewLine;
            //}
				COPE_PercepcionOK  = true;
				COPE_PercepcionMSGERROR  = "";
            //if( COPE_Percepcion == 0)
            //{
            //   _isCorrect = false;
            //   COPE_PercepcionOK  = false;
            //   COPE_PercepcionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Percepción", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo Percepción" + Environment.NewLine;
            //}
				COPE_TasaDespachoOK  = true;
				COPE_TasaDespachoMSGERROR  = "";
				if( COPE_TasaDespacho == 0)
				{
					_isCorrect = false;
					COPE_TasaDespachoOK  = false;
					COPE_TasaDespachoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tasa Despacho", "Operación");
					m_mensajeError += "* Debe ingresar el campo Tasa Despacho" + Environment.NewLine;
				}
				COPE_AdValoremOK  = true;
				COPE_AdValoremMSGERROR  = "";
            //if( COPE_AdValorem == 0)
            //{
            //   _isCorrect = false;
            //   COPE_AdValoremOK  = false;
            //   COPE_AdValoremMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "AdValorem", "Operación");
            //   m_mensajeError += "* Debe ingresar el campo AdValorem" + Environment.NewLine;
            //}

                COPE_NaveMSGERROR = "";
                if (String.IsNullOrEmpty(COPE_Nave))
                {
                    _isCorrect = false;
                    COPE_NaveMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Nave", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Nave." + Environment.NewLine;
                }

                COPE_ViajeMSGERROR = "";
                if (String.IsNullOrEmpty(COPE_Viaje))
                {
                    _isCorrect = false;
                    COPE_ViajeMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Viaje", "Operación");
                    m_mensajeError += "* Debe ingresar el campo Viaje." + Environment.NewLine;
                }

                COPE_MBLMSGERROR = "";
                if (String.IsNullOrEmpty(COPE_MBL))
                {
                    _isCorrect = false;
                    COPE_MBLMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "MBL", "Operación");
                    m_mensajeError += "* Debe ingresar el campo MBL." + Environment.NewLine;
                }

                //COPE_FechaArriboMSGERROR = "";
                //if (COPE_FechaArribo == null)
                //{
                //    _isCorrect = false;
                //    COPE_FechaArriboMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Fecha de Llegada", "Operación");
                //    m_mensajeError += "* Debe ingresar el campo Fecha Llegada." + Environment.NewLine;
                //}

                //COPE_CantidadDiasMSGERROR = "";
                //if (COPE_CantidadDias == null)
                //{
                //    _isCorrect = false;
                //    COPE_CantidadDiasMSGERROR = String.Format("Debe ingresar la {0} de la {1}.", "Cantidad Días", "Operación");
                //    m_mensajeError += "* Debe ingresar el campo Cantidad Días." + Environment.NewLine;
                //}
				OnPropertyChanged("MensajeError");
				return _isCorrect;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
