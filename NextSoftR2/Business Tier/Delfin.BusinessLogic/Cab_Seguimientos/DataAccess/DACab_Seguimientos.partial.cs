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
	public partial class BLCab_Seguimientos
	{
		#region [ Consultas ]
      
      private DataTable EnviaCorreo()
		{
			try
			{
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CSEGSS_EnviaCorreo");
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
               return _dt.Tables[0];
            }
            return null;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
      public bool ExisteOperacion(Cab_Seguimientos item)
      {
          try
          {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CSEGSS_ExisteOperacion");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", item.COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
            if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            return false;
          }
          catch (Exception ex)
          { throw ex; }
      }
		#endregion
	}
}
