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
      public IBLCab_Tarifa BL_Cab_Tarifa { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCab_Tarifa(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Tarifa.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Tarifa> GetAllCab_TarifaFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Cab_Tarifa.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<Cab_Tarifa> GetAllCab_Tarifa()
      {
         try
         {
            return BL_Cab_Tarifa.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public Cab_Tarifa GetOneCab_Tarifa(String CTAR_Tipo, Int32 CTAR_Codigo)
      {
         try
         {
            return BL_Cab_Tarifa.GetOne(CTAR_Tipo, CTAR_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCab_Tarifa(ref Cab_Tarifa Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_Cab_Tarifa.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
