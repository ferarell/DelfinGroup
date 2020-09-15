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
      public IBLCab_Cotizacion_OV BL_Cab_Cotizacion_OV { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCab_Cotizacion_OV(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Cotizacion_OV> GetAllCab_Cotizacion_OVFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Cotizacion_OV> GetAllCab_Cotizacion_OV()
      {
         try
         {
            return BL_Cab_Cotizacion_OV.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Cab_Cotizacion_OV GetOneCab_Cotizacion_OV(Int32 CCOT_Numero, Int16 CCOT_Tipo)
      {
         try
         {
            return BL_Cab_Cotizacion_OV.GetOne(CCOT_Numero, CCOT_Tipo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCab_Cotizacion_OV(ref Cab_Cotizacion_OV Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Cotizacion_OV.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
