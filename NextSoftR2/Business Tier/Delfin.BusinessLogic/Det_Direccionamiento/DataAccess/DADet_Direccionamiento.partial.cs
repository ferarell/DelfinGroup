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
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Direccionamiento
	{
		#region [ Consultas ]
      public DataTable SelectDetalleForward(Int32 _Operacion)
      {
         DataSet _ds = new DataSet();
         DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DDIRSS_DetalleForward");
         DataAccessEnterpriseSQL.DAAgregarParametro("@Operacion", _Operacion, SqlDbType.Int, 4, ParameterDirection.Input);
         _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
         if (_ds != null && _ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
         {
            return _ds.Tables[0];
         }
         return null;
      }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
