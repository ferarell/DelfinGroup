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
      #region [ Det_Cotizacion_OV_Documento ]
      [Dependency]
      public IBLDet_Cotizacion_OV_Documento BL_Det_Cotizacion_OV_Documento { get; set; }

      public Boolean SaveDet_Cotizacion_OV_Documento(Det_Cotizacion_OV_Documento Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_Documento.Save(ref Item);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Det_Cotizacion_OV_Documento GetOneDet_Cotizacion_OV_Documento(Int32 CCOT_Numero, Int32 DOOV_Codigo, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Documento.GetOne(CCOT_Numero, DOOV_Codigo, CCOT_Tipo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Det_Cotizacion_OV_Documento> GetAllDet_Cotizacion_OV_Documento()
      {
         try
         {
            return BL_Det_Cotizacion_OV_Documento.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
