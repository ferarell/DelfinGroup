using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLAnexos
	{
		#region [ Consultas ]
      private System.Data.DataTable SelectOnePrint(Int16 CCOT_Tipo, Int32 CCOT_Numero, Int16 ANEX_Item)
      {
         try
         {
            DataSet _ds = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("DOC_ANEXSS_UnRegPrint");
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinANEX_Item", ANEX_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
            _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_ds != null && _ds.Tables.Count == 1 && _ds.Tables[0].Rows.Count > 0)
            { _ds.Tables[0].TableName = "Anexos"; return _ds.Tables[0]; }
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
