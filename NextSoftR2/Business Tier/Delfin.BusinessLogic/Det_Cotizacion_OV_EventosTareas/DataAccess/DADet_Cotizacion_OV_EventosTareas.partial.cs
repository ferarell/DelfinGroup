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
	public partial class BLDet_Cotizacion_OV_EventosTareas
	{
		#region [ Consultas ]
      private ObservableCollection<Det_Cotizacion_OV_EventosTareas> SelectAllByCotizacion_OV(Int32 CCOT_Numero, Int16 CCOT_Tipo)
		{
			try
			{
            ObservableCollection<Det_Cotizacion_OV_EventosTareas> items = new ObservableCollection<Det_Cotizacion_OV_EventosTareas>();
            Det_Cotizacion_OV_EventosTareas item = new Det_Cotizacion_OV_EventosTareas();
				DataAccessEnterpriseSQL.DAAsignarProcedure("COM_EVENSS_Todos");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintCCOT_Numero", CCOT_Numero, SqlDbType.Int, 4, ParameterDirection.Input);
            DataAccessEnterpriseSQL.DAAgregarParametro("@psinCCOT_Tipo", CCOT_Tipo, SqlDbType.SmallInt, 2, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
                  item = new Det_Cotizacion_OV_EventosTareas();
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
