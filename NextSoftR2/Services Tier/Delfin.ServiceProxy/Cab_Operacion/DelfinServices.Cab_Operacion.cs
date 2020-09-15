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
      #region [ Cab_Operacion ]
      [Dependency]
      public IBLCab_Operacion BL_Cab_Operacion { get; set; }

      public Boolean SaveCab_Operacion( ref Cab_Operacion Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Operacion.Save( ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Cab_Operacion GetOneCab_Operacion(Int32 COPE_Codigo)
      {
         try
         {
            return BL_Cab_Operacion.GetOne(COPE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Cab_Operacion> GetAllOperacionByFiltros(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin, Int32 x_FacCliente, Int32 x_FacProveedor, Nullable<Int32> x_COPE_Codigo)
      {
          try
          {
              return BL_Cab_Operacion.GetAllByFiltros(x_ENTC_Codigo, x_COPE_NumDoc, x_COPE_FecEmiIni, x_COPE_FecEmiFin, x_FacCliente, x_FacProveedor, x_COPE_Codigo);
          }
          catch (Exception ex)
          { throw ex; }
      }
      #endregion
   }
}
