using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using Infrastructure.Aspect.Attributes;

namespace Delfin.Entities
{
   public class LoadingListResumido
   {
      #region [ Variables ]
      private String m_load_pol;
      private String m_load_mv;
      private Nullable<DateTime> m_load_etd;
      private String m_load_carrier;
      private String m_load_booking;
      private String m_load_mbl;
      private String m_load_hbl;
      private String m_load_pod;
      private String m_load_ofterm;
      private String m_load_cntr;
      private String m_load_shipper;
      private String m_load_consignee;
      private String m_load_code;      
      #endregion

      #region [ Propiedades ]
      /// <summary>
      /// Gets or sets el valor de: LOAD_POL.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 1)]
      public String LOAD_POL
      {
         get { if (m_load_pol != null && m_load_pol.Length > 50) { m_load_pol = m_load_pol.Substring(0, 50); } return m_load_pol; }
         set { m_load_pol = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_MV.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 2)]
      public String LOAD_MV
      {
         get { if (m_load_mv != null && m_load_mv.Length > 50) { m_load_mv = m_load_mv.Substring(0, 50); } return m_load_mv; }
         set { m_load_mv = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_ETD.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 3)]
      public Nullable<DateTime> LOAD_ETD
      {
         get { return m_load_etd; }
         set { m_load_etd = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_CARRIER.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 4)]
      public String LOAD_CARRIER
      {
         get { if (m_load_carrier != null && m_load_carrier.Length > 100) { m_load_carrier = m_load_carrier.Substring(0, 100); } return m_load_carrier; }
         set { m_load_carrier = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_BOOKING.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 5)]
      public String LOAD_BOOKING
      {
         get { if (m_load_booking != null && m_load_booking.Length > 50) { m_load_booking = m_load_booking.Substring(0, 50); } return m_load_booking; }
         set { m_load_booking = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_MBL.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 6)]
      public String LOAD_MBL
      {
         get { if (m_load_mbl != null && m_load_mbl.Length > 50) { m_load_mbl = m_load_mbl.Substring(0, 50); } return m_load_mbl; }
         set { m_load_mbl = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_HBL.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 7)]
      public String LOAD_HBL
      {
         get { if (m_load_hbl != null && m_load_hbl.Length > 50) { m_load_hbl = m_load_hbl.Substring(0, 50); } return m_load_hbl; }
         set { m_load_hbl = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_POD.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 8)]
      public String LOAD_POD
      {
         get { if (m_load_pod != null && m_load_pod.Length > 50) { m_load_pod = m_load_pod.Substring(0, 50); } return m_load_pod; }
         set { m_load_pod = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_OFTERM.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 9)]
      public String LOAD_OFTERM
      {
         get { if (m_load_ofterm != null && m_load_ofterm.Length > 50) { m_load_ofterm = m_load_ofterm.Substring(0, 50); } return m_load_ofterm; }
         set { m_load_ofterm = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_CNTR.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 10)]
      public String LOAD_CNTR
      {
         get { if (m_load_cntr != null && m_load_cntr.Length > 50) { m_load_cntr = m_load_cntr.Substring(0, 50); } return m_load_cntr; }
         set { m_load_cntr = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_SHIPPER.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 11)]
      public String LOAD_SHIPPER
      {
         get { if (m_load_shipper != null && m_load_shipper.Length > 100) { m_load_shipper = m_load_shipper.Substring(0, 100); } return m_load_shipper; }
         set { m_load_shipper = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_CONSIGNEE.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 12)]
      public String LOAD_CONSIGNEE
      {
         get { if (m_load_consignee != null && m_load_consignee.Length > 100) { m_load_consignee = m_load_consignee.Substring(0, 100); } return m_load_consignee; }
         set { m_load_consignee = value; }
      }
      /// <summary>
      /// Gets or sets el valor de: LOAD_CODE.
      /// </summary>
      [DataMember]
      [TableValueParameter(Export = true, Orden = 13)]
      public String LOAD_CODE
      {
         get { if (m_load_code != null && m_load_code.Length > 50) { m_load_code = m_load_code.Substring(0, 50); } return m_load_code; }
         set { m_load_code = value; }
      }
      #endregion


      //[POL]        
      //[M/V]        
      //[ETD]        
      //[CARRIER]    
      //[BOOKING NO.]
      //[MB/L]       
      //[HB/L]       
      //[POD]        
      //[20']        
      //[40']        
      //[40'HQ]      
      //[40'NOR]     
      //[O/F TERM]   
      //[CNTR]       
      //[SHIPPER]    
      //[CONSIGNEE]  
      //[CODE]       
   }
}
