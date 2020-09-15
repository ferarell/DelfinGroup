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
		#region [ Consultas ]
      public Boolean GetComisionValidar(Int32 COMI_Codigo, DateTime COMI_FecIni, DateTime COMI_FecFin)
      {
         try
         {
            return BL_Comision.GetValidar(COMI_Codigo, COMI_FecIni, COMI_FecFin);
         }
         catch (Exception)
         { throw; }
      }
		#endregion

		#region [ Metodos ]
      public Boolean SaveComisionesOV(ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters) //(Int32 NVIA_Codigo, String Usuario)
      {
         try
         {
            return BL_Comision.SaveComisiones(x_filters); //(NVIA_Codigo, Usuario);
         }
         catch (Exception)
         { throw; }
      }
		#endregion
   }
}
