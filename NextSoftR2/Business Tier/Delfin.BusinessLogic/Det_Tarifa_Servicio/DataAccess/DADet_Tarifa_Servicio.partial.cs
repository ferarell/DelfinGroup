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

namespace Delfin.BusinessLogic
{
	public partial class BLDet_Tarifa_Servicio
	{
		#region [ Consultas ]
        private ObservableCollection<Det_Tarifa_Servicio> SelectAllByTarifario(Int32 x_CTAR_Codigo, String x_CTAR_Tipo)
        {
            try
            {
                ObservableCollection<Det_Tarifa_Servicio> items = new ObservableCollection<Det_Tarifa_Servicio>();
                Det_Tarifa_Servicio item = new Det_Tarifa_Servicio();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTASSS_TodosByTarifa");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintCTAR_Codigo", x_CTAR_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCTAR_Tipo", x_CTAR_Tipo, SqlDbType.Char, 1, ParameterDirection.Input);
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Det_Tarifa_Servicio();
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
        private ObservableCollection<Det_Tarifa_Servicio> SelectAllServiciosTarifaByCotizacion(Int32? x_CTAR_CodigoLogistico, Int32? x_CTAR_CodigoAduanero)
        {
            try
            {
                ObservableCollection<Det_Tarifa_Servicio> items = new ObservableCollection<Det_Tarifa_Servicio>();
                Det_Tarifa_Servicio item = new Det_Tarifa_Servicio();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SLI_DTASSS_TodosByCotizacion");
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
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Det_Tarifa_Servicio();
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
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
