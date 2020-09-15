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
	[Serializable()]
	public partial class Cab_Cotizacion_OV : MasterBusinessEntity, INotifyPropertyChanged
	{
		#region [ Variables ]
		private Int32 m_ccot_numero;
		private Int16 m_ccot_tipo;
		private Nullable<Int16> m_empr_codigo;
		private Nullable<Int16> m_sucr_codigo;
		private String m_ccot_numdoc;
		private Nullable<Int32> m_ccot_numpadre;
		private Nullable<Int16> m_ccot_tipopadre;
      private Nullable<Int16> m_ccot_version = 1;
		private Boolean m_ccot_propia;
		private Nullable<Int32> m_entc_codcliente;
		private Nullable<Int32> m_entc_codtransportista;
		private Nullable<Int32> m_entc_codbroker;
		private Nullable<Int32> m_entc_codagente;
		private Nullable<Int32> m_entc_codcustomer;
		private Nullable<Int32> m_entc_codejecutivo;
		private String m_ccot_numpresupuesto;
      private Nullable<DateTime> m_ccot_fecemi;
		private Nullable<DateTime> m_ccot_fecvcto;
		private Boolean m_ccot_serviciologistico;
        private Boolean m_ccot_vobogatein;
		private Boolean m_ccot_cargarefrigerada;
		private Nullable<Decimal> m_ccot_temperatura;
		private Boolean m_ccot_cargapeligrosa;
		private Boolean m_ccot_roundtrip;
		private String m_ccot_observaciones;
		private Nullable<DateTime> m_ccot_feccierre;
		private Int16 m_ccot_almacenaje;
		private Int16 m_ccot_sobreestadia;
		private Int16 m_ccot_tiempoviaje;
		private Int16 m_ccot_validezoferta;
		private String m_tipo_tabinc;
		private String m_tipo_codinc;
		private String m_tipo_tabimo;
		private String m_tipo_codimo;
		private Nullable<Int32> m_cont_codigo;
		private String m_cons_tabrgm;
		private String m_cons_codrgm;
		
		private String m_cons_tabvia;
		private String m_cons_codvia;
		private String m_cons_tabfle;
		private String m_cons_codfle;
		private String m_cons_tabest;
		private String m_cons_codest;
		private Nullable<Int32> m_puer_coddestino;
		private Nullable<Int32> m_puer_codtrasbordo;
		private Nullable<Int32> m_puer_codorigen;
		private String m_ccot_usraprueba;
		private Nullable<DateTime> m_ccot_fecaprueba;
		private String m_ccot_usraceptarechaza;
		private Nullable<DateTime> m_ccot_fecaceptarechaza;
		private String m_tipo_tabmot;
		private String m_tipo_codmot;
		private Nullable<Int32> m_entc_codshipper;
		private Nullable<Int32> m_entc_codconsignee;
		private Nullable<Int32> m_entc_codnotify;
		private String m_cons_tabtft;
		private String m_cons_codtft;
		private Nullable<DateTime> m_ccot_fectarifa;
		private String m_ccot_pagombl;
		private String m_ccot_pagohbl;
      private String m_tipo_tabmnd;
      private String m_tipo_codmnd;

      private String m_tipo_tabdtm;
      private String m_tipo_coddtm;
      private String m_doov_cntr;
      private String m_doov_hbl;
      private String m_doov_mbl;
      private String m_doov_codreferencia;

      private Nullable<Int32> m_nvia_codigo;

      private String m_doov_feeder_impo;
      private Nullable<DateTime> m_doov_fecetdfeeder_impo;

      private Boolean m_ddov_hblnieto;

      private String m_ccot_imoun;

      private String m_tipo_tabtrf;
      private String m_tipo_codtrf;

      private String m_doov_placereceipt;
      private String m_doov_placedelivery;
      
      private String m_audi_usrcrea;
		private DateTime m_audi_feccrea;
		private String m_audi_usrmod;
		private Nullable<DateTime> m_audi_fecmod;
		#endregion

		#region [ Constructores ]
		/// <summary>
		/// Inicializar una nueva instancia de la clase Cab_Cotizacion_OV.
		/// </summary>
		public Cab_Cotizacion_OV()
		{  }
		#endregion

		#region [ Propiedades ]
		/// <summary>
		/// Gets or sets el valor de: CCOT_Numero.
		/// </summary>
		[DataMember]
		public Int32 CCOT_Numero
		{
			get { return m_ccot_numero; }
			set
			{
				if (m_ccot_numero != value)
				{
					m_ccot_numero = value;
					OnPropertyChanged("CCOT_Numero");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Tipo.
		/// </summary>
		[DataMember]
		public Int16 CCOT_Tipo
		{
			get { return m_ccot_tipo; }
			set
			{
				if (m_ccot_tipo != value)
				{
					m_ccot_tipo = value;
					OnPropertyChanged("CCOT_Tipo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: EMPR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> EMPR_Codigo
		{
			get { return m_empr_codigo; }
			set
			{
				if (m_empr_codigo != value)
				{
					m_empr_codigo = value;
					OnPropertyChanged("EMPR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: SUCR_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int16> SUCR_Codigo
		{
			get { return m_sucr_codigo; }
			set
			{
				if (m_sucr_codigo != value)
				{
					m_sucr_codigo = value;
					OnPropertyChanged("SUCR_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_NumDoc.
		/// </summary>
		[DataMember]
		public String CCOT_NumDoc
		{
			get { return m_ccot_numdoc; }
			set
			{
				if (m_ccot_numdoc != value)
				{
					m_ccot_numdoc = value;
					OnPropertyChanged("CCOT_NumDoc");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_NumPadre.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CCOT_NumPadre
		{
			get { return m_ccot_numpadre; }
			set
			{
				if (m_ccot_numpadre != value)
				{
					m_ccot_numpadre = value;
					OnPropertyChanged("CCOT_NumPadre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_TipoPadre.
		/// </summary>
		[DataMember]
		public Nullable<Int16> CCOT_TipoPadre
		{
			get { return m_ccot_tipopadre; }
			set
			{
				if (m_ccot_tipopadre != value)
				{
					m_ccot_tipopadre = value;
					OnPropertyChanged("CCOT_TipoPadre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Version.
		/// </summary>
		[DataMember]
		public Nullable<Int16> CCOT_Version
		{
			get { return m_ccot_version; }
			set
			{
				if (m_ccot_version != value)
				{
					m_ccot_version = value;
					OnPropertyChanged("CCOT_Version");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Propia.
		/// </summary>
		[DataMember]
		public Boolean CCOT_Propia
		{
			get { return m_ccot_propia; }
			set
			{
				if (m_ccot_propia != value)
				{
					m_ccot_propia = value;
					OnPropertyChanged("CCOT_Propia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodCliente.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodCliente
		{
			get { return m_entc_codcliente; }
			set
			{
				if (m_entc_codcliente != value)
				{
					m_entc_codcliente = value;
					OnPropertyChanged("ENTC_CodCliente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodTransportista.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodTransportista
		{
			get { return m_entc_codtransportista; }
			set
			{
				if (m_entc_codtransportista != value)
				{
					m_entc_codtransportista = value;
					OnPropertyChanged("ENTC_CodTransportista");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodBroker.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodBroker
		{
			get { return m_entc_codbroker; }
			set
			{
				if (m_entc_codbroker != value)
				{
					m_entc_codbroker = value;
					OnPropertyChanged("ENTC_CodBroker");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodAgente.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodAgente
		{
			get { return m_entc_codagente; }
			set
			{
				if (m_entc_codagente != value)
				{
					m_entc_codagente = value;
					OnPropertyChanged("ENTC_CodAgente");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodCustomer.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodCustomer
		{
			get { return m_entc_codcustomer; }
			set
			{
				if (m_entc_codcustomer != value)
				{
					m_entc_codcustomer = value;
					OnPropertyChanged("ENTC_CodCustomer");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodEjecutivo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodEjecutivo
		{
			get { return m_entc_codejecutivo; }
			set
			{
				if (m_entc_codejecutivo != value)
				{
					m_entc_codejecutivo = value;
					OnPropertyChanged("ENTC_CodEjecutivo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_NumPresupuesto.
		/// </summary>
		[DataMember]
		public String CCOT_NumPresupuesto
		{
			get { return m_ccot_numpresupuesto; }
			set
			{
				if (m_ccot_numpresupuesto != value)
				{
					m_ccot_numpresupuesto = value;
					OnPropertyChanged("CCOT_NumPresupuesto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_FecEmi.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CCOT_FecEmi
		{
			get { return m_ccot_fecemi; }
			set
			{
				if (m_ccot_fecemi != value)
				{
					m_ccot_fecemi = value;
					OnPropertyChanged("CCOT_FecEmi");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_FecVcto.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CCOT_FecVcto
		{
			get { return m_ccot_fecvcto; }
			set
			{
				if (m_ccot_fecvcto != value)
				{
					m_ccot_fecvcto = value;
					OnPropertyChanged("CCOT_FecVcto");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_ServicioLogistico.
		/// </summary>
		[DataMember]
		public Boolean CCOT_ServicioLogistico
		{
			get { return m_ccot_serviciologistico; }
			set
			{
				if (m_ccot_serviciologistico != value)
				{
					m_ccot_serviciologistico = value;
					OnPropertyChanged("CCOT_ServicioLogistico");
				}
			}
		}
        /// <summary>
        /// Gets or sets el valor de: CCOT_VoBo_GateIn.
        /// </summary>
        [DataMember]
        public Boolean CCOT_VoBoGateIn
        {
            get { return m_ccot_vobogatein; }
            set
            {
                if (m_ccot_vobogatein != value)
                {
                    m_ccot_vobogatein = value;
                    OnPropertyChanged("CCOT_VoBoGateIn");
                }
            }
        }
		/// <summary>
		/// Gets or sets el valor de: CCOT_CargaRefrigerada.
		/// </summary>
		[DataMember]
		public Boolean CCOT_CargaRefrigerada
		{
			get { return m_ccot_cargarefrigerada; }
			set
			{
				if (m_ccot_cargarefrigerada != value)
				{
					m_ccot_cargarefrigerada = value;
					OnPropertyChanged("CCOT_CargaRefrigerada");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Temperatura.
		/// </summary>
		[DataMember]
		public Nullable<Decimal> CCOT_Temperatura
		{
			get { return m_ccot_temperatura; }
			set
			{
				if (m_ccot_temperatura != value)
				{
					m_ccot_temperatura = value;
					OnPropertyChanged("CCOT_Temperatura");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_CargaPeligrosa.
		/// </summary>
		[DataMember]
		public Boolean CCOT_CargaPeligrosa
		{
			get { return m_ccot_cargapeligrosa; }
			set
			{
				if (m_ccot_cargapeligrosa != value)
				{
					m_ccot_cargapeligrosa = value;
					OnPropertyChanged("CCOT_CargaPeligrosa");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Roundtrip.
		/// </summary>
		[DataMember]
		public Boolean CCOT_Roundtrip
		{
			get { return m_ccot_roundtrip; }
			set
			{
				if (m_ccot_roundtrip != value)
				{
					m_ccot_roundtrip = value;
					OnPropertyChanged("CCOT_Roundtrip");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Observaciones.
		/// </summary>
		[DataMember]
		public String CCOT_Observaciones
		{
			get { return m_ccot_observaciones; }
			set
			{
				if (m_ccot_observaciones != value)
				{
					m_ccot_observaciones = value;
					OnPropertyChanged("CCOT_Observaciones");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_FecCierre.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CCOT_FecCierre
		{
			get { return m_ccot_feccierre; }
			set
			{
				if (m_ccot_feccierre != value)
				{
					m_ccot_feccierre = value;
					OnPropertyChanged("CCOT_FecCierre");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_Almacenaje.
		/// </summary>
		[DataMember]
		public Int16 CCOT_Almacenaje
		{
			get { return m_ccot_almacenaje; }
			set
			{
				if (m_ccot_almacenaje != value)
				{
					m_ccot_almacenaje = value;
					OnPropertyChanged("CCOT_Almacenaje");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_SobreEstadia.
		/// </summary>
		[DataMember]
		public Int16 CCOT_SobreEstadia
		{
			get { return m_ccot_sobreestadia; }
			set
			{
				if (m_ccot_sobreestadia != value)
				{
					m_ccot_sobreestadia = value;
					OnPropertyChanged("CCOT_SobreEstadia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_TiempoViaje.
		/// </summary>
		[DataMember]
		public Int16 CCOT_TiempoViaje
		{
			get { return m_ccot_tiempoviaje; }
			set
			{
				if (m_ccot_tiempoviaje != value)
				{
					m_ccot_tiempoviaje = value;
					OnPropertyChanged("CCOT_TiempoViaje");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_ValidezOferta.
		/// </summary>
		[DataMember]
		public Int16 CCOT_ValidezOferta
		{
			get { return m_ccot_validezoferta; }
			set
			{
				if (m_ccot_validezoferta != value)
				{
					m_ccot_validezoferta = value;
					OnPropertyChanged("CCOT_ValidezOferta");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabINC.
		/// </summary>
		[DataMember]
		public String TIPO_TabINC
		{
			get { return m_tipo_tabinc; }
			set
			{
				if (m_tipo_tabinc != value)
				{
					m_tipo_tabinc = value;
					OnPropertyChanged("TIPO_TabINC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodINC.
		/// </summary>
		[DataMember]
		public String TIPO_CodINC
		{
			get { return m_tipo_codinc; }
			set
			{
				if (m_tipo_codinc != value)
				{
					m_tipo_codinc = value;
					OnPropertyChanged("TIPO_CodINC");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabImo.
		/// </summary>
		[DataMember]
		public String TIPO_TabImo
		{
			get { return m_tipo_tabimo; }
			set
			{
				if (m_tipo_tabimo != value)
				{
					m_tipo_tabimo = value;
					OnPropertyChanged("TIPO_TabImo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodImo.
		/// </summary>
		[DataMember]
		public String TIPO_CodImo
		{
			get { return m_tipo_codimo; }
			set
			{
				if (m_tipo_codimo != value)
				{
					m_tipo_codimo = value;
					OnPropertyChanged("TIPO_CodImo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONT_Codigo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> CONT_Codigo
		{
			get { return m_cont_codigo; }
			set
			{
				if (m_cont_codigo != value)
				{
					m_cont_codigo = value;
					OnPropertyChanged("CONT_Codigo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabRGM.
		/// </summary>
		[DataMember]
		public String CONS_TabRGM
		{
			get { return m_cons_tabrgm; }
			set
			{
				if (m_cons_tabrgm != value)
				{
					m_cons_tabrgm = value;
					OnPropertyChanged("CONS_TabRGM");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodRGM.
		/// </summary>
		[DataMember]
		public String CONS_CodRGM
		{
			get { return m_cons_codrgm; }
			set
			{
				if (m_cons_codrgm != value)
				{
					m_cons_codrgm = value;
					OnPropertyChanged("CONS_CodRGM");
				}
			}
		}
		
		/// <summary>
		/// Gets or sets el valor de: CONS_TabVia.
		/// </summary>
		[DataMember]
		public String CONS_TabVia
		{
			get { return m_cons_tabvia; }
			set
			{
				if (m_cons_tabvia != value)
				{
					m_cons_tabvia = value;
					OnPropertyChanged("CONS_TabVia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodVia.
		/// </summary>
		[DataMember]
		public String CONS_CodVia
		{
			get { return m_cons_codvia; }
			set
			{
				if (m_cons_codvia != value)
				{
					m_cons_codvia = value;
					OnPropertyChanged("CONS_CodVia");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabFLE.
		/// </summary>
		[DataMember]
		public String CONS_TabFLE
		{
			get { return m_cons_tabfle; }
			set
			{
				if (m_cons_tabfle != value)
				{
					m_cons_tabfle = value;
					OnPropertyChanged("CONS_TabFLE");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodFLE.
		/// </summary>
		[DataMember]
		public String CONS_CodFLE
		{
			get { return m_cons_codfle; }
			set
			{
				if (m_cons_codfle != value)
				{
					m_cons_codfle = value;
					OnPropertyChanged("CONS_CodFLE");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabEST.
		/// </summary>
		[DataMember]
		public String CONS_TabEST
		{
			get { return m_cons_tabest; }
			set
			{
				if (m_cons_tabest != value)
				{
					m_cons_tabest = value;
					OnPropertyChanged("CONS_TabEST");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodEST.
		/// </summary>
		[DataMember]
		public String CONS_CodEST
		{
			get { return m_cons_codest; }
			set
			{
				if (m_cons_codest != value)
				{
					m_cons_codest = value;
					OnPropertyChanged("CONS_CodEST");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_CodDestino.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_CodDestino
		{
			get { return m_puer_coddestino; }
			set
			{
				if (m_puer_coddestino != value)
				{
					m_puer_coddestino = value;
					OnPropertyChanged("PUER_CodDestino");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_CodTrasbordo.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_CodTrasbordo
		{
			get { return m_puer_codtrasbordo; }
			set
			{
				if (m_puer_codtrasbordo != value)
				{
					m_puer_codtrasbordo = value;
					OnPropertyChanged("PUER_CodTrasbordo");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: PUER_CodOrigen.
		/// </summary>
		[DataMember]
		public Nullable<Int32> PUER_CodOrigen
		{
			get { return m_puer_codorigen; }
			set
			{
				if (m_puer_codorigen != value)
				{
					m_puer_codorigen = value;
					OnPropertyChanged("PUER_CodOrigen");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_UsrAprueba.
		/// </summary>
		[DataMember]
		public String CCOT_UsrAprueba
		{
			get { return m_ccot_usraprueba; }
			set
			{
				if (m_ccot_usraprueba != value)
				{
					m_ccot_usraprueba = value;
					OnPropertyChanged("CCOT_UsrAprueba");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_FecAprueba.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CCOT_FecAprueba
		{
			get { return m_ccot_fecaprueba; }
			set
			{
				if (m_ccot_fecaprueba != value)
				{
					m_ccot_fecaprueba = value;
					OnPropertyChanged("CCOT_FecAprueba");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_UsrAceptaRechaza.
		/// </summary>
		[DataMember]
		public String CCOT_UsrAceptaRechaza
		{
			get { return m_ccot_usraceptarechaza; }
			set
			{
				if (m_ccot_usraceptarechaza != value)
				{
					m_ccot_usraceptarechaza = value;
					OnPropertyChanged("CCOT_UsrAceptaRechaza");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_FecAceptaRechaza.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CCOT_FecAceptaRechaza
		{
			get { return m_ccot_fecaceptarechaza; }
			set
			{
				if (m_ccot_fecaceptarechaza != value)
				{
					m_ccot_fecaceptarechaza = value;
					OnPropertyChanged("CCOT_FecAceptaRechaza");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_TabMOT.
		/// </summary>
		[DataMember]
		public String TIPO_TabMOT
		{
			get { return m_tipo_tabmot; }
			set
			{
				if (m_tipo_tabmot != value)
				{
					m_tipo_tabmot = value;
					OnPropertyChanged("TIPO_TabMOT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: TIPO_CodMOT.
		/// </summary>
		[DataMember]
		public String TIPO_CodMOT
		{
			get { return m_tipo_codmot; }
			set
			{
				if (m_tipo_codmot != value)
				{
					m_tipo_codmot = value;
					OnPropertyChanged("TIPO_CodMOT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodShipper.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodShipper
		{
			get { return m_entc_codshipper; }
			set
			{
				if (m_entc_codshipper != value)
				{
					m_entc_codshipper = value;
					OnPropertyChanged("ENTC_CodShipper");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodConsignee.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodConsignee
		{
			get { return m_entc_codconsignee; }
			set
			{
				if (m_entc_codconsignee != value)
				{
					m_entc_codconsignee = value;
					OnPropertyChanged("ENTC_CodConsignee");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: ENTC_CodNotify.
		/// </summary>
		[DataMember]
		public Nullable<Int32> ENTC_CodNotify
		{
			get { return m_entc_codnotify; }
			set
			{
				if (m_entc_codnotify != value)
				{
					m_entc_codnotify = value;
					OnPropertyChanged("ENTC_CodNotify");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_TabTFT.
		/// </summary>
		[DataMember]
		public String CONS_TabTFT
		{
			get { return m_cons_tabtft; }
			set
			{
				if (m_cons_tabtft != value)
				{
					m_cons_tabtft = value;
					OnPropertyChanged("CONS_TabTFT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CONS_CodTFT.
		/// </summary>
		[DataMember]
		public String CONS_CodTFT
		{
			get { return m_cons_codtft; }
			set
			{
				if (m_cons_codtft != value)
				{
					m_cons_codtft = value;
					OnPropertyChanged("CONS_CodTFT");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_FecTarifa.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> CCOT_FecTarifa
		{
			get { return m_ccot_fectarifa; }
			set
			{
				if (m_ccot_fectarifa != value)
				{
					m_ccot_fectarifa = value;
					OnPropertyChanged("CCOT_FecTarifa");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_PagoMBL.
		/// </summary>
		[DataMember]
		public String CCOT_PagoMBL
		{
			get { return m_ccot_pagombl; }
			set
			{
				if (m_ccot_pagombl != value)
				{
					m_ccot_pagombl = value;
					OnPropertyChanged("CCOT_PagoMBL");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: CCOT_PagoHBL.
		/// </summary>
		[DataMember]
		public String CCOT_PagoHBL
		{
			get { return m_ccot_pagohbl; }
			set
			{
				if (m_ccot_pagohbl != value)
				{
					m_ccot_pagohbl = value;
					OnPropertyChanged("CCOT_PagoHBL");
				}
			}
		}
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabMND.
      /// </summary>
      [DataMember]
      public String TIPO_TabMND
      {
         get { return m_tipo_tabmnd; }
         set
         {
            if (m_tipo_tabmnd != value)
            {
               m_tipo_tabmnd = value;
               OnPropertyChanged("TIPO_TabMND");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodMND.
      /// </summary>
      [DataMember]
      public String TIPO_CodMND
      {
         get { return m_tipo_codmnd; }
         set
         {
            if (m_tipo_codmnd != value)
            {
               m_tipo_codmnd = value;
               OnPropertyChanged("TIPO_CodMND");
            }
         }
      }



      /// <summary>
      /// Gets or sets el valor de: TIPO_TabDTM.
      /// </summary>
      [DataMember]
      public String TIPO_TabDTM
      {
         get { return m_tipo_tabdtm; }
         set
         {
            if (m_tipo_tabdtm != value)
            {
               m_tipo_tabdtm = value;
               OnPropertyChanged("TIPO_TabDTM");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodDTM.
      /// </summary>
      [DataMember]
      public String TIPO_CodDTM
      {
         get { return m_tipo_coddtm; }
         set
         {
            if (m_tipo_coddtm != value)
            {
               m_tipo_coddtm = value;
               OnPropertyChanged("TIPO_CodDTM");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_Cntr.
      /// </summary>
      [DataMember]
      public String DOOV_Cntr
      {
         get { return m_doov_cntr; }
         set
         {
            if (m_doov_cntr != value)
            {
               m_doov_cntr = value;
               OnPropertyChanged("DOOV_Cntr");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_HBL.
      /// </summary>
      [DataMember]
      public String DOOV_HBL
      {
         get { return (!String.IsNullOrEmpty(m_doov_hbl) ? m_doov_hbl : null); }
         set
         {
            if (m_doov_hbl != value)
            {
               m_doov_hbl = value;
               OnPropertyChanged("DOOV_HBL");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_MBL.
      /// </summary>
      [DataMember]
      public String DOOV_MBL
      {
         get { return (!String.IsNullOrEmpty(m_doov_mbl) ? m_doov_mbl : null); }
         set
         {
            if (m_doov_mbl != value)
            {
               m_doov_mbl = value;
               OnPropertyChanged("DOOV_MBL");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: DOOV_CodReferencia.
      /// </summary>
      [DataMember]
      public String DOOV_CodReferencia
      {
         get { return m_doov_codreferencia; }
         set
         {
            if (m_doov_codreferencia != value)
            {
               m_doov_codreferencia = value;
               OnPropertyChanged("DOOV_CodReferencia");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: NVIA_Codigo.
      /// </summary>
      [DataMember]
      public Nullable<Int32> NVIA_Codigo
      {
         get { return m_nvia_codigo; }
         set
         {
            if (m_nvia_codigo != value)
            {
               m_nvia_codigo = value;
               OnPropertyChanged("NVIA_Codigo");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: DOOV_Feeder_IMPO.
      /// </summary>
      [DataMember]
      public String DOOV_Feeder_IMPO
      {
         get { return m_doov_feeder_impo; }
         set
         {
            if (m_doov_feeder_impo != value)
            {
               m_doov_feeder_impo = value;
               OnPropertyChanged("DOOV_Feeder_IMPO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_FecETDFeeder_IMPO.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> DOOV_FecETDFeeder_IMPO
      {
         get { return m_doov_fecetdfeeder_impo; }
         set
         {
            if (m_doov_fecetdfeeder_impo != value)
            {
               m_doov_fecetdfeeder_impo = value;
               OnPropertyChanged("DOOV_FecETDFeeder_IMPO");
            }
         }
      }

      /// <summary>
		/// Gets or sets el valor de: DDOV_HBLNieto.
		/// </summary>
		[DataMember]
		public Boolean DDOV_HBLNieto
		{
			get { return m_ddov_hblnieto; }
			set
			{
				if (m_ddov_hblnieto != value)
				{
					m_ddov_hblnieto = value;
					OnPropertyChanged("DDOV_HBLNieto");
				}
			}
		}

      /// <summary>
      /// Gets or sets el valor de: CCOT_ImoUN.
      /// </summary>
      [DataMember]
      public String CCOT_ImoUN
      {
         get { return m_ccot_imoun; }
         set
         {
            if (m_ccot_imoun != value)
            {
               m_ccot_imoun = value.Trim();
               OnPropertyChanged("CCOT_ImoUN");
            }
            
         }
      }
      
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabTRF.
      /// </summary>
      [DataMember]
      public String TIPO_TabTRF
      {
         get { return m_tipo_tabtrf; }
         set
         {
            if (value != m_tipo_tabtrf)
            { m_tipo_tabtrf = value; OnPropertyChanged("TIPO_TabTRF"); }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodTRF.
      /// </summary>
      [DataMember]
      public String TIPO_CodTRF
      {
         get { return m_tipo_codtrf; }
         set
         {
            if (value != m_tipo_codtrf)
            { m_tipo_codtrf = value; OnPropertyChanged("TIPO_CodTRF"); }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: DOOV_PlaceReceipt.
      /// </summary>
      [DataMember]
      public String DOOV_PlaceReceipt
      {
         get { return m_doov_placereceipt; }
         set
         {
            if (value != m_doov_placereceipt)
            { m_doov_placereceipt = value; OnPropertyChanged("DOOV_PlaceReceipt"); }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_PlaceDelivery.
      /// </summary>
      [DataMember]
      public String DOOV_PlaceDelivery
      {
         get { return m_doov_placedelivery; }
         set
         {
            if (value != m_doov_placedelivery)
            { m_doov_placedelivery = value; OnPropertyChanged("DOOV_PlaceDelivery"); }
         }
      }

      /// <summary>
		/// Gets or sets el valor de: AUDI_UsrCrea.
		/// </summary>
		[DataMember]
		public String AUDI_UsrCrea
		{
			get { return m_audi_usrcrea; }
			set
			{
				if (m_audi_usrcrea != value)
				{
					m_audi_usrcrea = value;
					OnPropertyChanged("AUDI_UsrCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecCrea.
		/// </summary>
		[DataMember]
		public DateTime AUDI_FecCrea
		{
			get { return m_audi_feccrea; }
			set
			{
				if (m_audi_feccrea != value)
				{
					m_audi_feccrea = value;
					OnPropertyChanged("AUDI_FecCrea");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_UsrMod.
		/// </summary>
		[DataMember]
		public String AUDI_UsrMod
		{
			get { return m_audi_usrmod; }
			set
			{
				if (m_audi_usrmod != value)
				{
					m_audi_usrmod = value;
					OnPropertyChanged("AUDI_UsrMod");
				}
			}
		}
		/// <summary>
		/// Gets or sets el valor de: AUDI_FecMod.
		/// </summary>
		[DataMember]
		public Nullable<DateTime> AUDI_FecMod
		{
			get { return m_audi_fecmod; }
			set
			{
				if (m_audi_fecmod != value)
				{
					m_audi_fecmod = value;
					OnPropertyChanged("AUDI_FecMod");
				}
			}
		}
		#endregion

		#region [ CopyTo ]
		public void CopyTo(ref Cab_Cotizacion_OV Item)
		{
			try
			{
				if (Item == null) { Item = new Cab_Cotizacion_OV(); }
				Item.CCOT_Numero = this.CCOT_Numero;
				Item.CCOT_Tipo = this.CCOT_Tipo;
				Item.EMPR_Codigo = this.EMPR_Codigo;
				Item.SUCR_Codigo = this.SUCR_Codigo;
				Item.CCOT_NumDoc = this.CCOT_NumDoc;
				Item.CCOT_NumPadre = this.CCOT_NumPadre;
				Item.CCOT_TipoPadre = this.CCOT_TipoPadre;
				Item.CCOT_Version = this.CCOT_Version;
				Item.CCOT_Propia = this.CCOT_Propia;
				Item.ENTC_CodCliente = this.ENTC_CodCliente;
				Item.ENTC_CodTransportista = this.ENTC_CodTransportista;
				Item.ENTC_CodBroker = this.ENTC_CodBroker;
				Item.ENTC_CodAgente = this.ENTC_CodAgente;
				Item.ENTC_CodCustomer = this.ENTC_CodCustomer;
				Item.ENTC_CodEjecutivo = this.ENTC_CodEjecutivo;
				Item.CCOT_NumPresupuesto = this.CCOT_NumPresupuesto;
				Item.CCOT_FecEmi = this.CCOT_FecEmi;
				Item.CCOT_FecVcto = this.CCOT_FecVcto;
				Item.CCOT_ServicioLogistico = this.CCOT_ServicioLogistico;
				Item.CCOT_CargaRefrigerada = this.CCOT_CargaRefrigerada;
				Item.CCOT_Temperatura = this.CCOT_Temperatura;
				Item.CCOT_CargaPeligrosa = this.CCOT_CargaPeligrosa;
				Item.CCOT_Roundtrip = this.CCOT_Roundtrip;
				Item.CCOT_Observaciones = this.CCOT_Observaciones;
				Item.CCOT_FecCierre = this.CCOT_FecCierre;
				Item.CCOT_Almacenaje = this.CCOT_Almacenaje;
				Item.CCOT_SobreEstadia = this.CCOT_SobreEstadia;
				Item.CCOT_TiempoViaje = this.CCOT_TiempoViaje;
				Item.CCOT_ValidezOferta = this.CCOT_ValidezOferta;
				Item.TIPO_TabINC = this.TIPO_TabINC;
				Item.TIPO_CodINC = this.TIPO_CodINC;
				Item.TIPO_TabImo = this.TIPO_TabImo;
				Item.TIPO_CodImo = this.TIPO_CodImo;
				Item.CONT_Codigo = this.CONT_Codigo;
				Item.CONS_TabRGM = this.CONS_TabRGM;
				Item.CONS_CodRGM = this.CONS_CodRGM;
				
				Item.CONS_TabVia = this.CONS_TabVia;
				Item.CONS_CodVia = this.CONS_CodVia;
				Item.CONS_TabFLE = this.CONS_TabFLE;
				Item.CONS_CodFLE = this.CONS_CodFLE;
				Item.CONS_TabEST = this.CONS_TabEST;
				Item.CONS_CodEST = this.CONS_CodEST;
				Item.PUER_CodDestino = this.PUER_CodDestino;
				Item.PUER_CodTrasbordo = this.PUER_CodTrasbordo;
				Item.PUER_CodOrigen = this.PUER_CodOrigen;
				Item.CCOT_UsrAprueba = this.CCOT_UsrAprueba;
				Item.CCOT_FecAprueba = this.CCOT_FecAprueba;
				Item.CCOT_UsrAceptaRechaza = this.CCOT_UsrAceptaRechaza;
				Item.CCOT_FecAceptaRechaza = this.CCOT_FecAceptaRechaza;
				Item.TIPO_TabMOT = this.TIPO_TabMOT;
				Item.TIPO_CodMOT = this.TIPO_CodMOT;
				Item.ENTC_CodShipper = this.ENTC_CodShipper;
				Item.ENTC_CodConsignee = this.ENTC_CodConsignee;
				Item.ENTC_CodNotify = this.ENTC_CodNotify;
				Item.CONS_TabTFT = this.CONS_TabTFT;
				Item.CONS_CodTFT = this.CONS_CodTFT;
				Item.CCOT_FecTarifa = this.CCOT_FecTarifa;
				Item.CCOT_PagoMBL = this.CCOT_PagoMBL;
				Item.CCOT_PagoHBL = this.CCOT_PagoHBL;
				Item.TIPO_TabMND = this.TIPO_TabMND;
				Item.TIPO_CodMND = this.TIPO_CodMND;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

      #region [ Version ]
      private Byte[] m_AUDI_Version;

      /// <summary>
      /// Gets or sets el valor de: AUDI_Version.
      /// </summary>
      [DataMember]
      public Byte[] AUDI_Version
      {
         get { return m_AUDI_Version; }
         set {
            if (m_AUDI_Version != value)
            { m_AUDI_Version = value; OnPropertyChanged("AUDI_Version"); }
         }
      }
      
      #endregion
   }
}
