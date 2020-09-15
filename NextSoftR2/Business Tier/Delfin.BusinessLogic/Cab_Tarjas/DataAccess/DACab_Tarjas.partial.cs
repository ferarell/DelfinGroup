using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infrastructure.Aspect.BusinessEntity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Infrastructure.Aspect.DataAccess;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLCab_Tarjas
	{
		#region [ Consultas ]
        private ObservableCollection<Cab_Tarjas> SelectAllPorFiltros(DateTime x_FecIni, DateTime x_FecFin)
        {
            try
            {
                ObservableCollection<Cab_Tarjas> items = new ObservableCollection<Cab_Tarjas>();
                Cab_Tarjas item = new Cab_Tarjas();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_TARJSS_TodosPorFiltros");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtFecIni", x_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtFecFin", x_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Cab_Tarjas();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataTable SelectAyudaTarjas()
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTAJSS_TodosAyuda");
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

        public DataSet SelectAllTarjasRebate(Int32? x_ENTC_Codigo, String x_COPE_NumDoc, String x_COPE_HBL, DateTime x_COPE_FecEmiIni, DateTime x_COPE_FecEmiFin)
        {
            try
            {
                DataSet Ds = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_COPESS_TarjasRebate");
                if (x_ENTC_Codigo != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (!String.IsNullOrEmpty(x_COPE_NumDoc))
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", x_COPE_NumDoc, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_NumDoc", DBNull.Value, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                if (!String.IsNullOrEmpty(x_COPE_NumDoc))
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_HBL", x_COPE_HBL, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCOPE_HBL", DBNull.Value, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiIni", x_COPE_FecEmiIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCOPE_FecEmiFin", x_COPE_FecEmiFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
                Ds = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (Ds != null && Ds.Tables.Count > 0)
                {
                    return Ds;
                }
                return null;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
