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
   public partial class CtaCte
   {
      #region Variables

      public enum TInterfazCtaCte
      {
         IngresoLibre = 0, RegistroDescuadre = 1, RegistroLiquidacion = 2, Facturar = 3, RegistroSLI = 4, AnularCtaCte = 5
         , EnviarAsientoADiario = 6, RegenerarAsientoReversionCompras = 7
      }

      public enum TipoDesvinculacion
      {
         AsientoProvision = 0, AsientoCompRev = 1, AsientoORevComp = 2
      }

      public enum TipoDesvAsiento
      {
         Anular = 0, Eliminar = 1
      }

      String m_CTAR_Tipo;
      Int32 m_Entidad;
      Int32 m_COPE_Codigo;
      Int16 m_TIPE_CodigoServicio;
      Int16 m_prefacturado;
      Decimal m_ccct_costo;

      #endregion

      #region Propiedades

      public enum TipoMovimiento
      {
         Ingreso = 0, Egreso = 1
      }

      [DataMember]
      public TipoMovimiento TMovimiento { get; set; }

      [DataMember]
      public Boolean Seleccionar { get; set; }

      [DataMember]
      public DetCtaCte ItemDetCtaCte { get; set; }

      public LiqCtaCte ItemLiqCtaCte { get; set; }
      [DataMember]
      public TInterfazCtaCte TipoInterfazCtaCte { get; set; }
      [DataMember]
      public String SerieFacturacion { get; set; }

      [DataMember]
      public String CTAR_Tipo
      {
         get { return m_CTAR_Tipo; }
         set { m_CTAR_Tipo = value; }
      }
      [DataMember]
      public Int32 Entidad
      {
         get { return m_Entidad; }
         set { m_Entidad = value; }
      }
      [DataMember]
      public Int32 COPE_Codigo
      {
         get { return m_COPE_Codigo; }
         set { m_COPE_Codigo = value; }
      }
      [DataMember]
      public Decimal CCCT_Costo
      {
         get { return m_ccct_costo; }
         set { m_ccct_costo = value; }
      }
      [DataMember]
      public Int16 TIPE_CodigoServicio
      {
         get { return m_TIPE_CodigoServicio; }
         set { m_TIPE_CodigoServicio = value; }
      }
      [DataMember]
      public Int16 PreFacturado
      {
         get { return m_prefacturado; }
         set { m_prefacturado = value; }
      }
      [DataMember]
      public String TIPO_MND { get; set; }
      [DataMember]
      public String TIPO_TDO { get; set; }
      [DataMember]
      public String TIPO_FPG { get; set; }
      [DataMember]
      public String TIPO_DET { get; set; }
      [DataMember]
      public String ENTC_DocIden { get; set; }
      [DataMember]
      public String ENTC_RazonSocial { get; set; }
      [DataMember]
      public String TIPE_Descripcion { get; set; }
      [DataMember]
      public Int32 MOVI_Codigo { get; set; }
      [DataMember]
      public String LIQU_Codigo { get; set; }
      [DataMember]
      public Nullable<Int16> LCCC_Item { get; set; }
      [DataMember]
      public String DOOV_MBL { get; set; }
      [DataMember]
      public String DOOV_HBL { get; set; }
      [DataMember]
      public String NAVE_Nombre { get; set; }
      [DataMember]
      public String FEmbarque { get; set; }
      [DataMember]
      public String FDescarga { get; set; }
      [DataMember]
      public String FechaETA { get; set; }

      [DataMember]
      public String Viaje { get; set; }
      [DataMember]
      public String OV_OP { get; set; }
      [DataMember]
      public String MBL_HBL { get; set; }
      [DataMember]
      public String TipoCtaCte { get; set; }
      [DataMember]
      public string MODULO { get; set; }
      [DataMember]
      public String ESTADO { get; set; }
      [DataMember]
      public String CCCT_Estado_text { get; set; }
      [DataMember]
      public String NumDoc { get; set; }

      [DataMember]
      public String Detraccion { set; get; }
      [DataMember]
      public Boolean ConDetraccion { get; set; }
      [DataMember]
      public String ConDetraccion_text { get { return ConDetraccion ? "Si" : "No"; } }
      [DataMember]
      public Nullable<DateTime> DOCV_FechaVcmto { get; set; }
      [DataMember]
      public Nullable<DateTime> DOCV_FechaEmision { get; set; }
      [DataMember]
      public Boolean Diferido { get; set; }
      [DataMember]
      public String TIPO_MND_Simbolo { get; set; }
      [DataMember]
      public String CCCT_RCImpreso_Text { get { return CCCT_RCImpreso ? "Si" : "No"; } }
      [DataMember]
      public String PagoMNDOriginal { get; set; }
      [DataMember]
      public Boolean CCOT_Bloqueado { get; set; }
      #region Conciliacion

      [DataMember]
      public String ObservacionesConciliacion { get; set; }
      [DataMember]
      public Boolean ConciliadoAgente { get; set; }
      [DataMember]
      public Boolean ConciliadoError { get; set; }
      [DataMember]
      public Nullable<Decimal> CCCT_Pendiente_Cargo { get; set; }
      [DataMember]
      public Nullable<Decimal> CCCT_Pendiente_Abono { get; set; }

      #endregion

      [DataMember]
      public String AsientoContable
      {
         get
         {
            if (!String.IsNullOrEmpty(m_caba_ano) && !String.IsNullOrEmpty(m_caba_mes))
            { return String.Format("{0}{1}-{2}-{3}", m_caba_ano, m_caba_mes, m_tipo_codreg, m_caba_nrovoucher); }
            else
            { return ""; }
         }
      }

      public String AsientoContableC
      {
         get
         {
            if (String.IsNullOrEmpty(m_caba_ano_lcompras) && String.IsNullOrEmpty(m_caba_mes_lcompras))
            { return ""; }
            else
            { return String.Format("{0}{1}-{2}-{3}", m_caba_ano_lcompras, m_caba_mes_lcompras, m_tipo_codreg_lcompras, m_caba_nrovoucher_lcompras); }
         }
      }
      [DataMember]
      public String AsientoContableO { get; set; }

      [DataMember]
      public String CCCT_OrigenContable { get; set; }
      [DataMember]
      public String CCCT_OrigenContableCompras { get; set; }
      [DataMember]
      public String OrigenDocumento { get; set; }
      
      [DataMember]
      public String SERV_Nombre_SPA { get; set; }
      [DataMember]
      public String TIPO_CodOPE_Costo { get; set; }
      [DataMember]
      public String TIPO_TabOPE_Costo { get; set; }
      [DataMember]
      public String CENT_Ano { get; set; }
      [DataMember]
      public String CENT_Codigo { get; set; }

      //public String CCCT_Numero_Original { get; set; }

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
      [DataMember]
      public Boolean NoDomiciliado { get; set; }
      [DataMember]
      public String TIPO_CodTDO_CodSunat { get; set; }
      [DataMember]
      public Nullable<DateTime> NVIA_FecPreFactura { get; set; }
      [DataMember]
      public Nullable<DateTime> NVIA_FecETA_IMPO_ETD_EXPO { get; set; }
      [DataMember]
      public String DocVenta { get; set; }

      #endregion
   }
}
