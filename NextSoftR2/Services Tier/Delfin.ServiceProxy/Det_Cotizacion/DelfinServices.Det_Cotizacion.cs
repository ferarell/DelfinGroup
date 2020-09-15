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
      #region [ Det_Cotizacion ]
      [Dependency]
      public IBLDet_Cotizacion BL_Det_Cotizacion { get; set; }

      public Boolean SaveDet_Cotizacion( ref Det_Cotizacion Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Det_Cotizacion GetOneDet_Cotizacion(Int32 CCOT_Codigo, Int32 DCOT_Item)
      {
         try
         {
            return BL_Det_Cotizacion.GetOne(CCOT_Codigo, DCOT_Item);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Det_Cotizacion> GetAllDet_CotizacionByCotizacion(Int32 x_CCOT_Codigo,String x_CTAR_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion.GetAllByCotizacion(x_CCOT_Codigo, x_CTAR_Tipo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
