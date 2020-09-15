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
	public partial class BLDet_Operacion_Servicio
	{
		#region [ Consultas ]
        private DataSet SelectAllServiciosAdicionalesReporte(Int32? x_ENTC_Codigo, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin,String TipoReporteAdicional)
        {
            try
            {
                DataSet DS = new DataSet();
                if (!String.IsNullOrEmpty(TipoReporteAdicional))
                {
                    DataAccessEnterpriseSQL.DAAsignarProcedure(TipoReporteAdicional.Equals("Transporte") ? "SLI_SOPESS_TodosReporteServ_AdicionalesTransporte" : "SLI_SOPESS_TodosReporteServ_AdicionalesAduana");
                    if (x_ENTC_Codigo != null)
                    {
                        DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                    }
                    else
                    {
                        DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                    }
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiIni", x_COPE_FecEmiIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiFin", x_COPE_FecEmiFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
                    DS = DataAccessEnterpriseSQL.DAExecuteDataSet();
                    if (DS != null && DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                    {
                        return DS;
                    }
                }
                return null;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion

		#region [ Metodos ]
        private bool UpdateDetServicioOperacion(Int32 x_COPE_Codigo, Int32 x_SOPE_Item, Int16 x_PDDO_Item, Int32 x_DOCV_Codigo, String x_CONS_CodEST)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_SOPESU_UnRegPorPreFacturacion");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintSOPE_Item", x_SOPE_Item, SqlDbType.Int, 4, ParameterDirection.Input);
                if (x_PDDO_Item > 0)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", x_PDDO_Item, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@psinPDDO_Item", DBNull.Value, SqlDbType.SmallInt, 2, ParameterDirection.Input);
                }
                if (x_DOCV_Codigo > 0)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", x_DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }

                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodEST", x_CONS_CodEST, SqlDbType.Char, 3, ParameterDirection.Input);

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
