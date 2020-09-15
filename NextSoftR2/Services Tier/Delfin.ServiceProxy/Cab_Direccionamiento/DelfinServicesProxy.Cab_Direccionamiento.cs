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
      public IBLCab_Direccionamiento BL_Cab_Direccionamiento { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCab_Direccionamiento(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Direccionamiento.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Direccionamiento> GetAllCab_DireccionamientoFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Direccionamiento.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Direccionamiento> GetAllCab_Direccionamiento()
      {
         try
         {
            return BL_Cab_Direccionamiento.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Cab_Direccionamiento GetOneCab_Direccionamiento(Int32 CDIR_Codigo)
      {
         try
         {
            return BL_Cab_Direccionamiento.GetOne(CDIR_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCab_Direccionamiento(ref Cab_Direccionamiento Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Direccionamiento.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
