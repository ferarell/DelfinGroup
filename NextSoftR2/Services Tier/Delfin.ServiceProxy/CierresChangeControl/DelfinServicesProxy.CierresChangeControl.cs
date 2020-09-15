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

   public partial class DelfinServicesProxy : IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLCierresChangeControl BL_CierresChangeControl { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCierresChangeControl(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CierresChangeControl.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CierresChangeControl> GetAllCierresChangeControlFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CierresChangeControl.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CierresChangeControl> GetAllCierresChangeControl()
      {
         try
         {
            return BL_CierresChangeControl.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public CierresChangeControl GetOneCierresChangeControl(Int16 EMPR_Codigo, Int16 SUCR_Codigo, String CHAN_Anio, String CHAN_Mes)
      {
         try
         {
            return BL_CierresChangeControl.GetOne(EMPR_Codigo, SUCR_Codigo, CHAN_Anio, CHAN_Mes);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCierresChangeControl(ref CierresChangeControl Item, ref String MensajeError)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_CierresChangeControl.Save(ref Item, ref MensajeError);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
