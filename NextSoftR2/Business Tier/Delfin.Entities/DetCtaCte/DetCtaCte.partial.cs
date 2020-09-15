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
   public partial class DetCtaCte
   {
      public enum TInterfazDetCtaCte
      {
         Normal = 0, Canje = 1
      }

      private Boolean m_Trasanct = false;

      [DataMember]
      public Boolean Trasanct
      {
         get { return m_Trasanct; }
         set { m_Trasanct = value; }
      }

      [DataMember]
      public Boolean Seleccionar { get; set; }

      [DataMember]
      public String CCCT_Serie { get; set; }
      [DataMember]
      public String CCCT_Numero { get; set; }
      [DataMember]
      public String NAVE_Nombre { get; set; }
      [DataMember]
      public String TIPO_MND { get; set; }
      [DataMember]
      public String TIPO_MND_Simbolo { get; set; }
      [DataMember]
      public String TIPO_CodMND_Real { get; set; }
      [DataMember]
      public String CONS_TDC { get; set; }
      [DataMember]
      public String TIPO_TDO { get; set; }
      [DataMember]
      public String TIPO_CodTDO { get; set; }

      [DataMember]
      public String MBL_HBL { get; set; }
      [DataMember]
      public String TipoPago { get; set; }
      [DataMember]
      public String OV_OP { get; set; }

      [DataMember]
      public Nullable<Decimal> CCCT_Monto { get; set; }
      [DataMember]
      public Nullable<Decimal> CCCT_Monto_Real { get; set; }
      [DataMember]
      public String CCCT_Monto_Real_Text
      {
         get { return String.Format("{0} {1:#,###,##0.00}", TIPO_MND_Simbolo, CCCT_Monto_Real); }
      }

      [DataMember]
      public Nullable<Decimal> CCCT_Saldo { get; set; }
      [DataMember]
      public String CCCT_Saldo_Text
      {
         get { return String.Format("{0} {1:#,###,##0.00}", TIPO_MND_Simbolo, CCCT_Saldo); }
      }

      [DataMember]
      public String CCCT_Monto_Text
      {
         get { return String.Format("{0} {1:#,###,##0.00}", TIPO_MND_Simbolo, CCCT_Monto); }
      }

      public String CCCT_Pendiente_Text
      {
         get { return String.Format("{0} {1:#,###,##0.00}", TIPO_MND_Simbolo, CCCT_Pendiente); }
      }

      [DataMember]
      public Nullable<Decimal> CCCT_Pendiente { get; set; }
      [DataMember]
      public Nullable<Decimal> CCCT_Pendiente_Real { get; set; }
      [DataMember]
      public Nullable<Decimal> CCCT_TipoCambio { get; set; }
      [DataMember]
      public Int32 ENTC_Codigo { get; set; }
      [DataMember]
      public String ENTC_DocIden { get; set; }
      [DataMember]
      public String ENTC_RazonSocial { get; set; }
      [DataMember]
      public DateTime CCCT_Fecha { get; set; }
      [DataMember]
      public DateTime CCCT_FechaEmision { get; set; }
      [DataMember]
      public Decimal CCCT_MontoDetraccion { get; set; }
      [DataMember]
      public String CCCT_Glosa { get; set; }
      [DataMember]
      public String SERV_Codigo { get; set; }
      [DataMember]
      public String SERV_Nombre_SPA { get; set; }

      [DataMember]
      public String FEmbarque { get; set; }
      [DataMember]
      public String FDescarga { get; set; }
      [DataMember]
      public String LIQU_Codigo { get; set; }
      [DataMember]
      public Boolean ENCB_NroCuenta_Bool { get; set; }
      [DataMember]
      public Boolean ENTC_Interbancario_Bool { get; set; }
      [DataMember]
      public String ENTC_Interbancario { get; set; }
      [DataMember]
      public String ENCB_NroCuenta { get; set; }
      [DataMember]
      public String TipoCtaCte { get; set; }
      [DataMember]
      public string MODULO { get; set; }
      [DataMember]
      public Boolean CCCT_ProvAsumeDetraccion { get; set; }
      [DataMember]
      public String CCCT_ProvAsumeDetraccion_Text { get { return CCCT_ProvAsumeDetraccion ? "Si" : "No"; } }

      [DataMember]
      public String TipoMovimiento { get; set; }
      [DataMember]
      public String Asiento { get; set; }
      [DataMember]
      public String CUBA_NroCuenta { get; set; }
      [DataMember]
      public String TIPO_MND_MOV { get; set; }
   }
}
