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
using Infrastructure.Aspect.Collections;

namespace Delfin.Entities
{
    public partial class Cab_Cotizacion_OV
    {
        #region [ Variables Validación ]
        private Boolean m_ccot_numeroOK;
        private String m_ccot_numeroMSGERROR;
        private Boolean m_ccot_tipoOK;
        private String m_ccot_tipoMSGERROR;
        private Boolean m_empr_codigoOK;
        private String m_empr_codigoMSGERROR;
        private Boolean m_sucr_codigoOK;
        private String m_sucr_codigoMSGERROR;
        private Boolean m_ccot_numdocOK;
        private String m_ccot_numdocMSGERROR;
        private Boolean m_ccot_numpadreOK;
        private String m_ccot_numpadreMSGERROR;
        private Boolean m_ccot_tipopadreOK;
        private String m_ccot_tipopadreMSGERROR;
        private Boolean m_ccot_versionOK;
        private String m_ccot_versionMSGERROR;
        private Boolean m_ccot_propiaOK;
        private String m_ccot_propiaMSGERROR;
        private Boolean m_entc_codclienteOK;
        private String m_entc_codclienteMSGERROR;
        private Boolean m_entc_codtransportistaOK;
        private String m_entc_codtransportistaMSGERROR;
        private Boolean m_entc_codbrokerOK;
        private String m_entc_codbrokerMSGERROR;
        private Boolean m_entc_codagenteOK;
        private String m_entc_codagenteMSGERROR;
        private Boolean m_entc_codcustomerOK;
        private String m_entc_codcustomerMSGERROR;
        private Boolean m_entc_codejecutivoOK;
        private String m_entc_codejecutivoMSGERROR;
        private Boolean m_ccot_numpresupuestoOK;
        private String m_ccot_numpresupuestoMSGERROR;
        private Boolean m_ccot_fecemiOK;
        private String m_ccot_fecemiMSGERROR;
        private Boolean m_ccot_fecvctoOK;
        private String m_ccot_fecvctoMSGERROR;
        private Boolean m_ccot_serviciologisticoOK;
        private String m_ccot_serviciologisticoMSGERROR;
        private Boolean m_ccot_cargarefrigeradaOK;
        private String m_ccot_cargarefrigeradaMSGERROR;
        private Boolean m_ccot_temperaturaOK;
        private String m_ccot_temperaturaMSGERROR;
        private Boolean m_ccot_cargapeligrosaOK;
        private String m_ccot_cargapeligrosaMSGERROR;
        private Boolean m_ccot_roundtripOK;
        private String m_ccot_roundtripMSGERROR;
        private Boolean m_ccot_observacionesOK;
        private String m_ccot_observacionesMSGERROR;
        private Boolean m_ccot_feccierreOK;
        private String m_ccot_feccierreMSGERROR;
        private Boolean m_ccot_almacenajeOK;
        private String m_ccot_almacenajeMSGERROR;
        private Boolean m_ccot_sobreestadiaOK;
        private String m_ccot_sobreestadiaMSGERROR;
        private Boolean m_ccot_tiempoviajeOK;
        private String m_ccot_tiempoviajeMSGERROR;
        private Boolean m_ccot_validezofertaOK;
        private String m_ccot_validezofertaMSGERROR;
        private Boolean m_tipo_tabincOK;
        private String m_tipo_tabincMSGERROR;
        private Boolean m_tipo_codincOK;
        private String m_tipo_codincMSGERROR;
        private Boolean m_tipo_tabimoOK;
        private String m_tipo_tabimoMSGERROR;
        private Boolean m_tipo_codimoOK;
        private String m_tipo_codimoMSGERROR;
        private Boolean m_cont_codigoOK;
        private String m_cont_codigoMSGERROR;
        private Boolean m_cons_tabrgmOK;
        private String m_cons_tabrgmMSGERROR;
        private Boolean m_cons_codrgmOK;
        private String m_cons_codrgmMSGERROR;

        private Boolean m_cons_tabviaOK;
        private String m_cons_tabviaMSGERROR;
        private Boolean m_cons_codviaOK;
        private String m_cons_codviaMSGERROR;
        private Boolean m_cons_tabfleOK;
        private String m_cons_tabfleMSGERROR;
        private Boolean m_cons_codfleOK;
        private String m_cons_codfleMSGERROR;
        private Boolean m_cons_tabestOK;
        private String m_cons_tabestMSGERROR;
        private Boolean m_cons_codestOK;
        private String m_cons_codestMSGERROR;
        private Boolean m_puer_coddestinoOK;
        private String m_puer_coddestinoMSGERROR;
        private Boolean m_puer_codtrasbordoOK;
        private String m_puer_codtrasbordoMSGERROR;
        private Boolean m_puer_codorigenOK;
        private String m_puer_codorigenMSGERROR;
        private Boolean m_ccot_usrapruebaOK;
        private String m_ccot_usrapruebaMSGERROR;
        private Boolean m_ccot_fecapruebaOK;
        private String m_ccot_fecapruebaMSGERROR;
        private Boolean m_ccot_usraceptarechazaOK;
        private String m_ccot_usraceptarechazaMSGERROR;
        private Boolean m_ccot_fecaceptarechazaOK;
        private String m_ccot_fecaceptarechazaMSGERROR;
        private Boolean m_tipo_tabmotOK;
        private String m_tipo_tabmotMSGERROR;
        private Boolean m_tipo_codmotOK;
        private String m_tipo_codmotMSGERROR;
        private Boolean m_entc_codshipperOK;
        private String m_entc_codshipperMSGERROR;
        private Boolean m_entc_codconsigneeOK;
        private String m_entc_codconsigneeMSGERROR;
        private Boolean m_entc_codnotifyOK;
        private String m_entc_codnotifyMSGERROR;
        private Boolean m_cons_tabtftOK;
        private String m_cons_tabtftMSGERROR;
        private Boolean m_cons_codtftOK;
        private String m_cons_codtftMSGERROR;
        private Boolean m_ccot_fectarifaOK;
        private String m_ccot_fectarifaMSGERROR;
        private Boolean m_ccot_pagomblOK;
        private String m_ccot_pagomblMSGERROR;
        private Boolean m_ccot_pagohblOK;
        private String m_ccot_pagohblMSGERROR;
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

        private Boolean m_tipo_tabdtmOK;
        private String m_tipo_tabdtmMSGERROR;
        private Boolean m_tipo_coddtmOK;
        private String m_tipo_coddtmMSGERROR;
        private Boolean m_DOOV_CntrOK;
        private String m_DOOV_CntrMSGERROR;
        private Boolean m_doov_hblOK;
        private String m_doov_hblMSGERROR;
        private Boolean m_doov_mblOK;
        private String m_doov_mblMSGERROR;

        private Boolean m_nvia_codigoOK;
        private String m_nvia_codigoMSGERROR;

        private Boolean m_ccot_imounOK;
        private String m_ccot_imounMSGERROR;

        private Boolean m_itemsfleteOK;
        private String m_itemsfleteMSGERROR;
        private Boolean m_itemsfleteembarqueOK;
        private String m_itemsfleteembarqueMSGERROR;
        private Boolean m_itemsservicioOK;
        private String m_itemsservicioMSGERROR;

