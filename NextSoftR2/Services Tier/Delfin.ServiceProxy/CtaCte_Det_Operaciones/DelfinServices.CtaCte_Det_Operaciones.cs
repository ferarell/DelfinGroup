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
      #region [ CtaCte_Det_Operaciones ]
      [Dependency]
      public IBLCtaCte_Det_Operaciones BL_CtaCte_Det_Operaciones { get; set; }

      public Boolean SaveCtaCte_Det_Operaciones(CtaCte_Det_Operaciones Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_CtaCte_Det_Operaciones.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public CtaCte_Det_Operaciones GetOneCtaCte_Det_Operaciones(Int32 DCTO_Codigo)
      {
         try
         {
            return BL_CtaCte_Det_Operaciones.GetOne(DCTO_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<CtaCte_Det_Operaciones> GetAllCtaCte_Det_Operaciones()
      {
         try
         {
            return BL_CtaCte_Det_Operaciones.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
