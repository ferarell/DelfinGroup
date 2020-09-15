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
      public IBLCuentasBancarias BL_CuentasBancarias { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCuentasBancarias(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CuentasBancarias.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CuentasBancarias> GetAllCuentasBancariasFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CuentasBancarias.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CuentasBancarias> GetAllCuentasBancarias()
      {
         try
         {
            return BL_CuentasBancarias.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public CuentasBancarias GetOneCuentasBancarias(Int16 EMPR_Codigo, String CUBA_Codigo)
      {
         try
         {
            return BL_CuentasBancarias.GetOne(EMPR_Codigo, CUBA_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCuentasBancarias(ref CuentasBancarias Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_CuentasBancarias.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