        private Boolean m_ddov_nrobookingOK;
        private String m_ddov_nrobookingMSGERROR;
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
        /// Gets or sets el valor de validación de: CCOT_NumDoc.
        /// </summary>
        [DataMember]
        public Boolean CCOT_NumDocOK
        {
            get { return m_ccot_numdocOK; }
            set
            {
                if (m_ccot_numdocOK != value)
                {
                    m_ccot_numdocOK = value;
                    OnPropertyChanged("CCOT_NumDocOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_NumDoc.
        /// </summary>
        [DataMember]
        public String CCOT_NumDocMSGERROR
        {
            get { return m_ccot_numdocMSGERROR; }
            set
            {
                if (m_ccot_numdocMSGERROR != value)
                {
                    m_ccot_numdocMSGERROR = value;
                    OnPropertyChanged("CCOT_NumDocMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_NumPadre.
        /// </summary>
        [DataMember]
        public Boolean CCOT_NumPadreOK
        {
            get { return m_ccot_numpadreOK; }
            set
            {
                if (m_ccot_numpadreOK != value)
                {
                    m_ccot_numpadreOK = value;
                    OnPropertyChanged("CCOT_NumPadreOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_NumPadre.
        /// </summary>
        [DataMember]
        public String CCOT_NumPadreMSGERROR
        {
            get { return m_ccot_numpadreMSGERROR; }
            set
            {
                if (m_ccot_numpadreMSGERROR != value)
                {
                    m_ccot_numpadreMSGERROR = value;
                    OnPropertyChanged("CCOT_NumPadreMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_TipoPadre.
        /// </summary>
        [DataMember]
        public Boolean CCOT_TipoPadreOK
        {
            get { return m_ccot_tipopadreOK; }
            set
            {
                if (m_ccot_tipopadreOK != value)
                {
                    m_ccot_tipopadreOK = value;
                    OnPropertyChanged("CCOT_TipoPadreOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_TipoPadre.
        /// </summary>
        [DataMember]
        public String CCOT_TipoPadreMSGERROR
        {
            get { return m_ccot_tipopadreMSGERROR; }
            set
            {
                if (m_ccot_tipopadreMSGERROR != value)
                {
                    m_ccot_tipopadreMSGERROR = value;
                    OnPropertyChanged("CCOT_TipoPadreMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_Version.
        /// </summary>
        [DataMember]
        public Boolean CCOT_VersionOK
        {
            get { return m_ccot_versionOK; }
            set
            {
                if (m_ccot_versionOK != value)
                {
                    m_ccot_versionOK = value;
                    OnPropertyChanged("CCOT_VersionOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_Version.
        /// </summary>
        [DataMember]
        public String CCOT_VersionMSGERROR
        {
            get { return m_ccot_versionMSGERROR; }
            set
            {
                if (m_ccot_versionMSGERROR != value)
                {
                    m_ccot_versionMSGERROR = value;
                    OnPropertyChanged("CCOT_VersionMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_Propia.
        /// </summary>
        [DataMember]
        public Boolean CCOT_PropiaOK
        {
            get { return m_ccot_propiaOK; }
            set
            {
                if (m_ccot_propiaOK != value)
                {
                    m_ccot_propiaOK = value;
                    OnPropertyChanged("CCOT_PropiaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_Propia.
        /// </summary>
        [DataMember]
        public String CCOT_PropiaMSGERROR
        {
            get { return m_ccot_propiaMSGERROR; }
            set
            {
                if (m_ccot_propiaMSGERROR != value)
                {
                    m_ccot_propiaMSGERROR = value;
                    OnPropertyChanged("CCOT_PropiaMSGERROR");
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
        /// Gets or sets el valor de validación de: ENTC_CodBroker.
        /// </summary>
        [DataMember]
        public Boolean ENTC_CodBrokerOK
        {
            get { return m_entc_codbrokerOK; }
            set
            {
                if (m_entc_codbrokerOK != value)
                {
                    m_entc_codbrokerOK = value;
                    OnPropertyChanged("ENTC_CodBrokerOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodBroker.
        /// </summary>
        [DataMember]
        public String ENTC_CodBrokerMSGERROR
        {
            get { return m_entc_codbrokerMSGERROR; }
            set
            {
                if (m_entc_codbrokerMSGERROR != value)
                {
                    m_entc_codbrokerMSGERROR = value;
                    OnPropertyChanged("ENTC_CodBrokerMSGERROR");
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
        /// Gets or sets el valor de validación de: ENTC_CodCustomer.
        /// </summary>
        [DataMember]
        public Boolean ENTC_CodCustomerOK
        {
            get { return m_entc_codcustomerOK; }
            set
            {
                if (m_entc_codcustomerOK != value)
                {
                    m_entc_codcustomerOK = value;
                    OnPropertyChanged("ENTC_CodCustomerOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodCustomer.
        /// </summary>
        [DataMember]
        public String ENTC_CodCustomerMSGERROR
        {
            get { return m_entc_codcustomerMSGERROR; }
            set
            {
                if (m_entc_codcustomerMSGERROR != value)
                {
                    m_entc_codcustomerMSGERROR = value;
                    OnPropertyChanged("ENTC_CodCustomerMSGERROR");
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
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_NumPresupuesto.
        /// </summary>
        [DataMember]
        public Boolean CCOT_NumPresupuestoOK
        {
            get { return m_ccot_numpresupuestoOK; }
            set
            {
                if (m_ccot_numpresupuestoOK != value)
                {
                    m_ccot_numpresupuestoOK = value;
                    OnPropertyChanged("CCOT_NumPresupuestoOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_NumPresupuesto.
        /// </summary>
        [DataMember]
        public String CCOT_NumPresupuestoMSGERROR
        {
            get { return m_ccot_numpresupuestoMSGERROR; }
            set
            {
                if (m_ccot_numpresupuestoMSGERROR != value)
                {
                    m_ccot_numpresupuestoMSGERROR = value;
                    OnPropertyChanged("CCOT_NumPresupuestoMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_FecEmi.
        /// </summary>
        [DataMember]
        public Boolean CCOT_FecEmiOK
        {
            get { return m_ccot_fecemiOK; }
            set
            {
                if (m_ccot_fecemiOK != value)
                {
                    m_ccot_fecemiOK = value;
                    OnPropertyChanged("CCOT_FecEmiOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_FecEmi.
        /// </summary>
        [DataMember]
        public String CCOT_FecEmiMSGERROR
        {
            get { return m_ccot_fecemiMSGERROR; }
            set
            {
                if (m_ccot_fecemiMSGERROR != value)
                {
                    m_ccot_fecemiMSGERROR = value;
                    OnPropertyChanged("CCOT_FecEmiMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_FecVcto.
        /// </summary>
        [DataMember]
        public Boolean CCOT_FecVctoOK
        {
            get { return m_ccot_fecvctoOK; }
            set
            {
                if (m_ccot_fecvctoOK != value)
                {
                    m_ccot_fecvctoOK = value;
                    OnPropertyChanged("CCOT_FecVctoOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_FecVcto.
        /// </summary>
        [DataMember]
        public String CCOT_FecVctoMSGERROR
        {
            get { return m_ccot_fecvctoMSGERROR; }
            set
            {
                if (m_ccot_fecvctoMSGERROR != value)
                {
                    m_ccot_fecvctoMSGERROR = value;
                    OnPropertyChanged("CCOT_FecVctoMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_ServicioLogistico.
        /// </summary>
        [DataMember]
        public Boolean CCOT_ServicioLogisticoOK
        {
            get { return m_ccot_serviciologisticoOK; }
            set
            {
                if (m_ccot_serviciologisticoOK != value)
                {
                    m_ccot_serviciologisticoOK = value;
                    OnPropertyChanged("CCOT_ServicioLogisticoOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_ServicioLogistico.
        /// </summary>
        [DataMember]
        public String CCOT_ServicioLogisticoMSGERROR
        {
            get { return m_ccot_serviciologisticoMSGERROR; }
            set
            {
                if (m_ccot_serviciologisticoMSGERROR != value)
                {
                    m_ccot_serviciologisticoMSGERROR = value;
                    OnPropertyChanged("CCOT_ServicioLogisticoMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_CargaRefrigerada.
        /// </summary>
        [DataMember]
        public Boolean CCOT_CargaRefrigeradaOK
        {
            get { return m_ccot_cargarefrigeradaOK; }
            set
            {
                if (m_ccot_cargarefrigeradaOK != value)
                {
                    m_ccot_cargarefrigeradaOK = value;
                    OnPropertyChanged("CCOT_CargaRefrigeradaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_CargaRefrigerada.
        /// </summary>
        [DataMember]
        public String CCOT_CargaRefrigeradaMSGERROR
        {
            get { return m_ccot_cargarefrigeradaMSGERROR; }
            set
            {
                if (m_ccot_cargarefrigeradaMSGERROR != value)
                {
                    m_ccot_cargarefrigeradaMSGERROR = value;
                    OnPropertyChanged("CCOT_CargaRefrigeradaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_Temperatura.
        /// </summary>
        [DataMember]
        public Boolean CCOT_TemperaturaOK
        {
            get { return m_ccot_temperaturaOK; }
            set
            {
                if (m_ccot_temperaturaOK != value)
                {
                    m_ccot_temperaturaOK = value;
                    OnPropertyChanged("CCOT_TemperaturaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_Temperatura.
        /// </summary>
        [DataMember]
        public String CCOT_TemperaturaMSGERROR
        {
            get { return m_ccot_temperaturaMSGERROR; }
            set
            {
                if (m_ccot_temperaturaMSGERROR != value)
                {
                    m_ccot_temperaturaMSGERROR = value;
                    OnPropertyChanged("CCOT_TemperaturaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_CargaPeligrosa.
        /// </summary>
        [DataMember]
        public Boolean CCOT_CargaPeligrosaOK
        {
            get { return m_ccot_cargapeligrosaOK; }
            set
            {
                if (m_ccot_cargapeligrosaOK != value)
                {
                    m_ccot_cargapeligrosaOK = value;
                    OnPropertyChanged("CCOT_CargaPeligrosaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_CargaPeligrosa.
        /// </summary>
        [DataMember]
        public String CCOT_CargaPeligrosaMSGERROR
        {
            get { return m_ccot_cargapeligrosaMSGERROR; }
            set
            {
                if (m_ccot_cargapeligrosaMSGERROR != value)
                {
                    m_ccot_cargapeligrosaMSGERROR = value;
                    OnPropertyChanged("CCOT_CargaPeligrosaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_Roundtrip.
        /// </summary>
        [DataMember]
        public Boolean CCOT_RoundtripOK
        {
            get { return m_ccot_roundtripOK; }
            set
            {
                if (m_ccot_roundtripOK != value)
                {
                    m_ccot_roundtripOK = value;
                    OnPropertyChanged("CCOT_RoundtripOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_Roundtrip.
        /// </summary>
        [DataMember]
        public String CCOT_RoundtripMSGERROR
        {
            get { return m_ccot_roundtripMSGERROR; }
            set
            {
                if (m_ccot_roundtripMSGERROR != value)
                {
                    m_ccot_roundtripMSGERROR = value;
                    OnPropertyChanged("CCOT_RoundtripMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_Observaciones.
        /// </summary>
        [DataMember]
        public Boolean CCOT_ObservacionesOK
        {
            get { return m_ccot_observacionesOK; }
            set
            {
                if (m_ccot_observacionesOK != value)
                {
                    m_ccot_observacionesOK = value;
                    OnPropertyChanged("CCOT_ObservacionesOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_Observaciones.
        /// </summary>
        [DataMember]
        public String CCOT_ObservacionesMSGERROR
        {
            get { return m_ccot_observacionesMSGERROR; }
            set
            {
                if (m_ccot_observacionesMSGERROR != value)
                {
                    m_ccot_observacionesMSGERROR = value;
                    OnPropertyChanged("CCOT_ObservacionesMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_FecCierre.
        /// </summary>
        [DataMember]
        public Boolean CCOT_FecCierreOK
        {
            get { return m_ccot_feccierreOK; }
            set
            {
                if (m_ccot_feccierreOK != value)
                {
                    m_ccot_feccierreOK = value;
                    OnPropertyChanged("CCOT_FecCierreOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_FecCierre.
        /// </summary>
        [DataMember]
        public String CCOT_FecCierreMSGERROR
        {
            get { return m_ccot_feccierreMSGERROR; }
            set
            {
                if (m_ccot_feccierreMSGERROR != value)
                {
                    m_ccot_feccierreMSGERROR = value;
                    OnPropertyChanged("CCOT_FecCierreMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_Almacenaje.
        /// </summary>
        [DataMember]
        public Boolean CCOT_AlmacenajeOK
        {
            get { return m_ccot_almacenajeOK; }
            set
            {
                if (m_ccot_almacenajeOK != value)
                {
                    m_ccot_almacenajeOK = value;
                    OnPropertyChanged("CCOT_AlmacenajeOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_Almacenaje.
        /// </summary>
        [DataMember]
        public String CCOT_AlmacenajeMSGERROR
        {
            get { return m_ccot_almacenajeMSGERROR; }
            set
            {
                if (m_ccot_almacenajeMSGERROR != value)
                {
                    m_ccot_almacenajeMSGERROR = value;
                    OnPropertyChanged("CCOT_AlmacenajeMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_SobreEstadia.
        /// </summary>
        [DataMember]
        public Boolean CCOT_SobreEstadiaOK
        {
            get { return m_ccot_sobreestadiaOK; }
            set
            {
                if (m_ccot_sobreestadiaOK != value)
                {
                    m_ccot_sobreestadiaOK = value;
                    OnPropertyChanged("CCOT_SobreEstadiaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_SobreEstadia.
        /// </summary>
        [DataMember]
        public String CCOT_SobreEstadiaMSGERROR
        {
            get { return m_ccot_sobreestadiaMSGERROR; }
            set
            {
                if (m_ccot_sobreestadiaMSGERROR != value)
                {
                    m_ccot_sobreestadiaMSGERROR = value;
                    OnPropertyChanged("CCOT_SobreEstadiaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_TiempoViaje.
        /// </summary>
        [DataMember]
        public Boolean CCOT_TiempoViajeOK
        {
            get { return m_ccot_tiempoviajeOK; }
            set
            {
                if (m_ccot_tiempoviajeOK != value)
                {
                    m_ccot_tiempoviajeOK = value;
                    OnPropertyChanged("CCOT_TiempoViajeOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_TiempoViaje.
        /// </summary>
        [DataMember]
        public String CCOT_TiempoViajeMSGERROR
        {
            get { return m_ccot_tiempoviajeMSGERROR; }
            set
            {
                if (m_ccot_tiempoviajeMSGERROR != value)
                {
                    m_ccot_tiempoviajeMSGERROR = value;
                    OnPropertyChanged("CCOT_TiempoViajeMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_ValidezOferta.
        /// </summary>
        [DataMember]
        public Boolean CCOT_ValidezOfertaOK
        {
            get { return m_ccot_validezofertaOK; }
            set
            {
                if (m_ccot_validezofertaOK != value)
                {
                    m_ccot_validezofertaOK = value;
                    OnPropertyChanged("CCOT_ValidezOfertaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_ValidezOferta.
        /// </summary>
        [DataMember]
        public String CCOT_ValidezOfertaMSGERROR
        {
            get { return m_ccot_validezofertaMSGERROR; }
            set
            {
                if (m_ccot_validezofertaMSGERROR != value)
                {
                    m_ccot_validezofertaMSGERROR = value;
                    OnPropertyChanged("CCOT_ValidezOfertaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabINC.
        /// </summary>
        [DataMember]
        public Boolean TIPO_TabINCOK
        {
            get { return m_tipo_tabincOK; }
            set
            {
                if (m_tipo_tabincOK != value)
                {
                    m_tipo_tabincOK = value;
                    OnPropertyChanged("TIPO_TabINCOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabINC.
        /// </summary>
        [DataMember]
        public String TIPO_TabINCMSGERROR
        {
            get { return m_tipo_tabincMSGERROR; }
            set
            {
                if (m_tipo_tabincMSGERROR != value)
                {
                    m_tipo_tabincMSGERROR = value;
                    OnPropertyChanged("TIPO_TabINCMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodINC.
        /// </summary>
        [DataMember]
        public Boolean TIPO_CodINCOK
        {
            get { return m_tipo_codincOK; }
            set
            {
                if (m_tipo_codincOK != value)
                {
                    m_tipo_codincOK = value;
                    OnPropertyChanged("TIPO_CodINCOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodINC.
        /// </summary>
        [DataMember]
        public String TIPO_CodINCMSGERROR
        {
            get { return m_tipo_codincMSGERROR; }
            set
            {
                if (m_tipo_codincMSGERROR != value)
                {
                    m_tipo_codincMSGERROR = value;
                    OnPropertyChanged("TIPO_CodINCMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabImo.
        /// </summary>
        [DataMember]
        public Boolean TIPO_TabImoOK
        {
            get { return m_tipo_tabimoOK; }
            set
            {
                if (m_tipo_tabimoOK != value)
                {
                    m_tipo_tabimoOK = value;
                    OnPropertyChanged("TIPO_TabImoOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabImo.
        /// </summary>
        [DataMember]
        public String TIPO_TabImoMSGERROR
        {
            get { return m_tipo_tabimoMSGERROR; }
            set
            {
                if (m_tipo_tabimoMSGERROR != value)
                {
                    m_tipo_tabimoMSGERROR = value;
                    OnPropertyChanged("TIPO_TabImoMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodImo.
        /// </summary>
        [DataMember]
        public Boolean TIPO_CodImoOK
        {
            get { return m_tipo_codimoOK; }
            set
            {
                if (m_tipo_codimoOK != value)
                {
                    m_tipo_codimoOK = value;
                    OnPropertyChanged("TIPO_CodImoOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodImo.
        /// </summary>
        [DataMember]
        public String TIPO_CodImoMSGERROR
        {
            get { return m_tipo_codimoMSGERROR; }
            set
            {
                if (m_tipo_codimoMSGERROR != value)
                {
                    m_tipo_codimoMSGERROR = value;
                    OnPropertyChanged("TIPO_CodImoMSGERROR");
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
        /// Gets or sets el valor de validación de: CONS_TabRGM.
        /// </summary>
        [DataMember]
        public Boolean CONS_TabRGMOK
        {
            get { return m_cons_tabrgmOK; }
            set
            {
                if (m_cons_tabrgmOK != value)
                {
                    m_cons_tabrgmOK = value;
                    OnPropertyChanged("CONS_TabRGMOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_TabRGM.
        /// </summary>
        [DataMember]
        public String CONS_TabRGMMSGERROR
        {
            get { return m_cons_tabrgmMSGERROR; }
            set
            {
                if (m_cons_tabrgmMSGERROR != value)
                {
                    m_cons_tabrgmMSGERROR = value;
                    OnPropertyChanged("CONS_TabRGMMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_CodRGM.
        /// </summary>
        [DataMember]
        public Boolean CONS_CodRGMOK
        {
            get { return m_cons_codrgmOK; }
            set
            {
                if (m_cons_codrgmOK != value)
                {
                    m_cons_codrgmOK = value;
                    OnPropertyChanged("CONS_CodRGMOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_CodRGM.
        /// </summary>
        [DataMember]
        public String CONS_CodRGMMSGERROR
        {
            get { return m_cons_codrgmMSGERROR; }
            set
            {
                if (m_cons_codrgmMSGERROR != value)
                {
                    m_cons_codrgmMSGERROR = value;
                    OnPropertyChanged("CONS_CodRGMMSGERROR");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de validación de: CONS_TabVia.
        /// </summary>
        [DataMember]
        public Boolean CONS_TabViaOK
        {
            get { return m_cons_tabviaOK; }
            set
            {
                if (m_cons_tabviaOK != value)
                {
                    m_cons_tabviaOK = value;
                    OnPropertyChanged("CONS_TabViaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_TabVia.
        /// </summary>
        [DataMember]
        public String CONS_TabViaMSGERROR
        {
            get { return m_cons_tabviaMSGERROR; }
            set
            {
                if (m_cons_tabviaMSGERROR != value)
                {
                    m_cons_tabviaMSGERROR = value;
                    OnPropertyChanged("CONS_TabViaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_CodVia.
        /// </summary>
        [DataMember]
        public Boolean CONS_CodViaOK
        {
            get { return m_cons_codviaOK; }
            set
            {
                if (m_cons_codviaOK != value)
                {
                    m_cons_codviaOK = value;
                    OnPropertyChanged("CONS_CodViaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_CodVia.
        /// </summary>
        [DataMember]
        public String CONS_CodViaMSGERROR
        {
            get { return m_cons_codviaMSGERROR; }
            set
            {
                if (m_cons_codviaMSGERROR != value)
                {
                    m_cons_codviaMSGERROR = value;
                    OnPropertyChanged("CONS_CodViaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_TabFLE.
        /// </summary>
        [DataMember]
        public Boolean CONS_TabFLEOK
        {
            get { return m_cons_tabfleOK; }
            set
            {
                if (m_cons_tabfleOK != value)
                {
                    m_cons_tabfleOK = value;
                    OnPropertyChanged("CONS_TabFLEOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_TabFLE.
        /// </summary>
        [DataMember]
        public String CONS_TabFLEMSGERROR
        {
            get { return m_cons_tabfleMSGERROR; }
            set
            {
                if (m_cons_tabfleMSGERROR != value)
                {
                    m_cons_tabfleMSGERROR = value;
                    OnPropertyChanged("CONS_TabFLEMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_CodFLE.
        /// </summary>
        [DataMember]
        public Boolean CONS_CodFLEOK
        {
            get { return m_cons_codfleOK; }
            set
            {
                if (m_cons_codfleOK != value)
                {
                    m_cons_codfleOK = value;
                    OnPropertyChanged("CONS_CodFLEOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_CodFLE.
        /// </summary>
        [DataMember]
        public String CONS_CodFLEMSGERROR
        {
            get { return m_cons_codfleMSGERROR; }
            set
            {
                if (m_cons_codfleMSGERROR != value)
                {
                    m_cons_codfleMSGERROR = value;
                    OnPropertyChanged("CONS_CodFLEMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_TabEST.
        /// </summary>
        [DataMember]
        public Boolean CONS_TabESTOK
        {
            get { return m_cons_tabestOK; }
            set
            {
                if (m_cons_tabestOK != value)
                {
                    m_cons_tabestOK = value;
                    OnPropertyChanged("CONS_TabESTOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_TabEST.
        /// </summary>
        [DataMember]
        public String CONS_TabESTMSGERROR
        {
            get { return m_cons_tabestMSGERROR; }
            set
            {
                if (m_cons_tabestMSGERROR != value)
                {
                    m_cons_tabestMSGERROR = value;
                    OnPropertyChanged("CONS_TabESTMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_CodEST.
        /// </summary>
        [DataMember]
        public Boolean CONS_CodESTOK
        {
            get { return m_cons_codestOK; }
            set
            {
                if (m_cons_codestOK != value)
                {
                    m_cons_codestOK = value;
                    OnPropertyChanged("CONS_CodESTOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_CodEST.
        /// </summary>
        [DataMember]
        public String CONS_CodESTMSGERROR
        {
            get { return m_cons_codestMSGERROR; }
            set
            {
                if (m_cons_codestMSGERROR != value)
                {
                    m_cons_codestMSGERROR = value;
                    OnPropertyChanged("CONS_CodESTMSGERROR");
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
        /// Gets or sets el valor de validación de: PUER_CodTrasbordo.
        /// </summary>
        [DataMember]
        public Boolean PUER_CodTrasbordoOK
        {
            get { return m_puer_codtrasbordoOK; }
            set
            {
                if (m_puer_codtrasbordoOK != value)
                {
                    m_puer_codtrasbordoOK = value;
                    OnPropertyChanged("PUER_CodTrasbordoOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: PUER_CodTrasbordo.
        /// </summary>
        [DataMember]
        public String PUER_CodTrasbordoMSGERROR
        {
            get { return m_puer_codtrasbordoMSGERROR; }
            set
            {
                if (m_puer_codtrasbordoMSGERROR != value)
                {
                    m_puer_codtrasbordoMSGERROR = value;
                    OnPropertyChanged("PUER_CodTrasbordoMSGERROR");
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
        /// Gets or sets el valor de validación de: CCOT_UsrAprueba.
        /// </summary>
        [DataMember]
        public Boolean CCOT_UsrApruebaOK
        {
            get { return m_ccot_usrapruebaOK; }
            set
            {
                if (m_ccot_usrapruebaOK != value)
                {
                    m_ccot_usrapruebaOK = value;
                    OnPropertyChanged("CCOT_UsrApruebaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_UsrAprueba.
        /// </summary>
        [DataMember]
        public String CCOT_UsrApruebaMSGERROR
        {
            get { return m_ccot_usrapruebaMSGERROR; }
            set
            {
                if (m_ccot_usrapruebaMSGERROR != value)
                {
                    m_ccot_usrapruebaMSGERROR = value;
                    OnPropertyChanged("CCOT_UsrApruebaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_FecAprueba.
        /// </summary>
        [DataMember]
        public Boolean CCOT_FecApruebaOK
        {
            get { return m_ccot_fecapruebaOK; }
            set
            {
                if (m_ccot_fecapruebaOK != value)
                {
                    m_ccot_fecapruebaOK = value;
                    OnPropertyChanged("CCOT_FecApruebaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_FecAprueba.
        /// </summary>
        [DataMember]
        public String CCOT_FecApruebaMSGERROR
        {
            get { return m_ccot_fecapruebaMSGERROR; }
            set
            {
                if (m_ccot_fecapruebaMSGERROR != value)
                {
                    m_ccot_fecapruebaMSGERROR = value;
                    OnPropertyChanged("CCOT_FecApruebaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_UsrAceptaRechaza.
        /// </summary>
        [DataMember]
        public Boolean CCOT_UsrAceptaRechazaOK
        {
            get { return m_ccot_usraceptarechazaOK; }
            set
            {
                if (m_ccot_usraceptarechazaOK != value)
                {
                    m_ccot_usraceptarechazaOK = value;
                    OnPropertyChanged("CCOT_UsrAceptaRechazaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_UsrAceptaRechaza.
        /// </summary>
        [DataMember]
        public String CCOT_UsrAceptaRechazaMSGERROR
        {
            get { return m_ccot_usraceptarechazaMSGERROR; }
            set
            {
                if (m_ccot_usraceptarechazaMSGERROR != value)
                {
                    m_ccot_usraceptarechazaMSGERROR = value;
                    OnPropertyChanged("CCOT_UsrAceptaRechazaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_FecAceptaRechaza.
        /// </summary>
        [DataMember]
        public Boolean CCOT_FecAceptaRechazaOK
        {
            get { return m_ccot_fecaceptarechazaOK; }
            set
            {
                if (m_ccot_fecaceptarechazaOK != value)
                {
                    m_ccot_fecaceptarechazaOK = value;
                    OnPropertyChanged("CCOT_FecAceptaRechazaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_FecAceptaRechaza.
        /// </summary>
        [DataMember]
        public String CCOT_FecAceptaRechazaMSGERROR
        {
            get { return m_ccot_fecaceptarechazaMSGERROR; }
            set
            {
                if (m_ccot_fecaceptarechazaMSGERROR != value)
                {
                    m_ccot_fecaceptarechazaMSGERROR = value;
                    OnPropertyChanged("CCOT_FecAceptaRechazaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_TabMOT.
        /// </summary>
        [DataMember]
        public Boolean TIPO_TabMOTOK
        {
            get { return m_tipo_tabmotOK; }
            set
            {
                if (m_tipo_tabmotOK != value)
                {
                    m_tipo_tabmotOK = value;
                    OnPropertyChanged("TIPO_TabMOTOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_TabMOT.
        /// </summary>
        [DataMember]
        public String TIPO_TabMOTMSGERROR
        {
            get { return m_tipo_tabmotMSGERROR; }
            set
            {
                if (m_tipo_tabmotMSGERROR != value)
                {
                    m_tipo_tabmotMSGERROR = value;
                    OnPropertyChanged("TIPO_TabMOTMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: TIPO_CodMOT.
        /// </summary>
        [DataMember]
        public Boolean TIPO_CodMOTOK
        {
            get { return m_tipo_codmotOK; }
            set
            {
                if (m_tipo_codmotOK != value)
                {
                    m_tipo_codmotOK = value;
                    OnPropertyChanged("TIPO_CodMOTOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: TIPO_CodMOT.
        /// </summary>
        [DataMember]
        public String TIPO_CodMOTMSGERROR
        {
            get { return m_tipo_codmotMSGERROR; }
            set
            {
                if (m_tipo_codmotMSGERROR != value)
                {
                    m_tipo_codmotMSGERROR = value;
                    OnPropertyChanged("TIPO_CodMOTMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_CodShipper.
        /// </summary>
        [DataMember]
        public Boolean ENTC_CodShipperOK
        {
            get { return m_entc_codshipperOK; }
            set
            {
                if (m_entc_codshipperOK != value)
                {
                    m_entc_codshipperOK = value;
                    OnPropertyChanged("ENTC_CodShipperOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodShipper.
        /// </summary>
        [DataMember]
        public String ENTC_CodShipperMSGERROR
        {
            get { return m_entc_codshipperMSGERROR; }
            set
            {
                if (m_entc_codshipperMSGERROR != value)
                {
                    m_entc_codshipperMSGERROR = value;
                    OnPropertyChanged("ENTC_CodShipperMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_CodConsignee.
        /// </summary>
        [DataMember]
        public Boolean ENTC_CodConsigneeOK
        {
            get { return m_entc_codconsigneeOK; }
            set
            {
                if (m_entc_codconsigneeOK != value)
                {
                    m_entc_codconsigneeOK = value;
                    OnPropertyChanged("ENTC_CodConsigneeOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodConsignee.
        /// </summary>
        [DataMember]
        public String ENTC_CodConsigneeMSGERROR
        {
            get { return m_entc_codconsigneeMSGERROR; }
            set
            {
                if (m_entc_codconsigneeMSGERROR != value)
                {
                    m_entc_codconsigneeMSGERROR = value;
                    OnPropertyChanged("ENTC_CodConsigneeMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_CodNotify.
        /// </summary>
        [DataMember]
        public Boolean ENTC_CodNotifyOK
        {
            get { return m_entc_codnotifyOK; }
            set
            {
                if (m_entc_codnotifyOK != value)
                {
                    m_entc_codnotifyOK = value;
                    OnPropertyChanged("ENTC_CodNotifyOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ENTC_CodNotify.
        /// </summary>
        [DataMember]
        public String ENTC_CodNotifyMSGERROR
        {
            get { return m_entc_codnotifyMSGERROR; }
            set
            {
                if (m_entc_codnotifyMSGERROR != value)
                {
                    m_entc_codnotifyMSGERROR = value;
                    OnPropertyChanged("ENTC_CodNotifyMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_TabTFT.
        /// </summary>
        [DataMember]
        public Boolean CONS_TabTFTOK
        {
            get { return m_cons_tabtftOK; }
            set
            {
                if (m_cons_tabtftOK != value)
                {
                    m_cons_tabtftOK = value;
                    OnPropertyChanged("CONS_TabTFTOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_TabTFT.
        /// </summary>
        [DataMember]
        public String CONS_TabTFTMSGERROR
        {
            get { return m_cons_tabtftMSGERROR; }
            set
            {
                if (m_cons_tabtftMSGERROR != value)
                {
                    m_cons_tabtftMSGERROR = value;
                    OnPropertyChanged("CONS_TabTFTMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CONS_CodTFT.
        /// </summary>
        [DataMember]
        public Boolean CONS_CodTFTOK
        {
            get { return m_cons_codtftOK; }
            set
            {
                if (m_cons_codtftOK != value)
                {
                    m_cons_codtftOK = value;
                    OnPropertyChanged("CONS_CodTFTOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CONS_CodTFT.
        /// </summary>
        [DataMember]
        public String CONS_CodTFTMSGERROR
        {
            get { return m_cons_codtftMSGERROR; }
            set
            {
                if (m_cons_codtftMSGERROR != value)
                {
                    m_cons_codtftMSGERROR = value;
                    OnPropertyChanged("CONS_CodTFTMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_FecTarifa.
        /// </summary>
        [DataMember]
        public Boolean CCOT_FecTarifaOK
        {
            get { return m_ccot_fectarifaOK; }
            set
            {
                if (m_ccot_fectarifaOK != value)
                {
                    m_ccot_fectarifaOK = value;
                    OnPropertyChanged("CCOT_FecTarifaOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_FecTarifa.
        /// </summary>
        [DataMember]
        public String CCOT_FecTarifaMSGERROR
        {
            get { return m_ccot_fectarifaMSGERROR; }
            set
            {
                if (m_ccot_fectarifaMSGERROR != value)
                {
                    m_ccot_fectarifaMSGERROR = value;
                    OnPropertyChanged("CCOT_FecTarifaMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_PagoMBL.
        /// </summary>
        [DataMember]
        public Boolean CCOT_PagoMBLOK
        {
            get { return m_ccot_pagomblOK; }
            set
            {
                if (m_ccot_pagomblOK != value)
                {
                    m_ccot_pagomblOK = value;
                    OnPropertyChanged("CCOT_PagoMBLOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_PagoMBL.
        /// </summary>
        [DataMember]
        public String CCOT_PagoMBLMSGERROR
        {
            get { return m_ccot_pagomblMSGERROR; }
            set
            {
                if (m_ccot_pagomblMSGERROR != value)
                {
                    m_ccot_pagomblMSGERROR = value;
                    OnPropertyChanged("CCOT_PagoMBLMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: CCOT_PagoHBL.
        /// </summary>
        [DataMember]
        public Boolean CCOT_PagoHBLOK
        {
            get { return m_ccot_pagohblOK; }
            set
            {
                if (m_ccot_pagohblOK != value)
                {
                    m_ccot_pagohblOK = value;
                    OnPropertyChanged("CCOT_PagoHBLOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_PagoHBL.
        /// </summary>
        [DataMember]
        public String CCOT_PagoHBLMSGERROR
        {
            get { return m_ccot_pagohblMSGERROR; }
            set
            {
                if (m_ccot_pagohblMSGERROR != value)
                {
                    m_ccot_pagohblMSGERROR = value;
                    OnPropertyChanged("CCOT_PagoHBLMSGERROR");
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
        /// Gets or sets el valor de validación de: "Cotización/Orden de Venta".
        /// </summary>
        [DataMember]
        public Boolean DOOV_CntrOK
        {
            get { return m_DOOV_CntrOK; }
            set
            {
                if (m_DOOV_CntrOK != value)
                {
                    m_DOOV_CntrOK = value;
                    OnPropertyChanged("DOOV_Cntr");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: "Cotización/Orden de Venta".
        /// </summary>
        [DataMember]
        public String DOOV_CntrMSGERROR
        {
            get { return m_DOOV_CntrMSGERROR; }
            set
            {
                if (m_DOOV_CntrMSGERROR != value)
                {
                    m_DOOV_CntrMSGERROR = value;
                    OnPropertyChanged("DOOV_Cntr");
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
        /// Gets or sets el valor de validación de: CCOT_ImoUN.
        /// </summary>
        [DataMember]
        public Boolean CCOT_ImoUNOK
        {
            get { return m_ccot_imounOK; }
            set
            {
                if (m_ccot_imounOK != value)
                {
                    m_ccot_imounOK = value;
                    OnPropertyChanged("CCOT_ImoUNOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: CCOT_ImoUN.
        /// </summary>
        [DataMember]
        public String CCOT_ImoUNMSGERROR
        {
            get { return m_ccot_imounMSGERROR; }
            set
            {
                if (m_ccot_imounMSGERROR != value)
                {
                    m_ccot_imounMSGERROR = value;
                    OnPropertyChanged("CCOT_ImoUNMSGERROR");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de validación de: ItemsFlete.
        /// </summary>
        [DataMember]
        public Boolean ItemsFleteOK
        {
            get { return m_itemsfleteOK; }
            set
            {
                if (m_itemsfleteOK != value)
                {
                    m_itemsfleteOK = value;
                    OnPropertyChanged("ItemsFleteOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ItemsFlete.
        /// </summary>
        [DataMember]
        public String ItemsFleteMSGERROR
        {
            get { return m_itemsfleteMSGERROR; }
            set
            {
                if (m_itemsfleteMSGERROR != value)
                {
                    m_itemsfleteMSGERROR = value;
                    OnPropertyChanged("ItemsFleteMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ItemsFlete.
        /// </summary>
        [DataMember]
        public Boolean ItemsFleteEmbarqueOK
        {
            get { return m_itemsfleteembarqueOK; }
            set
            {
                if (m_itemsfleteembarqueOK != value)
                {
                    m_itemsfleteembarqueOK = value;
                    OnPropertyChanged("ItemsFleteEmbarqueOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ItemsFlete.
        /// </summary>
        [DataMember]
        public String ItemsFleteEmbarqueMSGERROR
        {
            get { return m_itemsfleteembarqueMSGERROR; }
            set
            {
                if (m_itemsfleteembarqueMSGERROR != value)
                {
                    m_itemsfleteembarqueMSGERROR = value;
                    OnPropertyChanged("ItemsFleteEmbarqueMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: ItemsServicio.
        /// </summary>
        [DataMember]
        public Boolean ItemsServicioOK
        {
            get { return m_itemsservicioOK; }
            set
            {
                if (m_itemsservicioOK != value)
                {
                    m_itemsservicioOK = value;
                    OnPropertyChanged("ItemsServicioOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ItemsServicio.
        /// </summary>
        [DataMember]
        public String ItemsServicioMSGERROR
        {
            get { return m_itemsservicioMSGERROR; }
            set
            {
                if (m_itemsservicioMSGERROR != value)
                {
                    m_itemsservicioMSGERROR = value;
                    OnPropertyChanged("ItemsServicioMSGERROR");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de validación de: DDOV_NroBooking.
        /// </summary>
        [DataMember]
        public Boolean DDOV_NroBookingOK
        {
            get { return m_ddov_nrobookingOK; }
            set
            {
                if (m_ddov_nrobookingOK != value)
                {
                    m_ddov_nrobookingOK = value;
                    OnPropertyChanged("DDOV_NroBookingOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DDOV_NroBooking.
        /// </summary>
        [DataMember]
        public String DDOV_NroBookingMSGERROR
        {
            get { return m_ddov_nrobookingMSGERROR; }
            set
            {
                if (m_ddov_nrobookingMSGERROR != value)
                {
                    m_ddov_nrobookingMSGERROR = value;
                    OnPropertyChanged("DDOV_NroBookingMSGERROR");
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
        public Boolean Validar(ref Boolean _FleteNegativo)
        {
            try
            {
                Boolean _isCorrect = true;
                m_mensajeError = "";
                CCOT_NumeroOK = true;
                CCOT_NumeroMSGERROR = "";
                //if( CCOT_Numero == null)
                //{
                //   _isCorrect = false;
                //   CCOT_NumeroOK  = false;
                //   CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "Cotización/Orden de Venta");
                //   m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
                //}
                CCOT_TipoOK = true;
                CCOT_TipoMSGERROR = "";
                //if( CCOT_Tipo == null)
                //{
                //   _isCorrect = false;
                //   CCOT_TipoOK  = false;
                //   CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "Cotización/Orden de Venta");
                //   m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
                //}
                CCOT_NumDocOK = true;
                CCOT_NumDocMSGERROR = "";
                //if( String.IsNullOrEmpty(CCOT_NumDoc) )
                //{
                //   _isCorrect = false;
                //   CCOT_NumDocOK  = false;
                //   CCOT_NumDocMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_NumDoc", "Cotización/Orden de Venta");
                //   m_mensajeError += "* Debe ingresar el campo CCOT_NumDoc" + Environment.NewLine;
                //}
                CCOT_VersionOK = true;
                CCOT_VersionMSGERROR = "";
                if (CCOT_Version == null)
                {
                    _isCorrect = false;
                    CCOT_VersionOK = false;
                    CCOT_VersionMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Version", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo CCOT_Version" + Environment.NewLine;
                }

                CONS_TabESTOK = true;
                CONS_CodESTOK = true;
                CONS_TabESTMSGERROR = "";
                CONS_CodESTMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabEST) || String.IsNullOrEmpty(CONS_CodEST))
                {
                    _isCorrect = false;
                    CONS_TabESTOK = false;
                    CONS_CodESTOK = false;
                    CONS_TabESTMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Estado", "Cotización/Orden de Venta");
                    CONS_CodESTMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Estado", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Estado" + Environment.NewLine;
                }

                ENTC_CodClienteOK = true;
                ENTC_CodClienteMSGERROR = "";
                if (!ENTC_CodCliente.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodClienteOK = false;
                    ENTC_CodClienteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cliente", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Cliente" + Environment.NewLine;
                }

                CCOT_FecEmiOK = true;
                CCOT_FecEmiMSGERROR = "";
                if (!CCOT_FecEmi.HasValue)
                {
                    _isCorrect = false;
                    CCOT_FecEmiOK = false;
                    CCOT_FecEmiMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha Emisión", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Fecha Emisión" + Environment.NewLine;
                }

                CONS_TabRGMOK = true;
                CONS_CodRGMOK = true;
                CONS_TabRGMMSGERROR = "";
                CONS_CodRGMMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabRGM) || String.IsNullOrEmpty(CONS_CodRGM))
                {
                    _isCorrect = false;
                    CONS_TabRGMOK = false;
                    CONS_CodRGMOK = false;
                    CONS_TabRGMMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Régimen", "Cotización/Orden de Venta");
                    CONS_CodRGMMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Régimen", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Régimen" + Environment.NewLine;
                }

                CONS_TabViaOK = true;
                CONS_CodViaOK = true;
                CONS_TabViaMSGERROR = "";
                CONS_CodViaMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabVia) || String.IsNullOrEmpty(CONS_CodVia))
                {
                    _isCorrect = false;
                    CONS_TabViaOK = false;
                    CONS_CodViaOK = false;
                    CONS_TabViaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Vía", "Cotización/Orden de Venta");
                    CONS_CodViaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Vía", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Vía" + Environment.NewLine;
                }

                CCOT_FecVctoOK = true;
                CCOT_FecVctoMSGERROR = "";
                if (!CCOT_FecVcto.HasValue)
                {
                    _isCorrect = false;
                    CCOT_FecVctoOK = false;
                    CCOT_FecVctoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha Vencimiento", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Fecha Vencimiento" + Environment.NewLine;
                }

                ENTC_CodAgenteOK = true;
                ENTC_CodAgenteMSGERROR = "";
                if (!ENTC_CodAgente.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodAgenteOK = false;
                    ENTC_CodAgenteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Agente", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Agente" + Environment.NewLine;
                }

                ENTC_CodEjecutivoOK = true;
                ENTC_CodEjecutivoMSGERROR = "";
                if (!ENTC_CodEjecutivo.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodEjecutivoOK = false;
                    ENTC_CodEjecutivoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Ejecutivo", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Ejecutivo" + Environment.NewLine;
                }
                ENTC_CodCustomerOK = true;
                ENTC_CodCustomerMSGERROR = "";
                if (!ENTC_CodCustomer.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodCustomerOK = false;
                    ENTC_CodCustomerMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Customer", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Customer" + Environment.NewLine;
                }

                PUER_CodOrigenOK = true;
                PUER_CodOrigenMSGERROR = "";
                if (!PUER_CodOrigen.HasValue)
                {
                    _isCorrect = false;
                    PUER_CodOrigenOK = false;
                    PUER_CodOrigenMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Puerto Origen", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Puerto Origen" + Environment.NewLine;
                }

                PUER_CodDestinoOK = true;
                PUER_CodDestinoMSGERROR = "";
                if (!PUER_CodDestino.HasValue)
                {
                    _isCorrect = false;
                    PUER_CodDestinoOK = false;
                    PUER_CodDestinoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Puerto Destino", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Puerto Destino" + Environment.NewLine;
                }

                TIPO_TabMNDOK = true;
                TIPO_CodMNDOK = true;
                TIPO_TabMNDMSGERROR = "";
                TIPO_CodMNDMSGERROR = "";
                if (String.IsNullOrEmpty(TIPO_TabMND) || String.IsNullOrEmpty(TIPO_CodMND))
                {
                    _isCorrect = false;
                    TIPO_TabMNDOK = false;
                    TIPO_CodMNDOK = false;
                    TIPO_TabMNDMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Moneda", "Cotización/Orden de Venta");
                    TIPO_CodMNDMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Moneda", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Moneda" + Environment.NewLine;
                }

                CONS_TabFLEOK = true;
                CONS_CodFLEOK = true;
                CONS_TabFLEMSGERROR = "";
                CONS_CodFLEMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabFLE) || String.IsNullOrEmpty(CONS_CodFLE))
                {
                    _isCorrect = false;
                    CONS_TabFLEOK = false;
                    CONS_CodFLEOK = false;
                    CONS_TabFLEMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Condición", "Cotización/Orden de Venta");
                    CONS_CodFLEMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Condición", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Condición" + Environment.NewLine;
                }

                CCOT_PagoMBLOK = true;
                CCOT_PagoMBLMSGERROR = "";
                if (String.IsNullOrEmpty(CCOT_PagoMBL))
                {
                    _isCorrect = false;
                    CCOT_PagoMBLOK = false;
                    CCOT_PagoMBLMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "P/C (MBL)", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo P/C (MBL)" + Environment.NewLine;
                }

                CCOT_PagoHBLOK = true;
                CCOT_PagoHBLMSGERROR = "";
                if (String.IsNullOrEmpty(CCOT_PagoHBL))
                {
                    _isCorrect = false;
                    CCOT_PagoHBLOK = false;
                    CCOT_PagoHBLMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "P/C (HBL)", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo P/C (HBL)" + Environment.NewLine;
                }

                NVIA_CodigoOK = true;
                NVIA_CodigoMSGERROR = "";
                //if (!NVIA_Codigo.HasValue)
                //{
                //   _isCorrect = false;
                //   NVIA_CodigoOK = false;
                //   NVIA_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "NVIA_Codigo", "NaveViaje");
                //   m_mensajeError += "* Debe ingresar el campo NVIA_Codigo" + Environment.NewLine;
                //}

                ItemsFleteOK = true;
                ItemsFleteMSGERROR = "";
                foreach (Det_Cotizacion_OV_Flete _itemFlete in ItemsFlete)
                {
                    if (!String.IsNullOrEmpty(CCOT_PagoMBL) && !String.IsNullOrEmpty(CCOT_PagoHBL))
                    {
                        if (!_itemFlete.ValidarFlete(ref _FleteNegativo, CCOT_Tipo, CONS_CodFLE, CONS_CodRGM, CCOT_PagoMBL, CCOT_PagoHBL))
                        {
                            ItemsFleteMSGERROR += "Item: " + _itemFlete.DCOT_Item.ToString() + Environment.NewLine + _itemFlete.MensajeError + Environment.NewLine;
                            ItemsFleteOK = false;
                            _isCorrect = false;
                        }
                    }
                }
                if (!ItemsFleteOK)
                {
                    m_mensajeError += "La Grilla de Flete contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsFleteMSGERROR + Environment.NewLine;
                }



                ItemsFleteEmbarqueOK = true;
                ItemsFleteEmbarqueMSGERROR = "";
                foreach (Det_Cotizacion_OV_Flete _itemFlete in ItemsFlete)
                {
                    if (!_itemFlete.ValidarEmbarque())
                    {
                        ItemsFleteEmbarqueMSGERROR += "Item: " + _itemFlete.DCOT_Item.ToString() + Environment.NewLine + _itemFlete.MensajeError + Environment.NewLine;
                        ItemsFleteEmbarqueOK = false;
                        _isCorrect = false;
                    }
                }

                if (!ItemsFleteEmbarqueOK)
                {
                    m_mensajeError += "La Grilla de Flete Datos de Embarque contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsFleteEmbarqueMSGERROR + Environment.NewLine;
                }

                ItemsServicioOK = true;
                ItemsServicioMSGERROR = "";
                foreach (Det_Cotizacion_OV_Servicio _itemServicio in ItemsServicio)
                {
                    if (!_itemServicio.Validar())
                    {
                        ItemsServicioMSGERROR += "Item: " + _itemServicio.SCOT_Item.ToString() + Environment.NewLine + _itemServicio.MensajeError + Environment.NewLine;
                        ItemsServicioOK = false;
                        _isCorrect = false;
                    }
                }

                if (!ItemsServicioOK)
                {
                    m_mensajeError += "La Grilla de Servicios contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsServicioMSGERROR + Environment.NewLine;
                }

                DOOV_CntrOK = true;
                DOOV_CntrMSGERROR = "";
                //if (String.IsNullOrEmpty(DOOV_Cntr))
                //{
                //   _isCorrect = false;
                //   DOOV_Cntr"OK = false;
                //   DOOV_Cntr"MSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DOOV_Cntr", "Det_Cotizacion_OV_Documento");
                //   m_mensajeError += "* Debe ingresar el campo DOOV_Cntr" + Environment.NewLine;
                //}

                if (CCOT_CargaPeligrosa)
                {
                    TIPO_CodImoOK = true;
                    TIPO_CodImoMSGERROR = "";
                    if (String.IsNullOrEmpty(TIPO_CodImo))
                    {
                        _isCorrect = false;
                        TIPO_CodImoOK = false;
                        TIPO_CodImoMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "IMO Class", "Cotización/Orden de Venta");
                        m_mensajeError += "* Debe seleccionar el IMO Class" + Environment.NewLine;
                    }

                    CCOT_ImoUNOK = true;
                    CCOT_ImoUNMSGERROR = "";
                    if (String.IsNullOrEmpty(CCOT_ImoUN))
                    {
                        _isCorrect = false;
                        CCOT_ImoUNOK = false;
                        CCOT_ImoUNMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "IMO UN", "Cotización/Orden de Venta");
                        m_mensajeError += "* Debe seleccionar el IMO UN" + Environment.NewLine;
                    }


                }



                OnPropertyChanged("MensajeError");
                return _isCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean ValidarFechaTarifa()
        {
            try
            {
                Boolean _isCorrect = true;
                m_mensajeError = "";

                CCOT_FecTarifaOK = true;
                CCOT_FecTarifaMSGERROR = "";
                if (!CCOT_FecTarifa.HasValue)
                {
                    _isCorrect = false;
                    CCOT_FecTarifaOK = false;
                    CCOT_FecTarifaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha Tarifa", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Fecha Tarifa" + Environment.NewLine;
                }
                return _isCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Boolean ValidarVigenciaContrato()
        {
            try
            {
                Boolean _isCorrect = true;
                m_mensajeError = "";


                if (CCOT_FecTarifa.HasValue)
                {
                    if (ItemContrato != null && ItemContrato.CONT_FecIni.HasValue && ItemContrato.CONT_FecFin.HasValue)
                    {
                        if (!(ItemContrato.CONT_FecIni.Value >= CCOT_FecTarifa.Value && CCOT_FecTarifa <= ItemContrato.CONT_FecFin.Value))
                        {
                            _isCorrect = false;
                            CCOT_FecTarifaOK = false;
                            CCOT_FecTarifaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha Tarifa", "Cotización/Orden de Venta");
                            m_mensajeError += "* La Fecha Tarifa no se encuentra dentro del rango del Contrato (Incio: " + ItemContrato.CONT_FecIni.Value.ToShortDateString() + " Fin: " + ItemContrato.CONT_FecFin.Value.ToShortDateString() + ")" + Environment.NewLine;
                        }
                    }
                }
                return _isCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Validacion Servicios ]
        public Boolean ValidarOtrosTraficos()
        {
            try
            {
                Boolean _isCorrect = true;

                ItemsServicioOK = true;
                ItemsServicioMSGERROR = "";
                foreach (Det_Cotizacion_OV_Servicio _itemServicio in ItemsServicio)
                {
                    if (_itemServicio.CCOT_IngresoGasto == "E")
                    {
                        if (!_itemServicio.Validar())
                        {
                            ItemsServicioMSGERROR += "Item: " + _itemServicio.SCOT_Item.ToString() + Environment.NewLine + _itemServicio.MensajeError + Environment.NewLine;
                            ItemsServicioOK = false;
                            _isCorrect = false;
                        }
                    }
                }

                return _isCorrect;
            }
            catch (Exception) { throw; }
        }
        #endregion

        #region [ Validacion Operaciones ]

        #region [ Variables ]
        private Boolean m_itemsServicioChangeControlOK;
        private String m_itemsServicioChangeControlMSGERROR;

        private Boolean m_itemsDet_CNTROK;
        private String m_itemsDet_CNTRMSGERROR;
        #endregion

        #region [ Propiedades ]
        /// <summary>
        /// Gets or sets el valor de validación de: ItemsServicio.
        /// </summary>
        [DataMember]
        public Boolean ItemsServicioChangeControlOK
        {
            get { return m_itemsServicioChangeControlOK; }
            set
            {
                if (m_itemsServicioChangeControlOK != value)
                {
                    m_itemsServicioChangeControlOK = value;
                    OnPropertyChanged("ItemsServicioChangeControlOK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ItemsServicio.
        /// </summary>
        [DataMember]
        public String ItemsServicioChangeControlMSGERROR
        {
            get { return m_itemsServicioChangeControlMSGERROR; }
            set
            {
                if (m_itemsServicioChangeControlMSGERROR != value)
                {
                    m_itemsServicioChangeControlMSGERROR = value;
                    OnPropertyChanged("ItemsServicioChangeControlMSGERROR");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de validación de: ItemsServicio.
        /// </summary>
        [DataMember]
        public Boolean ItemsDet_CNTROK
        {
            get { return m_itemsDet_CNTROK; }
            set
            {
                if (m_itemsDet_CNTROK != value)
                {
                    m_itemsDet_CNTROK = value;
                    OnPropertyChanged("ItemsDet_CNTROK");
                }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: ItemsServicio.
        /// </summary>
        [DataMember]
        public String ItemsDet_CNTRMSGERROR
        {
            get { return m_itemsDet_CNTRMSGERROR; }
            set
            {
                if (m_itemsDet_CNTRMSGERROR != value)
                {
                    m_itemsDet_CNTRMSGERROR = value;
                    OnPropertyChanged("ItemsDet_CNTRMSGERROR");
                }
            }
        }
        #endregion

        public Boolean ValidarOperaciones(ref Boolean _FleteNegativo, Boolean ValidaContenedores = true, Boolean x_Documentada = false)
        {
            try
            {
                Boolean _isCorrect = true;
                m_mensajeError = "";
                CCOT_NumeroOK = true;
                CCOT_NumeroMSGERROR = "";
                //if( CCOT_Numero == null)
                //{
                //   _isCorrect = false;
                //   CCOT_NumeroOK  = false;
                //   CCOT_NumeroMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Numero", "Cotización/Orden de Venta");
                //   m_mensajeError += "* Debe ingresar el campo CCOT_Numero" + Environment.NewLine;
                //}
                CCOT_TipoOK = true;
                CCOT_TipoMSGERROR = "";
                //if( CCOT_Tipo == null)
                //{
                //   _isCorrect = false;
                //   CCOT_TipoOK  = false;
                //   CCOT_TipoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Tipo", "Cotización/Orden de Venta");
                //   m_mensajeError += "* Debe ingresar el campo CCOT_Tipo" + Environment.NewLine;
                //}
                CCOT_NumDocOK = true;
                CCOT_NumDocMSGERROR = "";
                //if( String.IsNullOrEmpty(CCOT_NumDoc) )
                //{
                //   _isCorrect = false;
                //   CCOT_NumDocOK  = false;
                //   CCOT_NumDocMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_NumDoc", "Cotización/Orden de Venta");
                //   m_mensajeError += "* Debe ingresar el campo CCOT_NumDoc" + Environment.NewLine;
                //}
                CCOT_VersionOK = true;
                CCOT_VersionMSGERROR = "";
                if (CCOT_Version == null)
                {
                    _isCorrect = false;
                    CCOT_VersionOK = false;
                    CCOT_VersionMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "CCOT_Version", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo CCOT_Version" + Environment.NewLine;
                }

                CONS_TabESTOK = true;
                CONS_CodESTOK = true;
                CONS_TabESTMSGERROR = "";
                CONS_CodESTMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabEST) || String.IsNullOrEmpty(CONS_CodEST))
                {
                    _isCorrect = false;
                    CONS_TabESTOK = false;
                    CONS_CodESTOK = false;
                    CONS_TabESTMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Estado", "Cotización/Orden de Venta");
                    CONS_CodESTMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Estado", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Estado" + Environment.NewLine;
                }

                ENTC_CodClienteOK = true;
                ENTC_CodClienteMSGERROR = "";
                if (!ENTC_CodCliente.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodClienteOK = false;
                    ENTC_CodClienteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Cliente", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Cliente" + Environment.NewLine;
                }

                CCOT_FecEmiOK = true;
                CCOT_FecEmiMSGERROR = "";
                if (!CCOT_FecEmi.HasValue)
                {
                    _isCorrect = false;
                    CCOT_FecEmiOK = false;
                    CCOT_FecEmiMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha Emisión", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Fecha Emisión" + Environment.NewLine;
                }

                CONS_TabRGMOK = true;
                CONS_CodRGMOK = true;
                CONS_TabRGMMSGERROR = "";
                CONS_CodRGMMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabRGM) || String.IsNullOrEmpty(CONS_CodRGM))
                {
                    _isCorrect = false;
                    CONS_TabRGMOK = false;
                    CONS_CodRGMOK = false;
                    CONS_TabRGMMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Régimen", "Cotización/Orden de Venta");
                    CONS_CodRGMMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Régimen", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Régimen" + Environment.NewLine;
                }

                CONS_TabViaOK = true;
                CONS_CodViaOK = true;
                CONS_TabViaMSGERROR = "";
                CONS_CodViaMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabVia) || String.IsNullOrEmpty(CONS_CodVia))
                {
                    _isCorrect = false;
                    CONS_TabViaOK = false;
                    CONS_CodViaOK = false;
                    CONS_TabViaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Vía", "Cotización/Orden de Venta");
                    CONS_CodViaMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Vía", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Vía" + Environment.NewLine;
                }

                CCOT_FecVctoOK = true;
                CCOT_FecVctoMSGERROR = "";
                if (!CCOT_FecVcto.HasValue)
                {
                    _isCorrect = false;
                    CCOT_FecVctoOK = false;
                    CCOT_FecVctoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Fecha Vencimiento", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Fecha Vencimiento" + Environment.NewLine;
                }

                ENTC_CodAgenteOK = true;
                ENTC_CodAgenteMSGERROR = "";
                if (!ENTC_CodAgente.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodAgenteOK = false;
                    ENTC_CodAgenteMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Agente", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Agente" + Environment.NewLine;
                }

                ENTC_CodEjecutivoOK = true;
                ENTC_CodEjecutivoMSGERROR = "";
                if (!ENTC_CodEjecutivo.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodEjecutivoOK = false;
                    ENTC_CodEjecutivoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Ejecutivo", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Ejecutivo" + Environment.NewLine;
                }
                ENTC_CodCustomerOK = true;
                ENTC_CodCustomerMSGERROR = "";
                if (!ENTC_CodCustomer.HasValue)
                {
                    _isCorrect = false;
                    ENTC_CodCustomerOK = false;
                    ENTC_CodCustomerMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Customer", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Customer" + Environment.NewLine;
                }

                PUER_CodOrigenOK = true;
                PUER_CodOrigenMSGERROR = "";
                if (!PUER_CodOrigen.HasValue)
                {
                    _isCorrect = false;
                    PUER_CodOrigenOK = false;
                    PUER_CodOrigenMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Puerto Origen", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Puerto Origen" + Environment.NewLine;
                }

                PUER_CodDestinoOK = true;
                PUER_CodDestinoMSGERROR = "";
                if (!PUER_CodDestino.HasValue)
                {
                    _isCorrect = false;
                    PUER_CodDestinoOK = false;
                    PUER_CodDestinoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Puerto Destino", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Puerto Destino" + Environment.NewLine;
                }

                TIPO_TabMNDOK = true;
                TIPO_CodMNDOK = true;
                TIPO_TabMNDMSGERROR = "";
                TIPO_CodMNDMSGERROR = "";
                if (String.IsNullOrEmpty(TIPO_TabMND) || String.IsNullOrEmpty(TIPO_CodMND))
                {
                    _isCorrect = false;
                    TIPO_TabMNDOK = false;
                    TIPO_CodMNDOK = false;
                    TIPO_TabMNDMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Moneda", "Cotización/Orden de Venta");
                    TIPO_CodMNDMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Moneda", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Moneda" + Environment.NewLine;
                }

                CONS_TabFLEOK = true;
                CONS_CodFLEOK = true;
                CONS_TabFLEMSGERROR = "";
                CONS_CodFLEMSGERROR = "";
                if (String.IsNullOrEmpty(CONS_TabFLE) || String.IsNullOrEmpty(CONS_CodFLE))
                {
                    _isCorrect = false;
                    CONS_TabFLEOK = false;
                    CONS_CodFLEOK = false;
                    CONS_TabFLEMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Condición", "Cotización/Orden de Venta");
                    CONS_CodFLEMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Condición", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo Condición" + Environment.NewLine;
                }

                CCOT_PagoMBLOK = true;
                CCOT_PagoMBLMSGERROR = "";
                if (String.IsNullOrEmpty(CCOT_PagoMBL))
                {
                    _isCorrect = false;
                    CCOT_PagoMBLOK = false;
                    CCOT_PagoMBLMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "P/C (MBL)", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo P/C (MBL)" + Environment.NewLine;
                }

                CCOT_PagoHBLOK = true;
                CCOT_PagoHBLMSGERROR = "";
                if (String.IsNullOrEmpty(CCOT_PagoHBL))
                {
                    _isCorrect = false;
                    CCOT_PagoHBLOK = false;
                    CCOT_PagoHBLMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "P/C (HBL)", "Cotización/Orden de Venta");
                    m_mensajeError += "* Debe ingresar el campo P/C (HBL)" + Environment.NewLine;
                }

                NVIA_CodigoOK = true;
                NVIA_CodigoMSGERROR = "";
                //if (!NVIA_Codigo.HasValue)
                //{
                //   _isCorrect = false;
                //   NVIA_CodigoOK = false;
                //   NVIA_CodigoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "NVIA_Codigo", "NaveViaje");
                //   m_mensajeError += "* Debe ingresar el campo NVIA_Codigo" + Environment.NewLine;
                //}

                ItemsFleteOK = true;
                ItemsFleteMSGERROR = "";
                foreach (Det_Cotizacion_OV_Flete _itemFlete in ItemsFlete)
                {
                    if (!_itemFlete.ValidarFlete(ref _FleteNegativo, CCOT_Tipo, CONS_CodFLE, CONS_CodRGM, CCOT_PagoMBL, CCOT_PagoHBL))
                    {
                        ItemsFleteMSGERROR += "Item: " + _itemFlete.DCOT_Item.ToString() + Environment.NewLine + _itemFlete.MensajeError + Environment.NewLine;
                        ItemsFleteOK = false;
                        _isCorrect = false;
                    }
                }
                if (!ItemsFleteOK)
                {
                    m_mensajeError += "La Grilla de Flete contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsFleteMSGERROR + Environment.NewLine;
                }

                ItemsFleteEmbarqueOK = true;
                ItemsFleteEmbarqueMSGERROR = "";
                foreach (Det_Cotizacion_OV_Flete _itemFlete in ItemsFlete)
                {
                    if (!_itemFlete.ValidarEmbarque())
                    {
                        ItemsFleteEmbarqueMSGERROR += "Item: " + _itemFlete.DCOT_Item.ToString() + Environment.NewLine + _itemFlete.MensajeError + Environment.NewLine;
                        ItemsFleteEmbarqueOK = false;
                        _isCorrect = false;
                    }
                }
                if (!ItemsFleteEmbarqueOK)
                {
                    m_mensajeError += "La Grilla de Flete contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsFleteEmbarqueMSGERROR + Environment.NewLine;
                }

                ItemsServicioOK = true;
                ItemsServicioMSGERROR = "";
                foreach (Det_Cotizacion_OV_Servicio _itemServicio in ItemsServicio)
                {
                    if (!_itemServicio.Validar())
                    {
                        ItemsServicioMSGERROR += "Item: " + _itemServicio.SCOT_Item.ToString() + Environment.NewLine + _itemServicio.MensajeError + Environment.NewLine;
                        ItemsServicioOK = false;
                        _isCorrect = false;
                    }
                }
                if (!ItemsServicioOK)
                {
                    m_mensajeError += "La Grilla de Servicios contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsServicioMSGERROR + Environment.NewLine;
                }

                ItemsServicioChangeControlOK = true;
                ItemsServicioChangeControlMSGERROR = "";
                foreach (Det_Cotizacion_OV_Servicio _itemServicioChangeControl in ItemsServicioChangeControl)
                {
                    if (!_itemServicioChangeControl.Validar())
                    {
                        ItemsServicioChangeControlMSGERROR += "Item: " + _itemServicioChangeControl.SCOT_Item.ToString() + Environment.NewLine + _itemServicioChangeControl.MensajeError + Environment.NewLine;
                        ItemsServicioChangeControlOK = false;
                        _isCorrect = false;
                    }
                }
                if (!ItemsServicioChangeControlOK)
                {
                    m_mensajeError += "La Grilla de Servicios Change Control contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsServicioChangeControlMSGERROR + Environment.NewLine;
                }

                ItemsDet_CNTROK = true;
                ItemsDet_CNTRMSGERROR = "";
                foreach (Det_CNTR _itemDet_CNTR in ItemsDet_CNTR)
                {
                    //FLE	002	LCL/FCL
                    //FLE	004	FCL/FCL
                    Boolean _validarFCL = (CONS_CodFLE == "002" || CONS_CodFLE == "004");
                    Boolean _validarMarcas = (CONS_CodVia != "002");
                    Boolean _documentado = x_Documentada;
                    if (!_itemDet_CNTR.Validar(_validarFCL, _validarMarcas, x_Documentada))
                    {
                        ItemsDet_CNTRMSGERROR += "  Item: " + _itemDet_CNTR.DHBL_Item.ToString() + Environment.NewLine + _itemDet_CNTR.MensajeError + Environment.NewLine;
                        ItemsDet_CNTROK = false;
                        _isCorrect = false;
                    }
                }
                if (!ItemsDet_CNTROK)
                {
                    m_mensajeError += "* La Grilla de Contenedores contiene los siguientes errores: " + Environment.NewLine;
                    m_mensajeError += ItemsDet_CNTRMSGERROR + Environment.NewLine;
                }

                DOOV_CntrOK = true;
                DOOV_CntrMSGERROR = "";
                //if (String.IsNullOrEmpty("Cotización/Orden de Venta"))
                //{
                //   _isCorrect = false;
                //   DOOV_CntrOK = false;
                //   DOOV_CntrMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "DOOV_Cntr", "Det_Cotizacion_OV_Documento");
                //   m_mensajeError += "* Debe ingresar el campo DOOV_Cntr" + Environment.NewLine;
                //}

                if (CCOT_CargaPeligrosa)
                {
                    TIPO_CodImoOK = true;
                    TIPO_CodImoMSGERROR = "";
                    if (String.IsNullOrEmpty(TIPO_CodImo))
                    {
                        _isCorrect = false;
                        TIPO_CodImoOK = false;
                        TIPO_CodImoMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "IMO Class", "Cotización/Orden de Venta");
                        m_mensajeError += "* Debe seleccionar el IMO Class" + Environment.NewLine;
                    }

                    CCOT_ImoUNOK = true;
                    CCOT_ImoUNMSGERROR = "";
                    if (String.IsNullOrEmpty(CCOT_ImoUN.Trim()))
                    {
                        _isCorrect = false;
                        CCOT_ImoUNOK = false;
                        CCOT_ImoUNMSGERROR = String.Format("Debe seleccionar el {0} de la {1}.", "IMO UN", "Cotización/Orden de Venta");
                        m_mensajeError += "* Debe seleccionar el IMO UN" + Environment.NewLine;
                    }
                }


                //Documentar 
                if (x_Documentada)
                {
                    DOOV_HBLOK = true;
                    DOOV_HBLMSGERROR = "";
                    if (String.IsNullOrEmpty(DOOV_HBL))
                    {
                        _isCorrect = false;
                        DOOV_HBLOK = false;
                        DOOV_HBLMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "HBL", "Orden de Venta");
                        m_mensajeError += "* Debe ingresar el HBL de la Orden de Venta" + Environment.NewLine;
                    }
                    DOOV_MBLOK = true;
                    DOOV_MBLMSGERROR = "";
                    if (String.IsNullOrEmpty(DOOV_MBL))
                    {
                        _isCorrect = false;
                        DOOV_MBLOK = false;
                        DOOV_MBLMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "MBL", "Orden de Venta");
                        m_mensajeError += "* Debe ingresar el MBL de la Orden de Venta" + Environment.NewLine;
                    }
                    if (DDOV_HBLNieto)
                    {
                        DOOV_NumeroBLNietoOK = true;
                        DOOV_NumeroBLNietoMSGERROR = "";
                        if (String.IsNullOrEmpty(DOOV_NumeroBLNieto))
                        {
                            _isCorrect = false;
                            DOOV_NumeroBLNietoOK = false;
                            DOOV_NumeroBLNietoMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "BL Nieto", "Orden de Venta");
                            m_mensajeError += "* Debe ingresar el BL Nieto de la Orden de Venta" + Environment.NewLine;
                        }
                    }
                    if (CONS_TabRGM == "RGM" && CONS_CodRGM == "002")
                    {
                        DDOV_NroBookingOK = true;
                        DDOV_NroBookingMSGERROR = "";
                        if (String.IsNullOrEmpty(DDOV_NroBooking))
                        {
                            _isCorrect = false;
                            DDOV_NroBookingOK = false;
                            DDOV_NroBookingMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Nro Booking", "Orden de Venta");
                            m_mensajeError += "* Debe ingresar el Nro Booking de la Orden de Venta" + Environment.NewLine;
                        }
                    }
                }

                //VALIDAR QUE LOS TIPOS DE CONTENEDOR EN EL FLETE ESTEN EN LOS CONTENEDORES
                //VIA 001	MARÍTIMA
                //FLE 002	LCL/FCL
                //FLE 004	FCL/FCL
                if (CONS_CodVia == "001" && (CONS_CodFLE == "002" || CONS_CodFLE == "004") && ValidaContenedores)
                { ValidarContenedores(ref _isCorrect, ref m_mensajeError); }

                OnPropertyChanged("MensajeError");
                return _isCorrect;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean ValidarContenedores(ref Boolean _isCorrect, ref String x_mensajeError)
        {
            try
            {
                //Boolean _isCorrect = true;
                if (ItemsFlete != null && ItemsFlete.Count > 0)
                {
                    if (ItemsDet_CNTR != null && ItemsFlete.Count > 0)
                    {
                        foreach (Det_Cotizacion_OV_Flete _itemDet_Cotizacion_OV_Flete in ItemsFlete)
                        {
                            var _contenedores = ItemsDet_CNTR.Where(cntr => cntr.PACK_Codigo == _itemDet_Cotizacion_OV_Flete.PACK_Codigo).ToObservableCollection();
                            if (_contenedores != null)
                            {
                                if (_contenedores.Count() != _itemDet_Cotizacion_OV_Flete.DCOT_Cantidad)
                                {
                                    _isCorrect = false;
                                    x_mensajeError += String.Format("Se ha configurado los fletes para {0} contenedor(es) de {1} y se ha registrado {2} contenedor(es).", (Int32)_itemDet_Cotizacion_OV_Flete.DCOT_Cantidad, _itemDet_Cotizacion_OV_Flete.PACK_Desc, ItemsDet_CNTR.Where(cntr => cntr.PACK_Codigo == _itemDet_Cotizacion_OV_Flete.PACK_Codigo).Count());
                                }
                            }
                            else
                            {
                                _isCorrect = false;
                                x_mensajeError += String.Format("Se ha configurado los fletes para {0} contenedor(es) de {1} y no se han registrado contenedor(es).", ItemsFlete.Count, _itemDet_Cotizacion_OV_Flete.PACK_Desc);
                            }
                        }
                    }
                    else
                    {
                        _isCorrect = false;
                        x_mensajeError += String.Format("Se ha configurado los fletes para {0} contenedores y no se han registrado contenedores", ItemsFlete.Count);
                    }
                }

                if (ItemsDet_CNTR != null && ItemsFlete.Count > 0)
                {
                    foreach (Det_CNTR _itemDet_CNTR in ItemsDet_CNTR.Where(cntr => cntr.PACK_Codigo.HasValue))
                    {
                        var _fletes = ItemsFlete.Where(dcot => dcot.PACK_Codigo == _itemDet_CNTR.PACK_Codigo);
                        if (_fletes == null || _fletes.Count() == 0)
                        {
                            _isCorrect = false;
                            x_mensajeError += String.Format("Se ha configurado contenedor(es) de {0} y no se han configurado en el flete.", _itemDet_CNTR.PACK_Desc);
                        }
                    }
                }

                if (ItemsDet_CNTR.Where(cntr => !cntr.PACK_Codigo.HasValue).Count() > 0)
                {
                   _isCorrect = false;
                   x_mensajeError += String.Format("No se ha seleccionado el Tipo de Contenedor de {0} registros.", ItemsDet_CNTR.Where(cntr => !cntr.PACK_Codigo.HasValue).Count());
                }

                return _isCorrect;
            }
            catch (Exception)
            { return false; }
        }
        #endregion
    }
}
