using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
      #region [ Consultas ]
      System.Data.DataTable OPE_GetDTCab_Cotizacion_OV(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      ObservableCollection<Cab_Cotizacion_OV> OPE_GetAllCab_Cotizacion_OVFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      ObservableCollection<Cab_Cotizacion_OV> OPE_GetAllCab_Cotizacion_OV();
      Cab_Cotizacion_OV OPE_GetOneCab_Cotizacion_OV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero);
      System.Data.DataSet OPE_GetOneCab_Cotizacion_OVImpresionHBL(Int16 CCOT_Tipo, Int32 CCOT_Numero);

      System.Data.DataTable OPE_GetOneCab_Cotizacion_OVImpresionEtiqueta(Int16 CCOT_Tipo, Int32 CCOT_Numero);
      #endregion

      #region [ Metodos ]
      Boolean OPE_SaveCab_Cotizacion_OV(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError);
      Boolean OPE_SaveCab_Cotizacion_OV_ValidarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, ref String x_mensaje);
      Boolean OPE_SaveCab_Cotizacion_OV_GenerarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, Decimal x_CCCT_TipoCambio, DateTime x_CCCT_FecEmision, String x_AUDI_Usuario, Boolean AprobarViaje, ref String x_mensaje);
      Boolean OPE_SaveCab_Cotizacion_OV_NumerarHBL(ref Cab_Cotizacion_OV Item, ref String NumeroHBL, String Usuario);
      Boolean OPE_SaveCab_Cotizacion_OV_CalculaRebateGRR(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);//(Nullable<Int32> x_ENTC_CodTransportista, Nullable<Int32> x_ENTC_CodCliente, Nullable<DateTime> x_FEC_IniEmbarque, Nullable<DateTime> x_FEC_FinEmbarque, Nullable<DateTime> x_FEC_IniLlegada, Nullable<DateTime> x_FEC_FinLlegada, String x_NRO_HBL, String x_NRO_OV);
      #endregion

      #region [ Reportes ]
      System.Data.DataTable OPE_GetCab_Cotizacion_OVStatment(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 NVIA_Codigo, Nullable<Int16> CCOT_Tipo, Nullable<Int32> CCOT_Numero, String Usuario, Decimal TIPC_TipoCambio, Boolean SCOT_ChangeControl, Boolean CCOT_ServicioTransmision);
      System.Data.DataSet OPE_GetCab_Cotizacion_OVReporteGerencia(String REPO_StoredProcedure, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime REPO_FechaInicio, DateTime REPO_FechaTermino, Decimal TIPC_TipoCambio);
      System.Data.DataSet OPE_GetCab_Cotizacion_OVReporteGerencia(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);

      System.Data.DataTable OPE_GetCab_Cotizacion_OVStatmentChange(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      #endregion
   }
}
