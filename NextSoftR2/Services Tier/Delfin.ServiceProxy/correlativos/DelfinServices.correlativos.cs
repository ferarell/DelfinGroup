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
      #region [ correlativos ]
      [Dependency]
      public IBLcorrelativos BL_correlativos { get; set; }

      public Boolean Savecorrelativos(correlativos Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_correlativos.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public correlativos GetOnecorrelativos(String CORR_ServerName, String CORR_CodCorr)
      {
         try
         {
            return BL_correlativos.GetOne(CORR_ServerName, CORR_CodCorr);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<correlativos> GetAllcorrelativos()
      {
         try
         {
            return BL_correlativos.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
