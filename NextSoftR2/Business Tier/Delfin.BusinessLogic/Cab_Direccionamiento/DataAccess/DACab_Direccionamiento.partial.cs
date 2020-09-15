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
	public partial class BLCab_Direccionamiento
	{
		#region [ Consultas ]
      public DataTable SelectForward(String Buque, String Viaje)
      {
         DataSet _ds = new DataSet();
         DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CDIRSS_CargaForward");
         DataAccessEnterpriseSQL.DAAgregarParametro("@Buque", Buque, SqlDbType.VarChar, 30, ParameterDirection.Input);
         DataAccessEnterpriseSQL.DAAgregarParametro("@Viaje", Viaje, SqlDbType.VarChar, 30, ParameterDirection.Input);
         _ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
         if (_ds != null && _ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
         {
            return _ds.Tables[0];
         }
         return null;
      }
		#endregion

		#region [ Metodos ]
      private bool UpdateDepTemporal(Int32 CDIR_Codigo, Int32 ENTC_CodTemporal, String AUDI_UsrMod)
      {
         try
         {
            DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CDIRSU_ActualizaDepTemporal");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCDIR_Codigo", CDIR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodTemporal", ENTC_CodTemporal, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);

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
