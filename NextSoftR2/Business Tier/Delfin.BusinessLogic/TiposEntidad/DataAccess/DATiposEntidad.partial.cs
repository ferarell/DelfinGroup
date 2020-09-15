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
	public partial class BLTiposEntidad
	{
		#region [ Consultas ]

      private ObservableCollection<TiposEntidad> SelectTodos()
      {
         try
         {
            ObservableCollection<TiposEntidad> items = new ObservableCollection<TiposEntidad>();
            TiposEntidad item = new TiposEntidad();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TIPESS_Todos");
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new TiposEntidad();
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
