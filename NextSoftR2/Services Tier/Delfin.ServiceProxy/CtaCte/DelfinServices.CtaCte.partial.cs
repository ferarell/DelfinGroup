using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using Delfin.Entities;
using Delfin.BusinessLogic;

namespace Delfin.ServiceProxy
{
   using Delfin.ServiceContracts;
   using Delfin.BusinessLogic;
   using Delfin.Entities;

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Consultas ]

       public DataTable GetCtaCteFiltros(DateTime x_Desde, DateTime x_Hasta, Int32 x_ENTC_Codigo, Boolean x_FiltroFechas)
      {
         try
         {
            return BL_CtaCte.GetCtaCteFiltros(x_Desde, x_Hasta, x_ENTC_Codigo, x_FiltroFechas);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable GetCtaCteDetalles(Int32 x_COPE_Codigo)
      {
         try
         {
            return BL_CtaCte.GetCtaCteDetalles(x_COPE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public DataTable GetCtaCtePendientes(Int16 x_TIPE_Codigo, Int32 x_ENTC_Codigo)
      {
         try
         {
            return BL_CtaCte.GetCtaCtePendientes(x_TIPE_Codigo, x_ENTC_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public Boolean GetCtaCteDoc_Detraccion(String x_TipoDoc, String x_Serie, String x_NroDoc, Int32 x_CodProve)
      {
          try
          {
              return BL_CtaCte.GetBuscarDoc_Detraccion(x_TipoDoc, x_Serie, x_NroDoc, x_CodProve);
          }
          catch (Exception ex)
          { throw ex; }
      }
      public DataTable GetOneCtaCteDT(Int16 EMPR_Codigo, Int32 x_CCCT_Codigo)
      {
          try { return BL_CtaCte.GetOneCtaCteDT( EMPR_Codigo, x_CCCT_Codigo); }
          catch (Exception ex)
          { throw ex; }
      }
      #endregion

      #region [ Metodos ]

      public CtaCte GetOneCtaCte(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Entities.CtaCte.TInterfazCtaCte x_opcion)
      {
         try
         {
            return BL_CtaCte.GetOne(EMPR_Codigo, CCCT_Codigo, x_opcion);
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveCtaCte(ref CtaCte Item, Entities.CtaCte.TInterfazCtaCte x_opcion)
      {
         try
         {
            return BL_CtaCte.Save(ref Item, x_opcion);
         }
         catch (Exception)
         { throw; }
      }

      public String SaveCtaCteILD(ref CtaCte Item, String x_DOPE_Items)
      {
          String _NroVoucher = "";
          try
          {
              if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
              {
                  _NroVoucher = BL_CtaCte.SaveCCCTILD(ref Item, x_DOPE_Items);
              }
              return _NroVoucher;
          }
          catch (Exception)
          { throw; }
      }

      public String SaveCtaCteSLI(ref CtaCte Item, String x_DOPE_Items)
      {
          String _NroVoucher = "";
          try
          {
              if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
              {
                  _NroVoucher= BL_CtaCte.SaveCCCTSLI(ref Item, x_DOPE_Items);
              }
              return _NroVoucher;
          }
          catch (Exception)
          { throw; }
      }

      public Boolean SaveCtaCteGenerarAsientosByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters, ref String x_mensaje)
      {
         try
         {
            return BL_CtaCte.SaveGenerarAsientosByFilter(x_procedure, x_filters, ref x_mensaje);
         }
         catch (Exception)
         { throw; }
      }

      public Boolean SaveCtaCteDesvinculacion(Int16 x_EMPR_Codigo, Int32 x_CCCT_Codigo, Entities.CtaCte.TipoDesvinculacion x_opcion, Entities.CtaCte.TipoDesvAsiento x_destino, String x_usuario)
      {
         try
         {
            return BL_CtaCte.SaveDesvinculacion(x_EMPR_Codigo, x_CCCT_Codigo, x_opcion, x_destino, x_usuario);
         }
         catch (Exception)
         { throw; }
      }

      #endregion
   }
}
