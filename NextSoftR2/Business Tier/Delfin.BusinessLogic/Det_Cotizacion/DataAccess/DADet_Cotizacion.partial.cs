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
using Infrastructure.Aspect.BusinessEntity;
using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Cotizacion
	{
		#region [ Consultas ]
        private ObservableCollection<Det_Cotizacion> SelectAllDet_CotizacionByOperacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero, Int32? x_CTAR_CodigoTransporte)
        {
            try
            {
                ObservableCollection<Det_Cotizacion> items = new ObservableCollection<Det_Cotizacion>();
                Det_Cotizacion item = new Det_Cotizacion();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DCOTSS_TodosByOperacion");
                if (x_CTAR_CodigoLogistico != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_CodigoLogistico", x_CTAR_CodigoLogistico.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_CodigoLogistico", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (x_CTAR_CodigoAduanero != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_CodigoAduanero", x_CTAR_CodigoAduanero.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_CodigoAduanero", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                if (x_CTAR_CodigoTransporte != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_CodigoTransporte", x_CTAR_CodigoTransporte.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_CodigoTransporte", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Det_Cotizacion();
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
        public DataTable SelectAllAyudaCotizacion(Int32? x_ENTC_CodigoCliente, Int32? x_ENTC_CodigoLNaviera, String x_NroCotizacion, String x_CTAR_Tipo, Int32 x_CCOT_Codigo)
        {
            try
            {
                DataSet _dt = new DataSet();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DCOTSS_TodosAyuda");
                if (!String.IsNullOrEmpty(x_NroCotizacion))
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", x_NroCotizacion, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@pvchCCOT_NumDoc", DBNull.Value, SqlDbType.VarChar, 11, ParameterDirection.Input);
                }
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", x_CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);

                if (x_ENTC_CodigoCliente != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodigoCliente", x_ENTC_CodigoCliente, SqlDbType.Int, 4, ParameterDirection.Input); 
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodigoCliente", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input); 
                }
                if (x_ENTC_CodigoLNaviera != null)
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodigoLNaviera", x_ENTC_CodigoLNaviera, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                else
                {
                    DataAccessEnterpriseSQL.DAAgregarParametro("@ENTC_CodigoLNaviera", DBNull.Value, SqlDbType.Int, 4, ParameterDirection.Input);
                }
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintENTC_CCOT_Codigo", x_CCOT_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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

		#endregion
	}
}
