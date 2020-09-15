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
      #region [ Det_Cotizacion_OV_Flete ]
      [Dependency]
      public IBLDet_Cotizacion_OV_Flete BL_Det_Cotizacion_OV_Flete { get; set; }

      public Boolean SaveDet_Cotizacion_OV_Flete(Det_Cotizacion_OV_Flete Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_Flete.Save(ref Item, true);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Det_Cotizacion_OV_Flete GetOneDet_Cotizacion_OV_Flete(Int32 CCOT_Numero, Int32 DCOT_Item, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Flete.GetOne(CCOT_Numero, DCOT_Item, CCOT_Tipo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Det_Cotizacion_OV_Flete> GetAllDet_Cotizacion_OV_Flete()
      {
         try
         {
            return BL_Det_Cotizacion_OV_Flete.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
