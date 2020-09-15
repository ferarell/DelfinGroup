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
	public partial class BLDetRebate
	{
		#region [ Consultas ]
      private ObservableCollection<DetRebate> SelectAllByRebate(Int32 REBA_Codigo)
      {
         try
         {
            ObservableCollection<DetRebate> items = new ObservableCollection<DetRebate>();
            DetRebate item = new DetRebate();
            DataAccessEnterpriseSQL.DAAsignarProcedure("TCOM_SP_CONSULTAR_DetRebate");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pintREBA_Codigo", REBA_Codigo, SqlDbType.Int, 4, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new DetRebate();
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
