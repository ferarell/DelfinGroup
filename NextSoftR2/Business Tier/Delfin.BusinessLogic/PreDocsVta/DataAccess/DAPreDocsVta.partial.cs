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
	public partial class BLPreDocsVta
	{
		#region [ Consultas ]
      public DataTable SelectAllServiciosPreFactura(Int32 x_COPE_Codigo, String x_TIPO_CodMND, Decimal x_TIPO_Cambio)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DOPESS_TodosByOperacionPreFactura");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCOPE_Codigo", x_COPE_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMND", x_TIPO_CodMND, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdcmTIPO_Cambio", x_TIPO_Cambio, SqlDbType.Decimal, 6,4, ParameterDirection.Input);
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
        public DataTable SelectOneSerieFactura(String x_CORR_ServerName, String x_CORR_CodCorr)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CORRSS_OneByCORR_CodCorr");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_ServerName", x_CORR_ServerName, SqlDbType.VarChar, 20, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCORR_CodCorr", x_CORR_CodCorr, SqlDbType.VarChar, 20, ParameterDirection.Input);
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
        public bool AnularPreDocsVta(ref PreDocsVta item,String TipoPrefactura)
        {
            try
            {
                if (item.Instance == Infrastructure.Aspect.BusinessEntity.InstanceEntity.Modified)
                {
                    if (!String.IsNullOrEmpty(TipoPrefactura))
                    {
                        if (TipoPrefactura.Equals("OPERACION")) // Operacion
                        {
                            DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDOCSU_UnRegAnulacion");
                            DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", item.PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodANU", item.CONS_CodANU, SqlDbType.Char, 3, ParameterDirection.Input);
                            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_TabANU", item.CONS_TabANU, SqlDbType.Char, 3, ParameterDirection.Input);
                            DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);  
                        }
                        else  // Tarjas
                        {
                           DataAccessEnterpriseSQL.DAAsignarProcedure("VEN_PDOCSU_UnRegTarjasAnulacion");
                           DataAccessEnterpriseSQL.DAAgregarParametro("@pintPDOC_Codigo", item.PDOC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input); 
                           DataAccessEnterpriseSQL.DAAgregarParametro("@pvchAUDI_UsrMod", item.AUDI_UsrMod, SqlDbType.VarChar, 20, ParameterDirection.Input);  
                        }
                        return DataAccessEnterpriseSQL.DAExecuteNonQuery() > 0;
                    }
                    { return false; }
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
	}
}
