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
      #region [ Det_Cotizacion_OV_Archivo ]
      [Dependency]
      public IBLDet_Cotizacion_OV_Archivo BL_Det_Cotizacion_OV_Archivo { get; set; }

      public Boolean SaveDet_Cotizacion_OV_Archivo(Det_Cotizacion_OV_Archivo Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_Archivo.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Det_Cotizacion_OV_Archivo GetOneDet_Cotizacion_OV_Archivo(Int32 OVAR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Archivo.GetOne(OVAR_Codigo, CCOT_Numero, CCOT_Tipo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Det_Cotizacion_OV_Archivo> GetAllDet_Cotizacion_OV_Archivo()
      {
         try
         {
            return BL_Det_Cotizacion_OV_Archivo.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
