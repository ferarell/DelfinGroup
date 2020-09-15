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
      #region [ Det_Cotizacion_OV_Novedad ]
      [Dependency]
      public IBLDet_Cotizacion_OV_Novedad BL_Det_Cotizacion_OV_Novedad { get; set; }

      public Boolean SaveDet_Cotizacion_OV_Novedad(Det_Cotizacion_OV_Novedad Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_Novedad.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Det_Cotizacion_OV_Novedad GetOneDet_Cotizacion_OV_Novedad(Int32 OVNO_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Novedad.GetOne(OVNO_Codigo, CCOT_Numero, CCOT_Tipo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Det_Cotizacion_OV_Novedad> GetAllDet_Cotizacion_OV_Novedad()
      {
         try
         {
            return BL_Det_Cotizacion_OV_Novedad.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
