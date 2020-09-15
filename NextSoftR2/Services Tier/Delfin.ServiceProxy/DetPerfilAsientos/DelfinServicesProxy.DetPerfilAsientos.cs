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
      public IBLDetPerfilAsientos BL_DetPerfilAsientos { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTDetPerfilAsientos(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetPerfilAsientos.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetPerfilAsientos> GetAllDetPerfilAsientosFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_DetPerfilAsientos.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<DetPerfilAsientos> GetAllDetPerfilAsientos()
      {
         try
         {
            return BL_DetPerfilAsientos.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public DetPerfilAsientos GetOneDetPerfilAsientos(String CABP_Ano, String CABP_Codigo, Int16 DETP_Item)
      {
         try
         {
            return BL_DetPerfilAsientos.GetOne(CABP_Ano, CABP_Codigo, DETP_Item);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveDetPerfilAsientos(ref DetPerfilAsientos Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_DetPerfilAsientos.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
