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
   public partial class DocsVta
   {
      //[DataMember]
      //public Int32 ENTC_Codigo { set; get; }

      #region Propiedades Adicionales
            
      public enum TInterfazDocsVta
      {
         Normal = 0, NotaCredito = 1, AnularNotaCredito = 2, AnularFactura = 3, ActualizarFormaPago = 4, RegenerarDocumentoVenta = 5
         , FacturacionLibre = 6, ActualizarFactura = 7, AnularFacturaFE = 8, AnularNotaCreditoFE = 9
      }
            
      [DataMember]
      public ObservableCollection<DetDocsVta> ItemsDetDocsVta { set; get; }

      [DataMember]
      public ObservableCollection<DetDocsVta> ItemsDetDocsVtaEliminados { set; get; }

      [DataMember]
      public ObservableCollection<DetDocsVta_Det_Operacion> ItemsDetDocsVta_Det_Operacion { set; get; }

      [DataMember]
      public CtaCte ItemCtaCte { get; set; }
      [DataMember]
      public DetCtaCte ItemDetCtaCte { get; set; }
      [DataMember]
      public DetCtaCte ItemDetCtaCteFactura { get; set; }

      [DataMember]
      public String DOCV_EstadoStr { set; get; }
      [DataMember]
      public String ENTC_DocIden { get; set; }
      [DataMember]
      public String Cliente { set; get; }
      [DataMember]
      public String Moneda { set; get; }

      [DataMember]
      public String COPE_HBL { set; get; }
      [DataMember]
      public String COPE_MBL { set; get; }
      [DataMember]
      public String TIPO_TDO { get; set; }
      [DataMember]
      public String TIPO_FPG { get; set; }

      [DataMember]
      public String COPE_NumDoc { set; get; }
      [DataMember]
      public Decimal DOCV_MontoPagado { set; get; }
      [DataMember]
      public String TIPO_TDO_Factura { get; set; }
      [DataMember]
      public String NroFactura { get; set; }
      [DataMember]
      public Decimal MontoFactura { get; set; }
      [DataMember]
      public String HBL_MBL { get; set; }
      [DataMember]
      public String OV_OP { get; set; }
      [DataMember]
      public Decimal CCCT_Pendiente { get; set; }
      [DataMember]
      public Int32 CCCT_Codigo { get; set; }
      [DataMember]
      public Int16 EMPR_Codigo { get; set; }
      [DataMember]
      public String CCCT_Glosa { get; set; }
      [DataMember]
      public Boolean CCOT_Bloqueado { get; set; }

      [DataMember]
      public String CCOT_TipoNumero { get; set; }

      [DataMember]
      public String AsientoContable { get; set; }


      [DataMember]
      public String emailFE { get; set; }


      [DataMember]
      public Decimal Base { get; set; }
      [DataMember]
      public Decimal IGV { get; set; }
      [DataMember]
      public Decimal Total { get; set; }
      [DataMember]
      public Decimal TipoCambio { get; set; }

      [DataMember]
      public Decimal CCCT_Monto_S { get; set; }
      [DataMember]
      public Decimal CCCT_Monto_D { get; set; }

      #endregion

   }
}
