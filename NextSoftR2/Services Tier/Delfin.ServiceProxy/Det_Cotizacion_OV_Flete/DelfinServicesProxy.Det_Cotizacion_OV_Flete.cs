using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Activation;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Infrastructure.Aspect.DataAccess;
using Delfin.ServiceContracts;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.ServiceProxy
{

   public partial class DelfinServices : IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLDet_Cotizacion_OV_Flete BL_Det_Cotizacion_OV_Flete { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDet_Cotizacion_OV_Flete(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Flete.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_Flete> GetAllDet_Cotizacion_OV_FleteFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Flete.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Det_Cotizacion_OV_Flete> GetAllDet_Cotizacion_OV_Flete()
      {
         try
         {
            return BL_Det_Cotizacion_OV_Flete.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Det_Cotizacion_OV_Flete GetOneDet_Cotizacion_OV_Flete(Int32 CCOT_Numero, Int32 DCOT_Item, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Det_Cotizacion_OV_Flete.GetOne(CCOT_Numero, DCOT_Item, CCOT_Tipo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDet_Cotizacion_OV_Flete(ref Det_Cotizacion_OV_Flete Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_Flete.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
