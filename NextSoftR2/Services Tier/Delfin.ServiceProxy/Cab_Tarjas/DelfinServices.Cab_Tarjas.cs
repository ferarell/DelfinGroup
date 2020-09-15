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
      #region [ Cab_Tarjas ]
      [Dependency]
      public IBLCab_Tarjas BL_Cab_Tarjas { get; set; }

      public Boolean SaveCab_Tarjas(ref Cab_Tarjas Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Tarjas.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Cab_Tarjas GetOneCab_Tarjas(Int32 TARJ_Codigo)
      {
         try
         {
            return BL_Cab_Tarjas.GetOne(TARJ_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Cab_Tarjas> GetAllCab_Tarjas()
      {
         try
         {
            return BL_Cab_Tarjas.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
