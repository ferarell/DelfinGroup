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
using Infrastructure.Aspect.BusinessEntity;
using System.Data;
namespace Delfin.BusinessLogic
{
	public partial class BLCab_Tarifa
	{
		#region [ Consultas ]
        private ObservableCollection<Cab_Tarifa> SelectAllByFiltros(Int32? LineaNaviera, Int32? AgMaritimo, Int32? DepTemporal ,
        Int32? DepVacio, Int32? AgAduana, Int32? Transporte, DateTime FecEmiDesde, DateTime FecEmiHasta, String TipoTarifa)
        {
            try
            {
                ObservableCollection<Cab_Tarifa> items = new ObservableCollection<Cab_Tarifa>();
                Cab_Tarifa item = new Cab_Tarifa();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CTARSS_TodosByFiltros");
                if (LineaNaviera!= null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoLN", LineaNaviera, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoLN", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (AgMaritimo != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoAM", AgMaritimo, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoAM", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (DepTemporal!= null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoDT", DepTemporal, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoDT", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (DepVacio != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoDV", DepVacio, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoDV", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (AgAduana != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoAA", AgAduana, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoAA", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (Transporte != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoLT", Transporte, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CodigoLT", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCTAR_FecIni", FecEmiDesde, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCTAR_FecFin", FecEmiHasta, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTipoTarifa", TipoTarifa, SqlDbType.Char, 1, ParameterDirection.Input);
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Cab_Tarifa();
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

        public DataTable SelectAllAyudaTarifa(String x_NroTarifa, String x_DescripTarifa, String x_CTAR_Tipo, Int32 x_CTAR_Codigo)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CTARSS_TodosAyuda");
                if (!String.IsNullOrEmpty(x_NroTarifa))
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCTAR_Numero", x_NroTarifa, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCTAR_Numero", DBNull.Value, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                if (!String.IsNullOrEmpty(x_DescripTarifa))
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCTAR_Descrip", x_DescripTarifa, SqlDbType.VarChar, 50, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCTAR_Descrip", DBNull.Value, SqlDbType.VarChar, 50, ParameterDirection.Input);
                }
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", x_CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_Codigo", x_CTAR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);

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
        private bool ValidarCopia(DateTime x_CTAR_FecIni, DateTime x_CTAR_FecFin, String x_CONS_CodReg, String x_TIPO_CodMnd, Int32 x_ENTC_CodigoLineaNaviera)
        {
            try
            {
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_CTARSI_ValidarCopia");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCTAR_FecIni", x_CTAR_FecIni, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pdtmCTAR_FecFin", x_CTAR_FecFin, SqlDbType.DateTime, 8, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrTIPO_CodMnd", x_TIPO_CodMnd, SqlDbType.Char, 3, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_Codigo", x_ENTC_CodigoLineaNaviera, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodReg", x_CONS_CodReg, SqlDbType.Char, 3, ParameterDirection.Input);
                DataSet _dt = new DataSet();
                _dt = DataAccessEnterpriseSQL.DAExecuteDataSet();
                if (_dt != null && _dt.Tables.Count > 0 && _dt.Tables[0].Rows.Count > 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
		#endregion
	}
}
