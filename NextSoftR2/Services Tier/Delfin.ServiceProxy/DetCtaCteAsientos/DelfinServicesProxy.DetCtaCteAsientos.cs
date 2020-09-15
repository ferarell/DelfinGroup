using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;
using Delfin.ServiceContracts;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.ServiceProxy
{

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLDetCtaCteAsientos BL_DetCtaCteAsientos { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDetCtaCteAsientos(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetCtaCteAsientos.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetCtaCteAsientos> GetAllDetCtaCteAsientosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetCtaCteAsientos.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetCtaCteAsientos> GetAllDetCtaCteAsientos()
      {
         try
         {
            return BL_DetCtaCteAsientos.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public DetCtaCteAsientos GetOneDetCtaCteAsientos(Int16 EMPR_Codigo, Int32 CCCT_Codigo, Int16 DCCA_Item)
      {
         try
         {
            return BL_DetCtaCteAsientos.GetOne(EMPR_Codigo, CCCT_Codigo, DCCA_Item);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDetCtaCteAsientos(ref DetCtaCteAsientos Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetCtaCteAsientos.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
