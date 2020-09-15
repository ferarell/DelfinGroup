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
      #region [ Cab_Cotizacion_OV ]
      [Dependency]
      public IBLCab_Cotizacion_OV BL_Cab_Cotizacion_OV { get; set; }

      public Cab_Cotizacion_OV SaveCab_Cotizacion_OV(Cab_Cotizacion_OV Item, ref String CCOT_MensajeError)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            { return BL_Cab_Cotizacion_OV.Save(ref Item, ref CCOT_MensajeError); }
            return Item;
         }
         catch (Exception ex)
         { throw ex; }
      }

      public Cab_Cotizacion_OV SaveCab_Cotizacion_OV(Cab_Cotizacion_OV Item, ref String CCOT_MensajeError, Cab_Cotizacion_OV.TipoInterfaz x_opcion)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.Save(ref Item, ref CCOT_MensajeError, x_opcion);
         }
         catch (Exception)
         { throw; }
      }

      public Cab_Cotizacion_OV GetOneCab_Cotizacion_OV(Int16 EMPR_Codigo, Int16 SUCR_Codigo, Int32 CCOT_Numero, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.GetOne(EMPR_Codigo, SUCR_Codigo, CCOT_Numero, CCOT_Tipo);
         }
         catch (Exception ex)
         { throw ex; }
      }

      public ObservableCollection<Cab_Cotizacion_OV> GetAllCab_Cotizacion_OV(Int16 EMPR_Codigo, Int16 SUCR_Codigo)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.GetAll(EMPR_Codigo, SUCR_Codigo);
         }
         catch (Exception ex)
         { throw ex; }
      }
      #endregion
   }
}
