using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using Infrastructure.Aspect.Attributes;


namespace Delfin.Entities
{
   public class LoadingListDetallado
   {
      #region [ Variables ]
      private String m_load_ronoup;
      private String m_load_followup;
      private String m_load_shipper;
      private String m_load_consignee;
      private String m_load_notify;
      private String m_load_pol;
      private String m_load_polname;
      private String m_load_pod;
      private String m_load_podname;
      private String m_load_carrier;
      private String m_load_booking;
      private String m_load_mbl;
      private String m_load_hbl;
      private Nullable<DateTime> m_load_etd;
      private Nullable<DateTime> m_load_eta;
      private String m_lode_tipocnt;
      private String m_lode_tamaniocntr;
      private String m_lode_numerocntr;
      private String m_lode_precinto;
      private String m_lode_cargapeligrosa;
      private String m_lode_imoclass;
      private Nullable<Decimal> m_lode_pesobruto;
      private String m_lode_packtype;
      private Nullable<Decimal> m_lode_cantbultos;
      private Nullable<Decimal> m_lode_volumen;
      private String m_lode_desccarga;
      private String m_lode_marcasnumeros;
      private String m_load_contractcode;
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: LOAD_RONOUP.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 1)]
      public String LOAD_RONOUP
      {
         get { if (m_load_ronoup != null && m_load_ronoup.Length > 50) { m_load_ronoup = m_load_ronoup.Substring(0, 50); } return m_load_ronoup; }
         set { m_load_ronoup = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_FOLLOWUP.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 2)]
      public String LOAD_FOLLOWUP
      {
         get { if (m_load_followup != null && m_load_followup.Length > 50) { m_load_followup = m_load_followup.Substring(0, 50); } return m_load_followup; }
         set { m_load_followup = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_SHIPPER.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 3)]
      public String LOAD_SHIPPER
      {
         get { if (m_load_shipper != null && m_load_shipper.Length > 100) { m_load_shipper = m_load_shipper.Substring(0, 100); } return m_load_shipper; }
         set { m_load_shipper = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_CONSIGNEE.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 4)]
      public String LOAD_CONSIGNEE
      {
         get { if (m_load_consignee != null && m_load_consignee.Length > 100) { m_load_consignee = m_load_consignee.Substring(0, 100); } return m_load_consignee; }
         set { m_load_consignee = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_NOTIFY.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 5)]
      public String LOAD_NOTIFY
      {
         get { if (m_load_notify != null && m_load_notify.Length > 100) { m_load_notify = m_load_notify.Substring(0, 100); } return m_load_notify; }
         set { m_load_notify = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_POL.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 6)]
      public String LOAD_POL
      {
         get { if (m_load_pol != null && m_load_pol.Length > 10) { m_load_pol = m_load_pol.Substring(0, 10); } return m_load_pol; }
         set { m_load_pol = value; }
      }      
      /// <summary>
      /// Gets or sets el valor de: LOAD_POLNAME.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 7)]
      public String LOAD_POLNAME
      {
         get { if (m_load_polname != null && m_load_polname.Length > 100) { m_load_polname = m_load_polname.Substring(0, 100); } return m_load_polname; }
         set { m_load_polname = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_POD.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 8)]
      public String LOAD_POD
      {
         get { if (m_load_pod != null && m_load_pod.Length > 10) { m_load_pod = m_load_pod.Substring(0, 10); } return m_load_pod; }
         set { m_load_pod = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_PODNAME.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 9)]
      public String LOAD_PODNAME
      {
         get { if (m_load_podname != null && m_load_podname.Length > 100) { m_load_podname = m_load_podname.Substring(0, 100); } return m_load_podname; }
         set { m_load_podname = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_CARRIER.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 10)]
      public String LOAD_CARRIER
      {
         get { if (m_load_carrier != null && m_load_carrier.Length > 100) { m_load_carrier = m_load_carrier.Substring(0, 100); } return m_load_carrier; }
         set { m_load_carrier = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_BOOKING.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 11)]
      public String LOAD_BOOKING
      {
         get { if (m_load_booking != null && m_load_booking.Length > 50) { m_load_booking = m_load_booking.Substring(0, 50); } return m_load_booking; }
         set { m_load_booking = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_MBL.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 12)]
      public String LOAD_MBL
      {
         get { if (m_load_mbl != null && m_load_mbl.Length > 50) { m_load_mbl = m_load_mbl.Substring(0, 50); } return m_load_mbl; }
         set { m_load_mbl = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_HBL.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 13)]
      public String LOAD_HBL
      {
         get { if (m_load_hbl != null && m_load_hbl.Length > 50) { m_load_hbl = m_load_hbl.Substring(0, 50); } return m_load_hbl; }
         set { m_load_hbl = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_ETD.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 14)]
      public Nullable<DateTime> LOAD_ETD
      {
         get { return m_load_etd; }
         set { m_load_etd = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_ETA.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 15)]
      public Nullable<DateTime> LOAD_ETA
      {
         get { return m_load_eta; }
         set { m_load_eta = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_TIPOCNT.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 16)]
      public String LODE_TIPOCNT
      {
         get { if (m_lode_tipocnt != null && m_lode_tipocnt.Length > 20) { m_lode_tipocnt = m_lode_tipocnt.Substring(0, 20); } return m_lode_tipocnt; }
         set { m_lode_tipocnt = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_TAMANIOCNTR.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 17)]
      public String LODE_TAMANIOCNTR
      {
         get { if (m_lode_tamaniocntr != null && m_lode_tamaniocntr.Length > 20) { m_lode_tamaniocntr = m_lode_tamaniocntr.Substring(0, 20); } return m_lode_tamaniocntr; }
         set { m_lode_tamaniocntr = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_NUMEROCNTR.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 18)]
      public String LODE_NUMEROCNTR
      {
         get { if (m_lode_numerocntr != null && m_lode_numerocntr.Length > 15) { m_lode_numerocntr = m_lode_numerocntr.Substring(0, 15); } return m_lode_numerocntr; }
         set { m_lode_numerocntr = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_PRECINTO.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 19)]
      public String LODE_PRECINTO
      {
         get { if (m_lode_precinto != null && m_lode_precinto.Length > 50) { m_lode_precinto = m_lode_precinto.Substring(0, 50); } return m_lode_precinto; }
         set { m_lode_precinto = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_CARGAPELIGROSA.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 20)]
      public String LODE_CARGAPELIGROSA
      {
         get { if (m_lode_cargapeligrosa != null && m_lode_cargapeligrosa.Length > 1) { m_lode_cargapeligrosa = m_lode_cargapeligrosa.Substring(0, 1); } return m_lode_cargapeligrosa; }
         set { m_lode_cargapeligrosa = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_IMOCLASS.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 21)]
      public String LODE_IMOCLASS
      {
         get { if (m_lode_imoclass != null && m_lode_imoclass.Length > 20) { m_lode_imoclass = m_lode_imoclass.Substring(0, 20); } return m_lode_imoclass; }
         set { m_lode_imoclass = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_PESOBRUTO.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 22)]
      public Nullable<Decimal> LODE_PESOBRUTO
      {
         get { return m_lode_pesobruto; }
         set { m_lode_pesobruto = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_PACKTYPE.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 23)]
      public String LODE_PACKTYPE
      {
         get { if (m_lode_packtype != null && m_lode_packtype.Length > 20) { m_lode_packtype = m_lode_packtype.Substring(0, 20); } return m_lode_packtype; }
         set { m_lode_packtype = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_CANTBULTOS.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 24)]
      public Nullable<Decimal> LODE_CANTBULTOS
      {
         get { return m_lode_cantbultos; }
         set { m_lode_cantbultos = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_VOLUMEN.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 25)]
      public Nullable<Decimal> LODE_VOLUMEN
      {
         get { return m_lode_volumen; }
         set { m_lode_volumen = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_DESCCARGA.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 26)]
      public String LODE_DESCCARGA
      {
         get { if (m_lode_desccarga != null && m_lode_desccarga.Length > 4000) { m_lode_desccarga = m_lode_desccarga.Substring(0, 4000); } return m_lode_desccarga; }
         set { m_lode_desccarga = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LODE_MARCASNUMEROS.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 27)]
      public String LODE_MARCASNUMEROS
      {
         get { if (m_lode_marcasnumeros != null && m_lode_marcasnumeros.Length > 4000) { m_lode_marcasnumeros = m_lode_marcasnumeros.Substring(0, 4000); } return m_lode_marcasnumeros; }
         set { m_lode_marcasnumeros = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_CONTRACTCODE.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 28)]
      public String LOAD_CONTRACTCODE
      {
         get { if (m_load_contractcode != null && m_load_contractcode.Length > 50) { m_load_contractcode = m_load_contractcode.Substring(0, 50); } return m_load_contractcode; }
         set { m_load_contractcode = value; }
      }
      #endregion

      //  [LOAD_RONOUP]         VARCHAR(50)  
      //, [LOAD_FOLLOWUP]       VARCHAR(50)  
      //, [LOAD_SHIPPER]        VARCHAR(100) 
      //, [LOAD_CONSIGNEE]      VARCHAR(100) 
      //, [LOAD_NOTIFY]         VARCHAR(100) 
      //, [LOAD_POL]            VARCHAR(5)   
      //, [LOAD_POLNAME]        VARCHAR(100) 
      //, [LOAD_POD]            VARCHAR(5)   
      //, [LOAD_PODNAME]        VARCHAR(100) 
      //, [LOAD_CARRIER]        VARCHAR(100) 
      //, [LOAD_BOOKING]        VARCHAR(50)  
      //, [LOAD_MBL]            VARCHAR(50)  
      //, [LOAD_HBL]            VARCHAR(50)  
      //, [LOAD_ETD]            DATETIME     
      //, [LOAD_ETA]            DATETIME     
      //, [LODE_TIPOCNT]        VARCHAR(20)  
      //, [LODE_TAMANIOCNTR]    VARCHAR(20)  
      //, [LODE_NUMEROCNTR]     VARCHAR(15)  
      //, [LODE_PRECINTO]       VARCHAR(50)  
      //, [LODE_CARGAPELIGROSA] CHAR(1)      
      //, [LODE_IMOCLASS]       VARCHAR(20)  
      //, [LODE_PESOBRUTO]      DECIMAL(14,3)
      //, [LODE_PACKTYPE]       VARCHAR(20)  
      //, [LODE_CANTBULTOS]     DECIMAL(14,3)
      //, [LODE_VOLUMEN]        DECIMAL(14,3)
      //, [LODE_DESCCARGA]      VARCHAR(1024)
      //, [LODE_MARCASNUMEROS]  VARCHAR(1024)
      //, [LOAD_CONTRACTCODE]   VARCHAR(50)  

   }
}