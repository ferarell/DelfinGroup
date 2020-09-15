using System;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
   public partial interface IBLCab_Cotizacion_OV
   {
      #region [ Consultas ]
      System.Data.DataTable OPE_GetDT(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      ObservableCollection<Cab_Cotizacion_OV> OPE_GetAllFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      ObservableCollection<Cab_Cotizacion_OV> OPE_GetAll();
      Cab_Cotizacion_OV OPE_GetOne(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero);

      System.Data.DataSet OPE_GetOneImpresionHBL(Int16 CCOT_Tipo, Int32 CCOT_Numero);
      System.Data.DataTable OPE_GetOneImpresionEtiqueta(Int16 CCOT_Tipo, Int32 CCOT_Numero);
      #endregion

      #region [ Metodos ]
      Boolean OPE_Save(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError);
      Boolean OPE_Save(ref ObservableCollection<Cab_Cotizacion_OV> Items);

      Boolean OPE_Save_ValidarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, ref String x_mensaje);
      Boolean OPE_Save_GenerarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, Decimal x_CCCT_TipoCambio, DateTime x_CCCT_FecEmision, String x_AUDI_Usuario, Boolean AprobarViaje, ref String x_mensaje);
      Boolean OPE_Save_NumerarHBL(ref Cab_Cotizacion_OV Item, ref String NumeroHBL, String Usuario);
      Boolean OPE_Update_CalculaRebateGRR(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      //(Nullable<Int32> x_ENTC_CodTransportista, Nullable<Int32> x_ENTC_CodCliente, Nullable<DateTime> x_FEC_IniEmbarque, Nullable<DateTime> x_FEC_FinEmbarque, Nullable<DateTime> x_FEC_IniLlegada, Nullable<DateTime> x_FEC_FinLlegada, String x_NRO_HBL, String x_NRO_OV);
      
      #endregion

      #region [ Reportes ]
      System.Data.DataTable OPE_GetStatment(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 NVIA_Codigo, Nullable<Int16> CCOT_Tipo, Nullable<Int32> CCOT_Numero, String Usuario, Decimal TIPC_TipoCambio, Boolean SCOT_ChangeControl, Boolean CCOT_ServicioTransmision);
      System.Data.DataSet OPE_GetReporteGerencia(String REPO_StoredProcedure, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime REPO_FechaInicio, DateTime REPO_FechaTermino, Decimal TIPC_TipoCambio);
      System.Data.DataSet OPE_GetReporteGerencia(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      System.Data.DataTable OPE_GetStatmentChange(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      #endregion
   }
}
