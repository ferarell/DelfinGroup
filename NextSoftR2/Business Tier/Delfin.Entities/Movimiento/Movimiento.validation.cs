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
   public partial class Movimiento
   {
      #region [ Variables Validación ]
      private Boolean m_empr_codigoOK;
      private String m_empr_codigoMSGERROR;
      private Boolean m_movi_codigoOK;
      private String m_movi_codigoMSGERROR;
      private Boolean m_sucr_codigoOK;
      private String m_sucr_codigoMSGERROR;
      private Boolean m_cuba_codigoOK;
      private String m_cuba_codigoMSGERROR;
      private Boolean m_plan_tipoOK;
      private String m_plan_tipoMSGERROR;
      private Boolean m_plan_codigoOK;
      private String m_plan_codigoMSGERROR;
      private Boolean m_fluj_codigoOK;
      private String m_fluj_codigoMSGERROR;
      private Boolean m_fluj_anioOK;
      private String m_fluj_anioMSGERROR;
      private Boolean m_tran_codigoOK;
      private String m_tran_codigoMSGERROR;
      private Boolean m_entc_codigoOK;
      private String m_entc_codigoMSGERROR;
      private Boolean m_tipo_tabmovOK;
      private String m_tipo_tabmovMSGERROR;
      private Boolean m_tipo_codmovOK;
      private String m_tipo_codmovMSGERROR;
      private Boolean m_cons_tabestOK;
      private String m_cons_tabestMSGERROR;
      private Boolean m_cons_codestOK;
      private String m_cons_codestMSGERROR;
      private Boolean m_movi_asientocontableOK;
      private String m_movi_asientocontableMSGERROR;
      private Boolean m_movi_numeroOK;
      private String m_movi_numeroMSGERROR;
      private Boolean m_movi_fecemisionOK;
      private String m_movi_fecemisionMSGERROR;
      private Boolean m_movi_conceptoOK;
      private String m_movi_conceptoMSGERROR;
      private Boolean m_movi_ordendeOK;
      private String m_movi_ordendeMSGERROR;
      private Boolean m_movi_montodebeOK;
      private String m_movi_montodebeMSGERROR;
      private Boolean m_movi_tipocambioOK;
      private String m_movi_tipocambioMSGERROR;
      private Boolean m_movi_montohaberOK;
      private String m_movi_montohaberMSGERROR;
      private Boolean m_movi_agrupacionOK;
      private String m_movi_agrupacionMSGERROR;
      private Boolean m_movi_chequeOK;
      private String m_movi_chequeMSGERROR;
      private Boolean m_movi_estadochequeOK;
      private String m_movi_estadochequeMSGERROR;
      private Boolean m_movi_userentregachequeOK;
      private String m_movi_userentregachequeMSGERROR;
      private Boolean m_movi_fecentregachequeOK;
      private String m_movi_fecentregachequeMSGERROR;
      private Boolean m_movi_fecdiferidoOK;
      private String m_movi_fecdiferidoMSGERROR;
      private Boolean m_movi_chequeimpresoOK;
      private String m_movi_chequeimpresoMSGERROR;
      private Boolean m_movi_useranulacionOK;
      private String m_movi_useranulacionMSGERROR;
      private Boolean m_movi_fecanulacionOK;
      private String m_movi_fecanulacionMSGERROR;
      private Boolean m_movi_glosaanulacionOK;
      private String m_movi_glosaanulacionMSGERROR;
      private Boolean m_movi_nrooperacionOK;
      private String m_movi_nrooperacionMSGERROR;
      private Boolean m_movi_nrooficinaOK;
      private String m_movi_nrooficinaMSGERROR;
      private Boolean m_movi_referenciaOK;
      private String m_movi_referenciaMSGERROR;
      private Boolean m_audi_usrcreaOK;
      private String m_audi_usrcreaMSGERROR;
      private Boolean m_audi_feccreaOK;
      private String m_audi_feccreaMSGERROR;
      private Boolean m_audi_usrmodOK;
      private String m_audi_usrmodMSGERROR;
      private Boolean m_audi_fecmodOK;
      private String m_audi_fecmodMSGERROR;

      private Boolean m_tipo_tabdesOK;
      private String m_tipo_tabdesMSGERROR;
      private Boolean m_tipo_coddesOK;
      private String m_tipo_coddesMSGERROR;
      private Boolean m_movi_montodescuadreOK;
      private String m_movi_montodescuadreMSGERROR;

      private Boolean m_tipo_tabmdpOK;
      private String m_tipo_tabmdpMSGERROR;
      private Boolean m_tipo_codmdpOK;
      private String m_tipo_codmdpMSGERROR;

      private Boolean m_MontoOK;
      private String m_MontoMSGERROR;

      #endregion

      #region [ Propiedades Validación ]
      /// <summary>
      /// Gets or sets el valor de validación de: EMPR_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean EMPR_CodigoOK
      {
         get { return m_empr_codigoOK; }
         set
         {
            if (m_empr_codigoOK != value)
            { m_empr_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: EMPR_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String EMPR_CodigoMSGERROR
      {
         get { return m_empr_codigoMSGERROR; }
         set
         {
            if (m_empr_codigoMSGERROR != value)
            { m_empr_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_CodigoOK
      {
         get { return m_movi_codigoOK; }
         set
         {
            if (m_movi_codigoOK != value)
            { m_movi_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_CodigoMSGERROR
      {
         get { return m_movi_codigoMSGERROR; }
         set
         {
            if (m_movi_codigoMSGERROR != value)
            { m_movi_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: SUCR_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean SUCR_CodigoOK
      {
         get { return m_sucr_codigoOK; }
         set
         {
            if (m_sucr_codigoOK != value)
            { m_sucr_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: SUCR_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String SUCR_CodigoMSGERROR
      {
         get { return m_sucr_codigoMSGERROR; }
         set
         {
            if (m_sucr_codigoMSGERROR != value)
            { m_sucr_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CUBA_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CUBA_CodigoOK
      {
         get { return m_cuba_codigoOK; }
         set
         {
            if (m_cuba_codigoOK != value)
            { m_cuba_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CUBA_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String CUBA_CodigoMSGERROR
      {
         get { return m_cuba_codigoMSGERROR; }
         set
         {
            if (m_cuba_codigoMSGERROR != value)
            { m_cuba_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: PLAN_Tipo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean PLAN_TipoOK
      {
         get { return m_plan_tipoOK; }
         set
         {
            if (m_plan_tipoOK != value)
            { m_plan_tipoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: PLAN_Tipo.
      /// </summary>
      [IgnoreDataMember]
      public String PLAN_TipoMSGERROR
      {
         get { return m_plan_tipoMSGERROR; }
         set
         {
            if (m_plan_tipoMSGERROR != value)
            { m_plan_tipoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: PLAN_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean PLAN_CodigoOK
      {
         get { return m_plan_codigoOK; }
         set
         {
            if (m_plan_codigoOK != value)
            { m_plan_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: PLAN_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String PLAN_CodigoMSGERROR
      {
         get { return m_plan_codigoMSGERROR; }
         set
         {
            if (m_plan_codigoMSGERROR != value)
            { m_plan_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: FLUJ_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean FLUJ_CodigoOK
      {
         get { return m_fluj_codigoOK; }
         set
         {
            if (m_fluj_codigoOK != value)
            { m_fluj_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: FLUJ_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String FLUJ_CodigoMSGERROR
      {
         get { return m_fluj_codigoMSGERROR; }
         set
         {
            if (m_fluj_codigoMSGERROR != value)
            { m_fluj_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: FLUJ_Anio.
      /// </summary>
      [IgnoreDataMember]
      public Boolean FLUJ_AnioOK
      {
         get { return m_fluj_anioOK; }
         set
         {
            if (m_fluj_anioOK != value)
            { m_fluj_anioOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: FLUJ_Anio.
      /// </summary>
      [IgnoreDataMember]
      public String FLUJ_AnioMSGERROR
      {
         get { return m_fluj_anioMSGERROR; }
         set
         {
            if (m_fluj_anioMSGERROR != value)
            { m_fluj_anioMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TRAN_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TRAN_CodigoOK
      {
         get { return m_tran_codigoOK; }
         set
         {
            if (m_tran_codigoOK != value)
            { m_tran_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TRAN_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String TRAN_CodigoMSGERROR
      {
         get { return m_tran_codigoMSGERROR; }
         set
         {
            if (m_tran_codigoMSGERROR != value)
            { m_tran_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public Boolean ENTC_CodigoOK
      {
         get { return m_entc_codigoOK; }
         set
         {
            if (m_entc_codigoOK != value)
            { m_entc_codigoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_Codigo.
      /// </summary>
      [IgnoreDataMember]
      public String ENTC_CodigoMSGERROR
      {
         get { return m_entc_codigoMSGERROR; }
         set
         {
            if (m_entc_codigoMSGERROR != value)
            { m_entc_codigoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_TabMOV.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_TabMOVOK
      {
         get { return m_tipo_tabmovOK; }
         set
         {
            if (m_tipo_tabmovOK != value)
            { m_tipo_tabmovOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabMOV.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_TabMOVMSGERROR
      {
         get { return m_tipo_tabmovMSGERROR; }
         set
         {
            if (m_tipo_tabmovMSGERROR != value)
            { m_tipo_tabmovMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodMOV.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_CodMOVOK
      {
         get { return m_tipo_codmovOK; }
         set
         {
            if (m_tipo_codmovOK != value)
            { m_tipo_codmovOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodMOV.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_CodMOVMSGERROR
      {
         get { return m_tipo_codmovMSGERROR; }
         set
         {
            if (m_tipo_codmovMSGERROR != value)
            { m_tipo_codmovMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CONS_TabEST.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CONS_TabESTOK
      {
         get { return m_cons_tabestOK; }
         set
         {
            if (m_cons_tabestOK != value)
            { m_cons_tabestOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CONS_TabEST.
      /// </summary>
      [IgnoreDataMember]
      public String CONS_TabESTMSGERROR
      {
         get { return m_cons_tabestMSGERROR; }
         set
         {
            if (m_cons_tabestMSGERROR != value)
            { m_cons_tabestMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CONS_CodEST.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CONS_CodESTOK
      {
         get { return m_cons_codestOK; }
         set
         {
            if (m_cons_codestOK != value)
            { m_cons_codestOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CONS_CodEST.
      /// </summary>
      [IgnoreDataMember]
      public String CONS_CodESTMSGERROR
      {
         get { return m_cons_codestMSGERROR; }
         set
         {
            if (m_cons_codestMSGERROR != value)
            { m_cons_codestMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_AsientoContable.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_AsientoContableOK
      {
         get { return m_movi_asientocontableOK; }
         set
         {
            if (m_movi_asientocontableOK != value)
            { m_movi_asientocontableOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_AsientoContable.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_AsientoContableMSGERROR
      {
         get { return m_movi_asientocontableMSGERROR; }
         set
         {
            if (m_movi_asientocontableMSGERROR != value)
            { m_movi_asientocontableMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_Numero.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_NumeroOK
      {
         get { return m_movi_numeroOK; }
         set
         {
            if (m_movi_numeroOK != value)
            { m_movi_numeroOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_Numero.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_NumeroMSGERROR
      {
         get { return m_movi_numeroMSGERROR; }
         set
         {
            if (m_movi_numeroMSGERROR != value)
            { m_movi_numeroMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_FecEmision.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_FecEmisionOK
      {
         get { return m_movi_fecemisionOK; }
         set
         {
            if (m_movi_fecemisionOK != value)
            { m_movi_fecemisionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_FecEmision.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_FecEmisionMSGERROR
      {
         get { return m_movi_fecemisionMSGERROR; }
         set
         {
            if (m_movi_fecemisionMSGERROR != value)
            { m_movi_fecemisionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_Concepto.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_ConceptoOK
      {
         get { return m_movi_conceptoOK; }
         set
         {
            if (m_movi_conceptoOK != value)
            { m_movi_conceptoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_Concepto.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_ConceptoMSGERROR
      {
         get { return m_movi_conceptoMSGERROR; }
         set
         {
            if (m_movi_conceptoMSGERROR != value)
            { m_movi_conceptoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_OrdenDe.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_OrdenDeOK
      {
         get { return m_movi_ordendeOK; }
         set
         {
            if (m_movi_ordendeOK != value)
            { m_movi_ordendeOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_OrdenDe.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_OrdenDeMSGERROR
      {
         get { return m_movi_ordendeMSGERROR; }
         set
         {
            if (m_movi_ordendeMSGERROR != value)
            { m_movi_ordendeMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_MontoDebe.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_MontoDebeOK
      {
         get { return m_movi_montodebeOK; }
         set
         {
            if (m_movi_montodebeOK != value)
            { m_movi_montodebeOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_MontoDebe.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_MontoDebeMSGERROR
      {
         get { return m_movi_montodebeMSGERROR; }
         set
         {
            if (m_movi_montodebeMSGERROR != value)
            { m_movi_montodebeMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_TipoCambio.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_TipoCambioOK
      {
         get { return m_movi_tipocambioOK; }
         set
         {
            if (m_movi_tipocambioOK != value)
            { m_movi_tipocambioOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_TipoCambio.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_TipoCambioMSGERROR
      {
         get { return m_movi_tipocambioMSGERROR; }
         set
         {
            if (m_movi_tipocambioMSGERROR != value)
            { m_movi_tipocambioMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_MontoHaber.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_MontoHaberOK
      {
         get { return m_movi_montohaberOK; }
         set
         {
            if (m_movi_montohaberOK != value)
            { m_movi_montohaberOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_MontoHaber.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_MontoHaberMSGERROR
      {
         get { return m_movi_montohaberMSGERROR; }
         set
         {
            if (m_movi_montohaberMSGERROR != value)
            { m_movi_montohaberMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_Agrupacion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_AgrupacionOK
      {
         get { return m_movi_agrupacionOK; }
         set
         {
            if (m_movi_agrupacionOK != value)
            { m_movi_agrupacionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_Agrupacion.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_AgrupacionMSGERROR
      {
         get { return m_movi_agrupacionMSGERROR; }
         set
         {
            if (m_movi_agrupacionMSGERROR != value)
            { m_movi_agrupacionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_Cheque.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_ChequeOK
      {
         get { return m_movi_chequeOK; }
         set
         {
            if (m_movi_chequeOK != value)
            { m_movi_chequeOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_Cheque.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_ChequeMSGERROR
      {
         get { return m_movi_chequeMSGERROR; }
         set
         {
            if (m_movi_chequeMSGERROR != value)
            { m_movi_chequeMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_EstadoCheque.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_EstadoChequeOK
      {
         get { return m_movi_estadochequeOK; }
         set
         {
            if (m_movi_estadochequeOK != value)
            { m_movi_estadochequeOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_EstadoCheque.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_EstadoChequeMSGERROR
      {
         get { return m_movi_estadochequeMSGERROR; }
         set
         {
            if (m_movi_estadochequeMSGERROR != value)
            { m_movi_estadochequeMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_UserEntregaCheque.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_UserEntregaChequeOK
      {
         get { return m_movi_userentregachequeOK; }
         set
         {
            if (m_movi_userentregachequeOK != value)
            { m_movi_userentregachequeOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_UserEntregaCheque.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_UserEntregaChequeMSGERROR
      {
         get { return m_movi_userentregachequeMSGERROR; }
         set
         {
            if (m_movi_userentregachequeMSGERROR != value)
            { m_movi_userentregachequeMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_FecEntregaCheque.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_FecEntregaChequeOK
      {
         get { return m_movi_fecentregachequeOK; }
         set
         {
            if (m_movi_fecentregachequeOK != value)
            { m_movi_fecentregachequeOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_FecEntregaCheque.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_FecEntregaChequeMSGERROR
      {
         get { return m_movi_fecentregachequeMSGERROR; }
         set
         {
            if (m_movi_fecentregachequeMSGERROR != value)
            { m_movi_fecentregachequeMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_FecDiferido.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_FecDiferidoOK
      {
         get { return m_movi_fecdiferidoOK; }
         set
         {
            if (m_movi_fecdiferidoOK != value)
            { m_movi_fecdiferidoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_FecDiferido.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_FecDiferidoMSGERROR
      {
         get { return m_movi_fecdiferidoMSGERROR; }
         set
         {
            if (m_movi_fecdiferidoMSGERROR != value)
            { m_movi_fecdiferidoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_ChequeImpreso.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_ChequeImpresoOK
      {
         get { return m_movi_chequeimpresoOK; }
         set
         {
            if (m_movi_chequeimpresoOK != value)
            { m_movi_chequeimpresoOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_ChequeImpreso.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_ChequeImpresoMSGERROR
      {
         get { return m_movi_chequeimpresoMSGERROR; }
         set
         {
            if (m_movi_chequeimpresoMSGERROR != value)
            { m_movi_chequeimpresoMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_UserAnulacion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_UserAnulacionOK
      {
         get { return m_movi_useranulacionOK; }
         set
         {
            if (m_movi_useranulacionOK != value)
            { m_movi_useranulacionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_UserAnulacion.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_UserAnulacionMSGERROR
      {
         get { return m_movi_useranulacionMSGERROR; }
         set
         {
            if (m_movi_useranulacionMSGERROR != value)
            { m_movi_useranulacionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_FecAnulacion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_FecAnulacionOK
      {
         get { return m_movi_fecanulacionOK; }
         set
         {
            if (m_movi_fecanulacionOK != value)
            { m_movi_fecanulacionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_FecAnulacion.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_FecAnulacionMSGERROR
      {
         get { return m_movi_fecanulacionMSGERROR; }
         set
         {
            if (m_movi_fecanulacionMSGERROR != value)
            { m_movi_fecanulacionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_GlosaAnulacion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_GlosaAnulacionOK
      {
         get { return m_movi_glosaanulacionOK; }
         set
         {
            if (m_movi_glosaanulacionOK != value)
            { m_movi_glosaanulacionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_GlosaAnulacion.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_GlosaAnulacionMSGERROR
      {
         get { return m_movi_glosaanulacionMSGERROR; }
         set
         {
            if (m_movi_glosaanulacionMSGERROR != value)
            { m_movi_glosaanulacionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_NroOperacion.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_NroOperacionOK
      {
         get { return m_movi_nrooperacionOK; }
         set
         {
            if (m_movi_nrooperacionOK != value)
            { m_movi_nrooperacionOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_NroOperacion.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_NroOperacionMSGERROR
      {
         get { return m_movi_nrooperacionMSGERROR; }
         set
         {
            if (m_movi_nrooperacionMSGERROR != value)
            { m_movi_nrooperacionMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_NroOficina.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_NroOficinaOK
      {
         get { return m_movi_nrooficinaOK; }
         set
         {
            if (m_movi_nrooficinaOK != value)
            { m_movi_nrooficinaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_NroOficina.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_NroOficinaMSGERROR
      {
         get { return m_movi_nrooficinaMSGERROR; }
         set
         {
            if (m_movi_nrooficinaMSGERROR != value)
            { m_movi_nrooficinaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_Referencia.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_ReferenciaOK
      {
         get { return m_movi_referenciaOK; }
         set
         {
            if (m_movi_referenciaOK != value)
            { m_movi_referenciaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_Referencia.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_ReferenciaMSGERROR
      {
         get { return m_movi_referenciaMSGERROR; }
         set
         {
            if (m_movi_referenciaMSGERROR != value)
            { m_movi_referenciaMSGERROR = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_TabDES.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_TabDESOK
      {
         get { return m_tipo_tabdesOK; }
         set
         {
            if (m_tipo_tabdesOK != value)
            { m_tipo_tabdesOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabDES.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_TabDESMSGERROR
      {
         get { return m_tipo_tabdesMSGERROR; }
         set
         {
            if (m_tipo_tabdesMSGERROR != value)
            { m_tipo_tabdesMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodDES.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_CodDESOK
      {
         get { return m_tipo_coddesOK; }
         set
         {
            if (m_tipo_coddesOK != value)
            { m_tipo_coddesOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodDES.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_CodDESMSGERROR
      {
         get { return m_tipo_coddesMSGERROR; }
         set
         {
            if (m_tipo_coddesMSGERROR != value)
            { m_tipo_coddesMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: MOVI_MontoDescuadre.
      /// </summary>
      [IgnoreDataMember]
      public Boolean MOVI_MontoDescuadreOK
      {
         get { return m_movi_montodescuadreOK; }
         set
         {
            if (m_movi_montodescuadreOK != value)
            { m_movi_montodescuadreOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: MOVI_MontoDescuadre.
      /// </summary>
      [IgnoreDataMember]
      public String MOVI_MontoDescuadreMSGERROR
      {
         get { return m_movi_montodescuadreMSGERROR; }
         set
         {
            if (m_movi_montodescuadreMSGERROR != value)
            { m_movi_montodescuadreMSGERROR = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_TabMDP.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_TabMDPOK
      {
         get { return m_tipo_tabmdpOK; }
         set
         {
            if (m_tipo_tabmdpOK != value)
            { m_tipo_tabmdpOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabMDP.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_TabMDPMSGERROR
      {
         get { return m_tipo_tabmdpMSGERROR; }
         set
         {
            if (m_tipo_tabmdpMSGERROR != value)
            { m_tipo_tabmdpMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodMDP.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_CodMDPOK
      {
         get { return m_tipo_codmdpOK; }
         set
         {
            if (m_tipo_codmdpOK != value)
            { m_tipo_codmdpOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodMDP.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_CodMDPMSGERROR
      {
         get { return m_tipo_codmdpMSGERROR; }
         set
         {
            if (m_tipo_codmdpMSGERROR != value)
            { m_tipo_codmdpMSGERROR = value; }
         }
      }

      public Boolean MontoOK
      {
         get { return m_MontoOK; }
         set { m_MontoOK = value; }
      }

      public String MontoMSGERROR
      {
         get { return m_MontoMSGERROR; }
         set { m_MontoMSGERROR = value; }
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
            EMPR_CodigoOK = true;
            EMPR_CodigoMSGERROR = "";
            //if( EMPR_Codigo == null)
            //{
            //   _isCorrect = false;
            //   EMPR_CodigoOK  = false;
            //   EMPR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "EMPR_Codigo", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo EMPR_Codigo" + Environment.NewLine;
            //}
            MOVI_CodigoOK = true;
            MOVI_CodigoMSGERROR = "";
            //if( MOVI_Codigo == 0)
            //{
            //   _isCorrect = false;
            //   MOVI_CodigoOK  = false;
            //   MOVI_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "MOVI_Codigo", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo MOVI_Codigo" + Environment.NewLine;
            //}
            SUCR_CodigoOK = true;
            SUCR_CodigoMSGERROR = "";
            //if( SUCR_Codigo == null)
            //{
            //   _isCorrect = false;
            //   SUCR_CodigoOK  = false;
            //   SUCR_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "SUCR_Codigo", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo SUCR_Codigo" + Environment.NewLine;
            //}
            CUBA_CodigoOK = true;
            CUBA_CodigoMSGERROR = "";
            if (String.IsNullOrEmpty(CUBA_Codigo))
            {
               _isCorrect = false;
               CUBA_CodigoOK = false;
               CUBA_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Cuenta Bancaria", "Movimiento");
               m_mensajeError += "* Debe ingresar el campo Cuenta Bancaria" + Environment.NewLine;
            }
            ENTC_CodigoOK = true;
            ENTC_CodigoMSGERROR = "";
            if (ENTC_Codigo == 0)
            {
               _isCorrect = false;
               ENTC_CodigoOK = false;
               ENTC_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Entidad", "Movimiento");
               m_mensajeError += "* Debe ingresar el campo Entidad" + Environment.NewLine;
            }
            TIPO_TabMOVOK = true;
            TIPO_TabMOVMSGERROR = "";
            //if( String.IsNullOrEmpty(TIPO_TabMOV) )
            //{
            //   _isCorrect = false;
            //   TIPO_TabMOVOK  = false;
            //   TIPO_TabMOVMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Movimiento", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo Tipo de Movimiento" + Environment.NewLine;
            //}
            TIPO_CodMOVOK = true;
            TIPO_CodMOVMSGERROR = "";
            if (NEstadoCheque != EstadoCheque.Blanco)
            {
               if (String.IsNullOrEmpty(TIPO_CodMOV))
               {
                  _isCorrect = false;
                  TIPO_CodMOVOK = false;
                  TIPO_CodMOVMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Tipo de Movimiento", "Movimiento");
                  m_mensajeError += "* Debe ingresar el campo Tipo de Movimiento" + Environment.NewLine;
               }
            }

            TIPO_CodMDPOK = true;
            TIPO_CodMDPMSGERROR = "";
            if (NEstadoCheque != EstadoCheque.Blanco)
            {
               if (String.IsNullOrEmpty(TIPO_CodMDP))
               {
                  _isCorrect = false;
                  TIPO_CodMDPOK = false;
                  TIPO_CodMDPMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Medio de Pago", "Movimiento");
                  m_mensajeError += "* Debe ingresar el campo Medio de Pago" + Environment.NewLine;
               }
            }

            CONS_TabESTOK = true;
            CONS_TabESTMSGERROR = "";
            //if( String.IsNullOrEmpty(CONS_TabEST) )
            //{
            //   _isCorrect = false;
            //   CONS_TabESTOK  = false;
            //   CONS_TabESTMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Estado de Movimiento", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo Estado de Movimiento" + Environment.NewLine;
            //}
            CONS_CodESTOK = true;
            CONS_CodESTMSGERROR = "";
            //if( String.IsNullOrEmpty(CONS_CodEST) )
            //{
            //   _isCorrect = false;
            //   CONS_CodESTOK  = false;
            //   CONS_CodESTMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CONS_CodEST", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo CONS_CodEST" + Environment.NewLine;
            //}
            MOVI_NumeroOK = true;
            MOVI_NumeroMSGERROR = "";
            MOVI_NroOperacionOK = true;
            MOVI_NroOperacionMSGERROR = "";
            if (NEstadoCheque == EstadoCheque.Blanco)
            {
               switch (GetTipoMovimiento())
               {
                  case TipoMovimiento.Ingresos:
                     if (String.IsNullOrEmpty(MOVI_NroOperacion))
                     {
                        _isCorrect = false;
                        MOVI_NroOperacionOK = false;
                        MOVI_NroOperacionMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Número de Operación", "Movimiento Cheque en Blanco");
                        m_mensajeError += "* Debe ingresar el campo Número de Cheque" + Environment.NewLine;
                     }
                     break;
                  case TipoMovimiento.IngresosDiferidos:
                     break;
                  case TipoMovimiento.EgresosDepositos:
                     break;
                  case TipoMovimiento.EgresosCheque:
                     if (String.IsNullOrEmpty(MOVI_Numero))
                     {
                        _isCorrect = false;
                        MOVI_NumeroOK = false;
                        MOVI_NumeroMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Número de Cheque", "Movimiento Cheque en Blanco");
                        m_mensajeError += "* Debe ingresar el campo Número de Cheque" + Environment.NewLine;
                     }
                     break;
                  case TipoMovimiento.EgresosChequeDiferido:
                     if (String.IsNullOrEmpty(MOVI_Numero))
                     {
                        _isCorrect = false;
                        MOVI_NumeroOK = false;
                        MOVI_NumeroMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Número de Cheque", "Movimiento Cheque en Blanco");
                        m_mensajeError += "* Debe ingresar el campo Número de Cheque" + Environment.NewLine;
                     }
                     break;
                  case TipoMovimiento.EgresosTransferenciaCuentasPropias:
                     break;
                  case TipoMovimiento.EgresosTransferenciaMVirtual:
                     break;
                  case TipoMovimiento.IngresosTransferenciaCuentasPropias:
                     break;
                  case TipoMovimiento.IngresosExtorno:
                     break;
                  case TipoMovimiento.EgresosExtorno:
                     break;
                  default:
                     break;
               }
            }
            else
            {

            }
            MOVI_FecEmisionOK = true;
            MOVI_FecEmisionMSGERROR = "";
            if (MOVI_FecEmision == null)
            {
               _isCorrect = false;
               MOVI_FecEmisionOK = false;
               MOVI_FecEmisionMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Fecha de Emisión", "Movimiento");
               m_mensajeError += "* Debe ingresar el campo Fecha de Emisión" + Environment.NewLine;
            }
            MOVI_ConceptoOK = true;
            MOVI_ConceptoMSGERROR = "";
            if (NEstadoCheque != EstadoCheque.Blanco)
            {
               if (String.IsNullOrEmpty(MOVI_Concepto))
               {
                  _isCorrect = false;
                  MOVI_ConceptoOK = false;
                  MOVI_ConceptoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Concepto", "Movimiento");
                  m_mensajeError += "* Debe ingresar el campo Concepto" + Environment.NewLine;
               }
            }
            MOVI_MontoDebeOK = true;
            MOVI_MontoDebeMSGERROR = "";
            //if( MOVI_MontoDebe == 0)
            //{
            //   _isCorrect = false;
            //   MOVI_MontoDebeOK  = false;
            //   MOVI_MontoDebeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "MOVI_MontoDebe", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo MOVI_MontoDebe" + Environment.NewLine;
            //}
            MOVI_MontoHaberOK = true;
            MOVI_MontoHaberMSGERROR = "";
            //if( MOVI_MontoHaber == 0)
            //{
            //   _isCorrect = false;
            //   MOVI_MontoHaberOK  = false;
            //   MOVI_MontoHaberMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "MOVI_MontoHaber", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo MOVI_MontoHaber" + Environment.NewLine;
            //}
            MOVI_ChequeOK = true;
            MOVI_ChequeMSGERROR = "";
            //if( MOVI_Cheque == null)
            //{
            //   _isCorrect = false;
            //   MOVI_ChequeOK  = false;
            //   MOVI_ChequeMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "MOVI_Cheque", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo MOVI_Cheque" + Environment.NewLine;
            //}
            ENTC_CodigoOK = true;
            ENTC_CodigoMSGERROR = "";
            if (NEstadoCheque != EstadoCheque.Blanco)
            {
               if (ENTC_Codigo == null)
               {
                  _isCorrect = false;
                  ENTC_CodigoOK = false;
                  ENTC_CodigoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Entidad", "Movimiento");
                  m_mensajeError += "* Debe ingresar el campo Entidad" + Environment.NewLine;
               }
            }

            MOVI_TipoCambioOK = true;
            MOVI_TipoCambioMSGERROR = "";
            if (MOVI_TipoCambio == null)
            {
               _isCorrect = false;
               MOVI_TipoCambioOK = false;
               MOVI_TipoCambioMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Tipo de Cambio", "Movimiento");
               m_mensajeError += "* Debe ingresar el campo tipo de cambio" + Environment.NewLine;
            }


            MontoOK = true;
            MontoMSGERROR = "";
            //if (Monto == 0)
            //{
            //   _isCorrect = false;
            //   MontoOK = false;
            //   MontoMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Monto", "Movimiento");
            //   m_mensajeError += "* Debe ingresar el campo Monto" + Environment.NewLine;
            //}

            if ((MOVI_MontoDebe + MOVI_MontoHaber) < 0)
            {
               _isCorrect = false;
               MOVI_MontoHaberOK = false;
               MOVI_MontoDebeOK = false;
               MOVI_MontoDebeMSGERROR = String.Format("El importe debe ser Igual o Superior a cero (0.00)", "", "");
               MOVI_MontoHaberMSGERROR = String.Format("El importe debe ser Igual o Superior a cero (0.00)", "", "");
               m_mensajeError += "* El importe debe ser Igual o Superior a ceros (0.00)" + Environment.NewLine;
            }

            switch (GetTipoMovimiento())
            {
               case TipoMovimiento.Ingresos:
                  MOVI_NroOperacionOK = true;
                  MOVI_NroOperacionMSGERROR = "";
                  if (String.IsNullOrEmpty(MOVI_NroOperacion))
                  {
                     _isCorrect = false;
                     MOVI_NroOperacionOK = false;
                     MOVI_NroOperacionMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Número de Operación", "Movimiento");
                     m_mensajeError += "* Debe ingresar el campo Número de Operación" + Environment.NewLine;
                  }
                  break;
               case TipoMovimiento.IngresosDiferidos:
                  MOVI_NroOperacionOK = true;
                  MOVI_NroOperacionMSGERROR = "";
                  if (String.IsNullOrEmpty(MOVI_NroOperacion))
                  {
                     _isCorrect = false;
                     MOVI_NroOperacionOK = false;
                     MOVI_NroOperacionMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Número de Operación", "Movimiento");
                     m_mensajeError += "* Debe ingresar el campo Número de Operación" + Environment.NewLine;
                  }
                  if (NEstadoCheque != EstadoCheque.Blanco)
                  {
                     MOVI_FecDiferidoOK = true;
                     MOVI_FecDiferidoMSGERROR = "";
                     if (MOVI_FecDiferido == null)
                     {
                        _isCorrect = false;
                        MOVI_FecDiferidoOK = false;
                        MOVI_FecDiferidoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Fecha Diferido", "Movimiento");
                        m_mensajeError += "* Debe ingresar el campo Fecha Diferido" + Environment.NewLine;
                     }
                  }
                  break;
               case TipoMovimiento.EgresosDepositos:
                  break;
               case TipoMovimiento.EgresosCheque:
                  break;
               case TipoMovimiento.EgresosChequeDiferido:
                  MOVI_FecDiferidoOK = true;
                  MOVI_FecDiferidoMSGERROR = "";
                  if (NEstadoCheque != EstadoCheque.Blanco)
                  {
                     if (MOVI_FecDiferido == null)
                     {
                        _isCorrect = false;
                        MOVI_FecDiferidoOK = false;
                        MOVI_FecDiferidoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Fecha Diferido", "Movimiento");
                        m_mensajeError += "* Debe ingresar el campo Fecha Diferido" + Environment.NewLine;
                     }
                  }
                  break;
               case TipoMovimiento.EgresosTransferenciaCuentasPropias:
                  break;
               case TipoMovimiento.EgresosTransferenciaMVirtual:
                  break;
               case TipoMovimiento.IngresosTransferenciaCuentasPropias:
                  break;
               default:
                  break;
            }

            if (TieneDescuadre)
            {
               TIPO_TabDESOK = true;
               TIPO_TabDESMSGERROR = "";
               TIPO_CodDESOK = true;
               TIPO_CodDESMSGERROR = "";
               //if (String.IsNullOrEmpty(TIPO_CodDES) || String.IsNullOrEmpty(TIPO_TabDES))
               //{
               //   _isCorrect = false;
               //   TIPO_CodDESOK = false;
               //   TIPO_CodDESMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Tipo de Descuadre", "Movimiento");
               //   m_mensajeError += "* Debe ingresar el campo Tipo de Descuadre" + Environment.NewLine;
               //}
               MOVI_MontoDescuadreOK = true;
               MOVI_MontoDescuadreMSGERROR = "";
               if (MOVI_MontoDescuadre == null)
               {
                  _isCorrect = false;
                  MOVI_MontoDescuadreOK = false;
                  MOVI_MontoDescuadreMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "campo Monto de Descuadre", "Movimiento");
                  m_mensajeError += "* Debe ingresar el campo Monto de Descuadre" + Environment.NewLine;
               }
            }


            return _isCorrect;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Boolean ValidarConciliacion()
      {
         try
         {
            Boolean _isCorrect = true;
            m_mensajeError = "";
            if (ItemConciliacion != null)
            {
               if (ItemConciliacion.CONC_FecConciliacion == null) { _isCorrect = false; m_mensajeError += String.Format("  * Debe registrar la fecha de conciliación {0}", Environment.NewLine); }
               if (ItemConciliacion.CONC_MontoBCO == null) { _isCorrect = false; m_mensajeError += String.Format("  * Debe registrar el monto de conciliación {0}", Environment.NewLine); }
               if (ItemConciliacion.CONC_Periodo == null) { _isCorrect = false; m_mensajeError += String.Format("  * Debe registrar el periodo de conciliación {0}", Environment.NewLine); }
            }
            else
            {
               _isCorrect = false;
               m_mensajeError += String.Format("  * Error en la inicialización de la conciliación.{0}", Environment.NewLine);
            }
            return _isCorrect;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
