using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Delfin.Entities
{
   public partial class Cab_Cotizacion_OV
   {
      #region [ Variables ]
      private String m_ccot_usrconfirma;
      private Nullable<DateTime> m_ccot_fecconfirma;
      private Nullable<DateTime> m_ccot_fecconcluye;
      private String m_ccot_usrconcluye;
      private Nullable<Decimal> m_ccot_profit;
      private Nullable<Decimal> m_ccot_teus;
      private Nullable<Decimal> m_ccot_profitprom;
      
      private Boolean m_ccot_emitirhbl;
      private Boolean m_ccot_sada;
      private Boolean m_ccot_enviaavisollegada;
      private Nullable<DateTime> m_ccot_fectrasbordo;
      private Boolean m_ccot_bloqueado;
      private Boolean m_ccot_serviciotransmision;
      private Nullable<Int32> m_entc_coddeptemporal;
      private Nullable<DateTime> m_doov_fecica;
        private Nullable<DateTime> m_ccot_fecemidoc;
        private Nullable<Int32> m_entc_codagentenieto;
      private Nullable<Int32> m_entc_codconsigneenieto;
      private Nullable<Int32> m_entc_codshippernieto;
      private Nullable<Int32> m_entc_codnotifynieto;
      private Nullable<DateTime> m_ddov_fecembarque;
      private Boolean m_ccot_deptemnegociaagente;
      private Nullable<Int32> m_entc_coddepvacio;
      private Nullable<Int16> m_tipe_coddepvacio;
      private String m_doov_numeroblnieto;
      private String m_cons_tablng;
      private String m_cons_codlng;
      private Nullable<DateTime> m_ccot_fecrecdocs;
      private Boolean m_ccot_conexcepcion;
      private Boolean m_ccot_vboperaciones;
      private Boolean m_ccot_vblogistico;
      private Boolean m_ccot_diferenciaflete;
      private Boolean m_ccot_diferenciafleterecup;
      private String m_ddov_nrobooking;
      private String m_ddov_descshipper;
      private String m_ddov_descconsignee;
      private String m_ddov_descnotify;
      private String m_ddov_descapplyto;
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: CCOT_UsrConfirma.
      /// </summary>
      [DataMember]
      public String CCOT_UsrConfirma
      {
         get { return m_ccot_usrconfirma; }
         set
         {
            if (m_ccot_usrconfirma != value)
            {
               m_ccot_usrconfirma = value;
               OnPropertyChanged("CCOT_UsrConfirma");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_FecConfirma.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCOT_FecConfirma
      {
         get { return m_ccot_fecconfirma; }
         set
         {
            if (m_ccot_fecconfirma != value)
            {
               m_ccot_fecconfirma = value;
               OnPropertyChanged("CCOT_FecConfirma");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_FecConcluye.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCOT_FecConcluye
      {
         get { return m_ccot_fecconcluye; }
         set
         {
            if (m_ccot_fecconcluye != value)
            {
               m_ccot_fecconcluye = value;
               OnPropertyChanged("CCOT_FecConcluye");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_UsrConcluye.
      /// </summary>
      [DataMember]
      public String CCOT_UsrConcluye
      {
         get { return m_ccot_usrconcluye; }
         set
         {
            if (m_ccot_usrconcluye != value)
            {
               m_ccot_usrconcluye = value;
               OnPropertyChanged("CCOT_UsrConcluye");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_Profit.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCOT_Profit
      {
         get { return m_ccot_profit; }
         set
         {
            if (m_ccot_profit != value)
            {
               m_ccot_profit = value;
               OnPropertyChanged("CCOT_Profit");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_TEUS.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCOT_TEUS
      {
         get { return m_ccot_teus; }
         set
         {
            if (m_ccot_teus != value)
            {
               m_ccot_teus = value;
               OnPropertyChanged("CCOT_TEUS");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_ProfitPRom.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCOT_ProfitPRom
      {
         get { return m_ccot_profitprom; }
         set
         {
            if (m_ccot_profitprom != value)
            {
               m_ccot_profitprom = value;
               OnPropertyChanged("CCOT_ProfitPRom");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: CCOT_EmitirHBL.
      /// </summary>
      [DataMember]
      public Boolean CCOT_EmitirHBL
      {
         get { return m_ccot_emitirhbl; }
         set
         {
            if (m_ccot_emitirhbl != value)
            {
               m_ccot_emitirhbl = value;
               OnPropertyChanged("CCOT_EmitirHBL");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_SADA.
      /// </summary>
      [DataMember]
      public Boolean CCOT_SADA
      {
         get { return m_ccot_sada; }
         set
         {
            if (m_ccot_sada != value)
            {
               m_ccot_sada = value;
               OnPropertyChanged("CCOT_SADA");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_EnviaAvisoLlegada.
      /// </summary>
      [DataMember]
      public Boolean CCOT_EnviaAvisoLlegada
      {
         get { return m_ccot_enviaavisollegada; }
         set
         {
            if (m_ccot_enviaavisollegada != value)
            {
               m_ccot_enviaavisollegada = value;
               OnPropertyChanged("CCOT_EnviaAvisoLlegada");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_FecTrasbordo.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCOT_FecTrasbordo
      {
         get { return m_ccot_fectrasbordo; }
         set
         {
            if (m_ccot_fectrasbordo != value)
            {
               m_ccot_fectrasbordo = value;
               OnPropertyChanged("CCOT_FecTrasbordo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_Bloqueado.
      /// </summary>
      [DataMember]
      public Boolean CCOT_Bloqueado
      {
         get { return m_ccot_bloqueado; }
         set
         {
            if (m_ccot_bloqueado != value)
            {
               m_ccot_bloqueado = value;
               OnPropertyChanged("CCOT_Bloqueado");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_ServioTransmision.
      /// </summary>
      [DataMember]
      public Boolean CCOT_ServicioTransmision
      {
         get { return m_ccot_serviciotransmision; }
         set
         {
            if (m_ccot_serviciotransmision != value)
            {
               m_ccot_serviciotransmision = value;
               OnPropertyChanged("CCOT_ServioTransmision");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodDepTemporal.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodDepTemporal
      {
         get { return m_entc_coddeptemporal; }
         set
         {
            if (m_entc_coddeptemporal != value)
            {
               m_entc_coddeptemporal = value;
               OnPropertyChanged("ENTC_CodDepTemporal");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_FecICA.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> DOOV_FecICA
      {
         get { return m_doov_fecica; }
         set
         {
            if (m_doov_fecica != value)
            {
               m_doov_fecica = value;
               OnPropertyChanged("DOOV_FecICA");
            }
         }
      }
        /// <summary>
        /// Gets or sets el valor de: DOOV_FecICA.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> CCOT_FecEmiDoc
        {
            get { return m_ccot_fecemidoc; }
            set
            {
                if (m_ccot_fecemidoc != value)
                {
                    m_ccot_fecemidoc = value;
                    OnPropertyChanged("CCOT_FecEmiDoc");
                }
            }
        }
        /// <summary>
        /// Gets or sets el valor de: ENTC_CodAgenteNieto.
        /// </summary>
        [DataMember]
      public Nullable<Int32> ENTC_CodAgenteNieto
      {
         get { return m_entc_codagentenieto; }
         set
         {
            if (m_entc_codagentenieto != value)
            {
               m_entc_codagentenieto = value;
               OnPropertyChanged("ENTC_CodAgenteNieto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodConsigneeNieto.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodConsigneeNieto
      {
         get { return m_entc_codconsigneenieto; }
         set
         {
            if (m_entc_codconsigneenieto != value)
            {
               m_entc_codconsigneenieto = value;
               OnPropertyChanged("ENTC_CodConsigneeNieto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodShipperNieto.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodShipperNieto
      {
         get { return m_entc_codshippernieto; }
         set
         {
            if (m_entc_codshippernieto != value)
            {
               m_entc_codshippernieto = value;
               OnPropertyChanged("ENTC_CodShipperNieto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodNotifyNieto.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodNotifyNieto
      {
         get { return m_entc_codnotifynieto; }
         set
         {
            if (m_entc_codnotifynieto != value)
            {
               m_entc_codnotifynieto = value;
               OnPropertyChanged("ENTC_CodNotifyNieto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DDOV_FecEmbarque.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> DDOV_FecEmbarque
      {
         get { return m_ddov_fecembarque; }
         set
         {
            if (m_ddov_fecembarque != value)
            {
               m_ddov_fecembarque = value;
               OnPropertyChanged("DDOV_FecEmbarque");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_DepTemNegociaAgente.
      /// </summary>
      [DataMember]
      public Boolean CCOT_DepTemNegociaAgente
      {
         get { return m_ccot_deptemnegociaagente; }
         set
         {
            if (m_ccot_deptemnegociaagente != value)
            {
               m_ccot_deptemnegociaagente = value;
               OnPropertyChanged("CCOT_DepTemNegociaAgente");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodDepVacio.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodDepVacio
      {
         get { return m_entc_coddepvacio; }
         set
         {
            if (m_entc_coddepvacio != value)
            {
               m_entc_coddepvacio = value;
               OnPropertyChanged("ENTC_CodDepVacio");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPE_CodDepVacio.
      /// </summary>
      [DataMember]
      public Nullable<Int16> TIPE_CodDepVacio
      {
         get { return m_tipe_coddepvacio; }
         set
         {
            if (m_tipe_coddepvacio != value)
            {
               m_tipe_coddepvacio = value;
               OnPropertyChanged("TIPE_CodDepVacio");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_NumeroBLNieto.
      /// </summary>
      [DataMember]
      public String DOOV_NumeroBLNieto
      {
         get { return m_doov_numeroblnieto; }
         set
         {
            if (m_doov_numeroblnieto != value)
            {
               m_doov_numeroblnieto = value;
               OnPropertyChanged("DOOV_NumeroBLNieto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CONS_TabLNG.
      /// </summary>
      [DataMember]
      public String CONS_TabLNG
      {
         get { return m_cons_tablng; }
         set
         {
            if (m_cons_tablng != value)
            {
               m_cons_tablng = value;
               OnPropertyChanged("CONS_TabLNG");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CONS_CodLNG.
      /// </summary>
      [DataMember]
      public String CONS_CodLNG
      {
         get { return m_cons_codlng; }
         set
         {
            if (m_cons_codlng != value)
            {
               m_cons_codlng = value;
               OnPropertyChanged("CONS_CodLNG");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_FecRecDocs.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCOT_FecRecDocs
      {
         get { return m_ccot_fecrecdocs; }
         set
         {
            if (m_ccot_fecrecdocs != value)
            {
               m_ccot_fecrecdocs = value;
               OnPropertyChanged("CCOT_FecRecDocs");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_ConExcepcion.
      /// </summary>
      [DataMember]
      public Boolean CCOT_ConExcepcion
      {
         get { return m_ccot_conexcepcion; }
         set
         {
            if (m_ccot_conexcepcion != value)
            {
               m_ccot_conexcepcion = value;
               OnPropertyChanged("CCOT_ConExcepcion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_VBOperaciones.
      /// </summary>
      [DataMember]
      public Boolean CCOT_VBOperaciones
      {
         get { return m_ccot_vboperaciones; }
         set
         {
            if (m_ccot_vboperaciones != value)
            {
               m_ccot_vboperaciones = value;
               OnPropertyChanged("CCOT_VBOperaciones");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_VBLogistico.
      /// </summary>
      [DataMember]
      public Boolean CCOT_VBLogistico
      {
         get { return m_ccot_vblogistico; }
         set
         {
            if (m_ccot_vblogistico != value)
            {
               m_ccot_vblogistico = value;
               OnPropertyChanged("CCOT_VBLogistico");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_DiferenciaFlete.
      /// </summary>
      [DataMember]
      public Boolean CCOT_DiferenciaFlete
      {
         get { return m_ccot_diferenciaflete; }
         set
         {
            if (m_ccot_diferenciaflete != value)
            {
               m_ccot_diferenciaflete = value;
               OnPropertyChanged("CCOT_DiferenciaFlete");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCOT_DiferenciaFleteRecup.
      /// </summary>
      [DataMember]
      public Boolean CCOT_DiferenciaFleteRecup
      {
         get { return m_ccot_diferenciafleterecup; }
         set
         {
            if (m_ccot_diferenciafleterecup != value)
            {
               m_ccot_diferenciafleterecup = value;
               OnPropertyChanged("CCOT_DiferenciaFleteRecup");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DDOV_NroBooking.
      /// </summary>
      [DataMember]
      public String DDOV_NroBooking
      {
         get { return m_ddov_nrobooking; }
         set {
            if (m_ddov_nrobooking != value)
            { 
               m_ddov_nrobooking = value;
               OnPropertyChanged("DDOV_NroBooking");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DDOV_DescShipper.
      /// </summary>
      [DataMember]
      public String DDOV_DescShipper
      {
         get { return m_ddov_descshipper; }
         set {
            if (m_ddov_descshipper != value)
            { 
               m_ddov_descshipper = value;
               OnPropertyChanged("DDOV_DescShipper");
            }

         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_DescConsignee.
      /// </summary>
      [DataMember]
      public String DDOV_DescConsignee
      {
         get { return m_ddov_descconsignee; }
         set
         {
            if (m_ddov_descconsignee != value)
            {
               m_ddov_descconsignee = value;
               OnPropertyChanged("DOOV_DescConsignee");
            }

         }
      }
      /// <summary>
      /// Gets or sets el valor de: DOOV_DescNotify.
      /// </summary>
      [DataMember]
      public String DDOV_DescNotify
      {
         get { return m_ddov_descnotify; }
         set
         {
            if (m_ddov_descnotify != value)
            {
               m_ddov_descnotify = value;
               OnPropertyChanged("DOOV_DescNotify");
            }

         }
      }
      /// <summary>
      /// Gets or sets el valor de: DDOV_DescApplyTo.
      /// </summary>
      [DataMember]
      public String DDOV_DescApplyTo
      {
         get { return m_ddov_descapplyto; }
         set
         {
            if (m_ddov_descapplyto != value)
            {
               m_ddov_descapplyto = value;
               OnPropertyChanged("DDOV_DescApplyTo");
            }

         }
      }
      #endregion

      #region [ Validacion ]
      #region [ Variables ]
      private Boolean m_ccot_emitirhblOK;
      private String m_ccot_emitirhblMSGERROR;
      private Boolean m_ccot_sadaOK;
      private String m_ccot_sadaMSGERROR;
      private Boolean m_ccot_enviaavisollegadaOK;
      private String m_ccot_enviaavisollegadaMSGERROR;
      private Boolean m_ccot_fectrasbordoOK;
      private String m_ccot_fectrasbordoMSGERROR;
      private Boolean m_ccot_bloqueadoOK;
      private String m_ccot_bloqueadoMSGERROR;
      private Boolean m_ccot_serviciotransmisionOK;
      private String m_ccot_serviciotransmisionMSGERROR;
      private Boolean m_entc_coddeptemporalOK;
      private String m_entc_coddeptemporalMSGERROR;
      private Boolean m_doov_fecicaOK;
      private String m_doov_fecicaMSGERROR;
        private Boolean m_ccot_fecemidocOK;
        private String m_ccot_fecemidocMSGERROR;
        private Boolean m_entc_codagentenietoOK;
      private String m_entc_codagentenietoMSGERROR;
      private Boolean m_entc_codconsigneenietoOK;
      private String m_entc_codconsigneenietoMSGERROR;
      private Boolean m_entc_codshippernietoOK;
      private String m_entc_codshippernietoMSGERROR;
      private Boolean m_entc_codnotifynietoOK;
      private String m_entc_codnotifynietoMSGERROR;
      private Boolean m_ddov_fecembarqueOK;
      private String m_ddov_fecembarqueMSGERROR;
      private Boolean m_ccot_deptemnegociaagenteOK;
      private String m_ccot_deptemnegociaagenteMSGERROR;
      private Boolean m_entc_coddepvacioOK;
      private String m_entc_coddepvacioMSGERROR;
      private Boolean m_tipe_coddepvacioOK;
      private String m_tipe_coddepvacioMSGERROR;
      private Boolean m_doov_numeroblnietoOK;
      private String m_doov_numeroblnietoMSGERROR;
      private Boolean m_cons_tablngOK;
      private String m_cons_tablngMSGERROR;
      private Boolean m_cons_codlngOK;
      private String m_cons_codlngMSGERROR;
      private Boolean m_ccot_fecrecepciondocumentosOK;
      private String m_ccot_fecrecepciondocumentosMSGERROR;
      private Boolean m_ccot_conexcepcionOK;
      private String m_ccot_conexcepcionMSGERROR;
      private Boolean m_ccot_vboperacionesOK;
      private String m_ccot_vboperacionesMSGERROR;
      private Boolean m_ccot_vblogisticoOK;
      private String m_ccot_vblogisticoMSGERROR;
      private Boolean m_ccot_diferenciafleteOK;
      private String m_ccot_diferenciafleteMSGERROR;
      private Boolean m_ccot_diferenciafleterecupOK;
      private String m_ccot_diferenciafleterecupMSGERROR;
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_EmitirHBL.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_EmitirHBLOK
      {
         get { return m_ccot_emitirhblOK; }
         set
         {
            if (m_ccot_emitirhblOK != value)
            { m_ccot_emitirhblOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_EmitirHBL.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_EmitirHBLMSGERROR
      {
         get { return m_ccot_emitirhblMSGERROR; }
         set
         {
            if (m_ccot_emitirhblMSGERROR != value)
            { m_ccot_emitirhblMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_SADA.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_SADAOK
      {
         get { return m_ccot_sadaOK; }
         set
         {
            if (m_ccot_sadaOK != value)
            { m_ccot_sadaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_SADA.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_SADAMSGERROR
      {
         get { return m_ccot_sadaMSGERROR; }
         set
         {
            if (m_ccot_sadaMSGERROR != value)
            { m_ccot_sadaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_EnviaAvisoLlegada.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_EnviaAvisoLlegadaOK
      {
         get { return m_ccot_enviaavisollegadaOK; }
         set
         {
            if (m_ccot_enviaavisollegadaOK != value)
            { m_ccot_enviaavisollegadaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_EnviaAvisoLlegada.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_EnviaAvisoLlegadaMSGERROR
      {
         get { return m_ccot_enviaavisollegadaMSGERROR; }
         set
         {
            if (m_ccot_enviaavisollegadaMSGERROR != value)
            { m_ccot_enviaavisollegadaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_FecTrasbordo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_FecTrasbordoOK
      {
         get { return m_ccot_fectrasbordoOK; }
         set
         {
            if (m_ccot_fectrasbordoOK != value)
            { m_ccot_fectrasbordoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_FecTrasbordo.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_FecTrasbordoMSGERROR
      {
         get { return m_ccot_fectrasbordoMSGERROR; }
         set
         {
            if (m_ccot_fectrasbordoMSGERROR != value)
            { m_ccot_fectrasbordoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_Bloqueado.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_BloqueadoOK
      {
         get { return m_ccot_bloqueadoOK; }
         set
         {
            if (m_ccot_bloqueadoOK != value)
            { m_ccot_bloqueadoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_Bloqueado.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_BloqueadoMSGERROR
      {
         get { return m_ccot_bloqueadoMSGERROR; }
         set
         {
            if (m_ccot_bloqueadoMSGERROR != value)
            { m_ccot_bloqueadoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_ServioTransmision.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_ServicioTransmisionOK
      {
         get { return m_ccot_serviciotransmisionOK; }
         set
         {
            if (m_ccot_serviciotransmisionOK != value)
            { m_ccot_serviciotransmisionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_ServioTransmision.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_ServicioTransmisionMSGERROR
      {
         get { return m_ccot_serviciotransmisionMSGERROR; }
         set
         {
            if (m_ccot_serviciotransmisionMSGERROR != value)
            { m_ccot_serviciotransmisionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_CodDepTemporal.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENTC_CodDepTemporalOK
      {
         get { return m_entc_coddeptemporalOK; }
         set
         {
            if (m_entc_coddeptemporalOK != value)
            { m_entc_coddeptemporalOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_CodDepTemporal.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodDepTemporalMSGERROR
      {
         get { return m_entc_coddeptemporalMSGERROR; }
         set
         {
            if (m_entc_coddeptemporalMSGERROR != value)
            { m_entc_coddeptemporalMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: DOOV_FecICA.
      /// </summary>
      [IgnoreDataMember]
      public Boolean DOOV_FecICAOK
      {
         get { return m_doov_fecicaOK; }
         set
         {
            if (m_doov_fecicaOK != value)
            { m_doov_fecicaOK = value; }
         }
      }
        /// <summary>
        /// Gets or sets el valor de validación de: DOOV_FecICA.
        /// </summary>
        [IgnoreDataMember]
        public Boolean CCOT_FecEmiDocOK
        {
            get { return m_ccot_fecemidocOK; }
            set
            {
                if (m_ccot_fecemidocOK != value)
                { m_ccot_fecemidocOK = value; }
            }
        }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DOOV_FecICA.
        /// </summary>
        [IgnoreDataMember]
      public String DOOV_FecICAMSGERROR
      {
         get { return m_doov_fecicaMSGERROR; }
         set
         {
            if (m_doov_fecicaMSGERROR != value)
            { m_doov_fecicaMSGERROR = value; }
         }
      }
        /// <summary>
        /// Gets or sets el mensaje de validación de: DOOV_FecICA.
        /// </summary>
        [IgnoreDataMember]
        public String CCOT_FecEmiDocMSGERROR
        {
            get { return m_ccot_fecemidocMSGERROR; }
            set
            {
                if (m_ccot_fecemidocMSGERROR != value)
                { m_ccot_fecemidocMSGERROR = value; }
            }
        }

        /// <summary>
        /// Gets or sets el valor de validación de: ENTC_CodAgenteNieto.
        /// </summary>
        [IgnoreDataMember]
      public Boolean ENTC_CodAgenteNietoOK
      {
         get { return m_entc_codagentenietoOK; }
         set
         {
            if (m_entc_codagentenietoOK != value)
            { m_entc_codagentenietoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_CodAgenteNieto.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodAgenteNietoMSGERROR
      {
         get { return m_entc_codagentenietoMSGERROR; }
         set
         {
            if (m_entc_codagentenietoMSGERROR != value)
            { m_entc_codagentenietoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_CodConsigneeNieto.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENTC_CodConsigneeNietoOK
      {
         get { return m_entc_codconsigneenietoOK; }
         set
         {
            if (m_entc_codconsigneenietoOK != value)
            { m_entc_codconsigneenietoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_CodConsigneeNieto.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodConsigneeNietoMSGERROR
      {
         get { return m_entc_codconsigneenietoMSGERROR; }
         set
         {
            if (m_entc_codconsigneenietoMSGERROR != value)
            { m_entc_codconsigneenietoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_CodShipperNieto.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENTC_CodShipperNietoOK
      {
         get { return m_entc_codshippernietoOK; }
         set
         {
            if (m_entc_codshippernietoOK != value)
            { m_entc_codshippernietoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_CodShipperNieto.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodShipperNietoMSGERROR
      {
         get { return m_entc_codshippernietoMSGERROR; }
         set
         {
            if (m_entc_codshippernietoMSGERROR != value)
            { m_entc_codshippernietoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_CodNotifyNieto.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENTC_CodNotifyNietoOK
      {
         get { return m_entc_codnotifynietoOK; }
         set
         {
            if (m_entc_codnotifynietoOK != value)
            { m_entc_codnotifynietoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_CodNotifyNieto.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodNotifyNietoMSGERROR
      {
         get { return m_entc_codnotifynietoMSGERROR; }
         set
         {
            if (m_entc_codnotifynietoMSGERROR != value)
            { m_entc_codnotifynietoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: DDOV_FecEmbarque.
      /// </summary>
      [IgnoreDataMember]
      public Boolean DDOV_FecEmbarqueOK
      {
         get { return m_ddov_fecembarqueOK; }
         set
         {
            if (m_ddov_fecembarqueOK != value)
            { m_ddov_fecembarqueOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: DDOV_FecEmbarque.
      /// </summary>
      [IgnoreDataMember]
      public String DDOV_FecEmbarqueMSGERROR
      {
         get { return m_ddov_fecembarqueMSGERROR; }
         set
         {
            if (m_ddov_fecembarqueMSGERROR != value)
            { m_ddov_fecembarqueMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_DepTemNegociaAgente.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_DepTemNegociaAgenteOK
      {
         get { return m_ccot_deptemnegociaagenteOK; }
         set
         {
            if (m_ccot_deptemnegociaagenteOK != value)
            { m_ccot_deptemnegociaagenteOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_DepTemNegociaAgente.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_DepTemNegociaAgenteMSGERROR
      {
         get { return m_ccot_deptemnegociaagenteMSGERROR; }
         set
         {
            if (m_ccot_deptemnegociaagenteMSGERROR != value)
            { m_ccot_deptemnegociaagenteMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_CodDepVacio.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENTC_CodDepVacioOK
      {
         get { return m_entc_coddepvacioOK; }
         set
         {
            if (m_entc_coddepvacioOK != value)
            { m_entc_coddepvacioOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_CodDepVacio.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodDepVacioMSGERROR
      {
         get { return m_entc_coddepvacioMSGERROR; }
         set
         {
            if (m_entc_coddepvacioMSGERROR != value)
            { m_entc_coddepvacioMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPE_CodDepVacio.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPE_CodDepVacioOK
      {
         get { return m_tipe_coddepvacioOK; }
         set
         {
            if (m_tipe_coddepvacioOK != value)
            { m_tipe_coddepvacioOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPE_CodDepVacio.
      /// </summary>
      [IgnoreDataMember]
      public String TIPE_CodDepVacioMSGERROR
      {
         get { return m_tipe_coddepvacioMSGERROR; }
         set
         {
            if (m_tipe_coddepvacioMSGERROR != value)
            { m_tipe_coddepvacioMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: DOOV_NumeroBLNieto.
      /// </summary>
      [IgnoreDataMember]
      public Boolean DOOV_NumeroBLNietoOK
      {
         get { return m_doov_numeroblnietoOK; }
         set
         {
            if (m_doov_numeroblnietoOK != value)
            { m_doov_numeroblnietoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: DOOV_NumeroBLNieto.
      /// </summary>
      [IgnoreDataMember]
      public String DOOV_NumeroBLNietoMSGERROR
      {
         get { return m_doov_numeroblnietoMSGERROR; }
         set
         {
            if (m_doov_numeroblnietoMSGERROR != value)
            { m_doov_numeroblnietoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CONS_TabLNG.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CONS_TabLNGOK
      {
         get { return m_cons_tablngOK; }
         set
         {
            if (m_cons_tablngOK != value)
            { m_cons_tablngOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CONS_TabLNG.
      /// </summary>
      [IgnoreDataMember]
      public String CONS_TabLNGMSGERROR
      {
         get { return m_cons_tablngMSGERROR; }
         set
         {
            if (m_cons_tablngMSGERROR != value)
            { m_cons_tablngMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CONS_CodLNG.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CONS_CodLNGOK
      {
         get { return m_cons_codlngOK; }
         set
         {
            if (m_cons_codlngOK != value)
            { m_cons_codlngOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CONS_CodLNG.
      /// </summary>
      [IgnoreDataMember]
      public String CONS_CodLNGMSGERROR
      {
         get { return m_cons_codlngMSGERROR; }
         set
         {
            if (m_cons_codlngMSGERROR != value)
            { m_cons_codlngMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_FecRecepcionDocumentos.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_FecRecepcionDocumentosOK
      {
         get { return m_ccot_fecrecepciondocumentosOK; }
         set
         {
            if (m_ccot_fecrecepciondocumentosOK != value)
            { m_ccot_fecrecepciondocumentosOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_FecRecepcionDocumentos.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_FecRecepcionDocumentosMSGERROR
      {
         get { return m_ccot_fecrecepciondocumentosMSGERROR; }
         set
         {
            if (m_ccot_fecrecepciondocumentosMSGERROR != value)
            { m_ccot_fecrecepciondocumentosMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_ConExcepcion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_ConExcepcionOK
      {
         get { return m_ccot_conexcepcionOK; }
         set
         {
            if (m_ccot_conexcepcionOK != value)
            { m_ccot_conexcepcionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_ConExcepcion.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_ConExcepcionMSGERROR
      {
         get { return m_ccot_conexcepcionMSGERROR; }
         set
         {
            if (m_ccot_conexcepcionMSGERROR != value)
            { m_ccot_conexcepcionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_VBOperaciones.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_VBOperacionesOK
      {
         get { return m_ccot_vboperacionesOK; }
         set
         {
            if (m_ccot_vboperacionesOK != value)
            { m_ccot_vboperacionesOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_VBOperaciones.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_VBOperacionesMSGERROR
      {
         get { return m_ccot_vboperacionesMSGERROR; }
         set
         {
            if (m_ccot_vboperacionesMSGERROR != value)
            { m_ccot_vboperacionesMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_VBLogistico.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_VBLogisticoOK
      {
         get { return m_ccot_vblogisticoOK; }
         set
         {
            if (m_ccot_vblogisticoOK != value)
            { m_ccot_vblogisticoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_VBLogistico.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_VBLogisticoMSGERROR
      {
         get { return m_ccot_vblogisticoMSGERROR; }
         set
         {
            if (m_ccot_vblogisticoMSGERROR != value)
            { m_ccot_vblogisticoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_DiferenciaFlete.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_DiferenciaFleteOK
      {
         get { return m_ccot_diferenciafleteOK; }
         set
         {
            if (m_ccot_diferenciafleteOK != value)
            { m_ccot_diferenciafleteOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_DiferenciaFlete.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_DiferenciaFleteMSGERROR
      {
         get { return m_ccot_diferenciafleteMSGERROR; }
         set
         {
            if (m_ccot_diferenciafleteMSGERROR != value)
            { m_ccot_diferenciafleteMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCOT_DiferenciaFleteRecup.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCOT_DiferenciaFleteRecupOK
      {
         get { return m_ccot_diferenciafleterecupOK; }
         set
         {
            if (m_ccot_diferenciafleterecupOK != value)
            { m_ccot_diferenciafleterecupOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCOT_DiferenciaFleteRecup.
      /// </summary>
      [IgnoreDataMember]
      public String CCOT_DiferenciaFleteRecupMSGERROR
      {
         get { return m_ccot_diferenciafleterecupMSGERROR; }
         set
         {
            if (m_ccot_diferenciafleterecupMSGERROR != value)
            { m_ccot_diferenciafleterecupMSGERROR = value; }
         }
      }
      #endregion

      #region [ Metodos ]
      
      #endregion
      #endregion

      #region [ Adicionales ]
      #region [ Variables ]
      private Boolean m_ccot_recibioprealerta;

      private String m_puer_codestandarorigen;
      private String m_puer_codestandardestino;
      private String m_puer_codestandartrasbordo;
      #endregion

      #region [ Propieades ]
      /// <summary>
      /// Gets or sets el valor de: CCOT_RecibioPreAlerta.
      /// </summary>
      [DataMember]
      public Boolean CCOT_RecibioPreAlerta
      {
         get { return m_ccot_recibioprealerta; }
         set {
            if (m_ccot_recibioprealerta != value)
            {
               m_ccot_recibioprealerta = value;
               OnPropertyChanged("CCOT_RecibioPreAlerta");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: PUER_CodEstandarOrigen.
      /// </summary>
      [DataMember]
      public String PUER_CodEstandarOrigen
      {
         get { return m_puer_codestandarorigen; }
         set {
            if (m_puer_codestandarorigen != value)
            { m_puer_codestandarorigen = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: PUER_CodEstandarDestino.
      /// </summary>
      [DataMember]
      public String PUER_CodEstandarDestino
      {
         get { return m_puer_codestandardestino; }
         set
         {
            if (m_puer_codestandardestino != value)
            { m_puer_codestandardestino = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: PUER_CodEstandarTrasbordo.
      /// </summary>
      [DataMember]
      public String PUER_CodEstandarTrasbordo
      {
         get { return m_puer_codestandartrasbordo; }
         set
         {
            if (m_puer_codestandartrasbordo != value)
            { m_puer_codestandartrasbordo = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: ENTC_NomDepTemporal.
      /// </summary>
      [DataMember]
      public String ENTC_NomDepTemporal { get; set; }

      /// <summary>
      /// Gets or sets el valor de: NVIA_FecETA_Zarpe.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecETA_Zarpe { get; set; }
      #endregion

      #endregion
   }
}
