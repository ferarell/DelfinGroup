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
   public partial class CtaCte : MasterBusinessEntity, INotifyPropertyChanged
   {
      #region [ Variables ]
      private Int16 m_empr_codigo;
      private Int32 m_ccct_codigo;
      private Nullable<Int16> m_sucr_codigo;
      private Nullable<Int32> m_docv_codigo;
      private Nullable<Int16> m_tipe_codigo;
      private Nullable<Int32> m_entc_codigo;
      private String m_tipo_tabtdo;
      private String m_tipo_tabmnd;
      private String m_tipo_tabfpg;
      private String m_tipo_codtdo;
      private String m_tipo_codmnd;
      private String m_tipo_codfpg;
      private String m_ccct_serie;
      private String m_ccct_numero;
      private String m_ccct_asientocontable;
      private Nullable<DateTime> m_ccct_fechaemision;
      private Nullable<Decimal> m_ccct_tipocambio;
      private Nullable<DateTime> m_ccct_fecharecepcion;
      private Nullable<DateTime> m_ccct_fechavcto;
      private Nullable<DateTime> m_ccct_fechapospago;
      private Nullable<Decimal> m_ccct_valvta;
      private Nullable<Decimal> m_ccct_discrepancia;
      private Nullable<Decimal> m_ccct_imp1;
      private Nullable<Decimal> m_ccct_imp2;
      private Nullable<Decimal> m_ccct_imp3;
      private Nullable<Decimal> m_ccct_imp4;
      private Nullable<Decimal> m_ccct_monto;
      private Nullable<Decimal> m_ccct_pendiente;
      private Nullable<DateTime> m_ccct_fecreg;
      private Nullable<DateTime> m_ccct_feccancel;
      private Nullable<Decimal> m_ccct_adquisicion;
      private Nullable<Decimal> m_ccct_pago;
      private Nullable<Decimal> m_ccct_pagoreg;
      private Nullable<Decimal> m_ccct_otros;
      private String m_ccct_glosa;
      private String m_ccct_estado;
      private Nullable<Int32> m_ccct_nrotransref;
      private String m_ccct_tipoletra;
      private String m_ccct_agrupacion;
      private Nullable<Boolean> m_ccct_regcompras;
      private String m_ccct_anexo;
      private String m_tipo_tabreg;
      private String m_tipo_codreg;
      private Nullable<Boolean> m_ccct_cobranzadudosa;
      private Nullable<Decimal> m_ccct_tchistorico;
      private Nullable<DateTime> m_ccct_feccierre;
      private Nullable<Decimal> m_ccct_tccierre;
      private Nullable<DateTime> m_ccct_feccierrehistorico;
      private Nullable<Boolean> m_ccct_ultimocierre;
      private Nullable<Int32> m_serv_codigo;
      private Nullable<Boolean> m_ccct_pagoinmediato;
      private String m_ccct_situacionletra;
      private Nullable<Boolean> m_ccct_aceptada1;
      private Nullable<Boolean> m_ccct_aceptada2;
      private Nullable<Boolean> m_ccct_protestada;
      private Nullable<Int32> m_ccct_nroprotesto;
      private String m_ccct_estadoletra;
      private String m_ccct_nrounicobco;
      private Nullable<DateTime> m_ccct_fecaceptacion;
      private Nullable<Boolean> m_ccct_sindocorigen;
      private Nullable<DateTime> m_ccct_fecenviobanco;
      private Nullable<DateTime> m_ccct_fecenvioproveedor;
      private String m_ccct_nrodetraccion;
      private Nullable<DateTime> m_ccct_fecdetraccion;
      private String m_tipo_tabdetrac;
      private String m_tipo_coddetrac;
      private String m_tipo_tabbco;
      private String m_tipo_codbco;
      private String m_ccct_glosacobranza;
      private Nullable<Decimal> m_ccct_valorreferencial;
      private String m_ccct_notas;
      private Nullable<Decimal> m_ccct_pordetraccion;
      private Nullable<Decimal> m_ccct_montodetraccion;
      private Nullable<Boolean> m_ccct_provasumedetraccion;
      private String m_cabp_ano;
      private String m_cabp_codigo;
      private Boolean m_ccct_rcimpreso;
      private String m_ccct_rcusrimpresion;
      private Nullable<DateTime> m_ccct_rcfecimpresion;      
      private String m_ccct_cuenta;
      private String m_ccct_cuentaigv;      
      private String m_tipo_tabdes;
      private String m_tipo_coddes;
      private Nullable<DateTime> m_audi_fecconta;      
      private String m_audi_usrconta;      
      private Nullable<Boolean> m_audi_contabilizado;
      private String m_audi_numcontable;
      private Nullable<Decimal> m_ccct_eurotcdoleuro;
      private Nullable<DateTime> m_ccct_eurotcdoleurofecha;
      private Nullable<Decimal> m_ccct_euromonto;
      private String m_cons_tabanu;
      private String m_cons_codanu;
      private String m_audi_usranulacion;
      private Nullable<DateTime> m_audi_fecanulacion;
      private Nullable<Int32> m_ccct_codreferencia;
      private String m_tipo_codtdoreferencia;
      private String m_ccct_seriereferencia;
      private String m_ccct_numeroreferencia;
      private Nullable<DateTime> m_ccct_fechaemisionreferencia;
      private Nullable<Decimal> m_ccct_porcentajeigv;
      private String m_caba_ano;
      private String m_caba_mes;
      private String m_caba_nrovoucher;
      private String m_caba_ano_lcompras;
      private String m_caba_mes_lcompras;
      private String m_tipo_tabreg_lcompras;
      private String m_tipo_codreg_lcompras;
      private String m_caba_nrovoucher_lcompras;
      private String m_ccct_cuentabi;
      private String m_ccct_origen;
      private String m_ccct_numero_original;
      private String m_ccct_serie_original;
      private Nullable<Decimal> m_ccct_porcimp1;
      private Nullable<Decimal> m_ccct_porcimp2;
      private Nullable<Decimal> m_ccct_porcimp3;
      private Nullable<Decimal> m_ccct_porcimp4;
      private Nullable<Boolean> m_ccct_retencionigv;
      private String m_tipo_tabti3;
      private String m_tipo_codti3;

      private String m_audi_usrcrea;
      private DateTime m_audi_feccrea;
      private String m_audi_usrmod;
      private Nullable<DateTime> m_audi_fecmod;
      #endregion

      #region [ Constructores ]
      /// <summary>
      /// Inicializar una nueva instancia de la clase CtaCte.
      /// </summary>
      public CtaCte()
      { }
      #endregion

      #region [ Propiedades ]

      /// <summary>
      /// Gets or sets el valor de: EMPR_Codigo.
      /// </summary>
      [DataMember]
      public Int16 EMPR_Codigo
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
      /// Gets or sets el valor de: CCCT_Codigo.
      /// </summary>
      [DataMember]
      public Int32 CCCT_Codigo
      {
         get { return m_ccct_codigo; }
         set
         {
            if (m_ccct_codigo != value)
            {
               m_ccct_codigo = value;
               OnPropertyChanged("CCCT_Codigo");
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
      /// Gets or sets el valor de: DOCV_Codigo.
      /// </summary>
      [DataMember]
      public Nullable<Int32> DOCV_Codigo
      {
         get { return m_docv_codigo; }
         set
         {
            if (m_docv_codigo != value)
            {
               m_docv_codigo = value;
               OnPropertyChanged("DOCV_Codigo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPE_Codigo.
      /// </summary>
      [DataMember]
      public Nullable<Int16> TIPE_Codigo
      {
         get { return m_tipe_codigo; }
         set
         {
            if (m_tipe_codigo != value)
            {
               m_tipe_codigo = value;
               OnPropertyChanged("TIPE_Codigo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: ENTC_Codigo.
      /// </summary>
      [DataMember]
      public Nullable<Int32> ENTC_Codigo
      {
         get { return m_entc_codigo; }
         set
         {
            if (m_entc_codigo != value)
            {
               m_entc_codigo = value;
               OnPropertyChanged("ENTC_Codigo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabTDO.
      /// </summary>
      [DataMember]
      public String TIPO_TabTDO
      {
         get { return m_tipo_tabtdo; }
         set
         {
            if (m_tipo_tabtdo != value)
            {
               m_tipo_tabtdo = value;
               OnPropertyChanged("TIPO_TabTDO");
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
      /// Gets or sets el valor de: TIPO_TabFPG.
      /// </summary>
      [DataMember]
      public String TIPO_TabFPG
      {
         get { return m_tipo_tabfpg; }
         set
         {
            if (m_tipo_tabfpg != value)
            {
               m_tipo_tabfpg = value;
               OnPropertyChanged("TIPO_TabFPG");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodTDO.
      /// </summary>
      [DataMember]
      public String TIPO_CodTDO
      {
         get { return m_tipo_codtdo; }
         set
         {
            if (m_tipo_codtdo != value)
            {
               m_tipo_codtdo = value;
               OnPropertyChanged("TIPO_CodTDO");
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
      /// Gets or sets el valor de: TIPO_CodFPG.
      /// </summary>
      [DataMember]
      public String TIPO_CodFPG
      {
         get { return m_tipo_codfpg; }
         set
         {
            if (m_tipo_codfpg != value)
            {
               m_tipo_codfpg = value;
               OnPropertyChanged("TIPO_CodFPG");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Serie.
      /// </summary>
      [DataMember]
      public String CCCT_Serie
      {
         get { return m_ccct_serie; }
         set
         {
            if (m_ccct_serie != value)
            {
               m_ccct_serie = value;
               OnPropertyChanged("CCCT_Serie");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Numero.
      /// </summary>
      [DataMember]
      public String CCCT_Numero
      {
         get { return m_ccct_numero; }
         set
         {
            if (m_ccct_numero != value)
            {
               m_ccct_numero = value;
               OnPropertyChanged("CCCT_Numero");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_AsientoContable.
      /// </summary>
      [DataMember]
      public String CCCT_AsientoContable
      {
         get { return m_ccct_asientocontable; }
         set
         {
            if (m_ccct_asientocontable != value)
            {
               m_ccct_asientocontable = value;
               OnPropertyChanged("CCCT_AsientoContable");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FechaEmision.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FechaEmision
      {
         get { return m_ccct_fechaemision; }
         set
         {
            if (m_ccct_fechaemision != value)
            {
               m_ccct_fechaemision = value;
               OnPropertyChanged("CCCT_FechaEmision");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_TipoCambio.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_TipoCambio
      {
         get { return m_ccct_tipocambio; }
         set
         {
            if (m_ccct_tipocambio != value)
            {
               m_ccct_tipocambio = value;
               OnPropertyChanged("CCCT_TipoCambio");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FechaRecepcion.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FechaRecepcion
      {
         get { return m_ccct_fecharecepcion; }
         set
         {
            if (m_ccct_fecharecepcion != value)
            {
               m_ccct_fecharecepcion = value;
               OnPropertyChanged("CCCT_FechaRecepcion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FechaVcto.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FechaVcto
      {
         get { return m_ccct_fechavcto; }
         set
         {
            if (m_ccct_fechavcto != value)
            {
               m_ccct_fechavcto = value;
               OnPropertyChanged("CCCT_FechaVcto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FechaPosPago.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FechaPosPago
      {
         get { return m_ccct_fechapospago; }
         set
         {
            if (m_ccct_fechapospago != value)
            {
               m_ccct_fechapospago = value;
               OnPropertyChanged("CCCT_FechaPosPago");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_ValVta.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_ValVta
      {
         get { return m_ccct_valvta; }
         set
         {
            if (m_ccct_valvta != value)
            {
               m_ccct_valvta = value;
               OnPropertyChanged("CCCT_ValVta");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_ValVta.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Discrepancia
      {
          get { return m_ccct_discrepancia; }
          set
          {
              if (m_ccct_discrepancia != value)
              {
                  m_ccct_discrepancia = value;
                  OnPropertyChanged("CCCT_Discrepancia");
              }
          }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Imp1.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Imp1
      {
         get { return m_ccct_imp1; }
         set
         {
            if (m_ccct_imp1 != value)
            {
               m_ccct_imp1 = value;
               OnPropertyChanged("CCCT_Imp1");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Imp2.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Imp2
      {
         get { return m_ccct_imp2; }
         set
         {
            if (m_ccct_imp2 != value)
            {
               m_ccct_imp2 = value;
               OnPropertyChanged("CCCT_Imp2");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Imp3.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Imp3
      {
         get { return m_ccct_imp3; }
         set
         {
            if (m_ccct_imp3 != value)
            {
               m_ccct_imp3 = value;
               OnPropertyChanged("CCCT_Imp3");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Imp4.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Imp4
      {
         get { return m_ccct_imp4; }
         set
         {
            if (m_ccct_imp4 != value)
            {
               m_ccct_imp4 = value;
               OnPropertyChanged("CCCT_Imp4");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Monto.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Monto
      {
         get { return m_ccct_monto; }
         set
         {
            if (m_ccct_monto != value)
            {
               m_ccct_monto = value;
               OnPropertyChanged("CCCT_Monto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Pendiente.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Pendiente
      {
         get { return m_ccct_pendiente; }
         set
         {
            if (m_ccct_pendiente != value)
            {
               m_ccct_pendiente = value;
               OnPropertyChanged("CCCT_Pendiente");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FecReg.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FecReg
      {
         get { return m_ccct_fecreg; }
         set
         {
            if (m_ccct_fecreg != value)
            {
               m_ccct_fecreg = value;
               OnPropertyChanged("CCCT_FecReg");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FecCancel.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FecCancel
      {
         get { return m_ccct_feccancel; }
         set
         {
            if (m_ccct_feccancel != value)
            {
               m_ccct_feccancel = value;
               OnPropertyChanged("CCCT_FecCancel");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Adquisicion.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Adquisicion
      {
         get { return m_ccct_adquisicion; }
         set
         {
            if (m_ccct_adquisicion != value)
            {
               m_ccct_adquisicion = value;
               OnPropertyChanged("CCCT_Adquisicion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Pago.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Pago
      {
         get { return m_ccct_pago; }
         set
         {
            if (m_ccct_pago != value)
            {
               m_ccct_pago = value;
               OnPropertyChanged("CCCT_Pago");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_PagoReg.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_PagoReg
      {
         get { return m_ccct_pagoreg; }
         set
         {
            if (m_ccct_pagoreg != value)
            {
               m_ccct_pagoreg = value;
               OnPropertyChanged("CCCT_PagoReg");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Otros.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_Otros
      {
         get { return m_ccct_otros; }
         set
         {
            if (m_ccct_otros != value)
            {
               m_ccct_otros = value;
               OnPropertyChanged("CCCT_Otros");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Glosa.
      /// </summary>
      [DataMember]
      public String CCCT_Glosa
      {
         get { return m_ccct_glosa; }
         set
         {
            if (m_ccct_glosa != value)
            {
               m_ccct_glosa = value;
               OnPropertyChanged("CCCT_Glosa");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Estado.
      /// </summary>
      [DataMember]
      public String CCCT_Estado
      {
         get { return m_ccct_estado; }
         set
         {
            if (m_ccct_estado != value)
            {
               m_ccct_estado = value;
               OnPropertyChanged("CCCT_Estado");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_NroTransRef.
      /// </summary>
      [DataMember]
      public Nullable<Int32> CCCT_NroTransRef
      {
         get { return m_ccct_nrotransref; }
         set
         {
            if (m_ccct_nrotransref != value)
            {
               m_ccct_nrotransref = value;
               OnPropertyChanged("CCCT_NroTransRef");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_TipoLetra.
      /// </summary>
      [DataMember]
      public String CCCT_TipoLetra
      {
         get { return m_ccct_tipoletra; }
         set
         {
            if (m_ccct_tipoletra != value)
            {
               m_ccct_tipoletra = value;
               OnPropertyChanged("CCCT_TipoLetra");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Agrupacion.
      /// </summary>
      [DataMember]
      public String CCCT_Agrupacion
      {
         get { return m_ccct_agrupacion; }
         set
         {
            if (m_ccct_agrupacion != value)
            {
               m_ccct_agrupacion = value;
               OnPropertyChanged("CCCT_Agrupacion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_RegCompras.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_RegCompras
      {
         get { return m_ccct_regcompras; }
         set
         {
            if (m_ccct_regcompras != value)
            {
               m_ccct_regcompras = value;
               OnPropertyChanged("CCCT_RegCompras");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Anexo.
      /// </summary>
      [DataMember]
      public String CCCT_Anexo
      {
         get { return m_ccct_anexo; }
         set
         {
            if (m_ccct_anexo != value)
            {
               m_ccct_anexo = value;
               OnPropertyChanged("CCCT_Anexo");
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
      /// Gets or sets el valor de: CCCT_CobranzaDudosa.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_CobranzaDudosa
      {
         get { return m_ccct_cobranzadudosa; }
         set
         {
            if (m_ccct_cobranzadudosa != value)
            {
               m_ccct_cobranzadudosa = value;
               OnPropertyChanged("CCCT_CobranzaDudosa");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_TCHistorico.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_TCHistorico
      {
         get { return m_ccct_tchistorico; }
         set
         {
            if (m_ccct_tchistorico != value)
            {
               m_ccct_tchistorico = value;
               OnPropertyChanged("CCCT_TCHistorico");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FecCierre.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FecCierre
      {
         get { return m_ccct_feccierre; }
         set
         {
            if (m_ccct_feccierre != value)
            {
               m_ccct_feccierre = value;
               OnPropertyChanged("CCCT_FecCierre");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_TCCierre.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_TCCierre
      {
         get { return m_ccct_tccierre; }
         set
         {
            if (m_ccct_tccierre != value)
            {
               m_ccct_tccierre = value;
               OnPropertyChanged("CCCT_TCCierre");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FecCierreHistorico.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FecCierreHistorico
      {
         get { return m_ccct_feccierrehistorico; }
         set
         {
            if (m_ccct_feccierrehistorico != value)
            {
               m_ccct_feccierrehistorico = value;
               OnPropertyChanged("CCCT_FecCierreHistorico");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_UltimoCierre.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_UltimoCierre
      {
         get { return m_ccct_ultimocierre; }
         set
         {
            if (m_ccct_ultimocierre != value)
            {
               m_ccct_ultimocierre = value;
               OnPropertyChanged("CCCT_UltimoCierre");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: SERV_Codigo.
      /// </summary>
      [DataMember]
      public Nullable<Int32> SERV_Codigo
      {
         get { return m_serv_codigo; }
         set
         {
            if (m_serv_codigo != value)
            {
               m_serv_codigo = value;
               OnPropertyChanged("SERV_Codigo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_PagoInmediato.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_PagoInmediato
      {
         get { return m_ccct_pagoinmediato; }
         set
         {
            if (m_ccct_pagoinmediato != value)
            {
               m_ccct_pagoinmediato = value;
               OnPropertyChanged("CCCT_PagoInmediato");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_SituacionLetra.
      /// </summary>
      [DataMember]
      public String CCCT_SituacionLetra
      {
         get { return m_ccct_situacionletra; }
         set
         {
            if (m_ccct_situacionletra != value)
            {
               m_ccct_situacionletra = value;
               OnPropertyChanged("CCCT_SituacionLetra");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Aceptada1.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_Aceptada1
      {
         get { return m_ccct_aceptada1; }
         set
         {
            if (m_ccct_aceptada1 != value)
            {
               m_ccct_aceptada1 = value;
               OnPropertyChanged("CCCT_Aceptada1");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Aceptada2.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_Aceptada2
      {
         get { return m_ccct_aceptada2; }
         set
         {
            if (m_ccct_aceptada2 != value)
            {
               m_ccct_aceptada2 = value;
               OnPropertyChanged("CCCT_Aceptada2");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Protestada.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_Protestada
      {
         get { return m_ccct_protestada; }
         set
         {
            if (m_ccct_protestada != value)
            {
               m_ccct_protestada = value;
               OnPropertyChanged("CCCT_Protestada");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_NroProtesto.
      /// </summary>
      [DataMember]
      public Nullable<Int32> CCCT_NroProtesto
      {
         get { return m_ccct_nroprotesto; }
         set
         {
            if (m_ccct_nroprotesto != value)
            {
               m_ccct_nroprotesto = value;
               OnPropertyChanged("CCCT_NroProtesto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_EstadoLetra.
      /// </summary>
      [DataMember]
      public String CCCT_EstadoLetra
      {
         get { return m_ccct_estadoletra; }
         set
         {
            if (m_ccct_estadoletra != value)
            {
               m_ccct_estadoletra = value;
               OnPropertyChanged("CCCT_EstadoLetra");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_NroUnicoBCO.
      /// </summary>
      [DataMember]
      public String CCCT_NroUnicoBCO
      {
         get { return m_ccct_nrounicobco; }
         set
         {
            if (m_ccct_nrounicobco != value)
            {
               m_ccct_nrounicobco = value;
               OnPropertyChanged("CCCT_NroUnicoBCO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FecAceptacion.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FecAceptacion
      {
         get { return m_ccct_fecaceptacion; }
         set
         {
            if (m_ccct_fecaceptacion != value)
            {
               m_ccct_fecaceptacion = value;
               OnPropertyChanged("CCCT_FecAceptacion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_SinDocOrigen.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_SinDocOrigen
      {
         get { return m_ccct_sindocorigen; }
         set
         {
            if (m_ccct_sindocorigen != value)
            {
               m_ccct_sindocorigen = value;
               OnPropertyChanged("CCCT_SinDocOrigen");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FecEnvioBanco.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FecEnvioBanco
      {
         get { return m_ccct_fecenviobanco; }
         set
         {
            if (m_ccct_fecenviobanco != value)
            {
               m_ccct_fecenviobanco = value;
               OnPropertyChanged("CCCT_FecEnvioBanco");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FecEnvioProveedor.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FecEnvioProveedor
      {
         get { return m_ccct_fecenvioproveedor; }
         set
         {
            if (m_ccct_fecenvioproveedor != value)
            {
               m_ccct_fecenvioproveedor = value;
               OnPropertyChanged("CCCT_FecEnvioProveedor");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_NroDetraccion.
      /// </summary>
      [DataMember]
      public String CCCT_NroDetraccion
      {
         get { return m_ccct_nrodetraccion; }
         set
         {
            if (m_ccct_nrodetraccion != value)
            {
               m_ccct_nrodetraccion = value;
               OnPropertyChanged("CCCT_NroDetraccion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FecDetraccion.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FecDetraccion
      {
         get { return m_ccct_fecdetraccion; }
         set
         {
            if (m_ccct_fecdetraccion != value)
            {
               m_ccct_fecdetraccion = value;
               OnPropertyChanged("CCCT_FecDetraccion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabDetrac.
      /// </summary>
      [DataMember]
      public String TIPO_TabDetrac
      {
         get { return m_tipo_tabdetrac; }
         set
         {
            if (m_tipo_tabdetrac != value)
            {
               m_tipo_tabdetrac = value;
               OnPropertyChanged("TIPO_TabDetrac");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodDetrac.
      /// </summary>
      [DataMember]
      public String TIPO_CodDetrac
      {
         get { return m_tipo_coddetrac; }
         set
         {
            if (m_tipo_coddetrac != value)
            {
               m_tipo_coddetrac = value;
               OnPropertyChanged("TIPO_CodDetrac");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabBCO.
      /// </summary>
      [DataMember]
      public String TIPO_TabBCO
      {
         get { return m_tipo_tabbco; }
         set
         {
            if (m_tipo_tabbco != value)
            {
               m_tipo_tabbco = value;
               OnPropertyChanged("TIPO_TabBCO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodBCO.
      /// </summary>
      [DataMember]
      public String TIPO_CodBCO
      {
         get { return m_tipo_codbco; }
         set
         {
            if (m_tipo_codbco != value)
            {
               m_tipo_codbco = value;
               OnPropertyChanged("TIPO_CodBCO");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_GlosaCobranza.
      /// </summary>
      [DataMember]
      public String CCCT_GlosaCobranza
      {
         get { return m_ccct_glosacobranza; }
         set
         {
            if (m_ccct_glosacobranza != value)
            {
               m_ccct_glosacobranza = value;
               OnPropertyChanged("CCCT_GlosaCobranza");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_ValorReferencial.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_ValorReferencial
      {
         get { return m_ccct_valorreferencial; }
         set
         {
            if (m_ccct_valorreferencial != value)
            {
               m_ccct_valorreferencial = value;
               OnPropertyChanged("CCCT_ValorReferencial");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Notas.
      /// </summary>
      [DataMember]
      public String CCCT_Notas
      {
         get { return m_ccct_notas; }
         set
         {
            if (m_ccct_notas != value)
            {
               m_ccct_notas = value;
               OnPropertyChanged("CCCT_Notas");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_PorDetraccion.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_PorDetraccion
      {
         get { return m_ccct_pordetraccion; }
         set
         {
            if (m_ccct_pordetraccion != value)
            {
               m_ccct_pordetraccion = value;
               OnPropertyChanged("CCCT_PorDetraccion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_MontoDetraccion.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_MontoDetraccion
      {
         get { return m_ccct_montodetraccion; }
         set
         {
            if (m_ccct_montodetraccion != value)
            {
               m_ccct_montodetraccion = value;
               OnPropertyChanged("CCCT_MontoDetraccion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_ProvAsumeDetraccion.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_ProvAsumeDetraccion
      {
         get { return m_ccct_provasumedetraccion; }
         set
         {
            if (m_ccct_provasumedetraccion != value)
            {
               m_ccct_provasumedetraccion = value;
               OnPropertyChanged("CCCT_ProvAsumeDetraccion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABP_Ano.
      /// </summary>
      [DataMember]
      public String CABP_Ano
      {
         get { return m_cabp_ano; }
         set
         {
            if (m_cabp_ano != value)
            {
               m_cabp_ano = value;
               OnPropertyChanged("CABP_Ano");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABP_Codigo.
      /// </summary>
      [DataMember]
      public String CABP_Codigo
      {
         get { return m_cabp_codigo; }
         set
         {
            if (m_cabp_codigo != value)
            {
               m_cabp_codigo = value;
               OnPropertyChanged("CABP_Codigo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_RCImpreso.
      /// </summary>
      [DataMember]
      public Boolean CCCT_RCImpreso
      {
         get { return m_ccct_rcimpreso; }
         set
         {
            if (m_ccct_rcimpreso != value)
            {
               m_ccct_rcimpreso = value;
               OnPropertyChanged("CCCT_RCImpreso");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_RCUsrImpresion.
      /// </summary>
      [DataMember]
      public String CCCT_RCUsrImpresion
      {
         get { return m_ccct_rcusrimpresion; }
         set
         {
            if (m_ccct_rcusrimpresion != value)
            {
               m_ccct_rcusrimpresion = value;
               OnPropertyChanged("CCCT_RCUsrImpresion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_RCFecImpresion.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_RCFecImpresion
      {
         get { return m_ccct_rcfecimpresion; }
         set
         {
            if (m_ccct_rcfecimpresion != value)
            {
               m_ccct_rcfecimpresion = value;
               OnPropertyChanged("CCCT_RCFecImpresion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Cuenta.
      /// </summary>
      [DataMember]
      public String CCCT_Cuenta
      {
         get { return m_ccct_cuenta; }
         set
         {
            if (m_ccct_cuenta != value)
            {
               m_ccct_cuenta = value;
               OnPropertyChanged("CCCT_Cuenta");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_CuentaIGV.
      /// </summary>
      [DataMember]
      public String CCCT_CuentaIGV
      {
         get { return m_ccct_cuentaigv; }
         set
         {
            if (m_ccct_cuentaigv != value)
            {
               m_ccct_cuentaigv = value;
               OnPropertyChanged("CCCT_CuentaIGV");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabDES.
      /// </summary>
      [DataMember]
      public String TIPO_TabDES
      {
         get { return m_tipo_tabdes; }
         set
         {
            if (m_tipo_tabdes != value)
            {
               m_tipo_tabdes = value;
               OnPropertyChanged("TIPO_TabDES");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodDES.
      /// </summary>
      [DataMember]
      public String TIPO_CodDES
      {
         get { return m_tipo_coddes; }
         set
         {
            if (m_tipo_coddes != value)
            {
               m_tipo_coddes = value;
               OnPropertyChanged("TIPO_CodDES");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_FecConta.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> AUDI_FecConta
      {
         get { return m_audi_fecconta; }
         set
         {
            if (m_audi_fecconta != value)
            {
               m_audi_fecconta = value;
               OnPropertyChanged("AUDI_FecConta");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_UsrConta.
      /// </summary>
      [DataMember]
      public String AUDI_UsrConta
      {
         get { return m_audi_usrconta; }
         set
         {
            if (m_audi_usrconta != value)
            {
               m_audi_usrconta = value;
               OnPropertyChanged("AUDI_UsrConta");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_Contabilizado.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> AUDI_Contabilizado
      {
         get { return m_audi_contabilizado; }
         set
         {
            if (m_audi_contabilizado != value)
            {
               m_audi_contabilizado = value;
               OnPropertyChanged("AUDI_Contabilizado");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_NumContable.
      /// </summary>
      [DataMember]
      public String AUDI_NumContable
      {
         get { return m_audi_numcontable; }
         set
         {
            if (m_audi_numcontable != value)
            {
               m_audi_numcontable = value;
               OnPropertyChanged("AUDI_NumContable");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_EuroTCDolEuro.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_EuroTCDolEuro
      {
         get { return m_ccct_eurotcdoleuro; }
         set
         {
            if (m_ccct_eurotcdoleuro != value)
            {
               m_ccct_eurotcdoleuro = value;
               OnPropertyChanged("CCCT_EuroTCDolEuro");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_EuroTCDolEuroFecha.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_EuroTCDolEuroFecha
      {
         get { return m_ccct_eurotcdoleurofecha; }
         set
         {
            if (m_ccct_eurotcdoleurofecha != value)
            {
               m_ccct_eurotcdoleurofecha = value;
               OnPropertyChanged("CCCT_EuroTCDolEuroFecha");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_EuroMonto.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_EuroMonto
      {
         get { return m_ccct_euromonto; }
         set
         {
            if (m_ccct_euromonto != value)
            {
               m_ccct_euromonto = value;
               OnPropertyChanged("CCCT_EuroMonto");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CONS_TabANU.
      /// </summary>
      [DataMember]
      public String CONS_TabANU
      {
         get { return m_cons_tabanu; }
         set
         {
            if (m_cons_tabanu != value)
            {
               m_cons_tabanu = value;
               OnPropertyChanged("CONS_TabANU");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CONS_CodANU.
      /// </summary>
      [DataMember]
      public String CONS_CodANU
      {
         get { return m_cons_codanu; }
         set
         {
            if (m_cons_codanu != value)
            {
               m_cons_codanu = value;
               OnPropertyChanged("CONS_CodANU");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_UsrAnulacion.
      /// </summary>
      [DataMember]
      public String AUDI_UsrAnulacion
      {
         get { return m_audi_usranulacion; }
         set
         {
            if (m_audi_usranulacion != value)
            {
               m_audi_usranulacion = value;
               OnPropertyChanged("AUDI_UsrAnulacion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: AUDI_FecAnulacion.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> AUDI_FecAnulacion
      {
         get { return m_audi_fecanulacion; }
         set
         {
            if (m_audi_fecanulacion != value)
            {
               m_audi_fecanulacion = value;
               OnPropertyChanged("AUDI_FecAnulacion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_CodReferencia.
      /// </summary>
      [DataMember]
      public Nullable<Int32> CCCT_CodReferencia
      {
         get { return m_ccct_codreferencia; }
         set
         {
            if (m_ccct_codreferencia != value)
            {
               m_ccct_codreferencia = value;
               OnPropertyChanged("CCCT_CodReferencia");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodTDOReferencia.
      /// </summary>
      [DataMember]
      public String TIPO_CodTDOReferencia
      {
         get { return m_tipo_codtdoreferencia; }
         set
         {
            if (m_tipo_codtdoreferencia != value)
            {
               m_tipo_codtdoreferencia = value;
               OnPropertyChanged("TIPO_CodTDOReferencia");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_SerieReferencia.
      /// </summary>
      [DataMember]
      public String CCCT_SerieReferencia
      {
         get { return m_ccct_seriereferencia; }
         set
         {
            if (m_ccct_seriereferencia != value)
            {
               m_ccct_seriereferencia = value;
               OnPropertyChanged("CCCT_SerieReferencia");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_NumeroReferencia.
      /// </summary>
      [DataMember]
      public String CCCT_NumeroReferencia
      {
         get { return m_ccct_numeroreferencia; }
         set
         {
            if (m_ccct_numeroreferencia != value)
            {
               m_ccct_numeroreferencia = value;
               OnPropertyChanged("CCCT_NumeroReferencia");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_FechaEmisionReferencia.
      /// </summary>
      [DataMember]
      public Nullable<DateTime> CCCT_FechaEmisionReferencia
      {
         get { return m_ccct_fechaemisionreferencia; }
         set
         {
            if (m_ccct_fechaemisionreferencia != value)
            {
               m_ccct_fechaemisionreferencia = value;
               OnPropertyChanged("CCCT_FechaEmisionReferencia");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_PorcentajeIGV.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_PorcentajeIGV
      {
         get { return m_ccct_porcentajeigv; }
         set
         {
            if (m_ccct_porcentajeigv != value)
            {
               m_ccct_porcentajeigv = value;
               OnPropertyChanged("CCCT_PorcentajeIGV");
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
      /// Gets or sets el valor de: CABA_Ano_LCompras.
      /// </summary>
      [DataMember]
      public String CABA_Ano_LCompras
      {
         get { return m_caba_ano_lcompras; }
         set
         {
            if (m_caba_ano_lcompras != value)
            {
               m_caba_ano_lcompras = value;
               OnPropertyChanged("CABA_Ano_LCompras");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_Mes_LCompras.
      /// </summary>
      [DataMember]
      public String CABA_Mes_LCompras
      {
         get { return m_caba_mes_lcompras; }
         set
         {
            if (m_caba_mes_lcompras != value)
            {
               m_caba_mes_lcompras = value;
               OnPropertyChanged("CABA_Mes_LCompras");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabREG_LCompras.
      /// </summary>
      [DataMember]
      public String TIPO_TabREG_LCompras
      {
         get { return m_tipo_tabreg_lcompras; }
         set
         {
            if (m_tipo_tabreg_lcompras != value)
            {
               m_tipo_tabreg_lcompras = value;
               OnPropertyChanged("TIPO_TabREG_LCompras");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodREG_LCompras.
      /// </summary>
      [DataMember]
      public String TIPO_CodREG_LCompras
      {
         get { return m_tipo_codreg_lcompras; }
         set
         {
            if (m_tipo_codreg_lcompras != value)
            {
               m_tipo_codreg_lcompras = value;
               OnPropertyChanged("TIPO_CodREG_LCompras");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CABA_NroVoucher_LCompras.
      /// </summary>
      [DataMember]
      public String CABA_NroVoucher_LCompras
      {
         get { return m_caba_nrovoucher_lcompras; }
         set
         {
            if (m_caba_nrovoucher_lcompras != value)
            {
               m_caba_nrovoucher_lcompras = value;
               OnPropertyChanged("CABA_NroVoucher_LCompras");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_CuentaBI.
      /// </summary>
      [DataMember]
      public String CCCT_CuentaBI
      {
         get { return m_ccct_cuentabi; }
         set
         {
            if (m_ccct_cuentabi != value)
            {
               m_ccct_cuentabi = value;
               OnPropertyChanged("CCCT_CuentaBI");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Origen.
      /// </summary>
      [DataMember]
      public String CCCT_Origen
      {
         get { return m_ccct_origen; }
         set
         {
            if (m_ccct_origen != value)
            {
               m_ccct_origen = value;
               OnPropertyChanged("CCCT_Origen");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Numero_Original.
      /// </summary>
      [DataMember]
      public String CCCT_Numero_Original
      {
         get { return m_ccct_numero_original; }
         set
         {
            if (m_ccct_numero_original != value)
            {
               m_ccct_numero_original = value;
               OnPropertyChanged("CCCT_Numero_Original");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_Serie_Original.
      /// </summary>
      [DataMember]
      public String CCCT_Serie_Original
      {
         get { return m_ccct_serie_original; }
         set
         {
            if (m_ccct_serie_original != value)
            {
               m_ccct_serie_original = value;
               OnPropertyChanged("CCCT_Serie_Original");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_PorcImp1.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_PorcImp1
      {
         get { return m_ccct_porcimp1; }
         set
         {
            if (m_ccct_porcimp1 != value)
            {
               m_ccct_porcimp1 = value;
               OnPropertyChanged("CCCT_PorcImp1");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_PorcImp2.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_PorcImp2
      {
         get { return m_ccct_porcimp2; }
         set
         {
            if (m_ccct_porcimp2 != value)
            {
               m_ccct_porcimp2 = value;
               OnPropertyChanged("CCCT_PorcImp2");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_PorcImp3.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_PorcImp3
      {
         get { return m_ccct_porcimp3; }
         set
         {
            if (m_ccct_porcimp3 != value)
            {
               m_ccct_porcimp3 = value;
               OnPropertyChanged("CCCT_PorcImp3");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_PorcImp4.
      /// </summary>
      [DataMember]
      public Nullable<Decimal> CCCT_PorcImp4
      {
         get { return m_ccct_porcimp4; }
         set
         {
            if (m_ccct_porcimp4 != value)
            {
               m_ccct_porcimp4 = value;
               OnPropertyChanged("CCCT_PorcImp4");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: CCCT_RetencionIGV.
      /// </summary>
      [DataMember]
      public Nullable<Boolean> CCCT_RetencionIGV
      {
         get { return m_ccct_retencionigv; }
         set
         {
            if (m_ccct_retencionigv != value)
            {
               m_ccct_retencionigv = value;
               OnPropertyChanged("CCCT_RetencionIGV");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabTI3.
      /// </summary>
      [DataMember]
      public String TIPO_TabTI3
      {
         get { return m_tipo_tabti3; }
         set
         {
            if (m_tipo_tabti3 != value)
            {
               m_tipo_tabti3 = value;
               OnPropertyChanged("TIPO_TabTI3");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodTI3.
      /// </summary>
      [DataMember]
      public String TIPO_CodTI3
      {
         get { return m_tipo_codti3; }
         set
         {
            if (m_tipo_codti3 != value)
            {
               m_tipo_codti3 = value;
               OnPropertyChanged("TIPO_CodTI3");
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
      public void CopyTo(ref CtaCte Item)
      {
         try
         {
            if (Item == null) { Item = new CtaCte(); }
            Item.EMPR_Codigo = this.EMPR_Codigo;
            Item.CCCT_Codigo = this.CCCT_Codigo;
            Item.SUCR_Codigo = this.SUCR_Codigo;
            Item.DOCV_Codigo = this.DOCV_Codigo;
            Item.TIPE_Codigo = this.TIPE_Codigo;
            Item.ENTC_Codigo = this.ENTC_Codigo;
            Item.TIPO_TabTDO = this.TIPO_TabTDO;
            Item.TIPO_TabMND = this.TIPO_TabMND;
            Item.TIPO_TabFPG = this.TIPO_TabFPG;
            Item.TIPO_CodTDO = this.TIPO_CodTDO;
            Item.TIPO_CodMND = this.TIPO_CodMND;
            Item.TIPO_CodFPG = this.TIPO_CodFPG;
            Item.CCCT_Serie = this.CCCT_Serie;
            Item.CCCT_Numero = this.CCCT_Numero;
            Item.CCCT_AsientoContable = this.CCCT_AsientoContable;
            Item.CCCT_FechaEmision = this.CCCT_FechaEmision;
            Item.CCCT_TipoCambio = this.CCCT_TipoCambio;
            Item.CCCT_FechaRecepcion = this.CCCT_FechaRecepcion;
            Item.CCCT_FechaVcto = this.CCCT_FechaVcto;
            Item.CCCT_FechaPosPago = this.CCCT_FechaPosPago;
            Item.CCCT_ValVta = this.CCCT_ValVta;
            Item.CCCT_Discrepancia = this.CCCT_Discrepancia;
            Item.CCCT_Imp1 = this.CCCT_Imp1;
            Item.CCCT_Imp2 = this.CCCT_Imp2;
            Item.CCCT_Imp3 = this.CCCT_Imp3;
            Item.CCCT_Imp4 = this.CCCT_Imp4;
            Item.CCCT_Monto = this.CCCT_Monto;
            Item.CCCT_Pendiente = this.CCCT_Pendiente;
            Item.CCCT_FecReg = this.CCCT_FecReg;
            Item.CCCT_FecCancel = this.CCCT_FecCancel;
            Item.CCCT_Adquisicion = this.CCCT_Adquisicion;
            Item.CCCT_Pago = this.CCCT_Pago;
            Item.CCCT_PagoReg = this.CCCT_PagoReg;
            Item.CCCT_Otros = this.CCCT_Otros;
            Item.CCCT_Glosa = this.CCCT_Glosa;
            Item.CCCT_Estado = this.CCCT_Estado;
            Item.CCCT_NroTransRef = this.CCCT_NroTransRef;
            Item.CCCT_TipoLetra = this.CCCT_TipoLetra;
            Item.CCCT_Agrupacion = this.CCCT_Agrupacion;
            Item.CCCT_RegCompras = this.CCCT_RegCompras;
            Item.CCCT_Anexo = this.CCCT_Anexo;
            Item.TIPO_TabREG = this.TIPO_TabREG;
            Item.TIPO_CodREG = this.TIPO_CodREG;
            Item.CCCT_CobranzaDudosa = this.CCCT_CobranzaDudosa;
            Item.CCCT_TCHistorico = this.CCCT_TCHistorico;
            Item.CCCT_FecCierre = this.CCCT_FecCierre;
            Item.CCCT_TCCierre = this.CCCT_TCCierre;
            Item.CCCT_FecCierreHistorico = this.CCCT_FecCierreHistorico;
            Item.CCCT_UltimoCierre = this.CCCT_UltimoCierre;
            Item.SERV_Codigo = this.SERV_Codigo;
            Item.CCCT_PagoInmediato = this.CCCT_PagoInmediato;
            Item.CCCT_SituacionLetra = this.CCCT_SituacionLetra;
            Item.CCCT_Aceptada1 = this.CCCT_Aceptada1;
            Item.CCCT_Aceptada2 = this.CCCT_Aceptada2;
            Item.CCCT_Protestada = this.CCCT_Protestada;
            Item.CCCT_NroProtesto = this.CCCT_NroProtesto;
            Item.CCCT_EstadoLetra = this.CCCT_EstadoLetra;
            Item.CCCT_NroUnicoBCO = this.CCCT_NroUnicoBCO;
            Item.CCCT_FecAceptacion = this.CCCT_FecAceptacion;
            Item.CCCT_SinDocOrigen = this.CCCT_SinDocOrigen;
            Item.CCCT_FecEnvioBanco = this.CCCT_FecEnvioBanco;
            Item.CCCT_FecEnvioProveedor = this.CCCT_FecEnvioProveedor;
            Item.CCCT_NroDetraccion = this.CCCT_NroDetraccion;
            Item.CCCT_FecDetraccion = this.CCCT_FecDetraccion;
            Item.TIPO_TabDetrac = this.TIPO_TabDetrac;
            Item.TIPO_CodDetrac = this.TIPO_CodDetrac;
            Item.TIPO_TabBCO = this.TIPO_TabBCO;
            Item.TIPO_CodBCO = this.TIPO_CodBCO;
            Item.CCCT_GlosaCobranza = this.CCCT_GlosaCobranza;
            Item.CCCT_ValorReferencial = this.CCCT_ValorReferencial;
            Item.CCCT_Notas = this.CCCT_Notas;
            Item.CCCT_PorDetraccion = this.CCCT_PorDetraccion;
            Item.CCCT_MontoDetraccion = this.CCCT_MontoDetraccion;
            Item.CCCT_ProvAsumeDetraccion = this.CCCT_ProvAsumeDetraccion;
            Item.CABP_Ano = this.CABP_Ano;
            Item.CABP_Codigo = this.CABP_Codigo;
            Item.CCCT_RCImpreso = this.CCCT_RCImpreso;
            Item.CCCT_RCUsrImpresion = this.CCCT_RCUsrImpresion;
            Item.CCCT_RCFecImpresion = this.CCCT_RCFecImpresion;
            Item.CCCT_Cuenta = this.CCCT_Cuenta;
            Item.CCCT_CuentaIGV = this.CCCT_CuentaIGV;
            Item.TIPO_TabDES = this.TIPO_TabDES;
            Item.TIPO_CodDES = this.TIPO_CodDES;
            Item.AUDI_FecConta = this.AUDI_FecConta;
            Item.AUDI_UsrConta = this.AUDI_UsrConta;
            Item.AUDI_Contabilizado = this.AUDI_Contabilizado;
            Item.AUDI_NumContable = this.AUDI_NumContable;
            Item.CCCT_EuroTCDolEuro = this.CCCT_EuroTCDolEuro;
            Item.CCCT_EuroTCDolEuroFecha = this.CCCT_EuroTCDolEuroFecha;
            Item.CCCT_EuroMonto = this.CCCT_EuroMonto;
            Item.CONS_TabANU = this.CONS_TabANU;
            Item.CONS_CodANU = this.CONS_CodANU;
            Item.AUDI_UsrAnulacion = this.AUDI_UsrAnulacion;
            Item.AUDI_FecAnulacion = this.AUDI_FecAnulacion;
            Item.CCCT_CodReferencia = this.CCCT_CodReferencia;
            Item.TIPO_CodTDOReferencia = this.TIPO_CodTDOReferencia;
            Item.CCCT_SerieReferencia = this.CCCT_SerieReferencia;
            Item.CCCT_NumeroReferencia = this.CCCT_NumeroReferencia;
            Item.CCCT_FechaEmisionReferencia = this.CCCT_FechaEmisionReferencia;
            Item.CCCT_PorcentajeIGV = this.CCCT_PorcentajeIGV;
            Item.CABA_Ano = this.CABA_Ano;
            Item.CABA_Mes = this.CABA_Mes;
            Item.CABA_NroVoucher = this.CABA_NroVoucher;
            Item.CABA_Ano_LCompras = this.CABA_Ano_LCompras;
            Item.CABA_Mes_LCompras = this.CABA_Mes_LCompras;
            Item.TIPO_TabREG_LCompras = this.TIPO_TabREG_LCompras;
            Item.TIPO_CodREG_LCompras = this.TIPO_CodREG_LCompras;
            Item.CABA_NroVoucher_LCompras = this.CABA_NroVoucher_LCompras;
            Item.CCCT_CuentaBI = this.CCCT_CuentaBI;
            Item.CCCT_Origen = this.CCCT_Origen;
            Item.CCCT_Numero_Original = this.CCCT_Numero_Original;
            Item.CCCT_Serie_Original = this.CCCT_Serie_Original;
            Item.CCCT_PorcImp1 = this.CCCT_PorcImp1;
            Item.CCCT_PorcImp2 = this.CCCT_PorcImp2;
            Item.CCCT_PorcImp3 = this.CCCT_PorcImp3;
            Item.CCCT_PorcImp4 = this.CCCT_PorcImp4;
            Item.CCCT_RetencionIGV = this.CCCT_RetencionIGV;
            Item.TIPO_TabTI3 = this.TIPO_TabTI3;
            Item.TIPO_CodTI3 = this.TIPO_CodTI3;

         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
