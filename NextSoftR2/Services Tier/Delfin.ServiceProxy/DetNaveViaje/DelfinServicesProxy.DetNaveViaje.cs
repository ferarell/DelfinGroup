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

   public partial class DelfinServices : IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLDetNaveViaje BL_DetNaveViaje { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDetNaveViaje(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetNaveViaje.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetNaveViaje> GetAllDetNaveViajeFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetNaveViaje.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetNaveViaje> GetAllDetNaveViaje()
      {
         try
         {
            return BL_DetNaveViaje.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public DetNaveViaje GetOneDetNaveViaje(Int32 DVIA_Codigo, Int32 NVIA_Codigo)
      {
         try
         {
            return BL_DetNaveViaje.GetOne(DVIA_Codigo, NVIA_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDetNaveViaje(ref DetNaveViaje Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetNaveViaje.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
