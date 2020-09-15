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
      public IBLCab_MBL BL_Cab_MBL { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCab_MBL(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_MBL.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_MBL> GetAllCab_MBLFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_MBL.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_MBL> GetAllCab_MBL()
      {
         try
         {
            return BL_Cab_MBL.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Cab_MBL GetOneCab_MBL(Int32 CMBL_codigo)
      {
         try
         {
            return BL_Cab_MBL.GetOne(CMBL_codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCab_MBL(ref Cab_MBL Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_MBL.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
