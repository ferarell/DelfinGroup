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
      public IBLAgMaritimoEntidad BL_AgMaritimoEntidad { get; set; }
      #endregion

      #region [ Consultas ]
      public System.Data.DataTable GetDTAgMaritimoEntidad(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_AgMaritimoEntidad.GetDT(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<AgMaritimoEntidad> GetAllAgMaritimoEntidadFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_AgMaritimoEntidad.GetAllFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      public ObservableCollection<AgMaritimoEntidad> GetAllAgMaritimoEntidad()
      {
         try
         {
            return BL_AgMaritimoEntidad.GetAll();
         }
         catch (Exception)
         { throw; }
      }
      public AgMaritimoEntidad GetOneAgMaritimoEntidad(Int32 AGMA_Codigo)
      {
         try
         {
            return BL_AgMaritimoEntidad.GetOne(AGMA_Codigo);
         }
         catch (Exception)
         { throw; }
      }

      #endregion

      #region [ Metodos ]
      public Boolean SaveAgMaritimoEntidad(ref AgMaritimoEntidad Item)
      {
         try
         {
            if (Item.Instance != Infrastructure.Aspect.BusinessEntity.InstanceEntity.Unchanged)
            {
               return BL_AgMaritimoEntidad.Save(ref Item);
            }
            return true;
         }
         catch (Exception)
         { throw; }
      }
      #endregion



   }
}
