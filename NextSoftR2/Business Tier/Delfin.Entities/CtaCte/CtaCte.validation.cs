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
using Delfin;

namespace Delfin.Entities
{
   public partial class CtaCte
   {
      #region [ Variables Validación ]
      private Boolean m_ccct_codigoOK;
      private String m_ccct_codigoMSGERROR;
      private Boolean m_ccct_fechaemisionOK;
      private String m_ccct_fechaemisionMSGERROR;
      private Boolean m_ccct_tipocambioOK;
      private String m_ccct_tipocambioMSGERROR;
      private Boolean m_ctct_serieOK;
      private String m_ctct_serieMSGERROR;
      private Boolean m_ctct_numeroOK;
      private String m_ctct_numeroMSGERROR;
      private Boolean m_ccct_fechaOK;
      private String m_ccct_fechaMSGERROR;
      private Boolean m_ccct_fechavctoOK;
      private String m_ccct_fechavctoMSGERROR;
      private Boolean m_ccct_fechacancelOK;
      private String m_ccct_fechacancelMSGERROR;
      private Boolean m_ccct_valvtaOK;
      private String m_ccct_valvtaMSGERROR;
      private Boolean m_ccct_discrepanciaOK;
      private String m_ccct_discrepanciaMSGERROR;
      private Boolean m_ccct_imp1OK;
      private String m_ccct_imp1MSGERROR;
      private Boolean m_ccct_imp2OK;
      private String m_ccct_imp2MSGERROR;
      private Boolean m_ccct_imp3OK;
      private String m_ccct_imp3MSGERROR;
      private Boolean m_ccct_imp4OK;
      private String m_ccct_imp4MSGERROR;
      private Boolean m_docv_codigoOK;
      private String m_docv_codigoMSGERROR;
      private Boolean m_tipe_codigoOK;
      private String m_tipe_codigoMSGERROR;
      private Boolean m_entc_codigoOK;
      private String m_entc_codigoMSGERROR;
      private Boolean m_tipo_tabtdoOK;
      private String m_tipo_tabtdoMSGERROR;
      private Boolean m_tipo_tabmndOK;
      private String m_tipo_tabmndMSGERROR;
      private Boolean m_tipo_tabfpgOK;
      private String m_tipo_tabfpgMSGERROR;
      private Boolean m_tipo_codtdoOK;
      private String m_tipo_codtdoMSGERROR;
      private Boolean m_tipo_codmndOK;
      private String m_tipo_codmndMSGERROR;
      private Boolean m_tipo_codfpgOK;
      private String m_tipo_codfpgMSGERROR;
      private Boolean m_ccct_montoOK;
      private String m_ccct_montoMSGERROR;
      private Boolean m_audi_usrcreaOK;
      private String m_audi_usrcreaMSGERROR;
      private Boolean m_audi_feccreaOK;
      private String m_audi_feccreaMSGERROR;
      private Boolean m_audi_usrmodOK;
      private String m_audi_usrmodMSGERROR;
      private Boolean m_audi_fecmodOK;
      private String m_audi_fecmodMSGERROR;

      private Boolean m_ccct_codreferenciaOK;
      private String m_ccct_codreferenciaMSGERROR;
      private Boolean m_ccct_seriereferenciaOK;
      private String m_ccct_seriereferenciaMSGERROR;
      private Boolean m_ccct_numeroreferenciaOK;
      private String m_ccct_numeroreferenciaMSGERROR;
      private Boolean m_ccct_fechaemisionreferenciaOK;
      private String m_ccct_fechaemisionreferenciaMSGERROR;
      private Boolean m_tipo_codtdoreferenciaOK;
      private String m_tipo_codtdoreferenciaMSGERROR;

      private Boolean m_ccct_fecrecepcionOK;
      private String m_ccct_fecrecepcionMSGERROR;
      private Boolean m_ccct_cuentabiOK;
      private String m_ccct_cuentabiMSGERROR;
      private Boolean m_ccct_fecregOK;
      private String m_ccct_fecregMSGERROR;

      private Boolean m_ccct_glosaOK;
      private String m_ccct_glosaMSGERROR;

      #endregion

