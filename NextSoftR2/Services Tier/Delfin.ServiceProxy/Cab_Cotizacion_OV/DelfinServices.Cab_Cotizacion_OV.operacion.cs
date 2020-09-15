using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;
using Delfin.ServiceContracts;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.ServiceProxy
{

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Consultas ]
      public System.Data.DataTable OPE_GetDTCab_Cotizacion_OV(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Cotizacion_OV> OPE_GetAllCab_Cotizacion_OVFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Cotizacion_OV> OPE_GetAllCab_Cotizacion_OV()
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Cab_Cotizacion_OV OPE_GetOneCab_Cotizacion_OV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetOne(EMPR_Codigo, SUCR_Codigo, CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet OPE_GetOneCab_Cotizacion_OVImpresionHBL(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetOneImpresionHBL(CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataTable OPE_GetOneCab_Cotizacion_OVImpresionEtiqueta(Int16 CCOT_Tipo, Int32 CCOT_Numero)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetOneImpresionEtiqueta(CCOT_Tipo, CCOT_Numero);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Metodos ]
      public Boolean OPE_SaveCab_Cotizacion_OV(ref Cab_Cotizacion_OV Item, ref String CCOT_MensajeError)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_Save(ref Item, ref CCOT_MensajeError);
         }
         catch (Exception)
         { throw; }
      }

      public Boolean OPE_SaveCab_Cotizacion_OV_ValidarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, ref String x_mensaje)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_Save_ValidarCuentasCorrientes(x_EMPR_Codigo, x_SUCR_Codigo, x_NVIA_Codigo, x_CCOT_Tipo, x_CCOT_Numero, ref x_mensaje);
         }
         catch (Exception)
         { throw; }
      }
      public Boolean OPE_SaveCab_Cotizacion_OV_GenerarCuentasCorrientes(Int16 x_EMPR_Codigo, Int16 x_SUCR_Codigo, Int32 x_NVIA_Codigo, Nullable<Int16> x_CCOT_Tipo, Nullable<Int32> x_CCOT_Numero, Decimal x_CCCT_TipoCambio, DateTime x_CCCT_FecEmision, String x_AUDI_Usuario, Boolean AprobarViaje, ref String x_mensaje)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_Save_GenerarCuentasCorrientes(x_EMPR_Codigo, x_SUCR_Codigo, x_NVIA_Codigo, x_CCOT_Tipo, x_CCOT_Numero, x_CCCT_TipoCambio, x_CCCT_FecEmision, x_AUDI_Usuario, AprobarViaje, ref x_mensaje);
         }
         catch (Exception)
         { throw; }
      }
      public Boolean OPE_SaveCab_Cotizacion_OV_NumerarHBL(ref Cab_Cotizacion_OV Item, ref String NumeroHBL, String Usuario)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_Save_NumerarHBL(ref Item, ref NumeroHBL , Usuario);
         }
         catch (Exception)
         { throw; }
      }
      public Boolean OPE_SaveCab_Cotizacion_OV_CalculaRebateGRR(String x_REBA_Tipo, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)//(Nullable<Int32> x_ENTC_CodTransportista, Nullable<Int32> x_ENTC_CodCliente, Nullable<DateTime> x_FEC_IniEmbarque, Nullable<DateTime> x_FEC_FinEmbarque, Nullable<DateTime> x_FEC_IniLlegada, Nullable<DateTime> x_FEC_FinLlegada, String x_NRO_HBL, String x_NRO_OV)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_Update_CalculaRebateGRR(x_REBA_Tipo, x_filters);//(x_ENTC_CodTransportista, x_ENTC_CodCliente, x_FEC_IniEmbarque, x_FEC_FinEmbarque, x_FEC_IniLlegada, x_FEC_FinLlegada, x_NRO_HBL, x_NRO_OV);
         }
         catch (Exception)
         { throw; }
      }
      #endregion

      #region [ Reportes ]
      public System.Data.DataTable OPE_GetCab_Cotizacion_OVStatment(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 NVIA_Codigo, Nullable<Int16> CCOT_Tipo, Nullable<Int32> CCOT_Numero, String Usuario, Decimal TIPC_TipoCambio, Boolean SCOT_ChangeControl, Boolean CCOT_ServicioTransmision)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetStatment(EMPR_Codigo, SUCR_Codigo, NVIA_Codigo, CCOT_Tipo, CCOT_Numero, Usuario, TIPC_TipoCambio, SCOT_ChangeControl, CCOT_ServicioTransmision);
         }
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet OPE_GetCab_Cotizacion_OVReporteGerencia(String REPO_StoredProcedure, Int16 EMPR_Codigo, Int16 SUCR_Codigo, DateTime REPO_FechaInicio, DateTime REPO_FechaTermino, Decimal TIPC_TipoCambio)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetReporteGerencia(REPO_StoredProcedure, EMPR_Codigo, SUCR_Codigo, REPO_FechaInicio, REPO_FechaTermino, TIPC_TipoCambio);
         } 
         catch (Exception)
         { throw; }
      }
      public System.Data.DataSet OPE_GetCab_Cotizacion_OVReporteGerencia(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetReporteGerencia(REPO_StoredProcedure, x_filters);
         }
         catch (Exception) { throw; }
      }

      public System.Data.DataTable OPE_GetCab_Cotizacion_OVStatmentChange(String REPO_StoredProcedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.OPE_GetStatmentChange(REPO_StoredProcedure, x_filters);
         }
         catch (Exception) { throw; }
      }
      #endregion
   }
}
