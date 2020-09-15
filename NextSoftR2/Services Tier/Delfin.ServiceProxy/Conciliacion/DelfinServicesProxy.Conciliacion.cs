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
      public IBLConciliacion BL_Conciliacion { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTConciliacion(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Conciliacion.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Conciliacion> GetAllConciliacionFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Conciliacion.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Conciliacion> GetAllConciliacion()
      {
         try
         {
            return BL_Conciliacion.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Conciliacion GetOneConciliacion(Int16 EMPR_Codigo, Int32 MOVI_Codigo, Int32 CONC_Codigo)
      {
         try
         {
            return BL_Conciliacion.GetOne(EMPR_Codigo, MOVI_Codigo, CONC_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveConciliacion(ref Conciliacion Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Conciliacion.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
