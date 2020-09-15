using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delfin.BusinessLogic
{
   public interface IBLAuditoria
   {
      System.Data.DataTable GetAllByFilter(String x_procedure, System.Collections.ObjectModel.ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters);
   }
}
