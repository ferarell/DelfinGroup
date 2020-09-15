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
	public partial class BLDet_Tarjas
	{
		#region [ Consultas ]
        public DataTable SelectAllServiciosDetTarjas(Int32 x_DOCV_Codigo, String x_TIPO_CodMND, Decimal x_TipoCambio)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTAJSS_TodosFacturaTarjas");
                if (x_DOCV_Codigo > 0)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", x_DOCV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input); 
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintDOCV_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", x_TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdcmTIPOCambio", x_TipoCambio, SqlDbType.Decimal, 10,4, ParameterDirection.Input);
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
        private bool UpdateDetTarjas(Int32 x_TARJ_Codigo, Int32 x_DTAJ_Item, Int16 x_PDDO_Item, Int32 x_DOCV_Codigo, String x_CONS_CodETJ)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTAJSS_UnRegPorPreFacturacion");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintTARJ_Codigo", x_TARJ_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintDTAJ_Item", x_DTAJ_Item, SqlDbType.Int, 4, ParameterDirection.Input);

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
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodETJ", x_CONS_CodETJ, SqlDbType.Char, 3, ParameterDirection.Input);

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
