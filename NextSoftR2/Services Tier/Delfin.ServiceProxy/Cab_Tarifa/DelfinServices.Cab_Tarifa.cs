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
      #region [ Cab_Tarifa ]
      [Dependency]
      public IBLCab_Tarifa BL_Cab_Tarifa { get; set; }

      public Boolean SaveCab_Tarifa( ref Cab_Tarifa Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Tarifa.Save( ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Cab_Tarifa GetOneCab_Tarifa(String CTAR_Tipo, Int32 CTAR_Codigo)
      {
         try
         {
            return BL_Cab_Tarifa.GetOne(CTAR_Tipo, CTAR_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Cab_Tarifa> GetAllCab_Tarifa()
      {
         try
         {
            return BL_Cab_Tarifa.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
