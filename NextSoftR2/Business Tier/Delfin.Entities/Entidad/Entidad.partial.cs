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
   public partial class Entidad
   {
      #region [ Variables ]

      public Entidad_Relacionados Relacionado { get; set; }

      public Nullable<Int32> ENTC_CodEjecutivoImpo { get; set; }
      public Nullable<Int32> ENTC_CodEjecutivoExpo { get; set; }
      public Nullable<Int32> ENTC_CodCustomerImpo { get; set; }
      public Nullable<Int32> ENTC_CodCustomerExpo { get; set; }

      private decimal? m_ENTC_ValRebate;
      private string m_TIPO_TabMND;
      private string m_TIPO_CodMND;
      private decimal? m_ENTC_ValTarja;
      private DateTime? m_ENTC_FechaCredito;
      private short? m_ENTC_DiasCredito;
      private bool m_ENTC_Tarja;

      private Int16 m_dire_codigo;
      private String m_dire_direccion;
      private String m_ubig_codigo;
      private String m_tipo_tabpais;
      private String m_tipo_codpais;
      private String m_dire_ubigeo;

      private String m_dire_direccionComercial;
      private String m_ubig_codigoComercial;
      private Int16 m_dire_codigoComercial;
      private String m_cons_tabrgm;
      private String m_cons_codrgm;
      private String m_tipo_tabtrf;
      private String m_tipo_codtrf;
      private String m_tipo_desctdi;

      public String CONS_RGM { get; set; }
      public String TIPO_TRF { get; set; }
      public String RELA_TipoRelacion { get; set; }
      public String TIPE_Hijo { get; set; }

      public Boolean ValidarDocIden { get; set; }

      public Entidad_Acuerdo EntidadAcuerdo { get; set; }
      public DirecENTC DirecEntcFiscal { get; set; }
      public DirecENTC DirecEntcComercial { get; set; }

      private Int16 m_tipe_codigo;

      public ObservableCollection<Entidad_Acuerdo> m_listAcuerdo;
      public ObservableCollection<Entidad_Servicio> m_listServicio;
      public ObservableCollection<Entidad_Servicio> m_listServicioDeleted;
      Entidad m_ItemContactoImpo;
      Entidad m_ItemContactoExpo;
      
      private Boolean m_entc_toorder;

      #endregion

      #region [ Propiedades ]

      /// <summary>
      /// Gets or sets el valor de: DIRE_Codigo.
      /// </summary>
      [DataMember]
      public Int16 DIRE_Codigo
      {
         get { return m_dire_codigo; }
         set
         {
            if (m_dire_codigo != value)
            {
               m_dire_codigo = value;
               OnPropertyChanged("DIRE_Codigo");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DIRE_Direccion.
      /// </summary>
      [DataMember]
      public String DIRE_Direccion
      {
         get { return m_dire_direccion; }
         set
         {
            if (m_dire_direccion != value)
            {
               m_dire_direccion = value;
               OnPropertyChanged("DIRE_Direccion");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: UBIG_Codigo.
      /// </summary>
      [DataMember]
      public String UBIG_CodigoFiscal
      {
         get { return m_ubig_codigo; }
         set
         {
            if (m_ubig_codigo != value)
            {
               m_ubig_codigo = value;
               OnPropertyChanged("UBIG_Codigo");
            }
         }
      }

      public String TIPO_TabPaisFiscal { get; set; }
      public String TIPO_CodPaisFiscal { get; set; }
      /// <summary>
      /// Gets or sets el valor de: TIPO_TabPais.
      /// </summary>
      [DataMember]
      public String TIPO_TabPaisComercial
      {
         get { return m_tipo_tabpais; }
         set
         {
            if (m_tipo_tabpais != value)
            {
               m_tipo_tabpais = value;
               OnPropertyChanged("TIPO_TabPais");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: TIPO_CodPais.
      /// </summary>
      [DataMember]
      public String TIPO_CodPaisComercial
      {
         get { return m_tipo_codpais; }
         set
         {
            if (m_tipo_codpais != value)
            {
               m_tipo_codpais = value;
               OnPropertyChanged("TIPO_CodPais");
            }
         }
      }
      /// <summary>
      /// Gets or sets el valor de: DIRE_Ubigeo.
      /// </summary>
      [DataMember]
      public String DIRE_Ubigeo
      {
         get { return m_dire_ubigeo; }
         set
         {
            if (m_dire_ubigeo != value)
            {
               m_dire_ubigeo = value;
               OnPropertyChanged("DIRE_Ubigeo");
            }
         }
      }


      [DataMember]
      public Int16 Dire_CodigoComercial
      {
         get { return m_dire_codigoComercial; }
         set { m_dire_codigoComercial = value; }
      }


      [DataMember]
      public string TIPO_CodMND
      {
         get { return m_TIPO_CodMND; }
         set { m_TIPO_CodMND = value; }
      }
      [DataMember]
      public string TIPO_TabMND
      {
         get { return m_TIPO_TabMND; }
         set { m_TIPO_TabMND = value; }
      }

      [DataMember]
      public String UBIG_CodigoComercial
      {
         get { return m_ubig_codigoComercial; }
         set { m_ubig_codigoComercial = value; }
      }
      [DataMember]
      public String DIRE_DireccionComercial
      {
         get { return m_dire_direccionComercial; }
         set { m_dire_direccionComercial = value; }
      }

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
      /// Gets or sets el valor de: TIPO_DescTDI.
      /// </summary>
      [DataMember]
      public String TIPO_DescTDI
      {
         get { return m_tipo_desctdi; }
         set
         {
            if (m_tipo_desctdi != value)
            {
               m_tipo_desctdi = value;
               OnPropertyChanged("TIPO_DescTDI");
            }
         }
      }

      [DataMember]
      public ObservableCollection<Entidad_Relacionados> ItemsDepTemporalEntidad { get; set; }


      /// <summary>
      /// Gets or sets el valor de: ENTC_Codigo.
      /// </summary>
      [DataMember]
      public Int16 TIPE_Codigo
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
      [DataMember]
      public ObservableCollection<Entidad_Acuerdo> ListAcuerdo
      {
         get { return m_listAcuerdo; }
         set { m_listAcuerdo = value; }

      }

      [DataMember]
      public ObservableCollection<Entidad_Servicio> ListServicio
      {
         get
         {
            if (m_listServicio == null)
            { m_listServicio = new ObservableCollection<Entidad_Servicio>(); }
            return m_listServicio;
         }
         set { m_listServicio = value; }
      }
      [DataMember]
      public ObservableCollection<Entidad_Servicio> ListServicioDeleted
      {
         get
         {
            if (m_listServicioDeleted == null)
            { m_listServicioDeleted = new ObservableCollection<Entidad_Servicio>(); }
            return m_listServicioDeleted;
         }
         set { m_listServicioDeleted = value; }
      }

      [DataMember]
      public Entidad ContactoImpo
      {
         get { return m_ItemContactoImpo; }
         set { m_ItemContactoImpo = value; }
      }

      [DataMember]
      public Entidad ContactoExpo
      {
         get { return m_ItemContactoExpo; }
         set { m_ItemContactoExpo = value; }
      }

      public String TIPO_HOL { get; set; }

      [DataMember]
      public Boolean ENTC_ToOrder
      {
         get { return m_entc_toorder; }
         set { m_entc_toorder = value; }
      }

      //[DataMember]
      //public Entidad Contactos
      //{
      //    get { return m_ItemContactos; }
      //    set { m_ItemContactos = value; }
      //}
      [DataMember]
      public ObservableCollection<Entidad> Relacionados { get; set; }

      [DataMember]
      public ObservableCollection<Entidad> RelacionadosEliminados { get; set; }

      [DataMember]
      public ObservableCollection<Entidad_Relacionados> EntidadDeposito { get; set; }

      #region [ Datos Financieros ]

      [DataMember]
      public ObservableCollection<Entities.EntidadLimiteCredito> ListEntidadLimiteCreditosCliente { get; set; }
      [DataMember]
      public ObservableCollection<Entities.EntidadLimiteCredito> ListEntidadLimiteCreditosProveedor { get; set; }
      [DataMember]
      public ObservableCollection<Entities.EntidadCuentaBancaria> ListEntidadCuentaBancarias { get; set; }
      [DataMember]
      public ObservableCollection<Entities.EntidadCuentaBancaria> ListEntidadCuentaBancariasEliminados { get; set; }
      #endregion

      public String Limitecredito { get; set; }

      #endregion
   }
}
