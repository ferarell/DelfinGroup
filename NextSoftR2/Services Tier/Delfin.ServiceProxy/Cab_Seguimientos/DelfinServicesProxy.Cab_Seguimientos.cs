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
      public IBLCab_Seguimientos BL_Cab_Seguimientos { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCab_Seguimientos(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Seguimientos.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Seguimientos> GetAllCab_SeguimientosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Seguimientos.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Seguimientos> GetAllCab_Seguimientos()
      {
         try
         {
            return BL_Cab_Seguimientos.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Cab_Seguimientos GetOneCab_Seguimientos(Int32 CSEG_Codigo)
      {
         try
         {
            return BL_Cab_Seguimientos.GetOne(CSEG_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCab_Seguimientos(ref Cab_Seguimientos Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Seguimientos.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
