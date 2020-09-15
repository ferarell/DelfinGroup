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
      public IBLCuentasBancariasUsuarios BL_CuentaBancosUsuarios { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCuentaBancosUsuarios(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CuentaBancosUsuarios.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CuentasBancariasUsuarios> GetAllCuentaBancosUsuariosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CuentaBancosUsuarios.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CuentasBancariasUsuarios> GetAllCuentaBancosUsuarios()
      {
         try
         {
            return BL_CuentaBancosUsuarios.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public CuentasBancariasUsuarios GetOneCuentaBancosUsuarios(Int16 EMPR_Codigo, String CUBA_Codigo, String USER_Codigo)
      {
         try
         {
            return BL_CuentaBancosUsuarios.GetOne(EMPR_Codigo, CUBA_Codigo, USER_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCuentaBancosUsuarios(ref CuentasBancariasUsuarios Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_CuentaBancosUsuarios.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
