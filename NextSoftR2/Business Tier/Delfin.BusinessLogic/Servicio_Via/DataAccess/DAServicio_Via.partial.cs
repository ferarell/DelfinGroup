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
	public partial class BLServicio_Via
	{
		#region [ Consultas ]
      private ObservableCollection<Servicio_Via> SelectAllByServicio(Int32 SERV_Codigo)
		{
			try
			{
				ObservableCollection<Servicio_Via> items = new ObservableCollection<Servicio_Via>();
				Servicio_Via item = new Servicio_Via();
				DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_Servicio_Via");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Servicio_Via();
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
