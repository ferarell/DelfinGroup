using Delfin.BusinessLogic;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delfin.ServiceProxy
{
   public partial class DelfinServicesProxy: Delfin.ServiceContracts.IDelfinServices
   {
      #region [ Propiedades ]
      [Dependency]
      public IBLAuditoria BL_Auditoria { get; set; }
      #endregion

      public System.Data.DataTable GetAllAuditoriaByFilter(String x_procedure, System.Collections.ObjectModel.ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return BL_Auditoria.GetAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
   }
}
