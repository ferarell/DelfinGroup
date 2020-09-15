using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.BusinessLogic;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLNave
	{
		#region [ Consultas ]
      private System.Data.DataTable SelectAllByFilters(String x_procedure, ObservableCollection<Infrastructure.Aspect.DataAccess.DataAccessFilterSQL> x_filters)
      {
         try
         {
            DataSet _ds = new DataSet();
            if (!String.IsNullOrEmpty(x_procedure))
            { DataAccessEnterpriseSQL.DAAsignarProcedure(x_procedure); }
            else
            { DataAccessEnterpriseSQL.DAAsignarProcedure("COM_NAVESS_TodosByFilters"); }
            if (x_filters != null && x_filters.Count > 0)
            {
               foreach (Infrastructure.Aspect.DataAccess.DataAccessFilterSQL _itemFilter in x_filters)
               { DataAccessEnterpriseSQL.DAAgregarParametro(_itemFilter.FilterName, _itemFilter.FilterValue, _itemFilter.FilterSQLType, _itemFilter.FilterSize); }
            }
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 1)
            { _ds.Tables[0].TableName = "Nave"; return _ds.Tables[0]; }
            else
            { return null; }
         }
         catch (Exception)
         { throw; }
      }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
