using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delfin.ServiceContracts
{
   public partial interface IDelfinServices
   {
      #region [ Consultas ]
      System.Data.DataTable GetAllAuditoriaByFilter(String x_procedure, System.Collections.ObjectModel.ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
      #endregion
   }
}
