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
      #region Variables

      private DetCtaCte m_itemDetCtaCte;
      private ObservableCollection<DetCtaCte> m_listDetCtaCte;
      private CtaCte m_itemCtaCteDescuadre;
      private ObservableCollection<CtaCte> m_listCtaCte;

      [DataMember]
      public ObservableCollection<MovimientoFlujo> ListFlujos { get; set; }
      [DataMember]
      public ObservableCollection<MovimientoFlujo> ListFlujosEliminados { get; set; }
      [DataMember]
      public ObservableCollection<Tipificaciones> ListTipificaciones { get; set; }
      [DataMember]
      public ObservableCollection<Tipificaciones> ListTipificacionesEliminados { get; set; }

      [DataMember]
      public ObservableCollection<DetCtaCte> ListDetCtaCte
      {
         get { return m_listDetCtaCte; }
         set { m_listDetCtaCte = value; }
      }
      [DataMember]
      public ObservableCollection<DetCtaCte> ListDetCtaCteEliminados { get; set; }
      #endregion
      [DataMember]
      public ObservableCollection<Conciliacion> ListConciliacion { get; set; }
      #region Enumeradores

      public enum TipoMovimiento
      {
         Ingresos = 1, IngresosDiferidos = 2, EgresosDepositos = 3, EgresosCheque = 4, EgresosChequeDiferido = 5, 
         EgresosTransferenciaCuentasPropias = 6, EgresosTransferenciaMVirtual = 7, IngresosTransferenciaCuentasPropias = 8,
         IngresosExtorno = 9, EgresosExtorno = 10
      }

      public enum TInterfazMovimiento
      {
         Ingresos = 0, Egresos = 1, ChequeEnBlanco = 2, Transferencia = 3, EjecutarDiferido = 4, RegistroPlanilla = 5,
         RediferirMovimiento = 6, Anular = 7, Extornar = 8, 
      }

      public enum TInterfazMovimientos
      {
         Conciliacion = 0
      }

      public enum EstadoCheque
      {
         Blanco = 0, Cartera = 1, Entregado = 2
      }

      public enum Estado
      {
         Ingresado = 1, Anulado = 2, Extornado = 3
      }

      #endregion

      #region Propiedaes

      [DataMember]
      public CtaCte ItemCtaCteDescuadre
      {
         get { return m_itemCtaCteDescuadre; }
         set { m_itemCtaCteDescuadre = value; }
      }
      [DataMember]
      public DetCtaCte ItemDetCtaCte
      {
         get { return m_itemDetCtaCte; }
         set { m_itemDetCtaCte = value; }
      }
      [DataMember]
      public Conciliacion ItemConciliacion { get; set; }
      [DataMember]
      public Chequera ItemChequera { get; set; }
      [DataMember]
      public Liquidacion Liquidacion { get; set; }

      public ObservableCollection<Firmas> ItemsFirmas { get; set; }
      [DataMember]
      public Tipos TIPO_Movimiento { get; set; }

      [DataMember]
      public Boolean Seleccionar { get; set; }
      [DataMember]
      public TInterfazMovimiento TipoInterfazMovimiento { get; set; }
      [DataMember]
      public EstadoCheque NEstadoCheque { get; set; }

      [DataMember]
      public String NEstado { get; set; }
      [DataMember]
      public String TIPO_CodMND { get; set; }
      [DataMember]
      public String TIPO_MND { get; set; }
      [DataMember]
      public String CUBA_NroCuenta { get; set; }
      [DataMember]
      public String TIPO_MOV { get; set; }
      [DataMember]
      public String TIPO_MOV_Corta { get; set; }
      [DataMember]
      public String TMovimiento { get; set; }
      [DataMember]
      public Decimal Monto { get; set; }
      [DataMember]
      public String Monto_text { get { return String.Format("{0} {1:#,###,##0.00}", TIPO_MND_Simbolo, Monto); } }
      [DataMember]
      public String Documentos { get; set; }
      [DataMember]
      public String OrdenVenta { get; set; }
      [DataMember]
      public String ENTC_DocIden { get; set; }
      [DataMember]
      public String ENTC_RazonSocial { get; set; }
      [DataMember]
      public Boolean TieneDescuadre { get; set; }
      [DataMember]
      public Boolean EsLiquidacion { get; set; }
      [DataMember]
      public Boolean GeneraCtaCte { get; set; }
      [DataMember]
      public String Oficina_Operacion { get; set; }
      [DataMember]
      public Boolean Extornado { get; set; }
      [DataMember]
      public String TipoCtaCte { get; set; }
      [DataMember]
      public String Extornado_Text { get { return Extornado ? "Si" : "No"; } }
      [DataMember]
      public Boolean Transferencia { get; set; }
      [DataMember]
      public String Transferencia_Text { get { return Transferencia ? "Si" : "No"; } }
      [DataMember]
      public Boolean Diferido { get; set; }
      [DataMember]
      public String Diferido_Text { get { return Diferido ? "Si" : "No"; } }
      [DataMember]
      public Boolean Ejecutado { get; set; }
      [DataMember]
      public Boolean ChequeEnBlanco { get; set; }
      [DataMember]
      public String ChequeEnBlanco_Text { get { return ChequeEnBlanco ? "Si" : "No"; } }
      [DataMember]
      public DateTime FechaSistema { get; set; }
      [DataMember]
      public String TIPO_MND_Simbolo { get; set; }
      [DataMember]
      public String TipoEntidad { get; set; }
      #region Conciliacion

      [DataMember]
      public Nullable<Int32> CONC_Codigo { get; set; }
      [DataMember]
      public String CONC_Periodo { get; set; }
      [DataMember]
      public Nullable<DateTime> CONC_FecConciliacion { get; set; }
      [DataMember]
      public Nullable<Decimal> CONC_MontoBCO { get; set; }

      #endregion

      #endregion

      #region Metodos

      public void SetTipoMovimiento(TipoMovimiento x_opcion)
      {
         TIPO_CodMOV = String.Format("{0:000}", (int)x_opcion);
         TIPO_TabMOV = "MOV";
      }

      public TipoMovimiento GetTipoMovimiento()
      {
         Int32 _tipo = 0;
         if (Int32.TryParse(m_tipo_codmov, out _tipo))
         {
            return (((TipoMovimiento)_tipo));
         }
         else
         {
            return TipoMovimiento.Ingresos;
         }
      }

      public void SetEstado(Estado x_opcion)
      {
         CONS_CodEST = String.Format("{0:000}", (int)x_opcion);
         CONS_TabEST = "EST";
      }

      public static String GetEstado(Estado x_opcion)
      {
         return String.Format("{0:000}", (int)x_opcion);
      }

      public void SetEstadoCheque(EstadoCheque x_estado)
      {
         this.MOVI_EstadoCheque = GetEstadoCheque(x_estado);
         this.NEstadoCheque = x_estado;
      }

      public static String GetEstadoCheque(EstadoCheque x_estado)
      {
         switch (x_estado)
         {
            case EstadoCheque.Blanco:
               return "B";
            case EstadoCheque.Cartera:
               return "C";
            case EstadoCheque.Entregado:
               return "E";
         }
         return "-";
      }

      public String GetTipoMovimiento(TipoMovimiento x_opcion)
      {
         return String.Format("{0:000}", (int)x_opcion);
      }

      [DataMember]
      public String AsientoContable_DG
      {
         get
         {
            if (!String.IsNullOrEmpty(m_caba_ano) && !String.IsNullOrEmpty(m_caba_nrovoucher))
            { return String.Format("{0}{1}-{2}-{3}", m_caba_ano, m_caba_mes, m_tipo_codreg, m_caba_nrovoucher); }
            else
            { return ""; }
         }
      }
      [DataMember]
      public String AsientoContable_DC
      {
         get
         {
            if (!String.IsNullOrEmpty(m_caba_ano_dc) && !String.IsNullOrEmpty(m_caba_nrovoucher_dc))
            { return String.Format("{0}{1}-{2}-{3}", m_caba_ano_dc, m_caba_mes_dc, m_tipo_codreg_dc, m_caba_nrovoucher_dc); }
            else
            { return ""; }
         }
      }

      [DataMember]
      public String AsientoContable_DG_02 { get; set; }
      [DataMember]
      public String AsientoContable_DG_04 { get; set; }
      [DataMember]
      public String AsientoContable_DC_04 { get; set; }

      #endregion

   }
}
