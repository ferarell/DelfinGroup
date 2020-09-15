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
      #region [ DepTemporalEntidad ]
      [Dependency]
      public IBLDepTemporalEntidad BL_DepTemporalEntidad { get; set; }

      public Boolean SaveDepTemporalEntidad(DepTemporalEntidad Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DepTemporalEntidad.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public DepTemporalEntidad GetOneDepTemporalEntidad(Int32 DETE_Codigo)
      {
         try
         {
            return BL_DepTemporalEntidad.GetOne(DETE_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<DepTemporalEntidad> GetAllDepTemporalEntidad(Int32? x_ENTC_Codigo)
      {
         try
         {
            return BL_DepTemporalEntidad.GetAll(x_ENTC_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
