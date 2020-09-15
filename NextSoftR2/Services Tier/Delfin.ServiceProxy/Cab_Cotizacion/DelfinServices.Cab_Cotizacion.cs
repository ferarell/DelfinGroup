using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;

namespace Delfin.ServiceProxy
{
   using Delfin.ServiceContracts;
   using Delfin.BusinessLogic;
   using Delfin.Entities;

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Cab_Cotizacion ]
      [Dependency]
      public IBLCab_Cotizacion BL_Cab_Cotizacion { get; set; }

      public Boolean SaveCab_Cotizacion(ref Cab_Cotizacion Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Cotizacion.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Cab_Cotizacion GetOneCab_Cotizacion(Int32 CCOT_Codigo)
      {
         try
         {
            return BL_Cab_Cotizacion.GetOne(CCOT_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Cab_Cotizacion> GetAllByFiltrosCab_Cotizacion(Int32? x_ENTC_Codigo, String x_CCOT_NumDoc, DateTime x_CCOT_FecEmiIni, DateTime x_CCOT_FecEmiFin)
      {
         try
         {
             return BL_Cab_Cotizacion.GetAllByFiltros(x_ENTC_Codigo, x_CCOT_NumDoc, x_CCOT_FecEmiIni, x_CCOT_FecEmiFin);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
