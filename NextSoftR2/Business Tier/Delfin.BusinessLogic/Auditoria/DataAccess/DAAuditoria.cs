using Infrastructure.Aspect.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;

namespace Delfin.BusinessLogic
{
   public partial class BLAuditoria
   {
      #region [ Consultas ]
      private System.Data.DataTable SelectAllByFilter(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            System.Data.DataSet dsAuditoria;
            System.Data.DataTable dtAuditoria;

            DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure);
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }

            dsAuditoria = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (dsAuditoria != null && dsAuditoria.Tables.Count > 0)
            {
               dtAuditoria = dsAuditoria.Tables[0];
               if (dtAuditoria != null && dtAuditoria.Rows.Count > 0)
               { return dtAuditoria; }
               else
               { return null; }
            }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
      #endregion
   }
}
