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
      public IBLDepVacioEntidad BL_DepVacioEntidad { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDepVacioEntidad(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DepVacioEntidad.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DepVacioEntidad> GetAllDepVacioEntidadFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DepVacioEntidad.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DepVacioEntidad> GetAllDepVacioEntidad()
      {
         try
         {
            return BL_DepVacioEntidad.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public DepVacioEntidad GetOneDepVacioEntidad(Int32 DEVA_Codigo)
      {
         try
         {
            return BL_DepVacioEntidad.GetOne(DEVA_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDepVacioEntidad(ref DepVacioEntidad Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DepVacioEntidad.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
