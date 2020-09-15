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
	public partial class BLCab_Cotizacion
	{
		#region [ Consultas ]

      public DataTable ImprimirCotizacion(Int32 x_CCOT_Codigo)
      {
         try
         {
            DataSet _dt = new DataSet();
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CCOTSS_Impresion");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", x_CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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
        private bool AprobarAnular(Int32 x_CCOT_Codigo, String x_Estado, String x_AUDI_UsrMod)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CCOTSU_UnRegAprobarAnular");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Codigo", x_CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEstado", x_Estado, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", x_AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);
                if (DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
	}
}