      #region [ Propiedades Validación ]
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Codigo.
      /// </summary>
      [DataMember]
      public Boolean CCCT_CodigoOK
      {
         get { return m_ccct_codigoOK; }
         set
         {
            if (m_ccct_codigoOK != value)
            {
               m_ccct_codigoOK = value;
               OnPropertyChanged("CCCT_CodigoOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_Codigo.
      /// </summary>
      [DataMember]
      public String CCCT_CodigoMSGERROR
      {
         get { return m_ccct_codigoMSGERROR; }
         set
         {
            if (m_ccct_codigoMSGERROR != value)
            {
               m_ccct_codigoMSGERROR = value;
               OnPropertyChanged("CCCT_CodigoMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_FechaEmision.
      /// </summary>
      [DataMember]
      public Boolean CCCT_FechaEmisionOK
      {
         get { return m_ccct_fechaemisionOK; }
         set
         {
            if (m_ccct_fechaemisionOK != value)
            {
               m_ccct_fechaemisionOK = value;
               OnPropertyChanged("CCCT_FechaEmisionOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_FechaEmision.
      /// </summary>
      [DataMember]
      public String CCCT_FechaEmisionMSGERROR
      {
         get { return m_ccct_fechaemisionMSGERROR; }
         set
         {
            if (m_ccct_fechaemisionMSGERROR != value)
            {
               m_ccct_fechaemisionMSGERROR = value;
               OnPropertyChanged("CCCT_FechaEmisionMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_TipoCambio.
      /// </summary>
      [DataMember]
      public Boolean CCCT_TipoCambioOK
      {
         get { return m_ccct_tipocambioOK; }
         set
         {
            if (m_ccct_tipocambioOK != value)
            {
               m_ccct_tipocambioOK = value;
               OnPropertyChanged("CCCT_TipoCambioOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_TipoCambio.
      /// </summary>
      [DataMember]
      public String CCCT_TipoCambioMSGERROR
      {
         get { return m_ccct_tipocambioMSGERROR; }
         set
         {
            if (m_ccct_tipocambioMSGERROR != value)
            {
               m_ccct_tipocambioMSGERROR = value;
               OnPropertyChanged("CCCT_TipoCambioMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CTCT_Serie.
      /// </summary>
      [DataMember]
      public Boolean CTCT_SerieOK
      {
         get { return m_ctct_serieOK; }
         set
         {
            if (m_ctct_serieOK != value)
            {
               m_ctct_serieOK = value;
               OnPropertyChanged("CTCT_SerieOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CTCT_Serie.
      /// </summary>
      [DataMember]
      public String CTCT_SerieMSGERROR
      {
         get { return m_ctct_serieMSGERROR; }
         set
         {
            if (m_ctct_serieMSGERROR != value)
            {
               m_ctct_serieMSGERROR = value;
               OnPropertyChanged("CTCT_SerieMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CTCT_Numero.
      /// </summary>
      [DataMember]
      public Boolean CTCT_NumeroOK
      {
         get { return m_ctct_numeroOK; }
         set
         {
            if (m_ctct_numeroOK != value)
            {
               m_ctct_numeroOK = value;
               OnPropertyChanged("CTCT_NumeroOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CTCT_Numero.
      /// </summary>
      [DataMember]
      public String CTCT_NumeroMSGERROR
      {
         get { return m_ctct_numeroMSGERROR; }
         set
         {
            if (m_ctct_numeroMSGERROR != value)
            {
               m_ctct_numeroMSGERROR = value;
               OnPropertyChanged("CTCT_NumeroMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Fecha.
      /// </summary>
      [DataMember]
      public Boolean CCCT_FechaOK
      {
         get { return m_ccct_fechaOK; }
         set
         {
            if (m_ccct_fechaOK != value)
            {
               m_ccct_fechaOK = value;
               OnPropertyChanged("CCCT_FechaOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_Fecha.
      /// </summary>
      [DataMember]
      public String CCCT_FechaMSGERROR
      {
         get { return m_ccct_fechaMSGERROR; }
         set
         {
            if (m_ccct_fechaMSGERROR != value)
            {
               m_ccct_fechaMSGERROR = value;
               OnPropertyChanged("CCCT_FechaMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_FechaVcto.
      /// </summary>
      [DataMember]
      public Boolean CCCT_FechaVctoOK
      {
         get { return m_ccct_fechavctoOK; }
         set
         {
            if (m_ccct_fechavctoOK != value)
            {
               m_ccct_fechavctoOK = value;
               OnPropertyChanged("CCCT_FechaVctoOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_FechaVcto.
      /// </summary>
      [DataMember]
      public String CCCT_FechaVctoMSGERROR
      {
         get { return m_ccct_fechavctoMSGERROR; }
         set
         {
            if (m_ccct_fechavctoMSGERROR != value)
            {
               m_ccct_fechavctoMSGERROR = value;
               OnPropertyChanged("CCCT_FechaVctoMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_FechaCancel.
      /// </summary>
      [DataMember]
      public Boolean CCCT_FechaCancelOK
      {
         get { return m_ccct_fechacancelOK; }
         set
         {
            if (m_ccct_fechacancelOK != value)
            {
               m_ccct_fechacancelOK = value;
               OnPropertyChanged("CCCT_FechaCancelOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_FechaCancel.
      /// </summary>
      [DataMember]
      public String CCCT_FechaCancelMSGERROR
      {
         get { return m_ccct_fechacancelMSGERROR; }
         set
         {
            if (m_ccct_fechacancelMSGERROR != value)
            {
               m_ccct_fechacancelMSGERROR = value;
               OnPropertyChanged("CCCT_FechaCancelMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_ValVta.
      /// </summary>
      [DataMember]
      public Boolean CCCT_ValVtaOK
      {
         get { return m_ccct_valvtaOK; }
         set
         {
            if (m_ccct_valvtaOK != value)
            {
               m_ccct_valvtaOK = value;
               OnPropertyChanged("CCCT_ValVtaOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_ValVta.
      /// </summary>
      [DataMember]
      public String CCCT_ValVtaMSGERROR
      {
         get { return m_ccct_valvtaMSGERROR; }
         set
         {
            if (m_ccct_valvtaMSGERROR != value)
            {
               m_ccct_valvtaMSGERROR = value;
               OnPropertyChanged("CCCT_ValVtaMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Discrepancia.
      /// </summary>
      [DataMember]
      public Boolean CCCT_DiscrepanciaOK
      {
          get { return m_ccct_discrepanciaOK; }
          set
          {
              if (m_ccct_discrepanciaOK != value)
              {
                  m_ccct_discrepanciaOK = value;
                  OnPropertyChanged("CCCT_DiscrepanciaOK");
              }
          }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_ValVta.
      /// </summary>
      [DataMember]
      public String CCCT_DiscrepanciaMSGERROR
      {
          get { return m_ccct_discrepanciaMSGERROR; }
          set
          {
              if (m_ccct_discrepanciaMSGERROR != value)
              {
                  m_ccct_discrepanciaMSGERROR = value;
                  OnPropertyChanged("CCCT_DiscrepanciaMSGERROR");
              }
          }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Imp1.
      /// </summary>
      [DataMember]
      public Boolean CCCT_Imp1OK
      {
         get { return m_ccct_imp1OK; }
         set
         {
            if (m_ccct_imp1OK != value)
            {
               m_ccct_imp1OK = value;
               OnPropertyChanged("CCCT_Imp1OK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_Imp1.
      /// </summary>
      [DataMember]
      public String CCCT_Imp1MSGERROR
      {
         get { return m_ccct_imp1MSGERROR; }
         set
         {
            if (m_ccct_imp1MSGERROR != value)
            {
               m_ccct_imp1MSGERROR = value;
               OnPropertyChanged("CCCT_Imp1MSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Imp2.
      /// </summary>
      [DataMember]
      public Boolean CCCT_Imp2OK
      {
         get { return m_ccct_imp2OK; }
         set
         {
            if (m_ccct_imp2OK != value)
            {
               m_ccct_imp2OK = value;
               OnPropertyChanged("CCCT_Imp2OK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_Imp2.
      /// </summary>
      [DataMember]
      public String CCCT_Imp2MSGERROR
      {
         get { return m_ccct_imp2MSGERROR; }
         set
         {
            if (m_ccct_imp2MSGERROR != value)
            {
               m_ccct_imp2MSGERROR = value;
               OnPropertyChanged("CCCT_Imp2MSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Imp3.
      /// </summary>
      [DataMember]
      public Boolean CCCT_Imp3OK
      {
         get { return m_ccct_imp3OK; }
         set
         {
            if (m_ccct_imp3OK != value)
            {
               m_ccct_imp3OK = value;
               OnPropertyChanged("CCCT_Imp3OK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_Imp3.
      /// </summary>
      [DataMember]
      public String CCCT_Imp3MSGERROR
      {
         get { return m_ccct_imp3MSGERROR; }
         set
         {
            if (m_ccct_imp3MSGERROR != value)
            {
               m_ccct_imp3MSGERROR = value;
               OnPropertyChanged("CCCT_Imp3MSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Imp4.
      /// </summary>
      [DataMember]
      public Boolean CCCT_Imp4OK
      {
         get { return m_ccct_imp4OK; }
         set
         {
            if (m_ccct_imp4OK != value)
            {
               m_ccct_imp4OK = value;
               OnPropertyChanged("CCCT_Imp4OK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_Imp4.
      /// </summary>
      [DataMember]
      public String CCCT_Imp4MSGERROR
      {
         get { return m_ccct_imp4MSGERROR; }
         set
         {
            if (m_ccct_imp4MSGERROR != value)
            {
               m_ccct_imp4MSGERROR = value;
               OnPropertyChanged("CCCT_Imp4MSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: DOCV_Codigo.
      /// </summary>
      [DataMember]
      public Boolean DOCV_CodigoOK
      {
         get { return m_docv_codigoOK; }
         set
         {
            if (m_docv_codigoOK != value)
            {
               m_docv_codigoOK = value;
               OnPropertyChanged("DOCV_CodigoOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: DOCV_Codigo.
      /// </summary>
      [DataMember]
      public String DOCV_CodigoMSGERROR
      {
         get { return m_docv_codigoMSGERROR; }
         set
         {
            if (m_docv_codigoMSGERROR != value)
            {
               m_docv_codigoMSGERROR = value;
               OnPropertyChanged("DOCV_CodigoMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPE_Codigo.
      /// </summary>
      [DataMember]
      public Boolean TIPE_CodigoOK
      {
         get { return m_tipe_codigoOK; }
         set
         {
            if (m_tipe_codigoOK != value)
            {
               m_tipe_codigoOK = value;
               OnPropertyChanged("TIPE_CodigoOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPE_Codigo.
      /// </summary>
      [DataMember]
      public String TIPE_CodigoMSGERROR
      {
         get { return m_tipe_codigoMSGERROR; }
         set
         {
            if (m_tipe_codigoMSGERROR != value)
            {
               m_tipe_codigoMSGERROR = value;
               OnPropertyChanged("TIPE_CodigoMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: ENTC_Codigo.
      /// </summary>
      [DataMember]
      public Boolean ENTC_CodigoOK
      {
         get { return m_entc_codigoOK; }
         set
         {
            if (m_entc_codigoOK != value)
            {
               m_entc_codigoOK = value;
               OnPropertyChanged("ENTC_CodigoOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: ENTC_Codigo.
      /// </summary>
      [DataMember]
      public String ENTC_CodigoMSGERROR
      {
         get { return m_entc_codigoMSGERROR; }
         set
         {
            if (m_entc_codigoMSGERROR != value)
            {
               m_entc_codigoMSGERROR = value;
               OnPropertyChanged("ENTC_CodigoMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_TabTDO.
      /// </summary>
      [DataMember]
      public Boolean TIPO_TabTDOOK
      {
         get { return m_tipo_tabtdoOK; }
         set
         {
            if (m_tipo_tabtdoOK != value)
            {
               m_tipo_tabtdoOK = value;
               OnPropertyChanged("TIPO_TabTDOOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabTDO.
      /// </summary>
      [DataMember]
      public String TIPO_TabTDOMSGERROR
      {
         get { return m_tipo_tabtdoMSGERROR; }
         set
         {
            if (m_tipo_tabtdoMSGERROR != value)
            {
               m_tipo_tabtdoMSGERROR = value;
               OnPropertyChanged("TIPO_TabTDOMSGERROR");
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
      /// Gets or sets el valor de validación de: TIPO_TabFPG.
      /// </summary>
      [DataMember]
      public Boolean TIPO_TabFPGOK
      {
         get { return m_tipo_tabfpgOK; }
         set
         {
            if (m_tipo_tabfpgOK != value)
            {
               m_tipo_tabfpgOK = value;
               OnPropertyChanged("TIPO_TabFPGOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_TabFPG.
      /// </summary>
      [DataMember]
      public String TIPO_TabFPGMSGERROR
      {
         get { return m_tipo_tabfpgMSGERROR; }
         set
         {
            if (m_tipo_tabfpgMSGERROR != value)
            {
               m_tipo_tabfpgMSGERROR = value;
               OnPropertyChanged("TIPO_TabFPGMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodTDO.
      /// </summary>
      [DataMember]
      public Boolean TIPO_CodTDOOK
      {
         get { return m_tipo_codtdoOK; }
         set
         {
            if (m_tipo_codtdoOK != value)
            {
               m_tipo_codtdoOK = value;
               OnPropertyChanged("TIPO_CodTDOOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodTDO.
      /// </summary>
      [DataMember]
      public String TIPO_CodTDOMSGERROR
      {
         get { return m_tipo_codtdoMSGERROR; }
         set
         {
            if (m_tipo_codtdoMSGERROR != value)
            {
               m_tipo_codtdoMSGERROR = value;
               OnPropertyChanged("TIPO_CodTDOMSGERROR");
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
      /// Gets or sets el valor de validación de: TIPO_CodFPG.
      /// </summary>
      [DataMember]
      public Boolean TIPO_CodFPGOK
      {
         get { return m_tipo_codfpgOK; }
         set
         {
            if (m_tipo_codfpgOK != value)
            {
               m_tipo_codfpgOK = value;
               OnPropertyChanged("TIPO_CodFPGOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodFPG.
      /// </summary>
      [DataMember]
      public String TIPO_CodFPGMSGERROR
      {
         get { return m_tipo_codfpgMSGERROR; }
         set
         {
            if (m_tipo_codfpgMSGERROR != value)
            {
               m_tipo_codfpgMSGERROR = value;
               OnPropertyChanged("TIPO_CodFPGMSGERROR");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Monto.
      /// </summary>
      [DataMember]
      public Boolean CCCT_MontoOK
      {
         get { return m_ccct_montoOK; }
         set
         {
            if (m_ccct_montoOK != value)
            {
               m_ccct_montoOK = value;
               OnPropertyChanged("CCCT_MontoOK");
            }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_Monto.
      /// </summary>
      [DataMember]
      public String CCCT_MontoMSGERROR
      {
         get { return m_ccct_montoMSGERROR; }
         set
         {
            if (m_ccct_montoMSGERROR != value)
            {
               m_ccct_montoMSGERROR = value;
               OnPropertyChanged("CCCT_MontoMSGERROR");
            }
         }
      }

      public String CCCT_FechaRecepcionMSGERROR
      {
         get { return m_ccct_fecrecepcionMSGERROR; }
         set
         {
            if (m_ccct_fecrecepcionMSGERROR != value)
            {
               m_ccct_fecrecepcionMSGERROR = value;
               OnPropertyChanged("CCCT_FechaRecepcionMSGERROR");
            }
         }
      }
      public Boolean CCCT_FechaRecepcionOK
      {
         get { return m_ccct_fecrecepcionOK; }
         set
         {
            if (m_ccct_fecrecepcionOK != value)
            {
               m_ccct_fecrecepcionOK = value;
               OnPropertyChanged("CCCT_FechaRecepcionOK");
            }
         }
      }

      public String TIPO_CodDetracMSGERROR { set; get; }

      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_CodReferencia.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCCT_CodReferenciaOK
      {
         get { return m_ccct_codreferenciaOK; }
         set
         {
            if (m_ccct_codreferenciaOK != value)
            { m_ccct_codreferenciaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_CodReferencia.
      /// </summary>
      [IgnoreDataMember]
      public String CCCT_CodReferenciaMSGERROR
      {
         get { return m_ccct_codreferenciaMSGERROR; }
         set
         {
            if (m_ccct_codreferenciaMSGERROR != value)
            { m_ccct_codreferenciaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_SerieReferencia.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCCT_SerieReferenciaOK
      {
         get { return m_ccct_seriereferenciaOK; }
         set
         {
            if (m_ccct_seriereferenciaOK != value)
            { m_ccct_seriereferenciaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_SerieReferencia.
      /// </summary>
      [IgnoreDataMember]
      public String CCCT_SerieReferenciaMSGERROR
      {
         get { return m_ccct_seriereferenciaMSGERROR; }
         set
         {
            if (m_ccct_seriereferenciaMSGERROR != value)
            { m_ccct_seriereferenciaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_NumeroReferencia.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCCT_NumeroReferenciaOK
      {
         get { return m_ccct_numeroreferenciaOK; }
         set
         {
            if (m_ccct_numeroreferenciaOK != value)
            { m_ccct_numeroreferenciaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_NumeroReferencia.
      /// </summary>
      [IgnoreDataMember]
      public String CCCT_NumeroReferenciaMSGERROR
      {
         get { return m_ccct_numeroreferenciaMSGERROR; }
         set
         {
            if (m_ccct_numeroreferenciaMSGERROR != value)
            { m_ccct_numeroreferenciaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_FechaEmisionReferencia.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCCT_FechaEmisionReferenciaOK
      {
         get { return m_ccct_fechaemisionreferenciaOK; }
         set
         {
            if (m_ccct_fechaemisionreferenciaOK != value)
            { m_ccct_fechaemisionreferenciaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_FechaEmisionReferencia.
      /// </summary>
      [IgnoreDataMember]
      public String CCCT_FechaEmisionReferenciaMSGERROR
      {
         get { return m_ccct_fechaemisionreferenciaMSGERROR; }
         set
         {
            if (m_ccct_fechaemisionreferenciaMSGERROR != value)
            { m_ccct_fechaemisionreferenciaMSGERROR = value; }
         }
      }
      /// <summary>
      /// Gets or sets el valor de validación de: TIPO_CodTDOReferencia.
      /// </summary>
      [IgnoreDataMember]
      public Boolean TIPO_CodTDOReferenciaOK
      {
         get { return m_tipo_codtdoreferenciaOK; }
         set
         {
            if (m_tipo_codtdoreferenciaOK != value)
            { m_tipo_codtdoreferenciaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: TIPO_CodTDOReferencia.
      /// </summary>
      [IgnoreDataMember]
      public String TIPO_CodTDOReferenciaMSGERROR
      {
         get { return m_tipo_codtdoreferenciaMSGERROR; }
         set
         {
            if (m_tipo_codtdoreferenciaMSGERROR != value)
            { m_tipo_codtdoreferenciaMSGERROR = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_CuentaBI.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCCT_CuentaBIOK
      {
         get { return m_ccct_cuentabiOK; }
         set
         {
            if (m_ccct_cuentabiOK != value)
            { m_ccct_cuentabiOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_CuentaBI.
      /// </summary>
      [IgnoreDataMember]
      public String CCCT_CuentaBIMSGERROR
      {
         get { return m_ccct_cuentabiMSGERROR; }
         set
         {
            if (m_ccct_cuentabiMSGERROR != value)
            { m_ccct_cuentabiMSGERROR = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_FecReg.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCCT_FecRegOK
      {
         get { return m_ccct_fecregOK; }
         set
         {
            if (m_ccct_fecregOK != value)
            { m_ccct_fecregOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_FecReg.
      /// </summary>
      [IgnoreDataMember]
      public String CCCT_FecRegMSGERROR
      {
         get { return m_ccct_fecregMSGERROR; }
         set
         {
            if (m_ccct_fecregMSGERROR != value)
            { m_ccct_fecregMSGERROR = value; }
         }
      }

      /// <summary>
      /// Gets or sets el valor de validación de: CCCT_Glosa.
      /// </summary>
      [IgnoreDataMember]
      public Boolean CCCT_GlosaOK
      {
         get { return m_ccct_glosaOK; }
         set
         {
            if (m_ccct_glosaOK != value)
            { m_ccct_glosaOK = value; }
         }
      }
      /// <summary>
      /// Gets or sets el mensaje de validación de: CCCT_Glosa.
      /// </summary>
      [IgnoreDataMember]
      public String CCCT_GlosaMSGERROR
      {
         get { return m_ccct_glosaMSGERROR; }
         set
         {
            if (m_ccct_glosaMSGERROR != value)
            { m_ccct_glosaMSGERROR = value; }
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

      public void SetMensajeError(String x_msg)
      {
         if (String.IsNullOrEmpty(m_mensajeError)) { m_mensajeError = ""; }
         m_mensajeError += Environment.NewLine + x_msg;
      }

      public Boolean Validar()
      {
         try
         {
            Boolean _isCorrect = true;
            m_mensajeError = "";
            CCCT_CodigoOK = true;
            CCCT_CodigoMSGERROR = "";
            //if( CCCT_Codigo == null)
            //{
            //   _isCorrect = false;
            //   CCCT_CodigoOK  = false;
            //   CCCT_CodigoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCCT_Codigo", "CtaCte");
            //   m_mensajeError += "* Debe ingresar el campo CCCT_Codigo" + Environment.NewLine;
            //}
            CCCT_FechaEmisionOK = true;
            CCCT_FechaEmisionMSGERROR = "";
            //if( CCCT_FechaEmision == null)
            //{
            //   _isCorrect = false;
            //   CCCT_FechaEmisionOK  = false;
            //   CCCT_FechaEmisionMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Fecha de Emisión", "CtaCte");
            //   m_mensajeError += "* Debe ingresar el campo CCCT_FechaEmision" + Environment.NewLine;
            //}
            CCCT_TipoCambioOK = true;
            CCCT_TipoCambioMSGERROR = "";
            if (CCCT_TipoCambio == null)
            {
               _isCorrect = false;
               CCCT_TipoCambioOK = false;
               CCCT_TipoCambioMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Tipo Cambio", "Documento");
               m_mensajeError += "* Debe ingresar el Tipo Cambio del Documento" + Environment.NewLine;
            }

            

            CTCT_SerieOK = true;
            CTCT_SerieMSGERROR = "";
            if (Infrastructure.Aspect.Constants.Util.ValidarObligatorio_Serie(TIPO_CodTDO_CodSunat))
            {
               if (String.IsNullOrEmpty(CCCT_Serie))
               {
                  _isCorrect = false;
                  CTCT_SerieOK = false;
                  CTCT_SerieMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Serie", "Documento");
                  m_mensajeError += "* Debe ingresar la Serie del Documento" + Environment.NewLine;
               }
            }
            CTCT_NumeroOK = true;
            CTCT_NumeroMSGERROR = "";
            if (Infrastructure.Aspect.Constants.Util.ValidarObligatorio_Numero(TIPO_CodTDO_CodSunat))
            {
               if (String.IsNullOrEmpty(CCCT_Numero))
               {
                  _isCorrect = false;
                  CTCT_NumeroOK = false;
                  CTCT_NumeroMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Numero", "Documento");
                  m_mensajeError += "* Debe ingresar el Numero del Documento " + Environment.NewLine;
               }
            }

            if (TIPE_Codigo != 1)
            {
               TIPO_CodDetracMSGERROR = "";
               if (String.IsNullOrEmpty(TIPO_CodDetrac))
               {
                  _isCorrect = false;
                  TIPO_CodDetracMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo de Detracción", "Documento");
                  m_mensajeError += "* Debe seleccionar el Tipo de Detracción del Documento" + Environment.NewLine;
               }
            }

            CCCT_FechaEmisionOK = true;
            CCCT_FechaEmisionMSGERROR = "";
            if (CCCT_FechaEmision == null)
            {
               _isCorrect = false;
               CCCT_FechaEmisionOK = false;
               CCCT_FechaEmisionMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha de Emision", "Documento");
               m_mensajeError += "* Debe ingresar la Fecha de Emision del Documento" + Environment.NewLine;
            }
            CCCT_FechaVctoOK = true;
            CCCT_FechaVctoMSGERROR = "";
            //if( CCCT_FechaVcto == null)
            //{
            //   _isCorrect = false;
            //   CCCT_FechaVctoOK  = false;
            //   CCCT_FechaVctoMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Fecha de Vencimiento", "CtaCte");
            //   m_mensajeError += "* Debe ingresar el campo CCCT_FechaVcto" + Environment.NewLine;
            //}
            CCCT_ValVtaOK = true;
            CCCT_ValVtaMSGERROR = "";
            if (CCCT_ValVta == 0)
            {
               _isCorrect = false;
               CCCT_ValVtaOK = false;
               CCCT_ValVtaMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Base Imponible", "Documento");
               m_mensajeError += "* Debe ingresar la Base Imponible del Documento" + Environment.NewLine;
            }
            //CCCT_Imp1OK  = true;
            //CCCT_Imp1MSGERROR  = "";
            //if( CCCT_Imp1 == 0)
            //{
            //   _isCorrect = false;
            //   CCCT_Imp1OK  = false;
            //   CCCT_Imp1MSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "CCCT_Imp1", "CtaCte");
            //   m_mensajeError += "* Debe ingresar el campo CCCT_Imp1" + Environment.NewLine;
            //}
            TIPE_CodigoOK = true;
            TIPE_CodigoMSGERROR = "";
            if (TIPE_Codigo == null)
            {
               _isCorrect = false;
               TIPE_CodigoOK = false;
               TIPE_CodigoMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo de Entidad", "Documento");
               m_mensajeError += "* Debe seleccionar el Tipo de Entidad del Documento" + Environment.NewLine;
            }
            ENTC_CodigoOK = true;
            ENTC_CodigoMSGERROR = "";
            if (ENTC_Codigo == null)
            {
               _isCorrect = false;
               ENTC_CodigoOK = false;
               ENTC_CodigoMSGERROR = String.Format("Debe seleccionar la {0} del {1}.", "Entidad", "Documento");
               m_mensajeError += "* Debe seleccionar la Entidad del Documento" + Environment.NewLine;
            }
            TIPO_TabTDOOK = true;
            TIPO_TabTDOMSGERROR = "";
            //if( String.IsNullOrEmpty(TIPO_TabTDO) )
            //{
            //   _isCorrect = false;
            //   TIPO_TabTDOOK  = false;
            //   TIPO_TabTDOMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Documento", "CtaCte");
            //   m_mensajeError += "* Debe ingresar el campo Tipo de Documento" + Environment.NewLine;
            //}
            TIPO_TabMNDOK = true;
            TIPO_TabMNDMSGERROR = "";
            //if( String.IsNullOrEmpty(TIPO_TabMND) )
            //{
            //   _isCorrect = false;
            //   TIPO_TabMNDOK  = false;
            //   TIPO_TabMNDMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Tipo de Moneda", "CtaCte");
            //   m_mensajeError += "* Debe ingresar el campo TIPO_TabMND" + Environment.NewLine;
            //}
            TIPO_TabFPGOK = true;
            TIPO_TabFPGMSGERROR = "";
            //if( String.IsNullOrEmpty(TIPO_TabFPG) )
            //{
            //   _isCorrect = false;
            //   TIPO_TabFPGOK  = false;
            //   TIPO_TabFPGMSGERROR  = String.Format("Debe ingresar el {0} de la {1}.", "Forma de Pago", "CtaCte");
            //   m_mensajeError += "* Debe ingresar el campo TIPO_TabFPG" + Environment.NewLine;
            //}
            TIPO_CodTDOOK = true;
            TIPO_CodTDOMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_CodTDO))
            {
               _isCorrect = false;
               TIPO_CodTDOOK = false;
               TIPO_CodTDOMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo de Documento", "Documento");
               m_mensajeError += "* Debe seleccionar el Tipo de Documento del Documento" + Environment.NewLine;
            }
            TIPO_CodMNDOK = true;
            TIPO_CodMNDMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_CodMND))
            {
               _isCorrect = false;
               TIPO_CodMNDOK = false;
               TIPO_CodMNDMSGERROR = String.Format("Debe seleccionar el {0} del {1}.", "Tipo de Moneda", "Documento");
               m_mensajeError += "* Debe seleccionar el Tipo de Moneda del Documento" + Environment.NewLine;
            }
            TIPO_CodFPGOK = true;
            TIPO_CodFPGMSGERROR = "";
            if (String.IsNullOrEmpty(TIPO_CodFPG))
            {
               _isCorrect = false;
               TIPO_CodFPGOK = false;
               TIPO_CodFPGMSGERROR = String.Format("Debe ingresar el {0} de la {1}.", "Forma de Pago", "Documento");
               m_mensajeError += "* Debe ingresar el campo Forma de Pago" + Environment.NewLine;
            }

            CCCT_GlosaOK = true;
            CCCT_GlosaMSGERROR = "";
            if (String.IsNullOrEmpty(CCCT_Glosa))
            {
               _isCorrect = false;
               CCCT_GlosaOK = false;
               CCCT_GlosaMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Glosa", "Documento");
               m_mensajeError += "* Debe ingresar el campo Glosa" + Environment.NewLine;
            }

            CCCT_FechaRecepcionOK = true;
            CCCT_FechaRecepcionMSGERROR = "";
            if (CCCT_FechaRecepcion == null)
            {
               _isCorrect = false;
               CCCT_FechaRecepcionOK = false;
               CCCT_FechaRecepcionMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha de Recepción", "Documento");
               m_mensajeError += "* Debe ingresar la Fecha de Recepción del Documento" + Environment.NewLine;
            }

            CCCT_MontoOK = true;
            CCCT_MontoMSGERROR = "";
            if (!CCCT_Monto.HasValue)
            {
               _isCorrect = false;
               CCCT_MontoOK = false;
               CCCT_MontoMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Monto", "Documento");
               m_mensajeError += "* Debe ingresar el Monto del Documentos" + Environment.NewLine;
            }
            else
            {
               if (CCCT_Monto.Value == 0)
               {
                  _isCorrect = false;
                  CCCT_MontoOK = false;
                  CCCT_MontoMSGERROR = String.Format("El valor del {0} del {1} debe ser diferente a cero.", "Monto", "Documento");
                  m_mensajeError += "* Debe ingresar un Monto mayor a cero" + Environment.NewLine;
               }
            }

            /* Validar Nota de Credito*/
            if (!String.IsNullOrEmpty(TIPO_CodTDO) && TIPO_CodTDO.Equals(Tipos.GetTipo(Tipos.TipoTDO.NotaCredito)))
            {
               CCCT_SerieReferenciaOK = true;
               CCCT_SerieReferenciaMSGERROR = "";
               if (String.IsNullOrEmpty(CCCT_SerieReferencia))
               {
                  _isCorrect = false;
                  CCCT_SerieReferenciaOK = false;
                  CCCT_SerieReferenciaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Número de Serie", "Documento de referencia");
                  m_mensajeError += "* Debe ingresar el Número de Serie del Documento de referencia" + Environment.NewLine;
               }
               CCCT_NumeroReferenciaOK = true;
               CCCT_NumeroReferenciaMSGERROR = "";
               if (String.IsNullOrEmpty(CCCT_NumeroReferencia))
               {
                  _isCorrect = false;
                  CCCT_NumeroReferenciaOK = false;
                  CCCT_NumeroReferenciaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Número", "Documento de referencia");
                  m_mensajeError += "* Debe ingresar el Número del Documento de referencia" + Environment.NewLine;
               }
               CCCT_FechaEmisionReferenciaOK = true;
               CCCT_FechaEmisionReferenciaMSGERROR = "";
               if (CCCT_FechaEmisionReferencia == null)
               {
                  _isCorrect = false;
                  CCCT_FechaEmisionReferenciaOK = false;
                  CCCT_FechaEmisionReferenciaMSGERROR = String.Format("Debe ingresar la {0} del {1}.", "Fecha de Emisión", "Documento de referencia");
                  m_mensajeError += "* Debe ingresar la Fecha de Emisión del Documento de referencia" + Environment.NewLine;
               }
               TIPO_CodTDOReferenciaOK = true;
               TIPO_CodTDOReferenciaMSGERROR = "";
               if (String.IsNullOrEmpty(TIPO_CodTDOReferencia))
               {
                  _isCorrect = false;
                  TIPO_CodTDOReferenciaOK = false;
                  TIPO_CodTDOReferenciaMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Tipo", "Documento de referencia");
                  m_mensajeError += "* Debe ingresar el Tipo del Documento de referencia" + Environment.NewLine;
               }
            }

            CCCT_CuentaBIOK = true;
            CCCT_CuentaBIMSGERROR = "";
            if (ListDetCtaCteAsientos != null)
            {
               //if (ListDetCtaCteAsientos.Count == 0)
               //{
               //   if (String.IsNullOrEmpty(CCCT_CuentaBI))
               //   {
               //      CCCT_CuentaBIOK = false;
               //      CCCT_CuentaBIMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "La Cuenta de Base Imponible", "Documento");
               //      m_mensajeError += String.Format("- Debe Ingresar la cuenta en la Base Imponible {0}", Environment.NewLine);
               //   }
               //}
            }

            CCCT_FecRegOK = true;
            CCCT_FecRegMSGERROR = "";
            if (!CCCT_FecReg.HasValue)
            {
               CCCT_FecRegOK = false;
               CCCT_FecRegMSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Fecha de Registro", "Documento");
               m_mensajeError += String.Format("- Debe Ingresar la Fecha de Registro{0}", Environment.NewLine);
               _isCorrect = false;
            }

            CCCT_Imp4OK = true;
            CCCT_Imp4MSGERROR = "";
            if (CCCT_Imp4.HasValue && CCCT_Imp4.Value > 0)
            {
               CCCT_Imp4OK = false;
               CCCT_Imp4MSGERROR = String.Format("Debe ingresar el {0} del {1}.", "Impuesto de 4ta", "Documento");
               m_mensajeError += String.Format("- Debe Ingresar el Impuesto de 4ta debe ser un numero negativo{0}", Environment.NewLine);
               _isCorrect = false;
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
