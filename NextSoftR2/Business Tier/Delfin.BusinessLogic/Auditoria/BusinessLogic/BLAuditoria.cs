using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Delfin.BusinessLogic
{
   public partial class BLAuditoria : IBLAuditoria
   {
      #region [ Consultas ]
      public System.Data.DataTable GetAllByFilter(string x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            return SelectAllByFilter(x_procedure, x_filters);
         }
         catch (Exception)
         { throw; }
      }
      #endregion
      
   }
}
