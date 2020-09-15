using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Infrastructure.Aspect.DataAccess;
using Infrastructure.Aspect.BusinessEntity;

using Delfin.Entities;

namespace Delfin.BusinessLogic
{
	public partial class BLServiciosRegimenVia
    {
		#region [ Consultas ]
        private ObservableCollection<ServiciosRegimenVia> SelectAllServiciosRegimenViaByServCodigo(Int32 SERV_Codigo)
        {
            try
            {
                ObservableCollection<ServiciosRegimenVia> items = new ObservableCollection<ServiciosRegimenVia>();
                ServiciosRegimenVia item = new ServiciosRegimenVia();
                DataAccessEnterpriseSQL.DAAsignarProcedure("SERVS_ServiciosRegimenViaPorServicio");
                DataAccessEnterpriseSQL.DAAgregarParametro("@pintSERV_Codigo", SERV_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
                
                using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new ServiciosRegimenVia();
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                        items.Add(item);
                    }
                }
                return items;
            }
            catch (Exception)
            { throw; }
        }
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
