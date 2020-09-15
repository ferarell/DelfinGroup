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
      public IBLDepTemporalEntidad BL_DepTemporalEntidad { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDepTemporalEntidad(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DepTemporalEntidad.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DepTemporalEntidad> GetAllDepTemporalEntidadFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DepTemporalEntidad.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DepTemporalEntidad> GetAllDepTemporalEntidad()
      {
         try
         {
            return BL_DepTemporalEntidad.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public DepTemporalEntidad GetOneDepTemporalEntidad(Int32 DETE_Codigo)
      {
         try
         {
            return BL_DepTemporalEntidad.GetOne(DETE_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDepTemporalEntidad(ref DepTemporalEntidad Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DepTemporalEntidad.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
