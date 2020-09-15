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
      #region [ DetRebate ]
      [Dependency]
      public IBLDetRebate BL_DetRebate { get; set; }

      public Boolean SaveDetRebate(DetRebate Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetRebate.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DetRebate GetOneDetRebate(Int32 DREB_Codigo)
      {
         try
         {
            return BL_DetRebate.GetOne(DREB_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<DetRebate> GetAllDetRebate()
      {
         try
         {
            return BL_DetRebate.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
