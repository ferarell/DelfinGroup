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
	public partial class Transferencia
   {
      #region [ Propiedades ]

      public enum Estado
      {
         Ingresado = 0, Anulado = 1
      }

      public enum TOperacion
      {
         Normal = 0, Eliminar = 1, Anular = 2
      }

      [DataMember]
	   public ObservableCollection<Movimiento> ListIngresos { get; set; }
      [DataMember]
      public ObservableCollection<Movimiento> ListIngresosEliminados { get; set; }
      [DataMember]
      public ObservableCollection<Movimiento> ListEgresos { get; set; }
      [DataMember]
      public ObservableCollection<Movimiento> ListEgresosEliminados { get; set; }
      [DataMember]
      public ObservableCollection<GastosBancarios> ListGastosBancarios { get; set; }
      [DataMember]
      public ObservableCollection<GastosBancarios> ListGastosBancariosEliminados { get; set; }
      
      [DataMember]
      public string TRAN_Estado_Text { get; set; }
      [DataMember]
      public Decimal Diferencia { get; set; }
      [DataMember]
      public String AsientoContable_DG { get; set; }
      [DataMember]
      public String AsientoContable_DC { get; set; }

      #endregion

      #region Metodos

      public void SetEstado(Estado x_opcion)
      {
         try
         {
            switch (x_opcion)
            {
               case Estado.Ingresado:
                  m_tran_estado = "I";
                  break;
               case Estado.Anulado:
                  m_tran_estado = "X";
                  break;
               default:
                  m_tran_estado = null;
                  break;
            }
         }
         catch (Exception)
         { }
      }

      public String GetEstado(Estado x_opcion)
      {
         try
         {
            switch (x_opcion)
            {
               case Estado.Ingresado:
                  return "I";
               case Estado.Anulado:
                  return "X";
               default:
                  return "";
            }
         }
         catch (Exception)
         { return ""; }
      }

      #endregion

   }
}
