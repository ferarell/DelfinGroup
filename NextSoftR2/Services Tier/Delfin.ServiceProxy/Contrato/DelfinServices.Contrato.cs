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
      #region [ Contrato ]
      [Dependency]
      public IBLContrato BL_Contrato { get; set; }

      public Int32 SaveContrato(Contrato Item, Boolean Tarifario)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Contrato.Save(ref Item, Tarifario);
            }
            else
            {
               if (Item.CONT_Codigo.HasValue)
               { return Item.CONT_Codigo.Value; }
               else
               { return -1; }
               
            }
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Contrato GetOneContrato(Int16 EMPR_Codigo, Int32 CONT_Codigo)
      {
         try
         {
            return BL_Contrato.GetOne(EMPR_Codigo, CONT_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Contrato> GetAllContrato(Int16 EMPR_Codigo)
      {
         try
         {
            return BL_Contrato.GetAll(EMPR_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
