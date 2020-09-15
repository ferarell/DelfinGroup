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
      #region [ DetDocsVta ]
      [Dependency]
      public IBLDetDocsVta BL_DetDocsVta { get; set; }

      public Boolean SaveDetDocsVta(DetDocsVta Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetDocsVta.Save(Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DetDocsVta GetOneDetDocsVta(Int16 DDOV_Item, Int32 DOCV_Codigo)
      {
         try
         {
            return BL_DetDocsVta.GetOne(DDOV_Item, DOCV_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<DetDocsVta> GetAllDetDocsVta()
      {
         try
         {
            return BL_DetDocsVta.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
