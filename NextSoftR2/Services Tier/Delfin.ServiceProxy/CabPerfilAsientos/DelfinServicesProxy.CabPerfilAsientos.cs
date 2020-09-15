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
      public IBLCabPerfilAsientos BL_CabPerfilAsientos { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCabPerfilAsientos(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CabPerfilAsientos.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CabPerfilAsientos> GetAllCabPerfilAsientosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CabPerfilAsientos.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CabPerfilAsientos> GetAllCabPerfilAsientos()
      {
         try
         {
            return BL_CabPerfilAsientos.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public CabPerfilAsientos GetOneCabPerfilAsientos(String CABP_Ano, String CABP_Codigo)
      {
         try
         {
            return BL_CabPerfilAsientos.GetOne(CABP_Ano, CABP_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCabPerfilAsientos(ref CabPerfilAsientos Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_CabPerfilAsientos.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
