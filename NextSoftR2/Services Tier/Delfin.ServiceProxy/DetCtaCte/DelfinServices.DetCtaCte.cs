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

      [Dependency]
      public IBLDetCtaCte BL_DetCtaCte { get; set; }

      #region [ Consultas ]
      public System.Data.DataTable GetDTDetCtaCte(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetCtaCte.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetCtaCte> GetAllDetCtaCteFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetCtaCte.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetCtaCte> GetAllDetCtaCte()
      {
         try
         {
            return BL_DetCtaCte.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public DetCtaCte GetOneDetCtaCte(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Int16 DCCT_Item)
      {
         try
         {
            return BL_DetCtaCte.GetOne(EMPR_Codigo, CCCT_Codigo, DCCT_Item);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDetCtaCte(ref DetCtaCte Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetCtaCte.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
