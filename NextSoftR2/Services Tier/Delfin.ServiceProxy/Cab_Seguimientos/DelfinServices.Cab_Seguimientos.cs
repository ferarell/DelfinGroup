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
      #region [ Cab_Seguimientos ]
      [Dependency]
      public IBLCab_Seguimientos BL_Cab_Seguimientos { get; set; }

      public Boolean SaveCab_Seguimientos(ref Cab_Seguimientos Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Seguimientos.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Cab_Seguimientos GetOneCab_Seguimientos(Int32 CSEG_Codigo)
      {
         try
         {
            return BL_Cab_Seguimientos.GetOne(CSEG_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      public ObservableCollection<Cab_Seguimientos> GetAllByCabSeguimientoByFiltros(DateTime x_CSEG_FechaEmisionIni, DateTime x_CSEG_FechaEmisionFin, String x_Nave)
      {
          try
          {
              return BL_Cab_Seguimientos.GetAllByCabSeguimientoByFiltros(x_CSEG_FechaEmisionIni, x_CSEG_FechaEmisionFin, x_Nave);
          }
          catch (Exception ex)
          { throw ex; }
      }
      #endregion
   }
}
