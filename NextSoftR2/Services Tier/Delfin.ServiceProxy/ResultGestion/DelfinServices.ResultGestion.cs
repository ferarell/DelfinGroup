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
      #region [ ResultGestion ]
      [Dependency]
      public IBLResultGestion BL_ResultGestion { get; set; }

      public Boolean SaveResultGestion(ResultGestion Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_ResultGestion.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ResultGestion GetOneResultGestion(Int16 RESG_Codigo)
      {
         try
         {
            return BL_ResultGestion.GetOne(RESG_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<ResultGestion> GetAllResultGestion()
      {
         try
         {
            return BL_ResultGestion.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
