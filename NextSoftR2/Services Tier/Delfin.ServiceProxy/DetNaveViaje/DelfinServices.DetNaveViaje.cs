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
      #region [ DetNaveViaje ]
      [Dependency]
      public IBLDetNaveViaje BL_DetNaveViaje { get; set; }

      public Boolean SaveDetNaveViaje(DetNaveViaje Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetNaveViaje.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DetNaveViaje GetOneDetNaveViaje(Int32 DVIA_Codigo, Int32 NVIA_Codigo)
      {
         try
         {
            return BL_DetNaveViaje.GetOne(DVIA_Codigo, NVIA_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<DetNaveViaje> GetAllDetNaveViaje()
      {
         try
         {
            return BL_DetNaveViaje.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
