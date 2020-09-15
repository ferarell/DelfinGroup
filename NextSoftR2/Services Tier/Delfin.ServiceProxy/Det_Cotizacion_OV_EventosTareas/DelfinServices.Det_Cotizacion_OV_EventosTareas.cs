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
      #region [ Det_Cotizacion_OV_EventosTareas ]
      [Dependency]
      public IBLDet_Cotizacion_OV_EventosTareas BL_Det_Cotizacion_OV_EventosTareas { get; set; }

      public Boolean SaveDet_Cotizacion_OV_EventosTareas(Det_Cotizacion_OV_EventosTareas Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Det_Cotizacion_OV_EventosTareas.Save(ref Item, true);
            }
            return true;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Boolean SaveDet_Cotizacion_OV_EventosTareas(ObservableCollection<Det_Cotizacion_OV_EventosTareas> Items)
      {
          try
          {             
                  return BL_Det_Cotizacion_OV_EventosTareas.Save(ref Items);
          }
          catch (Exception ex)
          { throw ex; }
      }

      public Det_Cotizacion_OV_EventosTareas GetOneDet_Cotizacion_OV_EventosTareas(Int32 CCOT_Numero, Int16 CCOT_Tipo, Int16 EVEN_Item)
      {
         try
         {
            return BL_Det_Cotizacion_OV_EventosTareas.GetOne(CCOT_Numero, CCOT_Tipo, EVEN_Item);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Det_Cotizacion_OV_EventosTareas> GetAllDet_Cotizacion_OV_EventosTareas()
      {
         try
         {
            return BL_Det_Cotizacion_OV_EventosTareas.GetAll();
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
