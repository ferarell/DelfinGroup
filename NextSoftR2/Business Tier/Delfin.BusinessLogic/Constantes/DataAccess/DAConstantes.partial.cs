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
	public partial class BLConstantes
	{
		#region [ Consultas ]
      private ObservableCollection<Constantes> SelectAllByConstantesTabla(String CONS_CodTabla)
      {
         try
         {
            ObservableCollection<Constantes> items = new ObservableCollection<Constantes>();
            Constantes item = new Constantes();
            DataAccessEnterpriseSQL.DAAsignarProcedure("T_SP_CONSULTAR_Constantes");
            DataAccessEnterpriseSQL.DAAgregarParametro("@pchrCONS_CodTabla", CONS_CodTabla, SqlDbType.Char, 3, ParameterDirection.Input);
            using (IDataReader reader = DataAccessEnterpriseSQL.DAExecuteReader())
            {
               while (reader.Read())
               {
                  item = new Constantes();
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
