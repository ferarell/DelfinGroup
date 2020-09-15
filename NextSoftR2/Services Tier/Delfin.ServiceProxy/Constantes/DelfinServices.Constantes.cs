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
      #region [ Constantes ]
      [Dependency]
      public IBLConstantes BL_Constantes { get; set; }

      public Boolean SaveConstantes(Constantes Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Constantes.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Constantes GetOneConstantes(String CONS_CodTabla, String CONS_CodTipo)
      {
         try
         {
            return BL_Constantes.GetOne(CONS_CodTabla, CONS_CodTipo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Constantes> GetAllConstantes()
      {
         try
         {
            return BL_Constantes.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
