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
      public IBLCtaCte_Det_Operaciones BL_CtaCte_Det_Operaciones { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTCtaCte_Det_Operaciones(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CtaCte_Det_Operaciones.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CtaCte_Det_Operaciones> GetAllCtaCte_Det_OperacionesFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_CtaCte_Det_Operaciones.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<CtaCte_Det_Operaciones> GetAllCtaCte_Det_Operaciones()
      {
         try
         {
            return BL_CtaCte_Det_Operaciones.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public CtaCte_Det_Operaciones GetOneCtaCte_Det_Operaciones(Int32 DCTO_Codigo)
      {
         try
         {
            return BL_CtaCte_Det_Operaciones.GetOne(DCTO_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveCtaCte_Det_Operaciones(ref CtaCte_Det_Operaciones Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_CtaCte_Det_Operaciones.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
