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
      public IBLDetMovimiento BL_DetMovimiento { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDetMovimiento(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetMovimiento.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetMovimiento> GetAllDetMovimientoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetMovimiento.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetMovimiento> GetAllDetMovimiento()
      {
         try
         {
            return BL_DetMovimiento.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public DetMovimiento GetOneDetMovimiento(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int16 DMOV_Item)
      {
         try
         {
            return BL_DetMovimiento.GetOne(EMPR_Codigo, MOVI_Codigo, DMOV_Item);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDetMovimiento(ref DetMovimiento Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetMovimiento.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
