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
   public partial class Planillas
   {

      #region [ Variables ]

      public enum Estado
      {
         Ingresado = 1, Anulado = 2, Extornado = 3
      }

      public enum TipoPlanilla
      {
         MedioVirtual = 0, Detracciones = 1
      }

      #endregion

      #region [ Propiedades ]

      [DataMember]
      public ObservableCollection<Entities.Movimiento> ListMovimiento { get; set; }
      [DataMember]
      public ObservableCollection<Entities.DetCtaCte> ListDetCtaCte { get; set; }
      [DataMember]
      public CuentasBancarias ItemCuentasBancarias { get; set; }
      [DataMember]
      public Decimal TipoCambio { get; set; }
      [DataMember]
      public String PLAN_Tipo_Text { get; set; }
      [DataMember]
      public Decimal Monto { get; set; }
      [DataMember]
      public String CONS_EST { get; set; }
      [DataMember]
      public String CUBA_Codigo { get; set; }
      [DataMember]
      public String CUBA_NroCuenta { get; set; }
      [DataMember]
      public String TIPO_MND { get; set; }
      [DataMember]
      public String TIPO_BCO { get; set; }
      [DataMember]
      public TipoPlanilla TPlanilla { get; set; }
      [DataMember]
      public String Banco { get; set; }
      [DataMember]
      public String RUC_Empresa { get; set; }
      [DataMember]
      public String AsientoCaja { get; set; }

      #endregion

      #region [ Metodos ]

      public void SetEstado(Estado x_opcion)
      {
         CONS_CodEST = String.Format("{0:000}", (int)x_opcion);
         CONS_TabEST = "EST";
      }

      public static String GetEstado(Estado x_opcion)
      {
         return String.Format("{0:000}", (int)x_opcion);
      }

      public void SetTipoPlanilla(TipoPlanilla x_opcion)
      {
         try
         {
            m_plan_tipo = GetTipoPlanilla(x_opcion);
         }
         catch (Exception)
         { }
      }

      public static String GetTipoPlanilla(TipoPlanilla x_opcion)
      {
         try
         {
            switch (x_opcion)
            {
               case TipoPlanilla.MedioVirtual:
                  return "WWW";
               case TipoPlanilla.Detracciones:
                  return "DET";
               default:
                  break;
            }
            return null;
         }
         catch (Exception)
         { return null; }
      }


      #endregion

   }
}
