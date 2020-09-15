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
   public partial class NaveViaje : MasterBusinessEntity, INotifyPropertyChanged
   {
      #region [ Variables ]
      private Int32 m_nvia_codigo;
      private String m_nvia_nroviaje;
      private Nullable<DateTime> m_nvia_feceta_impo_etd_expo;
      private Nullable<Int32> m_entc_codagenteport_expo;
      private Nullable<Int32> m_entc_codtransportista;
      private Nullable<Int16> m_nave_codigo;

      private Nullable<DateTime> m_nvia_feccutoff_expo;
      private Nullable<Int32> m_puer_codigo;
      private String m_tipo_tabtrf;
      private String m_tipo_codtrf;
      private String m_cons_tabrgm;
      private String m_cons_codrgm;

      private Nullable<Int32> m_entc_codtermport;
      private Nullable<DateTime> m_nvia_feccierre;
      private Nullable<DateTime> m_nvia_fecllega_impo_zarpe_expo;
        private Nullable<DateTime> m_nvia_fecllega_expo_zarpe_impo;
        private String m_cons_tabvia;
      private String m_cons_codvia;
      private String m_nvia_estado;
      private Nullable<DateTime> m_nvia_feccierredire_impo_termemba_expo;
        private Nullable<DateTime> m_nvia_fecplazovistobueno;

      private Nullable<DateTime> m_nvia_fecdescarga_impo;
      private Nullable<Int32> m_entc_codagenportvobo_impo;
      private Nullable<Int32> m_entc_codagenportvobo2_impo;
      private Nullable<DateTime> m_entc_fecrecogerdocs;
      private String m_nvia_usrprefactura;
      private Nullable<DateTime> m_nvia_fecprefactura;
      private String m_nvia_usrcierrenave;
      private Nullable<DateTime> m_nvia_feccierrenave;
      private String m_nvia_nromanifiesto;
      private String m_nvia_normanifiestodescon;
      private String m_nvia_usremitestatment;
      private Nullable<DateTime> m_nvia_fecemitestatment;
      private Boolean m_nvia_emitiostatment;

      private String m_caba_ano;
      private String m_caba_mes;
      private String m_tipo_tabreg;
      private String m_tipo_codreg;
      private String m_caba_nrovoucher;

      private DateTime m_audi_feccrea;
      private String m_audi_usrcrea;
      private Nullable<DateTime> m_audi_fecmod;
      private String m_audi_usrmod;
      #endregion

      #region [ Constructores ]
      /// <summary>
      /// Inicializar una nueva instancia de la clase NaveViaje.
      /// </summary>
      public NaveViaje()
      { }
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: NVIA_Codigo.
      /// </summary>
      [DataMember]
      public Int32 NVIA_Codigo
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
      /// Gets or sets el valor de: NVIA_NroViaje.
      /// </summary>
      [DataMember]
      public String NVIA_NroViaje
      {
         get { return m_nvia_nroviaje; }
         set
         {
            if (m_nvia_nroviaje != value)
            {
               m_nvia_nroviaje = value;
               OnPropertyChanged("NVIA_NroViaje");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecETA_IMPO_ETD_EXPO.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecETA_IMPO_ETD_EXPO
      {
         get { return m_nvia_feceta_impo_etd_expo; }
         set
         {
            if (m_nvia_feceta_impo_etd_expo != value)
            {
               m_nvia_feceta_impo_etd_expo = value;
               OnPropertyChanged("NVIA_FecETA_IMPO_ETD_EXPO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodAgentePort_EXPO.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodAgentePort_EXPO
      {
         get { return m_entc_codagenteport_expo; }
         set
         {
            if (m_entc_codagenteport_expo != value)
            {
               m_entc_codagenteport_expo = value;
               OnPropertyChanged("ENTC_CodAgentePort_EXPO");
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
      /// Gets or sets el valor de: NAVE_Codigo.
      /// </summary>
      [DataMember]
      public Nullable<Int16> NAVE_Codigo
      {
         get { return m_nave_codigo; }
         set
         {
            if (m_nave_codigo != value)
            {
               m_nave_codigo = value;
               OnPropertyChanged("NAVE_Codigo");
            }
         }
      }

      /// <summary>
      /// Gets or sets el valor de: NVIA_FecCutOff_EXPO.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecCutOff_EXPO
      {
         get { return m_nvia_feccutoff_expo; }
         set
         {
            if (m_nvia_feccutoff_expo != value)
            {
               m_nvia_feccutoff_expo = value;
               OnPropertyChanged("NVIA_FecCutOff_EXPO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: PUER_Codigo.
      /// </summary>
      [DataMember]
      public Nullable<Int32> PUER_Codigo
      {
         get { return m_puer_codigo; }
         set
         {
            if (m_puer_codigo != value)
            {
               m_puer_codigo = value;
               OnPropertyChanged("PUER_Codigo");
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
            if (m_tipo_tabtrf != value)
            {
               m_tipo_tabtrf = value;
               OnPropertyChanged("TIPO_TabTRF");
            }
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
            if (m_tipo_codtrf != value)
            {
               m_tipo_codtrf = value;
               OnPropertyChanged("TIPO_CodTRF");
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
      /// Gets or sets el valor de: ENTC_CodTermPort.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodTermPort
      {
         get { return m_entc_codtermport; }
         set
         {
            if (m_entc_codtermport != value)
            {
               m_entc_codtermport = value;
               OnPropertyChanged("ENTC_CodTermPort");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecCierre.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecCierre
      {
         get { return m_nvia_feccierre; }
         set
         {
            if (m_nvia_feccierre != value)
            {
               m_nvia_feccierre = value;
               OnPropertyChanged("NVIA_FecCierre");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecLlega_IMPO_Zarpe_EXPO.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecLlega_IMPO_Zarpe_EXPO
      {
         get { return m_nvia_fecllega_impo_zarpe_expo; }
         set
         {
            if (m_nvia_fecllega_impo_zarpe_expo != value)
            {
               m_nvia_fecllega_impo_zarpe_expo = value;
               OnPropertyChanged("NVIA_FecLlega_IMPO_Zarpe_EXPO");
            }
         }
      }

        /// <summary>
        /// Gets or sets el valor de: NVIA_FecLlega_Expo_Zarpe_IMPO.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> NVIA_FecLlega_Expo_Zarpe_IMPO
        {
            get { return m_nvia_fecllega_expo_zarpe_impo; }
            set
            {
                if (m_nvia_fecllega_expo_zarpe_impo != value)
                {
                    m_nvia_fecllega_expo_zarpe_impo = value;
                    OnPropertyChanged("NVIA_FecLlega_Expo_Zarpe_IMPO");
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
      /// Gets or sets el valor de: NVIA_Estado.
      /// </summary>
      [DataMember]
      public String NVIA_Estado
      {
         get { return m_nvia_estado; }
         set
         {
            if (m_nvia_estado != value)
            {
               m_nvia_estado = value;
               OnPropertyChanged("NVIA_Estado");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecCierreDire_IMPO_TermEmba_EXPO.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecCierreDire_IMPO_TermEmba_EXPO
      {
         get { return m_nvia_feccierredire_impo_termemba_expo; }
         set
         {
            if (m_nvia_feccierredire_impo_termemba_expo != value)
            {
               m_nvia_feccierredire_impo_termemba_expo = value;
               OnPropertyChanged("NVIA_FecCierreDire_IMPO_TermEmba_EXPO");
            }
         }
      }

        /// <summary>
        /// Gets or sets el valor de: NVIA_FecPlazoVistoBueno.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> NVIA_FecPlazoVistoBueno
        {
            get { return m_nvia_fecplazovistobueno; }
            set
            {
                if (m_nvia_fecplazovistobueno != value)
                {
                    m_nvia_fecplazovistobueno = value;
                    OnPropertyChanged("NVIA_FecPlazoVistoBueno");
                }
            }
        }

        /// <summary>
        /// Gets or sets el valor de: NVIA_FecDescarga_IMPO.
        /// </summary>
        [DataMember]
      public Nullable<DateTime> NVIA_FecDescarga_IMPO
      {
         get { return m_nvia_fecdescarga_impo; }
         set
         {
            if (m_nvia_fecdescarga_impo != value)
            {
               m_nvia_fecdescarga_impo = value;
               OnPropertyChanged("NVIA_FecDescarga_IMPO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodAgenPortVoBo_IMPO.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodAgenPortVoBo_IMPO
      {
         get { return m_entc_codagenportvobo_impo; }
         set
         {
            if (m_entc_codagenportvobo_impo != value)
            {
               m_entc_codagenportvobo_impo = value;
               OnPropertyChanged("ENTC_CodAgenPortVoBo_IMPO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_CodAgenPortVoBo2_IMPO.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_CodAgenPortVoBo2_IMPO
      {
         get { return m_entc_codagenportvobo2_impo; }
         set
         {
            if (m_entc_codagenportvobo2_impo != value)
            {
               m_entc_codagenportvobo2_impo = value;
               OnPropertyChanged("ENTC_CodAgenPortVoBo2_IMPO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_FecRecogerDocs.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> ENTC_FecRecogerDocs
      {
         get { return m_entc_fecrecogerdocs; }
         set
         {
            if (m_entc_fecrecogerdocs != value)
            {
               m_entc_fecrecogerdocs = value;
               OnPropertyChanged("ENTC_FecRecogerDocs");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_UsrPreFactura.
      /// </summary>
      [DataMember]
      public String NVIA_UsrPreFactura
      {
         get { return m_nvia_usrprefactura; }
         set
         {
            if (m_nvia_usrprefactura != value)
            {
               m_nvia_usrprefactura = value;
               OnPropertyChanged("NVIA_UsrPreFactura");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecPreFactura.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecPreFactura
      {
         get { return m_nvia_fecprefactura; }
         set
         {
            if (m_nvia_fecprefactura != value)
            {
               m_nvia_fecprefactura = value;
               OnPropertyChanged("NVIA_FecPreFactura");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_UsrCierreNave.
      /// </summary>
      [DataMember]
      public String NVIA_UsrCierreNave
      {
         get { return m_nvia_usrcierrenave; }
         set
         {
            if (m_nvia_usrcierrenave != value)
            {
               m_nvia_usrcierrenave = value;
               OnPropertyChanged("NVIA_UsrCierreNave");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecCierreNave.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecCierreNave
      {
         get { return m_nvia_feccierrenave; }
         set
         {
            if (m_nvia_feccierrenave != value)
            {
               m_nvia_feccierrenave = value;
               OnPropertyChanged("NVIA_FecCierreNave");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_NroManifiesto.
      /// </summary>
      [DataMember]
      public String NVIA_NroManifiesto
      {
         get { return m_nvia_nromanifiesto; }
         set
         {
            if (m_nvia_nromanifiesto != value)
            {
               m_nvia_nromanifiesto = value;
               OnPropertyChanged("NVIA_NroManifiesto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_NorManifiestoDescon.
      /// </summary>
      [DataMember]
      public String NVIA_NorManifiestoDescon
      {
         get { return m_nvia_normanifiestodescon; }
         set
         {
            if (m_nvia_normanifiestodescon != value)
            {
               m_nvia_normanifiestodescon = value;
               OnPropertyChanged("NVIA_NorManifiestoDescon");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_UsrEmiteStatment.
      /// </summary>
      [DataMember]
      public String NVIA_UsrEmiteStatment
      {
         get { return m_nvia_usremitestatment; }
         set
         {
            if (m_nvia_usremitestatment != value)
            {
               m_nvia_usremitestatment = value;
               OnPropertyChanged("NVIA_UsrEmiteStatment");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_FecEmiteStatment.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> NVIA_FecEmiteStatment
      {
         get { return m_nvia_fecemitestatment; }
         set
         {
            if (m_nvia_fecemitestatment != value)
            {
               m_nvia_fecemitestatment = value;
               OnPropertyChanged("NVIA_FecEmiteStatment");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: NVIA_EmitioStatment.
      /// </summary>
      [DataMember]
      public Boolean NVIA_EmitioStatment
      {
         get { return m_nvia_emitiostatment; }
         set
         {
            if (m_nvia_emitiostatment != value)
            {
               m_nvia_emitiostatment = value;
               OnPropertyChanged("NVIA_EmitioStatment");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_Ano.
      /// </summary>
      [DataMember]
      public String CABA_Ano
      {
         get { return m_caba_ano; }
         set
         {
            if (m_caba_ano != value)
            {
               m_caba_ano = value;
               OnPropertyChanged("CABA_Ano");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_Mes.
      /// </summary>
      [DataMember]
      public String CABA_Mes
      {
         get { return m_caba_mes; }
         set
         {
            if (m_caba_mes != value)
            {
               m_caba_mes = value;
               OnPropertyChanged("CABA_Mes");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabREG.
      /// </summary>
      [DataMember]
      public String TIPO_TabREG
      {
         get { return m_tipo_tabreg; }
         set
         {
            if (m_tipo_tabreg != value)
            {
               m_tipo_tabreg = value;
               OnPropertyChanged("TIPO_TabREG");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodREG.
      /// </summary>
      [DataMember]
      public String TIPO_CodREG
      {
         get { return m_tipo_codreg; }
         set
         {
            if (m_tipo_codreg != value)
            {
               m_tipo_codreg = value;
               OnPropertyChanged("TIPO_CodREG");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_NroVoucher.
      /// </summary>
      [DataMember]
      public String CABA_NroVoucher
      {
         get { return m_caba_nrovoucher; }
         set
         {
            if (m_caba_nrovoucher != value)
            {
               m_caba_nrovoucher = value;
               OnPropertyChanged("CABA_NroVoucher");
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
      #endregion

      #region [ CopyTo ]
      public void CopyTo(ref NaveViaje Item)
      {
         try
         {
            if (Item == null) { Item = new NaveViaje(); }
            Item.NVIA_Codigo = this.NVIA_Codigo;
            Item.NVIA_NroViaje = this.NVIA_NroViaje;
            Item.NVIA_FecETA_IMPO_ETD_EXPO = this.NVIA_FecETA_IMPO_ETD_EXPO;
            Item.ENTC_CodAgentePort_EXPO = this.ENTC_CodAgentePort_EXPO;
            Item.ENTC_CodTransportista = this.ENTC_CodTransportista;
            Item.NAVE_Codigo = this.NAVE_Codigo;
            Item.NVIA_FecCutOff_EXPO = this.NVIA_FecCutOff_EXPO;
            Item.PUER_Codigo = this.PUER_Codigo;
            Item.TIPO_TabTRF = this.TIPO_TabTRF;
            Item.TIPO_CodTRF = this.TIPO_CodTRF;

            Item.CONS_TabRGM = this.CONS_TabRGM;
            Item.CONS_CodRGM = this.CONS_CodRGM;
            Item.ENTC_CodTermPort = this.ENTC_CodTermPort;
            Item.NVIA_FecCierre = this.NVIA_FecCierre;
            Item.NVIA_FecLlega_IMPO_Zarpe_EXPO = this.NVIA_FecLlega_IMPO_Zarpe_EXPO;
                Item.NVIA_FecLlega_Expo_Zarpe_IMPO = this.NVIA_FecLlega_Expo_Zarpe_IMPO;
                Item.CONS_TabVia = this.CONS_TabVia;
            Item.CONS_CodVia = this.CONS_CodVia;
            Item.NVIA_Estado = this.NVIA_Estado;
            Item.NVIA_FecCierreDire_IMPO_TermEmba_EXPO = this.NVIA_FecCierreDire_IMPO_TermEmba_EXPO;
            Item.NVIA_FecDescarga_IMPO = this.NVIA_FecDescarga_IMPO;
            Item.ENTC_CodAgenPortVoBo_IMPO = this.ENTC_CodAgenPortVoBo_IMPO;
            Item.ENTC_CodAgenPortVoBo2_IMPO = this.ENTC_CodAgenPortVoBo2_IMPO;
            Item.ENTC_FecRecogerDocs = this.ENTC_FecRecogerDocs;
            Item.NVIA_UsrPreFactura = this.NVIA_UsrPreFactura;
            Item.NVIA_FecPreFactura = this.NVIA_FecPreFactura;
            Item.NVIA_UsrCierreNave = this.NVIA_UsrCierreNave;
            Item.NVIA_FecCierreNave = this.NVIA_FecCierreNave;
            Item.NVIA_NroManifiesto = this.NVIA_NroManifiesto;
            Item.NVIA_NorManifiestoDescon = this.NVIA_NorManifiestoDescon;
            Item.NVIA_UsrEmiteStatment = this.NVIA_UsrEmiteStatment;
            Item.NVIA_FecEmiteStatment = this.NVIA_FecEmiteStatment;
            Item.NVIA_EmitioStatment = this.NVIA_EmitioStatment;
            Item.CABA_Ano = this.CABA_Ano;
            Item.CABA_Mes = this.CABA_Mes;
            Item.TIPO_TabREG = this.TIPO_TabREG;
            Item.TIPO_CodREG = this.TIPO_CodREG;
            Item.CABA_NroVoucher = this.CABA_NroVoucher;

         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
